
using System;
using System.Collections.Generic;
using System.Linq;

namespace LangExt.Dragon
{
    partial class Linq
    {
        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2>> OrderBy<T1, T2, TKey>(this IEnumerable<_<T1, T2>> self, Func<T1, T2, TKey> keySelector)
        {
            return self.OrderBy(t => keySelector(t._1, t._2));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2>> OrderBy<T1, T2, TKey>(this IEnumerable<_<T1, T2>> self, Func<T1, T2, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.OrderBy(t => keySelector(t._1, t._2), comparer);
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort の降順版です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2>> OrderByDescending<T1, T2, TKey>(this IEnumerable<_<T1, T2>> self, Func<T1, T2, TKey> keySelector)
        {
            return self.OrderByDescending(t => keySelector(t._1, t._2));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort の降順版です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2>> OrderByDescending<T1, T2, TKey>(this IEnumerable<_<T1, T2>> self, Func<T1, T2, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.OrderByDescending(t => keySelector(t._1, t._2), comparer);
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2>> ThenBy<T1, T2, TKey>(this IOrderedEnumerable<_<T1, T2>> self, Func<T1, T2, TKey> keySelector)
        {
            return self.ThenBy(t => keySelector(t._1, t._2));
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2>> ThenBy<T1, T2, TKey>(this IOrderedEnumerable<_<T1, T2>> self, Func<T1, T2, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.ThenBy(t => keySelector(t._1, t._2), comparer);
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2>> ThenByDescending<T1, T2, TKey>(this IOrderedEnumerable<_<T1, T2>> self, Func<T1, T2, TKey> keySelector)
        {
            return self.ThenByDescending(t => keySelector(t._1, t._2));
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2>> ThenByDescending<T1, T2, TKey>(this IOrderedEnumerable<_<T1, T2>> self, Func<T1, T2, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.ThenByDescending(t => keySelector(t._1, t._2), comparer);
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3>> OrderBy<T1, T2, T3, TKey>(this IEnumerable<_<T1, T2, T3>> self, Func<T1, T2, T3, TKey> keySelector)
        {
            return self.OrderBy(t => keySelector(t._1, t._2, t._3));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3>> OrderBy<T1, T2, T3, TKey>(this IEnumerable<_<T1, T2, T3>> self, Func<T1, T2, T3, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.OrderBy(t => keySelector(t._1, t._2, t._3), comparer);
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort の降順版です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3>> OrderByDescending<T1, T2, T3, TKey>(this IEnumerable<_<T1, T2, T3>> self, Func<T1, T2, T3, TKey> keySelector)
        {
            return self.OrderByDescending(t => keySelector(t._1, t._2, t._3));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort の降順版です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3>> OrderByDescending<T1, T2, T3, TKey>(this IEnumerable<_<T1, T2, T3>> self, Func<T1, T2, T3, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.OrderByDescending(t => keySelector(t._1, t._2, t._3), comparer);
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3>> ThenBy<T1, T2, T3, TKey>(this IOrderedEnumerable<_<T1, T2, T3>> self, Func<T1, T2, T3, TKey> keySelector)
        {
            return self.ThenBy(t => keySelector(t._1, t._2, t._3));
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3>> ThenBy<T1, T2, T3, TKey>(this IOrderedEnumerable<_<T1, T2, T3>> self, Func<T1, T2, T3, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.ThenBy(t => keySelector(t._1, t._2, t._3), comparer);
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3>> ThenByDescending<T1, T2, T3, TKey>(this IOrderedEnumerable<_<T1, T2, T3>> self, Func<T1, T2, T3, TKey> keySelector)
        {
            return self.ThenByDescending(t => keySelector(t._1, t._2, t._3));
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3>> ThenByDescending<T1, T2, T3, TKey>(this IOrderedEnumerable<_<T1, T2, T3>> self, Func<T1, T2, T3, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.ThenByDescending(t => keySelector(t._1, t._2, t._3), comparer);
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4>> OrderBy<T1, T2, T3, T4, TKey>(this IEnumerable<_<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, TKey> keySelector)
        {
            return self.OrderBy(t => keySelector(t._1, t._2, t._3, t._4));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4>> OrderBy<T1, T2, T3, T4, TKey>(this IEnumerable<_<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.OrderBy(t => keySelector(t._1, t._2, t._3, t._4), comparer);
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort の降順版です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4>> OrderByDescending<T1, T2, T3, T4, TKey>(this IEnumerable<_<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, TKey> keySelector)
        {
            return self.OrderByDescending(t => keySelector(t._1, t._2, t._3, t._4));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort の降順版です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4>> OrderByDescending<T1, T2, T3, T4, TKey>(this IEnumerable<_<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.OrderByDescending(t => keySelector(t._1, t._2, t._3, t._4), comparer);
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4>> ThenBy<T1, T2, T3, T4, TKey>(this IOrderedEnumerable<_<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, TKey> keySelector)
        {
            return self.ThenBy(t => keySelector(t._1, t._2, t._3, t._4));
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4>> ThenBy<T1, T2, T3, T4, TKey>(this IOrderedEnumerable<_<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.ThenBy(t => keySelector(t._1, t._2, t._3, t._4), comparer);
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4>> ThenByDescending<T1, T2, T3, T4, TKey>(this IOrderedEnumerable<_<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, TKey> keySelector)
        {
            return self.ThenByDescending(t => keySelector(t._1, t._2, t._3, t._4));
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4>> ThenByDescending<T1, T2, T3, T4, TKey>(this IOrderedEnumerable<_<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.ThenByDescending(t => keySelector(t._1, t._2, t._3, t._4), comparer);
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5>> OrderBy<T1, T2, T3, T4, T5, TKey>(this IEnumerable<_<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, TKey> keySelector)
        {
            return self.OrderBy(t => keySelector(t._1, t._2, t._3, t._4, t._5));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5>> OrderBy<T1, T2, T3, T4, T5, TKey>(this IEnumerable<_<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.OrderBy(t => keySelector(t._1, t._2, t._3, t._4, t._5), comparer);
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort の降順版です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5>> OrderByDescending<T1, T2, T3, T4, T5, TKey>(this IEnumerable<_<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, TKey> keySelector)
        {
            return self.OrderByDescending(t => keySelector(t._1, t._2, t._3, t._4, t._5));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort の降順版です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5>> OrderByDescending<T1, T2, T3, T4, T5, TKey>(this IEnumerable<_<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.OrderByDescending(t => keySelector(t._1, t._2, t._3, t._4, t._5), comparer);
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5>> ThenBy<T1, T2, T3, T4, T5, TKey>(this IOrderedEnumerable<_<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, TKey> keySelector)
        {
            return self.ThenBy(t => keySelector(t._1, t._2, t._3, t._4, t._5));
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5>> ThenBy<T1, T2, T3, T4, T5, TKey>(this IOrderedEnumerable<_<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.ThenBy(t => keySelector(t._1, t._2, t._3, t._4, t._5), comparer);
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5>> ThenByDescending<T1, T2, T3, T4, T5, TKey>(this IOrderedEnumerable<_<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, TKey> keySelector)
        {
            return self.ThenByDescending(t => keySelector(t._1, t._2, t._3, t._4, t._5));
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5>> ThenByDescending<T1, T2, T3, T4, T5, TKey>(this IOrderedEnumerable<_<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.ThenByDescending(t => keySelector(t._1, t._2, t._3, t._4, t._5), comparer);
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6>> OrderBy<T1, T2, T3, T4, T5, T6, TKey>(this IEnumerable<_<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, TKey> keySelector)
        {
            return self.OrderBy(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6>> OrderBy<T1, T2, T3, T4, T5, T6, TKey>(this IEnumerable<_<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.OrderBy(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6), comparer);
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort の降順版です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6>> OrderByDescending<T1, T2, T3, T4, T5, T6, TKey>(this IEnumerable<_<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, TKey> keySelector)
        {
            return self.OrderByDescending(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort の降順版です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6>> OrderByDescending<T1, T2, T3, T4, T5, T6, TKey>(this IEnumerable<_<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.OrderByDescending(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6), comparer);
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6>> ThenBy<T1, T2, T3, T4, T5, T6, TKey>(this IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, TKey> keySelector)
        {
            return self.ThenBy(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6));
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6>> ThenBy<T1, T2, T3, T4, T5, T6, TKey>(this IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.ThenBy(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6), comparer);
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6>> ThenByDescending<T1, T2, T3, T4, T5, T6, TKey>(this IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, TKey> keySelector)
        {
            return self.ThenByDescending(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6));
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6>> ThenByDescending<T1, T2, T3, T4, T5, T6, TKey>(this IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.ThenByDescending(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6), comparer);
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> OrderBy<T1, T2, T3, T4, T5, T6, T7, TKey>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, TKey> keySelector)
        {
            return self.OrderBy(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> OrderBy<T1, T2, T3, T4, T5, T6, T7, TKey>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.OrderBy(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7), comparer);
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort の降順版です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> OrderByDescending<T1, T2, T3, T4, T5, T6, T7, TKey>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, TKey> keySelector)
        {
            return self.OrderByDescending(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort の降順版です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> OrderByDescending<T1, T2, T3, T4, T5, T6, T7, TKey>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.OrderByDescending(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7), comparer);
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> ThenBy<T1, T2, T3, T4, T5, T6, T7, TKey>(this IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, TKey> keySelector)
        {
            return self.ThenBy(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7));
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> ThenBy<T1, T2, T3, T4, T5, T6, T7, TKey>(this IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.ThenBy(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7), comparer);
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> ThenByDescending<T1, T2, T3, T4, T5, T6, T7, TKey>(this IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, TKey> keySelector)
        {
            return self.ThenByDescending(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7));
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> ThenByDescending<T1, T2, T3, T4, T5, T6, T7, TKey>(this IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.ThenByDescending(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7), comparer);
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="T8">シーケンスの保持する 8 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> OrderBy<T1, T2, T3, T4, T5, T6, T7, T8, TKey>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, TKey> keySelector)
        {
            return self.OrderBy(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="T8">シーケンスの保持する 8 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> OrderBy<T1, T2, T3, T4, T5, T6, T7, T8, TKey>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.OrderBy(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8), comparer);
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort の降順版です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="T8">シーケンスの保持する 8 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> OrderByDescending<T1, T2, T3, T4, T5, T6, T7, T8, TKey>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, TKey> keySelector)
        {
            return self.OrderByDescending(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort の降順版です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="T8">シーケンスの保持する 8 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> OrderByDescending<T1, T2, T3, T4, T5, T6, T7, T8, TKey>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.OrderByDescending(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8), comparer);
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="T8">シーケンスの保持する 8 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> ThenBy<T1, T2, T3, T4, T5, T6, T7, T8, TKey>(this IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, TKey> keySelector)
        {
            return self.ThenBy(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8));
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="T8">シーケンスの保持する 8 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> ThenBy<T1, T2, T3, T4, T5, T6, T7, T8, TKey>(this IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.ThenBy(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8), comparer);
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="T8">シーケンスの保持する 8 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> ThenByDescending<T1, T2, T3, T4, T5, T6, T7, T8, TKey>(this IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, TKey> keySelector)
        {
            return self.ThenByDescending(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8));
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="T8">シーケンスの保持する 8 つ目の型。</typeparam>
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> ThenByDescending<T1, T2, T3, T4, T5, T6, T7, T8, TKey>(this IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.ThenByDescending(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8), comparer);
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort です。
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
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> OrderBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, TKey>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TKey> keySelector)
        {
            return self.OrderBy(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort です。
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
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> OrderBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, TKey>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.OrderBy(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9), comparer);
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort の降順版です。
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
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> OrderByDescending<T1, T2, T3, T4, T5, T6, T7, T8, T9, TKey>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TKey> keySelector)
        {
            return self.OrderByDescending(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort の降順版です。
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
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> OrderByDescending<T1, T2, T3, T4, T5, T6, T7, T8, T9, TKey>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.OrderByDescending(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9), comparer);
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
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
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> ThenBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, TKey>(this IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TKey> keySelector)
        {
            return self.ThenBy(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9));
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
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
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> ThenBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, TKey>(this IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.ThenBy(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9), comparer);
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
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
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> ThenByDescending<T1, T2, T3, T4, T5, T6, T7, T8, T9, TKey>(this IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TKey> keySelector)
        {
            return self.ThenByDescending(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9));
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
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
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> ThenByDescending<T1, T2, T3, T4, T5, T6, T7, T8, T9, TKey>(this IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.ThenByDescending(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9), comparer);
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort です。
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
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> OrderBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TKey>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TKey> keySelector)
        {
            return self.OrderBy(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9, t._10));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort です。
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
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> OrderBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TKey>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.OrderBy(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9, t._10), comparer);
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort の降順版です。
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
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> OrderByDescending<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TKey>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TKey> keySelector)
        {
            return self.OrderByDescending(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9, t._10));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して keySelector に渡す sort の降順版です。
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
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> OrderByDescending<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TKey>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.OrderByDescending(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9, t._10), comparer);
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
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
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> ThenBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TKey>(this IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TKey> keySelector)
        {
            return self.ThenBy(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9, t._10));
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
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
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> ThenBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TKey>(this IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.ThenBy(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9, t._10), comparer);
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
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
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> ThenByDescending<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TKey>(this IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TKey> keySelector)
        {
            return self.ThenByDescending(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9, t._10));
        }

        /// <summary>
        /// OrderBy、OrderByDescending、ThenBy、ThenByDescending によって並び替えられたシーケンスの順序を保ったまま、さらに並び替えを行います。
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
        /// <typeparam name="TKey">keySelector によって返されるキーの型。</typeparam>
        /// <param name="self">sort 対象のシーケンス。</param>
        /// <param name="keySelector">要素からキーを抽出する関数。</param>
        /// <param name="comparer">キーを比較するオブジェクト。</param>
        /// <returns>要素がキーに従って並べ替えられているシーケンス。</returns>
        public static IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> ThenByDescending<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TKey>(this IOrderedEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TKey> keySelector, IComparer<TKey> comparer)
        {
            return self.ThenByDescending(t => keySelector(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9, t._10), comparer);
        }

    }
}