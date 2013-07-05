namespace LangExt.Compatibility.FSharp

module ActivePatterns =
  [<CompiledName "OptionPattern">]
  let (|CsSome|CsNone|) (opt: CsOption<_>) =
    opt.Match(
      (fun v -> CsSome v),
      (fun () -> CsNone))

  [<CompiledName "ResultPattern">]
  let (|Success|Failure|) (result: Result<_, _>) =
    result.Match(
      (fun v -> Success v),
      (fun v -> Failure v))