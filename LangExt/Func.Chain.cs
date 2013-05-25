
using System;

namespace LangExt
{
    partial class Func
    {
        /// <summary>
        /// 複数の関数を合成して一つの関数にします。
        /// </summary>
        public static Func<T1, T3> Chain<T1, T2, T3>(Func<T1, T2> f1, Func<T2, T3> f2)
        {
            return x => f2(f1(x));
        }

        /// <summary>
        /// 複数の関数を合成して一つの関数にします。
        /// </summary>
        public static Func<T1, T4> Chain<T1, T2, T3, T4>(Func<T1, T2> f1, Func<T2, T3> f2, Func<T3, T4> f3)
        {
            return x => f3(f2(f1(x)));
        }

        /// <summary>
        /// 複数の関数を合成して一つの関数にします。
        /// </summary>
        public static Func<T1, T5> Chain<T1, T2, T3, T4, T5>(Func<T1, T2> f1, Func<T2, T3> f2, Func<T3, T4> f3, Func<T4, T5> f4)
        {
            return x => f4(f3(f2(f1(x))));
        }

        /// <summary>
        /// 複数の関数を合成して一つの関数にします。
        /// </summary>
        public static Func<T1, T6> Chain<T1, T2, T3, T4, T5, T6>(Func<T1, T2> f1, Func<T2, T3> f2, Func<T3, T4> f3, Func<T4, T5> f4, Func<T5, T6> f5)
        {
            return x => f5(f4(f3(f2(f1(x)))));
        }

        /// <summary>
        /// 複数の関数を合成して一つの関数にします。
        /// </summary>
        public static Func<T1, T7> Chain<T1, T2, T3, T4, T5, T6, T7>(Func<T1, T2> f1, Func<T2, T3> f2, Func<T3, T4> f3, Func<T4, T5> f4, Func<T5, T6> f5, Func<T6, T7> f6)
        {
            return x => f6(f5(f4(f3(f2(f1(x))))));
        }

        /// <summary>
        /// 複数の関数を合成して一つの関数にします。
        /// </summary>
        public static Func<T1, T8> Chain<T1, T2, T3, T4, T5, T6, T7, T8>(Func<T1, T2> f1, Func<T2, T3> f2, Func<T3, T4> f3, Func<T4, T5> f4, Func<T5, T6> f5, Func<T6, T7> f6, Func<T7, T8> f7)
        {
            return x => f7(f6(f5(f4(f3(f2(f1(x)))))));
        }

        /// <summary>
        /// 複数の関数を合成して一つの関数にします。
        /// </summary>
        public static Func<T1, T9> Chain<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Func<T1, T2> f1, Func<T2, T3> f2, Func<T3, T4> f3, Func<T4, T5> f4, Func<T5, T6> f5, Func<T6, T7> f6, Func<T7, T8> f7, Func<T8, T9> f8)
        {
            return x => f8(f7(f6(f5(f4(f3(f2(f1(x))))))));
        }

