
using System;
using System.Collections.Generic;

namespace LangExt2
{
    partial class Seq
    {
        /// <summary>2個のシーケンスの要素1つ1つに対して、fを適用したシーケンスを返します。</summary>
        public static ISeq<U> ZipWith<T1, T2, U>(this ISeq<T1> ie1, ISeq<T2> ie2, Func<T1, T2, U> f)
        {
            return new Seq<U>(Enumerable.ZipWith(ie1, ie2, f));
        }

        /// <summary>2個のシーケンスをZipします。</summary>
        public static ISeq<Tuple<T1, T2>> Zip<T1, T2>(this ISeq<T1> ie1, ISeq<T2> ie2)
        {
            return new Seq<Tuple<T1, T2>>(Enumerable.Zip(ie1, ie2));
        }

        /// <summary>Zipされたシーケンスを元に戻し、2個のシーケンスのタプルとして返します。</summary>
        public static Tuple<ISeq<T1>, ISeq<T2>> Unzip<T1, T2>(this ISeq<Tuple<T1, T2>> self)
        {
            return TupleModule.Create(self.Map(x => x._1()), self.Map(x => x._2()));
        }

        /// <summary>3個のシーケンスの要素1つ1つに対して、fを適用したシーケンスを返します。</summary>
        public static ISeq<U> ZipWith<T1, T2, T3, U>(this ISeq<T1> ie1, ISeq<T2> ie2, ISeq<T3> ie3, Func<T1, T2, T3, U> f)
        {
            return new Seq<U>(Enumerable.ZipWith(ie1, ie2, ie3, f));
        }

        /// <summary>3個のシーケンスをZipします。</summary>
        public static ISeq<Tuple<T1, T2, T3>> Zip<T1, T2, T3>(this ISeq<T1> ie1, ISeq<T2> ie2, ISeq<T3> ie3)
        {
            return new Seq<Tuple<T1, T2, T3>>(Enumerable.Zip(ie1, ie2, ie3));
        }

        /// <summary>Zipされたシーケンスを元に戻し、3個のシーケンスのタプルとして返します。</summary>
        public static Tuple<ISeq<T1>, ISeq<T2>, ISeq<T3>> Unzip<T1, T2, T3>(this ISeq<Tuple<T1, T2, T3>> self)
        {
            return TupleModule.Create(self.Map(x => x._1()), self.Map(x => x._2()), self.Map(x => x._3()));
        }

        /// <summary>4個のシーケンスの要素1つ1つに対して、fを適用したシーケンスを返します。</summary>
        public static ISeq<U> ZipWith<T1, T2, T3, T4, U>(this ISeq<T1> ie1, ISeq<T2> ie2, ISeq<T3> ie3, ISeq<T4> ie4, Func<T1, T2, T3, T4, U> f)
        {
            return new Seq<U>(Enumerable.ZipWith(ie1, ie2, ie3, ie4, f));
        }

        /// <summary>4個のシーケンスをZipします。</summary>
        public static ISeq<Tuple<T1, T2, T3, T4>> Zip<T1, T2, T3, T4>(this ISeq<T1> ie1, ISeq<T2> ie2, ISeq<T3> ie3, ISeq<T4> ie4)
        {
            return new Seq<Tuple<T1, T2, T3, T4>>(Enumerable.Zip(ie1, ie2, ie3, ie4));
        }

        /// <summary>Zipされたシーケンスを元に戻し、4個のシーケンスのタプルとして返します。</summary>
        public static Tuple<ISeq<T1>, ISeq<T2>, ISeq<T3>, ISeq<T4>> Unzip<T1, T2, T3, T4>(this ISeq<Tuple<T1, T2, T3, T4>> self)
        {
            return TupleModule.Create(self.Map(x => x._1()), self.Map(x => x._2()), self.Map(x => x._3()), self.Map(x => x._4()));
        }

        /// <summary>5個のシーケンスの要素1つ1つに対して、fを適用したシーケンスを返します。</summary>
        public static ISeq<U> ZipWith<T1, T2, T3, T4, T5, U>(this ISeq<T1> ie1, ISeq<T2> ie2, ISeq<T3> ie3, ISeq<T4> ie4, ISeq<T5> ie5, Func<T1, T2, T3, T4, T5, U> f)
        {
            return new Seq<U>(Enumerable.ZipWith(ie1, ie2, ie3, ie4, ie5, f));
        }

