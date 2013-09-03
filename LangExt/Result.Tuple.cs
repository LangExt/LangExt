
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
        /// <summary>
        /// Result[Tuple[...], TFailure]のSuccessを生成します。
        /// </summary>
        public static Result<Tuple<T1, T2>, TFailure> NewSuccess<T1, T2, TFailure>(T1 t1, T2 t2)
        {
            return Result.NewSuccess<Tuple<T1, T2>, TFailure>(LangExt.Create.Tuple(t1, t2));
        }
        /// <summary>
        /// Result[Tuple[...], TFailure]のSuccessを生成します。
        /// </summary>
        public static Result<Tuple<T1, T2, T3>, TFailure> NewSuccess<T1, T2, T3, TFailure>(T1 t1, T2 t2, T3 t3)
        {
            return Result.NewSuccess<Tuple<T1, T2, T3>, TFailure>(LangExt.Create.Tuple(t1, t2, t3));
        }
        /// <summary>
        /// Result[Tuple[...], TFailure]のSuccessを生成します。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4>, TFailure> NewSuccess<T1, T2, T3, T4, TFailure>(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            return Result.NewSuccess<Tuple<T1, T2, T3, T4>, TFailure>(LangExt.Create.Tuple(t1, t2, t3, t4));
        }
        /// <summary>
        /// Result[Tuple[...], TFailure]のSuccessを生成します。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5>, TFailure> NewSuccess<T1, T2, T3, T4, T5, TFailure>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            return Result.NewSuccess<Tuple<T1, T2, T3, T4, T5>, TFailure>(LangExt.Create.Tuple(t1, t2, t3, t4, t5));
        }
        /// <summary>
        /// Result[Tuple[...], TFailure]のSuccessを生成します。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5, T6>, TFailure> NewSuccess<T1, T2, T3, T4, T5, T6, TFailure>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
        {
            return Result.NewSuccess<Tuple<T1, T2, T3, T4, T5, T6>, TFailure>(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6));
        }
        /// <summary>
        /// Result[Tuple[...], TFailure]のSuccessを生成します。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5, T6, T7>, TFailure> NewSuccess<T1, T2, T3, T4, T5, T6, T7, TFailure>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
        {
            return Result.NewSuccess<Tuple<T1, T2, T3, T4, T5, T6, T7>, TFailure>(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7));
        }
        /// <summary>
        /// Result[Tuple[...], TFailure]のSuccessを生成します。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>, TFailure> NewSuccess<T1, T2, T3, T4, T5, T6, T7, T8, TFailure>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
        {
            return Result.NewSuccess<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>, TFailure>(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8));
        }
        /// <summary>
        /// Result[Tuple[...], TFailure]のSuccessを生成します。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>, TFailure> NewSuccess<T1, T2, T3, T4, T5, T6, T7, T8, T9, TFailure>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
        {
            return Result.NewSuccess<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>, TFailure>(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9));
        }
        /// <summary>
        /// Result[Tuple[...], TFailure]のSuccessを生成します。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>, TFailure> NewSuccess<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TFailure>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
        {
            return Result.NewSuccess<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>, TFailure>(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
        }
        /// <summary>
        /// Result[Tuple[...], TFailure]のSuccessを生成します。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>, TFailure> NewSuccess<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TFailure>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
        {
            return Result.NewSuccess<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>, TFailure>(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
        }
        /// <summary>
        /// Result[Tuple[...], TFailure]のSuccessを生成します。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>, TFailure> NewSuccess<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TFailure>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
        {
            return Result.NewSuccess<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>, TFailure>(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
        }
        /// <summary>
        /// Result[Tuple[...], TFailure]のSuccessを生成します。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>, TFailure> NewSuccess<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TFailure>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
        {
            return Result.NewSuccess<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>, TFailure>(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
        }
        /// <summary>
        /// Result[Tuple[...], TFailure]のSuccessを生成します。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>, TFailure> NewSuccess<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TFailure>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
        {
            return Result.NewSuccess<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>, TFailure>(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
        }
        /// <summary>
        /// Result[Tuple[...], TFailure]のSuccessを生成します。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>, TFailure> NewSuccess<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TFailure>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
        {
            return Result.NewSuccess<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>, TFailure>(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
        }
        /// <summary>
        /// Result[Tuple[...], TFailure]のSuccessを生成します。
        /// </summary>
        public static Result<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>, TFailure> NewSuccess<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TFailure>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16)
        {
            return Result.NewSuccess<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>, TFailure>(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16));
        }
        /// <summary>
        /// Result[TSuccess, Tuple[...]]のFailureを生成します。
        /// </summary>
        public static Result<TSuccess, Tuple<T1, T2>> NewSuccess<TSuccess, T1, T2, TFailure>(T1 t1, T2 t2)
        {
            return Result.NewFailure<TSuccess, Tuple<T1, T2>>(LangExt.Create.Tuple(t1, t2));
        }
        /// <summary>
        /// Result[TSuccess, Tuple[...]]のFailureを生成します。
        /// </summary>
        public static Result<TSuccess, Tuple<T1, T2, T3>> NewSuccess<TSuccess, T1, T2, T3, TFailure>(T1 t1, T2 t2, T3 t3)
        {
            return Result.NewFailure<TSuccess, Tuple<T1, T2, T3>>(LangExt.Create.Tuple(t1, t2, t3));
        }
        /// <summary>
        /// Result[TSuccess, Tuple[...]]のFailureを生成します。
        /// </summary>
        public static Result<TSuccess, Tuple<T1, T2, T3, T4>> NewSuccess<TSuccess, T1, T2, T3, T4, TFailure>(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            return Result.NewFailure<TSuccess, Tuple<T1, T2, T3, T4>>(LangExt.Create.Tuple(t1, t2, t3, t4));
        }
        /// <summary>
        /// Result[TSuccess, Tuple[...]]のFailureを生成します。
        /// </summary>
        public static Result<TSuccess, Tuple<T1, T2, T3, T4, T5>> NewSuccess<TSuccess, T1, T2, T3, T4, T5, TFailure>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            return Result.NewFailure<TSuccess, Tuple<T1, T2, T3, T4, T5>>(LangExt.Create.Tuple(t1, t2, t3, t4, t5));
        }
        /// <summary>
        /// Result[TSuccess, Tuple[...]]のFailureを生成します。
        /// </summary>
        public static Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6>> NewSuccess<TSuccess, T1, T2, T3, T4, T5, T6, TFailure>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
        {
            return Result.NewFailure<TSuccess, Tuple<T1, T2, T3, T4, T5, T6>>(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6));
        }
        /// <summary>
        /// Result[TSuccess, Tuple[...]]のFailureを生成します。
        /// </summary>
        public static Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7>> NewSuccess<TSuccess, T1, T2, T3, T4, T5, T6, T7, TFailure>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
        {
            return Result.NewFailure<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7>>(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7));
        }
        /// <summary>
        /// Result[TSuccess, Tuple[...]]のFailureを生成します。
        /// </summary>
        public static Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> NewSuccess<TSuccess, T1, T2, T3, T4, T5, T6, T7, T8, TFailure>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
        {
            return Result.NewFailure<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>>(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8));
        }
        /// <summary>
        /// Result[TSuccess, Tuple[...]]のFailureを生成します。
        /// </summary>
        public static Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> NewSuccess<TSuccess, T1, T2, T3, T4, T5, T6, T7, T8, T9, TFailure>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
        {
            return Result.NewFailure<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>>(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9));
        }
        /// <summary>
        /// Result[TSuccess, Tuple[...]]のFailureを生成します。
        /// </summary>
        public static Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> NewSuccess<TSuccess, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TFailure>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
        {
            return Result.NewFailure<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>>(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
        }
        /// <summary>
        /// Result[TSuccess, Tuple[...]]のFailureを生成します。
        /// </summary>
        public static Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> NewSuccess<TSuccess, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TFailure>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
        {
            return Result.NewFailure<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>>(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
        }
        /// <summary>
        /// Result[TSuccess, Tuple[...]]のFailureを生成します。
        /// </summary>
        public static Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> NewSuccess<TSuccess, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TFailure>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
        {
            return Result.NewFailure<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>>(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
        }
        /// <summary>
        /// Result[TSuccess, Tuple[...]]のFailureを生成します。
        /// </summary>
        public static Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> NewSuccess<TSuccess, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TFailure>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
        {
            return Result.NewFailure<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>>(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
        }
        /// <summary>
        /// Result[TSuccess, Tuple[...]]のFailureを生成します。
        /// </summary>
        public static Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> NewSuccess<TSuccess, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TFailure>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
        {
            return Result.NewFailure<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>>(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
        }
        /// <summary>
        /// Result[TSuccess, Tuple[...]]のFailureを生成します。
        /// </summary>
        public static Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> NewSuccess<TSuccess, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TFailure>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
        {
            return Result.NewFailure<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>>(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
        }
        /// <summary>
        /// Result[TSuccess, Tuple[...]]のFailureを生成します。
        /// </summary>
        public static Result<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> NewSuccess<TSuccess, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TFailure>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16)
        {
            return Result.NewFailure<TSuccess, Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>>(LangExt.Create.Tuple(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16));
        }
    }
}