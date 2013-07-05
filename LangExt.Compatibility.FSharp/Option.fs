namespace LangExt.Compatibility.FSharp

[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module CsOption =
  let some x = CsOption<_>(x)
  let none<'a> = CsOption<'a>.None

  let toFsOption = function
  | CsSome v -> Some v
  | CsNone -> None

  let ofFsOption = function
  | Some v -> some v
  | None -> none

[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module FsOption =
  let toCsOption = function
  | Some v -> CsOption.some v
  | None -> CsOption.none

  let ofCsOption = function
  | CsSome v -> Some v
  | CsNone -> None