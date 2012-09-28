
using System;

namespace LangExt
{
    /// <summary>
    /// 複数の型を持ちうる際に使用するデータ型です。
    /// </summary>
    /// <typeparam name="T1">型 1。</typeparam>
    /// <typeparam name="T2">型 2。</typeparam>
    public sealed class Variant<T1, T2> : IEquatable<Variant<T1, T2>>
    {
        readonly Option<T1> t1;
        readonly Option<T2> t2;

        /// <summary>
        /// 1 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T1 value)
        {
            t1 = new Option<T1>(value);
        }

        /// <summary>
        /// 1 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2>(T1 value)
        {
            return new Variant<T1, T2>(value);
        }

        /// <summary>
        /// 2 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T2 value)
        {
            t2 = new Option<T2>(value);
        }

        /// <summary>
        /// 2 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2>(T2 value)
        {
            return new Variant<T1, T2>(value);
        }

        /// <summary>
        /// 疑似的にパターンマッチを行います。
        /// </summary>
        /// <typeparam name="T">パターンマッチが返す値の型。</typeparam>
        /// <param name="ifT1">このオブジェクトが 1 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT2">このオブジェクトが 2 つ目の型の値を保持していた場合の処理。</param>
        /// <returns>処理が返した値。</returns>
        public T Match<T>(Func<T1, T> ifT1, Func<T2, T> ifT2)
        {
            Func<Unit, T> thrower = _ => { throw new InvalidOperationException(); };
            return t1.Match<T>(ifT1, 
                                _2 => t2.Match<T>(ifT2, thrower)                                                                );
        }

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較する Variant。</param>
        /// <returns>現在のオブジェクトが other パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public bool Equals(Variant<T1, T2> other)
        {
            return other != null && t1 == other.t1;
        }

        /// <summary>
        /// 2 つの Variant の比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つの Variant が等しい場合は true、それ以外の場合は false。</returns>
        public static bool operator ==(Variant<T1, T2> a, Variant<T1, T2> b)
        {
            if (ReferenceEquals(a, null))
                return ReferenceEquals(b, null);
            return a.Equals(b);
        }

        /// <summary>
        /// 2 つの Variant の比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つの Variant が等しい場合は false、それ以外の場合は true。</returns>
        public static bool operator !=(Variant<T1, T2> a, Variant<T1, T2> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト。</param>
        /// <returns>現在のオブジェクトが obj パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public override bool Equals(object obj)
        {
            var other = obj as Variant<T1, T2>;
            if (other == null)
                return false;
            return Equals((Variant<T1, T2>)other);
        }

        /// <summary>
        /// 現在のオブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>現在のオブジェクトのハッシュコード。</returns>
        public override int GetHashCode()
        {
            var result = 31;
            result ^= t1.GetHashCode();
            result ^= t2.GetHashCode();
            return result;
        }

        /// <summary>
        /// 現在のオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>現在のオブジェクトの文字列表現。</returns>
        public override string ToString()
        {
            return Match(
                t1 => string.Format("Variant({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Variant({0}:{1})", t2, typeof(T2).Name)
            );
        }
    }
    /// <summary>
    /// 複数の型を持ちうる際に使用するデータ型です。
    /// </summary>
    /// <typeparam name="T1">型 1。</typeparam>
    /// <typeparam name="T2">型 2。</typeparam>
    /// <typeparam name="T3">型 3。</typeparam>
    public sealed class Variant<T1, T2, T3> : IEquatable<Variant<T1, T2, T3>>
    {
        readonly Option<T1> t1;
        readonly Option<T2> t2;
        readonly Option<T3> t3;

        /// <summary>
        /// 1 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T1 value)
        {
            t1 = new Option<T1>(value);
        }

        /// <summary>
        /// 1 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3>(T1 value)
        {
            return new Variant<T1, T2, T3>(value);
        }

        /// <summary>
        /// 2 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T2 value)
        {
            t2 = new Option<T2>(value);
        }

        /// <summary>
        /// 2 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3>(T2 value)
        {
            return new Variant<T1, T2, T3>(value);
        }

        /// <summary>
        /// 3 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T3 value)
        {
            t3 = new Option<T3>(value);
        }

        /// <summary>
        /// 3 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3>(T3 value)
        {
            return new Variant<T1, T2, T3>(value);
        }

        /// <summary>
        /// 疑似的にパターンマッチを行います。
        /// </summary>
        /// <typeparam name="T">パターンマッチが返す値の型。</typeparam>
        /// <param name="ifT1">このオブジェクトが 1 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT2">このオブジェクトが 2 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT3">このオブジェクトが 3 つ目の型の値を保持していた場合の処理。</param>
        /// <returns>処理が返した値。</returns>
        public T Match<T>(Func<T1, T> ifT1, Func<T2, T> ifT2, Func<T3, T> ifT3)
        {
            Func<Unit, T> thrower = _ => { throw new InvalidOperationException(); };
            return t1.Match<T>(ifT1, 
                                _2 => t2.Match<T>(ifT2,                                                                 _3 => t3.Match<T>(ifT3, thrower)                                )                                );
        }

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較する Variant。</param>
        /// <returns>現在のオブジェクトが other パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public bool Equals(Variant<T1, T2, T3> other)
        {
            return other != null && t1 == other.t1 && t2 == other.t2;
        }

