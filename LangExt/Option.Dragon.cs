

using System;
using System.Collections.Generic;

namespace LangExt
{
    partial class Option
    {
        #region 2要素タプルを扱う関数

        /// <summary>
        /// 2要素タプルのOptionの各要素を展開して関数に渡すMatchです。
        /// </summary>
        public static U Match<T1, T2, U>(this Option<Tuple<T1, T2>> self, Func<T1, T2, U> Some, Func<U> None)
        {
            return self.Match(tpl => Some(tpl._1(), tpl._2()), None);
        }

        /// <summary>
        /// 2要素タプルのOptionの各要素を展開して関数に渡すMatchです。
        /// </summary>
        public static void Match<T1, T2>(this Option<Tuple<T1, T2>> self, Action<T1, T2> Some, Action None)
        {
            self.Match(tpl => Some(tpl._1(), tpl._2()), None);
        }

        /// <summary>
        /// 2要素タプルのOptionの各要素を展開して関数に渡すMaybeです。
        /// </summary>
        public static U Maybe<T1, T2, U>(this Option<Tuple<T1, T2>> self, U defaultValue, Func<T1, T2, U> f)
        {
            return self.Maybe(defaultValue, tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのOptionの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2>(this Option<Tuple<T1, T2>> self, Func<T1, T2, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのOptionの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, U>(this Option<Tuple<T1, T2>> self, U init, Func<U, T1, T2, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのOptionの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2>(this Option<Tuple<T1, T2>> self, Func<T1, T2, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのOptionの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2>(this Option<Tuple<T1, T2>> self, Func<T1, T2, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのOptionの各要素を展開して関数に渡すFilterです。
        /// </summary>
        public static Option<Tuple<T1, T2>> Filter<T1, T2>(this Option<Tuple<T1, T2>> self, Func<T1, T2, bool> f)
        {
            return self.Filter(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのOptionの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static Option<U> Map<T1, T2, U>(this Option<Tuple<T1, T2>> self, Func<T1, T2, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのOptionの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2>(this Option<Tuple<T1, T2>> self, Action<T1, T2> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2()));
        }

        /// <summary>
        /// 2要素タプルのOptionの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static Option<U> Bind<T1, T2, U>(this Option<Tuple<T1, T2>> self, Func<T1, T2, Option<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2()));
        }
        #endregion

        #region 3要素タプルを扱う関数

        /// <summary>
        /// 3要素タプルのOptionの各要素を展開して関数に渡すMatchです。
        /// </summary>
        public static U Match<T1, T2, T3, U>(this Option<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, U> Some, Func<U> None)
        {
            return self.Match(tpl => Some(tpl._1(), tpl._2(), tpl._3()), None);
        }

        /// <summary>
        /// 3要素タプルのOptionの各要素を展開して関数に渡すMatchです。
        /// </summary>
        public static void Match<T1, T2, T3>(this Option<Tuple<T1, T2, T3>> self, Action<T1, T2, T3> Some, Action None)
        {
            self.Match(tpl => Some(tpl._1(), tpl._2(), tpl._3()), None);
        }

        /// <summary>
        /// 3要素タプルのOptionの各要素を展開して関数に渡すMaybeです。
        /// </summary>
        public static U Maybe<T1, T2, T3, U>(this Option<Tuple<T1, T2, T3>> self, U defaultValue, Func<T1, T2, T3, U> f)
        {
            return self.Maybe(defaultValue, tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのOptionの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3>(this Option<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのOptionの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, U>(this Option<Tuple<T1, T2, T3>> self, U init, Func<U, T1, T2, T3, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのOptionの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3>(this Option<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのOptionの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3>(this Option<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのOptionの各要素を展開して関数に渡すFilterです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3>> Filter<T1, T2, T3>(this Option<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, bool> f)
        {
            return self.Filter(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのOptionの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static Option<U> Map<T1, T2, T3, U>(this Option<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのOptionの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3>(this Option<Tuple<T1, T2, T3>> self, Action<T1, T2, T3> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }

        /// <summary>
        /// 3要素タプルのOptionの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static Option<U> Bind<T1, T2, T3, U>(this Option<Tuple<T1, T2, T3>> self, Func<T1, T2, T3, Option<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3()));
        }
        #endregion

        #region 4要素タプルを扱う関数

        /// <summary>
        /// 4要素タプルのOptionの各要素を展開して関数に渡すMatchです。
        /// </summary>
        public static U Match<T1, T2, T3, T4, U>(this Option<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, U> Some, Func<U> None)
        {
            return self.Match(tpl => Some(tpl._1(), tpl._2(), tpl._3(), tpl._4()), None);
        }

        /// <summary>
        /// 4要素タプルのOptionの各要素を展開して関数に渡すMatchです。
        /// </summary>
        public static void Match<T1, T2, T3, T4>(this Option<Tuple<T1, T2, T3, T4>> self, Action<T1, T2, T3, T4> Some, Action None)
        {
            self.Match(tpl => Some(tpl._1(), tpl._2(), tpl._3(), tpl._4()), None);
        }

        /// <summary>
        /// 4要素タプルのOptionの各要素を展開して関数に渡すMaybeです。
        /// </summary>
        public static U Maybe<T1, T2, T3, T4, U>(this Option<Tuple<T1, T2, T3, T4>> self, U defaultValue, Func<T1, T2, T3, T4, U> f)
        {
            return self.Maybe(defaultValue, tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのOptionの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4>(this Option<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのOptionの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, U>(this Option<Tuple<T1, T2, T3, T4>> self, U init, Func<U, T1, T2, T3, T4, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのOptionの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4>(this Option<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのOptionの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4>(this Option<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのOptionの各要素を展開して関数に渡すFilterです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4>> Filter<T1, T2, T3, T4>(this Option<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, bool> f)
        {
            return self.Filter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのOptionの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static Option<U> Map<T1, T2, T3, T4, U>(this Option<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのOptionの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4>(this Option<Tuple<T1, T2, T3, T4>> self, Action<T1, T2, T3, T4> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }

        /// <summary>
        /// 4要素タプルのOptionの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static Option<U> Bind<T1, T2, T3, T4, U>(this Option<Tuple<T1, T2, T3, T4>> self, Func<T1, T2, T3, T4, Option<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4()));
        }
        #endregion

        #region 5要素タプルを扱う関数

        /// <summary>
        /// 5要素タプルのOptionの各要素を展開して関数に渡すMatchです。
        /// </summary>
        public static U Match<T1, T2, T3, T4, T5, U>(this Option<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, U> Some, Func<U> None)
        {
            return self.Match(tpl => Some(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()), None);
        }

        /// <summary>
        /// 5要素タプルのOptionの各要素を展開して関数に渡すMatchです。
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5>(this Option<Tuple<T1, T2, T3, T4, T5>> self, Action<T1, T2, T3, T4, T5> Some, Action None)
        {
            self.Match(tpl => Some(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()), None);
        }

        /// <summary>
        /// 5要素タプルのOptionの各要素を展開して関数に渡すMaybeです。
        /// </summary>
        public static U Maybe<T1, T2, T3, T4, T5, U>(this Option<Tuple<T1, T2, T3, T4, T5>> self, U defaultValue, Func<T1, T2, T3, T4, T5, U> f)
        {
            return self.Maybe(defaultValue, tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのOptionの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5>(this Option<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのOptionの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, T5, U>(this Option<Tuple<T1, T2, T3, T4, T5>> self, U init, Func<U, T1, T2, T3, T4, T5, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのOptionの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5>(this Option<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのOptionの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5>(this Option<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのOptionの各要素を展開して関数に渡すFilterです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5>> Filter<T1, T2, T3, T4, T5>(this Option<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, bool> f)
        {
            return self.Filter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのOptionの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static Option<U> Map<T1, T2, T3, T4, T5, U>(this Option<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのOptionの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5>(this Option<Tuple<T1, T2, T3, T4, T5>> self, Action<T1, T2, T3, T4, T5> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }

        /// <summary>
        /// 5要素タプルのOptionの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static Option<U> Bind<T1, T2, T3, T4, T5, U>(this Option<Tuple<T1, T2, T3, T4, T5>> self, Func<T1, T2, T3, T4, T5, Option<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5()));
        }
        #endregion

        #region 6要素タプルを扱う関数

        /// <summary>
        /// 6要素タプルのOptionの各要素を展開して関数に渡すMatchです。
        /// </summary>
        public static U Match<T1, T2, T3, T4, T5, T6, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, U> Some, Func<U> None)
        {
            return self.Match(tpl => Some(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()), None);
        }

        /// <summary>
        /// 6要素タプルのOptionの各要素を展開して関数に渡すMatchです。
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5, T6>(this Option<Tuple<T1, T2, T3, T4, T5, T6>> self, Action<T1, T2, T3, T4, T5, T6> Some, Action None)
        {
            self.Match(tpl => Some(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()), None);
        }

        /// <summary>
        /// 6要素タプルのOptionの各要素を展開して関数に渡すMaybeです。
        /// </summary>
        public static U Maybe<T1, T2, T3, T4, T5, T6, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6>> self, U defaultValue, Func<T1, T2, T3, T4, T5, T6, U> f)
        {
            return self.Maybe(defaultValue, tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのOptionの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5, T6>(this Option<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのOptionの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, T5, T6, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのOptionの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5, T6>(this Option<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのOptionの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5, T6>(this Option<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのOptionの各要素を展開して関数に渡すFilterです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6>> Filter<T1, T2, T3, T4, T5, T6>(this Option<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, bool> f)
        {
            return self.Filter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのOptionの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static Option<U> Map<T1, T2, T3, T4, T5, T6, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのOptionの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5, T6>(this Option<Tuple<T1, T2, T3, T4, T5, T6>> self, Action<T1, T2, T3, T4, T5, T6> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }

        /// <summary>
        /// 6要素タプルのOptionの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static Option<U> Bind<T1, T2, T3, T4, T5, T6, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6>> self, Func<T1, T2, T3, T4, T5, T6, Option<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6()));
        }
        #endregion

        #region 7要素タプルを扱う関数

        /// <summary>
        /// 7要素タプルのOptionの各要素を展開して関数に渡すMatchです。
        /// </summary>
        public static U Match<T1, T2, T3, T4, T5, T6, T7, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, U> Some, Func<U> None)
        {
            return self.Match(tpl => Some(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()), None);
        }

        /// <summary>
        /// 7要素タプルのOptionの各要素を展開して関数に渡すMatchです。
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5, T6, T7>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Action<T1, T2, T3, T4, T5, T6, T7> Some, Action None)
        {
            self.Match(tpl => Some(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()), None);
        }

        /// <summary>
        /// 7要素タプルのOptionの各要素を展開して関数に渡すMaybeです。
        /// </summary>
        public static U Maybe<T1, T2, T3, T4, T5, T6, T7, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, U defaultValue, Func<T1, T2, T3, T4, T5, T6, T7, U> f)
        {
            return self.Maybe(defaultValue, tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのOptionの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5, T6, T7>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのOptionの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, T5, T6, T7, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのOptionの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5, T6, T7>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのOptionの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5, T6, T7>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのOptionの各要素を展開して関数に渡すFilterです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7>> Filter<T1, T2, T3, T4, T5, T6, T7>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, bool> f)
        {
            return self.Filter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのOptionの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static Option<U> Map<T1, T2, T3, T4, T5, T6, T7, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのOptionの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5, T6, T7>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Action<T1, T2, T3, T4, T5, T6, T7> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }

        /// <summary>
        /// 7要素タプルのOptionの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static Option<U> Bind<T1, T2, T3, T4, T5, T6, T7, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T2, T3, T4, T5, T6, T7, Option<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7()));
        }
        #endregion

        #region 8要素タプルを扱う関数

        /// <summary>
        /// 8要素タプルのOptionの各要素を展開して関数に渡すMatchです。
        /// </summary>
        public static U Match<T1, T2, T3, T4, T5, T6, T7, T8, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, U> Some, Func<U> None)
        {
            return self.Match(tpl => Some(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()), None);
        }

        /// <summary>
        /// 8要素タプルのOptionの各要素を展開して関数に渡すMatchです。
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5, T6, T7, T8>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8> Some, Action None)
        {
            self.Match(tpl => Some(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()), None);
        }

        /// <summary>
        /// 8要素タプルのOptionの各要素を展開して関数に渡すMaybeです。
        /// </summary>
        public static U Maybe<T1, T2, T3, T4, T5, T6, T7, T8, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, U defaultValue, Func<T1, T2, T3, T4, T5, T6, T7, T8, U> f)
        {
            return self.Maybe(defaultValue, tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのOptionの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5, T6, T7, T8>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのOptionの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, T5, T6, T7, T8, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのOptionの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5, T6, T7, T8>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのOptionの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5, T6, T7, T8>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのOptionの各要素を展開して関数に渡すFilterです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> Filter<T1, T2, T3, T4, T5, T6, T7, T8>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> f)
        {
            return self.Filter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのOptionの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static Option<U> Map<T1, T2, T3, T4, T5, T6, T7, T8, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのOptionの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5, T6, T7, T8>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }

        /// <summary>
        /// 8要素タプルのOptionの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static Option<U> Bind<T1, T2, T3, T4, T5, T6, T7, T8, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, Option<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8()));
        }
        #endregion

        #region 9要素タプルを扱う関数

        /// <summary>
        /// 9要素タプルのOptionの各要素を展開して関数に渡すMatchです。
        /// </summary>
        public static U Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> Some, Func<U> None)
        {
            return self.Match(tpl => Some(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()), None);
        }

        /// <summary>
        /// 9要素タプルのOptionの各要素を展開して関数に渡すMatchです。
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> Some, Action None)
        {
            self.Match(tpl => Some(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()), None);
        }

        /// <summary>
        /// 9要素タプルのOptionの各要素を展開して関数に渡すMaybeです。
        /// </summary>
        public static U Maybe<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, U defaultValue, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> f)
        {
            return self.Maybe(defaultValue, tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのOptionの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのOptionの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのOptionの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのOptionの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのOptionの各要素を展開して関数に渡すFilterです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> Filter<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> f)
        {
            return self.Filter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのOptionの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static Option<U> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのOptionの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }

        /// <summary>
        /// 9要素タプルのOptionの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static Option<U> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Option<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9()));
        }
        #endregion

        #region 10要素タプルを扱う関数

        /// <summary>
        /// 10要素タプルのOptionの各要素を展開して関数に渡すMatchです。
        /// </summary>
        public static U Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> Some, Func<U> None)
        {
            return self.Match(tpl => Some(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()), None);
        }

        /// <summary>
        /// 10要素タプルのOptionの各要素を展開して関数に渡すMatchです。
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Some, Action None)
        {
            self.Match(tpl => Some(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()), None);
        }

        /// <summary>
        /// 10要素タプルのOptionの各要素を展開して関数に渡すMaybeです。
        /// </summary>
        public static U Maybe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, U defaultValue, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> f)
        {
            return self.Maybe(defaultValue, tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのOptionの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのOptionの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのOptionの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのOptionの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのOptionの各要素を展開して関数に渡すFilterです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> Filter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> f)
        {
            return self.Filter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのOptionの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static Option<U> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのOptionの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }

        /// <summary>
        /// 10要素タプルのOptionの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static Option<U> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Option<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10()));
        }
        #endregion

        #region 11要素タプルを扱う関数

        /// <summary>
        /// 11要素タプルのOptionの各要素を展開して関数に渡すMatchです。
        /// </summary>
        public static U Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> Some, Func<U> None)
        {
            return self.Match(tpl => Some(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()), None);
        }

        /// <summary>
        /// 11要素タプルのOptionの各要素を展開して関数に渡すMatchです。
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Some, Action None)
        {
            self.Match(tpl => Some(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()), None);
        }

        /// <summary>
        /// 11要素タプルのOptionの各要素を展開して関数に渡すMaybeです。
        /// </summary>
        public static U Maybe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, U defaultValue, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> f)
        {
            return self.Maybe(defaultValue, tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのOptionの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのOptionの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのOptionの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのOptionの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのOptionの各要素を展開して関数に渡すFilterです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> Filter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> f)
        {
            return self.Filter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのOptionの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static Option<U> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのOptionの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }

        /// <summary>
        /// 11要素タプルのOptionの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static Option<U> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Option<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11()));
        }
        #endregion

        #region 12要素タプルを扱う関数

        /// <summary>
        /// 12要素タプルのOptionの各要素を展開して関数に渡すMatchです。
        /// </summary>
        public static U Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> Some, Func<U> None)
        {
            return self.Match(tpl => Some(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()), None);
        }

        /// <summary>
        /// 12要素タプルのOptionの各要素を展開して関数に渡すMatchです。
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Some, Action None)
        {
            self.Match(tpl => Some(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()), None);
        }

        /// <summary>
        /// 12要素タプルのOptionの各要素を展開して関数に渡すMaybeです。
        /// </summary>
        public static U Maybe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, U defaultValue, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> f)
        {
            return self.Maybe(defaultValue, tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのOptionの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのOptionの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのOptionの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのOptionの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのOptionの各要素を展開して関数に渡すFilterです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> Filter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> f)
        {
            return self.Filter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのOptionの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static Option<U> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのOptionの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }

        /// <summary>
        /// 12要素タプルのOptionの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static Option<U> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Option<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12()));
        }
        #endregion

        #region 13要素タプルを扱う関数

        /// <summary>
        /// 13要素タプルのOptionの各要素を展開して関数に渡すMatchです。
        /// </summary>
        public static U Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> Some, Func<U> None)
        {
            return self.Match(tpl => Some(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()), None);
        }

        /// <summary>
        /// 13要素タプルのOptionの各要素を展開して関数に渡すMatchです。
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Some, Action None)
        {
            self.Match(tpl => Some(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()), None);
        }

        /// <summary>
        /// 13要素タプルのOptionの各要素を展開して関数に渡すMaybeです。
        /// </summary>
        public static U Maybe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, U defaultValue, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> f)
        {
            return self.Maybe(defaultValue, tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのOptionの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのOptionの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのOptionの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのOptionの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのOptionの各要素を展開して関数に渡すFilterです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> Filter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> f)
        {
            return self.Filter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのOptionの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static Option<U> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのOptionの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }

        /// <summary>
        /// 13要素タプルのOptionの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static Option<U> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Option<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13()));
        }
        #endregion

        #region 14要素タプルを扱う関数

        /// <summary>
        /// 14要素タプルのOptionの各要素を展開して関数に渡すMatchです。
        /// </summary>
        public static U Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> Some, Func<U> None)
        {
            return self.Match(tpl => Some(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()), None);
        }

        /// <summary>
        /// 14要素タプルのOptionの各要素を展開して関数に渡すMatchです。
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Some, Action None)
        {
            self.Match(tpl => Some(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()), None);
        }

        /// <summary>
        /// 14要素タプルのOptionの各要素を展開して関数に渡すMaybeです。
        /// </summary>
        public static U Maybe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, U defaultValue, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> f)
        {
            return self.Maybe(defaultValue, tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのOptionの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのOptionの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのOptionの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのOptionの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのOptionの各要素を展開して関数に渡すFilterです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> Filter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> f)
        {
            return self.Filter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのOptionの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static Option<U> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのOptionの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }

        /// <summary>
        /// 14要素タプルのOptionの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static Option<U> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Option<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14()));
        }
        #endregion

        #region 15要素タプルを扱う関数

        /// <summary>
        /// 15要素タプルのOptionの各要素を展開して関数に渡すMatchです。
        /// </summary>
        public static U Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> Some, Func<U> None)
        {
            return self.Match(tpl => Some(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()), None);
        }

        /// <summary>
        /// 15要素タプルのOptionの各要素を展開して関数に渡すMatchです。
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Some, Action None)
        {
            self.Match(tpl => Some(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()), None);
        }

        /// <summary>
        /// 15要素タプルのOptionの各要素を展開して関数に渡すMaybeです。
        /// </summary>
        public static U Maybe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, U defaultValue, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> f)
        {
            return self.Maybe(defaultValue, tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのOptionの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのOptionの各要素を展開して関数に渡すFoldです。
        /// </summary>
        public static U Fold<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, U init, Func<U, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> f)
        {
            return self.Fold(init, (acc, tpl) => f(acc, tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのOptionの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのOptionの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのOptionの各要素を展開して関数に渡すFilterです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> Filter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> f)
        {
            return self.Filter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのOptionの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static Option<U> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのOptionの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }

        /// <summary>
        /// 15要素タプルのOptionの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static Option<U> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Option<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15()));
        }
        #endregion

        #region 16要素タプルを扱う関数

        /// <summary>
        /// 16要素タプルのOptionの各要素を展開して関数に渡すMatchです。
        /// </summary>
        public static U Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> Some, Func<U> None)
        {
            return self.Match(tpl => Some(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()), None);
        }

        /// <summary>
        /// 16要素タプルのOptionの各要素を展開して関数に渡すMatchです。
        /// </summary>
        public static void Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Some, Action None)
        {
            self.Match(tpl => Some(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()), None);
        }

        /// <summary>
        /// 16要素タプルのOptionの各要素を展開して関数に渡すMaybeです。
        /// </summary>
        public static U Maybe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, U defaultValue, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> f)
        {
            return self.Maybe(defaultValue, tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのOptionの各要素を展開して関数に渡すCountです。
        /// </summary>
        public static int Count<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> f)
        {
            return self.Count(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのOptionの各要素を展開して関数に渡すForallです。
        /// </summary>
        public static bool Forall<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> f)
        {
            return self.Forall(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのOptionの各要素を展開して関数に渡すExistsです。
        /// </summary>
        public static bool Exists<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> f)
        {
            return self.Exists(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのOptionの各要素を展開して関数に渡すFilterです。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> Filter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> f)
        {
            return self.Filter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのOptionの各要素を展開して関数に渡すMapです。
        /// </summary>
        public static Option<U> Map<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> f)
        {
            return self.Map(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのOptionの各要素を展開して関数に渡すIterです。
        /// </summary>
        public static void Iter<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> f)
        {
            self.Iter(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }

        /// <summary>
        /// 16要素タプルのOptionの各要素を展開して関数に渡すBindです。
        /// </summary>
        public static Option<U> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Option<U>> f)
        {
            return self.Bind(tpl => f(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16()));
        }
        #endregion

    }
}