using System;

namespace LangExt.Playground.PatternMatching
{
    /// <summary>
    /// パターンマッチの結果を格納するクラスです。
    /// </summary>
    /// <typeparam name="TResult">パターンマッチの結果の型</typeparam>
    /// <typeparam name="TNext">次のパターンに渡す値の型</typeparam>
    public sealed class _<TResult, TNext>
    {
        /// <summary>パターンマッチの結果</summary>
        public TResult Result { get; private set; }
        /// <summary>次のパターンに渡す値</summary>
        public TNext Next { get; private set; }

        internal _(TResult result, TNext next)
        {
            Result = result;
            Next = next;
        }
    }
    internal static class _
    {
        internal static _<TResult, TNext> Create<TResult, TNext>(Tuple<TResult, TNext> tpl)
        {
            return new _<TResult, TNext>(tpl.Fst(), tpl.Snd());
        }

        internal static _<TResult, TNext> Create<TResult, TNext>(TResult result, TNext next)
        {
            return new _<TResult, TNext>(result, next);
        }
    }

    /// <summary>
    /// パターンを表すインターフェイスです。
    /// </summary>
    /// <typeparam name="T">パターンにマッチするかどうかを検査する値の型</typeparam>
    /// <typeparam name="U">パターンにマッチした場合の結果の型</typeparam>
    public interface IPattern<T, U>
    {
        /// <summary>
        /// 引数をこのオブジェクトが表すパターンにマッチするかどうかを調べ、結果を返します。
        /// </summary>
        /// <param name="value">パターンマッチの対象</param>
        /// <returns>パターンにマッチした場合、結果の値と次のパターンに渡す値をSomeで包んだもの。マッチしなかった場合、None</returns>
        Option<_<U, T>> Match(T value);
    }

    /// <summary>
    /// IPatternのデフォルトの実装です。
    /// 関数からIPatternを構築します。
    /// </summary>
    /// <typeparam name="T">パターンにマッチするかどうかを検査する値の型</typeparam>
    /// <typeparam name="U">パターンにマッチした場合の結果の型</typeparam>
    public sealed class Pattern<T, U> : IPattern<T, U>
    {
        readonly Func<T, Option<_<U, T>>> f;

        /// <summary>関数からオブジェクトを構築します。</summary>
        public Pattern(Func<T, Option<_<U, T>>> f) { this.f = f; }

        /// <summary>
        /// 引数をこのオブジェクトが表すパターンにマッチするかどうかを調べ、結果を返します。
        /// </summary>
        /// <param name="value">パターンマッチの対象</param>
        /// <returns>パターンにマッチした場合、結果の値と次のパターンに渡す値をSomeで包んだもの。マッチしなかった場合、None</returns>
        public Option<_<U, T>> Match(T value) { return f(value); }
    }

    /// <summary>
    /// パターンに対するユーティリティ関数置き場です。
    /// </summary>
    public static partial class Pattern
    {
        /// <summary>
        /// パターンが一致した際の処理を登録します。
        /// </summary>
        /// <typeparam name="T">パターンにマッチするかどうかを検査する値の型</typeparam>
        /// <typeparam name="U">パターンにマッチした場合の結果の型</typeparam>
        /// <typeparam name="V">処理の結果の型</typeparam>
        /// <param name="self">パターン</param>
        /// <param name="f">パターンが一致した際の処理</param>
        /// <returns>処理の結果の型(パターンが一致しなかった場合はNone)</returns>
        public static Func<T, Option<V>> Then<T, U, V>(this IPattern<T, U> self, Func<U, V> f)
        {
            return xs =>
            {
                return
                    from _1 in self.Match(xs)
                    select f(_1.Result);
            };
        }

        /// <summary>
        /// パターンが一致した際の処理を登録します。
        /// </summary>
        /// <typeparam name="T">パターンにマッチするかどうかを検査する値の型</typeparam>
        /// <typeparam name="U">パターンにマッチした場合の結果の型</typeparam>
        /// <typeparam name="V">処理の結果の型</typeparam>
        /// <param name="self">パターン</param>
        /// <param name="f">パターンが一致した際の処理</param>
        /// <param name="otherwise">パターンが一致しなかった際の処理</param>
        /// <returns>処理の結果の型</returns>
        public static Func<T, V> Then<T, U, V>(this IPattern<T, U> self, Func<U, V> f, Func<T, V> otherwise)
        {
            return xs => self.Then(f)(xs).Match(x => x, () => otherwise(xs));
        }
    }
}
