using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

#pragma warning disable 618

namespace LangExt
{
    using StdEnumerable = System.Linq.Enumerable;

    /// <summary>
    /// 要素Tのシーケンスを表すインターフェイスです。
    /// </summary>
    /// <typeparam name="T">要素の型</typeparam>
    [Obsolete("このインターフェイスはLangExt3.0で廃止予定なので、代わりにSeq[T]を使ってください。")]
    public interface ISeq<out T> : IEnumerable<T> { }

    /// <summary>
    /// 要素Tのシーケンスを表すインターフェイスです。
    /// </summary>
    /// <typeparam name="T">要素の型</typeparam>
    public interface Seq<out T> : ISeq<T> { }

    internal sealed class EmptySeq<T> : Seq<T>
    {
        internal readonly static EmptySeq<T> Instance = new EmptySeq<T>();
        class EmptyEnumerator : IEnumerator<T>
        {
            internal readonly static EmptyEnumerator Instance = new EmptyEnumerator();

            public T Current { get { throw new NotImplementedException(); } }

            object System.Collections.IEnumerator.Current { get { throw new NotImplementedException(); } }

            public void Dispose() { }

            public bool MoveNext() { return false; }

            public void Reset() { throw new NotImplementedException(); }
        }

        public IEnumerator<T> GetEnumerator() { return EmptyEnumerator.Instance; }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return this.GetEnumerator(); }

