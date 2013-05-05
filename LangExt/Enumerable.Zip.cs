
using System;
using System.Collections.Generic;

namespace LangExt
{
    partial class Enumerable
    {
        /// <summary>2個のIEnumerableの要素1つ1つに対して、fを適用したIEnumerableを返します。</summary>
        public static IEnumerable<U> ZipWith<T1, T2, U>(this IEnumerable<T1> ie1, IEnumerable<T2> ie2, Func<T1, T2, U> f)
        {
            using (var itor1 = ie1.GetEnumerator())
            using (var itor2 = ie2.GetEnumerator())
            {
                while (itor1.MoveNext() && itor2.MoveNext())
                {
                    yield return f(itor1.Current, itor2.Current);
                }
            }
        }

        /// <summary>2個のIEnumerableをZipします。</summary>
        public static IEnumerable<Tuple<T1, T2>> Zip<T1, T2>(this IEnumerable<T1> ie1, IEnumerable<T2> ie2)
        {
            using (var itor1 = ie1.GetEnumerator())
            using (var itor2 = ie2.GetEnumerator())
            {
                while (itor1.MoveNext() && itor2.MoveNext())
                {
                    yield return Create.Tuple(itor1.Current, itor2.Current);
                }
            }
        }

        /// <summary>ZipされたIEnumerableを元に戻し、2個のIEnumerableのタプルとして返します。</summary>
        public static Tuple<IEnumerable<T1>, IEnumerable<T2>> Unzip<T1, T2>(this IEnumerable<Tuple<T1, T2>> self)
        {
            return Create.Tuple(self.Map(x => x._1()), self.Map(x => x._2()));
        }

        /// <summary>3個のIEnumerableの要素1つ1つに対して、fを適用したIEnumerableを返します。</summary>
        public static IEnumerable<U> ZipWith<T1, T2, T3, U>(this IEnumerable<T1> ie1, IEnumerable<T2> ie2, IEnumerable<T3> ie3, Func<T1, T2, T3, U> f)
        {
            using (var itor1 = ie1.GetEnumerator())
            using (var itor2 = ie2.GetEnumerator())
            using (var itor3 = ie3.GetEnumerator())
            {
                while (itor1.MoveNext() && itor2.MoveNext() && itor3.MoveNext())
                {
                    yield return f(itor1.Current, itor2.Current, itor3.Current);
                }
            }
        }

        /// <summary>3個のIEnumerableをZipします。</summary>
        public static IEnumerable<Tuple<T1, T2, T3>> Zip<T1, T2, T3>(this IEnumerable<T1> ie1, IEnumerable<T2> ie2, IEnumerable<T3> ie3)
        {
            using (var itor1 = ie1.GetEnumerator())
            using (var itor2 = ie2.GetEnumerator())
            using (var itor3 = ie3.GetEnumerator())
            {
                while (itor1.MoveNext() && itor2.MoveNext() && itor3.MoveNext())
                {
                    yield return Create.Tuple(itor1.Current, itor2.Current, itor3.Current);
                }
            }
        }

        /// <summary>ZipされたIEnumerableを元に戻し、3個のIEnumerableのタプルとして返します。</summary>
        public static Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>> Unzip<T1, T2, T3>(this IEnumerable<Tuple<T1, T2, T3>> self)
        {
            return Create.Tuple(self.Map(x => x._1()), self.Map(x => x._2()), self.Map(x => x._3()));
        }

        /// <summary>4個のIEnumerableの要素1つ1つに対して、fを適用したIEnumerableを返します。</summary>
        public static IEnumerable<U> ZipWith<T1, T2, T3, T4, U>(this IEnumerable<T1> ie1, IEnumerable<T2> ie2, IEnumerable<T3> ie3, IEnumerable<T4> ie4, Func<T1, T2, T3, T4, U> f)
        {
            using (var itor1 = ie1.GetEnumerator())
            using (var itor2 = ie2.GetEnumerator())
            using (var itor3 = ie3.GetEnumerator())
            using (var itor4 = ie4.GetEnumerator())
            {
                while (itor1.MoveNext() && itor2.MoveNext() && itor3.MoveNext() && itor4.MoveNext())
                {
                    yield return f(itor1.Current, itor2.Current, itor3.Current, itor4.Current);
                }
            }
        }

        /// <summary>4個のIEnumerableをZipします。</summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4>> Zip<T1, T2, T3, T4>(this IEnumerable<T1> ie1, IEnumerable<T2> ie2, IEnumerable<T3> ie3, IEnumerable<T4> ie4)
        {
            using (var itor1 = ie1.GetEnumerator())
            using (var itor2 = ie2.GetEnumerator())
            using (var itor3 = ie3.GetEnumerator())
            using (var itor4 = ie4.GetEnumerator())
            {
                while (itor1.MoveNext() && itor2.MoveNext() && itor3.MoveNext() && itor4.MoveNext())
                {
                    yield return Create.Tuple(itor1.Current, itor2.Current, itor3.Current, itor4.Current);
                }
            }
        }

        /// <summary>ZipされたIEnumerableを元に戻し、4個のIEnumerableのタプルとして返します。</summary>
        public static Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>> Unzip<T1, T2, T3, T4>(this IEnumerable<Tuple<T1, T2, T3, T4>> self)
        {
            return Create.Tuple(self.Map(x => x._1()), self.Map(x => x._2()), self.Map(x => x._3()), self.Map(x => x._4()));
        }

        /// <summary>5個のIEnumerableの要素1つ1つに対して、fを適用したIEnumerableを返します。</summary>
        public static IEnumerable<U> ZipWith<T1, T2, T3, T4, T5, U>(this IEnumerable<T1> ie1, IEnumerable<T2> ie2, IEnumerable<T3> ie3, IEnumerable<T4> ie4, IEnumerable<T5> ie5, Func<T1, T2, T3, T4, T5, U> f)
        {
            using (var itor1 = ie1.GetEnumerator())
            using (var itor2 = ie2.GetEnumerator())
            using (var itor3 = ie3.GetEnumerator())
            using (var itor4 = ie4.GetEnumerator())
            using (var itor5 = ie5.GetEnumerator())
            {
                while (itor1.MoveNext() && itor2.MoveNext() && itor3.MoveNext() && itor4.MoveNext() && itor5.MoveNext())
                {
                    yield return f(itor1.Current, itor2.Current, itor3.Current, itor4.Current, itor5.Current);
                }
            }
        }

        /// <summary>5個のIEnumerableをZipします。</summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5>> Zip<T1, T2, T3, T4, T5>(this IEnumerable<T1> ie1, IEnumerable<T2> ie2, IEnumerable<T3> ie3, IEnumerable<T4> ie4, IEnumerable<T5> ie5)
        {
            using (var itor1 = ie1.GetEnumerator())
            using (var itor2 = ie2.GetEnumerator())
            using (var itor3 = ie3.GetEnumerator())
            using (var itor4 = ie4.GetEnumerator())
            using (var itor5 = ie5.GetEnumerator())
            {
                while (itor1.MoveNext() && itor2.MoveNext() && itor3.MoveNext() && itor4.MoveNext() && itor5.MoveNext())
                {
                    yield return Create.Tuple(itor1.Current, itor2.Current, itor3.Current, itor4.Current, itor5.Current);
                }
            }
        }