        /// <summary>
        /// 2 つの Variant の比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つの Variant が等しい場合は true、それ以外の場合は false。</returns>
        public static bool operator ==(Variant<T1, T2, T3> a, Variant<T1, T2, T3> b)
        {
            if (ReferenceEquals(a, null))
                return ReferenceEquals(b, null);
            return a.Equals(b);
        }

        /// <summary>
        /// 2 つの Variant の比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つの Variant が等しい場合は false、それ以外の場合は true。</returns>
        public static bool operator !=(Variant<T1, T2, T3> a, Variant<T1, T2, T3> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト。</param>
        /// <returns>現在のオブジェクトが obj パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public override bool Equals(object obj)
        {
            var other = obj as Variant<T1, T2, T3>;
            if (other == null)
                return false;
            return Equals((Variant<T1, T2, T3>)other);
        }

        /// <summary>
        /// 現在のオブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>現在のオブジェクトのハッシュコード。</returns>
        public override int GetHashCode()
        {
            var result = 31;
            result ^= t1.GetHashCode();
            result ^= t2.GetHashCode();
            result ^= t3.GetHashCode();
            return result;
        }

        /// <summary>
        /// 現在のオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>現在のオブジェクトの文字列表現。</returns>
        public override string ToString()
        {
            return Match(
                t1 => string.Format("Variant({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Variant({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Variant({0}:{1})", t3, typeof(T3).Name)
            );
        }
    }
    /// <summary>
    /// 複数の型を持ちうる際に使用するデータ型です。
    /// </summary>
    /// <typeparam name="T1">型 1。</typeparam>
    /// <typeparam name="T2">型 2。</typeparam>
    /// <typeparam name="T3">型 3。</typeparam>
    /// <typeparam name="T4">型 4。</typeparam>
    public sealed class Variant<T1, T2, T3, T4> : IEquatable<Variant<T1, T2, T3, T4>>
    {
        readonly Option<T1> t1;
        readonly Option<T2> t2;
        readonly Option<T3> t3;
        readonly Option<T4> t4;

        /// <summary>
        /// 1 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T1 value)
        {
            t1 = new Option<T1>(value);
        }

        /// <summary>
        /// 1 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4>(T1 value)
        {
            return new Variant<T1, T2, T3, T4>(value);
        }

        /// <summary>
        /// 2 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T2 value)
        {
            t2 = new Option<T2>(value);
        }

        /// <summary>
        /// 2 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4>(T2 value)
        {
            return new Variant<T1, T2, T3, T4>(value);
        }

        /// <summary>
        /// 3 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T3 value)
        {
            t3 = new Option<T3>(value);
        }

        /// <summary>
        /// 3 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4>(T3 value)
        {
            return new Variant<T1, T2, T3, T4>(value);
        }

        /// <summary>
        /// 4 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T4 value)
        {
            t4 = new Option<T4>(value);
        }

        /// <summary>
        /// 4 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4>(T4 value)
        {
            return new Variant<T1, T2, T3, T4>(value);
        }

        /// <summary>
        /// 疑似的にパターンマッチを行います。
        /// </summary>
        /// <typeparam name="T">パターンマッチが返す値の型。</typeparam>
        /// <param name="ifT1">このオブジェクトが 1 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT2">このオブジェクトが 2 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT3">このオブジェクトが 3 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT4">このオブジェクトが 4 つ目の型の値を保持していた場合の処理。</param>
        /// <returns>処理が返した値。</returns>
        public T Match<T>(Func<T1, T> ifT1, Func<T2, T> ifT2, Func<T3, T> ifT3, Func<T4, T> ifT4)
        {
            Func<Unit, T> thrower = _ => { throw new InvalidOperationException(); };
            return t1.Match<T>(ifT1, 
                                _2 => t2.Match<T>(ifT2,                                                                 _3 => t3.Match<T>(ifT3,                                                                 _4 => t4.Match<T>(ifT4, thrower)                                ))                                );
        }

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較する Variant。</param>
        /// <returns>現在のオブジェクトが other パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public bool Equals(Variant<T1, T2, T3, T4> other)
        {
            return other != null && t1 == other.t1 && t2 == other.t2 && t3 == other.t3;
        }

        /// <summary>
        /// 2 つの Variant の比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つの Variant が等しい場合は true、それ以外の場合は false。</returns>
        public static bool operator ==(Variant<T1, T2, T3, T4> a, Variant<T1, T2, T3, T4> b)
        {
            if (ReferenceEquals(a, null))
                return ReferenceEquals(b, null);
            return a.Equals(b);
        }

        /// <summary>
        /// 2 つの Variant の比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つの Variant が等しい場合は false、それ以外の場合は true。</returns>
        public static bool operator !=(Variant<T1, T2, T3, T4> a, Variant<T1, T2, T3, T4> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト。</param>
        /// <returns>現在のオブジェクトが obj パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public override bool Equals(object obj)
        {
            var other = obj as Variant<T1, T2, T3, T4>;
            if (other == null)
                return false;
            return Equals((Variant<T1, T2, T3, T4>)other);
        }

        /// <summary>
        /// 現在のオブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>現在のオブジェクトのハッシュコード。</returns>
        public override int GetHashCode()
        {
            var result = 31;
            result ^= t1.GetHashCode();
            result ^= t2.GetHashCode();
            result ^= t3.GetHashCode();
            result ^= t4.GetHashCode();
            return result;
        }

        /// <summary>
        /// 現在のオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>現在のオブジェクトの文字列表現。</returns>
        public override string ToString()
        {
            return Match(
                t1 => string.Format("Variant({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Variant({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Variant({0}:{1})", t3, typeof(T3).Name),
                t4 => string.Format("Variant({0}:{1})", t4, typeof(T4).Name)
            );
        }
    }
    /// <summary>
    /// 複数の型を持ちうる際に使用するデータ型です。
    /// </summary>
    /// <typeparam name="T1">型 1。</typeparam>
    /// <typeparam name="T2">型 2。</typeparam>
    /// <typeparam name="T3">型 3。</typeparam>
    /// <typeparam name="T4">型 4。</typeparam>
    /// <typeparam name="T5">型 5。</typeparam>
    public sealed class Variant<T1, T2, T3, T4, T5> : IEquatable<Variant<T1, T2, T3, T4, T5>>
    {
        readonly Option<T1> t1;
        readonly Option<T2> t2;
        readonly Option<T3> t3;
        readonly Option<T4> t4;
        readonly Option<T5> t5;

