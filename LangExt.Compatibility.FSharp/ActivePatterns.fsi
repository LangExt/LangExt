namespace LangExt.Compatibility.FSharp

/// LangExtの型をmatch式で使えるようにするためのアクティブパターンを提供するモジュールです。
[<AutoOpen>]
module ActivePatterns =
  /// <summary>LangExtのOptionをmatch式で使えるようにします。</summary>
  /// <returns>入力が値を保持したオブジェクトの場合CsSome、値を持っていないオブジェクトの場合CsNone</returns>
  /// <remarks>このアクティブパターンは、OptionのMatchメソッドのビューです。</remarks>
  [<CompiledName "OptionPattern">]
  val (|CsSome|CsNone|) : opt: CsOption<'a> -> Choice<'a, unit>

  /// <summary>LangExtのResultをmatch式で使えるようにします。</summary>
  /// <returns>入力が成功を表すオブジェクトの場合Success、失敗を表すオブジェクトの場合Failure</returns>
  /// <remarks>このアクティブパターンは、ResultのMatchメソッドのビューです。</remarks>
  [<CompiledName "ResultPattern">]
  val (|Success|Failure|) : result: Result<'a, 'b> -> Choice<'a, 'b>