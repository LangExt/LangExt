using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace LangExt2
{
    /// <summary>
    /// IComparable[T]に対する操作を提供します。
    /// </summary>
    public static class Comparable
    {
        /// <summary>
        /// null安全にCompareToを呼び出します。
        /// selfがnullだった場合、otherがnullなら0を、そうでないなら-1を返します。
        /// これは、nullを最も小さい値として扱うことを意味します。
        /// この挙動との整合性を取るために、ComparaToに渡されたオブジェクトがnullだった場合は1以上の数を返すように実装してください。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static int RawCmp<T>(this T self, T other) where T : IComparable<T>
        {
            if (self.IsNull())
                return other.IsNull() ? 0 : -1;
            return self.CompareTo(other);
        }

        /// <summary>
        /// null安全にCompareToを呼び出し、結果をCompareResultに変換して返します。
        /// selfがnullだった場合、otherがnullならEQを、そうでないならLTを返します。
        /// これは、nullを最も小さい値として扱うことを意味します。
        /// この挙動との整合性を取るために、ComparaToに渡されたオブジェクトがnullだった場合は1以上の数を返すように実装してください。
        /// </summary>
        public static CompareResult Cmp<T>(this T self, T other) where T : IComparable<T>
        {
            return CompareResult.OfInt(self.RawCmp(other));
        }

        /// <summary>
        /// Cmpの結果です。
        /// </summary>
        public sealed class CompareResult
        {
            /// <summary>
            /// 左側のオブジェクトが右側のオブジェクトよりも小さいことを表します。
            /// </summary>
            public static readonly CompareResult LT = new CompareResult();
            /// <summary>
            /// 左側のオブジェクトと右側のオブジェクトが同じ大きさを持つことを表します。
            /// </summary>
            public static readonly CompareResult EQ = new CompareResult();
            /// <summary>
            /// 左側のオブジェクトが右側のオブジェクトよりも大きいことを表します。
            /// </summary>
            public static readonly CompareResult GT = new CompareResult();
            CompareResult() { }

            /// <summary>
            /// 数値からCompareResultオブジェクトに変換します。
            /// </summary>
            public static CompareResult OfInt(int rawCmp)
            {
                if (rawCmp == 0)
                    return EQ;
                return rawCmp < 0 ? LT : GT;
            }

            /// <summary>
            /// 結果に対して場合分けを行います。
            /// </summary>
            public T Match<T>(Func<T> ifLT, Func<T> ifEQ, Func<T> ifGT)
            {
                if (this == EQ) return ifEQ();
                return this == LT ? ifLT() : ifGT();
            }

            /// <summary>
            /// このオブジェクトがobjと等しいかどうかを返します。
            /// </summary>
            [EditorBrowsable(EditorBrowsableState.Never)]
            public override bool Equals(object obj)
            {
                var other = obj as CompareResult;
                if (other == null)
                    return false;
                return this == other;
            }

            /// <summary>
            /// このオブジェクトのハッシュ値を計算します。
            /// </summary>
            [EditorBrowsable(EditorBrowsableState.Never)]
            public override int GetHashCode()
            {
                return this.Match(() => -1, () => 0, () => 1);
            }

            /// <summary>
            /// このオブジェクトを文字列表現に変換します。
            /// </summary>
            [EditorBrowsable(EditorBrowsableState.Never)]
            public override string ToString()
            {
                return this.Match(() => "LT", () => "EQ", () => "GT");
            }
        }
    }
}
