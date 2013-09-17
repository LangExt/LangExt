

namespace LangExt
{
    partial class ObjectModule
    {
        /// <summary>
        /// 引数に渡されたオブジェクトのハッシュ値を計算します。
        /// </summary>
        public static int Hash(params object[] objs)
        {
            var res = 31;
            foreach (var obj in objs)
            {
                res ^= obj == null ? 0 : obj.GetHashCode();
            }
            return res;
        }

        /// <summary>
        /// 引数に渡されたオブジェクトのハッシュ値を計算します。
        /// </summary>
        public static int Hash<T1>(T1 t1)
        {
            var res = 31;
            res ^= t1.IsNull() ? 0 : t1.GetHashCode();
            return res;
        }

        /// <summary>
        /// 引数に渡されたオブジェクトのハッシュ値を計算します。
        /// </summary>
        public static int Hash<T1, T2>(T1 t1, T2 t2)
        {
            var res = 31;
            res ^= t1.IsNull() ? 0 : t1.GetHashCode();
            res ^= t2.IsNull() ? 0 : t2.GetHashCode();
            return res;
        }

        /// <summary>
        /// 引数に渡されたオブジェクトのハッシュ値を計算します。
        /// </summary>
        public static int Hash<T1, T2, T3>(T1 t1, T2 t2, T3 t3)
        {
            var res = 31;
            res ^= t1.IsNull() ? 0 : t1.GetHashCode();
            res ^= t2.IsNull() ? 0 : t2.GetHashCode();
            res ^= t3.IsNull() ? 0 : t3.GetHashCode();
            return res;
        }

        /// <summary>
        /// 引数に渡されたオブジェクトのハッシュ値を計算します。
        /// </summary>
        public static int Hash<T1, T2, T3, T4>(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            var res = 31;
            res ^= t1.IsNull() ? 0 : t1.GetHashCode();
            res ^= t2.IsNull() ? 0 : t2.GetHashCode();
            res ^= t3.IsNull() ? 0 : t3.GetHashCode();
            res ^= t4.IsNull() ? 0 : t4.GetHashCode();
            return res;
        }

        /// <summary>
        /// 引数に渡されたオブジェクトのハッシュ値を計算します。
        /// </summary>
        public static int Hash<T1, T2, T3, T4, T5>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            var res = 31;
            res ^= t1.IsNull() ? 0 : t1.GetHashCode();
            res ^= t2.IsNull() ? 0 : t2.GetHashCode();
            res ^= t3.IsNull() ? 0 : t3.GetHashCode();
            res ^= t4.IsNull() ? 0 : t4.GetHashCode();
            res ^= t5.IsNull() ? 0 : t5.GetHashCode();
            return res;
        }

        /// <summary>
        /// 引数に渡されたオブジェクトのハッシュ値を計算します。
        /// </summary>
        public static int Hash<T1, T2, T3, T4, T5, T6>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
        {
            var res = 31;
            res ^= t1.IsNull() ? 0 : t1.GetHashCode();
            res ^= t2.IsNull() ? 0 : t2.GetHashCode();
            res ^= t3.IsNull() ? 0 : t3.GetHashCode();
            res ^= t4.IsNull() ? 0 : t4.GetHashCode();
            res ^= t5.IsNull() ? 0 : t5.GetHashCode();
            res ^= t6.IsNull() ? 0 : t6.GetHashCode();
            return res;
        }

        /// <summary>
        /// 引数に渡されたオブジェクトのハッシュ値を計算します。
        /// </summary>
        public static int Hash<T1, T2, T3, T4, T5, T6, T7>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
        {
            var res = 31;
            res ^= t1.IsNull() ? 0 : t1.GetHashCode();
            res ^= t2.IsNull() ? 0 : t2.GetHashCode();
            res ^= t3.IsNull() ? 0 : t3.GetHashCode();
            res ^= t4.IsNull() ? 0 : t4.GetHashCode();
            res ^= t5.IsNull() ? 0 : t5.GetHashCode();
            res ^= t6.IsNull() ? 0 : t6.GetHashCode();
            res ^= t7.IsNull() ? 0 : t7.GetHashCode();
            return res;
        }

        /// <summary>
        /// 引数に渡されたオブジェクトのハッシュ値を計算します。
        /// </summary>
        public static int Hash<T1, T2, T3, T4, T5, T6, T7, T8>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
        {
            var res = 31;
            res ^= t1.IsNull() ? 0 : t1.GetHashCode();
            res ^= t2.IsNull() ? 0 : t2.GetHashCode();
            res ^= t3.IsNull() ? 0 : t3.GetHashCode();
            res ^= t4.IsNull() ? 0 : t4.GetHashCode();
            res ^= t5.IsNull() ? 0 : t5.GetHashCode();
            res ^= t6.IsNull() ? 0 : t6.GetHashCode();
            res ^= t7.IsNull() ? 0 : t7.GetHashCode();
            res ^= t8.IsNull() ? 0 : t8.GetHashCode();
            return res;
        }