        public override string ToString() { return "seq []"; }
    }

    internal class EnumerableSeq<T> : Seq<T>
    {
        #region EnumerableSeqの実装
        readonly IEnumerable<T> value;

        internal EnumerableSeq(IEnumerable<T> value) { this.value = value; }

        public IEnumerator<T> GetEnumerator() { return this.value.GetEnumerator(); }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return this.value.GetEnumerator(); }

        public override string ToString()
        {
            return string.Concat("seq [", Seq.ToSummaryText<T>(value), "]");
        }
        #endregion
    }

    partial class Create
    {
        /// <summary>
        /// 引数を要素として含むシーケンスを生成します。
        /// </summary>
        public static Seq<T> Seq<T>(params T[] elems) { return new EnumerableSeq<T>(elems); }
    }

    /// <summary>
    /// シーケンスに対する関数を提供します。
    /// シーケンスの状態と引数によって例外を投げうる関数は、Unsafe名前空間のSeqモジュールで提供しています。
    /// Initなどの、シーケンスの状態によらず、他の引数のみによって例外を投げうる関数はこのモジュールに定義しています。
    /// </summary>
    public static partial class Seq
    {
        internal static string ToSummaryText<T>(IEnumerable<T> value)
        {
            var res = new StringBuilder();
            int i = 0;
            foreach (var v in value)
            {
                if (i++ == 5)
                {
                    res.Append("..., ");
                    break;
                }
                res.Append(v + ", ");
            }
            if (i != 0)
                res.Remove(res.Length - 2, 2);
            return res.ToString();
        }

        #region 生成系メソッド(Empty/Create/InitInifinite/Init/Repeat/RepeatInfinite/Singleton/Unfold)
        /// <summary>
        /// 空のシーケンスを生成します。
        /// </summary>
        public static Seq<T> Empty<T>() { return EmptySeq<T>.Instance; }

        /// <summary>
        /// 引数を要素として含むシーケンスを生成します。
        /// </summary>
        public static Seq<T> Create<T>(params T[] elems) { return new EnumerableSeq<T>(elems); }

        /// <summary>
        /// fを元に無限に続くシーケンスを生成します。
        /// </summary>
        public static Seq<T> InitInfinite<T>(Func<int, T> f) { return new EnumerableSeq<T>(Enumerable.InitInfinite(f)); }

        /// <summary>
        /// fを元にn要素のシーケンスを生成します。
        /// </summary>
        public static Seq<T> Init<T>(int n, Func<int, T> f)
        {
            if (n < 0) throw new ArgumentOutOfRangeException("n", n, string.Format(Properties.Resources.ExMsgTooSmall, "n", 0, n));
            return new EnumerableSeq<T>(Enumerable.Init(n, f));
        }

        /// <summary>
        /// 指定した要素を含む無限に続くシーケンスを生成します。
        /// </summary>
        public static Seq<T> RepeatInfinite<T>(T t) { return new EnumerableSeq<T>(Enumerable.RepeatInfinite(t)); }

        /// <summary>
        /// 指定した要素を含むn要素のシーケンスを生成します。
        /// </summary>
        public static Seq<T> Repeat<T>(int n, T t)
        {
            if (n < 0) throw new ArgumentOutOfRangeException("n", n, string.Format(Properties.Resources.ExMsgTooSmall, "n", 0, n));
            return new EnumerableSeq<T>(Enumerable.Repeat(n, t));
        }

        /// <summary>
        /// 指定した要素のみを含む1要素のシーケンスを生成します。
        /// </summary>
        public static Seq<T> Singleton<T>(T t) { return Repeat(1, t); }

        /// <summary>
        /// 初期状態からfによって計算されたシーケンスを生成します。
        /// </summary>
        public static Seq<U> Unfold<T, U>(this T self, Func<T, Option<Tuple<U, T>>> f)
        {
            return new EnumerableSeq<U>(Enumerable.Unfold(self, f));
        }
        #endregion

        #region 長さ取得系メソッド(Size/Len/Count)
        /// <summary>
        /// シーケンスの長さを求めます。
        /// 標準クエリ演算子のCountに対応します。
        /// </summary>
        /// <remarks>
        /// Sizeは、Lenよりもより広範囲の対象に通用する名前です。
        /// 例えば、集合の要素数を考えたとき(集合がシーケンスかどうかは置いておいたとして)に、
        /// Lenは名前としては適しませんが、
        /// Sizeは集合の要素数として使っても問題ない名前です。
        /// そのため、Sizeを使うとより統一性を持ったコーディングが可能なので、
        /// LenでもSizeでも問題ない場合はSizeを使うようにしてください。
        /// </remarks>
        public static int Size<T>(this ISeq<T> self) { return StdEnumerable.Count(self); }

        /// <summary>
        /// シーケンスの長さを求めます。
        /// 標準クエリ演算子のCountに対応します。
        /// </summary>
        /// <remarks>
        /// Sizeは、Lenよりもより広範囲の対象に通用する名前です。
        /// 例えば、集合の要素数を考えたとき(集合がシーケンスかどうかは置いておいたとして)に、
        /// Lenは名前としては適しませんが、
        /// Sizeは集合の要素数として使っても問題ない名前です。
        /// そのため、Sizeを使うとより統一性を持ったコーディングが可能なので、
        /// LenでもSizeでも問題ない場合はSizeを使うようにしてください。
        /// </remarks>
        public static int Len<T>(this ISeq<T> self) { return StdEnumerable.Count(self); }

        /// <summary>
        /// シーケンスの長さを求めます。
        /// 標準クエリ演算子のLongCountに対応します。
        /// </summary>
        public static long LongLen<T>(this ISeq<T> self) { return StdEnumerable.LongCount(self); }

        /// <summary>
        /// predに合致する要素の個数を求めます。
        /// 標準クエリ演算子のCountに対応します。
        /// </summary>
        public static int Count<T>(this ISeq<T> self, Func<T, bool> pred) { return StdEnumerable.Count(self, pred); }

        /// <summary>
        /// predに合致する要素の個数を求めます。
        /// 標準クエリ演算子のLongCountに対応します。
        /// </summary>
        public static long LongCount<T>(this ISeq<T> self, Func<T, bool> pred) { return StdEnumerable.LongCount(self, pred); }
        #endregion

        #region Sum系メソッド
        /// <summary>
        /// intのシーケンスの総和を求めます。
        /// 標準クエリ演算子のSumに対応します。
        /// </summary>
        public static int Sum(this ISeq<int> self) { return StdEnumerable.Sum(self); }

        /// <summary>
        /// longのシーケンスの総和を求めます。
        /// 標準クエリ演算子のSumに対応します。
        /// </summary>
        public static long LongSum(this ISeq<long> self) { return StdEnumerable.Sum(self); }

        /// <summary>
        /// 任意の型のシーケンスの総和を求めます。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        /// <param name="self">レシーバ</param>
        /// <param name="strategy">総和を求める戦略を表すオブジェクト</param>
        public static T Sum<T>(this ISeq<T> self, ISumStrategy<T> strategy) { return self.Fold(strategy.Zero, strategy.Plus); }

        /// <summary>
        /// 任意の型のシーケンスの総和をintとして求めます。
        /// 標準クエリ演算子のSumに対応します。
        /// </summary>
        public static int SumBy<T>(this ISeq<T> self, Func<T, int> f) { return StdEnumerable.Sum<T>(self, f); }

        /// <summary>
        /// 任意の型のシーケンスの総和をlongとして求めます。
        /// 標準クエリ演算子のSumに対応します。
        /// </summary>
        public static long LongSumBy<T>(this ISeq<T> self, Func<T, long> f) { return StdEnumerable.Sum<T>(self, f); }

        /// <summary>
        /// 任意の型のシーケンスの総和を求めます。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        /// <param name="self">レシーバ</param>
        /// <param name="f">加算対象のオブジェクトへの変換関数</param>
        /// <param name="strategy">総和を求める戦略を表すオブジェクト</param>
        public static U SumBy<T, U>(this ISeq<T> self, Func<T, U> f, ISumStrategy<U> strategy)
        {
            return self.Map(f).Fold(strategy.Zero, strategy.Plus);
        }
        #endregion

        #region Max系メソッド
        /// <summary>
        /// シーケンスの最大値を求めます。
        /// シーケンスに要素が含まれなかった場合、Noneを返します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Option<T> TryMax<T>(this ISeq<T> self) where T : IComparable<T>
        {
            return self.IsEmpty() ? Option.None : Option.Some(Unsafe.SeqUnsafe.Max(self));
        }

        /// <summary>
        /// 任意の型のシーケンスの最大値を求めます。
        /// シーケンスに要素が含まれなかった場合、Noneを返します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Option<T> TryMaxWith<T>(this ISeq<T> self, Func<T, T, int> comparer)
        {
            return self.IsEmpty() ? Option.None : Option.Some(Unsafe.SeqUnsafe.MaxWith(self, comparer));
        }

        /// <summary>
        /// 任意の型のシーケンスの最大値を求めます。
        /// シーケンスに要素が含まれなかった場合、Noneを返します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Option<T> TryMaxBy<T, U>(this ISeq<T> self, Func<T, U> f) where U : IComparable<U>
        {
            return self.IsEmpty() ? Option.None : Option.Some(Unsafe.SeqUnsafe.MaxBy(self, f));
        }
        #endregion

        #region Min系メソッド
        /// <summary>
        /// シーケンスの最小値を求めます。
        /// シーケンスに要素が含まれなかった場合、Noneを返します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Option<T> TryMin<T>(this ISeq<T> self) where T : IComparable<T>
        {
            return self.IsEmpty() ? Option.None : Option.Some(Unsafe.SeqUnsafe.Min(self));
        }

        /// <summary>
        /// 任意の型のシーケンスの最小値を求めます。
        /// シーケンスに要素が含まれなかった場合、Noneを返します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Option<T> TryMinWith<T>(this ISeq<T> self, Func<T, T, int> comparer)
        {
            return self.IsEmpty() ? Option.None : Option.Some(Unsafe.SeqUnsafe.MinWith(self, comparer));
        }

        /// <summary>
        /// 任意の型のシーケンスの最小値を求めます。
        /// シーケンスに要素が含まれなかった場合、Noneを返します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Option<T> TryMinBy<T, U>(this ISeq<T> self, Func<T, U> f) where U : IComparable<U>
        {
            return self.IsEmpty() ? Option.None : Option.Some(Unsafe.SeqUnsafe.MinBy(self, f));
        }
        #endregion

        #region 畳み込み系メソッド(Fold/TryReduce/FoldBack/TryReduceBack/Scan/ScanBack/Scan1/Scan1Back)
        /// <summary>
        /// シーケンスを先頭から畳み込みます。
        /// 標準クエリ演算子のAggregateに対応します。
        /// </summary>
        public static U Fold<T, U>(this ISeq<T> self, U init, Func<U, T, U> f) { return StdEnumerable.Aggregate(self, init, f); }

        /// <summary>
        /// シーケンスを先頭から畳み込みます。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Option<T> TryReduce<T>(this ISeq<T> self, Func<T, T, T> f)
        {
            if (self.IsEmpty()) return Option.None;
            return Option.Some(StdEnumerable.Aggregate(self, f));
        }

        /// <summary>
        /// シーケンスを末尾から畳み込みます。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static U FoldBack<T, U>(this ISeq<T> self, U init, Func<T, U, U> f)
        {
            var res = init;
            foreach (var x in StdEnumerable.Reverse(self))
            {
                res = f(x, res);
            }
            return res;
        }

        /// <summary>
        /// シーケンスを末尾から畳み込みます。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Option<T> TryReduceBack<T>(this ISeq<T> self, Func<T, T, T> f)
        {
            if (self.IsEmpty()) return Option.None;
            return Option.Some(Unsafe.SeqUnsafe.ReduceBack(self, f));
        }

        /// <summary>
        /// シーケンスの先頭から畳み込みを行い、各ステップの結果をシーケンスとして返します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Seq<U> Scan<T, U>(this ISeq<T> self, U init, Func<U, T, U> f)
        {
            return new EnumerableSeq<U>(((IEnumerable<T>)self).Scan(init, f));
        }

        /// <summary>
        /// シーケンスの末尾から畳み込みを行い、各ステップの結果をシーケンスとして返します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Seq<U> ScanBack<T, U>(this ISeq<T> self, U init, Func<T, U, U> f)
        {
            var xs = StdEnumerable.Reverse(self);
            return new EnumerableSeq<U>(xs.Scan(init, (acc, x) => f(x, acc))).Reverse();
        }

        /// <summary>
        /// シーケンスの先頭から畳み込みを行い、各ステップの結果をシーケンスとして返します。
        /// Scanと異なり、初期値にはシーケンスの先頭要素が使われます。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Seq<T> Scan1<T>(this ISeq<T> self, Func<T, T, T> f)
        {
            return new EnumerableSeq<T>(((IEnumerable<T>)self).Scan1(f));
        }

        /// <summary>
        /// シーケンスの末尾から畳み込みを行い、各ステップの結果をシーケンスとして返します。
        /// Scanと異なり、初期値にはシーケンスの末尾要素が使われます。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Seq<T> ScanBack1<T>(this ISeq<T> self, Func<T, T, T> f)
        {
            var xs = StdEnumerable.Reverse(self);
            return new EnumerableSeq<T>(xs.Scan1((acc, x) => f(x, acc))).Reverse();
        }
        #endregion

        #region 探索系メソッド(TryFind/TryPick)
        /// <summary>
        /// シーケンスから、predを満たす最初の要素を探索します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Option<T> TryFind<T>(this ISeq<T> self, Func<T, bool> pred)
        {
            foreach (var x in self)
            {
                if (pred(x))
                    return Option.Some(x);
            }
            return Option.None;
        }

        /// <summary>
        /// シーケンスから、fがSomeを返す最初の要素を探索します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Option<U> TryPick<T, U>(this ISeq<T> self, Func<T, Option<U>> f)
        {
            foreach (var x in self)
            {
                var res = f(x);
                if (res.IsSome)
                    return res;
            }
            return Option.None;
        }
        #endregion

        #region 真偽値を返すメソッド(IsEmpty/IsNotEmpty/Forall/Exists)
        /// <summary>
        /// シーケンスが空かどうかを返します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static bool IsEmpty<T>(this ISeq<T> self) { return StdEnumerable.Any(self) == false; }

        /// <summary>
        /// シーケンスに要素が含まれるかどうかを返します。
        /// 標準クエリ演算子のAnyに対応します。
        /// </summary>
        public static bool IsNotEmpty<T>(this ISeq<T> self) { return StdEnumerable.Any(self); }

        /// <summary>
        /// シーケンスのすべての要素がpredを満たすかどうかを返します。
        /// 標準クエリ演算子のAllに対応します。
        /// </summary>
        public static bool Forall<T>(this ISeq<T> self, Func<T, bool> pred) { return StdEnumerable.All(self, pred); }

        /// <summary>
        /// シーケンスの要素のうち一つでもpredを満たす要素があるかどうかを返します。
        /// 標準クエリ演算子のAnyに対応します。
        /// </summary>
        public static bool Exists<T>(this ISeq<T> self, Func<T, bool> pred) { return StdEnumerable.Any(self, pred); }
        #endregion

        #region Filter系メソッド
        /// <summary>
        /// シーケンスから、predを満たす要素のみを含むシーケンスを生成して返します。
        /// 標準クエリ演算子のWhereに対応します。
        /// </summary>
        public static Seq<T> Filter<T>(this ISeq<T> self, Func<T, bool> pred) { return new EnumerableSeq<T>(StdEnumerable.Where(self, pred)); }

        /// <summary>
        /// シーケンスから、predを満たす要素のみを含むシーケンスを生成して返します。
        /// predには、要素のほかに要素のインデックスも渡されます。
        /// 標準クエリ演算子のWhereに対応します。
        /// </summary>
        public static Seq<T> FilterWithIndex<T>(this ISeq<T> self, Func<T, int, bool> pred) { return new EnumerableSeq<T>(StdEnumerable.Where(self, pred)); }
        #endregion

        #region Map系メソッド
        /// <summary>
        /// シーケンスのすべての要素に対してfを適用したシーケンスを生成して返します。
        /// 標準クエリ演算子のSelectに対応します。
        /// </summary>
        public static Seq<U> Map<T, U>(this ISeq<T> self, Func<T, U> f) { return new EnumerableSeq<U>(StdEnumerable.Select(self, f)); }

        /// <summary>
        /// シーケンスのすべての要素に対してfを適用したシーケンスを生成して返します。
        /// fには、要素のほかに要素のインデックスも渡されます。
        /// 標準クエリ演算子のSelectに対応します。
        /// </summary>
        public static Seq<U> MapWithIndex<T, U>(this ISeq<T> self, Func<T, int, U> f) { return new EnumerableSeq<U>(StdEnumerable.Select(self, f)); }
        #endregion

        #region Iter系メソッド
        /// <summary>
        /// シーケンスのすべての要素に対してactを実行します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static void Iter<T>(this ISeq<T> self, Action<T> act)
        {
            foreach (var x in self) act(x);
        }

        /// <summary>
        /// シーケンスのすべての要素に対してactを実行します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Unit IterF<T>(this ISeq<T> self, Func<T, Unit> act)
        {
            foreach (var x in self) act(x);
            return Unit._;
        }

        /// <summary>
        /// シーケンスのすべての要素に対してactを実行します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static void IterWithIndex<T>(this ISeq<T> self, Action<T, int> act)
        {
            var i = 0;
            foreach (var x in self) act(x, i++);
        }

        /// <summary>
        /// シーケンスのすべての要素に対してactを実行します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Unit IterFWithIndex<T>(this ISeq<T> self, Func<T, int, Unit> act)
        {
            var i = 0;
            foreach (var x in self) act(x, i++);
            return Unit._;
        }
        #endregion

        #region Bind系メソッド(Bind/BindWithIndex/Collect)
        /// <summary>
        /// シーケンスの各要素を順番にfの引数に対して渡し、fから返された各シーケンスを平坦化したシーケンスを生成して返します。
        /// 標準クエリ演算子のSelectManyに対応します。
        /// </summary>
        public static Seq<U> Bind<T, U>(this ISeq<T> self, Func<T, Seq<U>> f) { return new EnumerableSeq<U>(StdEnumerable.SelectMany(self, f)); }

        /// <summary>
        /// シーケンスの各要素を順番にfの引数に対して渡し、fから返された各シーケンスを平坦化したシーケンスを生成して返します。
        /// fには、要素のほかに要素のインデックスも渡されます。
        /// 標準クエリ演算子のSelectManyに対応します。
        /// </summary>
        public static Seq<U> BindWithIndex<T, U>(this ISeq<T> self, Func<T, int, Seq<U>> f) { return new EnumerableSeq<U>(StdEnumerable.SelectMany(self, f)); }

        /// <summary>
        /// シーケンスの各要素を順番にfの引数に対して渡し、fから返された各シーケンスを平坦化したシーケンスを生成して返します。
        /// 標準クエリ演算子のSelectManyに似ていますが、渡す関数の戻り値の型がより広いものを受け入れます。
        /// </summary>
        public static Seq<U> Collect<T, U, V>(this ISeq<T> self, Func<T, V> f) where V : ISeq<U>
        {
            var xs = new List<U>();
            var res = new EnumerableSeq<U>(xs);
            foreach (var x in self)
            {
                xs.AddRange(f(x));
            }
            return res;
        }
        
        // TODO : CollectWithIndex
        #endregion

        #region Choose系メソッド(Map + Filter)
        /// <summary>
        /// シーケンスのすべての要素に対してfを適用し、Someを返した要素のみを集めたシーケンスを生成して返します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Seq<U> Choose<T, U>(this ISeq<T> self, Func<T, Option<U>> f) { return new EnumerableSeq<U>(self.Bind(t => f(t).ToArray())); }

        /// <summary>
        /// シーケンスのすべての要素に対してfを適用し、Someを返した要素のみを集めたシーケンスを生成して返します。
        /// fには、要素のほかに要素のインデックスも渡されます。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Seq<U> ChooseWithIndex<T, U>(this ISeq<T> self, Func<T, int, Option<U>> f) { return new EnumerableSeq<U>(self.BindWithIndex((t, i) => f(t, i).ToArray())); }
        #endregion

        #region 部分シーケンス取得系メソッド(Skip/Take/SkipWhile/SkipWhileWithIndex/TakeWhile/TakeWhileWithIndex)
        /// <summary>
        /// シーケンスの先頭からn個の要素をスキップしたシーケンスを生成して返します。
        /// nが0以下の場合、入力のシーケンスがそのまま返されます。
        /// nがシーケンスの要素の個数よりも大きい場合、空のシーケンスが返されます。
        /// 標準クエリ演算子のSkipに対応します。
        /// </summary>
        public static Seq<T> Skip<T>(this ISeq<T> self, int n) { return new EnumerableSeq<T>(StdEnumerable.Skip(self, n)); }

        /// <summary>
        /// シーケンスの先頭からn個の要素を取り出したシーケンスを生成して返します。
        /// nが0以下の場合、空のシーケンスが返されます。
        /// nがシーケンスの要素の個数よりも大きい場合、入力のシーケンスがそのまま返されます。
        /// 標準クエリ演算子のTakeに対応します。
        /// </summary>
        public static Seq<T> Take<T>(this ISeq<T> self, int n) { return new EnumerableSeq<T>(StdEnumerable.Take(self, n)); }

        /// <summary>
        /// シーケンスの先頭からpredを満たす要素をスキップしたシーケンスを生成して返します。
        /// 標準クエリ演算子のSkipWhileに対応します。
        /// </summary>
        public static Seq<T> SkipWhile<T>(this ISeq<T> self, Func<T, bool> pred) { return new EnumerableSeq<T>(StdEnumerable.SkipWhile(self, pred)); }

        /// <summary>
        /// シーケンスの先頭からpredを満たす要素をスキップしたシーケンスを生成して返します。
        /// predには、要素のほかに要素のインデックスも渡されます。
        /// 標準クエリ演算子のSkipWhileに対応します。
        /// </summary>
        public static Seq<T> SkipWhileWithIndex<T>(this ISeq<T> self, Func<T, int, bool> pred) { return new EnumerableSeq<T>(StdEnumerable.SkipWhile(self, pred)); }

        /// <summary>
        /// シーケンスの先頭からpredを満たす要素を取り出したシーケンスを生成して返します。
        /// 標準クエリ演算子のTakeWhileに対応します。
        /// </summary>
        public static Seq<T> TakeWhile<T>(this ISeq<T> self, Func<T, bool> pred) { return new EnumerableSeq<T>(StdEnumerable.TakeWhile(self, pred)); }

        /// <summary>
        /// シーケンスの先頭からpredを満たす要素を取り出したシーケンスを生成して返します。
        /// predには、要素のほかに要素のインデックスも渡されます。
        /// 標準クエリ演算子のTakeWhileに対応します。
        /// </summary>
        public static Seq<T> TakeWhileWithIndex<T>(this ISeq<T> self, Func<T, int, bool> pred) { return new EnumerableSeq<T>(StdEnumerable.TakeWhile(self, pred)); }
        #endregion

        #region 分割系メソッド(Partition/SplitAt/Span/Break)
        /// <summary>
        /// predを満たす要素と満たさない要素にシーケンスを分割します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Tuple<Seq<T>, Seq<T>> Partition<T>(this ISeq<T> self, Func<T, bool> pred)
        {
            var res1 = new List<T>();
            var res2 = new List<T>();
            foreach (var x in self)
            {
                if (pred(x)) res1.Add(x);
                else res2.Add(x);
            }
            return Tuple.Create((Seq<T>)new EnumerableSeq<T>(res1), (Seq<T>)new EnumerableSeq<T>(res2));
        }

        /// <summary>
        /// 指定した位置シーケンスを分割します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Tuple<Seq<T>, Seq<T>> SplitAt<T>(this ISeq<T> self, int n)
        {
            return LangExt.Create.Tuple(new EnumerableSeq<T>(self).Take(n), new EnumerableSeq<T>(self).Skip(n));
        }

        /// <summary>
        /// TakeWhileの結果とSkipWhileの結果の両方を同時に取得します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Tuple<Seq<T>, Seq<T>> Span<T>(this ISeq<T> self, Func<T, bool> pred)
        {
            return LangExt.Create.Tuple(new EnumerableSeq<T>(self).TakeWhile(pred), new EnumerableSeq<T>(self).SkipWhile(pred));
        }

        /// <summary>
        /// TakeWhileの結果とSkipWhileの結果の両方を同時に取得します。
        /// Spanと異なり、predの否定が渡されます。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Tuple<Seq<T>, Seq<T>> Break<T>(this ISeq<T> self, Func<T, bool> pred)
        {
            return LangExt.Create.Tuple(new EnumerableSeq<T>(self).TakeWhile(t => !pred(t)), new EnumerableSeq<T>(self).SkipWhile(t => !pred(t)));
        }
        #endregion

        #region Window系メソッド(Windowed/Windowed3/Pairwise)
        /// <summary>
        /// シーケンスから取得された要素のスライド式ウィンドウを生成するシーケンスを返します。
        /// 各ウィンドウは、新しい配列として返されます。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Seq<T[]> Windowed<T>(this ISeq<T> self, int windowSize)
        {
            return new EnumerableSeq<T[]>(((IEnumerable<T>)self).Windowed(windowSize));
        }

        /// <summary>
        /// シーケンスから取得された要素のサイズ3のスライド式ウィンドウを生成するシーケンスを返します。
        /// 各ウィンドウは、3要素のタプルとして返されます。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Seq<Tuple<T, T, T>> Windowed3<T>(this ISeq<T> self)
        {
            return new EnumerableSeq<Tuple<T, T, T>>(((IEnumerable<T>)self).Windowed3());
        }

        /// <summary>
        /// シーケンスから取得された要素のサイズ2のスライド式ウィンドウを生成するシーケンスを返します。
        /// 各ウィンドウは、2要素のタプルとして返されます。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Seq<Tuple<T, T>> Pairwise<T>(this ISeq<T> self)
        {
            return new EnumerableSeq<Tuple<T, T>>(((IEnumerable<T>)self).Pairwise());
        }
        #endregion

        #region Sort系メソッド
        /// <summary>
        /// シーケンスをソートします。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Seq<T> Sort<T>(this ISeq<T> self)
        {
            return new EnumerableSeq<T>(StdEnumerable.OrderBy(self, x => x));
        }

        /// <summary>
        /// シーケンスを逆順にソートします。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Seq<T> RevSort<T>(this ISeq<T> self)
        {
            return new EnumerableSeq<T>(StdEnumerable.OrderByDescending(self, x => x));
        }

        /// <summary>
        /// シーケンスをソートします。
        /// 標準クエリ演算子のOrderByに対応します。
        /// </summary>
        public static OrderedSeq<T> SortBy<T, U>(this ISeq<T> self, Func<T, U> f)
        {
            return new OrderedEnumerableSeq<T>(StdEnumerable.OrderBy(self, f));
        }

        /// <summary>
        /// シーケンスを逆順にソートします。
        /// 標準クエリ演算子のOrderByDescendingに対応します。
        /// </summary>
        public static OrderedSeq<T> RevSortBy<T, U>(this ISeq<T> self, Func<T, U> f)
        {
            return new OrderedEnumerableSeq<T>(StdEnumerable.OrderByDescending(self, f));
        }
        #endregion

        #region 変換系メソッド(ToString/ToArray)
        /// <summary>
        /// 指定されたセパレータでシーケンスを連結し、文字列化します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static string ToString<T>(this ISeq<T> self, string open, string sep, string close)
        {
            var res = new StringBuilder();
            res.Append(open);
            var isFirst = true;
            foreach (var x in self)
            {
                if (isFirst)
                {
                    res.Append(x);
                    isFirst = false;
                }
                else
                {
                    res.Append(sep).Append(x);
                }
            }
            res.Append(close);
            return res.ToString();
        }

        /// <summary>
        /// 指定されたセパレータでシーケンスを連結し、文字列化します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static string ToString<T>(this ISeq<T> self, string sep)
        {
            return ToString(self, "", sep, "");
        }

        /// <summary>
        /// シーケンスを配列に変換します。
        /// 標準クエリ演算子のToArrayに対応します。
        /// </summary>
        public static T[] ToArray<T>(this ISeq<T> self)
        {
            return StdEnumerable.ToArray(self);
        }
        #endregion

        /// <summary>
        /// シーケンスの指定番目の要素を返します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Option<T> TryGet<T>(this ISeq<T> self, int index)
        {
            Func<ISeq<T>, int, T> f = Unsafe.SeqUnsafe.Get;
            return f.ToOptionFunc()(self, index);
        }

        /// <summary>
        /// シーケンスに別のシーケンスを連結したシーケンスを生成して返します。
        /// 標準クエリ演算子のConcatに対応します。
        /// </summary>
        public static Seq<T> Append<T>(this ISeq<T> self, ISeq<T> other) { return new EnumerableSeq<T>(StdEnumerable.Concat(self, other)); }

        /// <summary>
        /// ネストしたシーケンスのネストを一段取り除きます。
        /// 例えば、ISeq[ISeq[T]]をISeq[T]に変換します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Seq<T> Concat<T, U>(this ISeq<U> self) where U : IEnumerable<T> { return new EnumerableSeq<T>(self.Bind((U u) => u)); }

        /// <summary>
        /// シーケンスを、走査した要素をキャッシュするシーケンスに変換します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Seq<T> Cache<T>(this ISeq<T> self) { return new CachedSeq<T>(self); }

        /// <summary>
        /// シーケンスを反転させたシーケンスを生成します。
        /// 標準クエリ演算子のReverseに対応します。
        /// </summary>
        public static Seq<T> Reverse<T>(this ISeq<T> self)
        {
            return new EnumerableSeq<T>(StdEnumerable.Reverse(self));
        }

        /// <summary>
        /// Option[T]のシーケンスすべてがSomeだった場合は値を取り出したシーケンスをSomeに包んで返し、
        /// 一つでもNoneが存在した場合はNoneを返します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Option<Seq<T>> Sequence<T>(this ISeq<Option<T>> self)
        {
            var res = new List<T>();
            foreach (var x in self)
            {
                if (x.IsNone)
                    return Option.None;
                res.Add(Unsafe.OptionUnsafe.GetValue(x)); // 上のifでNoneの場合を除外しているので、このGetValueの呼び出しは安全
            }
            return Option.Some<Seq<T>>(new EnumerableSeq<T>(res));
        }

        /// <summary>
        /// Result[TSuccess, TFailure]のシーケンスすべてがSuccessだった場合は値を取り出したシーケンスをSuccessに包んで返し、
        /// 一つでもFailureが存在した場合はFailureを返します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Result<Seq<TSuccess>, TFailure> SequenceSuccess<TSuccess, TFailure>(this ISeq<Result<TSuccess, TFailure>> self)
        {
            var res = new List<TSuccess>();
            foreach (var x in self)
            {
                if (x.IsFailure)
                    return Result.Failure(x.FailureValue);
                res.Add(x.SuccessValue);
            }
            return Result.Success((Seq<TSuccess>)new EnumerableSeq<TSuccess>(res));
        }

        /// <summary>
        /// Result[TSuccess, TFailure]のシーケンスすべてがFailureだった場合は値を取り出したシーケンスをSuccessに包んで返し、
        /// 一つでもFailureが存在した場合はFailureを返します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Result<TSuccess, Seq<TFailure>> SequenceFailure<TSuccess, TFailure>(this ISeq<Result<TSuccess, TFailure>> self)
        {
            var res = new List<TFailure>();
            foreach (var x in self)
            {
                if (x.IsSuccess)
                    return Result.Success(x.SuccessValue);
                res.Add(x.FailureValue);
            }
            return Result.Failure((Seq<TFailure>)new EnumerableSeq<TFailure>(res));
        }

        /// <summary>
        /// Option[T]のシーケンスからSomeの要素のみを抜き出し、その値を取り出したシーケンスに変換します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Seq<T> OnlySome<T>(this ISeq<Option<T>> self) { return self.Choose(Func.Id); }

        /// <summary>
        /// Result[T, _]のシーケンスからSuccessの要素のみを抜き出し、その値を取り出したシーケンスに変換します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Seq<T> OnlySuccess<T, _>(this ISeq<Result<T, _>> self) { return self.Choose(Result.ToOption); }

        /// <summary>
        /// Result[_, T]のシーケンスからFailureの要素のみを抜き出し、その値を取り出したシーケンスに変換します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Seq<T> OnlyFailure<_, T>(this ISeq<Result<_, T>> self) { return self.Choose(Result.ToOptionFailure); }

        /// <summary>
        /// nullを含みうるシーケンスから、Optionのシーケンスに変換します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Seq<Option<T>> MapOption<T>(this ISeq<T> self) where T : class { return self.Map(Option.Create); }

        /// <summary>
        /// nullを含みうるシーケンスから、Optionのシーケンスに変換します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Seq<Option<T>> MapOption<T>(this ISeq<T?> self) where T : struct { return self.Map(Option.Create); }
        
        /// <summary>
        /// nullを含みうるシーケンスから、Resultのシーケンスに変換します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Seq<Result<T, Unit>> MapResult<T>(this ISeq<T> self) where T : class { return self.Map(Result.Create); }

        /// <summary>
        /// nullを含みうるシーケンスから、Resultのシーケンスに変換します。
        /// 対応する標準クエリ演算子はありません。
        /// </summary>
        public static Seq<Result<T, Unit>> MapResult<T>(this ISeq<T?> self) where T : struct { return self.Map(Result.Create); }
        
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