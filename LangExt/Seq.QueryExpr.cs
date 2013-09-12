using System;
using System.ComponentModel;

#pragma warning disable 618

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
        public static Seq<U> Select<T, U>(this ISeq<T> self, Func<T, U> f) { return self.Map(f); }

        /// <summary>
        /// クエリ式でシーケンスを扱うためのメソッドです。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Seq<V> SelectMany<T, U, V>(this ISeq<T> self, Func<T, ISeq<U>> f, Func<T, U, V> g)
        {
            return self.Bind(x => f(x).Bind(y => Seq.Singleton(g(x, y))));
        }

        /// <summary>
        /// クエリ式でシーケンスを扱うためのメソッドです。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Seq<T> Where<T>(this ISeq<T> self, Func<T, bool> pred) { return self.Filter(pred); }

        /// <summary>
        /// クエリ式でシーケンスを扱うためのメソッドです。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Seq<W> Join<T, U, V, W>(this ISeq<T> self, ISeq<U> xs, Func<T, V> f, Func<U, V> g, Func<T, U, W> h)
        {
            return new EnumerableSeq<W>(StdEnumerable.Join(self, xs, f, g, h));
        }

        /// <summary>
        /// クエリ式でシーケンスを扱うためのメソッドです。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static Seq<W> GroupJoin<T, U, V, W>(this ISeq<T> outer, ISeq<U> inner, Func<T, V> f, Func<U, V> g, Func<T, ISeq<U>, W> h)
        {
            return new EnumerableSeq<W>(StdEnumerable.GroupJoin(outer, inner, f, g, (t, ws) => h(t, new EnumerableSeq<U>(ws))));
        }

        /// <summary>
        /// クエリ式でシーケンスを扱うためのメソッドです。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static OrderedSeq<T> OrderBy<T, U>(this ISeq<T> self, Func<T, U> f)
        {
            return new OrderedEnumerableSeq<T>(StdEnumerable.OrderBy(self, f));
        }

        /// <summary>
        /// クエリ式でシーケンスを扱うためのメソッドです。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static OrderedSeq<T> OrderByDescending<T, U>(this ISeq<T> self, Func<T, U> f)
        {
            return new OrderedEnumerableSeq<T>(StdEnumerable.OrderByDescending(self, f));
        }
    }
}

#pragma warning restore 618