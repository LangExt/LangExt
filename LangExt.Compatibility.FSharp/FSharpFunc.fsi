namespace LangExt.Compatibility.FSharp

open System
open System.Runtime.CompilerServices

/// Funcデリゲートを操作するためのモジュールです。
[<Extension; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module Func =
  /// FuncデリゲートをFSharpFuncに変換します。
  [<Extension; CompiledName "ToFSharpFunc">]
  val toFSharpFunc0: Func<'TResult> -> (unit -> 'TResult)
  /// FuncデリゲートをFSharpFuncに変換します。
  [<Extension; CompiledName "ToFSharpFunc">]
  val toFSharpFunc1: Func<'T1, 'TResult> -> ('T1 -> 'TResult)
  /// FuncデリゲートをFSharpFuncに変換します。
  [<Extension; CompiledName "ToFSharpFunc">]
  val toFSharpFunc2: Func<'T1, 'T2, 'TResult> -> ('T1 -> 'T2 -> 'TResult)
  /// FuncデリゲートをFSharpFuncに変換します。
  [<Extension; CompiledName "ToFSharpFunc">]
  val toFSharpFunc3: Func<'T1, 'T2, 'T3, 'TResult> -> ('T1 -> 'T2 -> 'T3 -> 'TResult)
  /// FuncデリゲートをFSharpFuncに変換します。
  [<Extension; CompiledName "ToFSharpFunc">]
  val toFSharpFunc4: Func<'T1, 'T2, 'T3, 'T4, 'TResult> -> ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'TResult)
  /// FuncデリゲートをFSharpFuncに変換します。
  [<Extension; CompiledName "ToFSharpFunc">]
  val toFSharpFunc5: Func<'T1, 'T2, 'T3, 'T4, 'T5, 'TResult> -> ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'TResult)
  /// FuncデリゲートをFSharpFuncに変換します。
  [<Extension; CompiledName "ToFSharpFunc">]
  val toFSharpFunc6: Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'TResult> -> ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'TResult)
  /// FuncデリゲートをFSharpFuncに変換します。
  [<Extension; CompiledName "ToFSharpFunc">]
  val toFSharpFunc7: Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'TResult> -> ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'TResult)
  /// FuncデリゲートをFSharpFuncに変換します。
  [<Extension; CompiledName "ToFSharpFunc">]
  val toFSharpFunc8: Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'TResult> -> ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'TResult)
  /// FuncデリゲートをFSharpFuncに変換します。
  [<Extension; CompiledName "ToFSharpFunc">]
  val toFSharpFunc9: Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'TResult> -> ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'TResult)
  /// FuncデリゲートをFSharpFuncに変換します。
  [<Extension; CompiledName "ToFSharpFunc">]
  val toFSharpFunc10: Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'TResult> -> ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'TResult)
  /// FuncデリゲートをFSharpFuncに変換します。
  [<Extension; CompiledName "ToFSharpFunc">]
  val toFSharpFunc11: Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'TResult> -> ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'TResult)
  /// FuncデリゲートをFSharpFuncに変換します。
  [<Extension; CompiledName "ToFSharpFunc">]
  val toFSharpFunc12: Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'TResult> -> ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'TResult)
  /// FuncデリゲートをFSharpFuncに変換します。
  [<Extension; CompiledName "ToFSharpFunc">]
  val toFSharpFunc13: Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'TResult> -> ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'T13 -> 'TResult)
  /// FuncデリゲートをFSharpFuncに変換します。
  [<Extension; CompiledName "ToFSharpFunc">]
  val toFSharpFunc14: Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'TResult> -> ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'T13 -> 'T14 -> 'TResult)
  /// FuncデリゲートをFSharpFuncに変換します。
  [<Extension; CompiledName "ToFSharpFunc">]
  val toFSharpFunc15: Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'TResult> -> ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'T13 -> 'T14 -> 'T15 -> 'TResult)
  /// FuncデリゲートをFSharpFuncに変換します。
  [<Extension; CompiledName "ToFSharpFunc">]
  val toFSharpFunc16: Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16, 'TResult> -> ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'T13 -> 'T14 -> 'T15 -> 'T16 -> 'TResult)

