
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace LangExt
{
    public static partial class Choice
    {
        public static T BinOp<T1, T2, T>(Choice<T1, T2> a, Choice<T1, T2> b, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<int, int, T> Otherwise)
        {
            var aTag = a.TagIndex;
            var bTag = b.TagIndex;
            if (aTag == 1 && bTag == 1) return Case1(a.Case1.Value, b.Case1.Value);
            if (aTag == 2 && bTag == 2) return Case2(a.Case2.Value, b.Case2.Value);
            return Otherwise(aTag, bTag);
        }

        public static T BinOp<T1, T2, T>(this Tuple<Choice<T1, T2>, Choice<T1, T2>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<int, int, T> Otherwise)
        {
            return BinOp(self.Item1, self.Item2, Case1, Case2, Otherwise);
        }

        public static Comparable.CompareResult CompareTo<T1, T2>(this Choice<T1, T2> self, Choice<T1, T2> other)
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
        {
            return BinOp(self, other, (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b));
        }

        public static IComparer<Choice<T1, T2>> Comparer<T1, T2>()
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
        {
            return new Comparer<Choice<T1, T2>>((a, b) => a.CompareTo(b).Match(() => -1, () => 0, () => 1));
        }
        public static T BinOp<T1, T2, T3, T>(Choice<T1, T2, T3> a, Choice<T1, T2, T3> b, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<int, int, T> Otherwise)
        {
            var aTag = a.TagIndex;
            var bTag = b.TagIndex;
            if (aTag == 1 && bTag == 1) return Case1(a.Case1.Value, b.Case1.Value);
            if (aTag == 2 && bTag == 2) return Case2(a.Case2.Value, b.Case2.Value);
            if (aTag == 3 && bTag == 3) return Case3(a.Case3.Value, b.Case3.Value);
            return Otherwise(aTag, bTag);
        }

        public static T BinOp<T1, T2, T3, T>(this Tuple<Choice<T1, T2, T3>, Choice<T1, T2, T3>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<int, int, T> Otherwise)
        {
            return BinOp(self.Item1, self.Item2, Case1, Case2, Case3, Otherwise);
        }

        public static Comparable.CompareResult CompareTo<T1, T2, T3>(this Choice<T1, T2, T3> self, Choice<T1, T2, T3> other)
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
        {
            return BinOp(self, other, (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b));
        }

        public static IComparer<Choice<T1, T2, T3>> Comparer<T1, T2, T3>()
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
        {
            return new Comparer<Choice<T1, T2, T3>>((a, b) => a.CompareTo(b).Match(() => -1, () => 0, () => 1));
        }
        public static T BinOp<T1, T2, T3, T4, T>(Choice<T1, T2, T3, T4> a, Choice<T1, T2, T3, T4> b, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<int, int, T> Otherwise)
        {
            var aTag = a.TagIndex;
            var bTag = b.TagIndex;
            if (aTag == 1 && bTag == 1) return Case1(a.Case1.Value, b.Case1.Value);
            if (aTag == 2 && bTag == 2) return Case2(a.Case2.Value, b.Case2.Value);
            if (aTag == 3 && bTag == 3) return Case3(a.Case3.Value, b.Case3.Value);
            if (aTag == 4 && bTag == 4) return Case4(a.Case4.Value, b.Case4.Value);
            return Otherwise(aTag, bTag);
        }

        public static T BinOp<T1, T2, T3, T4, T>(this Tuple<Choice<T1, T2, T3, T4>, Choice<T1, T2, T3, T4>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<int, int, T> Otherwise)
        {
            return BinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Otherwise);
        }

        public static Comparable.CompareResult CompareTo<T1, T2, T3, T4>(this Choice<T1, T2, T3, T4> self, Choice<T1, T2, T3, T4> other)
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
            where T4 : IComparable<T4>
        {
            return BinOp(self, other, (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b));
        }

        public static IComparer<Choice<T1, T2, T3, T4>> Comparer<T1, T2, T3, T4>()
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
            where T4 : IComparable<T4>
        {
            return new Comparer<Choice<T1, T2, T3, T4>>((a, b) => a.CompareTo(b).Match(() => -1, () => 0, () => 1));
        }
        public static T BinOp<T1, T2, T3, T4, T5, T>(Choice<T1, T2, T3, T4, T5> a, Choice<T1, T2, T3, T4, T5> b, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<int, int, T> Otherwise)
        {
            var aTag = a.TagIndex;
            var bTag = b.TagIndex;
            if (aTag == 1 && bTag == 1) return Case1(a.Case1.Value, b.Case1.Value);
            if (aTag == 2 && bTag == 2) return Case2(a.Case2.Value, b.Case2.Value);
            if (aTag == 3 && bTag == 3) return Case3(a.Case3.Value, b.Case3.Value);
            if (aTag == 4 && bTag == 4) return Case4(a.Case4.Value, b.Case4.Value);
            if (aTag == 5 && bTag == 5) return Case5(a.Case5.Value, b.Case5.Value);
            return Otherwise(aTag, bTag);
        }

        public static T BinOp<T1, T2, T3, T4, T5, T>(this Tuple<Choice<T1, T2, T3, T4, T5>, Choice<T1, T2, T3, T4, T5>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<int, int, T> Otherwise)
        {
            return BinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Otherwise);
        }

        public static Comparable.CompareResult CompareTo<T1, T2, T3, T4, T5>(this Choice<T1, T2, T3, T4, T5> self, Choice<T1, T2, T3, T4, T5> other)
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
            where T4 : IComparable<T4>
            where T5 : IComparable<T5>
        {
            return BinOp(self, other, (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b));
        }

        public static IComparer<Choice<T1, T2, T3, T4, T5>> Comparer<T1, T2, T3, T4, T5>()
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
            where T4 : IComparable<T4>
            where T5 : IComparable<T5>
        {
            return new Comparer<Choice<T1, T2, T3, T4, T5>>((a, b) => a.CompareTo(b).Match(() => -1, () => 0, () => 1));
        }
        public static T BinOp<T1, T2, T3, T4, T5, T6, T>(Choice<T1, T2, T3, T4, T5, T6> a, Choice<T1, T2, T3, T4, T5, T6> b, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<int, int, T> Otherwise)
        {
            var aTag = a.TagIndex;
            var bTag = b.TagIndex;
            if (aTag == 1 && bTag == 1) return Case1(a.Case1.Value, b.Case1.Value);
            if (aTag == 2 && bTag == 2) return Case2(a.Case2.Value, b.Case2.Value);
            if (aTag == 3 && bTag == 3) return Case3(a.Case3.Value, b.Case3.Value);
            if (aTag == 4 && bTag == 4) return Case4(a.Case4.Value, b.Case4.Value);
            if (aTag == 5 && bTag == 5) return Case5(a.Case5.Value, b.Case5.Value);
            if (aTag == 6 && bTag == 6) return Case6(a.Case6.Value, b.Case6.Value);
            return Otherwise(aTag, bTag);
        }

        public static T BinOp<T1, T2, T3, T4, T5, T6, T>(this Tuple<Choice<T1, T2, T3, T4, T5, T6>, Choice<T1, T2, T3, T4, T5, T6>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<int, int, T> Otherwise)
        {
            return BinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Case6, Otherwise);
        }

        public static Comparable.CompareResult CompareTo<T1, T2, T3, T4, T5, T6>(this Choice<T1, T2, T3, T4, T5, T6> self, Choice<T1, T2, T3, T4, T5, T6> other)
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
            where T4 : IComparable<T4>
            where T5 : IComparable<T5>
            where T6 : IComparable<T6>
        {
            return BinOp(self, other, (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b));
        }

        public static IComparer<Choice<T1, T2, T3, T4, T5, T6>> Comparer<T1, T2, T3, T4, T5, T6>()
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
            where T4 : IComparable<T4>
            where T5 : IComparable<T5>
            where T6 : IComparable<T6>
        {
            return new Comparer<Choice<T1, T2, T3, T4, T5, T6>>((a, b) => a.CompareTo(b).Match(() => -1, () => 0, () => 1));
        }
        public static T BinOp<T1, T2, T3, T4, T5, T6, T7, T>(Choice<T1, T2, T3, T4, T5, T6, T7> a, Choice<T1, T2, T3, T4, T5, T6, T7> b, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<int, int, T> Otherwise)
        {
            var aTag = a.TagIndex;
            var bTag = b.TagIndex;
            if (aTag == 1 && bTag == 1) return Case1(a.Case1.Value, b.Case1.Value);
            if (aTag == 2 && bTag == 2) return Case2(a.Case2.Value, b.Case2.Value);
            if (aTag == 3 && bTag == 3) return Case3(a.Case3.Value, b.Case3.Value);
            if (aTag == 4 && bTag == 4) return Case4(a.Case4.Value, b.Case4.Value);
            if (aTag == 5 && bTag == 5) return Case5(a.Case5.Value, b.Case5.Value);
            if (aTag == 6 && bTag == 6) return Case6(a.Case6.Value, b.Case6.Value);
            if (aTag == 7 && bTag == 7) return Case7(a.Case7.Value, b.Case7.Value);
            return Otherwise(aTag, bTag);
        }

        public static T BinOp<T1, T2, T3, T4, T5, T6, T7, T>(this Tuple<Choice<T1, T2, T3, T4, T5, T6, T7>, Choice<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<int, int, T> Otherwise)
        {
            return BinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Case6, Case7, Otherwise);
        }

        public static Comparable.CompareResult CompareTo<T1, T2, T3, T4, T5, T6, T7>(this Choice<T1, T2, T3, T4, T5, T6, T7> self, Choice<T1, T2, T3, T4, T5, T6, T7> other)
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
            where T4 : IComparable<T4>
            where T5 : IComparable<T5>
            where T6 : IComparable<T6>
            where T7 : IComparable<T7>
        {
            return BinOp(self, other, (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b));
        }

        public static IComparer<Choice<T1, T2, T3, T4, T5, T6, T7>> Comparer<T1, T2, T3, T4, T5, T6, T7>()
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
            where T4 : IComparable<T4>
            where T5 : IComparable<T5>
            where T6 : IComparable<T6>
            where T7 : IComparable<T7>
        {
            return new Comparer<Choice<T1, T2, T3, T4, T5, T6, T7>>((a, b) => a.CompareTo(b).Match(() => -1, () => 0, () => 1));
        }
        public static T BinOp<T1, T2, T3, T4, T5, T6, T7, T8, T>(Choice<T1, T2, T3, T4, T5, T6, T7, T8> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8> b, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<int, int, T> Otherwise)
        {
            var aTag = a.TagIndex;
            var bTag = b.TagIndex;
            if (aTag == 1 && bTag == 1) return Case1(a.Case1.Value, b.Case1.Value);
            if (aTag == 2 && bTag == 2) return Case2(a.Case2.Value, b.Case2.Value);
            if (aTag == 3 && bTag == 3) return Case3(a.Case3.Value, b.Case3.Value);
            if (aTag == 4 && bTag == 4) return Case4(a.Case4.Value, b.Case4.Value);
            if (aTag == 5 && bTag == 5) return Case5(a.Case5.Value, b.Case5.Value);
            if (aTag == 6 && bTag == 6) return Case6(a.Case6.Value, b.Case6.Value);
            if (aTag == 7 && bTag == 7) return Case7(a.Case7.Value, b.Case7.Value);
            if (aTag == 8 && bTag == 8) return Case8(a.Case8.Value, b.Case8.Value);
            return Otherwise(aTag, bTag);
        }

        public static T BinOp<T1, T2, T3, T4, T5, T6, T7, T8, T>(this Tuple<Choice<T1, T2, T3, T4, T5, T6, T7, T8>, Choice<T1, T2, T3, T4, T5, T6, T7, T8>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<int, int, T> Otherwise)
        {
            return BinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Case6, Case7, Case8, Otherwise);
        }

        public static Comparable.CompareResult CompareTo<T1, T2, T3, T4, T5, T6, T7, T8>(this Choice<T1, T2, T3, T4, T5, T6, T7, T8> self, Choice<T1, T2, T3, T4, T5, T6, T7, T8> other)
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
            where T4 : IComparable<T4>
            where T5 : IComparable<T5>
            where T6 : IComparable<T6>
            where T7 : IComparable<T7>
            where T8 : IComparable<T8>
        {
            return BinOp(self, other, (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b));
        }

        public static IComparer<Choice<T1, T2, T3, T4, T5, T6, T7, T8>> Comparer<T1, T2, T3, T4, T5, T6, T7, T8>()
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
            where T4 : IComparable<T4>
            where T5 : IComparable<T5>
            where T6 : IComparable<T6>
            where T7 : IComparable<T7>
            where T8 : IComparable<T8>
        {
            return new Comparer<Choice<T1, T2, T3, T4, T5, T6, T7, T8>>((a, b) => a.CompareTo(b).Match(() => -1, () => 0, () => 1));
        }
        public static T BinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T>(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9> b, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<int, int, T> Otherwise)
        {
            var aTag = a.TagIndex;
            var bTag = b.TagIndex;
            if (aTag == 1 && bTag == 1) return Case1(a.Case1.Value, b.Case1.Value);
            if (aTag == 2 && bTag == 2) return Case2(a.Case2.Value, b.Case2.Value);
            if (aTag == 3 && bTag == 3) return Case3(a.Case3.Value, b.Case3.Value);
            if (aTag == 4 && bTag == 4) return Case4(a.Case4.Value, b.Case4.Value);
            if (aTag == 5 && bTag == 5) return Case5(a.Case5.Value, b.Case5.Value);
            if (aTag == 6 && bTag == 6) return Case6(a.Case6.Value, b.Case6.Value);
            if (aTag == 7 && bTag == 7) return Case7(a.Case7.Value, b.Case7.Value);
            if (aTag == 8 && bTag == 8) return Case8(a.Case8.Value, b.Case8.Value);
            if (aTag == 9 && bTag == 9) return Case9(a.Case9.Value, b.Case9.Value);
            return Otherwise(aTag, bTag);
        }

        public static T BinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T>(this Tuple<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<int, int, T> Otherwise)
        {
            return BinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Case6, Case7, Case8, Case9, Otherwise);
        }

        public static Comparable.CompareResult CompareTo<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9> self, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9> other)
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
            where T4 : IComparable<T4>
            where T5 : IComparable<T5>
            where T6 : IComparable<T6>
            where T7 : IComparable<T7>
            where T8 : IComparable<T8>
            where T9 : IComparable<T9>
        {
            return BinOp(self, other, (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b));
        }

        public static IComparer<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>> Comparer<T1, T2, T3, T4, T5, T6, T7, T8, T9>()
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
            where T4 : IComparable<T4>
            where T5 : IComparable<T5>
            where T6 : IComparable<T6>
            where T7 : IComparable<T7>
            where T8 : IComparable<T8>
            where T9 : IComparable<T9>
        {
            return new Comparer<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>>((a, b) => a.CompareTo(b).Match(() => -1, () => 0, () => 1));
        }
        public static T BinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T>(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> b, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10, Func<int, int, T> Otherwise)
        {
            var aTag = a.TagIndex;
            var bTag = b.TagIndex;
            if (aTag == 1 && bTag == 1) return Case1(a.Case1.Value, b.Case1.Value);
            if (aTag == 2 && bTag == 2) return Case2(a.Case2.Value, b.Case2.Value);
            if (aTag == 3 && bTag == 3) return Case3(a.Case3.Value, b.Case3.Value);
            if (aTag == 4 && bTag == 4) return Case4(a.Case4.Value, b.Case4.Value);
            if (aTag == 5 && bTag == 5) return Case5(a.Case5.Value, b.Case5.Value);
            if (aTag == 6 && bTag == 6) return Case6(a.Case6.Value, b.Case6.Value);
            if (aTag == 7 && bTag == 7) return Case7(a.Case7.Value, b.Case7.Value);
            if (aTag == 8 && bTag == 8) return Case8(a.Case8.Value, b.Case8.Value);
            if (aTag == 9 && bTag == 9) return Case9(a.Case9.Value, b.Case9.Value);
            if (aTag == 10 && bTag == 10) return Case10(a.Case10.Value, b.Case10.Value);
            return Otherwise(aTag, bTag);
        }

        public static T BinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T>(this Tuple<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10, Func<int, int, T> Otherwise)
        {
            return BinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Case6, Case7, Case8, Case9, Case10, Otherwise);
        }

        public static Comparable.CompareResult CompareTo<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> self, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> other)
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
            where T4 : IComparable<T4>
            where T5 : IComparable<T5>
            where T6 : IComparable<T6>
            where T7 : IComparable<T7>
            where T8 : IComparable<T8>
            where T9 : IComparable<T9>
            where T10 : IComparable<T10>
        {
            return BinOp(self, other, (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b));
        }

        public static IComparer<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> Comparer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>()
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
            where T4 : IComparable<T4>
            where T5 : IComparable<T5>
            where T6 : IComparable<T6>
            where T7 : IComparable<T7>
            where T8 : IComparable<T8>
            where T9 : IComparable<T9>
            where T10 : IComparable<T10>
        {
            return new Comparer<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>((a, b) => a.CompareTo(b).Match(() => -1, () => 0, () => 1));
        }
        public static T BinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T>(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> b, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10, Func<T11, T11, T> Case11, Func<int, int, T> Otherwise)
        {
            var aTag = a.TagIndex;
            var bTag = b.TagIndex;
            if (aTag == 1 && bTag == 1) return Case1(a.Case1.Value, b.Case1.Value);
            if (aTag == 2 && bTag == 2) return Case2(a.Case2.Value, b.Case2.Value);
            if (aTag == 3 && bTag == 3) return Case3(a.Case3.Value, b.Case3.Value);
            if (aTag == 4 && bTag == 4) return Case4(a.Case4.Value, b.Case4.Value);
            if (aTag == 5 && bTag == 5) return Case5(a.Case5.Value, b.Case5.Value);
            if (aTag == 6 && bTag == 6) return Case6(a.Case6.Value, b.Case6.Value);
            if (aTag == 7 && bTag == 7) return Case7(a.Case7.Value, b.Case7.Value);
            if (aTag == 8 && bTag == 8) return Case8(a.Case8.Value, b.Case8.Value);
            if (aTag == 9 && bTag == 9) return Case9(a.Case9.Value, b.Case9.Value);
            if (aTag == 10 && bTag == 10) return Case10(a.Case10.Value, b.Case10.Value);
            if (aTag == 11 && bTag == 11) return Case11(a.Case11.Value, b.Case11.Value);
            return Otherwise(aTag, bTag);
        }

        public static T BinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T>(this Tuple<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10, Func<T11, T11, T> Case11, Func<int, int, T> Otherwise)
        {
            return BinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Case6, Case7, Case8, Case9, Case10, Case11, Otherwise);
        }

        public static Comparable.CompareResult CompareTo<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> self, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> other)
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
            where T4 : IComparable<T4>
            where T5 : IComparable<T5>
            where T6 : IComparable<T6>
            where T7 : IComparable<T7>
            where T8 : IComparable<T8>
            where T9 : IComparable<T9>
            where T10 : IComparable<T10>
            where T11 : IComparable<T11>
        {
            return BinOp(self, other, (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b));
        }

        public static IComparer<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> Comparer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>()
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
            where T4 : IComparable<T4>
            where T5 : IComparable<T5>
            where T6 : IComparable<T6>
            where T7 : IComparable<T7>
            where T8 : IComparable<T8>
            where T9 : IComparable<T9>
            where T10 : IComparable<T10>
            where T11 : IComparable<T11>
        {
            return new Comparer<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>((a, b) => a.CompareTo(b).Match(() => -1, () => 0, () => 1));
        }
        public static T BinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T>(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> b, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10, Func<T11, T11, T> Case11, Func<T12, T12, T> Case12, Func<int, int, T> Otherwise)
        {
            var aTag = a.TagIndex;
            var bTag = b.TagIndex;
            if (aTag == 1 && bTag == 1) return Case1(a.Case1.Value, b.Case1.Value);
            if (aTag == 2 && bTag == 2) return Case2(a.Case2.Value, b.Case2.Value);
            if (aTag == 3 && bTag == 3) return Case3(a.Case3.Value, b.Case3.Value);
            if (aTag == 4 && bTag == 4) return Case4(a.Case4.Value, b.Case4.Value);
            if (aTag == 5 && bTag == 5) return Case5(a.Case5.Value, b.Case5.Value);
            if (aTag == 6 && bTag == 6) return Case6(a.Case6.Value, b.Case6.Value);
            if (aTag == 7 && bTag == 7) return Case7(a.Case7.Value, b.Case7.Value);
            if (aTag == 8 && bTag == 8) return Case8(a.Case8.Value, b.Case8.Value);
            if (aTag == 9 && bTag == 9) return Case9(a.Case9.Value, b.Case9.Value);
            if (aTag == 10 && bTag == 10) return Case10(a.Case10.Value, b.Case10.Value);
            if (aTag == 11 && bTag == 11) return Case11(a.Case11.Value, b.Case11.Value);
            if (aTag == 12 && bTag == 12) return Case12(a.Case12.Value, b.Case12.Value);
            return Otherwise(aTag, bTag);
        }

        public static T BinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T>(this Tuple<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10, Func<T11, T11, T> Case11, Func<T12, T12, T> Case12, Func<int, int, T> Otherwise)
        {
            return BinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Case6, Case7, Case8, Case9, Case10, Case11, Case12, Otherwise);
        }

        public static Comparable.CompareResult CompareTo<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> self, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> other)
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
            where T4 : IComparable<T4>
            where T5 : IComparable<T5>
            where T6 : IComparable<T6>
            where T7 : IComparable<T7>
            where T8 : IComparable<T8>
            where T9 : IComparable<T9>
            where T10 : IComparable<T10>
            where T11 : IComparable<T11>
            where T12 : IComparable<T12>
        {
            return BinOp(self, other, (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b));
        }

        public static IComparer<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> Comparer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>()
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
            where T4 : IComparable<T4>
            where T5 : IComparable<T5>
            where T6 : IComparable<T6>
            where T7 : IComparable<T7>
            where T8 : IComparable<T8>
            where T9 : IComparable<T9>
            where T10 : IComparable<T10>
            where T11 : IComparable<T11>
            where T12 : IComparable<T12>
        {
            return new Comparer<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>((a, b) => a.CompareTo(b).Match(() => -1, () => 0, () => 1));
        }
        public static T BinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T>(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> b, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10, Func<T11, T11, T> Case11, Func<T12, T12, T> Case12, Func<T13, T13, T> Case13, Func<int, int, T> Otherwise)
        {
            var aTag = a.TagIndex;
            var bTag = b.TagIndex;
            if (aTag == 1 && bTag == 1) return Case1(a.Case1.Value, b.Case1.Value);
            if (aTag == 2 && bTag == 2) return Case2(a.Case2.Value, b.Case2.Value);
            if (aTag == 3 && bTag == 3) return Case3(a.Case3.Value, b.Case3.Value);
            if (aTag == 4 && bTag == 4) return Case4(a.Case4.Value, b.Case4.Value);
            if (aTag == 5 && bTag == 5) return Case5(a.Case5.Value, b.Case5.Value);
            if (aTag == 6 && bTag == 6) return Case6(a.Case6.Value, b.Case6.Value);
            if (aTag == 7 && bTag == 7) return Case7(a.Case7.Value, b.Case7.Value);
            if (aTag == 8 && bTag == 8) return Case8(a.Case8.Value, b.Case8.Value);
            if (aTag == 9 && bTag == 9) return Case9(a.Case9.Value, b.Case9.Value);
            if (aTag == 10 && bTag == 10) return Case10(a.Case10.Value, b.Case10.Value);
            if (aTag == 11 && bTag == 11) return Case11(a.Case11.Value, b.Case11.Value);
            if (aTag == 12 && bTag == 12) return Case12(a.Case12.Value, b.Case12.Value);
            if (aTag == 13 && bTag == 13) return Case13(a.Case13.Value, b.Case13.Value);
            return Otherwise(aTag, bTag);
        }

        public static T BinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T>(this Tuple<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10, Func<T11, T11, T> Case11, Func<T12, T12, T> Case12, Func<T13, T13, T> Case13, Func<int, int, T> Otherwise)
        {
            return BinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Case6, Case7, Case8, Case9, Case10, Case11, Case12, Case13, Otherwise);
        }

        public static Comparable.CompareResult CompareTo<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> self, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> other)
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
            where T4 : IComparable<T4>
            where T5 : IComparable<T5>
            where T6 : IComparable<T6>
            where T7 : IComparable<T7>
            where T8 : IComparable<T8>
            where T9 : IComparable<T9>
            where T10 : IComparable<T10>
            where T11 : IComparable<T11>
            where T12 : IComparable<T12>
            where T13 : IComparable<T13>
        {
            return BinOp(self, other, (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b));
        }

        public static IComparer<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> Comparer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>()
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
            where T4 : IComparable<T4>
            where T5 : IComparable<T5>
            where T6 : IComparable<T6>
            where T7 : IComparable<T7>
            where T8 : IComparable<T8>
            where T9 : IComparable<T9>
            where T10 : IComparable<T10>
            where T11 : IComparable<T11>
            where T12 : IComparable<T12>
            where T13 : IComparable<T13>
        {
            return new Comparer<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>((a, b) => a.CompareTo(b).Match(() => -1, () => 0, () => 1));
        }
        public static T BinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T>(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> b, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10, Func<T11, T11, T> Case11, Func<T12, T12, T> Case12, Func<T13, T13, T> Case13, Func<T14, T14, T> Case14, Func<int, int, T> Otherwise)
        {
            var aTag = a.TagIndex;
            var bTag = b.TagIndex;
            if (aTag == 1 && bTag == 1) return Case1(a.Case1.Value, b.Case1.Value);
            if (aTag == 2 && bTag == 2) return Case2(a.Case2.Value, b.Case2.Value);
            if (aTag == 3 && bTag == 3) return Case3(a.Case3.Value, b.Case3.Value);
            if (aTag == 4 && bTag == 4) return Case4(a.Case4.Value, b.Case4.Value);
            if (aTag == 5 && bTag == 5) return Case5(a.Case5.Value, b.Case5.Value);
            if (aTag == 6 && bTag == 6) return Case6(a.Case6.Value, b.Case6.Value);
            if (aTag == 7 && bTag == 7) return Case7(a.Case7.Value, b.Case7.Value);
            if (aTag == 8 && bTag == 8) return Case8(a.Case8.Value, b.Case8.Value);
            if (aTag == 9 && bTag == 9) return Case9(a.Case9.Value, b.Case9.Value);
            if (aTag == 10 && bTag == 10) return Case10(a.Case10.Value, b.Case10.Value);
            if (aTag == 11 && bTag == 11) return Case11(a.Case11.Value, b.Case11.Value);
            if (aTag == 12 && bTag == 12) return Case12(a.Case12.Value, b.Case12.Value);
            if (aTag == 13 && bTag == 13) return Case13(a.Case13.Value, b.Case13.Value);
            if (aTag == 14 && bTag == 14) return Case14(a.Case14.Value, b.Case14.Value);
            return Otherwise(aTag, bTag);
        }

        public static T BinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T>(this Tuple<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10, Func<T11, T11, T> Case11, Func<T12, T12, T> Case12, Func<T13, T13, T> Case13, Func<T14, T14, T> Case14, Func<int, int, T> Otherwise)
        {
            return BinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Case6, Case7, Case8, Case9, Case10, Case11, Case12, Case13, Case14, Otherwise);
        }

        public static Comparable.CompareResult CompareTo<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> self, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> other)
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
            where T4 : IComparable<T4>
            where T5 : IComparable<T5>
            where T6 : IComparable<T6>
            where T7 : IComparable<T7>
            where T8 : IComparable<T8>
            where T9 : IComparable<T9>
            where T10 : IComparable<T10>
            where T11 : IComparable<T11>
            where T12 : IComparable<T12>
            where T13 : IComparable<T13>
            where T14 : IComparable<T14>
        {
            return BinOp(self, other, (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b));
        }

        public static IComparer<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> Comparer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>()
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
            where T4 : IComparable<T4>
            where T5 : IComparable<T5>
            where T6 : IComparable<T6>
            where T7 : IComparable<T7>
            where T8 : IComparable<T8>
            where T9 : IComparable<T9>
            where T10 : IComparable<T10>
            where T11 : IComparable<T11>
            where T12 : IComparable<T12>
            where T13 : IComparable<T13>
            where T14 : IComparable<T14>
        {
            return new Comparer<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>((a, b) => a.CompareTo(b).Match(() => -1, () => 0, () => 1));
        }
        public static T BinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T>(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> b, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10, Func<T11, T11, T> Case11, Func<T12, T12, T> Case12, Func<T13, T13, T> Case13, Func<T14, T14, T> Case14, Func<T15, T15, T> Case15, Func<int, int, T> Otherwise)
        {
            var aTag = a.TagIndex;
            var bTag = b.TagIndex;
            if (aTag == 1 && bTag == 1) return Case1(a.Case1.Value, b.Case1.Value);
            if (aTag == 2 && bTag == 2) return Case2(a.Case2.Value, b.Case2.Value);
            if (aTag == 3 && bTag == 3) return Case3(a.Case3.Value, b.Case3.Value);
            if (aTag == 4 && bTag == 4) return Case4(a.Case4.Value, b.Case4.Value);
            if (aTag == 5 && bTag == 5) return Case5(a.Case5.Value, b.Case5.Value);
            if (aTag == 6 && bTag == 6) return Case6(a.Case6.Value, b.Case6.Value);
            if (aTag == 7 && bTag == 7) return Case7(a.Case7.Value, b.Case7.Value);
            if (aTag == 8 && bTag == 8) return Case8(a.Case8.Value, b.Case8.Value);
            if (aTag == 9 && bTag == 9) return Case9(a.Case9.Value, b.Case9.Value);
            if (aTag == 10 && bTag == 10) return Case10(a.Case10.Value, b.Case10.Value);
            if (aTag == 11 && bTag == 11) return Case11(a.Case11.Value, b.Case11.Value);
            if (aTag == 12 && bTag == 12) return Case12(a.Case12.Value, b.Case12.Value);
            if (aTag == 13 && bTag == 13) return Case13(a.Case13.Value, b.Case13.Value);
            if (aTag == 14 && bTag == 14) return Case14(a.Case14.Value, b.Case14.Value);
            if (aTag == 15 && bTag == 15) return Case15(a.Case15.Value, b.Case15.Value);
            return Otherwise(aTag, bTag);
        }

        public static T BinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T>(this Tuple<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10, Func<T11, T11, T> Case11, Func<T12, T12, T> Case12, Func<T13, T13, T> Case13, Func<T14, T14, T> Case14, Func<T15, T15, T> Case15, Func<int, int, T> Otherwise)
        {
            return BinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Case6, Case7, Case8, Case9, Case10, Case11, Case12, Case13, Case14, Case15, Otherwise);
        }

        public static Comparable.CompareResult CompareTo<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> self, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> other)
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
            where T4 : IComparable<T4>
            where T5 : IComparable<T5>
            where T6 : IComparable<T6>
            where T7 : IComparable<T7>
            where T8 : IComparable<T8>
            where T9 : IComparable<T9>
            where T10 : IComparable<T10>
            where T11 : IComparable<T11>
            where T12 : IComparable<T12>
            where T13 : IComparable<T13>
            where T14 : IComparable<T14>
            where T15 : IComparable<T15>
        {
            return BinOp(self, other, (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b));
        }

        public static IComparer<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> Comparer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>()
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
            where T4 : IComparable<T4>
            where T5 : IComparable<T5>
            where T6 : IComparable<T6>
            where T7 : IComparable<T7>
            where T8 : IComparable<T8>
            where T9 : IComparable<T9>
            where T10 : IComparable<T10>
            where T11 : IComparable<T11>
            where T12 : IComparable<T12>
            where T13 : IComparable<T13>
            where T14 : IComparable<T14>
            where T15 : IComparable<T15>
        {
            return new Comparer<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>((a, b) => a.CompareTo(b).Match(() => -1, () => 0, () => 1));
        }
        public static T BinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T>(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> b, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10, Func<T11, T11, T> Case11, Func<T12, T12, T> Case12, Func<T13, T13, T> Case13, Func<T14, T14, T> Case14, Func<T15, T15, T> Case15, Func<T16, T16, T> Case16, Func<int, int, T> Otherwise)
        {
            var aTag = a.TagIndex;
            var bTag = b.TagIndex;
            if (aTag == 1 && bTag == 1) return Case1(a.Case1.Value, b.Case1.Value);
            if (aTag == 2 && bTag == 2) return Case2(a.Case2.Value, b.Case2.Value);
            if (aTag == 3 && bTag == 3) return Case3(a.Case3.Value, b.Case3.Value);
            if (aTag == 4 && bTag == 4) return Case4(a.Case4.Value, b.Case4.Value);
            if (aTag == 5 && bTag == 5) return Case5(a.Case5.Value, b.Case5.Value);
            if (aTag == 6 && bTag == 6) return Case6(a.Case6.Value, b.Case6.Value);
            if (aTag == 7 && bTag == 7) return Case7(a.Case7.Value, b.Case7.Value);
            if (aTag == 8 && bTag == 8) return Case8(a.Case8.Value, b.Case8.Value);
            if (aTag == 9 && bTag == 9) return Case9(a.Case9.Value, b.Case9.Value);
            if (aTag == 10 && bTag == 10) return Case10(a.Case10.Value, b.Case10.Value);
            if (aTag == 11 && bTag == 11) return Case11(a.Case11.Value, b.Case11.Value);
            if (aTag == 12 && bTag == 12) return Case12(a.Case12.Value, b.Case12.Value);
            if (aTag == 13 && bTag == 13) return Case13(a.Case13.Value, b.Case13.Value);
            if (aTag == 14 && bTag == 14) return Case14(a.Case14.Value, b.Case14.Value);
            if (aTag == 15 && bTag == 15) return Case15(a.Case15.Value, b.Case15.Value);
            if (aTag == 16 && bTag == 16) return Case16(a.Case16.Value, b.Case16.Value);
            return Otherwise(aTag, bTag);
        }

        public static T BinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T>(this Tuple<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10, Func<T11, T11, T> Case11, Func<T12, T12, T> Case12, Func<T13, T13, T> Case13, Func<T14, T14, T> Case14, Func<T15, T15, T> Case15, Func<T16, T16, T> Case16, Func<int, int, T> Otherwise)
        {
            return BinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Case6, Case7, Case8, Case9, Case10, Case11, Case12, Case13, Case14, Case15, Case16, Otherwise);
        }

        public static Comparable.CompareResult CompareTo<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> self, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> other)
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
            where T4 : IComparable<T4>
            where T5 : IComparable<T5>
            where T6 : IComparable<T6>
            where T7 : IComparable<T7>
            where T8 : IComparable<T8>
            where T9 : IComparable<T9>
            where T10 : IComparable<T10>
            where T11 : IComparable<T11>
            where T12 : IComparable<T12>
            where T13 : IComparable<T13>
            where T14 : IComparable<T14>
            where T15 : IComparable<T15>
            where T16 : IComparable<T16>
        {
            return BinOp(self, other, (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b));
        }

        public static IComparer<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> Comparer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>()
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
            where T4 : IComparable<T4>
            where T5 : IComparable<T5>
            where T6 : IComparable<T6>
            where T7 : IComparable<T7>
            where T8 : IComparable<T8>
            where T9 : IComparable<T9>
            where T10 : IComparable<T10>
            where T11 : IComparable<T11>
            where T12 : IComparable<T12>
            where T13 : IComparable<T13>
            where T14 : IComparable<T14>
            where T15 : IComparable<T15>
            where T16 : IComparable<T16>
        {
            return new Comparer<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>((a, b) => a.CompareTo(b).Match(() => -1, () => 0, () => 1));
        }
    }
}
