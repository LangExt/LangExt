using System;
using System.ComponentModel;

namespace LangExt
{
    namespace RangeUnit
    {
        /// <summary>Rangeの長さを表す単位クラスです。</summary>
        public sealed class Length : IUnit
        {
            Length() { }

            /// <summary>使用しません。</summary>
            [EditorBrowsable(EditorBrowsableState.Never)]
            public static new bool Equals(object a, object b)
            {
                return object.Equals(a, b);
            }

            /// <summary>使用しません。</summary>
            [EditorBrowsable(EditorBrowsableState.Never)]
            public static new bool ReferenceEquals(object a, object b)
            {
                return object.ReferenceEquals(a, b);
            }
        }
        
        /// <summary>Rangeで終点の位置を表す単位クラスです。</summary>
        public sealed class Index : IUnit
        {
            Index() { }

            /// <summary>使用しません。</summary>
            [EditorBrowsable(EditorBrowsableState.Never)]
            public static new bool Equals(object a, object b)
            {
                return object.Equals(a, b);
            }

            /// <summary>使用しません。</summary>
            [EditorBrowsable(EditorBrowsableState.Never)]
            public static new bool ReferenceEquals(object a, object b)
            {
                return object.ReferenceEquals(a, b);
            }
        }

        /// <summary>
        /// intに単位を扱う操作を追加するための拡張メソッドを提供します。
        /// </summary>
        public static class Int
        {
            /// <summary>数値を長さを表す数値に変換します。</summary>
            public static IntWithUnit<Length> ToLen(this int self) { return new IntWithUnit<Length>(self); }
            /// <summary>数値を位置を表す数値に変換します。</summary>
            public static IntWithUnit<Index> ToIdx(this int self) { return new IntWithUnit<Index>(self); }
        }
    }

    partial class Create
    {
        /// <summary>
        /// 指定された長さを持つ、0から始まるRangeを生成します。
        /// 長さに負の数を指定することはできません。
        /// </summary>
        public static Range Range(IntWithUnit<RangeUnit.Length> len)
        {
            return LangExt.Range.Create(len);
        }

        /// <summary>
        /// 指定された開始位置と長さを持つRangeを生成します。
        /// 長さに負の数を指定することはできません。
        /// </summary>
        public static Range Range(int from, IntWithUnit<RangeUnit.Length> len)
        {
            return LangExt.Range.Create(from, len);
        }

        /// <summary>
        /// 指定された終了位置(自身は含まない)を持つ、0から始まるRangeを生成します。
        /// </summary>
        public static Range Range(IntWithUnit<RangeUnit.Index> to)
        {
            return LangExt.Range.Create(to);
        }

        /// <summary>
        /// 指定された開始位置と終了位置(自身は含まない)を持つRangeを生成します。
        /// </summary>
        public static Range Range(int from, IntWithUnit<RangeUnit.Index> to)
        {
            return LangExt.Range.Create(from, to);
        }
    }

    /// <summary>
    /// 範囲を表すクラスです。
    /// </summary>
    public struct Range : IEquatable<Range>
    {
        /// <summary>
        /// 範囲の開始位置を表すインデックスです。。
        /// </summary>
        public readonly int Begin;
        /// <summary>
        /// 範囲の終了地点の直前を表すインデックスです。
        /// </summary>
        public readonly int End;
        /// <summary>
        /// 範囲の終了位置を表すインデックスを取得します。
        /// </summary>
        public int Last
        {
            get
            {
                if (Begin < End) return End - 1;
                if (Begin > End) return End + 1;
                throw new InvalidOperationException();
            }
        }
        /// <summary>
        /// 範囲の長さを表す数値を取得します。
        /// </summary>
        public int Length
        {
            get
            {
                if (Begin < End) return End - Begin;
                return Begin - End;
            }
        }

        /// <summary>
        /// BeginからEndへ値が増えていくRangeかどうかを取得します。
        /// </summary>
        public bool Increasing
        {
            get { return Begin < End; }
        }

        /// <summary>
        /// BeginからEndへ値が減っていくRangeかどうかを取得します。
        /// </summary>
        public bool Decreasing
        {
            get { return End < Begin; }
        }

        Range(int begin, int end)
        {
            this.Begin = begin;
            this.End = end;
        }

