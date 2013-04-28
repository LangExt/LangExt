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
        /// 自身がxと等しい場合Noneを返し、そうでない場合Someを返します。
        /// 自身がnullかつxがnullではなかったときのみ、このメソッドは例外を投げます。
        /// 自身もxもnullだった場合は、Noneを返します。
        /// </summary>
        public static Option<T> NoneIf<T>(this T self, T x)
        {
            return self.IsEqualTo(x) ? Option<T>.None : Option.Some(self);
        }

        /// <summary>
        /// predがtrueを返す場合Noneを返し、falseを返す場合Someを返します。
        /// 自身がnullかつpredがfalseを返した場合は、例外を投げます。
        /// また、predが例外を投げた場合も例外を投げます。
        /// 自身がnullでpredがtrueを返した場合は、Noneを返します。
        /// </summary>
        public static Option<T> NoneIf<T>(this T self, Func<bool> pred)
        {
            return pred() ? Option<T>.None : Option.Some(self);
        }

        /// <summary>
        /// 自身がnullの場合のみNoneを返し、それ以外の場合はSomeを返します。
        /// </summary>
        public static Option<T> NoneIfNull<T>(this T self)
        {
            return self.IsNull() ? Option<T>.None : Option.Some(self);
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
