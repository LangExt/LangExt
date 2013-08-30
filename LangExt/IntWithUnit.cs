using System;
using System.ComponentModel;

namespace LangExt
{
    /// <summary>intに対する関数を提供します。</summary>
    public static class Int
    {
        /// <summary>
        /// 数値に単位を追加します。
        /// </summary>
        public static IntWithUnit<T> WithUnit<T>(this int self) where T : IUnit { return (IntWithUnit<T>)self; }
        /// <summary>
        /// 数値に単位を追加します。
        /// </summary>
        public static IntWithUnit<T> WithUnit<T>(this int? self) where T : IUnit { return (IntWithUnit<T>)self; }

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

    /// <summary>
    /// 単位を持ったintです。
    /// 単位を型として表現できるため、より安全に数値演算が可能です。
    /// 例えば、単位が異なる数値を加算しようとした場合に、コンパイルエラーになります。
    /// この型の型パラメータTは、型パラメータだけに現れます(幽霊型)。
    /// この型のオブジェクトの演算の結果、値を持たない状態になることがありますが、
    /// その状態のオブジェクトを明示的に使うのは避けてください。
    /// </summary>
    /// <typeparam name="T">単位を表す型パラメータ</typeparam>
    public struct IntWithUnit<T> : IEquatable<IntWithUnit<T>>, IComparable<IntWithUnit<T>>
        where T : IUnit
    {
        /// <summary>このオブジェクトが数値を持っているかどうかを表します。基本的には使用しません。</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public readonly bool HasValue;
        /// <summary>このオブジェクトの数値を取得します。</summary>
        public readonly int Value;

        /// <summary>
        /// 値を持たないことを表す読み取り専用フィールドです。
        /// 基本的には使用しません。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly IntWithUnit<T> NoValue = new IntWithUnit<T>();

        /// <summary>
        /// 単位のない数値から単位を持った数値を生成するコンストラクタです。
        /// </summary>
        public IntWithUnit(int value)
        {
            HasValue = true;
            Value = value;
        }

        /// <summary>
        /// 単位のない数値から単位のある数値への明示的な変換演算子です。
        /// </summary>
        public static explicit operator IntWithUnit<T>(int? i)
        {
            return i.HasValue ? new IntWithUnit<T>(i.Value) : IntWithUnit<T>.NoValue;
        }

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較する単位付き数値</param>
        /// <returns>現在のオブジェクトがotherで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        public bool Equals(IntWithUnit<T> other)
        {
            return this.HasValue == other.HasValue && this.Value == other.Value;
        }

        /// <summary>
        /// 現在のオブジェクトとotherの大小関係を比較します。
        /// 通常は、演算子を使い、このメソッドは使いません。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int CompareTo(IntWithUnit<T> other)
        {
            if (!this.HasValue || !other.HasValue)
                throw new Exception();
            return this.Value.CompareTo(other.Value);
        }

        /// <summary>
        /// 2つの単位付き数値の比較を行います。
        /// </summary>
        /// <param name="lhs">1つ目の単位付き数値</param>
        /// <param name="rhs">2つ目の単位付き数値</param>
        /// <returns>2つの単位付き数値が等しい場合はtrue、それ以外の場合はfalse</returns>
        public static bool operator ==(IntWithUnit<T> lhs, IntWithUnit<T> rhs) { return lhs.Equals(rhs); }
        /// <summary>
        /// 2つの単位付き数値の比較を行います。
        /// </summary>
        /// <param name="lhs">1つ目の単位付き数値</param>
        /// <param name="rhs">2つ目の単位付き数値</param>
        /// <returns>2つの単位付き数値が等しい場合はfalse、それ以外の場合はtrue</returns>
        public static bool operator !=(IntWithUnit<T> lhs, IntWithUnit<T> rhs) { return lhs.Equals(rhs) == false; }

        /// <summary>単位付き数値と数値の比較を行います。</summary>
        public static bool operator ==(IntWithUnit<T> lhs, int? rhs) { return lhs.Equals((IntWithUnit<T>)rhs); }
        /// <summary>単位付き数値と数値の比較を行います。</summary>
        public static bool operator !=(IntWithUnit<T> lhs, int? rhs) { return lhs.Equals((IntWithUnit<T>)rhs) == false; }
        /// <summary>数値と単位付き数値の比較を行います。</summary>
        public static bool operator ==(int? lhs, IntWithUnit<T> rhs) { return rhs.Equals((IntWithUnit<T>)lhs); }
        /// <summary>数値と単位付き数値の比較を行います。</summary>
        public static bool operator !=(int? lhs, IntWithUnit<T> rhs) { return rhs.Equals((IntWithUnit<T>)lhs) == false; }

        /// <summary>
        /// 2つの単位付き数値の一つ目が小さい場合、二つ目(大きい方)を返し、それ以外の場合はNoValueが返されます。
        /// この挙動により、ある程度自然に比較演算子をチェーン出来ます。
        /// この演算子の結果として取得したオブジェクトは、他の比較演算子のどちらかの項に使う以外に用いないでください。
        /// </summary>
        public static IntWithUnit<T> operator <(IntWithUnit<T> lhs, IntWithUnit<T> rhs)
        {
            if (!lhs.HasValue || !rhs.HasValue) return IntWithUnit<T>.NoValue;
            return lhs.Value < rhs.Value ? rhs : IntWithUnit<T>.NoValue;
        }
        /// <summary>
        /// 2つの単位付き数値の一つ目が大きい場合、二つ目(小さい方)を返し、それ以外の場合はNoValueが返されます。
        /// この挙動により、ある程度自然に比較演算子をチェーン出来ます。
        /// この演算子の結果として取得したオブジェクトは、他の比較演算子のどちらかの項に使う以外に用いないでください。
        /// </summary>
        public static IntWithUnit<T> operator >(IntWithUnit<T> lhs, IntWithUnit<T> rhs)
        {
            if (!lhs.HasValue || !rhs.HasValue) return IntWithUnit<T>.NoValue;
            return lhs.Value > rhs.Value ? rhs : IntWithUnit<T>.NoValue;
        }
        /// <summary>
        /// 2つの単位付き数値の一つ目が小さい、もしくは等しい場合、二つ目(大きい方)を返し、それ以外の場合はNoValueが返されます。
        /// この挙動により、ある程度自然に比較演算子をチェーン出来ます。
        /// この演算子の結果として取得したオブジェクトは、他の比較演算子のどちらかの項に使う以外に用いないでください。
        /// </summary>
        public static IntWithUnit<T> operator <=(IntWithUnit<T> lhs, IntWithUnit<T> rhs)
        {
            if (!lhs.HasValue || !rhs.HasValue) return IntWithUnit<T>.NoValue;
            return lhs.Value <= rhs.Value ? rhs : IntWithUnit<T>.NoValue;
        }
        /// <summary>
        /// 2つの単位付き数値の一つ目が大きい、もしくは等しい場合、二つ目(小さい方)を返し、それ以外の場合はNoValueが返されます。
        /// この挙動により、ある程度自然に比較演算子をチェーン出来ます。
        /// この演算子の結果として取得したオブジェクトは、他の比較演算子のどちらかの項に使う以外に用いないでください。
        /// </summary>
        public static IntWithUnit<T> operator >=(IntWithUnit<T> lhs, IntWithUnit<T> rhs)
        {
            if (!lhs.HasValue || !rhs.HasValue) return IntWithUnit<T>.NoValue;
            return lhs.Value >= rhs.Value ? rhs : IntWithUnit<T>.NoValue;
        }

        /// <summary>
        /// 単位付き数値と数値の比較を行います。
        /// この演算子の結果として取得したオブジェクトは、他の比較演算子のどちらかの項に使う以外に用いないでください。
        /// </summary>
        public static IntWithUnit<T> operator <(IntWithUnit<T> lhs, int? rhs) { return lhs < (IntWithUnit<T>)rhs; }
        /// <summary>
        /// 数値と単位付き数値の比較を行います。
        /// この演算子の結果として取得したオブジェクトは、他の比較演算子のどちらかの項に使う以外に用いないでください。
        /// </summary>
        public static IntWithUnit<T> operator <(int? lhs, IntWithUnit<T> rhs) { return (IntWithUnit<T>)lhs < rhs; }
        /// <summary>
        /// 単位付き数値と数値の比較を行います。
        /// この演算子の結果として取得したオブジェクトは、他の比較演算子のどちらかの項に使う以外に用いないでください。
        /// </summary>
        public static IntWithUnit<T> operator >(IntWithUnit<T> lhs, int? rhs) { return lhs > (IntWithUnit<T>)rhs; }
        /// <summary>
        /// 数値と単位付き数値の比較を行います。
        /// この演算子の結果として取得したオブジェクトは、他の比較演算子のどちらかの項に使う以外に用いないでください。
        /// </summary>
        public static IntWithUnit<T> operator >(int? lhs, IntWithUnit<T> rhs) { return (IntWithUnit<T>)lhs > rhs; }
        /// <summary>
        /// 単位付き数値と数値の比較を行います。
        /// この演算子の結果として取得したオブジェクトは、他の比較演算子のどちらかの項に使う以外に用いないでください。
        /// </summary>
        public static IntWithUnit<T> operator <=(IntWithUnit<T> lhs, int? rhs) { return lhs <= (IntWithUnit<T>)rhs; }
        /// <summary>
        /// 数値と単位付き数値の比較を行います。
        /// この演算子の結果として取得したオブジェクトは、他の比較演算子のどちらかの項に使う以外に用いないでください。
        /// </summary>
        public static IntWithUnit<T> operator <=(int? lhs, IntWithUnit<T> rhs) { return (IntWithUnit<T>)lhs <= rhs; }
        /// <summary>
        /// 単位付き数値と数値の比較を行います。
        /// この演算子の結果として取得したオブジェクトは、他の比較演算子のどちらかの項に使う以外に用いないでください。
        /// </summary>
        public static IntWithUnit<T> operator >=(IntWithUnit<T> lhs, int? rhs) { return lhs >= (IntWithUnit<T>)rhs; }
        /// <summary>
        /// 数値と単位付き数値の比較を行います。
        /// この演算子の結果として取得したオブジェクトは、他の比較演算子のどちらかの項に使う以外に用いないでください。
        /// </summary>
        public static IntWithUnit<T> operator >=(int? lhs, IntWithUnit<T> rhs) { return (IntWithUnit<T>)lhs >= rhs; }

        /// <summary>オブジェクトが値を持つかどうかを判定します。</summary>
        public static bool operator true(IntWithUnit<T> i) { return i.HasValue; }
        /// <summary>オブジェクトが値を持つかどうかを判定します。</summary>
        public static bool operator false(IntWithUnit<T> i) { return !i.HasValue; }

        // 加減算はIntWithUnit<T>同士のみ(単位が異なる場合や、単位なしの場合は提供しない)
        /// <summary>
        /// 2つの単位付き数値を加算します。
        /// </summary>
        /// <param name="lhs">1つ目の単位付き数値</param>
        /// <param name="rhs">2つ目の単位付き数値</param>
        /// <returns>2つの単位付き数値を足し合わせた単位付き数値</returns>
        public static IntWithUnit<T> operator +(IntWithUnit<T> lhs, IntWithUnit<T> rhs)
        {
            if (!lhs.HasValue || !rhs.HasValue) return IntWithUnit<T>.NoValue;
            return new IntWithUnit<T>(lhs.Value + rhs.Value);
        }
        /// <summary>
        /// 2つの単位付き数値を減算します。
        /// </summary>
        /// <param name="lhs">1つ目の単位付き数値</param>
        /// <param name="rhs">2つ目の単位付き数値</param>
        /// <returns>1つ目の単位付き数値から2つ目の単位付き数値を引いた単位付き数値</returns>
        public static IntWithUnit<T> operator -(IntWithUnit<T> lhs, IntWithUnit<T> rhs)
        {
            if (!lhs.HasValue || !rhs.HasValue) return IntWithUnit<T>.NoValue;
            return new IntWithUnit<T>(lhs.Value - rhs.Value);
        }

        // 乗除算は片方のみがIntWithUnit<T>
        /// <summary>
        /// 単位付き数値と数値をかけ合わせます。
        /// </summary>
        /// <param name="lhs">単位付き数値</param>
        /// <param name="rhs">数値</param>
        /// <returns>単位付き数値に数値をかけた数値</returns>
        public static IntWithUnit<T> operator *(IntWithUnit<T> lhs, int rhs)
        {
            if (!lhs.HasValue) return IntWithUnit<T>.NoValue;
            return new IntWithUnit<T>(lhs.Value * rhs);
        }
        /// <summary>
        /// 数値と単位付き数値をかけ合わせます。
        /// </summary>
        /// <param name="lhs">数値</param>
        /// <param name="rhs">単位付き数値</param>
        /// <returns>数値に単位付き数値をかけた数値</returns>
        public static IntWithUnit<T> operator *(int? lhs, IntWithUnit<T> rhs)
        {
            if (!lhs.HasValue || !rhs.HasValue) return IntWithUnit<T>.NoValue;
            return new IntWithUnit<T>(lhs.Value * rhs.Value);
        }
        /// <summary>
        /// 単位付き数値を数値で割ります。
        /// </summary>
        /// <param name="lhs">単位付き数値</param>
        /// <param name="rhs">数値</param>
        /// <returns>単位付き数値を数値で割った単位付き数値</returns>
        public static IntWithUnit<T> operator /(IntWithUnit<T> lhs, int? rhs)
        {
            if (!lhs.HasValue || !rhs.HasValue) return IntWithUnit<T>.NoValue;
            return new IntWithUnit<T>(lhs.Value / rhs.Value);
        }
        /// <summary>
        /// 単位付き数値を数値で割った余りを計算します。
        /// </summary>
        /// <param name="lhs">単位付き数値</param>
        /// <param name="rhs">数値</param>
        /// <returns>単位付き数値を数値で割った余りの単位付き数値</returns>
        public static IntWithUnit<T> operator %(IntWithUnit<T> lhs, int? rhs)
        {
            if (!lhs.HasValue || !rhs.HasValue) return IntWithUnit<T>.NoValue;
            return new IntWithUnit<T>(lhs.Value % rhs.Value);
        }

        /// <summary>
        /// 単位付き数値の符号を反転します。
        /// </summary>
        /// <param name="value">単位付き数値</param>
        /// <returns>符号を反転した単位付き数値</returns>
        public static IntWithUnit<T> operator -(IntWithUnit<T> value)
        {
            if (!value.HasValue) return value;
            return new IntWithUnit<T>(-value.Value);
        }

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト</param>
        /// <returns>現在のオブジェクトがobjで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            if (!(obj is IntWithUnit<T>))
                return false;
            return this.Equals((IntWithUnit<T>)obj);
        }

        /// <summary>
        /// オブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>ハッシュコード</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            return 31 ^ this.HasValue.GetHashCode() ^ this.Value.GetHashCode();
        }

        /// <summary>
        /// このオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>このオブジェクトの文字列表現</returns>
        public override string ToString()
        {
            var type = "IntWithUnit<" + typeof(T).Name + ">";
            return this.HasValue ? type + ".NoValue"
                                 : type + "(" + this.Value + ")";
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
