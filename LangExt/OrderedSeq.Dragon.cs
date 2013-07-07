
using System;
using System.Collections.Generic;

namespace LangExt
{
    partial class OrderedSeq
    {
        #region 2要素タプルを扱うThenBy
        /// <summary>
        /// 2要素タプルの各要素を展開して関数に渡すThenByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2>> ThenBy<T1, T2, U>(this IOrderedSeq<Tuple<T1, T2>> self, Func<T1, T2, U> f)
        {
            return self.ThenBy(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルの各要素を展開して関数に渡すRevThenByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2>> RevThenBy<T1, T2, U>(this IOrderedSeq<Tuple<T1, T2>> self, Func<T1, T2, U> f)
        {
            return self.RevThenBy(tpl => f(tpl._1(), tpl._2()));
        }
        #endregion
        #region 3要素タプルを扱うThenBy
        /// <summary>
        /// 3要素タプルの各要素を展開して関数に渡すThenByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3>> ThenBy<T1, T2, T3, U>(this IOrderedSeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, U> f)
        {
            return self.ThenBy(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルの各要素を展開して関数に渡すRevThenByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3>> RevThenBy<T1, T2, T3, U>(this IOrderedSeq<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, U> f)
        {
            return self.RevThenBy(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }
        #endregion
        #region 4要素タプルを扱うThenBy
        /// <summary>
        /// 4要素タプルの各要素を展開して関数に渡すThenByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4>> ThenBy<T1, T2, T3, T4, U>(this IOrderedSeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, U> f)
        {
            return self.ThenBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルの各要素を展開して関数に渡すRevThenByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4>> RevThenBy<T1, T2, T3, T4, U>(this IOrderedSeq<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, U> f)
        {
            return self.RevThenBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }
        #endregion
        #region 5要素タプルを扱うThenBy
        /// <summary>
        /// 5要素タプルの各要素を展開して関数に渡すThenByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5>> ThenBy<T1, T2, T3, T4, T5, U>(this IOrderedSeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, U> f)
        {
            return self.ThenBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルの各要素を展開して関数に渡すRevThenByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5>> RevThenBy<T1, T2, T3, T4, T5, U>(this IOrderedSeq<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, U> f)
        {
            return self.RevThenBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }
        #endregion
        #region 6要素タプルを扱うThenBy
        /// <summary>
        /// 6要素タプルの各要素を展開して関数に渡すThenByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6>> ThenBy<T1, T2, T3, T4, T5, T6, U>(this IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, U> f)
        {
            return self.ThenBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルの各要素を展開して関数に渡すRevThenByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6>> RevThenBy<T1, T2, T3, T4, T5, T6, U>(this IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, U> f)
        {
            return self.RevThenBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }
        #endregion
        #region 7要素タプルを扱うThenBy
        /// <summary>
        /// 7要素タプルの各要素を展開して関数に渡すThenByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> ThenBy<T1, T2, T3, T4, T5, T6, T7, U>(this IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, U> f)
        {
            return self.ThenBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルの各要素を展開して関数に渡すRevThenByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> RevThenBy<T1, T2, T3, T4, T5, T6, T7, U>(this IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, U> f)
        {
            return self.RevThenBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }
        #endregion
        #region 8要素タプルを扱うThenBy
        /// <summary>
        /// 8要素タプルの各要素を展開して関数に渡すThenByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> ThenBy<T1, T2, T3, T4, T5, T6, T7, T8, U>(this IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, U> f)
        {
            return self.ThenBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルの各要素を展開して関数に渡すRevThenByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> RevThenBy<T1, T2, T3, T4, T5, T6, T7, T8, U>(this IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, U> f)
        {
            return self.RevThenBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }
        #endregion
        #region 9要素タプルを扱うThenBy
        /// <summary>
        /// 9要素タプルの各要素を展開して関数に渡すThenByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> ThenBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> f)
        {
            return self.ThenBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルの各要素を展開して関数に渡すRevThenByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> RevThenBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> f)
        {
            return self.RevThenBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }
        #endregion
        #region 10要素タプルを扱うThenBy
        /// <summary>
        /// 10要素タプルの各要素を展開して関数に渡すThenByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> ThenBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> f)
        {
            return self.ThenBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルの各要素を展開して関数に渡すRevThenByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> RevThenBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> f)
        {
            return self.RevThenBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }
        #endregion
        #region 11要素タプルを扱うThenBy
        /// <summary>
        /// 11要素タプルの各要素を展開して関数に渡すThenByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> ThenBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> f)
        {
            return self.ThenBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルの各要素を展開して関数に渡すRevThenByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> RevThenBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> f)
        {
            return self.RevThenBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }
        #endregion
        #region 12要素タプルを扱うThenBy
        /// <summary>
        /// 12要素タプルの各要素を展開して関数に渡すThenByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> ThenBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> f)
        {
            return self.ThenBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルの各要素を展開して関数に渡すRevThenByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> RevThenBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> f)
        {
            return self.RevThenBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }
        #endregion
        #region 13要素タプルを扱うThenBy
        /// <summary>
        /// 13要素タプルの各要素を展開して関数に渡すThenByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> ThenBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> f)
        {
            return self.ThenBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルの各要素を展開して関数に渡すRevThenByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> RevThenBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> f)
        {
            return self.RevThenBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }
        #endregion
        #region 14要素タプルを扱うThenBy
        /// <summary>
        /// 14要素タプルの各要素を展開して関数に渡すThenByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> ThenBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> f)
        {
            return self.ThenBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルの各要素を展開して関数に渡すRevThenByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> RevThenBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> f)
        {
            return self.RevThenBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }
        #endregion
        #region 15要素タプルを扱うThenBy
        /// <summary>
        /// 15要素タプルの各要素を展開して関数に渡すThenByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> ThenBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> f)
        {
            return self.ThenBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルの各要素を展開して関数に渡すRevThenByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> RevThenBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> f)
        {
            return self.RevThenBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }
        #endregion
        #region 16要素タプルを扱うThenBy
        /// <summary>
        /// 16要素タプルの各要素を展開して関数に渡すThenByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> ThenBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> f)
        {
            return self.ThenBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルの各要素を展開して関数に渡すRevThenByです。
        /// </summary>
        public static IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> RevThenBy<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this IOrderedSeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> f)
        {
            return self.RevThenBy(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }
        #endregion
    }
}