using System;
using System.Collections.Generic;
using System.Text;

namespace LangExt2
{
    using StdEnumerable = System.Linq.Enumerable;

    /// <summary>IEnumerableに対する関数を提供します。</summary>
    public static partial class Enumerable
    {
        /// <summary>
        /// IEnumerable[T]からシーケンスに変換します。
        /// </summary>
        public static ISeq<T> ToSeq<T>(this IEnumerable<T> self)
        {
            return new Seq<T>(self);
        }

        /// <summary>
        /// fを元に無限に続くIEnumerableを生成します。
        /// </summary>
        public static IEnumerable<T> InitInfinite<T>(Func<int, T> f)
        {
            var i = 0;
            while (true) yield return f(i++);
        }

        internal static IEnumerable<T> Init<T>(int n, Func<int, T> f)
        {
            for (int i = 0; i < n; i++) yield return f(i++);
        }

        /// <summary>
        /// 指定した要素を含む無限に続くIEnumerableを生成します。
        /// </summary>
        public static IEnumerable<T> RepeatInfinite<T>(T t)
        {
            while (true) yield return t;
        }

        internal static IEnumerable<T> Repeat<T>(int n, T t)
        {
            for (int i = 0; i < n; i++) yield return t;
        }

        /// <summary>
        /// IEnumerableから、predを満たす要素のみを含むIEnumerableを生成して返します。
        /// 標準クエリ演算子のWhereに対応します。
        /// </summary>
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> self, Func<T, bool> pred) { return self.Where(pred); }

        /// <summary>
        /// IEnumerableから、predを満たす要素のみを含むIEnumerableを生成して返します。
        /// predには、要素のほかに要素のインデックスも渡されます。
        /// 標準クエリ演算子のWhereに対応します。
        /// </summary>
        public static IEnumerable<T> FilterWitIndex<T>(this IEnumerable<T> self, Func<T, int, bool> pred) { return StdEnumerable.Where(self, pred); }

        /// <summary>
        /// IEnumerableのすべての要素に対してfを適用したIEnumerableを生成して返します。
        /// 標準クエリ演算子のSelectに対応します。
        /// </summary>
        public static IEnumerable<U> Map<T, U>(this IEnumerable<T> self, Func<T, U> f) { return self.Select(f); }

        /// <summary>
        /// IEnumerableのすべての要素に対してfを適用したIEnumerableを生成して返します。
        /// fには、要素のほかに要素のインデックスも渡されます。
        /// 標準クエリ演算子のSelectに対応します。
        /// </summary>
        public static IEnumerable<U> MapWithIndex<T, U>(this IEnumerable<T> self, Func<T, int, U> f) { return StdEnumerable.Select(self, f); }

        /// <summary>
        /// IEnumerableの各要素を順番にfの引数に対して渡し、fから返された各IEnumerableを平坦化したIEnumerableを生成して返します。
        /// 標準クエリ演算子のSelectManyに対応します。
        /// </summary>
        public static IEnumerable<U> Bind<T, U>(this IEnumerable<T> self, Func<T, IEnumerable<U>> f) { return StdEnumerable.SelectMany(self, f); }

        /// <summary>
        /// IEnumerableの各要素を順番にfの引数に対して渡し、fから返された各IEnumerableを平坦化したIEnumerableを生成して返します。
        /// fには、要素のほかに要素のインデックスも渡されます。
        /// 標準クエリ演算子のSelectManyに対応します。
        /// </summary>
        public static IEnumerable<U> BindWithIndex<T, U>(this IEnumerable<T> self, Func<T, int, IEnumerable<U>> f) { return StdEnumerable.SelectMany(self, f); }

        /// <summary>
        /// IEnumerableのすべての要素に対してfを適用し、Someを返した要素のみを集めたIEnumerableを生成して返します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static IEnumerable<U> Choose<T, U>(this IEnumerable<T> self, Func<T, Option<U>> f) { return self.Bind(t => f(t).ToArray()); }