        /// <summary>5個のシーケンスをZipします。</summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5>> Zip<T1, T2, T3, T4, T5>(this ISeq<T1> ie1, ISeq<T2> ie2, ISeq<T3> ie3, ISeq<T4> ie4, ISeq<T5> ie5)
        {
            return new Seq<Tuple<T1, T2, T3, T4, T5>>(Enumerable.Zip(ie1, ie2, ie3, ie4, ie5));
        }

        /// <summary>Zipされたシーケンスを元に戻し、5個のシーケンスのタプルとして返します。</summary>
        public static Tuple<ISeq<T1>, ISeq<T2>, ISeq<T3>, ISeq<T4>, ISeq<T5>> Unzip<T1, T2, T3, T4, T5>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self)
        {
            return TupleModule.Create(self.Map(x => x._1()), self.Map(x => x._2()), self.Map(x => x._3()), self.Map(x => x._4()), self.Map(x => x._5()));
        }

        /// <summary>6個のシーケンスの要素1つ1つに対して、fを適用したシーケンスを返します。</summary>
        public static ISeq<U> ZipWith<T1, T2, T3, T4, T5, T6, U>(this ISeq<T1> ie1, ISeq<T2> ie2, ISeq<T3> ie3, ISeq<T4> ie4, ISeq<T5> ie5, ISeq<T6> ie6, Func<T1, T2, T3, T4, T5, T6, U> f)
        {
            return new Seq<U>(Enumerable.ZipWith(ie1, ie2, ie3, ie4, ie5, ie6, f));
        }

        /// <summary>6個のシーケンスをZipします。</summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6>> Zip<T1, T2, T3, T4, T5, T6>(this ISeq<T1> ie1, ISeq<T2> ie2, ISeq<T3> ie3, ISeq<T4> ie4, ISeq<T5> ie5, ISeq<T6> ie6)
        {
            return new Seq<Tuple<T1, T2, T3, T4, T5, T6>>(Enumerable.Zip(ie1, ie2, ie3, ie4, ie5, ie6));
        }

