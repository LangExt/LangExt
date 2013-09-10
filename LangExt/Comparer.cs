using System;
using System.Collections.Generic;

namespace LangExt
{
    public static class Comparer
    {
        public static Comparer<T> Create<T>(Func<T, T, int> comparer) { return new Comparer<T>(comparer); }
    }

    partial class Create
    {
        public static Comparer<T> Comparer<T>(Func<T, T, int> comparer) { return new Comparer<T>(comparer); }
    }

    public sealed class Comparer<T> : IComparer<T>
    {
        readonly Func<T, T, int> comparer;

        public Comparer(Func<T, T, int> comparer) { this.comparer = comparer; }

        public int Compare(T x, T y) { return comparer(x, y); }
    }
}
