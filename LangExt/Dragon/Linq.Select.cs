
using System;
using System.Collections.Generic;
using System.Linq;

namespace LangExt.Dragon
{
    partial class Linq
    {
        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す map です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返される値の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して変換関数を適用した結果を要素に持つシーケンス。</returns>
        public static IEnumerable<TResult> Select<T1, T2, TResult>(this IEnumerable<_<T1, T2>> self, Func<T1, T2, TResult> selector)
        {
            return self.Select(t => selector(t._1, t._2));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す map です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返される値の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。最後のパラメータにはインデックスが渡されます。</param>
        /// <returns>self の各要素に対して変換関数を適用した結果を要素に持つシーケンス。</returns>
        public static IEnumerable<TResult> Select<T1, T2, TResult>(this IEnumerable<_<T1, T2>> self, Func<T1, T2, int, TResult> selector)
        {
            return self.Select((t, i) => selector(t._1, t._2, i));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す map です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返される値の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して変換関数を適用した結果を要素に持つシーケンス。</returns>
        public static IEnumerable<TResult> Select<T1, T2, T3, TResult>(this IEnumerable<_<T1, T2, T3>> self, Func<T1, T2, T3, TResult> selector)
        {
            return self.Select(t => selector(t._1, t._2, t._3));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す map です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返される値の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。最後のパラメータにはインデックスが渡されます。</param>
        /// <returns>self の各要素に対して変換関数を適用した結果を要素に持つシーケンス。</returns>
        public static IEnumerable<TResult> Select<T1, T2, T3, TResult>(this IEnumerable<_<T1, T2, T3>> self, Func<T1, T2, T3, int, TResult> selector)
        {
            return self.Select((t, i) => selector(t._1, t._2, t._3, i));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す map です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返される値の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して変換関数を適用した結果を要素に持つシーケンス。</returns>
        public static IEnumerable<TResult> Select<T1, T2, T3, T4, TResult>(this IEnumerable<_<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, TResult> selector)
        {
            return self.Select(t => selector(t._1, t._2, t._3, t._4));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す map です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返される値の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。最後のパラメータにはインデックスが渡されます。</param>
        /// <returns>self の各要素に対して変換関数を適用した結果を要素に持つシーケンス。</returns>
        public static IEnumerable<TResult> Select<T1, T2, T3, T4, TResult>(this IEnumerable<_<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, int, TResult> selector)
        {
            return self.Select((t, i) => selector(t._1, t._2, t._3, t._4, i));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す map です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返される値の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して変換関数を適用した結果を要素に持つシーケンス。</returns>
        public static IEnumerable<TResult> Select<T1, T2, T3, T4, T5, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, TResult> selector)
        {
            return self.Select(t => selector(t._1, t._2, t._3, t._4, t._5));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す map です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返される値の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。最後のパラメータにはインデックスが渡されます。</param>
        /// <returns>self の各要素に対して変換関数を適用した結果を要素に持つシーケンス。</returns>
        public static IEnumerable<TResult> Select<T1, T2, T3, T4, T5, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, int, TResult> selector)
        {
            return self.Select((t, i) => selector(t._1, t._2, t._3, t._4, t._5, i));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す map です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返される値の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して変換関数を適用した結果を要素に持つシーケンス。</returns>
        public static IEnumerable<TResult> Select<T1, T2, T3, T4, T5, T6, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, TResult> selector)
        {
            return self.Select(t => selector(t._1, t._2, t._3, t._4, t._5, t._6));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す map です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返される値の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。最後のパラメータにはインデックスが渡されます。</param>
        /// <returns>self の各要素に対して変換関数を適用した結果を要素に持つシーケンス。</returns>
        public static IEnumerable<TResult> Select<T1, T2, T3, T4, T5, T6, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, int, TResult> selector)
        {
            return self.Select((t, i) => selector(t._1, t._2, t._3, t._4, t._5, t._6, i));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す map です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返される値の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して変換関数を適用した結果を要素に持つシーケンス。</returns>
        public static IEnumerable<TResult> Select<T1, T2, T3, T4, T5, T6, T7, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, TResult> selector)
        {
            return self.Select(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す map です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返される値の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。最後のパラメータにはインデックスが渡されます。</param>
        /// <returns>self の各要素に対して変換関数を適用した結果を要素に持つシーケンス。</returns>
        public static IEnumerable<TResult> Select<T1, T2, T3, T4, T5, T6, T7, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, int, TResult> selector)
        {
            return self.Select((t, i) => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, i));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す map です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="T8">シーケンスの保持する 8 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返される値の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して変換関数を適用した結果を要素に持つシーケンス。</returns>
        public static IEnumerable<TResult> Select<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> selector)
        {
            return self.Select(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す map です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="T8">シーケンスの保持する 8 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返される値の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。最後のパラメータにはインデックスが渡されます。</param>
        /// <returns>self の各要素に対して変換関数を適用した結果を要素に持つシーケンス。</returns>
        public static IEnumerable<TResult> Select<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, int, TResult> selector)
        {
            return self.Select((t, i) => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, i));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す map です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="T8">シーケンスの保持する 8 つ目の型。</typeparam>
        /// <typeparam name="T9">シーケンスの保持する 9 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返される値の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して変換関数を適用した結果を要素に持つシーケンス。</returns>
        public static IEnumerable<TResult> Select<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> selector)
        {
            return self.Select(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す map です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="T8">シーケンスの保持する 8 つ目の型。</typeparam>
        /// <typeparam name="T9">シーケンスの保持する 9 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返される値の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。最後のパラメータにはインデックスが渡されます。</param>
        /// <returns>self の各要素に対して変換関数を適用した結果を要素に持つシーケンス。</returns>
        public static IEnumerable<TResult> Select<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, int, TResult> selector)
        {
            return self.Select((t, i) => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9, i));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す map です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="T8">シーケンスの保持する 8 つ目の型。</typeparam>
        /// <typeparam name="T9">シーケンスの保持する 9 つ目の型。</typeparam>
        /// <typeparam name="T10">シーケンスの保持する 10 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返される値の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して変換関数を適用した結果を要素に持つシーケンス。</returns>
        public static IEnumerable<TResult> Select<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> selector)
        {
            return self.Select(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9, t._10));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す map です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="T8">シーケンスの保持する 8 つ目の型。</typeparam>
        /// <typeparam name="T9">シーケンスの保持する 9 つ目の型。</typeparam>
        /// <typeparam name="T10">シーケンスの保持する 10 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返される値の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。最後のパラメータにはインデックスが渡されます。</param>
        /// <returns>self の各要素に対して変換関数を適用した結果を要素に持つシーケンス。</returns>
        public static IEnumerable<TResult> Select<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, int, TResult> selector)
        {
            return self.Select((t, i) => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9, t._10, i));
        }

    }
}