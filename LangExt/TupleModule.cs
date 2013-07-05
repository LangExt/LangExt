
using System;

namespace LangExt
{
    partial class Create
    {
        /// <summary>2要素のタプルを生成します。</summary>
        public static Tuple<T1, T2> Tuple<T1, T2>(T1 t1, T2 t2)
        {
            return TupleModule.Create(t1, t2);
        }

        /// <summary>3要素のタプルを生成します。</summary>
        public static Tuple<T1, T2, T3> Tuple<T1, T2, T3>(T1 t1, T2 t2, T3 t3)
        {
            return TupleModule.Create(t1, t2, t3);
        }

        /// <summary>4要素のタプルを生成します。</summary>
        public static Tuple<T1, T2, T3, T4> Tuple<T1, T2, T3, T4>(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            return TupleModule.Create(t1, t2, t3, t4);
        }

        /// <summary>5要素のタプルを生成します。</summary>
        public static Tuple<T1, T2, T3, T4, T5> Tuple<T1, T2, T3, T4, T5>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            return TupleModule.Create(t1, t2, t3, t4, t5);
        }

        /// <summary>6要素のタプルを生成します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6> Tuple<T1, T2, T3, T4, T5, T6>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
        {
            return TupleModule.Create(t1, t2, t3, t4, t5, t6);
        }

        /// <summary>7要素のタプルを生成します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7> Tuple<T1, T2, T3, T4, T5, T6, T7>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
        {
            return TupleModule.Create(t1, t2, t3, t4, t5, t6, t7);
        }

        /// <summary>8要素のタプルを生成します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> Tuple<T1, T2, T3, T4, T5, T6, T7, T8>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
        {
            return TupleModule.Create(t1, t2, t3, t4, t5, t6, t7, t8);
        }

        /// <summary>9要素のタプルを生成します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> Tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
        {
            return TupleModule.Create(t1, t2, t3, t4, t5, t6, t7, t8, t9);
        }