        /// <summary>
        /// 複数の関数を合成して一つの関数にします。
        /// </summary>
        public static Func<T1, T10> Chain<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Func<T1, T2> f1, Func<T2, T3> f2, Func<T3, T4> f3, Func<T4, T5> f4, Func<T5, T6> f5, Func<T6, T7> f6, Func<T7, T8> f7, Func<T8, T9> f8, Func<T9, T10> f9)
        {
            return x => f9(f8(f7(f6(f5(f4(f3(f2(f1(x)))))))));
        }

        /// <summary>
        /// 複数の関数を合成して一つの関数にします。
        /// </summary>
        public static Func<T1, T11> Chain<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Func<T1, T2> f1, Func<T2, T3> f2, Func<T3, T4> f3, Func<T4, T5> f4, Func<T5, T6> f5, Func<T6, T7> f6, Func<T7, T8> f7, Func<T8, T9> f8, Func<T9, T10> f9, Func<T10, T11> f10)
        {
            return x => f10(f9(f8(f7(f6(f5(f4(f3(f2(f1(x))))))))));
        }

        /// <summary>
        /// 複数の関数を合成して一つの関数にします。
        /// </summary>
        public static Func<T1, T12> Chain<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Func<T1, T2> f1, Func<T2, T3> f2, Func<T3, T4> f3, Func<T4, T5> f4, Func<T5, T6> f5, Func<T6, T7> f6, Func<T7, T8> f7, Func<T8, T9> f8, Func<T9, T10> f9, Func<T10, T11> f10, Func<T11, T12> f11)
        {
            return x => f11(f10(f9(f8(f7(f6(f5(f4(f3(f2(f1(x)))))))))));
        }

        /// <summary>
        /// 複数の関数を合成して一つの関数にします。
        /// </summary>
        public static Func<T1, T13> Chain<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Func<T1, T2> f1, Func<T2, T3> f2, Func<T3, T4> f3, Func<T4, T5> f4, Func<T5, T6> f5, Func<T6, T7> f6, Func<T7, T8> f7, Func<T8, T9> f8, Func<T9, T10> f9, Func<T10, T11> f10, Func<T11, T12> f11, Func<T12, T13> f12)
        {
            return x => f12(f11(f10(f9(f8(f7(f6(f5(f4(f3(f2(f1(x))))))))))));
        }

        /// <summary>
        /// 複数の関数を合成して一つの関数にします。
        /// </summary>
        public static Func<T1, T14> Chain<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Func<T1, T2> f1, Func<T2, T3> f2, Func<T3, T4> f3, Func<T4, T5> f4, Func<T5, T6> f5, Func<T6, T7> f6, Func<T7, T8> f7, Func<T8, T9> f8, Func<T9, T10> f9, Func<T10, T11> f10, Func<T11, T12> f11, Func<T12, T13> f12, Func<T13, T14> f13)
        {
            return x => f13(f12(f11(f10(f9(f8(f7(f6(f5(f4(f3(f2(f1(x)))))))))))));
        }

        /// <summary>
        /// 複数の関数を合成して一つの関数にします。
        /// </summary>
        public static Func<T1, T15> Chain<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Func<T1, T2> f1, Func<T2, T3> f2, Func<T3, T4> f3, Func<T4, T5> f4, Func<T5, T6> f5, Func<T6, T7> f6, Func<T7, T8> f7, Func<T8, T9> f8, Func<T9, T10> f9, Func<T10, T11> f10, Func<T11, T12> f11, Func<T12, T13> f12, Func<T13, T14> f13, Func<T14, T15> f14)
        {
            return x => f14(f13(f12(f11(f10(f9(f8(f7(f6(f5(f4(f3(f2(f1(x))))))))))))));
        }

        /// <summary>
        /// 複数の関数を合成して一つの関数にします。
        /// </summary>
        public static Func<T1, T16> Chain<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Func<T1, T2> f1, Func<T2, T3> f2, Func<T3, T4> f3, Func<T4, T5> f4, Func<T5, T6> f5, Func<T6, T7> f6, Func<T7, T8> f7, Func<T8, T9> f8, Func<T9, T10> f9, Func<T10, T11> f10, Func<T11, T12> f11, Func<T12, T13> f12, Func<T13, T14> f13, Func<T14, T15> f14, Func<T15, T16> f15)
        {
            return x => f15(f14(f13(f12(f11(f10(f9(f8(f7(f6(f5(f4(f3(f2(f1(x)))))))))))))));
        }

        /// <summary>
        /// 複数の関数を合成して一つの関数にします。
        /// </summary>
        public static Func<T1, T17> Chain<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(Func<T1, T2> f1, Func<T2, T3> f2, Func<T3, T4> f3, Func<T4, T5> f4, Func<T5, T6> f5, Func<T6, T7> f6, Func<T7, T8> f7, Func<T8, T9> f8, Func<T9, T10> f9, Func<T10, T11> f10, Func<T11, T12> f11, Func<T12, T13> f12, Func<T13, T14> f13, Func<T14, T15> f14, Func<T15, T16> f15, Func<T16, T17> f16)
        {
            return x => f16(f15(f14(f13(f12(f11(f10(f9(f8(f7(f6(f5(f4(f3(f2(f1(x))))))))))))))));
        }

    }
}
