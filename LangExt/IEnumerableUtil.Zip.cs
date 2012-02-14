
using System;
using System.Collections.Generic;
using System.Linq;

namespace LangExt
{
    partial class IEnumerableUtil
    {
        #region Zipメソッド

        /// <summary>
        /// 対象と引数を 2 要素のタプルにまとめます。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <param name="t1">1 つ目のシーケンス。</param>
        /// <param name="t2">2 つ目のシーケンス。</param>
        /// <returns>タプルのシーケンス。</returns>
        public static IEnumerable<_<T1, T2>> Zip<T1, T2>(this IEnumerable<T1> t1, IEnumerable<T2> t2)
        {
            using (var itr1 = t1.GetEnumerator())
            using (var itr2 = t2.GetEnumerator())
            {
                while (itr1.MoveNext() && itr2.MoveNext())
                    yield return Tpl.Of(itr1.Current, itr2.Current);
            }
        }

        /// <summary>
        /// 対象と引数を 3 要素のタプルにまとめます。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T3">3 つ目のシーケンスの型。</typeparam>
        /// <param name="t1">1 つ目のシーケンス。</param>
        /// <param name="t2">2 つ目のシーケンス。</param>
        /// <param name="t3">3 つ目のシーケンス。</param>
        /// <returns>タプルのシーケンス。</returns>
        public static IEnumerable<_<T1, T2, T3>> Zip<T1, T2, T3>(this IEnumerable<T1> t1, IEnumerable<T2> t2, IEnumerable<T3> t3)
        {
            using (var itr1 = t1.GetEnumerator())
            using (var itr2 = t2.GetEnumerator())
            using (var itr3 = t3.GetEnumerator())
            {
                while (itr1.MoveNext() && itr2.MoveNext() && itr3.MoveNext())
                    yield return Tpl.Of(itr1.Current, itr2.Current, itr3.Current);
            }
        }

        /// <summary>
        /// 対象と引数を 4 要素のタプルにまとめます。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T3">3 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T4">4 つ目のシーケンスの型。</typeparam>
        /// <param name="t1">1 つ目のシーケンス。</param>
        /// <param name="t2">2 つ目のシーケンス。</param>
        /// <param name="t3">3 つ目のシーケンス。</param>
        /// <param name="t4">4 つ目のシーケンス。</param>
        /// <returns>タプルのシーケンス。</returns>
        public static IEnumerable<_<T1, T2, T3, T4>> Zip<T1, T2, T3, T4>(this IEnumerable<T1> t1, IEnumerable<T2> t2, IEnumerable<T3> t3, IEnumerable<T4> t4)
        {
            using (var itr1 = t1.GetEnumerator())
            using (var itr2 = t2.GetEnumerator())
            using (var itr3 = t3.GetEnumerator())
            using (var itr4 = t4.GetEnumerator())
            {
                while (itr1.MoveNext() && itr2.MoveNext() && itr3.MoveNext() && itr4.MoveNext())
                    yield return Tpl.Of(itr1.Current, itr2.Current, itr3.Current, itr4.Current);
            }
        }

        /// <summary>
        /// 対象と引数を 5 要素のタプルにまとめます。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T3">3 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T4">4 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T5">5 つ目のシーケンスの型。</typeparam>
        /// <param name="t1">1 つ目のシーケンス。</param>
        /// <param name="t2">2 つ目のシーケンス。</param>
        /// <param name="t3">3 つ目のシーケンス。</param>
        /// <param name="t4">4 つ目のシーケンス。</param>
        /// <param name="t5">5 つ目のシーケンス。</param>
        /// <returns>タプルのシーケンス。</returns>
        public static IEnumerable<_<T1, T2, T3, T4, T5>> Zip<T1, T2, T3, T4, T5>(this IEnumerable<T1> t1, IEnumerable<T2> t2, IEnumerable<T3> t3, IEnumerable<T4> t4, IEnumerable<T5> t5)
        {
            using (var itr1 = t1.GetEnumerator())
            using (var itr2 = t2.GetEnumerator())
            using (var itr3 = t3.GetEnumerator())
            using (var itr4 = t4.GetEnumerator())
            using (var itr5 = t5.GetEnumerator())
            {
                while (itr1.MoveNext() && itr2.MoveNext() && itr3.MoveNext() && itr4.MoveNext() && itr5.MoveNext())
                    yield return Tpl.Of(itr1.Current, itr2.Current, itr3.Current, itr4.Current, itr5.Current);
            }
        }

        /// <summary>
        /// 対象と引数を 6 要素のタプルにまとめます。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T3">3 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T4">4 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T5">5 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T6">6 つ目のシーケンスの型。</typeparam>
        /// <param name="t1">1 つ目のシーケンス。</param>
        /// <param name="t2">2 つ目のシーケンス。</param>
        /// <param name="t3">3 つ目のシーケンス。</param>
        /// <param name="t4">4 つ目のシーケンス。</param>
        /// <param name="t5">5 つ目のシーケンス。</param>
        /// <param name="t6">6 つ目のシーケンス。</param>
        /// <returns>タプルのシーケンス。</returns>
        public static IEnumerable<_<T1, T2, T3, T4, T5, T6>> Zip<T1, T2, T3, T4, T5, T6>(this IEnumerable<T1> t1, IEnumerable<T2> t2, IEnumerable<T3> t3, IEnumerable<T4> t4, IEnumerable<T5> t5, IEnumerable<T6> t6)
        {
            using (var itr1 = t1.GetEnumerator())
            using (var itr2 = t2.GetEnumerator())
            using (var itr3 = t3.GetEnumerator())
            using (var itr4 = t4.GetEnumerator())
            using (var itr5 = t5.GetEnumerator())
            using (var itr6 = t6.GetEnumerator())
            {
                while (itr1.MoveNext() && itr2.MoveNext() && itr3.MoveNext() && itr4.MoveNext() && itr5.MoveNext() && itr6.MoveNext())
                    yield return Tpl.Of(itr1.Current, itr2.Current, itr3.Current, itr4.Current, itr5.Current, itr6.Current);
            }
        }

