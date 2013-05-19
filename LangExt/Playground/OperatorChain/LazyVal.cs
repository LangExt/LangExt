using System;
using System.ComponentModel;

namespace LangExt.Playground.OperatorChain
{
    /// <summary>
    /// 関数の実行結果を保存する簡単なラッパーです。
    /// 関数は一度しか呼び出されず、二回目以降は一回目の結果を保存した値を使います。
    /// </summary>
    /// <remarks>
    /// System.Lazy[T]とほとんど同じですが、こちらはマルチスレッドに対応していない点が異なります。
    /// また、関数からの暗黙型変換と、保持する結果の型への暗黙型変換を提供しているため、より自然に使用できます。
    /// </remarks>
    /// <typeparam name="T">保持する結果の型</typeparam>
    public sealed class LazyVal<T>
    {
        readonly Func<T> f;
        bool hasValue = false;
        T value;
 
        /// <summary>
        /// 関数を元にオブジェクトを構築します。
        /// </summary>
        public LazyVal(Func<T> f) { this.f = f; }
 
        /// <summary>
        /// すでに関数が実行され、結果が保持されているかどうかを取得します。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool AlreadyComputed { get { return hasValue; } }

        /// <summary>
        /// 明示的に関数を実行します。
        /// 通常は単にValueプロパティを使う方がいいですが、
        /// 本当に必要になるまで実行が遅延されると困る場合(最悪、ある場所までには計算を終えていたい場合など)はこのメソッドを使います。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Compute()
        {
            var _ = Value;
        }
 
        /// <summary>
        /// (まだ関数が実行されていなければ実行し、)このオブジェクトが保持する値を取得します。
        /// </summary>
        public T Value
        {
            get
            {
                if (hasValue) return value;
                value = f();
                hasValue = true;
                return value;
            }
        }
 
        /// <summary>
        /// LazyVal[T]からTに暗黙変換します。
        /// </summary>
        public static implicit operator T(LazyVal<T> v) { return v.Value; }

        /// <summary>
        /// () → T からLazyVal[T]に暗黙変換します。
        /// </summary>
        public static implicit operator LazyVal<T>(Func<T> f) { return new LazyVal<T>(f); }
    }
}