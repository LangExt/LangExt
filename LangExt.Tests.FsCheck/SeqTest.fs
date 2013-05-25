module SeqTest

#nowarn "25"

open System
open NUnit.Framework
open FsCheck
open FsCheck.NUnit

// =============================================================================
// テスト用のユーティリティ関数等の定義
// =============================================================================

// F#のSeqと混ざってしまうので用意
type LangExtSeq = LangExt.Seq
type UnsafeSeq = LangExt.Unsafe.SeqUnsafe

// いちいちCreateするのは面倒なので用意
let intSeq (xs: int[]) = LangExtSeq.Create(xs)
let longSeq (xs: int64[]) = LangExtSeq.Create(xs)
let strSeq (xs: string[]) = LangExtSeq.Create(xs)
let emptySeq<'a> = LangExtSeq.Empty<'a>()
let intIntSeq (xs: int[]) = LangExtSeq.Create(xs |> Array.map (fun x -> (x, x)))

// 2つのシーケンスを比較するtester
let eq xs ys =
  let xs1 = List.ofSeq xs
  let ys1 = List.ofSeq ys
  xs1 = ys1

// 2つの「シーケンスのタプル」を比較するtester
let bothEq (a1, b1) (a2, b2) = eq a1 a2 && eq b1 b2

// LangExt側のOption生成簡略化
let some x = LangExt.Option.Some(x)
let none () = LangExt.Option<_>.None
// Result生成簡略化
let success x = LangExt.Result.Success(x).CastFailure<_>()
let failure x = LangExt.Result.Failure(x).Cast<_>()

// F#側のOptionをLangExt側のOptionに
let convOpt = function Some x -> some x | None -> none()

// テストで使う述語関数
let even x = x % 2 = 0
let nat x = x >= 0
let empty xs = Array.isEmpty xs
let notEmpty xs = not (Array.isEmpty xs)

// ヘルパー関数
let pred x = x - 1

// xをactualerに渡した結果とexpectederに渡した結果をtesterに渡し、
// trueになればtrueを、falseになればその時の詳細を表示してfalseを返す、
// ヘルパー関数
let testBy x actualer tester expecteder =
  let actual = actualer x
  let expected = expecteder x
  if tester actual expected then true
  else
    printfn "data: %A" x
    printfn "expected: %A" expected
    printfn "but: %A" actual
    false

// テストしたい性質をactualerとしてテストする
let test actualer tester expecteder =
  check "" (fun x -> testBy x actualer tester expecteder)

// データがcondを満たすときのみテストを実行する版のtest
let testIf cond actualer tester expecteder =
  check "" (fun x -> cond x ==> (lazy testBy x actualer tester expecteder))

// データがcondを満たすときのみ例外を投げることをテストする
let throwIf cond (exnT: System.Type) f =
  check "" (fun x ->
    cond x ==>
      (lazy
        try
          let res = f x
          printfn "data: %A" x
          printfn "expected: throw %s" (exnT.Name)
          printfn "but: return %A" res
          false
        with
        | e when e.GetType() = exnT -> true
        | e ->
            printfn "data: %A" x
            printfn "expected: throw %s" (exnT.Name)
            printfn "but: throw %s" (e.GetType().Name)
            printfn "%A" e
            false))

// =============================================================================
// テスト本体
// =============================================================================

[<Test>]
let ``LangExtSeq.Create<int>(xs) eq xs``() =
  test (fun (xs: int[]) -> LangExtSeq.Create(xs)) eq (Seq.ofArray)

[<Test>]
let ``LangExtSeq.Create<string>(xs) eq xs``() =
  test (fun (xs: string[]) -> LangExtSeq.Create(xs)) eq (Seq.ofArray)

[<Test>]
let ``Create.Seq eq LangExtSeq.Create``() =
  test (fun (xs: int[]) -> LangExt.Create.Seq(xs)) eq (intSeq)

[<Test>]
let ``LangExtSeq.InitInfinite(fun i -> i) eq Seq.initInfinite id``() =
  testIf nat
    (fun n -> LangExtSeq.InitInfinite (fun i -> i) |> Seq.take n) // LangExt側はFuncを要求するのでラムダ式が必須
      eq (fun n -> Seq.initInfinite id |> Seq.take n)

[<Test>]
let ``LangExtSeq.InitInfinite(fun i -> string i) eq Seq.initInfinite string``() =
  testIf nat
    (fun n -> LangExtSeq.InitInfinite (fun i -> string i) |> Seq.take n) // LangExt側はFuncを要求するのでラムダ式が必須
      eq (fun n -> Seq.initInfinite string |> Seq.take n)

[<Test>]
let ``LangExtSeq.Init(m, fun i -> i) eq Seq.init m id``() =
  testIf nat
    (fun n -> LangExtSeq.Init(n, fun i -> i)) eq (fun n -> Seq.init n id) // LangExt側はFuncを要求するのでラムダ式が必須

[<Test>]
let ``LangExtSeq.Init(m, fun i -> string i) eq Seq.init m string``() =
  testIf nat
    (fun n -> LangExtSeq.Init(n, fun i -> string i)) eq (fun n -> Seq.init n string) // LangExt側はFuncを要求するのでラムダ式が必須

