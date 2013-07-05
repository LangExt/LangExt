namespace LangExt.Compatibility.FSharp

/// LangExtのOptionの別名です。
type CsOption<'a> = LangExt.Option<'a>

/// LangExtのOptionモジュールの別名です。
type CsOption = LangExt.Option

/// LangExtのOptionに対する操作を提供するモジュールです。
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module CsOption =
  /// LangExtのOptionのSomeを生成します。
  val some: 'a -> CsOption<'a>
  /// LangExtのOptionのNoneを生成します。
  val none<'a> : CsOption<'a>

  /// LangExtのOptionを、F#のoptionに変換します。
  /// パイプライン演算子とともに使うことを想定しています。
  /// パイプライン演算子とともに使わない場合、ofCsOptionを使うとより自然に書けます。
  val toFsOption: CsOption<'a> -> 'a option

  /// F#のOptionを、LangExtのOptionに変換します。
  /// 関数適用の形で使うことを想定しています。
  /// 関数適用の形で使わず、パイプライン演算子とともに使う場合はtoCsOptionを使うとより自然に書けます。
  val ofFsOption: 'a option -> CsOption<'a>

/// F#のOptionとLangExtのOptionを相互変換するためのモジュールです。
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
module FsOption =
  /// F#のOptionを、LangExtのOptionに変換します。
  /// パイプライン演算子とともに使うことを想定しています。
  /// パイプライン演算子とともに使わない場合、ofFsOptionを使うとより自然に書けます。
  val toCsOption: 'a option -> CsOption<'a>

  /// LangExtのOptionを、F#のoptionに変換します。
  /// 関数適用の形で使うことを想定しています。
  /// 関数適用の形で使わず、パイプライン演算子とともに使う場合はtoFsOptionを使うとより自然に書けます。
  val ofCsOption: CsOption<'a> -> 'a option
