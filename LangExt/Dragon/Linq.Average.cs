
using System;
using System.Collections.Generic;
using System.Linq;

namespace LangExt.Dragon
{
    partial class Linq
    {
        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static decimal Average<T1, T2>(this IEnumerable<_<T1, T2>> self, Func<T1, T2, decimal> selector)
        {
            return self.Average(t => selector(t._1, t._2));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static decimal? Average<T1, T2>(this IEnumerable<_<T1, T2>> self, Func<T1, T2, decimal?> selector)
        {
            return self.Average(t => selector(t._1, t._2));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double Average<T1, T2>(this IEnumerable<_<T1, T2>> self, Func<T1, T2, double> selector)
        {
            return self.Average(t => selector(t._1, t._2));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double? Average<T1, T2>(this IEnumerable<_<T1, T2>> self, Func<T1, T2, double?> selector)
        {
            return self.Average(t => selector(t._1, t._2));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static float Average<T1, T2>(this IEnumerable<_<T1, T2>> self, Func<T1, T2, float> selector)
        {
            return self.Average(t => selector(t._1, t._2));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static float? Average<T1, T2>(this IEnumerable<_<T1, T2>> self, Func<T1, T2, float?> selector)
        {
            return self.Average(t => selector(t._1, t._2));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double Average<T1, T2>(this IEnumerable<_<T1, T2>> self, Func<T1, T2, int> selector)
        {
            return self.Average(t => selector(t._1, t._2));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double? Average<T1, T2>(this IEnumerable<_<T1, T2>> self, Func<T1, T2, int?> selector)
        {
            return self.Average(t => selector(t._1, t._2));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double Average<T1, T2>(this IEnumerable<_<T1, T2>> self, Func<T1, T2, long> selector)
        {
            return self.Average(t => selector(t._1, t._2));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double? Average<T1, T2>(this IEnumerable<_<T1, T2>> self, Func<T1, T2, long?> selector)
        {
            return self.Average(t => selector(t._1, t._2));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static decimal Average<T1, T2, T3>(this IEnumerable<_<T1, T2, T3>> self, Func<T1, T2, T3, decimal> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static decimal? Average<T1, T2, T3>(this IEnumerable<_<T1, T2, T3>> self, Func<T1, T2, T3, decimal?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double Average<T1, T2, T3>(this IEnumerable<_<T1, T2, T3>> self, Func<T1, T2, T3, double> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double? Average<T1, T2, T3>(this IEnumerable<_<T1, T2, T3>> self, Func<T1, T2, T3, double?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static float Average<T1, T2, T3>(this IEnumerable<_<T1, T2, T3>> self, Func<T1, T2, T3, float> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static float? Average<T1, T2, T3>(this IEnumerable<_<T1, T2, T3>> self, Func<T1, T2, T3, float?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double Average<T1, T2, T3>(this IEnumerable<_<T1, T2, T3>> self, Func<T1, T2, T3, int> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double? Average<T1, T2, T3>(this IEnumerable<_<T1, T2, T3>> self, Func<T1, T2, T3, int?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double Average<T1, T2, T3>(this IEnumerable<_<T1, T2, T3>> self, Func<T1, T2, T3, long> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double? Average<T1, T2, T3>(this IEnumerable<_<T1, T2, T3>> self, Func<T1, T2, T3, long?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static decimal Average<T1, T2, T3, T4>(this IEnumerable<_<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, decimal> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static decimal? Average<T1, T2, T3, T4>(this IEnumerable<_<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, decimal?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double Average<T1, T2, T3, T4>(this IEnumerable<_<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, double> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double? Average<T1, T2, T3, T4>(this IEnumerable<_<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, double?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static float Average<T1, T2, T3, T4>(this IEnumerable<_<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, float> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static float? Average<T1, T2, T3, T4>(this IEnumerable<_<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, float?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double Average<T1, T2, T3, T4>(this IEnumerable<_<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, int> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double? Average<T1, T2, T3, T4>(this IEnumerable<_<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, int?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double Average<T1, T2, T3, T4>(this IEnumerable<_<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, long> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double? Average<T1, T2, T3, T4>(this IEnumerable<_<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, long?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static decimal Average<T1, T2, T3, T4, T5>(this IEnumerable<_<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, decimal> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static decimal? Average<T1, T2, T3, T4, T5>(this IEnumerable<_<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, decimal?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double Average<T1, T2, T3, T4, T5>(this IEnumerable<_<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, double> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double? Average<T1, T2, T3, T4, T5>(this IEnumerable<_<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, double?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static float Average<T1, T2, T3, T4, T5>(this IEnumerable<_<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, float> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static float? Average<T1, T2, T3, T4, T5>(this IEnumerable<_<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, float?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double Average<T1, T2, T3, T4, T5>(this IEnumerable<_<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, int> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double? Average<T1, T2, T3, T4, T5>(this IEnumerable<_<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, int?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double Average<T1, T2, T3, T4, T5>(this IEnumerable<_<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, long> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double? Average<T1, T2, T3, T4, T5>(this IEnumerable<_<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, long?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static decimal Average<T1, T2, T3, T4, T5, T6>(this IEnumerable<_<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, decimal> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static decimal? Average<T1, T2, T3, T4, T5, T6>(this IEnumerable<_<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, decimal?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double Average<T1, T2, T3, T4, T5, T6>(this IEnumerable<_<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, double> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double? Average<T1, T2, T3, T4, T5, T6>(this IEnumerable<_<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, double?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static float Average<T1, T2, T3, T4, T5, T6>(this IEnumerable<_<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, float> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static float? Average<T1, T2, T3, T4, T5, T6>(this IEnumerable<_<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, float?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double Average<T1, T2, T3, T4, T5, T6>(this IEnumerable<_<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, int> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double? Average<T1, T2, T3, T4, T5, T6>(this IEnumerable<_<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, int?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double Average<T1, T2, T3, T4, T5, T6>(this IEnumerable<_<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, long> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double? Average<T1, T2, T3, T4, T5, T6>(this IEnumerable<_<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, long?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static decimal Average<T1, T2, T3, T4, T5, T6, T7>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, decimal> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static decimal? Average<T1, T2, T3, T4, T5, T6, T7>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, decimal?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double Average<T1, T2, T3, T4, T5, T6, T7>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, double> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double? Average<T1, T2, T3, T4, T5, T6, T7>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, double?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static float Average<T1, T2, T3, T4, T5, T6, T7>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, float> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static float? Average<T1, T2, T3, T4, T5, T6, T7>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, float?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double Average<T1, T2, T3, T4, T5, T6, T7>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, int> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double? Average<T1, T2, T3, T4, T5, T6, T7>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, int?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double Average<T1, T2, T3, T4, T5, T6, T7>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, long> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double? Average<T1, T2, T3, T4, T5, T6, T7>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, long?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="T8">シーケンスの保持する 8 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static decimal Average<T1, T2, T3, T4, T5, T6, T7, T8>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, decimal> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="T8">シーケンスの保持する 8 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static decimal? Average<T1, T2, T3, T4, T5, T6, T7, T8>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, decimal?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="T8">シーケンスの保持する 8 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double Average<T1, T2, T3, T4, T5, T6, T7, T8>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, double> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="T8">シーケンスの保持する 8 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double? Average<T1, T2, T3, T4, T5, T6, T7, T8>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, double?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="T8">シーケンスの保持する 8 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static float Average<T1, T2, T3, T4, T5, T6, T7, T8>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, float> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="T8">シーケンスの保持する 8 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static float? Average<T1, T2, T3, T4, T5, T6, T7, T8>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, float?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="T8">シーケンスの保持する 8 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double Average<T1, T2, T3, T4, T5, T6, T7, T8>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, int> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="T8">シーケンスの保持する 8 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double? Average<T1, T2, T3, T4, T5, T6, T7, T8>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, int?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="T8">シーケンスの保持する 8 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double Average<T1, T2, T3, T4, T5, T6, T7, T8>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, long> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="T8">シーケンスの保持する 8 つ目の型。</typeparam>
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double? Average<T1, T2, T3, T4, T5, T6, T7, T8>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, long?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
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
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static decimal Average<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, decimal> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
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
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static decimal? Average<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, decimal?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
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
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double Average<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, double> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
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
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double? Average<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, double?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
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
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static float Average<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, float> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
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
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static float? Average<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, float?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
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
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double Average<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, int> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
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
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double? Average<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, int?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
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
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double Average<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, long> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
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
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double? Average<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, long?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
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
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static decimal Average<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, decimal> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9, t._10));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
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
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static decimal? Average<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, decimal?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9, t._10));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
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
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double Average<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, double> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9, t._10));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
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
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double? Average<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, double?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9, t._10));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
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
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static float Average<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, float> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9, t._10));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
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
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static float? Average<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, float?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9, t._10));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
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
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double Average<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, int> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9, t._10));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
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
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double? Average<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, int?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9, t._10));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
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
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double Average<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, long> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9, t._10));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して数値に変換し、平均を計算します。
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
        /// <param name="self">平均の計算対象となるシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>値のシーケンスの平均値。</returns>
        public static double? Average<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, long?> selector)
        {
            return self.Average(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9, t._10));
        }

    }
}