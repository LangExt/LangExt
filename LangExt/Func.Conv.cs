
using System;

namespace LangExt
{
    partial class Func
    {
        /// <summary>
        /// 第一引数に操作対象が来るような関数を、カリー化しつつ第一引数を最後の位置に持って行きます。
        /// これにより、オブジェクト指向スタイルの関数に対する部分適用を容易にします。
        /// </summary>
        public static Func<T2, Func<T1, T3>> ToFunctional<T1, T2, T3>(this Func<T1, T2, T3> self)
        {
            return t2 => t1 => self(t1, t2);
        }

        /// <summary>
        /// 最終引数に操作対象が来るようにカリー化された関数を、アンカリー化しつつ最後の引数を第一引数の位置に持って行きます。
        /// これにより、C#上でより自然に関数型スタイルの関数を扱えるようにします。
        /// </summary>
        public static Func<T2, T1, T3> ToObjective<T1, T2, T3>(this Func<T1, Func<T2, T3>> self)
        {
            return (t2, t1) => self(t1)(t2);
        }

        /// <summary>
        /// 第一引数に操作対象が来るような関数を、カリー化しつつ第一引数を最後の位置に持って行きます。
        /// これにより、オブジェクト指向スタイルの関数に対する部分適用を容易にします。
        /// </summary>
        public static Func<T2, Func<T3, Func<T1, T4>>> ToFunctional<T1, T2, T3, T4>(this Func<T1, T2, T3, T4> self)
        {
            return t2 => t3 => t1 => self(t1, t2, t3);
        }

        /// <summary>
        /// 最終引数に操作対象が来るようにカリー化された関数を、アンカリー化しつつ最後の引数を第一引数の位置に持って行きます。
        /// これにより、C#上でより自然に関数型スタイルの関数を扱えるようにします。
        /// </summary>
        public static Func<T3, T1, T2, T4> ToObjective<T1, T2, T3, T4>(this Func<T1, Func<T2, Func<T3, T4>>> self)
        {
            return (t3, t1, t2) => self(t1)(t2)(t3);
        }

        /// <summary>
        /// 第一引数に操作対象が来るような関数を、カリー化しつつ第一引数を最後の位置に持って行きます。
        /// これにより、オブジェクト指向スタイルの関数に対する部分適用を容易にします。
        /// </summary>
        public static Func<T2, Func<T3, Func<T4, Func<T1, T5>>>> ToFunctional<T1, T2, T3, T4, T5>(this Func<T1, T2, T3, T4, T5> self)
        {
            return t2 => t3 => t4 => t1 => self(t1, t2, t3, t4);
        }

        /// <summary>
        /// 最終引数に操作対象が来るようにカリー化された関数を、アンカリー化しつつ最後の引数を第一引数の位置に持って行きます。
        /// これにより、C#上でより自然に関数型スタイルの関数を扱えるようにします。
        /// </summary>
        public static Func<T4, T1, T2, T3, T5> ToObjective<T1, T2, T3, T4, T5>(this Func<T1, Func<T2, Func<T3, Func<T4, T5>>>> self)
        {
            return (t4, t1, t2, t3) => self(t1)(t2)(t3)(t4);
        }

        /// <summary>
        /// 第一引数に操作対象が来るような関数を、カリー化しつつ第一引数を最後の位置に持って行きます。
        /// これにより、オブジェクト指向スタイルの関数に対する部分適用を容易にします。
        /// </summary>
        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T1, T6>>>>> ToFunctional<T1, T2, T3, T4, T5, T6>(this Func<T1, T2, T3, T4, T5, T6> self)
        {
            return t2 => t3 => t4 => t5 => t1 => self(t1, t2, t3, t4, t5);
        }

        /// <summary>
        /// 最終引数に操作対象が来るようにカリー化された関数を、アンカリー化しつつ最後の引数を第一引数の位置に持って行きます。
        /// これにより、C#上でより自然に関数型スタイルの関数を扱えるようにします。
        /// </summary>
        public static Func<T5, T1, T2, T3, T4, T6> ToObjective<T1, T2, T3, T4, T5, T6>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, T6>>>>> self)
        {
            return (t5, t1, t2, t3, t4) => self(t1)(t2)(t3)(t4)(t5);
        }

        /// <summary>
        /// 第一引数に操作対象が来るような関数を、カリー化しつつ第一引数を最後の位置に持って行きます。
        /// これにより、オブジェクト指向スタイルの関数に対する部分適用を容易にします。
        /// </summary>
        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T1, T7>>>>>> ToFunctional<T1, T2, T3, T4, T5, T6, T7>(this Func<T1, T2, T3, T4, T5, T6, T7> self)
        {
            return t2 => t3 => t4 => t5 => t6 => t1 => self(t1, t2, t3, t4, t5, t6);
        }