        /// <summary>
        /// 引数に渡されたオブジェクトのハッシュ値を計算します。
        /// </summary>
        public static int Hash<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
        {
            var res = 31;
            res ^= t1.IsNull() ? 0 : t1.GetHashCode();
            res ^= t2.IsNull() ? 0 : t2.GetHashCode();
            res ^= t3.IsNull() ? 0 : t3.GetHashCode();
            res ^= t4.IsNull() ? 0 : t4.GetHashCode();
            res ^= t5.IsNull() ? 0 : t5.GetHashCode();
            res ^= t6.IsNull() ? 0 : t6.GetHashCode();
            res ^= t7.IsNull() ? 0 : t7.GetHashCode();
            res ^= t8.IsNull() ? 0 : t8.GetHashCode();
            res ^= t9.IsNull() ? 0 : t9.GetHashCode();
            return res;
        }

        /// <summary>
        /// 引数に渡されたオブジェクトのハッシュ値を計算します。
        /// </summary>
        public static int Hash<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
        {
            var res = 31;
            res ^= t1.IsNull() ? 0 : t1.GetHashCode();
            res ^= t2.IsNull() ? 0 : t2.GetHashCode();
            res ^= t3.IsNull() ? 0 : t3.GetHashCode();
            res ^= t4.IsNull() ? 0 : t4.GetHashCode();
            res ^= t5.IsNull() ? 0 : t5.GetHashCode();
            res ^= t6.IsNull() ? 0 : t6.GetHashCode();
            res ^= t7.IsNull() ? 0 : t7.GetHashCode();
            res ^= t8.IsNull() ? 0 : t8.GetHashCode();
            res ^= t9.IsNull() ? 0 : t9.GetHashCode();
            res ^= t10.IsNull() ? 0 : t10.GetHashCode();
            return res;
        }

        /// <summary>
        /// 引数に渡されたオブジェクトのハッシュ値を計算します。
        /// </summary>
        public static int Hash<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
        {
            var res = 31;
            res ^= t1.IsNull() ? 0 : t1.GetHashCode();
            res ^= t2.IsNull() ? 0 : t2.GetHashCode();
            res ^= t3.IsNull() ? 0 : t3.GetHashCode();
            res ^= t4.IsNull() ? 0 : t4.GetHashCode();
            res ^= t5.IsNull() ? 0 : t5.GetHashCode();
            res ^= t6.IsNull() ? 0 : t6.GetHashCode();
            res ^= t7.IsNull() ? 0 : t7.GetHashCode();
            res ^= t8.IsNull() ? 0 : t8.GetHashCode();
            res ^= t9.IsNull() ? 0 : t9.GetHashCode();
            res ^= t10.IsNull() ? 0 : t10.GetHashCode();
            res ^= t11.IsNull() ? 0 : t11.GetHashCode();
            return res;
        }

        /// <summary>
        /// 引数に渡されたオブジェクトのハッシュ値を計算します。
        /// </summary>
        public static int Hash<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
        {
            var res = 31;
            res ^= t1.IsNull() ? 0 : t1.GetHashCode();
            res ^= t2.IsNull() ? 0 : t2.GetHashCode();
            res ^= t3.IsNull() ? 0 : t3.GetHashCode();
            res ^= t4.IsNull() ? 0 : t4.GetHashCode();
            res ^= t5.IsNull() ? 0 : t5.GetHashCode();
            res ^= t6.IsNull() ? 0 : t6.GetHashCode();
            res ^= t7.IsNull() ? 0 : t7.GetHashCode();
            res ^= t8.IsNull() ? 0 : t8.GetHashCode();
            res ^= t9.IsNull() ? 0 : t9.GetHashCode();
            res ^= t10.IsNull() ? 0 : t10.GetHashCode();
            res ^= t11.IsNull() ? 0 : t11.GetHashCode();
            res ^= t12.IsNull() ? 0 : t12.GetHashCode();
            return res;
        }

