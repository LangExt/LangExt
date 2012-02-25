using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LangExt
{
    public static class FuncUtil
    {
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
