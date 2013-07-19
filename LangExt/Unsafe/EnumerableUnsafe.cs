using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace LangExt.Unsafe
{
    public static class EnumerableUnsafe
    {
        /// <summary>
        /// IEnumerableの指定番目の要素を取得します。
        /// 標準クエリ演算子のElementAtに対応します。
        /// </summary>
        public static T Get<T>(this IEnumerable<T> self, int index)
        {
            return self.ElementAt(index);
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
