namespace LangExt.Compatibility.FSharp

open LangExt

[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module CsResult =
  let success x = CsResult.NewSuccess<_, _>(x)
  let failure x = CsResult.NewFailure<_, _>(x)
  type ResultBuilder internal () =
    member this.Return(x) = success x
    member this.Bind(x, f) =
      match x with
      | CsSuccess x -> f x
      | CsFailure x -> failure x
  let result = ResultBuilder()