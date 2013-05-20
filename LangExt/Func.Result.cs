
using System;

namespace LangExt
{
    /// <summary>
    /// 関数がnullを返したことを表す例外です。
    /// この例外は、Func.ToResultの結果としてのみ使用されます。
    /// </summary>
    public sealed class NullResultException : Exception
    {
        /// <summary>objがNullResultExceptionであればtrueを返します。</summary>
        public override bool Equals(object obj) { return obj is NullResultException; }
        /// <summary>このオブジェクトのハッシュコードを返します。</summary>
        public override int GetHashCode() { return 11; }
        /// <summary>このオブジェクトの文字列表現を返します。</summary>
        public override string ToString() { return "NullResultException"; }
    }

    partial class Func
    {
        /// <summary>関数の結果をResultで包む関数に変換します。</summary>
        public static Func<Result<T, Exception>> ExnToResultFunc<T>(this Func<T> self)
        {
            return () => { try { return Result.Success(self()); } catch (Exception e) { return Result.Failure(e); } };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullの場合、Failureになります。</summary>
        public static Func<Result<T, Unit>> NullToResultFunc<T>(this Func<T> self) where T : class { return () => Result.Create(self()); }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullの場合、Failureになります。</summary>
        public static Func<Result<T, Unit>> NullToResultFunc<T>(this Func<T?> self) where T : struct { return () => Result.Create(self()); }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullか例外の場合、Failureになります。nullの場合はNullResultExceptionがFailureの値として使用されます。</summary>
        public static Func<Result<T, Exception>> ToResultFunc<T>(this Func<T> self)
        {
            return () =>
            {
                try
                {
                    var res = self();
                    if (res == null)
                        return Result.Failure((Exception)new NullResultException());
                    return Result.Success(res);
                } catch (Exception e) { return Result.Failure(e); }
            };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullか例外の場合、Failureになります。nullの場合はNullResultExceptionがFailureの値として使用されます。</summary>
        public static Func<Result<T, Exception>> ToResultFunc<T>(this Func<T?> self)
            where T : struct
        {
            return () =>
            {
                try
                {
                    var res = self();
                    if (res == null)
                        return Result.Failure((Exception)new NullResultException());
                    return Result.Success(res.Value);
                } catch (Exception e) { return Result.Failure(e); }
            };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。</summary>
        public static Func<T1, Result<U, Exception>> ExnToResultFunc<T1, U>(this Func<T1, U> self)
        {
            return (t1) => { try { return Result.Success(self(t1)); } catch (Exception e) { return Result.Failure(e); } };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullの場合、Failureになります。</summary>
        public static Func<T1, Result<U, Unit>> NullToResultFunc<T1, U>(this Func<T1, U> self)
            where U : class
        {
            return (t1) => Result.Create(self(t1));
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullの場合、Failureになります。</summary>
        public static Func<T1, Result<U, Unit>> NullToResultFunc<T1, U>(this Func<T1, U?> self)
            where U : struct
        {
            return (t1) => Result.Create(self(t1));
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullか例外の場合、Failureになります。nullの場合はNullResultExceptionがFailureの値として使用されます。</summary>
        public static Func<T1, Result<U, Exception>> ToResultFunc<T1, U>(this Func<T1, U> self)
        {
            return (t1) =>
            {
                try
                {
                    var res = self(t1);
                    if (res == null)
                        return Result.Failure((Exception)new NullResultException());
                    return Result.Success(res);
                } catch (Exception e) { return Result.Failure(e); }
            };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullか例外の場合、Failureになります。nullの場合はNullResultExceptionがFailureの値として使用されます。</summary>
        public static Func<T1, Result<U, Exception>> ToResultFunc<T1, U>(this Func<T1, U?> self)
            where U : struct
        {
            return (t1) =>
            {
                try
                {
                    var res = self(t1);
                    if (res == null)
                        return Result.Failure((Exception)new NullResultException());
                    return Result.Success(res.Value);
                } catch (Exception e) { return Result.Failure(e); }
            };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。</summary>
        public static Func<T1, T2, Result<U, Exception>> ExnToResultFunc<T1, T2, U>(this Func<T1, T2, U> self)
        {
            return (t1, t2) => { try { return Result.Success(self(t1, t2)); } catch (Exception e) { return Result.Failure(e); } };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullの場合、Failureになります。</summary>
        public static Func<T1, T2, Result<U, Unit>> NullToResultFunc<T1, T2, U>(this Func<T1, T2, U> self)
            where U : class
        {
            return (t1, t2) => Result.Create(self(t1, t2));
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullの場合、Failureになります。</summary>
        public static Func<T1, T2, Result<U, Unit>> NullToResultFunc<T1, T2, U>(this Func<T1, T2, U?> self)
            where U : struct
        {
            return (t1, t2) => Result.Create(self(t1, t2));
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullか例外の場合、Failureになります。nullの場合はNullResultExceptionがFailureの値として使用されます。</summary>
        public static Func<T1, T2, Result<U, Exception>> ToResultFunc<T1, T2, U>(this Func<T1, T2, U> self)
        {
            return (t1, t2) =>
            {
                try
                {
                    var res = self(t1, t2);
                    if (res == null)
                        return Result.Failure((Exception)new NullResultException());
                    return Result.Success(res);
                } catch (Exception e) { return Result.Failure(e); }
            };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullか例外の場合、Failureになります。nullの場合はNullResultExceptionがFailureの値として使用されます。</summary>
        public static Func<T1, T2, Result<U, Exception>> ToResultFunc<T1, T2, U>(this Func<T1, T2, U?> self)
            where U : struct
        {
            return (t1, t2) =>
            {
                try
                {
                    var res = self(t1, t2);
                    if (res == null)
                        return Result.Failure((Exception)new NullResultException());
                    return Result.Success(res.Value);
                } catch (Exception e) { return Result.Failure(e); }
            };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。</summary>
        public static Func<T1, T2, T3, Result<U, Exception>> ExnToResultFunc<T1, T2, T3, U>(this Func<T1, T2, T3, U> self)
        {
            return (t1, t2, t3) => { try { return Result.Success(self(t1, t2, t3)); } catch (Exception e) { return Result.Failure(e); } };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullの場合、Failureになります。</summary>
        public static Func<T1, T2, T3, Result<U, Unit>> NullToResultFunc<T1, T2, T3, U>(this Func<T1, T2, T3, U> self)
            where U : class
        {
            return (t1, t2, t3) => Result.Create(self(t1, t2, t3));
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullの場合、Failureになります。</summary>
        public static Func<T1, T2, T3, Result<U, Unit>> NullToResultFunc<T1, T2, T3, U>(this Func<T1, T2, T3, U?> self)
            where U : struct
        {
            return (t1, t2, t3) => Result.Create(self(t1, t2, t3));
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullか例外の場合、Failureになります。nullの場合はNullResultExceptionがFailureの値として使用されます。</summary>
        public static Func<T1, T2, T3, Result<U, Exception>> ToResultFunc<T1, T2, T3, U>(this Func<T1, T2, T3, U> self)
        {
            return (t1, t2, t3) =>
            {
                try
                {
                    var res = self(t1, t2, t3);
                    if (res == null)
                        return Result.Failure((Exception)new NullResultException());
                    return Result.Success(res);
                } catch (Exception e) { return Result.Failure(e); }
            };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullか例外の場合、Failureになります。nullの場合はNullResultExceptionがFailureの値として使用されます。</summary>
        public static Func<T1, T2, T3, Result<U, Exception>> ToResultFunc<T1, T2, T3, U>(this Func<T1, T2, T3, U?> self)
            where U : struct
        {
            return (t1, t2, t3) =>
            {
                try
                {
                    var res = self(t1, t2, t3);
                    if (res == null)
                        return Result.Failure((Exception)new NullResultException());
                    return Result.Success(res.Value);
                } catch (Exception e) { return Result.Failure(e); }
            };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。</summary>
        public static Func<T1, T2, T3, T4, Result<U, Exception>> ExnToResultFunc<T1, T2, T3, T4, U>(this Func<T1, T2, T3, T4, U> self)
        {
            return (t1, t2, t3, t4) => { try { return Result.Success(self(t1, t2, t3, t4)); } catch (Exception e) { return Result.Failure(e); } };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullの場合、Failureになります。</summary>
        public static Func<T1, T2, T3, T4, Result<U, Unit>> NullToResultFunc<T1, T2, T3, T4, U>(this Func<T1, T2, T3, T4, U> self)
            where U : class
        {
            return (t1, t2, t3, t4) => Result.Create(self(t1, t2, t3, t4));
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullの場合、Failureになります。</summary>
        public static Func<T1, T2, T3, T4, Result<U, Unit>> NullToResultFunc<T1, T2, T3, T4, U>(this Func<T1, T2, T3, T4, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4) => Result.Create(self(t1, t2, t3, t4));
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullか例外の場合、Failureになります。nullの場合はNullResultExceptionがFailureの値として使用されます。</summary>
        public static Func<T1, T2, T3, T4, Result<U, Exception>> ToResultFunc<T1, T2, T3, T4, U>(this Func<T1, T2, T3, T4, U> self)
        {
            return (t1, t2, t3, t4) =>
            {
                try
                {
                    var res = self(t1, t2, t3, t4);
                    if (res == null)
                        return Result.Failure((Exception)new NullResultException());
                    return Result.Success(res);
                } catch (Exception e) { return Result.Failure(e); }
            };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullか例外の場合、Failureになります。nullの場合はNullResultExceptionがFailureの値として使用されます。</summary>
        public static Func<T1, T2, T3, T4, Result<U, Exception>> ToResultFunc<T1, T2, T3, T4, U>(this Func<T1, T2, T3, T4, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4) =>
            {
                try
                {
                    var res = self(t1, t2, t3, t4);
                    if (res == null)
                        return Result.Failure((Exception)new NullResultException());
                    return Result.Success(res.Value);
                } catch (Exception e) { return Result.Failure(e); }
            };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。</summary>
        public static Func<T1, T2, T3, T4, T5, Result<U, Exception>> ExnToResultFunc<T1, T2, T3, T4, T5, U>(this Func<T1, T2, T3, T4, T5, U> self)
        {
            return (t1, t2, t3, t4, t5) => { try { return Result.Success(self(t1, t2, t3, t4, t5)); } catch (Exception e) { return Result.Failure(e); } };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullの場合、Failureになります。</summary>
        public static Func<T1, T2, T3, T4, T5, Result<U, Unit>> NullToResultFunc<T1, T2, T3, T4, T5, U>(this Func<T1, T2, T3, T4, T5, U> self)
            where U : class
        {
            return (t1, t2, t3, t4, t5) => Result.Create(self(t1, t2, t3, t4, t5));
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullの場合、Failureになります。</summary>
        public static Func<T1, T2, T3, T4, T5, Result<U, Unit>> NullToResultFunc<T1, T2, T3, T4, T5, U>(this Func<T1, T2, T3, T4, T5, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5) => Result.Create(self(t1, t2, t3, t4, t5));
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullか例外の場合、Failureになります。nullの場合はNullResultExceptionがFailureの値として使用されます。</summary>
        public static Func<T1, T2, T3, T4, T5, Result<U, Exception>> ToResultFunc<T1, T2, T3, T4, T5, U>(this Func<T1, T2, T3, T4, T5, U> self)
        {
            return (t1, t2, t3, t4, t5) =>
            {
                try
                {
                    var res = self(t1, t2, t3, t4, t5);
                    if (res == null)
                        return Result.Failure((Exception)new NullResultException());
                    return Result.Success(res);
                } catch (Exception e) { return Result.Failure(e); }
            };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullか例外の場合、Failureになります。nullの場合はNullResultExceptionがFailureの値として使用されます。</summary>
        public static Func<T1, T2, T3, T4, T5, Result<U, Exception>> ToResultFunc<T1, T2, T3, T4, T5, U>(this Func<T1, T2, T3, T4, T5, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5) =>
            {
                try
                {
                    var res = self(t1, t2, t3, t4, t5);
                    if (res == null)
                        return Result.Failure((Exception)new NullResultException());
                    return Result.Success(res.Value);
                } catch (Exception e) { return Result.Failure(e); }
            };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, Result<U, Exception>> ExnToResultFunc<T1, T2, T3, T4, T5, T6, U>(this Func<T1, T2, T3, T4, T5, T6, U> self)
        {
            return (t1, t2, t3, t4, t5, t6) => { try { return Result.Success(self(t1, t2, t3, t4, t5, t6)); } catch (Exception e) { return Result.Failure(e); } };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullの場合、Failureになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, Result<U, Unit>> NullToResultFunc<T1, T2, T3, T4, T5, T6, U>(this Func<T1, T2, T3, T4, T5, T6, U> self)
            where U : class
        {
            return (t1, t2, t3, t4, t5, t6) => Result.Create(self(t1, t2, t3, t4, t5, t6));
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullの場合、Failureになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, Result<U, Unit>> NullToResultFunc<T1, T2, T3, T4, T5, T6, U>(this Func<T1, T2, T3, T4, T5, T6, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6) => Result.Create(self(t1, t2, t3, t4, t5, t6));
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullか例外の場合、Failureになります。nullの場合はNullResultExceptionがFailureの値として使用されます。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, Result<U, Exception>> ToResultFunc<T1, T2, T3, T4, T5, T6, U>(this Func<T1, T2, T3, T4, T5, T6, U> self)
        {
            return (t1, t2, t3, t4, t5, t6) =>
            {
                try
                {
                    var res = self(t1, t2, t3, t4, t5, t6);
                    if (res == null)
                        return Result.Failure((Exception)new NullResultException());
                    return Result.Success(res);
                } catch (Exception e) { return Result.Failure(e); }
            };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullか例外の場合、Failureになります。nullの場合はNullResultExceptionがFailureの値として使用されます。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, Result<U, Exception>> ToResultFunc<T1, T2, T3, T4, T5, T6, U>(this Func<T1, T2, T3, T4, T5, T6, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6) =>
            {
                try
                {
                    var res = self(t1, t2, t3, t4, t5, t6);
                    if (res == null)
                        return Result.Failure((Exception)new NullResultException());
                    return Result.Success(res.Value);
                } catch (Exception e) { return Result.Failure(e); }
            };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, Result<U, Exception>> ExnToResultFunc<T1, T2, T3, T4, T5, T6, T7, U>(this Func<T1, T2, T3, T4, T5, T6, T7, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7) => { try { return Result.Success(self(t1, t2, t3, t4, t5, t6, t7)); } catch (Exception e) { return Result.Failure(e); } };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullの場合、Failureになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, Result<U, Unit>> NullToResultFunc<T1, T2, T3, T4, T5, T6, T7, U>(this Func<T1, T2, T3, T4, T5, T6, T7, U> self)
            where U : class
        {
            return (t1, t2, t3, t4, t5, t6, t7) => Result.Create(self(t1, t2, t3, t4, t5, t6, t7));
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullの場合、Failureになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, Result<U, Unit>> NullToResultFunc<T1, T2, T3, T4, T5, T6, T7, U>(this Func<T1, T2, T3, T4, T5, T6, T7, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7) => Result.Create(self(t1, t2, t3, t4, t5, t6, t7));
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullか例外の場合、Failureになります。nullの場合はNullResultExceptionがFailureの値として使用されます。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, Result<U, Exception>> ToResultFunc<T1, T2, T3, T4, T5, T6, T7, U>(this Func<T1, T2, T3, T4, T5, T6, T7, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7) =>
            {
                try
                {
                    var res = self(t1, t2, t3, t4, t5, t6, t7);
                    if (res == null)
                        return Result.Failure((Exception)new NullResultException());
                    return Result.Success(res);
                } catch (Exception e) { return Result.Failure(e); }
            };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullか例外の場合、Failureになります。nullの場合はNullResultExceptionがFailureの値として使用されます。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, Result<U, Exception>> ToResultFunc<T1, T2, T3, T4, T5, T6, T7, U>(this Func<T1, T2, T3, T4, T5, T6, T7, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7) =>
            {
                try
                {
                    var res = self(t1, t2, t3, t4, t5, t6, t7);
                    if (res == null)
                        return Result.Failure((Exception)new NullResultException());
                    return Result.Success(res.Value);
                } catch (Exception e) { return Result.Failure(e); }
            };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, Result<U, Exception>> ExnToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8) => { try { return Result.Success(self(t1, t2, t3, t4, t5, t6, t7, t8)); } catch (Exception e) { return Result.Failure(e); } };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullの場合、Failureになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, Result<U, Unit>> NullToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, U> self)
            where U : class
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8) => Result.Create(self(t1, t2, t3, t4, t5, t6, t7, t8));
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullの場合、Failureになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, Result<U, Unit>> NullToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8) => Result.Create(self(t1, t2, t3, t4, t5, t6, t7, t8));
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullか例外の場合、Failureになります。nullの場合はNullResultExceptionがFailureの値として使用されます。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, Result<U, Exception>> ToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8) =>
            {
                try
                {
                    var res = self(t1, t2, t3, t4, t5, t6, t7, t8);
                    if (res == null)
                        return Result.Failure((Exception)new NullResultException());
                    return Result.Success(res);
                } catch (Exception e) { return Result.Failure(e); }
            };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullか例外の場合、Failureになります。nullの場合はNullResultExceptionがFailureの値として使用されます。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, Result<U, Exception>> ToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8) =>
            {
                try
                {
                    var res = self(t1, t2, t3, t4, t5, t6, t7, t8);
                    if (res == null)
                        return Result.Failure((Exception)new NullResultException());
                    return Result.Success(res.Value);
                } catch (Exception e) { return Result.Failure(e); }
            };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Result<U, Exception>> ExnToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9) => { try { return Result.Success(self(t1, t2, t3, t4, t5, t6, t7, t8, t9)); } catch (Exception e) { return Result.Failure(e); } };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullの場合、Failureになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Result<U, Unit>> NullToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> self)
            where U : class
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9) => Result.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9));
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullの場合、Failureになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Result<U, Unit>> NullToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9) => Result.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9));
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullか例外の場合、Failureになります。nullの場合はNullResultExceptionがFailureの値として使用されます。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Result<U, Exception>> ToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9) =>
            {
                try
                {
                    var res = self(t1, t2, t3, t4, t5, t6, t7, t8, t9);
                    if (res == null)
                        return Result.Failure((Exception)new NullResultException());
                    return Result.Success(res);
                } catch (Exception e) { return Result.Failure(e); }
            };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullか例外の場合、Failureになります。nullの場合はNullResultExceptionがFailureの値として使用されます。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Result<U, Exception>> ToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9) =>
            {
                try
                {
                    var res = self(t1, t2, t3, t4, t5, t6, t7, t8, t9);
                    if (res == null)
                        return Result.Failure((Exception)new NullResultException());
                    return Result.Success(res.Value);
                } catch (Exception e) { return Result.Failure(e); }
            };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Result<U, Exception>> ExnToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => { try { return Result.Success(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10)); } catch (Exception e) { return Result.Failure(e); } };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullの場合、Failureになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Result<U, Unit>> NullToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> self)
            where U : class
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => Result.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullの場合、Failureになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Result<U, Unit>> NullToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => Result.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullか例外の場合、Failureになります。nullの場合はNullResultExceptionがFailureの値として使用されます。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Result<U, Exception>> ToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) =>
            {
                try
                {
                    var res = self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
                    if (res == null)
                        return Result.Failure((Exception)new NullResultException());
                    return Result.Success(res);
                } catch (Exception e) { return Result.Failure(e); }
            };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullか例外の場合、Failureになります。nullの場合はNullResultExceptionがFailureの値として使用されます。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Result<U, Exception>> ToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) =>
            {
                try
                {
                    var res = self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
                    if (res == null)
                        return Result.Failure((Exception)new NullResultException());
                    return Result.Success(res.Value);
                } catch (Exception e) { return Result.Failure(e); }
            };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Result<U, Exception>> ExnToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => { try { return Result.Success(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11)); } catch (Exception e) { return Result.Failure(e); } };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullの場合、Failureになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Result<U, Unit>> NullToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> self)
            where U : class
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => Result.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullの場合、Failureになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Result<U, Unit>> NullToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => Result.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullか例外の場合、Failureになります。nullの場合はNullResultExceptionがFailureの値として使用されます。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Result<U, Exception>> ToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) =>
            {
                try
                {
                    var res = self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
                    if (res == null)
                        return Result.Failure((Exception)new NullResultException());
                    return Result.Success(res);
                } catch (Exception e) { return Result.Failure(e); }
            };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullか例外の場合、Failureになります。nullの場合はNullResultExceptionがFailureの値として使用されます。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Result<U, Exception>> ToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) =>
            {
                try
                {
                    var res = self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
                    if (res == null)
                        return Result.Failure((Exception)new NullResultException());
                    return Result.Success(res.Value);
                } catch (Exception e) { return Result.Failure(e); }
            };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Result<U, Exception>> ExnToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => { try { return Result.Success(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12)); } catch (Exception e) { return Result.Failure(e); } };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullの場合、Failureになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Result<U, Unit>> NullToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> self)
            where U : class
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => Result.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullの場合、Failureになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Result<U, Unit>> NullToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => Result.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullか例外の場合、Failureになります。nullの場合はNullResultExceptionがFailureの値として使用されます。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Result<U, Exception>> ToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) =>
            {
                try
                {
                    var res = self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
                    if (res == null)
                        return Result.Failure((Exception)new NullResultException());
                    return Result.Success(res);
                } catch (Exception e) { return Result.Failure(e); }
            };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullか例外の場合、Failureになります。nullの場合はNullResultExceptionがFailureの値として使用されます。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Result<U, Exception>> ToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) =>
            {
                try
                {
                    var res = self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
                    if (res == null)
                        return Result.Failure((Exception)new NullResultException());
                    return Result.Success(res.Value);
                } catch (Exception e) { return Result.Failure(e); }
            };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Result<U, Exception>> ExnToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => { try { return Result.Success(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13)); } catch (Exception e) { return Result.Failure(e); } };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullの場合、Failureになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Result<U, Unit>> NullToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> self)
            where U : class
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => Result.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullの場合、Failureになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Result<U, Unit>> NullToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => Result.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullか例外の場合、Failureになります。nullの場合はNullResultExceptionがFailureの値として使用されます。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Result<U, Exception>> ToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) =>
            {
                try
                {
                    var res = self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
                    if (res == null)
                        return Result.Failure((Exception)new NullResultException());
                    return Result.Success(res);
                } catch (Exception e) { return Result.Failure(e); }
            };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullか例外の場合、Failureになります。nullの場合はNullResultExceptionがFailureの値として使用されます。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Result<U, Exception>> ToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) =>
            {
                try
                {
                    var res = self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
                    if (res == null)
                        return Result.Failure((Exception)new NullResultException());
                    return Result.Success(res.Value);
                } catch (Exception e) { return Result.Failure(e); }
            };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Result<U, Exception>> ExnToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => { try { return Result.Success(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14)); } catch (Exception e) { return Result.Failure(e); } };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullの場合、Failureになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Result<U, Unit>> NullToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> self)
            where U : class
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => Result.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullの場合、Failureになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Result<U, Unit>> NullToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => Result.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullか例外の場合、Failureになります。nullの場合はNullResultExceptionがFailureの値として使用されます。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Result<U, Exception>> ToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) =>
            {
                try
                {
                    var res = self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
                    if (res == null)
                        return Result.Failure((Exception)new NullResultException());
                    return Result.Success(res);
                } catch (Exception e) { return Result.Failure(e); }
            };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullか例外の場合、Failureになります。nullの場合はNullResultExceptionがFailureの値として使用されます。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Result<U, Exception>> ToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) =>
            {
                try
                {
                    var res = self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
                    if (res == null)
                        return Result.Failure((Exception)new NullResultException());
                    return Result.Success(res.Value);
                } catch (Exception e) { return Result.Failure(e); }
            };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Result<U, Exception>> ExnToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => { try { return Result.Success(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15)); } catch (Exception e) { return Result.Failure(e); } };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullの場合、Failureになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Result<U, Unit>> NullToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> self)
            where U : class
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => Result.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullの場合、Failureになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Result<U, Unit>> NullToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => Result.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullか例外の場合、Failureになります。nullの場合はNullResultExceptionがFailureの値として使用されます。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Result<U, Exception>> ToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) =>
            {
                try
                {
                    var res = self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
                    if (res == null)
                        return Result.Failure((Exception)new NullResultException());
                    return Result.Success(res);
                } catch (Exception e) { return Result.Failure(e); }
            };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullか例外の場合、Failureになります。nullの場合はNullResultExceptionがFailureの値として使用されます。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Result<U, Exception>> ToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) =>
            {
                try
                {
                    var res = self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
                    if (res == null)
                        return Result.Failure((Exception)new NullResultException());
                    return Result.Success(res.Value);
                } catch (Exception e) { return Result.Failure(e); }
            };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Result<U, Exception>> ExnToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => { try { return Result.Success(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16)); } catch (Exception e) { return Result.Failure(e); } };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullの場合、Failureになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Result<U, Unit>> NullToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> self)
            where U : class
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => Result.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16));
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullの場合、Failureになります。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Result<U, Unit>> NullToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => Result.Create(self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16));
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullか例外の場合、Failureになります。nullの場合はNullResultExceptionがFailureの値として使用されます。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Result<U, Exception>> ToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> self)
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) =>
            {
                try
                {
                    var res = self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);
                    if (res == null)
                        return Result.Failure((Exception)new NullResultException());
                    return Result.Success(res);
                } catch (Exception e) { return Result.Failure(e); }
            };
        }

        /// <summary>関数の結果をResultで包む関数に変換します。関数の結果がnullか例外の場合、Failureになります。nullの場合はNullResultExceptionがFailureの値として使用されます。</summary>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Result<U, Exception>> ToResultFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U?> self)
            where U : struct
        {
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) =>
            {
                try
                {
                    var res = self(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);
                    if (res == null)
                        return Result.Failure((Exception)new NullResultException());
                    return Result.Success(res.Value);
                } catch (Exception e) { return Result.Failure(e); }
            };
        }

    }
}