[<Test>]
let ``LangExtSeq.Init(negativeNum, fun i -> i) throws ArgumentOutOfRangeException``() =
  throwIf (not << nat) (typeof<ArgumentOutOfRangeException>)
    (fun n -> LangExtSeq.Init(n, fun i -> i))

[<Test>]
let ``LangExtSeq.RepeatInfinite(42) eq Seq.initInfinite (fun _ -> 42)``() =
  testIf nat
    (fun n -> LangExtSeq.RepeatInfinite(42) |> Seq.take n) eq (fun n -> Seq.initInfinite (fun _ -> 42) |> Seq.take n)

[<Test>]
let ``LangExtSeq.Repeat(n, 42) eq Seq.init n (fun _ -> 42)``() =
  testIf nat
    (fun n -> LangExtSeq.Repeat(n, 42)) eq (fun n -> Seq.init n (fun _ -> 42))

[<Test>]
let ``LangExtSeq.Repeat(negativeNum, 42) throws ArgumentOutOfRangeException``() =
  throwIf (not << nat) (typeof<ArgumentOutOfRangeException>)
    (fun n -> LangExtSeq.Repeat(n, 42))

[<Test>]
let ``LangExtSeq.Singleton n eq [n]``() =
  test (LangExtSeq.Singleton) eq (fun n -> [n])

[<Test>]
let ``LangExtSeq.Unfold eq Seq.unfold``() =
  test (fun n -> LangExtSeq.Unfold(n, fun x -> if x < 0 then none() else some (x, x - 1)))
    eq (Seq.unfold (fun x -> if x < 0 then None else Some (x, x - 1)))

[<Test>]
let ``LangExtSeq.Len eq Seq.length``() =
  test (intSeq >> LangExtSeq.Len) (=) (Seq.length)

[<Test>]
let ``LangExtSeq.LongLen eq Seq.length``() =
  test (intSeq >> LangExtSeq.LongLen) (=) (Seq.length >> int64)

[<Test>]
let ``LangExtSeq.Count eq (Seq.filter >> Seq.length)``() =
  test (fun xs -> LangExtSeq.Count(intSeq xs, fun x -> even x)) (=) (Seq.filter even >> Seq.length)

[<Test>]
let ``LangExtSeq.LongCount eq (Seq.filter >> Seq.length)``() =
  test (fun xs -> LangExtSeq.LongCount(intSeq xs, fun x -> even x)) (=) (Seq.filter even >> Seq.length >> int64)

[<Test>]
let ``LangExtSeq.Sum eq Seq.sum``() =
  test (intSeq >> LangExtSeq.Sum) (=) (Seq.sum)

[<Test>]
let ``LangExtSeq.LongSum seq Seq.sum``() =
  test (longSeq >> LangExtSeq.LongSum) (=) (Seq.sum)

[<Test>]
let ``LangExtSeq.Sum(xs, SumStrategy.String) eq String.concat ""``() =
  test (strSeq >> (fun xs -> LangExtSeq.Sum(xs, LangExt.SumStrategy.String))) (=) (String.concat "")

let toStrSeq (xs: int[]) = LangExtSeq.Create(Array.map string xs)

[<Test>]
let ``LangExtSeq.SumBy eq Seq.sumBy``() =
  test (fun xs -> LangExtSeq.SumBy(toStrSeq xs, fun s -> int s)) (=) (Seq.sumBy int) // LangExt側はFuncを要求するのでラムダ式が必須

[<Test>]
let ``LangExtSeq.LongSumBy eq Seq.sumBy``() =
  test (fun xs -> LangExtSeq.LongSumBy(toStrSeq xs, fun s -> int64 s)) (=) (Seq.sumBy int64) // LangExt側はFuncを要求するのでラムダ式が必須

[<Test>]
let ``LangExtSeq.SumBy(xs, SumStrategy.String) eq String.concat ""``() =
  test (fun xs -> LangExtSeq.SumBy(intSeq xs, (fun x -> string x), LangExt.SumStrategy.String)) // LangExt側はFuncを要求するのでラムダ式が必須
    (=) (Array.map string >> String.concat "")

[<Test>]
let ``LangExtSeq.Max eq Seq.max``() =
  testIf notEmpty (intSeq >> UnsafeSeq.Max) (=) (Seq.max)

[<Test; ExpectedException(typeof<InvalidOperationException>)>]
let ``LangExtSeq.Max(emptySeq) throws InvalidOperationException``() =
  UnsafeSeq.Max(emptySeq<int>) |> ignore
  Assert.Fail();

[<Test>]
let ``LangExtSeq.TryMax`` () =
  test (intSeq >> LangExtSeq.TryMax)
    (=) (fun xs -> if empty xs then none() else some(Seq.max xs))

[<Test>]
let ``LangExtSeq.MaxWith<T>``() =
  testIf notEmpty
    (fun strs -> UnsafeSeq.MaxWith(strSeq strs, fun a b -> a.Length - b.Length)) (=) (Seq.maxBy String.length)

[<Test; ExpectedException(typeof<InvalidOperationException>)>]
let ``LangExtSeq.MaxWith<T>(emptySeq, f) throws InvalidOperationException``() =
  UnsafeSeq.MaxWith(emptySeq<string>, fun a b -> a.Length - b.Length) |> ignore
  Assert.Fail();

