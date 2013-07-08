LangExt.Legacy
==============
これは、LangExt.Legacyの概要を説明するドキュメントです。

LangExt.Legacyとは
------------------
LangExt.Legacyは、レガシーコードを扱うための仕組みを提供するライブラリです。
LangExtとともに使うことが想定されていますが、現在のところLangExt.Legacy自体は単独でも使用可能です。

LangExt.Legacyが提供する主な機能
--------------------------------
LangExt.Legacyが提供する主な機能について、その役割や意味を簡単に説明します。
実際の使い方に関しては、ドキュメンテーションコメント等を参考にしてください。

### TypeMatch
TypeMatchは、objectに対する拡張として提供されています。
TypeMatchは、何らかの処理の結果をobject型として返すような旧時代のAPIを扱う場合に、便利に使えます。

例えば、実際にはintかstringを返すため、戻り値の型としてはobjectになっているようなメソッドがあったとします。
そういう場合に、TypeMatchを使わない場合は型チェックとキャストが必要になります。

```cs
var obj = DoSomething();
if (obj is int)
{
    var i = (int)obj;
    // intの場合の処理
}
else
{
    var str = (string)obj;
    // stringの場合の処理
}
```

これに対して、TypeMatchを使った場合は型チェックとキャストはTypeMatch内に隠ぺいされるため、
より宣言的な記述が可能になります。

```cs
return DoSomething().TypeMatch(
    (int i) => /* intの場合の処理 */,
    (string str) => /* stringの場合の処理 */);
```

TypeMatchは16個の型まで対応していますが、それより多い型の分岐もTypeMatchをネストすることで可能です。

```cs
return DoSomething().TypeMatch(
    (T1 t1) => /* T1の場合の処理 */,
    (T2 t2) => /* T2の場合の処理 */,
    // ...
    (T16 t16) => /* T16の場合の処理 */,
    other =>
        other.TypeMatch(
            (T17 t17) => /* T17の場合の処理 */,
            (T18 t18) => /* T18の場合の処理 */,
            // ...
        )
    );
```

さすがにここまで多様な型をobjectという単一の型にまとめてしまう例に遭遇したことは無いですが、
もしこのような状況に遭遇した場合は、元のAPIをラップした方が効果的でしょう。

TypeMatchはobjectに対する拡張として提供されているため、
任意の型階層を扱うことが出来ます。
例えば、Aを継承したB, C, Dがあった場合に、Aを返すメソッドに対して、

```cs
return DoSomething().TypeMatch(
    (B b) => /* Bの場合の処理 */,
    (C c) => /* Cの場合の処理 */,
    (D d) => /* Dの場合の処理 */);
```

のような使い方も可能です。

#### 注意すべき点
TypeMatchはあくまで型チェックとキャストを隠ぺいしているだけ、という点に注意してください。
例えば、Aを継承したBがあった場合に、

```cs
class A {}
class B : A {}
```

Aを返すDoSomethingに対してAを先に記述してしまうと、B固有の処理が実行されることはありません。

```cs
return DoSomething().TypeMatch(
    (A a) => /* Aの場合の処理 */,
    (B b) => /* Bの場合の処理 */  // この処理は実行されない
);
```

この場合に、コンパイラはエラーにすることも警告を出すこともできません。
型階層を扱う場合は、この挙動に十分に注意して扱ってください。
