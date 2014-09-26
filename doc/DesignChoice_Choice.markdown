Choiceの設計
============
LangExtでは、多者択一を表す型としてChoiceを提供しています。
ここでは、このChoiceの設計上の選択について説明します。

Choiceとは
----------
Choiceは、多者択一を表すクラスです。

例えば、状況によって返す型を変えたいとします。
そういう場合、通常は型階層を作って対処するか、objectを返すようにします。

標準ライブラリの[XPathEvaluate](http://msdn.microsoft.com/ja-jp/library/bb341675.aspx)は、
戻り値の型がobjectとなっており、実際にはbool/double/string/IEnumerable[T]を返します。

この際に問題になるのが、ドキュメントを読まなければ分からない、という点です。
こういう場合にChoiceを使うと、

```cs
public static Choice<bool, double, string, IEnumerable<Choice<XElement, XAttribute>>> XPathEvaluate(
    this XNode node,
    string expression
)
```

と、ドキュメントがなくてもこのうちのどれかが返る、というのが分かるようになります。

列挙型にも似ていますが、列挙型は種類しか表せないのに対して、Choiceは型に応じた値も持てるという違いがあります。

Choiceの生成
------------
Choiceの生成方法は、大まかに分けて

* コンストラクタで生成する
* Createを使って生成する(暗黙型変換前提)

の2つの方法があります。

コンストラクタで生成する方法はC#では一般的ですが、型パラメータをすべて書かなければならないため面倒です。
例えば、`int + string`を受け取る`F`という関数があった場合に、コンストラクタを使って渡してみましょう。

```cs
F(new Choice<int, string>(42));
```

`F`が`int + string`を受け取ることが分かり切っているにもかかわらず、コンストラクタでは型パラメータを省略できません。
これを解決するために、Create系メソッドと暗黙型変換を使います。

```cs
F(Create.Choice.Case1Of2(42));
// もしくは
F(Choice.CreateCase1Of2(42));
```

Choiceの保持する型の数が増えれば増えるほど、型パラメータを省略できることの嬉しさは増えます。

### Choice特有の事情
LangExtでは、CreateクラスによってLangExtが対応する型の生成をまとめています。
Choiceクラスの値もCreateクラスによって作れますが、Choiceクラス特有の事情によって他の型よりも一つ余分にネストしています。

```cs
// Choice以外の型の場合
var opt = Create.Option("hoge");
// Choiceの場合
Choice<int, string> x = Create.Choice.Case2Of2("hoge");
```

これは、補完の候補がChoiceで汚染されないための措置です。
Choiceは型自体2～16要素まで対応しているうえに、「その中でどのインデックスの型を保持するのか」という情報も必要です。
もしCreate直下にこれらのメソッドを追加していたら、Createの利用価値がなくなっていたでしょう。

値の取り出し方
--------------
Choiceが返ってきた場合は、返ってきたChoiceオブジェクトから値を取り出す必要があります。
Choiceオブジェクトから値を取り出す場合、Matchメソッドを使います。

```cs
return node.XPathEvaluate(expr).Match(
    b => b ? "yes" : "no",
    num => num.ToString(),
    str => str,
    nodes => nodes.Map(n => n.Match(elem => elem.ToString(), attr => attr.ToString())).ToString("[", ", ", "]")
);
```

Choiceをキャストすることや、直接値を取り出す手段は現状では実装していません[^unsafe]ので、必ずMatchメソッドを使うことになります。

[^unsafe]: 将来、Unsafe名前空間で提供する可能性はあります。

名前の選択
----------
LangExt1.xでは、ChoiceはVariantという名前で提供されていました。
しかし、Variantという名前は2つの点で紛らわしいです。

* VB/VBAが提供するVariantと紛らわしい
* OCamlなどの言語が提供するVariantと紛らわしい

LangExt1.xのVariantは、これらのVariantとは別物です[^boost]。

[^boost]: ちなみに、Variantという名前は[BoostというC++のライブラリ](http://www.boost.org/doc/html/variant.html)を意識した名前です。

### VB/VBAのVariantとの違い
VB/VBAのVariantは、何でも格納できる型です。
それに対してLangExt1.xのVariantは、型パラメータに指定したものしか格納することはできません。

また、VB/VBAのVariantはObjectとは異なり、実際に格納されている型に対する操作を直接することができます。
LangExt1.xのVariantはMatchや同値比較程度しかできません[^langext2choice]。

これらの特長により、VB/VBAのVariantよりも安全な操作が可能です。
VB/VBAの柔軟さが欲しい場合、dynamicがより適切な代替手段です。

[^langext2choice]: LangExt2.1で導入されたChoiceもほぼ同様です。

### OCamlなどのVariantとの違い
OCamlのVariantも、択一の型を表します。
しかし、LangExt1.xのVariant(や、LangExt2.xのChoice)と異なり、タグを持っています。
そのため、別のタグを付けることで、同じ型でも扱えます。

```ocaml
type t =
  | A of string
  | B of string
```

これをC#で実現する場合、LangExt1.xのVariant(や、LangExt2.xのChoice)ではなく、クラス階層を作る必要があります。

```cs
interface I {}
class A : I {}
class B : I {}
```

### 他の選択肢
これらのVariantとの区別をするために、LangExt2では、Choiceという名前を選択しました。
Choiceの他にも、OrやSumといった名前も考慮したのですが、TupleがAndやProductという名前ではないため見送りました[^choicechoice]。

[^choicechoice]: LangExtのドキュメントでは、intとstringのタプルを`int * string`、intとstringのChoiceを`int + string`のように書きます。
    これは、タプルが直積型と対応するのに対して、Choiceが直和型に対応していることを意識した表記方法です。
    他の候補としては、`&`と`|`を使う案や、`∧`と`∨`を使う案などがありましたが、F#のタプル表記との統一性を考えて現在の表記に落ち着きました。
    ちなみに、`int + string`と`string + int`は別の型として扱われることに注意してください。

LangExt1.xからの移行
--------------------
LangExt1.xでVariantを使っていた部分は、Choiceに置き換えてください。
Eitherを使っていたもので、成功/失敗を扱うものはResultに、それ以外は2要素のChoiceで置き換えてください。

Resultと2要素のChoiceでは、Resultの方が具体的なので出来る操作が多いですが、
2要素のChoiceの方が適用できる範囲は広くなります。
