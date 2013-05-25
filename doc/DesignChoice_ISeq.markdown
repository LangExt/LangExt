ISeq(シーケンス)
================
LangExtでは、IEnumerable[T]の代わりとなる型として、ISeq[T]を提供しています。
ここでは、なぜIEnumerable[T]の代わりにISeq[T]という別の型を用意したのかを中心に説明します。
また、LINQを捨てた理由についても説明します。

この設計選択に納得できない場合、LangExtを直接使うのは避けた方がいいでしょう。
LangExtからフォークして、独自のライブラリを作るなどしてください。

ISeqとIEnumerableの違い
-----------------------
ISeq[T]はIEnumerable[T]を継承しているため、IEnumerable[T]が必要な場面ではいつでもISeq[T]も使えます。
LangExtでは、IEnumerable[T]よりもISeq[T]の使用を推奨しています。
以降ではその理由を説明します。

### ISeq[T]の方が名前が短い
IEnumerable[T]は名前が長いという大きな欠点を抱えています。
長い型名はタイプが面倒なだけでなく、画面を占有するため、読みにくく理解しにくいコードになりがちです。
IEnumerable[T]を2つ受け取り、IEnumerable[T]を返すような関数Fを考えてみると、
関数のシグネチャだけでかなりの字数を消費してしまいます。

```cs
public static IEnumerable<T> F(IEnumerable<T> xs, IEnumerable<T> ys)
```

それに対して、ISeq[T]はIEnumerable[T]の半分の文字数で済むため、字数はそれほど消費しません。

```cs
public static ISeq<T> F(ISeq<T> xs, ISeq<T> ys)
```

本来なら、Seq[T]型にしたかったのですが、.NETの名前付けの慣習に従っています。
反対意見が少なければ、将来Seqという名前に変更する可能性はあります。

### ISeq[T]の方が出来る操作が多い
LangExtではISeq[T]の方を使ってもらえるように、IEnumerable[T]に対して出来る操作よりも、
ISeq[T]に対してできる操作の方が充実しています。

ISeq[T]のみに対してできる操作には、例えば以下の関数があります。

* Init/Repeat
* Size/Len/Count
* Exists/Forall
* Fold/FoldBack/ScanBack/TryReduce/TryReduceBack
* Filter/Partition
* Reverse
* Sort/RevSort
* TryFind/TryPick

これらの関数が使いたい場合、`ToSeq`メソッドでISeq[T]に変換してください。

### IEnumerable[T]を捨てたことによる欠点
IEnumerable[T]ではなく、ISeq[T]という新しい型を中心に据えたことによる欠点もあります。
それは、yield構文がそのままでは使えなくなるという点です。

C#のyield構文は、IEnumerable[T]/IEnumerator[T]と切り離すことが出来ません。
そのため、現状のLangExtではIEnumerable[T]に対してyieldで実装したものをISeq[T]でラップすることで実装しています。

標準クエリ演算子からの解放
--------------------------
LangExtでは、LINQ to Objectsに関して
[標準クエリ演算子](http://msdn.microsoft.com/ja-jp/library/vstudio/bb397896.aspx)
を捨て、独自の関数名を提供しています。
以降では、なぜ標準クエリ演算子を捨てたのかについて説明します。

### SQLに合わせたメソッド名
標準クエリ演算子は、各メソッド名にSQL由来の名前を付けています。
例えば、フィルター処理はWhere、射影操作にはSelectといった具合です。

これは、SQLを扱うことが多かった業務プログラマをLINQの世界に引き込みやすくした、
というよかった点もありますが、あまりに短期的なメリットしか見ていないように感じます。

全てをSQLに合わせることはできないため、無理のある名前を付けざるを得ない例(SelectMany)もあります。

それだけならまだましで、SQLと異なる名前を付けている例もあります。
例えば、SQLで結果セットの連結には`UNION ALL`を使いますが、標準クエリ演算子では`Concat`になっています。
他にも、SQLでは`AVG`なのに標準クエリ演算子では`Average`となっている例があります。

### 名前の使い回し
標準クエリ演算子は、オーバーロード機構を前提にして名前を使い回ししています。
例えば、述語を満たす要素が1つでもあるかどうかを調べる用途と、
そもそも要素が1つでも存在するかどうかを調べる用途に、`Any`という名前を使っています。
他にも、Aggregate(初期値を与えるか先頭の要素を使うか)、Count(長さを調べるか述語を満たす要素を数え上げるか)があります。

また、SelectやWhereなど、要素のインデックスを追加で取るオーバーロードを用意している関数もあります。

別の役割を持ったものには別の名前を付けるべきです。
標準クエリ演算子は名前を使い回しすぎでしょう。

LangExtでは、それぞれに別の名前を用意しています。
標準クエリ演算子のAnyはLangExtのExistsとIsNotEmptyに、AggregateはFoldとReduce(Unsafe名前空間)に、
CountはSize/LenとCountにそれぞれ対応します。
また、要素のインデックスを追加で取るバージョンは、メソッド名の後ろにWithIndexを付けています。

### LangExtのシーケンス操作関数の語彙
これらの問題を解決するため、LangExtでは主にF#から語彙を借りています。
F#の語彙はHaskellやOCaml、Scalaともある程度一致しているため、LINQの語彙よりも応用範囲が広くなります。

Optionを返すような関数にはTryを付けるようにしており、
Try無しの(例外を投げうる)関数はUnsafe名前空間内に別定義してあります。

### クエリ式の提供
LangExtでは、LINQのうち標準クエリ演算子は捨てましたが、クエリ式は使えるようになっています。
ISeq[T]も、クエリ式の対象にすることが可能です。

```cs
return
    from x in xs
    from y in ys
    select x + y;
```

クエリ式をサポートするためのメソッドは補完候補に表示されないようになっているため、
メソッド形式でそれらのメソッドを使うことは通常ありません。
