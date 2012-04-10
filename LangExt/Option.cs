using System;
using System.Collections.Generic;

namespace LangExt
{
    /// <summary>
    /// Optionのユーティリティ関数を提供します。
    /// </summary>
    public static class Option
    {
        /// <summary>
        /// 値を指定して Some を生成します。
        /// </summary>
        /// <typeparam name="T">Some に保持する値</typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Option<T> Some<T>(T value)
        {
            return new Option<T>(value);
        }
    }

    /// <summary>
    /// nullよりも安全に「値がないこと」を表すことのできるデータ型です。
    /// </summary>
    /// <remarks>
    /// この型は値のある「Some」と、値のない「None」を表すことができ、
    /// デフォルトでは None となります。
    /// また、任意の値からの暗黙変換を定義しており、この場合その値を保持する Some となります。
    /// </remarks>
    /// <typeparam name="T">値の型。</typeparam>
    public struct Option<T> : IEquatable<Option<T>>
    {
        readonly bool hasValue;
        readonly T value;

        /// <summary>
        /// 値を指定して明示的に Some を生成します。
        /// </summary>
        /// <param name="value">Some に保持する値。</param>
        public Option(T value)
        {
            this.hasValue = true;
            this.value = value;
        }

        public Option<T2> Bind<T2>(Func<T, Option<T2>> f)
        {
            return Match(f, _ => Option<T2>.None);
        }

        /// <summary>
        /// 任意の値からその値を保持する Some に変換します。
        /// </summary>
        /// <param name="value">値。</param>
        /// <returns>引数で指定された値を保持する Some。</returns>
        public static implicit operator Option<T>(T value)
        {
            return new Option<T>(value);
        }

        public static explicit operator T(Option<T> value)
        {
            return value.Match(
                some => some,
                _ => { throw new InvalidCastException(); });
        }

        /// <summary>
        /// None を明示的に取得します。
        /// </summary>
        public static Option<T> None { get { return default(Option<T>); } }

        /// <summary>
        /// 保持された値を安全に取り出します。
        /// </summary>
        /// <remarks>
        /// このオブジェクトが Some の場合、保持している値を、
        /// None の場合、引数で指定した値を返します。
        /// </remarks>
        /// <param name="ifNone">None だった場合に返す値。</param>
        /// <returns>Some の場合、保持された値。None の場合、引数で指定された値。</returns>
        public T Or(T ifNone)
        {
            if (hasValue)
                return value;
            else
                return ifNone;
        }

        /// <summary>
        /// 擬似的にパターンマッチを行います。
        /// 値がある場合とない場合の両方で何らかの処理を行う必要がある際に使用します。
        /// </summary>
        /// <typeparam name="S">パターンマッチが返す値の型。</typeparam>
        /// <param name="ifSome">Some の場合の処理。</param>
        /// <param name="ifNone">None の場合の処理。</param>
        /// <returns>処理が返した値。</returns>
        public S Match<S>(Func<T, S> ifSome, Func<Unit, S> ifNone)
        {
            if (hasValue)
                return ifSome(value);
            else
                return ifNone(Unit._);
        }

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較する Option。</param>
        /// <returns>現在のオブジェクトが other パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public bool Equals(Option<T> other)
        {
            return hasValue == other.hasValue && Equals(value, other.value);
        }

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト。</param>
        /// <returns>現在のオブジェクトが obj パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public override bool Equals(object obj)
        {
            if ((obj is Option<T>) == false)
                return false;
            return Equals((Option<T>)obj);
        }

        /// <summary>
        /// 2 つの Option の比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Option。</param>
        /// <param name="b">2 つ目の Option。</param>
        /// <returns>2 つの Option が等しい場合は true、それ以外の場合は false。</returns>
        public static bool operator ==(Option<T> a, Option<T> b)
        {
            return a.Equals(b);
        }

        /// <summary>
        /// 2 つの Option の比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Option。</param>
        /// <param name="b">2 つ目の Option。</param>
        /// <returns>2 つの Option が等しい場合は false、それ以外の場合は true。</returns>
        public static bool operator !=(Option<T> a, Option<T> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Option が値を持つかどうかを判定します。
        /// </summary>
        /// <param name="x">判定の対象。</param>
        /// <returns>値を持つ場合は true、それ以外の場合は false。</returns>
        public static bool operator true(Option<T> x)
        {
            return x.hasValue;
        }

        /// <summary>
        /// Option が値を持たないかどうかを判定します。
        /// </summary>
        /// <param name="x">判定の対象。</param>
        /// <returns>値を持つ場合は false、それ以外の場合は true。</returns>
        public static bool operator false(Option<T> x)
        {
            return !x.hasValue;
        }

        /// <summary>
        /// 左辺の Option が値を持つ場合は左辺を、そうでない場合は右辺を返します。
        /// 通常、直接使用せず、短絡演算子として使用します。
        /// </summary>
        /// <param name="a">1 つ目の Option。</param>
        /// <param name="b">2 つ目の Option。</param>
        /// <returns>左辺の Option が値を持つ場合は左辺、それ以外の場合は右辺。</returns>
        public static Option<T> operator |(Option<T> a, Option<T> b)
        {
            if (a.hasValue)
                return a;
            return b;
        }

        /// <summary>
        /// 左辺の Option が値を持たない場合は None を、そうでない場合は右辺を返します。
        /// 通常、直接使用せず、短絡演算子として使用します。
        /// </summary>
        /// <param name="a">1 つ目の Option。</param>
        /// <param name="b">2 つ目の Option。</param>
        /// <returns>左辺の Option が値を持たない場合は None、それ以外の場合は右辺。</returns>
        public static Option<T> operator &(Option<T> a, Option<T> b)
        {
            if (a.hasValue == false)
                return None;
            return b;
        }

        /// <summary>
        /// 現在のオブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>現在のオブジェクトのハッシュコード。</returns>
        public override int GetHashCode()
        {
            var result = 31;
            result ^= hasValue.GetHashCode();
            result ^= value == null ? 0 : value.GetHashCode();
            return result;
        }

        /// <summary>
        /// 現在のオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>現在のオブジェクトの文字列表現。</returns>
        public override string ToString()
        {
            if (hasValue)
                return string.Format("Some({0})", value);
            else
                return "None";
        }
    }
}