[<Test>]
let ``LangExtSeq.TryMaxWith<T>``() =
  test (fun strs -> LangExtSeq.TryMaxWith(strSeq strs, fun a b -> a.Length - b.Length))
    (=) (fun xs -> if empty xs then none() else some(Seq.maxBy String.length xs))

[<Test>]
let ``LangExtSeq.MaxBy``() =
  testIf notEmpty
    (fun xs -> UnsafeSeq.MaxBy(intSeq xs, fun i -> string i |> String.length)) // LangExt側はFuncを要求するのでラムダ式が必須
      (=) (Seq.maxBy (string >> String.length))

[<Test; ExpectedException(typeof<InvalidOperationException>)>]
let ``LangExtSeq.MaxBy<T>(emptySeq, f) throws InvalidOperationException``() =
  UnsafeSeq.MaxBy(emptySeq<int>, fun i -> string i |> String.length) |> ignore
  Assert.Fail();

[<Test>]
let ``LangExtSeq.TryMaxBy``() =
  test (fun xs -> LangExtSeq.TryMaxBy(intSeq xs, fun i -> string i |> String.length)) // LangExt側はFuncを要求するのでラムダ式が必須
    (=) (fun xs -> if empty xs then none() else some(Seq.maxBy (string >> String.length) xs))

[<Test>]
let ``LangExtSeq.Min eq Seq.min``() =
  testIf notEmpty (intSeq >> UnsafeSeq.Min) (=) (Seq.min)

[<Test; ExpectedException(typeof<InvalidOperationException>)>]
let ``LangExtSeq.Min(emptySeq) throws InvalidOperationException``() =
  UnsafeSeq.Min(emptySeq<int>) |> ignore
  Assert.Fail();

[<Test>]
let ``LangExtSeq.TryMin`` () =
  test (intSeq >> LangExtSeq.TryMin)
    (=) (fun xs -> if empty xs then none() else some(Seq.min xs))

[<Test>]
let ``LangExtSeq.MinWith<T>``() =
  testIf notEmpty
    (fun strs -> UnsafeSeq.MinWith(strSeq strs, fun a b -> a.Length - b.Length)) (=) (Seq.minBy String.length)

[<Test; ExpectedException(typeof<InvalidOperationException>)>]
let ``LangExtSeq.MinWith(emptySeq, f) throws InvalidOperationException``() =
  UnsafeSeq.MinWith(emptySeq<string>, fun a b -> a.Length - b.Length) |> ignore
  Assert.Fail();

[<Test>]
let ``LangExtSeq.TryMinWith<T>``() =
  test (fun strs -> LangExtSeq.TryMinWith(strSeq strs, fun a b -> a.Length - b.Length))
    (=) (fun xs -> if empty xs then none() else some(Seq.minBy String.length xs))

[<Test>]
let ``LangExtSeq.MinBy``() =
  testIf notEmpty
    (fun xs -> UnsafeSeq.MinBy(intSeq xs, fun i -> string i |> String.length)) // LangExt側はFuncを要求するのでラムダ式が必須
      (=) (Seq.minBy (string >> String.length))

[<Test; ExpectedException(typeof<InvalidOperationException>)>]
let ``LangExtSeq.MinBy(emptySeq, f) throws InvalidOperationException``() =
  UnsafeSeq.MinBy(emptySeq<int>, fun i -> string i |> String.length) |> ignore
  Assert.Fail();

[<Test>]
let ``LangExtSeq.TryMinBy``() =
  test (fun xs -> LangExtSeq.TryMinBy(intSeq xs, fun i -> string i |> String.length)) // LangExt側はFuncを要求するのでラムダ式が必須
    (=) (fun xs -> if empty xs then none() else some(Seq.minBy (string >> String.length) xs))

[<Test>]
let ``LangExtSeq.Fold eq Seq.fold``() =
  test (fun xs -> LangExtSeq.Fold(intSeq xs, 1, fun acc x -> acc * x)) (=) (Seq.fold (*) 1) // LangExt側はFuncを要求するのでラムダ式が必須

[<Test>]
let ``LangExtSeq.Reduce eq Seq.reduce``() =
  testIf notEmpty
    (fun xs -> UnsafeSeq.Reduce(strSeq xs, fun acc x -> acc + ", " + x))
      (=) (Seq.reduce (fun acc x -> acc + ", " + x))

[<Test; ExpectedException(typeof<InvalidOperationException>)>]
let ``LangExtSeq.Reduce(emptySeq, f) throws InvalidOperationException``() =
  UnsafeSeq.Reduce(emptySeq<string>, fun acc x -> acc + ", " + x) |> ignore
  Assert.Fail();

[<Test>]
let ``LangExtSeq.TryReduce``() =
  test (fun xs -> LangExtSeq.TryReduce(strSeq xs, fun acc x -> acc + ", " + x))
    (=) (fun xs -> if empty xs then none() else some(Seq.reduce (fun acc x -> acc + ", " + x) xs))

[<Test>]
let ``LangExtSeq.FoldBack eq Array.foldBack``() =
  test (fun xs -> LangExtSeq.FoldBack(intSeq xs, 0, fun x acc -> x - acc)) // LangExt側はFuncを要求するのでラムダ式が必須
    (=) (fun xs -> Array.foldBack (-) xs 0)