        /// <summary>
        /// 引数に渡されたオブジェクトのハッシュ値を計算します。
        /// </summary>
        public static int Hash<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
        {
            var res = 31;
            res ^= t1.IsNull() ? 0 : t1.GetHashCode();
            res ^= t2.IsNull() ? 0 : t2.GetHashCode();
            res ^= t3.IsNull() ? 0 : t3.GetHashCode();
            res ^= t4.IsNull() ? 0 : t4.GetHashCode();
            res ^= t5.IsNull() ? 0 : t5.GetHashCode();
            res ^= t6.IsNull() ? 0 : t6.GetHashCode();
            res ^= t7.IsNull() ? 0 : t7.GetHashCode();
            res ^= t8.IsNull() ? 0 : t8.GetHashCode();
            res ^= t9.IsNull() ? 0 : t9.GetHashCode();
            res ^= t10.IsNull() ? 0 : t10.GetHashCode();
            res ^= t11.IsNull() ? 0 : t11.GetHashCode();
            res ^= t12.IsNull() ? 0 : t12.GetHashCode();
            res ^= t13.IsNull() ? 0 : t13.GetHashCode();
            return res;
        }

        /// <summary>
        /// 引数に渡されたオブジェクトのハッシュ値を計算します。
        /// </summary>
        public static int Hash<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
        {
            var res = 31;
            res ^= t1.IsNull() ? 0 : t1.GetHashCode();
            res ^= t2.IsNull() ? 0 : t2.GetHashCode();
            res ^= t3.IsNull() ? 0 : t3.GetHashCode();
            res ^= t4.IsNull() ? 0 : t4.GetHashCode();
            res ^= t5.IsNull() ? 0 : t5.GetHashCode();
            res ^= t6.IsNull() ? 0 : t6.GetHashCode();
            res ^= t7.IsNull() ? 0 : t7.GetHashCode();
            res ^= t8.IsNull() ? 0 : t8.GetHashCode();
            res ^= t9.IsNull() ? 0 : t9.GetHashCode();
            res ^= t10.IsNull() ? 0 : t10.GetHashCode();
            res ^= t11.IsNull() ? 0 : t11.GetHashCode();
            res ^= t12.IsNull() ? 0 : t12.GetHashCode();
            res ^= t13.IsNull() ? 0 : t13.GetHashCode();
            res ^= t14.IsNull() ? 0 : t14.GetHashCode();
            return res;
        }

        /// <summary>
        /// 引数に渡されたオブジェクトのハッシュ値を計算します。
        /// </summary>
        public static int Hash<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
        {
            var res = 31;
            res ^= t1.IsNull() ? 0 : t1.GetHashCode();
            res ^= t2.IsNull() ? 0 : t2.GetHashCode();
            res ^= t3.IsNull() ? 0 : t3.GetHashCode();
            res ^= t4.IsNull() ? 0 : t4.GetHashCode();
            res ^= t5.IsNull() ? 0 : t5.GetHashCode();
            res ^= t6.IsNull() ? 0 : t6.GetHashCode();
            res ^= t7.IsNull() ? 0 : t7.GetHashCode();
            res ^= t8.IsNull() ? 0 : t8.GetHashCode();
            res ^= t9.IsNull() ? 0 : t9.GetHashCode();
            res ^= t10.IsNull() ? 0 : t10.GetHashCode();
            res ^= t11.IsNull() ? 0 : t11.GetHashCode();
            res ^= t12.IsNull() ? 0 : t12.GetHashCode();
            res ^= t13.IsNull() ? 0 : t13.GetHashCode();
            res ^= t14.IsNull() ? 0 : t14.GetHashCode();
            res ^= t15.IsNull() ? 0 : t15.GetHashCode();
            return res;
        }

        /// <summary>
        /// 引数に渡されたオブジェクトのハッシュ値を計算します。
        /// </summary>
        public static int Hash<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16)
        {
            var res = 31;
            res ^= t1.IsNull() ? 0 : t1.GetHashCode();
            res ^= t2.IsNull() ? 0 : t2.GetHashCode();
            res ^= t3.IsNull() ? 0 : t3.GetHashCode();
            res ^= t4.IsNull() ? 0 : t4.GetHashCode();
            res ^= t5.IsNull() ? 0 : t5.GetHashCode();
            res ^= t6.IsNull() ? 0 : t6.GetHashCode();
            res ^= t7.IsNull() ? 0 : t7.GetHashCode();
            res ^= t8.IsNull() ? 0 : t8.GetHashCode();
            res ^= t9.IsNull() ? 0 : t9.GetHashCode();
            res ^= t10.IsNull() ? 0 : t10.GetHashCode();
            res ^= t11.IsNull() ? 0 : t11.GetHashCode();
            res ^= t12.IsNull() ? 0 : t12.GetHashCode();
            res ^= t13.IsNull() ? 0 : t13.GetHashCode();
            res ^= t14.IsNull() ? 0 : t14.GetHashCode();
            res ^= t15.IsNull() ? 0 : t15.GetHashCode();
            res ^= t16.IsNull() ? 0 : t16.GetHashCode();
            return res;
        }
    }
}