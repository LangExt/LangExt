

using System;
using System.Collections.Generic;

namespace LangExt
{
    partial class Enumerable
    {
        #region 2要素タプルを扱う関数
        /// <summary>
        /// 2要素タプルの各要素を展開して関数に渡すUnfoldです。
        /// </summary>
        public static IEnumerable<U> Unfold<T1, T2, U>(this Tuple<T1, T2> self, Func<T1, T2, Option<Tuple<U, T1, T2>>> f)
        {
            return Unfold(self, tpl =>
                from res in tpl.Match(f)
                select Tuple.Create(res.Fst(), res.RemoveFirst()));
        }

        /// <summary>
        /// 2要素タプルのIEnumerableの各要素を展開して関数に渡すScanです。
        /// </summary>
        public static IEnumerable<U> Scan<T1, T2, U>(this IEnumerable<Tuple<T1, T2>> self, U init, Func<U, T1, T2, U> f)
        {
            return self.Scan(init, (acc, tpl) => f(acc, tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのIEnumerableの各要素を展開して関数に渡すScan1です。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2>> Scan1<T1, T2>(this IEnumerable<Tuple<T1, T2>> self, Func<T1, T2, T1, T2, Tuple<T1, T2>> f)
        {
            return self.Scan1((acc, tpl) => f(acc._1(), acc._2(), tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのIEnumerableの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static IEnumerable<U> Map<T1, T2, U>(this IEnumerable<Tuple<T1, T2>> self, Func<T1, T2, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのIEnumerableの各要素を展開して関数に渡すMapWithIndexです。
        /// </summary>
        public static IEnumerable<U> MapWithIndex<T1, T2, U>(this IEnumerable<Tuple<T1, T2>> self, Func<T1, T2, int, U> f)
        {
            return self.MapWithIndex((tpl, i) => f(tpl._1(), tpl._2(), i));
        }

        /// <summary>
        /// 2要素タプルのIEnumerableの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static IEnumerable<U> Bind<T1, T2, U>(this IEnumerable<Tuple<T1, T2>> self, Func<T1, T2, IEnumerable<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのIEnumerableの各要素を展開して関数に渡すBindWithIndexです。
        /// </summary>
        public static IEnumerable<U> BindWithIndex<T1, T2, U>(this IEnumerable<Tuple<T1, T2>> self, Func<T1, T2, int, IEnumerable<U>> f)
        {
            return self.BindWithIndex((tpl, i) => f(tpl._1(), tpl._2(), i));
        }

        /// <summary>
        /// 2要素タプルのIEnumerableの各要素を展開して関数に渡すSkipWhileです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2>> SkipWhile<T1, T2>(this IEnumerable<Tuple<T1, T2>> self, Func<T1, T2, bool> f)
        {
            return self.SkipWhile(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのIEnumerableの各要素を展開して関数に渡すTakeWhileです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2>> TakeWhile<T1, T2>(this IEnumerable<Tuple<T1, T2>> self, Func<T1, T2, bool> f)
        {
            return self.TakeWhile(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのIEnumerableの各要素を展開して関数に渡すSkipWhileWithIndexです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2>> SkipWhileWithIndex<T1, T2>(this IEnumerable<Tuple<T1, T2>> self, Func<T1, T2, int, bool> f)
        {
            return self.SkipWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), i));
        }

        /// <summary>
        /// 2要素タプルのIEnumerableの各要素を展開して関数に渡すTakeWhileWithIndexです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2>> TakeWhileWithIndex<T1, T2>(this IEnumerable<Tuple<T1, T2>> self, Func<T1, T2, int, bool> f)
        {
            return self.TakeWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), i));
        }

        /// <summary>
        /// 2要素タプルのIEnumerableの各要素を展開して関数に渡すSpanです。
        /// </summary>
        public static Tuple<IEnumerable<Tuple<T1, T2>>, IEnumerable<Tuple<T1, T2>>> Span<T1, T2>(this IEnumerable<Tuple<T1, T2>> self, Func<T1, T2, bool> f)
        {
            return self.Span(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのIEnumerableの各要素を展開して関数に渡すBreakです。
        /// </summary>
        public static Tuple<IEnumerable<Tuple<T1, T2>>, IEnumerable<Tuple<T1, T2>>> Break<T1, T2>(this IEnumerable<Tuple<T1, T2>> self, Func<T1, T2, bool> f)
        {
            return self.Break(tpl => f(tpl._1(), tpl._2()));
        }
        #endregion

        #region 3要素タプルを扱う関数
        /// <summary>
        /// 3要素タプルの各要素を展開して関数に渡すUnfoldです。
        /// </summary>
        public static IEnumerable<U> Unfold<T1, T2, T3, U>(this Tuple<T1, T2, T3> self, Func<T1, T2, T3, Option<Tuple<U, T1, T2, T3>>> f)
        {
            return Unfold(self, tpl =>
                from res in tpl.Match(f)
                select Tuple.Create(res.Fst(), res.RemoveFirst()));
        }

        /// <summary>
        /// 3要素タプルのIEnumerableの各要素を展開して関数に渡すScanです。
        /// </summary>
        public static IEnumerable<U> Scan<T1, T2, T3, U>(this IEnumerable<Tuple<T1, T2, T3>> self, U init, Func<U, T1, T2, T3, U> f)
        {
            return self.Scan(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのIEnumerableの各要素を展開して関数に渡すScan1です。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3>> Scan1<T1, T2, T3>(this IEnumerable<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, T1, T2, T3, Tuple<T1, T2, T3>> f)
        {
            return self.Scan1((acc, tpl) => f(acc._1(), acc._2(), acc._3(), tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのIEnumerableの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static IEnumerable<U> Map<T1, T2, T3, U>(this IEnumerable<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのIEnumerableの各要素を展開して関数に渡すMapWithIndexです。
        /// </summary>
        public static IEnumerable<U> MapWithIndex<T1, T2, T3, U>(this IEnumerable<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, int, U> f)
        {
            return self.MapWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), i));
        }

        /// <summary>
        /// 3要素タプルのIEnumerableの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static IEnumerable<U> Bind<T1, T2, T3, U>(this IEnumerable<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, IEnumerable<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのIEnumerableの各要素を展開して関数に渡すBindWithIndexです。
        /// </summary>
        public static IEnumerable<U> BindWithIndex<T1, T2, T3, U>(this IEnumerable<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, int, IEnumerable<U>> f)
        {
            return self.BindWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), i));
        }

        /// <summary>
        /// 3要素タプルのIEnumerableの各要素を展開して関数に渡すSkipWhileです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3>> SkipWhile<T1, T2, T3>(this IEnumerable<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, bool> f)
        {
            return self.SkipWhile(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのIEnumerableの各要素を展開して関数に渡すTakeWhileです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3>> TakeWhile<T1, T2, T3>(this IEnumerable<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, bool> f)
        {
            return self.TakeWhile(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのIEnumerableの各要素を展開して関数に渡すSkipWhileWithIndexです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3>> SkipWhileWithIndex<T1, T2, T3>(this IEnumerable<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, int, bool> f)
        {
            return self.SkipWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), i));
        }

        /// <summary>
        /// 3要素タプルのIEnumerableの各要素を展開して関数に渡すTakeWhileWithIndexです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3>> TakeWhileWithIndex<T1, T2, T3>(this IEnumerable<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, int, bool> f)
        {
            return self.TakeWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), i));
        }

        /// <summary>
        /// 3要素タプルのIEnumerableの各要素を展開して関数に渡すSpanです。
        /// </summary>
        public static Tuple<IEnumerable<Tuple<T1, T2, T3>>, IEnumerable<Tuple<T1, T2, T3>>> Span<T1, T2, T3>(this IEnumerable<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, bool> f)
        {
            return self.Span(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのIEnumerableの各要素を展開して関数に渡すBreakです。
        /// </summary>
        public static Tuple<IEnumerable<Tuple<T1, T2, T3>>, IEnumerable<Tuple<T1, T2, T3>>> Break<T1, T2, T3>(this IEnumerable<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, bool> f)
        {
            return self.Break(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }
        #endregion

        #region 4要素タプルを扱う関数
        /// <summary>
        /// 4要素タプルの各要素を展開して関数に渡すUnfoldです。
        /// </summary>
        public static IEnumerable<U> Unfold<T1, T2, T3, T4, U>(this Tuple<T1, T2, T3, T4> self, Func<T1, T2, T3, T4, Option<Tuple<U, T1, T2, T3, T4>>> f)
        {
            return Unfold(self, tpl =>
                from res in tpl.Match(f)
                select Tuple.Create(res.Fst(), res.RemoveFirst()));
        }

        /// <summary>
        /// 4要素タプルのIEnumerableの各要素を展開して関数に渡すScanです。
        /// </summary>
        public static IEnumerable<U> Scan<T1, T2, T3, T4, U>(this IEnumerable<Tuple<T1, T2, T3, T4>> self, U init, Func<U, T1, T2, T3, T4, U> f)
        {
            return self.Scan(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのIEnumerableの各要素を展開して関数に渡すScan1です。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4>> Scan1<T1, T2, T3, T4>(this IEnumerable<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, T1, T2, T3, T4, Tuple<T1, T2, T3, T4>> f)
        {
            return self.Scan1((acc, tpl) => f(acc._1(), acc._2(), acc._3(), acc._4(), tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのIEnumerableの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static IEnumerable<U> Map<T1, T2, T3, T4, U>(this IEnumerable<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのIEnumerableの各要素を展開して関数に渡すMapWithIndexです。
        /// </summary>
        public static IEnumerable<U> MapWithIndex<T1, T2, T3, T4, U>(this IEnumerable<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, int, U> f)
        {
            return self.MapWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), i));
        }

        /// <summary>
        /// 4要素タプルのIEnumerableの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static IEnumerable<U> Bind<T1, T2, T3, T4, U>(this IEnumerable<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, IEnumerable<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのIEnumerableの各要素を展開して関数に渡すBindWithIndexです。
        /// </summary>
        public static IEnumerable<U> BindWithIndex<T1, T2, T3, T4, U>(this IEnumerable<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, int, IEnumerable<U>> f)
        {
            return self.BindWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), i));
        }

        /// <summary>
        /// 4要素タプルのIEnumerableの各要素を展開して関数に渡すSkipWhileです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4>> SkipWhile<T1, T2, T3, T4>(this IEnumerable<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, bool> f)
        {
            return self.SkipWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのIEnumerableの各要素を展開して関数に渡すTakeWhileです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4>> TakeWhile<T1, T2, T3, T4>(this IEnumerable<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, bool> f)
        {
            return self.TakeWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのIEnumerableの各要素を展開して関数に渡すSkipWhileWithIndexです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4>> SkipWhileWithIndex<T1, T2, T3, T4>(this IEnumerable<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, int, bool> f)
        {
            return self.SkipWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), i));
        }

        /// <summary>
        /// 4要素タプルのIEnumerableの各要素を展開して関数に渡すTakeWhileWithIndexです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4>> TakeWhileWithIndex<T1, T2, T3, T4>(this IEnumerable<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, int, bool> f)
        {
            return self.TakeWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), i));
        }

        /// <summary>
        /// 4要素タプルのIEnumerableの各要素を展開して関数に渡すSpanです。
        /// </summary>
        public static Tuple<IEnumerable<Tuple<T1, T2, T3, T4>>, IEnumerable<Tuple<T1, T2, T3, T4>>> Span<T1, T2, T3, T4>(this IEnumerable<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, bool> f)
        {
            return self.Span(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのIEnumerableの各要素を展開して関数に渡すBreakです。
        /// </summary>
        public static Tuple<IEnumerable<Tuple<T1, T2, T3, T4>>, IEnumerable<Tuple<T1, T2, T3, T4>>> Break<T1, T2, T3, T4>(this IEnumerable<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, bool> f)
        {
            return self.Break(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }
        #endregion

        #region 5要素タプルを扱う関数
        /// <summary>
        /// 5要素タプルの各要素を展開して関数に渡すUnfoldです。
        /// </summary>
        public static IEnumerable<U> Unfold<T1, T2, T3, T4, T5, U>(this Tuple<T1, T2, T3, T4, T5> self, Func<T1, T2, T3, T4, T5, Option<Tuple<U, T1, T2, T3, T4, T5>>> f)
        {
            return Unfold(self, tpl =>
                from res in tpl.Match(f)
                select Tuple.Create(res.Fst(), res.RemoveFirst()));
        }

        /// <summary>
        /// 5要素タプルのIEnumerableの各要素を展開して関数に渡すScanです。
        /// </summary>
        public static IEnumerable<U> Scan<T1, T2, T3, T4, T5, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5>> self, U init, Func<U, T1, T2, T3, T4, T5, U> f)
        {
            return self.Scan(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのIEnumerableの各要素を展開して関数に渡すScan1です。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5>> Scan1<T1, T2, T3, T4, T5>(this IEnumerable<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, Tuple<T1, T2, T3, T4, T5>> f)
        {
            return self.Scan1((acc, tpl) => f(acc._1(), acc._2(), acc._3(), acc._4(), acc._5(), tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのIEnumerableの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static IEnumerable<U> Map<T1, T2, T3, T4, T5, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのIEnumerableの各要素を展開して関数に渡すMapWithIndexです。
        /// </summary>
        public static IEnumerable<U> MapWithIndex<T1, T2, T3, T4, T5, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, int, U> f)
        {
            return self.MapWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), i));
        }

        /// <summary>
        /// 5要素タプルのIEnumerableの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static IEnumerable<U> Bind<T1, T2, T3, T4, T5, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, IEnumerable<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのIEnumerableの各要素を展開して関数に渡すBindWithIndexです。
        /// </summary>
        public static IEnumerable<U> BindWithIndex<T1, T2, T3, T4, T5, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, int, IEnumerable<U>> f)
        {
            return self.BindWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), i));
        }

        /// <summary>
        /// 5要素タプルのIEnumerableの各要素を展開して関数に渡すSkipWhileです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5>> SkipWhile<T1, T2, T3, T4, T5>(this IEnumerable<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, bool> f)
        {
            return self.SkipWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのIEnumerableの各要素を展開して関数に渡すTakeWhileです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5>> TakeWhile<T1, T2, T3, T4, T5>(this IEnumerable<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, bool> f)
        {
            return self.TakeWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのIEnumerableの各要素を展開して関数に渡すSkipWhileWithIndexです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5>> SkipWhileWithIndex<T1, T2, T3, T4, T5>(this IEnumerable<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, int, bool> f)
        {
            return self.SkipWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), i));
        }

        /// <summary>
        /// 5要素タプルのIEnumerableの各要素を展開して関数に渡すTakeWhileWithIndexです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5>> TakeWhileWithIndex<T1, T2, T3, T4, T5>(this IEnumerable<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, int, bool> f)
        {
            return self.TakeWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), i));
        }

