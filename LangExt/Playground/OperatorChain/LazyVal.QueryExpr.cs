using System;
using System.ComponentModel;

namespace LangExt.Playground.OperatorChain
{
    partial class LazyVal
    {
        /// <summary>
        /// LazyValをクエリ式で使うためのメソッドです。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static LazyVal<U> Select<T, U>(this LazyVal<T> self, Func<T, U> f)
        {
            return self.Map(f);
        }
 
        /// <summary>
        /// LazyValをクエリ式で使うためのメソッドです。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static LazyVal<V> SelectMany<T, U, V>(this LazyVal<T> self, Func<T, LazyVal<U>> f, Func<T, U, V> g)
        {
            return self.Bind(t => f(t).Bind(u => new LazyVal<V>(() => g(t, u))));
        }
    }
}
