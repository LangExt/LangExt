

using System;
using System.Collections.Generic;

namespace LangExt
{
    partial class Result
    {
        #region Match
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TFailure1, TFailure2, U>(this Result<TSuccess1, Tuple<TFailure1, TFailure2>> self, Func<TSuccess1, U> Success, Func<TFailure1, TFailure2, U> Failure)
        {
            return self.Match(tpl => Success(tpl), tpl => Failure(tpl._1(), tpl._2()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TFailure1, TFailure2, TFailure3, U>(this Result<TSuccess1, Tuple<TFailure1, TFailure2, TFailure3>> self, Func<TSuccess1, U> Success, Func<TFailure1, TFailure2, TFailure3, U> Failure)
        {
            return self.Match(tpl => Success(tpl), tpl => Failure(tpl._1(), tpl._2(), tpl._3()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TFailure1, TFailure2, TFailure3, TFailure4, U>(this Result<TSuccess1, Tuple<TFailure1, TFailure2, TFailure3, TFailure4>> self, Func<TSuccess1, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, U> Failure)
        {
            return self.Match(tpl => Success(tpl), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, U>(this Result<TSuccess1, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5>> self, Func<TSuccess1, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, U> Failure)
        {
            return self.Match(tpl => Success(tpl), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, U>(this Result<TSuccess1, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6>> self, Func<TSuccess1, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, U> Failure)
        {
            return self.Match(tpl => Success(tpl), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, U>(this Result<TSuccess1, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7>> self, Func<TSuccess1, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, U> Failure)
        {
            return self.Match(tpl => Success(tpl), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, U>(this Result<TSuccess1, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8>>> self, Func<TSuccess1, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, U> Failure)
        {
            return self.Match(tpl => Success(tpl), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, U>(this Result<TSuccess1, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9>>> self, Func<TSuccess1, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, U> Failure)
        {
            return self.Match(tpl => Success(tpl), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, U>(this Result<TSuccess1, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10>>> self, Func<TSuccess1, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, U> Failure)
        {
            return self.Match(tpl => Success(tpl), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, U>(this Result<TSuccess1, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11>>> self, Func<TSuccess1, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, U> Failure)
        {
            return self.Match(tpl => Success(tpl), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, U>(this Result<TSuccess1, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12>>> self, Func<TSuccess1, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, U> Failure)
        {
            return self.Match(tpl => Success(tpl), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, U>(this Result<TSuccess1, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13>>> self, Func<TSuccess1, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, U> Failure)
        {
            return self.Match(tpl => Success(tpl), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, U>(this Result<TSuccess1, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14>>> self, Func<TSuccess1, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, U> Failure)
        {
            return self.Match(tpl => Success(tpl), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, U>(this Result<TSuccess1, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, Tuple<TFailure15>>>> self, Func<TSuccess1, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, U> Failure)
        {
            return self.Match(tpl => Success(tpl), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, TFailure16, U>(this Result<TSuccess1, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, Tuple<TFailure15, TFailure16>>>> self, Func<TSuccess1, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, TFailure16, U> Failure)
        {
            return self.Match(tpl => Success(tpl), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TFailure1, U>(this Result<Tuple<TSuccess1, TSuccess2>, TFailure1> self, Func<TSuccess1, TSuccess2, U> Success, Func<TFailure1, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2()), tpl => Failure(tpl));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TFailure1, TFailure2, U>(this Result<Tuple<TSuccess1, TSuccess2>, Tuple<TFailure1, TFailure2>> self, Func<TSuccess1, TSuccess2, U> Success, Func<TFailure1, TFailure2, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2()), tpl => Failure(tpl._1(), tpl._2()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TFailure1, TFailure2, TFailure3, U>(this Result<Tuple<TSuccess1, TSuccess2>, Tuple<TFailure1, TFailure2, TFailure3>> self, Func<TSuccess1, TSuccess2, U> Success, Func<TFailure1, TFailure2, TFailure3, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2()), tpl => Failure(tpl._1(), tpl._2(), tpl._3()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TFailure1, TFailure2, TFailure3, TFailure4, U>(this Result<Tuple<TSuccess1, TSuccess2>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4>> self, Func<TSuccess1, TSuccess2, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, U>(this Result<Tuple<TSuccess1, TSuccess2>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5>> self, Func<TSuccess1, TSuccess2, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, U>(this Result<Tuple<TSuccess1, TSuccess2>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6>> self, Func<TSuccess1, TSuccess2, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, U>(this Result<Tuple<TSuccess1, TSuccess2>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7>> self, Func<TSuccess1, TSuccess2, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, U>(this Result<Tuple<TSuccess1, TSuccess2>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8>>> self, Func<TSuccess1, TSuccess2, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, U>(this Result<Tuple<TSuccess1, TSuccess2>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9>>> self, Func<TSuccess1, TSuccess2, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, U>(this Result<Tuple<TSuccess1, TSuccess2>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10>>> self, Func<TSuccess1, TSuccess2, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, U>(this Result<Tuple<TSuccess1, TSuccess2>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11>>> self, Func<TSuccess1, TSuccess2, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, U>(this Result<Tuple<TSuccess1, TSuccess2>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12>>> self, Func<TSuccess1, TSuccess2, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, U>(this Result<Tuple<TSuccess1, TSuccess2>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13>>> self, Func<TSuccess1, TSuccess2, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, U>(this Result<Tuple<TSuccess1, TSuccess2>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14>>> self, Func<TSuccess1, TSuccess2, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, U>(this Result<Tuple<TSuccess1, TSuccess2>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, Tuple<TFailure15>>>> self, Func<TSuccess1, TSuccess2, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, TFailure16, U>(this Result<Tuple<TSuccess1, TSuccess2>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, Tuple<TFailure15, TFailure16>>>> self, Func<TSuccess1, TSuccess2, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, TFailure16, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TFailure1, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3>, TFailure1> self, Func<TSuccess1, TSuccess2, TSuccess3, U> Success, Func<TFailure1, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3()), tpl => Failure(tpl));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TFailure1, TFailure2, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3>, Tuple<TFailure1, TFailure2>> self, Func<TSuccess1, TSuccess2, TSuccess3, U> Success, Func<TFailure1, TFailure2, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3()), tpl => Failure(tpl._1(), tpl._2()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TFailure1, TFailure2, TFailure3, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3>, Tuple<TFailure1, TFailure2, TFailure3>> self, Func<TSuccess1, TSuccess2, TSuccess3, U> Success, Func<TFailure1, TFailure2, TFailure3, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3()), tpl => Failure(tpl._1(), tpl._2(), tpl._3()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TFailure1, TFailure2, TFailure3, TFailure4, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4>> self, Func<TSuccess1, TSuccess2, TSuccess3, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5>> self, Func<TSuccess1, TSuccess2, TSuccess3, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6>> self, Func<TSuccess1, TSuccess2, TSuccess3, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7>> self, Func<TSuccess1, TSuccess2, TSuccess3, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8>>> self, Func<TSuccess1, TSuccess2, TSuccess3, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9>>> self, Func<TSuccess1, TSuccess2, TSuccess3, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10>>> self, Func<TSuccess1, TSuccess2, TSuccess3, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11>>> self, Func<TSuccess1, TSuccess2, TSuccess3, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12>>> self, Func<TSuccess1, TSuccess2, TSuccess3, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13>>> self, Func<TSuccess1, TSuccess2, TSuccess3, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14>>> self, Func<TSuccess1, TSuccess2, TSuccess3, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, Tuple<TFailure15>>>> self, Func<TSuccess1, TSuccess2, TSuccess3, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, TFailure16, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, Tuple<TFailure15, TFailure16>>>> self, Func<TSuccess1, TSuccess2, TSuccess3, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, TFailure16, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TFailure1, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4>, TFailure1> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, U> Success, Func<TFailure1, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4()), tpl => Failure(tpl));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TFailure1, TFailure2, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4>, Tuple<TFailure1, TFailure2>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, U> Success, Func<TFailure1, TFailure2, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4()), tpl => Failure(tpl._1(), tpl._2()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TFailure1, TFailure2, TFailure3, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4>, Tuple<TFailure1, TFailure2, TFailure3>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, U> Success, Func<TFailure1, TFailure2, TFailure3, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4()), tpl => Failure(tpl._1(), tpl._2(), tpl._3()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TFailure1, TFailure2, TFailure3, TFailure4, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, Tuple<TFailure15>>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, TFailure16, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, Tuple<TFailure15, TFailure16>>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, TFailure16, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TFailure1, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5>, TFailure1> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, U> Success, Func<TFailure1, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()), tpl => Failure(tpl));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TFailure1, TFailure2, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5>, Tuple<TFailure1, TFailure2>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, U> Success, Func<TFailure1, TFailure2, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()), tpl => Failure(tpl._1(), tpl._2()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TFailure1, TFailure2, TFailure3, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5>, Tuple<TFailure1, TFailure2, TFailure3>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, U> Success, Func<TFailure1, TFailure2, TFailure3, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()), tpl => Failure(tpl._1(), tpl._2(), tpl._3()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TFailure1, TFailure2, TFailure3, TFailure4, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, Tuple<TFailure15>>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, TFailure16, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, Tuple<TFailure15, TFailure16>>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, TFailure16, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TFailure1, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6>, TFailure1> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, U> Success, Func<TFailure1, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()), tpl => Failure(tpl));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TFailure1, TFailure2, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6>, Tuple<TFailure1, TFailure2>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, U> Success, Func<TFailure1, TFailure2, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()), tpl => Failure(tpl._1(), tpl._2()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TFailure1, TFailure2, TFailure3, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6>, Tuple<TFailure1, TFailure2, TFailure3>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, U> Success, Func<TFailure1, TFailure2, TFailure3, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()), tpl => Failure(tpl._1(), tpl._2(), tpl._3()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TFailure1, TFailure2, TFailure3, TFailure4, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, Tuple<TFailure15>>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, TFailure16, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, Tuple<TFailure15, TFailure16>>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, TFailure16, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TFailure1, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7>, TFailure1> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, U> Success, Func<TFailure1, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()), tpl => Failure(tpl));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TFailure1, TFailure2, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7>, Tuple<TFailure1, TFailure2>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, U> Success, Func<TFailure1, TFailure2, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()), tpl => Failure(tpl._1(), tpl._2()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TFailure1, TFailure2, TFailure3, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7>, Tuple<TFailure1, TFailure2, TFailure3>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, U> Success, Func<TFailure1, TFailure2, TFailure3, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()), tpl => Failure(tpl._1(), tpl._2(), tpl._3()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TFailure1, TFailure2, TFailure3, TFailure4, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, Tuple<TFailure15>>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, TFailure16, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, Tuple<TFailure15, TFailure16>>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, TFailure16, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TFailure1, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8>>, TFailure1> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, U> Success, Func<TFailure1, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()), tpl => Failure(tpl));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TFailure1, TFailure2, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8>>, Tuple<TFailure1, TFailure2>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, U> Success, Func<TFailure1, TFailure2, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()), tpl => Failure(tpl._1(), tpl._2()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TFailure1, TFailure2, TFailure3, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8>>, Tuple<TFailure1, TFailure2, TFailure3>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, U> Success, Func<TFailure1, TFailure2, TFailure3, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()), tpl => Failure(tpl._1(), tpl._2(), tpl._3()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TFailure1, TFailure2, TFailure3, TFailure4, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, Tuple<TFailure15>>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, TFailure16, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, Tuple<TFailure15, TFailure16>>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, TFailure16, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TFailure1, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9>>, TFailure1> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, U> Success, Func<TFailure1, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()), tpl => Failure(tpl));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TFailure1, TFailure2, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9>>, Tuple<TFailure1, TFailure2>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, U> Success, Func<TFailure1, TFailure2, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()), tpl => Failure(tpl._1(), tpl._2()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TFailure1, TFailure2, TFailure3, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9>>, Tuple<TFailure1, TFailure2, TFailure3>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, U> Success, Func<TFailure1, TFailure2, TFailure3, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()), tpl => Failure(tpl._1(), tpl._2(), tpl._3()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TFailure1, TFailure2, TFailure3, TFailure4, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, Tuple<TFailure15>>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, TFailure16, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, Tuple<TFailure15, TFailure16>>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, TFailure16, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TFailure1, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10>>, TFailure1> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, U> Success, Func<TFailure1, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()), tpl => Failure(tpl));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TFailure1, TFailure2, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10>>, Tuple<TFailure1, TFailure2>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, U> Success, Func<TFailure1, TFailure2, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()), tpl => Failure(tpl._1(), tpl._2()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TFailure1, TFailure2, TFailure3, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10>>, Tuple<TFailure1, TFailure2, TFailure3>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, U> Success, Func<TFailure1, TFailure2, TFailure3, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()), tpl => Failure(tpl._1(), tpl._2(), tpl._3()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TFailure1, TFailure2, TFailure3, TFailure4, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, Tuple<TFailure15>>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, TFailure16, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, Tuple<TFailure15, TFailure16>>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, TFailure16, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TFailure1, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11>>, TFailure1> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, U> Success, Func<TFailure1, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()), tpl => Failure(tpl));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TFailure1, TFailure2, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11>>, Tuple<TFailure1, TFailure2>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, U> Success, Func<TFailure1, TFailure2, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()), tpl => Failure(tpl._1(), tpl._2()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TFailure1, TFailure2, TFailure3, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11>>, Tuple<TFailure1, TFailure2, TFailure3>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, U> Success, Func<TFailure1, TFailure2, TFailure3, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()), tpl => Failure(tpl._1(), tpl._2(), tpl._3()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TFailure1, TFailure2, TFailure3, TFailure4, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, Tuple<TFailure15>>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, TFailure16, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, Tuple<TFailure15, TFailure16>>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, TFailure16, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TFailure1, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12>>, TFailure1> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, U> Success, Func<TFailure1, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()), tpl => Failure(tpl));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TFailure1, TFailure2, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12>>, Tuple<TFailure1, TFailure2>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, U> Success, Func<TFailure1, TFailure2, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()), tpl => Failure(tpl._1(), tpl._2()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TFailure1, TFailure2, TFailure3, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12>>, Tuple<TFailure1, TFailure2, TFailure3>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, U> Success, Func<TFailure1, TFailure2, TFailure3, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()), tpl => Failure(tpl._1(), tpl._2(), tpl._3()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TFailure1, TFailure2, TFailure3, TFailure4, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, Tuple<TFailure15>>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, TFailure16, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, Tuple<TFailure15, TFailure16>>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, TFailure16, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TFailure1, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13>>, TFailure1> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, U> Success, Func<TFailure1, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()), tpl => Failure(tpl));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TFailure1, TFailure2, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13>>, Tuple<TFailure1, TFailure2>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, U> Success, Func<TFailure1, TFailure2, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()), tpl => Failure(tpl._1(), tpl._2()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TFailure1, TFailure2, TFailure3, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13>>, Tuple<TFailure1, TFailure2, TFailure3>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, U> Success, Func<TFailure1, TFailure2, TFailure3, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()), tpl => Failure(tpl._1(), tpl._2(), tpl._3()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TFailure1, TFailure2, TFailure3, TFailure4, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, Tuple<TFailure15>>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, TFailure16, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, Tuple<TFailure15, TFailure16>>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, TFailure16, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TFailure1, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14>>, TFailure1> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, U> Success, Func<TFailure1, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()), tpl => Failure(tpl));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TFailure1, TFailure2, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14>>, Tuple<TFailure1, TFailure2>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, U> Success, Func<TFailure1, TFailure2, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()), tpl => Failure(tpl._1(), tpl._2()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TFailure1, TFailure2, TFailure3, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14>>, Tuple<TFailure1, TFailure2, TFailure3>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, U> Success, Func<TFailure1, TFailure2, TFailure3, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()), tpl => Failure(tpl._1(), tpl._2(), tpl._3()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TFailure1, TFailure2, TFailure3, TFailure4, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, Tuple<TFailure15>>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, TFailure16, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, Tuple<TFailure15, TFailure16>>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, TFailure16, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TFailure1, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, Tuple<TSuccess15>>>, TFailure1> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, U> Success, Func<TFailure1, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()), tpl => Failure(tpl));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TFailure1, TFailure2, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, Tuple<TSuccess15>>>, Tuple<TFailure1, TFailure2>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, U> Success, Func<TFailure1, TFailure2, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()), tpl => Failure(tpl._1(), tpl._2()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TFailure1, TFailure2, TFailure3, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, Tuple<TSuccess15>>>, Tuple<TFailure1, TFailure2, TFailure3>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, U> Success, Func<TFailure1, TFailure2, TFailure3, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()), tpl => Failure(tpl._1(), tpl._2(), tpl._3()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TFailure1, TFailure2, TFailure3, TFailure4, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, Tuple<TSuccess15>>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, Tuple<TSuccess15>>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, Tuple<TSuccess15>>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, Tuple<TSuccess15>>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, Tuple<TSuccess15>>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, Tuple<TSuccess15>>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, Tuple<TSuccess15>>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, Tuple<TSuccess15>>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, Tuple<TSuccess15>>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, Tuple<TSuccess15>>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, Tuple<TSuccess15>>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, Tuple<TSuccess15>>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, Tuple<TFailure15>>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, TFailure16, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, Tuple<TSuccess15>>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, Tuple<TFailure15, TFailure16>>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, TFailure16, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TSuccess16, TFailure1, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, Tuple<TSuccess15, TSuccess16>>>, TFailure1> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TSuccess16, U> Success, Func<TFailure1, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()), tpl => Failure(tpl));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TSuccess16, TFailure1, TFailure2, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, Tuple<TSuccess15, TSuccess16>>>, Tuple<TFailure1, TFailure2>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TSuccess16, U> Success, Func<TFailure1, TFailure2, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()), tpl => Failure(tpl._1(), tpl._2()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TSuccess16, TFailure1, TFailure2, TFailure3, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, Tuple<TSuccess15, TSuccess16>>>, Tuple<TFailure1, TFailure2, TFailure3>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TSuccess16, U> Success, Func<TFailure1, TFailure2, TFailure3, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()), tpl => Failure(tpl._1(), tpl._2(), tpl._3()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TSuccess16, TFailure1, TFailure2, TFailure3, TFailure4, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, Tuple<TSuccess15, TSuccess16>>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TSuccess16, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TSuccess16, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, Tuple<TSuccess15, TSuccess16>>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TSuccess16, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TSuccess16, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, Tuple<TSuccess15, TSuccess16>>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TSuccess16, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TSuccess16, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, Tuple<TSuccess15, TSuccess16>>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TSuccess16, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TSuccess16, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, Tuple<TSuccess15, TSuccess16>>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TSuccess16, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TSuccess16, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, Tuple<TSuccess15, TSuccess16>>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TSuccess16, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TSuccess16, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, Tuple<TSuccess15, TSuccess16>>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TSuccess16, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TSuccess16, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, Tuple<TSuccess15, TSuccess16>>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TSuccess16, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TSuccess16, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, Tuple<TSuccess15, TSuccess16>>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TSuccess16, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TSuccess16, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, Tuple<TSuccess15, TSuccess16>>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TSuccess16, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TSuccess16, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, Tuple<TSuccess15, TSuccess16>>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TSuccess16, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TSuccess16, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, Tuple<TSuccess15, TSuccess16>>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, Tuple<TFailure15>>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TSuccess16, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }
        /// <summary>タプルの要素を展開して関数に渡すMatchです。</summary>
        public static U Match<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TSuccess16, TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, TFailure16, U>(this Result<Tuple<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, Tuple<TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, Tuple<TSuccess15, TSuccess16>>>, Tuple<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, Tuple<TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, Tuple<TFailure15, TFailure16>>>> self, Func<TSuccess1, TSuccess2, TSuccess3, TSuccess4, TSuccess5, TSuccess6, TSuccess7, TSuccess8, TSuccess9, TSuccess10, TSuccess11, TSuccess12, TSuccess13, TSuccess14, TSuccess15, TSuccess16, U> Success, Func<TFailure1, TFailure2, TFailure3, TFailure4, TFailure5, TFailure6, TFailure7, TFailure8, TFailure9, TFailure10, TFailure11, TFailure12, TFailure13, TFailure14, TFailure15, TFailure16, U> Failure)
        {
            return self.Match(tpl => Success(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()), tpl => Failure(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }
        #endregion
        #region 2要素タプルを扱うSuccess側の関数

        /// <summary>
        /// 2要素タプルのResultの各要素を展開して関数に渡すSafeCastです。
        /// </summary>
        public static Result<TSuccess2, TFailure> SafeCast<T1, T2, TFailure, TSuccess2>(this Result<Tuple<T1, T2>, TFailure> self, Func<T1, T2, TSuccess2> f)
        {
            return self.SafeCast(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのResultの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, TFailure>(this Result<Tuple<T1, T2>, TFailure> self, Func<T1, T2, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのResultの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, TFailure, U>(this Result<Tuple<T1, T2>, TFailure> self, U init, Func<U, T1, T2, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのResultの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, TFailure>(this Result<Tuple<T1, T2>, TFailure> self, Func<T1, T2, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのResultの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, TFailure>(this Result<Tuple<T1, T2>, TFailure> self, Func<T1, T2, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのResultの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static Result<U, TFailure> Map<T1, T2, TFailure, U>(this Result<Tuple<T1, T2>, TFailure> self, Func<T1, T2, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのResultの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, TFailure>(this Result<Tuple<T1, T2>, TFailure> self, Action<T1, T2> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのResultの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static Result<U, TFailure> Bind<T1, T2, TFailure, U>(this Result<Tuple<T1, T2>, TFailure> self, Func<T1, T2, Result<U, TFailure>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2()));
        }
        #endregion

        #region 3要素タプルを扱うSuccess側の関数

        /// <summary>
        /// 3要素タプルのResultの各要素を展開して関数に渡すSafeCastです。
        /// </summary>
        public static Result<TSuccess2, TFailure> SafeCast<T1, T2, T3, TFailure, TSuccess2>(this Result<Tuple<T1, T2, T3>, TFailure> self, Func<T1, T2, T3, TSuccess2> f)
        {
            return self.SafeCast(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのResultの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, TFailure>(this Result<Tuple<T1, T2, T3>, TFailure> self, Func<T1, T2, T3, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのResultの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, TFailure, U>(this Result<Tuple<T1, T2, T3>, TFailure> self, U init, Func<U, T1, T2, T3, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのResultの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, TFailure>(this Result<Tuple<T1, T2, T3>, TFailure> self, Func<T1, T2, T3, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのResultの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, TFailure>(this Result<Tuple<T1, T2, T3>, TFailure> self, Func<T1, T2, T3, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのResultの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static Result<U, TFailure> Map<T1, T2, T3, TFailure, U>(this Result<Tuple<T1, T2, T3>, TFailure> self, Func<T1, T2, T3, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのResultの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, TFailure>(this Result<Tuple<T1, T2, T3>, TFailure> self, Action<T1, T2, T3> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのResultの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static Result<U, TFailure> Bind<T1, T2, T3, TFailure, U>(this Result<Tuple<T1, T2, T3>, TFailure> self, Func<T1, T2, T3, Result<U, TFailure>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }
        #endregion

        #region 4要素タプルを扱うSuccess側の関数

        /// <summary>
        /// 4要素タプルのResultの各要素を展開して関数に渡すSafeCastです。
        /// </summary>
        public static Result<TSuccess2, TFailure> SafeCast<T1, T2, T3, T4, TFailure, TSuccess2>(this Result<Tuple<T1, T2, T3, T4>, TFailure> self, Func<T1, T2, T3, T4, TSuccess2> f)
        {
            return self.SafeCast(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのResultの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, TFailure>(this Result<Tuple<T1, T2, T3, T4>, TFailure> self, Func<T1, T2, T3, T4, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのResultの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, TFailure, U>(this Result<Tuple<T1, T2, T3, T4>, TFailure> self, U init, Func<U, T1, T2, T3, T4, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのResultの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, TFailure>(this Result<Tuple<T1, T2, T3, T4>, TFailure> self, Func<T1, T2, T3, T4, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのResultの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, TFailure>(this Result<Tuple<T1, T2, T3, T4>, TFailure> self, Func<T1, T2, T3, T4, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのResultの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static Result<U, TFailure> Map<T1, T2, T3, T4, TFailure, U>(this Result<Tuple<T1, T2, T3, T4>, TFailure> self, Func<T1, T2, T3, T4, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのResultの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, TFailure>(this Result<Tuple<T1, T2, T3, T4>, TFailure> self, Action<T1, T2, T3, T4> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのResultの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static Result<U, TFailure> Bind<T1, T2, T3, T4, TFailure, U>(this Result<Tuple<T1, T2, T3, T4>, TFailure> self, Func<T1, T2, T3, T4, Result<U, TFailure>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }
        #endregion

        #region 5要素タプルを扱うSuccess側の関数

        /// <summary>
        /// 5要素タプルのResultの各要素を展開して関数に渡すSafeCastです。
        /// </summary>
        public static Result<TSuccess2, TFailure> SafeCast<T1, T2, T3, T4, T5, TFailure, TSuccess2>(this Result<Tuple<T1, T2, T3, T4, T5>, TFailure> self, Func<T1, T2, T3, T4, T5, TSuccess2> f)
        {
            return self.SafeCast(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのResultの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5>, TFailure> self, Func<T1, T2, T3, T4, T5, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのResultの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, T5, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5>, TFailure> self, U init, Func<U, T1, T2, T3, T4, T5, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのResultの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5>, TFailure> self, Func<T1, T2, T3, T4, T5, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのResultの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5>, TFailure> self, Func<T1, T2, T3, T4, T5, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのResultの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static Result<U, TFailure> Map<T1, T2, T3, T4, T5, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5>, TFailure> self, Func<T1, T2, T3, T4, T5, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのResultの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5>, TFailure> self, Action<T1, T2, T3, T4, T5> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのResultの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static Result<U, TFailure> Bind<T1, T2, T3, T4, T5, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5>, TFailure> self, Func<T1, T2, T3, T4, T5, Result<U, TFailure>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }
        #endregion

        #region 6要素タプルを扱うSuccess側の関数

        /// <summary>
        /// 6要素タプルのResultの各要素を展開して関数に渡すSafeCastです。
        /// </summary>
        public static Result<TSuccess2, TFailure> SafeCast<T1, T2, T3, T4, T5, T6, TFailure, TSuccess2>(this Result<Tuple<T1, T2, T3, T4, T5, T6>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, TSuccess2> f)
        {
            return self.SafeCast(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのResultの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5, T6, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのResultの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, T5, T6, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5, T6>, TFailure> self, U init, Func<U, T1, T2, T3, T4, T5, T6, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのResultの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5, T6, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのResultの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5, T6, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのResultの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static Result<U, TFailure> Map<T1, T2, T3, T4, T5, T6, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5, T6>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのResultの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5, T6, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6>, TFailure> self, Action<T1, T2, T3, T4, T5, T6> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのResultの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static Result<U, TFailure> Bind<T1, T2, T3, T4, T5, T6, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5, T6>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, Result<U, TFailure>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }
        #endregion

        #region 7要素タプルを扱うSuccess側の関数

        /// <summary>
        /// 7要素タプルのResultの各要素を展開して関数に渡すSafeCastです。
        /// </summary>
        public static Result<TSuccess2, TFailure> SafeCast<T1, T2, T3, T4, T5, T6, T7, TFailure, TSuccess2>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, TSuccess2> f)
        {
            return self.SafeCast(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのResultの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5, T6, T7, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのResultの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, T5, T6, T7, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7>, TFailure> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのResultの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5, T6, T7, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのResultの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5, T6, T7, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのResultの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static Result<U, TFailure> Map<T1, T2, T3, T4, T5, T6, T7, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのResultの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5, T6, T7, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7>, TFailure> self, Action<T1, T2, T3, T4, T5, T6, T7> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのResultの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static Result<U, TFailure> Bind<T1, T2, T3, T4, T5, T6, T7, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, Result<U, TFailure>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }
        #endregion

        #region 8要素タプルを扱うSuccess側の関数

        /// <summary>
        /// 8要素タプルのResultの各要素を展開して関数に渡すSafeCastです。
        /// </summary>
        public static Result<TSuccess2, TFailure> SafeCast<T1, T2, T3, T4, T5, T6, T7, T8, TFailure, TSuccess2>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, TSuccess2> f)
        {
            return self.SafeCast(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのResultの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5, T6, T7, T8, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのResultの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, T5, T6, T7, T8, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>, TFailure> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのResultの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5, T6, T7, T8, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのResultの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5, T6, T7, T8, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのResultの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static Result<U, TFailure> Map<T1, T2, T3, T4, T5, T6, T7, T8, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのResultの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5, T6, T7, T8, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>, TFailure> self, Action<T1, T2, T3, T4, T5, T6, T7, T8> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのResultの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static Result<U, TFailure> Bind<T1, T2, T3, T4, T5, T6, T7, T8, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, Result<U, TFailure>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }
        #endregion

        #region 9要素タプルを扱うSuccess側の関数

        /// <summary>
        /// 9要素タプルのResultの各要素を展開して関数に渡すSafeCastです。
        /// </summary>
        public static Result<TSuccess2, TFailure> SafeCast<T1, T2, T3, T4, T5, T6, T7, T8, T9, TFailure, TSuccess2>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TSuccess2> f)
        {
            return self.SafeCast(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのResultの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5, T6, T7, T8, T9, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのResultの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, T5, T6, T7, T8, T9, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>, TFailure> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのResultの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5, T6, T7, T8, T9, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのResultの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5, T6, T7, T8, T9, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのResultの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static Result<U, TFailure> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのResultの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5, T6, T7, T8, T9, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>, TFailure> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのResultの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static Result<U, TFailure> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Result<U, TFailure>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }
        #endregion

        #region 10要素タプルを扱うSuccess側の関数

        /// <summary>
        /// 10要素タプルのResultの各要素を展開して関数に渡すSafeCastです。
        /// </summary>
        public static Result<TSuccess2, TFailure> SafeCast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TFailure, TSuccess2>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TSuccess2> f)
        {
            return self.SafeCast(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのResultの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのResultの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>, TFailure> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのResultの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのResultの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのResultの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static Result<U, TFailure> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのResultの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>, TFailure> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのResultの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static Result<U, TFailure> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Result<U, TFailure>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }
        #endregion

        #region 11要素タプルを扱うSuccess側の関数

        /// <summary>
        /// 11要素タプルのResultの各要素を展開して関数に渡すSafeCastです。
        /// </summary>
        public static Result<TSuccess2, TFailure> SafeCast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TFailure, TSuccess2>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TSuccess2> f)
        {
            return self.SafeCast(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのResultの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのResultの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>, TFailure> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのResultの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのResultの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのResultの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static Result<U, TFailure> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのResultの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>, TFailure> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのResultの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static Result<U, TFailure> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Result<U, TFailure>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }
        #endregion

        #region 12要素タプルを扱うSuccess側の関数

        /// <summary>
        /// 12要素タプルのResultの各要素を展開して関数に渡すSafeCastです。
        /// </summary>
        public static Result<TSuccess2, TFailure> SafeCast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TFailure, TSuccess2>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TSuccess2> f)
        {
            return self.SafeCast(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのResultの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのResultの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>, TFailure> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのResultの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのResultの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのResultの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static Result<U, TFailure> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのResultの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>, TFailure> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのResultの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static Result<U, TFailure> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Result<U, TFailure>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }
        #endregion

        #region 13要素タプルを扱うSuccess側の関数

        /// <summary>
        /// 13要素タプルのResultの各要素を展開して関数に渡すSafeCastです。
        /// </summary>
        public static Result<TSuccess2, TFailure> SafeCast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TFailure, TSuccess2>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TSuccess2> f)
        {
            return self.SafeCast(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのResultの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのResultの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>, TFailure> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのResultの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのResultの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのResultの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static Result<U, TFailure> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのResultの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>, TFailure> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのResultの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static Result<U, TFailure> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Result<U, TFailure>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }
        #endregion

        #region 14要素タプルを扱うSuccess側の関数

        /// <summary>
        /// 14要素タプルのResultの各要素を展開して関数に渡すSafeCastです。
        /// </summary>
        public static Result<TSuccess2, TFailure> SafeCast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TFailure, TSuccess2>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TSuccess2> f)
        {
            return self.SafeCast(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのResultの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのResultの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>, TFailure> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのResultの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのResultの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのResultの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static Result<U, TFailure> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのResultの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>, TFailure> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのResultの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static Result<U, TFailure> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Result<U, TFailure>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }
        #endregion

        #region 15要素タプルを扱うSuccess側の関数

        /// <summary>
        /// 15要素タプルのResultの各要素を展開して関数に渡すSafeCastです。
        /// </summary>
        public static Result<TSuccess2, TFailure> SafeCast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TFailure, TSuccess2>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TSuccess2> f)
        {
            return self.SafeCast(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのResultの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのResultの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>, TFailure> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのResultの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのResultの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのResultの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static Result<U, TFailure> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのResultの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>, TFailure> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのResultの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static Result<U, TFailure> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Result<U, TFailure>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }
        #endregion

        #region 16要素タプルを扱うSuccess側の関数

        /// <summary>
        /// 16要素タプルのResultの各要素を展開して関数に渡すSafeCastです。
        /// </summary>
        public static Result<TSuccess2, TFailure> SafeCast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TFailure, TSuccess2>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TSuccess2> f)
        {
            return self.SafeCast(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのResultの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのResultの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのResultの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのResultの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static Result<U, TFailure> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのResultの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TFailure>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>, TFailure> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのResultの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static Result<U, TFailure> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TFailure, U>(this Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>, TFailure> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Result<U, TFailure>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }
        #endregion

        #region 2要素タプルを扱うFailure側の関数

        /// <summary>
        /// 2要素タプルのResultの各要素を展開して関数に渡すSafeCastFailureです。
        /// </summary>
        public static Result<TSuccess, TFailure2> SafeCastFailure<T1, T2, TSuccess, TFailure2>(this Result<TSuccess, Tuple<T1, T2>> self, Func<T1, T2, TFailure2> f)
        {
            return self.SafeCastFailure(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのResultの各要素を展開して関数に渡すCountFailureです。
        /// </summary>
        public static int CountFailure<T1, T2, TSuccess>(this Result<TSuccess, Tuple<T1, T2>> self, Func<T1, T2, bool> f)
        {
            return self.CountFailure(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのResultの各要素を展開して関数に渡すFoldFailureです。
        /// </summary>
        public static U FoldFailure<T1, T2, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2>> self, U init, Func<U, T1, T2, U> f)
        {
            return self.FoldFailure(init, (acc, tpl) => f(acc, tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのResultの各要素を展開して関数に渡すForallFailureです。
        /// </summary>
        public static bool ForallFailure<T1, T2, TSuccess>(this Result<TSuccess, Tuple<T1, T2>> self, Func<T1, T2, bool> f)
        {
            return self.ForallFailure(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのResultの各要素を展開して関数に渡すExistsFailureです。
        /// </summary>
        public static bool ExistsFailure<T1, T2, TSuccess>(this Result<TSuccess, Tuple<T1, T2>> self, Func<T1, T2, bool> f)
        {
            return self.ExistsFailure(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのResultの各要素を展開して関数に渡すMapFailureです。
        /// </summary>
        public static Result<TSuccess, U> MapFailure<T1, T2, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2>> self, Func<T1, T2, U> f)
        {
            return self.MapFailure(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのResultの各要素を展開して関数に渡すIterFailureです。
        /// </summary>
        public static void IterFailure<T1, T2, TSuccess>(this Result<TSuccess, Tuple<T1, T2>> self, Action<T1, T2> f)
        {
            self.IterFailure(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのResultの各要素を展開して関数に渡すBindFailureです。
        /// </summary>
        public static Result<TSuccess, U> BindFailure<T1, T2, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2>> self, Func<T1, T2, Result<TSuccess, U>> f)
        {
            return self.BindFailure(tpl => f(tpl._1(), tpl._2()));
        }
        #endregion

        #region 3要素タプルを扱うFailure側の関数

        /// <summary>
        /// 3要素タプルのResultの各要素を展開して関数に渡すSafeCastFailureです。
        /// </summary>
        public static Result<TSuccess, TFailure2> SafeCastFailure<T1, T2, T3, TSuccess, TFailure2>(this Result<TSuccess, Tuple<T1, T2, T3>> self, Func<T1, T2, T3, TFailure2> f)
        {
            return self.SafeCastFailure(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのResultの各要素を展開して関数に渡すCountFailureです。
        /// </summary>
        public static int CountFailure<T1, T2, T3, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3>> self, Func<T1, T2, T3, bool> f)
        {
            return self.CountFailure(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのResultの各要素を展開して関数に渡すFoldFailureです。
        /// </summary>
        public static U FoldFailure<T1, T2, T3, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3>> self, U init, Func<U, T1, T2, T3, U> f)
        {
            return self.FoldFailure(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのResultの各要素を展開して関数に渡すForallFailureです。
        /// </summary>
        public static bool ForallFailure<T1, T2, T3, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3>> self, Func<T1, T2, T3, bool> f)
        {
            return self.ForallFailure(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのResultの各要素を展開して関数に渡すExistsFailureです。
        /// </summary>
        public static bool ExistsFailure<T1, T2, T3, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3>> self, Func<T1, T2, T3, bool> f)
        {
            return self.ExistsFailure(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのResultの各要素を展開して関数に渡すMapFailureです。
        /// </summary>
        public static Result<TSuccess, U> MapFailure<T1, T2, T3, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3>> self, Func<T1, T2, T3, U> f)
        {
            return self.MapFailure(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのResultの各要素を展開して関数に渡すIterFailureです。
        /// </summary>
        public static void IterFailure<T1, T2, T3, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3>> self, Action<T1, T2, T3> f)
        {
            self.IterFailure(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのResultの各要素を展開して関数に渡すBindFailureです。
        /// </summary>
        public static Result<TSuccess, U> BindFailure<T1, T2, T3, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3>> self, Func<T1, T2, T3, Result<TSuccess, U>> f)
        {
            return self.BindFailure(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }
        #endregion

        #region 4要素タプルを扱うFailure側の関数

        /// <summary>
        /// 4要素タプルのResultの各要素を展開して関数に渡すSafeCastFailureです。
        /// </summary>
        public static Result<TSuccess, TFailure2> SafeCastFailure<T1, T2, T3, T4, TSuccess, TFailure2>(this Result<TSuccess, Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, TFailure2> f)
        {
            return self.SafeCastFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのResultの各要素を展開して関数に渡すCountFailureです。
        /// </summary>
        public static int CountFailure<T1, T2, T3, T4, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, bool> f)
        {
            return self.CountFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのResultの各要素を展開して関数に渡すFoldFailureです。
        /// </summary>
        public static U FoldFailure<T1, T2, T3, T4, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4>> self, U init, Func<U, T1, T2, T3, T4, U> f)
        {
            return self.FoldFailure(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのResultの各要素を展開して関数に渡すForallFailureです。
        /// </summary>
        public static bool ForallFailure<T1, T2, T3, T4, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, bool> f)
        {
            return self.ForallFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのResultの各要素を展開して関数に渡すExistsFailureです。
        /// </summary>
        public static bool ExistsFailure<T1, T2, T3, T4, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, bool> f)
        {
            return self.ExistsFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのResultの各要素を展開して関数に渡すMapFailureです。
        /// </summary>
        public static Result<TSuccess, U> MapFailure<T1, T2, T3, T4, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, U> f)
        {
            return self.MapFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのResultの各要素を展開して関数に渡すIterFailureです。
        /// </summary>
        public static void IterFailure<T1, T2, T3, T4, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4>> self, Action<T1, T2, T3, T4> f)
        {
            self.IterFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのResultの各要素を展開して関数に渡すBindFailureです。
        /// </summary>
        public static Result<TSuccess, U> BindFailure<T1, T2, T3, T4, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, Result<TSuccess, U>> f)
        {
            return self.BindFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }
        #endregion

        #region 5要素タプルを扱うFailure側の関数

        /// <summary>
        /// 5要素タプルのResultの各要素を展開して関数に渡すSafeCastFailureです。
        /// </summary>
        public static Result<TSuccess, TFailure2> SafeCastFailure<T1, T2, T3, T4, T5, TSuccess, TFailure2>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, TFailure2> f)
        {
            return self.SafeCastFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのResultの各要素を展開して関数に渡すCountFailureです。
        /// </summary>
        public static int CountFailure<T1, T2, T3, T4, T5, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, bool> f)
        {
            return self.CountFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのResultの各要素を展開して関数に渡すFoldFailureです。
        /// </summary>
        public static U FoldFailure<T1, T2, T3, T4, T5, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5>> self, U init, Func<U, T1, T2, T3, T4, T5, U> f)
        {
            return self.FoldFailure(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのResultの各要素を展開して関数に渡すForallFailureです。
        /// </summary>
        public static bool ForallFailure<T1, T2, T3, T4, T5, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, bool> f)
        {
            return self.ForallFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのResultの各要素を展開して関数に渡すExistsFailureです。
        /// </summary>
        public static bool ExistsFailure<T1, T2, T3, T4, T5, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, bool> f)
        {
            return self.ExistsFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのResultの各要素を展開して関数に渡すMapFailureです。
        /// </summary>
        public static Result<TSuccess, U> MapFailure<T1, T2, T3, T4, T5, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, U> f)
        {
            return self.MapFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのResultの各要素を展開して関数に渡すIterFailureです。
        /// </summary>
        public static void IterFailure<T1, T2, T3, T4, T5, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5>> self, Action<T1, T2, T3, T4, T5> f)
        {
            self.IterFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのResultの各要素を展開して関数に渡すBindFailureです。
        /// </summary>
        public static Result<TSuccess, U> BindFailure<T1, T2, T3, T4, T5, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, Result<TSuccess, U>> f)
        {
            return self.BindFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }
        #endregion

        #region 6要素タプルを扱うFailure側の関数

        /// <summary>
        /// 6要素タプルのResultの各要素を展開して関数に渡すSafeCastFailureです。
        /// </summary>
        public static Result<TSuccess, TFailure2> SafeCastFailure<T1, T2, T3, T4, T5, T6, TSuccess, TFailure2>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, TFailure2> f)
        {
            return self.SafeCastFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのResultの各要素を展開して関数に渡すCountFailureです。
        /// </summary>
        public static int CountFailure<T1, T2, T3, T4, T5, T6, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, bool> f)
        {
            return self.CountFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのResultの各要素を展開して関数に渡すFoldFailureです。
        /// </summary>
        public static U FoldFailure<T1, T2, T3, T4, T5, T6, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, U> f)
        {
            return self.FoldFailure(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのResultの各要素を展開して関数に渡すForallFailureです。
        /// </summary>
        public static bool ForallFailure<T1, T2, T3, T4, T5, T6, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, bool> f)
        {
            return self.ForallFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのResultの各要素を展開して関数に渡すExistsFailureです。
        /// </summary>
        public static bool ExistsFailure<T1, T2, T3, T4, T5, T6, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, bool> f)
        {
            return self.ExistsFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのResultの各要素を展開して関数に渡すMapFailureです。
        /// </summary>
        public static Result<TSuccess, U> MapFailure<T1, T2, T3, T4, T5, T6, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, U> f)
        {
            return self.MapFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのResultの各要素を展開して関数に渡すIterFailureです。
        /// </summary>
        public static void IterFailure<T1, T2, T3, T4, T5, T6, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6>> self, Action<T1, T2, T3, T4, T5, T6> f)
        {
            self.IterFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのResultの各要素を展開して関数に渡すBindFailureです。
        /// </summary>
        public static Result<TSuccess, U> BindFailure<T1, T2, T3, T4, T5, T6, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, Result<TSuccess, U>> f)
        {
            return self.BindFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }
        #endregion

        #region 7要素タプルを扱うFailure側の関数

        /// <summary>
        /// 7要素タプルのResultの各要素を展開して関数に渡すSafeCastFailureです。
        /// </summary>
        public static Result<TSuccess, TFailure2> SafeCastFailure<T1, T2, T3, T4, T5, T6, T7, TSuccess, TFailure2>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, TFailure2> f)
        {
            return self.SafeCastFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのResultの各要素を展開して関数に渡すCountFailureです。
        /// </summary>
        public static int CountFailure<T1, T2, T3, T4, T5, T6, T7, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, bool> f)
        {
            return self.CountFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのResultの各要素を展開して関数に渡すFoldFailureです。
        /// </summary>
        public static U FoldFailure<T1, T2, T3, T4, T5, T6, T7, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, U> f)
        {
            return self.FoldFailure(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのResultの各要素を展開して関数に渡すForallFailureです。
        /// </summary>
        public static bool ForallFailure<T1, T2, T3, T4, T5, T6, T7, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, bool> f)
        {
            return self.ForallFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのResultの各要素を展開して関数に渡すExistsFailureです。
        /// </summary>
        public static bool ExistsFailure<T1, T2, T3, T4, T5, T6, T7, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, bool> f)
        {
            return self.ExistsFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのResultの各要素を展開して関数に渡すMapFailureです。
        /// </summary>
        public static Result<TSuccess, U> MapFailure<T1, T2, T3, T4, T5, T6, T7, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, U> f)
        {
            return self.MapFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのResultの各要素を展開して関数に渡すIterFailureです。
        /// </summary>
        public static void IterFailure<T1, T2, T3, T4, T5, T6, T7, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Action<T1, T2, T3, T4, T5, T6, T7> f)
        {
            self.IterFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのResultの各要素を展開して関数に渡すBindFailureです。
        /// </summary>
        public static Result<TSuccess, U> BindFailure<T1, T2, T3, T4, T5, T6, T7, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, Result<TSuccess, U>> f)
        {
            return self.BindFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }
        #endregion

        #region 8要素タプルを扱うFailure側の関数

        /// <summary>
        /// 8要素タプルのResultの各要素を展開して関数に渡すSafeCastFailureです。
        /// </summary>
        public static Result<TSuccess, TFailure2> SafeCastFailure<T1, T2, T3, T4, T5, T6, T7, T8, TSuccess, TFailure2>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, TFailure2> f)
        {
            return self.SafeCastFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのResultの各要素を展開して関数に渡すCountFailureです。
        /// </summary>
        public static int CountFailure<T1, T2, T3, T4, T5, T6, T7, T8, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> f)
        {
            return self.CountFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのResultの各要素を展開して関数に渡すFoldFailureです。
        /// </summary>
        public static U FoldFailure<T1, T2, T3, T4, T5, T6, T7, T8, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, U> f)
        {
            return self.FoldFailure(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのResultの各要素を展開して関数に渡すForallFailureです。
        /// </summary>
        public static bool ForallFailure<T1, T2, T3, T4, T5, T6, T7, T8, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> f)
        {
            return self.ForallFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのResultの各要素を展開して関数に渡すExistsFailureです。
        /// </summary>
        public static bool ExistsFailure<T1, T2, T3, T4, T5, T6, T7, T8, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> f)
        {
            return self.ExistsFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのResultの各要素を展開して関数に渡すMapFailureです。
        /// </summary>
        public static Result<TSuccess, U> MapFailure<T1, T2, T3, T4, T5, T6, T7, T8, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, U> f)
        {
            return self.MapFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのResultの各要素を展開して関数に渡すIterFailureです。
        /// </summary>
        public static void IterFailure<T1, T2, T3, T4, T5, T6, T7, T8, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8> f)
        {
            self.IterFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのResultの各要素を展開して関数に渡すBindFailureです。
        /// </summary>
        public static Result<TSuccess, U> BindFailure<T1, T2, T3, T4, T5, T6, T7, T8, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, Result<TSuccess, U>> f)
        {
            return self.BindFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }
        #endregion

        #region 9要素タプルを扱うFailure側の関数

        /// <summary>
        /// 9要素タプルのResultの各要素を展開して関数に渡すSafeCastFailureです。
        /// </summary>
        public static Result<TSuccess, TFailure2> SafeCastFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, TSuccess, TFailure2>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TFailure2> f)
        {
            return self.SafeCastFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのResultの各要素を展開して関数に渡すCountFailureです。
        /// </summary>
        public static int CountFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> f)
        {
            return self.CountFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのResultの各要素を展開して関数に渡すFoldFailureです。
        /// </summary>
        public static U FoldFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, U> f)
        {
            return self.FoldFailure(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのResultの各要素を展開して関数に渡すForallFailureです。
        /// </summary>
        public static bool ForallFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> f)
        {
            return self.ForallFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのResultの各要素を展開して関数に渡すExistsFailureです。
        /// </summary>
        public static bool ExistsFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> f)
        {
            return self.ExistsFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのResultの各要素を展開して関数に渡すMapFailureです。
        /// </summary>
        public static Result<TSuccess, U> MapFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> f)
        {
            return self.MapFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのResultの各要素を展開して関数に渡すIterFailureです。
        /// </summary>
        public static void IterFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> f)
        {
            self.IterFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのResultの各要素を展開して関数に渡すBindFailureです。
        /// </summary>
        public static Result<TSuccess, U> BindFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Result<TSuccess, U>> f)
        {
            return self.BindFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }
        #endregion

        #region 10要素タプルを扱うFailure側の関数

        /// <summary>
        /// 10要素タプルのResultの各要素を展開して関数に渡すSafeCastFailureです。
        /// </summary>
        public static Result<TSuccess, TFailure2> SafeCastFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TSuccess, TFailure2>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TFailure2> f)
        {
            return self.SafeCastFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのResultの各要素を展開して関数に渡すCountFailureです。
        /// </summary>
        public static int CountFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> f)
        {
            return self.CountFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのResultの各要素を展開して関数に渡すFoldFailureです。
        /// </summary>
        public static U FoldFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> f)
        {
            return self.FoldFailure(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのResultの各要素を展開して関数に渡すForallFailureです。
        /// </summary>
        public static bool ForallFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> f)
        {
            return self.ForallFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのResultの各要素を展開して関数に渡すExistsFailureです。
        /// </summary>
        public static bool ExistsFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> f)
        {
            return self.ExistsFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのResultの各要素を展開して関数に渡すMapFailureです。
        /// </summary>
        public static Result<TSuccess, U> MapFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> f)
        {
            return self.MapFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのResultの各要素を展開して関数に渡すIterFailureです。
        /// </summary>
        public static void IterFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> f)
        {
            self.IterFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのResultの各要素を展開して関数に渡すBindFailureです。
        /// </summary>
        public static Result<TSuccess, U> BindFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Result<TSuccess, U>> f)
        {
            return self.BindFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }
        #endregion

        #region 11要素タプルを扱うFailure側の関数

        /// <summary>
        /// 11要素タプルのResultの各要素を展開して関数に渡すSafeCastFailureです。
        /// </summary>
        public static Result<TSuccess, TFailure2> SafeCastFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TSuccess, TFailure2>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TFailure2> f)
        {
            return self.SafeCastFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのResultの各要素を展開して関数に渡すCountFailureです。
        /// </summary>
        public static int CountFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> f)
        {
            return self.CountFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのResultの各要素を展開して関数に渡すFoldFailureです。
        /// </summary>
        public static U FoldFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> f)
        {
            return self.FoldFailure(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのResultの各要素を展開して関数に渡すForallFailureです。
        /// </summary>
        public static bool ForallFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> f)
        {
            return self.ForallFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのResultの各要素を展開して関数に渡すExistsFailureです。
        /// </summary>
        public static bool ExistsFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> f)
        {
            return self.ExistsFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのResultの各要素を展開して関数に渡すMapFailureです。
        /// </summary>
        public static Result<TSuccess, U> MapFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> f)
        {
            return self.MapFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのResultの各要素を展開して関数に渡すIterFailureです。
        /// </summary>
        public static void IterFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> f)
        {
            self.IterFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのResultの各要素を展開して関数に渡すBindFailureです。
        /// </summary>
        public static Result<TSuccess, U> BindFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Result<TSuccess, U>> f)
        {
            return self.BindFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }
        #endregion

        #region 12要素タプルを扱うFailure側の関数

        /// <summary>
        /// 12要素タプルのResultの各要素を展開して関数に渡すSafeCastFailureです。
        /// </summary>
        public static Result<TSuccess, TFailure2> SafeCastFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TSuccess, TFailure2>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TFailure2> f)
        {
            return self.SafeCastFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのResultの各要素を展開して関数に渡すCountFailureです。
        /// </summary>
        public static int CountFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> f)
        {
            return self.CountFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのResultの各要素を展開して関数に渡すFoldFailureです。
        /// </summary>
        public static U FoldFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> f)
        {
            return self.FoldFailure(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのResultの各要素を展開して関数に渡すForallFailureです。
        /// </summary>
        public static bool ForallFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> f)
        {
            return self.ForallFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのResultの各要素を展開して関数に渡すExistsFailureです。
        /// </summary>
        public static bool ExistsFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> f)
        {
            return self.ExistsFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのResultの各要素を展開して関数に渡すMapFailureです。
        /// </summary>
        public static Result<TSuccess, U> MapFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> f)
        {
            return self.MapFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのResultの各要素を展開して関数に渡すIterFailureです。
        /// </summary>
        public static void IterFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> f)
        {
            self.IterFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのResultの各要素を展開して関数に渡すBindFailureです。
        /// </summary>
        public static Result<TSuccess, U> BindFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Result<TSuccess, U>> f)
        {
            return self.BindFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }
        #endregion

        #region 13要素タプルを扱うFailure側の関数

        /// <summary>
        /// 13要素タプルのResultの各要素を展開して関数に渡すSafeCastFailureです。
        /// </summary>
        public static Result<TSuccess, TFailure2> SafeCastFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TSuccess, TFailure2>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TFailure2> f)
        {
            return self.SafeCastFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのResultの各要素を展開して関数に渡すCountFailureです。
        /// </summary>
        public static int CountFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> f)
        {
            return self.CountFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのResultの各要素を展開して関数に渡すFoldFailureです。
        /// </summary>
        public static U FoldFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> f)
        {
            return self.FoldFailure(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのResultの各要素を展開して関数に渡すForallFailureです。
        /// </summary>
        public static bool ForallFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> f)
        {
            return self.ForallFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのResultの各要素を展開して関数に渡すExistsFailureです。
        /// </summary>
        public static bool ExistsFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> f)
        {
            return self.ExistsFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのResultの各要素を展開して関数に渡すMapFailureです。
        /// </summary>
        public static Result<TSuccess, U> MapFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> f)
        {
            return self.MapFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのResultの各要素を展開して関数に渡すIterFailureです。
        /// </summary>
        public static void IterFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> f)
        {
            self.IterFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのResultの各要素を展開して関数に渡すBindFailureです。
        /// </summary>
        public static Result<TSuccess, U> BindFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Result<TSuccess, U>> f)
        {
            return self.BindFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }
        #endregion

        #region 14要素タプルを扱うFailure側の関数

        /// <summary>
        /// 14要素タプルのResultの各要素を展開して関数に渡すSafeCastFailureです。
        /// </summary>
        public static Result<TSuccess, TFailure2> SafeCastFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TSuccess, TFailure2>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TFailure2> f)
        {
            return self.SafeCastFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのResultの各要素を展開して関数に渡すCountFailureです。
        /// </summary>
        public static int CountFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> f)
        {
            return self.CountFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのResultの各要素を展開して関数に渡すFoldFailureです。
        /// </summary>
        public static U FoldFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> f)
        {
            return self.FoldFailure(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのResultの各要素を展開して関数に渡すForallFailureです。
        /// </summary>
        public static bool ForallFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> f)
        {
            return self.ForallFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのResultの各要素を展開して関数に渡すExistsFailureです。
        /// </summary>
        public static bool ExistsFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> f)
        {
            return self.ExistsFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのResultの各要素を展開して関数に渡すMapFailureです。
        /// </summary>
        public static Result<TSuccess, U> MapFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> f)
        {
            return self.MapFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのResultの各要素を展開して関数に渡すIterFailureです。
        /// </summary>
        public static void IterFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> f)
        {
            self.IterFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのResultの各要素を展開して関数に渡すBindFailureです。
        /// </summary>
        public static Result<TSuccess, U> BindFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Result<TSuccess, U>> f)
        {
            return self.BindFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }
        #endregion

        #region 15要素タプルを扱うFailure側の関数

        /// <summary>
        /// 15要素タプルのResultの各要素を展開して関数に渡すSafeCastFailureです。
        /// </summary>
        public static Result<TSuccess, TFailure2> SafeCastFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TSuccess, TFailure2>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TFailure2> f)
        {
            return self.SafeCastFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのResultの各要素を展開して関数に渡すCountFailureです。
        /// </summary>
        public static int CountFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> f)
        {
            return self.CountFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのResultの各要素を展開して関数に渡すFoldFailureです。
        /// </summary>
        public static U FoldFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> f)
        {
            return self.FoldFailure(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのResultの各要素を展開して関数に渡すForallFailureです。
        /// </summary>
        public static bool ForallFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> f)
        {
            return self.ForallFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのResultの各要素を展開して関数に渡すExistsFailureです。
        /// </summary>
        public static bool ExistsFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> f)
        {
            return self.ExistsFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのResultの各要素を展開して関数に渡すMapFailureです。
        /// </summary>
        public static Result<TSuccess, U> MapFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> f)
        {
            return self.MapFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのResultの各要素を展開して関数に渡すIterFailureです。
        /// </summary>
        public static void IterFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> f)
        {
            self.IterFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのResultの各要素を展開して関数に渡すBindFailureです。
        /// </summary>
        public static Result<TSuccess, U> BindFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Result<TSuccess, U>> f)
        {
            return self.BindFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }
        #endregion

        #region 16要素タプルを扱うFailure側の関数

        /// <summary>
        /// 16要素タプルのResultの各要素を展開して関数に渡すSafeCastFailureです。
        /// </summary>
        public static Result<TSuccess, TFailure2> SafeCastFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TSuccess, TFailure2>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TFailure2> f)
        {
            return self.SafeCastFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのResultの各要素を展開して関数に渡すCountFailureです。
        /// </summary>
        public static int CountFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> f)
        {
            return self.CountFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのResultの各要素を展開して関数に渡すForallFailureです。
        /// </summary>
        public static bool ForallFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> f)
        {
            return self.ForallFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのResultの各要素を展開して関数に渡すExistsFailureです。
        /// </summary>
        public static bool ExistsFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> f)
        {
            return self.ExistsFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのResultの各要素を展開して関数に渡すMapFailureです。
        /// </summary>
        public static Result<TSuccess, U> MapFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> f)
        {
            return self.MapFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのResultの各要素を展開して関数に渡すIterFailureです。
        /// </summary>
        public static void IterFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TSuccess>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> f)
        {
            self.IterFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのResultの各要素を展開して関数に渡すBindFailureです。
        /// </summary>
        public static Result<TSuccess, U> BindFailure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TSuccess, U>(this Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Result<TSuccess, U>> f)
        {
            return self.BindFailure(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }
        #endregion

    }
}