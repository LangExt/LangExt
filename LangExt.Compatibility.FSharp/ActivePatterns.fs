namespace LangExt.Compatibility.FSharp

open LangExt

module ActivePatterns =
  [<CompiledName "OptionPattern">]
  let (|CsSome|CsNone|) (opt: Option<_>) =
    opt.Match(
      (fun v -> CsSome v),
      (fun () -> CsNone))

  [<CompiledName "ResultPattern">]
  let (|Success|Failure|) (result: Result<_, _>) =
    result.Match(
      (fun v -> Success v),
      (fun v -> Failure v))