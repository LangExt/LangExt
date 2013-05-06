using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace LangExt
{
    partial class Option
    {
        /// <summary>
        /// クエリ式でOptionを扱うためのメソッドです。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Option<U> Select<T, U>(this Option<T> self, Func<T, U> f)
        {
            return self.Map(f);
        }

        /// <summary>
        /// クエリ式でOptionを扱うためのメソッドです。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Option<T> Where<T>(this Option<T> self, Func<T, bool> pred)
        {
            return self.Filter(pred);
        }

        /// <summary>
        /// クエリ式でOptionを扱うためのメソッドです。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Option<V> SelectMany<T, U, V>(this Option<T> self, Func<T, Option<U>> f, Func<T, U, V> g)
        {
            return self.Bind(x => f(x).Bind(y => Option.Some(g(x, y))));
        }

        /// <summary>
        /// クエリ式でOptionを扱うためのメソッドです。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Option<T> Cast<T>(this Option<Placeholder> self)
        {
            return (Option<T>)self;
        }
    }
}