        /// <summary>
        /// 5要素タプルのIEnumerableの各要素を展開して関数に渡すSpanです。
        /// </summary>
        public static Tuple<IEnumerable<Tuple<T1, T2, T3, T4, T5>>, IEnumerable<Tuple<T1, T2, T3, T4, T5>>> Span<T1, T2, T3, T4, T5>(this IEnumerable<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, bool> f)
        {
            return self.Span(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのIEnumerableの各要素を展開して関数に渡すBreakです。
        /// </summary>
        public static Tuple<IEnumerable<Tuple<T1, T2, T3, T4, T5>>, IEnumerable<Tuple<T1, T2, T3, T4, T5>>> Break<T1, T2, T3, T4, T5>(this IEnumerable<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, bool> f)
        {
            return self.Break(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }
        #endregion

        #region 6要素タプルを扱う関数
        /// <summary>
        /// 6要素タプルの各要素を展開して関数に渡すUnfoldです。
        /// </summary>
        public static IEnumerable<U> Unfold<T1, T2, T3, T4, T5, T6, U>(this Tuple<T1, T2, T3, T4, T5, T6> self, Func<T1, T2, T3, T4, T5, T6, Option<Tuple<U, T1, T2, T3, T4, T5, T6>>> f)
        {
            return Unfold(self, tpl =>
                from res in tpl.Match(f)
                select Tuple.Create(res.Fst(), res.RemoveFirst()));
        }

        /// <summary>
        /// 6要素タプルのIEnumerableの各要素を展開して関数に渡すScanです。
        /// </summary>
        public static IEnumerable<U> Scan<T1, T2, T3, T4, T5, T6, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, U> f)
        {
            return self.Scan(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのIEnumerableの各要素を展開して関数に渡すScan1です。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>> Scan1<T1, T2, T3, T4, T5, T6>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, Tuple<T1, T2, T3, T4, T5, T6>> f)
        {
            return self.Scan1((acc, tpl) => f(acc._1(), acc._2(), acc._3(), acc._4(), acc._5(), acc._6(), tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのIEnumerableの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static IEnumerable<U> Map<T1, T2, T3, T4, T5, T6, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのIEnumerableの各要素を展開して関数に渡すMapWithIndexです。
        /// </summary>
        public static IEnumerable<U> MapWithIndex<T1, T2, T3, T4, T5, T6, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, int, U> f)
        {
            return self.MapWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), i));
        }

        /// <summary>
        /// 6要素タプルのIEnumerableの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static IEnumerable<U> Bind<T1, T2, T3, T4, T5, T6, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, IEnumerable<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのIEnumerableの各要素を展開して関数に渡すBindWithIndexです。
        /// </summary>
        public static IEnumerable<U> BindWithIndex<T1, T2, T3, T4, T5, T6, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, int, IEnumerable<U>> f)
        {
            return self.BindWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), i));
        }

        /// <summary>
        /// 6要素タプルのIEnumerableの各要素を展開して関数に渡すSkipWhileです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>> SkipWhile<T1, T2, T3, T4, T5, T6>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, bool> f)
        {
            return self.SkipWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのIEnumerableの各要素を展開して関数に渡すTakeWhileです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>> TakeWhile<T1, T2, T3, T4, T5, T6>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, bool> f)
        {
            return self.TakeWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのIEnumerableの各要素を展開して関数に渡すSkipWhileWithIndexです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>> SkipWhileWithIndex<T1, T2, T3, T4, T5, T6>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, int, bool> f)
        {
            return self.SkipWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), i));
        }

        /// <summary>
        /// 6要素タプルのIEnumerableの各要素を展開して関数に渡すTakeWhileWithIndexです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>> TakeWhileWithIndex<T1, T2, T3, T4, T5, T6>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, int, bool> f)
        {
            return self.TakeWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), i));
        }

        /// <summary>
        /// 6要素タプルのIEnumerableの各要素を展開して関数に渡すSpanです。
        /// </summary>
        public static Tuple<IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>>, IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>>> Span<T1, T2, T3, T4, T5, T6>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, bool> f)
        {
            return self.Span(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのIEnumerableの各要素を展開して関数に渡すBreakです。
        /// </summary>
        public static Tuple<IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>>, IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>>> Break<T1, T2, T3, T4, T5, T6>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, bool> f)
        {
            return self.Break(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }
        #endregion

        #region 7要素タプルを扱う関数
        /// <summary>
        /// 7要素タプルの各要素を展開して関数に渡すUnfoldです。
        /// </summary>
        public static IEnumerable<U> Unfold<T1, T2, T3, T4, T5, T6, T7, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7> self, Func<T1, T2, T3, T4, T5, T6, T7, Option<Tuple<U, T1, T2, T3, T4, T5, T6, Tuple<T7>>>> f)
        {
            return Unfold(self, tpl =>
                from res in tpl.Match(f)
                select Tuple.Create(res.Fst(), res.RemoveFirst()));
        }

        /// <summary>
        /// 7要素タプルのIEnumerableの各要素を展開して関数に渡すScanです。
        /// </summary>
        public static IEnumerable<U> Scan<T1, T2, T3, T4, T5, T6, T7, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, U> f)
        {
            return self.Scan(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのIEnumerableの各要素を展開して関数に渡すScan1です。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>> Scan1<T1, T2, T3, T4, T5, T6, T7>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, Tuple<T1, T2, T3, T4, T5, T6, T7>> f)
        {
            return self.Scan1((acc, tpl) => f(acc._1(), acc._2(), acc._3(), acc._4(), acc._5(), acc._6(), acc._7(), tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのIEnumerableの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static IEnumerable<U> Map<T1, T2, T3, T4, T5, T6, T7, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのIEnumerableの各要素を展開して関数に渡すMapWithIndexです。
        /// </summary>
        public static IEnumerable<U> MapWithIndex<T1, T2, T3, T4, T5, T6, T7, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, int, U> f)
        {
            return self.MapWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), i));
        }

        /// <summary>
        /// 7要素タプルのIEnumerableの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static IEnumerable<U> Bind<T1, T2, T3, T4, T5, T6, T7, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, IEnumerable<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのIEnumerableの各要素を展開して関数に渡すBindWithIndexです。
        /// </summary>
        public static IEnumerable<U> BindWithIndex<T1, T2, T3, T4, T5, T6, T7, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, int, IEnumerable<U>> f)
        {
            return self.BindWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), i));
        }

        /// <summary>
        /// 7要素タプルのIEnumerableの各要素を展開して関数に渡すSkipWhileです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>> SkipWhile<T1, T2, T3, T4, T5, T6, T7>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, bool> f)
        {
            return self.SkipWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのIEnumerableの各要素を展開して関数に渡すTakeWhileです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>> TakeWhile<T1, T2, T3, T4, T5, T6, T7>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, bool> f)
        {
            return self.TakeWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのIEnumerableの各要素を展開して関数に渡すSkipWhileWithIndexです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>> SkipWhileWithIndex<T1, T2, T3, T4, T5, T6, T7>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, int, bool> f)
        {
            return self.SkipWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), i));
        }

        /// <summary>
        /// 7要素タプルのIEnumerableの各要素を展開して関数に渡すTakeWhileWithIndexです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>> TakeWhileWithIndex<T1, T2, T3, T4, T5, T6, T7>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, int, bool> f)
        {
            return self.TakeWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), i));
        }

        /// <summary>
        /// 7要素タプルのIEnumerableの各要素を展開して関数に渡すSpanです。
        /// </summary>
        public static Tuple<IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>>, IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>>> Span<T1, T2, T3, T4, T5, T6, T7>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, bool> f)
        {
            return self.Span(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのIEnumerableの各要素を展開して関数に渡すBreakです。
        /// </summary>
        public static Tuple<IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>>, IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>>> Break<T1, T2, T3, T4, T5, T6, T7>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, bool> f)
        {
            return self.Break(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }
        #endregion

        #region 8要素タプルを扱う関数
        /// <summary>
        /// 8要素タプルの各要素を展開して関数に渡すUnfoldです。
        /// </summary>
        public static IEnumerable<U> Unfold<T1, T2, T3, T4, T5, T6, T7, T8, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, Option<Tuple<U, T1, T2, T3, T4, T5, T6, Tuple<T7, T8>>>> f)
        {
            return Unfold(self, tpl =>
                from res in tpl.Match(f)
                select Tuple.Create(res.Fst(), res.RemoveFirst()));
        }

        /// <summary>
        /// 8要素タプルのIEnumerableの各要素を展開して関数に渡すScanです。
        /// </summary>
        public static IEnumerable<U> Scan<T1, T2, T3, T4, T5, T6, T7, T8, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, U> f)
        {
            return self.Scan(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのIEnumerableの各要素を展開して関数に渡すScan1です。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> Scan1<T1, T2, T3, T4, T5, T6, T7, T8>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> f)
        {
            return self.Scan1((acc, tpl) => f(acc._1(), acc._2(), acc._3(), acc._4(), acc._5(), acc._6(), acc._7(), acc._8(), tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのIEnumerableの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static IEnumerable<U> Map<T1, T2, T3, T4, T5, T6, T7, T8, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのIEnumerableの各要素を展開して関数に渡すMapWithIndexです。
        /// </summary>
        public static IEnumerable<U> MapWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, int, U> f)
        {
            return self.MapWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), i));
        }

        /// <summary>
        /// 8要素タプルのIEnumerableの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static IEnumerable<U> Bind<T1, T2, T3, T4, T5, T6, T7, T8, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, IEnumerable<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのIEnumerableの各要素を展開して関数に渡すBindWithIndexです。
        /// </summary>
        public static IEnumerable<U> BindWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, int, IEnumerable<U>> f)
        {
            return self.BindWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), i));
        }

        /// <summary>
        /// 8要素タプルのIEnumerableの各要素を展開して関数に渡すSkipWhileです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> SkipWhile<T1, T2, T3, T4, T5, T6, T7, T8>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> f)
        {
            return self.SkipWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのIEnumerableの各要素を展開して関数に渡すTakeWhileです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> TakeWhile<T1, T2, T3, T4, T5, T6, T7, T8>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> f)
        {
            return self.TakeWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのIEnumerableの各要素を展開して関数に渡すSkipWhileWithIndexです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> SkipWhileWithIndex<T1, T2, T3, T4, T5, T6, T7, T8>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, int, bool> f)
        {
            return self.SkipWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), i));
        }

        /// <summary>
        /// 8要素タプルのIEnumerableの各要素を展開して関数に渡すTakeWhileWithIndexです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> TakeWhileWithIndex<T1, T2, T3, T4, T5, T6, T7, T8>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, int, bool> f)
        {
            return self.TakeWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), i));
        }

        /// <summary>
        /// 8要素タプルのIEnumerableの各要素を展開して関数に渡すSpanです。
        /// </summary>
        public static Tuple<IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>>, IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>>> Span<T1, T2, T3, T4, T5, T6, T7, T8>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> f)
        {
            return self.Span(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのIEnumerableの各要素を展開して関数に渡すBreakです。
        /// </summary>
        public static Tuple<IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>>, IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>>> Break<T1, T2, T3, T4, T5, T6, T7, T8>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> f)
        {
            return self.Break(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }
        #endregion

        #region 9要素タプルを扱う関数
        /// <summary>
        /// 9要素タプルの各要素を展開して関数に渡すUnfoldです。
        /// </summary>
        public static IEnumerable<U> Unfold<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Option<Tuple<U, T1, T2, T3, T4, T5, T6, Tuple<T7, T8, T9>>>> f)
        {
            return Unfold(self, tpl =>
                from res in tpl.Match(f)
                select Tuple.Create(res.Fst(), res.RemoveFirst()));
        }

        /// <summary>
        /// 9要素タプルのIEnumerableの各要素を展開して関数に渡すScanです。
        /// </summary>
        public static IEnumerable<U> Scan<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, U> f)
        {
            return self.Scan(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのIEnumerableの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static IEnumerable<U> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのIEnumerableの各要素を展開して関数に渡すMapWithIndexです。
        /// </summary>
        public static IEnumerable<U> MapWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, int, U> f)
        {
            return self.MapWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), i));
        }

        /// <summary>
        /// 9要素タプルのIEnumerableの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static IEnumerable<U> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, IEnumerable<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのIEnumerableの各要素を展開して関数に渡すBindWithIndexです。
        /// </summary>
        public static IEnumerable<U> BindWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, int, IEnumerable<U>> f)
        {
            return self.BindWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), i));
        }

        /// <summary>
        /// 9要素タプルのIEnumerableの各要素を展開して関数に渡すSkipWhileです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> SkipWhile<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> f)
        {
            return self.SkipWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのIEnumerableの各要素を展開して関数に渡すTakeWhileです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> TakeWhile<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> f)
        {
            return self.TakeWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのIEnumerableの各要素を展開して関数に渡すSkipWhileWithIndexです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> SkipWhileWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, int, bool> f)
        {
            return self.SkipWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), i));
        }

        /// <summary>
        /// 9要素タプルのIEnumerableの各要素を展開して関数に渡すTakeWhileWithIndexです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> TakeWhileWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, int, bool> f)
        {
            return self.TakeWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), i));
        }

        /// <summary>
        /// 9要素タプルのIEnumerableの各要素を展開して関数に渡すSpanです。
        /// </summary>
        public static Tuple<IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>>, IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>>> Span<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> f)
        {
            return self.Span(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのIEnumerableの各要素を展開して関数に渡すBreakです。
        /// </summary>
        public static Tuple<IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>>, IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>>> Break<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> f)
        {
            return self.Break(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }
        #endregion

        #region 10要素タプルを扱う関数
        /// <summary>
        /// 10要素タプルの各要素を展開して関数に渡すUnfoldです。
        /// </summary>
        public static IEnumerable<U> Unfold<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Option<Tuple<U, T1, T2, T3, T4, T5, T6, Tuple<T7, T8, T9, T10>>>> f)
        {
            return Unfold(self, tpl =>
                from res in tpl.Match(f)
                select Tuple.Create(res.Fst(), res.RemoveFirst()));
        }

        /// <summary>
        /// 10要素タプルのIEnumerableの各要素を展開して関数に渡すScanです。
        /// </summary>
        public static IEnumerable<U> Scan<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> f)
        {
            return self.Scan(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのIEnumerableの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static IEnumerable<U> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのIEnumerableの各要素を展開して関数に渡すMapWithIndexです。
        /// </summary>
        public static IEnumerable<U> MapWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, int, U> f)
        {
            return self.MapWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), i));
        }

        /// <summary>
        /// 10要素タプルのIEnumerableの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static IEnumerable<U> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, IEnumerable<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのIEnumerableの各要素を展開して関数に渡すBindWithIndexです。
        /// </summary>
        public static IEnumerable<U> BindWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, int, IEnumerable<U>> f)
        {
            return self.BindWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), i));
        }

        /// <summary>
        /// 10要素タプルのIEnumerableの各要素を展開して関数に渡すSkipWhileです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> SkipWhile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> f)
        {
            return self.SkipWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのIEnumerableの各要素を展開して関数に渡すTakeWhileです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> TakeWhile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> f)
        {
            return self.TakeWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのIEnumerableの各要素を展開して関数に渡すSkipWhileWithIndexです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> SkipWhileWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, int, bool> f)
        {
            return self.SkipWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), i));
        }

        /// <summary>
        /// 10要素タプルのIEnumerableの各要素を展開して関数に渡すTakeWhileWithIndexです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> TakeWhileWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, int, bool> f)
        {
            return self.TakeWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), i));
        }

        /// <summary>
        /// 10要素タプルのIEnumerableの各要素を展開して関数に渡すSpanです。
        /// </summary>
        public static Tuple<IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>>, IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>>> Span<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> f)
        {
            return self.Span(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのIEnumerableの各要素を展開して関数に渡すBreakです。
        /// </summary>
        public static Tuple<IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>>, IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>>> Break<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> f)
        {
            return self.Break(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }
        #endregion

        #region 11要素タプルを扱う関数
        /// <summary>
        /// 11要素タプルの各要素を展開して関数に渡すUnfoldです。
        /// </summary>
        public static IEnumerable<U> Unfold<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Option<Tuple<U, T1, T2, T3, T4, T5, T6, Tuple<T7, T8, T9, T10, T11>>>> f)
        {
            return Unfold(self, tpl =>
                from res in tpl.Match(f)
                select Tuple.Create(res.Fst(), res.RemoveFirst()));
        }

        /// <summary>
        /// 11要素タプルのIEnumerableの各要素を展開して関数に渡すScanです。
        /// </summary>
        public static IEnumerable<U> Scan<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> f)
        {
            return self.Scan(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのIEnumerableの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static IEnumerable<U> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのIEnumerableの各要素を展開して関数に渡すMapWithIndexです。
        /// </summary>
        public static IEnumerable<U> MapWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, int, U> f)
        {
            return self.MapWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), i));
        }

        /// <summary>
        /// 11要素タプルのIEnumerableの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static IEnumerable<U> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, IEnumerable<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのIEnumerableの各要素を展開して関数に渡すBindWithIndexです。
        /// </summary>
        public static IEnumerable<U> BindWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, int, IEnumerable<U>> f)
        {
            return self.BindWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), i));
        }

        /// <summary>
        /// 11要素タプルのIEnumerableの各要素を展開して関数に渡すSkipWhileです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> SkipWhile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> f)
        {
            return self.SkipWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのIEnumerableの各要素を展開して関数に渡すTakeWhileです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> TakeWhile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> f)
        {
            return self.TakeWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのIEnumerableの各要素を展開して関数に渡すSkipWhileWithIndexです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> SkipWhileWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, int, bool> f)
        {
            return self.SkipWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), i));
        }

        /// <summary>
        /// 11要素タプルのIEnumerableの各要素を展開して関数に渡すTakeWhileWithIndexです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> TakeWhileWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, int, bool> f)
        {
            return self.TakeWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), i));
        }

        /// <summary>
        /// 11要素タプルのIEnumerableの各要素を展開して関数に渡すSpanです。
        /// </summary>
        public static Tuple<IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>>, IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>>> Span<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> f)
        {
            return self.Span(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのIEnumerableの各要素を展開して関数に渡すBreakです。
        /// </summary>
        public static Tuple<IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>>, IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>>> Break<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> f)
        {
            return self.Break(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }
        #endregion

        #region 12要素タプルを扱う関数
        /// <summary>
        /// 12要素タプルの各要素を展開して関数に渡すUnfoldです。
        /// </summary>
        public static IEnumerable<U> Unfold<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Option<Tuple<U, T1, T2, T3, T4, T5, T6, Tuple<T7, T8, T9, T10, T11, T12>>>> f)
        {
            return Unfold(self, tpl =>
                from res in tpl.Match(f)
                select Tuple.Create(res.Fst(), res.RemoveFirst()));
        }

        /// <summary>
        /// 12要素タプルのIEnumerableの各要素を展開して関数に渡すScanです。
        /// </summary>
        public static IEnumerable<U> Scan<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> f)
        {
            return self.Scan(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのIEnumerableの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static IEnumerable<U> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのIEnumerableの各要素を展開して関数に渡すMapWithIndexです。
        /// </summary>
        public static IEnumerable<U> MapWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, int, U> f)
        {
            return self.MapWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), i));
        }

        /// <summary>
        /// 12要素タプルのIEnumerableの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static IEnumerable<U> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, IEnumerable<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのIEnumerableの各要素を展開して関数に渡すBindWithIndexです。
        /// </summary>
        public static IEnumerable<U> BindWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, int, IEnumerable<U>> f)
        {
            return self.BindWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), i));
        }

        /// <summary>
        /// 12要素タプルのIEnumerableの各要素を展開して関数に渡すSkipWhileです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> SkipWhile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> f)
        {
            return self.SkipWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのIEnumerableの各要素を展開して関数に渡すTakeWhileです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> TakeWhile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> f)
        {
            return self.TakeWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのIEnumerableの各要素を展開して関数に渡すSkipWhileWithIndexです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> SkipWhileWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, int, bool> f)
        {
            return self.SkipWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), i));
        }

        /// <summary>
        /// 12要素タプルのIEnumerableの各要素を展開して関数に渡すTakeWhileWithIndexです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> TakeWhileWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, int, bool> f)
        {
            return self.TakeWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), i));
        }

        /// <summary>
        /// 12要素タプルのIEnumerableの各要素を展開して関数に渡すSpanです。
        /// </summary>
        public static Tuple<IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>>, IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>>> Span<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> f)
        {
            return self.Span(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのIEnumerableの各要素を展開して関数に渡すBreakです。
        /// </summary>
        public static Tuple<IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>>, IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>>> Break<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> f)
        {
            return self.Break(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }
        #endregion

        #region 13要素タプルを扱う関数
        /// <summary>
        /// 13要素タプルの各要素を展開して関数に渡すUnfoldです。
        /// </summary>
        public static IEnumerable<U> Unfold<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Option<Tuple<U, T1, T2, T3, T4, T5, T6, Tuple<T7, T8, T9, T10, T11, T12, T13>>>> f)
        {
            return Unfold(self, tpl =>
                from res in tpl.Match(f)
                select Tuple.Create(res.Fst(), res.RemoveFirst()));
        }

        /// <summary>
        /// 13要素タプルのIEnumerableの各要素を展開して関数に渡すScanです。
        /// </summary>
        public static IEnumerable<U> Scan<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> f)
        {
            return self.Scan(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのIEnumerableの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static IEnumerable<U> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのIEnumerableの各要素を展開して関数に渡すMapWithIndexです。
        /// </summary>
        public static IEnumerable<U> MapWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, int, U> f)
        {
            return self.MapWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), i));
        }

        /// <summary>
        /// 13要素タプルのIEnumerableの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static IEnumerable<U> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, IEnumerable<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのIEnumerableの各要素を展開して関数に渡すBindWithIndexです。
        /// </summary>
        public static IEnumerable<U> BindWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, int, IEnumerable<U>> f)
        {
            return self.BindWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), i));
        }

        /// <summary>
        /// 13要素タプルのIEnumerableの各要素を展開して関数に渡すSkipWhileです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> SkipWhile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> f)
        {
            return self.SkipWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのIEnumerableの各要素を展開して関数に渡すTakeWhileです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> TakeWhile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> f)
        {
            return self.TakeWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのIEnumerableの各要素を展開して関数に渡すSkipWhileWithIndexです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> SkipWhileWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, int, bool> f)
        {
            return self.SkipWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), i));
        }

        /// <summary>
        /// 13要素タプルのIEnumerableの各要素を展開して関数に渡すTakeWhileWithIndexです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> TakeWhileWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, int, bool> f)
        {
            return self.TakeWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), i));
        }

        /// <summary>
        /// 13要素タプルのIEnumerableの各要素を展開して関数に渡すSpanです。
        /// </summary>
        public static Tuple<IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>>, IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>>> Span<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> f)
        {
            return self.Span(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのIEnumerableの各要素を展開して関数に渡すBreakです。
        /// </summary>
        public static Tuple<IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>>, IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>>> Break<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> f)
        {
            return self.Break(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }
        #endregion

        #region 14要素タプルを扱う関数
        /// <summary>
        /// 14要素タプルの各要素を展開して関数に渡すUnfoldです。
        /// </summary>
        public static IEnumerable<U> Unfold<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Option<Tuple<U, T1, T2, T3, T4, T5, T6, Tuple<T7, T8, T9, T10, T11, T12, T13, Tuple<T14>>>>> f)
        {
            return Unfold(self, tpl =>
                from res in tpl.Match(f)
                select Tuple.Create(res.Fst(), res.RemoveFirst()));
        }

        /// <summary>
        /// 14要素タプルのIEnumerableの各要素を展開して関数に渡すScanです。
        /// </summary>
        public static IEnumerable<U> Scan<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> f)
        {
            return self.Scan(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのIEnumerableの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static IEnumerable<U> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのIEnumerableの各要素を展開して関数に渡すMapWithIndexです。
        /// </summary>
        public static IEnumerable<U> MapWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, int, U> f)
        {
            return self.MapWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), i));
        }

        /// <summary>
        /// 14要素タプルのIEnumerableの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static IEnumerable<U> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, IEnumerable<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのIEnumerableの各要素を展開して関数に渡すBindWithIndexです。
        /// </summary>
        public static IEnumerable<U> BindWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, int, IEnumerable<U>> f)
        {
            return self.BindWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), i));
        }

        /// <summary>
        /// 14要素タプルのIEnumerableの各要素を展開して関数に渡すSkipWhileです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> SkipWhile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> f)
        {
            return self.SkipWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのIEnumerableの各要素を展開して関数に渡すTakeWhileです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> TakeWhile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> f)
        {
            return self.TakeWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのIEnumerableの各要素を展開して関数に渡すSkipWhileWithIndexです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> SkipWhileWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, int, bool> f)
        {
            return self.SkipWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), i));
        }

        /// <summary>
        /// 14要素タプルのIEnumerableの各要素を展開して関数に渡すTakeWhileWithIndexです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> TakeWhileWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, int, bool> f)
        {
            return self.TakeWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), i));
        }

        /// <summary>
        /// 14要素タプルのIEnumerableの各要素を展開して関数に渡すSpanです。
        /// </summary>
        public static Tuple<IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>>, IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>>> Span<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> f)
        {
            return self.Span(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのIEnumerableの各要素を展開して関数に渡すBreakです。
        /// </summary>
        public static Tuple<IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>>, IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>>> Break<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> f)
        {
            return self.Break(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }
        #endregion

        #region 15要素タプルを扱う関数
        /// <summary>
        /// 15要素タプルの各要素を展開して関数に渡すUnfoldです。
        /// </summary>
        public static IEnumerable<U> Unfold<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Option<Tuple<U, T1, T2, T3, T4, T5, T6, Tuple<T7, T8, T9, T10, T11, T12, T13, Tuple<T14, T15>>>>> f)
        {
            return Unfold(self, tpl =>
                from res in tpl.Match(f)
                select Tuple.Create(res.Fst(), res.RemoveFirst()));
        }

        /// <summary>
        /// 15要素タプルのIEnumerableの各要素を展開して関数に渡すScanです。
        /// </summary>
        public static IEnumerable<U> Scan<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> f)
        {
            return self.Scan(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのIEnumerableの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static IEnumerable<U> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのIEnumerableの各要素を展開して関数に渡すMapWithIndexです。
        /// </summary>
        public static IEnumerable<U> MapWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, int, U> f)
        {
            return self.MapWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), i));
        }

        /// <summary>
        /// 15要素タプルのIEnumerableの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static IEnumerable<U> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, IEnumerable<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのIEnumerableの各要素を展開して関数に渡すBindWithIndexです。
        /// </summary>
        public static IEnumerable<U> BindWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, int, IEnumerable<U>> f)
        {
            return self.BindWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), i));
        }

        /// <summary>
        /// 15要素タプルのIEnumerableの各要素を展開して関数に渡すSkipWhileです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> SkipWhile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> f)
        {
            return self.SkipWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのIEnumerableの各要素を展開して関数に渡すTakeWhileです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> TakeWhile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> f)
        {
            return self.TakeWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのIEnumerableの各要素を展開して関数に渡すSkipWhileWithIndexです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> SkipWhileWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, int, bool> f)
        {
            return self.SkipWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), i));
        }

        /// <summary>
        /// 15要素タプルのIEnumerableの各要素を展開して関数に渡すTakeWhileWithIndexです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> TakeWhileWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, int, bool> f)
        {
            return self.TakeWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), i));
        }

        /// <summary>
        /// 15要素タプルのIEnumerableの各要素を展開して関数に渡すSpanです。
        /// </summary>
        public static Tuple<IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>>, IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>>> Span<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> f)
        {
            return self.Span(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのIEnumerableの各要素を展開して関数に渡すBreakです。
        /// </summary>
        public static Tuple<IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>>, IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>>> Break<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> f)
        {
            return self.Break(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }
        #endregion

        #region 16要素タプルを扱う関数

        /// <summary>
        /// 16要素タプルのIEnumerableの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static IEnumerable<U> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのIEnumerableの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static IEnumerable<U> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, IEnumerable<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのIEnumerableの各要素を展開して関数に渡すSkipWhileです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> SkipWhile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> f)
        {
            return self.SkipWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのIEnumerableの各要素を展開して関数に渡すTakeWhileです。
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> TakeWhile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> f)
        {
            return self.TakeWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのIEnumerableの各要素を展開して関数に渡すSpanです。
        /// </summary>
        public static Tuple<IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>>, IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>>> Span<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> f)
        {
            return self.Span(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのIEnumerableの各要素を展開して関数に渡すBreakです。
        /// </summary>
        public static Tuple<IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>>, IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>>> Break<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> f)
        {
            return self.Break(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }
        #endregion

    }
}