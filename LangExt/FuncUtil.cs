using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LangExt
{
    /// <summary>
    /// 関数に対する便利関数を提供します。
    /// </summary>
    public static class FuncUtil
    {
        /// <summary>
        /// オブジェクトのアイデンティティ値を返します。
        /// </summary>
        /// <typeparam name="T">対象のオブジェクトの型を指定します。</typeparam>
        /// <param name="t">対象のオブジェクトを指定します。</param>
        /// <returns>指定されたオブジェクトのアイデンティティ値です。</returns>
        public static T Id<T>(T t)
        {
            return t;
        }

        public static Func<T1, Option<T2>> Maybe<T1, T2>(Func<T1, T2> f)
        {
            return t1 =>
            {
                try
                {
                    return new Option<T2>(f(t1));
                }
                catch
                {
                    return Option<T2>.None;
                }
            };
        }

        public static Func<T1, Either<Exception, T2>> Either<T1, T2>(Func<T1, T2> f)
        {
            return t1 =>
            {
                try
                {
                    return new Either<Exception,T2>(f(t1));
                }
                catch(Exception ex)
                {
                    return new Either<Exception, T2>(ex);
                }
            };
        }
    }
}