        /// <summary>
        /// 1 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T1 value)
        {
            t1 = new Option<T1>(value);
        }

        /// <summary>
        /// 1 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5>(T1 value)
        {
            return new Variant<T1, T2, T3, T4, T5>(value);
        }

        /// <summary>
        /// 2 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T2 value)
        {
            t2 = new Option<T2>(value);
        }

        /// <summary>
        /// 2 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5>(T2 value)
        {
            return new Variant<T1, T2, T3, T4, T5>(value);
        }

        /// <summary>
        /// 3 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T3 value)
        {
            t3 = new Option<T3>(value);
        }

        /// <summary>
        /// 3 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5>(T3 value)
        {
            return new Variant<T1, T2, T3, T4, T5>(value);
        }

        /// <summary>
        /// 4 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T4 value)
        {
            t4 = new Option<T4>(value);
        }

        /// <summary>
        /// 4 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5>(T4 value)
        {
            return new Variant<T1, T2, T3, T4, T5>(value);
        }

        /// <summary>
        /// 5 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T5 value)
        {
            t5 = new Option<T5>(value);
        }

        /// <summary>
        /// 5 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5>(T5 value)
        {
            return new Variant<T1, T2, T3, T4, T5>(value);
        }

        /// <summary>
        /// 疑似的にパターンマッチを行います。
        /// </summary>
        /// <typeparam name="T">パターンマッチが返す値の型。</typeparam>
        /// <param name="ifT1">このオブジェクトが 1 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT2">このオブジェクトが 2 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT3">このオブジェクトが 3 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT4">このオブジェクトが 4 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT5">このオブジェクトが 5 つ目の型の値を保持していた場合の処理。</param>
        /// <returns>処理が返した値。</returns>
        public T Match<T>(Func<T1, T> ifT1, Func<T2, T> ifT2, Func<T3, T> ifT3, Func<T4, T> ifT4, Func<T5, T> ifT5)
        {
            Func<Unit, T> thrower = _ => { throw new InvalidOperationException(); };
            return t1.Match<T>(ifT1, 
                                _2 => t2.Match<T>(ifT2,                                                                 _3 => t3.Match<T>(ifT3,                                                                 _4 => t4.Match<T>(ifT4,                                                                 _5 => t5.Match<T>(ifT5, thrower)                                )))                                );
        }

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較する Variant。</param>
        /// <returns>現在のオブジェクトが other パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public bool Equals(Variant<T1, T2, T3, T4, T5> other)
        {
            return other != null && t1 == other.t1 && t2 == other.t2 && t3 == other.t3 && t4 == other.t4;
        }

        /// <summary>
        /// 2 つの Variant の比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つの Variant が等しい場合は true、それ以外の場合は false。</returns>
        public static bool operator ==(Variant<T1, T2, T3, T4, T5> a, Variant<T1, T2, T3, T4, T5> b)
        {
            if (ReferenceEquals(a, null))
                return ReferenceEquals(b, null);
            return a.Equals(b);
        }

        /// <summary>
        /// 2 つの Variant の比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つの Variant が等しい場合は false、それ以外の場合は true。</returns>
        public static bool operator !=(Variant<T1, T2, T3, T4, T5> a, Variant<T1, T2, T3, T4, T5> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト。</param>
        /// <returns>現在のオブジェクトが obj パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public override bool Equals(object obj)
        {
            var other = obj as Variant<T1, T2, T3, T4, T5>;
            if (other == null)
                return false;
            return Equals((Variant<T1, T2, T3, T4, T5>)other);
        }

        /// <summary>
        /// 現在のオブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>現在のオブジェクトのハッシュコード。</returns>
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

        /// <summary>
        /// 現在のオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>現在のオブジェクトの文字列表現。</returns>
        public override string ToString()
        {
            return Match(
                t1 => string.Format("Variant({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Variant({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Variant({0}:{1})", t3, typeof(T3).Name),
                t4 => string.Format("Variant({0}:{1})", t4, typeof(T4).Name),
                t5 => string.Format("Variant({0}:{1})", t5, typeof(T5).Name)
            );
        }
    }
    /// <summary>
    /// 複数の型を持ちうる際に使用するデータ型です。
    /// </summary>
    /// <typeparam name="T1">型 1。</typeparam>
    /// <typeparam name="T2">型 2。</typeparam>
    /// <typeparam name="T3">型 3。</typeparam>
    /// <typeparam name="T4">型 4。</typeparam>
    /// <typeparam name="T5">型 5。</typeparam>
    /// <typeparam name="T6">型 6。</typeparam>
    public sealed class Variant<T1, T2, T3, T4, T5, T6> : IEquatable<Variant<T1, T2, T3, T4, T5, T6>>
    {
        readonly Option<T1> t1;
        readonly Option<T2> t2;
        readonly Option<T3> t3;
        readonly Option<T4> t4;
        readonly Option<T5> t5;
        readonly Option<T6> t6;

