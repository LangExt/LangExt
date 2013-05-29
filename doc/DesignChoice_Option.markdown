Optionの設計
============
Optionの意味を理解していることを前提に、直和型をC#で実現する方法についてを説明し、
LangExtではどういう方針を採用しているのかと、その理由について明らかにします。

バリアント型のC#での設計方針
----------------------------
Optionなどのバリアント型(VBのVariant型のことでは**ありません**)をC#で実現する場合、大まかに次の2つの方針があります。

* 型の階層で表現する
* タグを判別する値を持つようにする

一つ目の方法は、Option(もしくはMaybe)型の実現方法としてよく使われている方法です。

```
     +-----------+
     | Option[T] |
     +-----------+
           △
           ｜
     +-----＋-----+
     |            |
+---------+  +---------+
| Some[T] |  | None[T] |
+---------+  +---------+
| - value |
+---------+
```

二つ目の方法は、LangExtのOption型が採用している方法です。

```
     +------------+
     |  Option[T] |
     +------------+
     | - hasValue |
     | -   value  |
     +------------+
```

これらの特徴を、Option型を実現する場合を例に見ていきます。

### 型の階層で表現する方法
バリアント型を型の階層で表現する方法は、実際にはOption型をinterfaceとして定義することが多いようです。
この方法では、Option型に対する操作はポリモーフィズムによって実現され、分岐は型階層に隠蔽されます。

```cs
public interface IOption<out T>
{
    bool HasValue { get; }
    IOption<U> Map<U>(Func<T, U> f);
    IOption<U> Bind<U>(Func<T, IOption<U>> f);
    T GetOr(T defaultValue);
}

public sealed class Some<T> : IOption<T>
{
    readonly T value;
    public Some(T value) { this.value = value; }

    public bool HasValue { get { return true; } }
    public IOption<U> Map<U>(Func<T, U> f)
    {
        return new Some<U>(f(this.value));
    }
    public IOption<U> Bind<U>(Func<T, IOption<U>> f)
    {
        return f(this.value);
    }
    public T GetOr(T defaultValue) { return this.value; }
}

public sealed class None<T> : IOption<T>
{
    public bool HasValue { get { return false; } }
    public IOption<U> Map<U>(Func<T, U> f)
    {
        return new None<T>();
    }
    public IOption<U> Bind<U>(Func<T, IOption<U>> f)
    {
        return new None<T>();
    }
    public T GetOr(T defaultValue) { return defaultValue; }
}
```

実際には拡張メソッドで提供するメソッドについては、その中で分岐が発生しますが、
一番コアの部分は`if`による分岐を(それがいいことかどうかは置いておいて)完全に排除できます。

この方法は、オブジェクト指向プログラミング的な方法であり、
オブジェクト指向プログラマにとっては自然であり、美しい解決方法でしょう。

### タグを判別する値を持つ方法
Option型には`Some`と`None`という2つのラベルがあります。
これを判別するのに必要な情報は1bitでいいため、boolを使えば十分です。

```cs
public struct Option<T>
{
    readonly bool hasValue;
    readonly T value;
    public Option(T value)
    {
        this.hasValue = true;
        this.value = value;
    }

    public bool HasValue { get { return this.hasValue; } }
    public Option<U> Map<U>(Func<T, U> f)
    {
        if (this.hasValue)
            return new Option<U>();
        return new Option<U>(f(this.value));
    }
    public Option<U> Bind<U>(Func<T, U> f)
    {
        if (this.hasValue)
            return new Option<U>();
        return f(this.value);
    }
    public T GetOr(T defaultValue)
    {
        return this.hasValue ? this.value : defaultValue;
    }
}
```

バリアント型をタグを判別する値を持つことによって表現する方法は、先の方法に比べると泥臭い方法に見えます。
LangExtでは、この2つの方法のメリットとデメリットを考えたうえで、泥臭く思える後者の方法を採用しています。

### それぞれの利点と欠点
まずは、型の階層で表現する方法の利点を考えてみます。

1. `None`の場合に余分なフィールドを持つ必要がない
1. `Some`や`None`にも型を与えることになるため、「`Some`だけを受け取れるような関数」のように、柔軟な関数を定義可能
1. (Optionを`interface`とすることで)型パラメータに`out`が指定できる
1. 実装が綺麗に書ける