        /// <summary>
        /// IEnumerableのすべての要素に対してfを適用し、Someを返した要素のみを集めたIEnumerableを生成して返します。
        /// fには、要素のほかに要素のインデックスも渡されます。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static IEnumerable<U> ChooseWithIndex<T, U>(this IEnumerable<T> self, Func<T, int, Option<U>> f)
        {
            return self.BindWithIndex((t, i) => f(t, i).ToArray());
        }

        /// <summary>
        /// 非ジェネリック型のIEnumerableを、IEnumerable[T]に変換します。
        /// 標準クエリ演算子のCastに対応します。
        /// </summary>
        public static IEnumerable<T> Cast<T>(this System.Collections.IEnumerable self) { return Enumerable.Cast<T>(self); }

        /// <summary>
        /// IEnumerableに別のIEnumerableを連結したIEnumerableを生成して返します。
        /// 標準クエリ演算子のConcatに対応します。
        /// </summary>
        public static IEnumerable<T> Append<T>(this IEnumerable<T> self, IEnumerable<T> other) { return StdEnumerable.Concat(self, other); }

        /// <summary>
        /// ネストしたIEnumerableのネストを一段取り除きます。
        /// 例えば、IEnumerable[IEnumerable[T]]をIEnumerable[T]に変換します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static IEnumerable<T> Concat<T>(this IEnumerable<IEnumerable<T>> self) { return self.Bind(Func.Id); }

        /// <summary>
        /// IEnumerableの先頭からn個の要素をスキップしたIEnumerableを生成して返します。
        /// nが0以下の場合、入力のIEnumerableがそのまま返されます。
        /// nがIEnumerableの要素の個数よりも大きい場合、空のIEnumerableが返されます。
        /// 標準クエリ演算子のSkipに対応します。
        /// </summary>
        public static IEnumerable<T> Skip<T>(this IEnumerable<T> self, int n) { return StdEnumerable.Skip(self, n); }

        /// <summary>
        /// IEnumerableの先頭からn個の要素を取り出したIEnumerableを生成して返します。
        /// nが0以下の場合、空のIEnumerableが返されます。
        /// nがIEnumerableの要素の個数よりも大きい場合、入力のIEnumerableがそのまま返されます。
        /// 標準クエリ演算子のTakeに対応します。
        /// </summary>
        public static IEnumerable<T> Take<T>(this IEnumerable<T> self, int n) { return StdEnumerable.Take(self, n); }

        /// <summary>
        /// IEnumerableの先頭からpredを満たす要素をスキップしたIEnumerableを生成して返します。
        /// 標準クエリ演算子のSkipWhileに対応します。
        /// </summary>
        public static IEnumerable<T> SkipWhile<T>(this IEnumerable<T> self, Func<T, bool> pred) { return StdEnumerable.SkipWhile(self, pred); }

        /// <summary>
        /// IEnumerableの先頭からpredを満たす要素をスキップしたIEnumerableを生成して返します。
        /// predには、要素のほかに要素のインデックスも渡されます。
        /// 標準クエリ演算子のSkipWhileに対応します。
        /// </summary>
        public static IEnumerable<T> SkipWhileWithIndex<T>(this IEnumerable<T> self, Func<T, int, bool> pred) { return StdEnumerable.SkipWhile(self, pred); }

        /// <summary>
        /// IEnumerableの先頭からpredを満たす要素を取り出したIEnumerableを生成して返します。
        /// 標準クエリ演算子のTakeWhileに対応します。
        /// </summary>
        public static IEnumerable<T> TakeWhile<T>(this IEnumerable<T> self, Func<T, bool> pred) { return StdEnumerable.TakeWhile(self, pred); }

        /// <summary>
        /// IEnumerableの先頭からpredを満たす要素を取り出したIEnumerableを生成して返します。
        /// predには、要素のほかに要素のインデックスも渡されます。
        /// 標準クエリ演算子のTakeWhileに対応します。
        /// </summary>
        public static IEnumerable<T> TakeWhileWithIndex<T>(this IEnumerable<T> self, Func<T, int, bool> pred) { return StdEnumerable.TakeWhile(self, pred); }

