using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace LangExt
{
    using StdEnumerable = System.Linq.Enumerable;

    partial class Enumerable
    {
        /// <summary>
        /// クエリ式用に用意しています。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static IEnumerable<U> Select<T, U>(this IEnumerable<T> self, Func<T, U> f) { return StdEnumerable.Select(self, f); }

        /// <summary>
        /// クエリ式用に用意しています。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static IEnumerable<T> Where<T>(this IEnumerable<T> self, Func<T, bool> pred) { return StdEnumerable.Where(self, pred); }

        /// <summary>
        /// クエリ式用に用意しています。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static IEnumerable<V> SelectMany<T, U, V>(this IEnumerable<T> self, Func<T, IEnumerable<U>> f, Func<T, U, V> g) { return StdEnumerable.SelectMany(self, f, g); }

        /// <summary>
        /// クエリ式用に用意しています。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static IOrderedEnumerable<T> OrderBy<T, U>(this IEnumerable<T> self, Func<T, U> f) { return StdEnumerable.OrderBy(self, f); }

        /// <summary>
        /// クエリ式用に用意しています。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static IOrderedEnumerable<T> OrderByDescending<T, U>(this IEnumerable<T> self, Func<T, U> f) { return StdEnumerable.OrderByDescending(self, f); }

        /// <summary>
        /// クエリ式用に用意しています。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static IOrderedEnumerable<T> ThenBy<T, U>(this IOrderedEnumerable<T> self, Func<T, U> f) { return StdEnumerable.ThenBy(self, f); }

        /// <summary>
        /// クエリ式用に用意しています。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static IOrderedEnumerable<T> ThenByDescending<T, U>(this IOrderedEnumerable<T> self, Func<T, U> f) { return StdEnumerable.ThenByDescending(self, f); }

        /// <summary>
        /// クエリ式用に用意しています。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static IEnumerable<IGrouping<U, T>> GroupBy<T, U>(this IEnumerable<T> self, Func<T, U> f) { return StdEnumerable.GroupBy(self, f); }

        /// <summary>
        /// クエリ式用に用意しています。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static IEnumerable<IGrouping<U, V>> GroupBy<T, U, V>(this IEnumerable<T> self, Func<T, U> f, Func<T, V> g) { return StdEnumerable.GroupBy(self, f, g); }

        /// <summary>
        /// クエリ式用に用意しています。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static IEnumerable<W> GroupBy<T, U, V, W>(this IEnumerable<T> self, Func<T, U> f, Func<T, V> g, Func<U, IEnumerable<V>, W> h) { return StdEnumerable.GroupBy(self, f, g, h); }

        /// <summary>
        /// クエリ式用に用意しています。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static IEnumerable<W> GroupJoin<T, U, V, W>(this IEnumerable<T> self, IEnumerable<U> inner, Func<T, V> f, Func<U, V> g, Func<T, IEnumerable<U>, W> h) { return StdEnumerable.GroupJoin(self, inner, f, g, h); }

        /// <summary>
        /// クエリ式用に用意しています。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static IEnumerable<W> Join<T, U, V, W>(this IEnumerable<T> self, IEnumerable<U> inner, Func<T, V> f, Func<U, V> g, Func<T, U, W> h) { return StdEnumerable.Join(self, inner, f, g, h); }
    }
}
