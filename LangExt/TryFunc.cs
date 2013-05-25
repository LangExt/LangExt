
using System;

namespace LangExt
{

    /// <summary>
    /// TryFuncに対する関数を提供します。
    /// </summary>
    public static partial class TryFunc { }

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc<TResult>(out TResult result);

    partial class TryFunc
    {
        public static Func<Option<TResult>> ToOptFunc<TResult>(this TryFunc<TResult> f)
        {
            return () =>
            {
                TResult res;
                if (f(out res))
                    return Create.Option(res);
                return Option.None;
            };
        }
    }

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc<T1, TResult>(T1 t1, out TResult result);

    partial class TryFunc
    {
        public static Func<T1, Option<TResult>> ToOptFunc<T1, TResult>(this TryFunc<T1, TResult> f)
        {
            return (t1) =>
            {
                TResult res;
                if (f(t1, out res))
                    return Create.Option(res);
                return Option.None;
            };
        }
    }

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc<T1, T2, TResult>(T1 t1, T2 t2, out TResult result);

    partial class TryFunc
    {
        public static Func<T1, T2, Option<TResult>> ToOptFunc<T1, T2, TResult>(this TryFunc<T1, T2, TResult> f)
        {
            return (t1, t2) =>
            {
                TResult res;
                if (f(t1, t2, out res))
                    return Create.Option(res);
                return Option.None;
            };
        }
    }

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc<T1, T2, T3, TResult>(T1 t1, T2 t2, T3 t3, out TResult result);

    partial class TryFunc
    {
        public static Func<T1, T2, T3, Option<TResult>> ToOptFunc<T1, T2, T3, TResult>(this TryFunc<T1, T2, T3, TResult> f)
        {
            return (t1, t2, t3) =>
            {
                TResult res;
                if (f(t1, t2, t3, out res))
                    return Create.Option(res);
                return Option.None;
            };
        }
    }

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc<T1, T2, T3, T4, TResult>(T1 t1, T2 t2, T3 t3, T4 t4, out TResult result);

    partial class TryFunc
    {
        public static Func<T1, T2, T3, T4, Option<TResult>> ToOptFunc<T1, T2, T3, T4, TResult>(this TryFunc<T1, T2, T3, T4, TResult> f)
        {
            return (t1, t2, t3, t4) =>
            {
                TResult res;
                if (f(t1, t2, t3, t4, out res))
                    return Create.Option(res);
                return Option.None;
            };
        }
    }

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc<T1, T2, T3, T4, T5, TResult>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, out TResult result);

    partial class TryFunc
    {
        public static Func<T1, T2, T3, T4, T5, Option<TResult>> ToOptFunc<T1, T2, T3, T4, T5, TResult>(this TryFunc<T1, T2, T3, T4, T5, TResult> f)
        {
            return (t1, t2, t3, t4, t5) =>
            {
                TResult res;
                if (f(t1, t2, t3, t4, t5, out res))
                    return Create.Option(res);
                return Option.None;
            };
        }
    }

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc<T1, T2, T3, T4, T5, T6, TResult>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, out TResult result);

    partial class TryFunc
    {
        public static Func<T1, T2, T3, T4, T5, T6, Option<TResult>> ToOptFunc<T1, T2, T3, T4, T5, T6, TResult>(this TryFunc<T1, T2, T3, T4, T5, T6, TResult> f)
        {
            return (t1, t2, t3, t4, t5, t6) =>
            {
                TResult res;
                if (f(t1, t2, t3, t4, t5, t6, out res))
                    return Create.Option(res);
                return Option.None;
            };
        }
    }

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc<T1, T2, T3, T4, T5, T6, T7, TResult>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, out TResult result);

    partial class TryFunc
    {
        public static Func<T1, T2, T3, T4, T5, T6, T7, Option<TResult>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, TResult>(this TryFunc<T1, T2, T3, T4, T5, T6, T7, TResult> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7) =>
            {
                TResult res;
                if (f(t1, t2, t3, t4, t5, t6, t7, out res))
                    return Create.Option(res);
                return Option.None;
            };
        }
    }

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, out TResult result);

    partial class TryFunc
    {
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, Option<TResult>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this TryFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8) =>
            {
                TResult res;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, out res))
                    return Create.Option(res);
                return Option.None;
            };
        }
    }

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, out TResult result);

    partial class TryFunc
    {
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Option<TResult>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this TryFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9) =>
            {
                TResult res;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, out res))
                    return Create.Option(res);
                return Option.None;
            };
        }
    }

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, out TResult result);

    partial class TryFunc
    {
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Option<TResult>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this TryFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) =>
            {
                TResult res;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, out res))
                    return Create.Option(res);
                return Option.None;
            };
        }
    }

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, out TResult result);

    partial class TryFunc
    {
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Option<TResult>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this TryFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) =>
            {
                TResult res;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, out res))
                    return Create.Option(res);
                return Option.None;
            };
        }
    }

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, out TResult result);

    partial class TryFunc
    {
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Option<TResult>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this TryFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) =>
            {
                TResult res;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, out res))
                    return Create.Option(res);
                return Option.None;
            };
        }
    }

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, out TResult result);

    partial class TryFunc
    {
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Option<TResult>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this TryFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) =>
            {
                TResult res;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, out res))
                    return Create.Option(res);
                return Option.None;
            };
        }
    }

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, out TResult result);

    partial class TryFunc
    {
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Option<TResult>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this TryFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) =>
            {
                TResult res;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, out res))
                    return Create.Option(res);
                return Option.None;
            };
        }
    }

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, out TResult result);

    partial class TryFunc
    {
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Option<TResult>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this TryFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) =>
            {
                TResult res;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, out res))
                    return Create.Option(res);
                return Option.None;
            };
        }
    }

}