[<Test>]
let ``LangExtSeq.ReduceBack eq Array.reduceBack``() =
  testIf notEmpty
    (fun xs -> UnsafeSeq.ReduceBack(intSeq xs, fun x acc -> x - acc)) (=) (Array.reduceBack (-)) // LangExt側はFuncを要求するのでラムダ式が必須

[<Test; ExpectedException(typeof<InvalidOperationException>)>]
let ``LangExtSeq.ReduceBack(emptySeq, f) throws InvalidOperationException``() =
  UnsafeSeq.ReduceBack(emptySeq<int>, fun x acc -> x - acc) |> ignore
  Assert.Fail()

[<Test>]
let ``LangExtSeq.TryReduceBack``() =
  test (fun xs -> LangExtSeq.TryReduceBack(intSeq xs, fun x acc -> x - acc)) // LangExt側はFuncを要求するのでラムダ式が必須
    (=) (fun xs -> if empty xs then none() else some(Array.reduceBack (-) xs))

[<Test>]
let ``LangExtSeq.Scan eq Seq.scan``() =
  test (fun xs -> LangExtSeq.Scan(intSeq xs, 0, fun acc x -> acc + x)) eq (Seq.scan (+) 0) // LangExt側はFuncを要求するのでラムダ式が必須

[<Test>]
let ``LangExtSeq.ScanBack eq Array.scanBack``() =
  test (fun xs -> LangExtSeq.ScanBack(intSeq xs, 0, fun x acc -> x - acc)) // LangExt側はFuncを要求するのでラムダ式が必須
    eq (fun xs -> Array.scanBack (-) xs 0)

[<Test>]
let ``LangExtSeq.Scan1``() =
  test (fun xs -> LangExtSeq.Scan1(intSeq xs, fun acc x -> acc + x)) // LangExt側はFuncを要求するのでラムダ式が必須
    eq (fun xs -> if Array.isEmpty xs then Seq.empty else Seq.scan (+) xs.[0] xs.[1..])

[<Test>]
let ``LangExtSeq.ScanBack1``() =
  test (fun xs -> LangExtSeq.ScanBack1(intSeq xs, fun x acc -> x - acc)) // LangExt側はFuncを要求するのでラムダ式が必須
    eq (fun xs -> if Array.isEmpty xs then [||] else Array.scanBack (-) xs.[0..xs.Length-2] xs.[xs.Length-1])

[<Test>]
let ``LangExtSeq.Find eq Seq.find``() =
  testIf (fun (xs, x) -> xs |> Array.exists ((=)x))
    (fun (xs, x) -> UnsafeSeq.Find(intSeq xs, fun i -> i = x)) // LangExt側はFuncを要求するのでラムダ式が必須
      (=) (fun (xs, x) -> Seq.find ((=)x) xs)

[<Test; ExpectedException(typeof<InvalidOperationException>)>]
let ``LangExtSeq.Find(emptySeq, f) throws InvalidOperationException``() =
  UnsafeSeq.Find(emptySeq<int>, fun i -> i = 42) |> ignore
  Assert.Fail()

[<Test>]
let ``LangExtSeq.TryFind eq Seq.tryFind``() =
  test (fun (xs, x) -> LangExtSeq.TryFind(intSeq xs, fun i -> i = x)) // LangExt側はFuncを要求するのでラムダ式が必須
    (=) (fun (xs, x) -> Seq.tryFind ((=)x) xs |> convOpt)

[<Test>]
let ``LangExtSeq.Pick eq Seq.pick``() =
  testIf (Array.exists even)
    (fun xs -> UnsafeSeq.Pick(intSeq xs, fun x -> if even x then some(string x) else none()))
      (=) (Seq.pick (fun x -> if even x then Some (string x) else None))

[<Test; ExpectedException(typeof<InvalidOperationException>)>]
let ``LangExtSeq.Pick(emptySeq, f) throws InvalidOperationException``() =
  UnsafeSeq.Pick(emptySeq<int>, fun x -> if even x then some(string x) else none()) |> ignore
  Assert.Fail()

[<Test>]
let ``LangExtSeq.TryPick eq Seq.tryPick``() =
  test (fun xs -> LangExtSeq.TryPick(intSeq xs, fun x -> if even x then some(string x) else none()))
    (=) (Seq.tryPick (fun x -> if even x then Some (string x) else None) >> convOpt)

[<Test>]
let ``LangExtSeq.IsEmpty eq Seq.isEmpty``() =
  test (intSeq >> LangExtSeq.IsEmpty) (=) (Seq.isEmpty)

[<Test>]
let ``LangExtSeq.IsNotEmpty eq Seq.isEmpty >> not``() =
  test (intSeq >> LangExtSeq.IsNotEmpty) (=) (Seq.isEmpty >> not)

[<Test>]
let ``LangExtSeq.Forall eq Seq.forall``() =
  test (fun xs -> LangExtSeq.Forall(intSeq xs, fun x -> even x)) (=) (Seq.forall even) // LangExt側はFuncを要求するのでラムダ式が必須

[<Test>]
let ``LangExtSeq.Exists eq Seq.exists``() =
  test (fun xs -> LangExtSeq.Exists(intSeq xs, fun x -> even x)) (=) (Seq.exists even) // LangExt側はFuncを要求するのでラムダ式が必須

[<Test>]
let ``LangExtSeq.Filter eq Seq.filter``() =
  test (fun xs -> LangExtSeq.Filter(intSeq xs, fun x -> even x)) eq (Seq.filter even) // LangExt側はFuncを要求するのでラムダ式が必須
      