        /// <summary>
        /// 1 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T1 value)
        {
            t1 = new Option<T1>(value);
        }

        /// <summary>
        /// 1 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6>(T1 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// 2 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T2 value)
        {
            t2 = new Option<T2>(value);
        }

        /// <summary>
        /// 2 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6>(T2 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// 3 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T3 value)
        {
            t3 = new Option<T3>(value);
        }

        /// <summary>
        /// 3 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6>(T3 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// 4 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T4 value)
        {
            t4 = new Option<T4>(value);
        }

        /// <summary>
        /// 4 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6>(T4 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// 5 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T5 value)
        {
            t5 = new Option<T5>(value);
        }

        /// <summary>
        /// 5 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6>(T5 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// 6 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T6 value)
        {
            t6 = new Option<T6>(value);
        }

        /// <summary>
        /// 6 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6>(T6 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// 疑似的にパターンマッチを行います。
        /// </summary>
        /// <typeparam name="T">パターンマッチが返す値の型。</typeparam>
        /// <param name="ifT1">このオブジェクトが 1 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT2">このオブジェクトが 2 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT3">このオブジェクトが 3 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT4">このオブジェクトが 4 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT5">このオブジェクトが 5 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT6">このオブジェクトが 6 つ目の型の値を保持していた場合の処理。</param>
        /// <returns>処理が返した値。</returns>
        public T Match<T>(Func<T1, T> ifT1, Func<T2, T> ifT2, Func<T3, T> ifT3, Func<T4, T> ifT4, Func<T5, T> ifT5, Func<T6, T> ifT6)
        {
            Func<Unit, T> thrower = _ => { throw new InvalidOperationException(); };
            return t1.Match<T>(ifT1, 
                                _2 => t2.Match<T>(ifT2,                                                                 _3 => t3.Match<T>(ifT3,                                                                 _4 => t4.Match<T>(ifT4,                                                                 _5 => t5.Match<T>(ifT5,                                                                 _6 => t6.Match<T>(ifT6, thrower)                                ))))                                );
        }

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較する Variant。</param>
        /// <returns>現在のオブジェクトが other パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public bool Equals(Variant<T1, T2, T3, T4, T5, T6> other)
        {
            return other != null && t1 == other.t1 && t2 == other.t2 && t3 == other.t3 && t4 == other.t4 && t5 == other.t5;
        }

        /// <summary>
        /// 2 つの Variant の比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つの Variant が等しい場合は true、それ以外の場合は false。</returns>
        public static bool operator ==(Variant<T1, T2, T3, T4, T5, T6> a, Variant<T1, T2, T3, T4, T5, T6> b)
        {
            if (ReferenceEquals(a, null))
                return ReferenceEquals(b, null);
            return a.Equals(b);
        }

        /// <summary>
        /// 2 つの Variant の比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つの Variant が等しい場合は false、それ以外の場合は true。</returns>
        public static bool operator !=(Variant<T1, T2, T3, T4, T5, T6> a, Variant<T1, T2, T3, T4, T5, T6> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト。</param>
        /// <returns>現在のオブジェクトが obj パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public override bool Equals(object obj)
        {
            var other = obj as Variant<T1, T2, T3, T4, T5, T6>;
            if (other == null)
                return false;
            return Equals((Variant<T1, T2, T3, T4, T5, T6>)other);
        }

        /// <summary>
        /// 現在のオブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>現在のオブジェクトのハッシュコード。</returns>
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

        /// <summary>
        /// 現在のオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>現在のオブジェクトの文字列表現。</returns>
        public override string ToString()
        {
            return Match(
                t1 => string.Format("Variant({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Variant({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Variant({0}:{1})", t3, typeof(T3).Name),
                t4 => string.Format("Variant({0}:{1})", t4, typeof(T4).Name),
                t5 => string.Format("Variant({0}:{1})", t5, typeof(T5).Name),
                t6 => string.Format("Variant({0}:{1})", t6, typeof(T6).Name)
            );
        }
    }
    /// <summary>
    /// 複数の型を持ちうる際に使用するデータ型です。
    /// </summary>
    /// <typeparam name="T1">型 1。</typeparam>
    /// <typeparam name="T2">型 2。</typeparam>
    /// <typeparam name="T3">型 3。</typeparam>
    /// <typeparam name="T4">型 4。</typeparam>
    /// <typeparam name="T5">型 5。</typeparam>
    /// <typeparam name="T6">型 6。</typeparam>
    /// <typeparam name="T7">型 7。</typeparam>
    public sealed class Variant<T1, T2, T3, T4, T5, T6, T7> : IEquatable<Variant<T1, T2, T3, T4, T5, T6, T7>>
    {
        readonly Option<T1> t1;
        readonly Option<T2> t2;
        readonly Option<T3> t3;
        readonly Option<T4> t4;
        readonly Option<T5> t5;
        readonly Option<T6> t6;
        readonly Option<T7> t7;

        /// <summary>
        /// 1 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T1 value)
        {
            t1 = new Option<T1>(value);
        }

