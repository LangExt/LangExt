
using System;

namespace LangExt
{
    /// <summary>
    /// N 要素のタプルを生成するためのクラスです。
    /// 10 要素までのタプルに対応しています。
    /// </summary>
    public static partial class Tpl
    {
        /// <summary>
        /// 2 要素のタプルを生成します。
        /// </summary>
        public static _<T1, T2> Of<T1, T2>(T1 t1, T2 t2)
        {
            return new _<T1, T2>(t1, t2);
        }

        /// <summary>
        /// 3 要素のタプルを生成します。
        /// </summary>
        public static _<T1, T2, T3> Of<T1, T2, T3>(T1 t1, T2 t2, T3 t3)
        {
            return new _<T1, T2, T3>(t1, t2, t3);
        }

        /// <summary>
        /// 4 要素のタプルを生成します。
        /// </summary>
        public static _<T1, T2, T3, T4> Of<T1, T2, T3, T4>(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            return new _<T1, T2, T3, T4>(t1, t2, t3, t4);
        }

        /// <summary>
        /// 5 要素のタプルを生成します。
        /// </summary>
        public static _<T1, T2, T3, T4, T5> Of<T1, T2, T3, T4, T5>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            return new _<T1, T2, T3, T4, T5>(t1, t2, t3, t4, t5);
        }

        /// <summary>
        /// 6 要素のタプルを生成します。
        /// </summary>
        public static _<T1, T2, T3, T4, T5, T6> Of<T1, T2, T3, T4, T5, T6>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
        {
            return new _<T1, T2, T3, T4, T5, T6>(t1, t2, t3, t4, t5, t6);
        }

        /// <summary>
        /// 7 要素のタプルを生成します。
        /// </summary>
        public static _<T1, T2, T3, T4, T5, T6, T7> Of<T1, T2, T3, T4, T5, T6, T7>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
        {
            return new _<T1, T2, T3, T4, T5, T6, T7>(t1, t2, t3, t4, t5, t6, t7);
        }

        /// <summary>
        /// 8 要素のタプルを生成します。
        /// </summary>
        public static _<T1, T2, T3, T4, T5, T6, T7, T8> Of<T1, T2, T3, T4, T5, T6, T7, T8>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
        {
            return new _<T1, T2, T3, T4, T5, T6, T7, T8>(t1, t2, t3, t4, t5, t6, t7, t8);
        }

        /// <summary>
        /// 9 要素のタプルを生成します。
        /// </summary>
        public static _<T1, T2, T3, T4, T5, T6, T7, T8, T9> Of<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
        {
            return new _<T1, T2, T3, T4, T5, T6, T7, T8, T9>(t1, t2, t3, t4, t5, t6, t7, t8, t9);
        }