/// FSharpFuncを操作するためのモジュールです。
[<Extension; CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module FSharpFunc =
  /// FSharpFuncをFuncデリゲートに変換します。
  [<Extension; CompiledName "ToFunc">]
  val toFunc0: (unit -> 'TResult) -> Func<'TResult>
  /// FSharpFuncをFuncデリゲートに変換します。
  [<Extension; CompiledName "ToFunc">]
  val toFunc1: ('T1 -> 'TResult) -> Func<'T1, 'TResult>
  /// FSharpFuncをFuncデリゲートに変換します。
  [<Extension; CompiledName "ToFunc">]
  val toFunc2: ('T1 -> 'T2 -> 'TResult) -> Func<'T1, 'T2, 'TResult>
  /// FSharpFuncをFuncデリゲートに変換します。
  [<Extension; CompiledName "ToFunc">]
  val toFunc3: ('T1 -> 'T2 -> 'T3 -> 'TResult) -> Func<'T1, 'T2, 'T3, 'TResult>
  /// FSharpFuncをFuncデリゲートに変換します。
  [<Extension; CompiledName "ToFunc">]
  val toFunc4: ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'TResult) -> Func<'T1, 'T2, 'T3, 'T4, 'TResult>
  /// FSharpFuncをFuncデリゲートに変換します。
  [<Extension; CompiledName "ToFunc">]
  val toFunc5: ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'TResult) -> Func<'T1, 'T2, 'T3, 'T4, 'T5, 'TResult>
  /// FSharpFuncをFuncデリゲートに変換します。
  [<Extension; CompiledName "ToFunc">]
  val toFunc6: ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'TResult) -> Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'TResult>
  /// FSharpFuncをFuncデリゲートに変換します。
  [<Extension; CompiledName "ToFunc">]
  val toFunc7: ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'TResult) -> Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'TResult>
  /// FSharpFuncをFuncデリゲートに変換します。
  [<Extension; CompiledName "ToFunc">]
  val toFunc8: ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'TResult) -> Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'TResult>
  /// FSharpFuncをFuncデリゲートに変換します。
  [<Extension; CompiledName "ToFunc">]
  val toFunc9: ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'TResult) -> Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'TResult>
  /// FSharpFuncをFuncデリゲートに変換します。
  [<Extension; CompiledName "ToFunc">]
  val toFunc10: ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'TResult) -> Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'TResult>
  /// FSharpFuncをFuncデリゲートに変換します。
  [<Extension; CompiledName "ToFunc">]
  val toFunc11: ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'TResult) -> Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'TResult>
  /// FSharpFuncをFuncデリゲートに変換します。
  [<Extension; CompiledName "ToFunc">]
  val toFunc12: ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'TResult) -> Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'TResult>
  /// FSharpFuncをFuncデリゲートに変換します。
  [<Extension; CompiledName "ToFunc">]
  val toFunc13: ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'T13 -> 'TResult) -> Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'TResult>
  /// FSharpFuncをFuncデリゲートに変換します。
  [<Extension; CompiledName "ToFunc">]
  val toFunc14: ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'T13 -> 'T14 -> 'TResult) -> Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'TResult>
  /// FSharpFuncをFuncデリゲートに変換します。
  [<Extension; CompiledName "ToFunc">]
  val toFunc15: ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'T13 -> 'T14 -> 'T15 -> 'TResult) -> Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'TResult>
  /// FSharpFuncをFuncデリゲートに変換します。
  [<Extension; CompiledName "ToFunc">]
  val toFunc16: ('T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> 'T7 -> 'T8 -> 'T9 -> 'T10 -> 'T11 -> 'T12 -> 'T13 -> 'T14 -> 'T15 -> 'T16 -> 'TResult) -> Func<'T1, 'T2, 'T3, 'T4, 'T5, 'T6, 'T7, 'T8, 'T9, 'T10, 'T11, 'T12, 'T13, 'T14, 'T15, 'T16, 'TResult>