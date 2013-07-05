namespace LangExt.Compatibility.FSharp

module ActivePatterns =
  [<CompiledName "OptionPattern">]
  let (|CsSome|CsNone|) (opt: CsOption<_>) =
    opt.Match(
      (fun v -> CsSome v),
      (fun () -> CsNone))

  [<CompiledName "ResultPattern">]
  let (|CsSuccess|CsFailure|) (result: CsResult<_, _>) =
    result.Match(
      (fun v -> CsSuccess v),
      (fun v -> CsFailure v))