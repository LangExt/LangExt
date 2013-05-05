using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace LangExt
{
    partial class Result
    {
        /// <summary>
        /// クエリ式でResultを扱うためのメソッドです。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Result<U, _> Select<T, _, U>(this Result<T, _> self, Func<T, U> f)
        {
            return self.Map(f);
        }

        /// <summary>
        /// クエリ式でResultを扱うためのメソッドです。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Result<V, _> SelectMany<T, _, U, V>(this Result<T, _> self, Func<T, Result<U, _>> f, Func<T, U, V> g)
        {
            return self.Bind(x => f(x).Bind(y => Result.Success(g(x, y))));
        }
    }
}