        /// <summary>10要素のタプルを生成します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> Tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
        {
            return TupleModule.Create(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
        }

        /// <summary>11要素のタプルを生成します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> Tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
        {
            return TupleModule.Create(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
        }

        /// <summary>12要素のタプルを生成します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> Tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
        {
            return TupleModule.Create(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
        }

        /// <summary>13要素のタプルを生成します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> Tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
        {
            return TupleModule.Create(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
        }

        /// <summary>14要素のタプルを生成します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> Tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
        {
            return TupleModule.Create(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
        }

        /// <summary>15要素のタプルを生成します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> Tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
        {
            return TupleModule.Create(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
        }

        /// <summary>16要素のタプルを生成します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> Tuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16)
        {
            return TupleModule.Create(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);
        }

    }

    /// <summary>タプルに対する関数を提供します。</summary>
    public static class TupleModule
    {
        /// <summary>2要素のタプルを生成します。</summary>
        public static Tuple<T1, T2> Create<T1, T2>(T1 t1, T2 t2)
        {
            return new Tuple<T1, T2>(t1, t2);
        }
        /// <summary>2要素タプルから1番目の要素を取り出します。</summary>
        public static T1 Fst<T1, T2>(this Tuple<T1, T2> self) { return self.Item1; }
        /// <summary>2要素タプルから2番目の要素を取り出します。</summary>
        public static T2 Snd<T1, T2>(this Tuple<T1, T2> self) { return self.Item2; }
        /// <summary>2要素タプルから1番目の要素を取り出します。</summary>
        public static T1 _1<T1, T2>(this Tuple<T1, T2> self) { return self.Item1 ; }
        /// <summary>2要素タプルから2番目の要素を取り出します。</summary>
        public static T2 _2<T1, T2>(this Tuple<T1, T2> self) { return self.Item2 ; }

        /// <summary>2要素タプルに要素を追加し、3要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T1, T2, T3> Add<T1, T2, T3>(this Tuple<T1, T2> self, T3 t)
        {
            return LangExt.Create.Tuple(self._1(), self._2(), t);
        }
        /// <summary>2要素タプルに要素を追加し、3要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T0, T1, T2> AddFirst<T0, T1, T2>(this Tuple<T1, T2> self, T0 t)
        {
            return LangExt.Create.Tuple(t, self._1(), self._2());
        }


        /// <summary>2要素タプルに対して、擬似的にパターンマッチを行います。</summary>
        public static U Match<T1, T2, U>(this Tuple<T1, T2> self, Func<T1, T2, U> f)
        {
            return f(self._1(), self._2());
        }

        /// <summary>2要素タプルの1番目の要素に対して、関数を適用します。</summary>
        public static Tuple<U, T2> Map1<T1, T2, U>(this Tuple<T1, T2> self, Func<T1, U> f)
        {
            return TupleModule.Create(f(self._1()), self._2());
        }

        /// <summary>2要素タプルの2番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, U> Map2<T1, T2, U>(this Tuple<T1, T2> self, Func<T2, U> f)
        {
            return TupleModule.Create(self._1(), f(self._2()));
        }

        /// <summary>3要素のタプルを生成します。</summary>
        public static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 t1, T2 t2, T3 t3)
        {
            return new Tuple<T1, T2, T3>(t1, t2, t3);
        }
        /// <summary>3要素タプルから1番目の要素を取り出します。</summary>
        public static T1 Fst<T1, T2, T3>(this Tuple<T1, T2, T3> self) { return self.Item1; }
        /// <summary>3要素タプルから2番目の要素を取り出します。</summary>
        public static T2 Snd<T1, T2, T3>(this Tuple<T1, T2, T3> self) { return self.Item2; }
        /// <summary>3要素タプルから1番目の要素を取り出します。</summary>
        public static T1 _1<T1, T2, T3>(this Tuple<T1, T2, T3> self) { return self.Item1 ; }
        /// <summary>3要素タプルから2番目の要素を取り出します。</summary>
        public static T2 _2<T1, T2, T3>(this Tuple<T1, T2, T3> self) { return self.Item2 ; }
        /// <summary>3要素タプルから3番目の要素を取り出します。</summary>
        public static T3 _3<T1, T2, T3>(this Tuple<T1, T2, T3> self) { return self.Item3 ; }

        /// <summary>3要素タプルに要素を追加し、4要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T1, T2, T3, T4> Add<T1, T2, T3, T4>(this Tuple<T1, T2, T3> self, T4 t)
        {
            return LangExt.Create.Tuple(self._1(), self._2(), self._3(), t);
        }
        /// <summary>3要素タプルに要素を追加し、4要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T0, T1, T2, T3> AddFirst<T0, T1, T2, T3>(this Tuple<T1, T2, T3> self, T0 t)
        {
            return LangExt.Create.Tuple(t, self._1(), self._2(), self._3());
        }

        /// <summary>3要素タプルから末尾要素を削除し、2要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T1, T2> RemoveLast<T1, T2, T3>(this Tuple<T1, T2, T3> self)
        {
            return LangExt.Create.Tuple(self._1(), self._2());
        }
        /// <summary>3要素タプルから末尾要素を削除し、2要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T2, T3> RemoveFirst<T1, T2, T3>(this Tuple<T1, T2, T3> self)
        {
            return LangExt.Create.Tuple(self._2(), self._3());
        }

        /// <summary>3要素タプルに対して、擬似的にパターンマッチを行います。</summary>
        public static U Match<T1, T2, T3, U>(this Tuple<T1, T2, T3> self, Func<T1, T2, T3, U> f)
        {
            return f(self._1(), self._2(), self._3());
        }

        /// <summary>3要素タプルの1番目の要素に対して、関数を適用します。</summary>
        public static Tuple<U, T2, T3> Map1<T1, T2, T3, U>(this Tuple<T1, T2, T3> self, Func<T1, U> f)
        {
            return TupleModule.Create(f(self._1()), self._2(), self._3());
        }

        /// <summary>3要素タプルの2番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, U, T3> Map2<T1, T2, T3, U>(this Tuple<T1, T2, T3> self, Func<T2, U> f)
        {
            return TupleModule.Create(self._1(), f(self._2()), self._3());
        }

        /// <summary>3要素タプルの3番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, U> Map3<T1, T2, T3, U>(this Tuple<T1, T2, T3> self, Func<T3, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), f(self._3()));
        }

        /// <summary>4要素のタプルを生成します。</summary>
        public static Tuple<T1, T2, T3, T4> Create<T1, T2, T3, T4>(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            return new Tuple<T1, T2, T3, T4>(t1, t2, t3, t4);
        }
        /// <summary>4要素タプルから1番目の要素を取り出します。</summary>
        public static T1 Fst<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> self) { return self.Item1; }
        /// <summary>4要素タプルから2番目の要素を取り出します。</summary>
        public static T2 Snd<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> self) { return self.Item2; }
        /// <summary>4要素タプルから1番目の要素を取り出します。</summary>
        public static T1 _1<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> self) { return self.Item1 ; }
        /// <summary>4要素タプルから2番目の要素を取り出します。</summary>
        public static T2 _2<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> self) { return self.Item2 ; }
        /// <summary>4要素タプルから3番目の要素を取り出します。</summary>
        public static T3 _3<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> self) { return self.Item3 ; }
        /// <summary>4要素タプルから4番目の要素を取り出します。</summary>
        public static T4 _4<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> self) { return self.Item4 ; }

        /// <summary>4要素タプルに要素を追加し、5要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T1, T2, T3, T4, T5> Add<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4> self, T5 t)
        {
            return LangExt.Create.Tuple(self._1(), self._2(), self._3(), self._4(), t);
        }
        /// <summary>4要素タプルに要素を追加し、5要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T0, T1, T2, T3, T4> AddFirst<T0, T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> self, T0 t)
        {
            return LangExt.Create.Tuple(t, self._1(), self._2(), self._3(), self._4());
        }

        /// <summary>4要素タプルから末尾要素を削除し、3要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T1, T2, T3> RemoveLast<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> self)
        {
            return LangExt.Create.Tuple(self._1(), self._2(), self._3());
        }
        /// <summary>4要素タプルから末尾要素を削除し、3要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T2, T3, T4> RemoveFirst<T1, T2, T3, T4>(this Tuple<T1, T2, T3, T4> self)
        {
            return LangExt.Create.Tuple(self._2(), self._3(), self._4());
        }

        /// <summary>4要素タプルに対して、擬似的にパターンマッチを行います。</summary>
        public static U Match<T1, T2, T3, T4, U>(this Tuple<T1, T2, T3, T4> self, Func<T1, T2, T3, T4, U> f)
        {
            return f(self._1(), self._2(), self._3(), self._4());
        }

        /// <summary>4要素タプルの1番目の要素に対して、関数を適用します。</summary>
        public static Tuple<U, T2, T3, T4> Map1<T1, T2, T3, T4, U>(this Tuple<T1, T2, T3, T4> self, Func<T1, U> f)
        {
            return TupleModule.Create(f(self._1()), self._2(), self._3(), self._4());
        }

        /// <summary>4要素タプルの2番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, U, T3, T4> Map2<T1, T2, T3, T4, U>(this Tuple<T1, T2, T3, T4> self, Func<T2, U> f)
        {
            return TupleModule.Create(self._1(), f(self._2()), self._3(), self._4());
        }

        /// <summary>4要素タプルの3番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, U, T4> Map3<T1, T2, T3, T4, U>(this Tuple<T1, T2, T3, T4> self, Func<T3, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), f(self._3()), self._4());
        }

        /// <summary>4要素タプルの4番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, U> Map4<T1, T2, T3, T4, U>(this Tuple<T1, T2, T3, T4> self, Func<T4, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), f(self._4()));
        }

        /// <summary>5要素のタプルを生成します。</summary>
        public static Tuple<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            return new Tuple<T1, T2, T3, T4, T5>(t1, t2, t3, t4, t5);
        }
        /// <summary>5要素タプルから1番目の要素を取り出します。</summary>
        public static T1 Fst<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> self) { return self.Item1; }
        /// <summary>5要素タプルから2番目の要素を取り出します。</summary>
        public static T2 Snd<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> self) { return self.Item2; }
        /// <summary>5要素タプルから1番目の要素を取り出します。</summary>
        public static T1 _1<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> self) { return self.Item1 ; }
        /// <summary>5要素タプルから2番目の要素を取り出します。</summary>
        public static T2 _2<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> self) { return self.Item2 ; }
        /// <summary>5要素タプルから3番目の要素を取り出します。</summary>
        public static T3 _3<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> self) { return self.Item3 ; }
        /// <summary>5要素タプルから4番目の要素を取り出します。</summary>
        public static T4 _4<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> self) { return self.Item4 ; }
        /// <summary>5要素タプルから5番目の要素を取り出します。</summary>
        public static T5 _5<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> self) { return self.Item5 ; }

        /// <summary>5要素タプルに要素を追加し、6要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6> Add<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5> self, T6 t)
        {
            return LangExt.Create.Tuple(self._1(), self._2(), self._3(), self._4(), self._5(), t);
        }
        /// <summary>5要素タプルに要素を追加し、6要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T0, T1, T2, T3, T4, T5> AddFirst<T0, T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> self, T0 t)
        {
            return LangExt.Create.Tuple(t, self._1(), self._2(), self._3(), self._4(), self._5());
        }

        /// <summary>5要素タプルから末尾要素を削除し、4要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T1, T2, T3, T4> RemoveLast<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> self)
        {
            return LangExt.Create.Tuple(self._1(), self._2(), self._3(), self._4());
        }
        /// <summary>5要素タプルから末尾要素を削除し、4要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T2, T3, T4, T5> RemoveFirst<T1, T2, T3, T4, T5>(this Tuple<T1, T2, T3, T4, T5> self)
        {
            return LangExt.Create.Tuple(self._2(), self._3(), self._4(), self._5());
        }

        /// <summary>5要素タプルに対して、擬似的にパターンマッチを行います。</summary>
        public static U Match<T1, T2, T3, T4, T5, U>(this Tuple<T1, T2, T3, T4, T5> self, Func<T1, T2, T3, T4, T5, U> f)
        {
            return f(self._1(), self._2(), self._3(), self._4(), self._5());
        }

        /// <summary>5要素タプルの1番目の要素に対して、関数を適用します。</summary>
        public static Tuple<U, T2, T3, T4, T5> Map1<T1, T2, T3, T4, T5, U>(this Tuple<T1, T2, T3, T4, T5> self, Func<T1, U> f)
        {
            return TupleModule.Create(f(self._1()), self._2(), self._3(), self._4(), self._5());
        }

        /// <summary>5要素タプルの2番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, U, T3, T4, T5> Map2<T1, T2, T3, T4, T5, U>(this Tuple<T1, T2, T3, T4, T5> self, Func<T2, U> f)
        {
            return TupleModule.Create(self._1(), f(self._2()), self._3(), self._4(), self._5());
        }

        /// <summary>5要素タプルの3番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, U, T4, T5> Map3<T1, T2, T3, T4, T5, U>(this Tuple<T1, T2, T3, T4, T5> self, Func<T3, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), f(self._3()), self._4(), self._5());
        }

        /// <summary>5要素タプルの4番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, U, T5> Map4<T1, T2, T3, T4, T5, U>(this Tuple<T1, T2, T3, T4, T5> self, Func<T4, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), f(self._4()), self._5());
        }

        /// <summary>5要素タプルの5番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, U> Map5<T1, T2, T3, T4, T5, U>(this Tuple<T1, T2, T3, T4, T5> self, Func<T5, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), f(self._5()));
        }

        /// <summary>6要素のタプルを生成します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6>(t1, t2, t3, t4, t5, t6);
        }
        /// <summary>6要素タプルから1番目の要素を取り出します。</summary>
        public static T1 Fst<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> self) { return self.Item1; }
        /// <summary>6要素タプルから2番目の要素を取り出します。</summary>
        public static T2 Snd<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> self) { return self.Item2; }
        /// <summary>6要素タプルから1番目の要素を取り出します。</summary>
        public static T1 _1<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> self) { return self.Item1 ; }
        /// <summary>6要素タプルから2番目の要素を取り出します。</summary>
        public static T2 _2<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> self) { return self.Item2 ; }
        /// <summary>6要素タプルから3番目の要素を取り出します。</summary>
        public static T3 _3<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> self) { return self.Item3 ; }
        /// <summary>6要素タプルから4番目の要素を取り出します。</summary>
        public static T4 _4<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> self) { return self.Item4 ; }
        /// <summary>6要素タプルから5番目の要素を取り出します。</summary>
        public static T5 _5<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> self) { return self.Item5 ; }
        /// <summary>6要素タプルから6番目の要素を取り出します。</summary>
        public static T6 _6<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> self) { return self.Item6 ; }

        /// <summary>6要素タプルに要素を追加し、7要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7> Add<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6> self, T7 t)
        {
            return LangExt.Create.Tuple(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), t);
        }
        /// <summary>6要素タプルに要素を追加し、7要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T0, T1, T2, T3, T4, T5, T6> AddFirst<T0, T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> self, T0 t)
        {
            return LangExt.Create.Tuple(t, self._1(), self._2(), self._3(), self._4(), self._5(), self._6());
        }

        /// <summary>6要素タプルから末尾要素を削除し、5要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T1, T2, T3, T4, T5> RemoveLast<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> self)
        {
            return LangExt.Create.Tuple(self._1(), self._2(), self._3(), self._4(), self._5());
        }
        /// <summary>6要素タプルから末尾要素を削除し、5要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T2, T3, T4, T5, T6> RemoveFirst<T1, T2, T3, T4, T5, T6>(this Tuple<T1, T2, T3, T4, T5, T6> self)
        {
            return LangExt.Create.Tuple(self._2(), self._3(), self._4(), self._5(), self._6());
        }

        /// <summary>6要素タプルに対して、擬似的にパターンマッチを行います。</summary>
        public static U Match<T1, T2, T3, T4, T5, T6, U>(this Tuple<T1, T2, T3, T4, T5, T6> self, Func<T1, T2, T3, T4, T5, T6, U> f)
        {
            return f(self._1(), self._2(), self._3(), self._4(), self._5(), self._6());
        }

        /// <summary>6要素タプルの1番目の要素に対して、関数を適用します。</summary>
        public static Tuple<U, T2, T3, T4, T5, T6> Map1<T1, T2, T3, T4, T5, T6, U>(this Tuple<T1, T2, T3, T4, T5, T6> self, Func<T1, U> f)
        {
            return TupleModule.Create(f(self._1()), self._2(), self._3(), self._4(), self._5(), self._6());
        }

        /// <summary>6要素タプルの2番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, U, T3, T4, T5, T6> Map2<T1, T2, T3, T4, T5, T6, U>(this Tuple<T1, T2, T3, T4, T5, T6> self, Func<T2, U> f)
        {
            return TupleModule.Create(self._1(), f(self._2()), self._3(), self._4(), self._5(), self._6());
        }

        /// <summary>6要素タプルの3番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, U, T4, T5, T6> Map3<T1, T2, T3, T4, T5, T6, U>(this Tuple<T1, T2, T3, T4, T5, T6> self, Func<T3, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), f(self._3()), self._4(), self._5(), self._6());
        }

        /// <summary>6要素タプルの4番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, U, T5, T6> Map4<T1, T2, T3, T4, T5, T6, U>(this Tuple<T1, T2, T3, T4, T5, T6> self, Func<T4, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), f(self._4()), self._5(), self._6());
        }

        /// <summary>6要素タプルの5番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, U, T6> Map5<T1, T2, T3, T4, T5, T6, U>(this Tuple<T1, T2, T3, T4, T5, T6> self, Func<T5, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), f(self._5()), self._6());
        }

        /// <summary>6要素タプルの6番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, U> Map6<T1, T2, T3, T4, T5, T6, U>(this Tuple<T1, T2, T3, T4, T5, T6> self, Func<T6, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), f(self._6()));
        }

        /// <summary>7要素のタプルを生成します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7>(t1, t2, t3, t4, t5, t6, t7);
        }
        /// <summary>7要素タプルから1番目の要素を取り出します。</summary>
        public static T1 Fst<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> self) { return self.Item1; }
        /// <summary>7要素タプルから2番目の要素を取り出します。</summary>
        public static T2 Snd<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> self) { return self.Item2; }
        /// <summary>7要素タプルから1番目の要素を取り出します。</summary>
        public static T1 _1<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> self) { return self.Item1 ; }
        /// <summary>7要素タプルから2番目の要素を取り出します。</summary>
        public static T2 _2<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> self) { return self.Item2 ; }
        /// <summary>7要素タプルから3番目の要素を取り出します。</summary>
        public static T3 _3<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> self) { return self.Item3 ; }
        /// <summary>7要素タプルから4番目の要素を取り出します。</summary>
        public static T4 _4<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> self) { return self.Item4 ; }
        /// <summary>7要素タプルから5番目の要素を取り出します。</summary>
        public static T5 _5<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> self) { return self.Item5 ; }
        /// <summary>7要素タプルから6番目の要素を取り出します。</summary>
        public static T6 _6<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> self) { return self.Item6 ; }
        /// <summary>7要素タプルから7番目の要素を取り出します。</summary>
        public static T7 _7<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> self) { return self.Item7 ; }

        /// <summary>7要素タプルに要素を追加し、8要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> Add<T1, T2, T3, T4, T5, T6, T7, T8>(this Tuple<T1, T2, T3, T4, T5, T6, T7> self, T8 t)
        {
            return LangExt.Create.Tuple(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), t);
        }
        /// <summary>7要素タプルに要素を追加し、8要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T0, T1, T2, T3, T4, T5, T6, Tuple<T7>> AddFirst<T0, T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> self, T0 t)
        {
            return LangExt.Create.Tuple(t, self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7());
        }

        /// <summary>7要素タプルから末尾要素を削除し、6要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6> RemoveLast<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> self)
        {
            return LangExt.Create.Tuple(self._1(), self._2(), self._3(), self._4(), self._5(), self._6());
        }
        /// <summary>7要素タプルから末尾要素を削除し、6要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T2, T3, T4, T5, T6, T7> RemoveFirst<T1, T2, T3, T4, T5, T6, T7>(this Tuple<T1, T2, T3, T4, T5, T6, T7> self)
        {
            return LangExt.Create.Tuple(self._2(), self._3(), self._4(), self._5(), self._6(), self._7());
        }

        /// <summary>7要素タプルに対して、擬似的にパターンマッチを行います。</summary>
        public static U Match<T1, T2, T3, T4, T5, T6, T7, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7> self, Func<T1, T2, T3, T4, T5, T6, T7, U> f)
        {
            return f(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7());
        }

        /// <summary>7要素タプルの1番目の要素に対して、関数を適用します。</summary>
        public static Tuple<U, T2, T3, T4, T5, T6, T7> Map1<T1, T2, T3, T4, T5, T6, T7, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7> self, Func<T1, U> f)
        {
            return TupleModule.Create(f(self._1()), self._2(), self._3(), self._4(), self._5(), self._6(), self._7());
        }

        /// <summary>7要素タプルの2番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, U, T3, T4, T5, T6, T7> Map2<T1, T2, T3, T4, T5, T6, T7, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7> self, Func<T2, U> f)
        {
            return TupleModule.Create(self._1(), f(self._2()), self._3(), self._4(), self._5(), self._6(), self._7());
        }

        /// <summary>7要素タプルの3番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, U, T4, T5, T6, T7> Map3<T1, T2, T3, T4, T5, T6, T7, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7> self, Func<T3, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), f(self._3()), self._4(), self._5(), self._6(), self._7());
        }

        /// <summary>7要素タプルの4番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, U, T5, T6, T7> Map4<T1, T2, T3, T4, T5, T6, T7, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7> self, Func<T4, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), f(self._4()), self._5(), self._6(), self._7());
        }

        /// <summary>7要素タプルの5番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, U, T6, T7> Map5<T1, T2, T3, T4, T5, T6, T7, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7> self, Func<T5, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), f(self._5()), self._6(), self._7());
        }

        /// <summary>7要素タプルの6番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, U, T7> Map6<T1, T2, T3, T4, T5, T6, T7, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7> self, Func<T6, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), f(self._6()), self._7());
        }

        /// <summary>7要素タプルの7番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, U> Map7<T1, T2, T3, T4, T5, T6, T7, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7> self, Func<T7, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), f(self._7()));
        }

        /// <summary>8要素のタプルを生成します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> Create<T1, T2, T3, T4, T5, T6, T7, T8>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>(t1, t2, t3, t4, t5, t6, t7, new Tuple<T8>(t8));
        }
        /// <summary>8要素タプルから1番目の要素を取り出します。</summary>
        public static T1 Fst<T1, T2, T3, T4, T5, T6, T7, T8>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> self) { return self.Item1; }
        /// <summary>8要素タプルから2番目の要素を取り出します。</summary>
        public static T2 Snd<T1, T2, T3, T4, T5, T6, T7, T8>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> self) { return self.Item2; }
        /// <summary>8要素タプルから1番目の要素を取り出します。</summary>
        public static T1 _1<T1, T2, T3, T4, T5, T6, T7, T8>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> self) { return self.Item1 ; }
        /// <summary>8要素タプルから2番目の要素を取り出します。</summary>
        public static T2 _2<T1, T2, T3, T4, T5, T6, T7, T8>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> self) { return self.Item2 ; }
        /// <summary>8要素タプルから3番目の要素を取り出します。</summary>
        public static T3 _3<T1, T2, T3, T4, T5, T6, T7, T8>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> self) { return self.Item3 ; }
        /// <summary>8要素タプルから4番目の要素を取り出します。</summary>
        public static T4 _4<T1, T2, T3, T4, T5, T6, T7, T8>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> self) { return self.Item4 ; }
        /// <summary>8要素タプルから5番目の要素を取り出します。</summary>
        public static T5 _5<T1, T2, T3, T4, T5, T6, T7, T8>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> self) { return self.Item5 ; }
        /// <summary>8要素タプルから6番目の要素を取り出します。</summary>
        public static T6 _6<T1, T2, T3, T4, T5, T6, T7, T8>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> self) { return self.Item6 ; }
        /// <summary>8要素タプルから7番目の要素を取り出します。</summary>
        public static T7 _7<T1, T2, T3, T4, T5, T6, T7, T8>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> self) { return self.Item7 ; }
        /// <summary>8要素タプルから8番目の要素を取り出します。</summary>
        public static T8 _8<T1, T2, T3, T4, T5, T6, T7, T8>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> self) { return self.Rest.Item1 ; }

        /// <summary>8要素タプルに要素を追加し、9要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> Add<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> self, T9 t)
        {
            return LangExt.Create.Tuple(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), t);
        }
        /// <summary>8要素タプルに要素を追加し、9要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T0, T1, T2, T3, T4, T5, T6, Tuple<T7, T8>> AddFirst<T0, T1, T2, T3, T4, T5, T6, T7, T8>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> self, T0 t)
        {
            return LangExt.Create.Tuple(t, self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8());
        }

        /// <summary>8要素タプルから末尾要素を削除し、7要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7> RemoveLast<T1, T2, T3, T4, T5, T6, T7, T8>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> self)
        {
            return LangExt.Create.Tuple(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7());
        }
        /// <summary>8要素タプルから末尾要素を削除し、7要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T2, T3, T4, T5, T6, T7, T8> RemoveFirst<T1, T2, T3, T4, T5, T6, T7, T8>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> self)
        {
            return LangExt.Create.Tuple(self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8());
        }

        /// <summary>8要素タプルに対して、擬似的にパターンマッチを行います。</summary>
        public static U Match<T1, T2, T3, T4, T5, T6, T7, T8, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, U> f)
        {
            return f(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8());
        }

        /// <summary>8要素タプルの1番目の要素に対して、関数を適用します。</summary>
        public static Tuple<U, T2, T3, T4, T5, T6, T7, Tuple<T8>> Map1<T1, T2, T3, T4, T5, T6, T7, T8, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> self, Func<T1, U> f)
        {
            return TupleModule.Create(f(self._1()), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8());
        }

        /// <summary>8要素タプルの2番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, U, T3, T4, T5, T6, T7, Tuple<T8>> Map2<T1, T2, T3, T4, T5, T6, T7, T8, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> self, Func<T2, U> f)
        {
            return TupleModule.Create(self._1(), f(self._2()), self._3(), self._4(), self._5(), self._6(), self._7(), self._8());
        }

        /// <summary>8要素タプルの3番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, U, T4, T5, T6, T7, Tuple<T8>> Map3<T1, T2, T3, T4, T5, T6, T7, T8, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> self, Func<T3, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), f(self._3()), self._4(), self._5(), self._6(), self._7(), self._8());
        }

        /// <summary>8要素タプルの4番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, U, T5, T6, T7, Tuple<T8>> Map4<T1, T2, T3, T4, T5, T6, T7, T8, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> self, Func<T4, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), f(self._4()), self._5(), self._6(), self._7(), self._8());
        }

        /// <summary>8要素タプルの5番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, U, T6, T7, Tuple<T8>> Map5<T1, T2, T3, T4, T5, T6, T7, T8, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> self, Func<T5, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), f(self._5()), self._6(), self._7(), self._8());
        }

        /// <summary>8要素タプルの6番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, U, T7, Tuple<T8>> Map6<T1, T2, T3, T4, T5, T6, T7, T8, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> self, Func<T6, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), f(self._6()), self._7(), self._8());
        }

        /// <summary>8要素タプルの7番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, U, Tuple<T8>> Map7<T1, T2, T3, T4, T5, T6, T7, T8, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> self, Func<T7, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), f(self._7()), self._8());
        }

        /// <summary>8要素タプルの8番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<U>> Map8<T1, T2, T3, T4, T5, T6, T7, T8, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> self, Func<T8, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), f(self._8()));
        }

        /// <summary>9要素のタプルを生成します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>(t1, t2, t3, t4, t5, t6, t7, new Tuple<T8, T9>(t8, t9));
        }
        /// <summary>9要素タプルから1番目の要素を取り出します。</summary>
        public static T1 Fst<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> self) { return self.Item1; }
        /// <summary>9要素タプルから2番目の要素を取り出します。</summary>
        public static T2 Snd<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> self) { return self.Item2; }
        /// <summary>9要素タプルから1番目の要素を取り出します。</summary>
        public static T1 _1<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> self) { return self.Item1 ; }
        /// <summary>9要素タプルから2番目の要素を取り出します。</summary>
        public static T2 _2<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> self) { return self.Item2 ; }
        /// <summary>9要素タプルから3番目の要素を取り出します。</summary>
        public static T3 _3<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> self) { return self.Item3 ; }
        /// <summary>9要素タプルから4番目の要素を取り出します。</summary>
        public static T4 _4<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> self) { return self.Item4 ; }
        /// <summary>9要素タプルから5番目の要素を取り出します。</summary>
        public static T5 _5<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> self) { return self.Item5 ; }
        /// <summary>9要素タプルから6番目の要素を取り出します。</summary>
        public static T6 _6<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> self) { return self.Item6 ; }
        /// <summary>9要素タプルから7番目の要素を取り出します。</summary>
        public static T7 _7<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> self) { return self.Item7 ; }
        /// <summary>9要素タプルから8番目の要素を取り出します。</summary>
        public static T8 _8<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> self) { return self.Rest.Item1 ; }
        /// <summary>9要素タプルから9番目の要素を取り出します。</summary>
        public static T9 _9<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> self) { return self.Rest.Item2 ; }

        /// <summary>9要素タプルに要素を追加し、10要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> Add<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> self, T10 t)
        {
            return LangExt.Create.Tuple(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), t);
        }
        /// <summary>9要素タプルに要素を追加し、10要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T0, T1, T2, T3, T4, T5, T6, Tuple<T7, T8, T9>> AddFirst<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> self, T0 t)
        {
            return LangExt.Create.Tuple(t, self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9());
        }

        /// <summary>9要素タプルから末尾要素を削除し、8要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> RemoveLast<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> self)
        {
            return LangExt.Create.Tuple(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8());
        }
        /// <summary>9要素タプルから末尾要素を削除し、8要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T2, T3, T4, T5, T6, T7, T8, Tuple<T9>> RemoveFirst<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> self)
        {
            return LangExt.Create.Tuple(self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9());
        }

        /// <summary>9要素タプルに対して、擬似的にパターンマッチを行います。</summary>
        public static U Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> f)
        {
            return f(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9());
        }

        /// <summary>9要素タプルの1番目の要素に対して、関数を適用します。</summary>
        public static Tuple<U, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> Map1<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> self, Func<T1, U> f)
        {
            return TupleModule.Create(f(self._1()), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9());
        }

        /// <summary>9要素タプルの2番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, U, T3, T4, T5, T6, T7, Tuple<T8, T9>> Map2<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> self, Func<T2, U> f)
        {
            return TupleModule.Create(self._1(), f(self._2()), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9());
        }

        /// <summary>9要素タプルの3番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, U, T4, T5, T6, T7, Tuple<T8, T9>> Map3<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> self, Func<T3, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), f(self._3()), self._4(), self._5(), self._6(), self._7(), self._8(), self._9());
        }

        /// <summary>9要素タプルの4番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, U, T5, T6, T7, Tuple<T8, T9>> Map4<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> self, Func<T4, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), f(self._4()), self._5(), self._6(), self._7(), self._8(), self._9());
        }

        /// <summary>9要素タプルの5番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, U, T6, T7, Tuple<T8, T9>> Map5<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> self, Func<T5, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), f(self._5()), self._6(), self._7(), self._8(), self._9());
        }

        /// <summary>9要素タプルの6番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, U, T7, Tuple<T8, T9>> Map6<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> self, Func<T6, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), f(self._6()), self._7(), self._8(), self._9());
        }

        /// <summary>9要素タプルの7番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, U, Tuple<T8, T9>> Map7<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> self, Func<T7, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), f(self._7()), self._8(), self._9());
        }

        /// <summary>9要素タプルの8番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<U, T9>> Map8<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> self, Func<T8, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), f(self._8()), self._9());
        }

        /// <summary>9要素タプルの9番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, U>> Map9<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> self, Func<T9, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), f(self._9()));
        }

        /// <summary>10要素のタプルを生成します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>(t1, t2, t3, t4, t5, t6, t7, new Tuple<T8, T9, T10>(t8, t9, t10));
        }
        /// <summary>10要素タプルから1番目の要素を取り出します。</summary>
        public static T1 Fst<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> self) { return self.Item1; }
        /// <summary>10要素タプルから2番目の要素を取り出します。</summary>
        public static T2 Snd<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> self) { return self.Item2; }
        /// <summary>10要素タプルから1番目の要素を取り出します。</summary>
        public static T1 _1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> self) { return self.Item1 ; }
        /// <summary>10要素タプルから2番目の要素を取り出します。</summary>
        public static T2 _2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> self) { return self.Item2 ; }
        /// <summary>10要素タプルから3番目の要素を取り出します。</summary>
        public static T3 _3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> self) { return self.Item3 ; }
        /// <summary>10要素タプルから4番目の要素を取り出します。</summary>
        public static T4 _4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> self) { return self.Item4 ; }
        /// <summary>10要素タプルから5番目の要素を取り出します。</summary>
        public static T5 _5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> self) { return self.Item5 ; }
        /// <summary>10要素タプルから6番目の要素を取り出します。</summary>
        public static T6 _6<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> self) { return self.Item6 ; }
        /// <summary>10要素タプルから7番目の要素を取り出します。</summary>
        public static T7 _7<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> self) { return self.Item7 ; }
        /// <summary>10要素タプルから8番目の要素を取り出します。</summary>
        public static T8 _8<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> self) { return self.Rest.Item1 ; }
        /// <summary>10要素タプルから9番目の要素を取り出します。</summary>
        public static T9 _9<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> self) { return self.Rest.Item2 ; }
        /// <summary>10要素タプルから10番目の要素を取り出します。</summary>
        public static T10 _10<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> self) { return self.Rest.Item3 ; }

        /// <summary>10要素タプルに要素を追加し、11要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> Add<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> self, T11 t)
        {
            return LangExt.Create.Tuple(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), t);
        }
        /// <summary>10要素タプルに要素を追加し、11要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T0, T1, T2, T3, T4, T5, T6, Tuple<T7, T8, T9, T10>> AddFirst<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> self, T0 t)
        {
            return LangExt.Create.Tuple(t, self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10());
        }

        /// <summary>10要素タプルから末尾要素を削除し、9要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>> RemoveLast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> self)
        {
            return LangExt.Create.Tuple(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9());
        }
        /// <summary>10要素タプルから末尾要素を削除し、9要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T2, T3, T4, T5, T6, T7, T8, Tuple<T9, T10>> RemoveFirst<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> self)
        {
            return LangExt.Create.Tuple(self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10());
        }

        /// <summary>10要素タプルに対して、擬似的にパターンマッチを行います。</summary>
        public static U Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> f)
        {
            return f(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10());
        }

        /// <summary>10要素タプルの1番目の要素に対して、関数を適用します。</summary>
        public static Tuple<U, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> Map1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> self, Func<T1, U> f)
        {
            return TupleModule.Create(f(self._1()), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10());
        }

        /// <summary>10要素タプルの2番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, U, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> Map2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> self, Func<T2, U> f)
        {
            return TupleModule.Create(self._1(), f(self._2()), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10());
        }

        /// <summary>10要素タプルの3番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, U, T4, T5, T6, T7, Tuple<T8, T9, T10>> Map3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> self, Func<T3, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), f(self._3()), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10());
        }

        /// <summary>10要素タプルの4番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, U, T5, T6, T7, Tuple<T8, T9, T10>> Map4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> self, Func<T4, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), f(self._4()), self._5(), self._6(), self._7(), self._8(), self._9(), self._10());
        }

        /// <summary>10要素タプルの5番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, U, T6, T7, Tuple<T8, T9, T10>> Map5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> self, Func<T5, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), f(self._5()), self._6(), self._7(), self._8(), self._9(), self._10());
        }

        /// <summary>10要素タプルの6番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, U, T7, Tuple<T8, T9, T10>> Map6<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> self, Func<T6, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), f(self._6()), self._7(), self._8(), self._9(), self._10());
        }

        /// <summary>10要素タプルの7番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, U, Tuple<T8, T9, T10>> Map7<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> self, Func<T7, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), f(self._7()), self._8(), self._9(), self._10());
        }

        /// <summary>10要素タプルの8番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<U, T9, T10>> Map8<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> self, Func<T8, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), f(self._8()), self._9(), self._10());
        }

        /// <summary>10要素タプルの9番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, U, T10>> Map9<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> self, Func<T9, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), f(self._9()), self._10());
        }

        /// <summary>10要素タプルの10番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, U>> Map10<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> self, Func<T10, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), f(self._10()));
        }

        /// <summary>11要素のタプルを生成します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>(t1, t2, t3, t4, t5, t6, t7, new Tuple<T8, T9, T10, T11>(t8, t9, t10, t11));
        }
        /// <summary>11要素タプルから1番目の要素を取り出します。</summary>
        public static T1 Fst<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> self) { return self.Item1; }
        /// <summary>11要素タプルから2番目の要素を取り出します。</summary>
        public static T2 Snd<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> self) { return self.Item2; }
        /// <summary>11要素タプルから1番目の要素を取り出します。</summary>
        public static T1 _1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> self) { return self.Item1 ; }
        /// <summary>11要素タプルから2番目の要素を取り出します。</summary>
        public static T2 _2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> self) { return self.Item2 ; }
        /// <summary>11要素タプルから3番目の要素を取り出します。</summary>
        public static T3 _3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> self) { return self.Item3 ; }
        /// <summary>11要素タプルから4番目の要素を取り出します。</summary>
        public static T4 _4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> self) { return self.Item4 ; }
        /// <summary>11要素タプルから5番目の要素を取り出します。</summary>
        public static T5 _5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> self) { return self.Item5 ; }
        /// <summary>11要素タプルから6番目の要素を取り出します。</summary>
        public static T6 _6<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> self) { return self.Item6 ; }
        /// <summary>11要素タプルから7番目の要素を取り出します。</summary>
        public static T7 _7<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> self) { return self.Item7 ; }
        /// <summary>11要素タプルから8番目の要素を取り出します。</summary>
        public static T8 _8<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> self) { return self.Rest.Item1 ; }
        /// <summary>11要素タプルから9番目の要素を取り出します。</summary>
        public static T9 _9<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> self) { return self.Rest.Item2 ; }
        /// <summary>11要素タプルから10番目の要素を取り出します。</summary>
        public static T10 _10<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> self) { return self.Rest.Item3 ; }
        /// <summary>11要素タプルから11番目の要素を取り出します。</summary>
        public static T11 _11<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> self) { return self.Rest.Item4 ; }

        /// <summary>11要素タプルに要素を追加し、12要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> Add<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> self, T12 t)
        {
            return LangExt.Create.Tuple(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), t);
        }
        /// <summary>11要素タプルに要素を追加し、12要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T0, T1, T2, T3, T4, T5, T6, Tuple<T7, T8, T9, T10, T11>> AddFirst<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> self, T0 t)
        {
            return LangExt.Create.Tuple(t, self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11());
        }

        /// <summary>11要素タプルから末尾要素を削除し、10要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>> RemoveLast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> self)
        {
            return LangExt.Create.Tuple(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10());
        }
        /// <summary>11要素タプルから末尾要素を削除し、10要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T2, T3, T4, T5, T6, T7, T8, Tuple<T9, T10, T11>> RemoveFirst<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> self)
        {
            return LangExt.Create.Tuple(self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11());
        }

        /// <summary>11要素タプルに対して、擬似的にパターンマッチを行います。</summary>
        public static U Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> f)
        {
            return f(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11());
        }

        /// <summary>11要素タプルの1番目の要素に対して、関数を適用します。</summary>
        public static Tuple<U, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> Map1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> self, Func<T1, U> f)
        {
            return TupleModule.Create(f(self._1()), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11());
        }

        /// <summary>11要素タプルの2番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, U, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> Map2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> self, Func<T2, U> f)
        {
            return TupleModule.Create(self._1(), f(self._2()), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11());
        }

        /// <summary>11要素タプルの3番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, U, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> Map3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> self, Func<T3, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), f(self._3()), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11());
        }

        /// <summary>11要素タプルの4番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, U, T5, T6, T7, Tuple<T8, T9, T10, T11>> Map4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> self, Func<T4, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), f(self._4()), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11());
        }

        /// <summary>11要素タプルの5番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, U, T6, T7, Tuple<T8, T9, T10, T11>> Map5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> self, Func<T5, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), f(self._5()), self._6(), self._7(), self._8(), self._9(), self._10(), self._11());
        }

        /// <summary>11要素タプルの6番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, U, T7, Tuple<T8, T9, T10, T11>> Map6<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> self, Func<T6, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), f(self._6()), self._7(), self._8(), self._9(), self._10(), self._11());
        }

        /// <summary>11要素タプルの7番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, U, Tuple<T8, T9, T10, T11>> Map7<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> self, Func<T7, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), f(self._7()), self._8(), self._9(), self._10(), self._11());
        }

        /// <summary>11要素タプルの8番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<U, T9, T10, T11>> Map8<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> self, Func<T8, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), f(self._8()), self._9(), self._10(), self._11());
        }

        /// <summary>11要素タプルの9番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, U, T10, T11>> Map9<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> self, Func<T9, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), f(self._9()), self._10(), self._11());
        }

        /// <summary>11要素タプルの10番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, U, T11>> Map10<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> self, Func<T10, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), f(self._10()), self._11());
        }

        /// <summary>11要素タプルの11番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, U>> Map11<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> self, Func<T11, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), f(self._11()));
        }

        /// <summary>12要素のタプルを生成します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>(t1, t2, t3, t4, t5, t6, t7, new Tuple<T8, T9, T10, T11, T12>(t8, t9, t10, t11, t12));
        }
        /// <summary>12要素タプルから1番目の要素を取り出します。</summary>
        public static T1 Fst<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self) { return self.Item1; }
        /// <summary>12要素タプルから2番目の要素を取り出します。</summary>
        public static T2 Snd<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self) { return self.Item2; }
        /// <summary>12要素タプルから1番目の要素を取り出します。</summary>
        public static T1 _1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self) { return self.Item1 ; }
        /// <summary>12要素タプルから2番目の要素を取り出します。</summary>
        public static T2 _2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self) { return self.Item2 ; }
        /// <summary>12要素タプルから3番目の要素を取り出します。</summary>
        public static T3 _3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self) { return self.Item3 ; }
        /// <summary>12要素タプルから4番目の要素を取り出します。</summary>
        public static T4 _4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self) { return self.Item4 ; }
        /// <summary>12要素タプルから5番目の要素を取り出します。</summary>
        public static T5 _5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self) { return self.Item5 ; }
        /// <summary>12要素タプルから6番目の要素を取り出します。</summary>
        public static T6 _6<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self) { return self.Item6 ; }
        /// <summary>12要素タプルから7番目の要素を取り出します。</summary>
        public static T7 _7<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self) { return self.Item7 ; }
        /// <summary>12要素タプルから8番目の要素を取り出します。</summary>
        public static T8 _8<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self) { return self.Rest.Item1 ; }
        /// <summary>12要素タプルから9番目の要素を取り出します。</summary>
        public static T9 _9<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self) { return self.Rest.Item2 ; }
        /// <summary>12要素タプルから10番目の要素を取り出します。</summary>
        public static T10 _10<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self) { return self.Rest.Item3 ; }
        /// <summary>12要素タプルから11番目の要素を取り出します。</summary>
        public static T11 _11<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self) { return self.Rest.Item4 ; }
        /// <summary>12要素タプルから12番目の要素を取り出します。</summary>
        public static T12 _12<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self) { return self.Rest.Item5 ; }

        /// <summary>12要素タプルに要素を追加し、13要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> Add<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self, T13 t)
        {
            return LangExt.Create.Tuple(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), t);
        }
        /// <summary>12要素タプルに要素を追加し、13要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T0, T1, T2, T3, T4, T5, T6, Tuple<T7, T8, T9, T10, T11, T12>> AddFirst<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self, T0 t)
        {
            return LangExt.Create.Tuple(t, self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12());
        }

        /// <summary>12要素タプルから末尾要素を削除し、11要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>> RemoveLast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self)
        {
            return LangExt.Create.Tuple(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11());
        }
        /// <summary>12要素タプルから末尾要素を削除し、11要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T2, T3, T4, T5, T6, T7, T8, Tuple<T9, T10, T11, T12>> RemoveFirst<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self)
        {
            return LangExt.Create.Tuple(self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12());
        }

        /// <summary>12要素タプルに対して、擬似的にパターンマッチを行います。</summary>
        public static U Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> f)
        {
            return f(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12());
        }

        /// <summary>12要素タプルの1番目の要素に対して、関数を適用します。</summary>
        public static Tuple<U, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> Map1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self, Func<T1, U> f)
        {
            return TupleModule.Create(f(self._1()), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12());
        }

        /// <summary>12要素タプルの2番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, U, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> Map2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self, Func<T2, U> f)
        {
            return TupleModule.Create(self._1(), f(self._2()), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12());
        }

        /// <summary>12要素タプルの3番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, U, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> Map3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self, Func<T3, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), f(self._3()), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12());
        }

        /// <summary>12要素タプルの4番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, U, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> Map4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self, Func<T4, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), f(self._4()), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12());
        }

        /// <summary>12要素タプルの5番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, U, T6, T7, Tuple<T8, T9, T10, T11, T12>> Map5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self, Func<T5, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), f(self._5()), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12());
        }

        /// <summary>12要素タプルの6番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, U, T7, Tuple<T8, T9, T10, T11, T12>> Map6<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self, Func<T6, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), f(self._6()), self._7(), self._8(), self._9(), self._10(), self._11(), self._12());
        }

        /// <summary>12要素タプルの7番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, U, Tuple<T8, T9, T10, T11, T12>> Map7<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self, Func<T7, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), f(self._7()), self._8(), self._9(), self._10(), self._11(), self._12());
        }

        /// <summary>12要素タプルの8番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<U, T9, T10, T11, T12>> Map8<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self, Func<T8, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), f(self._8()), self._9(), self._10(), self._11(), self._12());
        }

        /// <summary>12要素タプルの9番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, U, T10, T11, T12>> Map9<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self, Func<T9, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), f(self._9()), self._10(), self._11(), self._12());
        }

        /// <summary>12要素タプルの10番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, U, T11, T12>> Map10<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self, Func<T10, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), f(self._10()), self._11(), self._12());
        }

        /// <summary>12要素タプルの11番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, U, T12>> Map11<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self, Func<T11, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), f(self._11()), self._12());
        }

        /// <summary>12要素タプルの12番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, U>> Map12<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> self, Func<T12, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), f(self._12()));
        }

        /// <summary>13要素のタプルを生成します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>(t1, t2, t3, t4, t5, t6, t7, new Tuple<T8, T9, T10, T11, T12, T13>(t8, t9, t10, t11, t12, t13));
        }
        /// <summary>13要素タプルから1番目の要素を取り出します。</summary>
        public static T1 Fst<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self) { return self.Item1; }
        /// <summary>13要素タプルから2番目の要素を取り出します。</summary>
        public static T2 Snd<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self) { return self.Item2; }
        /// <summary>13要素タプルから1番目の要素を取り出します。</summary>
        public static T1 _1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self) { return self.Item1 ; }
        /// <summary>13要素タプルから2番目の要素を取り出します。</summary>
        public static T2 _2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self) { return self.Item2 ; }
        /// <summary>13要素タプルから3番目の要素を取り出します。</summary>
        public static T3 _3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self) { return self.Item3 ; }
        /// <summary>13要素タプルから4番目の要素を取り出します。</summary>
        public static T4 _4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self) { return self.Item4 ; }
        /// <summary>13要素タプルから5番目の要素を取り出します。</summary>
        public static T5 _5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self) { return self.Item5 ; }
        /// <summary>13要素タプルから6番目の要素を取り出します。</summary>
        public static T6 _6<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self) { return self.Item6 ; }
        /// <summary>13要素タプルから7番目の要素を取り出します。</summary>
        public static T7 _7<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self) { return self.Item7 ; }
        /// <summary>13要素タプルから8番目の要素を取り出します。</summary>
        public static T8 _8<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self) { return self.Rest.Item1 ; }
        /// <summary>13要素タプルから9番目の要素を取り出します。</summary>
        public static T9 _9<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self) { return self.Rest.Item2 ; }
        /// <summary>13要素タプルから10番目の要素を取り出します。</summary>
        public static T10 _10<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self) { return self.Rest.Item3 ; }
        /// <summary>13要素タプルから11番目の要素を取り出します。</summary>
        public static T11 _11<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self) { return self.Rest.Item4 ; }
        /// <summary>13要素タプルから12番目の要素を取り出します。</summary>
        public static T12 _12<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self) { return self.Rest.Item5 ; }
        /// <summary>13要素タプルから13番目の要素を取り出します。</summary>
        public static T13 _13<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self) { return self.Rest.Item6 ; }

        /// <summary>13要素タプルに要素を追加し、14要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> Add<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self, T14 t)
        {
            return LangExt.Create.Tuple(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), t);
        }
        /// <summary>13要素タプルに要素を追加し、14要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T0, T1, T2, T3, T4, T5, T6, Tuple<T7, T8, T9, T10, T11, T12, T13>> AddFirst<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self, T0 t)
        {
            return LangExt.Create.Tuple(t, self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13());
        }

        /// <summary>13要素タプルから末尾要素を削除し、12要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>> RemoveLast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self)
        {
            return LangExt.Create.Tuple(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12());
        }
        /// <summary>13要素タプルから末尾要素を削除し、12要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T2, T3, T4, T5, T6, T7, T8, Tuple<T9, T10, T11, T12, T13>> RemoveFirst<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self)
        {
            return LangExt.Create.Tuple(self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13());
        }

        /// <summary>13要素タプルに対して、擬似的にパターンマッチを行います。</summary>
        public static U Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> f)
        {
            return f(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13());
        }

        /// <summary>13要素タプルの1番目の要素に対して、関数を適用します。</summary>
        public static Tuple<U, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> Map1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self, Func<T1, U> f)
        {
            return TupleModule.Create(f(self._1()), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13());
        }

        /// <summary>13要素タプルの2番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, U, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> Map2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self, Func<T2, U> f)
        {
            return TupleModule.Create(self._1(), f(self._2()), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13());
        }

        /// <summary>13要素タプルの3番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, U, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> Map3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self, Func<T3, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), f(self._3()), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13());
        }

        /// <summary>13要素タプルの4番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, U, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> Map4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self, Func<T4, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), f(self._4()), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13());
        }

        /// <summary>13要素タプルの5番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, U, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> Map5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self, Func<T5, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), f(self._5()), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13());
        }

        /// <summary>13要素タプルの6番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, U, T7, Tuple<T8, T9, T10, T11, T12, T13>> Map6<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self, Func<T6, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), f(self._6()), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13());
        }

        /// <summary>13要素タプルの7番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, U, Tuple<T8, T9, T10, T11, T12, T13>> Map7<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self, Func<T7, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), f(self._7()), self._8(), self._9(), self._10(), self._11(), self._12(), self._13());
        }

        /// <summary>13要素タプルの8番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<U, T9, T10, T11, T12, T13>> Map8<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self, Func<T8, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), f(self._8()), self._9(), self._10(), self._11(), self._12(), self._13());
        }

        /// <summary>13要素タプルの9番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, U, T10, T11, T12, T13>> Map9<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self, Func<T9, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), f(self._9()), self._10(), self._11(), self._12(), self._13());
        }

        /// <summary>13要素タプルの10番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, U, T11, T12, T13>> Map10<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self, Func<T10, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), f(self._10()), self._11(), self._12(), self._13());
        }

        /// <summary>13要素タプルの11番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, U, T12, T13>> Map11<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self, Func<T11, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), f(self._11()), self._12(), self._13());
        }

        /// <summary>13要素タプルの12番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, U, T13>> Map12<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self, Func<T12, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), f(self._12()), self._13());
        }

        /// <summary>13要素タプルの13番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, U>> Map13<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> self, Func<T13, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), f(self._13()));
        }

        /// <summary>14要素のタプルを生成します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>(t1, t2, t3, t4, t5, t6, t7, new Tuple<T8, T9, T10, T11, T12, T13, T14>(t8, t9, t10, t11, t12, t13, t14));
        }
        /// <summary>14要素タプルから1番目の要素を取り出します。</summary>
        public static T1 Fst<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self) { return self.Item1; }
        /// <summary>14要素タプルから2番目の要素を取り出します。</summary>
        public static T2 Snd<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self) { return self.Item2; }
        /// <summary>14要素タプルから1番目の要素を取り出します。</summary>
        public static T1 _1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self) { return self.Item1 ; }
        /// <summary>14要素タプルから2番目の要素を取り出します。</summary>
        public static T2 _2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self) { return self.Item2 ; }
        /// <summary>14要素タプルから3番目の要素を取り出します。</summary>
        public static T3 _3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self) { return self.Item3 ; }
        /// <summary>14要素タプルから4番目の要素を取り出します。</summary>
        public static T4 _4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self) { return self.Item4 ; }
        /// <summary>14要素タプルから5番目の要素を取り出します。</summary>
        public static T5 _5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self) { return self.Item5 ; }
        /// <summary>14要素タプルから6番目の要素を取り出します。</summary>
        public static T6 _6<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self) { return self.Item6 ; }
        /// <summary>14要素タプルから7番目の要素を取り出します。</summary>
        public static T7 _7<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self) { return self.Item7 ; }
        /// <summary>14要素タプルから8番目の要素を取り出します。</summary>
        public static T8 _8<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self) { return self.Rest.Item1 ; }
        /// <summary>14要素タプルから9番目の要素を取り出します。</summary>
        public static T9 _9<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self) { return self.Rest.Item2 ; }
        /// <summary>14要素タプルから10番目の要素を取り出します。</summary>
        public static T10 _10<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self) { return self.Rest.Item3 ; }
        /// <summary>14要素タプルから11番目の要素を取り出します。</summary>
        public static T11 _11<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self) { return self.Rest.Item4 ; }
        /// <summary>14要素タプルから12番目の要素を取り出します。</summary>
        public static T12 _12<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self) { return self.Rest.Item5 ; }
        /// <summary>14要素タプルから13番目の要素を取り出します。</summary>
        public static T13 _13<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self) { return self.Rest.Item6 ; }
        /// <summary>14要素タプルから14番目の要素を取り出します。</summary>
        public static T14 _14<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self) { return self.Rest.Item7 ; }

        /// <summary>14要素タプルに要素を追加し、15要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> Add<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self, T15 t)
        {
            return LangExt.Create.Tuple(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14(), t);
        }
        /// <summary>14要素タプルに要素を追加し、15要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T0, T1, T2, T3, T4, T5, T6, Tuple<T7, T8, T9, T10, T11, T12, T13, Tuple<T14>>> AddFirst<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self, T0 t)
        {
            return LangExt.Create.Tuple(t, self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14());
        }

        /// <summary>14要素タプルから末尾要素を削除し、13要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>> RemoveLast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self)
        {
            return LangExt.Create.Tuple(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13());
        }
        /// <summary>14要素タプルから末尾要素を削除し、13要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T2, T3, T4, T5, T6, T7, T8, Tuple<T9, T10, T11, T12, T13, T14>> RemoveFirst<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self)
        {
            return LangExt.Create.Tuple(self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14());
        }

        /// <summary>14要素タプルに対して、擬似的にパターンマッチを行います。</summary>
        public static U Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> f)
        {
            return f(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14());
        }

        /// <summary>14要素タプルの1番目の要素に対して、関数を適用します。</summary>
        public static Tuple<U, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> Map1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self, Func<T1, U> f)
        {
            return TupleModule.Create(f(self._1()), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14());
        }

        /// <summary>14要素タプルの2番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, U, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> Map2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self, Func<T2, U> f)
        {
            return TupleModule.Create(self._1(), f(self._2()), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14());
        }

        /// <summary>14要素タプルの3番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, U, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> Map3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self, Func<T3, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), f(self._3()), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14());
        }

        /// <summary>14要素タプルの4番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, U, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> Map4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self, Func<T4, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), f(self._4()), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14());
        }

        /// <summary>14要素タプルの5番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, U, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> Map5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self, Func<T5, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), f(self._5()), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14());
        }

        /// <summary>14要素タプルの6番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, U, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> Map6<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self, Func<T6, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), f(self._6()), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14());
        }

        /// <summary>14要素タプルの7番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, U, Tuple<T8, T9, T10, T11, T12, T13, T14>> Map7<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self, Func<T7, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), f(self._7()), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14());
        }

        /// <summary>14要素タプルの8番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<U, T9, T10, T11, T12, T13, T14>> Map8<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self, Func<T8, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), f(self._8()), self._9(), self._10(), self._11(), self._12(), self._13(), self._14());
        }

        /// <summary>14要素タプルの9番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, U, T10, T11, T12, T13, T14>> Map9<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self, Func<T9, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), f(self._9()), self._10(), self._11(), self._12(), self._13(), self._14());
        }

        /// <summary>14要素タプルの10番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, U, T11, T12, T13, T14>> Map10<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self, Func<T10, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), f(self._10()), self._11(), self._12(), self._13(), self._14());
        }

        /// <summary>14要素タプルの11番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, U, T12, T13, T14>> Map11<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self, Func<T11, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), f(self._11()), self._12(), self._13(), self._14());
        }

        /// <summary>14要素タプルの12番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, U, T13, T14>> Map12<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self, Func<T12, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), f(self._12()), self._13(), self._14());
        }

        /// <summary>14要素タプルの13番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, U, T14>> Map13<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self, Func<T13, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), f(self._13()), self._14());
        }

        /// <summary>14要素タプルの14番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, U>> Map14<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> self, Func<T14, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), f(self._14()));
        }

        /// <summary>15要素のタプルを生成します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>(t1, t2, t3, t4, t5, t6, t7, new Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>(t8, t9, t10, t11, t12, t13, t14, new Tuple<T15>(t15)));
        }
        /// <summary>15要素タプルから1番目の要素を取り出します。</summary>
        public static T1 Fst<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self) { return self.Item1; }
        /// <summary>15要素タプルから2番目の要素を取り出します。</summary>
        public static T2 Snd<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self) { return self.Item2; }
        /// <summary>15要素タプルから1番目の要素を取り出します。</summary>
        public static T1 _1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self) { return self.Item1 ; }
        /// <summary>15要素タプルから2番目の要素を取り出します。</summary>
        public static T2 _2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self) { return self.Item2 ; }
        /// <summary>15要素タプルから3番目の要素を取り出します。</summary>
        public static T3 _3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self) { return self.Item3 ; }
        /// <summary>15要素タプルから4番目の要素を取り出します。</summary>
        public static T4 _4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self) { return self.Item4 ; }
        /// <summary>15要素タプルから5番目の要素を取り出します。</summary>
        public static T5 _5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self) { return self.Item5 ; }
        /// <summary>15要素タプルから6番目の要素を取り出します。</summary>
        public static T6 _6<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self) { return self.Item6 ; }
        /// <summary>15要素タプルから7番目の要素を取り出します。</summary>
        public static T7 _7<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self) { return self.Item7 ; }
        /// <summary>15要素タプルから8番目の要素を取り出します。</summary>
        public static T8 _8<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self) { return self.Rest.Item1 ; }
        /// <summary>15要素タプルから9番目の要素を取り出します。</summary>
        public static T9 _9<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self) { return self.Rest.Item2 ; }
        /// <summary>15要素タプルから10番目の要素を取り出します。</summary>
        public static T10 _10<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self) { return self.Rest.Item3 ; }
        /// <summary>15要素タプルから11番目の要素を取り出します。</summary>
        public static T11 _11<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self) { return self.Rest.Item4 ; }
        /// <summary>15要素タプルから12番目の要素を取り出します。</summary>
        public static T12 _12<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self) { return self.Rest.Item5 ; }
        /// <summary>15要素タプルから13番目の要素を取り出します。</summary>
        public static T13 _13<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self) { return self.Rest.Item6 ; }
        /// <summary>15要素タプルから14番目の要素を取り出します。</summary>
        public static T14 _14<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self) { return self.Rest.Item7 ; }
        /// <summary>15要素タプルから15番目の要素を取り出します。</summary>
        public static T15 _15<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self) { return self.Rest.Rest.Item1 ; }

        /// <summary>15要素タプルに要素を追加し、16要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> Add<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self, T16 t)
        {
            return LangExt.Create.Tuple(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14(), self._15(), t);
        }
        /// <summary>15要素タプルに要素を追加し、16要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T0, T1, T2, T3, T4, T5, T6, Tuple<T7, T8, T9, T10, T11, T12, T13, Tuple<T14, T15>>> AddFirst<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self, T0 t)
        {
            return LangExt.Create.Tuple(t, self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14(), self._15());
        }

        /// <summary>15要素タプルから末尾要素を削除し、14要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>> RemoveLast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self)
        {
            return LangExt.Create.Tuple(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14());
        }
        /// <summary>15要素タプルから末尾要素を削除し、14要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T2, T3, T4, T5, T6, T7, T8, Tuple<T9, T10, T11, T12, T13, T14, T15>> RemoveFirst<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self)
        {
            return LangExt.Create.Tuple(self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14(), self._15());
        }

        /// <summary>15要素タプルに対して、擬似的にパターンマッチを行います。</summary>
        public static U Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> f)
        {
            return f(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14(), self._15());
        }

        /// <summary>15要素タプルの1番目の要素に対して、関数を適用します。</summary>
        public static Tuple<U, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> Map1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self, Func<T1, U> f)
        {
            return TupleModule.Create(f(self._1()), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14(), self._15());
        }

        /// <summary>15要素タプルの2番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, U, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> Map2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self, Func<T2, U> f)
        {
            return TupleModule.Create(self._1(), f(self._2()), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14(), self._15());
        }

        /// <summary>15要素タプルの3番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, U, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> Map3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self, Func<T3, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), f(self._3()), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14(), self._15());
        }

        /// <summary>15要素タプルの4番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, U, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> Map4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self, Func<T4, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), f(self._4()), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14(), self._15());
        }

        /// <summary>15要素タプルの5番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, U, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> Map5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self, Func<T5, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), f(self._5()), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14(), self._15());
        }

        /// <summary>15要素タプルの6番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, U, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> Map6<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self, Func<T6, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), f(self._6()), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14(), self._15());
        }

        /// <summary>15要素タプルの7番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, U, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> Map7<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self, Func<T7, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), f(self._7()), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14(), self._15());
        }

        /// <summary>15要素タプルの8番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<U, T9, T10, T11, T12, T13, T14, Tuple<T15>>> Map8<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self, Func<T8, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), f(self._8()), self._9(), self._10(), self._11(), self._12(), self._13(), self._14(), self._15());
        }

        /// <summary>15要素タプルの9番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, U, T10, T11, T12, T13, T14, Tuple<T15>>> Map9<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self, Func<T9, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), f(self._9()), self._10(), self._11(), self._12(), self._13(), self._14(), self._15());
        }

        /// <summary>15要素タプルの10番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, U, T11, T12, T13, T14, Tuple<T15>>> Map10<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self, Func<T10, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), f(self._10()), self._11(), self._12(), self._13(), self._14(), self._15());
        }

        /// <summary>15要素タプルの11番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, U, T12, T13, T14, Tuple<T15>>> Map11<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self, Func<T11, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), f(self._11()), self._12(), self._13(), self._14(), self._15());
        }

        /// <summary>15要素タプルの12番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, U, T13, T14, Tuple<T15>>> Map12<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self, Func<T12, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), f(self._12()), self._13(), self._14(), self._15());
        }

        /// <summary>15要素タプルの13番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, U, T14, Tuple<T15>>> Map13<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self, Func<T13, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), f(self._13()), self._14(), self._15());
        }

        /// <summary>15要素タプルの14番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, U, Tuple<T15>>> Map14<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self, Func<T14, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), f(self._14()), self._15());
        }

        /// <summary>15要素タプルの15番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<U>>> Map15<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> self, Func<T15, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14(), f(self._15()));
        }

        /// <summary>16要素のタプルを生成します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>(t1, t2, t3, t4, t5, t6, t7, new Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>(t8, t9, t10, t11, t12, t13, t14, new Tuple<T15, T16>(t15, t16)));
        }
        /// <summary>16要素タプルから1番目の要素を取り出します。</summary>
        public static T1 Fst<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self) { return self.Item1; }
        /// <summary>16要素タプルから2番目の要素を取り出します。</summary>
        public static T2 Snd<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self) { return self.Item2; }
        /// <summary>16要素タプルから1番目の要素を取り出します。</summary>
        public static T1 _1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self) { return self.Item1 ; }
        /// <summary>16要素タプルから2番目の要素を取り出します。</summary>
        public static T2 _2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self) { return self.Item2 ; }
        /// <summary>16要素タプルから3番目の要素を取り出します。</summary>
        public static T3 _3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self) { return self.Item3 ; }
        /// <summary>16要素タプルから4番目の要素を取り出します。</summary>
        public static T4 _4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self) { return self.Item4 ; }
        /// <summary>16要素タプルから5番目の要素を取り出します。</summary>
        public static T5 _5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self) { return self.Item5 ; }
        /// <summary>16要素タプルから6番目の要素を取り出します。</summary>
        public static T6 _6<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self) { return self.Item6 ; }
        /// <summary>16要素タプルから7番目の要素を取り出します。</summary>
        public static T7 _7<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self) { return self.Item7 ; }
        /// <summary>16要素タプルから8番目の要素を取り出します。</summary>
        public static T8 _8<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self) { return self.Rest.Item1 ; }
        /// <summary>16要素タプルから9番目の要素を取り出します。</summary>
        public static T9 _9<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self) { return self.Rest.Item2 ; }
        /// <summary>16要素タプルから10番目の要素を取り出します。</summary>
        public static T10 _10<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self) { return self.Rest.Item3 ; }
        /// <summary>16要素タプルから11番目の要素を取り出します。</summary>
        public static T11 _11<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self) { return self.Rest.Item4 ; }
        /// <summary>16要素タプルから12番目の要素を取り出します。</summary>
        public static T12 _12<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self) { return self.Rest.Item5 ; }
        /// <summary>16要素タプルから13番目の要素を取り出します。</summary>
        public static T13 _13<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self) { return self.Rest.Item6 ; }
        /// <summary>16要素タプルから14番目の要素を取り出します。</summary>
        public static T14 _14<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self) { return self.Rest.Item7 ; }
        /// <summary>16要素タプルから15番目の要素を取り出します。</summary>
        public static T15 _15<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self) { return self.Rest.Rest.Item1 ; }
        /// <summary>16要素タプルから16番目の要素を取り出します。</summary>
        public static T16 _16<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self) { return self.Rest.Rest.Item2 ; }


        /// <summary>16要素タプルから末尾要素を削除し、15要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>> RemoveLast<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self)
        {
            return LangExt.Create.Tuple(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14(), self._15());
        }
        /// <summary>16要素タプルから末尾要素を削除し、15要素タプルを生成します。主にコードの自動生成用に使用されます。</summary>
        public static Tuple<T2, T3, T4, T5, T6, T7, T8, Tuple<T9, T10, T11, T12, T13, T14, T15, Tuple<T16>>> RemoveFirst<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self)
        {
            return LangExt.Create.Tuple(self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14(), self._15(), self._16());
        }

        /// <summary>16要素タプルに対して、擬似的にパターンマッチを行います。</summary>
        public static U Match<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> f)
        {
            return f(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14(), self._15(), self._16());
        }

        /// <summary>16要素タプルの1番目の要素に対して、関数を適用します。</summary>
        public static Tuple<U, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> Map1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self, Func<T1, U> f)
        {
            return TupleModule.Create(f(self._1()), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14(), self._15(), self._16());
        }

        /// <summary>16要素タプルの2番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, U, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> Map2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self, Func<T2, U> f)
        {
            return TupleModule.Create(self._1(), f(self._2()), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14(), self._15(), self._16());
        }

        /// <summary>16要素タプルの3番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, U, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> Map3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self, Func<T3, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), f(self._3()), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14(), self._15(), self._16());
        }

        /// <summary>16要素タプルの4番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, U, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> Map4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self, Func<T4, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), f(self._4()), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14(), self._15(), self._16());
        }

        /// <summary>16要素タプルの5番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, U, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> Map5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self, Func<T5, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), f(self._5()), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14(), self._15(), self._16());
        }

        /// <summary>16要素タプルの6番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, U, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> Map6<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self, Func<T6, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), f(self._6()), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14(), self._15(), self._16());
        }

        /// <summary>16要素タプルの7番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, U, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> Map7<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self, Func<T7, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), f(self._7()), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14(), self._15(), self._16());
        }

        /// <summary>16要素タプルの8番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<U, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> Map8<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self, Func<T8, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), f(self._8()), self._9(), self._10(), self._11(), self._12(), self._13(), self._14(), self._15(), self._16());
        }

        /// <summary>16要素タプルの9番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, U, T10, T11, T12, T13, T14, Tuple<T15, T16>>> Map9<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self, Func<T9, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), f(self._9()), self._10(), self._11(), self._12(), self._13(), self._14(), self._15(), self._16());
        }

        /// <summary>16要素タプルの10番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, U, T11, T12, T13, T14, Tuple<T15, T16>>> Map10<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self, Func<T10, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), f(self._10()), self._11(), self._12(), self._13(), self._14(), self._15(), self._16());
        }

        /// <summary>16要素タプルの11番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, U, T12, T13, T14, Tuple<T15, T16>>> Map11<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self, Func<T11, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), f(self._11()), self._12(), self._13(), self._14(), self._15(), self._16());
        }

        /// <summary>16要素タプルの12番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, U, T13, T14, Tuple<T15, T16>>> Map12<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self, Func<T12, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), f(self._12()), self._13(), self._14(), self._15(), self._16());
        }

        /// <summary>16要素タプルの13番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, U, T14, Tuple<T15, T16>>> Map13<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self, Func<T13, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), f(self._13()), self._14(), self._15(), self._16());
        }

        /// <summary>16要素タプルの14番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, U, Tuple<T15, T16>>> Map14<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self, Func<T14, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), f(self._14()), self._15(), self._16());
        }

        /// <summary>16要素タプルの15番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<U, T16>>> Map15<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self, Func<T15, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14(), f(self._15()), self._16());
        }

        /// <summary>16要素タプルの16番目の要素に対して、関数を適用します。</summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, U>>> Map16<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>> self, Func<T16, U> f)
        {
            return TupleModule.Create(self._1(), self._2(), self._3(), self._4(), self._5(), self._6(), self._7(), self._8(), self._9(), self._10(), self._11(), self._12(), self._13(), self._14(), self._15(), f(self._16()));
        }

    }
}