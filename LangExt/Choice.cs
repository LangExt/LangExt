
using System;
using System.ComponentModel;

namespace LangExt
{
    public sealed class Choice<T1, T2> : IEquatable<Choice<T1, T2>>
    {
        readonly Option<T1> t1;
        readonly Option<T2> t2;

        public Choice(T1 value) { t1 = new Option<T1>(value); }

        public static implicit operator Choice<T1, T2>(T1 value) { return new Choice<T1, T2>(value); }

        public Choice(T2 value) { t2 = new Option<T2>(value); }

        public static implicit operator Choice<T1, T2>(T2 value) { return new Choice<T1, T2>(value); }


        public T Match<T>(Func<T1, T> Case1, Func<T2, T> Case2)
        {
            Func<T> thrower = () => { throw new InvalidOperationException(); };
            return t1.Match<T>(Case1, () => t2.Match<T>(Case2, thrower));
        }

        public bool Equals(Choice<T1, T2> other)
        {
            return other.IsNotNull() && t1 == other.t1 && t2 == other.t2;
        }

        public static bool operator ==(Choice<T1, T2> a, Choice<T1, T2> b)
        {
            if (a.IsNull())
                return b.IsNull();
            return a.Equals(b);
        }

        public static bool operator !=(Choice<T1, T2> a, Choice<T1, T2> b)
        {
            return !(a == b);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            var other = obj as Choice<T1, T2>;
            if (other.IsNull())
                return false;
            return Equals(other);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            var result = 31;
            result ^= t1.GetHashCode();
            result ^= t2.GetHashCode();
            return result;
        }

        public override string ToString()
        {
            return Match(
                t1 => string.Format("Choice({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Choice({0}:{1})", t2, typeof(T2).Name)
            );
        }
    }

    public sealed class Choice<T1, T2, T3> : IEquatable<Choice<T1, T2, T3>>
    {
        readonly Option<T1> t1;
        readonly Option<T2> t2;
        readonly Option<T3> t3;

        public Choice(T1 value) { t1 = new Option<T1>(value); }

        public static implicit operator Choice<T1, T2, T3>(T1 value) { return new Choice<T1, T2, T3>(value); }

        public Choice(T2 value) { t2 = new Option<T2>(value); }

        public static implicit operator Choice<T1, T2, T3>(T2 value) { return new Choice<T1, T2, T3>(value); }

        public Choice(T3 value) { t3 = new Option<T3>(value); }

        public static implicit operator Choice<T1, T2, T3>(T3 value) { return new Choice<T1, T2, T3>(value); }


        public T Match<T>(Func<T1, T> Case1, Func<T2, T> Case2, Func<T3, T> Case3)
        {
            Func<T> thrower = () => { throw new InvalidOperationException(); };
            return t1.Match<T>(Case1, () => t2.Match<T>(Case2, () => t3.Match<T>(Case3, thrower)));
        }

        public bool Equals(Choice<T1, T2, T3> other)
        {
            return other.IsNotNull() && t1 == other.t1 && t2 == other.t2 && t3 == other.t3;
        }

        public static bool operator ==(Choice<T1, T2, T3> a, Choice<T1, T2, T3> b)
        {
            if (a.IsNull())
                return b.IsNull();
            return a.Equals(b);
        }

        public static bool operator !=(Choice<T1, T2, T3> a, Choice<T1, T2, T3> b)
        {
            return !(a == b);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            var other = obj as Choice<T1, T2, T3>;
            if (other.IsNull())
                return false;
            return Equals(other);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            var result = 31;
            result ^= t1.GetHashCode();
            result ^= t2.GetHashCode();
            result ^= t3.GetHashCode();
            return result;
        }

        public override string ToString()
        {
            return Match(
                t1 => string.Format("Choice({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Choice({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Choice({0}:{1})", t3, typeof(T3).Name)
            );
        }
    }

    public sealed class Choice<T1, T2, T3, T4> : IEquatable<Choice<T1, T2, T3, T4>>
    {
        readonly Option<T1> t1;
        readonly Option<T2> t2;
        readonly Option<T3> t3;
        readonly Option<T4> t4;

        public Choice(T1 value) { t1 = new Option<T1>(value); }

        public static implicit operator Choice<T1, T2, T3, T4>(T1 value) { return new Choice<T1, T2, T3, T4>(value); }

        public Choice(T2 value) { t2 = new Option<T2>(value); }

        public static implicit operator Choice<T1, T2, T3, T4>(T2 value) { return new Choice<T1, T2, T3, T4>(value); }

        public Choice(T3 value) { t3 = new Option<T3>(value); }

        public static implicit operator Choice<T1, T2, T3, T4>(T3 value) { return new Choice<T1, T2, T3, T4>(value); }

        public Choice(T4 value) { t4 = new Option<T4>(value); }

        public static implicit operator Choice<T1, T2, T3, T4>(T4 value) { return new Choice<T1, T2, T3, T4>(value); }


        public T Match<T>(Func<T1, T> Case1, Func<T2, T> Case2, Func<T3, T> Case3, Func<T4, T> Case4)
        {
            Func<T> thrower = () => { throw new InvalidOperationException(); };
            return t1.Match<T>(Case1, () => t2.Match<T>(Case2, () => t3.Match<T>(Case3, () => t4.Match<T>(Case4, thrower))));
        }

        public bool Equals(Choice<T1, T2, T3, T4> other)
        {
            return other.IsNotNull() && t1 == other.t1 && t2 == other.t2 && t3 == other.t3 && t4 == other.t4;
        }

        public static bool operator ==(Choice<T1, T2, T3, T4> a, Choice<T1, T2, T3, T4> b)
        {
            if (a.IsNull())
                return b.IsNull();
            return a.Equals(b);
        }

        public static bool operator !=(Choice<T1, T2, T3, T4> a, Choice<T1, T2, T3, T4> b)
        {
            return !(a == b);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            var other = obj as Choice<T1, T2, T3, T4>;
            if (other.IsNull())
                return false;
            return Equals(other);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            var result = 31;
            result ^= t1.GetHashCode();
            result ^= t2.GetHashCode();
            result ^= t3.GetHashCode();
            result ^= t4.GetHashCode();
            return result;
        }

        public override string ToString()
        {
            return Match(
                t1 => string.Format("Choice({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Choice({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Choice({0}:{1})", t3, typeof(T3).Name),
                t4 => string.Format("Choice({0}:{1})", t4, typeof(T4).Name)
            );
        }
    }

    public sealed class Choice<T1, T2, T3, T4, T5> : IEquatable<Choice<T1, T2, T3, T4, T5>>
    {
        readonly Option<T1> t1;
        readonly Option<T2> t2;
        readonly Option<T3> t3;
        readonly Option<T4> t4;
        readonly Option<T5> t5;

