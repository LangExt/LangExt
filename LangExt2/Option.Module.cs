using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LangExt2
{
    partial class Option
    {
        /// <summary>
        /// (bool, T) → Option[T]
        /// </summary>
        public static Option<T> SomeIf<T>(bool cond, T value)
        {
            return value.ToOptionIf(cond);
        }

        /// <summary>
        /// (Option[T], U, T → U) → U
        /// </summary>
        public static U Maybe<T, U>(this Option<T> self, U defaultValue, Func<T, U> f)
        {
            return self.Match(f, () => defaultValue);
        }

        /// <summary>
        /// (Option[T], U, ((U, T) → U)) → U
        /// </summary>
        public static U Fold<T, U>(this Option<T> self, U init, Func<U, T, U> f)
        {
            return self.Match(v => f(init, v), () => init);
        }

        /// <summary>
        /// (Option[T], (T → bool)) → Option[T]
        /// </summary>
        public static Option<T> Filter<T>(this Option<T> self, Func<T, bool> pred)
        {
            return self.Match(v => pred(v) ? self : Option<T>.None, () => Option<T>.None);
        }

        /// <summary>
        /// (Option[T], (T → U)) → Option[U]
        /// </summary>
        public static Option<U> Map<T, U>(this Option<T> self, Func<T, U> f)
        {
            return self.Match(v => Option.Some(f(v)), () => Option<U>.None);
        }

        /// <summary>
        /// (Option[T], (T → void)) → void
        /// </summary>
        public static void Iter<T>(this Option<T> self, Action<T> act)
        {
            self.Match(v => act(v), () => { });
        }

        /// <summary>
        /// (Option[T], (T → bool)) → bool
        /// </summary>
        public static bool Exists<T>(this Option<T> self, Func<T, bool> pred)
        {
            return self.Match(v => pred(v), () => false);
        }

        /// <summary>
        /// (Option[T], (T → bool)) → bool
        /// </summary>
        public static bool Forall<T>(this Option<T> self, Func<T, bool> pred)
        {
            return self.Match(v => pred(v), () => true);
        }

        /// <summary>
        /// Option[T] → int
        /// </summary>
        public static int Length<T>(this Option<T> self)
        {
            return self.Match(_ => 1, () => 0);
        }

        /// <summary>
        /// (Option[T], (T → bool)) → int
        /// </summary>
        public static int Count<T>(this Option<T> self, Func<T, bool> pred)
        {
            return self.Match(v => pred(v) ? 1 : 0, () => 0);
        }

        /// <summary>
        /// Option[T] → T[]
        /// </summary>
        public static T[] ToArray<T>(this Option<T> self)
        {
            return self.Match(v => new[] { v }, () => new T[0]);
        }

        /// <summary>
        /// Option[T] → List[T]
        /// </summary>
        public static List<T> ToList<T>(this Option<T> self)
        {
            return self.Match(v => new List<T> { v }, () => new List<T>());
        }
    }
}
