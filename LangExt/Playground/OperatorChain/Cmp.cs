using System;

namespace LangExt.Playground.OperatorChain
{
    /// <summary>
    /// 比較演算子のチェーンを使うために必要なラッパークラスです。
    /// </summary>
    /// <typeparam name="T">ラップする(自身と比較可能な)型</typeparam>
    public struct Cmp<T> where T : IComparable<T>
    {
        static readonly Cmp<T> none = new Cmp<T>();

        bool hasValue;
        readonly T value;

        /// <summary>
        /// 引数をラップしたオブジェクトを構築します。
        /// </summary>
        /// <param name="value">ラップする(比較可能な)値</param>
        public Cmp(T value)
        {
            this.value = value;
            this.hasValue = true;
        }

        /// <summary>
        /// このオブジェクトが保持する値を取得します。
        /// オブジェクトが値を持っていなかった場合に参照すると、その型のデフォルト値が返ります。
        /// </summary>
        public T Value { get { return this.value; } }

        /// <summary>
        /// このオブジェクトが保持する値を取得します。
        /// オブジェクトが値を持っていなかった場合はNoneが返ります。
        /// </summary>
        public Option<T> TryGet() { return hasValue ? Option.Some(value) : Option.None; }

        /// <summary>
        /// 比較可能な値からCmp[T]に暗黙変換します。
        /// </summary>
        public static implicit operator Cmp<T>(T x)
        {
            return new Cmp<T>(x);
        }

        /// <summary>
        /// Cmp[T]からboolに暗黙変換します。
        /// Cmp[T]が値を持っている場合はtrue、そうでない場合はfalseになります。
        /// </summary>
        public static implicit operator bool(Cmp<T> x)
        {
            return x.hasValue;
        }

        public static bool operator true(Cmp<T> x)
        {
            return x.hasValue;
        }

        public static bool operator false(Cmp<T> x)
        {
            return x.hasValue == false;
        }

        public static Cmp<T> operator <(T lhs, Cmp<T> rhs)
        {
            if (rhs.hasValue == false)
                return none;
            return lhs.CompareTo(rhs.value) < 0 ? rhs : none;
        }

        public static Cmp<T> operator <(Cmp<T> lhs, T rhs)
        {
            if (lhs.hasValue == false)
                return none;
            return lhs.value.CompareTo(rhs) < 0 ? new Cmp<T>(rhs) : none;
        }

        public static Cmp<T> operator <(Cmp<T> lhs, Cmp<T> rhs)
        {
            if (lhs.hasValue == false || rhs.hasValue == false)
                return none;
            return lhs.value.CompareTo(rhs.value) < 0 ? rhs : none;
        }

        public static Cmp<T> operator <(Cmp<T> lhs, LazyVal<T> rhs)
        {
            if (lhs.hasValue == false)
                return none;
            return lhs.value.CompareTo(rhs) < 0 ? new Cmp<T>(rhs) : none;
        }

        public static Cmp<T> operator >(T lhs, Cmp<T> rhs)
        {
            if (rhs.hasValue == false)
                return none;
            return lhs.CompareTo(rhs.value) > 0 ? rhs : none;
        }

        public static Cmp<T> operator >(Cmp<T> lhs, T rhs)
        {
            if (lhs.hasValue == false)
                return none;
            return lhs.value.CompareTo(rhs) > 0 ? new Cmp<T>(rhs) : none;
        }

        public static Cmp<T> operator >(Cmp<T> lhs, Cmp<T> rhs)
        {
            if (lhs.hasValue == false || rhs.hasValue == false)
                return none;
            return lhs.value.CompareTo(rhs.value) > 0 ? rhs : none;
        }

        public static Cmp<T> operator >(Cmp<T> lhs, LazyVal<T> rhs)
        {
            if (lhs.hasValue == false)
                return none;
            return lhs.value.CompareTo(rhs) > 0 ? new Cmp<T>(rhs) : none;
        }

        public static Cmp<T> operator <=(T lhs, Cmp<T> rhs)
        {
            if (rhs.hasValue == false)
                return none;
            return lhs.CompareTo(rhs.value) <= 0 ? rhs : none;
        }

        public static Cmp<T> operator <=(Cmp<T> lhs, T rhs)
        {
            if (lhs.hasValue == false)
                return none;
            return lhs.value.CompareTo(rhs) <= 0 ? new Cmp<T>(rhs) : none;
        }

        public static Cmp<T> operator <=(Cmp<T> lhs, Cmp<T> rhs)
        {
            if (lhs.hasValue == false || rhs.hasValue == false)
                return none;
            return lhs.value.CompareTo(rhs.value) <= 0 ? rhs : none;
        }

        public static Cmp<T> operator <=(Cmp<T> lhs, LazyVal<T> rhs)
        {
            if (lhs.hasValue == false)
                return none;
            return lhs.value.CompareTo(rhs) <= 0 ? new Cmp<T>(rhs) : none;
        }

        public static Cmp<T> operator >=(T lhs, Cmp<T> rhs)
        {
            if (rhs.hasValue == false)
                return none;
            return lhs.CompareTo(rhs.value) >= 0 ? rhs : none;
        }

        public static Cmp<T> operator >=(Cmp<T> lhs, T rhs)
        {
            if (lhs.hasValue == false)
                return none;
            return lhs.value.CompareTo(rhs) >= 0 ? new Cmp<T>(rhs) : none;
        }

        public static Cmp<T> operator >=(Cmp<T> lhs, Cmp<T> rhs)
        {
            if (lhs.hasValue == false || rhs.hasValue == false)
                return none;
            return lhs.value.CompareTo(rhs.value) >= 0 ? rhs : none;
        }

        public static Cmp<T> operator >=(Cmp<T> lhs, LazyVal<T> rhs)
        {
            if (lhs.hasValue == false)
                return none;
            return lhs.value.CompareTo(rhs) >= 0 ? new Cmp<T>(rhs) : none;
        }
    }
}
