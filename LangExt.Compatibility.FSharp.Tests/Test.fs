[<NUnit.Framework.TestFixture>]
module Test

open LangExt
open LangExt.Compatibility.FSharp
open NUnit.Framework

[<Test>]
let LangExtのOptionをパターンマッチで使える() =
  match Option.Some(42) with
  | CsSome x -> Assert.AreEqual(42, x)
  | CsNone -> Assert.Fail()

  match Option.None with
  | CsSome _ -> Assert.Fail()
  | CsNone -> Assert.Pass()