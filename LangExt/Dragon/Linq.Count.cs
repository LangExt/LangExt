
using System;
using System.Collections.Generic;
using System.Linq;

namespace LangExt.Dragon
{
    partial class Linq
    {
        /// <summary>
        /// タプルのシーケンスの各要素を展開して predicate に渡す count です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <param name="self">カウントする対象のシーケンス。</param>
        /// <param name="predicate">各要素が条件を満たしているかどうかをテストする関数。</param>
        /// <returns>シーケンス内の要素のうち、条件を満たす要素の個数。</returns>
        public static int Count<T1, T2>(this IEnumerable<_<T1, T2>> self, Func<T1, T2, bool> predicate)
        {
            return self.Count(t => predicate(t._1, t._2));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して predicate に渡す count です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <param name="self">カウントする対象のシーケンス。</param>
        /// <param name="predicate">各要素が条件を満たしているかどうかをテストする関数。</param>
        /// <returns>シーケンス内の要素のうち、条件を満たす要素の個数。</returns>
        public static long LongCount<T1, T2>(this IEnumerable<_<T1, T2>> self, Func<T1, T2, bool> predicate)
        {
            return self.LongCount(t => predicate(t._1, t._2));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して predicate に渡す count です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <param name="self">カウントする対象のシーケンス。</param>
        /// <param name="predicate">各要素が条件を満たしているかどうかをテストする関数。</param>
        /// <returns>シーケンス内の要素のうち、条件を満たす要素の個数。</returns>
        public static int Count<T1, T2, T3>(this IEnumerable<_<T1, T2, T3>> self, Func<T1, T2, T3, bool> predicate)
        {
            return self.Count(t => predicate(t._1, t._2, t._3));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して predicate に渡す count です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <param name="self">カウントする対象のシーケンス。</param>
        /// <param name="predicate">各要素が条件を満たしているかどうかをテストする関数。</param>
        /// <returns>シーケンス内の要素のうち、条件を満たす要素の個数。</returns>
        public static long LongCount<T1, T2, T3>(this IEnumerable<_<T1, T2, T3>> self, Func<T1, T2, T3, bool> predicate)
        {
            return self.LongCount(t => predicate(t._1, t._2, t._3));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して predicate に渡す count です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <param name="self">カウントする対象のシーケンス。</param>
        /// <param name="predicate">各要素が条件を満たしているかどうかをテストする関数。</param>
        /// <returns>シーケンス内の要素のうち、条件を満たす要素の個数。</returns>
        public static int Count<T1, T2, T3, T4>(this IEnumerable<_<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, bool> predicate)
        {
            return self.Count(t => predicate(t._1, t._2, t._3, t._4));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して predicate に渡す count です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <param name="self">カウントする対象のシーケンス。</param>
        /// <param name="predicate">各要素が条件を満たしているかどうかをテストする関数。</param>
        /// <returns>シーケンス内の要素のうち、条件を満たす要素の個数。</returns>
        public static long LongCount<T1, T2, T3, T4>(this IEnumerable<_<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, bool> predicate)
        {
            return self.LongCount(t => predicate(t._1, t._2, t._3, t._4));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して predicate に渡す count です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <param name="self">カウントする対象のシーケンス。</param>
        /// <param name="predicate">各要素が条件を満たしているかどうかをテストする関数。</param>
        /// <returns>シーケンス内の要素のうち、条件を満たす要素の個数。</returns>
        public static int Count<T1, T2, T3, T4, T5>(this IEnumerable<_<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, bool> predicate)
        {
            return self.Count(t => predicate(t._1, t._2, t._3, t._4, t._5));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して predicate に渡す count です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <param name="self">カウントする対象のシーケンス。</param>
        /// <param name="predicate">各要素が条件を満たしているかどうかをテストする関数。</param>
        /// <returns>シーケンス内の要素のうち、条件を満たす要素の個数。</returns>
        public static long LongCount<T1, T2, T3, T4, T5>(this IEnumerable<_<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, bool> predicate)
        {
            return self.LongCount(t => predicate(t._1, t._2, t._3, t._4, t._5));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して predicate に渡す count です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <param name="self">カウントする対象のシーケンス。</param>
        /// <param name="predicate">各要素が条件を満たしているかどうかをテストする関数。</param>
        /// <returns>シーケンス内の要素のうち、条件を満たす要素の個数。</returns>
        public static int Count<T1, T2, T3, T4, T5, T6>(this IEnumerable<_<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, bool> predicate)
        {
            return self.Count(t => predicate(t._1, t._2, t._3, t._4, t._5, t._6));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して predicate に渡す count です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <param name="self">カウントする対象のシーケンス。</param>
        /// <param name="predicate">各要素が条件を満たしているかどうかをテストする関数。</param>
        /// <returns>シーケンス内の要素のうち、条件を満たす要素の個数。</returns>
        public static long LongCount<T1, T2, T3, T4, T5, T6>(this IEnumerable<_<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, bool> predicate)
        {
            return self.LongCount(t => predicate(t._1, t._2, t._3, t._4, t._5, t._6));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して predicate に渡す count です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <param name="self">カウントする対象のシーケンス。</param>
        /// <param name="predicate">各要素が条件を満たしているかどうかをテストする関数。</param>
        /// <returns>シーケンス内の要素のうち、条件を満たす要素の個数。</returns>
        public static int Count<T1, T2, T3, T4, T5, T6, T7>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, bool> predicate)
        {
            return self.Count(t => predicate(t._1, t._2, t._3, t._4, t._5, t._6, t._7));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して predicate に渡す count です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <param name="self">カウントする対象のシーケンス。</param>
        /// <param name="predicate">各要素が条件を満たしているかどうかをテストする関数。</param>
        /// <returns>シーケンス内の要素のうち、条件を満たす要素の個数。</returns>
        public static long LongCount<T1, T2, T3, T4, T5, T6, T7>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, bool> predicate)
        {
            return self.LongCount(t => predicate(t._1, t._2, t._3, t._4, t._5, t._6, t._7));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して predicate に渡す count です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="T8">シーケンスの保持する 8 つ目の型。</typeparam>
        /// <param name="self">カウントする対象のシーケンス。</param>
        /// <param name="predicate">各要素が条件を満たしているかどうかをテストする関数。</param>
        /// <returns>シーケンス内の要素のうち、条件を満たす要素の個数。</returns>
        public static int Count<T1, T2, T3, T4, T5, T6, T7, T8>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> predicate)
        {
            return self.Count(t => predicate(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して predicate に渡す count です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="T8">シーケンスの保持する 8 つ目の型。</typeparam>
        /// <param name="self">カウントする対象のシーケンス。</param>
        /// <param name="predicate">各要素が条件を満たしているかどうかをテストする関数。</param>
        /// <returns>シーケンス内の要素のうち、条件を満たす要素の個数。</returns>
        public static long LongCount<T1, T2, T3, T4, T5, T6, T7, T8>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> predicate)
        {
            return self.LongCount(t => predicate(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して predicate に渡す count です。
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
        /// <param name="self">カウントする対象のシーケンス。</param>
        /// <param name="predicate">各要素が条件を満たしているかどうかをテストする関数。</param>
        /// <returns>シーケンス内の要素のうち、条件を満たす要素の個数。</returns>
        public static int Count<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> predicate)
        {
            return self.Count(t => predicate(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して predicate に渡す count です。
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
        /// <param name="self">カウントする対象のシーケンス。</param>
        /// <param name="predicate">各要素が条件を満たしているかどうかをテストする関数。</param>
        /// <returns>シーケンス内の要素のうち、条件を満たす要素の個数。</returns>
        public static long LongCount<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> predicate)
        {
            return self.LongCount(t => predicate(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して predicate に渡す count です。
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
        /// <param name="self">カウントする対象のシーケンス。</param>
        /// <param name="predicate">各要素が条件を満たしているかどうかをテストする関数。</param>
        /// <returns>シーケンス内の要素のうち、条件を満たす要素の個数。</returns>
        public static int Count<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> predicate)
        {
            return self.Count(t => predicate(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9, t._10));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して predicate に渡す count です。
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
        /// <param name="self">カウントする対象のシーケンス。</param>
        /// <param name="predicate">各要素が条件を満たしているかどうかをテストする関数。</param>
        /// <returns>シーケンス内の要素のうち、条件を満たす要素の個数。</returns>
        public static long LongCount<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> predicate)
        {
            return self.LongCount(t => predicate(t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9, t._10));
        }

    }
}