let (|Even|_|) (x, i) = if even (x + i) then Some x else None

[<Test>]
let ``LangExtSeq.FilterWithIndex``() =
  test (fun xs -> LangExtSeq.FilterWithIndex(intSeq xs, fun x i -> even (x + i)))
    eq (fun xs -> Seq.zip xs (Seq.initInfinite id) |> Seq.choose (function Even i -> Some i | _ -> None))

[<Test>]
let ``LangExtSeq.Map eq Seq.map``() =
  test (fun xs -> LangExtSeq.Map(intSeq xs, fun x -> x * 2)) eq (Seq.map ((*)2)) // LangExt側はFuncを要求するのでラムダ式が必須

[<Test>]
let ``LangExtSeq.MapWithIndex eq Seq.mapi``() =
  test (fun xs -> LangExtSeq.MapWithIndex(intSeq xs, fun x i -> (x, i))) eq (Seq.mapi (fun i x -> (x, i)))

[<Test>]
let ``LangExtSeq.Iter eq Seq.iter (Action)``() =
  test (fun xs -> let n = ref 0 in LangExtSeq.Iter(intSeq xs, fun x -> n := !n + x); n)
    (=) (fun xs -> let n = ref 0 in Seq.iter (fun x -> n := !n + x) xs; n)

[<Test>]
let ``LangExtSeq.Iter eq Seq.iter (Func)``() =
  test (fun xs -> let n = ref 0 in ignore <| LangExtSeq.Iter(intSeq xs, fun x -> n := !n + x; LangExt.Unit.``_``); n)
    (=) (fun xs -> let n = ref 0 in Seq.iter (fun x -> n := !n + x) xs; n)

[<Test>]
let ``LangExtSeq.IterWithIndex eq Seq.iteri (Action)``() =
  test (fun xs -> let n = ref 0 in LangExtSeq.IterWithIndex(intSeq xs, fun x i -> n := !n + x + i); n)
    (=) (fun xs -> let n = ref 0 in Seq.iteri (fun i x -> n := !n + x + i) xs; n)

[<Test>]
let ``LangExtSeq.IterWithIndex eq Seq.iteri (Func)``() =
  test (fun xs -> let n = ref 0 in ignore <| LangExtSeq.IterWithIndex(intSeq xs, fun x i -> n := !n + x + i; LangExt.Unit.``_``); n)
    (=) (fun xs -> let n = ref 0 in Seq.iteri (fun i x -> n := !n + x + i) xs; n)

[<Test>]
let ``LangExtSeq.Bind eq Seq.collect``() =
  test (fun xs -> LangExtSeq.Bind(intSeq xs, fun x -> intSeq (Array.create (min (max x 0) 10) x)))
    eq (Seq.collect (fun x -> Seq.init (min (max x 0) 10) (fun _ -> x)))

[<Test>]
let ``LangExtSeq.BindWithIndex``() =
  test (fun xs -> LangExtSeq.BindWithIndex(intSeq xs, fun x i -> intSeq (Array.create (min (max (x + i) 0) 10) (x + i))))
    eq (Seq.mapi (fun i x -> (x, i)) >> Seq.collect (fun (x, i) -> Seq.init (min (max (x + i) 0) 10) (fun _ -> x + i)))

[<Test>]
let ``LangExtSeq.Collect eq Seq.collect``() =
  test (fun xs -> LangExtSeq.Collect(intSeq xs, fun x -> intSeq (Array.create (min (max x 0) 10) x)))
    eq (Seq.collect (fun x -> Seq.init (min (max x 0) 10) (fun _ -> x)))

[<Test>]
let ``LangExtSeq.Choose eq Seq.choose``() =
  test (fun xs -> LangExtSeq.Choose(intSeq xs, fun x -> if even x then some(x * 2) else none()))
    eq (Seq.choose (fun x -> if even x then Some (x * 2) else None))

[<Test>]
let ``LangExtSeq.ChooseWithIndex``() =
  test (fun xs -> LangExtSeq.ChooseWithIndex(intSeq xs, fun x i -> if even x then some(x * 2 + i) else none()))
    eq (Seq.mapi (fun i x -> (x, i)) >> Seq.choose (fun (x, i) -> if even x then Some (x * 2 + i) else None))

[<Test>]
let ``LangExtSeq.Skip eq Seq.skip``() =
  testIf (fun (xs, n) -> nat n && Seq.length xs >= n)
    (fun (xs, n) -> LangExtSeq.Skip(intSeq xs, n)) eq (fun (xs, n) -> Seq.skip n xs)

// nat nが成り立たない場合は入力がそのまま返る
[<Test>]
let ``LangExtSeq.Skip(seq, negativeNum) returns seq``() =
  testIf (fun (xs, n) -> n < 0) 
    (fun (xs, n) -> LangExtSeq.Skip(intSeq xs, n)) eq fst

// Seq.length xs >= nが成り立たない場合は空のシーケンスが返る
[<Test>]
let ``LangExtSeq.Skip(seq, largerThanSeqLen) returns empty seq``() =
  testIf (fun (xs, n) -> Seq.length xs < n) 
    (fun (xs, n) -> LangExtSeq.Skip(intSeq xs, n)) eq (fun _ -> [])

