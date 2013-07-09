LangExt.Compatibility.FSharp
============================
これは、LangExt.Compatibility.FSharpの概要を説明するドキュメントです。

LangExt.Compatibility.FSharpとは
--------------------------------
LangExt.Compatibility.FSharpは、LangExtを用いたC#のコードとF#のコードを繋ぐためのライブラリです。

LangExt.Compatibility.FSharpの機能のみをF#から利用する場合、
必要にならない限りLangExtをopenせず、LangExt.Compatibility.FSharpのみをopenしてください。

C#からこのライブラリを利用することは現状であまり考えていませんが、
今後は何かしらの対応を入れる可能性はあります。

LangExt.Compatibility.FSharpが提供する主な機能
----------------------------------------------
LangExt.Compatibility.FSharpが提供する主な機能について、その役割や意味を簡単に説明します。
実際の使い方に関しては、ドキュメンテーションコメント等を参考にしてください。

### LangExtの型に対する別名
LangExt.Compatibility.FSharpでは、LangExtが提供する型のうちOptionとResultにそれぞれ、
`CsOption`、`CsResult`という別名を提供しています。

OptionはF#にも存在するための別名ですが、Resultは標準の範囲ではF#にはありません。
しかし、他のF#ライブラリで提供されることが考えられるため、別名を用意しています。

### LangExtのOptionを生成する

CsOptionモジュールにLangExtのOptionを生成するための関数があります。

```ocaml
let f x =
  if x = 0 then CsOption.none else CsOption.some x
```

### LangExtのOptionをmatch式に使う
LangExtのOptionに対してアクティブパターンを提供しており、match式で使用可能です。

```ocaml
match opt with
| CsSome v -> sprintf "%A" v
| CsNone -> "none"
```

### LangExtのResultをmatch式に使う
LangExtのResultに対してアクティブパターンを提供しており、match式で使用可能です。

```ocaml
match res wit
| CsSuccess x -> sprintf "%A" x
| CsFailure x -> sprintf "%A" x
```

### LangExtのOptionとF#のOptionの相互変換
CsOptionモジュールとFsOptionモジュールに、LangExtのOptionとF#のOptionの相互変換を行うための関数があります。

LangExtのOptionからF#のOptionに変換する場合、`CsOption.toFsOption`か、`FsOption.ofCsOption`を使います。
この2つはまったく同じ機能を持ちますが、語順を意識してより自然に見えるように使い分けましょう。

```ocaml
(* 自然な語順 *)
let f (x: CsOption<'a>) =
  x |> CsOption.toFsOption |> Option.get

(* 不自然な語順 *)
let g (x: CsOption<'a>) =
  x |> FsOption.ofCsOption |> Option.get
```

このように、パイプライン演算子を使う場合は`CsOption.toFsOption`を使うほうが自然です。
それに対して、

```ocaml
(* 自然な語順 *)
let f (x: CsOption<'a>) =
  let opt = FsOption.ofCsOption x
  Option.get opt

(* 不自然な語順 *)
let g (x: CsOption<'a>) =
  let opt = CsOption.toFsOption x
  Option.get opt
```

のように、関数適用の形で使う場合は`FsOption.ofCsOption`を使うほうがより自然になります。

これらの逆の変換を行う`FsOption.toCsOption`と、`CsOption.ofFsOption`も定義されています。
