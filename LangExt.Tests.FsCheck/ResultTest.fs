module ResultTest

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
        (Result.Success(x) = Result.Success(y)) = (Result.Success(x).Equals(Result.Success(y)))))

[<Test>]
let ``!=(<>) eq (not Equals<T>)``() =
  check "" (fun (x, y) ->
    x <> null ==>
      (lazy
        (Result.Success(x) <> Result.Success(y)) = (not <| Result.Success(x).Equals(Result.Success(y)))))

[<Test>]
let ``Success(x).GetOr(y) returns x``() =
  check "" (fun (x, y) ->
    x <> null ==>
      (lazy
        Result.Success(x).GetOr(y) = x))

[<Test>]
let ``Failure(x).GetOr(y) returns y``() =
  check "" (fun (x, y) ->
    x <> null ==>
      (lazy
        Result.NewFailure<int, _>(x).GetOr(y) = y))

[<Test>]
let ``Success(x).GetFailureOr(y) returns y``() =
  check "" (fun (x, y) ->
    x <> null ==>
      (lazy
        Result.NewSuccess<_, int>(x).GetFailureOr(y) = y))

[<Test>]
let ``Failure(x).GetFailureOr(y) returns x``() =
  check "" (fun (x, y) ->
    x <> null ==>
      (lazy
        Result.Failure(x).GetFailureOr(y) = x))

[<Test>]
let ``Success(x).GetOrElse(() => { throw new Exception(); }) returns x``() =
  check "" (fun x ->
    x <> null ==>
      (lazy
        Result.Success(x).GetOrElse(fun () -> failwith "") = x))

[<Test>]
let ``Failure(x).GetOrElse(() => y) returns y``() =
  check "" (fun (x, y) ->
    x <> null ==>
      (lazy
        Result.NewFailure<int, _>(x).GetOrElse(fun () -> y) = y))

[<Test>]
let ``Success(x).GetFailureOrElse(() => y) returns y``() =
  check "" (fun (x, y) ->
    x <> null ==>
      (lazy
        Result.NewSuccess<_, int>(x).GetFailureOrElse(fun () -> y) = y))

[<Test>]
let ``Failure(x).GetFailureOrElse(() => { throw new Exception(); }) returns x``() =
  check "" (fun x ->
    x <> null ==>
      (lazy
        Result.Failure(x).GetFailureOrElse(fun () -> failwith "") = x))

[<Test>]
let ``Success(x).Match(v => y, _ => { throw new Exception(); }) returns y``() =
  check "" (fun (x, y) ->
    x <> null ==>
      (lazy
        Result.Success(x).Match((fun v -> y), fun _ -> failwith "") = y))

[<Test>]
let ``Failure(x).Match(_ => { throw new Exception(); }, v => y) returns y``() =
  check "" (fun (x, y) ->
    x <> null ==>
      (lazy
        Result.Failure(x).Match((fun _ -> failwith ""), fun v -> y) = y))

[<Test>]
let ``Success(x).Match(v => res = v, _ => { throw new Exception(); }) then res equals x``() =
  check "" (fun x ->
    let res = ref 0
    Result.Success(x).Match((fun v -> res := v), (fun _ -> failwith ""))
    !res = x)

[<Test>]
let ``Failure(x).Match(_ => { throw new Exception(); }, v => res = v) then res equals x``() =
  check "" (fun x ->
    let res = ref 0
    Result.Failure(x).Match((fun _ -> failwith ""), (fun v -> res := v))
    !res = x)

[<Test>]
let ``Success(x).GetHashCode() = Success(y).GetHashCode() when x = y``() =
  check "" (fun (x, y) ->
    if x = y then
      (Result.Success(x).GetHashCode() = Result.Success(y).GetHashCode())
    else
      true)

[<Test>]
let ``Failure(x).GetHashCode() = Failure(y).GetHashCode() when x = y``() =
  check "" (fun (x, y) ->
    if x = y then
      (Result.Failure(x).GetHashCode() = Result.Failure(y).GetHashCode())
    else
      true)