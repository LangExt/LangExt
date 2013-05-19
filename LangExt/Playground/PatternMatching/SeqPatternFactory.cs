using System;

namespace LangExt.Playground.PatternMatching
{
    /// <summary>
    /// シーケンスに対する代表的なパターンを生成するためのクラスです。
    /// </summary>
    /// <typeparam name="T">シーケンスの要素の型</typeparam>
    public sealed class SeqPatternFactory<T>
    {
        static T Head(ISeq<T> xs) { return xs.Find(_ => true); }
        static Option<T> TryHead(ISeq<T> xs) { return xs.TryFind(_ => true); }

        /// <summary>
        /// 空でないシーケンスの先頭要素に対して常にマッチするパターンです。
        /// </summary>
        public IPattern<ISeq<T>, T> Any
        {
            get
            {
                return new Pattern<ISeq<T>, T>(xs =>
                    xs.IsNotEmpty() ? Option.Some(_.Create(xs.SplitAt(1).Map1(Head)))
                                    : Option.None);
            }
        }

        /// <summary>
        /// 空でないシーケンスの先頭要素が引数で指定した値と等しい場合にマッチするパターンです。
        /// </summary>
        public IPattern<ISeq<T>, T> Eq(T x)
        {
            return new Pattern<ISeq<T>, T>(xs =>
                TryHead(xs).Bind(hd => hd.IsEqualTo(x) ? Option.Some(_.Create(hd, xs.Skip(1)))
                                                       : Option.None));
        }

        /// <summary>
        /// すべてのシーケンスにマッチします。
        /// </summary>
        public IPattern<ISeq<T>, ISeq<T>> Rest
        {
            get { return new Pattern<ISeq<T>, ISeq<T>>(xs => Option.Some(_.Create(xs, xs))); }
        }

        /// <summary>
        /// 空でないシーケンスの先頭要素が引数で指定した述語を満たす場合にマッチするパターンです。
        /// </summary>
        public IPattern<ISeq<T>, T> Pred(Func<T, bool> pred)
        {
            return new Pattern<ISeq<T>, T>(xs =>
                TryHead(xs).Bind(hd => pred(hd) ? Option.Some(_.Create(hd, xs.Skip(1)))
                                                : Option.None));
        }
    }
}
