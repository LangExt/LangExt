module OptionTest

open System
open NUnit.Framework
open FsCheck
open FsCheck.NUnit
open LangExt

[<Test>]
let ``== eq Equals<T>``() =
  check "" (fun (x, y) ->
    x <> null ==>
      (lazy
        (Option.Some(x) = Option.Some(y)) = (Option.Some(x).Equals(Option.Some(y)))))

[<Test>]
let ``!=(<>) eq (not Equals<T>)``() =
  check "" (fun (x, y) ->
    x <> null ==>
      (lazy
        (Option.Some(x) <> Option.Some(y)) = (not <| Option.Some(x).Equals(Option.Some(y)))))

[<Test>]
let ``Some(x).GetOr(y) returns x``() =
  check "" (fun (x, y) ->
    x <> null ==>
      (lazy
        Option.Some(x).GetOr(y) = x))

[<Test>]
let ``None.GetOr(x) returns x``() =
  check "" (fun x ->
    Option<string>.None.GetOr(x) = x)

[<Test>]
let ``Some(x).GetOrElse(() => { throw new Exception(); }) returns x``() =
  check "" (fun x ->
    x <> null ==>
      (lazy
        Option.Some(x).GetOrElse(fun () -> failwith "") = x))

[<Test>]
let ``None.GetOrElse(() => x) returns x``() =
  check "" (fun x ->
     Option<string>.None.GetOrElse(fun () -> x) = x)

[<Test>]
let ``Some(x).Match(v => y, () => { throw new Exception(); }) returns y``() =
  check "" (fun (x, y) ->
    x <> null ==>
      (lazy
        Option.Some(x).Match((fun v -> y), fun () -> failwith "") = y))

[<Test>]
let ``None.Match(v => { throw new Exception(); }, () => x) = x``() =
  check "" (fun x ->
    Option<string>.None.Match((fun v -> failwith ""), fun () -> x) = x)

[<Test>]
let ``Some(x).Match(v => res = v, () => { throw new Exception(); }) then res equals x``() =
  check "" (fun x ->
    let res = ref 0
    Option.Some(x).Match((fun v -> res := v), (fun () -> failwith ""))
    !res = x)

[<Test>]
let ``None.Match(v => { throw new Exception(); }, () => res = x) then res equals x``() =
  check "" (fun x ->
    let res = ref 0
    Option<string>.None.Match((fun v -> failwith ""), fun () -> res := x)
    !res = x)

[<Test>]
let ``Some(x).GetHashCode() = Some(y).GetHashCode() when x = y``() =
  check "" (fun (x, y) ->
    if x = y then
      (Option.Some(x).GetHashCode() = Option.Some(y).GetHashCode())
    else
      true)

[<Test>]
let ``Option<int>.None.GetHashCode() = Option<string>.None.GetHashCode()``() =
  Assert.That(Option<int>.None.GetHashCode(), Is.EqualTo(Option<string>.None.GetHashCode()))