特に、1つ目はラベルが多くなればなるほど効果を感じることができる利点でしょう。

2つ目も、Optionではそれほどメリットを感じないかもしれませんが、
例えばファイルとディレクトリを扱う型階層を作った場合などは大きな利点になります。

3つ目は`out`を付けることのできないようなものも考えられますが、Option型の場合には付けることができます。
TがSを継承している場合に、Option[T]がOption[S]として使えるというのは、オブジェクト指向言語においては非常に魅力的です。

4つ目は、実際にミニマムな実装をしたコードを見ても、`if`が全く出てこないため、オブジェクト指向プログラミングとして綺麗なコードと言えるでしょう。

では、タグを判別する値を持つことによって実現する方法の利点はどうでしょう。

1. Option型の変数に対して`null`を入れることを防げている(`struct`のため)
1. 勝手に独自のラベルを作ることができない(型階層で実現する方法の場合、IOptionを実装することで可能)

の2つです。
後者は一概には利点/欠点と判断できるものではないですが、少なくともOption型には不要な機能であり、それができてしまうと色々面倒です。

また、前者の利点は絶大です。
Option型が達成したいのは、「**`null`の排除**」です。
にもかかわらず、型階層による実現方法では、「`IOption[T]`型の変数そのものに`null`を入れられてしまう」という可能性を排除できません。

これは、別に

```cs
IOption<string> opt = null;
```

という直接的なコードが書かれてしまう、ということではありません。
そうではなく、例えば`IOption[T]`を受け取るような関数に「とりあえず」`null`を渡しておいて、「後で」直そう、と思って忘れていたような、
「うっかり`null`」の方を心配しています。

LangExtの公開以前のかなり初期のバージョンでは、型階層によってOptionを実現していました。
しかし、この手のミスがそれなりに発生したため、設計方針を切り替えたという経緯があります。

もちろん、これを単体テストやDbCによって排除すべきだ、という立場もあるでしょう。
しかし、単体テストで見つけるよりもコンパイル時に見つけた方が発見のコスト(単体テストではテストコードを書いたり、実行したりが必要)も修正のコストも小さくなりますし、
そもそも考慮漏れを起こす心配がありません。

また、DbC(というかCode Contracts)で「この型の**変数**には`null`は格納できない」のような契約の書き方がわかりませんでした。
もしかすると方法はあるのかもしれないですが、LangExtではCode Contractsでどうこうする、という方向は諦めています。

### どちらを採用するか
これらの利点と欠点を考えたうえで、LangExtでは`null`を徹底的に排除するために、タグを判別する値を持つ方法を採用しました。
これにより、LangExtのOptionでは(変数にしろ、Optionの高階関数に渡された関数の引数にしろ)`null`が来ることは一切考慮する必要がないという安心感を獲得しています。

### Option以外のバリアント型
これまで考えてきたのは、あくまでOption型を実現する場合についてです。
そのため、Option以外のバリアント型もすべてOption型と同じように実装するかどうかは別問題です。

Option型に失敗時の原因も持たせることができるように拡張したResult型では、Option型と同じ方針を採用していますが、
Option型と違って`struct`にすることができませんので、今後のバージョンで型階層による実現方法に変更される可能性もあります。
ただし、あくまで実現方法のみの変更になるため、変更があった場合でもユーザコードは修正不要です。

Option型の値の生成
------------------
Option型の値を生成する方法としては、コンストラクタを呼び出すのが.NETプログラマとしては最もわかりやすいでしょう。
しかし、この方法では常に型パラメータを明示する必要があるため、面倒です。

```cs
public void F(Option<string> opt) { ... }

F(new Option<string>("hoge")); // Some "hoge"
F(new Option<string>());       // None
```

これを解決するために、ほとんどのライブラリのOptionと同様、staticメソッドを提供しています。

```cs
F(Option.Some("hoge"));
```

さらに、LangExtではこれに加えて、型引数なしで`None`を使うことができるようにしています。

```cs
F(Option.None);
```

`Option.None`は`Option[Placeholder]`型の`None`を生成するようになっており、
`Option[Placeholder]`型から任意の`T`型のOption型への暗黙型変換を提供することでこれを実現しています。

