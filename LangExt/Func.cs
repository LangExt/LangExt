
namespace LangExt
{
    /// <summary>
    /// 5 個のパラメーターを受け取って TResult パラメーターに指定された型の値を返すメソッドをカプセル化します。
    /// </summary>
    /// <typeparam name="T1">このデリゲートによってカプセル化されるメソッドの第 1 パラメーターの型。</typeparam>
    /// <typeparam name="T2">このデリゲートによってカプセル化されるメソッドの第 2 パラメーターの型。</typeparam>
    /// <typeparam name="T3">このデリゲートによってカプセル化されるメソッドの第 3 パラメーターの型。</typeparam>
    /// <typeparam name="T4">このデリゲートによってカプセル化されるメソッドの第 4 パラメーターの型。</typeparam>
    /// <typeparam name="T5">このデリゲートによってカプセル化されるメソッドの第 5 パラメーターの型。</typeparam>
    /// <typeparam name="TResult">このデリゲートによってカプセル化されるメソッドの戻り値の型。</typeparam>
    /// <param name="arg1">このデリゲートによってカプセル化されるメソッドの第 1 パラメーター。</param>
    /// <param name="arg2">このデリゲートによってカプセル化されるメソッドの第 2 パラメーター。</param>
    /// <param name="arg3">このデリゲートによってカプセル化されるメソッドの第 3 パラメーター。</param>
    /// <param name="arg4">このデリゲートによってカプセル化されるメソッドの第 4 パラメーター。</param>
    /// <param name="arg5">このデリゲートによってカプセル化されるメソッドの第 5 パラメーター。</param>
    /// <returns>このデリゲートによってカプセル化されるメソッドの戻り値。</returns>
    public delegate TResult Func<T1, T2, T3, T4, T5,  TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);

    /// <summary>
    /// 6 個のパラメーターを受け取って TResult パラメーターに指定された型の値を返すメソッドをカプセル化します。
    /// </summary>
    /// <typeparam name="T1">このデリゲートによってカプセル化されるメソッドの第 1 パラメーターの型。</typeparam>
    /// <typeparam name="T2">このデリゲートによってカプセル化されるメソッドの第 2 パラメーターの型。</typeparam>
    /// <typeparam name="T3">このデリゲートによってカプセル化されるメソッドの第 3 パラメーターの型。</typeparam>
    /// <typeparam name="T4">このデリゲートによってカプセル化されるメソッドの第 4 パラメーターの型。</typeparam>
    /// <typeparam name="T5">このデリゲートによってカプセル化されるメソッドの第 5 パラメーターの型。</typeparam>
    /// <typeparam name="T6">このデリゲートによってカプセル化されるメソッドの第 6 パラメーターの型。</typeparam>
    /// <typeparam name="TResult">このデリゲートによってカプセル化されるメソッドの戻り値の型。</typeparam>
    /// <param name="arg1">このデリゲートによってカプセル化されるメソッドの第 1 パラメーター。</param>
    /// <param name="arg2">このデリゲートによってカプセル化されるメソッドの第 2 パラメーター。</param>
    /// <param name="arg3">このデリゲートによってカプセル化されるメソッドの第 3 パラメーター。</param>
    /// <param name="arg4">このデリゲートによってカプセル化されるメソッドの第 4 パラメーター。</param>
    /// <param name="arg5">このデリゲートによってカプセル化されるメソッドの第 5 パラメーター。</param>
    /// <param name="arg6">このデリゲートによってカプセル化されるメソッドの第 6 パラメーター。</param>
    /// <returns>このデリゲートによってカプセル化されるメソッドの戻り値。</returns>
    public delegate TResult Func<T1, T2, T3, T4, T5, T6,  TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);

    /// <summary>
    /// 7 個のパラメーターを受け取って TResult パラメーターに指定された型の値を返すメソッドをカプセル化します。
    /// </summary>
    /// <typeparam name="T1">このデリゲートによってカプセル化されるメソッドの第 1 パラメーターの型。</typeparam>
    /// <typeparam name="T2">このデリゲートによってカプセル化されるメソッドの第 2 パラメーターの型。</typeparam>
    /// <typeparam name="T3">このデリゲートによってカプセル化されるメソッドの第 3 パラメーターの型。</typeparam>
    /// <typeparam name="T4">このデリゲートによってカプセル化されるメソッドの第 4 パラメーターの型。</typeparam>
    /// <typeparam name="T5">このデリゲートによってカプセル化されるメソッドの第 5 パラメーターの型。</typeparam>
    /// <typeparam name="T6">このデリゲートによってカプセル化されるメソッドの第 6 パラメーターの型。</typeparam>
    /// <typeparam name="T7">このデリゲートによってカプセル化されるメソッドの第 7 パラメーターの型。</typeparam>
    /// <typeparam name="TResult">このデリゲートによってカプセル化されるメソッドの戻り値の型。</typeparam>
    /// <param name="arg1">このデリゲートによってカプセル化されるメソッドの第 1 パラメーター。</param>
    /// <param name="arg2">このデリゲートによってカプセル化されるメソッドの第 2 パラメーター。</param>
    /// <param name="arg3">このデリゲートによってカプセル化されるメソッドの第 3 パラメーター。</param>
    /// <param name="arg4">このデリゲートによってカプセル化されるメソッドの第 4 パラメーター。</param>
    /// <param name="arg5">このデリゲートによってカプセル化されるメソッドの第 5 パラメーター。</param>
    /// <param name="arg6">このデリゲートによってカプセル化されるメソッドの第 6 パラメーター。</param>
    /// <param name="arg7">このデリゲートによってカプセル化されるメソッドの第 7 パラメーター。</param>
    /// <returns>このデリゲートによってカプセル化されるメソッドの戻り値。</returns>
    public delegate TResult Func<T1, T2, T3, T4, T5, T6, T7,  TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);

    /// <summary>
    /// 8 個のパラメーターを受け取って TResult パラメーターに指定された型の値を返すメソッドをカプセル化します。
    /// </summary>
    /// <typeparam name="T1">このデリゲートによってカプセル化されるメソッドの第 1 パラメーターの型。</typeparam>
    /// <typeparam name="T2">このデリゲートによってカプセル化されるメソッドの第 2 パラメーターの型。</typeparam>
    /// <typeparam name="T3">このデリゲートによってカプセル化されるメソッドの第 3 パラメーターの型。</typeparam>
    /// <typeparam name="T4">このデリゲートによってカプセル化されるメソッドの第 4 パラメーターの型。</typeparam>
    /// <typeparam name="T5">このデリゲートによってカプセル化されるメソッドの第 5 パラメーターの型。</typeparam>
    /// <typeparam name="T6">このデリゲートによってカプセル化されるメソッドの第 6 パラメーターの型。</typeparam>
    /// <typeparam name="T7">このデリゲートによってカプセル化されるメソッドの第 7 パラメーターの型。</typeparam>
    /// <typeparam name="T8">このデリゲートによってカプセル化されるメソッドの第 8 パラメーターの型。</typeparam>
    /// <typeparam name="TResult">このデリゲートによってカプセル化されるメソッドの戻り値の型。</typeparam>
    /// <param name="arg1">このデリゲートによってカプセル化されるメソッドの第 1 パラメーター。</param>
    /// <param name="arg2">このデリゲートによってカプセル化されるメソッドの第 2 パラメーター。</param>
    /// <param name="arg3">このデリゲートによってカプセル化されるメソッドの第 3 パラメーター。</param>
    /// <param name="arg4">このデリゲートによってカプセル化されるメソッドの第 4 パラメーター。</param>
    /// <param name="arg5">このデリゲートによってカプセル化されるメソッドの第 5 パラメーター。</param>
    /// <param name="arg6">このデリゲートによってカプセル化されるメソッドの第 6 パラメーター。</param>
    /// <param name="arg7">このデリゲートによってカプセル化されるメソッドの第 7 パラメーター。</param>
    /// <param name="arg8">このデリゲートによってカプセル化されるメソッドの第 8 パラメーター。</param>
    /// <returns>このデリゲートによってカプセル化されるメソッドの戻り値。</returns>
    public delegate TResult Func<T1, T2, T3, T4, T5, T6, T7, T8,  TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);

    /// <summary>
    /// 9 個のパラメーターを受け取って TResult パラメーターに指定された型の値を返すメソッドをカプセル化します。
    /// </summary>
    /// <typeparam name="T1">このデリゲートによってカプセル化されるメソッドの第 1 パラメーターの型。</typeparam>
    /// <typeparam name="T2">このデリゲートによってカプセル化されるメソッドの第 2 パラメーターの型。</typeparam>
    /// <typeparam name="T3">このデリゲートによってカプセル化されるメソッドの第 3 パラメーターの型。</typeparam>
    /// <typeparam name="T4">このデリゲートによってカプセル化されるメソッドの第 4 パラメーターの型。</typeparam>
    /// <typeparam name="T5">このデリゲートによってカプセル化されるメソッドの第 5 パラメーターの型。</typeparam>
    /// <typeparam name="T6">このデリゲートによってカプセル化されるメソッドの第 6 パラメーターの型。</typeparam>
    /// <typeparam name="T7">このデリゲートによってカプセル化されるメソッドの第 7 パラメーターの型。</typeparam>
    /// <typeparam name="T8">このデリゲートによってカプセル化されるメソッドの第 8 パラメーターの型。</typeparam>
    /// <typeparam name="T9">このデリゲートによってカプセル化されるメソッドの第 9 パラメーターの型。</typeparam>
    /// <typeparam name="TResult">このデリゲートによってカプセル化されるメソッドの戻り値の型。</typeparam>
    /// <param name="arg1">このデリゲートによってカプセル化されるメソッドの第 1 パラメーター。</param>
    /// <param name="arg2">このデリゲートによってカプセル化されるメソッドの第 2 パラメーター。</param>
    /// <param name="arg3">このデリゲートによってカプセル化されるメソッドの第 3 パラメーター。</param>
    /// <param name="arg4">このデリゲートによってカプセル化されるメソッドの第 4 パラメーター。</param>
    /// <param name="arg5">このデリゲートによってカプセル化されるメソッドの第 5 パラメーター。</param>
    /// <param name="arg6">このデリゲートによってカプセル化されるメソッドの第 6 パラメーター。</param>
    /// <param name="arg7">このデリゲートによってカプセル化されるメソッドの第 7 パラメーター。</param>
    /// <param name="arg8">このデリゲートによってカプセル化されるメソッドの第 8 パラメーター。</param>
    /// <param name="arg9">このデリゲートによってカプセル化されるメソッドの第 9 パラメーター。</param>
    /// <returns>このデリゲートによってカプセル化されるメソッドの戻り値。</returns>
    public delegate TResult Func<T1, T2, T3, T4, T5, T6, T7, T8, T9,  TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9);

    /// <summary>
    /// 10 個のパラメーターを受け取って TResult パラメーターに指定された型の値を返すメソッドをカプセル化します。
    /// </summary>
    /// <typeparam name="T1">このデリゲートによってカプセル化されるメソッドの第 1 パラメーターの型。</typeparam>
    /// <typeparam name="T2">このデリゲートによってカプセル化されるメソッドの第 2 パラメーターの型。</typeparam>
    /// <typeparam name="T3">このデリゲートによってカプセル化されるメソッドの第 3 パラメーターの型。</typeparam>
    /// <typeparam name="T4">このデリゲートによってカプセル化されるメソッドの第 4 パラメーターの型。</typeparam>
    /// <typeparam name="T5">このデリゲートによってカプセル化されるメソッドの第 5 パラメーターの型。</typeparam>
    /// <typeparam name="T6">このデリゲートによってカプセル化されるメソッドの第 6 パラメーターの型。</typeparam>
    /// <typeparam name="T7">このデリゲートによってカプセル化されるメソッドの第 7 パラメーターの型。</typeparam>
    /// <typeparam name="T8">このデリゲートによってカプセル化されるメソッドの第 8 パラメーターの型。</typeparam>
    /// <typeparam name="T9">このデリゲートによってカプセル化されるメソッドの第 9 パラメーターの型。</typeparam>
    /// <typeparam name="T10">このデリゲートによってカプセル化されるメソッドの第 10 パラメーターの型。</typeparam>
    /// <typeparam name="TResult">このデリゲートによってカプセル化されるメソッドの戻り値の型。</typeparam>
    /// <param name="arg1">このデリゲートによってカプセル化されるメソッドの第 1 パラメーター。</param>
    /// <param name="arg2">このデリゲートによってカプセル化されるメソッドの第 2 パラメーター。</param>
    /// <param name="arg3">このデリゲートによってカプセル化されるメソッドの第 3 パラメーター。</param>
    /// <param name="arg4">このデリゲートによってカプセル化されるメソッドの第 4 パラメーター。</param>
    /// <param name="arg5">このデリゲートによってカプセル化されるメソッドの第 5 パラメーター。</param>
    /// <param name="arg6">このデリゲートによってカプセル化されるメソッドの第 6 パラメーター。</param>
    /// <param name="arg7">このデリゲートによってカプセル化されるメソッドの第 7 パラメーター。</param>
    /// <param name="arg8">このデリゲートによってカプセル化されるメソッドの第 8 パラメーター。</param>
    /// <param name="arg9">このデリゲートによってカプセル化されるメソッドの第 9 パラメーター。</param>
    /// <param name="arg10">このデリゲートによってカプセル化されるメソッドの第 10 パラメーター。</param>
    /// <returns>このデリゲートによってカプセル化されるメソッドの戻り値。</returns>
    public delegate TResult Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,  TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10);

    /// <summary>
    /// 11 個のパラメーターを受け取って TResult パラメーターに指定された型の値を返すメソッドをカプセル化します。
    /// </summary>
    /// <typeparam name="T1">このデリゲートによってカプセル化されるメソッドの第 1 パラメーターの型。</typeparam>
    /// <typeparam name="T2">このデリゲートによってカプセル化されるメソッドの第 2 パラメーターの型。</typeparam>
    /// <typeparam name="T3">このデリゲートによってカプセル化されるメソッドの第 3 パラメーターの型。</typeparam>
    /// <typeparam name="T4">このデリゲートによってカプセル化されるメソッドの第 4 パラメーターの型。</typeparam>
    /// <typeparam name="T5">このデリゲートによってカプセル化されるメソッドの第 5 パラメーターの型。</typeparam>
    /// <typeparam name="T6">このデリゲートによってカプセル化されるメソッドの第 6 パラメーターの型。</typeparam>
    /// <typeparam name="T7">このデリゲートによってカプセル化されるメソッドの第 7 パラメーターの型。</typeparam>
    /// <typeparam name="T8">このデリゲートによってカプセル化されるメソッドの第 8 パラメーターの型。</typeparam>
    /// <typeparam name="T9">このデリゲートによってカプセル化されるメソッドの第 9 パラメーターの型。</typeparam>
    /// <typeparam name="T10">このデリゲートによってカプセル化されるメソッドの第 10 パラメーターの型。</typeparam>
    /// <typeparam name="T11">このデリゲートによってカプセル化されるメソッドの第 11 パラメーターの型。</typeparam>
    /// <typeparam name="TResult">このデリゲートによってカプセル化されるメソッドの戻り値の型。</typeparam>
    /// <param name="arg1">このデリゲートによってカプセル化されるメソッドの第 1 パラメーター。</param>
    /// <param name="arg2">このデリゲートによってカプセル化されるメソッドの第 2 パラメーター。</param>
    /// <param name="arg3">このデリゲートによってカプセル化されるメソッドの第 3 パラメーター。</param>
    /// <param name="arg4">このデリゲートによってカプセル化されるメソッドの第 4 パラメーター。</param>
    /// <param name="arg5">このデリゲートによってカプセル化されるメソッドの第 5 パラメーター。</param>
    /// <param name="arg6">このデリゲートによってカプセル化されるメソッドの第 6 パラメーター。</param>
    /// <param name="arg7">このデリゲートによってカプセル化されるメソッドの第 7 パラメーター。</param>
    /// <param name="arg8">このデリゲートによってカプセル化されるメソッドの第 8 パラメーター。</param>
    /// <param name="arg9">このデリゲートによってカプセル化されるメソッドの第 9 パラメーター。</param>
    /// <param name="arg10">このデリゲートによってカプセル化されるメソッドの第 10 パラメーター。</param>
    /// <param name="arg11">このデリゲートによってカプセル化されるメソッドの第 11 パラメーター。</param>
    /// <returns>このデリゲートによってカプセル化されるメソッドの戻り値。</returns>
    public delegate TResult Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,  TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11);

    /// <summary>
    /// 12 個のパラメーターを受け取って TResult パラメーターに指定された型の値を返すメソッドをカプセル化します。
    /// </summary>
    /// <typeparam name="T1">このデリゲートによってカプセル化されるメソッドの第 1 パラメーターの型。</typeparam>
    /// <typeparam name="T2">このデリゲートによってカプセル化されるメソッドの第 2 パラメーターの型。</typeparam>
    /// <typeparam name="T3">このデリゲートによってカプセル化されるメソッドの第 3 パラメーターの型。</typeparam>
    /// <typeparam name="T4">このデリゲートによってカプセル化されるメソッドの第 4 パラメーターの型。</typeparam>
    /// <typeparam name="T5">このデリゲートによってカプセル化されるメソッドの第 5 パラメーターの型。</typeparam>
    /// <typeparam name="T6">このデリゲートによってカプセル化されるメソッドの第 6 パラメーターの型。</typeparam>
    /// <typeparam name="T7">このデリゲートによってカプセル化されるメソッドの第 7 パラメーターの型。</typeparam>
    /// <typeparam name="T8">このデリゲートによってカプセル化されるメソッドの第 8 パラメーターの型。</typeparam>
    /// <typeparam name="T9">このデリゲートによってカプセル化されるメソッドの第 9 パラメーターの型。</typeparam>
    /// <typeparam name="T10">このデリゲートによってカプセル化されるメソッドの第 10 パラメーターの型。</typeparam>
    /// <typeparam name="T11">このデリゲートによってカプセル化されるメソッドの第 11 パラメーターの型。</typeparam>
    /// <typeparam name="T12">このデリゲートによってカプセル化されるメソッドの第 12 パラメーターの型。</typeparam>
    /// <typeparam name="TResult">このデリゲートによってカプセル化されるメソッドの戻り値の型。</typeparam>
    /// <param name="arg1">このデリゲートによってカプセル化されるメソッドの第 1 パラメーター。</param>
    /// <param name="arg2">このデリゲートによってカプセル化されるメソッドの第 2 パラメーター。</param>
    /// <param name="arg3">このデリゲートによってカプセル化されるメソッドの第 3 パラメーター。</param>
    /// <param name="arg4">このデリゲートによってカプセル化されるメソッドの第 4 パラメーター。</param>
    /// <param name="arg5">このデリゲートによってカプセル化されるメソッドの第 5 パラメーター。</param>
    /// <param name="arg6">このデリゲートによってカプセル化されるメソッドの第 6 パラメーター。</param>
    /// <param name="arg7">このデリゲートによってカプセル化されるメソッドの第 7 パラメーター。</param>
    /// <param name="arg8">このデリゲートによってカプセル化されるメソッドの第 8 パラメーター。</param>
    /// <param name="arg9">このデリゲートによってカプセル化されるメソッドの第 9 パラメーター。</param>
    /// <param name="arg10">このデリゲートによってカプセル化されるメソッドの第 10 パラメーター。</param>
    /// <param name="arg11">このデリゲートによってカプセル化されるメソッドの第 11 パラメーター。</param>
    /// <param name="arg12">このデリゲートによってカプセル化されるメソッドの第 12 パラメーター。</param>
    /// <returns>このデリゲートによってカプセル化されるメソッドの戻り値。</returns>
    public delegate TResult Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,  TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12);

    /// <summary>
    /// 13 個のパラメーターを受け取って TResult パラメーターに指定された型の値を返すメソッドをカプセル化します。
    /// </summary>
    /// <typeparam name="T1">このデリゲートによってカプセル化されるメソッドの第 1 パラメーターの型。</typeparam>
    /// <typeparam name="T2">このデリゲートによってカプセル化されるメソッドの第 2 パラメーターの型。</typeparam>
    /// <typeparam name="T3">このデリゲートによってカプセル化されるメソッドの第 3 パラメーターの型。</typeparam>
    /// <typeparam name="T4">このデリゲートによってカプセル化されるメソッドの第 4 パラメーターの型。</typeparam>
    /// <typeparam name="T5">このデリゲートによってカプセル化されるメソッドの第 5 パラメーターの型。</typeparam>
    /// <typeparam name="T6">このデリゲートによってカプセル化されるメソッドの第 6 パラメーターの型。</typeparam>
    /// <typeparam name="T7">このデリゲートによってカプセル化されるメソッドの第 7 パラメーターの型。</typeparam>
    /// <typeparam name="T8">このデリゲートによってカプセル化されるメソッドの第 8 パラメーターの型。</typeparam>
    /// <typeparam name="T9">このデリゲートによってカプセル化されるメソッドの第 9 パラメーターの型。</typeparam>
    /// <typeparam name="T10">このデリゲートによってカプセル化されるメソッドの第 10 パラメーターの型。</typeparam>
    /// <typeparam name="T11">このデリゲートによってカプセル化されるメソッドの第 11 パラメーターの型。</typeparam>
    /// <typeparam name="T12">このデリゲートによってカプセル化されるメソッドの第 12 パラメーターの型。</typeparam>
    /// <typeparam name="T13">このデリゲートによってカプセル化されるメソッドの第 13 パラメーターの型。</typeparam>
    /// <typeparam name="TResult">このデリゲートによってカプセル化されるメソッドの戻り値の型。</typeparam>
    /// <param name="arg1">このデリゲートによってカプセル化されるメソッドの第 1 パラメーター。</param>
    /// <param name="arg2">このデリゲートによってカプセル化されるメソッドの第 2 パラメーター。</param>
    /// <param name="arg3">このデリゲートによってカプセル化されるメソッドの第 3 パラメーター。</param>
    /// <param name="arg4">このデリゲートによってカプセル化されるメソッドの第 4 パラメーター。</param>
    /// <param name="arg5">このデリゲートによってカプセル化されるメソッドの第 5 パラメーター。</param>
    /// <param name="arg6">このデリゲートによってカプセル化されるメソッドの第 6 パラメーター。</param>
    /// <param name="arg7">このデリゲートによってカプセル化されるメソッドの第 7 パラメーター。</param>
    /// <param name="arg8">このデリゲートによってカプセル化されるメソッドの第 8 パラメーター。</param>
    /// <param name="arg9">このデリゲートによってカプセル化されるメソッドの第 9 パラメーター。</param>
    /// <param name="arg10">このデリゲートによってカプセル化されるメソッドの第 10 パラメーター。</param>
    /// <param name="arg11">このデリゲートによってカプセル化されるメソッドの第 11 パラメーター。</param>
    /// <param name="arg12">このデリゲートによってカプセル化されるメソッドの第 12 パラメーター。</param>
    /// <param name="arg13">このデリゲートによってカプセル化されるメソッドの第 13 パラメーター。</param>
    /// <returns>このデリゲートによってカプセル化されるメソッドの戻り値。</returns>
    public delegate TResult Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13,  TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13);

    /// <summary>
    /// 14 個のパラメーターを受け取って TResult パラメーターに指定された型の値を返すメソッドをカプセル化します。
    /// </summary>
    /// <typeparam name="T1">このデリゲートによってカプセル化されるメソッドの第 1 パラメーターの型。</typeparam>
    /// <typeparam name="T2">このデリゲートによってカプセル化されるメソッドの第 2 パラメーターの型。</typeparam>
    /// <typeparam name="T3">このデリゲートによってカプセル化されるメソッドの第 3 パラメーターの型。</typeparam>
    /// <typeparam name="T4">このデリゲートによってカプセル化されるメソッドの第 4 パラメーターの型。</typeparam>
    /// <typeparam name="T5">このデリゲートによってカプセル化されるメソッドの第 5 パラメーターの型。</typeparam>
    /// <typeparam name="T6">このデリゲートによってカプセル化されるメソッドの第 6 パラメーターの型。</typeparam>
    /// <typeparam name="T7">このデリゲートによってカプセル化されるメソッドの第 7 パラメーターの型。</typeparam>
    /// <typeparam name="T8">このデリゲートによってカプセル化されるメソッドの第 8 パラメーターの型。</typeparam>
    /// <typeparam name="T9">このデリゲートによってカプセル化されるメソッドの第 9 パラメーターの型。</typeparam>
    /// <typeparam name="T10">このデリゲートによってカプセル化されるメソッドの第 10 パラメーターの型。</typeparam>
    /// <typeparam name="T11">このデリゲートによってカプセル化されるメソッドの第 11 パラメーターの型。</typeparam>
    /// <typeparam name="T12">このデリゲートによってカプセル化されるメソッドの第 12 パラメーターの型。</typeparam>
    /// <typeparam name="T13">このデリゲートによってカプセル化されるメソッドの第 13 パラメーターの型。</typeparam>
    /// <typeparam name="T14">このデリゲートによってカプセル化されるメソッドの第 14 パラメーターの型。</typeparam>
    /// <typeparam name="TResult">このデリゲートによってカプセル化されるメソッドの戻り値の型。</typeparam>
    /// <param name="arg1">このデリゲートによってカプセル化されるメソッドの第 1 パラメーター。</param>
    /// <param name="arg2">このデリゲートによってカプセル化されるメソッドの第 2 パラメーター。</param>
    /// <param name="arg3">このデリゲートによってカプセル化されるメソッドの第 3 パラメーター。</param>
    /// <param name="arg4">このデリゲートによってカプセル化されるメソッドの第 4 パラメーター。</param>
    /// <param name="arg5">このデリゲートによってカプセル化されるメソッドの第 5 パラメーター。</param>
    /// <param name="arg6">このデリゲートによってカプセル化されるメソッドの第 6 パラメーター。</param>
    /// <param name="arg7">このデリゲートによってカプセル化されるメソッドの第 7 パラメーター。</param>
    /// <param name="arg8">このデリゲートによってカプセル化されるメソッドの第 8 パラメーター。</param>
    /// <param name="arg9">このデリゲートによってカプセル化されるメソッドの第 9 パラメーター。</param>
    /// <param name="arg10">このデリゲートによってカプセル化されるメソッドの第 10 パラメーター。</param>
    /// <param name="arg11">このデリゲートによってカプセル化されるメソッドの第 11 パラメーター。</param>
    /// <param name="arg12">このデリゲートによってカプセル化されるメソッドの第 12 パラメーター。</param>
    /// <param name="arg13">このデリゲートによってカプセル化されるメソッドの第 13 パラメーター。</param>
    /// <param name="arg14">このデリゲートによってカプセル化されるメソッドの第 14 パラメーター。</param>
    /// <returns>このデリゲートによってカプセル化されるメソッドの戻り値。</returns>
    public delegate TResult Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14,  TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14);

    /// <summary>
    /// 15 個のパラメーターを受け取って TResult パラメーターに指定された型の値を返すメソッドをカプセル化します。
    /// </summary>
    /// <typeparam name="T1">このデリゲートによってカプセル化されるメソッドの第 1 パラメーターの型。</typeparam>
    /// <typeparam name="T2">このデリゲートによってカプセル化されるメソッドの第 2 パラメーターの型。</typeparam>
    /// <typeparam name="T3">このデリゲートによってカプセル化されるメソッドの第 3 パラメーターの型。</typeparam>
    /// <typeparam name="T4">このデリゲートによってカプセル化されるメソッドの第 4 パラメーターの型。</typeparam>
    /// <typeparam name="T5">このデリゲートによってカプセル化されるメソッドの第 5 パラメーターの型。</typeparam>
    /// <typeparam name="T6">このデリゲートによってカプセル化されるメソッドの第 6 パラメーターの型。</typeparam>
    /// <typeparam name="T7">このデリゲートによってカプセル化されるメソッドの第 7 パラメーターの型。</typeparam>
    /// <typeparam name="T8">このデリゲートによってカプセル化されるメソッドの第 8 パラメーターの型。</typeparam>
    /// <typeparam name="T9">このデリゲートによってカプセル化されるメソッドの第 9 パラメーターの型。</typeparam>
    /// <typeparam name="T10">このデリゲートによってカプセル化されるメソッドの第 10 パラメーターの型。</typeparam>
    /// <typeparam name="T11">このデリゲートによってカプセル化されるメソッドの第 11 パラメーターの型。</typeparam>
    /// <typeparam name="T12">このデリゲートによってカプセル化されるメソッドの第 12 パラメーターの型。</typeparam>
    /// <typeparam name="T13">このデリゲートによってカプセル化されるメソッドの第 13 パラメーターの型。</typeparam>
    /// <typeparam name="T14">このデリゲートによってカプセル化されるメソッドの第 14 パラメーターの型。</typeparam>
    /// <typeparam name="T15">このデリゲートによってカプセル化されるメソッドの第 15 パラメーターの型。</typeparam>
    /// <typeparam name="TResult">このデリゲートによってカプセル化されるメソッドの戻り値の型。</typeparam>
    /// <param name="arg1">このデリゲートによってカプセル化されるメソッドの第 1 パラメーター。</param>
    /// <param name="arg2">このデリゲートによってカプセル化されるメソッドの第 2 パラメーター。</param>
    /// <param name="arg3">このデリゲートによってカプセル化されるメソッドの第 3 パラメーター。</param>
    /// <param name="arg4">このデリゲートによってカプセル化されるメソッドの第 4 パラメーター。</param>
    /// <param name="arg5">このデリゲートによってカプセル化されるメソッドの第 5 パラメーター。</param>
    /// <param name="arg6">このデリゲートによってカプセル化されるメソッドの第 6 パラメーター。</param>
    /// <param name="arg7">このデリゲートによってカプセル化されるメソッドの第 7 パラメーター。</param>
    /// <param name="arg8">このデリゲートによってカプセル化されるメソッドの第 8 パラメーター。</param>
    /// <param name="arg9">このデリゲートによってカプセル化されるメソッドの第 9 パラメーター。</param>
    /// <param name="arg10">このデリゲートによってカプセル化されるメソッドの第 10 パラメーター。</param>
    /// <param name="arg11">このデリゲートによってカプセル化されるメソッドの第 11 パラメーター。</param>
    /// <param name="arg12">このデリゲートによってカプセル化されるメソッドの第 12 パラメーター。</param>
    /// <param name="arg13">このデリゲートによってカプセル化されるメソッドの第 13 パラメーター。</param>
    /// <param name="arg14">このデリゲートによってカプセル化されるメソッドの第 14 パラメーター。</param>
    /// <param name="arg15">このデリゲートによってカプセル化されるメソッドの第 15 パラメーター。</param>
    /// <returns>このデリゲートによってカプセル化されるメソッドの戻り値。</returns>
    public delegate TResult Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15,  TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15);

    /// <summary>
    /// 16 個のパラメーターを受け取って TResult パラメーターに指定された型の値を返すメソッドをカプセル化します。
    /// </summary>
    /// <typeparam name="T1">このデリゲートによってカプセル化されるメソッドの第 1 パラメーターの型。</typeparam>
    /// <typeparam name="T2">このデリゲートによってカプセル化されるメソッドの第 2 パラメーターの型。</typeparam>
    /// <typeparam name="T3">このデリゲートによってカプセル化されるメソッドの第 3 パラメーターの型。</typeparam>
    /// <typeparam name="T4">このデリゲートによってカプセル化されるメソッドの第 4 パラメーターの型。</typeparam>
    /// <typeparam name="T5">このデリゲートによってカプセル化されるメソッドの第 5 パラメーターの型。</typeparam>
    /// <typeparam name="T6">このデリゲートによってカプセル化されるメソッドの第 6 パラメーターの型。</typeparam>
    /// <typeparam name="T7">このデリゲートによってカプセル化されるメソッドの第 7 パラメーターの型。</typeparam>
    /// <typeparam name="T8">このデリゲートによってカプセル化されるメソッドの第 8 パラメーターの型。</typeparam>
    /// <typeparam name="T9">このデリゲートによってカプセル化されるメソッドの第 9 パラメーターの型。</typeparam>
    /// <typeparam name="T10">このデリゲートによってカプセル化されるメソッドの第 10 パラメーターの型。</typeparam>
    /// <typeparam name="T11">このデリゲートによってカプセル化されるメソッドの第 11 パラメーターの型。</typeparam>
    /// <typeparam name="T12">このデリゲートによってカプセル化されるメソッドの第 12 パラメーターの型。</typeparam>
    /// <typeparam name="T13">このデリゲートによってカプセル化されるメソッドの第 13 パラメーターの型。</typeparam>
    /// <typeparam name="T14">このデリゲートによってカプセル化されるメソッドの第 14 パラメーターの型。</typeparam>
    /// <typeparam name="T15">このデリゲートによってカプセル化されるメソッドの第 15 パラメーターの型。</typeparam>
    /// <typeparam name="T16">このデリゲートによってカプセル化されるメソッドの第 16 パラメーターの型。</typeparam>
    /// <typeparam name="TResult">このデリゲートによってカプセル化されるメソッドの戻り値の型。</typeparam>
    /// <param name="arg1">このデリゲートによってカプセル化されるメソッドの第 1 パラメーター。</param>
    /// <param name="arg2">このデリゲートによってカプセル化されるメソッドの第 2 パラメーター。</param>
    /// <param name="arg3">このデリゲートによってカプセル化されるメソッドの第 3 パラメーター。</param>
    /// <param name="arg4">このデリゲートによってカプセル化されるメソッドの第 4 パラメーター。</param>
    /// <param name="arg5">このデリゲートによってカプセル化されるメソッドの第 5 パラメーター。</param>
    /// <param name="arg6">このデリゲートによってカプセル化されるメソッドの第 6 パラメーター。</param>
    /// <param name="arg7">このデリゲートによってカプセル化されるメソッドの第 7 パラメーター。</param>
    /// <param name="arg8">このデリゲートによってカプセル化されるメソッドの第 8 パラメーター。</param>
    /// <param name="arg9">このデリゲートによってカプセル化されるメソッドの第 9 パラメーター。</param>
    /// <param name="arg10">このデリゲートによってカプセル化されるメソッドの第 10 パラメーター。</param>
    /// <param name="arg11">このデリゲートによってカプセル化されるメソッドの第 11 パラメーター。</param>
    /// <param name="arg12">このデリゲートによってカプセル化されるメソッドの第 12 パラメーター。</param>
    /// <param name="arg13">このデリゲートによってカプセル化されるメソッドの第 13 パラメーター。</param>
    /// <param name="arg14">このデリゲートによってカプセル化されるメソッドの第 14 パラメーター。</param>
    /// <param name="arg15">このデリゲートによってカプセル化されるメソッドの第 15 パラメーター。</param>
    /// <param name="arg16">このデリゲートによってカプセル化されるメソッドの第 16 パラメーター。</param>
    /// <returns>このデリゲートによってカプセル化されるメソッドの戻り値。</returns>
    public delegate TResult Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16,  TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16);

}