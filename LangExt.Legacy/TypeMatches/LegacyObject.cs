
using System;

namespace LangExt.Legacy.TypeMatches
{
    /// <summary>
    /// オブジェクトに対して型による擬似的なパターンマッチを提供するためのクラスです。
    /// </summary>
    public static class LegacyObject
    {
        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、オブジェクトをそのままOtherwiseに渡します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="Otherwise">どの型にも変換できなかった場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, TResult>(this object self, Func<T1, TResult> ifT1, Func<object, TResult> Otherwise)
        {
            if (self is T1) return ifT1((T1)self);
            return Otherwise(self);
        }

        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、例外を送出します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, TResult>(this object self, Func<T1, TResult> ifT1)
        {
            return TypeMatch(
                self,
                ifT1,
                _ => { throw new MatchFailureException(string.Format("Doesn't match any of [{0}].", typeof(T1).Name)); });
        }
        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、オブジェクトをそのままOtherwiseに渡します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="T2">変換を試みる 2 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT2">T2 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="Otherwise">どの型にも変換できなかった場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<object, TResult> Otherwise)
        {
            if (self is T1) return ifT1((T1)self);
            if (self is T2) return ifT2((T2)self);
            return Otherwise(self);
        }

        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、例外を送出します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="T2">変換を試みる 2 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT2">T2 つ目の型に変換できた場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2)
        {
            return TypeMatch(
                self,
                ifT1, ifT2,
                _ => { throw new MatchFailureException(string.Format("Doesn't match any of [{0}, {1}].", typeof(T1).Name, typeof(T2).Name)); });
        }
        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、オブジェクトをそのままOtherwiseに渡します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="T2">変換を試みる 2 つ目の型。</typeparam>
        /// <typeparam name="T3">変換を試みる 3 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT2">T2 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT3">T3 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="Otherwise">どの型にも変換できなかった場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<object, TResult> Otherwise)
        {
            if (self is T1) return ifT1((T1)self);
            if (self is T2) return ifT2((T2)self);
            if (self is T3) return ifT3((T3)self);
            return Otherwise(self);
        }

        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、例外を送出します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="T2">変換を試みる 2 つ目の型。</typeparam>
        /// <typeparam name="T3">変換を試みる 3 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT2">T2 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT3">T3 つ目の型に変換できた場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3)
        {
            return TypeMatch(
                self,
                ifT1, ifT2, ifT3,
                _ => { throw new MatchFailureException(string.Format("Doesn't match any of [{0}, {1}, {2}].", typeof(T1).Name, typeof(T2).Name, typeof(T3).Name)); });
        }
        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、オブジェクトをそのままOtherwiseに渡します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="T2">変換を試みる 2 つ目の型。</typeparam>
        /// <typeparam name="T3">変換を試みる 3 つ目の型。</typeparam>
        /// <typeparam name="T4">変換を試みる 4 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT2">T2 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT3">T3 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT4">T4 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="Otherwise">どの型にも変換できなかった場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, T4, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<object, TResult> Otherwise)
        {
            if (self is T1) return ifT1((T1)self);
            if (self is T2) return ifT2((T2)self);
            if (self is T3) return ifT3((T3)self);
            if (self is T4) return ifT4((T4)self);
            return Otherwise(self);
        }

        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、例外を送出します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="T2">変換を試みる 2 つ目の型。</typeparam>
        /// <typeparam name="T3">変換を試みる 3 つ目の型。</typeparam>
        /// <typeparam name="T4">変換を試みる 4 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT2">T2 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT3">T3 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT4">T4 つ目の型に変換できた場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, T4, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4)
        {
            return TypeMatch(
                self,
                ifT1, ifT2, ifT3, ifT4,
                _ => { throw new MatchFailureException(string.Format("Doesn't match any of [{0}, {1}, {2}, {3}].", typeof(T1).Name, typeof(T2).Name, typeof(T3).Name, typeof(T4).Name)); });
        }
        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、オブジェクトをそのままOtherwiseに渡します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="T2">変換を試みる 2 つ目の型。</typeparam>
        /// <typeparam name="T3">変換を試みる 3 つ目の型。</typeparam>
        /// <typeparam name="T4">変換を試みる 4 つ目の型。</typeparam>
        /// <typeparam name="T5">変換を試みる 5 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT2">T2 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT3">T3 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT4">T4 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT5">T5 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="Otherwise">どの型にも変換できなかった場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, T4, T5, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<object, TResult> Otherwise)
        {
            if (self is T1) return ifT1((T1)self);
            if (self is T2) return ifT2((T2)self);
            if (self is T3) return ifT3((T3)self);
            if (self is T4) return ifT4((T4)self);
            if (self is T5) return ifT5((T5)self);
            return Otherwise(self);
        }

        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、例外を送出します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="T2">変換を試みる 2 つ目の型。</typeparam>
        /// <typeparam name="T3">変換を試みる 3 つ目の型。</typeparam>
        /// <typeparam name="T4">変換を試みる 4 つ目の型。</typeparam>
        /// <typeparam name="T5">変換を試みる 5 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT2">T2 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT3">T3 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT4">T4 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT5">T5 つ目の型に変換できた場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, T4, T5, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5)
        {
            return TypeMatch(
                self,
                ifT1, ifT2, ifT3, ifT4, ifT5,
                _ => { throw new MatchFailureException(string.Format("Doesn't match any of [{0}, {1}, {2}, {3}, {4}].", typeof(T1).Name, typeof(T2).Name, typeof(T3).Name, typeof(T4).Name, typeof(T5).Name)); });
        }
        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、オブジェクトをそのままOtherwiseに渡します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="T2">変換を試みる 2 つ目の型。</typeparam>
        /// <typeparam name="T3">変換を試みる 3 つ目の型。</typeparam>
        /// <typeparam name="T4">変換を試みる 4 つ目の型。</typeparam>
        /// <typeparam name="T5">変換を試みる 5 つ目の型。</typeparam>
        /// <typeparam name="T6">変換を試みる 6 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT2">T2 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT3">T3 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT4">T4 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT5">T5 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT6">T6 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="Otherwise">どの型にも変換できなかった場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<object, TResult> Otherwise)
        {
            if (self is T1) return ifT1((T1)self);
            if (self is T2) return ifT2((T2)self);
            if (self is T3) return ifT3((T3)self);
            if (self is T4) return ifT4((T4)self);
            if (self is T5) return ifT5((T5)self);
            if (self is T6) return ifT6((T6)self);
            return Otherwise(self);
        }

        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、例外を送出します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="T2">変換を試みる 2 つ目の型。</typeparam>
        /// <typeparam name="T3">変換を試みる 3 つ目の型。</typeparam>
        /// <typeparam name="T4">変換を試みる 4 つ目の型。</typeparam>
        /// <typeparam name="T5">変換を試みる 5 つ目の型。</typeparam>
        /// <typeparam name="T6">変換を試みる 6 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT2">T2 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT3">T3 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT4">T4 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT5">T5 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT6">T6 つ目の型に変換できた場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6)
        {
            return TypeMatch(
                self,
                ifT1, ifT2, ifT3, ifT4, ifT5, ifT6,
                _ => { throw new MatchFailureException(string.Format("Doesn't match any of [{0}, {1}, {2}, {3}, {4}, {5}].", typeof(T1).Name, typeof(T2).Name, typeof(T3).Name, typeof(T4).Name, typeof(T5).Name, typeof(T6).Name)); });
        }
        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、オブジェクトをそのままOtherwiseに渡します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="T2">変換を試みる 2 つ目の型。</typeparam>
        /// <typeparam name="T3">変換を試みる 3 つ目の型。</typeparam>
        /// <typeparam name="T4">変換を試みる 4 つ目の型。</typeparam>
        /// <typeparam name="T5">変換を試みる 5 つ目の型。</typeparam>
        /// <typeparam name="T6">変換を試みる 6 つ目の型。</typeparam>
        /// <typeparam name="T7">変換を試みる 7 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT2">T2 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT3">T3 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT4">T4 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT5">T5 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT6">T6 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT7">T7 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="Otherwise">どの型にも変換できなかった場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<object, TResult> Otherwise)
        {
            if (self is T1) return ifT1((T1)self);
            if (self is T2) return ifT2((T2)self);
            if (self is T3) return ifT3((T3)self);
            if (self is T4) return ifT4((T4)self);
            if (self is T5) return ifT5((T5)self);
            if (self is T6) return ifT6((T6)self);
            if (self is T7) return ifT7((T7)self);
            return Otherwise(self);
        }

        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、例外を送出します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="T2">変換を試みる 2 つ目の型。</typeparam>
        /// <typeparam name="T3">変換を試みる 3 つ目の型。</typeparam>
        /// <typeparam name="T4">変換を試みる 4 つ目の型。</typeparam>
        /// <typeparam name="T5">変換を試みる 5 つ目の型。</typeparam>
        /// <typeparam name="T6">変換を試みる 6 つ目の型。</typeparam>
        /// <typeparam name="T7">変換を試みる 7 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT2">T2 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT3">T3 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT4">T4 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT5">T5 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT6">T6 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT7">T7 つ目の型に変換できた場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7)
        {
            return TypeMatch(
                self,
                ifT1, ifT2, ifT3, ifT4, ifT5, ifT6, ifT7,
                _ => { throw new MatchFailureException(string.Format("Doesn't match any of [{0}, {1}, {2}, {3}, {4}, {5}, {6}].", typeof(T1).Name, typeof(T2).Name, typeof(T3).Name, typeof(T4).Name, typeof(T5).Name, typeof(T6).Name, typeof(T7).Name)); });
        }
        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、オブジェクトをそのままOtherwiseに渡します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="T2">変換を試みる 2 つ目の型。</typeparam>
        /// <typeparam name="T3">変換を試みる 3 つ目の型。</typeparam>
        /// <typeparam name="T4">変換を試みる 4 つ目の型。</typeparam>
        /// <typeparam name="T5">変換を試みる 5 つ目の型。</typeparam>
        /// <typeparam name="T6">変換を試みる 6 つ目の型。</typeparam>
        /// <typeparam name="T7">変換を試みる 7 つ目の型。</typeparam>
        /// <typeparam name="T8">変換を試みる 8 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT2">T2 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT3">T3 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT4">T4 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT5">T5 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT6">T6 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT7">T7 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT8">T8 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="Otherwise">どの型にも変換できなかった場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<object, TResult> Otherwise)
        {
            if (self is T1) return ifT1((T1)self);
            if (self is T2) return ifT2((T2)self);
            if (self is T3) return ifT3((T3)self);
            if (self is T4) return ifT4((T4)self);
            if (self is T5) return ifT5((T5)self);
            if (self is T6) return ifT6((T6)self);
            if (self is T7) return ifT7((T7)self);
            if (self is T8) return ifT8((T8)self);
            return Otherwise(self);
        }

        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、例外を送出します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="T2">変換を試みる 2 つ目の型。</typeparam>
        /// <typeparam name="T3">変換を試みる 3 つ目の型。</typeparam>
        /// <typeparam name="T4">変換を試みる 4 つ目の型。</typeparam>
        /// <typeparam name="T5">変換を試みる 5 つ目の型。</typeparam>
        /// <typeparam name="T6">変換を試みる 6 つ目の型。</typeparam>
        /// <typeparam name="T7">変換を試みる 7 つ目の型。</typeparam>
        /// <typeparam name="T8">変換を試みる 8 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT2">T2 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT3">T3 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT4">T4 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT5">T5 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT6">T6 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT7">T7 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT8">T8 つ目の型に変換できた場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8)
        {
            return TypeMatch(
                self,
                ifT1, ifT2, ifT3, ifT4, ifT5, ifT6, ifT7, ifT8,
                _ => { throw new MatchFailureException(string.Format("Doesn't match any of [{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}].", typeof(T1).Name, typeof(T2).Name, typeof(T3).Name, typeof(T4).Name, typeof(T5).Name, typeof(T6).Name, typeof(T7).Name, typeof(T8).Name)); });
        }
        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、オブジェクトをそのままOtherwiseに渡します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="T2">変換を試みる 2 つ目の型。</typeparam>
        /// <typeparam name="T3">変換を試みる 3 つ目の型。</typeparam>
        /// <typeparam name="T4">変換を試みる 4 つ目の型。</typeparam>
        /// <typeparam name="T5">変換を試みる 5 つ目の型。</typeparam>
        /// <typeparam name="T6">変換を試みる 6 つ目の型。</typeparam>
        /// <typeparam name="T7">変換を試みる 7 つ目の型。</typeparam>
        /// <typeparam name="T8">変換を試みる 8 つ目の型。</typeparam>
        /// <typeparam name="T9">変換を試みる 9 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT2">T2 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT3">T3 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT4">T4 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT5">T5 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT6">T6 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT7">T7 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT8">T8 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT9">T9 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="Otherwise">どの型にも変換できなかった場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<object, TResult> Otherwise)
        {
            if (self is T1) return ifT1((T1)self);
            if (self is T2) return ifT2((T2)self);
            if (self is T3) return ifT3((T3)self);
            if (self is T4) return ifT4((T4)self);
            if (self is T5) return ifT5((T5)self);
            if (self is T6) return ifT6((T6)self);
            if (self is T7) return ifT7((T7)self);
            if (self is T8) return ifT8((T8)self);
            if (self is T9) return ifT9((T9)self);
            return Otherwise(self);
        }

        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、例外を送出します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="T2">変換を試みる 2 つ目の型。</typeparam>
        /// <typeparam name="T3">変換を試みる 3 つ目の型。</typeparam>
        /// <typeparam name="T4">変換を試みる 4 つ目の型。</typeparam>
        /// <typeparam name="T5">変換を試みる 5 つ目の型。</typeparam>
        /// <typeparam name="T6">変換を試みる 6 つ目の型。</typeparam>
        /// <typeparam name="T7">変換を試みる 7 つ目の型。</typeparam>
        /// <typeparam name="T8">変換を試みる 8 つ目の型。</typeparam>
        /// <typeparam name="T9">変換を試みる 9 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT2">T2 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT3">T3 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT4">T4 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT5">T5 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT6">T6 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT7">T7 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT8">T8 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT9">T9 つ目の型に変換できた場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9)
        {
            return TypeMatch(
                self,
                ifT1, ifT2, ifT3, ifT4, ifT5, ifT6, ifT7, ifT8, ifT9,
                _ => { throw new MatchFailureException(string.Format("Doesn't match any of [{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}].", typeof(T1).Name, typeof(T2).Name, typeof(T3).Name, typeof(T4).Name, typeof(T5).Name, typeof(T6).Name, typeof(T7).Name, typeof(T8).Name, typeof(T9).Name)); });
        }
        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、オブジェクトをそのままOtherwiseに渡します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="T2">変換を試みる 2 つ目の型。</typeparam>
        /// <typeparam name="T3">変換を試みる 3 つ目の型。</typeparam>
        /// <typeparam name="T4">変換を試みる 4 つ目の型。</typeparam>
        /// <typeparam name="T5">変換を試みる 5 つ目の型。</typeparam>
        /// <typeparam name="T6">変換を試みる 6 つ目の型。</typeparam>
        /// <typeparam name="T7">変換を試みる 7 つ目の型。</typeparam>
        /// <typeparam name="T8">変換を試みる 8 つ目の型。</typeparam>
        /// <typeparam name="T9">変換を試みる 9 つ目の型。</typeparam>
        /// <typeparam name="T10">変換を試みる 10 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT2">T2 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT3">T3 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT4">T4 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT5">T5 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT6">T6 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT7">T7 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT8">T8 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT9">T9 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT10">T10 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="Otherwise">どの型にも変換できなかった場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<object, TResult> Otherwise)
        {
            if (self is T1) return ifT1((T1)self);
            if (self is T2) return ifT2((T2)self);
            if (self is T3) return ifT3((T3)self);
            if (self is T4) return ifT4((T4)self);
            if (self is T5) return ifT5((T5)self);
            if (self is T6) return ifT6((T6)self);
            if (self is T7) return ifT7((T7)self);
            if (self is T8) return ifT8((T8)self);
            if (self is T9) return ifT9((T9)self);
            if (self is T10) return ifT10((T10)self);
            return Otherwise(self);
        }

        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、例外を送出します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="T2">変換を試みる 2 つ目の型。</typeparam>
        /// <typeparam name="T3">変換を試みる 3 つ目の型。</typeparam>
        /// <typeparam name="T4">変換を試みる 4 つ目の型。</typeparam>
        /// <typeparam name="T5">変換を試みる 5 つ目の型。</typeparam>
        /// <typeparam name="T6">変換を試みる 6 つ目の型。</typeparam>
        /// <typeparam name="T7">変換を試みる 7 つ目の型。</typeparam>
        /// <typeparam name="T8">変換を試みる 8 つ目の型。</typeparam>
        /// <typeparam name="T9">変換を試みる 9 つ目の型。</typeparam>
        /// <typeparam name="T10">変換を試みる 10 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT2">T2 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT3">T3 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT4">T4 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT5">T5 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT6">T6 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT7">T7 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT8">T8 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT9">T9 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT10">T10 つ目の型に変換できた場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10)
        {
            return TypeMatch(
                self,
                ifT1, ifT2, ifT3, ifT4, ifT5, ifT6, ifT7, ifT8, ifT9, ifT10,
                _ => { throw new MatchFailureException(string.Format("Doesn't match any of [{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}].", typeof(T1).Name, typeof(T2).Name, typeof(T3).Name, typeof(T4).Name, typeof(T5).Name, typeof(T6).Name, typeof(T7).Name, typeof(T8).Name, typeof(T9).Name, typeof(T10).Name)); });
        }
        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、オブジェクトをそのままOtherwiseに渡します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="T2">変換を試みる 2 つ目の型。</typeparam>
        /// <typeparam name="T3">変換を試みる 3 つ目の型。</typeparam>
        /// <typeparam name="T4">変換を試みる 4 つ目の型。</typeparam>
        /// <typeparam name="T5">変換を試みる 5 つ目の型。</typeparam>
        /// <typeparam name="T6">変換を試みる 6 つ目の型。</typeparam>
        /// <typeparam name="T7">変換を試みる 7 つ目の型。</typeparam>
        /// <typeparam name="T8">変換を試みる 8 つ目の型。</typeparam>
        /// <typeparam name="T9">変換を試みる 9 つ目の型。</typeparam>
        /// <typeparam name="T10">変換を試みる 10 つ目の型。</typeparam>
        /// <typeparam name="T11">変換を試みる 11 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT2">T2 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT3">T3 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT4">T4 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT5">T5 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT6">T6 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT7">T7 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT8">T8 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT9">T9 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT10">T10 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT11">T11 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="Otherwise">どの型にも変換できなかった場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11, Func<object, TResult> Otherwise)
        {
            if (self is T1) return ifT1((T1)self);
            if (self is T2) return ifT2((T2)self);
            if (self is T3) return ifT3((T3)self);
            if (self is T4) return ifT4((T4)self);
            if (self is T5) return ifT5((T5)self);
            if (self is T6) return ifT6((T6)self);
            if (self is T7) return ifT7((T7)self);
            if (self is T8) return ifT8((T8)self);
            if (self is T9) return ifT9((T9)self);
            if (self is T10) return ifT10((T10)self);
            if (self is T11) return ifT11((T11)self);
            return Otherwise(self);
        }

        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、例外を送出します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="T2">変換を試みる 2 つ目の型。</typeparam>
        /// <typeparam name="T3">変換を試みる 3 つ目の型。</typeparam>
        /// <typeparam name="T4">変換を試みる 4 つ目の型。</typeparam>
        /// <typeparam name="T5">変換を試みる 5 つ目の型。</typeparam>
        /// <typeparam name="T6">変換を試みる 6 つ目の型。</typeparam>
        /// <typeparam name="T7">変換を試みる 7 つ目の型。</typeparam>
        /// <typeparam name="T8">変換を試みる 8 つ目の型。</typeparam>
        /// <typeparam name="T9">変換を試みる 9 つ目の型。</typeparam>
        /// <typeparam name="T10">変換を試みる 10 つ目の型。</typeparam>
        /// <typeparam name="T11">変換を試みる 11 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT2">T2 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT3">T3 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT4">T4 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT5">T5 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT6">T6 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT7">T7 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT8">T8 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT9">T9 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT10">T10 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT11">T11 つ目の型に変換できた場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11)
        {
            return TypeMatch(
                self,
                ifT1, ifT2, ifT3, ifT4, ifT5, ifT6, ifT7, ifT8, ifT9, ifT10, ifT11,
                _ => { throw new MatchFailureException(string.Format("Doesn't match any of [{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}].", typeof(T1).Name, typeof(T2).Name, typeof(T3).Name, typeof(T4).Name, typeof(T5).Name, typeof(T6).Name, typeof(T7).Name, typeof(T8).Name, typeof(T9).Name, typeof(T10).Name, typeof(T11).Name)); });
        }
        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、オブジェクトをそのままOtherwiseに渡します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="T2">変換を試みる 2 つ目の型。</typeparam>
        /// <typeparam name="T3">変換を試みる 3 つ目の型。</typeparam>
        /// <typeparam name="T4">変換を試みる 4 つ目の型。</typeparam>
        /// <typeparam name="T5">変換を試みる 5 つ目の型。</typeparam>
        /// <typeparam name="T6">変換を試みる 6 つ目の型。</typeparam>
        /// <typeparam name="T7">変換を試みる 7 つ目の型。</typeparam>
        /// <typeparam name="T8">変換を試みる 8 つ目の型。</typeparam>
        /// <typeparam name="T9">変換を試みる 9 つ目の型。</typeparam>
        /// <typeparam name="T10">変換を試みる 10 つ目の型。</typeparam>
        /// <typeparam name="T11">変換を試みる 11 つ目の型。</typeparam>
        /// <typeparam name="T12">変換を試みる 12 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT2">T2 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT3">T3 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT4">T4 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT5">T5 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT6">T6 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT7">T7 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT8">T8 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT9">T9 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT10">T10 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT11">T11 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT12">T12 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="Otherwise">どの型にも変換できなかった場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11, Func<T12, TResult> ifT12, Func<object, TResult> Otherwise)
        {
            if (self is T1) return ifT1((T1)self);
            if (self is T2) return ifT2((T2)self);
            if (self is T3) return ifT3((T3)self);
            if (self is T4) return ifT4((T4)self);
            if (self is T5) return ifT5((T5)self);
            if (self is T6) return ifT6((T6)self);
            if (self is T7) return ifT7((T7)self);
            if (self is T8) return ifT8((T8)self);
            if (self is T9) return ifT9((T9)self);
            if (self is T10) return ifT10((T10)self);
            if (self is T11) return ifT11((T11)self);
            if (self is T12) return ifT12((T12)self);
            return Otherwise(self);
        }

        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、例外を送出します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="T2">変換を試みる 2 つ目の型。</typeparam>
        /// <typeparam name="T3">変換を試みる 3 つ目の型。</typeparam>
        /// <typeparam name="T4">変換を試みる 4 つ目の型。</typeparam>
        /// <typeparam name="T5">変換を試みる 5 つ目の型。</typeparam>
        /// <typeparam name="T6">変換を試みる 6 つ目の型。</typeparam>
        /// <typeparam name="T7">変換を試みる 7 つ目の型。</typeparam>
        /// <typeparam name="T8">変換を試みる 8 つ目の型。</typeparam>
        /// <typeparam name="T9">変換を試みる 9 つ目の型。</typeparam>
        /// <typeparam name="T10">変換を試みる 10 つ目の型。</typeparam>
        /// <typeparam name="T11">変換を試みる 11 つ目の型。</typeparam>
        /// <typeparam name="T12">変換を試みる 12 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT2">T2 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT3">T3 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT4">T4 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT5">T5 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT6">T6 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT7">T7 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT8">T8 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT9">T9 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT10">T10 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT11">T11 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT12">T12 つ目の型に変換できた場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11, Func<T12, TResult> ifT12)
        {
            return TypeMatch(
                self,
                ifT1, ifT2, ifT3, ifT4, ifT5, ifT6, ifT7, ifT8, ifT9, ifT10, ifT11, ifT12,
                _ => { throw new MatchFailureException(string.Format("Doesn't match any of [{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}].", typeof(T1).Name, typeof(T2).Name, typeof(T3).Name, typeof(T4).Name, typeof(T5).Name, typeof(T6).Name, typeof(T7).Name, typeof(T8).Name, typeof(T9).Name, typeof(T10).Name, typeof(T11).Name, typeof(T12).Name)); });
        }
        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、オブジェクトをそのままOtherwiseに渡します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="T2">変換を試みる 2 つ目の型。</typeparam>
        /// <typeparam name="T3">変換を試みる 3 つ目の型。</typeparam>
        /// <typeparam name="T4">変換を試みる 4 つ目の型。</typeparam>
        /// <typeparam name="T5">変換を試みる 5 つ目の型。</typeparam>
        /// <typeparam name="T6">変換を試みる 6 つ目の型。</typeparam>
        /// <typeparam name="T7">変換を試みる 7 つ目の型。</typeparam>
        /// <typeparam name="T8">変換を試みる 8 つ目の型。</typeparam>
        /// <typeparam name="T9">変換を試みる 9 つ目の型。</typeparam>
        /// <typeparam name="T10">変換を試みる 10 つ目の型。</typeparam>
        /// <typeparam name="T11">変換を試みる 11 つ目の型。</typeparam>
        /// <typeparam name="T12">変換を試みる 12 つ目の型。</typeparam>
        /// <typeparam name="T13">変換を試みる 13 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT2">T2 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT3">T3 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT4">T4 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT5">T5 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT6">T6 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT7">T7 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT8">T8 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT9">T9 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT10">T10 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT11">T11 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT12">T12 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT13">T13 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="Otherwise">どの型にも変換できなかった場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11, Func<T12, TResult> ifT12, Func<T13, TResult> ifT13, Func<object, TResult> Otherwise)
        {
            if (self is T1) return ifT1((T1)self);
            if (self is T2) return ifT2((T2)self);
            if (self is T3) return ifT3((T3)self);
            if (self is T4) return ifT4((T4)self);
            if (self is T5) return ifT5((T5)self);
            if (self is T6) return ifT6((T6)self);
            if (self is T7) return ifT7((T7)self);
            if (self is T8) return ifT8((T8)self);
            if (self is T9) return ifT9((T9)self);
            if (self is T10) return ifT10((T10)self);
            if (self is T11) return ifT11((T11)self);
            if (self is T12) return ifT12((T12)self);
            if (self is T13) return ifT13((T13)self);
            return Otherwise(self);
        }

        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、例外を送出します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="T2">変換を試みる 2 つ目の型。</typeparam>
        /// <typeparam name="T3">変換を試みる 3 つ目の型。</typeparam>
        /// <typeparam name="T4">変換を試みる 4 つ目の型。</typeparam>
        /// <typeparam name="T5">変換を試みる 5 つ目の型。</typeparam>
        /// <typeparam name="T6">変換を試みる 6 つ目の型。</typeparam>
        /// <typeparam name="T7">変換を試みる 7 つ目の型。</typeparam>
        /// <typeparam name="T8">変換を試みる 8 つ目の型。</typeparam>
        /// <typeparam name="T9">変換を試みる 9 つ目の型。</typeparam>
        /// <typeparam name="T10">変換を試みる 10 つ目の型。</typeparam>
        /// <typeparam name="T11">変換を試みる 11 つ目の型。</typeparam>
        /// <typeparam name="T12">変換を試みる 12 つ目の型。</typeparam>
        /// <typeparam name="T13">変換を試みる 13 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT2">T2 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT3">T3 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT4">T4 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT5">T5 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT6">T6 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT7">T7 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT8">T8 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT9">T9 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT10">T10 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT11">T11 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT12">T12 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT13">T13 つ目の型に変換できた場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11, Func<T12, TResult> ifT12, Func<T13, TResult> ifT13)
        {
            return TypeMatch(
                self,
                ifT1, ifT2, ifT3, ifT4, ifT5, ifT6, ifT7, ifT8, ifT9, ifT10, ifT11, ifT12, ifT13,
                _ => { throw new MatchFailureException(string.Format("Doesn't match any of [{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}].", typeof(T1).Name, typeof(T2).Name, typeof(T3).Name, typeof(T4).Name, typeof(T5).Name, typeof(T6).Name, typeof(T7).Name, typeof(T8).Name, typeof(T9).Name, typeof(T10).Name, typeof(T11).Name, typeof(T12).Name, typeof(T13).Name)); });
        }
        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、オブジェクトをそのままOtherwiseに渡します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="T2">変換を試みる 2 つ目の型。</typeparam>
        /// <typeparam name="T3">変換を試みる 3 つ目の型。</typeparam>
        /// <typeparam name="T4">変換を試みる 4 つ目の型。</typeparam>
        /// <typeparam name="T5">変換を試みる 5 つ目の型。</typeparam>
        /// <typeparam name="T6">変換を試みる 6 つ目の型。</typeparam>
        /// <typeparam name="T7">変換を試みる 7 つ目の型。</typeparam>
        /// <typeparam name="T8">変換を試みる 8 つ目の型。</typeparam>
        /// <typeparam name="T9">変換を試みる 9 つ目の型。</typeparam>
        /// <typeparam name="T10">変換を試みる 10 つ目の型。</typeparam>
        /// <typeparam name="T11">変換を試みる 11 つ目の型。</typeparam>
        /// <typeparam name="T12">変換を試みる 12 つ目の型。</typeparam>
        /// <typeparam name="T13">変換を試みる 13 つ目の型。</typeparam>
        /// <typeparam name="T14">変換を試みる 14 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT2">T2 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT3">T3 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT4">T4 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT5">T5 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT6">T6 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT7">T7 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT8">T8 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT9">T9 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT10">T10 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT11">T11 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT12">T12 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT13">T13 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT14">T14 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="Otherwise">どの型にも変換できなかった場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11, Func<T12, TResult> ifT12, Func<T13, TResult> ifT13, Func<T14, TResult> ifT14, Func<object, TResult> Otherwise)
        {
            if (self is T1) return ifT1((T1)self);
            if (self is T2) return ifT2((T2)self);
            if (self is T3) return ifT3((T3)self);
            if (self is T4) return ifT4((T4)self);
            if (self is T5) return ifT5((T5)self);
            if (self is T6) return ifT6((T6)self);
            if (self is T7) return ifT7((T7)self);
            if (self is T8) return ifT8((T8)self);
            if (self is T9) return ifT9((T9)self);
            if (self is T10) return ifT10((T10)self);
            if (self is T11) return ifT11((T11)self);
            if (self is T12) return ifT12((T12)self);
            if (self is T13) return ifT13((T13)self);
            if (self is T14) return ifT14((T14)self);
            return Otherwise(self);
        }

        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、例外を送出します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="T2">変換を試みる 2 つ目の型。</typeparam>
        /// <typeparam name="T3">変換を試みる 3 つ目の型。</typeparam>
        /// <typeparam name="T4">変換を試みる 4 つ目の型。</typeparam>
        /// <typeparam name="T5">変換を試みる 5 つ目の型。</typeparam>
        /// <typeparam name="T6">変換を試みる 6 つ目の型。</typeparam>
        /// <typeparam name="T7">変換を試みる 7 つ目の型。</typeparam>
        /// <typeparam name="T8">変換を試みる 8 つ目の型。</typeparam>
        /// <typeparam name="T9">変換を試みる 9 つ目の型。</typeparam>
        /// <typeparam name="T10">変換を試みる 10 つ目の型。</typeparam>
        /// <typeparam name="T11">変換を試みる 11 つ目の型。</typeparam>
        /// <typeparam name="T12">変換を試みる 12 つ目の型。</typeparam>
        /// <typeparam name="T13">変換を試みる 13 つ目の型。</typeparam>
        /// <typeparam name="T14">変換を試みる 14 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT2">T2 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT3">T3 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT4">T4 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT5">T5 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT6">T6 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT7">T7 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT8">T8 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT9">T9 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT10">T10 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT11">T11 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT12">T12 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT13">T13 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT14">T14 つ目の型に変換できた場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11, Func<T12, TResult> ifT12, Func<T13, TResult> ifT13, Func<T14, TResult> ifT14)
        {
            return TypeMatch(
                self,
                ifT1, ifT2, ifT3, ifT4, ifT5, ifT6, ifT7, ifT8, ifT9, ifT10, ifT11, ifT12, ifT13, ifT14,
                _ => { throw new MatchFailureException(string.Format("Doesn't match any of [{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}].", typeof(T1).Name, typeof(T2).Name, typeof(T3).Name, typeof(T4).Name, typeof(T5).Name, typeof(T6).Name, typeof(T7).Name, typeof(T8).Name, typeof(T9).Name, typeof(T10).Name, typeof(T11).Name, typeof(T12).Name, typeof(T13).Name, typeof(T14).Name)); });
        }
        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、オブジェクトをそのままOtherwiseに渡します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="T2">変換を試みる 2 つ目の型。</typeparam>
        /// <typeparam name="T3">変換を試みる 3 つ目の型。</typeparam>
        /// <typeparam name="T4">変換を試みる 4 つ目の型。</typeparam>
        /// <typeparam name="T5">変換を試みる 5 つ目の型。</typeparam>
        /// <typeparam name="T6">変換を試みる 6 つ目の型。</typeparam>
        /// <typeparam name="T7">変換を試みる 7 つ目の型。</typeparam>
        /// <typeparam name="T8">変換を試みる 8 つ目の型。</typeparam>
        /// <typeparam name="T9">変換を試みる 9 つ目の型。</typeparam>
        /// <typeparam name="T10">変換を試みる 10 つ目の型。</typeparam>
        /// <typeparam name="T11">変換を試みる 11 つ目の型。</typeparam>
        /// <typeparam name="T12">変換を試みる 12 つ目の型。</typeparam>
        /// <typeparam name="T13">変換を試みる 13 つ目の型。</typeparam>
        /// <typeparam name="T14">変換を試みる 14 つ目の型。</typeparam>
        /// <typeparam name="T15">変換を試みる 15 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT2">T2 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT3">T3 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT4">T4 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT5">T5 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT6">T6 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT7">T7 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT8">T8 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT9">T9 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT10">T10 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT11">T11 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT12">T12 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT13">T13 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT14">T14 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT15">T15 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="Otherwise">どの型にも変換できなかった場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11, Func<T12, TResult> ifT12, Func<T13, TResult> ifT13, Func<T14, TResult> ifT14, Func<T15, TResult> ifT15, Func<object, TResult> Otherwise)
        {
            if (self is T1) return ifT1((T1)self);
            if (self is T2) return ifT2((T2)self);
            if (self is T3) return ifT3((T3)self);
            if (self is T4) return ifT4((T4)self);
            if (self is T5) return ifT5((T5)self);
            if (self is T6) return ifT6((T6)self);
            if (self is T7) return ifT7((T7)self);
            if (self is T8) return ifT8((T8)self);
            if (self is T9) return ifT9((T9)self);
            if (self is T10) return ifT10((T10)self);
            if (self is T11) return ifT11((T11)self);
            if (self is T12) return ifT12((T12)self);
            if (self is T13) return ifT13((T13)self);
            if (self is T14) return ifT14((T14)self);
            if (self is T15) return ifT15((T15)self);
            return Otherwise(self);
        }

        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、例外を送出します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="T2">変換を試みる 2 つ目の型。</typeparam>
        /// <typeparam name="T3">変換を試みる 3 つ目の型。</typeparam>
        /// <typeparam name="T4">変換を試みる 4 つ目の型。</typeparam>
        /// <typeparam name="T5">変換を試みる 5 つ目の型。</typeparam>
        /// <typeparam name="T6">変換を試みる 6 つ目の型。</typeparam>
        /// <typeparam name="T7">変換を試みる 7 つ目の型。</typeparam>
        /// <typeparam name="T8">変換を試みる 8 つ目の型。</typeparam>
        /// <typeparam name="T9">変換を試みる 9 つ目の型。</typeparam>
        /// <typeparam name="T10">変換を試みる 10 つ目の型。</typeparam>
        /// <typeparam name="T11">変換を試みる 11 つ目の型。</typeparam>
        /// <typeparam name="T12">変換を試みる 12 つ目の型。</typeparam>
        /// <typeparam name="T13">変換を試みる 13 つ目の型。</typeparam>
        /// <typeparam name="T14">変換を試みる 14 つ目の型。</typeparam>
        /// <typeparam name="T15">変換を試みる 15 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT2">T2 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT3">T3 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT4">T4 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT5">T5 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT6">T6 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT7">T7 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT8">T8 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT9">T9 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT10">T10 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT11">T11 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT12">T12 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT13">T13 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT14">T14 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT15">T15 つ目の型に変換できた場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11, Func<T12, TResult> ifT12, Func<T13, TResult> ifT13, Func<T14, TResult> ifT14, Func<T15, TResult> ifT15)
        {
            return TypeMatch(
                self,
                ifT1, ifT2, ifT3, ifT4, ifT5, ifT6, ifT7, ifT8, ifT9, ifT10, ifT11, ifT12, ifT13, ifT14, ifT15,
                _ => { throw new MatchFailureException(string.Format("Doesn't match any of [{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}].", typeof(T1).Name, typeof(T2).Name, typeof(T3).Name, typeof(T4).Name, typeof(T5).Name, typeof(T6).Name, typeof(T7).Name, typeof(T8).Name, typeof(T9).Name, typeof(T10).Name, typeof(T11).Name, typeof(T12).Name, typeof(T13).Name, typeof(T14).Name, typeof(T15).Name)); });
        }
        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、オブジェクトをそのままOtherwiseに渡します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="T2">変換を試みる 2 つ目の型。</typeparam>
        /// <typeparam name="T3">変換を試みる 3 つ目の型。</typeparam>
        /// <typeparam name="T4">変換を試みる 4 つ目の型。</typeparam>
        /// <typeparam name="T5">変換を試みる 5 つ目の型。</typeparam>
        /// <typeparam name="T6">変換を試みる 6 つ目の型。</typeparam>
        /// <typeparam name="T7">変換を試みる 7 つ目の型。</typeparam>
        /// <typeparam name="T8">変換を試みる 8 つ目の型。</typeparam>
        /// <typeparam name="T9">変換を試みる 9 つ目の型。</typeparam>
        /// <typeparam name="T10">変換を試みる 10 つ目の型。</typeparam>
        /// <typeparam name="T11">変換を試みる 11 つ目の型。</typeparam>
        /// <typeparam name="T12">変換を試みる 12 つ目の型。</typeparam>
        /// <typeparam name="T13">変換を試みる 13 つ目の型。</typeparam>
        /// <typeparam name="T14">変換を試みる 14 つ目の型。</typeparam>
        /// <typeparam name="T15">変換を試みる 15 つ目の型。</typeparam>
        /// <typeparam name="T16">変換を試みる 16 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT2">T2 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT3">T3 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT4">T4 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT5">T5 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT6">T6 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT7">T7 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT8">T8 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT9">T9 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT10">T10 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT11">T11 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT12">T12 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT13">T13 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT14">T14 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT15">T15 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT16">T16 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="Otherwise">どの型にも変換できなかった場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11, Func<T12, TResult> ifT12, Func<T13, TResult> ifT13, Func<T14, TResult> ifT14, Func<T15, TResult> ifT15, Func<T16, TResult> ifT16, Func<object, TResult> Otherwise)
        {
            if (self is T1) return ifT1((T1)self);
            if (self is T2) return ifT2((T2)self);
            if (self is T3) return ifT3((T3)self);
            if (self is T4) return ifT4((T4)self);
            if (self is T5) return ifT5((T5)self);
            if (self is T6) return ifT6((T6)self);
            if (self is T7) return ifT7((T7)self);
            if (self is T8) return ifT8((T8)self);
            if (self is T9) return ifT9((T9)self);
            if (self is T10) return ifT10((T10)self);
            if (self is T11) return ifT11((T11)self);
            if (self is T12) return ifT12((T12)self);
            if (self is T13) return ifT13((T13)self);
            if (self is T14) return ifT14((T14)self);
            if (self is T15) return ifT15((T15)self);
            if (self is T16) return ifT16((T16)self);
            return Otherwise(self);
        }

        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、例外を送出します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="T2">変換を試みる 2 つ目の型。</typeparam>
        /// <typeparam name="T3">変換を試みる 3 つ目の型。</typeparam>
        /// <typeparam name="T4">変換を試みる 4 つ目の型。</typeparam>
        /// <typeparam name="T5">変換を試みる 5 つ目の型。</typeparam>
        /// <typeparam name="T6">変換を試みる 6 つ目の型。</typeparam>
        /// <typeparam name="T7">変換を試みる 7 つ目の型。</typeparam>
        /// <typeparam name="T8">変換を試みる 8 つ目の型。</typeparam>
        /// <typeparam name="T9">変換を試みる 9 つ目の型。</typeparam>
        /// <typeparam name="T10">変換を試みる 10 つ目の型。</typeparam>
        /// <typeparam name="T11">変換を試みる 11 つ目の型。</typeparam>
        /// <typeparam name="T12">変換を試みる 12 つ目の型。</typeparam>
        /// <typeparam name="T13">変換を試みる 13 つ目の型。</typeparam>
        /// <typeparam name="T14">変換を試みる 14 つ目の型。</typeparam>
        /// <typeparam name="T15">変換を試みる 15 つ目の型。</typeparam>
        /// <typeparam name="T16">変換を試みる 16 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT2">T2 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT3">T3 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT4">T4 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT5">T5 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT6">T6 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT7">T7 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT8">T8 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT9">T9 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT10">T10 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT11">T11 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT12">T12 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT13">T13 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT14">T14 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT15">T15 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT16">T16 つ目の型に変換できた場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11, Func<T12, TResult> ifT12, Func<T13, TResult> ifT13, Func<T14, TResult> ifT14, Func<T15, TResult> ifT15, Func<T16, TResult> ifT16)
        {
            return TypeMatch(
                self,
                ifT1, ifT2, ifT3, ifT4, ifT5, ifT6, ifT7, ifT8, ifT9, ifT10, ifT11, ifT12, ifT13, ifT14, ifT15, ifT16,
                _ => { throw new MatchFailureException(string.Format("Doesn't match any of [{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}].", typeof(T1).Name, typeof(T2).Name, typeof(T3).Name, typeof(T4).Name, typeof(T5).Name, typeof(T6).Name, typeof(T7).Name, typeof(T8).Name, typeof(T9).Name, typeof(T10).Name, typeof(T11).Name, typeof(T12).Name, typeof(T13).Name, typeof(T14).Name, typeof(T15).Name, typeof(T16).Name)); });
        }
    }
}