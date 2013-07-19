using System;
using System.ComponentModel;

namespace LangExt
{
    /// <summary>
    /// プレースホルダーとして使用することを前提とした型です。
    /// </summary>
    public enum Placeholder { }

    /// <summary>
    /// 値がないことを表すための型です。
    /// </summary>
    public struct Unit
    {
        /// <summary>
        /// Unitの値を取得します。
        /// </summary>
        public readonly static Unit _ = new Unit();

        /// <summary>
        /// Unitは常に等しいため、この演算子は常にfalseを返します。
        /// </summary>
        public static bool operator ==(Unit lhs, Unit rhs) { return true; }

        /// <summary>
        /// Unitは常に等しいため、この演算子は常にfalseを返します。
        /// </summary>
        public static bool operator !=(Unit lhs, Unit rhs) { return false; }

        /// <summary>
        /// 引数がUnitかどうかを判定します。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) { return obj is Unit; }

        /// <summary>
        /// このオブジェクトを表すハッシュ値を取得します。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() { return 13; }

        /// <summary>
        /// このオブジェクトの文字列表現を取得します。
        /// </summary>
        public override string ToString() { return "()"; }

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
    /// Unitに対する関数を提供します。
    /// </summary>
    public static class UnitModule
    {
        /// <summary>
        /// 値を無視してUnitを返します。
        /// </summary>
        public static Unit Ignore<T>(this T self) { return Unit._; }

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
