
using System;

namespace LangExt
{
    partial class Option
    {
        /// <summary>
        /// Option[Tuple[...]]のSomeを生成します。
        /// </summary>
        public static Option<Tuple<T1, T2>> Some<T1, T2>(T1 t1, T2 t2)
        {
            return Option.Some(LangExt.Create.Tuple(t1, t2));
        }
        /// <summary>
        /// Option[Tuple[...]]のSomeを生成します。
        /// </summary>
        public static Option<Tuple<T1, T2, T3>> Some<T1, T2, T3>(T1 t1, T2 t2, T3 t3)
        {
            return Option.Some(LangExt.Create.Tuple(t1, t2, t3));
        }
        /// <summary>
        /// Option[Tuple[...]]のSomeを生成します。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4>> Some<T1, T2, T3, T4>(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            return Option.Some(LangExt.Create.Tuple(t1, t2, t3, t4));
        }
        /// <summary>
        /// Option[Tuple[...]]のSomeを生成します。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5>> Some<T1, T2, T3, T4, T5>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            return Option.Some(LangExt.Create.Tuple(t1, t2, t3, t4, t5));
        }
        /// <summary>
        /// Option[Tuple[...]]のSomeを生成します。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6>> Some<T1, T2, T3, T4, T5, T6>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
        {
            return Option.Some(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6));
        }
        /// <summary>
        /// Option[Tuple[...]]のSomeを生成します。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7>> Some<T1, T2, T3, T4, T5, T6, T7>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
        {
            return Option.Some(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7));
        }
        /// <summary>
        /// Option[Tuple[...]]のSomeを生成します。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> Some<T1, T2, T3, T4, T5, T6, T7, T8>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
        {
            return Option.Some(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8));
        }
        /// <summary>
        /// Option[Tuple[...]]のSomeを生成します。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> Some<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
        {
            return Option.Some(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9));
        }
        /// <summary>
        /// Option[Tuple[...]]のSomeを生成します。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> Some<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
        {
            return Option.Some(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
        }
        /// <summary>
        /// Option[Tuple[...]]のSomeを生成します。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> Some<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
        {
            return Option.Some(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
        }
        /// <summary>
        /// Option[Tuple[...]]のSomeを生成します。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> Some<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
        {
            return Option.Some(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
        }
        /// <summary>
        /// Option[Tuple[...]]のSomeを生成します。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> Some<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
        {
            return Option.Some(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
        }
        /// <summary>
        /// Option[Tuple[...]]のSomeを生成します。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> Some<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
        {
            return Option.Some(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
        }
        /// <summary>
        /// Option[Tuple[...]]のSomeを生成します。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> Some<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
        {
            return Option.Some(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
        }
        /// <summary>
        /// Option[Tuple[...]]のSomeを生成します。
        /// </summary>
        public static Option<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> Some<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16)
        {
            return Option.Some(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16));
        }
    }
}