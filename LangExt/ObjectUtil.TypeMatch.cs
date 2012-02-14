
using System;

namespace LangExt
{
    partial class ObjectUtil
    {
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
            if (self is T1)
                return ifT1((T1)self);
            throw new Exception();
        }

        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、otherwise で指定した処理を実行して返します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="otherwise">どの型にも変換できなかった場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, TResult>(this object self, Func<T1, TResult> ifT1, Func<TResult> otherwise)
        {
            if (self is T1)
                return ifT1((T1)self);
            return otherwise();
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
            if (self is T1)
                return ifT1((T1)self);
            if (self is T2)
                return ifT2((T2)self);
            throw new Exception();
        }

        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、otherwise で指定した処理を実行して返します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="T2">変換を試みる 2 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT2">T2 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="otherwise">どの型にも変換できなかった場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<TResult> otherwise)
        {
            if (self is T1)
                return ifT1((T1)self);
            if (self is T2)
                return ifT2((T2)self);
            return otherwise();
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
            if (self is T1)
                return ifT1((T1)self);
            if (self is T2)
                return ifT2((T2)self);
            if (self is T3)
                return ifT3((T3)self);
            throw new Exception();
        }

        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、otherwise で指定した処理を実行して返します。
        /// </summary>
        /// <typeparam name="T1">変換を試みる 1 つ目の型。</typeparam>
        /// <typeparam name="T2">変換を試みる 2 つ目の型。</typeparam>
        /// <typeparam name="T3">変換を試みる 3 つ目の型。</typeparam>
        /// <typeparam name="TResult">処理の戻り値の型。</typeparam>
        /// <param name="self">変換対象。</param>
        /// <param name="ifT1">T1 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT2">T2 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="ifT3">T3 つ目の型に変換できた場合に実行される処理。</param>
        /// <param name="otherwise">どの型にも変換できなかった場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<TResult> otherwise)
        {
            if (self is T1)
                return ifT1((T1)self);
            if (self is T2)
                return ifT2((T2)self);
            if (self is T3)
                return ifT3((T3)self);
            return otherwise();
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
            if (self is T1)
                return ifT1((T1)self);
            if (self is T2)
                return ifT2((T2)self);
            if (self is T3)
                return ifT3((T3)self);
            if (self is T4)
                return ifT4((T4)self);
            throw new Exception();
        }

        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、otherwise で指定した処理を実行して返します。
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
        /// <param name="otherwise">どの型にも変換できなかった場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, T4, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<TResult> otherwise)
        {
            if (self is T1)
                return ifT1((T1)self);
            if (self is T2)
                return ifT2((T2)self);
            if (self is T3)
                return ifT3((T3)self);
            if (self is T4)
                return ifT4((T4)self);
            return otherwise();
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
            if (self is T1)
                return ifT1((T1)self);
            if (self is T2)
                return ifT2((T2)self);
            if (self is T3)
                return ifT3((T3)self);
            if (self is T4)
                return ifT4((T4)self);
            if (self is T5)
                return ifT5((T5)self);
            throw new Exception();
        }

        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、otherwise で指定した処理を実行して返します。
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
        /// <param name="otherwise">どの型にも変換できなかった場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, T4, T5, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<TResult> otherwise)
        {
            if (self is T1)
                return ifT1((T1)self);
            if (self is T2)
                return ifT2((T2)self);
            if (self is T3)
                return ifT3((T3)self);
            if (self is T4)
                return ifT4((T4)self);
            if (self is T5)
                return ifT5((T5)self);
            return otherwise();
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
            if (self is T1)
                return ifT1((T1)self);
            if (self is T2)
                return ifT2((T2)self);
            if (self is T3)
                return ifT3((T3)self);
            if (self is T4)
                return ifT4((T4)self);
            if (self is T5)
                return ifT5((T5)self);
            if (self is T6)
                return ifT6((T6)self);
            throw new Exception();
        }

        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、otherwise で指定した処理を実行して返します。
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
        /// <param name="otherwise">どの型にも変換できなかった場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<TResult> otherwise)
        {
            if (self is T1)
                return ifT1((T1)self);
            if (self is T2)
                return ifT2((T2)self);
            if (self is T3)
                return ifT3((T3)self);
            if (self is T4)
                return ifT4((T4)self);
            if (self is T5)
                return ifT5((T5)self);
            if (self is T6)
                return ifT6((T6)self);
            return otherwise();
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
            if (self is T1)
                return ifT1((T1)self);
            if (self is T2)
                return ifT2((T2)self);
            if (self is T3)
                return ifT3((T3)self);
            if (self is T4)
                return ifT4((T4)self);
            if (self is T5)
                return ifT5((T5)self);
            if (self is T6)
                return ifT6((T6)self);
            if (self is T7)
                return ifT7((T7)self);
            throw new Exception();
        }

        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、otherwise で指定した処理を実行して返します。
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
        /// <param name="otherwise">どの型にも変換できなかった場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<TResult> otherwise)
        {
            if (self is T1)
                return ifT1((T1)self);
            if (self is T2)
                return ifT2((T2)self);
            if (self is T3)
                return ifT3((T3)self);
            if (self is T4)
                return ifT4((T4)self);
            if (self is T5)
                return ifT5((T5)self);
            if (self is T6)
                return ifT6((T6)self);
            if (self is T7)
                return ifT7((T7)self);
            return otherwise();
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
            if (self is T1)
                return ifT1((T1)self);
            if (self is T2)
                return ifT2((T2)self);
            if (self is T3)
                return ifT3((T3)self);
            if (self is T4)
                return ifT4((T4)self);
            if (self is T5)
                return ifT5((T5)self);
            if (self is T6)
                return ifT6((T6)self);
            if (self is T7)
                return ifT7((T7)self);
            if (self is T8)
                return ifT8((T8)self);
            throw new Exception();
        }

        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、otherwise で指定した処理を実行して返します。
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
        /// <param name="otherwise">どの型にも変換できなかった場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<TResult> otherwise)
        {
            if (self is T1)
                return ifT1((T1)self);
            if (self is T2)
                return ifT2((T2)self);
            if (self is T3)
                return ifT3((T3)self);
            if (self is T4)
                return ifT4((T4)self);
            if (self is T5)
                return ifT5((T5)self);
            if (self is T6)
                return ifT6((T6)self);
            if (self is T7)
                return ifT7((T7)self);
            if (self is T8)
                return ifT8((T8)self);
            return otherwise();
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
            if (self is T1)
                return ifT1((T1)self);
            if (self is T2)
                return ifT2((T2)self);
            if (self is T3)
                return ifT3((T3)self);
            if (self is T4)
                return ifT4((T4)self);
            if (self is T5)
                return ifT5((T5)self);
            if (self is T6)
                return ifT6((T6)self);
            if (self is T7)
                return ifT7((T7)self);
            if (self is T8)
                return ifT8((T8)self);
            if (self is T9)
                return ifT9((T9)self);
            throw new Exception();
        }

        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、otherwise で指定した処理を実行して返します。
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
        /// <param name="otherwise">どの型にも変換できなかった場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<TResult> otherwise)
        {
            if (self is T1)
                return ifT1((T1)self);
            if (self is T2)
                return ifT2((T2)self);
            if (self is T3)
                return ifT3((T3)self);
            if (self is T4)
                return ifT4((T4)self);
            if (self is T5)
                return ifT5((T5)self);
            if (self is T6)
                return ifT6((T6)self);
            if (self is T7)
                return ifT7((T7)self);
            if (self is T8)
                return ifT8((T8)self);
            if (self is T9)
                return ifT9((T9)self);
            return otherwise();
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
            if (self is T1)
                return ifT1((T1)self);
            if (self is T2)
                return ifT2((T2)self);
            if (self is T3)
                return ifT3((T3)self);
            if (self is T4)
                return ifT4((T4)self);
            if (self is T5)
                return ifT5((T5)self);
            if (self is T6)
                return ifT6((T6)self);
            if (self is T7)
                return ifT7((T7)self);
            if (self is T8)
                return ifT8((T8)self);
            if (self is T9)
                return ifT9((T9)self);
            if (self is T10)
                return ifT10((T10)self);
            throw new Exception();
        }

        /// <summary>
        /// 型パラメータの先頭から順にキャスト出来るかを is 演算子で調べ、is 演算子が true を返した型に対応する処理を実行して返します。
        /// どの型にも変換できなかった場合、otherwise で指定した処理を実行して返します。
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
        /// <param name="otherwise">どの型にも変換できなかった場合に実行される処理。</param>
        /// <returns>処理の結果。</returns>
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<TResult> otherwise)
        {
            if (self is T1)
                return ifT1((T1)self);
            if (self is T2)
                return ifT2((T2)self);
            if (self is T3)
                return ifT3((T3)self);
            if (self is T4)
                return ifT4((T4)self);
            if (self is T5)
                return ifT5((T5)self);
            if (self is T6)
                return ifT6((T6)self);
            if (self is T7)
                return ifT7((T7)self);
            if (self is T8)
                return ifT8((T8)self);
            if (self is T9)
                return ifT9((T9)self);
            if (self is T10)
                return ifT10((T10)self);
            return otherwise();
        }

    }
}
