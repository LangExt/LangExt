namespace LangExt.Compatibility.FSharp

open LangExt

[<AutoOpen>]
module ActivePatterns =
  /// <summary>LangExtのOptionをmatch式で使えるようにします。</summary>
  /// <returns>入力が値を保持したオブジェクトの場合CsSome、値を持っていないオブジェクトの場合CsNone</returns>
  /// <remarks>このアクティブパターンは、OptionのMatchメソッドのビューです。</remarks>
  [<CompiledName "OptionPattern">]
  let (|CsSome|CsNone|) (opt: Option<_>) =
    opt.Match(
      (fun v -> CsSome v),
      (fun () -> CsNone))

  /// <summary>LangExtのResultをmatch式で使えるようにします。</summary>
  /// <returns>入力が成功を表すオブジェクトの場合Success、失敗を表すオブジェクトの場合Failure</returns>
  /// <remarks>このアクティブパターンは、ResultのMatchメソッドのビューです。</remarks>
  [<CompiledName "ResultPattern">]
  let (|Success|Failure|) (result: Result<_, _>) =
    result.Match(
      (fun v -> Success v),
      (fun v -> Failure v))