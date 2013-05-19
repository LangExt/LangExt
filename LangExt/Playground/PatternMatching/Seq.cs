using System;

namespace LangExt.Playground.PatternMatching
{
    /// <summary>
    /// シーケンスをパターンマッチに対応させるための拡張メソッド置き場です。
    /// </summary>
    public static class Seq
    {
        /// <summary>
        /// シーケンスに対してパターンマッチさせます。
        /// </summary>
        /// <typeparam name="T">シーケンスの要素の型</typeparam>
        /// <typeparam name="U">パターンマッチの結果</typeparam>
        /// <param name="self">シーケンス</param>
        /// <param name="pattern">パターンマッチとその後の処理を表す関数</param>
        /// <returns>処理結果</returns>
        public static U Match<T, U>(this ISeq<T> self, Func<ISeq<T>, U> pattern)
        {
            return pattern(self);
        }
    }
}
