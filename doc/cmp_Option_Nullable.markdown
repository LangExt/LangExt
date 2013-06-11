NullableとOptionの違い
======================
Optionそのものについてのエントリは書く必要ない(世の中に有用なドキュメントが山ほどあるから)かな、
と思っていたのですが、Nullableとの違いについてはそれなりに需要がありそうなので書いておきます。

ちなみに、個人的な嗜好によりOptionを持ち上げ、Nullableを下に扱う感じになっていますが、Nullableも(仕方なく)使うことはあります。
特別な理由がなければNullable使わずにOptionを使う、ということでもありますが、そこは一つよろしくお願いします。

Nullableとは
------------
C#では`null`は参照型でしか使えませんでした。
Nullableは、この制限がない(ように見えるよう特別扱いされている)唯一の値型です。
ジェネリック型になっており、任意の値型を扱うことが出来ます。

```cs
// Nullable<int>はint?と書ける
int? x = 42;   // 値がある
int? y = null; // 値がない

// こちらは参照型なので、Nullable型ではない
string a = "hoge"; // 値がある
string b = null;   // 値がない
```

Optionとは
----------
Optionは、「`null`よりも安全に値がないことを表せる」ものです。
標準にはありませんが、様々なライブラリで提供されています。
このエントリでは、Optionは[LangExt](https://github.com/LangExt/LangExt)のOptionを指すものとします。

ジェネリック型になっており、任意の型を扱うことが出来ます。

```cs
Option<int> x = Option.Some(42); // 値がある
Option<int> y = Option.None;     // 値がない

Option<string> a = Option.Some("hoge"); // 値がある
Option<string> b = Option.None;         // 値がない
```

NullableとOptionの類似点
------------------------
NullableもOptionも、structで実装されており、値を持っているかどうかを表すフラグと、値を保持しているという点で、構造は似ています。
しかし、似ているのは構造くらいで、目的や使い方などはかなり異なります。

NullableとOptionの違い
----------------------
### パラメータとして渡せる型の違い
Nullableは値型でも`null`を扱えるようにするために作られたため、値型しか型パラメータに指定できません(参照型はそもそも最初から`null`を扱える)。

```cs
Nullable<int> i = null;
// これはコンパイルエラー
//Nullable<string> s = null;
// そもそもこう書ける
string s = null;
```

それに対してOptionは、`null`を置き換えるために作られているため、値型であっても参照型であっても型パラメータに指定することができます。

```cs
Option<int> i = Option.None;
Option<string> s = Option.None;
// もちろんこれはコンパイルエラー
//string s = Option.None;
```

また、Nullableはネストさせることができません(`Nullable<Nullable<int>>`や、`int??`はできない)が、Optionは出来る、という違いもあります。

### 表記上の違い
Nullableは言語組み込みの機能なので、表記はとてもシンプルです。
また、値がある場合はその値が直接書けます。

それに対してOptionは、値がある場合でも`Option.Some`の呼び出しが必須になるため、その分面倒です。
任意の型からそのOption型への暗黙の型変換を提供すればこれは解決できるのですが、
これには問題もあるため、LangExtでは提供していません。

その理由については、
[Optionの設計](http://langext.github.io/LangExt/DesignChoice_Option.html#任意のt型からoptiont型への暗黙の型変換を提供しない理由)
で述べていますので、後で(NullableとOptionの違いを理解したうえで)読んでみてください。

### 設計方針の違い
Nullable型は値型で`null`を扱えるようにすることを目的としています。
単に値がない状態を表せればよく、それを**どう扱うか**には興味がありません。
そのため、Nullableが出来るのは基本的には

* `null`かどうかのチェック
* 値の取り出し

の2つだけです。

それに対して、Option型は**どうやって値がない状態を上手に扱うか**が最大の興味です。
そのため、Optionに対しては様々な操作が可能です。
しかし、Nullableには用意されている「値の取り出し」は、Optionでは簡単にはできないようになっています。

値が取り出せるのは一見便利に見えます。
しかし、値がない場合に値を取り出そうとした場合にどうすればいいかを考える必要があります。
Nullableの場合、

* 値がない場合に例外(InvalidOperationException)を投げるValueプロパティ
* 値がない場合にデフォルト値を返すGetValueOrDefaultメソッド
* 値がない場合に引数で指定した値を返すGetValueOrDefaultメソッド

の3つの方法を用意しています。
Valueプロパティは一番使うのが簡単なので一番多用されがちな方法となりますが、`null`チェックが強制されるわけではないため、気を抜くと簡単に例外が投げられてしまいます。
Nullableは「どうやって値がない状態をうまく扱うか」に興味がないため、
この設計選択は妥当と言えるでしょう(ただ、Nullableの場合と参照型の場合とで投げられる例外が違うのがいいことなのかどうかは場合によると思います)。

```cs
static string F(int? x)
{
    return x.Value.ToString(); // xがnullならInvalidOperationExceptionが発生
}
```

しかし、「どうやって値がない状態をうまく扱うか」が最大の興味であるOptionでは、簡単に例外を投げるわけにはいきません。
そこで、Optionがとる方針はこうです。
**「値の取得は禁止して、値を受け取った後の処理と、値がなかった(値が受け取れなかった)場合の処理を渡してもらいOptionの中でそれを振り分ければいい！」**

```cs
static string F(Option<int> x)
{
    // 値がない場合も考慮することを強制するAPI
    return x.Match(
      Some: i => i.ToString(),
      None: () => { throw new Exception(); }); // 今回は例外を投げるだけでいいので、Nullableより面倒
}
```

こうすることで、ついうっかり値がない考慮が漏れてしまうという失敗を防ぐことができるのが、OptionとNullableの最も大きな違いです。

### 値がないことの伝搬
`T`と演算可能な`U`があった時、`T?`と`U`も演算可能です。
そのため、以下のプログラムは「42.1」を表示します。

```cs
int? x = 42;
double? y = x + 0.1;
if (y != null)
    Console.WriteLine(y);
```

ここで、xが`null`だった場合はどうなるでしょうか。この場合、`null`が伝搬することになります(比較演算子の場合はまた違います)。
つまり、yも`null`になります。

```cs
int? x = null;
double? y = x + 0.1;
if (y != null)
    Console.WriteLine(y); // yがnullなので表示されない
```

では、以下の例ではどうでしょう？

```cs
int? x = null;
string y = x + "aaa";
if (y != null)
    Console.WriteLine(y);
```

この場合、なんと「aaa」が表示されます。
参照型の場合、(自分で定義しない限り)`null`の伝搬は起こらなかったので、`null`に文字列を加えたときの動作は特別なものではありませんでした。
しかし、Nullableに`null`の伝搬を導入したせいで、Nullableに関しては`null`に文字列を加えたときの動作が特別なものに見えるようになってしまっています。

Optionでどうなるかを見てみましょう。
Optionで同じことをするためには、Optionのままでは演算できないため、MapとIterを使います。
これらの関数は、内部でMatchを使って実装されています。

```cs
public static Option<U> Map<T, U>(this Option<T> self, Func<T, U> f)
{
    // fが呼び出されるのは値がある(Someの時)だけ
    return self.Match(
      Some: v => Option.Some(f(v)),
      None: () => Option.None);  // Noneは常に伝搬する(文字列が特別扱いされるなどはない)
}
public static void Iter<T>(this Option<T> self, Action<T> act)
{
    // actが呼び出されるのは値がある(Someの時)だけ
    self.Match(
      Some: v => act(v),
      None: () => { });
}
```

これらを使うと、「値があるかどうかわからないものに0.1を加え、値があればその結果を表示する」コードはこう書けます。

```cs
Option<int> x = Option.Some(42);
x.Map(_ => _ + 0.1)
 .Iter(y => Console.WriteLine(y)); // 「42.1」と表示される
```

```cs
Option<int> x = Option.None;
x.Map(_ => _ + 0.1)
 .Iter(y => Console.WriteLine(y)); // 何も表示されない
```

値があるかどうかの判定をユーザーコード側で行っていない(MapとIter内部で行っている)という違いはありますが、ここまでの動作はNullableと同様です。
Nullableと違うのは、文字列の結合も他の場合と同じような動作をする点です。

```cs
Option<int> x = Option.None;
x.Map(_ => _ + "aaa")
 .Iter(y => Console.WriteLine(y)); // 何も表示されない
```

値がなかった場合は空文字列として文字列を連結したい場合は、異なるコードになります。

```cs
Option<int> x = Option.None;
var y = x.Map(_ => _.ToString()) // 数値があれば文字列化
         .GetOr("") + "aaa";     // 値があればそれを取得し、なければ空文字列を取得
                                 // 取得した文字列と"aaa"を連結
Console.WriteLine(y);
```

Nullableでは、`T`型でできることは、極力`T?`型でもできるように考えられています。
しかし、そのせいで統一性が崩れてしまっています。

それに対して、Optionは`T`型にできる操作を`Option[T]`型に対して提供していません(提供できません)。
`T`型と`Option[T]`型は完全に別の型であり、Optionはあくまで「値があるかないかの表現」以上のことは行いません。
そのため、Optionが保持する値に対して処理を行いたい場合は、MapやIterのような高階関数を使って値を受け取る関数を渡すことになり、
すべての処理が統一性を保っています。

### クエリ式の対象にできるかどうか
クエリ式でOptionを扱うと、「値がない場合」を意識せずに処理が記述でき、非常に便利です。

```cs
// Option<int> TryGet(string key); があったとする
var res =
  from x in TryGet("x")
  from y in TryGet("y")
  select x + y;
```

この程度の例なら、Nullableでも問題なく扱えます。

```cs
// int? TryGet(string key); があったとする
var x = TryGet("x");
var y = TryGet("y");
var res = x + y;
```

しかし、参照型が混じると途端に厳しくなります。

```cs
// Optionの場合は特に何も変わらない
var res =
  from x in TryGetInt("x")
  from y in TryGetStr("y")
  select x + y; // x(の文字列表現)とyを連結
```

```cs
// Nullableと参照型との演算ではnullが伝搬しないので、nullチェックが必要になる
var x = TryGetInt("x");
var y = TryGetStr("y");
var res =
  // うっ・・・
  x == null || y == null ? null
                         : x + y;
```

これを回避したくて、Nullableにもクエリ式を提供したくなります。
しかし、これらのケースすべてをカバーできるクエリ式を提供することは、C# のオーバーロード解決能力が低いため不可能です。
実際に実装してみると分かるのですが、`T?`だけを扱うようなクエリ式は提供可能です。
例えば、

```cs
// int? TryGet(string key); があったとする
var res =
  from x in TryGet("x")
  from y in TryGet("y")
  select x + y;
```

ここまでは可能です。
しかし、そこに`T when T : class`も扱えるようにしようとすると、オーバーロードが解決できないバージョンのSelectManyを書く必要が出てきてしまいます。

NullableとOptionの違い
----------------------
Nullableは、`null`チェックから逃れることを目的としていない時点で良くないアイディアです。
[null参照の考案は10億ドル単位の過ち](http://developers.slashdot.jp/story/09/03/05/0937219/null%E5%8F%82%E7%85%A7%E3%81%AE%E8%80%83%E6%A1%88%E3%81%AF10%E5%84%84%E3%83%89%E3%83%AB%E5%8D%98%E4%BD%8D%E3%81%AE%E9%81%8E%E3%81%A1%EF%BC%9F)と、
考案者自らが認める過ちである`null`の適用範囲を広げてしまうNullableを、言語仕様(それどころかCLRにまで)に組み込んでしまうというのは、
個人的にはなんてセンスのない設計をしたんだ、と思ってしまいます。

それに対してOptionは、OOPの側面からみると[NullObjectをジェネリックの力を借りて汎用化したもの](http://bleis-tift.hatenablog.com/entry/20120628/1340893265)であり、
非常に好ましいものです。
シグネチャ上で「値がないかもしれない」ことを表すことができるのも、ありがたいです(Nullableは出来るが、参照型ではできない)。

構造は同じなのに、ここまで正反対の意見になるというのは、ちょっと面白いですね。
この違いは、主に提供するAPIから来ており、「値を(簡単には)取り出せない」という制限がOptionの良さの根源にあるというのは、心に留めておいてほしいです。
何でもかんでもできるAPIが常によいというわけではないのです。

(おまけ)Optionからの値の取り出し
--------------------------------
・・・とは言うものの、Optionからさくっと値を取り出したい場合があるのも事実です。
例えば、「ここでは絶対値があることが分かりきっている」というような場合です。
そのような場合でも、通常は値がなかった場合の考慮が必要ですが、LangExt.Unsafe名前空間をusingすることで、Optionから直接値を取り出せる関数が使えるようになります。

LangExtのOptionに限らず、たいていのOptionの実装には、このような「直接値を取り出す」関数が提供されています。
そればかりか、場合によっては他のAPIと一緒にこの関数を紹介してしまっている場合もあります。

しかし、Optionの目的を「安全に値がないことを表す」と置くのであれば、この関数をそのように紹介するのはよくないことです。
これを先に教えてしまえば、`null`を知っている人の多くは「使いにくい`null`だ」と思いながらOptionを使ってしまうことでしょう。

そういう事態を避けるためにも、Optionから直接値を取り出す関数は、Optionの目的や利点を語った後で教えるべきです。
場合によっては、教えないというのもアリでしょう。
それくらい、慎重に扱うべきものです。