[<Test>]
let ``LangExtSeq.Take eq Seq.take``() =
  testIf (fun (xs, n) -> nat n && Seq.length xs >= n)
    (fun (xs, n) -> LangExtSeq.Take(intSeq xs, n)) eq (fun (xs, n) -> Seq.take n xs)

// nat nが成り立たない場合は空のシーケンスが返る
[<Test>]
let ``LangExtSeq.Take(seq, negativeNum) returns empty seq``() =
  testIf (fun (xs, n) -> n < 0) 
    (fun (xs, n) -> LangExtSeq.Take(intSeq xs, n)) eq (fun _ -> [])

// Seq.length xs >= nが成り立たない場合は入力がそのまま返る
[<Test>]
let ``LangExtSeq.Take(seq, largerThanSeqLen) returns seq``() =
  testIf (fun (xs, n) -> Seq.length xs < n) 
    (fun (xs, n) -> LangExtSeq.Take(intSeq xs, n)) eq fst

[<Test>]
let ``LangExtSeq.SkipWhile eq Seq.skipWhile``() =
  test (fun xs -> LangExtSeq.SkipWhile(intSeq xs, fun x -> even x))
    eq (Seq.skipWhile even)

[<Test>]
let ``LangExtSeq.SkipWhileWithIndex``() =
  test (fun xs -> LangExtSeq.SkipWhileWithIndex(intSeq xs, fun x i -> even (x + i)))
    eq (Seq.mapi (fun i x -> (x, i)) >> Seq.skipWhile (fun (x, i) -> even (x + i)) >> Seq.map fst)

[<Test>]
let ``LangExtSeq.TakeWhile eq Seq.takeWhile``() =
  test (fun xs -> LangExtSeq.TakeWhile(intSeq xs, fun x -> even x))
    eq (Seq.takeWhile even)

[<Test>]
let ``LangExtSeq.TakeWhileWithIndex``() =
  test (fun xs -> LangExtSeq.TakeWhileWithIndex(intSeq xs, fun x i -> even (x + i)))
    eq (Seq.mapi (fun i x -> (x, i)) >> Seq.takeWhile (fun (x, i) -> even (x + i)) >> Seq.map fst)

[<Test>]
let ``LangExtSeq.Partition eq Seq.partition``() =
  test (fun xs -> LangExtSeq.Partition(intSeq xs, fun x -> even x))
    (fun (a1, b1) (a2, b2) -> eq a1 a2 && eq b1 b2)
    (Array.partition even >> fun (a, b) -> (Seq.ofArray a, Seq.ofArray b))

[<Test>]
let ``LangExtSeq.SplitAt``() =
  testIf (fun (xs, n) -> nat n && Seq.length xs >= n) (fun (xs, n) -> LangExtSeq.SplitAt(intSeq xs, n))
    bothEq (fun (xs, n) -> (Seq.take n xs), (Seq.skip n xs))

[<Test>]
let ``LangExtSeq.SplitAt (short)``() =
  testIf (fun (xs, n) -> Seq.length xs < n) (fun (xs, n) -> LangExtSeq.SplitAt(intSeq xs, n))
    bothEq (fun (xs, n) -> xs, [])

[<Test>]
let ``LangExtSeq.Span``() =
  test (fun xs -> LangExtSeq.Span(intSeq xs, fun x -> even x))
    bothEq (fun xs -> ((Seq.takeWhile even xs), (Seq.skipWhile even xs)))

[<Test>]
let ``LangExtSeq.Break``() =
  test (fun xs -> LangExtSeq.Break(intSeq xs, fun x -> even x))
    bothEq (fun xs -> ((Seq.takeWhile (not << even) xs), (Seq.skipWhile (not << even) xs)))

[<Test>]
let ``LangExtSeq.Windowed eq Seq.windowed``() =
  testIf (snd >> pred >> nat) (fun (xs, n) -> LangExtSeq.Windowed(intSeq xs, n))
    eq (fun (xs, n) -> Seq.windowed n xs)

[<Test>]
let ``LangExtSeq.Windowed(seq, zeroOrNeg) throws ArgumentOutOfRangeException``() =
  throwIf (snd >> pred >> nat >> not) (typeof<ArgumentOutOfRangeException>)
    (fun (xs, n) -> LangExtSeq.Windowed(intSeq xs, n))

[<Test>]
let ``LangExtSeq.Windowed3(seq) eq LangExtSeq.Windowed(seq, 3)``() =
  test (fun xs -> LangExtSeq.Windowed3(intSeq xs))
    eq (fun xs -> LangExtSeq.Windowed(intSeq xs, 3) |> Seq.map (fun [|a;b;c|] -> (a, b, c)))

[<Test>]
let ``LangExtSeq.Pairwise eq Seq.pairwise``() =
  test (fun xs -> LangExtSeq.Pairwise(intSeq xs)) eq Seq.pairwise

[<Test>]
let ``LangExtSeq.Sort eq Seq.sort``() =
  test (intSeq >> LangExtSeq.Sort) eq Seq.sort

