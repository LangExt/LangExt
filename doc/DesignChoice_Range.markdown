Rangeの設計
===========
LangExtでは、(整数の)範囲を表す型としてRangeを提供しています。
ここでは、このRangeの設計上の選択について説明します。

Rangeとは
---------
Rangeは、簡単には始点と終点(自身を含まない)を保持するクラスです。
それ自体は非常に単純ですが、どのようにしてRangeを生成するかという問題があります。

Rangeの生成問題
---------------
例えば、LINQのEnumerable.Rangeは始点と範囲の長さを指定するインターフェイスになっています。

```cs
Enumerable.Range(2, 4); // => { 2, 3, 4, 5 }
```

それに対して、C++やPythonのrangeは、始点と終点(自身を含まない)を指定するインターフェイスになっています。

```python
# Python
list(range(2, 4)) # => [ 2, 3 ]
```

これは、複数の言語を知っているプログラマにとっては頭の痛い問題で、
言語ごとにどちらのインターフェイスを備えているかを覚えておくか、都度調べる必要があります。

この問題は範囲を扱う場合に常について回ります。

* 部分文字列の指定方法
* 部分リストの指定方法
* GUIの複数選択時の指定方法

.NETでは幸い、大体のAPIが始点と長さを渡す方法に統一されていますが、
そうだとしても、分かりにくいことに変わりはありません。

幽霊型(Phantom Type)による解決
------------------------------
この問題を、LangExtでは幽霊型を使うことで解決しています。
幽霊型とは、型パラメータの値を使わないにもかかわらず、型パラメータを持つような型のことです。
例えば次のようなものです。

```cs
// 型パラメータとしてTを受け取るが、
public interface Hoge<T>
{
    // そのTを使っていない
    int Piyo();
}
```

### IntWithUnit[T]型

LangExtでは、IntWithUnit[T]という型があり、このTを使っていません。
この型はint型の値をラップするだけのクラスですが、単位を表す型を型パラメータとして取ります。
型パラメータがあるおかげで、以下のaとbは違う型になります。

```cs
class KiB : IUnit {}
class MilliSecond : IUnit {}

var a = new IntWithUnit<KiB>(124)
var b = new IntWithUnit<MilliSecond>(326);
```

IntWithUnitでは、加算を以下のように定義しています。

```cs
public static IntWithUnit<T> operator +(IntWithUnit<T> lhs, IntWithUnit<T> rhs) { ... }
```

これにより、加算は型パラメータが同じもの同士でしかできない、という制約を実現しています。
この制約はコンパイル時に働くため、上の例で`a + b`と書いても、コンパイルエラーになります。

### Range.Create
LangExtのRangeを生成するためには、コンストラクタではなくCreateメソッドを使います。
このCreateメソッドの引数にIntWithUnitを使っており、長さの指定も終了位置の指定も出来るようになっています。

```cs
public struct Range : IEquatable<Range>
{
    // ...
    public static Range Create(int begin, IntWithUnit<RangeUnit.Length> len) { ... }
    public static Range Create(int begin, IntWithUnit<RangeUnit.Index> end) { ... }
    // ...
}
```

Rangeを生成する場合は、以下のようにします。

```cs
Range.Create(2, new IntWithUnit<RangeUnit.Length>(4)); // => Range(Begin=2, End=6, Length=4)
Range.Create(2, new IntWithUnit<RangeUnit.Index>(4));  // => Range(Begin=2, End=4, Length=2)
```

Rangeは、それ自体はSeqではないので、SeqにするためにはToSeqメソッドを呼ぶ必要があります。

```cs
Range.Create(2, new IntWithUnit<RangeUnit.Length>(4)).ToSeq(); // => { 2, 3, 4, 5 }
Range.Create(2, new IntWithUnit<RangeUnit.Index>(4)).ToSeq();  // => { 2, 3 }
```

幽霊型による解決の欠点
----------------------
幽霊型によるRangeの生成の欠点は、記述が面倒なところでしょう。
拡張メソッドを用意したとしても、長くなってしまいます。

```cs
Range.Create(2, (4).AsIndex()).ToSeq(); // => { 2, 3 }
```

これを緩和するために、Create以外にもRangeを生成する方法を提供しています。

```cs
Range.FromUntil(2, 4).ToSeq(); // => { 2, 3 }
Range.FromTo(2, 4).ToSeq();    // => { 2, 3, 4 }
```

.NETのAPIとしては長さを取るものが多いので、長さを指定してRangeを生成する用のstaticメソッドも用意したいのですが、
いい名前が思い浮かばないためまだ用意できていません。