        /// <summary>
        /// 1 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7>(T1 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// 2 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T2 value)
        {
            t2 = new Option<T2>(value);
        }

        /// <summary>
        /// 2 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7>(T2 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// 3 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T3 value)
        {
            t3 = new Option<T3>(value);
        }

        /// <summary>
        /// 3 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7>(T3 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// 4 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T4 value)
        {
            t4 = new Option<T4>(value);
        }

        /// <summary>
        /// 4 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7>(T4 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// 5 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T5 value)
        {
            t5 = new Option<T5>(value);
        }

        /// <summary>
        /// 5 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7>(T5 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// 6 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T6 value)
        {
            t6 = new Option<T6>(value);
        }

        /// <summary>
        /// 6 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7>(T6 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// 7 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T7 value)
        {
            t7 = new Option<T7>(value);
        }

        /// <summary>
        /// 7 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7>(T7 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// 疑似的にパターンマッチを行います。
        /// </summary>
        /// <typeparam name="T">パターンマッチが返す値の型。</typeparam>
        /// <param name="ifT1">このオブジェクトが 1 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT2">このオブジェクトが 2 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT3">このオブジェクトが 3 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT4">このオブジェクトが 4 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT5">このオブジェクトが 5 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT6">このオブジェクトが 6 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT7">このオブジェクトが 7 つ目の型の値を保持していた場合の処理。</param>
        /// <returns>処理が返した値。</returns>
        public T Match<T>(Func<T1, T> ifT1, Func<T2, T> ifT2, Func<T3, T> ifT3, Func<T4, T> ifT4, Func<T5, T> ifT5, Func<T6, T> ifT6, Func<T7, T> ifT7)
        {
            Func<Unit, T> thrower = _ => { throw new InvalidOperationException(); };
            return t1.Match<T>(ifT1, 
                                _2 => t2.Match<T>(ifT2,                                                                 _3 => t3.Match<T>(ifT3,                                                                 _4 => t4.Match<T>(ifT4,                                                                 _5 => t5.Match<T>(ifT5,                                                                 _6 => t6.Match<T>(ifT6,                                                                 _7 => t7.Match<T>(ifT7, thrower)                                )))))                                );
        }

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較する Variant。</param>
        /// <returns>現在のオブジェクトが other パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public bool Equals(Variant<T1, T2, T3, T4, T5, T6, T7> other)
        {
            return other != null && t1 == other.t1 && t2 == other.t2 && t3 == other.t3 && t4 == other.t4 && t5 == other.t5 && t6 == other.t6;
        }

        /// <summary>
        /// 2 つの Variant の比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つの Variant が等しい場合は true、それ以外の場合は false。</returns>
        public static bool operator ==(Variant<T1, T2, T3, T4, T5, T6, T7> a, Variant<T1, T2, T3, T4, T5, T6, T7> b)
        {
            if (ReferenceEquals(a, null))
                return ReferenceEquals(b, null);
            return a.Equals(b);
        }

        /// <summary>
        /// 2 つの Variant の比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つの Variant が等しい場合は false、それ以外の場合は true。</returns>
        public static bool operator !=(Variant<T1, T2, T3, T4, T5, T6, T7> a, Variant<T1, T2, T3, T4, T5, T6, T7> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト。</param>
        /// <returns>現在のオブジェクトが obj パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public override bool Equals(object obj)
        {
            var other = obj as Variant<T1, T2, T3, T4, T5, T6, T7>;
            if (other == null)
                return false;
            return Equals((Variant<T1, T2, T3, T4, T5, T6, T7>)other);
        }

        /// <summary>
        /// 現在のオブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>現在のオブジェクトのハッシュコード。</returns>
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

        /// <summary>
        /// 現在のオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>現在のオブジェクトの文字列表現。</returns>
        public override string ToString()
        {
            return Match(
                t1 => string.Format("Variant({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Variant({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Variant({0}:{1})", t3, typeof(T3).Name),
                t4 => string.Format("Variant({0}:{1})", t4, typeof(T4).Name),
                t5 => string.Format("Variant({0}:{1})", t5, typeof(T5).Name),
                t6 => string.Format("Variant({0}:{1})", t6, typeof(T6).Name),
                t7 => string.Format("Variant({0}:{1})", t7, typeof(T7).Name)
            );
        }
    }
    /// <summary>
    /// 複数の型を持ちうる際に使用するデータ型です。
    /// </summary>
    /// <typeparam name="T1">型 1。</typeparam>
    /// <typeparam name="T2">型 2。</typeparam>
    /// <typeparam name="T3">型 3。</typeparam>
    /// <typeparam name="T4">型 4。</typeparam>
    /// <typeparam name="T5">型 5。</typeparam>
    /// <typeparam name="T6">型 6。</typeparam>
    /// <typeparam name="T7">型 7。</typeparam>
    /// <typeparam name="T8">型 8。</typeparam>
    public sealed class Variant<T1, T2, T3, T4, T5, T6, T7, T8> : IEquatable<Variant<T1, T2, T3, T4, T5, T6, T7, T8>>
    {
        readonly Option<T1> t1;
        readonly Option<T2> t2;
        readonly Option<T3> t3;
        readonly Option<T4> t4;
        readonly Option<T5> t5;
        readonly Option<T6> t6;
        readonly Option<T7> t7;
        readonly Option<T8> t8;

