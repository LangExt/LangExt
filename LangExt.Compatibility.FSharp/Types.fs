﻿namespace LangExt.Compatibility.FSharp

/// LangExtのOptionの別名です。
type CsOption<'a> = LangExt.Option<'a>

/// LangExtのOptionモジュールの別名です。
type CsOption = LangExt.Option

/// LangExtのResultの別名です。
type CsResult<'TSuccess, 'TFailure> = LangExt.Result<'TSuccess, 'TFailure>

/// LangExtのResultモジュールの別名です。
type CsResult = LangExt.Result