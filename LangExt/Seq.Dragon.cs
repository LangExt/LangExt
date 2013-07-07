
using System;
using System.Collections.Generic;

namespace LangExt
{
    partial class Seq
    {
        #region 2要素タプルを扱う関数
        /// <summary>
        /// 2要素タプルの各要素を展開して関数に渡すUnfoldです。
        /// </summary>
        public static ISeq<U> Unfold<T1, T2, U>(this Tuple<T1, T2> self, Func<T1, T2, Option<Tuple<U, T1, T2>>> f)
        {
            return Unfold(self, tpl =>
                from res in tpl.Match(f)
                select Tuple.Create(res.Fst(), res.RemoveFirst()));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すLongCountです。
        /// </summary>
        public static long LongCount<T1, T2>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, bool> f)
        {
            return self.LongCount(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すSumByです。
        /// </summary>
        public static int SumBy<T1, T2>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, int> f)
        {
            return self.SumBy(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すLongSumByです。
        /// </summary>
        public static long LongSumBy<T1, T2>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, long> f)
        {
            return self.LongSumBy(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すSumByです。
        /// </summary>
        public static U SumBy<T1, T2, U>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, U> f, ISumStrategy<U> strategy)
        {
            return self.SumBy(tpl => f(tpl._1(), tpl._2()), strategy);
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すTryMaxByです。
        /// </summary>
        public static Option<Tuple<T1, T2>> TryMaxBy<T1, T2, U>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, U> f) where U : IComparable<U>
        {
            return self.TryMaxBy(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すTryMinByです。
        /// </summary>
        public static Option<Tuple<T1, T2>> TryMinBy<T1, T2, U>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, U> f) where U : IComparable<U>
        {
            return self.TryMinBy(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, U>(this ISeq<Tuple<T1, T2>> self, U init, Func<U, T1, T2, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すTryReduceです。
        /// </summary>
        public static Option<Tuple<T1, T2>> TryReduce<T1, T2>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, T1, T2, Tuple<T1, T2>> f)
        {
            return self.TryReduce((acc, tpl) => f(acc._1(), acc._2(), tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すFoldBackです。
        /// </summary>
        public static U FoldBack<T1, T2, U>(this ISeq<Tuple<T1, T2>> self, U init, Func<T1, T2, U, U> f)
        {
            return self.FoldBack(init, (tpl, xs) => f(tpl._1(), tpl._2(), xs));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すTryReduceBackです。
        /// </summary>
        public static Option<Tuple<T1, T2>> TryReduceBack<T1, T2>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, T1, T2, Tuple<T1, T2>> f)
        {
            return self.TryReduceBack((tpl, xs) => f(tpl._1(), tpl._2(), xs._1(), xs._2()));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すScanです。
        /// </summary>
        public static ISeq<U> Scan<T1, T2, U>(this ISeq<Tuple<T1, T2>> self, U init, Func<U, T1, T2, U> f)
        {
            return self.Scan(init, (acc, tpl) => f(acc, tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すScanBackです。
        /// </summary>
        public static ISeq<U> ScanBack<T1, T2, U>(this ISeq<Tuple<T1, T2>> self, U init, Func<T1, T2, U, U> f)
        {
            return self.ScanBack(init, (tpl, xs) => f(tpl._1(), tpl._2(), xs));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すScan1です。
        /// </summary>
        public static ISeq<Tuple<T1, T2>> Scan1<T1, T2>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, T1, T2, Tuple<T1, T2>> f)
        {
            return self.Scan1((acc, tpl) => f(acc._1(), acc._2(), tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すScanBack1です。
        /// </summary>
        public static ISeq<Tuple<T1, T2>> ScanBack1<T1, T2>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, T1, T2, Tuple<T1, T2>> f)
        {
            return self.ScanBack1((tpl, xs) => f(tpl._1(), tpl._2(), xs._1(), xs._2()));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すTryFindです。
        /// </summary>
        public static Option<Tuple<T1, T2>> TryFind<T1, T2>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, bool> f)
        {
            return self.TryFind(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すTryPickです。
        /// </summary>
        public static Option<U> TryPick<T1, T2, U>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, Option<U>> f)
        {
            return self.TryPick(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すFilterです。
        /// </summary>
        public static ISeq<Tuple<T1, T2>> Filter<T1, T2>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, bool> f)
        {
            return self.Filter(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すFilterWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2>> FilterWithIndex<T1, T2>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, int, bool> f)
        {
            return self.FilterWithIndex((tpl, i) => f(tpl._1(), tpl._2(), i));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static ISeq<U> Map<T1, T2, U>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すMapWithIndexです。
        /// </summary>
        public static ISeq<U> MapWithIndex<T1, T2, U>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, int, U> f)
        {
            return self.MapWithIndex((tpl, i) => f(tpl._1(), tpl._2(), i));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2>(this ISeq<Tuple<T1, T2>> self, Action<T1, T2> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すIterWithIndexです。
        /// </summary>
        public static void IterWithIndex<T1, T2>(this ISeq<Tuple<T1, T2>> self, Action<T1, T2, int> f)
        {
            self.IterWithIndex((tpl, i) => f(tpl._1(), tpl._2(), i));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static ISeq<U> Bind<T1, T2, U>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, ISeq<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すBindWithIndexです。
        /// </summary>
        public static ISeq<U> BindWithIndex<T1, T2, U>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, int, ISeq<U>> f)
        {
            return self.BindWithIndex((tpl, i) => f(tpl._1(), tpl._2(), i));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すChooseです。
        /// </summary>
        public static ISeq<U> Choose<T1, T2, U>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, Option<U>> f)
        {
            return self.Choose(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すChooseWithIndexです。
        /// </summary>
        public static ISeq<U> ChooseWithIndex<T1, T2, U>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, int, Option<U>> f)
        {
            return self.ChooseWithIndex((tpl, i) => f(tpl._1(), tpl._2(), i));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すSkipWhileです。
        /// </summary>
        public static ISeq<Tuple<T1, T2>> SkipWhile<T1, T2>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, bool> f)
        {
            return self.SkipWhile(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すTakeWhileです。
        /// </summary>
        public static ISeq<Tuple<T1, T2>> TakeWhile<T1, T2>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, bool> f)
        {
            return self.TakeWhile(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すSkipWhileWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2>> SkipWhileWithIndex<T1, T2>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, int, bool> f)
        {
            return self.SkipWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), i));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すTakeWhileWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2>> TakeWhileWithIndex<T1, T2>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, int, bool> f)
        {
            return self.TakeWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), i));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すPartitionです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2>>, ISeq<Tuple<T1, T2>>> Partition<T1, T2>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, bool> f)
        {
            return self.Partition(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すSpanです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2>>, ISeq<Tuple<T1, T2>>> Span<T1, T2>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, bool> f)
        {
            return self.Span(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すBreakです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2>>, ISeq<Tuple<T1, T2>>> Break<T1, T2>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, bool> f)
        {
            return self.Break(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すSortByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2>> SortBy<T1, T2, U>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, U> f)
        {
            return self.SortBy(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すRevSortByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2>> RevSortBy<T1, T2, U>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, U> f)
        {
            return self.RevSortBy(tpl => f(tpl._1(), tpl._2()));
        }
        #endregion

        #region 3要素タプルを扱う関数
        /// <summary>
        /// 3要素タプルの各要素を展開して関数に渡すUnfoldです。
        /// </summary>
        public static ISeq<U> Unfold<T1, T2, T3, U>(this Tuple<T1, T2, T3> self, Func<T1, T2, T3, Option<Tuple<U, T1, T2, T3>>> f)
        {
            return Unfold(self, tpl =>
                from res in tpl.Match(f)
                select Tuple.Create(res.Fst(), res.RemoveFirst()));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すLongCountです。
        /// </summary>
        public static long LongCount<T1, T2, T3>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, bool> f)
        {
            return self.LongCount(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すSumByです。
        /// </summary>
        public static int SumBy<T1, T2, T3>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, int> f)
        {
            return self.SumBy(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すLongSumByです。
        /// </summary>
        public static long LongSumBy<T1, T2, T3>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, long> f)
        {
            return self.LongSumBy(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すSumByです。
        /// </summary>
        public static U SumBy<T1, T2, T3, U>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, U> f, ISumStrategy<U> strategy)
        {
            return self.SumBy(tpl => f(tpl._1(), tpl._2(), tpl._3()), strategy);
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すTryMaxByです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3>> TryMaxBy<T1, T2, T3, U>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, U> f) where U : IComparable<U>
        {
            return self.TryMaxBy(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すTryMinByです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3>> TryMinBy<T1, T2, T3, U>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, U> f) where U : IComparable<U>
        {
            return self.TryMinBy(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, U>(this ISeq<Tuple<T1, T2, T3>> self, U init, Func<U, T1, T2, T3, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すTryReduceです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3>> TryReduce<T1, T2, T3>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, T1, T2, T3, Tuple<T1, T2, T3>> f)
        {
            return self.TryReduce((acc, tpl) => f(acc._1(), acc._2(), acc._3(), tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すFoldBackです。
        /// </summary>
        public static U FoldBack<T1, T2, T3, U>(this ISeq<Tuple<T1, T2, T3>> self, U init, Func<T1, T2, T3, U, U> f)
        {
            return self.FoldBack(init, (tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), xs));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すTryReduceBackです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3>> TryReduceBack<T1, T2, T3>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, T1, T2, T3, Tuple<T1, T2, T3>> f)
        {
            return self.TryReduceBack((tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), xs._1(), xs._2(), xs._3()));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すScanです。
        /// </summary>
        public static ISeq<U> Scan<T1, T2, T3, U>(this ISeq<Tuple<T1, T2, T3>> self, U init, Func<U, T1, T2, T3, U> f)
        {
            return self.Scan(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すScanBackです。
        /// </summary>
        public static ISeq<U> ScanBack<T1, T2, T3, U>(this ISeq<Tuple<T1, T2, T3>> self, U init, Func<T1, T2, T3, U, U> f)
        {
            return self.ScanBack(init, (tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), xs));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すScan1です。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3>> Scan1<T1, T2, T3>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, T1, T2, T3, Tuple<T1, T2, T3>> f)
        {
            return self.Scan1((acc, tpl) => f(acc._1(), acc._2(), acc._3(), tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すScanBack1です。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3>> ScanBack1<T1, T2, T3>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, T1, T2, T3, Tuple<T1, T2, T3>> f)
        {
            return self.ScanBack1((tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), xs._1(), xs._2(), xs._3()));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すTryFindです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3>> TryFind<T1, T2, T3>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, bool> f)
        {
            return self.TryFind(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すTryPickです。
        /// </summary>
        public static Option<U> TryPick<T1, T2, T3, U>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, Option<U>> f)
        {
            return self.TryPick(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すFilterです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3>> Filter<T1, T2, T3>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, bool> f)
        {
            return self.Filter(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すFilterWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3>> FilterWithIndex<T1, T2, T3>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, int, bool> f)
        {
            return self.FilterWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), i));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static ISeq<U> Map<T1, T2, T3, U>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すMapWithIndexです。
        /// </summary>
        public static ISeq<U> MapWithIndex<T1, T2, T3, U>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, int, U> f)
        {
            return self.MapWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), i));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3>(this ISeq<Tuple<T1, T2, T3>> self, Action<T1, T2, T3> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すIterWithIndexです。
        /// </summary>
        public static void IterWithIndex<T1, T2, T3>(this ISeq<Tuple<T1, T2, T3>> self, Action<T1, T2, T3, int> f)
        {
            self.IterWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), i));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static ISeq<U> Bind<T1, T2, T3, U>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, ISeq<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すBindWithIndexです。
        /// </summary>
        public static ISeq<U> BindWithIndex<T1, T2, T3, U>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, int, ISeq<U>> f)
        {
            return self.BindWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), i));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すChooseです。
        /// </summary>
        public static ISeq<U> Choose<T1, T2, T3, U>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, Option<U>> f)
        {
            return self.Choose(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すChooseWithIndexです。
        /// </summary>
        public static ISeq<U> ChooseWithIndex<T1, T2, T3, U>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, int, Option<U>> f)
        {
            return self.ChooseWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), i));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すSkipWhileです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3>> SkipWhile<T1, T2, T3>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, bool> f)
        {
            return self.SkipWhile(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すTakeWhileです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3>> TakeWhile<T1, T2, T3>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, bool> f)
        {
            return self.TakeWhile(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すSkipWhileWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3>> SkipWhileWithIndex<T1, T2, T3>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, int, bool> f)
        {
            return self.SkipWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), i));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すTakeWhileWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3>> TakeWhileWithIndex<T1, T2, T3>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, int, bool> f)
        {
            return self.TakeWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), i));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すPartitionです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3>>, ISeq<Tuple<T1, T2, T3>>> Partition<T1, T2, T3>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, bool> f)
        {
            return self.Partition(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すSpanです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3>>, ISeq<Tuple<T1, T2, T3>>> Span<T1, T2, T3>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, bool> f)
        {
            return self.Span(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すBreakです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3>>, ISeq<Tuple<T1, T2, T3>>> Break<T1, T2, T3>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, bool> f)
        {
            return self.Break(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すSortByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3>> SortBy<T1, T2, T3, U>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, U> f)
        {
            return self.SortBy(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すRevSortByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3>> RevSortBy<T1, T2, T3, U>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, U> f)
        {
            return self.RevSortBy(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }
        #endregion

        #region 4要素タプルを扱う関数
        /// <summary>
        /// 4要素タプルの各要素を展開して関数に渡すUnfoldです。
        /// </summary>
        public static ISeq<U> Unfold<T1, T2, T3, T4, U>(this Tuple<T1, T2, T3, T4> self, Func<T1, T2, T3, T4, Option<Tuple<U, T1, T2, T3, T4>>> f)
        {
            return Unfold(self, tpl =>
                from res in tpl.Match(f)
                select Tuple.Create(res.Fst(), res.RemoveFirst()));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すLongCountです。
        /// </summary>
        public static long LongCount<T1, T2, T3, T4>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, bool> f)
        {
            return self.LongCount(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すSumByです。
        /// </summary>
        public static int SumBy<T1, T2, T3, T4>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, int> f)
        {
            return self.SumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すLongSumByです。
        /// </summary>
        public static long LongSumBy<T1, T2, T3, T4>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, long> f)
        {
            return self.LongSumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すSumByです。
        /// </summary>
        public static U SumBy<T1, T2, T3, T4, U>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, U> f, ISumStrategy<U> strategy)
        {
            return self.SumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()), strategy);
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すTryMaxByです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4>> TryMaxBy<T1, T2, T3, T4, U>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, U> f) where U : IComparable<U>
        {
            return self.TryMaxBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すTryMinByです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4>> TryMinBy<T1, T2, T3, T4, U>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, U> f) where U : IComparable<U>
        {
            return self.TryMinBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, U>(this ISeq<Tuple<T1, T2, T3, T4>> self, U init, Func<U, T1, T2, T3, T4, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すTryReduceです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4>> TryReduce<T1, T2, T3, T4>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, T1, T2, T3, T4, Tuple<T1, T2, T3, T4>> f)
        {
            return self.TryReduce((acc, tpl) => f(acc._1(), acc._2(), acc._3(), acc._4(), tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すFoldBackです。
        /// </summary>
        public static U FoldBack<T1, T2, T3, T4, U>(this ISeq<Tuple<T1, T2, T3, T4>> self, U init, Func<T1, T2, T3, T4, U, U> f)
        {
            return self.FoldBack(init, (tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), xs));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すTryReduceBackです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4>> TryReduceBack<T1, T2, T3, T4>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, T1, T2, T3, T4, Tuple<T1, T2, T3, T4>> f)
        {
            return self.TryReduceBack((tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), xs._1(), xs._2(), xs._3(), xs._4()));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すScanです。
        /// </summary>
        public static ISeq<U> Scan<T1, T2, T3, T4, U>(this ISeq<Tuple<T1, T2, T3, T4>> self, U init, Func<U, T1, T2, T3, T4, U> f)
        {
            return self.Scan(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すScanBackです。
        /// </summary>
        public static ISeq<U> ScanBack<T1, T2, T3, T4, U>(this ISeq<Tuple<T1, T2, T3, T4>> self, U init, Func<T1, T2, T3, T4, U, U> f)
        {
            return self.ScanBack(init, (tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), xs));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すScan1です。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4>> Scan1<T1, T2, T3, T4>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, T1, T2, T3, T4, Tuple<T1, T2, T3, T4>> f)
        {
            return self.Scan1((acc, tpl) => f(acc._1(), acc._2(), acc._3(), acc._4(), tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すScanBack1です。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4>> ScanBack1<T1, T2, T3, T4>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, T1, T2, T3, T4, Tuple<T1, T2, T3, T4>> f)
        {
            return self.ScanBack1((tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), xs._1(), xs._2(), xs._3(), xs._4()));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すTryFindです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4>> TryFind<T1, T2, T3, T4>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, bool> f)
        {
            return self.TryFind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すTryPickです。
        /// </summary>
        public static Option<U> TryPick<T1, T2, T3, T4, U>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, Option<U>> f)
        {
            return self.TryPick(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すFilterです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4>> Filter<T1, T2, T3, T4>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, bool> f)
        {
            return self.Filter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すFilterWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4>> FilterWithIndex<T1, T2, T3, T4>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, int, bool> f)
        {
            return self.FilterWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), i));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static ISeq<U> Map<T1, T2, T3, T4, U>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すMapWithIndexです。
        /// </summary>
        public static ISeq<U> MapWithIndex<T1, T2, T3, T4, U>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, int, U> f)
        {
            return self.MapWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), i));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4>(this ISeq<Tuple<T1, T2, T3, T4>> self, Action<T1, T2, T3, T4> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すIterWithIndexです。
        /// </summary>
        public static void IterWithIndex<T1, T2, T3, T4>(this ISeq<Tuple<T1, T2, T3, T4>> self, Action<T1, T2, T3, T4, int> f)
        {
            self.IterWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), i));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static ISeq<U> Bind<T1, T2, T3, T4, U>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, ISeq<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すBindWithIndexです。
        /// </summary>
        public static ISeq<U> BindWithIndex<T1, T2, T3, T4, U>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, int, ISeq<U>> f)
        {
            return self.BindWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), i));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すChooseです。
        /// </summary>
        public static ISeq<U> Choose<T1, T2, T3, T4, U>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, Option<U>> f)
        {
            return self.Choose(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すChooseWithIndexです。
        /// </summary>
        public static ISeq<U> ChooseWithIndex<T1, T2, T3, T4, U>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, int, Option<U>> f)
        {
            return self.ChooseWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), i));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すSkipWhileです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4>> SkipWhile<T1, T2, T3, T4>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, bool> f)
        {
            return self.SkipWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すTakeWhileです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4>> TakeWhile<T1, T2, T3, T4>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, bool> f)
        {
            return self.TakeWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すSkipWhileWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4>> SkipWhileWithIndex<T1, T2, T3, T4>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, int, bool> f)
        {
            return self.SkipWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), i));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すTakeWhileWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4>> TakeWhileWithIndex<T1, T2, T3, T4>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, int, bool> f)
        {
            return self.TakeWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), i));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すPartitionです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4>>, ISeq<Tuple<T1, T2, T3, T4>>> Partition<T1, T2, T3, T4>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, bool> f)
        {
            return self.Partition(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すSpanです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4>>, ISeq<Tuple<T1, T2, T3, T4>>> Span<T1, T2, T3, T4>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, bool> f)
        {
            return self.Span(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すBreakです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4>>, ISeq<Tuple<T1, T2, T3, T4>>> Break<T1, T2, T3, T4>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, bool> f)
        {
            return self.Break(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すSortByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4>> SortBy<T1, T2, T3, T4, U>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, U> f)
        {
            return self.SortBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すRevSortByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4>> RevSortBy<T1, T2, T3, T4, U>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, U> f)
        {
            return self.RevSortBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }
        #endregion

        #region 5要素タプルを扱う関数
        /// <summary>
        /// 5要素タプルの各要素を展開して関数に渡すUnfoldです。
        /// </summary>
        public static ISeq<U> Unfold<T1, T2, T3, T4, T5, U>(this Tuple<T1, T2, T3, T4, T5> self, Func<T1, T2, T3, T4, T5, Option<Tuple<U, T1, T2, T3, T4, T5>>> f)
        {
            return Unfold(self, tpl =>
                from res in tpl.Match(f)
                select Tuple.Create(res.Fst(), res.RemoveFirst()));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すLongCountです。
        /// </summary>
        public static long LongCount<T1, T2, T3, T4, T5>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, bool> f)
        {
            return self.LongCount(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すSumByです。
        /// </summary>
        public static int SumBy<T1, T2, T3, T4, T5>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, int> f)
        {
            return self.SumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すLongSumByです。
        /// </summary>
        public static long LongSumBy<T1, T2, T3, T4, T5>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, long> f)
        {
            return self.LongSumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すSumByです。
        /// </summary>
        public static U SumBy<T1, T2, T3, T4, T5, U>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, U> f, ISumStrategy<U> strategy)
        {
            return self.SumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()), strategy);
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すTryMaxByです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5>> TryMaxBy<T1, T2, T3, T4, T5, U>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, U> f) where U : IComparable<U>
        {
            return self.TryMaxBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すTryMinByです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5>> TryMinBy<T1, T2, T3, T4, T5, U>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, U> f) where U : IComparable<U>
        {
            return self.TryMinBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, T5, U>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, U init, Func<U, T1, T2, T3, T4, T5, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すTryReduceです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5>> TryReduce<T1, T2, T3, T4, T5>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, Tuple<T1, T2, T3, T4, T5>> f)
        {
            return self.TryReduce((acc, tpl) => f(acc._1(), acc._2(), acc._3(), acc._4(), acc._5(), tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すFoldBackです。
        /// </summary>
        public static U FoldBack<T1, T2, T3, T4, T5, U>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, U init, Func<T1, T2, T3, T4, T5, U, U> f)
        {
            return self.FoldBack(init, (tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), xs));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すTryReduceBackです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5>> TryReduceBack<T1, T2, T3, T4, T5>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, Tuple<T1, T2, T3, T4, T5>> f)
        {
            return self.TryReduceBack((tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), xs._1(), xs._2(), xs._3(), xs._4(), xs._5()));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すScanです。
        /// </summary>
        public static ISeq<U> Scan<T1, T2, T3, T4, T5, U>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, U init, Func<U, T1, T2, T3, T4, T5, U> f)
        {
            return self.Scan(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すScanBackです。
        /// </summary>
        public static ISeq<U> ScanBack<T1, T2, T3, T4, T5, U>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, U init, Func<T1, T2, T3, T4, T5, U, U> f)
        {
            return self.ScanBack(init, (tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), xs));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すScan1です。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5>> Scan1<T1, T2, T3, T4, T5>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, Tuple<T1, T2, T3, T4, T5>> f)
        {
            return self.Scan1((acc, tpl) => f(acc._1(), acc._2(), acc._3(), acc._4(), acc._5(), tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すScanBack1です。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5>> ScanBack1<T1, T2, T3, T4, T5>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, Tuple<T1, T2, T3, T4, T5>> f)
        {
            return self.ScanBack1((tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), xs._1(), xs._2(), xs._3(), xs._4(), xs._5()));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すTryFindです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5>> TryFind<T1, T2, T3, T4, T5>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, bool> f)
        {
            return self.TryFind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すTryPickです。
        /// </summary>
        public static Option<U> TryPick<T1, T2, T3, T4, T5, U>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, Option<U>> f)
        {
            return self.TryPick(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すFilterです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5>> Filter<T1, T2, T3, T4, T5>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, bool> f)
        {
            return self.Filter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すFilterWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5>> FilterWithIndex<T1, T2, T3, T4, T5>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, int, bool> f)
        {
            return self.FilterWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), i));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static ISeq<U> Map<T1, T2, T3, T4, T5, U>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すMapWithIndexです。
        /// </summary>
        public static ISeq<U> MapWithIndex<T1, T2, T3, T4, T5, U>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, int, U> f)
        {
            return self.MapWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), i));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Action<T1, T2, T3, T4, T5> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すIterWithIndexです。
        /// </summary>
        public static void IterWithIndex<T1, T2, T3, T4, T5>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Action<T1, T2, T3, T4, T5, int> f)
        {
            self.IterWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), i));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static ISeq<U> Bind<T1, T2, T3, T4, T5, U>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, ISeq<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すBindWithIndexです。
        /// </summary>
        public static ISeq<U> BindWithIndex<T1, T2, T3, T4, T5, U>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, int, ISeq<U>> f)
        {
            return self.BindWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), i));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すChooseです。
        /// </summary>
        public static ISeq<U> Choose<T1, T2, T3, T4, T5, U>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, Option<U>> f)
        {
            return self.Choose(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すChooseWithIndexです。
        /// </summary>
        public static ISeq<U> ChooseWithIndex<T1, T2, T3, T4, T5, U>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, int, Option<U>> f)
        {
            return self.ChooseWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), i));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すSkipWhileです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5>> SkipWhile<T1, T2, T3, T4, T5>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, bool> f)
        {
            return self.SkipWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すTakeWhileです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5>> TakeWhile<T1, T2, T3, T4, T5>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, bool> f)
        {
            return self.TakeWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すSkipWhileWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5>> SkipWhileWithIndex<T1, T2, T3, T4, T5>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, int, bool> f)
        {
            return self.SkipWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), i));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すTakeWhileWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5>> TakeWhileWithIndex<T1, T2, T3, T4, T5>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, int, bool> f)
        {
            return self.TakeWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), i));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すPartitionです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5>>, ISeq<Tuple<T1, T2, T3, T4, T5>>> Partition<T1, T2, T3, T4, T5>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, bool> f)
        {
            return self.Partition(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すSpanです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5>>, ISeq<Tuple<T1, T2, T3, T4, T5>>> Span<T1, T2, T3, T4, T5>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, bool> f)
        {
            return self.Span(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すBreakです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5>>, ISeq<Tuple<T1, T2, T3, T4, T5>>> Break<T1, T2, T3, T4, T5>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, bool> f)
        {
            return self.Break(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すSortByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5>> SortBy<T1, T2, T3, T4, T5, U>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, U> f)
        {
            return self.SortBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すRevSortByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5>> RevSortBy<T1, T2, T3, T4, T5, U>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, U> f)
        {
            return self.RevSortBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }
        #endregion

        #region 6要素タプルを扱う関数
        /// <summary>
        /// 6要素タプルの各要素を展開して関数に渡すUnfoldです。
        /// </summary>
        public static ISeq<U> Unfold<T1, T2, T3, T4, T5, T6, U>(this Tuple<T1, T2, T3, T4, T5, T6> self, Func<T1, T2, T3, T4, T5, T6, Option<Tuple<U, T1, T2, T3, T4, T5, T6>>> f)
        {
            return Unfold(self, tpl =>
                from res in tpl.Match(f)
                select Tuple.Create(res.Fst(), res.RemoveFirst()));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5, T6>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すLongCountです。
        /// </summary>
        public static long LongCount<T1, T2, T3, T4, T5, T6>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, bool> f)
        {
            return self.LongCount(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すSumByです。
        /// </summary>
        public static int SumBy<T1, T2, T3, T4, T5, T6>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, int> f)
        {
            return self.SumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すLongSumByです。
        /// </summary>
        public static long LongSumBy<T1, T2, T3, T4, T5, T6>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, long> f)
        {
            return self.LongSumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すSumByです。
        /// </summary>
        public static U SumBy<T1, T2, T3, T4, T5, T6, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, U> f, ISumStrategy<U> strategy)
        {
            return self.SumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()), strategy);
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すTryMaxByです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6>> TryMaxBy<T1, T2, T3, T4, T5, T6, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, U> f) where U : IComparable<U>
        {
            return self.TryMaxBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すTryMinByです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6>> TryMinBy<T1, T2, T3, T4, T5, T6, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, U> f) where U : IComparable<U>
        {
            return self.TryMinBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, T5, T6, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すTryReduceです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6>> TryReduce<T1, T2, T3, T4, T5, T6>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, Tuple<T1, T2, T3, T4, T5, T6>> f)
        {
            return self.TryReduce((acc, tpl) => f(acc._1(), acc._2(), acc._3(), acc._4(), acc._5(), acc._6(), tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すFoldBackです。
        /// </summary>
        public static U FoldBack<T1, T2, T3, T4, T5, T6, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, U init, Func<T1, T2, T3, T4, T5, T6, U, U> f)
        {
            return self.FoldBack(init, (tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), xs));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すTryReduceBackです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6>> TryReduceBack<T1, T2, T3, T4, T5, T6>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, Tuple<T1, T2, T3, T4, T5, T6>> f)
        {
            return self.TryReduceBack((tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), xs._1(), xs._2(), xs._3(), xs._4(), xs._5(), xs._6()));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すScanです。
        /// </summary>
        public static ISeq<U> Scan<T1, T2, T3, T4, T5, T6, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, U> f)
        {
            return self.Scan(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すScanBackです。
        /// </summary>
        public static ISeq<U> ScanBack<T1, T2, T3, T4, T5, T6, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, U init, Func<T1, T2, T3, T4, T5, T6, U, U> f)
        {
            return self.ScanBack(init, (tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), xs));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すScan1です。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6>> Scan1<T1, T2, T3, T4, T5, T6>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, Tuple<T1, T2, T3, T4, T5, T6>> f)
        {
            return self.Scan1((acc, tpl) => f(acc._1(), acc._2(), acc._3(), acc._4(), acc._5(), acc._6(), tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すScanBack1です。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6>> ScanBack1<T1, T2, T3, T4, T5, T6>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, Tuple<T1, T2, T3, T4, T5, T6>> f)
        {
            return self.ScanBack1((tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), xs._1(), xs._2(), xs._3(), xs._4(), xs._5(), xs._6()));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すTryFindです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6>> TryFind<T1, T2, T3, T4, T5, T6>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, bool> f)
        {
            return self.TryFind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すTryPickです。
        /// </summary>
        public static Option<U> TryPick<T1, T2, T3, T4, T5, T6, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, Option<U>> f)
        {
            return self.TryPick(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5, T6>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5, T6>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すFilterです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6>> Filter<T1, T2, T3, T4, T5, T6>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, bool> f)
        {
            return self.Filter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すFilterWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6>> FilterWithIndex<T1, T2, T3, T4, T5, T6>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, int, bool> f)
        {
            return self.FilterWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), i));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static ISeq<U> Map<T1, T2, T3, T4, T5, T6, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すMapWithIndexです。
        /// </summary>
        public static ISeq<U> MapWithIndex<T1, T2, T3, T4, T5, T6, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, int, U> f)
        {
            return self.MapWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), i));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5, T6>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Action<T1, T2, T3, T4, T5, T6> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すIterWithIndexです。
        /// </summary>
        public static void IterWithIndex<T1, T2, T3, T4, T5, T6>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Action<T1, T2, T3, T4, T5, T6, int> f)
        {
            self.IterWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), i));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static ISeq<U> Bind<T1, T2, T3, T4, T5, T6, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, ISeq<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すBindWithIndexです。
        /// </summary>
        public static ISeq<U> BindWithIndex<T1, T2, T3, T4, T5, T6, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, int, ISeq<U>> f)
        {
            return self.BindWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), i));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すChooseです。
        /// </summary>
        public static ISeq<U> Choose<T1, T2, T3, T4, T5, T6, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, Option<U>> f)
        {
            return self.Choose(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すChooseWithIndexです。
        /// </summary>
        public static ISeq<U> ChooseWithIndex<T1, T2, T3, T4, T5, T6, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, int, Option<U>> f)
        {
            return self.ChooseWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), i));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すSkipWhileです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6>> SkipWhile<T1, T2, T3, T4, T5, T6>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, bool> f)
        {
            return self.SkipWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すTakeWhileです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6>> TakeWhile<T1, T2, T3, T4, T5, T6>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, bool> f)
        {
            return self.TakeWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すSkipWhileWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6>> SkipWhileWithIndex<T1, T2, T3, T4, T5, T6>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, int, bool> f)
        {
            return self.SkipWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), i));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すTakeWhileWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6>> TakeWhileWithIndex<T1, T2, T3, T4, T5, T6>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, int, bool> f)
        {
            return self.TakeWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), i));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すPartitionです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5, T6>>, ISeq<Tuple<T1, T2, T3, T4, T5, T6>>> Partition<T1, T2, T3, T4, T5, T6>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, bool> f)
        {
            return self.Partition(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すSpanです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5, T6>>, ISeq<Tuple<T1, T2, T3, T4, T5, T6>>> Span<T1, T2, T3, T4, T5, T6>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, bool> f)
        {
            return self.Span(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すBreakです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5, T6>>, ISeq<Tuple<T1, T2, T3, T4, T5, T6>>> Break<T1, T2, T3, T4, T5, T6>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, bool> f)
        {
            return self.Break(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すSortByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6>> SortBy<T1, T2, T3, T4, T5, T6, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, U> f)
        {
            return self.SortBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すRevSortByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6>> RevSortBy<T1, T2, T3, T4, T5, T6, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, U> f)
        {
            return self.RevSortBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }
        #endregion

        #region 7要素タプルを扱う関数
        /// <summary>
        /// 7要素タプルの各要素を展開して関数に渡すUnfoldです。
        /// </summary>
        public static ISeq<U> Unfold<T1, T2, T3, T4, T5, T6, T7, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7> self, Func<T1, T2, T3, T4, T5, T6, T7, Option<Tuple<U, T1, T2, T3, T4, T5, T6, Tuple<T7>>>> f)
        {
            return Unfold(self, tpl =>
                from res in tpl.Match(f)
                select Tuple.Create(res.Fst(), res.RemoveFirst()));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5, T6, T7>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すLongCountです。
        /// </summary>
        public static long LongCount<T1, T2, T3, T4, T5, T6, T7>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, bool> f)
        {
            return self.LongCount(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すSumByです。
        /// </summary>
        public static int SumBy<T1, T2, T3, T4, T5, T6, T7>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, int> f)
        {
            return self.SumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すLongSumByです。
        /// </summary>
        public static long LongSumBy<T1, T2, T3, T4, T5, T6, T7>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, long> f)
        {
            return self.LongSumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すSumByです。
        /// </summary>
        public static U SumBy<T1, T2, T3, T4, T5, T6, T7, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, U> f, ISumStrategy<U> strategy)
        {
            return self.SumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()), strategy);
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すTryMaxByです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7>> TryMaxBy<T1, T2, T3, T4, T5, T6, T7, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, U> f) where U : IComparable<U>
        {
            return self.TryMaxBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すTryMinByです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7>> TryMinBy<T1, T2, T3, T4, T5, T6, T7, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, U> f) where U : IComparable<U>
        {
            return self.TryMinBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, T5, T6, T7, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すTryReduceです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7>> TryReduce<T1, T2, T3, T4, T5, T6, T7>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, Tuple<T1, T2, T3, T4, T5, T6, T7>> f)
        {
            return self.TryReduce((acc, tpl) => f(acc._1(), acc._2(), acc._3(), acc._4(), acc._5(), acc._6(), acc._7(), tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すFoldBackです。
        /// </summary>
        public static U FoldBack<T1, T2, T3, T4, T5, T6, T7, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, U init, Func<T1, T2, T3, T4, T5, T6, T7, U, U> f)
        {
            return self.FoldBack(init, (tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), xs));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すTryReduceBackです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7>> TryReduceBack<T1, T2, T3, T4, T5, T6, T7>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, Tuple<T1, T2, T3, T4, T5, T6, T7>> f)
        {
            return self.TryReduceBack((tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), xs._1(), xs._2(), xs._3(), xs._4(), xs._5(), xs._6(), xs._7()));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すScanです。
        /// </summary>
        public static ISeq<U> Scan<T1, T2, T3, T4, T5, T6, T7, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, U> f)
        {
            return self.Scan(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すScanBackです。
        /// </summary>
        public static ISeq<U> ScanBack<T1, T2, T3, T4, T5, T6, T7, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, U init, Func<T1, T2, T3, T4, T5, T6, T7, U, U> f)
        {
            return self.ScanBack(init, (tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), xs));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すScan1です。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> Scan1<T1, T2, T3, T4, T5, T6, T7>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, Tuple<T1, T2, T3, T4, T5, T6, T7>> f)
        {
            return self.Scan1((acc, tpl) => f(acc._1(), acc._2(), acc._3(), acc._4(), acc._5(), acc._6(), acc._7(), tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すScanBack1です。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> ScanBack1<T1, T2, T3, T4, T5, T6, T7>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, Tuple<T1, T2, T3, T4, T5, T6, T7>> f)
        {
            return self.ScanBack1((tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), xs._1(), xs._2(), xs._3(), xs._4(), xs._5(), xs._6(), xs._7()));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すTryFindです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7>> TryFind<T1, T2, T3, T4, T5, T6, T7>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, bool> f)
        {
            return self.TryFind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すTryPickです。
        /// </summary>
        public static Option<U> TryPick<T1, T2, T3, T4, T5, T6, T7, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, Option<U>> f)
        {
            return self.TryPick(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5, T6, T7>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5, T6, T7>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すFilterです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> Filter<T1, T2, T3, T4, T5, T6, T7>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, bool> f)
        {
            return self.Filter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すFilterWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> FilterWithIndex<T1, T2, T3, T4, T5, T6, T7>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, int, bool> f)
        {
            return self.FilterWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), i));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static ISeq<U> Map<T1, T2, T3, T4, T5, T6, T7, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すMapWithIndexです。
        /// </summary>
        public static ISeq<U> MapWithIndex<T1, T2, T3, T4, T5, T6, T7, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, int, U> f)
        {
            return self.MapWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), i));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5, T6, T7>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Action<T1, T2, T3, T4, T5, T6, T7> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すIterWithIndexです。
        /// </summary>
        public static void IterWithIndex<T1, T2, T3, T4, T5, T6, T7>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Action<T1, T2, T3, T4, T5, T6, T7, int> f)
        {
            self.IterWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), i));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static ISeq<U> Bind<T1, T2, T3, T4, T5, T6, T7, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, ISeq<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すBindWithIndexです。
        /// </summary>
        public static ISeq<U> BindWithIndex<T1, T2, T3, T4, T5, T6, T7, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, int, ISeq<U>> f)
        {
            return self.BindWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), i));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すChooseです。
        /// </summary>
        public static ISeq<U> Choose<T1, T2, T3, T4, T5, T6, T7, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, Option<U>> f)
        {
            return self.Choose(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すChooseWithIndexです。
        /// </summary>
        public static ISeq<U> ChooseWithIndex<T1, T2, T3, T4, T5, T6, T7, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, int, Option<U>> f)
        {
            return self.ChooseWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), i));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すSkipWhileです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> SkipWhile<T1, T2, T3, T4, T5, T6, T7>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, bool> f)
        {
            return self.SkipWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すTakeWhileです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> TakeWhile<T1, T2, T3, T4, T5, T6, T7>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, bool> f)
        {
            return self.TakeWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すSkipWhileWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> SkipWhileWithIndex<T1, T2, T3, T4, T5, T6, T7>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, int, bool> f)
        {
            return self.SkipWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), i));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すTakeWhileWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> TakeWhileWithIndex<T1, T2, T3, T4, T5, T6, T7>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, int, bool> f)
        {
            return self.TakeWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), i));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すPartitionです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>>, ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>>> Partition<T1, T2, T3, T4, T5, T6, T7>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, bool> f)
        {
            return self.Partition(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すSpanです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>>, ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>>> Span<T1, T2, T3, T4, T5, T6, T7>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, bool> f)
        {
            return self.Span(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すBreakです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>>, ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>>> Break<T1, T2, T3, T4, T5, T6, T7>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, bool> f)
        {
            return self.Break(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すSortByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> SortBy<T1, T2, T3, T4, T5, T6, T7, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, U> f)
        {
            return self.SortBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すRevSortByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> RevSortBy<T1, T2, T3, T4, T5, T6, T7, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, U> f)
        {
            return self.RevSortBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }
        #endregion

        #region 8要素タプルを扱う関数
        /// <summary>
        /// 8要素タプルの各要素を展開して関数に渡すUnfoldです。
        /// </summary>
        public static ISeq<U> Unfold<T1, T2, T3, T4, T5, T6, T7, T8, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, Option<Tuple<U, T1, T2, T3, T4, T5, T6, Tuple<T7, T8>>>> f)
        {
            return Unfold(self, tpl =>
                from res in tpl.Match(f)
                select Tuple.Create(res.Fst(), res.RemoveFirst()));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5, T6, T7, T8>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すLongCountです。
        /// </summary>
        public static long LongCount<T1, T2, T3, T4, T5, T6, T7, T8>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> f)
        {
            return self.LongCount(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すSumByです。
        /// </summary>
        public static int SumBy<T1, T2, T3, T4, T5, T6, T7, T8>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, int> f)
        {
            return self.SumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すLongSumByです。
        /// </summary>
        public static long LongSumBy<T1, T2, T3, T4, T5, T6, T7, T8>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, long> f)
        {
            return self.LongSumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すSumByです。
        /// </summary>
        public static U SumBy<T1, T2, T3, T4, T5, T6, T7, T8, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, U> f, ISumStrategy<U> strategy)
        {
            return self.SumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()), strategy);
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すTryMaxByです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> TryMaxBy<T1, T2, T3, T4, T5, T6, T7, T8, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, U> f) where U : IComparable<U>
        {
            return self.TryMaxBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すTryMinByです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> TryMinBy<T1, T2, T3, T4, T5, T6, T7, T8, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, U> f) where U : IComparable<U>
        {
            return self.TryMinBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, T5, T6, T7, T8, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すTryReduceです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> TryReduce<T1, T2, T3, T4, T5, T6, T7, T8>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> f)
        {
            return self.TryReduce((acc, tpl) => f(acc._1(), acc._2(), acc._3(), acc._4(), acc._5(), acc._6(), acc._7(), acc._8(), tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すFoldBackです。
        /// </summary>
        public static U FoldBack<T1, T2, T3, T4, T5, T6, T7, T8, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, U init, Func<T1, T2, T3, T4, T5, T6, T7, T8, U, U> f)
        {
            return self.FoldBack(init, (tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), xs));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すTryReduceBackです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> TryReduceBack<T1, T2, T3, T4, T5, T6, T7, T8>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> f)
        {
            return self.TryReduceBack((tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), xs._1(), xs._2(), xs._3(), xs._4(), xs._5(), xs._6(), xs._7(), xs._8()));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すScanです。
        /// </summary>
        public static ISeq<U> Scan<T1, T2, T3, T4, T5, T6, T7, T8, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, U> f)
        {
            return self.Scan(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すScanBackです。
        /// </summary>
        public static ISeq<U> ScanBack<T1, T2, T3, T4, T5, T6, T7, T8, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, U init, Func<T1, T2, T3, T4, T5, T6, T7, T8, U, U> f)
        {
            return self.ScanBack(init, (tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), xs));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すScan1です。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> Scan1<T1, T2, T3, T4, T5, T6, T7, T8>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> f)
        {
            return self.Scan1((acc, tpl) => f(acc._1(), acc._2(), acc._3(), acc._4(), acc._5(), acc._6(), acc._7(), acc._8(), tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すScanBack1です。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> ScanBack1<T1, T2, T3, T4, T5, T6, T7, T8>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> f)
        {
            return self.ScanBack1((tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), xs._1(), xs._2(), xs._3(), xs._4(), xs._5(), xs._6(), xs._7(), xs._8()));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すTryFindです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> TryFind<T1, T2, T3, T4, T5, T6, T7, T8>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> f)
        {
            return self.TryFind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すTryPickです。
        /// </summary>
        public static Option<U> TryPick<T1, T2, T3, T4, T5, T6, T7, T8, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, Option<U>> f)
        {
            return self.TryPick(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5, T6, T7, T8>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5, T6, T7, T8>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すFilterです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> Filter<T1, T2, T3, T4, T5, T6, T7, T8>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> f)
        {
            return self.Filter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すFilterWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> FilterWithIndex<T1, T2, T3, T4, T5, T6, T7, T8>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, int, bool> f)
        {
            return self.FilterWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), i));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static ISeq<U> Map<T1, T2, T3, T4, T5, T6, T7, T8, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すMapWithIndexです。
        /// </summary>
        public static ISeq<U> MapWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, int, U> f)
        {
            return self.MapWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), i));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5, T6, T7, T8>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すIterWithIndexです。
        /// </summary>
        public static void IterWithIndex<T1, T2, T3, T4, T5, T6, T7, T8>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, int> f)
        {
            self.IterWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), i));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static ISeq<U> Bind<T1, T2, T3, T4, T5, T6, T7, T8, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, ISeq<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すBindWithIndexです。
        /// </summary>
        public static ISeq<U> BindWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, int, ISeq<U>> f)
        {
            return self.BindWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), i));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すChooseです。
        /// </summary>
        public static ISeq<U> Choose<T1, T2, T3, T4, T5, T6, T7, T8, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, Option<U>> f)
        {
            return self.Choose(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すChooseWithIndexです。
        /// </summary>
        public static ISeq<U> ChooseWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, int, Option<U>> f)
        {
            return self.ChooseWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), i));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すSkipWhileです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> SkipWhile<T1, T2, T3, T4, T5, T6, T7, T8>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> f)
        {
            return self.SkipWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すTakeWhileです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> TakeWhile<T1, T2, T3, T4, T5, T6, T7, T8>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> f)
        {
            return self.TakeWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すSkipWhileWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> SkipWhileWithIndex<T1, T2, T3, T4, T5, T6, T7, T8>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, int, bool> f)
        {
            return self.SkipWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), i));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すTakeWhileWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> TakeWhileWithIndex<T1, T2, T3, T4, T5, T6, T7, T8>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, int, bool> f)
        {
            return self.TakeWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), i));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すPartitionです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>>, ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>>> Partition<T1, T2, T3, T4, T5, T6, T7, T8>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> f)
        {
            return self.Partition(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すSpanです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>>, ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>>> Span<T1, T2, T3, T4, T5, T6, T7, T8>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> f)
        {
            return self.Span(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すBreakです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>>, ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>>> Break<T1, T2, T3, T4, T5, T6, T7, T8>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> f)
        {
            return self.Break(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すSortByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> SortBy<T1, T2, T3, T4, T5, T6, T7, T8, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, U> f)
        {
            return self.SortBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すRevSortByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> RevSortBy<T1, T2, T3, T4, T5, T6, T7, T8, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, U> f)
        {
            return self.RevSortBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }
        #endregion

        #region 9要素タプルを扱う関数
        /// <summary>
        /// 9要素タプルの各要素を展開して関数に渡すUnfoldです。
        /// </summary>
        public static ISeq<U> Unfold<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Option<Tuple<U, T1, T2, T3, T4, T5, T6, Tuple<T7, T8, T9>>>> f)
        {
            return Unfold(self, tpl =>
                from res in tpl.Match(f)
                select Tuple.Create(res.Fst(), res.RemoveFirst()));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すLongCountです。
        /// </summary>
        public static long LongCount<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> f)
        {
            return self.LongCount(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すSumByです。
        /// </summary>
        public static int SumBy<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, int> f)
        {
            return self.SumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すLongSumByです。
        /// </summary>
        public static long LongSumBy<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, long> f)
        {
            return self.LongSumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すSumByです。
        /// </summary>
        public static U SumBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> f, ISumStrategy<U> strategy)
        {
            return self.SumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()), strategy);
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すTryMaxByです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> TryMaxBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> f) where U : IComparable<U>
        {
            return self.TryMaxBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すTryMinByです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> TryMinBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> f) where U : IComparable<U>
        {
            return self.TryMinBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すFoldBackです。
        /// </summary>
        public static U FoldBack<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, U init, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U, U> f)
        {
            return self.FoldBack(init, (tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), xs));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すScanです。
        /// </summary>
        public static ISeq<U> Scan<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, U> f)
        {
            return self.Scan(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すScanBackです。
        /// </summary>
        public static ISeq<U> ScanBack<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, U init, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U, U> f)
        {
            return self.ScanBack(init, (tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), xs));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すTryFindです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> TryFind<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> f)
        {
            return self.TryFind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すTryPickです。
        /// </summary>
        public static Option<U> TryPick<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Option<U>> f)
        {
            return self.TryPick(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すFilterです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> Filter<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> f)
        {
            return self.Filter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すFilterWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> FilterWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, int, bool> f)
        {
            return self.FilterWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), i));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static ISeq<U> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すMapWithIndexです。
        /// </summary>
        public static ISeq<U> MapWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, int, U> f)
        {
            return self.MapWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), i));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すIterWithIndexです。
        /// </summary>
        public static void IterWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, int> f)
        {
            self.IterWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), i));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static ISeq<U> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, ISeq<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すBindWithIndexです。
        /// </summary>
        public static ISeq<U> BindWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, int, ISeq<U>> f)
        {
            return self.BindWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), i));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すChooseです。
        /// </summary>
        public static ISeq<U> Choose<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Option<U>> f)
        {
            return self.Choose(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すChooseWithIndexです。
        /// </summary>
        public static ISeq<U> ChooseWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, int, Option<U>> f)
        {
            return self.ChooseWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), i));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すSkipWhileです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> SkipWhile<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> f)
        {
            return self.SkipWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すTakeWhileです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> TakeWhile<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> f)
        {
            return self.TakeWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すSkipWhileWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> SkipWhileWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, int, bool> f)
        {
            return self.SkipWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), i));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すTakeWhileWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> TakeWhileWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, int, bool> f)
        {
            return self.TakeWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), i));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すPartitionです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>>, ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>>> Partition<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> f)
        {
            return self.Partition(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すSpanです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>>, ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>>> Span<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> f)
        {
            return self.Span(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すBreakです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>>, ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>>> Break<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> f)
        {
            return self.Break(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すSortByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> SortBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> f)
        {
            return self.SortBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すRevSortByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> RevSortBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> f)
        {
            return self.RevSortBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }
        #endregion

        #region 10要素タプルを扱う関数
        /// <summary>
        /// 10要素タプルの各要素を展開して関数に渡すUnfoldです。
        /// </summary>
        public static ISeq<U> Unfold<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Option<Tuple<U, T1, T2, T3, T4, T5, T6, Tuple<T7, T8, T9, T10>>>> f)
        {
            return Unfold(self, tpl =>
                from res in tpl.Match(f)
                select Tuple.Create(res.Fst(), res.RemoveFirst()));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すLongCountです。
        /// </summary>
        public static long LongCount<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> f)
        {
            return self.LongCount(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すSumByです。
        /// </summary>
        public static int SumBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, int> f)
        {
            return self.SumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すLongSumByです。
        /// </summary>
        public static long LongSumBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, long> f)
        {
            return self.LongSumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すSumByです。
        /// </summary>
        public static U SumBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> f, ISumStrategy<U> strategy)
        {
            return self.SumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()), strategy);
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すTryMaxByです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> TryMaxBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> f) where U : IComparable<U>
        {
            return self.TryMaxBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すTryMinByです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> TryMinBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> f) where U : IComparable<U>
        {
            return self.TryMinBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すFoldBackです。
        /// </summary>
        public static U FoldBack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, U init, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U, U> f)
        {
            return self.FoldBack(init, (tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), xs));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すScanです。
        /// </summary>
        public static ISeq<U> Scan<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> f)
        {
            return self.Scan(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すScanBackです。
        /// </summary>
        public static ISeq<U> ScanBack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, U init, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U, U> f)
        {
            return self.ScanBack(init, (tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), xs));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すTryFindです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> TryFind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> f)
        {
            return self.TryFind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すTryPickです。
        /// </summary>
        public static Option<U> TryPick<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Option<U>> f)
        {
            return self.TryPick(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すFilterです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> Filter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> f)
        {
            return self.Filter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すFilterWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> FilterWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, int, bool> f)
        {
            return self.FilterWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), i));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static ISeq<U> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すMapWithIndexです。
        /// </summary>
        public static ISeq<U> MapWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, int, U> f)
        {
            return self.MapWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), i));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すIterWithIndexです。
        /// </summary>
        public static void IterWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, int> f)
        {
            self.IterWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), i));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static ISeq<U> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, ISeq<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すBindWithIndexです。
        /// </summary>
        public static ISeq<U> BindWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, int, ISeq<U>> f)
        {
            return self.BindWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), i));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すChooseです。
        /// </summary>
        public static ISeq<U> Choose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Option<U>> f)
        {
            return self.Choose(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すChooseWithIndexです。
        /// </summary>
        public static ISeq<U> ChooseWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, int, Option<U>> f)
        {
            return self.ChooseWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), i));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すSkipWhileです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> SkipWhile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> f)
        {
            return self.SkipWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すTakeWhileです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> TakeWhile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> f)
        {
            return self.TakeWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すSkipWhileWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> SkipWhileWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, int, bool> f)
        {
            return self.SkipWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), i));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すTakeWhileWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> TakeWhileWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, int, bool> f)
        {
            return self.TakeWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), i));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すPartitionです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>>, ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>>> Partition<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> f)
        {
            return self.Partition(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すSpanです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>>, ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>>> Span<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> f)
        {
            return self.Span(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すBreakです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>>, ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>>> Break<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> f)
        {
            return self.Break(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すSortByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> SortBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> f)
        {
            return self.SortBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すRevSortByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> RevSortBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> f)
        {
            return self.RevSortBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }
        #endregion

        #region 11要素タプルを扱う関数
        /// <summary>
        /// 11要素タプルの各要素を展開して関数に渡すUnfoldです。
        /// </summary>
        public static ISeq<U> Unfold<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Option<Tuple<U, T1, T2, T3, T4, T5, T6, Tuple<T7, T8, T9, T10, T11>>>> f)
        {
            return Unfold(self, tpl =>
                from res in tpl.Match(f)
                select Tuple.Create(res.Fst(), res.RemoveFirst()));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すLongCountです。
        /// </summary>
        public static long LongCount<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> f)
        {
            return self.LongCount(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すSumByです。
        /// </summary>
        public static int SumBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, int> f)
        {
            return self.SumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すLongSumByです。
        /// </summary>
        public static long LongSumBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, long> f)
        {
            return self.LongSumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すSumByです。
        /// </summary>
        public static U SumBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> f, ISumStrategy<U> strategy)
        {
            return self.SumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()), strategy);
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すTryMaxByです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> TryMaxBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> f) where U : IComparable<U>
        {
            return self.TryMaxBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すTryMinByです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> TryMinBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> f) where U : IComparable<U>
        {
            return self.TryMinBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すFoldBackです。
        /// </summary>
        public static U FoldBack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, U init, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U, U> f)
        {
            return self.FoldBack(init, (tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), xs));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すScanです。
        /// </summary>
        public static ISeq<U> Scan<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> f)
        {
            return self.Scan(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すScanBackです。
        /// </summary>
        public static ISeq<U> ScanBack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, U init, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U, U> f)
        {
            return self.ScanBack(init, (tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), xs));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すTryFindです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> TryFind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> f)
        {
            return self.TryFind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すTryPickです。
        /// </summary>
        public static Option<U> TryPick<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Option<U>> f)
        {
            return self.TryPick(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すFilterです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> Filter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> f)
        {
            return self.Filter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すFilterWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> FilterWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, int, bool> f)
        {
            return self.FilterWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), i));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static ISeq<U> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すMapWithIndexです。
        /// </summary>
        public static ISeq<U> MapWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, int, U> f)
        {
            return self.MapWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), i));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すIterWithIndexです。
        /// </summary>
        public static void IterWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, int> f)
        {
            self.IterWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), i));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static ISeq<U> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, ISeq<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すBindWithIndexです。
        /// </summary>
        public static ISeq<U> BindWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, int, ISeq<U>> f)
        {
            return self.BindWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), i));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すChooseです。
        /// </summary>
        public static ISeq<U> Choose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Option<U>> f)
        {
            return self.Choose(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すChooseWithIndexです。
        /// </summary>
        public static ISeq<U> ChooseWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, int, Option<U>> f)
        {
            return self.ChooseWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), i));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すSkipWhileです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> SkipWhile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> f)
        {
            return self.SkipWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すTakeWhileです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> TakeWhile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> f)
        {
            return self.TakeWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すSkipWhileWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> SkipWhileWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, int, bool> f)
        {
            return self.SkipWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), i));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すTakeWhileWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> TakeWhileWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, int, bool> f)
        {
            return self.TakeWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), i));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すPartitionです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>>, ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>>> Partition<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> f)
        {
            return self.Partition(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すSpanです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>>, ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>>> Span<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> f)
        {
            return self.Span(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すBreakです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>>, ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>>> Break<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> f)
        {
            return self.Break(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すSortByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> SortBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> f)
        {
            return self.SortBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すRevSortByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> RevSortBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> f)
        {
            return self.RevSortBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }
        #endregion

        #region 12要素タプルを扱う関数
        /// <summary>
        /// 12要素タプルの各要素を展開して関数に渡すUnfoldです。
        /// </summary>
        public static ISeq<U> Unfold<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Option<Tuple<U, T1, T2, T3, T4, T5, T6, Tuple<T7, T8, T9, T10, T11, T12>>>> f)
        {
            return Unfold(self, tpl =>
                from res in tpl.Match(f)
                select Tuple.Create(res.Fst(), res.RemoveFirst()));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すLongCountです。
        /// </summary>
        public static long LongCount<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> f)
        {
            return self.LongCount(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すSumByです。
        /// </summary>
        public static int SumBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, int> f)
        {
            return self.SumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すLongSumByです。
        /// </summary>
        public static long LongSumBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, long> f)
        {
            return self.LongSumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すSumByです。
        /// </summary>
        public static U SumBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> f, ISumStrategy<U> strategy)
        {
            return self.SumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()), strategy);
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すTryMaxByです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> TryMaxBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> f) where U : IComparable<U>
        {
            return self.TryMaxBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すTryMinByです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> TryMinBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> f) where U : IComparable<U>
        {
            return self.TryMinBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すFoldBackです。
        /// </summary>
        public static U FoldBack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, U init, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U, U> f)
        {
            return self.FoldBack(init, (tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), xs));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すScanです。
        /// </summary>
        public static ISeq<U> Scan<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> f)
        {
            return self.Scan(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すScanBackです。
        /// </summary>
        public static ISeq<U> ScanBack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, U init, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U, U> f)
        {
            return self.ScanBack(init, (tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), xs));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すTryFindです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> TryFind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> f)
        {
            return self.TryFind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すTryPickです。
        /// </summary>
        public static Option<U> TryPick<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Option<U>> f)
        {
            return self.TryPick(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すFilterです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> Filter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> f)
        {
            return self.Filter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すFilterWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> FilterWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, int, bool> f)
        {
            return self.FilterWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), i));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static ISeq<U> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すMapWithIndexです。
        /// </summary>
        public static ISeq<U> MapWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, int, U> f)
        {
            return self.MapWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), i));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すIterWithIndexです。
        /// </summary>
        public static void IterWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, int> f)
        {
            self.IterWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), i));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static ISeq<U> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, ISeq<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すBindWithIndexです。
        /// </summary>
        public static ISeq<U> BindWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, int, ISeq<U>> f)
        {
            return self.BindWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), i));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すChooseです。
        /// </summary>
        public static ISeq<U> Choose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Option<U>> f)
        {
            return self.Choose(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すChooseWithIndexです。
        /// </summary>
        public static ISeq<U> ChooseWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, int, Option<U>> f)
        {
            return self.ChooseWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), i));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すSkipWhileです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> SkipWhile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> f)
        {
            return self.SkipWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すTakeWhileです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> TakeWhile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> f)
        {
            return self.TakeWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すSkipWhileWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> SkipWhileWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, int, bool> f)
        {
            return self.SkipWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), i));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すTakeWhileWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> TakeWhileWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, int, bool> f)
        {
            return self.TakeWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), i));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すPartitionです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>>, ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>>> Partition<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> f)
        {
            return self.Partition(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すSpanです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>>, ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>>> Span<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> f)
        {
            return self.Span(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すBreakです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>>, ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>>> Break<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> f)
        {
            return self.Break(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すSortByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> SortBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> f)
        {
            return self.SortBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すRevSortByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> RevSortBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> f)
        {
            return self.RevSortBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }
        #endregion

        #region 13要素タプルを扱う関数
        /// <summary>
        /// 13要素タプルの各要素を展開して関数に渡すUnfoldです。
        /// </summary>
        public static ISeq<U> Unfold<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Option<Tuple<U, T1, T2, T3, T4, T5, T6, Tuple<T7, T8, T9, T10, T11, T12, T13>>>> f)
        {
            return Unfold(self, tpl =>
                from res in tpl.Match(f)
                select Tuple.Create(res.Fst(), res.RemoveFirst()));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すLongCountです。
        /// </summary>
        public static long LongCount<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> f)
        {
            return self.LongCount(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すSumByです。
        /// </summary>
        public static int SumBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, int> f)
        {
            return self.SumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すLongSumByです。
        /// </summary>
        public static long LongSumBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, long> f)
        {
            return self.LongSumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すSumByです。
        /// </summary>
        public static U SumBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> f, ISumStrategy<U> strategy)
        {
            return self.SumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()), strategy);
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すTryMaxByです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> TryMaxBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> f) where U : IComparable<U>
        {
            return self.TryMaxBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すTryMinByです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> TryMinBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> f) where U : IComparable<U>
        {
            return self.TryMinBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すFoldBackです。
        /// </summary>
        public static U FoldBack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, U init, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U, U> f)
        {
            return self.FoldBack(init, (tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), xs));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すScanです。
        /// </summary>
        public static ISeq<U> Scan<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> f)
        {
            return self.Scan(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すScanBackです。
        /// </summary>
        public static ISeq<U> ScanBack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, U init, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U, U> f)
        {
            return self.ScanBack(init, (tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), xs));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すTryFindです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> TryFind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> f)
        {
            return self.TryFind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すTryPickです。
        /// </summary>
        public static Option<U> TryPick<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Option<U>> f)
        {
            return self.TryPick(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すFilterです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> Filter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> f)
        {
            return self.Filter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すFilterWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> FilterWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, int, bool> f)
        {
            return self.FilterWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), i));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static ISeq<U> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すMapWithIndexです。
        /// </summary>
        public static ISeq<U> MapWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, int, U> f)
        {
            return self.MapWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), i));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すIterWithIndexです。
        /// </summary>
        public static void IterWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, int> f)
        {
            self.IterWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), i));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static ISeq<U> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, ISeq<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すBindWithIndexです。
        /// </summary>
        public static ISeq<U> BindWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, int, ISeq<U>> f)
        {
            return self.BindWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), i));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すChooseです。
        /// </summary>
        public static ISeq<U> Choose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Option<U>> f)
        {
            return self.Choose(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すChooseWithIndexです。
        /// </summary>
        public static ISeq<U> ChooseWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, int, Option<U>> f)
        {
            return self.ChooseWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), i));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すSkipWhileです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> SkipWhile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> f)
        {
            return self.SkipWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すTakeWhileです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> TakeWhile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> f)
        {
            return self.TakeWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すSkipWhileWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> SkipWhileWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, int, bool> f)
        {
            return self.SkipWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), i));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すTakeWhileWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> TakeWhileWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, int, bool> f)
        {
            return self.TakeWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), i));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すPartitionです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>>, ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>>> Partition<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> f)
        {
            return self.Partition(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すSpanです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>>, ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>>> Span<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> f)
        {
            return self.Span(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すBreakです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>>, ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>>> Break<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> f)
        {
            return self.Break(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すSortByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> SortBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> f)
        {
            return self.SortBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すRevSortByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> RevSortBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> f)
        {
            return self.RevSortBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }
        #endregion

        #region 14要素タプルを扱う関数
        /// <summary>
        /// 14要素タプルの各要素を展開して関数に渡すUnfoldです。
        /// </summary>
        public static ISeq<U> Unfold<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Option<Tuple<U, T1, T2, T3, T4, T5, T6, Tuple<T7, T8, T9, T10, T11, T12, T13, Tuple<T14>>>>> f)
        {
            return Unfold(self, tpl =>
                from res in tpl.Match(f)
                select Tuple.Create(res.Fst(), res.RemoveFirst()));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すLongCountです。
        /// </summary>
        public static long LongCount<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> f)
        {
            return self.LongCount(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すSumByです。
        /// </summary>
        public static int SumBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, int> f)
        {
            return self.SumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すLongSumByです。
        /// </summary>
        public static long LongSumBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, long> f)
        {
            return self.LongSumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すSumByです。
        /// </summary>
        public static U SumBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> f, ISumStrategy<U> strategy)
        {
            return self.SumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()), strategy);
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すTryMaxByです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> TryMaxBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> f) where U : IComparable<U>
        {
            return self.TryMaxBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すTryMinByです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> TryMinBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> f) where U : IComparable<U>
        {
            return self.TryMinBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すFoldBackです。
        /// </summary>
        public static U FoldBack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, U init, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U, U> f)
        {
            return self.FoldBack(init, (tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), xs));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すScanです。
        /// </summary>
        public static ISeq<U> Scan<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> f)
        {
            return self.Scan(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すScanBackです。
        /// </summary>
        public static ISeq<U> ScanBack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, U init, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U, U> f)
        {
            return self.ScanBack(init, (tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), xs));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すTryFindです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> TryFind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> f)
        {
            return self.TryFind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すTryPickです。
        /// </summary>
        public static Option<U> TryPick<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Option<U>> f)
        {
            return self.TryPick(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すFilterです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> Filter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> f)
        {
            return self.Filter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すFilterWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> FilterWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, int, bool> f)
        {
            return self.FilterWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), i));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static ISeq<U> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すMapWithIndexです。
        /// </summary>
        public static ISeq<U> MapWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, int, U> f)
        {
            return self.MapWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), i));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すIterWithIndexです。
        /// </summary>
        public static void IterWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, int> f)
        {
            self.IterWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), i));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static ISeq<U> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, ISeq<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すBindWithIndexです。
        /// </summary>
        public static ISeq<U> BindWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, int, ISeq<U>> f)
        {
            return self.BindWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), i));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すChooseです。
        /// </summary>
        public static ISeq<U> Choose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Option<U>> f)
        {
            return self.Choose(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すChooseWithIndexです。
        /// </summary>
        public static ISeq<U> ChooseWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, int, Option<U>> f)
        {
            return self.ChooseWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), i));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すSkipWhileです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> SkipWhile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> f)
        {
            return self.SkipWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すTakeWhileです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> TakeWhile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> f)
        {
            return self.TakeWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すSkipWhileWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> SkipWhileWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, int, bool> f)
        {
            return self.SkipWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), i));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すTakeWhileWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> TakeWhileWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, int, bool> f)
        {
            return self.TakeWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), i));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すPartitionです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>>, ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>>> Partition<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> f)
        {
            return self.Partition(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すSpanです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>>, ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>>> Span<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> f)
        {
            return self.Span(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すBreakです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>>, ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>>> Break<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> f)
        {
            return self.Break(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すSortByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> SortBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> f)
        {
            return self.SortBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すRevSortByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> RevSortBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> f)
        {
            return self.RevSortBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }
        #endregion

        #region 15要素タプルを扱う関数
        /// <summary>
        /// 15要素タプルの各要素を展開して関数に渡すUnfoldです。
        /// </summary>
        public static ISeq<U> Unfold<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Option<Tuple<U, T1, T2, T3, T4, T5, T6, Tuple<T7, T8, T9, T10, T11, T12, T13, Tuple<T14, T15>>>>> f)
        {
            return Unfold(self, tpl =>
                from res in tpl.Match(f)
                select Tuple.Create(res.Fst(), res.RemoveFirst()));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すLongCountです。
        /// </summary>
        public static long LongCount<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> f)
        {
            return self.LongCount(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すSumByです。
        /// </summary>
        public static int SumBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, int> f)
        {
            return self.SumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すLongSumByです。
        /// </summary>
        public static long LongSumBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, long> f)
        {
            return self.LongSumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すSumByです。
        /// </summary>
        public static U SumBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> f, ISumStrategy<U> strategy)
        {
            return self.SumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()), strategy);
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すTryMaxByです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> TryMaxBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> f) where U : IComparable<U>
        {
            return self.TryMaxBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すTryMinByです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> TryMinBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> f) where U : IComparable<U>
        {
            return self.TryMinBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すFoldBackです。
        /// </summary>
        public static U FoldBack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, U init, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U, U> f)
        {
            return self.FoldBack(init, (tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), xs));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すScanです。
        /// </summary>
        public static ISeq<U> Scan<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> f)
        {
            return self.Scan(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すScanBackです。
        /// </summary>
        public static ISeq<U> ScanBack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, U init, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U, U> f)
        {
            return self.ScanBack(init, (tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), xs));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すTryFindです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> TryFind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> f)
        {
            return self.TryFind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すTryPickです。
        /// </summary>
        public static Option<U> TryPick<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Option<U>> f)
        {
            return self.TryPick(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すFilterです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> Filter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> f)
        {
            return self.Filter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すFilterWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> FilterWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, int, bool> f)
        {
            return self.FilterWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), i));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static ISeq<U> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すMapWithIndexです。
        /// </summary>
        public static ISeq<U> MapWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, int, U> f)
        {
            return self.MapWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), i));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すIterWithIndexです。
        /// </summary>
        public static void IterWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, int> f)
        {
            self.IterWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), i));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static ISeq<U> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, ISeq<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すBindWithIndexです。
        /// </summary>
        public static ISeq<U> BindWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, int, ISeq<U>> f)
        {
            return self.BindWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), i));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すChooseです。
        /// </summary>
        public static ISeq<U> Choose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Option<U>> f)
        {
            return self.Choose(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すChooseWithIndexです。
        /// </summary>
        public static ISeq<U> ChooseWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, int, Option<U>> f)
        {
            return self.ChooseWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), i));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すSkipWhileです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> SkipWhile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> f)
        {
            return self.SkipWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すTakeWhileです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> TakeWhile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> f)
        {
            return self.TakeWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すSkipWhileWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> SkipWhileWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, int, bool> f)
        {
            return self.SkipWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), i));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すTakeWhileWithIndexです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> TakeWhileWithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, int, bool> f)
        {
            return self.TakeWhileWithIndex((tpl, i) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), i));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すPartitionです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>>, ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>>> Partition<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> f)
        {
            return self.Partition(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すSpanです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>>, ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>>> Span<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> f)
        {
            return self.Span(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すBreakです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>>, ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>>> Break<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> f)
        {
            return self.Break(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すSortByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> SortBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> f)
        {
            return self.SortBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すRevSortByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> RevSortBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> f)
        {
            return self.RevSortBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }
        #endregion

        #region 16要素タプルを扱う関数

        /// <summary>
        /// 16要素タプルのシーケンスの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのシーケンスの各要素を展開して関数に渡すLongCountです。
        /// </summary>
        public static long LongCount<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> f)
        {
            return self.LongCount(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのシーケンスの各要素を展開して関数に渡すSumByです。
        /// </summary>
        public static int SumBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, int> f)
        {
            return self.SumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのシーケンスの各要素を展開して関数に渡すLongSumByです。
        /// </summary>
        public static long LongSumBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, long> f)
        {
            return self.LongSumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのシーケンスの各要素を展開して関数に渡すSumByです。
        /// </summary>
        public static U SumBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> f, ISumStrategy<U> strategy)
        {
            return self.SumBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()), strategy);
        }

        /// <summary>
        /// 16要素タプルのシーケンスの各要素を展開して関数に渡すTryMaxByです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> TryMaxBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> f) where U : IComparable<U>
        {
            return self.TryMaxBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのシーケンスの各要素を展開して関数に渡すTryMinByです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> TryMinBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> f) where U : IComparable<U>
        {
            return self.TryMinBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのシーケンスの各要素を展開して関数に渡すTryFindです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> TryFind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> f)
        {
            return self.TryFind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのシーケンスの各要素を展開して関数に渡すTryPickです。
        /// </summary>
        public static Option<U> TryPick<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Option<U>> f)
        {
            return self.TryPick(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのシーケンスの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのシーケンスの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのシーケンスの各要素を展開して関数に渡すFilterです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> Filter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> f)
        {
            return self.Filter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのシーケンスの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static ISeq<U> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのシーケンスの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのシーケンスの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static ISeq<U> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, ISeq<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのシーケンスの各要素を展開して関数に渡すChooseです。
        /// </summary>
        public static ISeq<U> Choose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Option<U>> f)
        {
            return self.Choose(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのシーケンスの各要素を展開して関数に渡すSkipWhileです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> SkipWhile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> f)
        {
            return self.SkipWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのシーケンスの各要素を展開して関数に渡すTakeWhileです。
        /// </summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> TakeWhile<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> f)
        {
            return self.TakeWhile(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのシーケンスの各要素を展開して関数に渡すPartitionです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>>, ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>>> Partition<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> f)
        {
            return self.Partition(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのシーケンスの各要素を展開して関数に渡すSpanです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>>, ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>>> Span<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> f)
        {
            return self.Span(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのシーケンスの各要素を展開して関数に渡すBreakです。
        /// </summary>
        public static Tuple<ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>>, ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>>> Break<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> f)
        {
            return self.Break(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのシーケンスの各要素を展開して関数に渡すSortByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> SortBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> f)
        {
            return self.SortBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのシーケンスの各要素を展開して関数に渡すRevSortByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> RevSortBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> f)
        {
            return self.RevSortBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }
        #endregion

    }
}
