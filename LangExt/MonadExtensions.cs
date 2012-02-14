using System;
using System.Collections.Generic;
using System.Text;

namespace LangExt
{
    public static class MonadExtensions
    {
        public static Option<U> Select<T,U>(this Option<T> m, Func<T, U> k)
        {
            return m.Match(some => k(some) , _ => Option<U>.None);
        }

        public static Option<U> SelectMany<T, U>(this Option<T> m, Func<T, Option<U>> k)
        {
            return m.Bind(k);
        }

        public static Option<V> SelectMany<T, U, V>(this Option<T> m, Func<T, Option<U>> k, Func<T, U, V> s)
        {
            return m.Bind(x => k(x).Bind(y => new Option<V>(s(x, y))));
        }

        public static Either<TLeft, TRight2> Select<TLeft, TRight, TRight2>(this Either<TLeft, TRight> m, Func<TRight, TRight2> k)
        {
            return m.Match<Either<TLeft, TRight2>>(e => Either.Left(e), some => Either.Right(k(some)));
        }

        public static Either<TLeft, TRight2> SelectMany<TLeft, TRight, TRight2>(this Either<TLeft, TRight> m, Func<TRight, Either<TLeft, TRight2>> k)
        {
            return m.Bind(k);
        }

        public static Either<TLeft, TRight3> SelectMany<TLeft, TRight, TRight2, TRight3>(this Either<TLeft, TRight> m, Func<TRight, Either<TLeft, TRight2>> k, Func<TRight, TRight2, TRight3> s)
        {
            return m.Bind( x => k(x).Bind(y => Either.Right(s(x, y))));
        }  
    }
}