### それ以外の方法
それ以外の方法として、任意の`T`型から`Option[T]`への暗黙型変換を提供することも考えられます。
また、`null`を任意の`T`型のOption型の`None`に暗黙変換を提供するのも便利かもしれません。

LangExtでは、これらの変換を提供することも考えましたが、どちらも却下しました。

### 任意の`T`型から`Option[T]`型への暗黙の型変換を提供しない理由
これを提供しないのは、`null`の扱いにあります。

```cs
public Option<string> F(string str)
{
    return str;
}
```

さて、単純なコードではありますが、`str`には`null`が格納されている可能性があります。
その場合にこのコードは何を返すべきでしょうか？`Some null`でしょうか？それとも、`None`でしょうか？

これは暗黙の型変換の仕様さえ覚えてしまえばそれでいいのですが、
それを知らない人が「こっちだ」と思い込んでしまう可能性は捨てきれません。

そのため、LangExtではこの変換を提供していません[^somenull]。

```cs
public Option<string> F(string str)
{
    return Option.Some(str);
}
// もしstrがnullの場合にNoneが返したい場合は、明示的に書く
public Option<string> G(string str)
{
    if (str == null)
        return Option.None;
    return Option.Some(str);
}
```

[^somenull]: さらに、LangExtでは`Option.Some(null)`は例外を投げるようになっており、`null`を格納する`Some`は作ることができません。
    これによって、Optionの高階関数に渡す関数の引数に`null`が渡されることがないことも保証しています。
    もし`Some null`のようなことがしたいのであれば、Optionをネストするか、別の型を作るようにしてください。

### `null`を任意の`T`型のOption型の`None`に暗黙変換しない理由
これには、上の問題以上の問題があります。

例えば、当初は`Option[string]`を受け取っていた関数Fの仕様が変わり、`string`を受け取ることになったとした場合、
`null`を`None`に暗黙変換している個所はコンパイルエラーにならずに単に`null`を渡してしまうことになります。

```cs
// 暗黙の型変換を提供していれば、F(Option<string> opt)でもF(string str)でもコンパイルできてしまう
F(null);
```

実はこのような暗黙の型変換を公開前のLangExtは提供していたことがありました。
その当時はまだ`Option.None`とは書けず、`Option.None<string>()`のように書く必要があったこともあり、
手軽に書ける`null`からの変換を多用していました。
しかしというか、やはりというか、上のような問題がそれなりに発生し、
さらに`Option.None`という書き方ができるようになったため、`null`を`None`として扱う機能は削除しました。

クエリ式への対応
----------------
Option型をクエリ式に対応させる最も手軽な方法は、`IEnumerable[T]`を実装することでしょう。
そうすれば、`IEnumerable[T]`に対して定義された`Select`や`SelectMany`によって、Optionをクエリ式で扱えるようになります。

しかし、この方法では最終的に得られる型が`Option[T]`ではなく`IEnumerable[T]`になってしまいます。
そのため、LangExtではOption.QueryExpr.csでOption用のクエリ式用メソッドを提供しています。

`IEnumerable[T]`を実装していないのは、Option型を`IEnumerable[T]`として使いたいことがないからです。

match式の模倣
-------------
探した限りはあまり他で同じようなことをやっているライブラリがなかったのですが、
LangExtは(F#のような)match式をある程度模倣するMatchメソッドを提供しています。

```cs
int F(Option<string> opt)
{
    return opt.Match(
        str => int.Parse(str), // 値があった場合の処理
        () => -1);             // 値がなかった場合の処理
}
```

また、名前付き引数を使って、以下のように記述することもできます。

```cs
int F(Option<string> opt)
{
    return opt.Match(
        Some: str => int.Parse(str), // 値があった場合の処理
        None: () => -1);             // 値がなかった場合の処理
}
```

名前付き引数なので、順番を入れ替えることもできます。
このようなMatchメソッドは、Optionに限らず便利に使えるため、提供できる場合は提供しておくといいでしょう。

LangExtでは、Optionのほかに、ResultやTupleでもMatchメソッドを提供しています。
シーケンスに対しては[実験的に実装してみた](https://github.com/LangExt/LangExt/blob/2944308908ef644baaff6c155e0d9a739e9cd598/LangExt.Tests/Playground/PatternMatching/Example.cs)
ものの、このままでは複雑すぎて使い物にならないので、アイディア募集中です。
