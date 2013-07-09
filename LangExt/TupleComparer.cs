
using System;
using System.Collections.Generic;

namespace LangExt
{
    public static class TupleComparer
    {
        sealed class Cmp<T> : IComparer<T>
            where T : IComparable<T>
        {
            public static readonly Cmp<T> Instance = new Cmp<T>();
            public int Compare(T x, T y) { return x.RawCmp(y); }
        }

        static class Comparer
        {
            internal static Comparer<T1, T2> Create<T1, T2>() where T1 : IComparable<T1> where T2 : IComparable<T2>
            {
                return new Comparer<T1, T2>(Cmp<T1>.Instance, Cmp<T2>.Instance);
            }
            internal static Comparer<T1, T2> Create<T1, T2>(IComparer<T1> cmp1) where T2 : IComparable<T2>
            {
                return new Comparer<T1, T2>(cmp1, Cmp<T2>.Instance);
            }
            internal static Comparer<T1, T2> Create<T1, T2>(IComparer<T2> cmp2) where T1 : IComparable<T1>
            {
                return new Comparer<T1, T2>(Cmp<T1>.Instance, cmp2);
            }
            internal static Comparer<T1, T2> Create<T1, T2>(IComparer<T1> cmp1, IComparer<T2> cmp2)
            {
                return new Comparer<T1, T2>(cmp1, cmp2);
            }
            internal static Comparer<T1, T2, T3> Create<T1, T2, T3>() where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3>
            {
                return new Comparer<T1, T2, T3>(Cmp<T1>.Instance, Cmp<T2>.Instance, Cmp<T3>.Instance);
            }
            internal static Comparer<T1, T2, T3> Create<T1, T2, T3>(IComparer<T1> cmp1) where T2 : IComparable<T2> where T3 : IComparable<T3>
            {
                return new Comparer<T1, T2, T3>(cmp1, Cmp<T2>.Instance, Cmp<T3>.Instance);
            }
            internal static Comparer<T1, T2, T3> Create<T1, T2, T3>(IComparer<T2> cmp2) where T1 : IComparable<T1> where T3 : IComparable<T3>
            {
                return new Comparer<T1, T2, T3>(Cmp<T1>.Instance, cmp2, Cmp<T3>.Instance);
            }
            internal static Comparer<T1, T2, T3> Create<T1, T2, T3>(IComparer<T1> cmp1, IComparer<T2> cmp2) where T3 : IComparable<T3>
            {
                return new Comparer<T1, T2, T3>(cmp1, cmp2, Cmp<T3>.Instance);
            }
            internal static Comparer<T1, T2, T3> Create<T1, T2, T3>(IComparer<T3> cmp3) where T1 : IComparable<T1> where T2 : IComparable<T2>
            {
                return new Comparer<T1, T2, T3>(Cmp<T1>.Instance, Cmp<T2>.Instance, cmp3);
            }
            internal static Comparer<T1, T2, T3> Create<T1, T2, T3>(IComparer<T1> cmp1, IComparer<T3> cmp3) where T2 : IComparable<T2>
            {
                return new Comparer<T1, T2, T3>(cmp1, Cmp<T2>.Instance, cmp3);
            }
            internal static Comparer<T1, T2, T3> Create<T1, T2, T3>(IComparer<T2> cmp2, IComparer<T3> cmp3) where T1 : IComparable<T1>
            {
                return new Comparer<T1, T2, T3>(Cmp<T1>.Instance, cmp2, cmp3);
            }
            internal static Comparer<T1, T2, T3> Create<T1, T2, T3>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3)
            {
                return new Comparer<T1, T2, T3>(cmp1, cmp2, cmp3);
            }
            internal static Comparer<T1, T2, T3, T4> Create<T1, T2, T3, T4>() where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4>
            {
                return new Comparer<T1, T2, T3, T4>(Cmp<T1>.Instance, Cmp<T2>.Instance, Cmp<T3>.Instance, Cmp<T4>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4> Create<T1, T2, T3, T4>(IComparer<T1> cmp1) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4>
            {
                return new Comparer<T1, T2, T3, T4>(cmp1, Cmp<T2>.Instance, Cmp<T3>.Instance, Cmp<T4>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4> Create<T1, T2, T3, T4>(IComparer<T2> cmp2) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4>
            {
                return new Comparer<T1, T2, T3, T4>(Cmp<T1>.Instance, cmp2, Cmp<T3>.Instance, Cmp<T4>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4> Create<T1, T2, T3, T4>(IComparer<T1> cmp1, IComparer<T2> cmp2) where T3 : IComparable<T3> where T4 : IComparable<T4>
            {
                return new Comparer<T1, T2, T3, T4>(cmp1, cmp2, Cmp<T3>.Instance, Cmp<T4>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4> Create<T1, T2, T3, T4>(IComparer<T3> cmp3) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4>
            {
                return new Comparer<T1, T2, T3, T4>(Cmp<T1>.Instance, Cmp<T2>.Instance, cmp3, Cmp<T4>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4> Create<T1, T2, T3, T4>(IComparer<T1> cmp1, IComparer<T3> cmp3) where T2 : IComparable<T2> where T4 : IComparable<T4>
            {
                return new Comparer<T1, T2, T3, T4>(cmp1, Cmp<T2>.Instance, cmp3, Cmp<T4>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4> Create<T1, T2, T3, T4>(IComparer<T2> cmp2, IComparer<T3> cmp3) where T1 : IComparable<T1> where T4 : IComparable<T4>
            {
                return new Comparer<T1, T2, T3, T4>(Cmp<T1>.Instance, cmp2, cmp3, Cmp<T4>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4> Create<T1, T2, T3, T4>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3) where T4 : IComparable<T4>
            {
                return new Comparer<T1, T2, T3, T4>(cmp1, cmp2, cmp3, Cmp<T4>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4> Create<T1, T2, T3, T4>(IComparer<T4> cmp4) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3>
            {
                return new Comparer<T1, T2, T3, T4>(Cmp<T1>.Instance, Cmp<T2>.Instance, Cmp<T3>.Instance, cmp4);
            }
            internal static Comparer<T1, T2, T3, T4> Create<T1, T2, T3, T4>(IComparer<T1> cmp1, IComparer<T4> cmp4) where T2 : IComparable<T2> where T3 : IComparable<T3>
            {
                return new Comparer<T1, T2, T3, T4>(cmp1, Cmp<T2>.Instance, Cmp<T3>.Instance, cmp4);
            }
            internal static Comparer<T1, T2, T3, T4> Create<T1, T2, T3, T4>(IComparer<T2> cmp2, IComparer<T4> cmp4) where T1 : IComparable<T1> where T3 : IComparable<T3>
            {
                return new Comparer<T1, T2, T3, T4>(Cmp<T1>.Instance, cmp2, Cmp<T3>.Instance, cmp4);
            }
            internal static Comparer<T1, T2, T3, T4> Create<T1, T2, T3, T4>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4) where T3 : IComparable<T3>
            {
                return new Comparer<T1, T2, T3, T4>(cmp1, cmp2, Cmp<T3>.Instance, cmp4);
            }
            internal static Comparer<T1, T2, T3, T4> Create<T1, T2, T3, T4>(IComparer<T3> cmp3, IComparer<T4> cmp4) where T1 : IComparable<T1> where T2 : IComparable<T2>
            {
                return new Comparer<T1, T2, T3, T4>(Cmp<T1>.Instance, Cmp<T2>.Instance, cmp3, cmp4);
            }
            internal static Comparer<T1, T2, T3, T4> Create<T1, T2, T3, T4>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4) where T2 : IComparable<T2>
            {
                return new Comparer<T1, T2, T3, T4>(cmp1, Cmp<T2>.Instance, cmp3, cmp4);
            }
            internal static Comparer<T1, T2, T3, T4> Create<T1, T2, T3, T4>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4) where T1 : IComparable<T1>
            {
                return new Comparer<T1, T2, T3, T4>(Cmp<T1>.Instance, cmp2, cmp3, cmp4);
            }
            internal static Comparer<T1, T2, T3, T4> Create<T1, T2, T3, T4>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4)
            {
                return new Comparer<T1, T2, T3, T4>(cmp1, cmp2, cmp3, cmp4);
            }
            internal static Comparer<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>() where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5>(Cmp<T1>.Instance, Cmp<T2>.Instance, Cmp<T3>.Instance, Cmp<T4>.Instance, Cmp<T5>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(IComparer<T1> cmp1) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5>(cmp1, Cmp<T2>.Instance, Cmp<T3>.Instance, Cmp<T4>.Instance, Cmp<T5>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(IComparer<T2> cmp2) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5>(Cmp<T1>.Instance, cmp2, Cmp<T3>.Instance, Cmp<T4>.Instance, Cmp<T5>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T2> cmp2) where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5>(cmp1, cmp2, Cmp<T3>.Instance, Cmp<T4>.Instance, Cmp<T5>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(IComparer<T3> cmp3) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5>(Cmp<T1>.Instance, Cmp<T2>.Instance, cmp3, Cmp<T4>.Instance, Cmp<T5>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T3> cmp3) where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5>(cmp1, Cmp<T2>.Instance, cmp3, Cmp<T4>.Instance, Cmp<T5>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(IComparer<T2> cmp2, IComparer<T3> cmp3) where T1 : IComparable<T1> where T4 : IComparable<T4> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5>(Cmp<T1>.Instance, cmp2, cmp3, Cmp<T4>.Instance, Cmp<T5>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3) where T4 : IComparable<T4> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5>(cmp1, cmp2, cmp3, Cmp<T4>.Instance, Cmp<T5>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(IComparer<T4> cmp4) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5>(Cmp<T1>.Instance, Cmp<T2>.Instance, Cmp<T3>.Instance, cmp4, Cmp<T5>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T4> cmp4) where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5>(cmp1, Cmp<T2>.Instance, Cmp<T3>.Instance, cmp4, Cmp<T5>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(IComparer<T2> cmp2, IComparer<T4> cmp4) where T1 : IComparable<T1> where T3 : IComparable<T3> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5>(Cmp<T1>.Instance, cmp2, Cmp<T3>.Instance, cmp4, Cmp<T5>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4) where T3 : IComparable<T3> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5>(cmp1, cmp2, Cmp<T3>.Instance, cmp4, Cmp<T5>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(IComparer<T3> cmp3, IComparer<T4> cmp4) where T1 : IComparable<T1> where T2 : IComparable<T2> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5>(Cmp<T1>.Instance, Cmp<T2>.Instance, cmp3, cmp4, Cmp<T5>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4) where T2 : IComparable<T2> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5>(cmp1, Cmp<T2>.Instance, cmp3, cmp4, Cmp<T5>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4) where T1 : IComparable<T1> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5>(Cmp<T1>.Instance, cmp2, cmp3, cmp4, Cmp<T5>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4) where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5>(cmp1, cmp2, cmp3, cmp4, Cmp<T5>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4>
            {
                return new Comparer<T1, T2, T3, T4, T5>(Cmp<T1>.Instance, Cmp<T2>.Instance, Cmp<T3>.Instance, Cmp<T4>.Instance, cmp5);
            }
            internal static Comparer<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T5> cmp5) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4>
            {
                return new Comparer<T1, T2, T3, T4, T5>(cmp1, Cmp<T2>.Instance, Cmp<T3>.Instance, Cmp<T4>.Instance, cmp5);
            }
            internal static Comparer<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(IComparer<T2> cmp2, IComparer<T5> cmp5) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4>
            {
                return new Comparer<T1, T2, T3, T4, T5>(Cmp<T1>.Instance, cmp2, Cmp<T3>.Instance, Cmp<T4>.Instance, cmp5);
            }
            internal static Comparer<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T5> cmp5) where T3 : IComparable<T3> where T4 : IComparable<T4>
            {
                return new Comparer<T1, T2, T3, T4, T5>(cmp1, cmp2, Cmp<T3>.Instance, Cmp<T4>.Instance, cmp5);
            }
            internal static Comparer<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(IComparer<T3> cmp3, IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4>
            {
                return new Comparer<T1, T2, T3, T4, T5>(Cmp<T1>.Instance, Cmp<T2>.Instance, cmp3, Cmp<T4>.Instance, cmp5);
            }
            internal static Comparer<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T5> cmp5) where T2 : IComparable<T2> where T4 : IComparable<T4>
            {
                return new Comparer<T1, T2, T3, T4, T5>(cmp1, Cmp<T2>.Instance, cmp3, Cmp<T4>.Instance, cmp5);
            }
            internal static Comparer<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5) where T1 : IComparable<T1> where T4 : IComparable<T4>
            {
                return new Comparer<T1, T2, T3, T4, T5>(Cmp<T1>.Instance, cmp2, cmp3, Cmp<T4>.Instance, cmp5);
            }
            internal static Comparer<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5) where T4 : IComparable<T4>
            {
                return new Comparer<T1, T2, T3, T4, T5>(cmp1, cmp2, cmp3, Cmp<T4>.Instance, cmp5);
            }
            internal static Comparer<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3>
            {
                return new Comparer<T1, T2, T3, T4, T5>(Cmp<T1>.Instance, Cmp<T2>.Instance, Cmp<T3>.Instance, cmp4, cmp5);
            }
            internal static Comparer<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T4> cmp4, IComparer<T5> cmp5) where T2 : IComparable<T2> where T3 : IComparable<T3>
            {
                return new Comparer<T1, T2, T3, T4, T5>(cmp1, Cmp<T2>.Instance, Cmp<T3>.Instance, cmp4, cmp5);
            }
            internal static Comparer<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1> where T3 : IComparable<T3>
            {
                return new Comparer<T1, T2, T3, T4, T5>(Cmp<T1>.Instance, cmp2, Cmp<T3>.Instance, cmp4, cmp5);
            }
            internal static Comparer<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5) where T3 : IComparable<T3>
            {
                return new Comparer<T1, T2, T3, T4, T5>(cmp1, cmp2, Cmp<T3>.Instance, cmp4, cmp5);
            }
            internal static Comparer<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2>
            {
                return new Comparer<T1, T2, T3, T4, T5>(Cmp<T1>.Instance, Cmp<T2>.Instance, cmp3, cmp4, cmp5);
            }
            internal static Comparer<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5) where T2 : IComparable<T2>
            {
                return new Comparer<T1, T2, T3, T4, T5>(cmp1, Cmp<T2>.Instance, cmp3, cmp4, cmp5);
            }
            internal static Comparer<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1>
            {
                return new Comparer<T1, T2, T3, T4, T5>(Cmp<T1>.Instance, cmp2, cmp3, cmp4, cmp5);
            }
            internal static Comparer<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5)
            {
                return new Comparer<T1, T2, T3, T4, T5>(cmp1, cmp2, cmp3, cmp4, cmp5);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>() where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(Cmp<T1>.Instance, Cmp<T2>.Instance, Cmp<T3>.Instance, Cmp<T4>.Instance, Cmp<T5>.Instance, Cmp<T6>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(cmp1, Cmp<T2>.Instance, Cmp<T3>.Instance, Cmp<T4>.Instance, Cmp<T5>.Instance, Cmp<T6>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(Cmp<T1>.Instance, cmp2, Cmp<T3>.Instance, Cmp<T4>.Instance, Cmp<T5>.Instance, Cmp<T6>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2) where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, Cmp<T3>.Instance, Cmp<T4>.Instance, Cmp<T5>.Instance, Cmp<T6>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T3> cmp3) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(Cmp<T1>.Instance, Cmp<T2>.Instance, cmp3, Cmp<T4>.Instance, Cmp<T5>.Instance, Cmp<T6>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T3> cmp3) where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(cmp1, Cmp<T2>.Instance, cmp3, Cmp<T4>.Instance, Cmp<T5>.Instance, Cmp<T6>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T3> cmp3) where T1 : IComparable<T1> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(Cmp<T1>.Instance, cmp2, cmp3, Cmp<T4>.Instance, Cmp<T5>.Instance, Cmp<T6>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3) where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp3, Cmp<T4>.Instance, Cmp<T5>.Instance, Cmp<T6>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T4> cmp4) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(Cmp<T1>.Instance, Cmp<T2>.Instance, Cmp<T3>.Instance, cmp4, Cmp<T5>.Instance, Cmp<T6>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T4> cmp4) where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(cmp1, Cmp<T2>.Instance, Cmp<T3>.Instance, cmp4, Cmp<T5>.Instance, Cmp<T6>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T4> cmp4) where T1 : IComparable<T1> where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(Cmp<T1>.Instance, cmp2, Cmp<T3>.Instance, cmp4, Cmp<T5>.Instance, Cmp<T6>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4) where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, Cmp<T3>.Instance, cmp4, Cmp<T5>.Instance, Cmp<T6>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T3> cmp3, IComparer<T4> cmp4) where T1 : IComparable<T1> where T2 : IComparable<T2> where T5 : IComparable<T5> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(Cmp<T1>.Instance, Cmp<T2>.Instance, cmp3, cmp4, Cmp<T5>.Instance, Cmp<T6>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4) where T2 : IComparable<T2> where T5 : IComparable<T5> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(cmp1, Cmp<T2>.Instance, cmp3, cmp4, Cmp<T5>.Instance, Cmp<T6>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4) where T1 : IComparable<T1> where T5 : IComparable<T5> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(Cmp<T1>.Instance, cmp2, cmp3, cmp4, Cmp<T5>.Instance, Cmp<T6>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4) where T5 : IComparable<T5> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp3, cmp4, Cmp<T5>.Instance, Cmp<T6>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(Cmp<T1>.Instance, Cmp<T2>.Instance, Cmp<T3>.Instance, Cmp<T4>.Instance, cmp5, Cmp<T6>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T5> cmp5) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(cmp1, Cmp<T2>.Instance, Cmp<T3>.Instance, Cmp<T4>.Instance, cmp5, Cmp<T6>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T5> cmp5) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(Cmp<T1>.Instance, cmp2, Cmp<T3>.Instance, Cmp<T4>.Instance, cmp5, Cmp<T6>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T5> cmp5) where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, Cmp<T3>.Instance, Cmp<T4>.Instance, cmp5, Cmp<T6>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T3> cmp3, IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(Cmp<T1>.Instance, Cmp<T2>.Instance, cmp3, Cmp<T4>.Instance, cmp5, Cmp<T6>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T5> cmp5) where T2 : IComparable<T2> where T4 : IComparable<T4> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(cmp1, Cmp<T2>.Instance, cmp3, Cmp<T4>.Instance, cmp5, Cmp<T6>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5) where T1 : IComparable<T1> where T4 : IComparable<T4> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(Cmp<T1>.Instance, cmp2, cmp3, Cmp<T4>.Instance, cmp5, Cmp<T6>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5) where T4 : IComparable<T4> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp3, Cmp<T4>.Instance, cmp5, Cmp<T6>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(Cmp<T1>.Instance, Cmp<T2>.Instance, Cmp<T3>.Instance, cmp4, cmp5, Cmp<T6>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T4> cmp4, IComparer<T5> cmp5) where T2 : IComparable<T2> where T3 : IComparable<T3> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(cmp1, Cmp<T2>.Instance, Cmp<T3>.Instance, cmp4, cmp5, Cmp<T6>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1> where T3 : IComparable<T3> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(Cmp<T1>.Instance, cmp2, Cmp<T3>.Instance, cmp4, cmp5, Cmp<T6>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5) where T3 : IComparable<T3> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, Cmp<T3>.Instance, cmp4, cmp5, Cmp<T6>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(Cmp<T1>.Instance, Cmp<T2>.Instance, cmp3, cmp4, cmp5, Cmp<T6>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5) where T2 : IComparable<T2> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(cmp1, Cmp<T2>.Instance, cmp3, cmp4, cmp5, Cmp<T6>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(Cmp<T1>.Instance, cmp2, cmp3, cmp4, cmp5, Cmp<T6>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5) where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp3, cmp4, cmp5, Cmp<T6>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(Cmp<T1>.Instance, Cmp<T2>.Instance, Cmp<T3>.Instance, Cmp<T4>.Instance, Cmp<T5>.Instance, cmp6);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T6> cmp6) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(cmp1, Cmp<T2>.Instance, Cmp<T3>.Instance, Cmp<T4>.Instance, Cmp<T5>.Instance, cmp6);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T6> cmp6) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(Cmp<T1>.Instance, cmp2, Cmp<T3>.Instance, Cmp<T4>.Instance, Cmp<T5>.Instance, cmp6);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T6> cmp6) where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, Cmp<T3>.Instance, Cmp<T4>.Instance, Cmp<T5>.Instance, cmp6);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T3> cmp3, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(Cmp<T1>.Instance, Cmp<T2>.Instance, cmp3, Cmp<T4>.Instance, Cmp<T5>.Instance, cmp6);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T6> cmp6) where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(cmp1, Cmp<T2>.Instance, cmp3, Cmp<T4>.Instance, Cmp<T5>.Instance, cmp6);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T6> cmp6) where T1 : IComparable<T1> where T4 : IComparable<T4> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(Cmp<T1>.Instance, cmp2, cmp3, Cmp<T4>.Instance, Cmp<T5>.Instance, cmp6);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T6> cmp6) where T4 : IComparable<T4> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp3, Cmp<T4>.Instance, Cmp<T5>.Instance, cmp6);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T4> cmp4, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(Cmp<T1>.Instance, Cmp<T2>.Instance, Cmp<T3>.Instance, cmp4, Cmp<T5>.Instance, cmp6);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T4> cmp4, IComparer<T6> cmp6) where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(cmp1, Cmp<T2>.Instance, Cmp<T3>.Instance, cmp4, Cmp<T5>.Instance, cmp6);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T6> cmp6) where T1 : IComparable<T1> where T3 : IComparable<T3> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(Cmp<T1>.Instance, cmp2, Cmp<T3>.Instance, cmp4, Cmp<T5>.Instance, cmp6);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T6> cmp6) where T3 : IComparable<T3> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, Cmp<T3>.Instance, cmp4, Cmp<T5>.Instance, cmp6);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(Cmp<T1>.Instance, Cmp<T2>.Instance, cmp3, cmp4, Cmp<T5>.Instance, cmp6);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6) where T2 : IComparable<T2> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(cmp1, Cmp<T2>.Instance, cmp3, cmp4, Cmp<T5>.Instance, cmp6);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6) where T1 : IComparable<T1> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(Cmp<T1>.Instance, cmp2, cmp3, cmp4, Cmp<T5>.Instance, cmp6);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6) where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp3, cmp4, Cmp<T5>.Instance, cmp6);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(Cmp<T1>.Instance, Cmp<T2>.Instance, Cmp<T3>.Instance, Cmp<T4>.Instance, cmp5, cmp6);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T5> cmp5, IComparer<T6> cmp6) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(cmp1, Cmp<T2>.Instance, Cmp<T3>.Instance, Cmp<T4>.Instance, cmp5, cmp6);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(Cmp<T1>.Instance, cmp2, Cmp<T3>.Instance, Cmp<T4>.Instance, cmp5, cmp6);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T5> cmp5, IComparer<T6> cmp6) where T3 : IComparable<T3> where T4 : IComparable<T4>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, Cmp<T3>.Instance, Cmp<T4>.Instance, cmp5, cmp6);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(Cmp<T1>.Instance, Cmp<T2>.Instance, cmp3, Cmp<T4>.Instance, cmp5, cmp6);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6) where T2 : IComparable<T2> where T4 : IComparable<T4>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(cmp1, Cmp<T2>.Instance, cmp3, Cmp<T4>.Instance, cmp5, cmp6);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T4 : IComparable<T4>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(Cmp<T1>.Instance, cmp2, cmp3, Cmp<T4>.Instance, cmp5, cmp6);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6) where T4 : IComparable<T4>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp3, Cmp<T4>.Instance, cmp5, cmp6);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(Cmp<T1>.Instance, Cmp<T2>.Instance, Cmp<T3>.Instance, cmp4, cmp5, cmp6);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T2 : IComparable<T2> where T3 : IComparable<T3>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(cmp1, Cmp<T2>.Instance, Cmp<T3>.Instance, cmp4, cmp5, cmp6);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T3 : IComparable<T3>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(Cmp<T1>.Instance, cmp2, Cmp<T3>.Instance, cmp4, cmp5, cmp6);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T3 : IComparable<T3>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, Cmp<T3>.Instance, cmp4, cmp5, cmp6);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(Cmp<T1>.Instance, Cmp<T2>.Instance, cmp3, cmp4, cmp5, cmp6);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T2 : IComparable<T2>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(cmp1, Cmp<T2>.Instance, cmp3, cmp4, cmp5, cmp6);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(Cmp<T1>.Instance, cmp2, cmp3, cmp4, cmp5, cmp6);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6)
            {
                return new Comparer<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp3, cmp4, cmp5, cmp6);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>() where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, Cmp<T2>.Instance, Cmp<T3>.Instance, Cmp<T4>.Instance, Cmp<T5>.Instance, Cmp<T6>.Instance, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, Cmp<T2>.Instance, Cmp<T3>.Instance, Cmp<T4>.Instance, Cmp<T5>.Instance, Cmp<T6>.Instance, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, cmp2, Cmp<T3>.Instance, Cmp<T4>.Instance, Cmp<T5>.Instance, Cmp<T6>.Instance, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2) where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, Cmp<T3>.Instance, Cmp<T4>.Instance, Cmp<T5>.Instance, Cmp<T6>.Instance, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, Cmp<T2>.Instance, cmp3, Cmp<T4>.Instance, Cmp<T5>.Instance, Cmp<T6>.Instance, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3) where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, Cmp<T2>.Instance, cmp3, Cmp<T4>.Instance, Cmp<T5>.Instance, Cmp<T6>.Instance, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3) where T1 : IComparable<T1> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, cmp2, cmp3, Cmp<T4>.Instance, Cmp<T5>.Instance, Cmp<T6>.Instance, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3) where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, Cmp<T4>.Instance, Cmp<T5>.Instance, Cmp<T6>.Instance, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T4> cmp4) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, Cmp<T2>.Instance, Cmp<T3>.Instance, cmp4, Cmp<T5>.Instance, Cmp<T6>.Instance, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T4> cmp4) where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, Cmp<T2>.Instance, Cmp<T3>.Instance, cmp4, Cmp<T5>.Instance, Cmp<T6>.Instance, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T4> cmp4) where T1 : IComparable<T1> where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, cmp2, Cmp<T3>.Instance, cmp4, Cmp<T5>.Instance, Cmp<T6>.Instance, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4) where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, Cmp<T3>.Instance, cmp4, Cmp<T5>.Instance, Cmp<T6>.Instance, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T4> cmp4) where T1 : IComparable<T1> where T2 : IComparable<T2> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, Cmp<T2>.Instance, cmp3, cmp4, Cmp<T5>.Instance, Cmp<T6>.Instance, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4) where T2 : IComparable<T2> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, Cmp<T2>.Instance, cmp3, cmp4, Cmp<T5>.Instance, Cmp<T6>.Instance, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4) where T1 : IComparable<T1> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, cmp2, cmp3, cmp4, Cmp<T5>.Instance, Cmp<T6>.Instance, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4) where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp4, Cmp<T5>.Instance, Cmp<T6>.Instance, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, Cmp<T2>.Instance, Cmp<T3>.Instance, Cmp<T4>.Instance, cmp5, Cmp<T6>.Instance, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T5> cmp5) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, Cmp<T2>.Instance, Cmp<T3>.Instance, Cmp<T4>.Instance, cmp5, Cmp<T6>.Instance, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T5> cmp5) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, cmp2, Cmp<T3>.Instance, Cmp<T4>.Instance, cmp5, Cmp<T6>.Instance, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T5> cmp5) where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, Cmp<T3>.Instance, Cmp<T4>.Instance, cmp5, Cmp<T6>.Instance, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4> where T6 : IComparable<T6> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, Cmp<T2>.Instance, cmp3, Cmp<T4>.Instance, cmp5, Cmp<T6>.Instance, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T5> cmp5) where T2 : IComparable<T2> where T4 : IComparable<T4> where T6 : IComparable<T6> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, Cmp<T2>.Instance, cmp3, Cmp<T4>.Instance, cmp5, Cmp<T6>.Instance, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5) where T1 : IComparable<T1> where T4 : IComparable<T4> where T6 : IComparable<T6> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, cmp2, cmp3, Cmp<T4>.Instance, cmp5, Cmp<T6>.Instance, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5) where T4 : IComparable<T4> where T6 : IComparable<T6> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, Cmp<T4>.Instance, cmp5, Cmp<T6>.Instance, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T6 : IComparable<T6> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, Cmp<T2>.Instance, Cmp<T3>.Instance, cmp4, cmp5, Cmp<T6>.Instance, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T4> cmp4, IComparer<T5> cmp5) where T2 : IComparable<T2> where T3 : IComparable<T3> where T6 : IComparable<T6> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, Cmp<T2>.Instance, Cmp<T3>.Instance, cmp4, cmp5, Cmp<T6>.Instance, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1> where T3 : IComparable<T3> where T6 : IComparable<T6> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, cmp2, Cmp<T3>.Instance, cmp4, cmp5, Cmp<T6>.Instance, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5) where T3 : IComparable<T3> where T6 : IComparable<T6> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, Cmp<T3>.Instance, cmp4, cmp5, Cmp<T6>.Instance, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2> where T6 : IComparable<T6> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, Cmp<T2>.Instance, cmp3, cmp4, cmp5, Cmp<T6>.Instance, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5) where T2 : IComparable<T2> where T6 : IComparable<T6> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, Cmp<T2>.Instance, cmp3, cmp4, cmp5, Cmp<T6>.Instance, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1> where T6 : IComparable<T6> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, cmp2, cmp3, cmp4, cmp5, Cmp<T6>.Instance, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5) where T6 : IComparable<T6> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp4, cmp5, Cmp<T6>.Instance, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, Cmp<T2>.Instance, Cmp<T3>.Instance, Cmp<T4>.Instance, Cmp<T5>.Instance, cmp6, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T6> cmp6) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, Cmp<T2>.Instance, Cmp<T3>.Instance, Cmp<T4>.Instance, Cmp<T5>.Instance, cmp6, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T6> cmp6) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, cmp2, Cmp<T3>.Instance, Cmp<T4>.Instance, Cmp<T5>.Instance, cmp6, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T6> cmp6) where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, Cmp<T3>.Instance, Cmp<T4>.Instance, Cmp<T5>.Instance, cmp6, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, Cmp<T2>.Instance, cmp3, Cmp<T4>.Instance, Cmp<T5>.Instance, cmp6, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T6> cmp6) where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, Cmp<T2>.Instance, cmp3, Cmp<T4>.Instance, Cmp<T5>.Instance, cmp6, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T6> cmp6) where T1 : IComparable<T1> where T4 : IComparable<T4> where T5 : IComparable<T5> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, cmp2, cmp3, Cmp<T4>.Instance, Cmp<T5>.Instance, cmp6, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T6> cmp6) where T4 : IComparable<T4> where T5 : IComparable<T5> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, Cmp<T4>.Instance, Cmp<T5>.Instance, cmp6, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T4> cmp4, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, Cmp<T2>.Instance, Cmp<T3>.Instance, cmp4, Cmp<T5>.Instance, cmp6, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T4> cmp4, IComparer<T6> cmp6) where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, Cmp<T2>.Instance, Cmp<T3>.Instance, cmp4, Cmp<T5>.Instance, cmp6, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T6> cmp6) where T1 : IComparable<T1> where T3 : IComparable<T3> where T5 : IComparable<T5> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, cmp2, Cmp<T3>.Instance, cmp4, Cmp<T5>.Instance, cmp6, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T6> cmp6) where T3 : IComparable<T3> where T5 : IComparable<T5> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, Cmp<T3>.Instance, cmp4, Cmp<T5>.Instance, cmp6, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T5 : IComparable<T5> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, Cmp<T2>.Instance, cmp3, cmp4, Cmp<T5>.Instance, cmp6, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6) where T2 : IComparable<T2> where T5 : IComparable<T5> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, Cmp<T2>.Instance, cmp3, cmp4, Cmp<T5>.Instance, cmp6, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6) where T1 : IComparable<T1> where T5 : IComparable<T5> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, cmp2, cmp3, cmp4, Cmp<T5>.Instance, cmp6, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6) where T5 : IComparable<T5> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp4, Cmp<T5>.Instance, cmp6, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, Cmp<T2>.Instance, Cmp<T3>.Instance, Cmp<T4>.Instance, cmp5, cmp6, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T5> cmp5, IComparer<T6> cmp6) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, Cmp<T2>.Instance, Cmp<T3>.Instance, Cmp<T4>.Instance, cmp5, cmp6, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, cmp2, Cmp<T3>.Instance, Cmp<T4>.Instance, cmp5, cmp6, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T5> cmp5, IComparer<T6> cmp6) where T3 : IComparable<T3> where T4 : IComparable<T4> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, Cmp<T3>.Instance, Cmp<T4>.Instance, cmp5, cmp6, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, Cmp<T2>.Instance, cmp3, Cmp<T4>.Instance, cmp5, cmp6, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6) where T2 : IComparable<T2> where T4 : IComparable<T4> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, Cmp<T2>.Instance, cmp3, Cmp<T4>.Instance, cmp5, cmp6, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T4 : IComparable<T4> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, cmp2, cmp3, Cmp<T4>.Instance, cmp5, cmp6, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6) where T4 : IComparable<T4> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, Cmp<T4>.Instance, cmp5, cmp6, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, Cmp<T2>.Instance, Cmp<T3>.Instance, cmp4, cmp5, cmp6, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T2 : IComparable<T2> where T3 : IComparable<T3> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, Cmp<T2>.Instance, Cmp<T3>.Instance, cmp4, cmp5, cmp6, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T3 : IComparable<T3> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, cmp2, Cmp<T3>.Instance, cmp4, cmp5, cmp6, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T3 : IComparable<T3> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, Cmp<T3>.Instance, cmp4, cmp5, cmp6, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, Cmp<T2>.Instance, cmp3, cmp4, cmp5, cmp6, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T2 : IComparable<T2> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, Cmp<T2>.Instance, cmp3, cmp4, cmp5, cmp6, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, cmp2, cmp3, cmp4, cmp5, cmp6, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T7 : IComparable<T7>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp4, cmp5, cmp6, Cmp<T7>.Instance);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, Cmp<T2>.Instance, Cmp<T3>.Instance, Cmp<T4>.Instance, Cmp<T5>.Instance, Cmp<T6>.Instance, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T7> cmp7) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, Cmp<T2>.Instance, Cmp<T3>.Instance, Cmp<T4>.Instance, Cmp<T5>.Instance, Cmp<T6>.Instance, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T7> cmp7) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, cmp2, Cmp<T3>.Instance, Cmp<T4>.Instance, Cmp<T5>.Instance, Cmp<T6>.Instance, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T7> cmp7) where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, Cmp<T3>.Instance, Cmp<T4>.Instance, Cmp<T5>.Instance, Cmp<T6>.Instance, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, Cmp<T2>.Instance, cmp3, Cmp<T4>.Instance, Cmp<T5>.Instance, Cmp<T6>.Instance, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T7> cmp7) where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, Cmp<T2>.Instance, cmp3, Cmp<T4>.Instance, Cmp<T5>.Instance, Cmp<T6>.Instance, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T7> cmp7) where T1 : IComparable<T1> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, cmp2, cmp3, Cmp<T4>.Instance, Cmp<T5>.Instance, Cmp<T6>.Instance, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T7> cmp7) where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, Cmp<T4>.Instance, Cmp<T5>.Instance, Cmp<T6>.Instance, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T4> cmp4, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, Cmp<T2>.Instance, Cmp<T3>.Instance, cmp4, Cmp<T5>.Instance, Cmp<T6>.Instance, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T4> cmp4, IComparer<T7> cmp7) where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, Cmp<T2>.Instance, Cmp<T3>.Instance, cmp4, Cmp<T5>.Instance, Cmp<T6>.Instance, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T7> cmp7) where T1 : IComparable<T1> where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, cmp2, Cmp<T3>.Instance, cmp4, Cmp<T5>.Instance, Cmp<T6>.Instance, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T7> cmp7) where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, Cmp<T3>.Instance, cmp4, Cmp<T5>.Instance, Cmp<T6>.Instance, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T5 : IComparable<T5> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, Cmp<T2>.Instance, cmp3, cmp4, Cmp<T5>.Instance, Cmp<T6>.Instance, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T7> cmp7) where T2 : IComparable<T2> where T5 : IComparable<T5> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, Cmp<T2>.Instance, cmp3, cmp4, Cmp<T5>.Instance, Cmp<T6>.Instance, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T7> cmp7) where T1 : IComparable<T1> where T5 : IComparable<T5> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, cmp2, cmp3, cmp4, Cmp<T5>.Instance, Cmp<T6>.Instance, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T7> cmp7) where T5 : IComparable<T5> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp4, Cmp<T5>.Instance, Cmp<T6>.Instance, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T5> cmp5, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, Cmp<T2>.Instance, Cmp<T3>.Instance, Cmp<T4>.Instance, cmp5, Cmp<T6>.Instance, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T5> cmp5, IComparer<T7> cmp7) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, Cmp<T2>.Instance, Cmp<T3>.Instance, Cmp<T4>.Instance, cmp5, Cmp<T6>.Instance, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T5> cmp5, IComparer<T7> cmp7) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, cmp2, Cmp<T3>.Instance, Cmp<T4>.Instance, cmp5, Cmp<T6>.Instance, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T5> cmp5, IComparer<T7> cmp7) where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, Cmp<T3>.Instance, Cmp<T4>.Instance, cmp5, Cmp<T6>.Instance, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, Cmp<T2>.Instance, cmp3, Cmp<T4>.Instance, cmp5, Cmp<T6>.Instance, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T7> cmp7) where T2 : IComparable<T2> where T4 : IComparable<T4> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, Cmp<T2>.Instance, cmp3, Cmp<T4>.Instance, cmp5, Cmp<T6>.Instance, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T7> cmp7) where T1 : IComparable<T1> where T4 : IComparable<T4> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, cmp2, cmp3, Cmp<T4>.Instance, cmp5, Cmp<T6>.Instance, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T7> cmp7) where T4 : IComparable<T4> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, Cmp<T4>.Instance, cmp5, Cmp<T6>.Instance, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, Cmp<T2>.Instance, Cmp<T3>.Instance, cmp4, cmp5, Cmp<T6>.Instance, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T7> cmp7) where T2 : IComparable<T2> where T3 : IComparable<T3> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, Cmp<T2>.Instance, Cmp<T3>.Instance, cmp4, cmp5, Cmp<T6>.Instance, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T7> cmp7) where T1 : IComparable<T1> where T3 : IComparable<T3> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, cmp2, Cmp<T3>.Instance, cmp4, cmp5, Cmp<T6>.Instance, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T7> cmp7) where T3 : IComparable<T3> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, Cmp<T3>.Instance, cmp4, cmp5, Cmp<T6>.Instance, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, Cmp<T2>.Instance, cmp3, cmp4, cmp5, Cmp<T6>.Instance, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T7> cmp7) where T2 : IComparable<T2> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, Cmp<T2>.Instance, cmp3, cmp4, cmp5, Cmp<T6>.Instance, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T7> cmp7) where T1 : IComparable<T1> where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, cmp2, cmp3, cmp4, cmp5, Cmp<T6>.Instance, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T7> cmp7) where T6 : IComparable<T6>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp4, cmp5, Cmp<T6>.Instance, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, Cmp<T2>.Instance, Cmp<T3>.Instance, Cmp<T4>.Instance, Cmp<T5>.Instance, cmp6, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T6> cmp6, IComparer<T7> cmp7) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, Cmp<T2>.Instance, Cmp<T3>.Instance, Cmp<T4>.Instance, Cmp<T5>.Instance, cmp6, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, cmp2, Cmp<T3>.Instance, Cmp<T4>.Instance, Cmp<T5>.Instance, cmp6, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T6> cmp6, IComparer<T7> cmp7) where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, Cmp<T3>.Instance, Cmp<T4>.Instance, Cmp<T5>.Instance, cmp6, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, Cmp<T2>.Instance, cmp3, Cmp<T4>.Instance, Cmp<T5>.Instance, cmp6, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T6> cmp6, IComparer<T7> cmp7) where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, Cmp<T2>.Instance, cmp3, Cmp<T4>.Instance, Cmp<T5>.Instance, cmp6, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T4 : IComparable<T4> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, cmp2, cmp3, Cmp<T4>.Instance, Cmp<T5>.Instance, cmp6, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T6> cmp6, IComparer<T7> cmp7) where T4 : IComparable<T4> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, Cmp<T4>.Instance, Cmp<T5>.Instance, cmp6, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T4> cmp4, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, Cmp<T2>.Instance, Cmp<T3>.Instance, cmp4, Cmp<T5>.Instance, cmp6, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T4> cmp4, IComparer<T6> cmp6, IComparer<T7> cmp7) where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, Cmp<T2>.Instance, Cmp<T3>.Instance, cmp4, Cmp<T5>.Instance, cmp6, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T3 : IComparable<T3> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, cmp2, Cmp<T3>.Instance, cmp4, Cmp<T5>.Instance, cmp6, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T6> cmp6, IComparer<T7> cmp7) where T3 : IComparable<T3> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, Cmp<T3>.Instance, cmp4, Cmp<T5>.Instance, cmp6, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, Cmp<T2>.Instance, cmp3, cmp4, Cmp<T5>.Instance, cmp6, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6, IComparer<T7> cmp7) where T2 : IComparable<T2> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, Cmp<T2>.Instance, cmp3, cmp4, Cmp<T5>.Instance, cmp6, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, cmp2, cmp3, cmp4, Cmp<T5>.Instance, cmp6, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6, IComparer<T7> cmp7) where T5 : IComparable<T5>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp4, Cmp<T5>.Instance, cmp6, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, Cmp<T2>.Instance, Cmp<T3>.Instance, Cmp<T4>.Instance, cmp5, cmp6, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, Cmp<T2>.Instance, Cmp<T3>.Instance, Cmp<T4>.Instance, cmp5, cmp6, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, cmp2, Cmp<T3>.Instance, Cmp<T4>.Instance, cmp5, cmp6, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T3 : IComparable<T3> where T4 : IComparable<T4>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, Cmp<T3>.Instance, Cmp<T4>.Instance, cmp5, cmp6, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, Cmp<T2>.Instance, cmp3, Cmp<T4>.Instance, cmp5, cmp6, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T2 : IComparable<T2> where T4 : IComparable<T4>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, Cmp<T2>.Instance, cmp3, Cmp<T4>.Instance, cmp5, cmp6, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T4 : IComparable<T4>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, cmp2, cmp3, Cmp<T4>.Instance, cmp5, cmp6, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T4 : IComparable<T4>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, Cmp<T4>.Instance, cmp5, cmp6, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, Cmp<T2>.Instance, Cmp<T3>.Instance, cmp4, cmp5, cmp6, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T2 : IComparable<T2> where T3 : IComparable<T3>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, Cmp<T2>.Instance, Cmp<T3>.Instance, cmp4, cmp5, cmp6, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T3 : IComparable<T3>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, cmp2, Cmp<T3>.Instance, cmp4, cmp5, cmp6, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T3 : IComparable<T3>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, Cmp<T3>.Instance, cmp4, cmp5, cmp6, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, Cmp<T2>.Instance, cmp3, cmp4, cmp5, cmp6, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T2 : IComparable<T2>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, Cmp<T2>.Instance, cmp3, cmp4, cmp5, cmp6, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1>
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(Cmp<T1>.Instance, cmp2, cmp3, cmp4, cmp5, cmp6, cmp7);
            }
            internal static Comparer<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7)
            {
                return new Comparer<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp4, cmp5, cmp6, cmp7);
            }
        }

        class Comparer<T1, T2> : IComparer<Tuple<T1, T2>>
        {
            readonly IComparer<T1> cmp1;
            readonly IComparer<T2> cmp2;
            internal Comparer(IComparer<T1> cmp1, IComparer<T2> cmp2)
            {
                this.cmp1 = cmp1;
                this.cmp2 = cmp2;
            }

            public int Compare(Tuple<T1, T2> x, Tuple<T1, T2> y)
            {
                return
                    x.Match((x1, x2) =>
                        y.Match((y1, y2) =>
                        {
                            var res1 = cmp1.Compare(x1, y1); if (res1 != 0) return res1;
                            var res2 = cmp2.Compare(x2, y2); if (res2 != 0) return res2;
                            return 0;
                        }));
            }
        }
        class Comparer<T1, T2, T3> : IComparer<Tuple<T1, T2, T3>>
        {
            readonly IComparer<T1> cmp1;
            readonly IComparer<T2> cmp2;
            readonly IComparer<T3> cmp3;
            internal Comparer(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3)
            {
                this.cmp1 = cmp1;
                this.cmp2 = cmp2;
                this.cmp3 = cmp3;
            }

            public int Compare(Tuple<T1, T2, T3> x, Tuple<T1, T2, T3> y)
            {
                return
                    x.Match((x1, x2, x3) =>
                        y.Match((y1, y2, y3) =>
                        {
                            var res1 = cmp1.Compare(x1, y1); if (res1 != 0) return res1;
                            var res2 = cmp2.Compare(x2, y2); if (res2 != 0) return res2;
                            var res3 = cmp3.Compare(x3, y3); if (res3 != 0) return res3;
                            return 0;
                        }));
            }
        }
        class Comparer<T1, T2, T3, T4> : IComparer<Tuple<T1, T2, T3, T4>>
        {
            readonly IComparer<T1> cmp1;
            readonly IComparer<T2> cmp2;
            readonly IComparer<T3> cmp3;
            readonly IComparer<T4> cmp4;
            internal Comparer(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4)
            {
                this.cmp1 = cmp1;
                this.cmp2 = cmp2;
                this.cmp3 = cmp3;
                this.cmp4 = cmp4;
            }

            public int Compare(Tuple<T1, T2, T3, T4> x, Tuple<T1, T2, T3, T4> y)
            {
                return
                    x.Match((x1, x2, x3, x4) =>
                        y.Match((y1, y2, y3, y4) =>
                        {
                            var res1 = cmp1.Compare(x1, y1); if (res1 != 0) return res1;
                            var res2 = cmp2.Compare(x2, y2); if (res2 != 0) return res2;
                            var res3 = cmp3.Compare(x3, y3); if (res3 != 0) return res3;
                            var res4 = cmp4.Compare(x4, y4); if (res4 != 0) return res4;
                            return 0;
                        }));
            }
        }
        class Comparer<T1, T2, T3, T4, T5> : IComparer<Tuple<T1, T2, T3, T4, T5>>
        {
            readonly IComparer<T1> cmp1;
            readonly IComparer<T2> cmp2;
            readonly IComparer<T3> cmp3;
            readonly IComparer<T4> cmp4;
            readonly IComparer<T5> cmp5;
            internal Comparer(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5)
            {
                this.cmp1 = cmp1;
                this.cmp2 = cmp2;
                this.cmp3 = cmp3;
                this.cmp4 = cmp4;
                this.cmp5 = cmp5;
            }

            public int Compare(Tuple<T1, T2, T3, T4, T5> x, Tuple<T1, T2, T3, T4, T5> y)
            {
                return
                    x.Match((x1, x2, x3, x4, x5) =>
                        y.Match((y1, y2, y3, y4, y5) =>
                        {
                            var res1 = cmp1.Compare(x1, y1); if (res1 != 0) return res1;
                            var res2 = cmp2.Compare(x2, y2); if (res2 != 0) return res2;
                            var res3 = cmp3.Compare(x3, y3); if (res3 != 0) return res3;
                            var res4 = cmp4.Compare(x4, y4); if (res4 != 0) return res4;
                            var res5 = cmp5.Compare(x5, y5); if (res5 != 0) return res5;
                            return 0;
                        }));
            }
        }
        class Comparer<T1, T2, T3, T4, T5, T6> : IComparer<Tuple<T1, T2, T3, T4, T5, T6>>
        {
            readonly IComparer<T1> cmp1;
            readonly IComparer<T2> cmp2;
            readonly IComparer<T3> cmp3;
            readonly IComparer<T4> cmp4;
            readonly IComparer<T5> cmp5;
            readonly IComparer<T6> cmp6;
            internal Comparer(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6)
            {
                this.cmp1 = cmp1;
                this.cmp2 = cmp2;
                this.cmp3 = cmp3;
                this.cmp4 = cmp4;
                this.cmp5 = cmp5;
                this.cmp6 = cmp6;
            }

            public int Compare(Tuple<T1, T2, T3, T4, T5, T6> x, Tuple<T1, T2, T3, T4, T5, T6> y)
            {
                return
                    x.Match((x1, x2, x3, x4, x5, x6) =>
                        y.Match((y1, y2, y3, y4, y5, y6) =>
                        {
                            var res1 = cmp1.Compare(x1, y1); if (res1 != 0) return res1;
                            var res2 = cmp2.Compare(x2, y2); if (res2 != 0) return res2;
                            var res3 = cmp3.Compare(x3, y3); if (res3 != 0) return res3;
                            var res4 = cmp4.Compare(x4, y4); if (res4 != 0) return res4;
                            var res5 = cmp5.Compare(x5, y5); if (res5 != 0) return res5;
                            var res6 = cmp6.Compare(x6, y6); if (res6 != 0) return res6;
                            return 0;
                        }));
            }
        }
        class Comparer<T1, T2, T3, T4, T5, T6, T7> : IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>>
        {
            readonly IComparer<T1> cmp1;
            readonly IComparer<T2> cmp2;
            readonly IComparer<T3> cmp3;
            readonly IComparer<T4> cmp4;
            readonly IComparer<T5> cmp5;
            readonly IComparer<T6> cmp6;
            readonly IComparer<T7> cmp7;
            internal Comparer(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7)
            {
                this.cmp1 = cmp1;
                this.cmp2 = cmp2;
                this.cmp3 = cmp3;
                this.cmp4 = cmp4;
                this.cmp5 = cmp5;
                this.cmp6 = cmp6;
                this.cmp7 = cmp7;
            }

            public int Compare(Tuple<T1, T2, T3, T4, T5, T6, T7> x, Tuple<T1, T2, T3, T4, T5, T6, T7> y)
            {
                return
                    x.Match((x1, x2, x3, x4, x5, x6, x7) =>
                        y.Match((y1, y2, y3, y4, y5, y6, y7) =>
                        {
                            var res1 = cmp1.Compare(x1, y1); if (res1 != 0) return res1;
                            var res2 = cmp2.Compare(x2, y2); if (res2 != 0) return res2;
                            var res3 = cmp3.Compare(x3, y3); if (res3 != 0) return res3;
                            var res4 = cmp4.Compare(x4, y4); if (res4 != 0) return res4;
                            var res5 = cmp5.Compare(x5, y5); if (res5 != 0) return res5;
                            var res6 = cmp6.Compare(x6, y6); if (res6 != 0) return res6;
                            var res7 = cmp7.Compare(x7, y7); if (res7 != 0) return res7;
                            return 0;
                        }));
            }
        }
        public static IComparer<Tuple<T1, T2>> Create<T1, T2>() where T1 : IComparable<T1> where T2 : IComparable<T2>
        { return Comparer.Create<T1, T2>(); }
        public static IComparer<Tuple<T1, T2>> Create<T1, T2>(IComparer<T1> cmp1) where T2 : IComparable<T2>
        { return Comparer.Create<T1, T2>(cmp1); }
        public static IComparer<Tuple<T1, T2>> Create<T1, T2>(IComparer<T2> cmp2) where T1 : IComparable<T1>
        { return Comparer.Create<T1, T2>(cmp2); }
        public static IComparer<Tuple<T1, T2>> Create<T1, T2>(IComparer<T1> cmp1, IComparer<T2> cmp2)
        { return Comparer.Create<T1, T2>(cmp1, cmp2); }
        public static IComparer<Tuple<T1, T2, T3>> Create<T1, T2, T3>() where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3>
        { return Comparer.Create<T1, T2, T3>(); }
        public static IComparer<Tuple<T1, T2, T3>> Create<T1, T2, T3>(IComparer<T1> cmp1) where T2 : IComparable<T2> where T3 : IComparable<T3>
        { return Comparer.Create<T1, T2, T3>(cmp1); }
        public static IComparer<Tuple<T1, T2, T3>> Create<T1, T2, T3>(IComparer<T2> cmp2) where T1 : IComparable<T1> where T3 : IComparable<T3>
        { return Comparer.Create<T1, T2, T3>(cmp2); }
        public static IComparer<Tuple<T1, T2, T3>> Create<T1, T2, T3>(IComparer<T1> cmp1, IComparer<T2> cmp2) where T3 : IComparable<T3>
        { return Comparer.Create<T1, T2, T3>(cmp1, cmp2); }
        public static IComparer<Tuple<T1, T2, T3>> Create<T1, T2, T3>(IComparer<T3> cmp3) where T1 : IComparable<T1> where T2 : IComparable<T2>
        { return Comparer.Create<T1, T2, T3>(cmp3); }
        public static IComparer<Tuple<T1, T2, T3>> Create<T1, T2, T3>(IComparer<T1> cmp1, IComparer<T3> cmp3) where T2 : IComparable<T2>
        { return Comparer.Create<T1, T2, T3>(cmp1, cmp3); }
        public static IComparer<Tuple<T1, T2, T3>> Create<T1, T2, T3>(IComparer<T2> cmp2, IComparer<T3> cmp3) where T1 : IComparable<T1>
        { return Comparer.Create<T1, T2, T3>(cmp2, cmp3); }
        public static IComparer<Tuple<T1, T2, T3>> Create<T1, T2, T3>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3)
        { return Comparer.Create<T1, T2, T3>(cmp1, cmp2, cmp3); }
        public static IComparer<Tuple<T1, T2, T3, T4>> Create<T1, T2, T3, T4>() where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4>
        { return Comparer.Create<T1, T2, T3, T4>(); }
        public static IComparer<Tuple<T1, T2, T3, T4>> Create<T1, T2, T3, T4>(IComparer<T1> cmp1) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4>
        { return Comparer.Create<T1, T2, T3, T4>(cmp1); }
        public static IComparer<Tuple<T1, T2, T3, T4>> Create<T1, T2, T3, T4>(IComparer<T2> cmp2) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4>
        { return Comparer.Create<T1, T2, T3, T4>(cmp2); }
        public static IComparer<Tuple<T1, T2, T3, T4>> Create<T1, T2, T3, T4>(IComparer<T1> cmp1, IComparer<T2> cmp2) where T3 : IComparable<T3> where T4 : IComparable<T4>
        { return Comparer.Create<T1, T2, T3, T4>(cmp1, cmp2); }
        public static IComparer<Tuple<T1, T2, T3, T4>> Create<T1, T2, T3, T4>(IComparer<T3> cmp3) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4>
        { return Comparer.Create<T1, T2, T3, T4>(cmp3); }
        public static IComparer<Tuple<T1, T2, T3, T4>> Create<T1, T2, T3, T4>(IComparer<T1> cmp1, IComparer<T3> cmp3) where T2 : IComparable<T2> where T4 : IComparable<T4>
        { return Comparer.Create<T1, T2, T3, T4>(cmp1, cmp3); }
        public static IComparer<Tuple<T1, T2, T3, T4>> Create<T1, T2, T3, T4>(IComparer<T2> cmp2, IComparer<T3> cmp3) where T1 : IComparable<T1> where T4 : IComparable<T4>
        { return Comparer.Create<T1, T2, T3, T4>(cmp2, cmp3); }
        public static IComparer<Tuple<T1, T2, T3, T4>> Create<T1, T2, T3, T4>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3) where T4 : IComparable<T4>
        { return Comparer.Create<T1, T2, T3, T4>(cmp1, cmp2, cmp3); }
        public static IComparer<Tuple<T1, T2, T3, T4>> Create<T1, T2, T3, T4>(IComparer<T4> cmp4) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3>
        { return Comparer.Create<T1, T2, T3, T4>(cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4>> Create<T1, T2, T3, T4>(IComparer<T1> cmp1, IComparer<T4> cmp4) where T2 : IComparable<T2> where T3 : IComparable<T3>
        { return Comparer.Create<T1, T2, T3, T4>(cmp1, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4>> Create<T1, T2, T3, T4>(IComparer<T2> cmp2, IComparer<T4> cmp4) where T1 : IComparable<T1> where T3 : IComparable<T3>
        { return Comparer.Create<T1, T2, T3, T4>(cmp2, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4>> Create<T1, T2, T3, T4>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4) where T3 : IComparable<T3>
        { return Comparer.Create<T1, T2, T3, T4>(cmp1, cmp2, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4>> Create<T1, T2, T3, T4>(IComparer<T3> cmp3, IComparer<T4> cmp4) where T1 : IComparable<T1> where T2 : IComparable<T2>
        { return Comparer.Create<T1, T2, T3, T4>(cmp3, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4>> Create<T1, T2, T3, T4>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4) where T2 : IComparable<T2>
        { return Comparer.Create<T1, T2, T3, T4>(cmp1, cmp3, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4>> Create<T1, T2, T3, T4>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4) where T1 : IComparable<T1>
        { return Comparer.Create<T1, T2, T3, T4>(cmp2, cmp3, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4>> Create<T1, T2, T3, T4>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4)
        { return Comparer.Create<T1, T2, T3, T4>(cmp1, cmp2, cmp3, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> Create<T1, T2, T3, T4, T5>() where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5>(); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> Create<T1, T2, T3, T4, T5>(IComparer<T1> cmp1) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5>(cmp1); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> Create<T1, T2, T3, T4, T5>(IComparer<T2> cmp2) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5>(cmp2); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> Create<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T2> cmp2) where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5>(cmp1, cmp2); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> Create<T1, T2, T3, T4, T5>(IComparer<T3> cmp3) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5>(cmp3); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> Create<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T3> cmp3) where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5>(cmp1, cmp3); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> Create<T1, T2, T3, T4, T5>(IComparer<T2> cmp2, IComparer<T3> cmp3) where T1 : IComparable<T1> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5>(cmp2, cmp3); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> Create<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3) where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5>(cmp1, cmp2, cmp3); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> Create<T1, T2, T3, T4, T5>(IComparer<T4> cmp4) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5>(cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> Create<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T4> cmp4) where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5>(cmp1, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> Create<T1, T2, T3, T4, T5>(IComparer<T2> cmp2, IComparer<T4> cmp4) where T1 : IComparable<T1> where T3 : IComparable<T3> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5>(cmp2, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> Create<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4) where T3 : IComparable<T3> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5>(cmp1, cmp2, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> Create<T1, T2, T3, T4, T5>(IComparer<T3> cmp3, IComparer<T4> cmp4) where T1 : IComparable<T1> where T2 : IComparable<T2> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5>(cmp3, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> Create<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4) where T2 : IComparable<T2> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5>(cmp1, cmp3, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> Create<T1, T2, T3, T4, T5>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4) where T1 : IComparable<T1> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5>(cmp2, cmp3, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> Create<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4) where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5>(cmp1, cmp2, cmp3, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> Create<T1, T2, T3, T4, T5>(IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4>
        { return Comparer.Create<T1, T2, T3, T4, T5>(cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> Create<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T5> cmp5) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4>
        { return Comparer.Create<T1, T2, T3, T4, T5>(cmp1, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> Create<T1, T2, T3, T4, T5>(IComparer<T2> cmp2, IComparer<T5> cmp5) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4>
        { return Comparer.Create<T1, T2, T3, T4, T5>(cmp2, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> Create<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T5> cmp5) where T3 : IComparable<T3> where T4 : IComparable<T4>
        { return Comparer.Create<T1, T2, T3, T4, T5>(cmp1, cmp2, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> Create<T1, T2, T3, T4, T5>(IComparer<T3> cmp3, IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4>
        { return Comparer.Create<T1, T2, T3, T4, T5>(cmp3, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> Create<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T5> cmp5) where T2 : IComparable<T2> where T4 : IComparable<T4>
        { return Comparer.Create<T1, T2, T3, T4, T5>(cmp1, cmp3, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> Create<T1, T2, T3, T4, T5>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5) where T1 : IComparable<T1> where T4 : IComparable<T4>
        { return Comparer.Create<T1, T2, T3, T4, T5>(cmp2, cmp3, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> Create<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5) where T4 : IComparable<T4>
        { return Comparer.Create<T1, T2, T3, T4, T5>(cmp1, cmp2, cmp3, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> Create<T1, T2, T3, T4, T5>(IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3>
        { return Comparer.Create<T1, T2, T3, T4, T5>(cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> Create<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T4> cmp4, IComparer<T5> cmp5) where T2 : IComparable<T2> where T3 : IComparable<T3>
        { return Comparer.Create<T1, T2, T3, T4, T5>(cmp1, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> Create<T1, T2, T3, T4, T5>(IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1> where T3 : IComparable<T3>
        { return Comparer.Create<T1, T2, T3, T4, T5>(cmp2, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> Create<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5) where T3 : IComparable<T3>
        { return Comparer.Create<T1, T2, T3, T4, T5>(cmp1, cmp2, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> Create<T1, T2, T3, T4, T5>(IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2>
        { return Comparer.Create<T1, T2, T3, T4, T5>(cmp3, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> Create<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5) where T2 : IComparable<T2>
        { return Comparer.Create<T1, T2, T3, T4, T5>(cmp1, cmp3, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> Create<T1, T2, T3, T4, T5>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1>
        { return Comparer.Create<T1, T2, T3, T4, T5>(cmp2, cmp3, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> Create<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5)
        { return Comparer.Create<T1, T2, T3, T4, T5>(cmp1, cmp2, cmp3, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>() where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp1); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp2); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2) where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp2); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T3> cmp3) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp3); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T3> cmp3) where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp3); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T3> cmp3) where T1 : IComparable<T1> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp2, cmp3); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3) where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp3); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T4> cmp4) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T4> cmp4) where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T4> cmp4) where T1 : IComparable<T1> where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp2, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4) where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T3> cmp3, IComparer<T4> cmp4) where T1 : IComparable<T1> where T2 : IComparable<T2> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp3, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4) where T2 : IComparable<T2> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp3, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4) where T1 : IComparable<T1> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp2, cmp3, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4) where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp3, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T5> cmp5) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T5> cmp5) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp2, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T5> cmp5) where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T3> cmp3, IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp3, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T5> cmp5) where T2 : IComparable<T2> where T4 : IComparable<T4> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp3, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5) where T1 : IComparable<T1> where T4 : IComparable<T4> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp2, cmp3, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5) where T4 : IComparable<T4> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp3, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T4> cmp4, IComparer<T5> cmp5) where T2 : IComparable<T2> where T3 : IComparable<T3> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1> where T3 : IComparable<T3> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp2, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5) where T3 : IComparable<T3> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp3, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5) where T2 : IComparable<T2> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp3, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp2, cmp3, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5) where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp3, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T6> cmp6) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T6> cmp6) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp2, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T6> cmp6) where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T3> cmp3, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp3, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T6> cmp6) where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp3, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T6> cmp6) where T1 : IComparable<T1> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp2, cmp3, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T6> cmp6) where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp3, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T4> cmp4, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp4, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T4> cmp4, IComparer<T6> cmp6) where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp4, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T6> cmp6) where T1 : IComparable<T1> where T3 : IComparable<T3> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp2, cmp4, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T6> cmp6) where T3 : IComparable<T3> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp4, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp3, cmp4, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6) where T2 : IComparable<T2> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp3, cmp4, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6) where T1 : IComparable<T1> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp2, cmp3, cmp4, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6) where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp3, cmp4, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T5> cmp5, IComparer<T6> cmp6) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp2, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T5> cmp5, IComparer<T6> cmp6) where T3 : IComparable<T3> where T4 : IComparable<T4>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp3, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6) where T2 : IComparable<T2> where T4 : IComparable<T4>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp3, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T4 : IComparable<T4>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp2, cmp3, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6) where T4 : IComparable<T4>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp3, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp4, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T2 : IComparable<T2> where T3 : IComparable<T3>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp4, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T3 : IComparable<T3>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp2, cmp4, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T3 : IComparable<T3>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp4, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp3, cmp4, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T2 : IComparable<T2>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp3, cmp4, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp2, cmp3, cmp4, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> Create<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6)
        { return Comparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp3, cmp4, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>() where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2) where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp3); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3) where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp3); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3) where T1 : IComparable<T1> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp3); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3) where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T4> cmp4) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T4> cmp4) where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T4> cmp4) where T1 : IComparable<T1> where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4) where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T4> cmp4) where T1 : IComparable<T1> where T2 : IComparable<T2> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp3, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4) where T2 : IComparable<T2> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp3, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4) where T1 : IComparable<T1> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp3, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4) where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T5> cmp5) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T5> cmp5) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T5> cmp5) where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp3, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T5> cmp5) where T2 : IComparable<T2> where T4 : IComparable<T4> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp3, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5) where T1 : IComparable<T1> where T4 : IComparable<T4> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp3, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5) where T4 : IComparable<T4> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T4> cmp4, IComparer<T5> cmp5) where T2 : IComparable<T2> where T3 : IComparable<T3> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1> where T3 : IComparable<T3> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5) where T3 : IComparable<T3> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp3, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5) where T2 : IComparable<T2> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp3, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp3, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5) where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T6> cmp6) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T6> cmp6) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T6> cmp6) where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp3, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T6> cmp6) where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp3, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T6> cmp6) where T1 : IComparable<T1> where T4 : IComparable<T4> where T5 : IComparable<T5> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp3, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T6> cmp6) where T4 : IComparable<T4> where T5 : IComparable<T5> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T4> cmp4, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp4, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T4> cmp4, IComparer<T6> cmp6) where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp4, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T6> cmp6) where T1 : IComparable<T1> where T3 : IComparable<T3> where T5 : IComparable<T5> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp4, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T6> cmp6) where T3 : IComparable<T3> where T5 : IComparable<T5> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp4, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T5 : IComparable<T5> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp3, cmp4, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6) where T2 : IComparable<T2> where T5 : IComparable<T5> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp3, cmp4, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6) where T1 : IComparable<T1> where T5 : IComparable<T5> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp3, cmp4, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6) where T5 : IComparable<T5> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp4, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T5> cmp5, IComparer<T6> cmp6) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T5> cmp5, IComparer<T6> cmp6) where T3 : IComparable<T3> where T4 : IComparable<T4> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp3, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6) where T2 : IComparable<T2> where T4 : IComparable<T4> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp3, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T4 : IComparable<T4> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp3, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6) where T4 : IComparable<T4> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp4, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T2 : IComparable<T2> where T3 : IComparable<T3> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp4, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T3 : IComparable<T3> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp4, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T3 : IComparable<T3> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp4, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp3, cmp4, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T2 : IComparable<T2> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp3, cmp4, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp3, cmp4, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T7 : IComparable<T7>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp4, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T7> cmp7) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T7> cmp7) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T7> cmp7) where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp3, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T7> cmp7) where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp3, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T7> cmp7) where T1 : IComparable<T1> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp3, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T7> cmp7) where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T4> cmp4, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp4, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T4> cmp4, IComparer<T7> cmp7) where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp4, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T7> cmp7) where T1 : IComparable<T1> where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp4, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T7> cmp7) where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp4, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp3, cmp4, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T7> cmp7) where T2 : IComparable<T2> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp3, cmp4, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T7> cmp7) where T1 : IComparable<T1> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp3, cmp4, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T7> cmp7) where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp4, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T5> cmp5, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp5, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T5> cmp5, IComparer<T7> cmp7) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp5, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T5> cmp5, IComparer<T7> cmp7) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp5, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T5> cmp5, IComparer<T7> cmp7) where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp5, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp3, cmp5, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T7> cmp7) where T2 : IComparable<T2> where T4 : IComparable<T4> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp3, cmp5, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T7> cmp7) where T1 : IComparable<T1> where T4 : IComparable<T4> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp3, cmp5, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T7> cmp7) where T4 : IComparable<T4> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp5, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp4, cmp5, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T7> cmp7) where T2 : IComparable<T2> where T3 : IComparable<T3> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp4, cmp5, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T7> cmp7) where T1 : IComparable<T1> where T3 : IComparable<T3> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp4, cmp5, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T7> cmp7) where T3 : IComparable<T3> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp4, cmp5, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp3, cmp4, cmp5, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T7> cmp7) where T2 : IComparable<T2> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp3, cmp4, cmp5, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T7> cmp7) where T1 : IComparable<T1> where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp3, cmp4, cmp5, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T7> cmp7) where T6 : IComparable<T6>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp4, cmp5, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T6> cmp6, IComparer<T7> cmp7) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T6> cmp6, IComparer<T7> cmp7) where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp3, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T6> cmp6, IComparer<T7> cmp7) where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp3, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp3, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T6> cmp6, IComparer<T7> cmp7) where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T4> cmp4, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp4, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T4> cmp4, IComparer<T6> cmp6, IComparer<T7> cmp7) where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp4, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T3 : IComparable<T3> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp4, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T6> cmp6, IComparer<T7> cmp7) where T3 : IComparable<T3> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp4, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp3, cmp4, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6, IComparer<T7> cmp7) where T2 : IComparable<T2> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp3, cmp4, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp3, cmp4, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6, IComparer<T7> cmp7) where T5 : IComparable<T5>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp4, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp5, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp5, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp5, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T3 : IComparable<T3> where T4 : IComparable<T4>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp5, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp3, cmp5, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T2 : IComparable<T2> where T4 : IComparable<T4>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp3, cmp5, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T4 : IComparable<T4>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp3, cmp5, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T4 : IComparable<T4>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp5, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp4, cmp5, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T2 : IComparable<T2> where T3 : IComparable<T3>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp4, cmp5, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T3 : IComparable<T3>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp4, cmp5, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T3 : IComparable<T3>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp4, cmp5, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp3, cmp4, cmp5, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T2 : IComparable<T2>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp3, cmp4, cmp5, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1>
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp3, cmp4, cmp5, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> Create<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7)
        { return Comparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp4, cmp5, cmp6, cmp7); }
    }

    partial class Create
    {
        public static IComparer<Tuple<T1, T2>> TupleComparer<T1, T2>() where T1 : IComparable<T1> where T2 : IComparable<T2>
        { return LangExt.TupleComparer.Create<T1, T2>(); }
        public static IComparer<Tuple<T1, T2>> TupleComparer<T1, T2>(IComparer<T1> cmp1) where T2 : IComparable<T2>
        { return LangExt.TupleComparer.Create<T1, T2>(cmp1); }
        public static IComparer<Tuple<T1, T2>> TupleComparer<T1, T2>(IComparer<T2> cmp2) where T1 : IComparable<T1>
        { return LangExt.TupleComparer.Create<T1, T2>(cmp2); }
        public static IComparer<Tuple<T1, T2>> TupleComparer<T1, T2>(IComparer<T1> cmp1, IComparer<T2> cmp2)
        { return LangExt.TupleComparer.Create<T1, T2>(cmp1, cmp2); }
        public static IComparer<Tuple<T1, T2, T3>> TupleComparer<T1, T2, T3>() where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3>
        { return LangExt.TupleComparer.Create<T1, T2, T3>(); }
        public static IComparer<Tuple<T1, T2, T3>> TupleComparer<T1, T2, T3>(IComparer<T1> cmp1) where T2 : IComparable<T2> where T3 : IComparable<T3>
        { return LangExt.TupleComparer.Create<T1, T2, T3>(cmp1); }
        public static IComparer<Tuple<T1, T2, T3>> TupleComparer<T1, T2, T3>(IComparer<T2> cmp2) where T1 : IComparable<T1> where T3 : IComparable<T3>
        { return LangExt.TupleComparer.Create<T1, T2, T3>(cmp2); }
        public static IComparer<Tuple<T1, T2, T3>> TupleComparer<T1, T2, T3>(IComparer<T1> cmp1, IComparer<T2> cmp2) where T3 : IComparable<T3>
        { return LangExt.TupleComparer.Create<T1, T2, T3>(cmp1, cmp2); }
        public static IComparer<Tuple<T1, T2, T3>> TupleComparer<T1, T2, T3>(IComparer<T3> cmp3) where T1 : IComparable<T1> where T2 : IComparable<T2>
        { return LangExt.TupleComparer.Create<T1, T2, T3>(cmp3); }
        public static IComparer<Tuple<T1, T2, T3>> TupleComparer<T1, T2, T3>(IComparer<T1> cmp1, IComparer<T3> cmp3) where T2 : IComparable<T2>
        { return LangExt.TupleComparer.Create<T1, T2, T3>(cmp1, cmp3); }
        public static IComparer<Tuple<T1, T2, T3>> TupleComparer<T1, T2, T3>(IComparer<T2> cmp2, IComparer<T3> cmp3) where T1 : IComparable<T1>
        { return LangExt.TupleComparer.Create<T1, T2, T3>(cmp2, cmp3); }
        public static IComparer<Tuple<T1, T2, T3>> TupleComparer<T1, T2, T3>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3)
        { return LangExt.TupleComparer.Create<T1, T2, T3>(cmp1, cmp2, cmp3); }
        public static IComparer<Tuple<T1, T2, T3, T4>> TupleComparer<T1, T2, T3, T4>() where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4>(); }
        public static IComparer<Tuple<T1, T2, T3, T4>> TupleComparer<T1, T2, T3, T4>(IComparer<T1> cmp1) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4>(cmp1); }
        public static IComparer<Tuple<T1, T2, T3, T4>> TupleComparer<T1, T2, T3, T4>(IComparer<T2> cmp2) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4>(cmp2); }
        public static IComparer<Tuple<T1, T2, T3, T4>> TupleComparer<T1, T2, T3, T4>(IComparer<T1> cmp1, IComparer<T2> cmp2) where T3 : IComparable<T3> where T4 : IComparable<T4>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4>(cmp1, cmp2); }
        public static IComparer<Tuple<T1, T2, T3, T4>> TupleComparer<T1, T2, T3, T4>(IComparer<T3> cmp3) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4>(cmp3); }
        public static IComparer<Tuple<T1, T2, T3, T4>> TupleComparer<T1, T2, T3, T4>(IComparer<T1> cmp1, IComparer<T3> cmp3) where T2 : IComparable<T2> where T4 : IComparable<T4>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4>(cmp1, cmp3); }
        public static IComparer<Tuple<T1, T2, T3, T4>> TupleComparer<T1, T2, T3, T4>(IComparer<T2> cmp2, IComparer<T3> cmp3) where T1 : IComparable<T1> where T4 : IComparable<T4>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4>(cmp2, cmp3); }
        public static IComparer<Tuple<T1, T2, T3, T4>> TupleComparer<T1, T2, T3, T4>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3) where T4 : IComparable<T4>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4>(cmp1, cmp2, cmp3); }
        public static IComparer<Tuple<T1, T2, T3, T4>> TupleComparer<T1, T2, T3, T4>(IComparer<T4> cmp4) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4>(cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4>> TupleComparer<T1, T2, T3, T4>(IComparer<T1> cmp1, IComparer<T4> cmp4) where T2 : IComparable<T2> where T3 : IComparable<T3>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4>(cmp1, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4>> TupleComparer<T1, T2, T3, T4>(IComparer<T2> cmp2, IComparer<T4> cmp4) where T1 : IComparable<T1> where T3 : IComparable<T3>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4>(cmp2, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4>> TupleComparer<T1, T2, T3, T4>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4) where T3 : IComparable<T3>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4>(cmp1, cmp2, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4>> TupleComparer<T1, T2, T3, T4>(IComparer<T3> cmp3, IComparer<T4> cmp4) where T1 : IComparable<T1> where T2 : IComparable<T2>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4>(cmp3, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4>> TupleComparer<T1, T2, T3, T4>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4) where T2 : IComparable<T2>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4>(cmp1, cmp3, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4>> TupleComparer<T1, T2, T3, T4>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4) where T1 : IComparable<T1>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4>(cmp2, cmp3, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4>> TupleComparer<T1, T2, T3, T4>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4)
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4>(cmp1, cmp2, cmp3, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> TupleComparer<T1, T2, T3, T4, T5>() where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5>(); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> TupleComparer<T1, T2, T3, T4, T5>(IComparer<T1> cmp1) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5>(cmp1); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> TupleComparer<T1, T2, T3, T4, T5>(IComparer<T2> cmp2) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5>(cmp2); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> TupleComparer<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T2> cmp2) where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5>(cmp1, cmp2); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> TupleComparer<T1, T2, T3, T4, T5>(IComparer<T3> cmp3) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5>(cmp3); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> TupleComparer<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T3> cmp3) where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5>(cmp1, cmp3); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> TupleComparer<T1, T2, T3, T4, T5>(IComparer<T2> cmp2, IComparer<T3> cmp3) where T1 : IComparable<T1> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5>(cmp2, cmp3); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> TupleComparer<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3) where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5>(cmp1, cmp2, cmp3); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> TupleComparer<T1, T2, T3, T4, T5>(IComparer<T4> cmp4) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5>(cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> TupleComparer<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T4> cmp4) where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5>(cmp1, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> TupleComparer<T1, T2, T3, T4, T5>(IComparer<T2> cmp2, IComparer<T4> cmp4) where T1 : IComparable<T1> where T3 : IComparable<T3> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5>(cmp2, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> TupleComparer<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4) where T3 : IComparable<T3> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5>(cmp1, cmp2, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> TupleComparer<T1, T2, T3, T4, T5>(IComparer<T3> cmp3, IComparer<T4> cmp4) where T1 : IComparable<T1> where T2 : IComparable<T2> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5>(cmp3, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> TupleComparer<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4) where T2 : IComparable<T2> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5>(cmp1, cmp3, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> TupleComparer<T1, T2, T3, T4, T5>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4) where T1 : IComparable<T1> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5>(cmp2, cmp3, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> TupleComparer<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4) where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5>(cmp1, cmp2, cmp3, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> TupleComparer<T1, T2, T3, T4, T5>(IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5>(cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> TupleComparer<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T5> cmp5) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5>(cmp1, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> TupleComparer<T1, T2, T3, T4, T5>(IComparer<T2> cmp2, IComparer<T5> cmp5) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5>(cmp2, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> TupleComparer<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T5> cmp5) where T3 : IComparable<T3> where T4 : IComparable<T4>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5>(cmp1, cmp2, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> TupleComparer<T1, T2, T3, T4, T5>(IComparer<T3> cmp3, IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5>(cmp3, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> TupleComparer<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T5> cmp5) where T2 : IComparable<T2> where T4 : IComparable<T4>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5>(cmp1, cmp3, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> TupleComparer<T1, T2, T3, T4, T5>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5) where T1 : IComparable<T1> where T4 : IComparable<T4>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5>(cmp2, cmp3, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> TupleComparer<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5) where T4 : IComparable<T4>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5>(cmp1, cmp2, cmp3, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> TupleComparer<T1, T2, T3, T4, T5>(IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5>(cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> TupleComparer<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T4> cmp4, IComparer<T5> cmp5) where T2 : IComparable<T2> where T3 : IComparable<T3>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5>(cmp1, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> TupleComparer<T1, T2, T3, T4, T5>(IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1> where T3 : IComparable<T3>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5>(cmp2, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> TupleComparer<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5) where T3 : IComparable<T3>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5>(cmp1, cmp2, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> TupleComparer<T1, T2, T3, T4, T5>(IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5>(cmp3, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> TupleComparer<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5) where T2 : IComparable<T2>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5>(cmp1, cmp3, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> TupleComparer<T1, T2, T3, T4, T5>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5>(cmp2, cmp3, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5>> TupleComparer<T1, T2, T3, T4, T5>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5)
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5>(cmp1, cmp2, cmp3, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>() where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp1); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp2); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2) where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp2); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T3> cmp3) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp3); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T3> cmp3) where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp3); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T3> cmp3) where T1 : IComparable<T1> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp2, cmp3); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3) where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp3); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T4> cmp4) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T4> cmp4) where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T4> cmp4) where T1 : IComparable<T1> where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp2, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4) where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T3> cmp3, IComparer<T4> cmp4) where T1 : IComparable<T1> where T2 : IComparable<T2> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp3, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4) where T2 : IComparable<T2> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp3, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4) where T1 : IComparable<T1> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp2, cmp3, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4) where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp3, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T5> cmp5) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T5> cmp5) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp2, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T5> cmp5) where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T3> cmp3, IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp3, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T5> cmp5) where T2 : IComparable<T2> where T4 : IComparable<T4> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp3, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5) where T1 : IComparable<T1> where T4 : IComparable<T4> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp2, cmp3, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5) where T4 : IComparable<T4> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp3, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T4> cmp4, IComparer<T5> cmp5) where T2 : IComparable<T2> where T3 : IComparable<T3> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1> where T3 : IComparable<T3> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp2, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5) where T3 : IComparable<T3> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp3, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5) where T2 : IComparable<T2> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp3, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp2, cmp3, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5) where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp3, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T6> cmp6) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T6> cmp6) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp2, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T6> cmp6) where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T3> cmp3, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp3, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T6> cmp6) where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp3, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T6> cmp6) where T1 : IComparable<T1> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp2, cmp3, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T6> cmp6) where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp3, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T4> cmp4, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp4, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T4> cmp4, IComparer<T6> cmp6) where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp4, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T6> cmp6) where T1 : IComparable<T1> where T3 : IComparable<T3> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp2, cmp4, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T6> cmp6) where T3 : IComparable<T3> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp4, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp3, cmp4, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6) where T2 : IComparable<T2> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp3, cmp4, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6) where T1 : IComparable<T1> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp2, cmp3, cmp4, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6) where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp3, cmp4, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T5> cmp5, IComparer<T6> cmp6) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp2, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T5> cmp5, IComparer<T6> cmp6) where T3 : IComparable<T3> where T4 : IComparable<T4>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp3, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6) where T2 : IComparable<T2> where T4 : IComparable<T4>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp3, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T4 : IComparable<T4>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp2, cmp3, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6) where T4 : IComparable<T4>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp3, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp4, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T2 : IComparable<T2> where T3 : IComparable<T3>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp4, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T3 : IComparable<T3>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp2, cmp4, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T3 : IComparable<T3>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp4, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp3, cmp4, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T2 : IComparable<T2>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp3, cmp4, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp2, cmp3, cmp4, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6>> TupleComparer<T1, T2, T3, T4, T5, T6>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6)
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6>(cmp1, cmp2, cmp3, cmp4, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>() where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2) where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp3); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3) where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp3); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3) where T1 : IComparable<T1> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp3); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3) where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T4> cmp4) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T4> cmp4) where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T4> cmp4) where T1 : IComparable<T1> where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4) where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T4> cmp4) where T1 : IComparable<T1> where T2 : IComparable<T2> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp3, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4) where T2 : IComparable<T2> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp3, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4) where T1 : IComparable<T1> where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp3, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4) where T5 : IComparable<T5> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp4); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T5> cmp5) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T5> cmp5) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T5> cmp5) where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp3, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T5> cmp5) where T2 : IComparable<T2> where T4 : IComparable<T4> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp3, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5) where T1 : IComparable<T1> where T4 : IComparable<T4> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp3, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5) where T4 : IComparable<T4> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T4> cmp4, IComparer<T5> cmp5) where T2 : IComparable<T2> where T3 : IComparable<T3> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1> where T3 : IComparable<T3> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5) where T3 : IComparable<T3> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1> where T2 : IComparable<T2> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp3, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5) where T2 : IComparable<T2> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp3, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5) where T1 : IComparable<T1> where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp3, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5) where T6 : IComparable<T6> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp4, cmp5); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T6> cmp6) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T6> cmp6) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T6> cmp6) where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp3, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T6> cmp6) where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp3, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T6> cmp6) where T1 : IComparable<T1> where T4 : IComparable<T4> where T5 : IComparable<T5> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp3, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T6> cmp6) where T4 : IComparable<T4> where T5 : IComparable<T5> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T4> cmp4, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp4, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T4> cmp4, IComparer<T6> cmp6) where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp4, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T6> cmp6) where T1 : IComparable<T1> where T3 : IComparable<T3> where T5 : IComparable<T5> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp4, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T6> cmp6) where T3 : IComparable<T3> where T5 : IComparable<T5> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp4, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T5 : IComparable<T5> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp3, cmp4, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6) where T2 : IComparable<T2> where T5 : IComparable<T5> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp3, cmp4, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6) where T1 : IComparable<T1> where T5 : IComparable<T5> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp3, cmp4, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6) where T5 : IComparable<T5> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp4, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T5> cmp5, IComparer<T6> cmp6) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T5> cmp5, IComparer<T6> cmp6) where T3 : IComparable<T3> where T4 : IComparable<T4> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp3, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6) where T2 : IComparable<T2> where T4 : IComparable<T4> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp3, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T4 : IComparable<T4> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp3, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6) where T4 : IComparable<T4> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp4, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T2 : IComparable<T2> where T3 : IComparable<T3> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp4, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T3 : IComparable<T3> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp4, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T3 : IComparable<T3> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp4, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T2 : IComparable<T2> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp3, cmp4, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T2 : IComparable<T2> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp3, cmp4, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T1 : IComparable<T1> where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp3, cmp4, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6) where T7 : IComparable<T7>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp4, cmp5, cmp6); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T7> cmp7) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T7> cmp7) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T7> cmp7) where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp3, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T7> cmp7) where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp3, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T7> cmp7) where T1 : IComparable<T1> where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp3, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T7> cmp7) where T4 : IComparable<T4> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T4> cmp4, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp4, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T4> cmp4, IComparer<T7> cmp7) where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp4, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T7> cmp7) where T1 : IComparable<T1> where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp4, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T7> cmp7) where T3 : IComparable<T3> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp4, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp3, cmp4, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T7> cmp7) where T2 : IComparable<T2> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp3, cmp4, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T7> cmp7) where T1 : IComparable<T1> where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp3, cmp4, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T7> cmp7) where T5 : IComparable<T5> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp4, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T5> cmp5, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp5, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T5> cmp5, IComparer<T7> cmp7) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp5, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T5> cmp5, IComparer<T7> cmp7) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp5, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T5> cmp5, IComparer<T7> cmp7) where T3 : IComparable<T3> where T4 : IComparable<T4> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp5, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp3, cmp5, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T7> cmp7) where T2 : IComparable<T2> where T4 : IComparable<T4> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp3, cmp5, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T7> cmp7) where T1 : IComparable<T1> where T4 : IComparable<T4> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp3, cmp5, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T7> cmp7) where T4 : IComparable<T4> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp5, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp4, cmp5, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T7> cmp7) where T2 : IComparable<T2> where T3 : IComparable<T3> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp4, cmp5, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T7> cmp7) where T1 : IComparable<T1> where T3 : IComparable<T3> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp4, cmp5, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T7> cmp7) where T3 : IComparable<T3> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp4, cmp5, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp3, cmp4, cmp5, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T7> cmp7) where T2 : IComparable<T2> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp3, cmp4, cmp5, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T7> cmp7) where T1 : IComparable<T1> where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp3, cmp4, cmp5, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T7> cmp7) where T6 : IComparable<T6>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp4, cmp5, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T6> cmp6, IComparer<T7> cmp7) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T6> cmp6, IComparer<T7> cmp7) where T3 : IComparable<T3> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp3, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T6> cmp6, IComparer<T7> cmp7) where T2 : IComparable<T2> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp3, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp3, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T6> cmp6, IComparer<T7> cmp7) where T4 : IComparable<T4> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T4> cmp4, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp4, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T4> cmp4, IComparer<T6> cmp6, IComparer<T7> cmp7) where T2 : IComparable<T2> where T3 : IComparable<T3> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp4, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T3 : IComparable<T3> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp4, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T6> cmp6, IComparer<T7> cmp7) where T3 : IComparable<T3> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp4, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp3, cmp4, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6, IComparer<T7> cmp7) where T2 : IComparable<T2> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp3, cmp4, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp3, cmp4, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T6> cmp6, IComparer<T7> cmp7) where T5 : IComparable<T5>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp4, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp5, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T2 : IComparable<T2> where T3 : IComparable<T3> where T4 : IComparable<T4>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp5, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T3 : IComparable<T3> where T4 : IComparable<T4>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp5, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T3 : IComparable<T3> where T4 : IComparable<T4>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp5, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T4 : IComparable<T4>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp3, cmp5, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T2 : IComparable<T2> where T4 : IComparable<T4>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp3, cmp5, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T4 : IComparable<T4>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp3, cmp5, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T4 : IComparable<T4>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp5, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2> where T3 : IComparable<T3>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp4, cmp5, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T2 : IComparable<T2> where T3 : IComparable<T3>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp4, cmp5, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T3 : IComparable<T3>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp4, cmp5, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T3 : IComparable<T3>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp4, cmp5, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1> where T2 : IComparable<T2>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp3, cmp4, cmp5, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T2 : IComparable<T2>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp3, cmp4, cmp5, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7) where T1 : IComparable<T1>
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp2, cmp3, cmp4, cmp5, cmp6, cmp7); }
        public static IComparer<Tuple<T1, T2, T3, T4, T5, T6, T7>> TupleComparer<T1, T2, T3, T4, T5, T6, T7>(IComparer<T1> cmp1, IComparer<T2> cmp2, IComparer<T3> cmp3, IComparer<T4> cmp4, IComparer<T5> cmp5, IComparer<T6> cmp6, IComparer<T7> cmp7)
        { return LangExt.TupleComparer.Create<T1, T2, T3, T4, T5, T6, T7>(cmp1, cmp2, cmp3, cmp4, cmp5, cmp6, cmp7); }
    }
}
