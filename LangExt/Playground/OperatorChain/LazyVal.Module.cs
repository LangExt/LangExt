using System;

namespace LangExt.Playground.OperatorChain
{
    /// <summary>LazyValに対する関数を提供します。</summary>
    public static partial class LazyVal
    {
        /// <summary>
        /// LazyVal[T] → (T → LazyVal[U]) → LazyVal[U]
        /// </summary>
        public static LazyVal<U> Bind<T, U>(this LazyVal<T> self, Func<T, LazyVal<U>> f)
        {
            return new LazyVal<U>(() => f(self.Value).Value);
        }
 
        /// <summary>
        /// LazyVal[T] → (T → U) → LazyVal[U]
        /// </summary>
        public static LazyVal<U> Map<T, U>(this LazyVal<T> self, Func<T, U> f)
        {
            return new LazyVal<U>(() => f(self.Value));
        }
 
        /// <summary>
        /// LazyVal[T] → LazyVal[T] → LazyVal[T]
        /// </summary>
        public static LazyVal<T> OrElse<T>(this LazyVal<T> self, LazyVal<T> v)
        {
            if (self.AlreadyComputed) return self;
            else return v;
        }
 
        /// <summary>
        /// LazyVal[LazyVal[T]] → LazyVal[T]
        /// </summary>
        public static LazyVal<T> Unwrap<T>(this LazyVal<LazyVal<T>> self)
        {
            return self.Value;
        }
    }
}