        /// <summary>
        /// 10 要素のタプルを生成します。
        /// </summary>
        public static _<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Of<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
        {
            return new _<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
        }

    }

    /// <summary>
    /// 2 要素のタプルを表します。
    /// </summary>
    public struct _<T1, T2> : IEquatable<_<T1, T2>>
    {
        /// <summary>
        /// タプルの 1 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T1 _1;
        /// <summary>
        /// タプルの 2 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T2 _2;

        internal _(T1 t1, T2 t2)
        {
            _1 = t1;
            _2 = t2;
        }
        
        /// <summary>
        /// タプルのシーケンスの各要素を展開します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返される値の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して変換関数を適用した結果を要素に持つシーケンス。</returns>
        public TResult Let<TResult>(Func<T1, T2, TResult> f)
        {
            return f(_1, _2);
        }

        #region IEquatable<Tpl<T1, T2>> メンバ

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較するタプル。</param>
        /// <returns>現在のオブジェクトが other パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public bool Equals(_<T1, T2> other)
        {
            return Equals(_1, other._1) && Equals(_2, other._2);
        }

        #endregion

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト。</param>
        /// <returns>現在のオブジェクトが obj パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is _<T1, T2>))
                return false;

            return Equals((_<T1, T2>)obj);
        }

        /// <summary>
        /// 現在のオブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>現在のオブジェクトのハッシュコード。</returns>
        public override int GetHashCode()
        {
            var result = 31;
            result ^= _1 == null ? 0 : _1.GetHashCode();
            result ^= _2 == null ? 0 : _2.GetHashCode();
            return result;
        }

        /// <summary>
        /// 2 つのタプルの比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つのタプルが等しい場合は true、それ以外の場合は false。</returns>
        public static bool operator ==(_<T1, T2> a, _<T1, T2> b)
        {
            return a.Equals(b);
        }

        /// <summary>
        /// 2 つのタプルの比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つのタプルが等しい場合は false、それ以外の場合は true。</returns>
        public static bool operator !=(_<T1, T2> a, _<T1, T2> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 現在のオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>現在のオブジェクトの文字列表現。</returns>
        public override string ToString()
        {
            return string.Format("({0}, {1})", _1, _2);
        }
    }
    /// <summary>
    /// 3 要素のタプルを表します。
    /// </summary>
    public struct _<T1, T2, T3> : IEquatable<_<T1, T2, T3>>
    {
        /// <summary>
        /// タプルの 1 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T1 _1;
        /// <summary>
        /// タプルの 2 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T2 _2;
        /// <summary>
        /// タプルの 3 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T3 _3;

        internal _(T1 t1, T2 t2, T3 t3)
        {
            _1 = t1;
            _2 = t2;
            _3 = t3;
        }
        
        /// <summary>
        /// タプルのシーケンスの各要素を展開します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返される値の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して変換関数を適用した結果を要素に持つシーケンス。</returns>
        public TResult Let<TResult>(Func<T1, T2, T3, TResult> f)
        {
            return f(_1, _2, _3);
        }

        #region IEquatable<Tpl<T1, T2, T3>> メンバ

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較するタプル。</param>
        /// <returns>現在のオブジェクトが other パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public bool Equals(_<T1, T2, T3> other)
        {
            return Equals(_1, other._1) && Equals(_2, other._2) && Equals(_3, other._3);
        }

        #endregion

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト。</param>
        /// <returns>現在のオブジェクトが obj パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is _<T1, T2, T3>))
                return false;

            return Equals((_<T1, T2, T3>)obj);
        }

        /// <summary>
        /// 現在のオブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>現在のオブジェクトのハッシュコード。</returns>
        public override int GetHashCode()
        {
            var result = 31;
            result ^= _1 == null ? 0 : _1.GetHashCode();
            result ^= _2 == null ? 0 : _2.GetHashCode();
            result ^= _3 == null ? 0 : _3.GetHashCode();
            return result;
        }

        /// <summary>
        /// 2 つのタプルの比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つのタプルが等しい場合は true、それ以外の場合は false。</returns>
        public static bool operator ==(_<T1, T2, T3> a, _<T1, T2, T3> b)
        {
            return a.Equals(b);
        }

        /// <summary>
        /// 2 つのタプルの比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つのタプルが等しい場合は false、それ以外の場合は true。</returns>
        public static bool operator !=(_<T1, T2, T3> a, _<T1, T2, T3> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 現在のオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>現在のオブジェクトの文字列表現。</returns>
        public override string ToString()
        {
            return string.Format("({0}, {1}, {2})", _1, _2, _3);
        }
    }
    /// <summary>
    /// 4 要素のタプルを表します。
    /// </summary>
    public struct _<T1, T2, T3, T4> : IEquatable<_<T1, T2, T3, T4>>
    {
        /// <summary>
        /// タプルの 1 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T1 _1;
        /// <summary>
        /// タプルの 2 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T2 _2;
        /// <summary>
        /// タプルの 3 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T3 _3;
        /// <summary>
        /// タプルの 4 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T4 _4;

        internal _(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            _1 = t1;
            _2 = t2;
            _3 = t3;
            _4 = t4;
        }
        
        /// <summary>
        /// タプルのシーケンスの各要素を展開します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返される値の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して変換関数を適用した結果を要素に持つシーケンス。</returns>
        public TResult Let<TResult>(Func<T1, T2, T3, T4, TResult> f)
        {
            return f(_1, _2, _3, _4);
        }

        #region IEquatable<Tpl<T1, T2, T3, T4>> メンバ

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較するタプル。</param>
        /// <returns>現在のオブジェクトが other パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public bool Equals(_<T1, T2, T3, T4> other)
        {
            return Equals(_1, other._1) && Equals(_2, other._2) && Equals(_3, other._3) && Equals(_4, other._4);
        }

        #endregion

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト。</param>
        /// <returns>現在のオブジェクトが obj パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is _<T1, T2, T3, T4>))
                return false;

            return Equals((_<T1, T2, T3, T4>)obj);
        }

        /// <summary>
        /// 現在のオブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>現在のオブジェクトのハッシュコード。</returns>
        public override int GetHashCode()
        {
            var result = 31;
            result ^= _1 == null ? 0 : _1.GetHashCode();
            result ^= _2 == null ? 0 : _2.GetHashCode();
            result ^= _3 == null ? 0 : _3.GetHashCode();
            result ^= _4 == null ? 0 : _4.GetHashCode();
            return result;
        }

        /// <summary>
        /// 2 つのタプルの比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つのタプルが等しい場合は true、それ以外の場合は false。</returns>
        public static bool operator ==(_<T1, T2, T3, T4> a, _<T1, T2, T3, T4> b)
        {
            return a.Equals(b);
        }

        /// <summary>
        /// 2 つのタプルの比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つのタプルが等しい場合は false、それ以外の場合は true。</returns>
        public static bool operator !=(_<T1, T2, T3, T4> a, _<T1, T2, T3, T4> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 現在のオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>現在のオブジェクトの文字列表現。</returns>
        public override string ToString()
        {
            return string.Format("({0}, {1}, {2}, {3})", _1, _2, _3, _4);
        }
    }
    /// <summary>
    /// 5 要素のタプルを表します。
    /// </summary>
    public struct _<T1, T2, T3, T4, T5> : IEquatable<_<T1, T2, T3, T4, T5>>
    {
        /// <summary>
        /// タプルの 1 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T1 _1;
        /// <summary>
        /// タプルの 2 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T2 _2;
        /// <summary>
        /// タプルの 3 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T3 _3;
        /// <summary>
        /// タプルの 4 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T4 _4;
        /// <summary>
        /// タプルの 5 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T5 _5;

        internal _(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            _1 = t1;
            _2 = t2;
            _3 = t3;
            _4 = t4;
            _5 = t5;
        }
        
        /// <summary>
        /// タプルのシーケンスの各要素を展開します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返される値の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して変換関数を適用した結果を要素に持つシーケンス。</returns>
        public TResult Let<TResult>(Func<T1, T2, T3, T4, T5, TResult> f)
        {
            return f(_1, _2, _3, _4, _5);
        }

        #region IEquatable<Tpl<T1, T2, T3, T4, T5>> メンバ

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較するタプル。</param>
        /// <returns>現在のオブジェクトが other パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public bool Equals(_<T1, T2, T3, T4, T5> other)
        {
            return Equals(_1, other._1) && Equals(_2, other._2) && Equals(_3, other._3) && Equals(_4, other._4) && Equals(_5, other._5);
        }

        #endregion

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト。</param>
        /// <returns>現在のオブジェクトが obj パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is _<T1, T2, T3, T4, T5>))
                return false;

            return Equals((_<T1, T2, T3, T4, T5>)obj);
        }

        /// <summary>
        /// 現在のオブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>現在のオブジェクトのハッシュコード。</returns>
        public override int GetHashCode()
        {
            var result = 31;
            result ^= _1 == null ? 0 : _1.GetHashCode();
            result ^= _2 == null ? 0 : _2.GetHashCode();
            result ^= _3 == null ? 0 : _3.GetHashCode();
            result ^= _4 == null ? 0 : _4.GetHashCode();
            result ^= _5 == null ? 0 : _5.GetHashCode();
            return result;
        }

        /// <summary>
        /// 2 つのタプルの比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つのタプルが等しい場合は true、それ以外の場合は false。</returns>
        public static bool operator ==(_<T1, T2, T3, T4, T5> a, _<T1, T2, T3, T4, T5> b)
        {
            return a.Equals(b);
        }

        /// <summary>
        /// 2 つのタプルの比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つのタプルが等しい場合は false、それ以外の場合は true。</returns>
        public static bool operator !=(_<T1, T2, T3, T4, T5> a, _<T1, T2, T3, T4, T5> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 現在のオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>現在のオブジェクトの文字列表現。</returns>
        public override string ToString()
        {
            return string.Format("({0}, {1}, {2}, {3}, {4})", _1, _2, _3, _4, _5);
        }
    }
    /// <summary>
    /// 6 要素のタプルを表します。
    /// </summary>
    public struct _<T1, T2, T3, T4, T5, T6> : IEquatable<_<T1, T2, T3, T4, T5, T6>>
    {
        /// <summary>
        /// タプルの 1 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T1 _1;
        /// <summary>
        /// タプルの 2 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T2 _2;
        /// <summary>
        /// タプルの 3 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T3 _3;
        /// <summary>
        /// タプルの 4 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T4 _4;
        /// <summary>
        /// タプルの 5 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T5 _5;
        /// <summary>
        /// タプルの 6 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T6 _6;

        internal _(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
        {
            _1 = t1;
            _2 = t2;
            _3 = t3;
            _4 = t4;
            _5 = t5;
            _6 = t6;
        }
        
        /// <summary>
        /// タプルのシーケンスの各要素を展開します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返される値の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して変換関数を適用した結果を要素に持つシーケンス。</returns>
        public TResult Let<TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> f)
        {
            return f(_1, _2, _3, _4, _5, _6);
        }

        #region IEquatable<Tpl<T1, T2, T3, T4, T5, T6>> メンバ

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較するタプル。</param>
        /// <returns>現在のオブジェクトが other パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public bool Equals(_<T1, T2, T3, T4, T5, T6> other)
        {
            return Equals(_1, other._1) && Equals(_2, other._2) && Equals(_3, other._3) && Equals(_4, other._4) && Equals(_5, other._5) && Equals(_6, other._6);
        }

        #endregion

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト。</param>
        /// <returns>現在のオブジェクトが obj パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is _<T1, T2, T3, T4, T5, T6>))
                return false;

            return Equals((_<T1, T2, T3, T4, T5, T6>)obj);
        }

        /// <summary>
        /// 現在のオブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>現在のオブジェクトのハッシュコード。</returns>
        public override int GetHashCode()
        {
            var result = 31;
            result ^= _1 == null ? 0 : _1.GetHashCode();
            result ^= _2 == null ? 0 : _2.GetHashCode();
            result ^= _3 == null ? 0 : _3.GetHashCode();
            result ^= _4 == null ? 0 : _4.GetHashCode();
            result ^= _5 == null ? 0 : _5.GetHashCode();
            result ^= _6 == null ? 0 : _6.GetHashCode();
            return result;
        }

        /// <summary>
        /// 2 つのタプルの比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つのタプルが等しい場合は true、それ以外の場合は false。</returns>
        public static bool operator ==(_<T1, T2, T3, T4, T5, T6> a, _<T1, T2, T3, T4, T5, T6> b)
        {
            return a.Equals(b);
        }

        /// <summary>
        /// 2 つのタプルの比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つのタプルが等しい場合は false、それ以外の場合は true。</returns>
        public static bool operator !=(_<T1, T2, T3, T4, T5, T6> a, _<T1, T2, T3, T4, T5, T6> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 現在のオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>現在のオブジェクトの文字列表現。</returns>
        public override string ToString()
        {
            return string.Format("({0}, {1}, {2}, {3}, {4}, {5})", _1, _2, _3, _4, _5, _6);
        }
    }
    /// <summary>
    /// 7 要素のタプルを表します。
    /// </summary>
    public struct _<T1, T2, T3, T4, T5, T6, T7> : IEquatable<_<T1, T2, T3, T4, T5, T6, T7>>
    {
        /// <summary>
        /// タプルの 1 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T1 _1;
        /// <summary>
        /// タプルの 2 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T2 _2;
        /// <summary>
        /// タプルの 3 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T3 _3;
        /// <summary>
        /// タプルの 4 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T4 _4;
        /// <summary>
        /// タプルの 5 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T5 _5;
        /// <summary>
        /// タプルの 6 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T6 _6;
        /// <summary>
        /// タプルの 7 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T7 _7;

        internal _(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
        {
            _1 = t1;
            _2 = t2;
            _3 = t3;
            _4 = t4;
            _5 = t5;
            _6 = t6;
            _7 = t7;
        }
        
        /// <summary>
        /// タプルのシーケンスの各要素を展開します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返される値の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して変換関数を適用した結果を要素に持つシーケンス。</returns>
        public TResult Let<TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> f)
        {
            return f(_1, _2, _3, _4, _5, _6, _7);
        }

        #region IEquatable<Tpl<T1, T2, T3, T4, T5, T6, T7>> メンバ

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較するタプル。</param>
        /// <returns>現在のオブジェクトが other パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public bool Equals(_<T1, T2, T3, T4, T5, T6, T7> other)
        {
            return Equals(_1, other._1) && Equals(_2, other._2) && Equals(_3, other._3) && Equals(_4, other._4) && Equals(_5, other._5) && Equals(_6, other._6) && Equals(_7, other._7);
        }

        #endregion

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト。</param>
        /// <returns>現在のオブジェクトが obj パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is _<T1, T2, T3, T4, T5, T6, T7>))
                return false;

            return Equals((_<T1, T2, T3, T4, T5, T6, T7>)obj);
        }

        /// <summary>
        /// 現在のオブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>現在のオブジェクトのハッシュコード。</returns>
        public override int GetHashCode()
        {
            var result = 31;
            result ^= _1 == null ? 0 : _1.GetHashCode();
            result ^= _2 == null ? 0 : _2.GetHashCode();
            result ^= _3 == null ? 0 : _3.GetHashCode();
            result ^= _4 == null ? 0 : _4.GetHashCode();
            result ^= _5 == null ? 0 : _5.GetHashCode();
            result ^= _6 == null ? 0 : _6.GetHashCode();
            result ^= _7 == null ? 0 : _7.GetHashCode();
            return result;
        }

        /// <summary>
        /// 2 つのタプルの比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つのタプルが等しい場合は true、それ以外の場合は false。</returns>
        public static bool operator ==(_<T1, T2, T3, T4, T5, T6, T7> a, _<T1, T2, T3, T4, T5, T6, T7> b)
        {
            return a.Equals(b);
        }

        /// <summary>
        /// 2 つのタプルの比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つのタプルが等しい場合は false、それ以外の場合は true。</returns>
        public static bool operator !=(_<T1, T2, T3, T4, T5, T6, T7> a, _<T1, T2, T3, T4, T5, T6, T7> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 現在のオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>現在のオブジェクトの文字列表現。</returns>
        public override string ToString()
        {
            return string.Format("({0}, {1}, {2}, {3}, {4}, {5}, {6})", _1, _2, _3, _4, _5, _6, _7);
        }
    }
    /// <summary>
    /// 8 要素のタプルを表します。
    /// </summary>
    public struct _<T1, T2, T3, T4, T5, T6, T7, T8> : IEquatable<_<T1, T2, T3, T4, T5, T6, T7, T8>>
    {
        /// <summary>
        /// タプルの 1 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T1 _1;
        /// <summary>
        /// タプルの 2 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T2 _2;
        /// <summary>
        /// タプルの 3 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T3 _3;
        /// <summary>
        /// タプルの 4 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T4 _4;
        /// <summary>
        /// タプルの 5 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T5 _5;
        /// <summary>
        /// タプルの 6 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T6 _6;
        /// <summary>
        /// タプルの 7 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T7 _7;
        /// <summary>
        /// タプルの 8 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T8 _8;

        internal _(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
        {
            _1 = t1;
            _2 = t2;
            _3 = t3;
            _4 = t4;
            _5 = t5;
            _6 = t6;
            _7 = t7;
            _8 = t8;
        }
        
        /// <summary>
        /// タプルのシーケンスの各要素を展開します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="T8">シーケンスの保持する 8 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返される値の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して変換関数を適用した結果を要素に持つシーケンス。</returns>
        public TResult Let<TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> f)
        {
            return f(_1, _2, _3, _4, _5, _6, _7, _8);
        }

        #region IEquatable<Tpl<T1, T2, T3, T4, T5, T6, T7, T8>> メンバ

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較するタプル。</param>
        /// <returns>現在のオブジェクトが other パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public bool Equals(_<T1, T2, T3, T4, T5, T6, T7, T8> other)
        {
            return Equals(_1, other._1) && Equals(_2, other._2) && Equals(_3, other._3) && Equals(_4, other._4) && Equals(_5, other._5) && Equals(_6, other._6) && Equals(_7, other._7) && Equals(_8, other._8);
        }

        #endregion

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト。</param>
        /// <returns>現在のオブジェクトが obj パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is _<T1, T2, T3, T4, T5, T6, T7, T8>))
                return false;

            return Equals((_<T1, T2, T3, T4, T5, T6, T7, T8>)obj);
        }

        /// <summary>
        /// 現在のオブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>現在のオブジェクトのハッシュコード。</returns>
        public override int GetHashCode()
        {
            var result = 31;
            result ^= _1 == null ? 0 : _1.GetHashCode();
            result ^= _2 == null ? 0 : _2.GetHashCode();
            result ^= _3 == null ? 0 : _3.GetHashCode();
            result ^= _4 == null ? 0 : _4.GetHashCode();
            result ^= _5 == null ? 0 : _5.GetHashCode();
            result ^= _6 == null ? 0 : _6.GetHashCode();
            result ^= _7 == null ? 0 : _7.GetHashCode();
            result ^= _8 == null ? 0 : _8.GetHashCode();
            return result;
        }

        /// <summary>
        /// 2 つのタプルの比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つのタプルが等しい場合は true、それ以外の場合は false。</returns>
        public static bool operator ==(_<T1, T2, T3, T4, T5, T6, T7, T8> a, _<T1, T2, T3, T4, T5, T6, T7, T8> b)
        {
            return a.Equals(b);
        }

        /// <summary>
        /// 2 つのタプルの比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つのタプルが等しい場合は false、それ以外の場合は true。</returns>
        public static bool operator !=(_<T1, T2, T3, T4, T5, T6, T7, T8> a, _<T1, T2, T3, T4, T5, T6, T7, T8> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 現在のオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>現在のオブジェクトの文字列表現。</returns>
        public override string ToString()
        {
            return string.Format("({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", _1, _2, _3, _4, _5, _6, _7, _8);
        }
    }
    /// <summary>
    /// 9 要素のタプルを表します。
    /// </summary>
    public struct _<T1, T2, T3, T4, T5, T6, T7, T8, T9> : IEquatable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9>>
    {
        /// <summary>
        /// タプルの 1 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T1 _1;
        /// <summary>
        /// タプルの 2 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T2 _2;
        /// <summary>
        /// タプルの 3 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T3 _3;
        /// <summary>
        /// タプルの 4 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T4 _4;
        /// <summary>
        /// タプルの 5 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T5 _5;
        /// <summary>
        /// タプルの 6 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T6 _6;
        /// <summary>
        /// タプルの 7 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T7 _7;
        /// <summary>
        /// タプルの 8 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T8 _8;
        /// <summary>
        /// タプルの 9 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T9 _9;

        internal _(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
        {
            _1 = t1;
            _2 = t2;
            _3 = t3;
            _4 = t4;
            _5 = t5;
            _6 = t6;
            _7 = t7;
            _8 = t8;
            _9 = t9;
        }
        
        /// <summary>
        /// タプルのシーケンスの各要素を展開します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="T8">シーケンスの保持する 8 つ目の型。</typeparam>
        /// <typeparam name="T9">シーケンスの保持する 9 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返される値の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して変換関数を適用した結果を要素に持つシーケンス。</returns>
        public TResult Let<TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> f)
        {
            return f(_1, _2, _3, _4, _5, _6, _7, _8, _9);
        }

        #region IEquatable<Tpl<T1, T2, T3, T4, T5, T6, T7, T8, T9>> メンバ

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較するタプル。</param>
        /// <returns>現在のオブジェクトが other パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public bool Equals(_<T1, T2, T3, T4, T5, T6, T7, T8, T9> other)
        {
            return Equals(_1, other._1) && Equals(_2, other._2) && Equals(_3, other._3) && Equals(_4, other._4) && Equals(_5, other._5) && Equals(_6, other._6) && Equals(_7, other._7) && Equals(_8, other._8) && Equals(_9, other._9);
        }

        #endregion

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト。</param>
        /// <returns>現在のオブジェクトが obj パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is _<T1, T2, T3, T4, T5, T6, T7, T8, T9>))
                return false;

            return Equals((_<T1, T2, T3, T4, T5, T6, T7, T8, T9>)obj);
        }

        /// <summary>
        /// 現在のオブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>現在のオブジェクトのハッシュコード。</returns>
        public override int GetHashCode()
        {
            var result = 31;
            result ^= _1 == null ? 0 : _1.GetHashCode();
            result ^= _2 == null ? 0 : _2.GetHashCode();
            result ^= _3 == null ? 0 : _3.GetHashCode();
            result ^= _4 == null ? 0 : _4.GetHashCode();
            result ^= _5 == null ? 0 : _5.GetHashCode();
            result ^= _6 == null ? 0 : _6.GetHashCode();
            result ^= _7 == null ? 0 : _7.GetHashCode();
            result ^= _8 == null ? 0 : _8.GetHashCode();
            result ^= _9 == null ? 0 : _9.GetHashCode();
            return result;
        }

        /// <summary>
        /// 2 つのタプルの比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つのタプルが等しい場合は true、それ以外の場合は false。</returns>
        public static bool operator ==(_<T1, T2, T3, T4, T5, T6, T7, T8, T9> a, _<T1, T2, T3, T4, T5, T6, T7, T8, T9> b)
        {
            return a.Equals(b);
        }

        /// <summary>
        /// 2 つのタプルの比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つのタプルが等しい場合は false、それ以外の場合は true。</returns>
        public static bool operator !=(_<T1, T2, T3, T4, T5, T6, T7, T8, T9> a, _<T1, T2, T3, T4, T5, T6, T7, T8, T9> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 現在のオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>現在のオブジェクトの文字列表現。</returns>
        public override string ToString()
        {
            return string.Format("({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", _1, _2, _3, _4, _5, _6, _7, _8, _9);
        }
    }
    /// <summary>
    /// 10 要素のタプルを表します。
    /// </summary>
    public struct _<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : IEquatable<_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>
    {
        /// <summary>
        /// タプルの 1 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T1 _1;
        /// <summary>
        /// タプルの 2 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T2 _2;
        /// <summary>
        /// タプルの 3 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T3 _3;
        /// <summary>
        /// タプルの 4 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T4 _4;
        /// <summary>
        /// タプルの 5 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T5 _5;
        /// <summary>
        /// タプルの 6 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T6 _6;
        /// <summary>
        /// タプルの 7 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T7 _7;
        /// <summary>
        /// タプルの 8 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T8 _8;
        /// <summary>
        /// タプルの 9 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T9 _9;
        /// <summary>
        /// タプルの 10 番目の要素ですが、できる限り直接参照しないようにしてください。
        /// </summary>
        public readonly T10 _10;

        internal _(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
        {
            _1 = t1;
            _2 = t2;
            _3 = t3;
            _4 = t4;
            _5 = t5;
            _6 = t6;
            _7 = t7;
            _8 = t8;
            _9 = t9;
            _10 = t10;
        }
        
        /// <summary>
        /// タプルのシーケンスの各要素を展開します。
        /// </summary>
        /// <typeparam name="T1">シーケンスの保持する 1 つ目の型。</typeparam>
        /// <typeparam name="T2">シーケンスの保持する 2 つ目の型。</typeparam>
        /// <typeparam name="T3">シーケンスの保持する 3 つ目の型。</typeparam>
        /// <typeparam name="T4">シーケンスの保持する 4 つ目の型。</typeparam>
        /// <typeparam name="T5">シーケンスの保持する 5 つ目の型。</typeparam>
        /// <typeparam name="T6">シーケンスの保持する 6 つ目の型。</typeparam>
        /// <typeparam name="T7">シーケンスの保持する 7 つ目の型。</typeparam>
        /// <typeparam name="T8">シーケンスの保持する 8 つ目の型。</typeparam>
        /// <typeparam name="T9">シーケンスの保持する 9 つ目の型。</typeparam>
        /// <typeparam name="T10">シーケンスの保持する 10 つ目の型。</typeparam>
        /// <typeparam name="TResult">selector によって返される値の型。</typeparam>
        /// <param name="self">変換関数を呼び出す対象となる値のシーケンス。</param>
        /// <param name="selector">各要素に適用する変換関数。</param>
        /// <returns>self の各要素に対して変換関数を適用した結果を要素に持つシーケンス。</returns>
        public TResult Let<TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> f)
        {
            return f(_1, _2, _3, _4, _5, _6, _7, _8, _9, _10);
        }

        #region IEquatable<Tpl<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> メンバ

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較するタプル。</param>
        /// <returns>現在のオブジェクトが other パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public bool Equals(_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> other)
        {
            return Equals(_1, other._1) && Equals(_2, other._2) && Equals(_3, other._3) && Equals(_4, other._4) && Equals(_5, other._5) && Equals(_6, other._6) && Equals(_7, other._7) && Equals(_8, other._8) && Equals(_9, other._9) && Equals(_10, other._10);
        }

        #endregion

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト。</param>
        /// <returns>現在のオブジェクトが obj パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is _<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>))
                return false;

            return Equals((_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>)obj);
        }

        /// <summary>
        /// 現在のオブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>現在のオブジェクトのハッシュコード。</returns>
        public override int GetHashCode()
        {
            var result = 31;
            result ^= _1 == null ? 0 : _1.GetHashCode();
            result ^= _2 == null ? 0 : _2.GetHashCode();
            result ^= _3 == null ? 0 : _3.GetHashCode();
            result ^= _4 == null ? 0 : _4.GetHashCode();
            result ^= _5 == null ? 0 : _5.GetHashCode();
            result ^= _6 == null ? 0 : _6.GetHashCode();
            result ^= _7 == null ? 0 : _7.GetHashCode();
            result ^= _8 == null ? 0 : _8.GetHashCode();
            result ^= _9 == null ? 0 : _9.GetHashCode();
            result ^= _10 == null ? 0 : _10.GetHashCode();
            return result;
        }

        /// <summary>
        /// 2 つのタプルの比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つのタプルが等しい場合は true、それ以外の場合は false。</returns>
        public static bool operator ==(_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> a, _<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> b)
        {
            return a.Equals(b);
        }

        /// <summary>
        /// 2 つのタプルの比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Variant。</param>
        /// <param name="b">2 つ目の Variant。</param>
        /// <returns>2 つのタプルが等しい場合は false、それ以外の場合は true。</returns>
        public static bool operator !=(_<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> a, _<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 現在のオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>現在のオブジェクトの文字列表現。</returns>
        public override string ToString()
        {
            return string.Format("({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", _1, _2, _3, _4, _5, _6, _7, _8, _9, _10);
        }
    }
}