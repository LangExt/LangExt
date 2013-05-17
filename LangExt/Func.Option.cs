
using System;

namespace LangExt
{
    partial class Func
    {
        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果が例外の場合、Noneになります。</summary>
        public static Func<Option<T>> ExnToOptionFunc<T>(this Func<T> self)
        {
            return () => { try { return Option.Some(self()); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullの場合、Noneになります。</summary>
        public static Func<Option<T>> NullToOptionFunc<T>(this Func<T> self)
            where T : class
        {
            return () => Option.Create(self());
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullの場合、Noneになります。</summary>
        public static Func<Option<T>> NullToOptionFunc<T>(this Func<T?> self)
            where T : struct
        {
            return () => Option.Create(self());
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullか例外の場合、Noneになります。</summary>
        public static Func<Option<T>> ToOptionFunc<T>(this Func<T> self)
        {
            return () => { try { return Option.Create(self()); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullか例外の場合、Noneになります。</summary>
        public static Func<Option<T>> ToOptionFunc<T>(this Func<T?> self)
            where T : struct
        {
            return () => { try { return Option.Create(self()); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果が例外の場合、Noneになります。</summary>
        public static Func<T1, Option<U>> ExnToOptionFunc<T1, U>(this Func<T1, U> self)
        {
            return (t1) => { try { return Option.Some(self(t1)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullの場合、Noneになります。</summary>
        public static Func<T1, Option<U>> NullToOptionFunc<T1, U>(this Func<T1, U> self)
            where U : class
        {
            return (t1) => Option.Create(self(t1));
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullの場合、Noneになります。</summary>
        public static Func<T1, Option<U>> NullToOptionFunc<T1, U>(this Func<T1, U?> self)
            where U : struct
        {
            return (t1) => Option.Create(self(t1));
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullか例外の場合、Noneになります。</summary>
        public static Func<T1, Option<U>> ToOptionFunc<T1, U>(this Func<T1, U> self)
        {
            return (t1) => { try { return Option.Create(self(t1)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullか例外の場合、Noneになります。</summary>
        public static Func<T1, Option<U>> ToOptionFunc<T1, U>(this Func<T1, U?> self)
            where U : struct
        {
            return (t1) => { try { return Option.Create(self(t1)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果が例外の場合、Noneになります。</summary>
        public static Func<T1, T2, Option<U>> ExnToOptionFunc<T1, T2, U>(this Func<T1, T2, U> self)
        {
            return (t1, t2) => { try { return Option.Some(self(t1, t2)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullの場合、Noneになります。</summary>
        public static Func<T1, T2, Option<U>> NullToOptionFunc<T1, T2, U>(this Func<T1, T2, U> self)
            where U : class
        {
            return (t1, t2) => Option.Create(self(t1, t2));
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullの場合、Noneになります。</summary>
        public static Func<T1, T2, Option<U>> NullToOptionFunc<T1, T2, U>(this Func<T1, T2, U?> self)
            where U : struct
        {
            return (t1, t2) => Option.Create(self(t1, t2));
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullか例外の場合、Noneになります。</summary>
        public static Func<T1, T2, Option<U>> ToOptionFunc<T1, T2, U>(this Func<T1, T2, U> self)
        {
            return (t1, t2) => { try { return Option.Create(self(t1, t2)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullか例外の場合、Noneになります。</summary>
        public static Func<T1, T2, Option<U>> ToOptionFunc<T1, T2, U>(this Func<T1, T2, U?> self)
            where U : struct
        {
            return (t1, t2) => { try { return Option.Create(self(t1, t2)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果が例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, Option<U>> ExnToOptionFunc<T1, T2, T3, U>(this Func<T1, T2, T3, U> self)
        {
            return (t1, t2, t3) => { try { return Option.Some(self(t1, t2, t3)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullの場合、Noneになります。</summary>
        public static Func<T1, T2, T3, Option<U>> NullToOptionFunc<T1, T2, T3, U>(this Func<T1, T2, T3, U> self)
            where U : class
        {
            return (t1, t2, t3) => Option.Create(self(t1, t2, t3));
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullの場合、Noneになります。</summary>
        public static Func<T1, T2, T3, Option<U>> NullToOptionFunc<T1, T2, T3, U>(this Func<T1, T2, T3, U?> self)
            where U : struct
        {
            return (t1, t2, t3) => Option.Create(self(t1, t2, t3));
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullか例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, Option<U>> ToOptionFunc<T1, T2, T3, U>(this Func<T1, T2, T3, U> self)
        {
            return (t1, t2, t3) => { try { return Option.Create(self(t1, t2, t3)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullか例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, Option<U>> ToOptionFunc<T1, T2, T3, U>(this Func<T1, T2, T3, U?> self)
            where U : struct
        {
            return (t1, t2, t3) => { try { return Option.Create(self(t1, t2, t3)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果が例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, Option<U>> ExnToOptionFunc<T1, T2, T3, T4, U>(this Func<T1, T2, T3, T4, U> self)
        {
            return (t1, t2, t3, t4) => { try { return Option.Some(self(t1, t2, t3, t4)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullの場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, Option<U>> NullToOptionFunc<T1, T2, T3, T4, U>(this Func<T1, T2, T3, T4, U> self)
            where U : class
        {
            return (t1, t2, t3, t4) => Option.Create(self(t1, t2, t3, t4));
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullの場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, Option<U>> NullToOptionFunc<T1, T2, T3, T4, U>(this Func<T1, T2, T3, T4, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4) => Option.Create(self(t1, t2, t3, t4));
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullか例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, Option<U>> ToOptionFunc<T1, T2, T3, T4, U>(this Func<T1, T2, T3, T4, U> self)
        {
            return (t1, t2, t3, t4) => { try { return Option.Create(self(t1, t2, t3, t4)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullか例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, Option<U>> ToOptionFunc<T1, T2, T3, T4, U>(this Func<T1, T2, T3, T4, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4) => { try { return Option.Create(self(t1, t2, t3, t4)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果が例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, Option<U>> ExnToOptionFunc<T1, T2, T3, T4, T5, U>(this Func<T1, T2, T3, T4, T5, U> self)
        {
            return (t1, t2, t3, t4, t5) => { try { return Option.Some(self(t1, t2, t3, t4, t5)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullの場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, Option<U>> NullToOptionFunc<T1, T2, T3, T4, T5, U>(this Func<T1, T2, T3, T4, T5, U> self)
            where U : class
        {
            return (t1, t2, t3, t4, t5) => Option.Create(self(t1, t2, t3, t4, t5));
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullの場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, Option<U>> NullToOptionFunc<T1, T2, T3, T4, T5, U>(this Func<T1, T2, T3, T4, T5, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5) => Option.Create(self(t1, t2, t3, t4, t5));
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullか例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, Option<U>> ToOptionFunc<T1, T2, T3, T4, T5, U>(this Func<T1, T2, T3, T4, T5, U> self)
        {
            return (t1, t2, t3, t4, t5) => { try { return Option.Create(self(t1, t2, t3, t4, t5)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullか例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, Option<U>> ToOptionFunc<T1, T2, T3, T4, T5, U>(this Func<T1, T2, T3, T4, T5, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5) => { try { return Option.Create(self(t1, t2, t3, t4, t5)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果が例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, Option<U>> ExnToOptionFunc<T1, T2, T3, T4, T5, T6, U>(this Func<T1, T2, T3, T4, T5, T6, U> self)
        {
            return (t1, t2, t3, t4, t5, t6) => { try { return Option.Some(self(t1, t2, t3, t4, t5, t6)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullの場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, Option<U>> NullToOptionFunc<T1, T2, T3, T4, T5, T6, U>(this Func<T1, T2, T3, T4, T5, T6, U> self)
            where U : class
        {
            return (t1, t2, t3, t4, t5, t6) => Option.Create(self(t1, t2, t3, t4, t5, t6));
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullの場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, Option<U>> NullToOptionFunc<T1, T2, T3, T4, T5, T6, U>(this Func<T1, T2, T3, T4, T5, T6, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6) => Option.Create(self(t1, t2, t3, t4, t5, t6));
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullか例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, Option<U>> ToOptionFunc<T1, T2, T3, T4, T5, T6, U>(this Func<T1, T2, T3, T4, T5, T6, U> self)
        {
            return (t1, t2, t3, t4, t5, t6) => { try { return Option.Create(self(t1, t2, t3, t4, t5, t6)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullか例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, Option<U>> ToOptionFunc<T1, T2, T3, T4, T5, T6, U>(this Func<T1, T2, T3, T4, T5, T6, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6) => { try { return Option.Create(self(t1, t2, t3, t4, t5, t6)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果が例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, Option<U>> ExnToOptionFunc<T1, T2, T3, T4, T5, T6, T7, U>(this Func<T1, T2, T3, T4, T5, T6, T7, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7) => { try { return Option.Some(self(t1, t2, t3, t4, t5, t6, t7)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullの場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, Option<U>> NullToOptionFunc<T1, T2, T3, T4, T5, T6, T7, U>(this Func<T1, T2, T3, T4, T5, T6, T7, U> self)
            where U : class
        {
            return (t1, t2, t3, t4, t5, t6, t7) => Option.Create(self(t1, t2, t3, t4, t5, t6, t7));
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullの場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, Option<U>> NullToOptionFunc<T1, T2, T3, T4, T5, T6, T7, U>(this Func<T1, T2, T3, T4, T5, T6, T7, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7) => Option.Create(self(t1, t2, t3, t4, t5, t6, t7));
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullか例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, Option<U>> ToOptionFunc<T1, T2, T3, T4, T5, T6, T7, U>(this Func<T1, T2, T3, T4, T5, T6, T7, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7) => { try { return Option.Create(self(t1, t2, t3, t4, t5, t6, t7)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullか例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, Option<U>> ToOptionFunc<T1, T2, T3, T4, T5, T6, T7, U>(this Func<T1, T2, T3, T4, T5, T6, T7, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7) => { try { return Option.Create(self(t1, t2, t3, t4, t5, t6, t7)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果が例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, Option<U>> ExnToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8) => { try { return Option.Some(self(t1, t2, t3, t4, t5, t6, t7, t8)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullの場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, Option<U>> NullToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, U> self)
            where U : class
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8) => Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8));
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullの場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, Option<U>> NullToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8) => Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8));
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullか例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, Option<U>> ToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8) => { try { return Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullか例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, Option<U>> ToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8) => { try { return Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果が例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Option<U>> ExnToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9) => { try { return Option.Some(self(t1, t2, t3, t4, t5, t6, t7, t8, t9)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullの場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Option<U>> NullToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> self)
            where U : class
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9) => Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9));
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullの場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Option<U>> NullToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9) => Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9));
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullか例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Option<U>> ToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9) => { try { return Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullか例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Option<U>> ToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9) => { try { return Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果が例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Option<U>> ExnToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => { try { return Option.Some(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullの場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Option<U>> NullToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> self)
            where U : class
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullの場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Option<U>> NullToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullか例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Option<U>> ToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => { try { return Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullか例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Option<U>> ToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => { try { return Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果が例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Option<U>> ExnToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => { try { return Option.Some(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullの場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Option<U>> NullToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> self)
            where U : class
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullの場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Option<U>> NullToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullか例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Option<U>> ToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => { try { return Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullか例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Option<U>> ToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => { try { return Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果が例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Option<U>> ExnToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => { try { return Option.Some(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullの場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Option<U>> NullToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> self)
            where U : class
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullの場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Option<U>> NullToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullか例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Option<U>> ToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => { try { return Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullか例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Option<U>> ToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => { try { return Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果が例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Option<U>> ExnToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => { try { return Option.Some(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullの場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Option<U>> NullToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> self)
            where U : class
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullの場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Option<U>> NullToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullか例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Option<U>> ToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => { try { return Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullか例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Option<U>> ToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => { try { return Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果が例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Option<U>> ExnToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => { try { return Option.Some(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullの場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Option<U>> NullToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> self)
            where U : class
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullの場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Option<U>> NullToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullか例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Option<U>> ToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => { try { return Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullか例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Option<U>> ToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => { try { return Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果が例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Option<U>> ExnToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => { try { return Option.Some(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullの場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Option<U>> NullToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> self)
            where U : class
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullの場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Option<U>> NullToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullか例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Option<U>> ToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => { try { return Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullか例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Option<U>> ToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => { try { return Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果が例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Option<U>> ExnToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => { try { return Option.Some(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullの場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Option<U>> NullToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> self)
            where U : class
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16));
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullの場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Option<U>> NullToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16));
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullか例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Option<U>> ToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => { try { return Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16)); } catch { return Option.None; } };
        }

        /// <summary>関数の結果をOptionで包む関数に変換します。関数の結果がnullか例外の場合、Noneになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Option<U>> ToOptionFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => { try { return Option.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16)); } catch { return Option.None; } };
        }

    }
}