        /// <summary>
        /// 1 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T1 value)
        {
            t1 = new Option<T1>(value);
        }

        /// <summary>
        /// 1 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8>(T1 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// 2 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T2 value)
        {
            t2 = new Option<T2>(value);
        }

        /// <summary>
        /// 2 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8>(T2 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// 3 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T3 value)
        {
            t3 = new Option<T3>(value);
        }

        /// <summary>
        /// 3 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8>(T3 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// 4 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T4 value)
        {
            t4 = new Option<T4>(value);
        }

        /// <summary>
        /// 4 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8>(T4 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// 5 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T5 value)
        {
            t5 = new Option<T5>(value);
        }

        /// <summary>
        /// 5 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8>(T5 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// 6 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T6 value)
        {
            t6 = new Option<T6>(value);
        }

        /// <summary>
        /// 6 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8>(T6 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// 7 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T7 value)
        {
            t7 = new Option<T7>(value);
        }

        /// <summary>
        /// 7 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8>(T7 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// 8 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T8 value)
        {
            t8 = new Option<T8>(value);
        }

        /// <summary>
        /// 8 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8>(T8 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// 疑似的にパターンマッチを行います。
        /// </summary>
        /// <typeparam name="T">パターンマッチが返す値の型。</typeparam>
        /// <param name="ifT1">このオブジェクトが 1 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT2">このオブジェクトが 2 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT3">このオブジェクトが 3 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT4">このオブジェクトが 4 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT5">このオブジェクトが 5 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT6">このオブジェクトが 6 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT7">このオブジェクトが 7 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT8">このオブジェクトが 8 つ目の型の値を保持していた場合の処理。</param>
        /// <returns>処理が返した値。</returns>
        public T Match<T>(Func<T1, T> ifT1, Func<T2, T> ifT2, Func<T3, T> ifT3, Func<T4, T> ifT4, Func<T5, T> ifT5, Func<T6, T> ifT6, Func<T7, T> ifT7, Func<T8, T> ifT8)
        {
            Func<Unit, T> thrower = _ => { throw new InvalidOperationException(); };
            return t1.Match<T>(ifT1, 
                                _2 => t2.Match<T>(ifT2,                                                                 _3 => t3.Match<T>(ifT3,                                                                 _4 => t4.Match<T>(ifT4,                                                                 _5 => t5.Match<T>(ifT5,                                                                 _6 => t6.Match<T>(ifT6,                                                                 _7 => t7.Match<T>(ifT7,                                                                 _8 => t8.Match<T>(ifT8, thrower)                                ))))))                                );
        }

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較する Variant。</param>
        /// <returns>現在のオブジェクトが other パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public bool Equals(Variant<T1, T2, T3, T4, T5, T6, T7, T8> other)
        {
            return other != null && t1 == other.t1 && t2 == other.t2 && t3 == other.t3 && t4 == other.t4 && t5 == other.t5 && t6 == other.t6 && t7 == other.t7;
        }

        /// <summary>
        /// 2 つの Variant の比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つの Variant が等しい場合は true、それ以外の場合は false。</returns>
        public static bool operator ==(Variant<T1, T2, T3, T4, T5, T6, T7, T8> a, Variant<T1, T2, T3, T4, T5, T6, T7, T8> b)
        {
            if (ReferenceEquals(a, null))
                return ReferenceEquals(b, null);
            return a.Equals(b);
        }

        /// <summary>
        /// 2 つの Variant の比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つの Variant が等しい場合は false、それ以外の場合は true。</returns>
        public static bool operator !=(Variant<T1, T2, T3, T4, T5, T6, T7, T8> a, Variant<T1, T2, T3, T4, T5, T6, T7, T8> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト。</param>
        /// <returns>現在のオブジェクトが obj パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public override bool Equals(object obj)
        {
            var other = obj as Variant<T1, T2, T3, T4, T5, T6, T7, T8>;
            if (other == null)
                return false;
            return Equals((Variant<T1, T2, T3, T4, T5, T6, T7, T8>)other);
        }

        /// <summary>
        /// 現在のオブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>現在のオブジェクトのハッシュコード。</returns>
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

        /// <summary>
        /// 現在のオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>現在のオブジェクトの文字列表現。</returns>
        public override string ToString()
        {
            return Match(
                t1 => string.Format("Variant({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Variant({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Variant({0}:{1})", t3, typeof(T3).Name),
                t4 => string.Format("Variant({0}:{1})", t4, typeof(T4).Name),
                t5 => string.Format("Variant({0}:{1})", t5, typeof(T5).Name),
                t6 => string.Format("Variant({0}:{1})", t6, typeof(T6).Name),
                t7 => string.Format("Variant({0}:{1})", t7, typeof(T7).Name),
                t8 => string.Format("Variant({0}:{1})", t8, typeof(T8).Name)
            );
        }
    }
    /// <summary>
    /// 複数の型を持ちうる際に使用するデータ型です。
    /// </summary>
    /// <typeparam name="T1">型 1。</typeparam>
    /// <typeparam name="T2">型 2。</typeparam>
    /// <typeparam name="T3">型 3。</typeparam>
    /// <typeparam name="T4">型 4。</typeparam>
    /// <typeparam name="T5">型 5。</typeparam>
    /// <typeparam name="T6">型 6。</typeparam>
    /// <typeparam name="T7">型 7。</typeparam>
    /// <typeparam name="T8">型 8。</typeparam>
    /// <typeparam name="T9">型 9。</typeparam>
    public sealed class Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9> : IEquatable<Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>>
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

