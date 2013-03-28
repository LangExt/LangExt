using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace LangExt2
{
    partial class Enumerable
    {
        /// <summary>
        /// クエリ式用に用意しています。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static IEnumerable<U> Select<T, U>(this IEnumerable<T> self, Func<T, U> f) { return self.Select(f); }

        /// <summary>
        /// クエリ式用に用意しています。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static IEnumerable<T> Where<T>(this IEnumerable<T> self, Func<T, bool> pred) { return self.Where(pred); }

        /// <summary>
        /// クエリ式用に用意しています。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static IEnumerable<V> SelectMany<T, U, V>(this IEnumerable<T> self, Func<T, IEnumerable<U>> f, Func<T, U, V> g) { return self.SelectMany(f, g); }

        /// <summary>
        /// クエリ式用に用意しています。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static IOrderedEnumerable<T> OrderBy<T, U>(this IEnumerable<T> self, Func<T, U> f) { return self.OrderBy(f); }

        /// <summary>
        /// クエリ式用に用意しています。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static IOrderedEnumerable<T> OrderByDescending<T, U>(this IEnumerable<T> self, Func<T, U> f) { return self.OrderByDescending(f); }

        /// <summary>
        /// クエリ式用に用意しています。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static IOrderedEnumerable<T> ThenBy<T, U>(this IOrderedEnumerable<T> self, Func<T, U> f) { return self.ThenBy(f); }

        /// <summary>
        /// クエリ式用に用意しています。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static IOrderedEnumerable<T> ThenByDescending<T, U>(this IOrderedEnumerable<T> self, Func<T, U> f) { return self.ThenByDescending(f); }

        /// <summary>
        /// クエリ式用に用意しています。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static IGrouping<U, T> GroupBy<T, U>(this IEnumerable<T> self, Func<T, U> f) { return self.GroupBy(f); }

        /// <summary>
        /// クエリ式用に用意しています。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static IGrouping<V, T> GroupBy<T, U, V>(this IEnumerable<T> self, Func<T, U> f, Func<T, V> g) { return self.GroupBy(f, g); }

        /// <summary>
        /// クエリ式用に用意しています。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static IGrouping<W, T> GroupBy<T, U, V, W>(this IEnumerable<T> self, Func<T, U> f, Func<T, V> g, Func<U, IEnumerable<V>, W> h) { return self.GroupBy(f, g, h); }

        /// <summary>
        /// クエリ式用に用意しています。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static IEnumerable<W> GroupJoin<T, U, V, W>(this IEnumerable<T> self, IEnumerable<U> inner, Func<T, V> f, Func<U, V> g, Func<T, IEnumerable<U>, W> h) { return self.GroupJoin(inner, f, g, h); }

        /// <summary>
        /// クエリ式用に用意しています。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static IEnumerable<W> Join<T, U, V, W>(this IEnumerable<T> self, IEnumerable<U> inner, Func<T, V> f, Func<U, V> g, Func<T, U, W> h) { return self.Join(inner, f, g, h); }
    }
}