        /// <summary>
        /// 指定された長さを持つ、0から始まるRangeを生成します。
        /// 長さに負の数を指定することはできません。
        /// </summary>
        public static Range Create(IntWithUnit<RangeUnit.Length> len)
        {
            if (len < 0)
                throw new ArgumentOutOfRangeException("len", string.Format(Properties.Resources.ExMsgTooSmall2, "len", 0, len));
            return new Range(0, len.Value);
        }

        /// <summary>
        /// 指定された開始位置と長さを持つRangeを生成します。
        /// 長さに負の数を指定することはできません。
        /// </summary>
        public static Range Create(int from, IntWithUnit<RangeUnit.Length> len)
        {
            if (len < 0)
                throw new ArgumentOutOfRangeException("len", string.Format(Properties.Resources.ExMsgTooSmall2, "len", 0, len));
            return new Range(from, from + len.Value);
        }

        /// <summary>
        /// 指定された終了位置(自身は含まない)を持つ、0から始まるRangeを生成します。
        /// </summary>
        public static Range Create(IntWithUnit<RangeUnit.Index> end)
        {
            return new Range(0, end.Value);
        }

        /// <summary>
        /// 指定された開始位置と終了位置(自身は含まない)を持つRangeを生成します。
        /// </summary>
        public static Range Create(int begin, IntWithUnit<RangeUnit.Index> end)
        {
            return new Range(begin, end.Value);
        }

        /// <summary>
        /// 指定された開始位置と終了位置(自身を含む)を持つRangeを生成します。
        /// </summary>
        /// <param name="from">生成する範囲の開始位置</param>
        /// <param name="to">生成する範囲の終了位置(自身を含む)</param>
        public static Range FromTo(int from, int to)
        {
            return from <= to ? new Range(from, to + 1)
                              : new Range(from, to - 1);
        }

        /// <summary>
        /// 指定された開始位置と終了位置(自身を含まない)を持つRangeを生成します。
        /// </summary>
        /// <param name="from">生成する範囲の開始位置</param>
        /// <param name="until">生成する範囲の終了位置(自身を含まない)</param>
        public static Range FromUntil(int from, int until)
        {
            return new Range(from, until);
        }

        /// <summary>
        /// 範囲をシーケンスに変換します。
        /// </summary>
        public ISeq<int> ToSeq()
        {
            var from = this.Begin;
            if (this.Increasing)
                return Seq.Init(this.Length, i => from + i);
            return Seq.Init(this.Length, i => from - i);
        }

        System.Collections.Generic.IEnumerable<int> ToSeqImpl(int step)
        {
            for (int crnt = this.Begin; crnt < this.End; crnt += step)
                yield return crnt;
        }

        /// <summary>
        /// stepを指定して範囲をシーケンスに変換します。
        /// </summary>
        public ISeq<int> ToSeq(int step)
        {
            if (step == 0)
                throw new ArgumentOutOfRangeException("step", string.Format(Properties.Resources.ExMsgInvalidValue, 0));
            if (this.Increasing && step < 0)
                throw new ArgumentException("step", string.Format(Properties.Resources.ExMsgTooSmall2, "step", 0, step));
            if (this.Decreasing && step > 0)
                throw new ArgumentException("step", string.Format(Properties.Resources.ExMsgTooBig2, "step", 0, step));
            return ToSeqImpl(step).ToSeq();
        }

        /// <summary>
        /// 現在のオブジェクトと、同じ型の別のオブジェクトが等しいかどうかを判定します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較するRange</param>
        /// <returns>現在のオブジェクトがotherで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        public bool Equals(Range other)
        {
            return this.Begin == other.Begin && this.End == other.End;
        }

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト</param>
        /// <returns>現在のオブジェクトがobjで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            if (!(obj is Range))
                return false;
            return this.Equals((Range)obj);
        }

        /// <summary>
        /// オブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>ハッシュコード</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            return 31 ^ this.Begin.GetHashCode() ^ this.End.GetHashCode();
        }

        /// <summary>
        /// このオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>このオブジェクトの文字列表現</returns>
        public override string ToString()
        {
            return string.Format("Range(Begin={0}, End={1}, Length={2})", this.Begin, this.End, this.Length);
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
