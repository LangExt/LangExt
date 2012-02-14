
using System;
using System.Collections.Generic;
using System.Linq;

namespace LangExt.Dragon
{
    partial class Linq
    {
        /// <summary>
        /// タプルのシーケンスの各要素を展開して func に渡す fold です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="TAccumulate">アキュムレータ値の型。</typeparam>
        /// <param name="self">集計対象のシーケンス。</param>
        /// <param name="seed">初期値。</param>
        /// <param name="func">各要素に対して呼び出すアキュムレータ関数。</param>
        /// <returns>最終的なアキュムレータ値。</returns>
        public static TAccumulate Aggregate<T1, T2, TAccumulate>(this IEnumerable<_<T1, T2>> self, TAccumulate seed, Func<TAccumulate, T1, T2, TAccumulate> func)
        {
            return self.Aggregate(seed, (acc, t) => func(acc, t._1, t._2));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して func に渡す fold です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="TAccumulate">アキュムレータ値の型。</typeparam>
        /// <typeparam name="TResult">結果の値の型。</typeparam>
        /// <param name="self">集計対象のシーケンス。</param>
        /// <param name="seed">初期値。</param>
        /// <param name="func">各要素に対して呼び出すアキュムレータ関数。</param>
        /// <param name="resultSelector">最終的なアキュムレータ値を結果値に変換する関数。</param>
        /// <returns>変換された最終的なアキュムレータ値。</returns>
        public static TResult Aggregate<T1, T2, TAccumulate, TResult>(this IEnumerable<_<T1, T2>> self, TAccumulate seed, Func<TAccumulate, T1, T2, TAccumulate> func, Func<TAccumulate, TResult> resultSelector)
        {
            return self.Aggregate(seed, (acc, t) => func(acc, t._1, t._2), resultSelector);
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して func に渡す fold です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="TAccumulate">アキュムレータ値の型。</typeparam>
        /// <param name="self">集計対象のシーケンス。</param>
        /// <param name="seed">初期値。</param>
        /// <param name="func">各要素に対して呼び出すアキュムレータ関数。</param>
        /// <returns>最終的なアキュムレータ値。</returns>
        public static TAccumulate Aggregate<T1, T2, T3, TAccumulate>(this IEnumerable<_<T1, T2, T3>> self, TAccumulate seed, Func<TAccumulate, T1, T2, T3, TAccumulate> func)
        {
            return self.Aggregate(seed, (acc, t) => func(acc, t._1, t._2, t._3));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して func に渡す fold です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="TAccumulate">アキュムレータ値の型。</typeparam>
        /// <typeparam name="TResult">結果の値の型。</typeparam>
        /// <param name="self">集計対象のシーケンス。</param>
        /// <param name="seed">初期値。</param>
        /// <param name="func">各要素に対して呼び出すアキュムレータ関数。</param>
        /// <param name="resultSelector">最終的なアキュムレータ値を結果値に変換する関数。</param>
        /// <returns>変換された最終的なアキュムレータ値。</returns>
        public static TResult Aggregate<T1, T2, T3, TAccumulate, TResult>(this IEnumerable<_<T1, T2, T3>> self, TAccumulate seed, Func<TAccumulate, T1, T2, T3, TAccumulate> func, Func<TAccumulate, TResult> resultSelector)
        {
            return self.Aggregate(seed, (acc, t) => func(acc, t._1, t._2, t._3), resultSelector);
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して func に渡す fold です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="TAccumulate">アキュムレータ値の型。</typeparam>
        /// <param name="self">集計対象のシーケンス。</param>
        /// <param name="seed">初期値。</param>
        /// <param name="func">各要素に対して呼び出すアキュムレータ関数。</param>
        /// <returns>最終的なアキュムレータ値。</returns>
        public static TAccumulate Aggregate<T1, T2, T3, T4, TAccumulate>(this IEnumerable<_<T1, T2, T3, T4>> self, TAccumulate seed, Func<TAccumulate, T1, T2, T3, T4, TAccumulate> func)
        {
            return self.Aggregate(seed, (acc, t) => func(acc, t._1, t._2, t._3, t._4));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して func に渡す fold です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="TAccumulate">アキュムレータ値の型。</typeparam>
        /// <typeparam name="TResult">結果の値の型。</typeparam>
        /// <param name="self">集計対象のシーケンス。</param>
        /// <param name="seed">初期値。</param>
        /// <param name="func">各要素に対して呼び出すアキュムレータ関数。</param>
        /// <param name="resultSelector">最終的なアキュムレータ値を結果値に変換する関数。</param>
        /// <returns>変換された最終的なアキュムレータ値。</returns>
        public static TResult Aggregate<T1, T2, T3, T4, TAccumulate, TResult>(this IEnumerable<_<T1, T2, T3, T4>> self, TAccumulate seed, Func<TAccumulate, T1, T2, T3, T4, TAccumulate> func, Func<TAccumulate, TResult> resultSelector)
        {
            return self.Aggregate(seed, (acc, t) => func(acc, t._1, t._2, t._3, t._4), resultSelector);
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して func に渡す fold です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="TAccumulate">アキュムレータ値の型。</typeparam>
        /// <param name="self">集計対象のシーケンス。</param>
        /// <param name="seed">初期値。</param>
        /// <param name="func">各要素に対して呼び出すアキュムレータ関数。</param>
        /// <returns>最終的なアキュムレータ値。</returns>
        public static TAccumulate Aggregate<T1, T2, T3, T4, T5, TAccumulate>(this IEnumerable<_<T1, T2, T3, T4, T5>> self, TAccumulate seed, Func<TAccumulate, T1, T2, T3, T4, T5, TAccumulate> func)
        {
            return self.Aggregate(seed, (acc, t) => func(acc, t._1, t._2, t._3, t._4, t._5));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して func に渡す fold です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="TAccumulate">アキュムレータ値の型。</typeparam>
        /// <typeparam name="TResult">結果の値の型。</typeparam>
        /// <param name="self">集計対象のシーケンス。</param>
        /// <param name="seed">初期値。</param>
        /// <param name="func">各要素に対して呼び出すアキュムレータ関数。</param>
        /// <param name="resultSelector">最終的なアキュムレータ値を結果値に変換する関数。</param>
        /// <returns>変換された最終的なアキュムレータ値。</returns>
        public static TResult Aggregate<T1, T2, T3, T4, T5, TAccumulate, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5>> self, TAccumulate seed, Func<TAccumulate, T1, T2, T3, T4, T5, TAccumulate> func, Func<TAccumulate, TResult> resultSelector)
        {
            return self.Aggregate(seed, (acc, t) => func(acc, t._1, t._2, t._3, t._4, t._5), resultSelector);
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して func に渡す fold です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="TAccumulate">アキュムレータ値の型。</typeparam>
        /// <param name="self">集計対象のシーケンス。</param>
        /// <param name="seed">初期値。</param>
        /// <param name="func">各要素に対して呼び出すアキュムレータ関数。</param>
        /// <returns>最終的なアキュムレータ値。</returns>
        public static TAccumulate Aggregate<T1, T2, T3, T4, T5, T6, TAccumulate>(this IEnumerable<_<T1, T2, T3, T4, T5, T6>> self, TAccumulate seed, Func<TAccumulate, T1, T2, T3, T4, T5, T6, TAccumulate> func)
        {
            return self.Aggregate(seed, (acc, t) => func(acc, t._1, t._2, t._3, t._4, t._5, t._6));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して func に渡す fold です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="TAccumulate">アキュムレータ値の型。</typeparam>
        /// <typeparam name="TResult">結果の値の型。</typeparam>
        /// <param name="self">集計対象のシーケンス。</param>
        /// <param name="seed">初期値。</param>
        /// <param name="func">各要素に対して呼び出すアキュムレータ関数。</param>
        /// <param name="resultSelector">最終的なアキュムレータ値を結果値に変換する関数。</param>
        /// <returns>変換された最終的なアキュムレータ値。</returns>
        public static TResult Aggregate<T1, T2, T3, T4, T5, T6, TAccumulate, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5, T6>> self, TAccumulate seed, Func<TAccumulate, T1, T2, T3, T4, T5, T6, TAccumulate> func, Func<TAccumulate, TResult> resultSelector)
        {
            return self.Aggregate(seed, (acc, t) => func(acc, t._1, t._2, t._3, t._4, t._5, t._6), resultSelector);
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して func に渡す fold です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="TAccumulate">アキュムレータ値の型。</typeparam>
        /// <param name="self">集計対象のシーケンス。</param>
        /// <param name="seed">初期値。</param>
        /// <param name="func">各要素に対して呼び出すアキュムレータ関数。</param>
        /// <returns>最終的なアキュムレータ値。</returns>
        public static TAccumulate Aggregate<T1, T2, T3, T4, T5, T6, T7, TAccumulate>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> self, TAccumulate seed, Func<TAccumulate, T1, T2, T3, T4, T5, T6, T7, TAccumulate> func)
        {
            return self.Aggregate(seed, (acc, t) => func(acc, t._1, t._2, t._3, t._4, t._5, t._6, t._7));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して func に渡す fold です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="TAccumulate">アキュムレータ値の型。</typeparam>
        /// <typeparam name="TResult">結果の値の型。</typeparam>
        /// <param name="self">集計対象のシーケンス。</param>
        /// <param name="seed">初期値。</param>
        /// <param name="func">各要素に対して呼び出すアキュムレータ関数。</param>
        /// <param name="resultSelector">最終的なアキュムレータ値を結果値に変換する関数。</param>
        /// <returns>変換された最終的なアキュムレータ値。</returns>
        public static TResult Aggregate<T1, T2, T3, T4, T5, T6, T7, TAccumulate, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7>> self, TAccumulate seed, Func<TAccumulate, T1, T2, T3, T4, T5, T6, T7, TAccumulate> func, Func<TAccumulate, TResult> resultSelector)
        {
            return self.Aggregate(seed, (acc, t) => func(acc, t._1, t._2, t._3, t._4, t._5, t._6, t._7), resultSelector);
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して func に渡す fold です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="T8">シーケンスの保持する 8 つ目の型。</typeparam>
        /// <typeparam name="TAccumulate">アキュムレータ値の型。</typeparam>
        /// <param name="self">集計対象のシーケンス。</param>
        /// <param name="seed">初期値。</param>
        /// <param name="func">各要素に対して呼び出すアキュムレータ関数。</param>
        /// <returns>最終的なアキュムレータ値。</returns>
        public static TAccumulate Aggregate<T1, T2, T3, T4, T5, T6, T7, T8, TAccumulate>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> self, TAccumulate seed, Func<TAccumulate, T1, T2, T3, T4, T5, T6, T7, T8, TAccumulate> func)
        {
            return self.Aggregate(seed, (acc, t) => func(acc, t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して func に渡す fold です。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="T8">シーケンスの保持する 8 つ目の型。</typeparam>
        /// <typeparam name="TAccumulate">アキュムレータ値の型。</typeparam>
        /// <typeparam name="TResult">結果の値の型。</typeparam>
        /// <param name="self">集計対象のシーケンス。</param>
        /// <param name="seed">初期値。</param>
        /// <param name="func">各要素に対して呼び出すアキュムレータ関数。</param>
        /// <param name="resultSelector">最終的なアキュムレータ値を結果値に変換する関数。</param>
        /// <returns>変換された最終的なアキュムレータ値。</returns>
        public static TResult Aggregate<T1, T2, T3, T4, T5, T6, T7, T8, TAccumulate, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8>> self, TAccumulate seed, Func<TAccumulate, T1, T2, T3, T4, T5, T6, T7, T8, TAccumulate> func, Func<TAccumulate, TResult> resultSelector)
        {
            return self.Aggregate(seed, (acc, t) => func(acc, t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8), resultSelector);
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して func に渡す fold です。
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
        /// <typeparam name="TAccumulate">アキュムレータ値の型。</typeparam>
        /// <param name="self">集計対象のシーケンス。</param>
        /// <param name="seed">初期値。</param>
        /// <param name="func">各要素に対して呼び出すアキュムレータ関数。</param>
        /// <returns>最終的なアキュムレータ値。</returns>
        public static TAccumulate Aggregate<T1, T2, T3, T4, T5, T6, T7, T8, T9, TAccumulate>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> self, TAccumulate seed, Func<TAccumulate, T1, T2, T3, T4, T5, T6, T7, T8, T9, TAccumulate> func)
        {
            return self.Aggregate(seed, (acc, t) => func(acc, t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して func に渡す fold です。
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
        /// <typeparam name="TAccumulate">アキュムレータ値の型。</typeparam>
        /// <typeparam name="TResult">結果の値の型。</typeparam>
        /// <param name="self">集計対象のシーケンス。</param>
        /// <param name="seed">初期値。</param>
        /// <param name="func">各要素に対して呼び出すアキュムレータ関数。</param>
        /// <param name="resultSelector">最終的なアキュムレータ値を結果値に変換する関数。</param>
        /// <returns>変換された最終的なアキュムレータ値。</returns>
        public static TResult Aggregate<T1, T2, T3, T4, T5, T6, T7, T8, T9, TAccumulate, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>> self, TAccumulate seed, Func<TAccumulate, T1, T2, T3, T4, T5, T6, T7, T8, T9, TAccumulate> func, Func<TAccumulate, TResult> resultSelector)
        {
            return self.Aggregate(seed, (acc, t) => func(acc, t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9), resultSelector);
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して func に渡す fold です。
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
        /// <typeparam name="TAccumulate">アキュムレータ値の型。</typeparam>
        /// <param name="self">集計対象のシーケンス。</param>
        /// <param name="seed">初期値。</param>
        /// <param name="func">各要素に対して呼び出すアキュムレータ関数。</param>
        /// <returns>最終的なアキュムレータ値。</returns>
        public static TAccumulate Aggregate<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TAccumulate>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> self, TAccumulate seed, Func<TAccumulate, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TAccumulate> func)
        {
            return self.Aggregate(seed, (acc, t) => func(acc, t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9, t._10));
        }

        /// <summary>
        /// タプルのシーケンスの各要素を展開して func に渡す fold です。
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
        /// <typeparam name="TAccumulate">アキュムレータ値の型。</typeparam>
        /// <typeparam name="TResult">結果の値の型。</typeparam>
        /// <param name="self">集計対象のシーケンス。</param>
        /// <param name="seed">初期値。</param>
        /// <param name="func">各要素に対して呼び出すアキュムレータ関数。</param>
        /// <param name="resultSelector">最終的なアキュムレータ値を結果値に変換する関数。</param>
        /// <returns>変換された最終的なアキュムレータ値。</returns>
        public static TResult Aggregate<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TAccumulate, TResult>(this IEnumerable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> self, TAccumulate seed, Func<TAccumulate, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TAccumulate> func, Func<TAccumulate, TResult> resultSelector)
        {
            return self.Aggregate(seed, (acc, t) => func(acc, t._1, t._2, t._3, t._4, t._5, t._6, t._7, t._8, t._9, t._10), resultSelector);
        }

    }
}