        /// <summary>Zipされたシーケンスを元に戻し、6個のシーケンスのタプルとして返します。</summary>
        public static Tuple<ISeq<T1>, ISeq<T2>, ISeq<T3>, ISeq<T4>, ISeq<T5>, ISeq<T6>> Unzip<T1, T2, T3, T4, T5, T6>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self)
        {
            return TupleModule.Create(self.Map(x => x._1()), self.Map(x => x._2()), self.Map(x => x._3()), self.Map(x => x._4()), self.Map(x => x._5()), self.Map(x => x._6()));
        }

        /// <summary>7個のシーケンスの要素1つ1つに対して、fを適用したシーケンスを返します。</summary>
        public static ISeq<U> ZipWith<T1, T2, T3, T4, T5, T6, T7, U>(this ISeq<T1> ie1, ISeq<T2> ie2, ISeq<T3> ie3, ISeq<T4> ie4, ISeq<T5> ie5, ISeq<T6> ie6, ISeq<T7> ie7, Func<T1, T2, T3, T4, T5, T6, T7, U> f)
        {
            return new Seq<U>(Enumerable.ZipWith(ie1, ie2, ie3, ie4, ie5, ie6, ie7, f));
        }

        /// <summary>7個のシーケンスをZipします。</summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> Zip<T1, T2, T3, T4, T5, T6, T7>(this ISeq<T1> ie1, ISeq<T2> ie2, ISeq<T3> ie3, ISeq<T4> ie4, ISeq<T5> ie5, ISeq<T6> ie6, ISeq<T7> ie7)
        {
            return new Seq<Tuple<T1, T2, T3, T4, T5, T6, T7>>(Enumerable.Zip(ie1, ie2, ie3, ie4, ie5, ie6, ie7));
        }

        /// <summary>Zipされたシーケンスを元に戻し、7個のシーケンスのタプルとして返します。</summary>
        public static Tuple<ISeq<T1>, ISeq<T2>, ISeq<T3>, ISeq<T4>, ISeq<T5>, ISeq<T6>, ISeq<T7>> Unzip<T1, T2, T3, T4, T5, T6, T7>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self)
        {
            return TupleModule.Create(self.Map(x => x._1()), self.Map(x => x._2()), self.Map(x => x._3()), self.Map(x => x._4()), self.Map(x => x._5()), self.Map(x => x._6()), self.Map(x => x._7()));
        }

        /// <summary>8個のシーケンスの要素1つ1つに対して、fを適用したシーケンスを返します。</summary>
        public static ISeq<U> ZipWith<T1, T2, T3, T4, T5, T6, T7, T8, U>(this ISeq<T1> ie1, ISeq<T2> ie2, ISeq<T3> ie3, ISeq<T4> ie4, ISeq<T5> ie5, ISeq<T6> ie6, ISeq<T7> ie7, ISeq<T8> ie8, Func<T1, T2, T3, T4, T5, T6, T7, T8, U> f)
        {
            return new Seq<U>(Enumerable.ZipWith(ie1, ie2, ie3, ie4, ie5, ie6, ie7, ie8, f));
        }

        /// <summary>8個のシーケンスをZipします。</summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> Zip<T1, T2, T3, T4, T5, T6, T7, T8>(this ISeq<T1> ie1, ISeq<T2> ie2, ISeq<T3> ie3, ISeq<T4> ie4, ISeq<T5> ie5, ISeq<T6> ie6, ISeq<T7> ie7, ISeq<T8> ie8)
        {
            return new Seq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>>(Enumerable.Zip(ie1, ie2, ie3, ie4, ie5, ie6, ie7, ie8));
        }

        /// <summary>Zipされたシーケンスを元に戻し、8個のシーケンスのタプルとして返します。</summary>
        public static Tuple<ISeq<T1>, ISeq<T2>, ISeq<T3>, ISeq<T4>, ISeq<T5>, ISeq<T6>, ISeq<T7>, Tuple<ISeq<T8>>> Unzip<T1, T2, T3, T4, T5, T6, T7, T8>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self)
        {
            return TupleModule.Create(self.Map(x => x._1()), self.Map(x => x._2()), self.Map(x => x._3()), self.Map(x => x._4()), self.Map(x => x._5()), self.Map(x => x._6()), self.Map(x => x._7()), self.Map(x => x._8()));
        }

        /// <summary>9個のシーケンスの要素1つ1つに対して、fを適用したシーケンスを返します。</summary>
        public static ISeq<U> ZipWith<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this ISeq<T1> ie1, ISeq<T2> ie2, ISeq<T3> ie3, ISeq<T4> ie4, ISeq<T5> ie5, ISeq<T6> ie6, ISeq<T7> ie7, ISeq<T8> ie8, ISeq<T9> ie9, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> f)
        {
            return new Seq<U>(Enumerable.ZipWith(ie1, ie2, ie3, ie4, ie5, ie6, ie7, ie8, ie9, f));
        }

        /// <summary>9個のシーケンスをZipします。</summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ISeq<T1> ie1, ISeq<T2> ie2, ISeq<T3> ie3, ISeq<T4> ie4, ISeq<T5> ie5, ISeq<T6> ie6, ISeq<T7> ie7, ISeq<T8> ie8, ISeq<T9> ie9)
        {
            return new Seq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>>(Enumerable.Zip(ie1, ie2, ie3, ie4, ie5, ie6, ie7, ie8, ie9));
        }

        /// <summary>Zipされたシーケンスを元に戻し、9個のシーケンスのタプルとして返します。</summary>
        public static Tuple<ISeq<T1>, ISeq<T2>, ISeq<T3>, ISeq<T4>, ISeq<T5>, ISeq<T6>, ISeq<T7>, Tuple<ISeq<T8>, ISeq<T9>>> Unzip<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self)
        {
            return TupleModule.Create(self.Map(x => x._1()), self.Map(x => x._2()), self.Map(x => x._3()), self.Map(x => x._4()), self.Map(x => x._5()), self.Map(x => x._6()), self.Map(x => x._7()), self.Map(x => x._8()), self.Map(x => x._9()));
        }

        /// <summary>10個のシーケンスの要素1つ1つに対して、fを適用したシーケンスを返します。</summary>
        public static ISeq<U> ZipWith<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this ISeq<T1> ie1, ISeq<T2> ie2, ISeq<T3> ie3, ISeq<T4> ie4, ISeq<T5> ie5, ISeq<T6> ie6, ISeq<T7> ie7, ISeq<T8> ie8, ISeq<T9> ie9, ISeq<T10> ie10, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> f)
        {
            return new Seq<U>(Enumerable.ZipWith(ie1, ie2, ie3, ie4, ie5, ie6, ie7, ie8, ie9, ie10, f));
        }

        /// <summary>10個のシーケンスをZipします。</summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ISeq<T1> ie1, ISeq<T2> ie2, ISeq<T3> ie3, ISeq<T4> ie4, ISeq<T5> ie5, ISeq<T6> ie6, ISeq<T7> ie7, ISeq<T8> ie8, ISeq<T9> ie9, ISeq<T10> ie10)
        {
            return new Seq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>>(Enumerable.Zip(ie1, ie2, ie3, ie4, ie5, ie6, ie7, ie8, ie9, ie10));
        }

        /// <summary>Zipされたシーケンスを元に戻し、10個のシーケンスのタプルとして返します。</summary>
        public static Tuple<ISeq<T1>, ISeq<T2>, ISeq<T3>, ISeq<T4>, ISeq<T5>, ISeq<T6>, ISeq<T7>, Tuple<ISeq<T8>, ISeq<T9>, ISeq<T10>>> Unzip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self)
        {
            return TupleModule.Create(self.Map(x => x._1()), self.Map(x => x._2()), self.Map(x => x._3()), self.Map(x => x._4()), self.Map(x => x._5()), self.Map(x => x._6()), self.Map(x => x._7()), self.Map(x => x._8()), self.Map(x => x._9()), self.Map(x => x._10()));
        }

        /// <summary>11個のシーケンスの要素1つ1つに対して、fを適用したシーケンスを返します。</summary>
        public static ISeq<U> ZipWith<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this ISeq<T1> ie1, ISeq<T2> ie2, ISeq<T3> ie3, ISeq<T4> ie4, ISeq<T5> ie5, ISeq<T6> ie6, ISeq<T7> ie7, ISeq<T8> ie8, ISeq<T9> ie9, ISeq<T10> ie10, ISeq<T11> ie11, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> f)
        {
            return new Seq<U>(Enumerable.ZipWith(ie1, ie2, ie3, ie4, ie5, ie6, ie7, ie8, ie9, ie10, ie11, f));
        }

        /// <summary>11個のシーケンスをZipします。</summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ISeq<T1> ie1, ISeq<T2> ie2, ISeq<T3> ie3, ISeq<T4> ie4, ISeq<T5> ie5, ISeq<T6> ie6, ISeq<T7> ie7, ISeq<T8> ie8, ISeq<T9> ie9, ISeq<T10> ie10, ISeq<T11> ie11)
        {
            return new Seq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>>(Enumerable.Zip(ie1, ie2, ie3, ie4, ie5, ie6, ie7, ie8, ie9, ie10, ie11));
        }

        /// <summary>Zipされたシーケンスを元に戻し、11個のシーケンスのタプルとして返します。</summary>
        public static Tuple<ISeq<T1>, ISeq<T2>, ISeq<T3>, ISeq<T4>, ISeq<T5>, ISeq<T6>, ISeq<T7>, Tuple<ISeq<T8>, ISeq<T9>, ISeq<T10>, ISeq<T11>>> Unzip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self)
        {
            return TupleModule.Create(self.Map(x => x._1()), self.Map(x => x._2()), self.Map(x => x._3()), self.Map(x => x._4()), self.Map(x => x._5()), self.Map(x => x._6()), self.Map(x => x._7()), self.Map(x => x._8()), self.Map(x => x._9()), self.Map(x => x._10()), self.Map(x => x._11()));
        }

        /// <summary>12個のシーケンスの要素1つ1つに対して、fを適用したシーケンスを返します。</summary>
        public static ISeq<U> ZipWith<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this ISeq<T1> ie1, ISeq<T2> ie2, ISeq<T3> ie3, ISeq<T4> ie4, ISeq<T5> ie5, ISeq<T6> ie6, ISeq<T7> ie7, ISeq<T8> ie8, ISeq<T9> ie9, ISeq<T10> ie10, ISeq<T11> ie11, ISeq<T12> ie12, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> f)
        {
            return new Seq<U>(Enumerable.ZipWith(ie1, ie2, ie3, ie4, ie5, ie6, ie7, ie8, ie9, ie10, ie11, ie12, f));
        }

        /// <summary>12個のシーケンスをZipします。</summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ISeq<T1> ie1, ISeq<T2> ie2, ISeq<T3> ie3, ISeq<T4> ie4, ISeq<T5> ie5, ISeq<T6> ie6, ISeq<T7> ie7, ISeq<T8> ie8, ISeq<T9> ie9, ISeq<T10> ie10, ISeq<T11> ie11, ISeq<T12> ie12)
        {
            return new Seq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>>(Enumerable.Zip(ie1, ie2, ie3, ie4, ie5, ie6, ie7, ie8, ie9, ie10, ie11, ie12));
        }

        /// <summary>Zipされたシーケンスを元に戻し、12個のシーケンスのタプルとして返します。</summary>
        public static Tuple<ISeq<T1>, ISeq<T2>, ISeq<T3>, ISeq<T4>, ISeq<T5>, ISeq<T6>, ISeq<T7>, Tuple<ISeq<T8>, ISeq<T9>, ISeq<T10>, ISeq<T11>, ISeq<T12>>> Unzip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self)
        {
            return TupleModule.Create(self.Map(x => x._1()), self.Map(x => x._2()), self.Map(x => x._3()), self.Map(x => x._4()), self.Map(x => x._5()), self.Map(x => x._6()), self.Map(x => x._7()), self.Map(x => x._8()), self.Map(x => x._9()), self.Map(x => x._10()), self.Map(x => x._11()), self.Map(x => x._12()));
        }

        /// <summary>13個のシーケンスの要素1つ1つに対して、fを適用したシーケンスを返します。</summary>
        public static ISeq<U> ZipWith<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this ISeq<T1> ie1, ISeq<T2> ie2, ISeq<T3> ie3, ISeq<T4> ie4, ISeq<T5> ie5, ISeq<T6> ie6, ISeq<T7> ie7, ISeq<T8> ie8, ISeq<T9> ie9, ISeq<T10> ie10, ISeq<T11> ie11, ISeq<T12> ie12, ISeq<T13> ie13, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> f)
        {
            return new Seq<U>(Enumerable.ZipWith(ie1, ie2, ie3, ie4, ie5, ie6, ie7, ie8, ie9, ie10, ie11, ie12, ie13, f));
        }

        /// <summary>13個のシーケンスをZipします。</summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ISeq<T1> ie1, ISeq<T2> ie2, ISeq<T3> ie3, ISeq<T4> ie4, ISeq<T5> ie5, ISeq<T6> ie6, ISeq<T7> ie7, ISeq<T8> ie8, ISeq<T9> ie9, ISeq<T10> ie10, ISeq<T11> ie11, ISeq<T12> ie12, ISeq<T13> ie13)
        {
            return new Seq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>>(Enumerable.Zip(ie1, ie2, ie3, ie4, ie5, ie6, ie7, ie8, ie9, ie10, ie11, ie12, ie13));
        }

        /// <summary>Zipされたシーケンスを元に戻し、13個のシーケンスのタプルとして返します。</summary>
        public static Tuple<ISeq<T1>, ISeq<T2>, ISeq<T3>, ISeq<T4>, ISeq<T5>, ISeq<T6>, ISeq<T7>, Tuple<ISeq<T8>, ISeq<T9>, ISeq<T10>, ISeq<T11>, ISeq<T12>, ISeq<T13>>> Unzip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self)
        {
            return TupleModule.Create(self.Map(x => x._1()), self.Map(x => x._2()), self.Map(x => x._3()), self.Map(x => x._4()), self.Map(x => x._5()), self.Map(x => x._6()), self.Map(x => x._7()), self.Map(x => x._8()), self.Map(x => x._9()), self.Map(x => x._10()), self.Map(x => x._11()), self.Map(x => x._12()), self.Map(x => x._13()));
        }

        /// <summary>14個のシーケンスの要素1つ1つに対して、fを適用したシーケンスを返します。</summary>
        public static ISeq<U> ZipWith<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this ISeq<T1> ie1, ISeq<T2> ie2, ISeq<T3> ie3, ISeq<T4> ie4, ISeq<T5> ie5, ISeq<T6> ie6, ISeq<T7> ie7, ISeq<T8> ie8, ISeq<T9> ie9, ISeq<T10> ie10, ISeq<T11> ie11, ISeq<T12> ie12, ISeq<T13> ie13, ISeq<T14> ie14, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> f)
        {
            return new Seq<U>(Enumerable.ZipWith(ie1, ie2, ie3, ie4, ie5, ie6, ie7, ie8, ie9, ie10, ie11, ie12, ie13, ie14, f));
        }

        /// <summary>14個のシーケンスをZipします。</summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ISeq<T1> ie1, ISeq<T2> ie2, ISeq<T3> ie3, ISeq<T4> ie4, ISeq<T5> ie5, ISeq<T6> ie6, ISeq<T7> ie7, ISeq<T8> ie8, ISeq<T9> ie9, ISeq<T10> ie10, ISeq<T11> ie11, ISeq<T12> ie12, ISeq<T13> ie13, ISeq<T14> ie14)
        {
            return new Seq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>>(Enumerable.Zip(ie1, ie2, ie3, ie4, ie5, ie6, ie7, ie8, ie9, ie10, ie11, ie12, ie13, ie14));
        }

        /// <summary>Zipされたシーケンスを元に戻し、14個のシーケンスのタプルとして返します。</summary>
        public static Tuple<ISeq<T1>, ISeq<T2>, ISeq<T3>, ISeq<T4>, ISeq<T5>, ISeq<T6>, ISeq<T7>, Tuple<ISeq<T8>, ISeq<T9>, ISeq<T10>, ISeq<T11>, ISeq<T12>, ISeq<T13>, ISeq<T14>>> Unzip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self)
        {
            return TupleModule.Create(self.Map(x => x._1()), self.Map(x => x._2()), self.Map(x => x._3()), self.Map(x => x._4()), self.Map(x => x._5()), self.Map(x => x._6()), self.Map(x => x._7()), self.Map(x => x._8()), self.Map(x => x._9()), self.Map(x => x._10()), self.Map(x => x._11()), self.Map(x => x._12()), self.Map(x => x._13()), self.Map(x => x._14()));
        }

        /// <summary>15個のシーケンスの要素1つ1つに対して、fを適用したシーケンスを返します。</summary>
        public static ISeq<U> ZipWith<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this ISeq<T1> ie1, ISeq<T2> ie2, ISeq<T3> ie3, ISeq<T4> ie4, ISeq<T5> ie5, ISeq<T6> ie6, ISeq<T7> ie7, ISeq<T8> ie8, ISeq<T9> ie9, ISeq<T10> ie10, ISeq<T11> ie11, ISeq<T12> ie12, ISeq<T13> ie13, ISeq<T14> ie14, ISeq<T15> ie15, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> f)
        {
            return new Seq<U>(Enumerable.ZipWith(ie1, ie2, ie3, ie4, ie5, ie6, ie7, ie8, ie9, ie10, ie11, ie12, ie13, ie14, ie15, f));
        }

        /// <summary>15個のシーケンスをZipします。</summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ISeq<T1> ie1, ISeq<T2> ie2, ISeq<T3> ie3, ISeq<T4> ie4, ISeq<T5> ie5, ISeq<T6> ie6, ISeq<T7> ie7, ISeq<T8> ie8, ISeq<T9> ie9, ISeq<T10> ie10, ISeq<T11> ie11, ISeq<T12> ie12, ISeq<T13> ie13, ISeq<T14> ie14, ISeq<T15> ie15)
        {
            return new Seq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>>(Enumerable.Zip(ie1, ie2, ie3, ie4, ie5, ie6, ie7, ie8, ie9, ie10, ie11, ie12, ie13, ie14, ie15));
        }

        /// <summary>Zipされたシーケンスを元に戻し、15個のシーケンスのタプルとして返します。</summary>
        public static Tuple<ISeq<T1>, ISeq<T2>, ISeq<T3>, ISeq<T4>, ISeq<T5>, ISeq<T6>, ISeq<T7>, Tuple<ISeq<T8>, ISeq<T9>, ISeq<T10>, ISeq<T11>, ISeq<T12>, ISeq<T13>, ISeq<T14>, Tuple<ISeq<T15>>>> Unzip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self)
        {
            return TupleModule.Create(self.Map(x => x._1()), self.Map(x => x._2()), self.Map(x => x._3()), self.Map(x => x._4()), self.Map(x => x._5()), self.Map(x => x._6()), self.Map(x => x._7()), self.Map(x => x._8()), self.Map(x => x._9()), self.Map(x => x._10()), self.Map(x => x._11()), self.Map(x => x._12()), self.Map(x => x._13()), self.Map(x => x._14()), self.Map(x => x._15()));
        }

        /// <summary>16個のシーケンスの要素1つ1つに対して、fを適用したシーケンスを返します。</summary>
        public static ISeq<U> ZipWith<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this ISeq<T1> ie1, ISeq<T2> ie2, ISeq<T3> ie3, ISeq<T4> ie4, ISeq<T5> ie5, ISeq<T6> ie6, ISeq<T7> ie7, ISeq<T8> ie8, ISeq<T9> ie9, ISeq<T10> ie10, ISeq<T11> ie11, ISeq<T12> ie12, ISeq<T13> ie13, ISeq<T14> ie14, ISeq<T15> ie15, ISeq<T16> ie16, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> f)
        {
            return new Seq<U>(Enumerable.ZipWith(ie1, ie2, ie3, ie4, ie5, ie6, ie7, ie8, ie9, ie10, ie11, ie12, ie13, ie14, ie15, ie16, f));
        }

        /// <summary>16個のシーケンスをZipします。</summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this ISeq<T1> ie1, ISeq<T2> ie2, ISeq<T3> ie3, ISeq<T4> ie4, ISeq<T5> ie5, ISeq<T6> ie6, ISeq<T7> ie7, ISeq<T8> ie8, ISeq<T9> ie9, ISeq<T10> ie10, ISeq<T11> ie11, ISeq<T12> ie12, ISeq<T13> ie13, ISeq<T14> ie14, ISeq<T15> ie15, ISeq<T16> ie16)
        {
            return new Seq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>>(Enumerable.Zip(ie1, ie2, ie3, ie4, ie5, ie6, ie7, ie8, ie9, ie10, ie11, ie12, ie13, ie14, ie15, ie16));
        }

        /// <summary>Zipされたシーケンスを元に戻し、16個のシーケンスのタプルとして返します。</summary>
        public static Tuple<ISeq<T1>, ISeq<T2>, ISeq<T3>, ISeq<T4>, ISeq<T5>, ISeq<T6>, ISeq<T7>, Tuple<ISeq<T8>, ISeq<T9>, ISeq<T10>, ISeq<T11>, ISeq<T12>, ISeq<T13>, ISeq<T14>, Tuple<ISeq<T15>, ISeq<T16>>>> Unzip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self)
        {
            return TupleModule.Create(self.Map(x => x._1()), self.Map(x => x._2()), self.Map(x => x._3()), self.Map(x => x._4()), self.Map(x => x._5()), self.Map(x => x._6()), self.Map(x => x._7()), self.Map(x => x._8()), self.Map(x => x._9()), self.Map(x => x._10()), self.Map(x => x._11()), self.Map(x => x._12()), self.Map(x => x._13()), self.Map(x => x._14()), self.Map(x => x._15()), self.Map(x => x._16()));
        }


        /// <summary>シーケンスに対して、0から始まる整数列をZipします。</summary>
        public static ISeq<Tuple<T1, int>> WithIndex<T1>(this ISeq<T1> self)
        {
            return self.Zip(InitInfinite(Func.Id));
        }

        /// <summary>2要素のタプルのシーケンスに対して、0から始まる整数列を加えたタプルのシーケンスとして返します。</summary>
        public static ISeq<Tuple<T1, T2, int>> WithIndex<T1, T2>(this ISeq<Tuple<T1, T2>> self)
        {
            return new Seq<Tuple<T1, T2, int>>(self.WithIndex());
        }

        /// <summary>3要素のタプルのシーケンスに対して、0から始まる整数列を加えたタプルのシーケンスとして返します。</summary>
        public static ISeq<Tuple<T1, T2, T3, int>> WithIndex<T1, T2, T3>(this ISeq<Tuple<T1, T2, T3>> self)
        {
            return new Seq<Tuple<T1, T2, T3, int>>(self.WithIndex());
        }

        /// <summary>4要素のタプルのシーケンスに対して、0から始まる整数列を加えたタプルのシーケンスとして返します。</summary>
        public static ISeq<Tuple<T1, T2, T3, T4, int>> WithIndex<T1, T2, T3, T4>(this ISeq<Tuple<T1, T2, T3, T4>> self)
        {
            return new Seq<Tuple<T1, T2, T3, T4, int>>(self.WithIndex());
        }

        /// <summary>5要素のタプルのシーケンスに対して、0から始まる整数列を加えたタプルのシーケンスとして返します。</summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, int>> WithIndex<T1, T2, T3, T4, T5>(this ISeq<Tuple<T1, T2, T3, T4, T5>> self)
        {
            return new Seq<Tuple<T1, T2, T3, T4, T5, int>>(self.WithIndex());
        }

        /// <summary>6要素のタプルのシーケンスに対して、0から始まる整数列を加えたタプルのシーケンスとして返します。</summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, int>> WithIndex<T1, T2, T3, T4, T5, T6>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6>> self)
        {
            return new Seq<Tuple<T1, T2, T3, T4, T5, T6, int>>(self.WithIndex());
        }

        /// <summary>7要素のタプルのシーケンスに対して、0から始まる整数列を加えたタプルのシーケンスとして返します。</summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<int>>> WithIndex<T1, T2, T3, T4, T5, T6, T7>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7>> self)
        {
            return new Seq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<int>>>(self.WithIndex());
        }

        /// <summary>8要素のタプルのシーケンスに対して、0から始まる整数列を加えたタプルのシーケンスとして返します。</summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, int>>> WithIndex<T1, T2, T3, T4, T5, T6, T7, T8>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self)
        {
            return new Seq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, int>>>(self.WithIndex());
        }

        /// <summary>9要素のタプルのシーケンスに対して、0から始まる整数列を加えたタプルのシーケンスとして返します。</summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, int>>> WithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self)
        {
            return new Seq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, int>>>(self.WithIndex());
        }

        /// <summary>10要素のタプルのシーケンスに対して、0から始まる整数列を加えたタプルのシーケンスとして返します。</summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, int>>> WithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self)
        {
            return new Seq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, int>>>(self.WithIndex());
        }

        /// <summary>11要素のタプルのシーケンスに対して、0から始まる整数列を加えたタプルのシーケンスとして返します。</summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, int>>> WithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self)
        {
            return new Seq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, int>>>(self.WithIndex());
        }

        /// <summary>12要素のタプルのシーケンスに対して、0から始まる整数列を加えたタプルのシーケンスとして返します。</summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, int>>> WithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self)
        {
            return new Seq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, int>>>(self.WithIndex());
        }

        /// <summary>13要素のタプルのシーケンスに対して、0から始まる整数列を加えたタプルのシーケンスとして返します。</summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, int>>> WithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self)
        {
            return new Seq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, int>>>(self.WithIndex());
        }

        /// <summary>14要素のタプルのシーケンスに対して、0から始まる整数列を加えたタプルのシーケンスとして返します。</summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<int>>>> WithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self)
        {
            return new Seq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<int>>>>(self.WithIndex());
        }

        /// <summary>15要素のタプルのシーケンスに対して、0から始まる整数列を加えたタプルのシーケンスとして返します。</summary>
        public static ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, int>>>> WithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this ISeq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self)
        {
            return new Seq<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, int>>>>(self.WithIndex());
        }

    }
}