        /// <summary>
        /// 最終引数に操作対象が来るようにカリー化された関数を、アンカリー化しつつ最後の引数を第一引数の位置に持って行きます。
        /// これにより、C#上でより自然に関数型スタイルの関数を扱えるようにします。
        /// </summary>
        public static Func<T6, T1, T2, T3, T4, T5, T7> ToObjective<T1, T2, T3, T4, T5, T6, T7>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, T7>>>>>> self)
        {
            return (t6, t1, t2, t3, t4, t5) => self(t1)(t2)(t3)(t4)(t5)(t6);
        }

        /// <summary>
        /// 第一引数に操作対象が来るような関数を、カリー化しつつ第一引数を最後の位置に持って行きます。
        /// これにより、オブジェクト指向スタイルの関数に対する部分適用を容易にします。
        /// </summary>
        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T1, T8>>>>>>> ToFunctional<T1, T2, T3, T4, T5, T6, T7, T8>(this Func<T1, T2, T3, T4, T5, T6, T7, T8> self)
        {
            return t2 => t3 => t4 => t5 => t6 => t7 => t1 => self(t1, t2, t3, t4, t5, t6, t7);
        }

        /// <summary>
        /// 最終引数に操作対象が来るようにカリー化された関数を、アンカリー化しつつ最後の引数を第一引数の位置に持って行きます。
        /// これにより、C#上でより自然に関数型スタイルの関数を扱えるようにします。
        /// </summary>
        public static Func<T7, T1, T2, T3, T4, T5, T6, T8> ToObjective<T1, T2, T3, T4, T5, T6, T7, T8>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, T8>>>>>>> self)
        {
            return (t7, t1, t2, t3, t4, t5, t6) => self(t1)(t2)(t3)(t4)(t5)(t6)(t7);
        }

        /// <summary>
        /// 第一引数に操作対象が来るような関数を、カリー化しつつ第一引数を最後の位置に持って行きます。
        /// これにより、オブジェクト指向スタイルの関数に対する部分適用を容易にします。
        /// </summary>
        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T1, T9>>>>>>>> ToFunctional<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9> self)
        {
            return t2 => t3 => t4 => t5 => t6 => t7 => t8 => t1 => self(t1, t2, t3, t4, t5, t6, t7, t8);
        }

        /// <summary>
        /// 最終引数に操作対象が来るようにカリー化された関数を、アンカリー化しつつ最後の引数を第一引数の位置に持って行きます。
        /// これにより、C#上でより自然に関数型スタイルの関数を扱えるようにします。
        /// </summary>
        public static Func<T8, T1, T2, T3, T4, T5, T6, T7, T9> ToObjective<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, T9>>>>>>>> self)
        {
            return (t8, t1, t2, t3, t4, t5, t6, t7) => self(t1)(t2)(t3)(t4)(t5)(t6)(t7)(t8);
        }

        /// <summary>
        /// 第一引数に操作対象が来るような関数を、カリー化しつつ第一引数を最後の位置に持って行きます。
        /// これにより、オブジェクト指向スタイルの関数に対する部分適用を容易にします。
        /// </summary>
        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T1, T10>>>>>>>>> ToFunctional<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self)
        {
            return t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t1 => self(t1, t2, t3, t4, t5, t6, t7, t8, t9);
        }

        /// <summary>
        /// 最終引数に操作対象が来るようにカリー化された関数を、アンカリー化しつつ最後の引数を第一引数の位置に持って行きます。
        /// これにより、C#上でより自然に関数型スタイルの関数を扱えるようにします。
        /// </summary>
        public static Func<T9, T1, T2, T3, T4, T5, T6, T7, T8, T10> ToObjective<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, T10>>>>>>>>> self)
        {
            return (t9, t1, t2, t3, t4, t5, t6, t7, t8) => self(t1)(t2)(t3)(t4)(t5)(t6)(t7)(t8)(t9);
        }

        /// <summary>
        /// 第一引数に操作対象が来るような関数を、カリー化しつつ第一引数を最後の位置に持って行きます。
        /// これにより、オブジェクト指向スタイルの関数に対する部分適用を容易にします。
        /// </summary>
        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T1, T11>>>>>>>>>> ToFunctional<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self)
        {
            return t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t1 => self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
        }

        /// <summary>
        /// 最終引数に操作対象が来るようにカリー化された関数を、アンカリー化しつつ最後の引数を第一引数の位置に持って行きます。
        /// これにより、C#上でより自然に関数型スタイルの関数を扱えるようにします。
        /// </summary>
        public static Func<T10, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11> ToObjective<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, T11>>>>>>>>>> self)
        {
            return (t10, t1, t2, t3, t4, t5, t6, t7, t8, t9) => self(t1)(t2)(t3)(t4)(t5)(t6)(t7)(t8)(t9)(t10);
        }

        /// <summary>
        /// 第一引数に操作対象が来るような関数を、カリー化しつつ第一引数を最後の位置に持って行きます。
        /// これにより、オブジェクト指向スタイルの関数に対する部分適用を容易にします。
        /// </summary>
        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T1, T12>>>>>>>>>>> ToFunctional<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self)
        {
            return t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t1 => self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
        }

        /// <summary>
        /// 最終引数に操作対象が来るようにカリー化された関数を、アンカリー化しつつ最後の引数を第一引数の位置に持って行きます。
        /// これにより、C#上でより自然に関数型スタイルの関数を扱えるようにします。
        /// </summary>
        public static Func<T11, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12> ToObjective<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, T12>>>>>>>>>>> self)
        {
            return (t11, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => self(t1)(t2)(t3)(t4)(t5)(t6)(t7)(t8)(t9)(t10)(t11);
        }

        /// <summary>
        /// 第一引数に操作対象が来るような関数を、カリー化しつつ第一引数を最後の位置に持って行きます。
        /// これにより、オブジェクト指向スタイルの関数に対する部分適用を容易にします。
        /// </summary>
        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T1, T13>>>>>>>>>>>> ToFunctional<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self)
        {
            return t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t1 => self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
        }

        /// <summary>
        /// 最終引数に操作対象が来るようにカリー化された関数を、アンカリー化しつつ最後の引数を第一引数の位置に持って行きます。
        /// これにより、C#上でより自然に関数型スタイルの関数を扱えるようにします。
        /// </summary>
        public static Func<T12, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13> ToObjective<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, T13>>>>>>>>>>>> self)
        {
            return (t12, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => self(t1)(t2)(t3)(t4)(t5)(t6)(t7)(t8)(t9)(t10)(t11)(t12);
        }

        /// <summary>
        /// 第一引数に操作対象が来るような関数を、カリー化しつつ第一引数を最後の位置に持って行きます。
        /// これにより、オブジェクト指向スタイルの関数に対する部分適用を容易にします。
        /// </summary>
        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T1, T14>>>>>>>>>>>>> ToFunctional<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self)
        {
            return t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => t1 => self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
        }

        /// <summary>
        /// 最終引数に操作対象が来るようにカリー化された関数を、アンカリー化しつつ最後の引数を第一引数の位置に持って行きます。
        /// これにより、C#上でより自然に関数型スタイルの関数を扱えるようにします。
        /// </summary>
        public static Func<T13, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14> ToObjective<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, T14>>>>>>>>>>>>> self)
        {
            return (t13, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => self(t1)(t2)(t3)(t4)(t5)(t6)(t7)(t8)(t9)(t10)(t11)(t12)(t13);
        }

        /// <summary>
        /// 第一引数に操作対象が来るような関数を、カリー化しつつ第一引数を最後の位置に持って行きます。
        /// これにより、オブジェクト指向スタイルの関数に対する部分適用を容易にします。
        /// </summary>
        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T1, T15>>>>>>>>>>>>>> ToFunctional<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self)
        {
            return t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => t14 => t1 => self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
        }

        /// <summary>
        /// 最終引数に操作対象が来るようにカリー化された関数を、アンカリー化しつつ最後の引数を第一引数の位置に持って行きます。
        /// これにより、C#上でより自然に関数型スタイルの関数を扱えるようにします。
        /// </summary>
        public static Func<T14, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15> ToObjective<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, T15>>>>>>>>>>>>>> self)
        {
            return (t14, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => self(t1)(t2)(t3)(t4)(t5)(t6)(t7)(t8)(t9)(t10)(t11)(t12)(t13)(t14);
        }

        /// <summary>
        /// 第一引数に操作対象が来るような関数を、カリー化しつつ第一引数を最後の位置に持って行きます。
        /// これにより、オブジェクト指向スタイルの関数に対する部分適用を容易にします。
        /// </summary>
        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T1, T16>>>>>>>>>>>>>>> ToFunctional<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> self)
        {
            return t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => t14 => t15 => t1 => self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
        }

        /// <summary>
        /// 最終引数に操作対象が来るようにカリー化された関数を、アンカリー化しつつ最後の引数を第一引数の位置に持って行きます。
        /// これにより、C#上でより自然に関数型スタイルの関数を扱えるようにします。
        /// </summary>
        public static Func<T15, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16> ToObjective<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, T16>>>>>>>>>>>>>>> self)
        {
            return (t15, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => self(t1)(t2)(t3)(t4)(t5)(t6)(t7)(t8)(t9)(t10)(t11)(t12)(t13)(t14)(t15);
        }

        /// <summary>
        /// 第一引数に操作対象が来るような関数を、カリー化しつつ第一引数を最後の位置に持って行きます。
        /// これにより、オブジェクト指向スタイルの関数に対する部分適用を容易にします。
        /// </summary>
        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, Func<T1, T17>>>>>>>>>>>>>>>> ToFunctional<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> self)
        {
            return t2 => t3 => t4 => t5 => t6 => t7 => t8 => t9 => t10 => t11 => t12 => t13 => t14 => t15 => t16 => t1 => self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);
        }

        /// <summary>
        /// 最終引数に操作対象が来るようにカリー化された関数を、アンカリー化しつつ最後の引数を第一引数の位置に持って行きます。
        /// これにより、C#上でより自然に関数型スタイルの関数を扱えるようにします。
        /// </summary>
        public static Func<T16, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17> ToObjective<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, T17>>>>>>>>>>>>>>>> self)
        {
            return (t16, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => self(t1)(t2)(t3)(t4)(t5)(t6)(t7)(t8)(t9)(t10)(t11)(t12)(t13)(t14)(t15)(t16);
        }

    }
}