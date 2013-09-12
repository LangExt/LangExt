using System;
using System.ComponentModel;

#pragma warning disable 618

namespace LangExt.Unsafe
{
    using StdEnumerable = System.Linq.Enumerable;

    /// <summary>
    /// シーケンスに対する(例外を投げうる)関数を提供します。
    /// </summary>
    public static partial class SeqUnsafe
    {
        /// <summary>
        /// シーケンスの指定番目の要素を取得します。
        /// 標準クエリ演算子のElementAtに対応します。
        /// </summary>
        public static T Get<T>(this ISeq<T> self, int index) { return StdEnumerable.ElementAt(self, index); }

        /// <summary>
        /// シーケンスの最大値を求めます。
        /// 標準クエリ演算子のMaxに対応します。
        /// </summary>
        public static T Max<T>(this ISeq<T> self) where T : IComparable<T> { return StdEnumerable.Max(self); }

        /// <summary>
        /// 任意の型のシーケンスの最大値を求めます。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static T MaxWith<T>(this ISeq<T> self, Func<T, T, int> comparer)
        {
            return self.Reduce((a, b) =>
            {
                var r = comparer(a, b);
                return r > 0 ? a :
                       r < 0 ? b :
                               a;
            });
        }

        /// <summary>
        /// 任意の型のシーケンスの最大値を求めます。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static T MaxBy<T, U>(this ISeq<T> self, Func<T, U> f) where U : IComparable<U>
        {
            // Reduceでf(a).Cmp(f(b))してもよかったけど、fの呼び出し回数を減らすためにいったんMapすることにした
            return self
                .Map(x => Tuple.Create(x, f(x)))
                .Reduce((a, b) => a._2().Cmp(b._2()).Match(() => b, () => a, () => a))
                ._1();
        }

        /// <summary>
        /// シーケンスの最小値を求めます。
        /// 標準クエリ演算子のMinに対応します。
        /// </summary>
        public static T Min<T>(this ISeq<T> self) where T : IComparable<T> { return StdEnumerable.Min(self); }

        /// <summary>
        /// 任意の型のシーケンスの最小値を求めます。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static T MinWith<T>(this ISeq<T> self, Func<T, T, int> comparer)
        {
            return self.Reduce((a, b) =>
            {
                var r = comparer(a, b);
                return r > 0 ? b :
                       r < 0 ? a :
                               a;
            });
        }

        /// <summary>
        /// 任意の型のシーケンスの最小値を求めます。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static T MinBy<T, U>(this ISeq<T> self, Func<T, U> f) where U : IComparable<U>
        {
            // Reduceでf(a).Cmp(f(b))してもよかったけど、fの呼び出し回数を減らすためにいったんMapすることにした
            return self
                .Map(x => Tuple.Create(x, f(x)))
                .Reduce((a, b) => a._2().Cmp(b._2()).Match(() => a, () => a, () => b))
                ._1();
        }

        /// <summary>
        /// シーケンスを先頭から畳み込みます。
        /// 標準クエリ演算子のAggregateに対応します。
        /// </summary>
        public static T Reduce<T>(this ISeq<T> self, Func<T, T, T> f) { return StdEnumerable.Aggregate(self, f); }

        /// <summary>
        /// シーケンスを末尾から畳み込みます。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static T ReduceBack<T>(this ISeq<T> self, Func<T, T, T> f)
        {
            var xs = StdEnumerable.Reverse(self);
            using (var itor = xs.GetEnumerator())
            {
                if (itor.MoveNext() == false)
                    throw new InvalidOperationException(string.Format(Properties.Resources.ExMsgSeqIsEmpty, "self"));
                var res = itor.Current;
                while (itor.MoveNext())
                    res = f(itor.Current, res);
                return res;
            }
        }

        /// <summary>
        /// シーケンスから、predを満たす最初の要素を探索します。
        /// 標準クエリ演算子のFirstに対応します。
        /// </summary>
        public static T Find<T>(this ISeq<T> self, Func<T, bool> pred) { return StdEnumerable.First(self, pred); }

        /// <summary>
        /// シーケンスから、fがSomeを返す最初の要素を探索し、Someの中身を返します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static U Pick<T, U>(this ISeq<T> self, Func<T, Option<U>> f)
        {
            foreach (var x in self)
            {
                var res = f(x);
                if (res.IsSome)
                    return res.GetValue();
            }
            throw new InvalidOperationException(string.Format(Properties.Resources.ExMsgElementNotFound, "self"));
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

#pragma warning restore 618