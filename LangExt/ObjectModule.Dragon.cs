

using System;
using System.Collections.Generic;

namespace LangExt
{
    partial class ObjectModule
    {
        #region 2要素タプルを扱う関数

        /// <summary>
        /// 2要素タプルの各要素を展開して関数に渡すTapです。
        /// </summary>
        public static Tuple<T1, T2> Tap<T1, T2>(this Tuple<T1, T2> self, Action<T1, T2> f)
        {
            return self.Tap(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルの各要素を展開して関数に渡すNoneIfです。
        /// </summary>
        public static Option<Tuple<T1, T2>> NoneIf<T1, T2>(this Tuple<T1, T2> self, Func<T1, T2, bool> f)
        {
            return self.NoneIf(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルの各要素を展開して関数に渡すFailureIfです。
        /// </summary>
        public static Result<Tuple<T1, T2>, Unit> FailureIf<T1, T2>(this Tuple<T1, T2> self, Func<T1, T2, bool> f)
        {
            return self.FailureIf(tpl => f(tpl._1(), tpl._2()));
        }
        #endregion

        #region 3要素タプルを扱う関数

        /// <summary>
        /// 3要素タプルの各要素を展開して関数に渡すTapです。
        /// </summary>
        public static Tuple<T1, T2, T3> Tap<T1, T2, T3>(this Tuple<T1, T2, T3> self, Action<T1, T2, T3> f)
        {
            return self.Tap(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルの各要素を展開して関数に渡すNoneIfです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3>> NoneIf<T1, T2, T3>(this Tuple<T1, T2, T3> self, Func<T1, T2, T3, bool> f)
        {
            return self.NoneIf(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルの各要素を展開して関数に渡すFailureIfです。
        /// </summary>
        public static Result<Tuple<T1, T2, T3>, Unit> FailureIf<T1, T2, T3>(this Tuple<T1, T2, T3> self, Func<T1, T2, T3, bool> f)
        {
            return self.FailureIf(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }
        #endregion

        #region 4要素タプルを扱う関数

        /// <summary>
        /// 4要素タプルの各要素を展開して関数に渡すTapです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4> Tap<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> self, Action<T1, T2, T3, T4> f)
        {
            return self.Tap(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルの各要素を展開して関数に渡すNoneIfです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4>> NoneIf<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> self, Func<T1, T2, T3, T4, bool> f)
        {
            return self.NoneIf(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルの各要素を展開して関数に渡すFailureIfです。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4>, Unit> FailureIf<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> self, Func<T1, T2, T3, T4, bool> f)
        {
            return self.FailureIf(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }
        #endregion

        #region 5要素タプルを扱う関数

        /// <summary>
        /// 5要素タプルの各要素を展開して関数に渡すTapです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5> Tap<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> self, Action<T1, T2, T3, T4, T5> f)
        {
            return self.Tap(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルの各要素を展開して関数に渡すNoneIfです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5>> NoneIf<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> self, Func<T1, T2, T3, T4, T5, bool> f)
        {
            return self.NoneIf(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルの各要素を展開して関数に渡すFailureIfです。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5>, Unit> FailureIf<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> self, Func<T1, T2, T3, T4, T5, bool> f)
        {
            return self.FailureIf(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }
        #endregion

        #region 6要素タプルを扱う関数

        /// <summary>
        /// 6要素タプルの各要素を展開して関数に渡すTapです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6> Tap<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> self, Action<T1, T2, T3, T4, T5, T6> f)
        {
            return self.Tap(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルの各要素を展開して関数に渡すNoneIfです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6>> NoneIf<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> self, Func<T1, T2, T3, T4, T5, T6, bool> f)
        {
            return self.NoneIf(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルの各要素を展開して関数に渡すFailureIfです。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5, T6>, Unit> FailureIf<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> self, Func<T1, T2, T3, T4, T5, T6, bool> f)
        {
            return self.FailureIf(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }
        #endregion

        #region 7要素タプルを扱う関数

        /// <summary>
        /// 7要素タプルの各要素を展開して関数に渡すTapです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7> Tap<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> self, Action<T1, T2, T3, T4, T5, T6, T7> f)
        {
            return self.Tap(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルの各要素を展開して関数に渡すNoneIfです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7>> NoneIf<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> self, Func<T1, T2, T3, T4, T5, T6, T7, bool> f)
        {
            return self.NoneIf(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルの各要素を展開して関数に渡すFailureIfです。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5, T6, T7>, Unit> FailureIf<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> self, Func<T1, T2, T3, T4, T5, T6, T7, bool> f)
        {
            return self.FailureIf(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }
        #endregion

        #region 8要素タプルを扱う関数

        /// <summary>
        /// 8要素タプルの各要素を展開して関数に渡すTapです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> Tap<T1, T2, T3, T4, T5, T6, T7, T8>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8> f)
        {
            return self.Tap(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルの各要素を展開して関数に渡すNoneIfです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> NoneIf<T1, T2, T3, T4, T5, T6, T7, T8>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> f)
        {
            return self.NoneIf(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルの各要素を展開して関数に渡すFailureIfです。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>, Unit> FailureIf<T1, T2, T3, T4, T5, T6, T7, T8>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> f)
        {
            return self.FailureIf(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }
        #endregion

        #region 9要素タプルを扱う関数

        /// <summary>
        /// 9要素タプルの各要素を展開して関数に渡すTapです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> Tap<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> f)
        {
            return self.Tap(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルの各要素を展開して関数に渡すNoneIfです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> NoneIf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> f)
        {
            return self.NoneIf(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルの各要素を展開して関数に渡すFailureIfです。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>, Unit> FailureIf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> f)
        {
            return self.FailureIf(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }
        #endregion

        #region 10要素タプルを扱う関数

        /// <summary>
        /// 10要素タプルの各要素を展開して関数に渡すTapです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> Tap<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> f)
        {
            return self.Tap(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルの各要素を展開して関数に渡すNoneIfです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> NoneIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> f)
        {
            return self.NoneIf(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルの各要素を展開して関数に渡すFailureIfです。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>, Unit> FailureIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> f)
        {
            return self.FailureIf(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }
        #endregion

        #region 11要素タプルを扱う関数

        /// <summary>
        /// 11要素タプルの各要素を展開して関数に渡すTapです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> Tap<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> f)
        {
            return self.Tap(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルの各要素を展開して関数に渡すNoneIfです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> NoneIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> f)
        {
            return self.NoneIf(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルの各要素を展開して関数に渡すFailureIfです。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>, Unit> FailureIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> f)
        {
            return self.FailureIf(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }
        #endregion

        #region 12要素タプルを扱う関数

        /// <summary>
        /// 12要素タプルの各要素を展開して関数に渡すTapです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> Tap<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> f)
        {
            return self.Tap(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルの各要素を展開して関数に渡すNoneIfです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> NoneIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> f)
        {
            return self.NoneIf(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルの各要素を展開して関数に渡すFailureIfです。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>, Unit> FailureIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> f)
        {
            return self.FailureIf(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }
        #endregion

        #region 13要素タプルを扱う関数

        /// <summary>
        /// 13要素タプルの各要素を展開して関数に渡すTapです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> Tap<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> f)
        {
            return self.Tap(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルの各要素を展開して関数に渡すNoneIfです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> NoneIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> f)
        {
            return self.NoneIf(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルの各要素を展開して関数に渡すFailureIfです。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>, Unit> FailureIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> f)
        {
            return self.FailureIf(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }
        #endregion

        #region 14要素タプルを扱う関数

        /// <summary>
        /// 14要素タプルの各要素を展開して関数に渡すTapです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> Tap<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> f)
        {
            return self.Tap(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルの各要素を展開して関数に渡すNoneIfです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> NoneIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> f)
        {
            return self.NoneIf(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルの各要素を展開して関数に渡すFailureIfです。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>, Unit> FailureIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> f)
        {
            return self.FailureIf(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }
        #endregion

        #region 15要素タプルを扱う関数

        /// <summary>
        /// 15要素タプルの各要素を展開して関数に渡すTapです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> Tap<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> f)
        {
            return self.Tap(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルの各要素を展開して関数に渡すNoneIfです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> NoneIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> f)
        {
            return self.NoneIf(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルの各要素を展開して関数に渡すFailureIfです。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>, Unit> FailureIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> f)
        {
            return self.FailureIf(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }
        #endregion

        #region 16要素タプルを扱う関数

        /// <summary>
        /// 16要素タプルの各要素を展開して関数に渡すTapです。
        /// </summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> Tap<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> f)
        {
            return self.Tap(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルの各要素を展開して関数に渡すNoneIfです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> NoneIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> f)
        {
            return self.NoneIf(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルの各要素を展開して関数に渡すFailureIfです。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>, Unit> FailureIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> f)
        {
            return self.FailureIf(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }
        #endregion

    }
}