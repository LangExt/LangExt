using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LangExt
{
    partial class IEnumerableUtil
    {
        /// <summary>
        /// シーケンス内の指定されたインデックス位置にある要素を安全に返します。
        /// </summary>
        /// <typeparam name="TSource">source の要素の型。</typeparam>
        /// <param name="source">返される要素が含まれる IEnumerable<T>。</param>
        /// <param name="index">取得する要素の、0 から始まるインデックス。</param>
        /// <returns>ソース シーケンス内の指定された位置にある要素。</returns>
        public static Option<TSource> ElementAt<TSource>(this IEnumerable<TSource> source, int index)
        {
            if (0 <= index && index < source.Count())
                return Enumerable.ElementAt(source, index);
            else
                return Option<TSource>.None;
        }

        /// <summary>
        /// シーケンスの最初の要素を安全に返します。
        /// </summary>
        /// <typeparam name="TSource">source の要素の型。</typeparam>
        /// <param name="source">最初の要素を返す IEnumerable<T>。</param>
        /// <returns指定されたシーケンスの最初の要素。></returns>
        public static Option<TSource> First<TSource>(this IEnumerable<TSource> source)
        {
            if (source.Any())
                return Enumerable.First(source);
            else
                return Option<TSource>.None;
        }

        /// <summary>
        /// シーケンスの唯一の要素を返します。シーケンス内の要素が 1 つだけではない場合は、Noneを返します。
        /// </summary>
        /// <typeparam name="TSource">source の要素の型。</typeparam>
        /// <param name="source">1 つの要素を返す IEnumerable<T>。</param>
        /// <returns>入力シーケンスの 1 つの要素。</returns>
        public static Option<TSource> Single<TSource>(this IEnumerable<TSource> source)
        {
            var count = source.Count();
            if (0 < count && count < 2)
                return Enumerable.First(source);
            else
                return Option<TSource>.None;
        }
    }
}