        /// <summary>
        /// 1 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T1 value)
        {
            t1 = new Option<T1>(value);
        }

        /// <summary>
        /// 1 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// 2 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T2 value)
        {
            t2 = new Option<T2>(value);
        }

        /// <summary>
        /// 2 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T2 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// 3 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T3 value)
        {
            t3 = new Option<T3>(value);
        }

        /// <summary>
        /// 3 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T3 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// 4 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T4 value)
        {
            t4 = new Option<T4>(value);
        }

        /// <summary>
        /// 4 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T4 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// 5 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T5 value)
        {
            t5 = new Option<T5>(value);
        }

        /// <summary>
        /// 5 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T5 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// 6 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T6 value)
        {
            t6 = new Option<T6>(value);
        }

        /// <summary>
        /// 6 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T6 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// 7 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T7 value)
        {
            t7 = new Option<T7>(value);
        }

        /// <summary>
        /// 7 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T7 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// 8 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T8 value)
        {
            t8 = new Option<T8>(value);
        }

        /// <summary>
        /// 8 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T8 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// 9 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T9 value)
        {
            t9 = new Option<T9>(value);
        }

        /// <summary>
        /// 9 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T9 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// 疑似的にパターンマッチを行います。
        /// </summary>
        /// <typeparam name="T">パターンマッチが返す値の型。</typeparam>
        /// <param name="ifT1">このオブジェクトが 1 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT2">このオブジェクトが 2 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT3">このオブジェクトが 3 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT4">このオブジェクトが 4 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT5">このオブジェクトが 5 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT6">このオブジェクトが 6 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT7">このオブジェクトが 7 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT8">このオブジェクトが 8 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT9">このオブジェクトが 9 つ目の型の値を保持していた場合の処理。</param>
        /// <returns>処理が返した値。</returns>
        public T Match<T>(Func<T1, T> ifT1, Func<T2, T> ifT2, Func<T3, T> ifT3, Func<T4, T> ifT4, Func<T5, T> ifT5, Func<T6, T> ifT6, Func<T7, T> ifT7, Func<T8, T> ifT8, Func<T9, T> ifT9)
        {
            Func<Unit, T> thrower = _ => { throw new InvalidOperationException(); };
            return t1.Match<T>(ifT1, 
                                _2 => t2.Match<T>(ifT2,                                                                 _3 => t3.Match<T>(ifT3,                                                                 _4 => t4.Match<T>(ifT4,                                                                 _5 => t5.Match<T>(ifT5,                                                                 _6 => t6.Match<T>(ifT6,                                                                 _7 => t7.Match<T>(ifT7,                                                                 _8 => t8.Match<T>(ifT8,                                                                 _9 => t9.Match<T>(ifT9, thrower)                                )))))))                                );
        }

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較する Variant。</param>
        /// <returns>現在のオブジェクトが other パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public bool Equals(Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9> other)
        {
            return other != null && t1 == other.t1 && t2 == other.t2 && t3 == other.t3 && t4 == other.t4 && t5 == other.t5 && t6 == other.t6 && t7 == other.t7 && t8 == other.t8;
        }

        /// <summary>
        /// 2 つの Variant の比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つの Variant が等しい場合は true、それ以外の場合は false。</returns>
        public static bool operator ==(Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9> a, Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9> b)
        {
            if (ReferenceEquals(a, null))
                return ReferenceEquals(b, null);
            return a.Equals(b);
        }

        /// <summary>
        /// 2 つの Variant の比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つの Variant が等しい場合は false、それ以外の場合は true。</returns>
        public static bool operator !=(Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9> a, Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト。</param>
        /// <returns>現在のオブジェクトが obj パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public override bool Equals(object obj)
        {
            var other = obj as Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>;
            if (other == null)
                return false;
            return Equals((Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9>)other);
        }

        /// <summary>
        /// 現在のオブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>現在のオブジェクトのハッシュコード。</returns>
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

        /// <summary>
        /// 現在のオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>現在のオブジェクトの文字列表現。</returns>
        public override string ToString()
        {
            return Match(
                t1 => string.Format("Variant({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Variant({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Variant({0}:{1})", t3, typeof(T3).Name),
                t4 => string.Format("Variant({0}:{1})", t4, typeof(T4).Name),
                t5 => string.Format("Variant({0}:{1})", t5, typeof(T5).Name),
                t6 => string.Format("Variant({0}:{1})", t6, typeof(T6).Name),
                t7 => string.Format("Variant({0}:{1})", t7, typeof(T7).Name),
                t8 => string.Format("Variant({0}:{1})", t8, typeof(T8).Name),
                t9 => string.Format("Variant({0}:{1})", t9, typeof(T9).Name)
            );
        }
    }
    /// <summary>
    /// 複数の型を持ちうる際に使用するデータ型です。
    /// </summary>
    /// <typeparam name="T1">型 1。</typeparam>
    /// <typeparam name="T2">型 2。</typeparam>
    /// <typeparam name="T3">型 3。</typeparam>
    /// <typeparam name="T4">型 4。</typeparam>
    /// <typeparam name="T5">型 5。</typeparam>
    /// <typeparam name="T6">型 6。</typeparam>
    /// <typeparam name="T7">型 7。</typeparam>
    /// <typeparam name="T8">型 8。</typeparam>
    /// <typeparam name="T9">型 9。</typeparam>
    /// <typeparam name="T10">型 10。</typeparam>
    public sealed class Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : IEquatable<Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>
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