[<Test>]
let ``LangExtSeq.RevSort eq (Seq.sort >> Seq.toList >> List.rev``() =
  test (intSeq >> LangExtSeq.RevSort) eq (Seq.sort >> Seq.toList >> List.rev)

[<Test>]
let ``LangExtSeq.SortBy eq Seq.sortBy``() =
  test (fun xs -> LangExtSeq.SortBy(intSeq xs, fun x -> if even x then -x else x))
    eq (Seq.sortBy (fun x -> if even x then -x else x))

[<Test>]
let ``ThenBy``() =
  test (fun xs -> LangExt.OrderedSeq.ThenBy(LangExtSeq.SortBy(intIntSeq xs, fun (x, _) -> x), fun (_, y) -> y))
    eq (fun xs -> LangExtSeq.Sort(intIntSeq xs))

[<Test>]
let ``RevThenBy``() =
  test (fun xs -> LangExt.OrderedSeq.RevThenBy(LangExtSeq.RevSortBy(intIntSeq xs, fun (x, _) -> x), fun (_, y) -> y))
    eq (fun xs -> LangExtSeq.RevSort(intIntSeq xs))

[<Test>]
let ``LangExtSeq.RevSortBy eq (Seq.sortBy >> Seq.toList >> List.rev``() =
  test (fun xs -> LangExtSeq.RevSortBy(intSeq xs, fun x -> if even x then -x else x))
    eq (Seq.sortBy (fun x -> if even x then -x else x) >> Seq.toList >> List.rev)

[<Test>]
let ``LangExtSeq.ToString eq String.concat``() =
  test (fun xs -> LangExtSeq.ToString(strSeq xs, ", ")) (=) (String.concat ", ")

[<Test>]
let ``LangExtSeq.ToSting(open, sep, close) eq (String.concat sep >> fun s -> open + s + close)``() =
  test (fun xs -> LangExtSeq.ToString(strSeq xs, "[", ", ", "]"))
    (=) (String.concat ", " >> fun s -> "[" + s + "]")

[<Test>]
let ``LangExtSeq.ToArray eq Seq.toArray``() =
  test (intSeq >> LangExtSeq.ToArray) (=) Seq.toArray

[<Test>]
let ``LangExtSeq.Get eq Seq.nth``() =
  testIf (fun (xs, n) -> nat n && (Seq.length xs) > n)
    (fun (xs, n) -> UnsafeSeq.Get(intSeq xs, n)) (=) (fun (xs, n) -> Seq.nth n xs)

[<Test>]
let ``LangExtSeq.Get throws InvalidOperationException when len xs <= n``() =
  throwIf (fun (xs, n) -> Seq.length xs <= n) (typeof<ArgumentOutOfRangeException>)
    (fun (xs, n) -> UnsafeSeq.Get(intSeq xs, n))

[<Test>]
let ``LangExtSeq.TryGet``() =
  test (fun (xs, n) -> LangExtSeq.TryGet(intSeq xs, n))
    (=) (fun (xs, n) -> try some(Seq.nth n xs) with _ -> none())

[<Test>]
let ``LangExtSeq.Append eq Seq.append``() =
  test (fun (xs, ys) -> LangExtSeq.Append(intSeq xs, intSeq ys))
    eq (fun (xs, ys) -> Seq.append xs ys)

[<Test>]
let ``LangExtSeq.Concat eq Seq.concat``() =
  testIf (snd >> nat) (fun (xs, n) -> LangExtSeq.Concat(LangExtSeq.Repeat(n, intSeq xs)))
    eq (fun (xs, n) -> Seq.init n (fun _ -> xs) |> Seq.concat)

[<Test>]
let ``not cache``() =
  check "" (fun xs ->
    notEmpty xs ==>
      let n = ref 0
      let seq = LangExtSeq.Map(intSeq xs, fun x -> incr n; x)
      seq |> Seq.iter ignore
      seq |> Seq.iter ignore
      !n > (Seq.length seq))

[<Test>]
let ``LangExtSeq.Cache``() =
  check "" (fun xs ->
    let n = ref 0
    let seq = LangExtSeq.Map(intSeq xs, fun x -> incr n; x)
    let cached = LangExtSeq.Cache(seq)
    cached |> Seq.iter ignore
    cached |> Seq.iter ignore
    !n = (Seq.length cached))

[<Test>]
let ``LangExtSeq.Reverse eq Array.rev``() =
  test (intSeq >> LangExtSeq.Reverse) eq Array.rev

[<Test>]
let ``LangExtSeq.Sequence`` () =
  let optSeq xs = LangExtSeq.Map(intSeq xs, fun x -> if even x then some(x) else none())
  let optEq a b =
    let conv (x: LangExt.Option<LangExt.ISeq<_>>) =
      if x.IsSome then Some(x.GetOrElse(fun () -> failwith ""))
      else None
    match (conv a), (conv b) with
    | Some a, Some b -> eq a b
    | None, None -> true
    | _ -> false
  test (fun xs -> LangExtSeq.Sequence(optSeq xs))
    optEq (fun xs -> if Seq.forall even xs then some(intSeq xs) else none())

[<Test>]
let ``LangExtSeq.SequenceSuccess`` () =
  let resSeq xs = LangExtSeq.Map(intSeq xs, fun x -> if even x then success(x) else failure(x))
  let resEq a b =
    let conv (x: LangExt.Result<LangExt.ISeq<_>, int>) =
      if x.IsSuccess then Some(x.GetOrElse(fun () -> failwith ""))
      else None
    match (conv a), (conv b) with
    | Some a, Some b -> eq a b
    | None, None -> true
    | _ -> false
  test (fun xs -> LangExtSeq.SequenceSuccess(resSeq xs))
    resEq (fun xs -> if Seq.forall even xs then success(intSeq xs) else failure(-1))

[<Test>]
let ``LangExtSeq.SequenceFailure`` () =
  let resSeq xs = LangExtSeq.Map(intSeq xs, fun x -> if even x then success(x) else failure(x))
  let resEq a b =
    let conv (x: LangExt.Result<int, LangExt.ISeq<_>>) =
      if x.IsFailure then Some(x.GetFailureOrElse(fun () -> failwith ""))
      else None
    match (conv a), (conv b) with
    | Some a, Some b -> eq a b
    | None, None -> true
    | _ -> false
  test (fun xs -> LangExtSeq.SequenceFailure(resSeq xs))
    resEq (fun xs -> if Seq.forall (not << even) xs then failure(intSeq xs) else success(-1))

[<Test>]
let ``LangExtSeq.OnlySome eq (Seq.choose conv)``() =
  let conv (x: LangExt.Option<_>) =
    if x.IsSome then Some(x.GetOrElse(fun () -> failwith ""))
    else None
  let optSeq xs = LangExtSeq.Map(intSeq xs, fun x -> if even x then some(x) else none())
  test (optSeq >> LangExtSeq.OnlySome) eq (optSeq >> (Seq.choose conv))

[<Test>]
let ``LangExtSeq.OnlySuccess eq (Seq.choose conv)``() =
  let conv (x: LangExt.Result<_, _>) =
    if x.IsSuccess then Some(x.GetOrElse(fun () -> failwith ""))
    else None
  let resSeq xs = LangExtSeq.Map(intSeq xs, fun x -> if even x then success(x) else failure(x))
  test (resSeq >> LangExtSeq.OnlySuccess) eq (resSeq >> (Seq.choose conv))

[<Test>]
let ``LangExtSeq.OnlyFailure eq (Seq.choose conv)``() =
  let conv (x: LangExt.Result<_, _>) =
    if x.IsFailure then Some(x.GetFailureOrElse(fun () -> failwith ""))
    else None
  let resSeq xs = LangExtSeq.Map(intSeq xs, fun x -> if even x then success(x) else failure(x))
  test (resSeq >> LangExtSeq.OnlyFailure) eq (resSeq >> (Seq.choose conv))

[<Test>]
let ``LangExtSeq.MapOption (class) eq (Seq.map (function null -> none() | x -> some(x)))``() =
  let strSeq xs = LangExtSeq.Map(strSeq xs, fun x -> if x.Length = 1 then null else x)
  test (strSeq >> LangExtSeq.MapOption) eq (strSeq >> (Seq.map (function null -> none() | x -> some(x))))

open Microsoft.FSharp.Linq
let (|Null|NotNull|) (x: Nullable<_>) =
  if x.HasValue then NotNull x.Value else Null

[<Test>]
let ``LangExtSeq.MapOption (nullable struct) eq (Seq.Map (function Null -> none() | NotNull x -> some(x)))``() =
  let nullableIntSeq xs = LangExtSeq.Map(intSeq xs, fun x -> if nat x then Nullable<int>() else Nullable(x))
  test (nullableIntSeq >> LangExtSeq.MapOption)
    eq (nullableIntSeq >> (Seq.map (function Null -> none() | NotNull x -> some(x))))

[<Test>]
let ``LangExtSeq.MapResult (class) eq (Seq.map (function null -> failure(()) | x -> success(x)))``() =
  let strSeq xs = LangExtSeq.Map(strSeq xs, fun x -> if x.Length = 1 then null else x)
  test (strSeq >> LangExtSeq.MapResult) eq (strSeq >> (Seq.map (function null -> failure(LangExt.Unit.``_``) | x -> success(x))))

[<Test>]
let ``LangExtSeq.MapResult (nullable struct) eq (Seq.Map (function Null -> failure(()) | NotNull x -> success(x)))``() =
  let nullableIntSeq xs = LangExtSeq.Map(intSeq xs, fun x -> if nat x then Nullable<int>() else Nullable(x))
  test (nullableIntSeq >> LangExtSeq.MapResult)
    eq (nullableIntSeq >> (Seq.map (function Null -> failure(LangExt.Unit.``_``) | NotNull x -> success(x))))

[<Test>]
let ``LangExtSeq.Zip eq Seq.zip``() =
  test (fun (xs, ys) -> LangExtSeq.Zip(intSeq xs, strSeq ys)) eq (fun (xs, ys) -> Seq.zip xs ys)

[<Test>]
let ``LangExtSeq.ZipWith``() =
  test (fun (xs, ys) -> LangExtSeq.ZipWith(intSeq xs, strSeq ys, fun x y -> string x + y))
    eq (fun (xs, ys) -> Seq.zip xs ys |> Seq.map (fun (x, y) -> string x + y))

[<Test>]
let ``LangExtSeq.Unzip``() =
  test (fun xs -> LangExtSeq.Unzip(LangExtSeq.Zip(intSeq xs, intSeq xs)) |> fst) eq id

[<Test>]
let ``LangExtSeq.WithIndex``() =
  test (fun xs -> LangExtSeq.WithIndex(strSeq xs))
    eq (Seq.mapi (fun i x -> (x, i)))