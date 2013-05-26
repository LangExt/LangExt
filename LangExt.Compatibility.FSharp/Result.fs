namespace LangExt.Compatibility.FSharp

open LangExt

module Result =
  let (|Success|Failure|) (result: Result<_, _>) =
    result.Match(
      (fun v -> Success v),
      (fun v -> Failure v))