        /// <summary>
        /// 対象と引数を 7 要素のタプルにまとめます。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T3">3 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T4">4 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T5">5 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T6">6 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T7">7 つ目のシーケンスの型。</typeparam>
        /// <param name="t1">1 つ目のシーケンス。</param>
        /// <param name="t2">2 つ目のシーケンス。</param>
        /// <param name="t3">3 つ目のシーケンス。</param>
        /// <param name="t4">4 つ目のシーケンス。</param>
        /// <param name="t5">5 つ目のシーケンス。</param>
        /// <param name="t6">6 つ目のシーケンス。</param>
        /// <param name="t7">7 つ目のシーケンス。</param>
        /// <returns>タプルのシーケンス。</returns>
        public static IEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> Zip<T1, T2, T3, T4, T5, T6, T7>(this IEnumerable<T1> t1, IEnumerable<T2> t2, IEnumerable<T3> t3, IEnumerable<T4> t4, IEnumerable<T5> t5, IEnumerable<T6> t6, IEnumerable<T7> t7)
        {
            using (var itr1 = t1.GetEnumerator())
            using (var itr2 = t2.GetEnumerator())
            using (var itr3 = t3.GetEnumerator())
            using (var itr4 = t4.GetEnumerator())
            using (var itr5 = t5.GetEnumerator())
            using (var itr6 = t6.GetEnumerator())
            using (var itr7 = t7.GetEnumerator())
            {
                while (itr1.MoveNext() && itr2.MoveNext() && itr3.MoveNext() && itr4.MoveNext() && itr5.MoveNext() && itr6.MoveNext() && itr7.MoveNext())
                    yield return Tpl.Of(itr1.Current, itr2.Current, itr3.Current, itr4.Current, itr5.Current, itr6.Current, itr7.Current);
            }
        }

        /// <summary>
        /// 対象と引数を 8 要素のタプルにまとめます。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T3">3 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T4">4 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T5">5 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T6">6 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T7">7 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T8">8 つ目のシーケンスの型。</typeparam>
        /// <param name="t1">1 つ目のシーケンス。</param>
        /// <param name="t2">2 つ目のシーケンス。</param>
        /// <param name="t3">3 つ目のシーケンス。</param>
        /// <param name="t4">4 つ目のシーケンス。</param>
        /// <param name="t5">5 つ目のシーケンス。</param>
        /// <param name="t6">6 つ目のシーケンス。</param>
        /// <param name="t7">7 つ目のシーケンス。</param>
        /// <param name="t8">8 つ目のシーケンス。</param>
        /// <returns>タプルのシーケンス。</returns>
        public static IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> Zip<T1, T2, T3, T4, T5, T6, T7, T8>(this IEnumerable<T1> t1, IEnumerable<T2> t2, IEnumerable<T3> t3, IEnumerable<T4> t4, IEnumerable<T5> t5, IEnumerable<T6> t6, IEnumerable<T7> t7, IEnumerable<T8> t8)
        {
            using (var itr1 = t1.GetEnumerator())
            using (var itr2 = t2.GetEnumerator())
            using (var itr3 = t3.GetEnumerator())
            using (var itr4 = t4.GetEnumerator())
            using (var itr5 = t5.GetEnumerator())
            using (var itr6 = t6.GetEnumerator())
            using (var itr7 = t7.GetEnumerator())
            using (var itr8 = t8.GetEnumerator())
            {
                while (itr1.MoveNext() && itr2.MoveNext() && itr3.MoveNext() && itr4.MoveNext() && itr5.MoveNext() && itr6.MoveNext() && itr7.MoveNext() && itr8.MoveNext())
                    yield return Tpl.Of(itr1.Current, itr2.Current, itr3.Current, itr4.Current, itr5.Current, itr6.Current, itr7.Current, itr8.Current);
            }
        }

        /// <summary>
        /// 対象と引数を 9 要素のタプルにまとめます。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T3">3 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T4">4 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T5">5 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T6">6 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T7">7 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T8">8 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T9">9 つ目のシーケンスの型。</typeparam>
        /// <param name="t1">1 つ目のシーケンス。</param>
        /// <param name="t2">2 つ目のシーケンス。</param>
        /// <param name="t3">3 つ目のシーケンス。</param>
        /// <param name="t4">4 つ目のシーケンス。</param>
        /// <param name="t5">5 つ目のシーケンス。</param>
        /// <param name="t6">6 つ目のシーケンス。</param>
        /// <param name="t7">7 つ目のシーケンス。</param>
        /// <param name="t8">8 つ目のシーケンス。</param>
        /// <param name="t9">9 つ目のシーケンス。</param>
        /// <returns>タプルのシーケンス。</returns>
        public static IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IEnumerable<T1> t1, IEnumerable<T2> t2, IEnumerable<T3> t3, IEnumerable<T4> t4, IEnumerable<T5> t5, IEnumerable<T6> t6, IEnumerable<T7> t7, IEnumerable<T8> t8, IEnumerable<T9> t9)
        {
            using (var itr1 = t1.GetEnumerator())
            using (var itr2 = t2.GetEnumerator())
            using (var itr3 = t3.GetEnumerator())
            using (var itr4 = t4.GetEnumerator())
            using (var itr5 = t5.GetEnumerator())
            using (var itr6 = t6.GetEnumerator())
            using (var itr7 = t7.GetEnumerator())
            using (var itr8 = t8.GetEnumerator())
            using (var itr9 = t9.GetEnumerator())
            {
                while (itr1.MoveNext() && itr2.MoveNext() && itr3.MoveNext() && itr4.MoveNext() && itr5.MoveNext() && itr6.MoveNext() && itr7.MoveNext() && itr8.MoveNext() && itr9.MoveNext())
                    yield return Tpl.Of(itr1.Current, itr2.Current, itr3.Current, itr4.Current, itr5.Current, itr6.Current, itr7.Current, itr8.Current, itr9.Current);
            }
        }

