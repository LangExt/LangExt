Applyの設計
==========
LangExtでは、OptionやResultに対して関数を適用できる機能としてApplyモジュールを提供しています。
ここでは、このApplyの設計上の選択について説明します。

Applyとは
--------
Applyモジュールは、OptionやResult（以降、モナド）に対して関数を適用する機能を提供します。

モナドに対しての関数適用は、Bind関数やクエリ式によって行われますが、Applyモジュールはそのファサードとして機能します。
このファサードは、クエリ式でfrom v in mとしたvをselectのみで使うだけの場合に有効です。

```cs
var res =
    from x in mx
    from y in my
    select x + y;
```

このコードは、Applyモジュールを使うことで以下のように変形できます。

```cs
var res = Apply.To(mx, my).By((x, y) => x + y);
```

selectの処理が関数化されている場合、更に単純に記述できます。

```cs
var res = Apply.To(mx, my).By(f);
```

名前の選択
---------
Applyモジュールは、HaskellのApplicativeに影響を受けたので、最初は名前もそのまま輸入することを考えました。
ただし、C#はHaskellほど演算子オーバーロードを自由に行えず、演算子を使わずに`Applicative.Apply`のようにすると名前が長くなり
ファサードとしての役割が弱くなってしまいます。

次に、名前を短くするために、`Apply._`や`Ap.ply`という名前を考案しました。
しかしながら、これらは一見したときに分かりにくいため却下となりました。

C#にはメソッドチェーンという文化があります。
最終的には、Applyモジュールはこの文化にのっとり関数の適用の対象（To）と関数(By)を分離することにしました。
そして下記のようになりました。

```cs
Apply.To(o1, o2, ..., o16).By(func)
```

HaskellのApplicativeとは、適用の順番が逆であることに注意してください。
これは、C#では関数合成のサポートがなく、代わりにラムダ式を使う頻度が高いのでByの引数式のほうが長くなることを考慮したためです。

ファンクタについて
-------------
HaskellのApplicativeはモナドに対してではなくファンクタに対して適用が行われます。
しかし、C#では型クラスをエミュレートすることが難しく、各々のモナドをファンクタとして汎化することができません。
そのため、Applyモジュールでは、次のようにオーバーロードを使い各モナドをサポートしています。

```cs
public static class Apply
{
    public static ApplicativeOption<T1> To<T1>(Option<T1> m1) { ... }
    public static ApplicativeOption<T1, T2> To<T1, T2>(Option<T1> m1, Option<T2> m2) { ... }
    ...
    public static ApplicativeResult<T1, TFailure> To<T1, TFailure>(Result<T1, TFailure> m1) { ... }
    public static ApplicativeResult<T1, T2, TFailure> To<T1, T2, TFailure>(Result<T1, TFailure> m1, Result<T2, TFailure> m2) { ... }
    ...
}
```