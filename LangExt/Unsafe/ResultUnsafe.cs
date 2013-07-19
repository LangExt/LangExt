using System;
using System.ComponentModel;

namespace LangExt.Unsafe
{
    /// <summary>
    /// Resultに対する(例外を投げうる)関数を提供します。
    /// </summary>
    public static class ResultUnsafe
    {
        /// <summary>
        /// 保持している成功の値を強制的に取得します。
        /// このメソッドはFailureの場合に意味のない値(default(TFailure))を返すため、危険です。
        /// そのため、このメソッドは基本的には使用せず、MatchメソッドやGetOrメソッドを使用するようにしてください。
        /// </summary>
        /// <returns>内部で保持している成功の値</returns>
        public static TSuccess GetSuccessValue<TSuccess, TFailure>(this Result<TSuccess, TFailure> self)
        {
            return self.SuccessValue;
        }

        /// <summary>
        /// 保持している失敗の値を強制的に取得します。
        /// このメソッドはSuccessの場合に意味のない値(default(TSuccess))を返すため、危険です。
        /// そのため、このメソッドは基本的には使用せず、MatchメソッドやGetFailureOrメソッドを使用するようにしてください。
        /// </summary>
        /// <returns>内部で保持している失敗の値</returns>
        public static TFailure GetFailureValue<TSuccess, TFailure>(this Result<TSuccess, TFailure> self)
        {
            return self.FailureValue;
        }

        /// <summary>
        /// 使用しません。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static new bool Equals(object a, object b)
        {
            return object.Equals(a, b);
        }

        /// <summary>
        /// 使用しません。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static new bool ReferenceEquals(object a, object b)
        {
            return object.ReferenceEquals(a, b);
        }
    }
}
