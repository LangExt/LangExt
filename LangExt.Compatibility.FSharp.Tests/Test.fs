[<NUnit.Framework.TestFixture>]
module Test

open LangExt.Compatibility.FSharp
open NUnit.Framework

[<Test>]
let LangExtのOptionをmatch式で使える() =
  match CsOption.Some(42) with
  | CsSome x -> Assert.AreEqual(42, x)
  | CsNone -> Assert.Fail()

  match CsOption.None with
  | CsSome _ -> Assert.Fail()
  | CsNone -> Assert.Pass()

[<Test>]
let LangExtのResultをmatch式で使える() =
  match CsResult.Success("hoge") with
  | CsSuccess str -> Assert.AreEqual("hoge", str)
  | CsFailure _ -> Assert.Fail()

  match CsResult.Failure("piyo") with
  | CsSuccess _ -> Assert.Fail()
  | CsFailure str -> Assert.AreEqual("piyo", str)

[<Test>]
let ``LangExtのOptionからF#のOptionに変換できる``() =
  let res = CsOption.Some(42) |> CsOption.toFsOption
  Assert.AreEqual(Some(42), res)

  let res = CsOption.None |> CsOption.toFsOption
  Assert.AreEqual(None, res)

  let res = FsOption.ofCsOption (CsOption.Some(42))
  Assert.AreEqual(Some(42), res)

  let res = FsOption.ofCsOption CsOption.None
  Assert.AreEqual(None, res)