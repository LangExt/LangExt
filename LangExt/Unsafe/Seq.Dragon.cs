

using System;
using System.Collections.Generic;

namespace LangExt.Unsafe
{
    partial class Seq
    {
        #region 2要素タプルを扱う関数

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すMaxByです。
        /// </summary>
        public static Tuple<T1, T2> MaxBy<T1, T2, U>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, U> f) where U : IComparable<U>
        {
            return self.MaxBy(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すMinByです。
        /// </summary>
        public static Tuple<T1, T2> MinBy<T1, T2, U>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, U> f) where U : IComparable<U>
        {
            return self.MinBy(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すReduceです。
        /// </summary>
        public static Tuple<T1, T2> Reduce<T1, T2>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, T1, T2, Tuple<T1, T2>> f)
        {
            return self.Reduce((acc, tpl) => f(acc._1(), acc._2(), tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すReduceBackです。
        /// </summary>
        public static Tuple<T1, T2> ReduceBack<T1, T2>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, T1, T2, Tuple<T1, T2>> f)
        {
            return self.ReduceBack((tpl, xs) => f(tpl._1(), tpl._2(), xs._1(), xs._2()));
        }

        /// <summary>
        /// 2要素タプルのシーケンスの各要素を展開して関数に渡すFindです。
        /// </summary>
        public static Tuple<T1, T2> Find<T1, T2>(this ISeq<Tuple<T1, T2>> self, Func<T1, T2, bool> f)
        {
            return self.Find(tpl => f(tpl._1(), tpl._2()));
        }
        #endregion

        #region 3要素タプルを扱う関数

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すMaxByです。
        /// </summary>
        public static Tuple<T1, T2, T3> MaxBy<T1, T2, T3, U>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, U> f) where U : IComparable<U>
        {
            return self.MaxBy(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すMinByです。
        /// </summary>
        public static Tuple<T1, T2, T3> MinBy<T1, T2, T3, U>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, U> f) where U : IComparable<U>
        {
            return self.MinBy(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すReduceです。
        /// </summary>
        public static Tuple<T1, T2, T3> Reduce<T1, T2, T3>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, T1, T2, T3, Tuple<T1, T2, T3>> f)
        {
            return self.Reduce((acc, tpl) => f(acc._1(), acc._2(), acc._3(), tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すReduceBackです。
        /// </summary>
        public static Tuple<T1, T2, T3> ReduceBack<T1, T2, T3>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, T1, T2, T3, Tuple<T1, T2, T3>> f)
        {
            return self.ReduceBack((tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), xs._1(), xs._2(), xs._3()));
        }

        /// <summary>
        /// 3要素タプルのシーケンスの各要素を展開して関数に渡すFindです。
        /// </summary>
        public static Tuple<T1, T2, T3> Find<T1, T2, T3>(this ISeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, bool> f)
        {
            return self.Find(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }
        #endregion

        #region 4要素タプルを扱う関数

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すMaxByです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4> MaxBy<T1, T2, T3, T4, U>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, U> f) where U : IComparable<U>
        {
            return self.MaxBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すMinByです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4> MinBy<T1, T2, T3, T4, U>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, U> f) where U : IComparable<U>
        {
            return self.MinBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すReduceです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4> Reduce<T1, T2, T3, T4>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, T1, T2, T3, T4, Tuple<T1, T2, T3, T4>> f)
        {
            return self.Reduce((acc, tpl) => f(acc._1(), acc._2(), acc._3(), acc._4(), tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すReduceBackです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4> ReduceBack<T1, T2, T3, T4>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, T1, T2, T3, T4, Tuple<T1, T2, T3, T4>> f)
        {
            return self.ReduceBack((tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), xs._1(), xs._2(), xs._3(), xs._4()));
        }

        /// <summary>
        /// 4要素タプルのシーケンスの各要素を展開して関数に渡すFindです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4> Find<T1, T2, T3, T4>(this ISeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, bool> f)
        {
            return self.Find(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }
        #endregion

        #region 5要素タプルを扱う関数

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すMaxByです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5> MaxBy<T1, T2, T3, T4, T5, U>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, U> f) where U : IComparable<U>
        {
            return self.MaxBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すMinByです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5> MinBy<T1, T2, T3, T4, T5, U>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, U> f) where U : IComparable<U>
        {
            return self.MinBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すReduceです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5> Reduce<T1, T2, T3, T4, T5>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, Tuple<T1, T2, T3, T4, T5>> f)
        {
            return self.Reduce((acc, tpl) => f(acc._1(), acc._2(), acc._3(), acc._4(), acc._5(), tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すReduceBackです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5> ReduceBack<T1, T2, T3, T4, T5>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, T1, T2, T3, T4, T5, Tuple<T1, T2, T3, T4, T5>> f)
        {
            return self.ReduceBack((tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), xs._1(), xs._2(), xs._3(), xs._4(), xs._5()));
        }

        /// <summary>
        /// 5要素タプルのシーケンスの各要素を展開して関数に渡すFindです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5> Find<T1, T2, T3, T4, T5>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, bool> f)
        {
            return self.Find(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }
        #endregion

        #region 6要素タプルを扱う関数

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すMaxByです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6> MaxBy<T1, T2, T3, T4, T5, T6, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, U> f) where U : IComparable<U>
        {
            return self.MaxBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すMinByです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6> MinBy<T1, T2, T3, T4, T5, T6, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, U> f) where U : IComparable<U>
        {
            return self.MinBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すReduceです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6> Reduce<T1, T2, T3, T4, T5, T6>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, Tuple<T1, T2, T3, T4, T5, T6>> f)
        {
            return self.Reduce((acc, tpl) => f(acc._1(), acc._2(), acc._3(), acc._4(), acc._5(), acc._6(), tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すReduceBackです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6> ReduceBack<T1, T2, T3, T4, T5, T6>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, T1, T2, T3, T4, T5, T6, Tuple<T1, T2, T3, T4, T5, T6>> f)
        {
            return self.ReduceBack((tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), xs._1(), xs._2(), xs._3(), xs._4(), xs._5(), xs._6()));
        }

        /// <summary>
        /// 6要素タプルのシーケンスの各要素を展開して関数に渡すFindです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6> Find<T1, T2, T3, T4, T5, T6>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, bool> f)
        {
            return self.Find(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }
        #endregion

        #region 7要素タプルを扱う関数

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すMaxByです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7> MaxBy<T1, T2, T3, T4, T5, T6, T7, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, U> f) where U : IComparable<U>
        {
            return self.MaxBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すMinByです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7> MinBy<T1, T2, T3, T4, T5, T6, T7, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, U> f) where U : IComparable<U>
        {
            return self.MinBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すReduceです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7> Reduce<T1, T2, T3, T4, T5, T6, T7>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, Tuple<T1, T2, T3, T4, T5, T6, T7>> f)
        {
            return self.Reduce((acc, tpl) => f(acc._1(), acc._2(), acc._3(), acc._4(), acc._5(), acc._6(), acc._7(), tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すReduceBackです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7> ReduceBack<T1, T2, T3, T4, T5, T6, T7>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, T1, T2, T3, T4, T5, T6, T7, Tuple<T1, T2, T3, T4, T5, T6, T7>> f)
        {
            return self.ReduceBack((tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), xs._1(), xs._2(), xs._3(), xs._4(), xs._5(), xs._6(), xs._7()));
        }

        /// <summary>
        /// 7要素タプルのシーケンスの各要素を展開して関数に渡すFindです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7> Find<T1, T2, T3, T4, T5, T6, T7>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, bool> f)
        {
            return self.Find(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }
        #endregion

        #region 8要素タプルを扱う関数

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すMaxByです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> MaxBy<T1, T2, T3, T4, T5, T6, T7, T8, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, U> f) where U : IComparable<U>
        {
            return self.MaxBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すMinByです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> MinBy<T1, T2, T3, T4, T5, T6, T7, T8, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, U> f) where U : IComparable<U>
        {
            return self.MinBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すReduceです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> Reduce<T1, T2, T3, T4, T5, T6, T7, T8>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> f)
        {
            return self.Reduce((acc, tpl) => f(acc._1(), acc._2(), acc._3(), acc._4(), acc._5(), acc._6(), acc._7(), acc._8(), tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すReduceBackです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> ReduceBack<T1, T2, T3, T4, T5, T6, T7, T8>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T1, T2, T3, T4, T5, T6, T7, T8, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> f)
        {
            return self.ReduceBack((tpl, xs) => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), xs._1(), xs._2(), xs._3(), xs._4(), xs._5(), xs._6(), xs._7(), xs._8()));
        }

        /// <summary>
        /// 8要素タプルのシーケンスの各要素を展開して関数に渡すFindです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> Find<T1, T2, T3, T4, T5, T6, T7, T8>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> f)
        {
            return self.Find(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }
        #endregion

        #region 9要素タプルを扱う関数

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すMaxByです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> MaxBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> f) where U : IComparable<U>
        {
            return self.MaxBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すMinByです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> MinBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> f) where U : IComparable<U>
        {
            return self.MinBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのシーケンスの各要素を展開して関数に渡すFindです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> Find<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> f)
        {
            return self.Find(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }
        #endregion

        #region 10要素タプルを扱う関数

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すMaxByです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> MaxBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> f) where U : IComparable<U>
        {
            return self.MaxBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すMinByです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> MinBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> f) where U : IComparable<U>
        {
            return self.MinBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのシーケンスの各要素を展開して関数に渡すFindです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> Find<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> f)
        {
            return self.Find(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }
        #endregion

        #region 11要素タプルを扱う関数

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すMaxByです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> MaxBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> f) where U : IComparable<U>
        {
            return self.MaxBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すMinByです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> MinBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> f) where U : IComparable<U>
        {
            return self.MinBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのシーケンスの各要素を展開して関数に渡すFindです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> Find<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> f)
        {
            return self.Find(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }
        #endregion

        #region 12要素タプルを扱う関数

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すMaxByです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> MaxBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> f) where U : IComparable<U>
        {
            return self.MaxBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すMinByです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> MinBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> f) where U : IComparable<U>
        {
            return self.MinBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのシーケンスの各要素を展開して関数に渡すFindです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> Find<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> f)
        {
            return self.Find(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }
        #endregion

        #region 13要素タプルを扱う関数

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すMaxByです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> MaxBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> f) where U : IComparable<U>
        {
            return self.MaxBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すMinByです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> MinBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> f) where U : IComparable<U>
        {
            return self.MinBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのシーケンスの各要素を展開して関数に渡すFindです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> Find<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> f)
        {
            return self.Find(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }
        #endregion

        #region 14要素タプルを扱う関数

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すMaxByです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> MaxBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> f) where U : IComparable<U>
        {
            return self.MaxBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すMinByです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> MinBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> f) where U : IComparable<U>
        {
            return self.MinBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのシーケンスの各要素を展開して関数に渡すFindです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> Find<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> f)
        {
            return self.Find(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }
        #endregion

        #region 15要素タプルを扱う関数

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すMaxByです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> MaxBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> f) where U : IComparable<U>
        {
            return self.MaxBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すMinByです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> MinBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> f) where U : IComparable<U>
        {
            return self.MinBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのシーケンスの各要素を展開して関数に渡すFindです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> Find<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> f)
        {
            return self.Find(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }
        #endregion

        #region 16要素タプルを扱う関数

        /// <summary>
        /// 16要素タプルのシーケンスの各要素を展開して関数に渡すMaxByです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> MaxBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> f) where U : IComparable<U>
        {
            return self.MaxBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのシーケンスの各要素を展開して関数に渡すMinByです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> MinBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> f) where U : IComparable<U>
        {
            return self.MinBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのシーケンスの各要素を展開して関数に渡すFindです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> Find<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> f)
        {
            return self.Find(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }
        #endregion

    }
}