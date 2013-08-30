using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace LangExt
{
    namespace RangeUnit
    {
        public sealed class Length : IUnit { Length() { } }
        public sealed class Index : IUnit { Index() { } }

        public static class Int
        {
            public static IntWithUnit<Length> ToLen(this int self) { return new IntWithUnit<Length>(self); }
            public static IntWithUnit<Index> ToIdx(this int self) { return new IntWithUnit<Index>(self); }
        }
    }

    partial class Create
    {
        public static Range Range(IntWithUnit<RangeUnit.Length> len)
        {
            return new Range(len.Value);
        }

        public static Range Range(int from, IntWithUnit<RangeUnit.Length> len)
        {
            return new Range(from, len.Value);
        }

        public static Range Range(IntWithUnit<RangeUnit.Index> to)
        {
            return new Range(0, to.Value + 1);
        }

        public static Range Range(int from, IntWithUnit<RangeUnit.Index> to)
        {
            return new Range(from, to.Value - from + 1);
        }
    }

    public struct Range : IEquatable<Range>
    {
        public readonly int From;
        public readonly int To;
        public int Length
        {
            get
            {
                if (From <= To) return To - From + 1;
                return From - To + 1;
            }
        }

        Range(int from, int to, bool canNegLen)
        {
            this.From = from;
            this.To = to;
            if (!canNegLen && this.Length < 0)
                throw new ArgumentOutOfRangeException("from, to", string.Format(Properties.Resources.ExMsgTooSmall, "(to - from + 1)", 0, this.Length));
        }

        public Range(int from, int len) : this(from, from + len - 1, false) { }

        public Range(int len) : this(0, len - 1, false) { }

        public static Range Create(IntWithUnit<RangeUnit.Length> len)
        {
            return new Range(len.Value);
        }

        public static Range Create(int from, IntWithUnit<RangeUnit.Length> len)
        {
            return new Range(from, len.Value);
        }

        public static Range Create(IntWithUnit<RangeUnit.Index> to)
        {
            return new Range(0, to.Value + 1);
        }

        public static Range Create(int from, IntWithUnit<RangeUnit.Index> to)
        {
            return new Range(from, to.Value - from + 1);
        }

        public static Range FromTo(int from, int to)
        {
            return new Range(from, to, true);
        }

        public ISeq<int> ToSeq()
        {
            var from = this.From;
            if (from <= this.To)
                return Seq.Init(this.Length, i => from + i);
            return Seq.Init(this.Length, i => from - i);
        }

        public bool Equals(Range other)
        {
            return this.From == other.From && this.Length == other.Length;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            if (!(obj is Range))
                return false;
            return this.Equals((Range)obj);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            return 31 ^ this.From.GetHashCode() ^ this.To.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("Range(From={0}, To={1}, Length={2})", this.From, this.To, this.Length);
        }
    }
}
