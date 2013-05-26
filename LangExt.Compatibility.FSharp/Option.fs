namespace LangExt.Compatibility.FSharp

open LangExt

module Option =
  let (|CsSome|CsNone|) (opt: Option<_>) =
    opt.Match(
      (fun v -> CsSome v),
      (fun () -> CsNone))