        /// <summary>
        /// 対象と引数を 10 要素のタプルにまとめます。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T3">3 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T4">4 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T5">5 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T6">6 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T7">7 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T8">8 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T9">9 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T10">10 つ目のシーケンスの型。</typeparam>
        /// <param name="t1">1 つ目のシーケンス。</param>
        /// <param name="t2">2 つ目のシーケンス。</param>
        /// <param name="t3">3 つ目のシーケンス。</param>
        /// <param name="t4">4 つ目のシーケンス。</param>
        /// <param name="t5">5 つ目のシーケンス。</param>
        /// <param name="t6">6 つ目のシーケンス。</param>
        /// <param name="t7">7 つ目のシーケンス。</param>
        /// <param name="t8">8 つ目のシーケンス。</param>
        /// <param name="t9">9 つ目のシーケンス。</param>
        /// <param name="t10">10 つ目のシーケンス。</param>
        /// <returns>タプルのシーケンス。</returns>
        public static IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IEnumerable<T1> t1, IEnumerable<T2> t2, IEnumerable<T3> t3, IEnumerable<T4> t4, IEnumerable<T5> t5, IEnumerable<T6> t6, IEnumerable<T7> t7, IEnumerable<T8> t8, IEnumerable<T9> t9, IEnumerable<T10> t10)
        {
            using (var itr1 = t1.GetEnumerator())
            using (var itr2 = t2.GetEnumerator())
            using (var itr3 = t3.GetEnumerator())
            using (var itr4 = t4.GetEnumerator())
            using (var itr5 = t5.GetEnumerator())
            using (var itr6 = t6.GetEnumerator())
            using (var itr7 = t7.GetEnumerator())
            using (var itr8 = t8.GetEnumerator())
            using (var itr9 = t9.GetEnumerator())
            using (var itr10 = t10.GetEnumerator())
            {
                while (itr1.MoveNext() && itr2.MoveNext() && itr3.MoveNext() && itr4.MoveNext() && itr5.MoveNext() && itr6.MoveNext() && itr7.MoveNext() && itr8.MoveNext() && itr9.MoveNext() && itr10.MoveNext())
                    yield return Tpl.Of(itr1.Current, itr2.Current, itr3.Current, itr4.Current, itr5.Current, itr6.Current, itr7.Current, itr8.Current, itr9.Current, itr10.Current);
            }
        }

        #endregion

        #region Unzipメソッド

        /// <summary>
        /// Zip したものを元に戻します。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <param name="self">タプルのシーケンス。</param>
        /// <returns>シーケンスのタプル。</returns>
        public static _<IEnumerable<T1>, IEnumerable<T2>> Unzip<T1, T2>(this IEnumerable<_<T1, T2>> self)
        {
            return Tpl.Of(self.Select(t => t._1), self.Select(t => t._2));
        }

        /// <summary>
        /// Zip したものを元に戻します。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T3">3 つ目のシーケンスの型。</typeparam>
        /// <param name="self">タプルのシーケンス。</param>
        /// <returns>シーケンスのタプル。</returns>
        public static _<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>> Unzip<T1, T2, T3>(this IEnumerable<_<T1, T2, T3>> self)
        {
            return Tpl.Of(self.Select(t => t._1), self.Select(t => t._2), self.Select(t => t._3));
        }

        /// <summary>
        /// Zip したものを元に戻します。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T3">3 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T4">4 つ目のシーケンスの型。</typeparam>
        /// <param name="self">タプルのシーケンス。</param>
        /// <returns>シーケンスのタプル。</returns>
        public static _<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>> Unzip<T1, T2, T3, T4>(this IEnumerable<_<T1, T2, T3, T4>> self)
        {
            return Tpl.Of(self.Select(t => t._1), self.Select(t => t._2), self.Select(t => t._3), self.Select(t => t._4));
        }

        /// <summary>
        /// Zip したものを元に戻します。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T3">3 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T4">4 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T5">5 つ目のシーケンスの型。</typeparam>
        /// <param name="self">タプルのシーケンス。</param>
        /// <returns>シーケンスのタプル。</returns>
        public static _<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>> Unzip<T1, T2, T3, T4, T5>(this IEnumerable<_<T1, T2, T3, T4, T5>> self)
        {
            return Tpl.Of(self.Select(t => t._1), self.Select(t => t._2), self.Select(t => t._3), self.Select(t => t._4), self.Select(t => t._5));
        }

        /// <summary>
        /// Zip したものを元に戻します。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T3">3 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T4">4 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T5">5 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T6">6 つ目のシーケンスの型。</typeparam>
        /// <param name="self">タプルのシーケンス。</param>
        /// <returns>シーケンスのタプル。</returns>
        public static _<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>> Unzip<T1, T2, T3, T4, T5, T6>(this IEnumerable<_<T1, T2, T3, T4, T5, T6>> self)
        {
            return Tpl.Of(self.Select(t => t._1), self.Select(t => t._2), self.Select(t => t._3), self.Select(t => t._4), self.Select(t => t._5), self.Select(t => t._6));
        }

        /// <summary>
        /// Zip したものを元に戻します。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T3">3 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T4">4 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T5">5 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T6">6 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T7">7 つ目のシーケンスの型。</typeparam>
        /// <param name="self">タプルのシーケンス。</param>
        /// <returns>シーケンスのタプル。</returns>
        public static _<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>> Unzip<T1, T2, T3, T4, T5, T6, T7>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> self)
        {
            return Tpl.Of(self.Select(t => t._1), self.Select(t => t._2), self.Select(t => t._3), self.Select(t => t._4), self.Select(t => t._5), self.Select(t => t._6), self.Select(t => t._7));
        }

        /// <summary>
        /// Zip したものを元に戻します。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T3">3 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T4">4 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T5">5 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T6">6 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T7">7 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T8">8 つ目のシーケンスの型。</typeparam>
        /// <param name="self">タプルのシーケンス。</param>
        /// <returns>シーケンスのタプル。</returns>
        public static _<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>, IEnumerable<T8>> Unzip<T1, T2, T3, T4, T5, T6, T7, T8>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> self)
        {
            return Tpl.Of(self.Select(t => t._1), self.Select(t => t._2), self.Select(t => t._3), self.Select(t => t._4), self.Select(t => t._5), self.Select(t => t._6), self.Select(t => t._7), self.Select(t => t._8));
        }

        /// <summary>
        /// Zip したものを元に戻します。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T3">3 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T4">4 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T5">5 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T6">6 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T7">7 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T8">8 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T9">9 つ目のシーケンスの型。</typeparam>
        /// <param name="self">タプルのシーケンス。</param>
        /// <returns>シーケンスのタプル。</returns>
        public static _<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>, IEnumerable<T8>, IEnumerable<T9>> Unzip<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> self)
        {
            return Tpl.Of(self.Select(t => t._1), self.Select(t => t._2), self.Select(t => t._3), self.Select(t => t._4), self.Select(t => t._5), self.Select(t => t._6), self.Select(t => t._7), self.Select(t => t._8), self.Select(t => t._9));
        }

        /// <summary>
        /// Zip したものを元に戻します。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T3">3 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T4">4 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T5">5 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T6">6 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T7">7 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T8">8 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T9">9 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T10">10 つ目のシーケンスの型。</typeparam>
        /// <param name="self">タプルのシーケンス。</param>
        /// <returns>シーケンスのタプル。</returns>
        public static _<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>, IEnumerable<T8>, IEnumerable<T9>, IEnumerable<T10>> Unzip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> self)
        {
            return Tpl.Of(self.Select(t => t._1), self.Select(t => t._2), self.Select(t => t._3), self.Select(t => t._4), self.Select(t => t._5), self.Select(t => t._6), self.Select(t => t._7), self.Select(t => t._8), self.Select(t => t._9), self.Select(t => t._10));
        }

        #endregion

        #region ZipWithメソッド

        /// <summary>
        /// 引数に処理を適用した結果を返します。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="R">処理の結果の型。</typeparam>
        /// <param name="t1">処理に渡す 1 つ目のシーケンス。</param>
        /// <param name="t2">処理に渡す 2 つ目のシーケンス。</param>
        /// <param name="func">処理。</param>
        /// <returns>処理の結果。</returns>
        public static IEnumerable<R> ZipWith<T1, T2, R>(this IEnumerable<T1> t1, IEnumerable<T2> t2, Func<T1, T2, R> func)
        {
            using (var itr1 = t1.GetEnumerator())
            using (var itr2 = t2.GetEnumerator())
            {
                while (itr1.MoveNext() && itr2.MoveNext())
                    yield return func(itr1.Current, itr2.Current);
            }
        }

        /// <summary>
        /// 引数に処理を適用した結果を返します。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T3">3 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="R">処理の結果の型。</typeparam>
        /// <param name="t1">処理に渡す 1 つ目のシーケンス。</param>
        /// <param name="t2">処理に渡す 2 つ目のシーケンス。</param>
        /// <param name="t3">処理に渡す 3 つ目のシーケンス。</param>
        /// <param name="func">処理。</param>
        /// <returns>処理の結果。</returns>
        public static IEnumerable<R> ZipWith<T1, T2, T3, R>(this IEnumerable<T1> t1, IEnumerable<T2> t2, IEnumerable<T3> t3, Func<T1, T2, T3, R> func)
        {
            using (var itr1 = t1.GetEnumerator())
            using (var itr2 = t2.GetEnumerator())
            using (var itr3 = t3.GetEnumerator())
            {
                while (itr1.MoveNext() && itr2.MoveNext() && itr3.MoveNext())
                    yield return func(itr1.Current, itr2.Current, itr3.Current);
            }
        }

        /// <summary>
        /// 引数に処理を適用した結果を返します。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T3">3 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T4">4 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="R">処理の結果の型。</typeparam>
        /// <param name="t1">処理に渡す 1 つ目のシーケンス。</param>
        /// <param name="t2">処理に渡す 2 つ目のシーケンス。</param>
        /// <param name="t3">処理に渡す 3 つ目のシーケンス。</param>
        /// <param name="t4">処理に渡す 4 つ目のシーケンス。</param>
        /// <param name="func">処理。</param>
        /// <returns>処理の結果。</returns>
        public static IEnumerable<R> ZipWith<T1, T2, T3, T4, R>(this IEnumerable<T1> t1, IEnumerable<T2> t2, IEnumerable<T3> t3, IEnumerable<T4> t4, Func<T1, T2, T3, T4, R> func)
        {
            using (var itr1 = t1.GetEnumerator())
            using (var itr2 = t2.GetEnumerator())
            using (var itr3 = t3.GetEnumerator())
            using (var itr4 = t4.GetEnumerator())
            {
                while (itr1.MoveNext() && itr2.MoveNext() && itr3.MoveNext() && itr4.MoveNext())
                    yield return func(itr1.Current, itr2.Current, itr3.Current, itr4.Current);
            }
        }

        /// <summary>
        /// 引数に処理を適用した結果を返します。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T3">3 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T4">4 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T5">5 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="R">処理の結果の型。</typeparam>
        /// <param name="t1">処理に渡す 1 つ目のシーケンス。</param>
        /// <param name="t2">処理に渡す 2 つ目のシーケンス。</param>
        /// <param name="t3">処理に渡す 3 つ目のシーケンス。</param>
        /// <param name="t4">処理に渡す 4 つ目のシーケンス。</param>
        /// <param name="t5">処理に渡す 5 つ目のシーケンス。</param>
        /// <param name="func">処理。</param>
        /// <returns>処理の結果。</returns>
        public static IEnumerable<R> ZipWith<T1, T2, T3, T4, T5, R>(this IEnumerable<T1> t1, IEnumerable<T2> t2, IEnumerable<T3> t3, IEnumerable<T4> t4, IEnumerable<T5> t5, Func<T1, T2, T3, T4, T5, R> func)
        {
            using (var itr1 = t1.GetEnumerator())
            using (var itr2 = t2.GetEnumerator())
            using (var itr3 = t3.GetEnumerator())
            using (var itr4 = t4.GetEnumerator())
            using (var itr5 = t5.GetEnumerator())
            {
                while (itr1.MoveNext() && itr2.MoveNext() && itr3.MoveNext() && itr4.MoveNext() && itr5.MoveNext())
                    yield return func(itr1.Current, itr2.Current, itr3.Current, itr4.Current, itr5.Current);
            }
        }

        /// <summary>
        /// 引数に処理を適用した結果を返します。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T3">3 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T4">4 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T5">5 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T6">6 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="R">処理の結果の型。</typeparam>
        /// <param name="t1">処理に渡す 1 つ目のシーケンス。</param>
        /// <param name="t2">処理に渡す 2 つ目のシーケンス。</param>
        /// <param name="t3">処理に渡す 3 つ目のシーケンス。</param>
        /// <param name="t4">処理に渡す 4 つ目のシーケンス。</param>
        /// <param name="t5">処理に渡す 5 つ目のシーケンス。</param>
        /// <param name="t6">処理に渡す 6 つ目のシーケンス。</param>
        /// <param name="func">処理。</param>
        /// <returns>処理の結果。</returns>
        public static IEnumerable<R> ZipWith<T1, T2, T3, T4, T5, T6, R>(this IEnumerable<T1> t1, IEnumerable<T2> t2, IEnumerable<T3> t3, IEnumerable<T4> t4, IEnumerable<T5> t5, IEnumerable<T6> t6, Func<T1, T2, T3, T4, T5, T6, R> func)
        {
            using (var itr1 = t1.GetEnumerator())
            using (var itr2 = t2.GetEnumerator())
            using (var itr3 = t3.GetEnumerator())
            using (var itr4 = t4.GetEnumerator())
            using (var itr5 = t5.GetEnumerator())
            using (var itr6 = t6.GetEnumerator())
            {
                while (itr1.MoveNext() && itr2.MoveNext() && itr3.MoveNext() && itr4.MoveNext() && itr5.MoveNext() && itr6.MoveNext())
                    yield return func(itr1.Current, itr2.Current, itr3.Current, itr4.Current, itr5.Current, itr6.Current);
            }
        }

        /// <summary>
        /// 引数に処理を適用した結果を返します。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T3">3 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T4">4 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T5">5 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T6">6 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T7">7 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="R">処理の結果の型。</typeparam>
        /// <param name="t1">処理に渡す 1 つ目のシーケンス。</param>
        /// <param name="t2">処理に渡す 2 つ目のシーケンス。</param>
        /// <param name="t3">処理に渡す 3 つ目のシーケンス。</param>
        /// <param name="t4">処理に渡す 4 つ目のシーケンス。</param>
        /// <param name="t5">処理に渡す 5 つ目のシーケンス。</param>
        /// <param name="t6">処理に渡す 6 つ目のシーケンス。</param>
        /// <param name="t7">処理に渡す 7 つ目のシーケンス。</param>
        /// <param name="func">処理。</param>
        /// <returns>処理の結果。</returns>
        public static IEnumerable<R> ZipWith<T1, T2, T3, T4, T5, T6, T7, R>(this IEnumerable<T1> t1, IEnumerable<T2> t2, IEnumerable<T3> t3, IEnumerable<T4> t4, IEnumerable<T5> t5, IEnumerable<T6> t6, IEnumerable<T7> t7, Func<T1, T2, T3, T4, T5, T6, T7, R> func)
        {
            using (var itr1 = t1.GetEnumerator())
            using (var itr2 = t2.GetEnumerator())
            using (var itr3 = t3.GetEnumerator())
            using (var itr4 = t4.GetEnumerator())
            using (var itr5 = t5.GetEnumerator())
            using (var itr6 = t6.GetEnumerator())
            using (var itr7 = t7.GetEnumerator())
            {
                while (itr1.MoveNext() && itr2.MoveNext() && itr3.MoveNext() && itr4.MoveNext() && itr5.MoveNext() && itr6.MoveNext() && itr7.MoveNext())
                    yield return func(itr1.Current, itr2.Current, itr3.Current, itr4.Current, itr5.Current, itr6.Current, itr7.Current);
            }
        }

        /// <summary>
        /// 引数に処理を適用した結果を返します。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T3">3 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T4">4 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T5">5 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T6">6 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T7">7 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T8">8 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="R">処理の結果の型。</typeparam>
        /// <param name="t1">処理に渡す 1 つ目のシーケンス。</param>
        /// <param name="t2">処理に渡す 2 つ目のシーケンス。</param>
        /// <param name="t3">処理に渡す 3 つ目のシーケンス。</param>
        /// <param name="t4">処理に渡す 4 つ目のシーケンス。</param>
        /// <param name="t5">処理に渡す 5 つ目のシーケンス。</param>
        /// <param name="t6">処理に渡す 6 つ目のシーケンス。</param>
        /// <param name="t7">処理に渡す 7 つ目のシーケンス。</param>
        /// <param name="t8">処理に渡す 8 つ目のシーケンス。</param>
        /// <param name="func">処理。</param>
        /// <returns>処理の結果。</returns>
        public static IEnumerable<R> ZipWith<T1, T2, T3, T4, T5, T6, T7, T8, R>(this IEnumerable<T1> t1, IEnumerable<T2> t2, IEnumerable<T3> t3, IEnumerable<T4> t4, IEnumerable<T5> t5, IEnumerable<T6> t6, IEnumerable<T7> t7, IEnumerable<T8> t8, Func<T1, T2, T3, T4, T5, T6, T7, T8, R> func)
        {
            using (var itr1 = t1.GetEnumerator())
            using (var itr2 = t2.GetEnumerator())
            using (var itr3 = t3.GetEnumerator())
            using (var itr4 = t4.GetEnumerator())
            using (var itr5 = t5.GetEnumerator())
            using (var itr6 = t6.GetEnumerator())
            using (var itr7 = t7.GetEnumerator())
            using (var itr8 = t8.GetEnumerator())
            {
                while (itr1.MoveNext() && itr2.MoveNext() && itr3.MoveNext() && itr4.MoveNext() && itr5.MoveNext() && itr6.MoveNext() && itr7.MoveNext() && itr8.MoveNext())
                    yield return func(itr1.Current, itr2.Current, itr3.Current, itr4.Current, itr5.Current, itr6.Current, itr7.Current, itr8.Current);
            }
        }

        /// <summary>
        /// 引数に処理を適用した結果を返します。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T3">3 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T4">4 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T5">5 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T6">6 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T7">7 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T8">8 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T9">9 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="R">処理の結果の型。</typeparam>
        /// <param name="t1">処理に渡す 1 つ目のシーケンス。</param>
        /// <param name="t2">処理に渡す 2 つ目のシーケンス。</param>
        /// <param name="t3">処理に渡す 3 つ目のシーケンス。</param>
        /// <param name="t4">処理に渡す 4 つ目のシーケンス。</param>
        /// <param name="t5">処理に渡す 5 つ目のシーケンス。</param>
        /// <param name="t6">処理に渡す 6 つ目のシーケンス。</param>
        /// <param name="t7">処理に渡す 7 つ目のシーケンス。</param>
        /// <param name="t8">処理に渡す 8 つ目のシーケンス。</param>
        /// <param name="t9">処理に渡す 9 つ目のシーケンス。</param>
        /// <param name="func">処理。</param>
        /// <returns>処理の結果。</returns>
        public static IEnumerable<R> ZipWith<T1, T2, T3, T4, T5, T6, T7, T8, T9, R>(this IEnumerable<T1> t1, IEnumerable<T2> t2, IEnumerable<T3> t3, IEnumerable<T4> t4, IEnumerable<T5> t5, IEnumerable<T6> t6, IEnumerable<T7> t7, IEnumerable<T8> t8, IEnumerable<T9> t9, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, R> func)
        {
            using (var itr1 = t1.GetEnumerator())
            using (var itr2 = t2.GetEnumerator())
            using (var itr3 = t3.GetEnumerator())
            using (var itr4 = t4.GetEnumerator())
            using (var itr5 = t5.GetEnumerator())
            using (var itr6 = t6.GetEnumerator())
            using (var itr7 = t7.GetEnumerator())
            using (var itr8 = t8.GetEnumerator())
            using (var itr9 = t9.GetEnumerator())
            {
                while (itr1.MoveNext() && itr2.MoveNext() && itr3.MoveNext() && itr4.MoveNext() && itr5.MoveNext() && itr6.MoveNext() && itr7.MoveNext() && itr8.MoveNext() && itr9.MoveNext())
                    yield return func(itr1.Current, itr2.Current, itr3.Current, itr4.Current, itr5.Current, itr6.Current, itr7.Current, itr8.Current, itr9.Current);
            }
        }

        /// <summary>
        /// 引数に処理を適用した結果を返します。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T3">3 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T4">4 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T5">5 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T6">6 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T7">7 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T8">8 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T9">9 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T10">10 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="R">処理の結果の型。</typeparam>
        /// <param name="t1">処理に渡す 1 つ目のシーケンス。</param>
        /// <param name="t2">処理に渡す 2 つ目のシーケンス。</param>
        /// <param name="t3">処理に渡す 3 つ目のシーケンス。</param>
        /// <param name="t4">処理に渡す 4 つ目のシーケンス。</param>
        /// <param name="t5">処理に渡す 5 つ目のシーケンス。</param>
        /// <param name="t6">処理に渡す 6 つ目のシーケンス。</param>
        /// <param name="t7">処理に渡す 7 つ目のシーケンス。</param>
        /// <param name="t8">処理に渡す 8 つ目のシーケンス。</param>
        /// <param name="t9">処理に渡す 9 つ目のシーケンス。</param>
        /// <param name="t10">処理に渡す 10 つ目のシーケンス。</param>
        /// <param name="func">処理。</param>
        /// <returns>処理の結果。</returns>
        public static IEnumerable<R> ZipWith<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, R>(this IEnumerable<T1> t1, IEnumerable<T2> t2, IEnumerable<T3> t3, IEnumerable<T4> t4, IEnumerable<T5> t5, IEnumerable<T6> t6, IEnumerable<T7> t7, IEnumerable<T8> t8, IEnumerable<T9> t9, IEnumerable<T10> t10, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, R> func)
        {
            using (var itr1 = t1.GetEnumerator())
            using (var itr2 = t2.GetEnumerator())
            using (var itr3 = t3.GetEnumerator())
            using (var itr4 = t4.GetEnumerator())
            using (var itr5 = t5.GetEnumerator())
            using (var itr6 = t6.GetEnumerator())
            using (var itr7 = t7.GetEnumerator())
            using (var itr8 = t8.GetEnumerator())
            using (var itr9 = t9.GetEnumerator())
            using (var itr10 = t10.GetEnumerator())
            {
                while (itr1.MoveNext() && itr2.MoveNext() && itr3.MoveNext() && itr4.MoveNext() && itr5.MoveNext() && itr6.MoveNext() && itr7.MoveNext() && itr8.MoveNext() && itr9.MoveNext() && itr10.MoveNext())
                    yield return func(itr1.Current, itr2.Current, itr3.Current, itr4.Current, itr5.Current, itr6.Current, itr7.Current, itr8.Current, itr9.Current, itr10.Current);
            }
        }

        #endregion

        #region ZipWithIndexメソッド

        /// <summary>
        /// 対象とインデックスを 2 要素のタプルにまとめます。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <param name="t1">1 つ目のシーケンス。</param>
        /// <returns>インデックスを持ったタプルのシーケンス。</returns>
        public static IEnumerable<_<T1, int>> ZipWithIndex<T1>(this IEnumerable<T1> t1)
        {
            using (var itr1 = t1.GetEnumerator())
            {
                var index = 0;
                while (itr1.MoveNext())
                    yield return Tpl.Of(itr1.Current, index++);
            }
        }

        /// <summary>
        /// 対象と引数とインデックスを 3 要素のタプルにまとめます。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <param name="t1">1 つ目のシーケンス。</param>
        /// <param name="t2">2 つ目のシーケンス。</param>
        /// <returns>インデックスを持ったタプルのシーケンス。</returns>
        public static IEnumerable<_<T1, T2, int>> ZipWithIndex<T1, T2>(this IEnumerable<T1> t1, IEnumerable<T2> t2)
        {
            using (var itr1 = t1.GetEnumerator())
            using (var itr2 = t2.GetEnumerator())
            {
                var index = 0;
                while (itr1.MoveNext() && itr2.MoveNext())
                    yield return Tpl.Of(itr1.Current, itr2.Current, index++);
            }
        }

        /// <summary>
        /// 対象と引数とインデックスを 4 要素のタプルにまとめます。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T3">3 つ目のシーケンスの型。</typeparam>
        /// <param name="t1">1 つ目のシーケンス。</param>
        /// <param name="t2">2 つ目のシーケンス。</param>
        /// <param name="t3">3 つ目のシーケンス。</param>
        /// <returns>インデックスを持ったタプルのシーケンス。</returns>
        public static IEnumerable<_<T1, T2, T3, int>> ZipWithIndex<T1, T2, T3>(this IEnumerable<T1> t1, IEnumerable<T2> t2, IEnumerable<T3> t3)
        {
            using (var itr1 = t1.GetEnumerator())
            using (var itr2 = t2.GetEnumerator())
            using (var itr3 = t3.GetEnumerator())
            {
                var index = 0;
                while (itr1.MoveNext() && itr2.MoveNext() && itr3.MoveNext())
                    yield return Tpl.Of(itr1.Current, itr2.Current, itr3.Current, index++);
            }
        }

        /// <summary>
        /// 対象と引数とインデックスを 5 要素のタプルにまとめます。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T3">3 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T4">4 つ目のシーケンスの型。</typeparam>
        /// <param name="t1">1 つ目のシーケンス。</param>
        /// <param name="t2">2 つ目のシーケンス。</param>
        /// <param name="t3">3 つ目のシーケンス。</param>
        /// <param name="t4">4 つ目のシーケンス。</param>
        /// <returns>インデックスを持ったタプルのシーケンス。</returns>
        public static IEnumerable<_<T1, T2, T3, T4, int>> ZipWithIndex<T1, T2, T3, T4>(this IEnumerable<T1> t1, IEnumerable<T2> t2, IEnumerable<T3> t3, IEnumerable<T4> t4)
        {
            using (var itr1 = t1.GetEnumerator())
            using (var itr2 = t2.GetEnumerator())
            using (var itr3 = t3.GetEnumerator())
            using (var itr4 = t4.GetEnumerator())
            {
                var index = 0;
                while (itr1.MoveNext() && itr2.MoveNext() && itr3.MoveNext() && itr4.MoveNext())
                    yield return Tpl.Of(itr1.Current, itr2.Current, itr3.Current, itr4.Current, index++);
            }
        }

        /// <summary>
        /// 対象と引数とインデックスを 6 要素のタプルにまとめます。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T3">3 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T4">4 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T5">5 つ目のシーケンスの型。</typeparam>
        /// <param name="t1">1 つ目のシーケンス。</param>
        /// <param name="t2">2 つ目のシーケンス。</param>
        /// <param name="t3">3 つ目のシーケンス。</param>
        /// <param name="t4">4 つ目のシーケンス。</param>
        /// <param name="t5">5 つ目のシーケンス。</param>
        /// <returns>インデックスを持ったタプルのシーケンス。</returns>
        public static IEnumerable<_<T1, T2, T3, T4, T5, int>> ZipWithIndex<T1, T2, T3, T4, T5>(this IEnumerable<T1> t1, IEnumerable<T2> t2, IEnumerable<T3> t3, IEnumerable<T4> t4, IEnumerable<T5> t5)
        {
            using (var itr1 = t1.GetEnumerator())
            using (var itr2 = t2.GetEnumerator())
            using (var itr3 = t3.GetEnumerator())
            using (var itr4 = t4.GetEnumerator())
            using (var itr5 = t5.GetEnumerator())
            {
                var index = 0;
                while (itr1.MoveNext() && itr2.MoveNext() && itr3.MoveNext() && itr4.MoveNext() && itr5.MoveNext())
                    yield return Tpl.Of(itr1.Current, itr2.Current, itr3.Current, itr4.Current, itr5.Current, index++);
            }
        }

        /// <summary>
        /// 対象と引数とインデックスを 7 要素のタプルにまとめます。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T3">3 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T4">4 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T5">5 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T6">6 つ目のシーケンスの型。</typeparam>
        /// <param name="t1">1 つ目のシーケンス。</param>
        /// <param name="t2">2 つ目のシーケンス。</param>
        /// <param name="t3">3 つ目のシーケンス。</param>
        /// <param name="t4">4 つ目のシーケンス。</param>
        /// <param name="t5">5 つ目のシーケンス。</param>
        /// <param name="t6">6 つ目のシーケンス。</param>
        /// <returns>インデックスを持ったタプルのシーケンス。</returns>
        public static IEnumerable<_<T1, T2, T3, T4, T5, T6, int>> ZipWithIndex<T1, T2, T3, T4, T5, T6>(this IEnumerable<T1> t1, IEnumerable<T2> t2, IEnumerable<T3> t3, IEnumerable<T4> t4, IEnumerable<T5> t5, IEnumerable<T6> t6)
        {
            using (var itr1 = t1.GetEnumerator())
            using (var itr2 = t2.GetEnumerator())
            using (var itr3 = t3.GetEnumerator())
            using (var itr4 = t4.GetEnumerator())
            using (var itr5 = t5.GetEnumerator())
            using (var itr6 = t6.GetEnumerator())
            {
                var index = 0;
                while (itr1.MoveNext() && itr2.MoveNext() && itr3.MoveNext() && itr4.MoveNext() && itr5.MoveNext() && itr6.MoveNext())
                    yield return Tpl.Of(itr1.Current, itr2.Current, itr3.Current, itr4.Current, itr5.Current, itr6.Current, index++);
            }
        }

        /// <summary>
        /// 対象と引数とインデックスを 8 要素のタプルにまとめます。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T3">3 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T4">4 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T5">5 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T6">6 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T7">7 つ目のシーケンスの型。</typeparam>
        /// <param name="t1">1 つ目のシーケンス。</param>
        /// <param name="t2">2 つ目のシーケンス。</param>
        /// <param name="t3">3 つ目のシーケンス。</param>
        /// <param name="t4">4 つ目のシーケンス。</param>
        /// <param name="t5">5 つ目のシーケンス。</param>
        /// <param name="t6">6 つ目のシーケンス。</param>
        /// <param name="t7">7 つ目のシーケンス。</param>
        /// <returns>インデックスを持ったタプルのシーケンス。</returns>
        public static IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, int>> ZipWithIndex<T1, T2, T3, T4, T5, T6, T7>(this IEnumerable<T1> t1, IEnumerable<T2> t2, IEnumerable<T3> t3, IEnumerable<T4> t4, IEnumerable<T5> t5, IEnumerable<T6> t6, IEnumerable<T7> t7)
        {
            using (var itr1 = t1.GetEnumerator())
            using (var itr2 = t2.GetEnumerator())
            using (var itr3 = t3.GetEnumerator())
            using (var itr4 = t4.GetEnumerator())
            using (var itr5 = t5.GetEnumerator())
            using (var itr6 = t6.GetEnumerator())
            using (var itr7 = t7.GetEnumerator())
            {
                var index = 0;
                while (itr1.MoveNext() && itr2.MoveNext() && itr3.MoveNext() && itr4.MoveNext() && itr5.MoveNext() && itr6.MoveNext() && itr7.MoveNext())
                    yield return Tpl.Of(itr1.Current, itr2.Current, itr3.Current, itr4.Current, itr5.Current, itr6.Current, itr7.Current, index++);
            }
        }

        /// <summary>
        /// 対象と引数とインデックスを 9 要素のタプルにまとめます。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T3">3 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T4">4 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T5">5 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T6">6 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T7">7 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T8">8 つ目のシーケンスの型。</typeparam>
        /// <param name="t1">1 つ目のシーケンス。</param>
        /// <param name="t2">2 つ目のシーケンス。</param>
        /// <param name="t3">3 つ目のシーケンス。</param>
        /// <param name="t4">4 つ目のシーケンス。</param>
        /// <param name="t5">5 つ目のシーケンス。</param>
        /// <param name="t6">6 つ目のシーケンス。</param>
        /// <param name="t7">7 つ目のシーケンス。</param>
        /// <param name="t8">8 つ目のシーケンス。</param>
        /// <returns>インデックスを持ったタプルのシーケンス。</returns>
        public static IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, int>> ZipWithIndex<T1, T2, T3, T4, T5, T6, T7, T8>(this IEnumerable<T1> t1, IEnumerable<T2> t2, IEnumerable<T3> t3, IEnumerable<T4> t4, IEnumerable<T5> t5, IEnumerable<T6> t6, IEnumerable<T7> t7, IEnumerable<T8> t8)
        {
            using (var itr1 = t1.GetEnumerator())
            using (var itr2 = t2.GetEnumerator())
            using (var itr3 = t3.GetEnumerator())
            using (var itr4 = t4.GetEnumerator())
            using (var itr5 = t5.GetEnumerator())
            using (var itr6 = t6.GetEnumerator())
            using (var itr7 = t7.GetEnumerator())
            using (var itr8 = t8.GetEnumerator())
            {
                var index = 0;
                while (itr1.MoveNext() && itr2.MoveNext() && itr3.MoveNext() && itr4.MoveNext() && itr5.MoveNext() && itr6.MoveNext() && itr7.MoveNext() && itr8.MoveNext())
                    yield return Tpl.Of(itr1.Current, itr2.Current, itr3.Current, itr4.Current, itr5.Current, itr6.Current, itr7.Current, itr8.Current, index++);
            }
        }

        /// <summary>
        /// 対象と引数とインデックスを 10 要素のタプルにまとめます。
        /// </summary>
        /// <typeparam name="T1">1 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T2">2 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T3">3 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T4">4 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T5">5 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T6">6 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T7">7 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T8">8 つ目のシーケンスの型。</typeparam>
        /// <typeparam name="T9">9 つ目のシーケンスの型。</typeparam>
        /// <param name="t1">1 つ目のシーケンス。</param>
        /// <param name="t2">2 つ目のシーケンス。</param>
        /// <param name="t3">3 つ目のシーケンス。</param>
        /// <param name="t4">4 つ目のシーケンス。</param>
        /// <param name="t5">5 つ目のシーケンス。</param>
        /// <param name="t6">6 つ目のシーケンス。</param>
        /// <param name="t7">7 つ目のシーケンス。</param>
        /// <param name="t8">8 つ目のシーケンス。</param>
        /// <param name="t9">9 つ目のシーケンス。</param>
        /// <returns>インデックスを持ったタプルのシーケンス。</returns>
        public static IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, int>> ZipWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IEnumerable<T1> t1, IEnumerable<T2> t2, IEnumerable<T3> t3, IEnumerable<T4> t4, IEnumerable<T5> t5, IEnumerable<T6> t6, IEnumerable<T7> t7, IEnumerable<T8> t8, IEnumerable<T9> t9)
        {
            using (var itr1 = t1.GetEnumerator())
            using (var itr2 = t2.GetEnumerator())
            using (var itr3 = t3.GetEnumerator())
            using (var itr4 = t4.GetEnumerator())
            using (var itr5 = t5.GetEnumerator())
            using (var itr6 = t6.GetEnumerator())
            using (var itr7 = t7.GetEnumerator())
            using (var itr8 = t8.GetEnumerator())
            using (var itr9 = t9.GetEnumerator())
            {
                var index = 0;
                while (itr1.MoveNext() && itr2.MoveNext() && itr3.MoveNext() && itr4.MoveNext() && itr5.MoveNext() && itr6.MoveNext() && itr7.MoveNext() && itr8.MoveNext() && itr9.MoveNext())
                    yield return Tpl.Of(itr1.Current, itr2.Current, itr3.Current, itr4.Current, itr5.Current, itr6.Current, itr7.Current, itr8.Current, itr9.Current, index++);
            }
        }

        #endregion
    }
}