        public Choice(T1 value) { t1 = new Option<T1>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5>(T1 value) { return new Choice<T1, T2, T3, T4, T5>(value); }

        public Choice(T2 value) { t2 = new Option<T2>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5>(T2 value) { return new Choice<T1, T2, T3, T4, T5>(value); }

        public Choice(T3 value) { t3 = new Option<T3>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5>(T3 value) { return new Choice<T1, T2, T3, T4, T5>(value); }

        public Choice(T4 value) { t4 = new Option<T4>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5>(T4 value) { return new Choice<T1, T2, T3, T4, T5>(value); }

        public Choice(T5 value) { t5 = new Option<T5>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5>(T5 value) { return new Choice<T1, T2, T3, T4, T5>(value); }


        public T Match<T>(Func<T1, T> Case1, Func<T2, T> Case2, Func<T3, T> Case3, Func<T4, T> Case4, Func<T5, T> Case5)
        {
            Func<T> thrower = () => { throw new InvalidOperationException(); };
            return t1.Match<T>(Case1, () => t2.Match<T>(Case2, () => t3.Match<T>(Case3, () => t4.Match<T>(Case4, () => t5.Match<T>(Case5, thrower)))));
        }

        public bool Equals(Choice<T1, T2, T3, T4, T5> other)
        {
            return other.IsNotNull() && t1 == other.t1 && t2 == other.t2 && t3 == other.t3 && t4 == other.t4 && t5 == other.t5;
        }

        public static bool operator ==(Choice<T1, T2, T3, T4, T5> a, Choice<T1, T2, T3, T4, T5> b)
        {
            if (a.IsNull())
                return b.IsNull();
            return a.Equals(b);
        }

        public static bool operator !=(Choice<T1, T2, T3, T4, T5> a, Choice<T1, T2, T3, T4, T5> b)
        {
            return !(a == b);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            var other = obj as Choice<T1, T2, T3, T4, T5>;
            if (other.IsNull())
                return false;
            return Equals(other);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            var result = 31;
            result ^= t1.GetHashCode();
            result ^= t2.GetHashCode();
            result ^= t3.GetHashCode();
            result ^= t4.GetHashCode();
            result ^= t5.GetHashCode();
            return result;
        }

        public override string ToString()
        {
            return Match(
                t1 => string.Format("Choice({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Choice({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Choice({0}:{1})", t3, typeof(T3).Name),
                t4 => string.Format("Choice({0}:{1})", t4, typeof(T4).Name),
                t5 => string.Format("Choice({0}:{1})", t5, typeof(T5).Name)
            );
        }
    }

    public sealed class Choice<T1, T2, T3, T4, T5, T6> : IEquatable<Choice<T1, T2, T3, T4, T5, T6>>
    {
        readonly Option<T1> t1;
        readonly Option<T2> t2;
        readonly Option<T3> t3;
        readonly Option<T4> t4;
        readonly Option<T5> t5;
        readonly Option<T6> t6;

        public Choice(T1 value) { t1 = new Option<T1>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6>(T1 value) { return new Choice<T1, T2, T3, T4, T5, T6>(value); }

        public Choice(T2 value) { t2 = new Option<T2>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6>(T2 value) { return new Choice<T1, T2, T3, T4, T5, T6>(value); }

        public Choice(T3 value) { t3 = new Option<T3>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6>(T3 value) { return new Choice<T1, T2, T3, T4, T5, T6>(value); }

        public Choice(T4 value) { t4 = new Option<T4>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6>(T4 value) { return new Choice<T1, T2, T3, T4, T5, T6>(value); }

        public Choice(T5 value) { t5 = new Option<T5>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6>(T5 value) { return new Choice<T1, T2, T3, T4, T5, T6>(value); }

        public Choice(T6 value) { t6 = new Option<T6>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6>(T6 value) { return new Choice<T1, T2, T3, T4, T5, T6>(value); }


        public T Match<T>(Func<T1, T> Case1, Func<T2, T> Case2, Func<T3, T> Case3, Func<T4, T> Case4, Func<T5, T> Case5, Func<T6, T> Case6)
        {
            Func<T> thrower = () => { throw new InvalidOperationException(); };
            return t1.Match<T>(Case1, () => t2.Match<T>(Case2, () => t3.Match<T>(Case3, () => t4.Match<T>(Case4, () => t5.Match<T>(Case5, () => t6.Match<T>(Case6, thrower))))));
        }

        public bool Equals(Choice<T1, T2, T3, T4, T5, T6> other)
        {
            return other.IsNotNull() && t1 == other.t1 && t2 == other.t2 && t3 == other.t3 && t4 == other.t4 && t5 == other.t5 && t6 == other.t6;
        }

        public static bool operator ==(Choice<T1, T2, T3, T4, T5, T6> a, Choice<T1, T2, T3, T4, T5, T6> b)
        {
            if (a.IsNull())
                return b.IsNull();
            return a.Equals(b);
        }

        public static bool operator !=(Choice<T1, T2, T3, T4, T5, T6> a, Choice<T1, T2, T3, T4, T5, T6> b)
        {
            return !(a == b);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            var other = obj as Choice<T1, T2, T3, T4, T5, T6>;
            if (other.IsNull())
                return false;
            return Equals(other);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            var result = 31;
            result ^= t1.GetHashCode();
            result ^= t2.GetHashCode();
            result ^= t3.GetHashCode();
            result ^= t4.GetHashCode();
            result ^= t5.GetHashCode();
            result ^= t6.GetHashCode();
            return result;
        }

        public override string ToString()
        {
            return Match(
                t1 => string.Format("Choice({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Choice({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Choice({0}:{1})", t3, typeof(T3).Name),
                t4 => string.Format("Choice({0}:{1})", t4, typeof(T4).Name),
                t5 => string.Format("Choice({0}:{1})", t5, typeof(T5).Name),
                t6 => string.Format("Choice({0}:{1})", t6, typeof(T6).Name)
            );
        }
    }

    public sealed class Choice<T1, T2, T3, T4, T5, T6, T7> : IEquatable<Choice<T1, T2, T3, T4, T5, T6, T7>>
    {
        readonly Option<T1> t1;
        readonly Option<T2> t2;
        readonly Option<T3> t3;
        readonly Option<T4> t4;
        readonly Option<T5> t5;
        readonly Option<T6> t6;
        readonly Option<T7> t7;

        public Choice(T1 value) { t1 = new Option<T1>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7>(T1 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7>(value); }

        public Choice(T2 value) { t2 = new Option<T2>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7>(T2 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7>(value); }

        public Choice(T3 value) { t3 = new Option<T3>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7>(T3 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7>(value); }

        public Choice(T4 value) { t4 = new Option<T4>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7>(T4 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7>(value); }

        public Choice(T5 value) { t5 = new Option<T5>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7>(T5 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7>(value); }

        public Choice(T6 value) { t6 = new Option<T6>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7>(T6 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7>(value); }

        public Choice(T7 value) { t7 = new Option<T7>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7>(T7 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7>(value); }


        public T Match<T>(Func<T1, T> Case1, Func<T2, T> Case2, Func<T3, T> Case3, Func<T4, T> Case4, Func<T5, T> Case5, Func<T6, T> Case6, Func<T7, T> Case7)
        {
            Func<T> thrower = () => { throw new InvalidOperationException(); };
            return t1.Match<T>(Case1, () => t2.Match<T>(Case2, () => t3.Match<T>(Case3, () => t4.Match<T>(Case4, () => t5.Match<T>(Case5, () => t6.Match<T>(Case6, () => t7.Match<T>(Case7, thrower)))))));
        }

        public bool Equals(Choice<T1, T2, T3, T4, T5, T6, T7> other)
        {
            return other.IsNotNull() && t1 == other.t1 && t2 == other.t2 && t3 == other.t3 && t4 == other.t4 && t5 == other.t5 && t6 == other.t6 && t7 == other.t7;
        }

        public static bool operator ==(Choice<T1, T2, T3, T4, T5, T6, T7> a, Choice<T1, T2, T3, T4, T5, T6, T7> b)
        {
            if (a.IsNull())
                return b.IsNull();
            return a.Equals(b);
        }

        public static bool operator !=(Choice<T1, T2, T3, T4, T5, T6, T7> a, Choice<T1, T2, T3, T4, T5, T6, T7> b)
        {
            return !(a == b);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            var other = obj as Choice<T1, T2, T3, T4, T5, T6, T7>;
            if (other.IsNull())
                return false;
            return Equals(other);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            var result = 31;
            result ^= t1.GetHashCode();
            result ^= t2.GetHashCode();
            result ^= t3.GetHashCode();
            result ^= t4.GetHashCode();
            result ^= t5.GetHashCode();
            result ^= t6.GetHashCode();
            result ^= t7.GetHashCode();
            return result;
        }

        public override string ToString()
        {
            return Match(
                t1 => string.Format("Choice({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Choice({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Choice({0}:{1})", t3, typeof(T3).Name),
                t4 => string.Format("Choice({0}:{1})", t4, typeof(T4).Name),
                t5 => string.Format("Choice({0}:{1})", t5, typeof(T5).Name),
                t6 => string.Format("Choice({0}:{1})", t6, typeof(T6).Name),
                t7 => string.Format("Choice({0}:{1})", t7, typeof(T7).Name)
            );
        }
    }

    public sealed class Choice<T1, T2, T3, T4, T5, T6, T7, T8> : IEquatable<Choice<T1, T2, T3, T4, T5, T6, T7, T8>>
    {
        readonly Option<T1> t1;
        readonly Option<T2> t2;
        readonly Option<T3> t3;
        readonly Option<T4> t4;
        readonly Option<T5> t5;
        readonly Option<T6> t6;
        readonly Option<T7> t7;
        readonly Option<T8> t8;

        public Choice(T1 value) { t1 = new Option<T1>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8>(T1 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8>(value); }

        public Choice(T2 value) { t2 = new Option<T2>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8>(T2 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8>(value); }

        public Choice(T3 value) { t3 = new Option<T3>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8>(T3 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8>(value); }

        public Choice(T4 value) { t4 = new Option<T4>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8>(T4 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8>(value); }

        public Choice(T5 value) { t5 = new Option<T5>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8>(T5 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8>(value); }

        public Choice(T6 value) { t6 = new Option<T6>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8>(T6 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8>(value); }

        public Choice(T7 value) { t7 = new Option<T7>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8>(T7 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8>(value); }

        public Choice(T8 value) { t8 = new Option<T8>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8>(T8 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8>(value); }


        public T Match<T>(Func<T1, T> Case1, Func<T2, T> Case2, Func<T3, T> Case3, Func<T4, T> Case4, Func<T5, T> Case5, Func<T6, T> Case6, Func<T7, T> Case7, Func<T8, T> Case8)
        {
            Func<T> thrower = () => { throw new InvalidOperationException(); };
            return t1.Match<T>(Case1, () => t2.Match<T>(Case2, () => t3.Match<T>(Case3, () => t4.Match<T>(Case4, () => t5.Match<T>(Case5, () => t6.Match<T>(Case6, () => t7.Match<T>(Case7, () => t8.Match<T>(Case8, thrower))))))));
        }

        public bool Equals(Choice<T1, T2, T3, T4, T5, T6, T7, T8> other)
        {
            return other.IsNotNull() && t1 == other.t1 && t2 == other.t2 && t3 == other.t3 && t4 == other.t4 && t5 == other.t5 && t6 == other.t6 && t7 == other.t7 && t8 == other.t8;
        }

        public static bool operator ==(Choice<T1, T2, T3, T4, T5, T6, T7, T8> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8> b)
        {
            if (a.IsNull())
                return b.IsNull();
            return a.Equals(b);
        }

        public static bool operator !=(Choice<T1, T2, T3, T4, T5, T6, T7, T8> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8> b)
        {
            return !(a == b);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            var other = obj as Choice<T1, T2, T3, T4, T5, T6, T7, T8>;
            if (other.IsNull())
                return false;
            return Equals(other);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            var result = 31;
            result ^= t1.GetHashCode();
            result ^= t2.GetHashCode();
            result ^= t3.GetHashCode();
            result ^= t4.GetHashCode();
            result ^= t5.GetHashCode();
            result ^= t6.GetHashCode();
            result ^= t7.GetHashCode();
            result ^= t8.GetHashCode();
            return result;
        }

        public override string ToString()
        {
            return Match(
                t1 => string.Format("Choice({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Choice({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Choice({0}:{1})", t3, typeof(T3).Name),
                t4 => string.Format("Choice({0}:{1})", t4, typeof(T4).Name),
                t5 => string.Format("Choice({0}:{1})", t5, typeof(T5).Name),
                t6 => string.Format("Choice({0}:{1})", t6, typeof(T6).Name),
                t7 => string.Format("Choice({0}:{1})", t7, typeof(T7).Name),
                t8 => string.Format("Choice({0}:{1})", t8, typeof(T8).Name)
            );
        }
    }

    public sealed class Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9> : IEquatable<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>>
    {
        readonly Option<T1> t1;
        readonly Option<T2> t2;
        readonly Option<T3> t3;
        readonly Option<T4> t4;
        readonly Option<T5> t5;
        readonly Option<T6> t6;
        readonly Option<T7> t7;
        readonly Option<T8> t8;
        readonly Option<T9> t9;

        public Choice(T1 value) { t1 = new Option<T1>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value); }

        public Choice(T2 value) { t2 = new Option<T2>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T2 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value); }

        public Choice(T3 value) { t3 = new Option<T3>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T3 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value); }

        public Choice(T4 value) { t4 = new Option<T4>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T4 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value); }

        public Choice(T5 value) { t5 = new Option<T5>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T5 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value); }

        public Choice(T6 value) { t6 = new Option<T6>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T6 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value); }

        public Choice(T7 value) { t7 = new Option<T7>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T7 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value); }

        public Choice(T8 value) { t8 = new Option<T8>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T8 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value); }

        public Choice(T9 value) { t9 = new Option<T9>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T9 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value); }


        public T Match<T>(Func<T1, T> Case1, Func<T2, T> Case2, Func<T3, T> Case3, Func<T4, T> Case4, Func<T5, T> Case5, Func<T6, T> Case6, Func<T7, T> Case7, Func<T8, T> Case8, Func<T9, T> Case9)
        {
            Func<T> thrower = () => { throw new InvalidOperationException(); };
            return t1.Match<T>(Case1, () => t2.Match<T>(Case2, () => t3.Match<T>(Case3, () => t4.Match<T>(Case4, () => t5.Match<T>(Case5, () => t6.Match<T>(Case6, () => t7.Match<T>(Case7, () => t8.Match<T>(Case8, () => t9.Match<T>(Case9, thrower)))))))));
        }

        public bool Equals(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9> other)
        {
            return other.IsNotNull() && t1 == other.t1 && t2 == other.t2 && t3 == other.t3 && t4 == other.t4 && t5 == other.t5 && t6 == other.t6 && t7 == other.t7 && t8 == other.t8 && t9 == other.t9;
        }

        public static bool operator ==(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9> b)
        {
            if (a.IsNull())
                return b.IsNull();
            return a.Equals(b);
        }

        public static bool operator !=(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9> b)
        {
            return !(a == b);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            var other = obj as Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>;
            if (other.IsNull())
                return false;
            return Equals(other);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            var result = 31;
            result ^= t1.GetHashCode();
            result ^= t2.GetHashCode();
            result ^= t3.GetHashCode();
            result ^= t4.GetHashCode();
            result ^= t5.GetHashCode();
            result ^= t6.GetHashCode();
            result ^= t7.GetHashCode();
            result ^= t8.GetHashCode();
            result ^= t9.GetHashCode();
            return result;
        }

        public override string ToString()
        {
            return Match(
                t1 => string.Format("Choice({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Choice({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Choice({0}:{1})", t3, typeof(T3).Name),
                t4 => string.Format("Choice({0}:{1})", t4, typeof(T4).Name),
                t5 => string.Format("Choice({0}:{1})", t5, typeof(T5).Name),
                t6 => string.Format("Choice({0}:{1})", t6, typeof(T6).Name),
                t7 => string.Format("Choice({0}:{1})", t7, typeof(T7).Name),
                t8 => string.Format("Choice({0}:{1})", t8, typeof(T8).Name),
                t9 => string.Format("Choice({0}:{1})", t9, typeof(T9).Name)
            );
        }
    }

    public sealed class Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : IEquatable<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>
    {
        readonly Option<T1> t1;
        readonly Option<T2> t2;
        readonly Option<T3> t3;
        readonly Option<T4> t4;
        readonly Option<T5> t5;
        readonly Option<T6> t6;
        readonly Option<T7> t7;
        readonly Option<T8> t8;
        readonly Option<T9> t9;
        readonly Option<T10> t10;

        public Choice(T1 value) { t1 = new Option<T1>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value); }

        public Choice(T2 value) { t2 = new Option<T2>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T2 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value); }

        public Choice(T3 value) { t3 = new Option<T3>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T3 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value); }

        public Choice(T4 value) { t4 = new Option<T4>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T4 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value); }

        public Choice(T5 value) { t5 = new Option<T5>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T5 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value); }

        public Choice(T6 value) { t6 = new Option<T6>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T6 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value); }

        public Choice(T7 value) { t7 = new Option<T7>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T7 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value); }

        public Choice(T8 value) { t8 = new Option<T8>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T8 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value); }

        public Choice(T9 value) { t9 = new Option<T9>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T9 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value); }

        public Choice(T10 value) { t10 = new Option<T10>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T10 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value); }


        public T Match<T>(Func<T1, T> Case1, Func<T2, T> Case2, Func<T3, T> Case3, Func<T4, T> Case4, Func<T5, T> Case5, Func<T6, T> Case6, Func<T7, T> Case7, Func<T8, T> Case8, Func<T9, T> Case9, Func<T10, T> Case10)
        {
            Func<T> thrower = () => { throw new InvalidOperationException(); };
            return t1.Match<T>(Case1, () => t2.Match<T>(Case2, () => t3.Match<T>(Case3, () => t4.Match<T>(Case4, () => t5.Match<T>(Case5, () => t6.Match<T>(Case6, () => t7.Match<T>(Case7, () => t8.Match<T>(Case8, () => t9.Match<T>(Case9, () => t10.Match<T>(Case10, thrower))))))))));
        }

        public bool Equals(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> other)
        {
            return other.IsNotNull() && t1 == other.t1 && t2 == other.t2 && t3 == other.t3 && t4 == other.t4 && t5 == other.t5 && t6 == other.t6 && t7 == other.t7 && t8 == other.t8 && t9 == other.t9 && t10 == other.t10;
        }

        public static bool operator ==(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> b)
        {
            if (a.IsNull())
                return b.IsNull();
            return a.Equals(b);
        }

        public static bool operator !=(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> b)
        {
            return !(a == b);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            var other = obj as Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>;
            if (other.IsNull())
                return false;
            return Equals(other);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            var result = 31;
            result ^= t1.GetHashCode();
            result ^= t2.GetHashCode();
            result ^= t3.GetHashCode();
            result ^= t4.GetHashCode();
            result ^= t5.GetHashCode();
            result ^= t6.GetHashCode();
            result ^= t7.GetHashCode();
            result ^= t8.GetHashCode();
            result ^= t9.GetHashCode();
            result ^= t10.GetHashCode();
            return result;
        }

        public override string ToString()
        {
            return Match(
                t1 => string.Format("Choice({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Choice({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Choice({0}:{1})", t3, typeof(T3).Name),
                t4 => string.Format("Choice({0}:{1})", t4, typeof(T4).Name),
                t5 => string.Format("Choice({0}:{1})", t5, typeof(T5).Name),
                t6 => string.Format("Choice({0}:{1})", t6, typeof(T6).Name),
                t7 => string.Format("Choice({0}:{1})", t7, typeof(T7).Name),
                t8 => string.Format("Choice({0}:{1})", t8, typeof(T8).Name),
                t9 => string.Format("Choice({0}:{1})", t9, typeof(T9).Name),
                t10 => string.Format("Choice({0}:{1})", t10, typeof(T10).Name)
            );
        }
    }

    public sealed class Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : IEquatable<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>
    {
        readonly Option<T1> t1;
        readonly Option<T2> t2;
        readonly Option<T3> t3;
        readonly Option<T4> t4;
        readonly Option<T5> t5;
        readonly Option<T6> t6;
        readonly Option<T7> t7;
        readonly Option<T8> t8;
        readonly Option<T9> t9;
        readonly Option<T10> t10;
        readonly Option<T11> t11;

        public Choice(T1 value) { t1 = new Option<T1>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value); }

        public Choice(T2 value) { t2 = new Option<T2>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T2 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value); }

        public Choice(T3 value) { t3 = new Option<T3>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T3 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value); }

        public Choice(T4 value) { t4 = new Option<T4>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T4 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value); }

        public Choice(T5 value) { t5 = new Option<T5>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T5 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value); }

        public Choice(T6 value) { t6 = new Option<T6>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T6 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value); }

        public Choice(T7 value) { t7 = new Option<T7>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T7 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value); }

