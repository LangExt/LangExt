
using System;
using System.Collections.Generic;
using System.Linq;

namespace LangExt.Dragon
{
    partial class Linq
    {
        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す flatMap です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返されるシーケンスの要素の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して一対多の変換関数を呼び出した結果として得られる要素を含むシーケンス。</returns>
        public static IEnumerable<TResult> SelectMany<T1, T2, TResult>(this IEnumerable<_<T1, T2>> self, Func<T1, T2, IEnumerable<TResult>> selector)
        {
            return self.SelectMany(t => selector(t._1, t._2));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す flatMap です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返されるシーケンスの要素の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。最後のパラメータにはインデックスが渡されます。</param>
        /// <returns>self の各要素に対して一対多の変換関数を呼び出した結果として得られる要素を含むシーケンス。</returns>
        public static IEnumerable<TResult> SelectMany<T1, T2, TResult>(this IEnumerable<_<T1, T2>> self, Func<T1, T2, int, IEnumerable<TResult>> selector)
        {
            return self.SelectMany((t, i) => selector(t._1, t._2, i));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す flatMap です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="TCollection">collectionSelector によって収集される中間要素の型。</typeparam>
        /// <typeparam name="TResult">結果のシーケンスの要素の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="collectionSelector">各要素に適用する変換関数。</param>
        /// <param name="resultSelector">中間シーケンスの各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して一対多の変換関数 collectionSelector を呼び出し、こうしたシーケンスの各要素とそれに対応するソース要素を結果の要素に割り当てた結果として得られる要素を含むシーケンス。</returns>
        public static IEnumerable<TResult> SelectMany<T1, T2, TCollection, TResult>(this IEnumerable<_<T1, T2>> self, Func<T1, T2, IEnumerable<TCollection>> collectionSelector, Func<T1, T2, TCollection, TResult> resultSelector)
        {
            return self.SelectMany(t => collectionSelector(t._1, t._2), (t, c) => resultSelector(t._1, t._2, c));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す flatMap です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返されるシーケンスの要素の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して一対多の変換関数を呼び出した結果として得られる要素を含むシーケンス。</returns>
        public static IEnumerable<TResult> SelectMany<T1, T2, T3, TResult>(this IEnumerable<_<T1, T2, T3>> self, Func<T1, T2, T3, IEnumerable<TResult>> selector)
        {
            return self.SelectMany(t => selector(t._1, t._2, t._3));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す flatMap です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返されるシーケンスの要素の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。最後のパラメータにはインデックスが渡されます。</param>
        /// <returns>self の各要素に対して一対多の変換関数を呼び出した結果として得られる要素を含むシーケンス。</returns>
        public static IEnumerable<TResult> SelectMany<T1, T2, T3, TResult>(this IEnumerable<_<T1, T2, T3>> self, Func<T1, T2, T3, int, IEnumerable<TResult>> selector)
        {
            return self.SelectMany((t, i) => selector(t._1, t._2, t._3, i));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す flatMap です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="TCollection">collectionSelector によって収集される中間要素の型。</typeparam>
        /// <typeparam name="TResult">結果のシーケンスの要素の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="collectionSelector">各要素に適用する変換関数。</param>
        /// <param name="resultSelector">中間シーケンスの各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して一対多の変換関数 collectionSelector を呼び出し、こうしたシーケンスの各要素とそれに対応するソース要素を結果の要素に割り当てた結果として得られる要素を含むシーケンス。</returns>
        public static IEnumerable<TResult> SelectMany<T1, T2, T3, TCollection, TResult>(this IEnumerable<_<T1, T2, T3>> self, Func<T1, T2, T3, IEnumerable<TCollection>> collectionSelector, Func<T1, T2, T3, TCollection, TResult> resultSelector)
        {
            return self.SelectMany(t => collectionSelector(t._1, t._2, t._3), (t, c) => resultSelector(t._1, t._2, t._3, c));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す flatMap です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返されるシーケンスの要素の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して一対多の変換関数を呼び出した結果として得られる要素を含むシーケンス。</returns>
        public static IEnumerable<TResult> SelectMany<T1, T2, T3, T4, TResult>(this IEnumerable<_<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, IEnumerable<TResult>> selector)
        {
            return self.SelectMany(t => selector(t._1, t._2, t._3, t._4));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す flatMap です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返されるシーケンスの要素の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。最後のパラメータにはインデックスが渡されます。</param>
        /// <returns>self の各要素に対して一対多の変換関数を呼び出した結果として得られる要素を含むシーケンス。</returns>
        public static IEnumerable<TResult> SelectMany<T1, T2, T3, T4, TResult>(this IEnumerable<_<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, int, IEnumerable<TResult>> selector)
        {
            return self.SelectMany((t, i) => selector(t._1, t._2, t._3, t._4, i));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す flatMap です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="TCollection">collectionSelector によって収集される中間要素の型。</typeparam>
        /// <typeparam name="TResult">結果のシーケンスの要素の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="collectionSelector">各要素に適用する変換関数。</param>
        /// <param name="resultSelector">中間シーケンスの各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して一対多の変換関数 collectionSelector を呼び出し、こうしたシーケンスの各要素とそれに対応するソース要素を結果の要素に割り当てた結果として得られる要素を含むシーケンス。</returns>
        public static IEnumerable<TResult> SelectMany<T1, T2, T3, T4, TCollection, TResult>(this IEnumerable<_<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, IEnumerable<TCollection>> collectionSelector, Func<T1, T2, T3, T4, TCollection, TResult> resultSelector)
        {
            return self.SelectMany(t => collectionSelector(t._1, t._2, t._3, t._4), (t, c) => resultSelector(t._1, t._2, t._3, t._4, c));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す flatMap です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返されるシーケンスの要素の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して一対多の変換関数を呼び出した結果として得られる要素を含むシーケンス。</returns>
        public static IEnumerable<TResult> SelectMany<T1, T2, T3, T4, T5, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, IEnumerable<TResult>> selector)
        {
            return self.SelectMany(t => selector(t._1, t._2, t._3, t._4, t._5));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す flatMap です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返されるシーケンスの要素の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。最後のパラメータにはインデックスが渡されます。</param>
        /// <returns>self の各要素に対して一対多の変換関数を呼び出した結果として得られる要素を含むシーケンス。</returns>
        public static IEnumerable<TResult> SelectMany<T1, T2, T3, T4, T5, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, int, IEnumerable<TResult>> selector)
        {
            return self.SelectMany((t, i) => selector(t._1, t._2, t._3, t._4, t._5, i));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す flatMap です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="TCollection">collectionSelector によって収集される中間要素の型。</typeparam>
        /// <typeparam name="TResult">結果のシーケンスの要素の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="collectionSelector">各要素に適用する変換関数。</param>
        /// <param name="resultSelector">中間シーケンスの各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して一対多の変換関数 collectionSelector を呼び出し、こうしたシーケンスの各要素とそれに対応するソース要素を結果の要素に割り当てた結果として得られる要素を含むシーケンス。</returns>
        public static IEnumerable<TResult> SelectMany<T1, T2, T3, T4, T5, TCollection, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, IEnumerable<TCollection>> collectionSelector, Func<T1, T2, T3, T4, T5, TCollection, TResult> resultSelector)
        {
            return self.SelectMany(t => collectionSelector(t._1, t._2, t._3, t._4, t._5), (t, c) => resultSelector(t._1, t._2, t._3, t._4, t._5, c));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す flatMap です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返されるシーケンスの要素の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して一対多の変換関数を呼び出した結果として得られる要素を含むシーケンス。</returns>
        public static IEnumerable<TResult> SelectMany<T1, T2, T3, T4, T5, T6, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, IEnumerable<TResult>> selector)
        {
            return self.SelectMany(t => selector(t._1, t._2, t._3, t._4, t._5, t._6));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す flatMap です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返されるシーケンスの要素の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。最後のパラメータにはインデックスが渡されます。</param>
        /// <returns>self の各要素に対して一対多の変換関数を呼び出した結果として得られる要素を含むシーケンス。</returns>
        public static IEnumerable<TResult> SelectMany<T1, T2, T3, T4, T5, T6, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, int, IEnumerable<TResult>> selector)
        {
            return self.SelectMany((t, i) => selector(t._1, t._2, t._3, t._4, t._5, t._6, i));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す flatMap です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="TCollection">collectionSelector によって収集される中間要素の型。</typeparam>
        /// <typeparam name="TResult">結果のシーケンスの要素の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="collectionSelector">各要素に適用する変換関数。</param>
        /// <param name="resultSelector">中間シーケンスの各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して一対多の変換関数 collectionSelector を呼び出し、こうしたシーケンスの各要素とそれに対応するソース要素を結果の要素に割り当てた結果として得られる要素を含むシーケンス。</returns>
        public static IEnumerable<TResult> SelectMany<T1, T2, T3, T4, T5, T6, TCollection, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, IEnumerable<TCollection>> collectionSelector, Func<T1, T2, T3, T4, T5, T6, TCollection, TResult> resultSelector)
        {
            return self.SelectMany(t => collectionSelector(t._1, t._2, t._3, t._4, t._5, t._6), (t, c) => resultSelector(t._1, t._2, t._3, t._4, t._5, t._6, c));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す flatMap です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返されるシーケンスの要素の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して一対多の変換関数を呼び出した結果として得られる要素を含むシーケンス。</returns>
        public static IEnumerable<TResult> SelectMany<T1, T2, T3, T4, T5, T6, T7, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, IEnumerable<TResult>> selector)
        {
            return self.SelectMany(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す flatMap です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返されるシーケンスの要素の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。最後のパラメータにはインデックスが渡されます。</param>
        /// <returns>self の各要素に対して一対多の変換関数を呼び出した結果として得られる要素を含むシーケンス。</returns>
        public static IEnumerable<TResult> SelectMany<T1, T2, T3, T4, T5, T6, T7, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, int, IEnumerable<TResult>> selector)
        {
            return self.SelectMany((t, i) => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, i));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す flatMap です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="TCollection">collectionSelector によって収集される中間要素の型。</typeparam>
        /// <typeparam name="TResult">結果のシーケンスの要素の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="collectionSelector">各要素に適用する変換関数。</param>
        /// <param name="resultSelector">中間シーケンスの各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して一対多の変換関数 collectionSelector を呼び出し、こうしたシーケンスの各要素とそれに対応するソース要素を結果の要素に割り当てた結果として得られる要素を含むシーケンス。</returns>
        public static IEnumerable<TResult> SelectMany<T1, T2, T3, T4, T5, T6, T7, TCollection, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, IEnumerable<TCollection>> collectionSelector, Func<T1, T2, T3, T4, T5, T6, T7, TCollection, TResult> resultSelector)
        {
            return self.SelectMany(t => collectionSelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7), (t, c) => resultSelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, c));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す flatMap です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="T8">シーケンスの保持する 8 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返されるシーケンスの要素の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して一対多の変換関数を呼び出した結果として得られる要素を含むシーケンス。</returns>
        public static IEnumerable<TResult> SelectMany<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, IEnumerable<TResult>> selector)
        {
            return self.SelectMany(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す flatMap です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="T8">シーケンスの保持する 8 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返されるシーケンスの要素の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。最後のパラメータにはインデックスが渡されます。</param>
        /// <returns>self の各要素に対して一対多の変換関数を呼び出した結果として得られる要素を含むシーケンス。</returns>
        public static IEnumerable<TResult> SelectMany<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, int, IEnumerable<TResult>> selector)
        {
            return self.SelectMany((t, i) => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, i));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す flatMap です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="T8">シーケンスの保持する 8 つ目の型。</typeparam>
        /// <typeparam name="TCollection">collectionSelector によって収集される中間要素の型。</typeparam>
        /// <typeparam name="TResult">結果のシーケンスの要素の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="collectionSelector">各要素に適用する変換関数。</param>
        /// <param name="resultSelector">中間シーケンスの各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して一対多の変換関数 collectionSelector を呼び出し、こうしたシーケンスの各要素とそれに対応するソース要素を結果の要素に割り当てた結果として得られる要素を含むシーケンス。</returns>
        public static IEnumerable<TResult> SelectMany<T1, T2, T3, T4, T5, T6, T7, T8, TCollection, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, IEnumerable<TCollection>> collectionSelector, Func<T1, T2, T3, T4, T5, T6, T7, T8, TCollection, TResult> resultSelector)
        {
            return self.SelectMany(t => collectionSelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8), (t, c) => resultSelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, c));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す flatMap です。
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
        /// <typeparam name="TResult">selector によって返されるシーケンスの要素の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して一対多の変換関数を呼び出した結果として得られる要素を含むシーケンス。</returns>
        public static IEnumerable<TResult> SelectMany<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, IEnumerable<TResult>> selector)
        {
            return self.SelectMany(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す flatMap です。
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
        /// <typeparam name="TResult">selector によって返されるシーケンスの要素の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。最後のパラメータにはインデックスが渡されます。</param>
        /// <returns>self の各要素に対して一対多の変換関数を呼び出した結果として得られる要素を含むシーケンス。</returns>
        public static IEnumerable<TResult> SelectMany<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, int, IEnumerable<TResult>> selector)
        {
            return self.SelectMany((t, i) => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9, i));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す flatMap です。
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
        /// <typeparam name="TCollection">collectionSelector によって収集される中間要素の型。</typeparam>
        /// <typeparam name="TResult">結果のシーケンスの要素の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="collectionSelector">各要素に適用する変換関数。</param>
        /// <param name="resultSelector">中間シーケンスの各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して一対多の変換関数 collectionSelector を呼び出し、こうしたシーケンスの各要素とそれに対応するソース要素を結果の要素に割り当てた結果として得られる要素を含むシーケンス。</returns>
        public static IEnumerable<TResult> SelectMany<T1, T2, T3, T4, T5, T6, T7, T8, T9, TCollection, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, IEnumerable<TCollection>> collectionSelector, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TCollection, TResult> resultSelector)
        {
            return self.SelectMany(t => collectionSelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9), (t, c) => resultSelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9, c));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す flatMap です。
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
        /// <typeparam name="TResult">selector によって返されるシーケンスの要素の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して一対多の変換関数を呼び出した結果として得られる要素を含むシーケンス。</returns>
        public static IEnumerable<TResult> SelectMany<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, IEnumerable<TResult>> selector)
        {
            return self.SelectMany(t => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9, t._10));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す flatMap です。
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
        /// <typeparam name="TResult">selector によって返されるシーケンスの要素の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。最後のパラメータにはインデックスが渡されます。</param>
        /// <returns>self の各要素に対して一対多の変換関数を呼び出した結果として得られる要素を含むシーケンス。</returns>
        public static IEnumerable<TResult> SelectMany<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, int, IEnumerable<TResult>> selector)
        {
            return self.SelectMany((t, i) => selector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9, t._10, i));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して selector に渡す flatMap です。
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
        /// <typeparam name="TCollection">collectionSelector によって収集される中間要素の型。</typeparam>
        /// <typeparam name="TResult">結果のシーケンスの要素の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="collectionSelector">各要素に適用する変換関数。</param>
        /// <param name="resultSelector">中間シーケンスの各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して一対多の変換関数 collectionSelector を呼び出し、こうしたシーケンスの各要素とそれに対応するソース要素を結果の要素に割り当てた結果として得られる要素を含むシーケンス。</returns>
        public static IEnumerable<TResult> SelectMany<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TCollection, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, IEnumerable<TCollection>> collectionSelector, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TCollection, TResult> resultSelector)
        {
            return self.SelectMany(t => collectionSelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9, t._10), (t, c) => resultSelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9, t._10, c));
        }

    }
}