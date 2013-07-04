namespace LangExt.Compatibility.FSharp

open LangExt

/// LangExtのResultに対する操作を提供するモジュールです。
module Result =
  /// <summary>LangExtのResultをmatch式で使えるようにします。</summary>
  /// <returns>入力が成功を表すオブジェクトの場合Success、失敗を表すオブジェクトの場合Failure</returns>
  /// <remarks>このアクティブパターンは、ResultのMatchメソッドのビューです。</remarks>
  [<CompiledName "ResultPattern">]
  let (|Success|Failure|) (result: Result<_, _>) =
    result.Match(
      (fun v -> Success v),
      (fun v -> Failure v))