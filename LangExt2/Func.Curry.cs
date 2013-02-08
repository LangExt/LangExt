
using System;

namespace LangExt2
{
    partial class Func
    {
        /// <summary>2つの引数を受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, U>> Curried<T1, T2, U>(this Func<T1, T2, U> self)
        {
            return t1 => t2 => self(t1, t2);
        }

        /// <summary>2つの引数を受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, U>> Curry<T1, T2, U>(Func<T1, T2, U> self)
        {
            return t1 => t2 => self(t1, t2);
        }

        /// <summary>2要素のタプルを受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, U>> CurriedX<T1, T2, U>(this Func<Tuple<T1, T2>, U> self)
        {
            return t1 => t2 => self(Create.Tuple(t1, t2));
        }

        /// <summary>2要素のタプルを受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, U>> CurryX<T1, T2, U>(Func<Tuple<T1, T2>, U> self)
        {
            return t1 => t2 => self(Create.Tuple(t1, t2));
        }

        /// <summary>2つの引数を受け取る複数関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2>, U> Tupled<T1, T2, U>(this Func<T1, T2, U> self)
        {
            return tpl => self(tpl._1(), tpl._2());
        }

        /// <summary>2つの引数を受け取る複数関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2>, U> Tuple<T1, T2, U>(Func<T1, T2, U> self)
        {
            return tpl => self(tpl._1(), tpl._2());
        }

        /// <summary>2つの引数を受け取るカリー化関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2>, U> UncurriedX<T1, T2, U>(this Func<T1, Func<T2, U>> self)
        {
            return tpl => self(tpl._1())(tpl._2());
        }

        /// <summary>2つの引数を受け取るカリー化関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2>, U> UncurryX<T1, T2, U>(Func<T1, Func<T2, U>> self)
        {
            return tpl => self(tpl._1())(tpl._2());
        }

        /// <summary>2要素のタプルを受け取る関数を複数引数関数化します。</summary>
        public static Func<T1, T2, U> Untupled<T1, T2, U>(this Func<Tuple<T1, T2>, U> self)
        {
            return (t1, t2) => self(Create.Tuple(t1, t2));
        }

        /// <summary>2要素のタプルを受け取る関数を複数引数関数化します。</summary>
        public static Func<T1, T2, U> Untuple<T1, T2, U>(Func<Tuple<T1, T2>, U> self)
        {
            return (t1, t2) => self(Create.Tuple(t1, t2));
        }

        /// <summary>2つの引数を受け取るカリー化関数をアンカリー化します。</summary>
        public static Func<T1, T2, U> Uncurried<T1, T2, U>(this Func<T1, Func<T2, U>> self)
        {
            return (t1, t2) => self(t1)(t2);
        }

        /// <summary>2つの引数を受け取るカリー化関数をアンカリー化します。</summary>
        public static Func<T1, T2, U> Uncurry<T1, T2, U>(Func<T1, Func<T2, U>> self)
        {
            return (t1, t2) => self(t1)(t2);
        }

        /// <summary>3つの引数を受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, U>>> Curried<T1, T2, T3, U>(this Func<T1, T2, T3, U> self)
        {
            return t1 => t2 => t3 => self(t1, t2, t3);
        }

        /// <summary>3つの引数を受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, U>>> Curry<T1, T2, T3, U>(Func<T1, T2, T3, U> self)
        {
            return t1 => t2 => t3 => self(t1, t2, t3);
        }

        /// <summary>3要素のタプルを受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, U>>> CurriedX<T1, T2, T3, U>(this Func<Tuple<T1, T2, T3>, U> self)
        {
            return t1 => t2 => t3 => self(Create.Tuple(t1, t2, t3));
        }

        /// <summary>3要素のタプルを受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, U>>> CurryX<T1, T2, T3, U>(Func<Tuple<T1, T2, T3>, U> self)
        {
            return t1 => t2 => t3 => self(Create.Tuple(t1, t2, t3));
        }

        /// <summary>3つの引数を受け取る複数関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3>, U> Tupled<T1, T2, T3, U>(this Func<T1, T2, T3, U> self)
        {
            return tpl => self(tpl._1(), tpl._2(), tpl._3());
        }

        /// <summary>3つの引数を受け取る複数関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3>, U> Tuple<T1, T2, T3, U>(Func<T1, T2, T3, U> self)
        {
            return tpl => self(tpl._1(), tpl._2(), tpl._3());
        }

        /// <summary>3つの引数を受け取るカリー化関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3>, U> UncurriedX<T1, T2, T3, U>(this Func<T1, Func<T2, Func<T3, U>>> self)
        {
            return tpl => self(tpl._1())(tpl._2())(tpl._3());
        }

        /// <summary>3つの引数を受け取るカリー化関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3>, U> UncurryX<T1, T2, T3, U>(Func<T1, Func<T2, Func<T3, U>>> self)
        {
            return tpl => self(tpl._1())(tpl._2())(tpl._3());
        }

        /// <summary>3要素のタプルを受け取る関数を複数引数関数化します。</summary>
        public static Func<T1, T2, T3, U> Untupled<T1, T2, T3, U>(this Func<Tuple<T1, T2, T3>, U> self)
        {
            return (t1, t2, t3) => self(Create.Tuple(t1, t2, t3));
        }

