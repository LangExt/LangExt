using System;
using System.Collections.Generic;
using System.Text;

namespace LangExt
{
    using StdEnumerable = System.Linq.Enumerable;

    /// <summary>
    /// 要素Tの並び替えられたシーケンスを表すインターフェイスです。
    /// </summary>
    /// <typeparam name="T">要素の型</typeparam>
    public interface IOrderedSeq<T> : ISeq<T>, System.Linq.IOrderedEnumerable<T> { }

    internal class OrderedSeq<T> : IOrderedSeq<T>
    {
        #region OrderedSeqの実装
        readonly System.Linq.IOrderedEnumerable<T> value;

        internal OrderedSeq(System.Linq.IOrderedEnumerable<T> value) { this.value = value; }

        public IEnumerator<T> GetEnumerator() { return this.value.GetEnumerator(); }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return this.value.GetEnumerator(); }

        public System.Linq.IOrderedEnumerable<T> CreateOrderedEnumerable<U>(Func<T, U> f, IComparer<U> comparer, bool descending)
        {
            return value.CreateOrderedEnumerable(f, comparer, descending);
        }

        public override string ToString()
        {
            return string.Concat("seq [", Seq.ToSummaryText<T>(value), "]");
        }
        #endregion
    }

    /// <summary>
    /// 並び替えられたシーケンスに対する関数を提供します。
    /// </summary>
    public static partial class OrderedSeq
    {
        /// <summary>
        /// 並び替えられたシーケンスをさらに別のキーで安定ソートします。
        /// 標準クエリ演算子のThenByに対応します。
        /// </summary>
        public static IOrderedSeq<T> ThenBy<T, U>(this IOrderedSeq<T> self, Func<T, U> f)
        {
            return new OrderedSeq<T>(StdEnumerable.ThenBy(self, f));
        }

        /// <summary>
        /// 並び替えられたシーケンスをさらに別のキーで安定ソートします。
        /// 標準クエリ演算子のThenByDescendingに対応します。
        /// </summary>
        public static IOrderedSeq<T> RevThenBy<T, U>(this IOrderedSeq<T> self, Func<T, U> f)
        {
            return new OrderedSeq<T>(StdEnumerable.ThenByDescending(self, f));
        }
    }
}
