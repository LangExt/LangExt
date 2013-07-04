namespace LangExt.Compatibility.FSharp

open LangExt

/// LangExtのOptionに対する操作を提供するモジュールです。
module Option =
  /// <summary>LangExtのOptionをmatch式で使えるようにします。</summary>
  /// <returns>入力が値を保持したオブジェクトの場合CsSome、値を持っていないオブジェクトの場合CsNone</returns>
  /// <remarks>このアクティブパターンは、OptionのMatchメソッドのビューです。</remarks>
  [<CompiledName "OptionPattern">]
  let (|CsSome|CsNone|) (opt: Option<_>) =
    opt.Match(
      (fun v -> CsSome v),
      (fun () -> CsNone))