        /// <summary>3要素のタプルを受け取る関数を複数引数関数化します。</summary>
        public static Func<T1, T2, T3, U> Untuple<T1, T2, T3, U>(Func<Tuple<T1, T2, T3>, U> self)
        {
            return (t1, t2, t3) => self(Create.Tuple(t1, t2, t3));
        }

        /// <summary>3つの引数を受け取るカリー化関数をアンカリー化します。</summary>
        public static Func<T1, T2, T3, U> Uncurried<T1, T2, T3, U>(this Func<T1, Func<T2, Func<T3, U>>> self)
        {
            return (t1, t2, t3) => self(t1)(t2)(t3);
        }

        /// <summary>3つの引数を受け取るカリー化関数をアンカリー化します。</summary>
        public static Func<T1, T2, T3, U> Uncurry<T1, T2, T3, U>(Func<T1, Func<T2, Func<T3, U>>> self)
        {
            return (t1, t2, t3) => self(t1)(t2)(t3);
        }

        /// <summary>4つの引数を受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, U>>>> Curried<T1, T2, T3, T4, U>(this Func<T1, T2, T3, T4, U> self)
        {
            return t1 => t2 => t3 => t4 => self(t1, t2, t3, t4);
        }

        /// <summary>4つの引数を受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, U>>>> Curry<T1, T2, T3, T4, U>(Func<T1, T2, T3, T4, U> self)
        {
            return t1 => t2 => t3 => t4 => self(t1, t2, t3, t4);
        }

        /// <summary>4要素のタプルを受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, U>>>> CurriedX<T1, T2, T3, T4, U>(this Func<Tuple<T1, T2, T3, T4>, U> self)
        {
            return t1 => t2 => t3 => t4 => self(Create.Tuple(t1, t2, t3, t4));
        }

        /// <summary>4要素のタプルを受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, U>>>> CurryX<T1, T2, T3, T4, U>(Func<Tuple<T1, T2, T3, T4>, U> self)
        {
            return t1 => t2 => t3 => t4 => self(Create.Tuple(t1, t2, t3, t4));
        }

        /// <summary>4つの引数を受け取る複数関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4>, U> Tupled<T1, T2, T3, T4, U>(this Func<T1, T2, T3, T4, U> self)
        {
            return tpl => self(tpl._1(), tpl._2(), tpl._3(), tpl._4());
        }

        /// <summary>4つの引数を受け取る複数関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4>, U> Tuple<T1, T2, T3, T4, U>(Func<T1, T2, T3, T4, U> self)
        {
            return tpl => self(tpl._1(), tpl._2(), tpl._3(), tpl._4());
        }

        /// <summary>4つの引数を受け取るカリー化関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4>, U> UncurriedX<T1, T2, T3, T4, U>(this Func<T1, Func<T2, Func<T3, Func<T4, U>>>> self)
        {
            return tpl => self(tpl._1())(tpl._2())(tpl._3())(tpl._4());
        }

        /// <summary>4つの引数を受け取るカリー化関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4>, U> UncurryX<T1, T2, T3, T4, U>(Func<T1, Func<T2, Func<T3, Func<T4, U>>>> self)
        {
            return tpl => self(tpl._1())(tpl._2())(tpl._3())(tpl._4());
        }

        /// <summary>4要素のタプルを受け取る関数を複数引数関数化します。</summary>
        public static Func<T1, T2, T3, T4, U> Untupled<T1, T2, T3, T4, U>(this Func<Tuple<T1, T2, T3, T4>, U> self)
        {
            return (t1, t2, t3, t4) => self(Create.Tuple(t1, t2, t3, t4));
        }

        /// <summary>4要素のタプルを受け取る関数を複数引数関数化します。</summary>
        public static Func<T1, T2, T3, T4, U> Untuple<T1, T2, T3, T4, U>(Func<Tuple<T1, T2, T3, T4>, U> self)
        {
            return (t1, t2, t3, t4) => self(Create.Tuple(t1, t2, t3, t4));
        }

        /// <summary>4つの引数を受け取るカリー化関数をアンカリー化します。</summary>
        public static Func<T1, T2, T3, T4, U> Uncurried<T1, T2, T3, T4, U>(this Func<T1, Func<T2, Func<T3, Func<T4, U>>>> self)
        {
            return (t1, t2, t3, t4) => self(t1)(t2)(t3)(t4);
        }

        /// <summary>4つの引数を受け取るカリー化関数をアンカリー化します。</summary>
        public static Func<T1, T2, T3, T4, U> Uncurry<T1, T2, T3, T4, U>(Func<T1, Func<T2, Func<T3, Func<T4, U>>>> self)
        {
            return (t1, t2, t3, t4) => self(t1)(t2)(t3)(t4);
        }

        /// <summary>5つの引数を受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, U>>>>> Curried<T1, T2, T3, T4, T5, U>(this Func<T1, T2, T3, T4, T5, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => self(t1, t2, t3, t4, t5);
        }

