using System;
using System.ComponentModel;

namespace LangExt.Unsafe
{
    /// <summary>
    /// Optionに対する(例外を投げうる)関数を提供します。
    /// </summary>
    public static class OptionUnsafe
    {
        /// <summary>
        /// 保持している値を強制的に取得します。
        /// このメソッドはNoneの場合に意味のない値(default(T))を返すため、危険です。
        /// そのため、このメソッドは基本的には使用せず、
        /// MatchメソッドやGetOrメソッドを使用するようにしてください。
        /// </summary>
        /// <returns>内部で保持している値</returns>
        public static T GetValue<T>(this Option<T> self)
        {
            return self.Value;
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
