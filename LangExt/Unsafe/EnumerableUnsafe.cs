using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
