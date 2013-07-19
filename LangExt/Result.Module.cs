using System;

namespace LangExt
{
    partial class Result
    {
        /// <summary>
        /// (Result[T, _], U, ((U, T) → U)) → U
        /// </summary>
        public static U Fold<T, _, U>(this Result<T, _> self, U init, Func<U, T, U> f)
        {
            return self.Match(s => f(init, s), e => init);
        }

        /// <summary>
        /// (Result[_, T], U, ((U, T) → U)) → U
        /// </summary>
        public static U FoldFailure<_, T, U>(this Result<_, T> self, U init, Func<U, T, U> f)
        {
            return self.Match(s => init, e => f(init, e));
        }

        /// <summary>
        /// (Result[T, _], (T → U)) → Result[U, _]
        /// </summary>
        public static Result<U, _> Map<T, _, U>(this Result<T, _> self, Func<T, U> f)
        {
            return self.Match(s => Result.Success(f(s)), e => (Result<U, _>)Result.Failure(e));
        }

        /// <summary>
        /// (Result[_, T], (T → U)) → Result[_, U]
        /// </summary>
        public static Result<_, U> MapFailure<_, T, U>(this Result<_, T> self, Func<T, U> f)
        {
            return self.Match(s => Result.Success(s), e => (Result<_, U>)Result.Failure(f(e)));
        }

        /// <summary>
        /// (Result[T, _], (T → void)) → void
        /// </summary>
        public static void Iter<T, _>(this Result<T, _> self, Action<T> f)
        {
            self.Match(s => f(s), e => { });
        }

        /// <summary>
        /// (Result[T, _], (T → Unit)) → Unit
        /// </summary>
        public static Unit Iter<T, _>(this Result<T, _> self, Func<T, Unit> f)
        {
            return self.Match(s => f(s), e => Unit._);
        }

        /// <summary>
        /// (Result[_, T], (T → void)) → void
        /// </summary>
        public static void IterFailure<_, T>(this Result<_, T> self, Action<T> f)
        {
            self.Match(s => { }, e => f(e));
        }

        /// <summary>
        /// (Result[_, T], (T → Unit)) → Unit
        /// </summary>
        public static Unit IterFailure<_, T>(this Result<_, T> self, Func<T, Unit> f)
        {
            return self.Match(s => Unit._, e => f(e));
        }

        /// <summary>
        /// (Result[T, _], (T → bool)) → bool
        /// </summary>
        public static bool Exists<T, _>(this Result<T, _> self, Func<T, bool> pred)
        {
            return self.Match(s => pred(s), e => false);
        }

        /// <summary>
        /// (Result[_, T], (T → bool)) → bool
        /// </summary>
        public static bool ExistsFailure<_, T>(this Result<_, T> self, Func<T, bool> pred)
        {
            return self.Match(s => false, e => pred(e));
        }

        /// <summary>
        /// (Result[T, _], (T → bool)) → bool
        /// </summary>
        public static bool Forall<T, _>(this Result<T, _> self, Func<T, bool> pred)
        {
            return self.Match(s => pred(s), e => true);
        }

        /// <summary>
        /// (Result[_, T], (T → bool)) → bool
        /// </summary>
        public static bool ForallFailure<_, T>(this Result<_, T> self, Func<T, bool> pred)
        {
            return self.Match(s => true, e => pred(e));
        }

        /// <summary>
        /// Result[T, U] → int
        /// </summary>
        public static int Size<T, U>(this Result<T, U> self)
        {
            return self.Match(s => 1, e => 0);
        }

        /// <summary>
        /// Result[T, U] → int
        /// </summary>
        public static int SizeFailure<T, U>(this Result<T, U> self)
        {
            return self.Match(s => 0, e => 1);
        }

        /// <summary>
        /// Result[T, U] → int
        /// </summary>
        public static int Len<T, U>(this Result<T, U> self)
        {
            return self.Match(s => 1, e => 0);
        }

        /// <summary>
        /// Result[T, U] → int
        /// </summary>
        public static int LenFailure<T, U>(this Result<T, U> self)
        {
            return self.Match(s => 0, e => 1);
        }

        /// <summary>
        /// (Result[T, _], (T → bool)) → int
        /// </summary>
        public static int Count<T, _>(this Result<T, _> self, Func<T, bool> pred)
        {
            return self.Match(s => pred(s) ? 1 : 0, e => 0);
        }

        /// <summary>
        /// (Result[_, T], (T → bool)) → int
        /// </summary>
        public static int CountFailure<_, T>(this Result<_, T> self, Func<T, bool> pred)
        {
            return self.Match(s => 0, e => pred(e) ? 1 : 0);
        }

        /// <summary>
        /// Result[T, _] → T[]
        /// </summary>
        public static T[] ToArray<T, _>(this Result<T, _> self)
        {
            return self.Match(s => new[] { s }, f => new T[0]);
        }

        /// <summary>
        /// Result[_, T] → T[]
        /// </summary>
        public static T[] ToArrayFailure<_, T>(this Result<_, T> self)
        {
            return self.Match(s => new T[0], e => new[] { e });
        }

        /// <summary>
        /// Result[T, _] → ISeq[T]
        /// </summary>
        public static ISeq<T> ToSeq<T, _>(this Result<T, _> self)
        {
            return self.Match(Seq.Singleton, e => Seq.Empty<T>());
        }

        /// <summary>
        /// Result[_, T] → ISeq[T]
        /// </summary>
        public static ISeq<T> ToSeqFailure<_, T>(this Result<_, T> self)
        {
            return self.Match(s => Seq.Empty<T>(), Seq.Singleton);
        }

        /// <summary>
        /// Result[T, _] → Option[T]
        /// </summary>
        public static Option<T> ToOption<T, _>(this Result<T, _> self)
        {
            return self.Match(s => Option.Some(s), e => Option.None);
        }

        /// <summary>
        /// Result[_, T] → Option[T]
        /// </summary>
        public static Option<T> ToOptionFailure<_, T>(this Result<_, T> self)
        {
            return self.Match(s => Option.None, e => Option.Some(e));
        }

        /// <summary>
        /// Result[TSuccess, TFailure] → Result[TFailure, TSuccess]
        /// </summary>
        public static Result<TFailure, TSuccess> SwapResult<TSuccess, TFailure>(this Result<TSuccess, TFailure> self)
        {
            return self.Match(s => Result.Failure(s).Cast<TFailure>(), e => Result.Success(e));
        }
    }
}
