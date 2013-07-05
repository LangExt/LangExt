namespace LangExt.Compatibility.FSharp

open LangExt

module CsOption =
  let toFsOption = function
  | CsSome v -> Some v
  | CsNone -> None

  let ofFsOption = function
  | Some v -> Option.Some v
  | None -> Option<_>.None

module FsOption =
  let toCsOption = function
  | Some v -> Option.Some v
  | None -> Option<_>.None

  let ofCsOption = function
  | CsSome v -> Some v
  | CsNone -> None