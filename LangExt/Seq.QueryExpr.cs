using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LangExt
{
    using StdEnumerable = System.Linq.Enumerable;

    // このモジュールのメソッドは、クエリ式でのみ使うことを意識しているので、
    // メソッド形式では呼びにくいように変数名等は一文字を使っている
    partial class Seq
    {
        /// <summary>
        /// クエリ式でシーケンスを扱うためのメソッドです。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static ISeq<U> Select<T, U>(this ISeq<T> self, Func<T, U> f) { return self.Map(f); }

        /// <summary>
        /// クエリ式でシーケンスを扱うためのメソッドです。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static ISeq<V> SelectMany<T, U, V>(this ISeq<T> self, Func<T, ISeq<U>> f, Func<T, U, V> g)
        {
            return self.Bind(x => f(x).Bind(y => Seq.Singleton(g(x, y))));
        }

        /// <summary>
        /// クエリ式でシーケンスを扱うためのメソッドです。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static ISeq<T> Where<T>(this ISeq<T> self, Func<T, bool> pred) { return self.Filter(pred); }

        /// <summary>
        /// クエリ式でシーケンスを扱うためのメソッドです。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static ISeq<W> Join<T, U, V, W>(this ISeq<T> self, ISeq<U> xs, Func<T, V> f, Func<U, V> g, Func<T, U, W> h)
        {
            return new Seq<W>(StdEnumerable.Join(self, xs, f, g, h));
        }

        /// <summary>
        /// クエリ式でシーケンスを扱うためのメソッドです。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static ISeq<W> GroupJoin<T, U, V, W>(this ISeq<T> outer, ISeq<U> inner, Func<T, V> f, Func<U, V> g, Func<T, ISeq<U>, W> h)
        {
            return new Seq<W>(StdEnumerable.GroupJoin(outer, inner, f, g, (t, ws) => h(t, new Seq<U>(ws))));
        }

        /// <summary>
        /// クエリ式でシーケンスを扱うためのメソッドです。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static ISeq<T> OrderBy<T, U>(this ISeq<T> self, Func<T, U> f)
        {
            return new Seq<T>(StdEnumerable.OrderBy(self, f));
        }

        /// <summary>
        /// クエリ式でシーケンスを扱うためのメソッドです。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static ISeq<T> OrderByDescending<T, U>(this ISeq<T> self, Func<T, U> f)
        {
            return new Seq<T>(StdEnumerable.OrderByDescending(self, f));
        }
    }
}
