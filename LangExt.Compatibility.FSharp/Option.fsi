namespace LangExt.Compatibility.FSharp

open LangExt

/// LangExtのOptionに対する操作を提供するモジュールです。
module Option =
  /// LangExtのOptionを、F#のoptionに変換します。
  /// パイプライン演算子とともに使うことを想定しています。
  /// パイプライン演算子とともに使わない場合、ofLangExtを使うとより自然に書けます。
  val toFSharp: Option<'a> -> 'a option

  /// F#のOptionを、LangExtのOptionに変換します。
  /// 関数適用の形で使うことを想定しています。
  /// 関数適用の形で使わず、パイプライン演算子とともに使う場合はtoLangExtを使うとより自然に書けます。
  val ofFSharp: 'a option -> Option<'a>

  /// F#のOptionを、LangExtのOptionに変換します。
  /// パイプライン演算子とともに使うことを想定しています。
  /// パイプライン演算子とともに使わない場合、ofFSharpを使うとより自然に書けます。
  val toLangExt: 'a option -> Option<'a>

  /// LangExtのOptionを、F#のoptionに変換します。
  /// 関数適用の形で使うことを想定しています。
  /// 関数適用の形で使わず、パイプライン演算子とともに使う場合はtoFSharpを使うとより自然に書けます。
  val ofLangExt: Option<'a> -> 'a option
