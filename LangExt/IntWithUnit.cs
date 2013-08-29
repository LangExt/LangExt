using System;
using System.ComponentModel;

namespace LangExt
{
    public static class Int
    {
        public static IntWithUnit<T> WithUnit<T>(this int self) where T : IUnit { return (IntWithUnit<T>)self; }
        public static IntWithUnit<T> WithUnit<T>(this int? self) where T : IUnit { return (IntWithUnit<T>)self; }
    }

    public struct IntWithUnit<T> : IEquatable<IntWithUnit<T>>, IComparable<IntWithUnit<T>>
        where T : IUnit
    {
        public readonly bool HasValue;
        public readonly int Value;

        public static readonly IntWithUnit<T> NoValue = new IntWithUnit<T>();

        public IntWithUnit(int value)
        {
            HasValue = true;
            Value = value;
        }

        public static explicit operator IntWithUnit<T>(int? i)
        {
            return i.HasValue ? new IntWithUnit<T>(i.Value) : IntWithUnit<T>.NoValue;
        }

        public bool Equals(IntWithUnit<T> other)
        {
            return this.HasValue == other.HasValue && this.Value == other.Value;
        }

        public int CompareTo(IntWithUnit<T> other)
        {
            if (!this.HasValue || !other.HasValue)
                throw new Exception();
            return this.Value.CompareTo(other.Value);
        }

        public static bool operator ==(IntWithUnit<T> lhs, IntWithUnit<T> rhs) { return lhs.Equals(rhs); }
        public static bool operator !=(IntWithUnit<T> lhs, IntWithUnit<T> rhs) { return lhs.Equals(rhs) == false; }

        public static bool operator ==(IntWithUnit<T> lhs, int? rhs) { return lhs.Equals((IntWithUnit<T>)rhs); }
        public static bool operator !=(IntWithUnit<T> lhs, int? rhs) { return lhs.Equals((IntWithUnit<T>)rhs) == false; }
        public static bool operator ==(int? lhs, IntWithUnit<T> rhs) { return rhs.Equals((IntWithUnit<T>)lhs); }
        public static bool operator !=(int? lhs, IntWithUnit<T> rhs) { return rhs.Equals((IntWithUnit<T>)lhs) == false; }

        public static IntWithUnit<T> operator <(IntWithUnit<T> lhs, IntWithUnit<T> rhs)
        {
            if (!lhs.HasValue || !rhs.HasValue) return IntWithUnit<T>.NoValue;
            return lhs.Value < rhs.Value ? rhs : IntWithUnit<T>.NoValue;
        }
        public static IntWithUnit<T> operator >(IntWithUnit<T> lhs, IntWithUnit<T> rhs)
        {
            if (!lhs.HasValue || !rhs.HasValue) return IntWithUnit<T>.NoValue;
            return lhs.Value > rhs.Value ? rhs : IntWithUnit<T>.NoValue;
        }
        public static IntWithUnit<T> operator <=(IntWithUnit<T> lhs, IntWithUnit<T> rhs)
        {
            if (!lhs.HasValue || !rhs.HasValue) return IntWithUnit<T>.NoValue;
            return lhs.Value <= rhs.Value ? rhs : IntWithUnit<T>.NoValue;
        }
        public static IntWithUnit<T> operator >=(IntWithUnit<T> lhs, IntWithUnit<T> rhs)
        {
            if (!lhs.HasValue || !rhs.HasValue) return IntWithUnit<T>.NoValue;
            return lhs.Value >= rhs.Value ? rhs : IntWithUnit<T>.NoValue;
        }

        public static IntWithUnit<T> operator <(IntWithUnit<T> lhs, int? rhs) { return lhs < (IntWithUnit<T>)rhs; }
        public static IntWithUnit<T> operator <(int? lhs, IntWithUnit<T> rhs) { return (IntWithUnit<T>)lhs < rhs; }
        public static IntWithUnit<T> operator >(IntWithUnit<T> lhs, int? rhs) { return lhs > (IntWithUnit<T>)rhs; }
        public static IntWithUnit<T> operator >(int? lhs, IntWithUnit<T> rhs) { return (IntWithUnit<T>)lhs > rhs; }
        public static IntWithUnit<T> operator <=(IntWithUnit<T> lhs, int? rhs) { return lhs <= (IntWithUnit<T>)rhs; }
        public static IntWithUnit<T> operator <=(int? lhs, IntWithUnit<T> rhs) { return (IntWithUnit<T>)lhs <= rhs; }
        public static IntWithUnit<T> operator >=(IntWithUnit<T> lhs, int? rhs) { return lhs >= (IntWithUnit<T>)rhs; }
        public static IntWithUnit<T> operator >=(int? lhs, IntWithUnit<T> rhs) { return (IntWithUnit<T>)lhs >= rhs; }

        public static bool operator true(IntWithUnit<T> i) { return i.HasValue; }
        public static bool operator false(IntWithUnit<T> i) { return !i.HasValue; }

        // 加減算はIntWithUnit<T>同士のみ(単位が異なる場合や、単位なしの場合は提供しない)
        public static IntWithUnit<T> operator +(IntWithUnit<T> lhs, IntWithUnit<T> rhs)
        {
            if (!lhs.HasValue || !rhs.HasValue) return IntWithUnit<T>.NoValue;
            return new IntWithUnit<T>(lhs.Value + rhs.Value);
        }
        public static IntWithUnit<T> operator -(IntWithUnit<T> lhs, IntWithUnit<T> rhs)
        {
            if (!lhs.HasValue || !rhs.HasValue) return IntWithUnit<T>.NoValue;
            return new IntWithUnit<T>(lhs.Value - rhs.Value);
        }

        // 乗除算は片方のみがIntWithUnit<T>
        public static IntWithUnit<T> operator *(IntWithUnit<T> lhs, int? rhs)
        {
            if (!lhs.HasValue || !rhs.HasValue) return IntWithUnit<T>.NoValue;
            return new IntWithUnit<T>(lhs.Value * rhs.Value);
        }
        public static IntWithUnit<T> operator *(int? lhs, IntWithUnit<T> rhs)
        {
            if (!lhs.HasValue || !rhs.HasValue) return IntWithUnit<T>.NoValue;
            return new IntWithUnit<T>(lhs.Value * rhs.Value);
        }
        public static IntWithUnit<T> operator /(IntWithUnit<T> lhs, int? rhs)
        {
            if (!lhs.HasValue || !rhs.HasValue) return IntWithUnit<T>.NoValue;
            return new IntWithUnit<T>(lhs.Value / rhs.Value);
        }
        public static IntWithUnit<T> operator %(IntWithUnit<T> lhs, int? rhs)
        {
            if (!lhs.HasValue || !rhs.HasValue) return IntWithUnit<T>.NoValue;
            return new IntWithUnit<T>(lhs.Value % rhs.Value);
        }

        public static IntWithUnit<T> operator -(IntWithUnit<T> value)
        {
            if (!value.HasValue) return value;
            return new IntWithUnit<T>(-value.Value);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            if (!(obj is IntWithUnit<T>))
                return false;
            return this.Equals((IntWithUnit<T>)obj);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            return 31 ^ this.HasValue.GetHashCode() ^ this.Value.GetHashCode();
        }

        public override string ToString()
        {
            var type = "IntWithUnit<" + typeof(T).Name + ">";
            return this.HasValue ? type + ".NoValue"
                                 : type + "(" + this.Value + ")";
        }
    }
}