        /// <summary>
        /// 1 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T1 value)
        {
            t1 = new Option<T1>(value);
        }

        /// <summary>
        /// 1 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// 2 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T2 value)
        {
            t2 = new Option<T2>(value);
        }

        /// <summary>
        /// 2 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T2 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// 3 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T3 value)
        {
            t3 = new Option<T3>(value);
        }

        /// <summary>
        /// 3 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T3 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// 4 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T4 value)
        {
            t4 = new Option<T4>(value);
        }

        /// <summary>
        /// 4 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T4 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// 5 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T5 value)
        {
            t5 = new Option<T5>(value);
        }

        /// <summary>
        /// 5 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T5 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// 6 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T6 value)
        {
            t6 = new Option<T6>(value);
        }

        /// <summary>
        /// 6 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T6 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// 7 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T7 value)
        {
            t7 = new Option<T7>(value);
        }

        /// <summary>
        /// 7 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T7 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// 8 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T8 value)
        {
            t8 = new Option<T8>(value);
        }

        /// <summary>
        /// 8 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T8 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// 9 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T9 value)
        {
            t9 = new Option<T9>(value);
        }

        /// <summary>
        /// 9 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T9 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// 10 つ目の型の値を持つオブジェクトを構築します。
        /// </summary>
        /// <param name="value">値。</param>
        public Variant(T10 value)
        {
            t10 = new Option<T10>(value);
        }

        /// <summary>
        /// 10 つ目の型の値からその値を保持する Variant に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Variant。</returns>
        public static implicit operator Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T10 value)
        {
            return new Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// 疑似的にパターンマッチを行います。
        /// </summary>
        /// <typeparam name="T">パターンマッチが返す値の型。</typeparam>
        /// <param name="ifT1">このオブジェクトが 1 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT2">このオブジェクトが 2 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT3">このオブジェクトが 3 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT4">このオブジェクトが 4 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT5">このオブジェクトが 5 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT6">このオブジェクトが 6 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT7">このオブジェクトが 7 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT8">このオブジェクトが 8 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT9">このオブジェクトが 9 つ目の型の値を保持していた場合の処理。</param>
        /// <param name="ifT10">このオブジェクトが 10 つ目の型の値を保持していた場合の処理。</param>
        /// <returns>処理が返した値。</returns>
        public T Match<T>(Func<T1, T> ifT1, Func<T2, T> ifT2, Func<T3, T> ifT3, Func<T4, T> ifT4, Func<T5, T> ifT5, Func<T6, T> ifT6, Func<T7, T> ifT7, Func<T8, T> ifT8, Func<T9, T> ifT9, Func<T10, T> ifT10)
        {
            Func<Unit, T> thrower = _ => { throw new InvalidOperationException(); };
            return t1.Match<T>(ifT1, 
                                _2 => t2.Match<T>(ifT2,                                                                 _3 => t3.Match<T>(ifT3,                                                                 _4 => t4.Match<T>(ifT4,                                                                 _5 => t5.Match<T>(ifT5,                                                                 _6 => t6.Match<T>(ifT6,                                                                 _7 => t7.Match<T>(ifT7,                                                                 _8 => t8.Match<T>(ifT8,                                                                 _9 => t9.Match<T>(ifT9,                                                                 _10 => t10.Match<T>(ifT10, thrower)                                ))))))))                                );
        }

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較する Variant。</param>
        /// <returns>現在のオブジェクトが other パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public bool Equals(Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> other)
        {
            return other != null && t1 == other.t1 && t2 == other.t2 && t3 == other.t3 && t4 == other.t4 && t5 == other.t5 && t6 == other.t6 && t7 == other.t7 && t8 == other.t8 && t9 == other.t9;
        }

        /// <summary>
        /// 2 つの Variant の比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つの Variant が等しい場合は true、それ以外の場合は false。</returns>
        public static bool operator ==(Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> a, Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> b)
        {
            if (ReferenceEquals(a, null))
                return ReferenceEquals(b, null);
            return a.Equals(b);
        }

        /// <summary>
        /// 2 つの Variant の比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つの Variant が等しい場合は false、それ以外の場合は true。</returns>
        public static bool operator !=(Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> a, Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト。</param>
        /// <returns>現在のオブジェクトが obj パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public override bool Equals(object obj)
        {
            var other = obj as Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>;
            if (other == null)
                return false;
            return Equals((Variant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>)other);
        }

        /// <summary>
        /// 現在のオブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>現在のオブジェクトのハッシュコード。</returns>
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

        /// <summary>
        /// 現在のオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>現在のオブジェクトの文字列表現。</returns>
        public override string ToString()
        {
            return Match(
                t1 => string.Format("Variant({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Variant({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Variant({0}:{1})", t3, typeof(T3).Name),
                t4 => string.Format("Variant({0}:{1})", t4, typeof(T4).Name),
                t5 => string.Format("Variant({0}:{1})", t5, typeof(T5).Name),
                t6 => string.Format("Variant({0}:{1})", t6, typeof(T6).Name),
                t7 => string.Format("Variant({0}:{1})", t7, typeof(T7).Name),
                t8 => string.Format("Variant({0}:{1})", t8, typeof(T8).Name),
                t9 => string.Format("Variant({0}:{1})", t9, typeof(T9).Name),
                t10 => string.Format("Variant({0}:{1})", t10, typeof(T10).Name)
            );
        }
    }
}