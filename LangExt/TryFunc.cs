
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
    public delegate bool TryFunc1<TResult1>(out TResult1 result1);

    partial class TryFunc
    {
        public static Func<Option<TResult1>> ToOptFunc<TResult1>(this TryFunc1<TResult1> f)
        {
            return () =>
            {
                TResult1 res1;
                if (f(out res1))
                    return Create.Option(res1);
                return Option.None;
            };
        }
    }

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc1<T1, TResult1>(T1 t1, out TResult1 result1);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc2<TResult1, TResult2>(out TResult1 result1, out TResult2 result2);

    partial class TryFunc
    {
        public static Func<T1, Option<TResult1>> ToOptFunc<T1, TResult1>(this TryFunc1<T1, TResult1> f)
        {
            return (t1) =>
            {
                TResult1 res1;
                if (f(t1, out res1))
                    return Create.Option(res1);
                return Option.None;
            };
        }
        public static Func<Option<Tuple<TResult1, TResult2>>> ToOptFunc<TResult1, TResult2>(this TryFunc2<TResult1, TResult2> f)
        {
            return () =>
            {
                TResult1 res1;
                TResult2 res2;
                if (f(out res1, out res2))
                    return Create.Option(Create.Tuple(res1, res2));
                return Option.None;
            };
        }
    }

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc1<T1, T2, TResult1>(T1 t1, T2 t2, out TResult1 result1);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc2<T1, TResult1, TResult2>(T1 t1, out TResult1 result1, out TResult2 result2);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc3<TResult1, TResult2, TResult3>(out TResult1 result1, out TResult2 result2, out TResult3 result3);

    partial class TryFunc
    {
        public static Func<T1, T2, Option<TResult1>> ToOptFunc<T1, T2, TResult1>(this TryFunc1<T1, T2, TResult1> f)
        {
            return (t1, t2) =>
            {
                TResult1 res1;
                if (f(t1, t2, out res1))
                    return Create.Option(res1);
                return Option.None;
            };
        }
        public static Func<T1, Option<Tuple<TResult1, TResult2>>> ToOptFunc<T1, TResult1, TResult2>(this TryFunc2<T1, TResult1, TResult2> f)
        {
            return (t1) =>
            {
                TResult1 res1;
                TResult2 res2;
                if (f(t1, out res1, out res2))
                    return Create.Option(Create.Tuple(res1, res2));
                return Option.None;
            };
        }
        public static Func<Option<Tuple<TResult1, TResult2, TResult3>>> ToOptFunc<TResult1, TResult2, TResult3>(this TryFunc3<TResult1, TResult2, TResult3> f)
        {
            return () =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                if (f(out res1, out res2, out res3))
                    return Create.Option(Create.Tuple(res1, res2, res3));
                return Option.None;
            };
        }
    }

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc1<T1, T2, T3, TResult1>(T1 t1, T2 t2, T3 t3, out TResult1 result1);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc2<T1, T2, TResult1, TResult2>(T1 t1, T2 t2, out TResult1 result1, out TResult2 result2);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc3<T1, TResult1, TResult2, TResult3>(T1 t1, out TResult1 result1, out TResult2 result2, out TResult3 result3);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc4<TResult1, TResult2, TResult3, TResult4>(out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4);

    partial class TryFunc
    {
        public static Func<T1, T2, T3, Option<TResult1>> ToOptFunc<T1, T2, T3, TResult1>(this TryFunc1<T1, T2, T3, TResult1> f)
        {
            return (t1, t2, t3) =>
            {
                TResult1 res1;
                if (f(t1, t2, t3, out res1))
                    return Create.Option(res1);
                return Option.None;
            };
        }
        public static Func<T1, T2, Option<Tuple<TResult1, TResult2>>> ToOptFunc<T1, T2, TResult1, TResult2>(this TryFunc2<T1, T2, TResult1, TResult2> f)
        {
            return (t1, t2) =>
            {
                TResult1 res1;
                TResult2 res2;
                if (f(t1, t2, out res1, out res2))
                    return Create.Option(Create.Tuple(res1, res2));
                return Option.None;
            };
        }
        public static Func<T1, Option<Tuple<TResult1, TResult2, TResult3>>> ToOptFunc<T1, TResult1, TResult2, TResult3>(this TryFunc3<T1, TResult1, TResult2, TResult3> f)
        {
            return (t1) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                if (f(t1, out res1, out res2, out res3))
                    return Create.Option(Create.Tuple(res1, res2, res3));
                return Option.None;
            };
        }
        public static Func<Option<Tuple<TResult1, TResult2, TResult3, TResult4>>> ToOptFunc<TResult1, TResult2, TResult3, TResult4>(this TryFunc4<TResult1, TResult2, TResult3, TResult4> f)
        {
            return () =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                if (f(out res1, out res2, out res3, out res4))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4));
                return Option.None;
            };
        }
    }

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc1<T1, T2, T3, T4, TResult1>(T1 t1, T2 t2, T3 t3, T4 t4, out TResult1 result1);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc2<T1, T2, T3, TResult1, TResult2>(T1 t1, T2 t2, T3 t3, out TResult1 result1, out TResult2 result2);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc3<T1, T2, TResult1, TResult2, TResult3>(T1 t1, T2 t2, out TResult1 result1, out TResult2 result2, out TResult3 result3);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc4<T1, TResult1, TResult2, TResult3, TResult4>(T1 t1, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc5<TResult1, TResult2, TResult3, TResult4, TResult5>(out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5);

    partial class TryFunc
    {
        public static Func<T1, T2, T3, T4, Option<TResult1>> ToOptFunc<T1, T2, T3, T4, TResult1>(this TryFunc1<T1, T2, T3, T4, TResult1> f)
        {
            return (t1, t2, t3, t4) =>
            {
                TResult1 res1;
                if (f(t1, t2, t3, t4, out res1))
                    return Create.Option(res1);
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, Option<Tuple<TResult1, TResult2>>> ToOptFunc<T1, T2, T3, TResult1, TResult2>(this TryFunc2<T1, T2, T3, TResult1, TResult2> f)
        {
            return (t1, t2, t3) =>
            {
                TResult1 res1;
                TResult2 res2;
                if (f(t1, t2, t3, out res1, out res2))
                    return Create.Option(Create.Tuple(res1, res2));
                return Option.None;
            };
        }
        public static Func<T1, T2, Option<Tuple<TResult1, TResult2, TResult3>>> ToOptFunc<T1, T2, TResult1, TResult2, TResult3>(this TryFunc3<T1, T2, TResult1, TResult2, TResult3> f)
        {
            return (t1, t2) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                if (f(t1, t2, out res1, out res2, out res3))
                    return Create.Option(Create.Tuple(res1, res2, res3));
                return Option.None;
            };
        }
        public static Func<T1, Option<Tuple<TResult1, TResult2, TResult3, TResult4>>> ToOptFunc<T1, TResult1, TResult2, TResult3, TResult4>(this TryFunc4<T1, TResult1, TResult2, TResult3, TResult4> f)
        {
            return (t1) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                if (f(t1, out res1, out res2, out res3, out res4))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4));
                return Option.None;
            };
        }
        public static Func<Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5>>> ToOptFunc<TResult1, TResult2, TResult3, TResult4, TResult5>(this TryFunc5<TResult1, TResult2, TResult3, TResult4, TResult5> f)
        {
            return () =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                if (f(out res1, out res2, out res3, out res4, out res5))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5));
                return Option.None;
            };
        }
    }

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc1<T1, T2, T3, T4, T5, TResult1>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, out TResult1 result1);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc2<T1, T2, T3, T4, TResult1, TResult2>(T1 t1, T2 t2, T3 t3, T4 t4, out TResult1 result1, out TResult2 result2);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc3<T1, T2, T3, TResult1, TResult2, TResult3>(T1 t1, T2 t2, T3 t3, out TResult1 result1, out TResult2 result2, out TResult3 result3);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc4<T1, T2, TResult1, TResult2, TResult3, TResult4>(T1 t1, T2 t2, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc5<T1, TResult1, TResult2, TResult3, TResult4, TResult5>(T1 t1, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc6<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>(out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6);

    partial class TryFunc
    {
        public static Func<T1, T2, T3, T4, T5, Option<TResult1>> ToOptFunc<T1, T2, T3, T4, T5, TResult1>(this TryFunc1<T1, T2, T3, T4, T5, TResult1> f)
        {
            return (t1, t2, t3, t4, t5) =>
            {
                TResult1 res1;
                if (f(t1, t2, t3, t4, t5, out res1))
                    return Create.Option(res1);
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, Option<Tuple<TResult1, TResult2>>> ToOptFunc<T1, T2, T3, T4, TResult1, TResult2>(this TryFunc2<T1, T2, T3, T4, TResult1, TResult2> f)
        {
            return (t1, t2, t3, t4) =>
            {
                TResult1 res1;
                TResult2 res2;
                if (f(t1, t2, t3, t4, out res1, out res2))
                    return Create.Option(Create.Tuple(res1, res2));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, Option<Tuple<TResult1, TResult2, TResult3>>> ToOptFunc<T1, T2, T3, TResult1, TResult2, TResult3>(this TryFunc3<T1, T2, T3, TResult1, TResult2, TResult3> f)
        {
            return (t1, t2, t3) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                if (f(t1, t2, t3, out res1, out res2, out res3))
                    return Create.Option(Create.Tuple(res1, res2, res3));
                return Option.None;
            };
        }
        public static Func<T1, T2, Option<Tuple<TResult1, TResult2, TResult3, TResult4>>> ToOptFunc<T1, T2, TResult1, TResult2, TResult3, TResult4>(this TryFunc4<T1, T2, TResult1, TResult2, TResult3, TResult4> f)
        {
            return (t1, t2) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                if (f(t1, t2, out res1, out res2, out res3, out res4))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4));
                return Option.None;
            };
        }
        public static Func<T1, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5>>> ToOptFunc<T1, TResult1, TResult2, TResult3, TResult4, TResult5>(this TryFunc5<T1, TResult1, TResult2, TResult3, TResult4, TResult5> f)
        {
            return (t1) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                if (f(t1, out res1, out res2, out res3, out res4, out res5))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5));
                return Option.None;
            };
        }
        public static Func<Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>>> ToOptFunc<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>(this TryFunc6<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> f)
        {
            return () =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                if (f(out res1, out res2, out res3, out res4, out res5, out res6))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6));
                return Option.None;
            };
        }
    }

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc1<T1, T2, T3, T4, T5, T6, TResult1>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, out TResult1 result1);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc2<T1, T2, T3, T4, T5, TResult1, TResult2>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, out TResult1 result1, out TResult2 result2);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc3<T1, T2, T3, T4, TResult1, TResult2, TResult3>(T1 t1, T2 t2, T3 t3, T4 t4, out TResult1 result1, out TResult2 result2, out TResult3 result3);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc4<T1, T2, T3, TResult1, TResult2, TResult3, TResult4>(T1 t1, T2 t2, T3 t3, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc5<T1, T2, TResult1, TResult2, TResult3, TResult4, TResult5>(T1 t1, T2 t2, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc6<T1, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>(T1 t1, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc7<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>(out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7);

    partial class TryFunc
    {
        public static Func<T1, T2, T3, T4, T5, T6, Option<TResult1>> ToOptFunc<T1, T2, T3, T4, T5, T6, TResult1>(this TryFunc1<T1, T2, T3, T4, T5, T6, TResult1> f)
        {
            return (t1, t2, t3, t4, t5, t6) =>
            {
                TResult1 res1;
                if (f(t1, t2, t3, t4, t5, t6, out res1))
                    return Create.Option(res1);
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, Option<Tuple<TResult1, TResult2>>> ToOptFunc<T1, T2, T3, T4, T5, TResult1, TResult2>(this TryFunc2<T1, T2, T3, T4, T5, TResult1, TResult2> f)
        {
            return (t1, t2, t3, t4, t5) =>
            {
                TResult1 res1;
                TResult2 res2;
                if (f(t1, t2, t3, t4, t5, out res1, out res2))
                    return Create.Option(Create.Tuple(res1, res2));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, Option<Tuple<TResult1, TResult2, TResult3>>> ToOptFunc<T1, T2, T3, T4, TResult1, TResult2, TResult3>(this TryFunc3<T1, T2, T3, T4, TResult1, TResult2, TResult3> f)
        {
            return (t1, t2, t3, t4) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                if (f(t1, t2, t3, t4, out res1, out res2, out res3))
                    return Create.Option(Create.Tuple(res1, res2, res3));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, Option<Tuple<TResult1, TResult2, TResult3, TResult4>>> ToOptFunc<T1, T2, T3, TResult1, TResult2, TResult3, TResult4>(this TryFunc4<T1, T2, T3, TResult1, TResult2, TResult3, TResult4> f)
        {
            return (t1, t2, t3) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                if (f(t1, t2, t3, out res1, out res2, out res3, out res4))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4));
                return Option.None;
            };
        }
        public static Func<T1, T2, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5>>> ToOptFunc<T1, T2, TResult1, TResult2, TResult3, TResult4, TResult5>(this TryFunc5<T1, T2, TResult1, TResult2, TResult3, TResult4, TResult5> f)
        {
            return (t1, t2) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                if (f(t1, t2, out res1, out res2, out res3, out res4, out res5))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5));
                return Option.None;
            };
        }
        public static Func<T1, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>>> ToOptFunc<T1, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>(this TryFunc6<T1, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> f)
        {
            return (t1) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                if (f(t1, out res1, out res2, out res3, out res4, out res5, out res6))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6));
                return Option.None;
            };
        }
        public static Func<Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>>> ToOptFunc<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>(this TryFunc7<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> f)
        {
            return () =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                if (f(out res1, out res2, out res3, out res4, out res5, out res6, out res7))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7));
                return Option.None;
            };
        }
    }

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc1<T1, T2, T3, T4, T5, T6, T7, TResult1>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, out TResult1 result1);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc2<T1, T2, T3, T4, T5, T6, TResult1, TResult2>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, out TResult1 result1, out TResult2 result2);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc3<T1, T2, T3, T4, T5, TResult1, TResult2, TResult3>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, out TResult1 result1, out TResult2 result2, out TResult3 result3);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc4<T1, T2, T3, T4, TResult1, TResult2, TResult3, TResult4>(T1 t1, T2 t2, T3 t3, T4 t4, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc5<T1, T2, T3, TResult1, TResult2, TResult3, TResult4, TResult5>(T1 t1, T2 t2, T3 t3, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc6<T1, T2, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>(T1 t1, T2 t2, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc7<T1, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>(T1 t1, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc8<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8>(out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8);

    partial class TryFunc
    {
        public static Func<T1, T2, T3, T4, T5, T6, T7, Option<TResult1>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, TResult1>(this TryFunc1<T1, T2, T3, T4, T5, T6, T7, TResult1> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7) =>
            {
                TResult1 res1;
                if (f(t1, t2, t3, t4, t5, t6, t7, out res1))
                    return Create.Option(res1);
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, Option<Tuple<TResult1, TResult2>>> ToOptFunc<T1, T2, T3, T4, T5, T6, TResult1, TResult2>(this TryFunc2<T1, T2, T3, T4, T5, T6, TResult1, TResult2> f)
        {
            return (t1, t2, t3, t4, t5, t6) =>
            {
                TResult1 res1;
                TResult2 res2;
                if (f(t1, t2, t3, t4, t5, t6, out res1, out res2))
                    return Create.Option(Create.Tuple(res1, res2));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, Option<Tuple<TResult1, TResult2, TResult3>>> ToOptFunc<T1, T2, T3, T4, T5, TResult1, TResult2, TResult3>(this TryFunc3<T1, T2, T3, T4, T5, TResult1, TResult2, TResult3> f)
        {
            return (t1, t2, t3, t4, t5) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                if (f(t1, t2, t3, t4, t5, out res1, out res2, out res3))
                    return Create.Option(Create.Tuple(res1, res2, res3));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, Option<Tuple<TResult1, TResult2, TResult3, TResult4>>> ToOptFunc<T1, T2, T3, T4, TResult1, TResult2, TResult3, TResult4>(this TryFunc4<T1, T2, T3, T4, TResult1, TResult2, TResult3, TResult4> f)
        {
            return (t1, t2, t3, t4) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                if (f(t1, t2, t3, t4, out res1, out res2, out res3, out res4))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5>>> ToOptFunc<T1, T2, T3, TResult1, TResult2, TResult3, TResult4, TResult5>(this TryFunc5<T1, T2, T3, TResult1, TResult2, TResult3, TResult4, TResult5> f)
        {
            return (t1, t2, t3) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                if (f(t1, t2, t3, out res1, out res2, out res3, out res4, out res5))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5));
                return Option.None;
            };
        }
        public static Func<T1, T2, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>>> ToOptFunc<T1, T2, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>(this TryFunc6<T1, T2, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> f)
        {
            return (t1, t2) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                if (f(t1, t2, out res1, out res2, out res3, out res4, out res5, out res6))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6));
                return Option.None;
            };
        }
        public static Func<T1, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>>> ToOptFunc<T1, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>(this TryFunc7<T1, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> f)
        {
            return (t1) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                if (f(t1, out res1, out res2, out res3, out res4, out res5, out res6, out res7))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7));
                return Option.None;
            };
        }
        public static Func<Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8>>>> ToOptFunc<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8>(this TryFunc8<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> f)
        {
            return () =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                if (f(out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8));
                return Option.None;
            };
        }
    }

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc1<T1, T2, T3, T4, T5, T6, T7, T8, TResult1>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, out TResult1 result1);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc2<T1, T2, T3, T4, T5, T6, T7, TResult1, TResult2>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, out TResult1 result1, out TResult2 result2);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc3<T1, T2, T3, T4, T5, T6, TResult1, TResult2, TResult3>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, out TResult1 result1, out TResult2 result2, out TResult3 result3);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc4<T1, T2, T3, T4, T5, TResult1, TResult2, TResult3, TResult4>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc5<T1, T2, T3, T4, TResult1, TResult2, TResult3, TResult4, TResult5>(T1 t1, T2 t2, T3 t3, T4 t4, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc6<T1, T2, T3, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>(T1 t1, T2 t2, T3 t3, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc7<T1, T2, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>(T1 t1, T2 t2, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc8<T1, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8>(T1 t1, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc9<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9>(out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9);

    partial class TryFunc
    {
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, Option<TResult1>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult1>(this TryFunc1<T1, T2, T3, T4, T5, T6, T7, T8, TResult1> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8) =>
            {
                TResult1 res1;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, out res1))
                    return Create.Option(res1);
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, Option<Tuple<TResult1, TResult2>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, TResult1, TResult2>(this TryFunc2<T1, T2, T3, T4, T5, T6, T7, TResult1, TResult2> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7) =>
            {
                TResult1 res1;
                TResult2 res2;
                if (f(t1, t2, t3, t4, t5, t6, t7, out res1, out res2))
                    return Create.Option(Create.Tuple(res1, res2));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, Option<Tuple<TResult1, TResult2, TResult3>>> ToOptFunc<T1, T2, T3, T4, T5, T6, TResult1, TResult2, TResult3>(this TryFunc3<T1, T2, T3, T4, T5, T6, TResult1, TResult2, TResult3> f)
        {
            return (t1, t2, t3, t4, t5, t6) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                if (f(t1, t2, t3, t4, t5, t6, out res1, out res2, out res3))
                    return Create.Option(Create.Tuple(res1, res2, res3));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, Option<Tuple<TResult1, TResult2, TResult3, TResult4>>> ToOptFunc<T1, T2, T3, T4, T5, TResult1, TResult2, TResult3, TResult4>(this TryFunc4<T1, T2, T3, T4, T5, TResult1, TResult2, TResult3, TResult4> f)
        {
            return (t1, t2, t3, t4, t5) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                if (f(t1, t2, t3, t4, t5, out res1, out res2, out res3, out res4))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5>>> ToOptFunc<T1, T2, T3, T4, TResult1, TResult2, TResult3, TResult4, TResult5>(this TryFunc5<T1, T2, T3, T4, TResult1, TResult2, TResult3, TResult4, TResult5> f)
        {
            return (t1, t2, t3, t4) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                if (f(t1, t2, t3, t4, out res1, out res2, out res3, out res4, out res5))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>>> ToOptFunc<T1, T2, T3, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>(this TryFunc6<T1, T2, T3, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> f)
        {
            return (t1, t2, t3) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                if (f(t1, t2, t3, out res1, out res2, out res3, out res4, out res5, out res6))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6));
                return Option.None;
            };
        }
        public static Func<T1, T2, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>>> ToOptFunc<T1, T2, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>(this TryFunc7<T1, T2, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> f)
        {
            return (t1, t2) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                if (f(t1, t2, out res1, out res2, out res3, out res4, out res5, out res6, out res7))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7));
                return Option.None;
            };
        }
        public static Func<T1, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8>>>> ToOptFunc<T1, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8>(this TryFunc8<T1, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> f)
        {
            return (t1) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                if (f(t1, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8));
                return Option.None;
            };
        }
        public static Func<Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9>>>> ToOptFunc<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9>(this TryFunc9<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> f)
        {
            return () =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                if (f(out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9));
                return Option.None;
            };
        }
    }

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc1<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult1>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, out TResult1 result1);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc2<T1, T2, T3, T4, T5, T6, T7, T8, TResult1, TResult2>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, out TResult1 result1, out TResult2 result2);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc3<T1, T2, T3, T4, T5, T6, T7, TResult1, TResult2, TResult3>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, out TResult1 result1, out TResult2 result2, out TResult3 result3);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc4<T1, T2, T3, T4, T5, T6, TResult1, TResult2, TResult3, TResult4>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc5<T1, T2, T3, T4, T5, TResult1, TResult2, TResult3, TResult4, TResult5>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc6<T1, T2, T3, T4, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>(T1 t1, T2 t2, T3 t3, T4 t4, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc7<T1, T2, T3, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>(T1 t1, T2 t2, T3 t3, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc8<T1, T2, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8>(T1 t1, T2 t2, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc9<T1, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9>(T1 t1, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc10<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10>(out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9, out TResult10 result10);

    partial class TryFunc
    {
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Option<TResult1>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult1>(this TryFunc1<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult1> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9) =>
            {
                TResult1 res1;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, out res1))
                    return Create.Option(res1);
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, Option<Tuple<TResult1, TResult2>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult1, TResult2>(this TryFunc2<T1, T2, T3, T4, T5, T6, T7, T8, TResult1, TResult2> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8) =>
            {
                TResult1 res1;
                TResult2 res2;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, out res1, out res2))
                    return Create.Option(Create.Tuple(res1, res2));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, Option<Tuple<TResult1, TResult2, TResult3>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, TResult1, TResult2, TResult3>(this TryFunc3<T1, T2, T3, T4, T5, T6, T7, TResult1, TResult2, TResult3> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                if (f(t1, t2, t3, t4, t5, t6, t7, out res1, out res2, out res3))
                    return Create.Option(Create.Tuple(res1, res2, res3));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, Option<Tuple<TResult1, TResult2, TResult3, TResult4>>> ToOptFunc<T1, T2, T3, T4, T5, T6, TResult1, TResult2, TResult3, TResult4>(this TryFunc4<T1, T2, T3, T4, T5, T6, TResult1, TResult2, TResult3, TResult4> f)
        {
            return (t1, t2, t3, t4, t5, t6) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                if (f(t1, t2, t3, t4, t5, t6, out res1, out res2, out res3, out res4))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5>>> ToOptFunc<T1, T2, T3, T4, T5, TResult1, TResult2, TResult3, TResult4, TResult5>(this TryFunc5<T1, T2, T3, T4, T5, TResult1, TResult2, TResult3, TResult4, TResult5> f)
        {
            return (t1, t2, t3, t4, t5) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                if (f(t1, t2, t3, t4, t5, out res1, out res2, out res3, out res4, out res5))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>>> ToOptFunc<T1, T2, T3, T4, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>(this TryFunc6<T1, T2, T3, T4, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> f)
        {
            return (t1, t2, t3, t4) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                if (f(t1, t2, t3, t4, out res1, out res2, out res3, out res4, out res5, out res6))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>>> ToOptFunc<T1, T2, T3, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>(this TryFunc7<T1, T2, T3, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> f)
        {
            return (t1, t2, t3) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                if (f(t1, t2, t3, out res1, out res2, out res3, out res4, out res5, out res6, out res7))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7));
                return Option.None;
            };
        }
        public static Func<T1, T2, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8>>>> ToOptFunc<T1, T2, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8>(this TryFunc8<T1, T2, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> f)
        {
            return (t1, t2) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                if (f(t1, t2, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8));
                return Option.None;
            };
        }
        public static Func<T1, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9>>>> ToOptFunc<T1, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9>(this TryFunc9<T1, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> f)
        {
            return (t1) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                if (f(t1, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9));
                return Option.None;
            };
        }
        public static Func<Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9, TResult10>>>> ToOptFunc<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10>(this TryFunc10<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10> f)
        {
            return () =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                TResult10 res10;
                if (f(out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9, out res10))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9, res10));
                return Option.None;
            };
        }
    }

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult1>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, out TResult1 result1);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc2<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult1, TResult2>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, out TResult1 result1, out TResult2 result2);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc3<T1, T2, T3, T4, T5, T6, T7, T8, TResult1, TResult2, TResult3>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, out TResult1 result1, out TResult2 result2, out TResult3 result3);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc4<T1, T2, T3, T4, T5, T6, T7, TResult1, TResult2, TResult3, TResult4>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc5<T1, T2, T3, T4, T5, T6, TResult1, TResult2, TResult3, TResult4, TResult5>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc6<T1, T2, T3, T4, T5, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc7<T1, T2, T3, T4, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>(T1 t1, T2 t2, T3 t3, T4 t4, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc8<T1, T2, T3, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8>(T1 t1, T2 t2, T3 t3, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc9<T1, T2, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9>(T1 t1, T2 t2, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc10<T1, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10>(T1 t1, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9, out TResult10 result10);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc11<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11>(out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9, out TResult10 result10, out TResult11 result11);

    partial class TryFunc
    {
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Option<TResult1>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult1>(this TryFunc1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult1> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) =>
            {
                TResult1 res1;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, out res1))
                    return Create.Option(res1);
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Option<Tuple<TResult1, TResult2>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult1, TResult2>(this TryFunc2<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult1, TResult2> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9) =>
            {
                TResult1 res1;
                TResult2 res2;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, out res1, out res2))
                    return Create.Option(Create.Tuple(res1, res2));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, Option<Tuple<TResult1, TResult2, TResult3>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult1, TResult2, TResult3>(this TryFunc3<T1, T2, T3, T4, T5, T6, T7, T8, TResult1, TResult2, TResult3> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, out res1, out res2, out res3))
                    return Create.Option(Create.Tuple(res1, res2, res3));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, Option<Tuple<TResult1, TResult2, TResult3, TResult4>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, TResult1, TResult2, TResult3, TResult4>(this TryFunc4<T1, T2, T3, T4, T5, T6, T7, TResult1, TResult2, TResult3, TResult4> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                if (f(t1, t2, t3, t4, t5, t6, t7, out res1, out res2, out res3, out res4))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5>>> ToOptFunc<T1, T2, T3, T4, T5, T6, TResult1, TResult2, TResult3, TResult4, TResult5>(this TryFunc5<T1, T2, T3, T4, T5, T6, TResult1, TResult2, TResult3, TResult4, TResult5> f)
        {
            return (t1, t2, t3, t4, t5, t6) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                if (f(t1, t2, t3, t4, t5, t6, out res1, out res2, out res3, out res4, out res5))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>>> ToOptFunc<T1, T2, T3, T4, T5, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>(this TryFunc6<T1, T2, T3, T4, T5, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> f)
        {
            return (t1, t2, t3, t4, t5) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                if (f(t1, t2, t3, t4, t5, out res1, out res2, out res3, out res4, out res5, out res6))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>>> ToOptFunc<T1, T2, T3, T4, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>(this TryFunc7<T1, T2, T3, T4, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> f)
        {
            return (t1, t2, t3, t4) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                if (f(t1, t2, t3, t4, out res1, out res2, out res3, out res4, out res5, out res6, out res7))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8>>>> ToOptFunc<T1, T2, T3, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8>(this TryFunc8<T1, T2, T3, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> f)
        {
            return (t1, t2, t3) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                if (f(t1, t2, t3, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8));
                return Option.None;
            };
        }
        public static Func<T1, T2, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9>>>> ToOptFunc<T1, T2, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9>(this TryFunc9<T1, T2, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> f)
        {
            return (t1, t2) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                if (f(t1, t2, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9));
                return Option.None;
            };
        }
        public static Func<T1, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9, TResult10>>>> ToOptFunc<T1, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10>(this TryFunc10<T1, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10> f)
        {
            return (t1) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                TResult10 res10;
                if (f(t1, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9, out res10))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9, res10));
                return Option.None;
            };
        }
        public static Func<Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9, TResult10, TResult11>>>> ToOptFunc<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11>(this TryFunc11<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11> f)
        {
            return () =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                TResult10 res10;
                TResult11 res11;
                if (f(out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9, out res10, out res11))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9, res10, res11));
                return Option.None;
            };
        }
    }

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult1>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, out TResult1 result1);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult1, TResult2>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, out TResult1 result1, out TResult2 result2);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc3<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult1, TResult2, TResult3>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, out TResult1 result1, out TResult2 result2, out TResult3 result3);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc4<T1, T2, T3, T4, T5, T6, T7, T8, TResult1, TResult2, TResult3, TResult4>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc5<T1, T2, T3, T4, T5, T6, T7, TResult1, TResult2, TResult3, TResult4, TResult5>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc6<T1, T2, T3, T4, T5, T6, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc7<T1, T2, T3, T4, T5, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc8<T1, T2, T3, T4, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8>(T1 t1, T2 t2, T3 t3, T4 t4, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc9<T1, T2, T3, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9>(T1 t1, T2 t2, T3 t3, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc10<T1, T2, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10>(T1 t1, T2 t2, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9, out TResult10 result10);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc11<T1, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11>(T1 t1, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9, out TResult10 result10, out TResult11 result11);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc12<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12>(out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9, out TResult10 result10, out TResult11 result11, out TResult12 result12);

    partial class TryFunc
    {
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Option<TResult1>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult1>(this TryFunc1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult1> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) =>
            {
                TResult1 res1;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, out res1))
                    return Create.Option(res1);
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Option<Tuple<TResult1, TResult2>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult1, TResult2>(this TryFunc2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult1, TResult2> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) =>
            {
                TResult1 res1;
                TResult2 res2;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, out res1, out res2))
                    return Create.Option(Create.Tuple(res1, res2));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Option<Tuple<TResult1, TResult2, TResult3>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult1, TResult2, TResult3>(this TryFunc3<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult1, TResult2, TResult3> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, out res1, out res2, out res3))
                    return Create.Option(Create.Tuple(res1, res2, res3));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, Option<Tuple<TResult1, TResult2, TResult3, TResult4>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult1, TResult2, TResult3, TResult4>(this TryFunc4<T1, T2, T3, T4, T5, T6, T7, T8, TResult1, TResult2, TResult3, TResult4> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, out res1, out res2, out res3, out res4))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, TResult1, TResult2, TResult3, TResult4, TResult5>(this TryFunc5<T1, T2, T3, T4, T5, T6, T7, TResult1, TResult2, TResult3, TResult4, TResult5> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                if (f(t1, t2, t3, t4, t5, t6, t7, out res1, out res2, out res3, out res4, out res5))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>>> ToOptFunc<T1, T2, T3, T4, T5, T6, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>(this TryFunc6<T1, T2, T3, T4, T5, T6, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> f)
        {
            return (t1, t2, t3, t4, t5, t6) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                if (f(t1, t2, t3, t4, t5, t6, out res1, out res2, out res3, out res4, out res5, out res6))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>>> ToOptFunc<T1, T2, T3, T4, T5, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>(this TryFunc7<T1, T2, T3, T4, T5, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> f)
        {
            return (t1, t2, t3, t4, t5) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                if (f(t1, t2, t3, t4, t5, out res1, out res2, out res3, out res4, out res5, out res6, out res7))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8>>>> ToOptFunc<T1, T2, T3, T4, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8>(this TryFunc8<T1, T2, T3, T4, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> f)
        {
            return (t1, t2, t3, t4) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                if (f(t1, t2, t3, t4, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9>>>> ToOptFunc<T1, T2, T3, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9>(this TryFunc9<T1, T2, T3, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> f)
        {
            return (t1, t2, t3) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                if (f(t1, t2, t3, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9));
                return Option.None;
            };
        }
        public static Func<T1, T2, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9, TResult10>>>> ToOptFunc<T1, T2, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10>(this TryFunc10<T1, T2, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10> f)
        {
            return (t1, t2) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                TResult10 res10;
                if (f(t1, t2, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9, out res10))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9, res10));
                return Option.None;
            };
        }
        public static Func<T1, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9, TResult10, TResult11>>>> ToOptFunc<T1, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11>(this TryFunc11<T1, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11> f)
        {
            return (t1) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                TResult10 res10;
                TResult11 res11;
                if (f(t1, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9, out res10, out res11))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9, res10, res11));
                return Option.None;
            };
        }
        public static Func<Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9, TResult10, TResult11, TResult12>>>> ToOptFunc<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12>(this TryFunc12<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12> f)
        {
            return () =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                TResult10 res10;
                TResult11 res11;
                TResult12 res12;
                if (f(out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9, out res10, out res11, out res12))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9, res10, res11, res12));
                return Option.None;
            };
        }
    }

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult1>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, out TResult1 result1);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult1, TResult2>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, out TResult1 result1, out TResult2 result2);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult1, TResult2, TResult3>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, out TResult1 result1, out TResult2 result2, out TResult3 result3);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc4<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult1, TResult2, TResult3, TResult4>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc5<T1, T2, T3, T4, T5, T6, T7, T8, TResult1, TResult2, TResult3, TResult4, TResult5>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc6<T1, T2, T3, T4, T5, T6, T7, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc7<T1, T2, T3, T4, T5, T6, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc8<T1, T2, T3, T4, T5, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc9<T1, T2, T3, T4, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9>(T1 t1, T2 t2, T3 t3, T4 t4, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc10<T1, T2, T3, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10>(T1 t1, T2 t2, T3 t3, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9, out TResult10 result10);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc11<T1, T2, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11>(T1 t1, T2 t2, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9, out TResult10 result10, out TResult11 result11);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc12<T1, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12>(T1 t1, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9, out TResult10 result10, out TResult11 result11, out TResult12 result12);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc13<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13>(out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9, out TResult10 result10, out TResult11 result11, out TResult12 result12, out TResult13 result13);

    partial class TryFunc
    {
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Option<TResult1>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult1>(this TryFunc1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult1> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) =>
            {
                TResult1 res1;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, out res1))
                    return Create.Option(res1);
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Option<Tuple<TResult1, TResult2>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult1, TResult2>(this TryFunc2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult1, TResult2> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) =>
            {
                TResult1 res1;
                TResult2 res2;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, out res1, out res2))
                    return Create.Option(Create.Tuple(res1, res2));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Option<Tuple<TResult1, TResult2, TResult3>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult1, TResult2, TResult3>(this TryFunc3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult1, TResult2, TResult3> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, out res1, out res2, out res3))
                    return Create.Option(Create.Tuple(res1, res2, res3));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Option<Tuple<TResult1, TResult2, TResult3, TResult4>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult1, TResult2, TResult3, TResult4>(this TryFunc4<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult1, TResult2, TResult3, TResult4> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, out res1, out res2, out res3, out res4))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult1, TResult2, TResult3, TResult4, TResult5>(this TryFunc5<T1, T2, T3, T4, T5, T6, T7, T8, TResult1, TResult2, TResult3, TResult4, TResult5> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, out res1, out res2, out res3, out res4, out res5))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>(this TryFunc6<T1, T2, T3, T4, T5, T6, T7, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                if (f(t1, t2, t3, t4, t5, t6, t7, out res1, out res2, out res3, out res4, out res5, out res6))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>>> ToOptFunc<T1, T2, T3, T4, T5, T6, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>(this TryFunc7<T1, T2, T3, T4, T5, T6, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> f)
        {
            return (t1, t2, t3, t4, t5, t6) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                if (f(t1, t2, t3, t4, t5, t6, out res1, out res2, out res3, out res4, out res5, out res6, out res7))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8>>>> ToOptFunc<T1, T2, T3, T4, T5, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8>(this TryFunc8<T1, T2, T3, T4, T5, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> f)
        {
            return (t1, t2, t3, t4, t5) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                if (f(t1, t2, t3, t4, t5, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9>>>> ToOptFunc<T1, T2, T3, T4, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9>(this TryFunc9<T1, T2, T3, T4, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> f)
        {
            return (t1, t2, t3, t4) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                if (f(t1, t2, t3, t4, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9, TResult10>>>> ToOptFunc<T1, T2, T3, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10>(this TryFunc10<T1, T2, T3, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10> f)
        {
            return (t1, t2, t3) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                TResult10 res10;
                if (f(t1, t2, t3, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9, out res10))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9, res10));
                return Option.None;
            };
        }
        public static Func<T1, T2, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9, TResult10, TResult11>>>> ToOptFunc<T1, T2, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11>(this TryFunc11<T1, T2, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11> f)
        {
            return (t1, t2) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                TResult10 res10;
                TResult11 res11;
                if (f(t1, t2, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9, out res10, out res11))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9, res10, res11));
                return Option.None;
            };
        }
        public static Func<T1, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9, TResult10, TResult11, TResult12>>>> ToOptFunc<T1, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12>(this TryFunc12<T1, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12> f)
        {
            return (t1) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                TResult10 res10;
                TResult11 res11;
                TResult12 res12;
                if (f(t1, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9, out res10, out res11, out res12))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9, res10, res11, res12));
                return Option.None;
            };
        }
        public static Func<Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9, TResult10, TResult11, TResult12, TResult13>>>> ToOptFunc<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13>(this TryFunc13<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13> f)
        {
            return () =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                TResult10 res10;
                TResult11 res11;
                TResult12 res12;
                TResult13 res13;
                if (f(out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9, out res10, out res11, out res12, out res13))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9, res10, res11, res12, res13));
                return Option.None;
            };
        }
    }

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult1>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, out TResult1 result1);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult1, TResult2>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, out TResult1 result1, out TResult2 result2);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult1, TResult2, TResult3>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, out TResult1 result1, out TResult2 result2, out TResult3 result3);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult1, TResult2, TResult3, TResult4>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc5<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult1, TResult2, TResult3, TResult4, TResult5>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc6<T1, T2, T3, T4, T5, T6, T7, T8, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc7<T1, T2, T3, T4, T5, T6, T7, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc8<T1, T2, T3, T4, T5, T6, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc9<T1, T2, T3, T4, T5, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc10<T1, T2, T3, T4, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10>(T1 t1, T2 t2, T3 t3, T4 t4, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9, out TResult10 result10);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc11<T1, T2, T3, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11>(T1 t1, T2 t2, T3 t3, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9, out TResult10 result10, out TResult11 result11);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc12<T1, T2, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12>(T1 t1, T2 t2, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9, out TResult10 result10, out TResult11 result11, out TResult12 result12);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc13<T1, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13>(T1 t1, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9, out TResult10 result10, out TResult11 result11, out TResult12 result12, out TResult13 result13);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc14<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14>(out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9, out TResult10 result10, out TResult11 result11, out TResult12 result12, out TResult13 result13, out TResult14 result14);

    partial class TryFunc
    {
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Option<TResult1>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult1>(this TryFunc1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult1> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) =>
            {
                TResult1 res1;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, out res1))
                    return Create.Option(res1);
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Option<Tuple<TResult1, TResult2>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult1, TResult2>(this TryFunc2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult1, TResult2> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) =>
            {
                TResult1 res1;
                TResult2 res2;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, out res1, out res2))
                    return Create.Option(Create.Tuple(res1, res2));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Option<Tuple<TResult1, TResult2, TResult3>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult1, TResult2, TResult3>(this TryFunc3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult1, TResult2, TResult3> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, out res1, out res2, out res3))
                    return Create.Option(Create.Tuple(res1, res2, res3));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Option<Tuple<TResult1, TResult2, TResult3, TResult4>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult1, TResult2, TResult3, TResult4>(this TryFunc4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult1, TResult2, TResult3, TResult4> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, out res1, out res2, out res3, out res4))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult1, TResult2, TResult3, TResult4, TResult5>(this TryFunc5<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult1, TResult2, TResult3, TResult4, TResult5> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, out res1, out res2, out res3, out res4, out res5))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>(this TryFunc6<T1, T2, T3, T4, T5, T6, T7, T8, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, out res1, out res2, out res3, out res4, out res5, out res6))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>(this TryFunc7<T1, T2, T3, T4, T5, T6, T7, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                if (f(t1, t2, t3, t4, t5, t6, t7, out res1, out res2, out res3, out res4, out res5, out res6, out res7))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8>>>> ToOptFunc<T1, T2, T3, T4, T5, T6, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8>(this TryFunc8<T1, T2, T3, T4, T5, T6, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> f)
        {
            return (t1, t2, t3, t4, t5, t6) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                if (f(t1, t2, t3, t4, t5, t6, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9>>>> ToOptFunc<T1, T2, T3, T4, T5, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9>(this TryFunc9<T1, T2, T3, T4, T5, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> f)
        {
            return (t1, t2, t3, t4, t5) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                if (f(t1, t2, t3, t4, t5, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9, TResult10>>>> ToOptFunc<T1, T2, T3, T4, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10>(this TryFunc10<T1, T2, T3, T4, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10> f)
        {
            return (t1, t2, t3, t4) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                TResult10 res10;
                if (f(t1, t2, t3, t4, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9, out res10))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9, res10));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9, TResult10, TResult11>>>> ToOptFunc<T1, T2, T3, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11>(this TryFunc11<T1, T2, T3, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11> f)
        {
            return (t1, t2, t3) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                TResult10 res10;
                TResult11 res11;
                if (f(t1, t2, t3, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9, out res10, out res11))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9, res10, res11));
                return Option.None;
            };
        }
        public static Func<T1, T2, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9, TResult10, TResult11, TResult12>>>> ToOptFunc<T1, T2, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12>(this TryFunc12<T1, T2, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12> f)
        {
            return (t1, t2) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                TResult10 res10;
                TResult11 res11;
                TResult12 res12;
                if (f(t1, t2, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9, out res10, out res11, out res12))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9, res10, res11, res12));
                return Option.None;
            };
        }
        public static Func<T1, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9, TResult10, TResult11, TResult12, TResult13>>>> ToOptFunc<T1, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13>(this TryFunc13<T1, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13> f)
        {
            return (t1) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                TResult10 res10;
                TResult11 res11;
                TResult12 res12;
                TResult13 res13;
                if (f(t1, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9, out res10, out res11, out res12, out res13))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9, res10, res11, res12, res13));
                return Option.None;
            };
        }
        public static Func<Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14>>>> ToOptFunc<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14>(this TryFunc14<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14> f)
        {
            return () =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                TResult10 res10;
                TResult11 res11;
                TResult12 res12;
                TResult13 res13;
                TResult14 res14;
                if (f(out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9, out res10, out res11, out res12, out res13, out res14))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9, res10, res11, res12, res13, res14));
                return Option.None;
            };
        }
    }

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult1>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, out TResult1 result1);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult1, TResult2>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, out TResult1 result1, out TResult2 result2);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult1, TResult2, TResult3>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, out TResult1 result1, out TResult2 result2, out TResult3 result3);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult1, TResult2, TResult3, TResult4>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult1, TResult2, TResult3, TResult4, TResult5>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc6<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc7<T1, T2, T3, T4, T5, T6, T7, T8, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc8<T1, T2, T3, T4, T5, T6, T7, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc9<T1, T2, T3, T4, T5, T6, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc10<T1, T2, T3, T4, T5, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9, out TResult10 result10);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc11<T1, T2, T3, T4, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11>(T1 t1, T2 t2, T3 t3, T4 t4, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9, out TResult10 result10, out TResult11 result11);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc12<T1, T2, T3, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12>(T1 t1, T2 t2, T3 t3, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9, out TResult10 result10, out TResult11 result11, out TResult12 result12);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc13<T1, T2, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13>(T1 t1, T2 t2, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9, out TResult10 result10, out TResult11 result11, out TResult12 result12, out TResult13 result13);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc14<T1, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14>(T1 t1, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9, out TResult10 result10, out TResult11 result11, out TResult12 result12, out TResult13 result13, out TResult14 result14);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc15<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15>(out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9, out TResult10 result10, out TResult11 result11, out TResult12 result12, out TResult13 result13, out TResult14 result14, out TResult15 result15);

    partial class TryFunc
    {
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Option<TResult1>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult1>(this TryFunc1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult1> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) =>
            {
                TResult1 res1;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, out res1))
                    return Create.Option(res1);
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Option<Tuple<TResult1, TResult2>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult1, TResult2>(this TryFunc2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult1, TResult2> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) =>
            {
                TResult1 res1;
                TResult2 res2;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, out res1, out res2))
                    return Create.Option(Create.Tuple(res1, res2));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Option<Tuple<TResult1, TResult2, TResult3>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult1, TResult2, TResult3>(this TryFunc3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult1, TResult2, TResult3> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, out res1, out res2, out res3))
                    return Create.Option(Create.Tuple(res1, res2, res3));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Option<Tuple<TResult1, TResult2, TResult3, TResult4>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult1, TResult2, TResult3, TResult4>(this TryFunc4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult1, TResult2, TResult3, TResult4> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, out res1, out res2, out res3, out res4))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult1, TResult2, TResult3, TResult4, TResult5>(this TryFunc5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult1, TResult2, TResult3, TResult4, TResult5> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, out res1, out res2, out res3, out res4, out res5))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>(this TryFunc6<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, out res1, out res2, out res3, out res4, out res5, out res6))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>(this TryFunc7<T1, T2, T3, T4, T5, T6, T7, T8, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, out res1, out res2, out res3, out res4, out res5, out res6, out res7))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8>>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8>(this TryFunc8<T1, T2, T3, T4, T5, T6, T7, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                if (f(t1, t2, t3, t4, t5, t6, t7, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9>>>> ToOptFunc<T1, T2, T3, T4, T5, T6, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9>(this TryFunc9<T1, T2, T3, T4, T5, T6, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> f)
        {
            return (t1, t2, t3, t4, t5, t6) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                if (f(t1, t2, t3, t4, t5, t6, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9, TResult10>>>> ToOptFunc<T1, T2, T3, T4, T5, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10>(this TryFunc10<T1, T2, T3, T4, T5, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10> f)
        {
            return (t1, t2, t3, t4, t5) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                TResult10 res10;
                if (f(t1, t2, t3, t4, t5, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9, out res10))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9, res10));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9, TResult10, TResult11>>>> ToOptFunc<T1, T2, T3, T4, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11>(this TryFunc11<T1, T2, T3, T4, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11> f)
        {
            return (t1, t2, t3, t4) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                TResult10 res10;
                TResult11 res11;
                if (f(t1, t2, t3, t4, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9, out res10, out res11))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9, res10, res11));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9, TResult10, TResult11, TResult12>>>> ToOptFunc<T1, T2, T3, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12>(this TryFunc12<T1, T2, T3, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12> f)
        {
            return (t1, t2, t3) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                TResult10 res10;
                TResult11 res11;
                TResult12 res12;
                if (f(t1, t2, t3, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9, out res10, out res11, out res12))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9, res10, res11, res12));
                return Option.None;
            };
        }
        public static Func<T1, T2, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9, TResult10, TResult11, TResult12, TResult13>>>> ToOptFunc<T1, T2, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13>(this TryFunc13<T1, T2, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13> f)
        {
            return (t1, t2) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                TResult10 res10;
                TResult11 res11;
                TResult12 res12;
                TResult13 res13;
                if (f(t1, t2, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9, out res10, out res11, out res12, out res13))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9, res10, res11, res12, res13));
                return Option.None;
            };
        }
        public static Func<T1, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14>>>> ToOptFunc<T1, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14>(this TryFunc14<T1, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14> f)
        {
            return (t1) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                TResult10 res10;
                TResult11 res11;
                TResult12 res12;
                TResult13 res13;
                TResult14 res14;
                if (f(t1, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9, out res10, out res11, out res12, out res13, out res14))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9, res10, res11, res12, res13, res14));
                return Option.None;
            };
        }
        public static Func<Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, Tuple<TResult15>>>>> ToOptFunc<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15>(this TryFunc15<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15> f)
        {
            return () =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                TResult10 res10;
                TResult11 res11;
                TResult12 res12;
                TResult13 res13;
                TResult14 res14;
                TResult15 res15;
                if (f(out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9, out res10, out res11, out res12, out res13, out res14, out res15))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9, res10, res11, res12, res13, res14, res15));
                return Option.None;
            };
        }
    }

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult1>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, out TResult1 result1);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult1, TResult2>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, out TResult1 result1, out TResult2 result2);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult1, TResult2, TResult3>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, out TResult1 result1, out TResult2 result2, out TResult3 result3);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult1, TResult2, TResult3, TResult4>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult1, TResult2, TResult3, TResult4, TResult5>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc6<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc7<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc8<T1, T2, T3, T4, T5, T6, T7, T8, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc9<T1, T2, T3, T4, T5, T6, T7, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc10<T1, T2, T3, T4, T5, T6, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9, out TResult10 result10);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc11<T1, T2, T3, T4, T5, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9, out TResult10 result10, out TResult11 result11);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc12<T1, T2, T3, T4, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12>(T1 t1, T2 t2, T3 t3, T4 t4, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9, out TResult10 result10, out TResult11 result11, out TResult12 result12);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc13<T1, T2, T3, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13>(T1 t1, T2 t2, T3 t3, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9, out TResult10 result10, out TResult11 result11, out TResult12 result12, out TResult13 result13);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc14<T1, T2, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14>(T1 t1, T2 t2, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9, out TResult10 result10, out TResult11 result11, out TResult12 result12, out TResult13 result13, out TResult14 result14);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc15<T1, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15>(T1 t1, out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9, out TResult10 result10, out TResult11 result11, out TResult12 result12, out TResult13 result13, out TResult14 result14, out TResult15 result15);

    /// <summary>
    /// 出力引数を伴う関数を表すデリゲートです。
    /// </summary>
    public delegate bool TryFunc16<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16>(out TResult1 result1, out TResult2 result2, out TResult3 result3, out TResult4 result4, out TResult5 result5, out TResult6 result6, out TResult7 result7, out TResult8 result8, out TResult9 result9, out TResult10 result10, out TResult11 result11, out TResult12 result12, out TResult13 result13, out TResult14 result14, out TResult15 result15, out TResult16 result16);

    partial class TryFunc
    {
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Option<TResult1>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult1>(this TryFunc1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult1> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) =>
            {
                TResult1 res1;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, out res1))
                    return Create.Option(res1);
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Option<Tuple<TResult1, TResult2>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult1, TResult2>(this TryFunc2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult1, TResult2> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) =>
            {
                TResult1 res1;
                TResult2 res2;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, out res1, out res2))
                    return Create.Option(Create.Tuple(res1, res2));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Option<Tuple<TResult1, TResult2, TResult3>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult1, TResult2, TResult3>(this TryFunc3<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult1, TResult2, TResult3> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, out res1, out res2, out res3))
                    return Create.Option(Create.Tuple(res1, res2, res3));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Option<Tuple<TResult1, TResult2, TResult3, TResult4>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult1, TResult2, TResult3, TResult4>(this TryFunc4<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult1, TResult2, TResult3, TResult4> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, out res1, out res2, out res3, out res4))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult1, TResult2, TResult3, TResult4, TResult5>(this TryFunc5<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult1, TResult2, TResult3, TResult4, TResult5> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, out res1, out res2, out res3, out res4, out res5))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6>(this TryFunc6<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, out res1, out res2, out res3, out res4, out res5, out res6))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7>(this TryFunc7<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, t9, out res1, out res2, out res3, out res4, out res5, out res6, out res7))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8>>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8>(this TryFunc8<T1, T2, T3, T4, T5, T6, T7, T8, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                if (f(t1, t2, t3, t4, t5, t6, t7, t8, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, T7, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9>>>> ToOptFunc<T1, T2, T3, T4, T5, T6, T7, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9>(this TryFunc9<T1, T2, T3, T4, T5, T6, T7, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9> f)
        {
            return (t1, t2, t3, t4, t5, t6, t7) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                if (f(t1, t2, t3, t4, t5, t6, t7, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, T6, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9, TResult10>>>> ToOptFunc<T1, T2, T3, T4, T5, T6, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10>(this TryFunc10<T1, T2, T3, T4, T5, T6, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10> f)
        {
            return (t1, t2, t3, t4, t5, t6) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                TResult10 res10;
                if (f(t1, t2, t3, t4, t5, t6, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9, out res10))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9, res10));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, T5, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9, TResult10, TResult11>>>> ToOptFunc<T1, T2, T3, T4, T5, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11>(this TryFunc11<T1, T2, T3, T4, T5, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11> f)
        {
            return (t1, t2, t3, t4, t5) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                TResult10 res10;
                TResult11 res11;
                if (f(t1, t2, t3, t4, t5, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9, out res10, out res11))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9, res10, res11));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, T4, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9, TResult10, TResult11, TResult12>>>> ToOptFunc<T1, T2, T3, T4, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12>(this TryFunc12<T1, T2, T3, T4, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12> f)
        {
            return (t1, t2, t3, t4) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                TResult10 res10;
                TResult11 res11;
                TResult12 res12;
                if (f(t1, t2, t3, t4, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9, out res10, out res11, out res12))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9, res10, res11, res12));
                return Option.None;
            };
        }
        public static Func<T1, T2, T3, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9, TResult10, TResult11, TResult12, TResult13>>>> ToOptFunc<T1, T2, T3, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13>(this TryFunc13<T1, T2, T3, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13> f)
        {
            return (t1, t2, t3) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                TResult10 res10;
                TResult11 res11;
                TResult12 res12;
                TResult13 res13;
                if (f(t1, t2, t3, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9, out res10, out res11, out res12, out res13))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9, res10, res11, res12, res13));
                return Option.None;
            };
        }
        public static Func<T1, T2, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14>>>> ToOptFunc<T1, T2, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14>(this TryFunc14<T1, T2, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14> f)
        {
            return (t1, t2) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                TResult10 res10;
                TResult11 res11;
                TResult12 res12;
                TResult13 res13;
                TResult14 res14;
                if (f(t1, t2, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9, out res10, out res11, out res12, out res13, out res14))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9, res10, res11, res12, res13, res14));
                return Option.None;
            };
        }
        public static Func<T1, Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, Tuple<TResult15>>>>> ToOptFunc<T1, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15>(this TryFunc15<T1, TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15> f)
        {
            return (t1) =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                TResult10 res10;
                TResult11 res11;
                TResult12 res12;
                TResult13 res13;
                TResult14 res14;
                TResult15 res15;
                if (f(t1, out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9, out res10, out res11, out res12, out res13, out res14, out res15))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9, res10, res11, res12, res13, res14, res15));
                return Option.None;
            };
        }
        public static Func<Option<Tuple<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, Tuple<TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, Tuple<TResult15, TResult16>>>>> ToOptFunc<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16>(this TryFunc16<TResult1, TResult2, TResult3, TResult4, TResult5, TResult6, TResult7, TResult8, TResult9, TResult10, TResult11, TResult12, TResult13, TResult14, TResult15, TResult16> f)
        {
            return () =>
            {
                TResult1 res1;
                TResult2 res2;
                TResult3 res3;
                TResult4 res4;
                TResult5 res5;
                TResult6 res6;
                TResult7 res7;
                TResult8 res8;
                TResult9 res9;
                TResult10 res10;
                TResult11 res11;
                TResult12 res12;
                TResult13 res13;
                TResult14 res14;
                TResult15 res15;
                TResult16 res16;
                if (f(out res1, out res2, out res3, out res4, out res5, out res6, out res7, out res8, out res9, out res10, out res11, out res12, out res13, out res14, out res15, out res16))
                    return Create.Option(Create.Tuple(res1, res2, res3, res4, res5, res6, res7, res8, res9, res10, res11, res12, res13, res14, res15, res16));
                return Option.None;
            };
        }
    }

}
