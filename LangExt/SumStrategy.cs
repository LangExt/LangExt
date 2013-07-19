using System;
using System.ComponentModel;

namespace LangExt
{
    /// <summary>
    /// Tの総和の計算を行う戦略を表すインターフェイスです。
    /// </summary>
    /// <typeparam name="T">総和を計算する型</typeparam>
    public interface ISumStrategy<T>
    {
        /// <summary>
        /// Tの加算に対する単位元を取得します。
        /// </summary>
        T Zero { get; }

        /// <summary>
        /// Tを加算する演算です。
        /// 可換であることは、このインターフェイスでは求めていません。
        /// </summary>
        T Plus(T a, T b);
    }

    /// <summary>
    /// よく使用するISumStrategyの生成を簡略化するためのクラスです。
    /// </summary>
    public static class SumStrategy
    {
        /// <summary>
        /// ゼロ値と加算のための関数からISumStrategyを生成します。
        /// </summary>
        public static ISumStrategy<T> Create<T>(T zero, Func<T, T, T> adder) { return new SumStrategy<T>(zero, adder); }
        /// <summary>
        /// decimalに対するISumStrategyを返します。
        /// </summary>
        public static ISumStrategy<decimal> Decimal { get { return new SumStrategy<decimal>(0.0M, (a, b) => a + b); } }
        /// <summary>
        /// doubleに対するISumStrategyを返します。
        /// </summary>
        public static ISumStrategy<double> Double { get { return new SumStrategy<double>(0.0, (a, b) => a + b); } }
        /// <summary>
        /// floatに対するISumStrategyを返します。
        /// </summary>
        public static ISumStrategy<float> Float { get { return new SumStrategy<float>(0.0f, (a, b) => a + b); } }
        /// <summary>
        /// System.TimeSpanに対するISumStrategyを返します。
        /// </summary>
        public static ISumStrategy<TimeSpan> TimeSpan { get { return new SumStrategy<TimeSpan>(System.TimeSpan.Zero, (a, b) => a + b); } }
        /// <summary>
        /// stringに対するISumStrategyを返します。
        /// </summary>
        public static ISumStrategy<string> String { get { return new SumStrategy<string>("", (a, b) => a + b); } }
        
        /// <summary>
        /// 使用しません。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static new bool Equals(object a, object b)
        {
            return object.Equals(a, b);
        }

        /// <summary>
        /// 使用しません。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static new bool ReferenceEquals(object a, object b)
        {
            return object.ReferenceEquals(a, b);
        }
    }

    internal class SumStrategy<T> : ISumStrategy<T>
    {
        readonly T zero;
        readonly Func<T, T, T> adder;

        internal SumStrategy(T zero, Func<T, T, T> adder)
        {
            this.zero = zero;
            this.adder = adder;
        }

        public T Zero { get { return zero; } }

        public T Plus(T a, T b) { return adder(a, b); }
    }
}