        /// <summary>ZipされたIEnumerableを元に戻し、5個のIEnumerableのタプルとして返します。</summary>
        public static Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>> Unzip<T1, T2, T3, T4, T5>(this IEnumerable<Tuple<T1, T2, T3, T4, T5>> self)
        {
            return Create.Tuple(self.Map(x => x._1()), self.Map(x => x._2()), self.Map(x => x._3()), self.Map(x => x._4()), self.Map(x => x._5()));
        }

        /// <summary>6個のIEnumerableの要素1つ1つに対して、fを適用したIEnumerableを返します。</summary>
        public static IEnumerable<U> ZipWith<T1, T2, T3, T4, T5, T6, U>(this IEnumerable<T1> ie1, IEnumerable<T2> ie2, IEnumerable<T3> ie3, IEnumerable<T4> ie4, IEnumerable<T5> ie5, IEnumerable<T6> ie6, Func<T1, T2, T3, T4, T5, T6, U> f)
        {
            using (var itor1 = ie1.GetEnumerator())
            using (var itor2 = ie2.GetEnumerator())
            using (var itor3 = ie3.GetEnumerator())
            using (var itor4 = ie4.GetEnumerator())
            using (var itor5 = ie5.GetEnumerator())
            using (var itor6 = ie6.GetEnumerator())
            {
                while (itor1.MoveNext() && itor2.MoveNext() && itor3.MoveNext() && itor4.MoveNext() && itor5.MoveNext() && itor6.MoveNext())
                {
                    yield return f(itor1.Current, itor2.Current, itor3.Current, itor4.Current, itor5.Current, itor6.Current);
                }
            }
        }

        /// <summary>6個のIEnumerableをZipします。</summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>> Zip<T1, T2, T3, T4, T5, T6>(this IEnumerable<T1> ie1, IEnumerable<T2> ie2, IEnumerable<T3> ie3, IEnumerable<T4> ie4, IEnumerable<T5> ie5, IEnumerable<T6> ie6)
        {
            using (var itor1 = ie1.GetEnumerator())
            using (var itor2 = ie2.GetEnumerator())
            using (var itor3 = ie3.GetEnumerator())
            using (var itor4 = ie4.GetEnumerator())
            using (var itor5 = ie5.GetEnumerator())
            using (var itor6 = ie6.GetEnumerator())
            {
                while (itor1.MoveNext() && itor2.MoveNext() && itor3.MoveNext() && itor4.MoveNext() && itor5.MoveNext() && itor6.MoveNext())
                {
                    yield return Create.Tuple(itor1.Current, itor2.Current, itor3.Current, itor4.Current, itor5.Current, itor6.Current);
                }
            }
        }

        /// <summary>ZipされたIEnumerableを元に戻し、6個のIEnumerableのタプルとして返します。</summary>
        public static Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>> Unzip<T1, T2, T3, T4, T5, T6>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>> self)
        {
            return Create.Tuple(self.Map(x => x._1()), self.Map(x => x._2()), self.Map(x => x._3()), self.Map(x => x._4()), self.Map(x => x._5()), self.Map(x => x._6()));
        }

        /// <summary>7個のIEnumerableの要素1つ1つに対して、fを適用したIEnumerableを返します。</summary>
        public static IEnumerable<U> ZipWith<T1, T2, T3, T4, T5, T6, T7, U>(this IEnumerable<T1> ie1, IEnumerable<T2> ie2, IEnumerable<T3> ie3, IEnumerable<T4> ie4, IEnumerable<T5> ie5, IEnumerable<T6> ie6, IEnumerable<T7> ie7, Func<T1, T2, T3, T4, T5, T6, T7, U> f)
        {
            using (var itor1 = ie1.GetEnumerator())
            using (var itor2 = ie2.GetEnumerator())
            using (var itor3 = ie3.GetEnumerator())
            using (var itor4 = ie4.GetEnumerator())
            using (var itor5 = ie5.GetEnumerator())
            using (var itor6 = ie6.GetEnumerator())
            using (var itor7 = ie7.GetEnumerator())
            {
                while (itor1.MoveNext() && itor2.MoveNext() && itor3.MoveNext() && itor4.MoveNext() && itor5.MoveNext() && itor6.MoveNext() && itor7.MoveNext())
                {
                    yield return f(itor1.Current, itor2.Current, itor3.Current, itor4.Current, itor5.Current, itor6.Current, itor7.Current);
                }
            }
        }

        /// <summary>7個のIEnumerableをZipします。</summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>> Zip<T1, T2, T3, T4, T5, T6, T7>(this IEnumerable<T1> ie1, IEnumerable<T2> ie2, IEnumerable<T3> ie3, IEnumerable<T4> ie4, IEnumerable<T5> ie5, IEnumerable<T6> ie6, IEnumerable<T7> ie7)
        {
            using (var itor1 = ie1.GetEnumerator())
            using (var itor2 = ie2.GetEnumerator())
            using (var itor3 = ie3.GetEnumerator())
            using (var itor4 = ie4.GetEnumerator())
            using (var itor5 = ie5.GetEnumerator())
            using (var itor6 = ie6.GetEnumerator())
            using (var itor7 = ie7.GetEnumerator())
            {
                while (itor1.MoveNext() && itor2.MoveNext() && itor3.MoveNext() && itor4.MoveNext() && itor5.MoveNext() && itor6.MoveNext() && itor7.MoveNext())
                {
                    yield return Create.Tuple(itor1.Current, itor2.Current, itor3.Current, itor4.Current, itor5.Current, itor6.Current, itor7.Current);
                }
            }
        }

