
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace LangExt
{
    /// <summary>
    /// Choiceに対する操作を提供します。
    /// </summary>
    public static partial class Choice
    {
        /// <summary>
        /// T1を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2> Create<T1, T2>(T1 value)
        {
            return new Choice<T1, T2>(value);
        }

        /// <summary>
        /// T2を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2> Create<T1, T2>(T2 value)
        {
            return new Choice<T1, T2>(value);
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]に対して、二項演算の適用を試みます。
        /// 保持する型が2つのオブジェクトで異なる場合、Noneが返されます。
        /// </summary>
        public static Option<T> TryBinOp<T1, T2, T>(Choice<T1, T2> a, Choice<T1, T2> b, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2)
        {
            var aTag = a.TagIndex;
            var bTag = b.TagIndex;
            if (aTag == 1 && bTag == 1) return Option.Some(Case1(a.Case1.Value, b.Case1.Value));
            if (aTag == 2 && bTag == 2) return Option.Some(Case2(a.Case2.Value, b.Case2.Value));
            return Option.None;
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]のタプルに対して、二項演算の適用を試みます。
        /// 保持する型が2つのオブジェクトで異なる場合、Noneが返されます。
        /// </summary>
        public static Option<T> TryBinOp<T1, T2, T>(this Tuple<Choice<T1, T2>, Choice<T1, T2>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2)
        {
            return TryBinOp(self.Item1, self.Item2, Case1, Case2);
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]に対して、二項演算を適用します。
        /// 保持する型が2つのオブジェクトで異なる場合、保持する型のインデックスが渡される関数が呼び出されます。
        /// </summary>
        public static T BinOp<T1, T2, T>(Choice<T1, T2> a, Choice<T1, T2> b, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<int, int, T> Otherwise)
        {
            var aTag = a.TagIndex;
            var bTag = b.TagIndex;
            if (aTag == 1 && bTag == 1) return Case1(a.Case1.Value, b.Case1.Value);
            if (aTag == 2 && bTag == 2) return Case2(a.Case2.Value, b.Case2.Value);
            return Otherwise(aTag, bTag);
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]のタプルに対して、二項演算を適用します。
        /// 保持する型が2つのオブジェクトで異なる場合、保持する型のインデックスが渡される関数が呼び出されます。
        /// </summary>
        public static T BinOp<T1, T2, T>(this Tuple<Choice<T1, T2>, Choice<T1, T2>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<int, int, T> Otherwise)
        {
            return BinOp(self.Item1, self.Item2, Case1, Case2, Otherwise);
        }

        /// <summary>
        /// 全ての型パラメータがIComparable[T]を実装するChoice[...]どうしの大小関係を判断して返します。
        /// </summary>
        public static Comparable.CompareResult CompareTo<T1, T2>(this Choice<T1, T2> self, Choice<T1, T2> other)
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
        {
            return BinOp(self, other, (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b));
        }

        /// <summary>
        /// 全ての型パラメータがIComparable[T]を実装するChoice[...]を比較するためのIComparer[Choice[...]]を取得します。
        /// </summary>
        public static IComparer<Choice<T1, T2>> Comparer<T1, T2>()
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
        {
            return new Comparer<Choice<T1, T2>>((a, b) => a.CompareTo(b).Match(() => -1, () => 0, () => 1));
        }
        /// <summary>
        /// T1を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3> Create<T1, T2, T3>(T1 value)
        {
            return new Choice<T1, T2, T3>(value);
        }

        /// <summary>
        /// T2を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3> Create<T1, T2, T3>(T2 value)
        {
            return new Choice<T1, T2, T3>(value);
        }

        /// <summary>
        /// T3を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3> Create<T1, T2, T3>(T3 value)
        {
            return new Choice<T1, T2, T3>(value);
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]に対して、二項演算の適用を試みます。
        /// 保持する型が2つのオブジェクトで異なる場合、Noneが返されます。
        /// </summary>
        public static Option<T> TryBinOp<T1, T2, T3, T>(Choice<T1, T2, T3> a, Choice<T1, T2, T3> b, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3)
        {
            var aTag = a.TagIndex;
            var bTag = b.TagIndex;
            if (aTag == 1 && bTag == 1) return Option.Some(Case1(a.Case1.Value, b.Case1.Value));
            if (aTag == 2 && bTag == 2) return Option.Some(Case2(a.Case2.Value, b.Case2.Value));
            if (aTag == 3 && bTag == 3) return Option.Some(Case3(a.Case3.Value, b.Case3.Value));
            return Option.None;
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]のタプルに対して、二項演算の適用を試みます。
        /// 保持する型が2つのオブジェクトで異なる場合、Noneが返されます。
        /// </summary>
        public static Option<T> TryBinOp<T1, T2, T3, T>(this Tuple<Choice<T1, T2, T3>, Choice<T1, T2, T3>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3)
        {
            return TryBinOp(self.Item1, self.Item2, Case1, Case2, Case3);
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]に対して、二項演算を適用します。
        /// 保持する型が2つのオブジェクトで異なる場合、保持する型のインデックスが渡される関数が呼び出されます。
        /// </summary>
        public static T BinOp<T1, T2, T3, T>(Choice<T1, T2, T3> a, Choice<T1, T2, T3> b, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<int, int, T> Otherwise)
        {
            var aTag = a.TagIndex;
            var bTag = b.TagIndex;
            if (aTag == 1 && bTag == 1) return Case1(a.Case1.Value, b.Case1.Value);
            if (aTag == 2 && bTag == 2) return Case2(a.Case2.Value, b.Case2.Value);
            if (aTag == 3 && bTag == 3) return Case3(a.Case3.Value, b.Case3.Value);
            return Otherwise(aTag, bTag);
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]のタプルに対して、二項演算を適用します。
        /// 保持する型が2つのオブジェクトで異なる場合、保持する型のインデックスが渡される関数が呼び出されます。
        /// </summary>
        public static T BinOp<T1, T2, T3, T>(this Tuple<Choice<T1, T2, T3>, Choice<T1, T2, T3>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<int, int, T> Otherwise)
        {
            return BinOp(self.Item1, self.Item2, Case1, Case2, Case3, Otherwise);
        }

        /// <summary>
        /// 全ての型パラメータがIComparable[T]を実装するChoice[...]どうしの大小関係を判断して返します。
        /// </summary>
        public static Comparable.CompareResult CompareTo<T1, T2, T3>(this Choice<T1, T2, T3> self, Choice<T1, T2, T3> other)
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
        {
            return BinOp(self, other, (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b));
        }

        /// <summary>
        /// 全ての型パラメータがIComparable[T]を実装するChoice[...]を比較するためのIComparer[Choice[...]]を取得します。
        /// </summary>
        public static IComparer<Choice<T1, T2, T3>> Comparer<T1, T2, T3>()
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
        {
            return new Comparer<Choice<T1, T2, T3>>((a, b) => a.CompareTo(b).Match(() => -1, () => 0, () => 1));
        }
        /// <summary>
        /// T1を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4> Create<T1, T2, T3, T4>(T1 value)
        {
            return new Choice<T1, T2, T3, T4>(value);
        }

        /// <summary>
        /// T2を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4> Create<T1, T2, T3, T4>(T2 value)
        {
            return new Choice<T1, T2, T3, T4>(value);
        }

        /// <summary>
        /// T3を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4> Create<T1, T2, T3, T4>(T3 value)
        {
            return new Choice<T1, T2, T3, T4>(value);
        }

        /// <summary>
        /// T4を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4> Create<T1, T2, T3, T4>(T4 value)
        {
            return new Choice<T1, T2, T3, T4>(value);
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]に対して、二項演算の適用を試みます。
        /// 保持する型が2つのオブジェクトで異なる場合、Noneが返されます。
        /// </summary>
        public static Option<T> TryBinOp<T1, T2, T3, T4, T>(Choice<T1, T2, T3, T4> a, Choice<T1, T2, T3, T4> b, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4)
        {
            var aTag = a.TagIndex;
            var bTag = b.TagIndex;
            if (aTag == 1 && bTag == 1) return Option.Some(Case1(a.Case1.Value, b.Case1.Value));
            if (aTag == 2 && bTag == 2) return Option.Some(Case2(a.Case2.Value, b.Case2.Value));
            if (aTag == 3 && bTag == 3) return Option.Some(Case3(a.Case3.Value, b.Case3.Value));
            if (aTag == 4 && bTag == 4) return Option.Some(Case4(a.Case4.Value, b.Case4.Value));
            return Option.None;
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]のタプルに対して、二項演算の適用を試みます。
        /// 保持する型が2つのオブジェクトで異なる場合、Noneが返されます。
        /// </summary>
        public static Option<T> TryBinOp<T1, T2, T3, T4, T>(this Tuple<Choice<T1, T2, T3, T4>, Choice<T1, T2, T3, T4>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4)
        {
            return TryBinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4);
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]に対して、二項演算を適用します。
        /// 保持する型が2つのオブジェクトで異なる場合、保持する型のインデックスが渡される関数が呼び出されます。
        /// </summary>
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

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]のタプルに対して、二項演算を適用します。
        /// 保持する型が2つのオブジェクトで異なる場合、保持する型のインデックスが渡される関数が呼び出されます。
        /// </summary>
        public static T BinOp<T1, T2, T3, T4, T>(this Tuple<Choice<T1, T2, T3, T4>, Choice<T1, T2, T3, T4>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<int, int, T> Otherwise)
        {
            return BinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Otherwise);
        }

        /// <summary>
        /// 全ての型パラメータがIComparable[T]を実装するChoice[...]どうしの大小関係を判断して返します。
        /// </summary>
        public static Comparable.CompareResult CompareTo<T1, T2, T3, T4>(this Choice<T1, T2, T3, T4> self, Choice<T1, T2, T3, T4> other)
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
            where T4 : IComparable<T4>
        {
            return BinOp(self, other, (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b));
        }

        /// <summary>
        /// 全ての型パラメータがIComparable[T]を実装するChoice[...]を比較するためのIComparer[Choice[...]]を取得します。
        /// </summary>
        public static IComparer<Choice<T1, T2, T3, T4>> Comparer<T1, T2, T3, T4>()
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
            where T4 : IComparable<T4>
        {
            return new Comparer<Choice<T1, T2, T3, T4>>((a, b) => a.CompareTo(b).Match(() => -1, () => 0, () => 1));
        }
        /// <summary>
        /// T1を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(T1 value)
        {
            return new Choice<T1, T2, T3, T4, T5>(value);
        }

        /// <summary>
        /// T2を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(T2 value)
        {
            return new Choice<T1, T2, T3, T4, T5>(value);
        }

        /// <summary>
        /// T3を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(T3 value)
        {
            return new Choice<T1, T2, T3, T4, T5>(value);
        }

        /// <summary>
        /// T4を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(T4 value)
        {
            return new Choice<T1, T2, T3, T4, T5>(value);
        }

        /// <summary>
        /// T5を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(T5 value)
        {
            return new Choice<T1, T2, T3, T4, T5>(value);
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]に対して、二項演算の適用を試みます。
        /// 保持する型が2つのオブジェクトで異なる場合、Noneが返されます。
        /// </summary>
        public static Option<T> TryBinOp<T1, T2, T3, T4, T5, T>(Choice<T1, T2, T3, T4, T5> a, Choice<T1, T2, T3, T4, T5> b, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5)
        {
            var aTag = a.TagIndex;
            var bTag = b.TagIndex;
            if (aTag == 1 && bTag == 1) return Option.Some(Case1(a.Case1.Value, b.Case1.Value));
            if (aTag == 2 && bTag == 2) return Option.Some(Case2(a.Case2.Value, b.Case2.Value));
            if (aTag == 3 && bTag == 3) return Option.Some(Case3(a.Case3.Value, b.Case3.Value));
            if (aTag == 4 && bTag == 4) return Option.Some(Case4(a.Case4.Value, b.Case4.Value));
            if (aTag == 5 && bTag == 5) return Option.Some(Case5(a.Case5.Value, b.Case5.Value));
            return Option.None;
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]のタプルに対して、二項演算の適用を試みます。
        /// 保持する型が2つのオブジェクトで異なる場合、Noneが返されます。
        /// </summary>
        public static Option<T> TryBinOp<T1, T2, T3, T4, T5, T>(this Tuple<Choice<T1, T2, T3, T4, T5>, Choice<T1, T2, T3, T4, T5>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5)
        {
            return TryBinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5);
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]に対して、二項演算を適用します。
        /// 保持する型が2つのオブジェクトで異なる場合、保持する型のインデックスが渡される関数が呼び出されます。
        /// </summary>
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

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]のタプルに対して、二項演算を適用します。
        /// 保持する型が2つのオブジェクトで異なる場合、保持する型のインデックスが渡される関数が呼び出されます。
        /// </summary>
        public static T BinOp<T1, T2, T3, T4, T5, T>(this Tuple<Choice<T1, T2, T3, T4, T5>, Choice<T1, T2, T3, T4, T5>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<int, int, T> Otherwise)
        {
            return BinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Otherwise);
        }

        /// <summary>
        /// 全ての型パラメータがIComparable[T]を実装するChoice[...]どうしの大小関係を判断して返します。
        /// </summary>
        public static Comparable.CompareResult CompareTo<T1, T2, T3, T4, T5>(this Choice<T1, T2, T3, T4, T5> self, Choice<T1, T2, T3, T4, T5> other)
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
            where T4 : IComparable<T4>
            where T5 : IComparable<T5>
        {
            return BinOp(self, other, (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b), (a, b) => a.Cmp(b));
        }

        /// <summary>
        /// 全ての型パラメータがIComparable[T]を実装するChoice[...]を比較するためのIComparer[Choice[...]]を取得します。
        /// </summary>
        public static IComparer<Choice<T1, T2, T3, T4, T5>> Comparer<T1, T2, T3, T4, T5>()
            where T1 : IComparable<T1>
            where T2 : IComparable<T2>
            where T3 : IComparable<T3>
            where T4 : IComparable<T4>
            where T5 : IComparable<T5>
        {
            return new Comparer<Choice<T1, T2, T3, T4, T5>>((a, b) => a.CompareTo(b).Match(() => -1, () => 0, () => 1));
        }
        /// <summary>
        /// T1を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(T1 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// T2を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(T2 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// T3を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(T3 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// T4を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(T4 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// T5を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(T5 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// T6を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(T6 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]に対して、二項演算の適用を試みます。
        /// 保持する型が2つのオブジェクトで異なる場合、Noneが返されます。
        /// </summary>
        public static Option<T> TryBinOp<T1, T2, T3, T4, T5, T6, T>(Choice<T1, T2, T3, T4, T5, T6> a, Choice<T1, T2, T3, T4, T5, T6> b, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6)
        {
            var aTag = a.TagIndex;
            var bTag = b.TagIndex;
            if (aTag == 1 && bTag == 1) return Option.Some(Case1(a.Case1.Value, b.Case1.Value));
            if (aTag == 2 && bTag == 2) return Option.Some(Case2(a.Case2.Value, b.Case2.Value));
            if (aTag == 3 && bTag == 3) return Option.Some(Case3(a.Case3.Value, b.Case3.Value));
            if (aTag == 4 && bTag == 4) return Option.Some(Case4(a.Case4.Value, b.Case4.Value));
            if (aTag == 5 && bTag == 5) return Option.Some(Case5(a.Case5.Value, b.Case5.Value));
            if (aTag == 6 && bTag == 6) return Option.Some(Case6(a.Case6.Value, b.Case6.Value));
            return Option.None;
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]のタプルに対して、二項演算の適用を試みます。
        /// 保持する型が2つのオブジェクトで異なる場合、Noneが返されます。
        /// </summary>
        public static Option<T> TryBinOp<T1, T2, T3, T4, T5, T6, T>(this Tuple<Choice<T1, T2, T3, T4, T5, T6>, Choice<T1, T2, T3, T4, T5, T6>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6)
        {
            return TryBinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Case6);
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]に対して、二項演算を適用します。
        /// 保持する型が2つのオブジェクトで異なる場合、保持する型のインデックスが渡される関数が呼び出されます。
        /// </summary>
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

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]のタプルに対して、二項演算を適用します。
        /// 保持する型が2つのオブジェクトで異なる場合、保持する型のインデックスが渡される関数が呼び出されます。
        /// </summary>
        public static T BinOp<T1, T2, T3, T4, T5, T6, T>(this Tuple<Choice<T1, T2, T3, T4, T5, T6>, Choice<T1, T2, T3, T4, T5, T6>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<int, int, T> Otherwise)
        {
            return BinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Case6, Otherwise);
        }

        /// <summary>
        /// 全ての型パラメータがIComparable[T]を実装するChoice[...]どうしの大小関係を判断して返します。
        /// </summary>
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

        /// <summary>
        /// 全ての型パラメータがIComparable[T]を実装するChoice[...]を比較するためのIComparer[Choice[...]]を取得します。
        /// </summary>
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
        /// <summary>
        /// T1を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(T1 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// T2を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(T2 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// T3を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(T3 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// T4を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(T4 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// T5を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(T5 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// T6を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(T6 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// T7を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(T7 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]に対して、二項演算の適用を試みます。
        /// 保持する型が2つのオブジェクトで異なる場合、Noneが返されます。
        /// </summary>
        public static Option<T> TryBinOp<T1, T2, T3, T4, T5, T6, T7, T>(Choice<T1, T2, T3, T4, T5, T6, T7> a, Choice<T1, T2, T3, T4, T5, T6, T7> b, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7)
        {
            var aTag = a.TagIndex;
            var bTag = b.TagIndex;
            if (aTag == 1 && bTag == 1) return Option.Some(Case1(a.Case1.Value, b.Case1.Value));
            if (aTag == 2 && bTag == 2) return Option.Some(Case2(a.Case2.Value, b.Case2.Value));
            if (aTag == 3 && bTag == 3) return Option.Some(Case3(a.Case3.Value, b.Case3.Value));
            if (aTag == 4 && bTag == 4) return Option.Some(Case4(a.Case4.Value, b.Case4.Value));
            if (aTag == 5 && bTag == 5) return Option.Some(Case5(a.Case5.Value, b.Case5.Value));
            if (aTag == 6 && bTag == 6) return Option.Some(Case6(a.Case6.Value, b.Case6.Value));
            if (aTag == 7 && bTag == 7) return Option.Some(Case7(a.Case7.Value, b.Case7.Value));
            return Option.None;
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]のタプルに対して、二項演算の適用を試みます。
        /// 保持する型が2つのオブジェクトで異なる場合、Noneが返されます。
        /// </summary>
        public static Option<T> TryBinOp<T1, T2, T3, T4, T5, T6, T7, T>(this Tuple<Choice<T1, T2, T3, T4, T5, T6, T7>, Choice<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7)
        {
            return TryBinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Case6, Case7);
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]に対して、二項演算を適用します。
        /// 保持する型が2つのオブジェクトで異なる場合、保持する型のインデックスが渡される関数が呼び出されます。
        /// </summary>
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

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]のタプルに対して、二項演算を適用します。
        /// 保持する型が2つのオブジェクトで異なる場合、保持する型のインデックスが渡される関数が呼び出されます。
        /// </summary>
        public static T BinOp<T1, T2, T3, T4, T5, T6, T7, T>(this Tuple<Choice<T1, T2, T3, T4, T5, T6, T7>, Choice<T1, T2, T3, T4, T5, T6, T7>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<int, int, T> Otherwise)
        {
            return BinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Case6, Case7, Otherwise);
        }

        /// <summary>
        /// 全ての型パラメータがIComparable[T]を実装するChoice[...]どうしの大小関係を判断して返します。
        /// </summary>
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

        /// <summary>
        /// 全ての型パラメータがIComparable[T]を実装するChoice[...]を比較するためのIComparer[Choice[...]]を取得します。
        /// </summary>
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
        /// <summary>
        /// T1を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8> Create<T1, T2, T3, T4, T5, T6, T7, T8>(T1 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// T2を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8> Create<T1, T2, T3, T4, T5, T6, T7, T8>(T2 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// T3を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8> Create<T1, T2, T3, T4, T5, T6, T7, T8>(T3 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// T4を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8> Create<T1, T2, T3, T4, T5, T6, T7, T8>(T4 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// T5を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8> Create<T1, T2, T3, T4, T5, T6, T7, T8>(T5 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// T6を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8> Create<T1, T2, T3, T4, T5, T6, T7, T8>(T6 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// T7を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8> Create<T1, T2, T3, T4, T5, T6, T7, T8>(T7 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// T8を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8> Create<T1, T2, T3, T4, T5, T6, T7, T8>(T8 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]に対して、二項演算の適用を試みます。
        /// 保持する型が2つのオブジェクトで異なる場合、Noneが返されます。
        /// </summary>
        public static Option<T> TryBinOp<T1, T2, T3, T4, T5, T6, T7, T8, T>(Choice<T1, T2, T3, T4, T5, T6, T7, T8> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8> b, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8)
        {
            var aTag = a.TagIndex;
            var bTag = b.TagIndex;
            if (aTag == 1 && bTag == 1) return Option.Some(Case1(a.Case1.Value, b.Case1.Value));
            if (aTag == 2 && bTag == 2) return Option.Some(Case2(a.Case2.Value, b.Case2.Value));
            if (aTag == 3 && bTag == 3) return Option.Some(Case3(a.Case3.Value, b.Case3.Value));
            if (aTag == 4 && bTag == 4) return Option.Some(Case4(a.Case4.Value, b.Case4.Value));
            if (aTag == 5 && bTag == 5) return Option.Some(Case5(a.Case5.Value, b.Case5.Value));
            if (aTag == 6 && bTag == 6) return Option.Some(Case6(a.Case6.Value, b.Case6.Value));
            if (aTag == 7 && bTag == 7) return Option.Some(Case7(a.Case7.Value, b.Case7.Value));
            if (aTag == 8 && bTag == 8) return Option.Some(Case8(a.Case8.Value, b.Case8.Value));
            return Option.None;
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]のタプルに対して、二項演算の適用を試みます。
        /// 保持する型が2つのオブジェクトで異なる場合、Noneが返されます。
        /// </summary>
        public static Option<T> TryBinOp<T1, T2, T3, T4, T5, T6, T7, T8, T>(this Tuple<Choice<T1, T2, T3, T4, T5, T6, T7, T8>, Choice<T1, T2, T3, T4, T5, T6, T7, T8>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8)
        {
            return TryBinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Case6, Case7, Case8);
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]に対して、二項演算を適用します。
        /// 保持する型が2つのオブジェクトで異なる場合、保持する型のインデックスが渡される関数が呼び出されます。
        /// </summary>
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

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]のタプルに対して、二項演算を適用します。
        /// 保持する型が2つのオブジェクトで異なる場合、保持する型のインデックスが渡される関数が呼び出されます。
        /// </summary>
        public static T BinOp<T1, T2, T3, T4, T5, T6, T7, T8, T>(this Tuple<Choice<T1, T2, T3, T4, T5, T6, T7, T8>, Choice<T1, T2, T3, T4, T5, T6, T7, T8>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<int, int, T> Otherwise)
        {
            return BinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Case6, Case7, Case8, Otherwise);
        }

        /// <summary>
        /// 全ての型パラメータがIComparable[T]を実装するChoice[...]どうしの大小関係を判断して返します。
        /// </summary>
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

        /// <summary>
        /// 全ての型パラメータがIComparable[T]を実装するChoice[...]を比較するためのIComparer[Choice[...]]を取得します。
        /// </summary>
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
        /// <summary>
        /// T1を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// T2を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T2 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// T3を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T3 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// T4を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T4 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// T5を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T5 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// T6を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T6 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// T7を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T7 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// T8を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T8 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// T9を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T9 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]に対して、二項演算の適用を試みます。
        /// 保持する型が2つのオブジェクトで異なる場合、Noneが返されます。
        /// </summary>
        public static Option<T> TryBinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T>(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9> b, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9)
        {
            var aTag = a.TagIndex;
            var bTag = b.TagIndex;
            if (aTag == 1 && bTag == 1) return Option.Some(Case1(a.Case1.Value, b.Case1.Value));
            if (aTag == 2 && bTag == 2) return Option.Some(Case2(a.Case2.Value, b.Case2.Value));
            if (aTag == 3 && bTag == 3) return Option.Some(Case3(a.Case3.Value, b.Case3.Value));
            if (aTag == 4 && bTag == 4) return Option.Some(Case4(a.Case4.Value, b.Case4.Value));
            if (aTag == 5 && bTag == 5) return Option.Some(Case5(a.Case5.Value, b.Case5.Value));
            if (aTag == 6 && bTag == 6) return Option.Some(Case6(a.Case6.Value, b.Case6.Value));
            if (aTag == 7 && bTag == 7) return Option.Some(Case7(a.Case7.Value, b.Case7.Value));
            if (aTag == 8 && bTag == 8) return Option.Some(Case8(a.Case8.Value, b.Case8.Value));
            if (aTag == 9 && bTag == 9) return Option.Some(Case9(a.Case9.Value, b.Case9.Value));
            return Option.None;
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]のタプルに対して、二項演算の適用を試みます。
        /// 保持する型が2つのオブジェクトで異なる場合、Noneが返されます。
        /// </summary>
        public static Option<T> TryBinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T>(this Tuple<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9)
        {
            return TryBinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Case6, Case7, Case8, Case9);
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]に対して、二項演算を適用します。
        /// 保持する型が2つのオブジェクトで異なる場合、保持する型のインデックスが渡される関数が呼び出されます。
        /// </summary>
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

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]のタプルに対して、二項演算を適用します。
        /// 保持する型が2つのオブジェクトで異なる場合、保持する型のインデックスが渡される関数が呼び出されます。
        /// </summary>
        public static T BinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T>(this Tuple<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<int, int, T> Otherwise)
        {
            return BinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Case6, Case7, Case8, Case9, Otherwise);
        }

        /// <summary>
        /// 全ての型パラメータがIComparable[T]を実装するChoice[...]どうしの大小関係を判断して返します。
        /// </summary>
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

        /// <summary>
        /// 全ての型パラメータがIComparable[T]を実装するChoice[...]を比較するためのIComparer[Choice[...]]を取得します。
        /// </summary>
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
        /// <summary>
        /// T1を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// T2を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T2 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// T3を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T3 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// T4を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T4 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// T5を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T5 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// T6を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T6 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// T7を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T7 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// T8を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T8 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// T9を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T9 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// T10を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T10 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]に対して、二項演算の適用を試みます。
        /// 保持する型が2つのオブジェクトで異なる場合、Noneが返されます。
        /// </summary>
        public static Option<T> TryBinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T>(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> b, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10)
        {
            var aTag = a.TagIndex;
            var bTag = b.TagIndex;
            if (aTag == 1 && bTag == 1) return Option.Some(Case1(a.Case1.Value, b.Case1.Value));
            if (aTag == 2 && bTag == 2) return Option.Some(Case2(a.Case2.Value, b.Case2.Value));
            if (aTag == 3 && bTag == 3) return Option.Some(Case3(a.Case3.Value, b.Case3.Value));
            if (aTag == 4 && bTag == 4) return Option.Some(Case4(a.Case4.Value, b.Case4.Value));
            if (aTag == 5 && bTag == 5) return Option.Some(Case5(a.Case5.Value, b.Case5.Value));
            if (aTag == 6 && bTag == 6) return Option.Some(Case6(a.Case6.Value, b.Case6.Value));
            if (aTag == 7 && bTag == 7) return Option.Some(Case7(a.Case7.Value, b.Case7.Value));
            if (aTag == 8 && bTag == 8) return Option.Some(Case8(a.Case8.Value, b.Case8.Value));
            if (aTag == 9 && bTag == 9) return Option.Some(Case9(a.Case9.Value, b.Case9.Value));
            if (aTag == 10 && bTag == 10) return Option.Some(Case10(a.Case10.Value, b.Case10.Value));
            return Option.None;
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]のタプルに対して、二項演算の適用を試みます。
        /// 保持する型が2つのオブジェクトで異なる場合、Noneが返されます。
        /// </summary>
        public static Option<T> TryBinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T>(this Tuple<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10)
        {
            return TryBinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Case6, Case7, Case8, Case9, Case10);
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]に対して、二項演算を適用します。
        /// 保持する型が2つのオブジェクトで異なる場合、保持する型のインデックスが渡される関数が呼び出されます。
        /// </summary>
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

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]のタプルに対して、二項演算を適用します。
        /// 保持する型が2つのオブジェクトで異なる場合、保持する型のインデックスが渡される関数が呼び出されます。
        /// </summary>
        public static T BinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T>(this Tuple<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10, Func<int, int, T> Otherwise)
        {
            return BinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Case6, Case7, Case8, Case9, Case10, Otherwise);
        }

        /// <summary>
        /// 全ての型パラメータがIComparable[T]を実装するChoice[...]どうしの大小関係を判断して返します。
        /// </summary>
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

        /// <summary>
        /// 全ての型パラメータがIComparable[T]を実装するChoice[...]を比較するためのIComparer[Choice[...]]を取得します。
        /// </summary>
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
        /// <summary>
        /// T1を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }

        /// <summary>
        /// T2を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T2 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }

        /// <summary>
        /// T3を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T3 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }

        /// <summary>
        /// T4を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T4 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }

        /// <summary>
        /// T5を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T5 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }

        /// <summary>
        /// T6を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T6 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }

        /// <summary>
        /// T7を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T7 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }

        /// <summary>
        /// T8を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T8 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }

        /// <summary>
        /// T9を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T9 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }

        /// <summary>
        /// T10を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T10 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }

        /// <summary>
        /// T11を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T11 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]に対して、二項演算の適用を試みます。
        /// 保持する型が2つのオブジェクトで異なる場合、Noneが返されます。
        /// </summary>
        public static Option<T> TryBinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T>(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> b, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10, Func<T11, T11, T> Case11)
        {
            var aTag = a.TagIndex;
            var bTag = b.TagIndex;
            if (aTag == 1 && bTag == 1) return Option.Some(Case1(a.Case1.Value, b.Case1.Value));
            if (aTag == 2 && bTag == 2) return Option.Some(Case2(a.Case2.Value, b.Case2.Value));
            if (aTag == 3 && bTag == 3) return Option.Some(Case3(a.Case3.Value, b.Case3.Value));
            if (aTag == 4 && bTag == 4) return Option.Some(Case4(a.Case4.Value, b.Case4.Value));
            if (aTag == 5 && bTag == 5) return Option.Some(Case5(a.Case5.Value, b.Case5.Value));
            if (aTag == 6 && bTag == 6) return Option.Some(Case6(a.Case6.Value, b.Case6.Value));
            if (aTag == 7 && bTag == 7) return Option.Some(Case7(a.Case7.Value, b.Case7.Value));
            if (aTag == 8 && bTag == 8) return Option.Some(Case8(a.Case8.Value, b.Case8.Value));
            if (aTag == 9 && bTag == 9) return Option.Some(Case9(a.Case9.Value, b.Case9.Value));
            if (aTag == 10 && bTag == 10) return Option.Some(Case10(a.Case10.Value, b.Case10.Value));
            if (aTag == 11 && bTag == 11) return Option.Some(Case11(a.Case11.Value, b.Case11.Value));
            return Option.None;
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]のタプルに対して、二項演算の適用を試みます。
        /// 保持する型が2つのオブジェクトで異なる場合、Noneが返されます。
        /// </summary>
        public static Option<T> TryBinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T>(this Tuple<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10, Func<T11, T11, T> Case11)
        {
            return TryBinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Case6, Case7, Case8, Case9, Case10, Case11);
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]に対して、二項演算を適用します。
        /// 保持する型が2つのオブジェクトで異なる場合、保持する型のインデックスが渡される関数が呼び出されます。
        /// </summary>
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

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]のタプルに対して、二項演算を適用します。
        /// 保持する型が2つのオブジェクトで異なる場合、保持する型のインデックスが渡される関数が呼び出されます。
        /// </summary>
        public static T BinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T>(this Tuple<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10, Func<T11, T11, T> Case11, Func<int, int, T> Otherwise)
        {
            return BinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Case6, Case7, Case8, Case9, Case10, Case11, Otherwise);
        }

        /// <summary>
        /// 全ての型パラメータがIComparable[T]を実装するChoice[...]どうしの大小関係を判断して返します。
        /// </summary>
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

        /// <summary>
        /// 全ての型パラメータがIComparable[T]を実装するChoice[...]を比較するためのIComparer[Choice[...]]を取得します。
        /// </summary>
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
        /// <summary>
        /// T1を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// T2を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T2 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// T3を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T3 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// T4を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T4 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// T5を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T5 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// T6を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T6 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// T7を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T7 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// T8を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T8 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// T9を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T9 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// T10を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T10 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// T11を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T11 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// T12を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T12 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]に対して、二項演算の適用を試みます。
        /// 保持する型が2つのオブジェクトで異なる場合、Noneが返されます。
        /// </summary>
        public static Option<T> TryBinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T>(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> b, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10, Func<T11, T11, T> Case11, Func<T12, T12, T> Case12)
        {
            var aTag = a.TagIndex;
            var bTag = b.TagIndex;
            if (aTag == 1 && bTag == 1) return Option.Some(Case1(a.Case1.Value, b.Case1.Value));
            if (aTag == 2 && bTag == 2) return Option.Some(Case2(a.Case2.Value, b.Case2.Value));
            if (aTag == 3 && bTag == 3) return Option.Some(Case3(a.Case3.Value, b.Case3.Value));
            if (aTag == 4 && bTag == 4) return Option.Some(Case4(a.Case4.Value, b.Case4.Value));
            if (aTag == 5 && bTag == 5) return Option.Some(Case5(a.Case5.Value, b.Case5.Value));
            if (aTag == 6 && bTag == 6) return Option.Some(Case6(a.Case6.Value, b.Case6.Value));
            if (aTag == 7 && bTag == 7) return Option.Some(Case7(a.Case7.Value, b.Case7.Value));
            if (aTag == 8 && bTag == 8) return Option.Some(Case8(a.Case8.Value, b.Case8.Value));
            if (aTag == 9 && bTag == 9) return Option.Some(Case9(a.Case9.Value, b.Case9.Value));
            if (aTag == 10 && bTag == 10) return Option.Some(Case10(a.Case10.Value, b.Case10.Value));
            if (aTag == 11 && bTag == 11) return Option.Some(Case11(a.Case11.Value, b.Case11.Value));
            if (aTag == 12 && bTag == 12) return Option.Some(Case12(a.Case12.Value, b.Case12.Value));
            return Option.None;
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]のタプルに対して、二項演算の適用を試みます。
        /// 保持する型が2つのオブジェクトで異なる場合、Noneが返されます。
        /// </summary>
        public static Option<T> TryBinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T>(this Tuple<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10, Func<T11, T11, T> Case11, Func<T12, T12, T> Case12)
        {
            return TryBinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Case6, Case7, Case8, Case9, Case10, Case11, Case12);
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]に対して、二項演算を適用します。
        /// 保持する型が2つのオブジェクトで異なる場合、保持する型のインデックスが渡される関数が呼び出されます。
        /// </summary>
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

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]のタプルに対して、二項演算を適用します。
        /// 保持する型が2つのオブジェクトで異なる場合、保持する型のインデックスが渡される関数が呼び出されます。
        /// </summary>
        public static T BinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T>(this Tuple<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10, Func<T11, T11, T> Case11, Func<T12, T12, T> Case12, Func<int, int, T> Otherwise)
        {
            return BinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Case6, Case7, Case8, Case9, Case10, Case11, Case12, Otherwise);
        }

        /// <summary>
        /// 全ての型パラメータがIComparable[T]を実装するChoice[...]どうしの大小関係を判断して返します。
        /// </summary>
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

        /// <summary>
        /// 全ての型パラメータがIComparable[T]を実装するChoice[...]を比較するためのIComparer[Choice[...]]を取得します。
        /// </summary>
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
        /// <summary>
        /// T1を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// T2を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T2 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// T3を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T3 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// T4を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T4 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// T5を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T5 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// T6を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T6 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// T7を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T7 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// T8を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T8 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// T9を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T9 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// T10を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T10 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// T11を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T11 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// T12を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T12 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// T13を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T13 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]に対して、二項演算の適用を試みます。
        /// 保持する型が2つのオブジェクトで異なる場合、Noneが返されます。
        /// </summary>
        public static Option<T> TryBinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T>(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> b, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10, Func<T11, T11, T> Case11, Func<T12, T12, T> Case12, Func<T13, T13, T> Case13)
        {
            var aTag = a.TagIndex;
            var bTag = b.TagIndex;
            if (aTag == 1 && bTag == 1) return Option.Some(Case1(a.Case1.Value, b.Case1.Value));
            if (aTag == 2 && bTag == 2) return Option.Some(Case2(a.Case2.Value, b.Case2.Value));
            if (aTag == 3 && bTag == 3) return Option.Some(Case3(a.Case3.Value, b.Case3.Value));
            if (aTag == 4 && bTag == 4) return Option.Some(Case4(a.Case4.Value, b.Case4.Value));
            if (aTag == 5 && bTag == 5) return Option.Some(Case5(a.Case5.Value, b.Case5.Value));
            if (aTag == 6 && bTag == 6) return Option.Some(Case6(a.Case6.Value, b.Case6.Value));
            if (aTag == 7 && bTag == 7) return Option.Some(Case7(a.Case7.Value, b.Case7.Value));
            if (aTag == 8 && bTag == 8) return Option.Some(Case8(a.Case8.Value, b.Case8.Value));
            if (aTag == 9 && bTag == 9) return Option.Some(Case9(a.Case9.Value, b.Case9.Value));
            if (aTag == 10 && bTag == 10) return Option.Some(Case10(a.Case10.Value, b.Case10.Value));
            if (aTag == 11 && bTag == 11) return Option.Some(Case11(a.Case11.Value, b.Case11.Value));
            if (aTag == 12 && bTag == 12) return Option.Some(Case12(a.Case12.Value, b.Case12.Value));
            if (aTag == 13 && bTag == 13) return Option.Some(Case13(a.Case13.Value, b.Case13.Value));
            return Option.None;
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]のタプルに対して、二項演算の適用を試みます。
        /// 保持する型が2つのオブジェクトで異なる場合、Noneが返されます。
        /// </summary>
        public static Option<T> TryBinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T>(this Tuple<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10, Func<T11, T11, T> Case11, Func<T12, T12, T> Case12, Func<T13, T13, T> Case13)
        {
            return TryBinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Case6, Case7, Case8, Case9, Case10, Case11, Case12, Case13);
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]に対して、二項演算を適用します。
        /// 保持する型が2つのオブジェクトで異なる場合、保持する型のインデックスが渡される関数が呼び出されます。
        /// </summary>
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

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]のタプルに対して、二項演算を適用します。
        /// 保持する型が2つのオブジェクトで異なる場合、保持する型のインデックスが渡される関数が呼び出されます。
        /// </summary>
        public static T BinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T>(this Tuple<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10, Func<T11, T11, T> Case11, Func<T12, T12, T> Case12, Func<T13, T13, T> Case13, Func<int, int, T> Otherwise)
        {
            return BinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Case6, Case7, Case8, Case9, Case10, Case11, Case12, Case13, Otherwise);
        }

        /// <summary>
        /// 全ての型パラメータがIComparable[T]を実装するChoice[...]どうしの大小関係を判断して返します。
        /// </summary>
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

        /// <summary>
        /// 全ての型パラメータがIComparable[T]を実装するChoice[...]を比較するためのIComparer[Choice[...]]を取得します。
        /// </summary>
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
        /// <summary>
        /// T1を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// T2を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T2 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// T3を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T3 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// T4を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T4 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// T5を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T5 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// T6を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T6 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// T7を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T7 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// T8を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T8 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// T9を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T9 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// T10を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T10 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// T11を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T11 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// T12を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T12 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// T13を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T13 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// T14を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T14 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]に対して、二項演算の適用を試みます。
        /// 保持する型が2つのオブジェクトで異なる場合、Noneが返されます。
        /// </summary>
        public static Option<T> TryBinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T>(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> b, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10, Func<T11, T11, T> Case11, Func<T12, T12, T> Case12, Func<T13, T13, T> Case13, Func<T14, T14, T> Case14)
        {
            var aTag = a.TagIndex;
            var bTag = b.TagIndex;
            if (aTag == 1 && bTag == 1) return Option.Some(Case1(a.Case1.Value, b.Case1.Value));
            if (aTag == 2 && bTag == 2) return Option.Some(Case2(a.Case2.Value, b.Case2.Value));
            if (aTag == 3 && bTag == 3) return Option.Some(Case3(a.Case3.Value, b.Case3.Value));
            if (aTag == 4 && bTag == 4) return Option.Some(Case4(a.Case4.Value, b.Case4.Value));
            if (aTag == 5 && bTag == 5) return Option.Some(Case5(a.Case5.Value, b.Case5.Value));
            if (aTag == 6 && bTag == 6) return Option.Some(Case6(a.Case6.Value, b.Case6.Value));
            if (aTag == 7 && bTag == 7) return Option.Some(Case7(a.Case7.Value, b.Case7.Value));
            if (aTag == 8 && bTag == 8) return Option.Some(Case8(a.Case8.Value, b.Case8.Value));
            if (aTag == 9 && bTag == 9) return Option.Some(Case9(a.Case9.Value, b.Case9.Value));
            if (aTag == 10 && bTag == 10) return Option.Some(Case10(a.Case10.Value, b.Case10.Value));
            if (aTag == 11 && bTag == 11) return Option.Some(Case11(a.Case11.Value, b.Case11.Value));
            if (aTag == 12 && bTag == 12) return Option.Some(Case12(a.Case12.Value, b.Case12.Value));
            if (aTag == 13 && bTag == 13) return Option.Some(Case13(a.Case13.Value, b.Case13.Value));
            if (aTag == 14 && bTag == 14) return Option.Some(Case14(a.Case14.Value, b.Case14.Value));
            return Option.None;
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]のタプルに対して、二項演算の適用を試みます。
        /// 保持する型が2つのオブジェクトで異なる場合、Noneが返されます。
        /// </summary>
        public static Option<T> TryBinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T>(this Tuple<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10, Func<T11, T11, T> Case11, Func<T12, T12, T> Case12, Func<T13, T13, T> Case13, Func<T14, T14, T> Case14)
        {
            return TryBinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Case6, Case7, Case8, Case9, Case10, Case11, Case12, Case13, Case14);
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]に対して、二項演算を適用します。
        /// 保持する型が2つのオブジェクトで異なる場合、保持する型のインデックスが渡される関数が呼び出されます。
        /// </summary>
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

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]のタプルに対して、二項演算を適用します。
        /// 保持する型が2つのオブジェクトで異なる場合、保持する型のインデックスが渡される関数が呼び出されます。
        /// </summary>
        public static T BinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T>(this Tuple<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10, Func<T11, T11, T> Case11, Func<T12, T12, T> Case12, Func<T13, T13, T> Case13, Func<T14, T14, T> Case14, Func<int, int, T> Otherwise)
        {
            return BinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Case6, Case7, Case8, Case9, Case10, Case11, Case12, Case13, Case14, Otherwise);
        }

        /// <summary>
        /// 全ての型パラメータがIComparable[T]を実装するChoice[...]どうしの大小関係を判断して返します。
        /// </summary>
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

        /// <summary>
        /// 全ての型パラメータがIComparable[T]を実装するChoice[...]を比較するためのIComparer[Choice[...]]を取得します。
        /// </summary>
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
        /// <summary>
        /// T1を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// T2を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T2 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// T3を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T3 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// T4を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T4 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// T5を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T5 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// T6を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T6 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// T7を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T7 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// T8を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T8 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// T9を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T9 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// T10を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T10 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// T11を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T11 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// T12を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T12 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// T13を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T13 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// T14を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T14 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// T15を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T15 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]に対して、二項演算の適用を試みます。
        /// 保持する型が2つのオブジェクトで異なる場合、Noneが返されます。
        /// </summary>
        public static Option<T> TryBinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T>(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> b, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10, Func<T11, T11, T> Case11, Func<T12, T12, T> Case12, Func<T13, T13, T> Case13, Func<T14, T14, T> Case14, Func<T15, T15, T> Case15)
        {
            var aTag = a.TagIndex;
            var bTag = b.TagIndex;
            if (aTag == 1 && bTag == 1) return Option.Some(Case1(a.Case1.Value, b.Case1.Value));
            if (aTag == 2 && bTag == 2) return Option.Some(Case2(a.Case2.Value, b.Case2.Value));
            if (aTag == 3 && bTag == 3) return Option.Some(Case3(a.Case3.Value, b.Case3.Value));
            if (aTag == 4 && bTag == 4) return Option.Some(Case4(a.Case4.Value, b.Case4.Value));
            if (aTag == 5 && bTag == 5) return Option.Some(Case5(a.Case5.Value, b.Case5.Value));
            if (aTag == 6 && bTag == 6) return Option.Some(Case6(a.Case6.Value, b.Case6.Value));
            if (aTag == 7 && bTag == 7) return Option.Some(Case7(a.Case7.Value, b.Case7.Value));
            if (aTag == 8 && bTag == 8) return Option.Some(Case8(a.Case8.Value, b.Case8.Value));
            if (aTag == 9 && bTag == 9) return Option.Some(Case9(a.Case9.Value, b.Case9.Value));
            if (aTag == 10 && bTag == 10) return Option.Some(Case10(a.Case10.Value, b.Case10.Value));
            if (aTag == 11 && bTag == 11) return Option.Some(Case11(a.Case11.Value, b.Case11.Value));
            if (aTag == 12 && bTag == 12) return Option.Some(Case12(a.Case12.Value, b.Case12.Value));
            if (aTag == 13 && bTag == 13) return Option.Some(Case13(a.Case13.Value, b.Case13.Value));
            if (aTag == 14 && bTag == 14) return Option.Some(Case14(a.Case14.Value, b.Case14.Value));
            if (aTag == 15 && bTag == 15) return Option.Some(Case15(a.Case15.Value, b.Case15.Value));
            return Option.None;
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]のタプルに対して、二項演算の適用を試みます。
        /// 保持する型が2つのオブジェクトで異なる場合、Noneが返されます。
        /// </summary>
        public static Option<T> TryBinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T>(this Tuple<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10, Func<T11, T11, T> Case11, Func<T12, T12, T> Case12, Func<T13, T13, T> Case13, Func<T14, T14, T> Case14, Func<T15, T15, T> Case15)
        {
            return TryBinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Case6, Case7, Case8, Case9, Case10, Case11, Case12, Case13, Case14, Case15);
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]に対して、二項演算を適用します。
        /// 保持する型が2つのオブジェクトで異なる場合、保持する型のインデックスが渡される関数が呼び出されます。
        /// </summary>
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

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]のタプルに対して、二項演算を適用します。
        /// 保持する型が2つのオブジェクトで異なる場合、保持する型のインデックスが渡される関数が呼び出されます。
        /// </summary>
        public static T BinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T>(this Tuple<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10, Func<T11, T11, T> Case11, Func<T12, T12, T> Case12, Func<T13, T13, T> Case13, Func<T14, T14, T> Case14, Func<T15, T15, T> Case15, Func<int, int, T> Otherwise)
        {
            return BinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Case6, Case7, Case8, Case9, Case10, Case11, Case12, Case13, Case14, Case15, Otherwise);
        }

        /// <summary>
        /// 全ての型パラメータがIComparable[T]を実装するChoice[...]どうしの大小関係を判断して返します。
        /// </summary>
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

        /// <summary>
        /// 全ての型パラメータがIComparable[T]を実装するChoice[...]を比較するためのIComparer[Choice[...]]を取得します。
        /// </summary>
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
        /// <summary>
        /// T1を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T1 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// T2を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T2 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// T3を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T3 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// T4を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T4 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// T5を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T5 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// T6を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T6 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// T7を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T7 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// T8を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T8 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// T9を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T9 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// T10を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T10 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// T11を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T11 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// T12を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T12 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// T13を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T13 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// T14を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T14 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// T15を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T15 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// T16を含むChoice[...]オブジェクトを生成します。
        /// </summary>
        public static Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T16 value)
        {
            return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]に対して、二項演算の適用を試みます。
        /// 保持する型が2つのオブジェクトで異なる場合、Noneが返されます。
        /// </summary>
        public static Option<T> TryBinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T>(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> b, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10, Func<T11, T11, T> Case11, Func<T12, T12, T> Case12, Func<T13, T13, T> Case13, Func<T14, T14, T> Case14, Func<T15, T15, T> Case15, Func<T16, T16, T> Case16)
        {
            var aTag = a.TagIndex;
            var bTag = b.TagIndex;
            if (aTag == 1 && bTag == 1) return Option.Some(Case1(a.Case1.Value, b.Case1.Value));
            if (aTag == 2 && bTag == 2) return Option.Some(Case2(a.Case2.Value, b.Case2.Value));
            if (aTag == 3 && bTag == 3) return Option.Some(Case3(a.Case3.Value, b.Case3.Value));
            if (aTag == 4 && bTag == 4) return Option.Some(Case4(a.Case4.Value, b.Case4.Value));
            if (aTag == 5 && bTag == 5) return Option.Some(Case5(a.Case5.Value, b.Case5.Value));
            if (aTag == 6 && bTag == 6) return Option.Some(Case6(a.Case6.Value, b.Case6.Value));
            if (aTag == 7 && bTag == 7) return Option.Some(Case7(a.Case7.Value, b.Case7.Value));
            if (aTag == 8 && bTag == 8) return Option.Some(Case8(a.Case8.Value, b.Case8.Value));
            if (aTag == 9 && bTag == 9) return Option.Some(Case9(a.Case9.Value, b.Case9.Value));
            if (aTag == 10 && bTag == 10) return Option.Some(Case10(a.Case10.Value, b.Case10.Value));
            if (aTag == 11 && bTag == 11) return Option.Some(Case11(a.Case11.Value, b.Case11.Value));
            if (aTag == 12 && bTag == 12) return Option.Some(Case12(a.Case12.Value, b.Case12.Value));
            if (aTag == 13 && bTag == 13) return Option.Some(Case13(a.Case13.Value, b.Case13.Value));
            if (aTag == 14 && bTag == 14) return Option.Some(Case14(a.Case14.Value, b.Case14.Value));
            if (aTag == 15 && bTag == 15) return Option.Some(Case15(a.Case15.Value, b.Case15.Value));
            if (aTag == 16 && bTag == 16) return Option.Some(Case16(a.Case16.Value, b.Case16.Value));
            return Option.None;
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]のタプルに対して、二項演算の適用を試みます。
        /// 保持する型が2つのオブジェクトで異なる場合、Noneが返されます。
        /// </summary>
        public static Option<T> TryBinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T>(this Tuple<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10, Func<T11, T11, T> Case11, Func<T12, T12, T> Case12, Func<T13, T13, T> Case13, Func<T14, T14, T> Case14, Func<T15, T15, T> Case15, Func<T16, T16, T> Case16)
        {
            return TryBinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Case6, Case7, Case8, Case9, Case10, Case11, Case12, Case13, Case14, Case15, Case16);
        }

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]に対して、二項演算を適用します。
        /// 保持する型が2つのオブジェクトで異なる場合、保持する型のインデックスが渡される関数が呼び出されます。
        /// </summary>
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

        /// <summary>
        /// 2つの同じ型パラメータを持つChoice[...]のタプルに対して、二項演算を適用します。
        /// 保持する型が2つのオブジェクトで異なる場合、保持する型のインデックスが渡される関数が呼び出されます。
        /// </summary>
        public static T BinOp<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T>(this Tuple<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> self, Func<T1, T1, T> Case1, Func<T2, T2, T> Case2, Func<T3, T3, T> Case3, Func<T4, T4, T> Case4, Func<T5, T5, T> Case5, Func<T6, T6, T> Case6, Func<T7, T7, T> Case7, Func<T8, T8, T> Case8, Func<T9, T9, T> Case9, Func<T10, T10, T> Case10, Func<T11, T11, T> Case11, Func<T12, T12, T> Case12, Func<T13, T13, T> Case13, Func<T14, T14, T> Case14, Func<T15, T15, T> Case15, Func<T16, T16, T> Case16, Func<int, int, T> Otherwise)
        {
            return BinOp(self.Item1, self.Item2, Case1, Case2, Case3, Case4, Case5, Case6, Case7, Case8, Case9, Case10, Case11, Case12, Case13, Case14, Case15, Case16, Otherwise);
        }

        /// <summary>
        /// 全ての型パラメータがIComparable[T]を実装するChoice[...]どうしの大小関係を判断して返します。
        /// </summary>
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

        /// <summary>
        /// 全ての型パラメータがIComparable[T]を実装するChoice[...]を比較するためのIComparer[Choice[...]]を取得します。
        /// </summary>
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
}
