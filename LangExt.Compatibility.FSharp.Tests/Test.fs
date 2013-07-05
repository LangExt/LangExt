[<NUnit.Framework.TestFixture>]
module Test

open LangExt
open LangExt.Compatibility.FSharp
open NUnit.Framework

[<Test>]
let LangExtのOptionをmatch式で使える() =
  match Option.Some(42) with
  | CsSome x -> Assert.AreEqual(42, x)
  | CsNone -> Assert.Fail()

  match Option.None with
  | CsSome _ -> Assert.Fail()
  | CsNone -> Assert.Pass()

[<Test>]
let LangExtのResultをmatch式で使える() =
  match Result.Success("hoge") with
  | Success str -> Assert.AreEqual("hoge", str)
  | Failure _ -> Assert.Fail()

  match Result.Failure("piyo") with
  | Success _ -> Assert.Fail()
  | Failure str -> Assert.AreEqual("piyo", str)

[<Test>]
let ``LangExtのOptionからF#のOptionに変換できる``() =
  let res = Option.Some(42) |> CsOption.toFsOption
  Assert.AreEqual(Some(42), res)

  let res = Option.None |> CsOption.toFsOption
  Assert.AreEqual(None, res)

  let res = FsOption.ofCsOption (Option.Some(42))
  Assert.AreEqual(Some(42), res)

  let res = FsOption.ofCsOption Option.None
  Assert.AreEqual(None, res)