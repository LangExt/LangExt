namespace LangExt.Compatibility.FSharp

open LangExt

module Option =
  let toFSharp = function
  | CsSome v -> Some v
  | CsNone -> None

  let ofFSharp = function
  | Some v -> Option.Some v
  | None -> Option<_>.None

  let toLangExt = function
  | Some v -> Option.Some v
  | None -> Option<_>.None

  let ofLangExt = function
  | CsSome v -> Some v
  | CsNone -> None