        /// <summary>5つの引数を受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, U>>>>> Curry<T1, T2, T3, T4, T5, U>(Func<T1, T2, T3, T4, T5, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => self(t1, t2, t3, t4, t5);
        }

        /// <summary>5要素のタプルを受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, U>>>>> CurriedX<T1, T2, T3, T4, T5, U>(this Func<Tuple<T1, T2, T3, T4, T5>, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => self(Create.Tuple(t1, t2, t3, t4, t5));
        }

        /// <summary>5要素のタプルを受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, U>>>>> CurryX<T1, T2, T3, T4, T5, U>(Func<Tuple<T1, T2, T3, T4, T5>, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => self(Create.Tuple(t1, t2, t3, t4, t5));
        }

        /// <summary>5つの引数を受け取る複数関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5>, U> Tupled<T1, T2, T3, T4, T5, U>(this Func<T1, T2, T3, T4, T5, U> self)
        {
            return tpl => self(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5());
        }

        /// <summary>5つの引数を受け取る複数関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5>, U> Tuple<T1, T2, T3, T4, T5, U>(Func<T1, T2, T3, T4, T5, U> self)
        {
            return tpl => self(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5());
        }

        /// <summary>5つの引数を受け取るカリー化関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5>, U> UncurriedX<T1, T2, T3, T4, T5, U>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, U>>>>> self)
        {
            return tpl => self(tpl._1())(tpl._2())(tpl._3())(tpl._4())(tpl._5());
        }

        /// <summary>5つの引数を受け取るカリー化関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5>, U> UncurryX<T1, T2, T3, T4, T5, U>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, U>>>>> self)
        {
            return tpl => self(tpl._1())(tpl._2())(tpl._3())(tpl._4())(tpl._5());
        }

        /// <summary>5要素のタプルを受け取る関数を複数引数関数化します。</summary>
        public static Func<T1, T2, T3, T4, T5, U> Untupled<T1, T2, T3, T4, T5, U>(this Func<Tuple<T1, T2, T3, T4, T5>, U> self)
        {
            return (t1, t2, t3, t4, t5) => self(Create.Tuple(t1, t2, t3, t4, t5));
        }

        /// <summary>5要素のタプルを受け取る関数を複数引数関数化します。</summary>
        public static Func<T1, T2, T3, T4, T5, U> Untuple<T1, T2, T3, T4, T5, U>(Func<Tuple<T1, T2, T3, T4, T5>, U> self)
        {
            return (t1, t2, t3, t4, t5) => self(Create.Tuple(t1, t2, t3, t4, t5));
        }

        /// <summary>5つの引数を受け取るカリー化関数をアンカリー化します。</summary>
        public static Func<T1, T2, T3, T4, T5, U> Uncurried<T1, T2, T3, T4, T5, U>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, U>>>>> self)
        {
            return (t1, t2, t3, t4, t5) => self(t1)(t2)(t3)(t4)(t5);
        }

        /// <summary>5つの引数を受け取るカリー化関数をアンカリー化します。</summary>
        public static Func<T1, T2, T3, T4, T5, U> Uncurry<T1, T2, T3, T4, T5, U>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, U>>>>> self)
        {
            return (t1, t2, t3, t4, t5) => self(t1)(t2)(t3)(t4)(t5);
        }

        /// <summary>6つの引数を受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, U>>>>>> Curried<T1, T2, T3, T4, T5, T6, U>(this Func<T1, T2, T3, T4, T5, T6, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => self(t1, t2, t3, t4, t5, t6);
        }

        /// <summary>6つの引数を受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, U>>>>>> Curry<T1, T2, T3, T4, T5, T6, U>(Func<T1, T2, T3, T4, T5, T6, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => self(t1, t2, t3, t4, t5, t6);
        }

        /// <summary>6要素のタプルを受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, U>>>>>> CurriedX<T1, T2, T3, T4, T5, T6, U>(this Func<Tuple<T1, T2, T3, T4, T5, T6>, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => self(Create.Tuple(t1, t2, t3, t4, t5, t6));
        }

        /// <summary>6要素のタプルを受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, U>>>>>> CurryX<T1, T2, T3, T4, T5, T6, U>(Func<Tuple<T1, T2, T3, T4, T5, T6>, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => self(Create.Tuple(t1, t2, t3, t4, t5, t6));
        }

        /// <summary>6つの引数を受け取る複数関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6>, U> Tupled<T1, T2, T3, T4, T5, T6, U>(this Func<T1, T2, T3, T4, T5, T6, U> self)
        {
            return tpl => self(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6());
        }

        /// <summary>6つの引数を受け取る複数関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6>, U> Tuple<T1, T2, T3, T4, T5, T6, U>(Func<T1, T2, T3, T4, T5, T6, U> self)
        {
            return tpl => self(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6());
        }

        /// <summary>6つの引数を受け取るカリー化関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6>, U> UncurriedX<T1, T2, T3, T4, T5, T6, U>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, U>>>>>> self)
        {
            return tpl => self(tpl._1())(tpl._2())(tpl._3())(tpl._4())(tpl._5())(tpl._6());
        }

        /// <summary>6つの引数を受け取るカリー化関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6>, U> UncurryX<T1, T2, T3, T4, T5, T6, U>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, U>>>>>> self)
        {
            return tpl => self(tpl._1())(tpl._2())(tpl._3())(tpl._4())(tpl._5())(tpl._6());
        }

        /// <summary>6要素のタプルを受け取る関数を複数引数関数化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, U> Untupled<T1, T2, T3, T4, T5, T6, U>(this Func<Tuple<T1, T2, T3, T4, T5, T6>, U> self)
        {
            return (t1, t2, t3, t4, t5, t6) => self(Create.Tuple(t1, t2, t3, t4, t5, t6));
        }

        /// <summary>6要素のタプルを受け取る関数を複数引数関数化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, U> Untuple<T1, T2, T3, T4, T5, T6, U>(Func<Tuple<T1, T2, T3, T4, T5, T6>, U> self)
        {
            return (t1, t2, t3, t4, t5, t6) => self(Create.Tuple(t1, t2, t3, t4, t5, t6));
        }

        /// <summary>6つの引数を受け取るカリー化関数をアンカリー化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, U> Uncurried<T1, T2, T3, T4, T5, T6, U>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, U>>>>>> self)
        {
            return (t1, t2, t3, t4, t5, t6) => self(t1)(t2)(t3)(t4)(t5)(t6);
        }

        /// <summary>6つの引数を受け取るカリー化関数をアンカリー化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, U> Uncurry<T1, T2, T3, T4, T5, T6, U>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, U>>>>>> self)
        {
            return (t1, t2, t3, t4, t5, t6) => self(t1)(t2)(t3)(t4)(t5)(t6);
        }

        /// <summary>7つの引数を受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, U>>>>>>> Curried<T1, T2, T3, T4, T5, T6, T7, U>(this Func<T1, T2, T3, T4, T5, T6, T7, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => self(t1, t2, t3, t4, t5, t6, t7);
        }

        /// <summary>7つの引数を受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, U>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, U>(Func<T1, T2, T3, T4, T5, T6, T7, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => self(t1, t2, t3, t4, t5, t6, t7);
        }

        /// <summary>7要素のタプルを受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, U>>>>>>> CurriedX<T1, T2, T3, T4, T5, T6, T7, U>(this Func<Tuple<T1, T2, T3, T4, T5, T6, T7>, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7));
        }

        /// <summary>7要素のタプルを受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, U>>>>>>> CurryX<T1, T2, T3, T4, T5, T6, T7, U>(Func<Tuple<T1, T2, T3, T4, T5, T6, T7>, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7));
        }

        /// <summary>7つの引数を受け取る複数関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7>, U> Tupled<T1, T2, T3, T4, T5, T6, T7, U>(this Func<T1, T2, T3, T4, T5, T6, T7, U> self)
        {
            return tpl => self(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7());
        }

        /// <summary>7つの引数を受け取る複数関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7>, U> Tuple<T1, T2, T3, T4, T5, T6, T7, U>(Func<T1, T2, T3, T4, T5, T6, T7, U> self)
        {
            return tpl => self(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7());
        }

        /// <summary>7つの引数を受け取るカリー化関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7>, U> UncurriedX<T1, T2, T3, T4, T5, T6, T7, U>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, U>>>>>>> self)
        {
            return tpl => self(tpl._1())(tpl._2())(tpl._3())(tpl._4())(tpl._5())(tpl._6())(tpl._7());
        }

        /// <summary>7つの引数を受け取るカリー化関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7>, U> UncurryX<T1, T2, T3, T4, T5, T6, T7, U>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, U>>>>>>> self)
        {
            return tpl => self(tpl._1())(tpl._2())(tpl._3())(tpl._4())(tpl._5())(tpl._6())(tpl._7());
        }

        /// <summary>7要素のタプルを受け取る関数を複数引数関数化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, U> Untupled<T1, T2, T3, T4, T5, T6, T7, U>(this Func<Tuple<T1, T2, T3, T4, T5, T6, T7>, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7) => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7));
        }

        /// <summary>7要素のタプルを受け取る関数を複数引数関数化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, U> Untuple<T1, T2, T3, T4, T5, T6, T7, U>(Func<Tuple<T1, T2, T3, T4, T5, T6, T7>, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7) => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7));
        }

        /// <summary>7つの引数を受け取るカリー化関数をアンカリー化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, U> Uncurried<T1, T2, T3, T4, T5, T6, T7, U>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, U>>>>>>> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7) => self(t1)(t2)(t3)(t4)(t5)(t6)(t7);
        }

        /// <summary>7つの引数を受け取るカリー化関数をアンカリー化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, U> Uncurry<T1, T2, T3, T4, T5, T6, T7, U>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, U>>>>>>> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7) => self(t1)(t2)(t3)(t4)(t5)(t6)(t7);
        }

        /// <summary>8つの引数を受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, U>>>>>>>> Curried<T1, T2, T3, T4, T5, T6, T7, T8, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => self(t1, t2, t3, t4, t5, t6, t7, t8);
        }

        /// <summary>8つの引数を受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, U>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => self(t1, t2, t3, t4, t5, t6, t7, t8);
        }

        /// <summary>8要素のタプルを受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, U>>>>>>>> CurriedX<T1, T2, T3, T4, T5, T6, T7, T8, U>(this Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8));
        }

        /// <summary>8要素のタプルを受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, U>>>>>>>> CurryX<T1, T2, T3, T4, T5, T6, T7, T8, U>(Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8));
        }

        /// <summary>8つの引数を受け取る複数関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>, U> Tupled<T1, T2, T3, T4, T5, T6, T7, T8, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, U> self)
        {
            return tpl => self(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8());
        }

        /// <summary>8つの引数を受け取る複数関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>, U> Tuple<T1, T2, T3, T4, T5, T6, T7, T8, U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, U> self)
        {
            return tpl => self(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8());
        }

        /// <summary>8つの引数を受け取るカリー化関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>, U> UncurriedX<T1, T2, T3, T4, T5, T6, T7, T8, U>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, U>>>>>>>> self)
        {
            return tpl => self(tpl._1())(tpl._2())(tpl._3())(tpl._4())(tpl._5())(tpl._6())(tpl._7())(tpl._8());
        }

        /// <summary>8つの引数を受け取るカリー化関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>, U> UncurryX<T1, T2, T3, T4, T5, T6, T7, T8, U>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, U>>>>>>>> self)
        {
            return tpl => self(tpl._1())(tpl._2())(tpl._3())(tpl._4())(tpl._5())(tpl._6())(tpl._7())(tpl._8());
        }

        /// <summary>8要素のタプルを受け取る関数を複数引数関数化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, U> Untupled<T1, T2, T3, T4, T5, T6, T7, T8, U>(this Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8) => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8));
        }

        /// <summary>8要素のタプルを受け取る関数を複数引数関数化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, U> Untuple<T1, T2, T3, T4, T5, T6, T7, T8, U>(Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8) => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8));
        }

        /// <summary>8つの引数を受け取るカリー化関数をアンカリー化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, U> Uncurried<T1, T2, T3, T4, T5, T6, T7, T8, U>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, U>>>>>>>> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8) => self(t1)(t2)(t3)(t4)(t5)(t6)(t7)(t8);
        }

        /// <summary>8つの引数を受け取るカリー化関数をアンカリー化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, U> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, U>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, U>>>>>>>> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8) => self(t1)(t2)(t3)(t4)(t5)(t6)(t7)(t8);
        }

        /// <summary>9つの引数を受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, U>>>>>>>>> Curried<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => self(t1, t2, t3, t4, t5, t6, t7, t8, t9);
        }

        /// <summary>9つの引数を受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, U>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => self(t1, t2, t3, t4, t5, t6, t7, t8, t9);
        }

        /// <summary>9要素のタプルを受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, U>>>>>>>>> CurriedX<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9));
        }

        /// <summary>9要素のタプルを受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, U>>>>>>>>> CurryX<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9));
        }

        /// <summary>9つの引数を受け取る複数関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>, U> Tupled<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> self)
        {
            return tpl => self(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9());
        }

        /// <summary>9つの引数を受け取る複数関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>, U> Tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> self)
        {
            return tpl => self(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9());
        }

        /// <summary>9つの引数を受け取るカリー化関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>, U> UncurriedX<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, U>>>>>>>>> self)
        {
            return tpl => self(tpl._1())(tpl._2())(tpl._3())(tpl._4())(tpl._5())(tpl._6())(tpl._7())(tpl._8())(tpl._9());
        }

        /// <summary>9つの引数を受け取るカリー化関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>, U> UncurryX<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, U>>>>>>>>> self)
        {
            return tpl => self(tpl._1())(tpl._2())(tpl._3())(tpl._4())(tpl._5())(tpl._6())(tpl._7())(tpl._8())(tpl._9());
        }

        /// <summary>9要素のタプルを受け取る関数を複数引数関数化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> Untupled<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9) => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9));
        }

        /// <summary>9要素のタプルを受け取る関数を複数引数関数化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> Untuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9) => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9));
        }

        /// <summary>9つの引数を受け取るカリー化関数をアンカリー化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> Uncurried<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, U>>>>>>>>> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9) => self(t1)(t2)(t3)(t4)(t5)(t6)(t7)(t8)(t9);
        }

        /// <summary>9つの引数を受け取るカリー化関数をアンカリー化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, U>>>>>>>>> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9) => self(t1)(t2)(t3)(t4)(t5)(t6)(t7)(t8)(t9);
        }

        /// <summary>10つの引数を受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, U>>>>>>>>>> Curried<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
        }

        /// <summary>10つの引数を受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, U>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
        }

        /// <summary>10要素のタプルを受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, U>>>>>>>>>> CurriedX<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
        }

        /// <summary>10要素のタプルを受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, U>>>>>>>>>> CurryX<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
        }

        /// <summary>10つの引数を受け取る複数関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>, U> Tupled<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> self)
        {
            return tpl => self(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10());
        }

        /// <summary>10つの引数を受け取る複数関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>, U> Tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> self)
        {
            return tpl => self(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10());
        }

        /// <summary>10つの引数を受け取るカリー化関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>, U> UncurriedX<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, U>>>>>>>>>> self)
        {
            return tpl => self(tpl._1())(tpl._2())(tpl._3())(tpl._4())(tpl._5())(tpl._6())(tpl._7())(tpl._8())(tpl._9())(tpl._10());
        }

        /// <summary>10つの引数を受け取るカリー化関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>, U> UncurryX<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, U>>>>>>>>>> self)
        {
            return tpl => self(tpl._1())(tpl._2())(tpl._3())(tpl._4())(tpl._5())(tpl._6())(tpl._7())(tpl._8())(tpl._9())(tpl._10());
        }

        /// <summary>10要素のタプルを受け取る関数を複数引数関数化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> Untupled<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
        }

        /// <summary>10要素のタプルを受け取る関数を複数引数関数化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> Untuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
        }

        /// <summary>10つの引数を受け取るカリー化関数をアンカリー化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> Uncurried<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, U>>>>>>>>>> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => self(t1)(t2)(t3)(t4)(t5)(t6)(t7)(t8)(t9)(t10);
        }

        /// <summary>10つの引数を受け取るカリー化関数をアンカリー化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, U>>>>>>>>>> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => self(t1)(t2)(t3)(t4)(t5)(t6)(t7)(t8)(t9)(t10);
        }

        /// <summary>11つの引数を受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, U>>>>>>>>>>> Curried<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
        }

        /// <summary>11つの引数を受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, U>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
        }

        /// <summary>11要素のタプルを受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, U>>>>>>>>>>> CurriedX<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
        }

        /// <summary>11要素のタプルを受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, U>>>>>>>>>>> CurryX<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
        }

        /// <summary>11つの引数を受け取る複数関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>, U> Tupled<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> self)
        {
            return tpl => self(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11());
        }

        /// <summary>11つの引数を受け取る複数関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>, U> Tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> self)
        {
            return tpl => self(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11());
        }

        /// <summary>11つの引数を受け取るカリー化関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>, U> UncurriedX<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, U>>>>>>>>>>> self)
        {
            return tpl => self(tpl._1())(tpl._2())(tpl._3())(tpl._4())(tpl._5())(tpl._6())(tpl._7())(tpl._8())(tpl._9())(tpl._10())(tpl._11());
        }

        /// <summary>11つの引数を受け取るカリー化関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>, U> UncurryX<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, U>>>>>>>>>>> self)
        {
            return tpl => self(tpl._1())(tpl._2())(tpl._3())(tpl._4())(tpl._5())(tpl._6())(tpl._7())(tpl._8())(tpl._9())(tpl._10())(tpl._11());
        }

        /// <summary>11要素のタプルを受け取る関数を複数引数関数化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> Untupled<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
        }

        /// <summary>11要素のタプルを受け取る関数を複数引数関数化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> Untuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
        }

        /// <summary>11つの引数を受け取るカリー化関数をアンカリー化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> Uncurried<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, U>>>>>>>>>>> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => self(t1)(t2)(t3)(t4)(t5)(t6)(t7)(t8)(t9)(t10)(t11);
        }

        /// <summary>11つの引数を受け取るカリー化関数をアンカリー化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, U>>>>>>>>>>> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => self(t1)(t2)(t3)(t4)(t5)(t6)(t7)(t8)(t9)(t10)(t11);
        }

        /// <summary>12つの引数を受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, U>>>>>>>>>>>> Curried<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
        }

        /// <summary>12つの引数を受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, U>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
        }

        /// <summary>12要素のタプルを受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, U>>>>>>>>>>>> CurriedX<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
        }

        /// <summary>12要素のタプルを受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, U>>>>>>>>>>>> CurryX<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
        }

        /// <summary>12つの引数を受け取る複数関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>, U> Tupled<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> self)
        {
            return tpl => self(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12());
        }

        /// <summary>12つの引数を受け取る複数関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>, U> Tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> self)
        {
            return tpl => self(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12());
        }

        /// <summary>12つの引数を受け取るカリー化関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>, U> UncurriedX<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, U>>>>>>>>>>>> self)
        {
            return tpl => self(tpl._1())(tpl._2())(tpl._3())(tpl._4())(tpl._5())(tpl._6())(tpl._7())(tpl._8())(tpl._9())(tpl._10())(tpl._11())(tpl._12());
        }

        /// <summary>12つの引数を受け取るカリー化関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>, U> UncurryX<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, U>>>>>>>>>>>> self)
        {
            return tpl => self(tpl._1())(tpl._2())(tpl._3())(tpl._4())(tpl._5())(tpl._6())(tpl._7())(tpl._8())(tpl._9())(tpl._10())(tpl._11())(tpl._12());
        }

        /// <summary>12要素のタプルを受け取る関数を複数引数関数化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> Untupled<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
        }

        /// <summary>12要素のタプルを受け取る関数を複数引数関数化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> Untuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
        }

        /// <summary>12つの引数を受け取るカリー化関数をアンカリー化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> Uncurried<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, U>>>>>>>>>>>> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => self(t1)(t2)(t3)(t4)(t5)(t6)(t7)(t8)(t9)(t10)(t11)(t12);
        }

        /// <summary>12つの引数を受け取るカリー化関数をアンカリー化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, U>>>>>>>>>>>> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => self(t1)(t2)(t3)(t4)(t5)(t6)(t7)(t8)(t9)(t10)(t11)(t12);
        }

        /// <summary>13つの引数を受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, U>>>>>>>>>>>>> Curried<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
        }

        /// <summary>13つの引数を受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, U>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
        }

        /// <summary>13要素のタプルを受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, U>>>>>>>>>>>>> CurriedX<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
        }

        /// <summary>13要素のタプルを受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, U>>>>>>>>>>>>> CurryX<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
        }

        /// <summary>13つの引数を受け取る複数関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>, U> Tupled<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> self)
        {
            return tpl => self(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13());
        }

        /// <summary>13つの引数を受け取る複数関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>, U> Tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> self)
        {
            return tpl => self(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13());
        }

        /// <summary>13つの引数を受け取るカリー化関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>, U> UncurriedX<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, U>>>>>>>>>>>>> self)
        {
            return tpl => self(tpl._1())(tpl._2())(tpl._3())(tpl._4())(tpl._5())(tpl._6())(tpl._7())(tpl._8())(tpl._9())(tpl._10())(tpl._11())(tpl._12())(tpl._13());
        }

        /// <summary>13つの引数を受け取るカリー化関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>, U> UncurryX<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, U>>>>>>>>>>>>> self)
        {
            return tpl => self(tpl._1())(tpl._2())(tpl._3())(tpl._4())(tpl._5())(tpl._6())(tpl._7())(tpl._8())(tpl._9())(tpl._10())(tpl._11())(tpl._12())(tpl._13());
        }

        /// <summary>13要素のタプルを受け取る関数を複数引数関数化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> Untupled<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
        }

        /// <summary>13要素のタプルを受け取る関数を複数引数関数化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> Untuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
        }

        /// <summary>13つの引数を受け取るカリー化関数をアンカリー化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> Uncurried<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, U>>>>>>>>>>>>> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => self(t1)(t2)(t3)(t4)(t5)(t6)(t7)(t8)(t9)(t10)(t11)(t12)(t13);
        }

        /// <summary>13つの引数を受け取るカリー化関数をアンカリー化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, U>>>>>>>>>>>>> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => self(t1)(t2)(t3)(t4)(t5)(t6)(t7)(t8)(t9)(t10)(t11)(t12)(t13);
        }

        /// <summary>14つの引数を受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, U>>>>>>>>>>>>>> Curried<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => t14 => self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
        }

        /// <summary>14つの引数を受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, U>>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => t14 => self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
        }

        /// <summary>14要素のタプルを受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, U>>>>>>>>>>>>>> CurriedX<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => t14 => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
        }

        /// <summary>14要素のタプルを受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, U>>>>>>>>>>>>>> CurryX<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => t14 => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
        }

        /// <summary>14つの引数を受け取る複数関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>, U> Tupled<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> self)
        {
            return tpl => self(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14());
        }

        /// <summary>14つの引数を受け取る複数関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>, U> Tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> self)
        {
            return tpl => self(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14());
        }

        /// <summary>14つの引数を受け取るカリー化関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>, U> UncurriedX<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, U>>>>>>>>>>>>>> self)
        {
            return tpl => self(tpl._1())(tpl._2())(tpl._3())(tpl._4())(tpl._5())(tpl._6())(tpl._7())(tpl._8())(tpl._9())(tpl._10())(tpl._11())(tpl._12())(tpl._13())(tpl._14());
        }

        /// <summary>14つの引数を受け取るカリー化関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>, U> UncurryX<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, U>>>>>>>>>>>>>> self)
        {
            return tpl => self(tpl._1())(tpl._2())(tpl._3())(tpl._4())(tpl._5())(tpl._6())(tpl._7())(tpl._8())(tpl._9())(tpl._10())(tpl._11())(tpl._12())(tpl._13())(tpl._14());
        }

        /// <summary>14要素のタプルを受け取る関数を複数引数関数化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> Untupled<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
        }

        /// <summary>14要素のタプルを受け取る関数を複数引数関数化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> Untuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
        }

        /// <summary>14つの引数を受け取るカリー化関数をアンカリー化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> Uncurried<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, U>>>>>>>>>>>>>> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => self(t1)(t2)(t3)(t4)(t5)(t6)(t7)(t8)(t9)(t10)(t11)(t12)(t13)(t14);
        }

        /// <summary>14つの引数を受け取るカリー化関数をアンカリー化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, U>>>>>>>>>>>>>> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => self(t1)(t2)(t3)(t4)(t5)(t6)(t7)(t8)(t9)(t10)(t11)(t12)(t13)(t14);
        }

        /// <summary>15つの引数を受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, U>>>>>>>>>>>>>>> Curried<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => t14 => t15 => self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
        }

        /// <summary>15つの引数を受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, U>>>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => t14 => t15 => self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
        }

        /// <summary>15要素のタプルを受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, U>>>>>>>>>>>>>>> CurriedX<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => t14 => t15 => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
        }

        /// <summary>15要素のタプルを受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, U>>>>>>>>>>>>>>> CurryX<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => t14 => t15 => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
        }

        /// <summary>15つの引数を受け取る複数関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>, U> Tupled<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> self)
        {
            return tpl => self(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15());
        }

        /// <summary>15つの引数を受け取る複数関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>, U> Tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> self)
        {
            return tpl => self(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15());
        }

        /// <summary>15つの引数を受け取るカリー化関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>, U> UncurriedX<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, U>>>>>>>>>>>>>>> self)
        {
            return tpl => self(tpl._1())(tpl._2())(tpl._3())(tpl._4())(tpl._5())(tpl._6())(tpl._7())(tpl._8())(tpl._9())(tpl._10())(tpl._11())(tpl._12())(tpl._13())(tpl._14())(tpl._15());
        }

        /// <summary>15つの引数を受け取るカリー化関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>, U> UncurryX<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, U>>>>>>>>>>>>>>> self)
        {
            return tpl => self(tpl._1())(tpl._2())(tpl._3())(tpl._4())(tpl._5())(tpl._6())(tpl._7())(tpl._8())(tpl._9())(tpl._10())(tpl._11())(tpl._12())(tpl._13())(tpl._14())(tpl._15());
        }

        /// <summary>15要素のタプルを受け取る関数を複数引数関数化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> Untupled<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
        }

        /// <summary>15要素のタプルを受け取る関数を複数引数関数化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> Untuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
        }

        /// <summary>15つの引数を受け取るカリー化関数をアンカリー化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> Uncurried<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, U>>>>>>>>>>>>>>> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => self(t1)(t2)(t3)(t4)(t5)(t6)(t7)(t8)(t9)(t10)(t11)(t12)(t13)(t14)(t15);
        }

        /// <summary>15つの引数を受け取るカリー化関数をアンカリー化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, U>>>>>>>>>>>>>>> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => self(t1)(t2)(t3)(t4)(t5)(t6)(t7)(t8)(t9)(t10)(t11)(t12)(t13)(t14)(t15);
        }

        /// <summary>16つの引数を受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, U>>>>>>>>>>>>>>>> Curried<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => t14 => t15 => t16 => self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);
        }

        /// <summary>16つの引数を受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, U>>>>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => t14 => t15 => t16 => self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);
        }

        /// <summary>16要素のタプルを受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, U>>>>>>>>>>>>>>>> CurriedX<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => t14 => t15 => t16 => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16));
        }

        /// <summary>16要素のタプルを受け取る関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, U>>>>>>>>>>>>>>>> CurryX<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>, U> self)
        {
            return t1 => t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => t14 => t15 => t16 => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16));
        }

        /// <summary>16つの引数を受け取る複数関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>, U> Tupled<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> self)
        {
            return tpl => self(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16());
        }

        /// <summary>16つの引数を受け取る複数関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>, U> Tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> self)
        {
            return tpl => self(tpl._1(), tpl._2(), tpl._3(), tpl._4(), tpl._5(), tpl._6(), tpl._7(), tpl._8(), tpl._9(), tpl._10(), tpl._11(), tpl._12(), tpl._13(), tpl._14(), tpl._15(), tpl._16());
        }

        /// <summary>16つの引数を受け取るカリー化関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>, U> UncurriedX<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, U>>>>>>>>>>>>>>>> self)
        {
            return tpl => self(tpl._1())(tpl._2())(tpl._3())(tpl._4())(tpl._5())(tpl._6())(tpl._7())(tpl._8())(tpl._9())(tpl._10())(tpl._11())(tpl._12())(tpl._13())(tpl._14())(tpl._15())(tpl._16());
        }

        /// <summary>16つの引数を受け取るカリー化関数をタプル関数化します。</summary>
        public static Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>, U> UncurryX<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, U>>>>>>>>>>>>>>>> self)
        {
            return tpl => self(tpl._1())(tpl._2())(tpl._3())(tpl._4())(tpl._5())(tpl._6())(tpl._7())(tpl._8())(tpl._9())(tpl._10())(tpl._11())(tpl._12())(tpl._13())(tpl._14())(tpl._15())(tpl._16());
        }

        /// <summary>16要素のタプルを受け取る関数を複数引数関数化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> Untupled<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16));
        }

        /// <summary>16要素のタプルを受け取る関数を複数引数関数化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> Untuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(Func<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => self(Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16));
        }

        /// <summary>16つの引数を受け取るカリー化関数をアンカリー化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> Uncurried<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, U>>>>>>>>>>>>>>>> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => self(t1)(t2)(t3)(t4)(t5)(t6)(t7)(t8)(t9)(t10)(t11)(t12)(t13)(t14)(t15)(t16);
        }

        /// <summary>16つの引数を受け取るカリー化関数をアンカリー化します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, U>>>>>>>>>>>>>>>> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => self(t1)(t2)(t3)(t4)(t5)(t6)(t7)(t8)(t9)(t10)(t11)(t12)(t13)(t14)(t15)(t16);
        }

    }
}