        public Choice(T8 value) { t8 = new Option<T8>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T8 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value); }

        public Choice(T9 value) { t9 = new Option<T9>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T9 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value); }

        public Choice(T10 value) { t10 = new Option<T10>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T10 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value); }

        public Choice(T11 value) { t11 = new Option<T11>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T11 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value); }


        public T Match<T>(Func<T1, T> Case1, Func<T2, T> Case2, Func<T3, T> Case3, Func<T4, T> Case4, Func<T5, T> Case5, Func<T6, T> Case6, Func<T7, T> Case7, Func<T8, T> Case8, Func<T9, T> Case9, Func<T10, T> Case10, Func<T11, T> Case11)
        {
            Func<T> thrower = () => { throw new InvalidOperationException(); };
            return t1.Match<T>(Case1, () => t2.Match<T>(Case2, () => t3.Match<T>(Case3, () => t4.Match<T>(Case4, () => t5.Match<T>(Case5, () => t6.Match<T>(Case6, () => t7.Match<T>(Case7, () => t8.Match<T>(Case8, () => t9.Match<T>(Case9, () => t10.Match<T>(Case10, () => t11.Match<T>(Case11, thrower)))))))))));
        }

        public bool Equals(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> other)
        {
            return other.IsNotNull() && t1 == other.t1 && t2 == other.t2 && t3 == other.t3 && t4 == other.t4 && t5 == other.t5 && t6 == other.t6 && t7 == other.t7 && t8 == other.t8 && t9 == other.t9 && t10 == other.t10 && t11 == other.t11;
        }

        public static bool operator ==(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> b)
        {
            if (a.IsNull())
                return b.IsNull();
            return a.Equals(b);
        }

        public static bool operator !=(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> b)
        {
            return !(a == b);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            var other = obj as Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>;
            if (other.IsNull())
                return false;
            return Equals(other);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            var result = 31;
            result ^= t1.GetHashCode();
            result ^= t2.GetHashCode();
            result ^= t3.GetHashCode();
            result ^= t4.GetHashCode();
            result ^= t5.GetHashCode();
            result ^= t6.GetHashCode();
            result ^= t7.GetHashCode();
            result ^= t8.GetHashCode();
            result ^= t9.GetHashCode();
            result ^= t10.GetHashCode();
            result ^= t11.GetHashCode();
            return result;
        }

        public override string ToString()
        {
            return Match(
                t1 => string.Format("Choice({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Choice({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Choice({0}:{1})", t3, typeof(T3).Name),
                t4 => string.Format("Choice({0}:{1})", t4, typeof(T4).Name),
                t5 => string.Format("Choice({0}:{1})", t5, typeof(T5).Name),
                t6 => string.Format("Choice({0}:{1})", t6, typeof(T6).Name),
                t7 => string.Format("Choice({0}:{1})", t7, typeof(T7).Name),
                t8 => string.Format("Choice({0}:{1})", t8, typeof(T8).Name),
                t9 => string.Format("Choice({0}:{1})", t9, typeof(T9).Name),
                t10 => string.Format("Choice({0}:{1})", t10, typeof(T10).Name),
                t11 => string.Format("Choice({0}:{1})", t11, typeof(T11).Name)
            );
        }
    }

    public sealed class Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : IEquatable<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>
    {
        readonly Option<T1> t1;
        readonly Option<T2> t2;
        readonly Option<T3> t3;
        readonly Option<T4> t4;
        readonly Option<T5> t5;
        readonly Option<T6> t6;
        readonly Option<T7> t7;
        readonly Option<T8> t8;
        readonly Option<T9> t9;
        readonly Option<T10> t10;
        readonly Option<T11> t11;
        readonly Option<T12> t12;

        public Choice(T1 value) { t1 = new Option<T1>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value); }

        public Choice(T2 value) { t2 = new Option<T2>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T2 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value); }

        public Choice(T3 value) { t3 = new Option<T3>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T3 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value); }

        public Choice(T4 value) { t4 = new Option<T4>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T4 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value); }

        public Choice(T5 value) { t5 = new Option<T5>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T5 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value); }

        public Choice(T6 value) { t6 = new Option<T6>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T6 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value); }

        public Choice(T7 value) { t7 = new Option<T7>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T7 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value); }

        public Choice(T8 value) { t8 = new Option<T8>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T8 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value); }

        public Choice(T9 value) { t9 = new Option<T9>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T9 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value); }

        public Choice(T10 value) { t10 = new Option<T10>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T10 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value); }

        public Choice(T11 value) { t11 = new Option<T11>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T11 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value); }

        public Choice(T12 value) { t12 = new Option<T12>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T12 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value); }


        public T Match<T>(Func<T1, T> Case1, Func<T2, T> Case2, Func<T3, T> Case3, Func<T4, T> Case4, Func<T5, T> Case5, Func<T6, T> Case6, Func<T7, T> Case7, Func<T8, T> Case8, Func<T9, T> Case9, Func<T10, T> Case10, Func<T11, T> Case11, Func<T12, T> Case12)
        {
            Func<T> thrower = () => { throw new InvalidOperationException(); };
            return t1.Match<T>(Case1, () => t2.Match<T>(Case2, () => t3.Match<T>(Case3, () => t4.Match<T>(Case4, () => t5.Match<T>(Case5, () => t6.Match<T>(Case6, () => t7.Match<T>(Case7, () => t8.Match<T>(Case8, () => t9.Match<T>(Case9, () => t10.Match<T>(Case10, () => t11.Match<T>(Case11, () => t12.Match<T>(Case12, thrower))))))))))));
        }

        public bool Equals(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> other)
        {
            return other.IsNotNull() && t1 == other.t1 && t2 == other.t2 && t3 == other.t3 && t4 == other.t4 && t5 == other.t5 && t6 == other.t6 && t7 == other.t7 && t8 == other.t8 && t9 == other.t9 && t10 == other.t10 && t11 == other.t11 && t12 == other.t12;
        }

        public static bool operator ==(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> b)
        {
            if (a.IsNull())
                return b.IsNull();
            return a.Equals(b);
        }

        public static bool operator !=(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> b)
        {
            return !(a == b);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            var other = obj as Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>;
            if (other.IsNull())
                return false;
            return Equals(other);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            var result = 31;
            result ^= t1.GetHashCode();
            result ^= t2.GetHashCode();
            result ^= t3.GetHashCode();
            result ^= t4.GetHashCode();
            result ^= t5.GetHashCode();
            result ^= t6.GetHashCode();
            result ^= t7.GetHashCode();
            result ^= t8.GetHashCode();
            result ^= t9.GetHashCode();
            result ^= t10.GetHashCode();
            result ^= t11.GetHashCode();
            result ^= t12.GetHashCode();
            return result;
        }

        public override string ToString()
        {
            return Match(
                t1 => string.Format("Choice({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Choice({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Choice({0}:{1})", t3, typeof(T3).Name),
                t4 => string.Format("Choice({0}:{1})", t4, typeof(T4).Name),
                t5 => string.Format("Choice({0}:{1})", t5, typeof(T5).Name),
                t6 => string.Format("Choice({0}:{1})", t6, typeof(T6).Name),
                t7 => string.Format("Choice({0}:{1})", t7, typeof(T7).Name),
                t8 => string.Format("Choice({0}:{1})", t8, typeof(T8).Name),
                t9 => string.Format("Choice({0}:{1})", t9, typeof(T9).Name),
                t10 => string.Format("Choice({0}:{1})", t10, typeof(T10).Name),
                t11 => string.Format("Choice({0}:{1})", t11, typeof(T11).Name),
                t12 => string.Format("Choice({0}:{1})", t12, typeof(T12).Name)
            );
        }
    }

    public sealed class Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : IEquatable<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>
    {
        readonly Option<T1> t1;
        readonly Option<T2> t2;
        readonly Option<T3> t3;
        readonly Option<T4> t4;
        readonly Option<T5> t5;
        readonly Option<T6> t6;
        readonly Option<T7> t7;
        readonly Option<T8> t8;
        readonly Option<T9> t9;
        readonly Option<T10> t10;
        readonly Option<T11> t11;
        readonly Option<T12> t12;
        readonly Option<T13> t13;

        public Choice(T1 value) { t1 = new Option<T1>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value); }

        public Choice(T2 value) { t2 = new Option<T2>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T2 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value); }

        public Choice(T3 value) { t3 = new Option<T3>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T3 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value); }

        public Choice(T4 value) { t4 = new Option<T4>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T4 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value); }

        public Choice(T5 value) { t5 = new Option<T5>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T5 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value); }

        public Choice(T6 value) { t6 = new Option<T6>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T6 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value); }

        public Choice(T7 value) { t7 = new Option<T7>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T7 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value); }

        public Choice(T8 value) { t8 = new Option<T8>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T8 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value); }

        public Choice(T9 value) { t9 = new Option<T9>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T9 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value); }

        public Choice(T10 value) { t10 = new Option<T10>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T10 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value); }

        public Choice(T11 value) { t11 = new Option<T11>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T11 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value); }

        public Choice(T12 value) { t12 = new Option<T12>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T12 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value); }

        public Choice(T13 value) { t13 = new Option<T13>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T13 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value); }


        public T Match<T>(Func<T1, T> Case1, Func<T2, T> Case2, Func<T3, T> Case3, Func<T4, T> Case4, Func<T5, T> Case5, Func<T6, T> Case6, Func<T7, T> Case7, Func<T8, T> Case8, Func<T9, T> Case9, Func<T10, T> Case10, Func<T11, T> Case11, Func<T12, T> Case12, Func<T13, T> Case13)
        {
            Func<T> thrower = () => { throw new InvalidOperationException(); };
            return t1.Match<T>(Case1, () => t2.Match<T>(Case2, () => t3.Match<T>(Case3, () => t4.Match<T>(Case4, () => t5.Match<T>(Case5, () => t6.Match<T>(Case6, () => t7.Match<T>(Case7, () => t8.Match<T>(Case8, () => t9.Match<T>(Case9, () => t10.Match<T>(Case10, () => t11.Match<T>(Case11, () => t12.Match<T>(Case12, () => t13.Match<T>(Case13, thrower)))))))))))));
        }

        public bool Equals(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> other)
        {
            return other.IsNotNull() && t1 == other.t1 && t2 == other.t2 && t3 == other.t3 && t4 == other.t4 && t5 == other.t5 && t6 == other.t6 && t7 == other.t7 && t8 == other.t8 && t9 == other.t9 && t10 == other.t10 && t11 == other.t11 && t12 == other.t12 && t13 == other.t13;
        }

        public static bool operator ==(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> b)
        {
            if (a.IsNull())
                return b.IsNull();
            return a.Equals(b);
        }

        public static bool operator !=(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> b)
        {
            return !(a == b);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            var other = obj as Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>;
            if (other.IsNull())
                return false;
            return Equals(other);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            var result = 31;
            result ^= t1.GetHashCode();
            result ^= t2.GetHashCode();
            result ^= t3.GetHashCode();
            result ^= t4.GetHashCode();
            result ^= t5.GetHashCode();
            result ^= t6.GetHashCode();
            result ^= t7.GetHashCode();
            result ^= t8.GetHashCode();
            result ^= t9.GetHashCode();
            result ^= t10.GetHashCode();
            result ^= t11.GetHashCode();
            result ^= t12.GetHashCode();
            result ^= t13.GetHashCode();
            return result;
        }

        public override string ToString()
        {
            return Match(
                t1 => string.Format("Choice({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Choice({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Choice({0}:{1})", t3, typeof(T3).Name),
                t4 => string.Format("Choice({0}:{1})", t4, typeof(T4).Name),
                t5 => string.Format("Choice({0}:{1})", t5, typeof(T5).Name),
                t6 => string.Format("Choice({0}:{1})", t6, typeof(T6).Name),
                t7 => string.Format("Choice({0}:{1})", t7, typeof(T7).Name),
                t8 => string.Format("Choice({0}:{1})", t8, typeof(T8).Name),
                t9 => string.Format("Choice({0}:{1})", t9, typeof(T9).Name),
                t10 => string.Format("Choice({0}:{1})", t10, typeof(T10).Name),
                t11 => string.Format("Choice({0}:{1})", t11, typeof(T11).Name),
                t12 => string.Format("Choice({0}:{1})", t12, typeof(T12).Name),
                t13 => string.Format("Choice({0}:{1})", t13, typeof(T13).Name)
            );
        }
    }

    public sealed class Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : IEquatable<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>
    {
        readonly Option<T1> t1;
        readonly Option<T2> t2;
        readonly Option<T3> t3;
        readonly Option<T4> t4;
        readonly Option<T5> t5;
        readonly Option<T6> t6;
        readonly Option<T7> t7;
        readonly Option<T8> t8;
        readonly Option<T9> t9;
        readonly Option<T10> t10;
        readonly Option<T11> t11;
        readonly Option<T12> t12;
        readonly Option<T13> t13;
        readonly Option<T14> t14;

        public Choice(T1 value) { t1 = new Option<T1>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value); }

        public Choice(T2 value) { t2 = new Option<T2>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T2 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value); }

        public Choice(T3 value) { t3 = new Option<T3>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T3 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value); }

        public Choice(T4 value) { t4 = new Option<T4>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T4 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value); }

        public Choice(T5 value) { t5 = new Option<T5>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T5 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value); }

        public Choice(T6 value) { t6 = new Option<T6>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T6 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value); }

        public Choice(T7 value) { t7 = new Option<T7>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T7 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value); }

        public Choice(T8 value) { t8 = new Option<T8>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T8 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value); }

        public Choice(T9 value) { t9 = new Option<T9>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T9 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value); }

        public Choice(T10 value) { t10 = new Option<T10>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T10 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value); }

        public Choice(T11 value) { t11 = new Option<T11>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T11 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value); }

        public Choice(T12 value) { t12 = new Option<T12>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T12 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value); }

        public Choice(T13 value) { t13 = new Option<T13>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T13 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value); }

        public Choice(T14 value) { t14 = new Option<T14>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T14 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value); }


        public T Match<T>(Func<T1, T> Case1, Func<T2, T> Case2, Func<T3, T> Case3, Func<T4, T> Case4, Func<T5, T> Case5, Func<T6, T> Case6, Func<T7, T> Case7, Func<T8, T> Case8, Func<T9, T> Case9, Func<T10, T> Case10, Func<T11, T> Case11, Func<T12, T> Case12, Func<T13, T> Case13, Func<T14, T> Case14)
        {
            Func<T> thrower = () => { throw new InvalidOperationException(); };
            return t1.Match<T>(Case1, () => t2.Match<T>(Case2, () => t3.Match<T>(Case3, () => t4.Match<T>(Case4, () => t5.Match<T>(Case5, () => t6.Match<T>(Case6, () => t7.Match<T>(Case7, () => t8.Match<T>(Case8, () => t9.Match<T>(Case9, () => t10.Match<T>(Case10, () => t11.Match<T>(Case11, () => t12.Match<T>(Case12, () => t13.Match<T>(Case13, () => t14.Match<T>(Case14, thrower))))))))))))));
        }

        public bool Equals(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> other)
        {
            return other.IsNotNull() && t1 == other.t1 && t2 == other.t2 && t3 == other.t3 && t4 == other.t4 && t5 == other.t5 && t6 == other.t6 && t7 == other.t7 && t8 == other.t8 && t9 == other.t9 && t10 == other.t10 && t11 == other.t11 && t12 == other.t12 && t13 == other.t13 && t14 == other.t14;
        }

        public static bool operator ==(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> b)
        {
            if (a.IsNull())
                return b.IsNull();
            return a.Equals(b);
        }

        public static bool operator !=(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> b)
        {
            return !(a == b);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            var other = obj as Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>;
            if (other.IsNull())
                return false;
            return Equals(other);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            var result = 31;
            result ^= t1.GetHashCode();
            result ^= t2.GetHashCode();
            result ^= t3.GetHashCode();
            result ^= t4.GetHashCode();
            result ^= t5.GetHashCode();
            result ^= t6.GetHashCode();
            result ^= t7.GetHashCode();
            result ^= t8.GetHashCode();
            result ^= t9.GetHashCode();
            result ^= t10.GetHashCode();
            result ^= t11.GetHashCode();
            result ^= t12.GetHashCode();
            result ^= t13.GetHashCode();
            result ^= t14.GetHashCode();
            return result;
        }

        public override string ToString()
        {
            return Match(
                t1 => string.Format("Choice({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Choice({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Choice({0}:{1})", t3, typeof(T3).Name),
                t4 => string.Format("Choice({0}:{1})", t4, typeof(T4).Name),
                t5 => string.Format("Choice({0}:{1})", t5, typeof(T5).Name),
                t6 => string.Format("Choice({0}:{1})", t6, typeof(T6).Name),
                t7 => string.Format("Choice({0}:{1})", t7, typeof(T7).Name),
                t8 => string.Format("Choice({0}:{1})", t8, typeof(T8).Name),
                t9 => string.Format("Choice({0}:{1})", t9, typeof(T9).Name),
                t10 => string.Format("Choice({0}:{1})", t10, typeof(T10).Name),
                t11 => string.Format("Choice({0}:{1})", t11, typeof(T11).Name),
                t12 => string.Format("Choice({0}:{1})", t12, typeof(T12).Name),
                t13 => string.Format("Choice({0}:{1})", t13, typeof(T13).Name),
                t14 => string.Format("Choice({0}:{1})", t14, typeof(T14).Name)
            );
        }
    }

    public sealed class Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : IEquatable<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>
    {
        readonly Option<T1> t1;
        readonly Option<T2> t2;
        readonly Option<T3> t3;
        readonly Option<T4> t4;
        readonly Option<T5> t5;
        readonly Option<T6> t6;
        readonly Option<T7> t7;
        readonly Option<T8> t8;
        readonly Option<T9> t9;
        readonly Option<T10> t10;
        readonly Option<T11> t11;
        readonly Option<T12> t12;
        readonly Option<T13> t13;
        readonly Option<T14> t14;
        readonly Option<T15> t15;

        public Choice(T1 value) { t1 = new Option<T1>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value); }

        public Choice(T2 value) { t2 = new Option<T2>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T2 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value); }

        public Choice(T3 value) { t3 = new Option<T3>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T3 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value); }

        public Choice(T4 value) { t4 = new Option<T4>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T4 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value); }

        public Choice(T5 value) { t5 = new Option<T5>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T5 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value); }

        public Choice(T6 value) { t6 = new Option<T6>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T6 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value); }

        public Choice(T7 value) { t7 = new Option<T7>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T7 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value); }

        public Choice(T8 value) { t8 = new Option<T8>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T8 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value); }

        public Choice(T9 value) { t9 = new Option<T9>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T9 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value); }

        public Choice(T10 value) { t10 = new Option<T10>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T10 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value); }

        public Choice(T11 value) { t11 = new Option<T11>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T11 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value); }

        public Choice(T12 value) { t12 = new Option<T12>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T12 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value); }

        public Choice(T13 value) { t13 = new Option<T13>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T13 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value); }

        public Choice(T14 value) { t14 = new Option<T14>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T14 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value); }

        public Choice(T15 value) { t15 = new Option<T15>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T15 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value); }


        public T Match<T>(Func<T1, T> Case1, Func<T2, T> Case2, Func<T3, T> Case3, Func<T4, T> Case4, Func<T5, T> Case5, Func<T6, T> Case6, Func<T7, T> Case7, Func<T8, T> Case8, Func<T9, T> Case9, Func<T10, T> Case10, Func<T11, T> Case11, Func<T12, T> Case12, Func<T13, T> Case13, Func<T14, T> Case14, Func<T15, T> Case15)
        {
            Func<T> thrower = () => { throw new InvalidOperationException(); };
            return t1.Match<T>(Case1, () => t2.Match<T>(Case2, () => t3.Match<T>(Case3, () => t4.Match<T>(Case4, () => t5.Match<T>(Case5, () => t6.Match<T>(Case6, () => t7.Match<T>(Case7, () => t8.Match<T>(Case8, () => t9.Match<T>(Case9, () => t10.Match<T>(Case10, () => t11.Match<T>(Case11, () => t12.Match<T>(Case12, () => t13.Match<T>(Case13, () => t14.Match<T>(Case14, () => t15.Match<T>(Case15, thrower)))))))))))))));
        }

        public bool Equals(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> other)
        {
            return other.IsNotNull() && t1 == other.t1 && t2 == other.t2 && t3 == other.t3 && t4 == other.t4 && t5 == other.t5 && t6 == other.t6 && t7 == other.t7 && t8 == other.t8 && t9 == other.t9 && t10 == other.t10 && t11 == other.t11 && t12 == other.t12 && t13 == other.t13 && t14 == other.t14 && t15 == other.t15;
        }

        public static bool operator ==(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> b)
        {
            if (a.IsNull())
                return b.IsNull();
            return a.Equals(b);
        }

        public static bool operator !=(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> b)
        {
            return !(a == b);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            var other = obj as Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>;
            if (other.IsNull())
                return false;
            return Equals(other);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            var result = 31;
            result ^= t1.GetHashCode();
            result ^= t2.GetHashCode();
            result ^= t3.GetHashCode();
            result ^= t4.GetHashCode();
            result ^= t5.GetHashCode();
            result ^= t6.GetHashCode();
            result ^= t7.GetHashCode();
            result ^= t8.GetHashCode();
            result ^= t9.GetHashCode();
            result ^= t10.GetHashCode();
            result ^= t11.GetHashCode();
            result ^= t12.GetHashCode();
            result ^= t13.GetHashCode();
            result ^= t14.GetHashCode();
            result ^= t15.GetHashCode();
            return result;
        }

        public override string ToString()
        {
            return Match(
                t1 => string.Format("Choice({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Choice({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Choice({0}:{1})", t3, typeof(T3).Name),
                t4 => string.Format("Choice({0}:{1})", t4, typeof(T4).Name),
                t5 => string.Format("Choice({0}:{1})", t5, typeof(T5).Name),
                t6 => string.Format("Choice({0}:{1})", t6, typeof(T6).Name),
                t7 => string.Format("Choice({0}:{1})", t7, typeof(T7).Name),
                t8 => string.Format("Choice({0}:{1})", t8, typeof(T8).Name),
                t9 => string.Format("Choice({0}:{1})", t9, typeof(T9).Name),
                t10 => string.Format("Choice({0}:{1})", t10, typeof(T10).Name),
                t11 => string.Format("Choice({0}:{1})", t11, typeof(T11).Name),
                t12 => string.Format("Choice({0}:{1})", t12, typeof(T12).Name),
                t13 => string.Format("Choice({0}:{1})", t13, typeof(T13).Name),
                t14 => string.Format("Choice({0}:{1})", t14, typeof(T14).Name),
                t15 => string.Format("Choice({0}:{1})", t15, typeof(T15).Name)
            );
        }
    }

    public sealed class Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : IEquatable<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>
    {
        readonly Option<T1> t1;
        readonly Option<T2> t2;
        readonly Option<T3> t3;
        readonly Option<T4> t4;
        readonly Option<T5> t5;
        readonly Option<T6> t6;
        readonly Option<T7> t7;
        readonly Option<T8> t8;
        readonly Option<T9> t9;
        readonly Option<T10> t10;
        readonly Option<T11> t11;
        readonly Option<T12> t12;
        readonly Option<T13> t13;
        readonly Option<T14> t14;
        readonly Option<T15> t15;
        readonly Option<T16> t16;

        public Choice(T1 value) { t1 = new Option<T1>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T1 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value); }

        public Choice(T2 value) { t2 = new Option<T2>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T2 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value); }

        public Choice(T3 value) { t3 = new Option<T3>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T3 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value); }

        public Choice(T4 value) { t4 = new Option<T4>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T4 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value); }

        public Choice(T5 value) { t5 = new Option<T5>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T5 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value); }

        public Choice(T6 value) { t6 = new Option<T6>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T6 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value); }

        public Choice(T7 value) { t7 = new Option<T7>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T7 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value); }

        public Choice(T8 value) { t8 = new Option<T8>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T8 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value); }

        public Choice(T9 value) { t9 = new Option<T9>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T9 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value); }

        public Choice(T10 value) { t10 = new Option<T10>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T10 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value); }

        public Choice(T11 value) { t11 = new Option<T11>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T11 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value); }

        public Choice(T12 value) { t12 = new Option<T12>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T12 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value); }

        public Choice(T13 value) { t13 = new Option<T13>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T13 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value); }

        public Choice(T14 value) { t14 = new Option<T14>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T14 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value); }

        public Choice(T15 value) { t15 = new Option<T15>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T15 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value); }

        public Choice(T16 value) { t16 = new Option<T16>(value); }

        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T16 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value); }


        public T Match<T>(Func<T1, T> Case1, Func<T2, T> Case2, Func<T3, T> Case3, Func<T4, T> Case4, Func<T5, T> Case5, Func<T6, T> Case6, Func<T7, T> Case7, Func<T8, T> Case8, Func<T9, T> Case9, Func<T10, T> Case10, Func<T11, T> Case11, Func<T12, T> Case12, Func<T13, T> Case13, Func<T14, T> Case14, Func<T15, T> Case15, Func<T16, T> Case16)
        {
            Func<T> thrower = () => { throw new InvalidOperationException(); };
            return t1.Match<T>(Case1, () => t2.Match<T>(Case2, () => t3.Match<T>(Case3, () => t4.Match<T>(Case4, () => t5.Match<T>(Case5, () => t6.Match<T>(Case6, () => t7.Match<T>(Case7, () => t8.Match<T>(Case8, () => t9.Match<T>(Case9, () => t10.Match<T>(Case10, () => t11.Match<T>(Case11, () => t12.Match<T>(Case12, () => t13.Match<T>(Case13, () => t14.Match<T>(Case14, () => t15.Match<T>(Case15, () => t16.Match<T>(Case16, thrower))))))))))))))));
        }

        public bool Equals(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> other)
        {
            return other.IsNotNull() && t1 == other.t1 && t2 == other.t2 && t3 == other.t3 && t4 == other.t4 && t5 == other.t5 && t6 == other.t6 && t7 == other.t7 && t8 == other.t8 && t9 == other.t9 && t10 == other.t10 && t11 == other.t11 && t12 == other.t12 && t13 == other.t13 && t14 == other.t14 && t15 == other.t15 && t16 == other.t16;
        }

        public static bool operator ==(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> b)
        {
            if (a.IsNull())
                return b.IsNull();
            return a.Equals(b);
        }

        public static bool operator !=(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> b)
        {
            return !(a == b);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            var other = obj as Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>;
            if (other.IsNull())
                return false;
            return Equals(other);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            var result = 31;
            result ^= t1.GetHashCode();
            result ^= t2.GetHashCode();
            result ^= t3.GetHashCode();
            result ^= t4.GetHashCode();
            result ^= t5.GetHashCode();
            result ^= t6.GetHashCode();
            result ^= t7.GetHashCode();
            result ^= t8.GetHashCode();
            result ^= t9.GetHashCode();
            result ^= t10.GetHashCode();
            result ^= t11.GetHashCode();
            result ^= t12.GetHashCode();
            result ^= t13.GetHashCode();
            result ^= t14.GetHashCode();
            result ^= t15.GetHashCode();
            result ^= t16.GetHashCode();
            return result;
        }

        public override string ToString()
        {
            return Match(
                t1 => string.Format("Choice({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Choice({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Choice({0}:{1})", t3, typeof(T3).Name),
                t4 => string.Format("Choice({0}:{1})", t4, typeof(T4).Name),
                t5 => string.Format("Choice({0}:{1})", t5, typeof(T5).Name),
                t6 => string.Format("Choice({0}:{1})", t6, typeof(T6).Name),
                t7 => string.Format("Choice({0}:{1})", t7, typeof(T7).Name),
                t8 => string.Format("Choice({0}:{1})", t8, typeof(T8).Name),
                t9 => string.Format("Choice({0}:{1})", t9, typeof(T9).Name),
                t10 => string.Format("Choice({0}:{1})", t10, typeof(T10).Name),
                t11 => string.Format("Choice({0}:{1})", t11, typeof(T11).Name),
                t12 => string.Format("Choice({0}:{1})", t12, typeof(T12).Name),
                t13 => string.Format("Choice({0}:{1})", t13, typeof(T13).Name),
                t14 => string.Format("Choice({0}:{1})", t14, typeof(T14).Name),
                t15 => string.Format("Choice({0}:{1})", t15, typeof(T15).Name),
                t16 => string.Format("Choice({0}:{1})", t16, typeof(T16).Name)
            );
        }
    }

}