        /// <summary>ZipされたIEnumerableを元に戻し、7個のIEnumerableのタプルとして返します。</summary>
        public static Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>> Unzip<T1, T2, T3, T4, T5, T6, T7>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>> self)
        {
            return Create.Tuple(self.Map(x => x._1()), self.Map(x => x._2()), self.Map(x => x._3()), self.Map(x => x._4()), self.Map(x => x._5()), self.Map(x => x._6()), self.Map(x => x._7()));
        }

        /// <summary>8個のIEnumerableの要素1つ1つに対して、fを適用したIEnumerableを返します。</summary>
        public static IEnumerable<U> ZipWith<T1, T2, T3, T4, T5, T6, T7, T8, U>(this IEnumerable<T1> ie1, IEnumerable<T2> ie2, IEnumerable<T3> ie3, IEnumerable<T4> ie4, IEnumerable<T5> ie5, IEnumerable<T6> ie6, IEnumerable<T7> ie7, IEnumerable<T8> ie8, Func<T1, T2, T3, T4, T5, T6, T7, T8, U> f)
        {
            using (var itor1 = ie1.GetEnumerator())
            using (var itor2 = ie2.GetEnumerator())
            using (var itor3 = ie3.GetEnumerator())
            using (var itor4 = ie4.GetEnumerator())
            using (var itor5 = ie5.GetEnumerator())
            using (var itor6 = ie6.GetEnumerator())
            using (var itor7 = ie7.GetEnumerator())
            using (var itor8 = ie8.GetEnumerator())
            {
                while (itor1.MoveNext() && itor2.MoveNext() && itor3.MoveNext() && itor4.MoveNext() && itor5.MoveNext() && itor6.MoveNext() && itor7.MoveNext() && itor8.MoveNext())
                {
                    yield return f(itor1.Current, itor2.Current, itor3.Current, itor4.Current, itor5.Current, itor6.Current, itor7.Current, itor8.Current);
                }
            }
        }

        /// <summary>8個のIEnumerableをZipします。</summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> Zip<T1, T2, T3, T4, T5, T6, T7, T8>(this IEnumerable<T1> ie1, IEnumerable<T2> ie2, IEnumerable<T3> ie3, IEnumerable<T4> ie4, IEnumerable<T5> ie5, IEnumerable<T6> ie6, IEnumerable<T7> ie7, IEnumerable<T8> ie8)
        {
            using (var itor1 = ie1.GetEnumerator())
            using (var itor2 = ie2.GetEnumerator())
            using (var itor3 = ie3.GetEnumerator())
            using (var itor4 = ie4.GetEnumerator())
            using (var itor5 = ie5.GetEnumerator())
            using (var itor6 = ie6.GetEnumerator())
            using (var itor7 = ie7.GetEnumerator())
            using (var itor8 = ie8.GetEnumerator())
            {
                while (itor1.MoveNext() && itor2.MoveNext() && itor3.MoveNext() && itor4.MoveNext() && itor5.MoveNext() && itor6.MoveNext() && itor7.MoveNext() && itor8.MoveNext())
                {
                    yield return Create.Tuple(itor1.Current, itor2.Current, itor3.Current, itor4.Current, itor5.Current, itor6.Current, itor7.Current, itor8.Current);
                }
            }
        }

        /// <summary>ZipされたIEnumerableを元に戻し、8個のIEnumerableのタプルとして返します。</summary>
        public static Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>, Tuple<IEnumerable<T8>>> Unzip<T1, T2, T3, T4, T5, T6, T7, T8>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self)
        {
            return Create.Tuple(self.Map(x => x._1()), self.Map(x => x._2()), self.Map(x => x._3()), self.Map(x => x._4()), self.Map(x => x._5()), self.Map(x => x._6()), self.Map(x => x._7()), self.Map(x => x._8()));
        }

        /// <summary>9個のIEnumerableの要素1つ1つに対して、fを適用したIEnumerableを返します。</summary>
        public static IEnumerable<U> ZipWith<T1, T2, T3, T4, T5, T6, T7, T8, T9, U>(this IEnumerable<T1> ie1, IEnumerable<T2> ie2, IEnumerable<T3> ie3, IEnumerable<T4> ie4, IEnumerable<T5> ie5, IEnumerable<T6> ie6, IEnumerable<T7> ie7, IEnumerable<T8> ie8, IEnumerable<T9> ie9, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> f)
        {
            using (var itor1 = ie1.GetEnumerator())
            using (var itor2 = ie2.GetEnumerator())
            using (var itor3 = ie3.GetEnumerator())
            using (var itor4 = ie4.GetEnumerator())
            using (var itor5 = ie5.GetEnumerator())
            using (var itor6 = ie6.GetEnumerator())
            using (var itor7 = ie7.GetEnumerator())
            using (var itor8 = ie8.GetEnumerator())
            using (var itor9 = ie9.GetEnumerator())
            {
                while (itor1.MoveNext() && itor2.MoveNext() && itor3.MoveNext() && itor4.MoveNext() && itor5.MoveNext() && itor6.MoveNext() && itor7.MoveNext() && itor8.MoveNext() && itor9.MoveNext())
                {
                    yield return f(itor1.Current, itor2.Current, itor3.Current, itor4.Current, itor5.Current, itor6.Current, itor7.Current, itor8.Current, itor9.Current);
                }
            }
        }

        /// <summary>9個のIEnumerableをZipします。</summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IEnumerable<T1> ie1, IEnumerable<T2> ie2, IEnumerable<T3> ie3, IEnumerable<T4> ie4, IEnumerable<T5> ie5, IEnumerable<T6> ie6, IEnumerable<T7> ie7, IEnumerable<T8> ie8, IEnumerable<T9> ie9)
        {
            using (var itor1 = ie1.GetEnumerator())
            using (var itor2 = ie2.GetEnumerator())
            using (var itor3 = ie3.GetEnumerator())
            using (var itor4 = ie4.GetEnumerator())
            using (var itor5 = ie5.GetEnumerator())
            using (var itor6 = ie6.GetEnumerator())
            using (var itor7 = ie7.GetEnumerator())
            using (var itor8 = ie8.GetEnumerator())
            using (var itor9 = ie9.GetEnumerator())
            {
                while (itor1.MoveNext() && itor2.MoveNext() && itor3.MoveNext() && itor4.MoveNext() && itor5.MoveNext() && itor6.MoveNext() && itor7.MoveNext() && itor8.MoveNext() && itor9.MoveNext())
                {
                    yield return Create.Tuple(itor1.Current, itor2.Current, itor3.Current, itor4.Current, itor5.Current, itor6.Current, itor7.Current, itor8.Current, itor9.Current);
                }
            }
        }

        /// <summary>ZipされたIEnumerableを元に戻し、9個のIEnumerableのタプルとして返します。</summary>
        public static Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>, Tuple<IEnumerable<T8>, IEnumerable<T9>>> Unzip<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self)
        {
            return Create.Tuple(self.Map(x => x._1()), self.Map(x => x._2()), self.Map(x => x._3()), self.Map(x => x._4()), self.Map(x => x._5()), self.Map(x => x._6()), self.Map(x => x._7()), self.Map(x => x._8()), self.Map(x => x._9()));
        }

        /// <summary>10個のIEnumerableの要素1つ1つに対して、fを適用したIEnumerableを返します。</summary>
        public static IEnumerable<U> ZipWith<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U>(this IEnumerable<T1> ie1, IEnumerable<T2> ie2, IEnumerable<T3> ie3, IEnumerable<T4> ie4, IEnumerable<T5> ie5, IEnumerable<T6> ie6, IEnumerable<T7> ie7, IEnumerable<T8> ie8, IEnumerable<T9> ie9, IEnumerable<T10> ie10, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> f)
        {
            using (var itor1 = ie1.GetEnumerator())
            using (var itor2 = ie2.GetEnumerator())
            using (var itor3 = ie3.GetEnumerator())
            using (var itor4 = ie4.GetEnumerator())
            using (var itor5 = ie5.GetEnumerator())
            using (var itor6 = ie6.GetEnumerator())
            using (var itor7 = ie7.GetEnumerator())
            using (var itor8 = ie8.GetEnumerator())
            using (var itor9 = ie9.GetEnumerator())
            using (var itor10 = ie10.GetEnumerator())
            {
                while (itor1.MoveNext() && itor2.MoveNext() && itor3.MoveNext() && itor4.MoveNext() && itor5.MoveNext() && itor6.MoveNext() && itor7.MoveNext() && itor8.MoveNext() && itor9.MoveNext() && itor10.MoveNext())
                {
                    yield return f(itor1.Current, itor2.Current, itor3.Current, itor4.Current, itor5.Current, itor6.Current, itor7.Current, itor8.Current, itor9.Current, itor10.Current);
                }
            }
        }

        /// <summary>10個のIEnumerableをZipします。</summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IEnumerable<T1> ie1, IEnumerable<T2> ie2, IEnumerable<T3> ie3, IEnumerable<T4> ie4, IEnumerable<T5> ie5, IEnumerable<T6> ie6, IEnumerable<T7> ie7, IEnumerable<T8> ie8, IEnumerable<T9> ie9, IEnumerable<T10> ie10)
        {
            using (var itor1 = ie1.GetEnumerator())
            using (var itor2 = ie2.GetEnumerator())
            using (var itor3 = ie3.GetEnumerator())
            using (var itor4 = ie4.GetEnumerator())
            using (var itor5 = ie5.GetEnumerator())
            using (var itor6 = ie6.GetEnumerator())
            using (var itor7 = ie7.GetEnumerator())
            using (var itor8 = ie8.GetEnumerator())
            using (var itor9 = ie9.GetEnumerator())
            using (var itor10 = ie10.GetEnumerator())
            {
                while (itor1.MoveNext() && itor2.MoveNext() && itor3.MoveNext() && itor4.MoveNext() && itor5.MoveNext() && itor6.MoveNext() && itor7.MoveNext() && itor8.MoveNext() && itor9.MoveNext() && itor10.MoveNext())
                {
                    yield return Create.Tuple(itor1.Current, itor2.Current, itor3.Current, itor4.Current, itor5.Current, itor6.Current, itor7.Current, itor8.Current, itor9.Current, itor10.Current);
                }
            }
        }

        /// <summary>ZipされたIEnumerableを元に戻し、10個のIEnumerableのタプルとして返します。</summary>
        public static Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>, Tuple<IEnumerable<T8>, IEnumerable<T9>, IEnumerable<T10>>> Unzip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self)
        {
            return Create.Tuple(self.Map(x => x._1()), self.Map(x => x._2()), self.Map(x => x._3()), self.Map(x => x._4()), self.Map(x => x._5()), self.Map(x => x._6()), self.Map(x => x._7()), self.Map(x => x._8()), self.Map(x => x._9()), self.Map(x => x._10()));
        }

        /// <summary>11個のIEnumerableの要素1つ1つに対して、fを適用したIEnumerableを返します。</summary>
        public static IEnumerable<U> ZipWith<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U>(this IEnumerable<T1> ie1, IEnumerable<T2> ie2, IEnumerable<T3> ie3, IEnumerable<T4> ie4, IEnumerable<T5> ie5, IEnumerable<T6> ie6, IEnumerable<T7> ie7, IEnumerable<T8> ie8, IEnumerable<T9> ie9, IEnumerable<T10> ie10, IEnumerable<T11> ie11, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> f)
        {
            using (var itor1 = ie1.GetEnumerator())
            using (var itor2 = ie2.GetEnumerator())
            using (var itor3 = ie3.GetEnumerator())
            using (var itor4 = ie4.GetEnumerator())
            using (var itor5 = ie5.GetEnumerator())
            using (var itor6 = ie6.GetEnumerator())
            using (var itor7 = ie7.GetEnumerator())
            using (var itor8 = ie8.GetEnumerator())
            using (var itor9 = ie9.GetEnumerator())
            using (var itor10 = ie10.GetEnumerator())
            using (var itor11 = ie11.GetEnumerator())
            {
                while (itor1.MoveNext() && itor2.MoveNext() && itor3.MoveNext() && itor4.MoveNext() && itor5.MoveNext() && itor6.MoveNext() && itor7.MoveNext() && itor8.MoveNext() && itor9.MoveNext() && itor10.MoveNext() && itor11.MoveNext())
                {
                    yield return f(itor1.Current, itor2.Current, itor3.Current, itor4.Current, itor5.Current, itor6.Current, itor7.Current, itor8.Current, itor9.Current, itor10.Current, itor11.Current);
                }
            }
        }

        /// <summary>11個のIEnumerableをZipします。</summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IEnumerable<T1> ie1, IEnumerable<T2> ie2, IEnumerable<T3> ie3, IEnumerable<T4> ie4, IEnumerable<T5> ie5, IEnumerable<T6> ie6, IEnumerable<T7> ie7, IEnumerable<T8> ie8, IEnumerable<T9> ie9, IEnumerable<T10> ie10, IEnumerable<T11> ie11)
        {
            using (var itor1 = ie1.GetEnumerator())
            using (var itor2 = ie2.GetEnumerator())
            using (var itor3 = ie3.GetEnumerator())
            using (var itor4 = ie4.GetEnumerator())
            using (var itor5 = ie5.GetEnumerator())
            using (var itor6 = ie6.GetEnumerator())
            using (var itor7 = ie7.GetEnumerator())
            using (var itor8 = ie8.GetEnumerator())
            using (var itor9 = ie9.GetEnumerator())
            using (var itor10 = ie10.GetEnumerator())
            using (var itor11 = ie11.GetEnumerator())
            {
                while (itor1.MoveNext() && itor2.MoveNext() && itor3.MoveNext() && itor4.MoveNext() && itor5.MoveNext() && itor6.MoveNext() && itor7.MoveNext() && itor8.MoveNext() && itor9.MoveNext() && itor10.MoveNext() && itor11.MoveNext())
                {
                    yield return Create.Tuple(itor1.Current, itor2.Current, itor3.Current, itor4.Current, itor5.Current, itor6.Current, itor7.Current, itor8.Current, itor9.Current, itor10.Current, itor11.Current);
                }
            }
        }

        /// <summary>ZipされたIEnumerableを元に戻し、11個のIEnumerableのタプルとして返します。</summary>
        public static Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>, Tuple<IEnumerable<T8>, IEnumerable<T9>, IEnumerable<T10>, IEnumerable<T11>>> Unzip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self)
        {
            return Create.Tuple(self.Map(x => x._1()), self.Map(x => x._2()), self.Map(x => x._3()), self.Map(x => x._4()), self.Map(x => x._5()), self.Map(x => x._6()), self.Map(x => x._7()), self.Map(x => x._8()), self.Map(x => x._9()), self.Map(x => x._10()), self.Map(x => x._11()));
        }

        /// <summary>12個のIEnumerableの要素1つ1つに対して、fを適用したIEnumerableを返します。</summary>
        public static IEnumerable<U> ZipWith<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U>(this IEnumerable<T1> ie1, IEnumerable<T2> ie2, IEnumerable<T3> ie3, IEnumerable<T4> ie4, IEnumerable<T5> ie5, IEnumerable<T6> ie6, IEnumerable<T7> ie7, IEnumerable<T8> ie8, IEnumerable<T9> ie9, IEnumerable<T10> ie10, IEnumerable<T11> ie11, IEnumerable<T12> ie12, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> f)
        {
            using (var itor1 = ie1.GetEnumerator())
            using (var itor2 = ie2.GetEnumerator())
            using (var itor3 = ie3.GetEnumerator())
            using (var itor4 = ie4.GetEnumerator())
            using (var itor5 = ie5.GetEnumerator())
            using (var itor6 = ie6.GetEnumerator())
            using (var itor7 = ie7.GetEnumerator())
            using (var itor8 = ie8.GetEnumerator())
            using (var itor9 = ie9.GetEnumerator())
            using (var itor10 = ie10.GetEnumerator())
            using (var itor11 = ie11.GetEnumerator())
            using (var itor12 = ie12.GetEnumerator())
            {
                while (itor1.MoveNext() && itor2.MoveNext() && itor3.MoveNext() && itor4.MoveNext() && itor5.MoveNext() && itor6.MoveNext() && itor7.MoveNext() && itor8.MoveNext() && itor9.MoveNext() && itor10.MoveNext() && itor11.MoveNext() && itor12.MoveNext())
                {
                    yield return f(itor1.Current, itor2.Current, itor3.Current, itor4.Current, itor5.Current, itor6.Current, itor7.Current, itor8.Current, itor9.Current, itor10.Current, itor11.Current, itor12.Current);
                }
            }
        }

        /// <summary>12個のIEnumerableをZipします。</summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IEnumerable<T1> ie1, IEnumerable<T2> ie2, IEnumerable<T3> ie3, IEnumerable<T4> ie4, IEnumerable<T5> ie5, IEnumerable<T6> ie6, IEnumerable<T7> ie7, IEnumerable<T8> ie8, IEnumerable<T9> ie9, IEnumerable<T10> ie10, IEnumerable<T11> ie11, IEnumerable<T12> ie12)
        {
            using (var itor1 = ie1.GetEnumerator())
            using (var itor2 = ie2.GetEnumerator())
            using (var itor3 = ie3.GetEnumerator())
            using (var itor4 = ie4.GetEnumerator())
            using (var itor5 = ie5.GetEnumerator())
            using (var itor6 = ie6.GetEnumerator())
            using (var itor7 = ie7.GetEnumerator())
            using (var itor8 = ie8.GetEnumerator())
            using (var itor9 = ie9.GetEnumerator())
            using (var itor10 = ie10.GetEnumerator())
            using (var itor11 = ie11.GetEnumerator())
            using (var itor12 = ie12.GetEnumerator())
            {
                while (itor1.MoveNext() && itor2.MoveNext() && itor3.MoveNext() && itor4.MoveNext() && itor5.MoveNext() && itor6.MoveNext() && itor7.MoveNext() && itor8.MoveNext() && itor9.MoveNext() && itor10.MoveNext() && itor11.MoveNext() && itor12.MoveNext())
                {
                    yield return Create.Tuple(itor1.Current, itor2.Current, itor3.Current, itor4.Current, itor5.Current, itor6.Current, itor7.Current, itor8.Current, itor9.Current, itor10.Current, itor11.Current, itor12.Current);
                }
            }
        }

        /// <summary>ZipされたIEnumerableを元に戻し、12個のIEnumerableのタプルとして返します。</summary>
        public static Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>, Tuple<IEnumerable<T8>, IEnumerable<T9>, IEnumerable<T10>, IEnumerable<T11>, IEnumerable<T12>>> Unzip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self)
        {
            return Create.Tuple(self.Map(x => x._1()), self.Map(x => x._2()), self.Map(x => x._3()), self.Map(x => x._4()), self.Map(x => x._5()), self.Map(x => x._6()), self.Map(x => x._7()), self.Map(x => x._8()), self.Map(x => x._9()), self.Map(x => x._10()), self.Map(x => x._11()), self.Map(x => x._12()));
        }

        /// <summary>13個のIEnumerableの要素1つ1つに対して、fを適用したIEnumerableを返します。</summary>
        public static IEnumerable<U> ZipWith<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U>(this IEnumerable<T1> ie1, IEnumerable<T2> ie2, IEnumerable<T3> ie3, IEnumerable<T4> ie4, IEnumerable<T5> ie5, IEnumerable<T6> ie6, IEnumerable<T7> ie7, IEnumerable<T8> ie8, IEnumerable<T9> ie9, IEnumerable<T10> ie10, IEnumerable<T11> ie11, IEnumerable<T12> ie12, IEnumerable<T13> ie13, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> f)
        {
            using (var itor1 = ie1.GetEnumerator())
            using (var itor2 = ie2.GetEnumerator())
            using (var itor3 = ie3.GetEnumerator())
            using (var itor4 = ie4.GetEnumerator())
            using (var itor5 = ie5.GetEnumerator())
            using (var itor6 = ie6.GetEnumerator())
            using (var itor7 = ie7.GetEnumerator())
            using (var itor8 = ie8.GetEnumerator())
            using (var itor9 = ie9.GetEnumerator())
            using (var itor10 = ie10.GetEnumerator())
            using (var itor11 = ie11.GetEnumerator())
            using (var itor12 = ie12.GetEnumerator())
            using (var itor13 = ie13.GetEnumerator())
            {
                while (itor1.MoveNext() && itor2.MoveNext() && itor3.MoveNext() && itor4.MoveNext() && itor5.MoveNext() && itor6.MoveNext() && itor7.MoveNext() && itor8.MoveNext() && itor9.MoveNext() && itor10.MoveNext() && itor11.MoveNext() && itor12.MoveNext() && itor13.MoveNext())
                {
                    yield return f(itor1.Current, itor2.Current, itor3.Current, itor4.Current, itor5.Current, itor6.Current, itor7.Current, itor8.Current, itor9.Current, itor10.Current, itor11.Current, itor12.Current, itor13.Current);
                }
            }
        }

        /// <summary>13個のIEnumerableをZipします。</summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IEnumerable<T1> ie1, IEnumerable<T2> ie2, IEnumerable<T3> ie3, IEnumerable<T4> ie4, IEnumerable<T5> ie5, IEnumerable<T6> ie6, IEnumerable<T7> ie7, IEnumerable<T8> ie8, IEnumerable<T9> ie9, IEnumerable<T10> ie10, IEnumerable<T11> ie11, IEnumerable<T12> ie12, IEnumerable<T13> ie13)
        {
            using (var itor1 = ie1.GetEnumerator())
            using (var itor2 = ie2.GetEnumerator())
            using (var itor3 = ie3.GetEnumerator())
            using (var itor4 = ie4.GetEnumerator())
            using (var itor5 = ie5.GetEnumerator())
            using (var itor6 = ie6.GetEnumerator())
            using (var itor7 = ie7.GetEnumerator())
            using (var itor8 = ie8.GetEnumerator())
            using (var itor9 = ie9.GetEnumerator())
            using (var itor10 = ie10.GetEnumerator())
            using (var itor11 = ie11.GetEnumerator())
            using (var itor12 = ie12.GetEnumerator())
            using (var itor13 = ie13.GetEnumerator())
            {
                while (itor1.MoveNext() && itor2.MoveNext() && itor3.MoveNext() && itor4.MoveNext() && itor5.MoveNext() && itor6.MoveNext() && itor7.MoveNext() && itor8.MoveNext() && itor9.MoveNext() && itor10.MoveNext() && itor11.MoveNext() && itor12.MoveNext() && itor13.MoveNext())
                {
                    yield return Create.Tuple(itor1.Current, itor2.Current, itor3.Current, itor4.Current, itor5.Current, itor6.Current, itor7.Current, itor8.Current, itor9.Current, itor10.Current, itor11.Current, itor12.Current, itor13.Current);
                }
            }
        }

        /// <summary>ZipされたIEnumerableを元に戻し、13個のIEnumerableのタプルとして返します。</summary>
        public static Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>, Tuple<IEnumerable<T8>, IEnumerable<T9>, IEnumerable<T10>, IEnumerable<T11>, IEnumerable<T12>, IEnumerable<T13>>> Unzip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self)
        {
            return Create.Tuple(self.Map(x => x._1()), self.Map(x => x._2()), self.Map(x => x._3()), self.Map(x => x._4()), self.Map(x => x._5()), self.Map(x => x._6()), self.Map(x => x._7()), self.Map(x => x._8()), self.Map(x => x._9()), self.Map(x => x._10()), self.Map(x => x._11()), self.Map(x => x._12()), self.Map(x => x._13()));
        }

        /// <summary>14個のIEnumerableの要素1つ1つに対して、fを適用したIEnumerableを返します。</summary>
        public static IEnumerable<U> ZipWith<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U>(this IEnumerable<T1> ie1, IEnumerable<T2> ie2, IEnumerable<T3> ie3, IEnumerable<T4> ie4, IEnumerable<T5> ie5, IEnumerable<T6> ie6, IEnumerable<T7> ie7, IEnumerable<T8> ie8, IEnumerable<T9> ie9, IEnumerable<T10> ie10, IEnumerable<T11> ie11, IEnumerable<T12> ie12, IEnumerable<T13> ie13, IEnumerable<T14> ie14, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> f)
        {
            using (var itor1 = ie1.GetEnumerator())
            using (var itor2 = ie2.GetEnumerator())
            using (var itor3 = ie3.GetEnumerator())
            using (var itor4 = ie4.GetEnumerator())
            using (var itor5 = ie5.GetEnumerator())
            using (var itor6 = ie6.GetEnumerator())
            using (var itor7 = ie7.GetEnumerator())
            using (var itor8 = ie8.GetEnumerator())
            using (var itor9 = ie9.GetEnumerator())
            using (var itor10 = ie10.GetEnumerator())
            using (var itor11 = ie11.GetEnumerator())
            using (var itor12 = ie12.GetEnumerator())
            using (var itor13 = ie13.GetEnumerator())
            using (var itor14 = ie14.GetEnumerator())
            {
                while (itor1.MoveNext() && itor2.MoveNext() && itor3.MoveNext() && itor4.MoveNext() && itor5.MoveNext() && itor6.MoveNext() && itor7.MoveNext() && itor8.MoveNext() && itor9.MoveNext() && itor10.MoveNext() && itor11.MoveNext() && itor12.MoveNext() && itor13.MoveNext() && itor14.MoveNext())
                {
                    yield return f(itor1.Current, itor2.Current, itor3.Current, itor4.Current, itor5.Current, itor6.Current, itor7.Current, itor8.Current, itor9.Current, itor10.Current, itor11.Current, itor12.Current, itor13.Current, itor14.Current);
                }
            }
        }

        /// <summary>14個のIEnumerableをZipします。</summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IEnumerable<T1> ie1, IEnumerable<T2> ie2, IEnumerable<T3> ie3, IEnumerable<T4> ie4, IEnumerable<T5> ie5, IEnumerable<T6> ie6, IEnumerable<T7> ie7, IEnumerable<T8> ie8, IEnumerable<T9> ie9, IEnumerable<T10> ie10, IEnumerable<T11> ie11, IEnumerable<T12> ie12, IEnumerable<T13> ie13, IEnumerable<T14> ie14)
        {
            using (var itor1 = ie1.GetEnumerator())
            using (var itor2 = ie2.GetEnumerator())
            using (var itor3 = ie3.GetEnumerator())
            using (var itor4 = ie4.GetEnumerator())
            using (var itor5 = ie5.GetEnumerator())
            using (var itor6 = ie6.GetEnumerator())
            using (var itor7 = ie7.GetEnumerator())
            using (var itor8 = ie8.GetEnumerator())
            using (var itor9 = ie9.GetEnumerator())
            using (var itor10 = ie10.GetEnumerator())
            using (var itor11 = ie11.GetEnumerator())
            using (var itor12 = ie12.GetEnumerator())
            using (var itor13 = ie13.GetEnumerator())
            using (var itor14 = ie14.GetEnumerator())
            {
                while (itor1.MoveNext() && itor2.MoveNext() && itor3.MoveNext() && itor4.MoveNext() && itor5.MoveNext() && itor6.MoveNext() && itor7.MoveNext() && itor8.MoveNext() && itor9.MoveNext() && itor10.MoveNext() && itor11.MoveNext() && itor12.MoveNext() && itor13.MoveNext() && itor14.MoveNext())
                {
                    yield return Create.Tuple(itor1.Current, itor2.Current, itor3.Current, itor4.Current, itor5.Current, itor6.Current, itor7.Current, itor8.Current, itor9.Current, itor10.Current, itor11.Current, itor12.Current, itor13.Current, itor14.Current);
                }
            }
        }

        /// <summary>ZipされたIEnumerableを元に戻し、14個のIEnumerableのタプルとして返します。</summary>
        public static Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>, Tuple<IEnumerable<T8>, IEnumerable<T9>, IEnumerable<T10>, IEnumerable<T11>, IEnumerable<T12>, IEnumerable<T13>, IEnumerable<T14>>> Unzip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self)
        {
            return Create.Tuple(self.Map(x => x._1()), self.Map(x => x._2()), self.Map(x => x._3()), self.Map(x => x._4()), self.Map(x => x._5()), self.Map(x => x._6()), self.Map(x => x._7()), self.Map(x => x._8()), self.Map(x => x._9()), self.Map(x => x._10()), self.Map(x => x._11()), self.Map(x => x._12()), self.Map(x => x._13()), self.Map(x => x._14()));
        }

        /// <summary>15個のIEnumerableの要素1つ1つに対して、fを適用したIEnumerableを返します。</summary>
        public static IEnumerable<U> ZipWith<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U>(this IEnumerable<T1> ie1, IEnumerable<T2> ie2, IEnumerable<T3> ie3, IEnumerable<T4> ie4, IEnumerable<T5> ie5, IEnumerable<T6> ie6, IEnumerable<T7> ie7, IEnumerable<T8> ie8, IEnumerable<T9> ie9, IEnumerable<T10> ie10, IEnumerable<T11> ie11, IEnumerable<T12> ie12, IEnumerable<T13> ie13, IEnumerable<T14> ie14, IEnumerable<T15> ie15, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> f)
        {
            using (var itor1 = ie1.GetEnumerator())
            using (var itor2 = ie2.GetEnumerator())
            using (var itor3 = ie3.GetEnumerator())
            using (var itor4 = ie4.GetEnumerator())
            using (var itor5 = ie5.GetEnumerator())
            using (var itor6 = ie6.GetEnumerator())
            using (var itor7 = ie7.GetEnumerator())
            using (var itor8 = ie8.GetEnumerator())
            using (var itor9 = ie9.GetEnumerator())
            using (var itor10 = ie10.GetEnumerator())
            using (var itor11 = ie11.GetEnumerator())
            using (var itor12 = ie12.GetEnumerator())
            using (var itor13 = ie13.GetEnumerator())
            using (var itor14 = ie14.GetEnumerator())
            using (var itor15 = ie15.GetEnumerator())
            {
                while (itor1.MoveNext() && itor2.MoveNext() && itor3.MoveNext() && itor4.MoveNext() && itor5.MoveNext() && itor6.MoveNext() && itor7.MoveNext() && itor8.MoveNext() && itor9.MoveNext() && itor10.MoveNext() && itor11.MoveNext() && itor12.MoveNext() && itor13.MoveNext() && itor14.MoveNext() && itor15.MoveNext())
                {
                    yield return f(itor1.Current, itor2.Current, itor3.Current, itor4.Current, itor5.Current, itor6.Current, itor7.Current, itor8.Current, itor9.Current, itor10.Current, itor11.Current, itor12.Current, itor13.Current, itor14.Current, itor15.Current);
                }
            }
        }

        /// <summary>15個のIEnumerableをZipします。</summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IEnumerable<T1> ie1, IEnumerable<T2> ie2, IEnumerable<T3> ie3, IEnumerable<T4> ie4, IEnumerable<T5> ie5, IEnumerable<T6> ie6, IEnumerable<T7> ie7, IEnumerable<T8> ie8, IEnumerable<T9> ie9, IEnumerable<T10> ie10, IEnumerable<T11> ie11, IEnumerable<T12> ie12, IEnumerable<T13> ie13, IEnumerable<T14> ie14, IEnumerable<T15> ie15)
        {
            using (var itor1 = ie1.GetEnumerator())
            using (var itor2 = ie2.GetEnumerator())
            using (var itor3 = ie3.GetEnumerator())
            using (var itor4 = ie4.GetEnumerator())
            using (var itor5 = ie5.GetEnumerator())
            using (var itor6 = ie6.GetEnumerator())
            using (var itor7 = ie7.GetEnumerator())
            using (var itor8 = ie8.GetEnumerator())
            using (var itor9 = ie9.GetEnumerator())
            using (var itor10 = ie10.GetEnumerator())
            using (var itor11 = ie11.GetEnumerator())
            using (var itor12 = ie12.GetEnumerator())
            using (var itor13 = ie13.GetEnumerator())
            using (var itor14 = ie14.GetEnumerator())
            using (var itor15 = ie15.GetEnumerator())
            {
                while (itor1.MoveNext() && itor2.MoveNext() && itor3.MoveNext() && itor4.MoveNext() && itor5.MoveNext() && itor6.MoveNext() && itor7.MoveNext() && itor8.MoveNext() && itor9.MoveNext() && itor10.MoveNext() && itor11.MoveNext() && itor12.MoveNext() && itor13.MoveNext() && itor14.MoveNext() && itor15.MoveNext())
                {
                    yield return Create.Tuple(itor1.Current, itor2.Current, itor3.Current, itor4.Current, itor5.Current, itor6.Current, itor7.Current, itor8.Current, itor9.Current, itor10.Current, itor11.Current, itor12.Current, itor13.Current, itor14.Current, itor15.Current);
                }
            }
        }

        /// <summary>ZipされたIEnumerableを元に戻し、15個のIEnumerableのタプルとして返します。</summary>
        public static Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>, Tuple<IEnumerable<T8>, IEnumerable<T9>, IEnumerable<T10>, IEnumerable<T11>, IEnumerable<T12>, IEnumerable<T13>, IEnumerable<T14>, Tuple<IEnumerable<T15>>>> Unzip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self)
        {
            return Create.Tuple(self.Map(x => x._1()), self.Map(x => x._2()), self.Map(x => x._3()), self.Map(x => x._4()), self.Map(x => x._5()), self.Map(x => x._6()), self.Map(x => x._7()), self.Map(x => x._8()), self.Map(x => x._9()), self.Map(x => x._10()), self.Map(x => x._11()), self.Map(x => x._12()), self.Map(x => x._13()), self.Map(x => x._14()), self.Map(x => x._15()));
        }

        /// <summary>16個のIEnumerableの要素1つ1つに対して、fを適用したIEnumerableを返します。</summary>
        public static IEnumerable<U> ZipWith<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U>(this IEnumerable<T1> ie1, IEnumerable<T2> ie2, IEnumerable<T3> ie3, IEnumerable<T4> ie4, IEnumerable<T5> ie5, IEnumerable<T6> ie6, IEnumerable<T7> ie7, IEnumerable<T8> ie8, IEnumerable<T9> ie9, IEnumerable<T10> ie10, IEnumerable<T11> ie11, IEnumerable<T12> ie12, IEnumerable<T13> ie13, IEnumerable<T14> ie14, IEnumerable<T15> ie15, IEnumerable<T16> ie16, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> f)
        {
            using (var itor1 = ie1.GetEnumerator())
            using (var itor2 = ie2.GetEnumerator())
            using (var itor3 = ie3.GetEnumerator())
            using (var itor4 = ie4.GetEnumerator())
            using (var itor5 = ie5.GetEnumerator())
            using (var itor6 = ie6.GetEnumerator())
            using (var itor7 = ie7.GetEnumerator())
            using (var itor8 = ie8.GetEnumerator())
            using (var itor9 = ie9.GetEnumerator())
            using (var itor10 = ie10.GetEnumerator())
            using (var itor11 = ie11.GetEnumerator())
            using (var itor12 = ie12.GetEnumerator())
            using (var itor13 = ie13.GetEnumerator())
            using (var itor14 = ie14.GetEnumerator())
            using (var itor15 = ie15.GetEnumerator())
            using (var itor16 = ie16.GetEnumerator())
            {
                while (itor1.MoveNext() && itor2.MoveNext() && itor3.MoveNext() && itor4.MoveNext() && itor5.MoveNext() && itor6.MoveNext() && itor7.MoveNext() && itor8.MoveNext() && itor9.MoveNext() && itor10.MoveNext() && itor11.MoveNext() && itor12.MoveNext() && itor13.MoveNext() && itor14.MoveNext() && itor15.MoveNext() && itor16.MoveNext())
                {
                    yield return f(itor1.Current, itor2.Current, itor3.Current, itor4.Current, itor5.Current, itor6.Current, itor7.Current, itor8.Current, itor9.Current, itor10.Current, itor11.Current, itor12.Current, itor13.Current, itor14.Current, itor15.Current, itor16.Current);
                }
            }
        }

        /// <summary>16個のIEnumerableをZipします。</summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> Zip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IEnumerable<T1> ie1, IEnumerable<T2> ie2, IEnumerable<T3> ie3, IEnumerable<T4> ie4, IEnumerable<T5> ie5, IEnumerable<T6> ie6, IEnumerable<T7> ie7, IEnumerable<T8> ie8, IEnumerable<T9> ie9, IEnumerable<T10> ie10, IEnumerable<T11> ie11, IEnumerable<T12> ie12, IEnumerable<T13> ie13, IEnumerable<T14> ie14, IEnumerable<T15> ie15, IEnumerable<T16> ie16)
        {
            using (var itor1 = ie1.GetEnumerator())
            using (var itor2 = ie2.GetEnumerator())
            using (var itor3 = ie3.GetEnumerator())
            using (var itor4 = ie4.GetEnumerator())
            using (var itor5 = ie5.GetEnumerator())
            using (var itor6 = ie6.GetEnumerator())
            using (var itor7 = ie7.GetEnumerator())
            using (var itor8 = ie8.GetEnumerator())
            using (var itor9 = ie9.GetEnumerator())
            using (var itor10 = ie10.GetEnumerator())
            using (var itor11 = ie11.GetEnumerator())
            using (var itor12 = ie12.GetEnumerator())
            using (var itor13 = ie13.GetEnumerator())
            using (var itor14 = ie14.GetEnumerator())
            using (var itor15 = ie15.GetEnumerator())
            using (var itor16 = ie16.GetEnumerator())
            {
                while (itor1.MoveNext() && itor2.MoveNext() && itor3.MoveNext() && itor4.MoveNext() && itor5.MoveNext() && itor6.MoveNext() && itor7.MoveNext() && itor8.MoveNext() && itor9.MoveNext() && itor10.MoveNext() && itor11.MoveNext() && itor12.MoveNext() && itor13.MoveNext() && itor14.MoveNext() && itor15.MoveNext() && itor16.MoveNext())
                {
                    yield return Create.Tuple(itor1.Current, itor2.Current, itor3.Current, itor4.Current, itor5.Current, itor6.Current, itor7.Current, itor8.Current, itor9.Current, itor10.Current, itor11.Current, itor12.Current, itor13.Current, itor14.Current, itor15.Current, itor16.Current);
                }
            }
        }

        /// <summary>ZipされたIEnumerableを元に戻し、16個のIEnumerableのタプルとして返します。</summary>
        public static Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>, Tuple<IEnumerable<T8>, IEnumerable<T9>, IEnumerable<T10>, IEnumerable<T11>, IEnumerable<T12>, IEnumerable<T13>, IEnumerable<T14>, Tuple<IEnumerable<T15>, IEnumerable<T16>>>> Unzip<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, T16>>>> self)
        {
            return Create.Tuple(self.Map(x => x._1()), self.Map(x => x._2()), self.Map(x => x._3()), self.Map(x => x._4()), self.Map(x => x._5()), self.Map(x => x._6()), self.Map(x => x._7()), self.Map(x => x._8()), self.Map(x => x._9()), self.Map(x => x._10()), self.Map(x => x._11()), self.Map(x => x._12()), self.Map(x => x._13()), self.Map(x => x._14()), self.Map(x => x._15()), self.Map(x => x._16()));
        }


        /// <summary>IEnumerableに対して、0から始まる整数列をZipします。</summary>
        public static IEnumerable<Tuple<T1, int>> WithIndex<T1>(this IEnumerable<T1> self)
        {
            return self.Zip(InitInfinite(Func.Id));
        }

        /// <summary>2要素のタプルのIEnumerableに対して、0から始まる整数列を加えたタプルのIEnumerableとして返します。</summary>
        public static IEnumerable<Tuple<T1, T2, int>> WithIndex<T1, T2>(this IEnumerable<Tuple<T1, T2>> self)
        {
            foreach (var tpl in self.Zip(InitInfinite(Func.Id))) yield return tpl.Item1.Add(tpl.Item2);
        }

        /// <summary>3要素のタプルのIEnumerableに対して、0から始まる整数列を加えたタプルのIEnumerableとして返します。</summary>
        public static IEnumerable<Tuple<T1, T2, T3, int>> WithIndex<T1, T2, T3>(this IEnumerable<Tuple<T1, T2, T3>> self)
        {
            foreach (var tpl in self.Zip(InitInfinite(Func.Id))) yield return tpl.Item1.Add(tpl.Item2);
        }

        /// <summary>4要素のタプルのIEnumerableに対して、0から始まる整数列を加えたタプルのIEnumerableとして返します。</summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, int>> WithIndex<T1, T2, T3, T4>(this IEnumerable<Tuple<T1, T2, T3, T4>> self)
        {
            foreach (var tpl in self.Zip(InitInfinite(Func.Id))) yield return tpl.Item1.Add(tpl.Item2);
        }

        /// <summary>5要素のタプルのIEnumerableに対して、0から始まる整数列を加えたタプルのIEnumerableとして返します。</summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, int>> WithIndex<T1, T2, T3, T4, T5>(this IEnumerable<Tuple<T1, T2, T3, T4, T5>> self)
        {
            foreach (var tpl in self.Zip(InitInfinite(Func.Id))) yield return tpl.Item1.Add(tpl.Item2);
        }

        /// <summary>6要素のタプルのIEnumerableに対して、0から始まる整数列を加えたタプルのIEnumerableとして返します。</summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, int>> WithIndex<T1, T2, T3, T4, T5, T6>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>> self)
        {
            foreach (var tpl in self.Zip(InitInfinite(Func.Id))) yield return tpl.Item1.Add(tpl.Item2);
        }

        /// <summary>7要素のタプルのIEnumerableに対して、0から始まる整数列を加えたタプルのIEnumerableとして返します。</summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<int>>> WithIndex<T1, T2, T3, T4, T5, T6, T7>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>> self)
        {
            foreach (var tpl in self.Zip(InitInfinite(Func.Id))) yield return tpl.Item1.Add(tpl.Item2);
        }

        /// <summary>8要素のタプルのIEnumerableに対して、0から始まる整数列を加えたタプルのIEnumerableとして返します。</summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, int>>> WithIndex<T1, T2, T3, T4, T5, T6, T7, T8>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>> self)
        {
            foreach (var tpl in self.Zip(InitInfinite(Func.Id))) yield return tpl.Item1.Add(tpl.Item2);
        }

        /// <summary>9要素のタプルのIEnumerableに対して、0から始まる整数列を加えたタプルのIEnumerableとして返します。</summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, int>>> WithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9>>> self)
        {
            foreach (var tpl in self.Zip(InitInfinite(Func.Id))) yield return tpl.Item1.Add(tpl.Item2);
        }

        /// <summary>10要素のタプルのIEnumerableに対して、0から始まる整数列を加えたタプルのIEnumerableとして返します。</summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, int>>> WithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10>>> self)
        {
            foreach (var tpl in self.Zip(InitInfinite(Func.Id))) yield return tpl.Item1.Add(tpl.Item2);
        }

        /// <summary>11要素のタプルのIEnumerableに対して、0から始まる整数列を加えたタプルのIEnumerableとして返します。</summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, int>>> WithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11>>> self)
        {
            foreach (var tpl in self.Zip(InitInfinite(Func.Id))) yield return tpl.Item1.Add(tpl.Item2);
        }

        /// <summary>12要素のタプルのIEnumerableに対して、0から始まる整数列を加えたタプルのIEnumerableとして返します。</summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, int>>> WithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12>>> self)
        {
            foreach (var tpl in self.Zip(InitInfinite(Func.Id))) yield return tpl.Item1.Add(tpl.Item2);
        }

        /// <summary>13要素のタプルのIEnumerableに対して、0から始まる整数列を加えたタプルのIEnumerableとして返します。</summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, int>>> WithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13>>> self)
        {
            foreach (var tpl in self.Zip(InitInfinite(Func.Id))) yield return tpl.Item1.Add(tpl.Item2);
        }

        /// <summary>14要素のタプルのIEnumerableに対して、0から始まる整数列を加えたタプルのIEnumerableとして返します。</summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<int>>>> WithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14>>> self)
        {
            foreach (var tpl in self.Zip(InitInfinite(Func.Id))) yield return tpl.Item1.Add(tpl.Item2);
        }

        /// <summary>15要素のタプルのIEnumerableに対して、0から始まる整数列を加えたタプルのIEnumerableとして返します。</summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15, int>>>> WithIndex<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8, T9, T10, T11, T12, T13, T14, Tuple<T15>>>> self)
        {
            foreach (var tpl in self.Zip(InitInfinite(Func.Id))) yield return tpl.Item1.Add(tpl.Item2);
        }

    }
}