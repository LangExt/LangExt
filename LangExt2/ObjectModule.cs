using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LangExt2
{
    /// <summary>
    /// Objectに対する関数を提供します。
    /// </summary>
    public static class ObjectModule
    {
        /// <summary>
        /// オブジェクトがnullかどうかを判定します。
        /// </summary>
        /// <param name="self">判定の対象</param>
        /// <returns>オブジェクトがnullの場合true、nullではない場合false</returns>
        public static bool IsNull(this object self)
        {
            return self == null;
        }

        /// <summary>
        /// オブジェクトがnullかどうかを判定します。
        /// </summary>
        /// <param name="self">判定の対象</param>
        /// <returns>オブジェクトがnullの場合false、nullではない場合true</returns>
        public static bool IsNotNull(this object self)
        {
            return self != null;
        }

        /// <summary>
        /// null安全にEqualsを呼び出します。
        /// 関数を値として使用したい場合は、こちらではなくEqを使用してください。
        /// </summary>
        public static bool IsEqualTo(this object self, object other)
        {
            return self == null ? other == null : self.Equals(other);
        }

        /// <summary>
        /// null安全にEqualsを呼び出し、結果を反転させます。
        /// 関数を値として使用したい場合は、こちらではなくNotEqを使用してください。
        /// </summary>
        public static bool IsNotEqualTo(this object self, object other)
        {
            return self.IsEqualTo(other) == false;
        }

        /// <summary>
        /// 関数としてnull安全なEqualsの呼び出しを行いたい場合に使用します。
        /// </summary>
        public static bool Eq(object a, object b)
        {
            return a.IsEqualTo(b);
        }

        /// <summary>
        /// 関数としてnull安全なEqualsの呼び出しと否定を行いたい場合に使用します。
        /// </summary>
        public static bool NotEq(object a, object b)
        {
            return a.IsNotEqualTo(b);
        }

        /// <summary>
        /// null安全にToStringを呼び出します。
        /// </summary>
        public static string ToStr(this object self)
        {
            return (self ?? "").ToString();
        }

        /// <summary>
        /// bool値によってOptionを生成します。
        /// </summary>
        public static Option<T> ToOptionIf<T>(this T self, bool cond)
        {
            return cond ? Option.Some(self) : Option<T>.None;
        }

        /// <summary>
        /// bool値によってOptionを生成します。
        /// </summary>
        public static Option<T> ToOptionIf<T>(this T self, Func<bool> cond)
        {
            return cond() ? Option.Some(self) : Option<T>.None;
        }

        /// <summary>
        /// bool値によってResultを生成します。
        /// </summary>
        public static Result<T, Unit> ToResultIf<T>(this T self, bool cond)
        {
            if (cond)
                return Result.Success(self);
            else
                return Result.Failure(Unit._);
        }

        /// <summary>
        /// bool値によってResultを生成します。
        /// </summary>
        public static Result<T, Unit> ToResultIf<T>(this T self, Func<bool> cond)
        {
            if (cond())
                return Result.Success(self);
            else
                return Result.Failure(Unit._);
        }
    }
}
