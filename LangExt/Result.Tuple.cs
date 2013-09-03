
using System;

namespace LangExt
{
    partial class Result
    {
        /// <summary>
        /// Result[Tuple[...], Placeholder]のSuccessを生成します。
        /// </summary>
        public static Result<Tuple<T1, T2>, Placeholder> Success<T1, T2>(T1 t1, T2 t2)
        {
            return Result.Success(LangExt.Create.Tuple(t1, t2));
        }
        /// <summary>
        /// Result[Tuple[...], Placeholder]のSuccessを生成します。
        /// </summary>
        public static Result<Tuple<T1, T2, T3>, Placeholder> Success<T1, T2, T3>(T1 t1, T2 t2, T3 t3)
        {
            return Result.Success(LangExt.Create.Tuple(t1, t2, t3));
        }
        /// <summary>
        /// Result[Tuple[...], Placeholder]のSuccessを生成します。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4>, Placeholder> Success<T1, T2, T3, T4>(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            return Result.Success(LangExt.Create.Tuple(t1, t2, t3, t4));
        }
        /// <summary>
        /// Result[Tuple[...], Placeholder]のSuccessを生成します。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5>, Placeholder> Success<T1, T2, T3, T4, T5>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            return Result.Success(LangExt.Create.Tuple(t1, t2, t3, t4, t5));
        }
        /// <summary>
        /// Result[Tuple[...], Placeholder]のSuccessを生成します。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5, T6>, Placeholder> Success<T1, T2, T3, T4, T5, T6>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
        {
            return Result.Success(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6));
        }
        /// <summary>
        /// Result[Tuple[...], Placeholder]のSuccessを生成します。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5, T6, T7>, Placeholder> Success<T1, T2, T3, T4, T5, T6, T7>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
        {
            return Result.Success(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7));
        }
        /// <summary>
        /// Result[Tuple[...], Placeholder]のSuccessを生成します。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>, Placeholder> Success<T1, T2, T3, T4, T5, T6, T7, T8>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
        {
            return Result.Success(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8));
        }
        /// <summary>
        /// Result[Tuple[...], Placeholder]のSuccessを生成します。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>, Placeholder> Success<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
        {
            return Result.Success(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9));
        }
        /// <summary>
        /// Result[Tuple[...], Placeholder]のSuccessを生成します。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>, Placeholder> Success<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
        {
            return Result.Success(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
        }
        /// <summary>
        /// Result[Tuple[...], Placeholder]のSuccessを生成します。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>, Placeholder> Success<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
        {
            return Result.Success(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
        }
        /// <summary>
        /// Result[Tuple[...], Placeholder]のSuccessを生成します。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>, Placeholder> Success<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
        {
            return Result.Success(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
        }
        /// <summary>
        /// Result[Tuple[...], Placeholder]のSuccessを生成します。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>, Placeholder> Success<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
        {
            return Result.Success(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
        }
        /// <summary>
        /// Result[Tuple[...], Placeholder]のSuccessを生成します。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>, Placeholder> Success<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
        {
            return Result.Success(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
        }
        /// <summary>
        /// Result[Tuple[...], Placeholder]のSuccessを生成します。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>, Placeholder> Success<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
        {
            return Result.Success(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
        }
        /// <summary>
        /// Result[Tuple[...], Placeholder]のSuccessを生成します。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>, Placeholder> Success<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16)
        {
            return Result.Success(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16));
        }
        /// <summary>
        /// Result[Placeholder, Tuple[...]]のFailureを生成します。
        /// </summary>
        public static Result<Placeholder, Tuple<T1, T2>> Failure<T1, T2>(T1 t1, T2 t2)
        {
            return Result.Failure(LangExt.Create.Tuple(t1, t2));
        }
        /// <summary>
        /// Result[Placeholder, Tuple[...]]のFailureを生成します。
        /// </summary>
        public static Result<Placeholder, Tuple<T1, T2, T3>> Failure<T1, T2, T3>(T1 t1, T2 t2, T3 t3)
        {
            return Result.Failure(LangExt.Create.Tuple(t1, t2, t3));
        }
        /// <summary>
        /// Result[Placeholder, Tuple[...]]のFailureを生成します。
        /// </summary>
        public static Result<Placeholder, Tuple<T1, T2, T3, T4>> Failure<T1, T2, T3, T4>(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            return Result.Failure(LangExt.Create.Tuple(t1, t2, t3, t4));
        }
        /// <summary>
        /// Result[Placeholder, Tuple[...]]のFailureを生成します。
        /// </summary>
        public static Result<Placeholder, Tuple<T1, T2, T3, T4, T5>> Failure<T1, T2, T3, T4, T5>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            return Result.Failure(LangExt.Create.Tuple(t1, t2, t3, t4, t5));
        }
        /// <summary>
        /// Result[Placeholder, Tuple[...]]のFailureを生成します。
        /// </summary>
        public static Result<Placeholder, Tuple<T1, T2, T3, T4, T5, T6>> Failure<T1, T2, T3, T4, T5, T6>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
        {
            return Result.Failure(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6));
        }
        /// <summary>
        /// Result[Placeholder, Tuple[...]]のFailureを生成します。
        /// </summary>
        public static Result<Placeholder, Tuple<T1, T2, T3, T4, T5, T6, T7>> Failure<T1, T2, T3, T4, T5, T6, T7>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
        {
            return Result.Failure(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7));
        }
        /// <summary>
        /// Result[Placeholder, Tuple[...]]のFailureを生成します。
        /// </summary>
        public static Result<Placeholder, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> Failure<T1, T2, T3, T4, T5, T6, T7, T8>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
        {
            return Result.Failure(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8));
        }
        /// <summary>
        /// Result[Placeholder, Tuple[...]]のFailureを生成します。
        /// </summary>
        public static Result<Placeholder, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> Failure<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
        {
            return Result.Failure(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9));
        }
        /// <summary>
        /// Result[Placeholder, Tuple[...]]のFailureを生成します。
        /// </summary>
        public static Result<Placeholder, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> Failure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
        {
            return Result.Failure(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
        }
        /// <summary>
        /// Result[Placeholder, Tuple[...]]のFailureを生成します。
        /// </summary>
        public static Result<Placeholder, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> Failure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
        {
            return Result.Failure(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
        }
        /// <summary>
        /// Result[Placeholder, Tuple[...]]のFailureを生成します。
        /// </summary>
        public static Result<Placeholder, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> Failure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
        {
            return Result.Failure(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
        }
        /// <summary>
        /// Result[Placeholder, Tuple[...]]のFailureを生成します。
        /// </summary>
        public static Result<Placeholder, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> Failure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
        {
            return Result.Failure(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
        }
        /// <summary>
        /// Result[Placeholder, Tuple[...]]のFailureを生成します。
        /// </summary>
        public static Result<Placeholder, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> Failure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
        {
            return Result.Failure(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
        }
        /// <summary>
        /// Result[Placeholder, Tuple[...]]のFailureを生成します。
        /// </summary>
        public static Result<Placeholder, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> Failure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
        {
            return Result.Failure(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
        }
        /// <summary>
        /// Result[Placeholder, Tuple[...]]のFailureを生成します。
        /// </summary>
        public static Result<Placeholder, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> Failure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16)
        {
            return Result.Failure(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16));
        }
    }
}