        /// <summary>
        /// IEnumerableを、走査した要素をキャッシュするIEnumerableに変換します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static IEnumerable<T> Cache<T>(this IEnumerable<T> self) { return new CachedEnumerable<T>(self); }

        /// <summary>
        /// 指定した位置でIEnumerableを分割します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Tuple<IEnumerable<T>, IEnumerable<T>> SplitAt<T>(this IEnumerable<T> self, int n) { return Create.Tuple(self.Take(n), self.Skip(n)); }

        /// <summary>
        /// TakeWhileの結果とSkipWhileの結果の両方を同時に取得します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Tuple<IEnumerable<T>, IEnumerable<T>> Span<T>(this IEnumerable<T> self, Func<T, bool> pred)
        {
            return Create.Tuple(self.TakeWhile(pred), self.SkipWhile(pred));
        }

        /// <summary>
        /// TakeWhileの結果とSkipWhileの結果の両方を同時に取得します。
        /// Spanと異なり、predの否定が渡されます。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Tuple<IEnumerable<T>, IEnumerable<T>> Break<T>(this IEnumerable<T> self, Func<T, bool> pred)
        {
            return Create.Tuple(self.TakeWhile(t => !pred(t)), self.SkipWhile(t => !pred(t)));
        }

        /// <summary>
        /// IEnumerableから取得された要素のスライド式ウィンドウを生成するIEnumerableを返します。
        /// 各ウィンドウは、新しい配列として返されます。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static IEnumerable<T[]> Windowed<T>(this IEnumerable<T> self, int windowSize)
        {
            var buffer = new Queue<T>(windowSize);
            using (var itor = self.GetEnumerator())
            {
                while (buffer.Count < windowSize)
                {
                    if (itor.MoveNext() == false)
                        yield break;
                    buffer.Enqueue(itor.Current);
                }
                yield return buffer.ToArray();

                while (itor.MoveNext())
                {
                    buffer.Dequeue();
                    buffer.Enqueue(itor.Current);
                    yield return buffer.ToArray();
                }
            }
        }

        /// <summary>
        /// IEnumerableから取得された要素のサイズ3のスライド式ウィンドウを生成するIEnumerableを返します。
        /// 各ウィンドウは、3要素のタプルとして返されます。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static IEnumerable<Tuple<T, T, T>> Windowed3<T>(this IEnumerable<T> self)
        {
            return self.Windowed(3).Map(xs => Create.Tuple(xs[0], xs[1], xs[2]));
        }

        /// <summary>
        /// IEnumerableから取得された要素のサイズ2のスライド式ウィンドウを生成するIEnumerableを返します。
        /// 各ウィンドウは、2要素のタプルとして返されます。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static IEnumerable<Tuple<T, T>> Pairwise<T>(this IEnumerable<T> self)
        {
            using (var itor = self.GetEnumerator())
            {
                if (itor.MoveNext() == false)
                    yield break;
                var prev = itor.Current;

                while (itor.MoveNext())
                {
                    yield return Create.Tuple(prev, itor.Current);
                    prev = itor.Current;
                }
            }
        }

        /// <summary>
        /// IEnumerableの先頭から畳み込みを行い、各ステップの結果をIEnumerableとして返します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static IEnumerable<U> Scan<T, U>(this IEnumerable<T> self, U init, Func<U, T, U> f)
        {
            var crnt = init;
            foreach (var x in self)
            {
                var res = f(crnt, x);
                yield return crnt;
                crnt = res;
            }
        }

        /// <summary>
        /// IEnumerableの先頭から畳み込みを行い、各ステップの結果をIEnumerableとして返します。
        /// Scanと異なり、初期値にはIEnumerableの先頭要素が使われます。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static IEnumerable<T> Scan1<T>(this IEnumerable<T> self, Func<T, T, T> f)
        {
            using (var itor = self.GetEnumerator())
            {
                if (itor.MoveNext() == false)
                    throw new Exception();
                var crnt = itor.Current;
                while (itor.MoveNext())
                {
                    var res = f(crnt, itor.Current);
                    yield return crnt;
                    crnt = res;
                }
            }
        }
    }
}
