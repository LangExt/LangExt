using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace LangExt
{
    /// <summary>
    /// Comparerに対する操作を提供します。
    /// </summary>
    public static class Comparer
    {
        /// <summary>
        /// 比較用関数を指定して、Comparer[T]を生成します。
        /// </summary>
        public static Comparer<T> Create<T>(Func<T, T, int> comparer) { return new Comparer<T>(comparer); }

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

    partial class Create
    {
        /// <summary>
        /// 比較用関数を指定して、Compare[T]を生成します。
        /// </summary>
        public static Comparer<T> Comparer<T>(Func<T, T, int> comparer) { return new Comparer<T>(comparer); }
    }

    /// <summary>
    /// 2つのオブジェクトを比較するための関数からIComparer[T]に変換するアダプタークラスです。
    /// </summary>
    public sealed class Comparer<T> : IComparer<T>
    {
        readonly Func<T, T, int> comparer;

        /// <summary>
        /// 2つのオブジェクトを比較する関数を指定してオブジェクトを生成します。
        /// </summary>
        public Comparer(Func<T, T, int> comparer) { this.comparer = comparer; }

        /// <summary>
        /// 2つのオブジェクトを比較し、一方が他方より小さいか、等しいか、大きいかを示す値を返します。
        /// </summary>
        public int Compare(T x, T y) { return comparer(x, y); }
    }
}
