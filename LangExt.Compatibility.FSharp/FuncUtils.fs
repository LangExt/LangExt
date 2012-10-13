namespace LangExt.Compatibility.FSharp

open System
open System.Runtime.CompilerServices

[<Extension>]
type FuncUtils =
  [<Extension>]
  static member ToFSharpFunc(f: Func<_>) = fun () -> f.Invoke()
  [<Extension>]
  static member ToFSharpFunc(f: Func<_, _>) = fun x1 -> f.Invoke(x1)
  [<Extension>]
  static member ToFSharpFunc(f: Func<_, _, _>) = fun x1 x2 -> f.Invoke(x1, x2)
  [<Extension>]
  static member ToFSharpFunc(f: Func<_, _, _, _>) = fun x1 x2 x3 -> f.Invoke(x1, x2, x3)
  [<Extension>]
  static member ToFSharpFunc(f: Func<_, _, _, _, _>) = fun x1 x2 x3 x4 -> f.Invoke(x1, x2, x3, x4)
  [<Extension>]
  static member ToFSharpFunc(f: Func<_, _, _, _, _, _>) = fun x1 x2 x3 x4 x5 -> f.Invoke(x1, x2, x3, x4, x5)
  [<Extension>]
  static member ToFSharpFunc(f: Func<_, _, _, _, _, _, _>) = fun x1 x2 x3 x4 x5 x6 -> f.Invoke(x1, x2, x3, x4, x5, x6)
  [<Extension>]
  static member ToFSharpFunc(f: Func<_, _, _, _, _, _, _, _>) = fun x1 x2 x3 x4 x5 x6 x7 -> f.Invoke(x1, x2, x3, x4, x5, x6, x7)
  [<Extension>]
  static member ToFSharpFunc(f: Func<_, _, _, _, _, _, _, _, _>) = fun x1 x2 x3 x4 x5 x6 x7 x8 -> f.Invoke(x1, x2, x3, x4, x5, x6, x7, x8)
  [<Extension>]
  static member ToFSharpFunc(f: Func<_, _, _, _, _, _, _, _, _, _>) = fun x1 x2 x3 x4 x5 x6 x7 x8 x9 -> f.Invoke(x1, x2, x3, x4, x5, x6, x7, x8, x9)
  [<Extension>]
  static member ToFSharpFunc(f: Func<_, _, _, _, _, _, _, _, _, _, _>) = fun x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 -> f.Invoke(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10)
  [<Extension>]
  static member ToFSharpFunc(f: Func<_, _, _, _, _, _, _, _, _, _, _, _>) = fun x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 -> f.Invoke(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11)
  [<Extension>]
  static member ToFSharpFunc(f: Func<_, _, _, _, _, _, _, _, _, _, _, _, _>) = fun x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 -> f.Invoke(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12)
  [<Extension>]
  static member ToFSharpFunc(f: Func<_, _, _, _, _, _, _, _, _, _, _, _, _, _>) = fun x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 -> f.Invoke(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13)
  [<Extension>]
  static member ToFSharpFunc(f: Func<_, _, _, _, _, _, _, _, _, _, _, _, _, _, _>) = fun x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 -> f.Invoke(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14)
  [<Extension>]
  static member ToFSharpFunc(f: Func<_, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _>) = fun x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 -> f.Invoke(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15)
  [<Extension>]
  static member ToFSharpFunc(f: Func<_, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _>) = fun x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 x16 -> f.Invoke(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16)
  [<Extension>]
  static member ToFSharpFunc(a: Action) = fun () -> a.Invoke()

  [<Extension>]
  static member ToFSharpFunc(a: Action<_>) = fun x1 -> a.Invoke(x1)
  [<Extension>]
  static member ToFSharpFunc(a: Action<_, _>) = fun x1 x2 -> a.Invoke(x1, x2)
  [<Extension>]
  static member ToFSharpFunc(a: Action<_, _, _>) = fun x1 x2 x3 -> a.Invoke(x1, x2, x3)
  [<Extension>]
  static member ToFSharpFunc(a: Action<_, _, _, _>) = fun x1 x2 x3 x4 -> a.Invoke(x1, x2, x3, x4)
  [<Extension>]
  static member ToFSharpFunc(a: Action<_, _, _, _, _>) = fun x1 x2 x3 x4 x5 -> a.Invoke(x1, x2, x3, x4, x5)
  [<Extension>]
  static member ToFSharpFunc(a: Action<_, _, _, _, _, _>) = fun x1 x2 x3 x4 x5 x6 -> a.Invoke(x1, x2, x3, x4, x5, x6)
  [<Extension>]
  static member ToFSharpFunc(a: Action<_, _, _, _, _, _, _>) = fun x1 x2 x3 x4 x5 x6 x7 -> a.Invoke(x1, x2, x3, x4, x5, x6, x7)
  [<Extension>]
  static member ToFSharpFunc(a: Action<_, _, _, _, _, _, _, _>) = fun x1 x2 x3 x4 x5 x6 x7 x8 -> a.Invoke(x1, x2, x3, x4, x5, x6, x7, x8)
  [<Extension>]
  static member ToFSharpFunc(a: Action<_, _, _, _, _, _, _, _, _>) = fun x1 x2 x3 x4 x5 x6 x7 x8 x9 -> a.Invoke(x1, x2, x3, x4, x5, x6, x7, x8, x9)
  [<Extension>]
  static member ToFSharpFunc(a: Action<_, _, _, _, _, _, _, _, _, _>) = fun x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 -> a.Invoke(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10)
  [<Extension>]
  static member ToFSharpFunc(a: Action<_, _, _, _, _, _, _, _, _, _, _>) = fun x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 -> a.Invoke(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11)
  [<Extension>]
  static member ToFSharpFunc(a: Action<_, _, _, _, _, _, _, _, _, _, _, _>) = fun x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 -> a.Invoke(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12)
  [<Extension>]
  static member ToFSharpFunc(a: Action<_, _, _, _, _, _, _, _, _, _, _, _, _>) = fun x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 -> a.Invoke(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13)
  [<Extension>]
  static member ToFSharpFunc(a: Action<_, _, _, _, _, _, _, _, _, _, _, _, _, _>) = fun x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 -> a.Invoke(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14)
  [<Extension>]
  static member ToFSharpFunc(a: Action<_, _, _, _, _, _, _, _, _, _, _, _, _, _, _>) = fun x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 -> a.Invoke(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15)
  [<Extension>]
  static member ToFSharpFunc(a: Action<_, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _>) = fun x1 x2 x3 x4 x5 x6 x7 x8 x9 x10 x11 x12 x13 x14 x15 x16 -> a.Invoke(x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16)
