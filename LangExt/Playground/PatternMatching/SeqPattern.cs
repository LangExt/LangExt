
using System;

namespace LangExt.Playground.PatternMatching
{
    /// <summary>
    /// シーケンスに対するパターンと、パターンが一致した際の処理を関連付けるためのクラスです。
    /// </summary>
    /// <typeparam name="T">シーケンスの要素の型</typeparam>
    /// <typeparam name="T1">パターンが一致した際の処理が受け取る第1引数の型</typeparam>
    public class SeqPattern<T, T1>
    {
        internal readonly IPattern<ISeq<T>, T1> Pat1;

        /// <summary>
        /// シーケンスに対するパターンを元にオブジェクトを構築します。
        /// </summary>
        /// <param name="pat1">1個目のパターン</param>
        public SeqPattern(IPattern<ISeq<T>, T1> pat1)
        {
            Pat1 = pat1;
        }

        /// <summary>
        /// パターンが一致した際の処理を登録します。
        /// </summary>
        /// <typeparam name="U">処理の結果の型</typeparam>
        /// <param name="f">パターンが一致した際の処理</param>
        /// <returns>処理の結果の型(パターンが一致しなかった場合はNone)</returns>
        public Func<ISeq<T>, Option<U>> Then<U>(Func<T1, U> f)
        {
            return xs =>
            {
                return
                    from _1 in Pat1.Match(xs)
                    select f(_1.Result);
            };
        }

        /// <summary>
        /// パターンが一致した際の処理を登録します。
        /// </summary>
        /// <typeparam name="U">処理の結果の型</typeparam>
        /// <param name="f">パターンが一致した際の処理</param>
        /// <param name="otherwise">パターンが一致しなかった際の処理</param>
        /// <returns>処理の結果の型</returns>
        public Func<ISeq<T>, U> Then<U>(Func<T1, U> f, Func<ISeq<T>, U> otherwise)
        {
            return xs => Then(f)(xs).Match(x => x, () => otherwise(xs));
        }
    }

    /// <summary>
    /// シーケンスに対するパターンと、パターンが一致した際の処理を関連付けるためのクラスです。
    /// </summary>
    /// <typeparam name="T">シーケンスの要素の型</typeparam>
    /// <typeparam name="T1">パターンが一致した際の処理が受け取る第1引数の型</typeparam>
    /// <typeparam name="T2">パターンが一致した際の処理が受け取る第2引数の型</typeparam>
    public class SeqPattern<T, T1, T2>
    {
        internal readonly IPattern<ISeq<T>, T1> Pat1;
        internal readonly IPattern<ISeq<T>, T2> Pat2;

        /// <summary>
        /// シーケンスに対するパターンを元にオブジェクトを構築します。
        /// </summary>
        /// <param name="pat1">1個目のパターン</param>
        /// <param name="pat2">2個目のパターン</param>
        public SeqPattern(IPattern<ISeq<T>, T1> pat1, IPattern<ISeq<T>, T2> pat2)
        {
            Pat1 = pat1;
            Pat2 = pat2;
        }

        /// <summary>
        /// パターンが一致した際の処理を登録します。
        /// </summary>
        /// <typeparam name="U">処理の結果の型</typeparam>
        /// <param name="f">パターンが一致した際の処理</param>
        /// <returns>処理の結果の型(パターンが一致しなかった場合はNone)</returns>
        public Func<ISeq<T>, Option<U>> Then<U>(Func<T1, T2, U> f)
        {
            return xs =>
            {
                return
                    from _1 in Pat1.Match(xs)
                    from _2 in Pat2.Match(_1.Next)
                    select f(_1.Result, _2.Result);
            };
        }

        /// <summary>
        /// パターンが一致した際の処理を登録します。
        /// </summary>
        /// <typeparam name="U">処理の結果の型</typeparam>
        /// <param name="f">パターンが一致した際の処理</param>
        /// <param name="otherwise">パターンが一致しなかった際の処理</param>
        /// <returns>処理の結果の型</returns>
        public Func<ISeq<T>, U> Then<U>(Func<T1, T2, U> f, Func<ISeq<T>, U> otherwise)
        {
            return xs => Then(f)(xs).Match(x => x, () => otherwise(xs));
        }
    }

    /// <summary>
    /// シーケンスに対するパターンと、パターンが一致した際の処理を関連付けるためのクラスです。
    /// </summary>
    /// <typeparam name="T">シーケンスの要素の型</typeparam>
    /// <typeparam name="T1">パターンが一致した際の処理が受け取る第1引数の型</typeparam>
    /// <typeparam name="T2">パターンが一致した際の処理が受け取る第2引数の型</typeparam>
    /// <typeparam name="T3">パターンが一致した際の処理が受け取る第3引数の型</typeparam>
    public class SeqPattern<T, T1, T2, T3>
    {
        internal readonly IPattern<ISeq<T>, T1> Pat1;
        internal readonly IPattern<ISeq<T>, T2> Pat2;
        internal readonly IPattern<ISeq<T>, T3> Pat3;

        /// <summary>
        /// シーケンスに対するパターンを元にオブジェクトを構築します。
        /// </summary>
        /// <param name="pat1">1個目のパターン</param>
        /// <param name="pat2">2個目のパターン</param>
        /// <param name="pat3">3個目のパターン</param>
        public SeqPattern(IPattern<ISeq<T>, T1> pat1, IPattern<ISeq<T>, T2> pat2, IPattern<ISeq<T>, T3> pat3)
        {
            Pat1 = pat1;
            Pat2 = pat2;
            Pat3 = pat3;
        }

        /// <summary>
        /// パターンが一致した際の処理を登録します。
        /// </summary>
        /// <typeparam name="U">処理の結果の型</typeparam>
        /// <param name="f">パターンが一致した際の処理</param>
        /// <returns>処理の結果の型(パターンが一致しなかった場合はNone)</returns>
        public Func<ISeq<T>, Option<U>> Then<U>(Func<T1, T2, T3, U> f)
        {
            return xs =>
            {
                return
                    from _1 in Pat1.Match(xs)
                    from _2 in Pat2.Match(_1.Next)
                    from _3 in Pat3.Match(_2.Next)
                    select f(_1.Result, _2.Result, _3.Result);
            };
        }

        /// <summary>
        /// パターンが一致した際の処理を登録します。
        /// </summary>
        /// <typeparam name="U">処理の結果の型</typeparam>
        /// <param name="f">パターンが一致した際の処理</param>
        /// <param name="otherwise">パターンが一致しなかった際の処理</param>
        /// <returns>処理の結果の型</returns>
        public Func<ISeq<T>, U> Then<U>(Func<T1, T2, T3, U> f, Func<ISeq<T>, U> otherwise)
        {
            return xs => Then(f)(xs).Match(x => x, () => otherwise(xs));
        }
    }

    /// <summary>
    /// シーケンスに対するパターンと、パターンが一致した際の処理を関連付けるためのクラスです。
    /// </summary>
    /// <typeparam name="T">シーケンスの要素の型</typeparam>
    /// <typeparam name="T1">パターンが一致した際の処理が受け取る第1引数の型</typeparam>
    /// <typeparam name="T2">パターンが一致した際の処理が受け取る第2引数の型</typeparam>
    /// <typeparam name="T3">パターンが一致した際の処理が受け取る第3引数の型</typeparam>
    /// <typeparam name="T4">パターンが一致した際の処理が受け取る第4引数の型</typeparam>
    public class SeqPattern<T, T1, T2, T3, T4>
    {
        internal readonly IPattern<ISeq<T>, T1> Pat1;
        internal readonly IPattern<ISeq<T>, T2> Pat2;
        internal readonly IPattern<ISeq<T>, T3> Pat3;
        internal readonly IPattern<ISeq<T>, T4> Pat4;

        /// <summary>
        /// シーケンスに対するパターンを元にオブジェクトを構築します。
        /// </summary>
        /// <param name="pat1">1個目のパターン</param>
        /// <param name="pat2">2個目のパターン</param>
        /// <param name="pat3">3個目のパターン</param>
        /// <param name="pat4">4個目のパターン</param>
        public SeqPattern(IPattern<ISeq<T>, T1> pat1, IPattern<ISeq<T>, T2> pat2, IPattern<ISeq<T>, T3> pat3, IPattern<ISeq<T>, T4> pat4)
        {
            Pat1 = pat1;
            Pat2 = pat2;
            Pat3 = pat3;
            Pat4 = pat4;
        }

        /// <summary>
        /// パターンが一致した際の処理を登録します。
        /// </summary>
        /// <typeparam name="U">処理の結果の型</typeparam>
        /// <param name="f">パターンが一致した際の処理</param>
        /// <returns>処理の結果の型(パターンが一致しなかった場合はNone)</returns>
        public Func<ISeq<T>, Option<U>> Then<U>(Func<T1, T2, T3, T4, U> f)
        {
            return xs =>
            {
                return
                    from _1 in Pat1.Match(xs)
                    from _2 in Pat2.Match(_1.Next)
                    from _3 in Pat3.Match(_2.Next)
                    from _4 in Pat4.Match(_3.Next)
                    select f(_1.Result, _2.Result, _3.Result, _4.Result);
            };
        }

        /// <summary>
        /// パターンが一致した際の処理を登録します。
        /// </summary>
        /// <typeparam name="U">処理の結果の型</typeparam>
        /// <param name="f">パターンが一致した際の処理</param>
        /// <param name="otherwise">パターンが一致しなかった際の処理</param>
        /// <returns>処理の結果の型</returns>
        public Func<ISeq<T>, U> Then<U>(Func<T1, T2, T3, T4, U> f, Func<ISeq<T>, U> otherwise)
        {
            return xs => Then(f)(xs).Match(x => x, () => otherwise(xs));
        }
    }

    /// <summary>
    /// シーケンスに対するパターンと、パターンが一致した際の処理を関連付けるためのクラスです。
    /// </summary>
    /// <typeparam name="T">シーケンスの要素の型</typeparam>
    /// <typeparam name="T1">パターンが一致した際の処理が受け取る第1引数の型</typeparam>
    /// <typeparam name="T2">パターンが一致した際の処理が受け取る第2引数の型</typeparam>
    /// <typeparam name="T3">パターンが一致した際の処理が受け取る第3引数の型</typeparam>
    /// <typeparam name="T4">パターンが一致した際の処理が受け取る第4引数の型</typeparam>
    /// <typeparam name="T5">パターンが一致した際の処理が受け取る第5引数の型</typeparam>
    public class SeqPattern<T, T1, T2, T3, T4, T5>
    {
        internal readonly IPattern<ISeq<T>, T1> Pat1;
        internal readonly IPattern<ISeq<T>, T2> Pat2;
        internal readonly IPattern<ISeq<T>, T3> Pat3;
        internal readonly IPattern<ISeq<T>, T4> Pat4;
        internal readonly IPattern<ISeq<T>, T5> Pat5;

        /// <summary>
        /// シーケンスに対するパターンを元にオブジェクトを構築します。
        /// </summary>
        /// <param name="pat1">1個目のパターン</param>
        /// <param name="pat2">2個目のパターン</param>
        /// <param name="pat3">3個目のパターン</param>
        /// <param name="pat4">4個目のパターン</param>
        /// <param name="pat5">5個目のパターン</param>
        public SeqPattern(IPattern<ISeq<T>, T1> pat1, IPattern<ISeq<T>, T2> pat2, IPattern<ISeq<T>, T3> pat3, IPattern<ISeq<T>, T4> pat4, IPattern<ISeq<T>, T5> pat5)
        {
            Pat1 = pat1;
            Pat2 = pat2;
            Pat3 = pat3;
            Pat4 = pat4;
            Pat5 = pat5;
        }

        /// <summary>
        /// パターンが一致した際の処理を登録します。
        /// </summary>
        /// <typeparam name="U">処理の結果の型</typeparam>
        /// <param name="f">パターンが一致した際の処理</param>
        /// <returns>処理の結果の型(パターンが一致しなかった場合はNone)</returns>
        public Func<ISeq<T>, Option<U>> Then<U>(Func<T1, T2, T3, T4, T5, U> f)
        {
            return xs =>
            {
                return
                    from _1 in Pat1.Match(xs)
                    from _2 in Pat2.Match(_1.Next)
                    from _3 in Pat3.Match(_2.Next)
                    from _4 in Pat4.Match(_3.Next)
                    from _5 in Pat5.Match(_4.Next)
                    select f(_1.Result, _2.Result, _3.Result, _4.Result, _5.Result);
            };
        }

        /// <summary>
        /// パターンが一致した際の処理を登録します。
        /// </summary>
        /// <typeparam name="U">処理の結果の型</typeparam>
        /// <param name="f">パターンが一致した際の処理</param>
        /// <param name="otherwise">パターンが一致しなかった際の処理</param>
        /// <returns>処理の結果の型</returns>
        public Func<ISeq<T>, U> Then<U>(Func<T1, T2, T3, T4, T5, U> f, Func<ISeq<T>, U> otherwise)
        {
            return xs => Then(f)(xs).Match(x => x, () => otherwise(xs));
        }
    }

    /// <summary>
    /// シーケンスに対するパターンと、パターンが一致した際の処理を関連付けるためのクラスです。
    /// </summary>
    /// <typeparam name="T">シーケンスの要素の型</typeparam>
    /// <typeparam name="T1">パターンが一致した際の処理が受け取る第1引数の型</typeparam>
    /// <typeparam name="T2">パターンが一致した際の処理が受け取る第2引数の型</typeparam>
    /// <typeparam name="T3">パターンが一致した際の処理が受け取る第3引数の型</typeparam>
    /// <typeparam name="T4">パターンが一致した際の処理が受け取る第4引数の型</typeparam>
    /// <typeparam name="T5">パターンが一致した際の処理が受け取る第5引数の型</typeparam>
    /// <typeparam name="T6">パターンが一致した際の処理が受け取る第6引数の型</typeparam>
    public class SeqPattern<T, T1, T2, T3, T4, T5, T6>
    {
        internal readonly IPattern<ISeq<T>, T1> Pat1;
        internal readonly IPattern<ISeq<T>, T2> Pat2;
        internal readonly IPattern<ISeq<T>, T3> Pat3;
        internal readonly IPattern<ISeq<T>, T4> Pat4;
        internal readonly IPattern<ISeq<T>, T5> Pat5;
        internal readonly IPattern<ISeq<T>, T6> Pat6;

        /// <summary>
        /// シーケンスに対するパターンを元にオブジェクトを構築します。
        /// </summary>
        /// <param name="pat1">1個目のパターン</param>
        /// <param name="pat2">2個目のパターン</param>
        /// <param name="pat3">3個目のパターン</param>
        /// <param name="pat4">4個目のパターン</param>
        /// <param name="pat5">5個目のパターン</param>
        /// <param name="pat6">6個目のパターン</param>
        public SeqPattern(IPattern<ISeq<T>, T1> pat1, IPattern<ISeq<T>, T2> pat2, IPattern<ISeq<T>, T3> pat3, IPattern<ISeq<T>, T4> pat4, IPattern<ISeq<T>, T5> pat5, IPattern<ISeq<T>, T6> pat6)
        {
            Pat1 = pat1;
            Pat2 = pat2;
            Pat3 = pat3;
            Pat4 = pat4;
            Pat5 = pat5;
            Pat6 = pat6;
        }

        /// <summary>
        /// パターンが一致した際の処理を登録します。
        /// </summary>
        /// <typeparam name="U">処理の結果の型</typeparam>
        /// <param name="f">パターンが一致した際の処理</param>
        /// <returns>処理の結果の型(パターンが一致しなかった場合はNone)</returns>
        public Func<ISeq<T>, Option<U>> Then<U>(Func<T1, T2, T3, T4, T5, T6, U> f)
        {
            return xs =>
            {
                return
                    from _1 in Pat1.Match(xs)
                    from _2 in Pat2.Match(_1.Next)
                    from _3 in Pat3.Match(_2.Next)
                    from _4 in Pat4.Match(_3.Next)
                    from _5 in Pat5.Match(_4.Next)
                    from _6 in Pat6.Match(_5.Next)
                    select f(_1.Result, _2.Result, _3.Result, _4.Result, _5.Result, _6.Result);
            };
        }

        /// <summary>
        /// パターンが一致した際の処理を登録します。
        /// </summary>
        /// <typeparam name="U">処理の結果の型</typeparam>
        /// <param name="f">パターンが一致した際の処理</param>
        /// <param name="otherwise">パターンが一致しなかった際の処理</param>
        /// <returns>処理の結果の型</returns>
        public Func<ISeq<T>, U> Then<U>(Func<T1, T2, T3, T4, T5, T6, U> f, Func<ISeq<T>, U> otherwise)
        {
            return xs => Then(f)(xs).Match(x => x, () => otherwise(xs));
        }
    }

    /// <summary>
    /// シーケンスに対するパターンと、パターンが一致した際の処理を関連付けるためのクラスです。
    /// </summary>
    /// <typeparam name="T">シーケンスの要素の型</typeparam>
    /// <typeparam name="T1">パターンが一致した際の処理が受け取る第1引数の型</typeparam>
    /// <typeparam name="T2">パターンが一致した際の処理が受け取る第2引数の型</typeparam>
    /// <typeparam name="T3">パターンが一致した際の処理が受け取る第3引数の型</typeparam>
    /// <typeparam name="T4">パターンが一致した際の処理が受け取る第4引数の型</typeparam>
    /// <typeparam name="T5">パターンが一致した際の処理が受け取る第5引数の型</typeparam>
    /// <typeparam name="T6">パターンが一致した際の処理が受け取る第6引数の型</typeparam>
    /// <typeparam name="T7">パターンが一致した際の処理が受け取る第7引数の型</typeparam>
    public class SeqPattern<T, T1, T2, T3, T4, T5, T6, T7>
    {
        internal readonly IPattern<ISeq<T>, T1> Pat1;
        internal readonly IPattern<ISeq<T>, T2> Pat2;
        internal readonly IPattern<ISeq<T>, T3> Pat3;
        internal readonly IPattern<ISeq<T>, T4> Pat4;
        internal readonly IPattern<ISeq<T>, T5> Pat5;
        internal readonly IPattern<ISeq<T>, T6> Pat6;
        internal readonly IPattern<ISeq<T>, T7> Pat7;

        /// <summary>
        /// シーケンスに対するパターンを元にオブジェクトを構築します。
        /// </summary>
        /// <param name="pat1">1個目のパターン</param>
        /// <param name="pat2">2個目のパターン</param>
        /// <param name="pat3">3個目のパターン</param>
        /// <param name="pat4">4個目のパターン</param>
        /// <param name="pat5">5個目のパターン</param>
        /// <param name="pat6">6個目のパターン</param>
        /// <param name="pat7">7個目のパターン</param>
        public SeqPattern(IPattern<ISeq<T>, T1> pat1, IPattern<ISeq<T>, T2> pat2, IPattern<ISeq<T>, T3> pat3, IPattern<ISeq<T>, T4> pat4, IPattern<ISeq<T>, T5> pat5, IPattern<ISeq<T>, T6> pat6, IPattern<ISeq<T>, T7> pat7)
        {
            Pat1 = pat1;
            Pat2 = pat2;
            Pat3 = pat3;
            Pat4 = pat4;
            Pat5 = pat5;
            Pat6 = pat6;
            Pat7 = pat7;
        }

        /// <summary>
        /// パターンが一致した際の処理を登録します。
        /// </summary>
        /// <typeparam name="U">処理の結果の型</typeparam>
        /// <param name="f">パターンが一致した際の処理</param>
        /// <returns>処理の結果の型(パターンが一致しなかった場合はNone)</returns>
        public Func<ISeq<T>, Option<U>> Then<U>(Func<T1, T2, T3, T4, T5, T6, T7, U> f)
        {
            return xs =>
            {
                return
                    from _1 in Pat1.Match(xs)
                    from _2 in Pat2.Match(_1.Next)
                    from _3 in Pat3.Match(_2.Next)
                    from _4 in Pat4.Match(_3.Next)
                    from _5 in Pat5.Match(_4.Next)
                    from _6 in Pat6.Match(_5.Next)
                    from _7 in Pat7.Match(_6.Next)
                    select f(_1.Result, _2.Result, _3.Result, _4.Result, _5.Result, _6.Result, _7.Result);
            };
        }

        /// <summary>
        /// パターンが一致した際の処理を登録します。
        /// </summary>
        /// <typeparam name="U">処理の結果の型</typeparam>
        /// <param name="f">パターンが一致した際の処理</param>
        /// <param name="otherwise">パターンが一致しなかった際の処理</param>
        /// <returns>処理の結果の型</returns>
        public Func<ISeq<T>, U> Then<U>(Func<T1, T2, T3, T4, T5, T6, T7, U> f, Func<ISeq<T>, U> otherwise)
        {
            return xs => Then(f)(xs).Match(x => x, () => otherwise(xs));
        }
    }

    /// <summary>
    /// シーケンスに対するパターンと、パターンが一致した際の処理を関連付けるためのクラスです。
    /// </summary>
    /// <typeparam name="T">シーケンスの要素の型</typeparam>
    /// <typeparam name="T1">パターンが一致した際の処理が受け取る第1引数の型</typeparam>
    /// <typeparam name="T2">パターンが一致した際の処理が受け取る第2引数の型</typeparam>
    /// <typeparam name="T3">パターンが一致した際の処理が受け取る第3引数の型</typeparam>
    /// <typeparam name="T4">パターンが一致した際の処理が受け取る第4引数の型</typeparam>
    /// <typeparam name="T5">パターンが一致した際の処理が受け取る第5引数の型</typeparam>
    /// <typeparam name="T6">パターンが一致した際の処理が受け取る第6引数の型</typeparam>
    /// <typeparam name="T7">パターンが一致した際の処理が受け取る第7引数の型</typeparam>
    /// <typeparam name="T8">パターンが一致した際の処理が受け取る第8引数の型</typeparam>
    public class SeqPattern<T, T1, T2, T3, T4, T5, T6, T7, T8>
    {
        internal readonly IPattern<ISeq<T>, T1> Pat1;
        internal readonly IPattern<ISeq<T>, T2> Pat2;
        internal readonly IPattern<ISeq<T>, T3> Pat3;
        internal readonly IPattern<ISeq<T>, T4> Pat4;
        internal readonly IPattern<ISeq<T>, T5> Pat5;
        internal readonly IPattern<ISeq<T>, T6> Pat6;
        internal readonly IPattern<ISeq<T>, T7> Pat7;
        internal readonly IPattern<ISeq<T>, T8> Pat8;

        /// <summary>
        /// シーケンスに対するパターンを元にオブジェクトを構築します。
        /// </summary>
        /// <param name="pat1">1個目のパターン</param>
        /// <param name="pat2">2個目のパターン</param>
        /// <param name="pat3">3個目のパターン</param>
        /// <param name="pat4">4個目のパターン</param>
        /// <param name="pat5">5個目のパターン</param>
        /// <param name="pat6">6個目のパターン</param>
        /// <param name="pat7">7個目のパターン</param>
        /// <param name="pat8">8個目のパターン</param>
        public SeqPattern(IPattern<ISeq<T>, T1> pat1, IPattern<ISeq<T>, T2> pat2, IPattern<ISeq<T>, T3> pat3, IPattern<ISeq<T>, T4> pat4, IPattern<ISeq<T>, T5> pat5, IPattern<ISeq<T>, T6> pat6, IPattern<ISeq<T>, T7> pat7, IPattern<ISeq<T>, T8> pat8)
        {
            Pat1 = pat1;
            Pat2 = pat2;
            Pat3 = pat3;
            Pat4 = pat4;
            Pat5 = pat5;
            Pat6 = pat6;
            Pat7 = pat7;
            Pat8 = pat8;
        }

        /// <summary>
        /// パターンが一致した際の処理を登録します。
        /// </summary>
        /// <typeparam name="U">処理の結果の型</typeparam>
        /// <param name="f">パターンが一致した際の処理</param>
        /// <returns>処理の結果の型(パターンが一致しなかった場合はNone)</returns>
        public Func<ISeq<T>, Option<U>> Then<U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, U> f)
        {
            return xs =>
            {
                return
                    from _1 in Pat1.Match(xs)
                    from _2 in Pat2.Match(_1.Next)
                    from _3 in Pat3.Match(_2.Next)
                    from _4 in Pat4.Match(_3.Next)
                    from _5 in Pat5.Match(_4.Next)
                    from _6 in Pat6.Match(_5.Next)
                    from _7 in Pat7.Match(_6.Next)
                    from _8 in Pat8.Match(_7.Next)
                    select f(_1.Result, _2.Result, _3.Result, _4.Result, _5.Result, _6.Result, _7.Result, _8.Result);
            };
        }

        /// <summary>
        /// パターンが一致した際の処理を登録します。
        /// </summary>
        /// <typeparam name="U">処理の結果の型</typeparam>
        /// <param name="f">パターンが一致した際の処理</param>
        /// <param name="otherwise">パターンが一致しなかった際の処理</param>
        /// <returns>処理の結果の型</returns>
        public Func<ISeq<T>, U> Then<U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, U> f, Func<ISeq<T>, U> otherwise)
        {
            return xs => Then(f)(xs).Match(x => x, () => otherwise(xs));
        }
    }

    /// <summary>
    /// シーケンスに対するパターンと、パターンが一致した際の処理を関連付けるためのクラスです。
    /// </summary>
    /// <typeparam name="T">シーケンスの要素の型</typeparam>
    /// <typeparam name="T1">パターンが一致した際の処理が受け取る第1引数の型</typeparam>
    /// <typeparam name="T2">パターンが一致した際の処理が受け取る第2引数の型</typeparam>
    /// <typeparam name="T3">パターンが一致した際の処理が受け取る第3引数の型</typeparam>
    /// <typeparam name="T4">パターンが一致した際の処理が受け取る第4引数の型</typeparam>
    /// <typeparam name="T5">パターンが一致した際の処理が受け取る第5引数の型</typeparam>
    /// <typeparam name="T6">パターンが一致した際の処理が受け取る第6引数の型</typeparam>
    /// <typeparam name="T7">パターンが一致した際の処理が受け取る第7引数の型</typeparam>
    /// <typeparam name="T8">パターンが一致した際の処理が受け取る第8引数の型</typeparam>
    /// <typeparam name="T9">パターンが一致した際の処理が受け取る第9引数の型</typeparam>
    public class SeqPattern<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>
    {
        internal readonly IPattern<ISeq<T>, T1> Pat1;
        internal readonly IPattern<ISeq<T>, T2> Pat2;
        internal readonly IPattern<ISeq<T>, T3> Pat3;
        internal readonly IPattern<ISeq<T>, T4> Pat4;
        internal readonly IPattern<ISeq<T>, T5> Pat5;
        internal readonly IPattern<ISeq<T>, T6> Pat6;
        internal readonly IPattern<ISeq<T>, T7> Pat7;
        internal readonly IPattern<ISeq<T>, T8> Pat8;
        internal readonly IPattern<ISeq<T>, T9> Pat9;

        /// <summary>
        /// シーケンスに対するパターンを元にオブジェクトを構築します。
        /// </summary>
        /// <param name="pat1">1個目のパターン</param>
        /// <param name="pat2">2個目のパターン</param>
        /// <param name="pat3">3個目のパターン</param>
        /// <param name="pat4">4個目のパターン</param>
        /// <param name="pat5">5個目のパターン</param>
        /// <param name="pat6">6個目のパターン</param>
        /// <param name="pat7">7個目のパターン</param>
        /// <param name="pat8">8個目のパターン</param>
        /// <param name="pat9">9個目のパターン</param>
        public SeqPattern(IPattern<ISeq<T>, T1> pat1, IPattern<ISeq<T>, T2> pat2, IPattern<ISeq<T>, T3> pat3, IPattern<ISeq<T>, T4> pat4, IPattern<ISeq<T>, T5> pat5, IPattern<ISeq<T>, T6> pat6, IPattern<ISeq<T>, T7> pat7, IPattern<ISeq<T>, T8> pat8, IPattern<ISeq<T>, T9> pat9)
        {
            Pat1 = pat1;
            Pat2 = pat2;
            Pat3 = pat3;
            Pat4 = pat4;
            Pat5 = pat5;
            Pat6 = pat6;
            Pat7 = pat7;
            Pat8 = pat8;
            Pat9 = pat9;
        }

        /// <summary>
        /// パターンが一致した際の処理を登録します。
        /// </summary>
        /// <typeparam name="U">処理の結果の型</typeparam>
        /// <param name="f">パターンが一致した際の処理</param>
        /// <returns>処理の結果の型(パターンが一致しなかった場合はNone)</returns>
        public Func<ISeq<T>, Option<U>> Then<U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> f)
        {
            return xs =>
            {
                return
                    from _1 in Pat1.Match(xs)
                    from _2 in Pat2.Match(_1.Next)
                    from _3 in Pat3.Match(_2.Next)
                    from _4 in Pat4.Match(_3.Next)
                    from _5 in Pat5.Match(_4.Next)
                    from _6 in Pat6.Match(_5.Next)
                    from _7 in Pat7.Match(_6.Next)
                    from _8 in Pat8.Match(_7.Next)
                    from _9 in Pat9.Match(_8.Next)
                    select f(_1.Result, _2.Result, _3.Result, _4.Result, _5.Result, _6.Result, _7.Result, _8.Result, _9.Result);
            };
        }

        /// <summary>
        /// パターンが一致した際の処理を登録します。
        /// </summary>
        /// <typeparam name="U">処理の結果の型</typeparam>
        /// <param name="f">パターンが一致した際の処理</param>
        /// <param name="otherwise">パターンが一致しなかった際の処理</param>
        /// <returns>処理の結果の型</returns>
        public Func<ISeq<T>, U> Then<U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, U> f, Func<ISeq<T>, U> otherwise)
        {
            return xs => Then(f)(xs).Match(x => x, () => otherwise(xs));
        }
    }

    /// <summary>
    /// シーケンスに対するパターンと、パターンが一致した際の処理を関連付けるためのクラスです。
    /// </summary>
    /// <typeparam name="T">シーケンスの要素の型</typeparam>
    /// <typeparam name="T1">パターンが一致した際の処理が受け取る第1引数の型</typeparam>
    /// <typeparam name="T2">パターンが一致した際の処理が受け取る第2引数の型</typeparam>
    /// <typeparam name="T3">パターンが一致した際の処理が受け取る第3引数の型</typeparam>
    /// <typeparam name="T4">パターンが一致した際の処理が受け取る第4引数の型</typeparam>
    /// <typeparam name="T5">パターンが一致した際の処理が受け取る第5引数の型</typeparam>
    /// <typeparam name="T6">パターンが一致した際の処理が受け取る第6引数の型</typeparam>
    /// <typeparam name="T7">パターンが一致した際の処理が受け取る第7引数の型</typeparam>
    /// <typeparam name="T8">パターンが一致した際の処理が受け取る第8引数の型</typeparam>
    /// <typeparam name="T9">パターンが一致した際の処理が受け取る第9引数の型</typeparam>
    /// <typeparam name="T10">パターンが一致した際の処理が受け取る第10引数の型</typeparam>
    public class SeqPattern<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
    {
        internal readonly IPattern<ISeq<T>, T1> Pat1;
        internal readonly IPattern<ISeq<T>, T2> Pat2;
        internal readonly IPattern<ISeq<T>, T3> Pat3;
        internal readonly IPattern<ISeq<T>, T4> Pat4;
        internal readonly IPattern<ISeq<T>, T5> Pat5;
        internal readonly IPattern<ISeq<T>, T6> Pat6;
        internal readonly IPattern<ISeq<T>, T7> Pat7;
        internal readonly IPattern<ISeq<T>, T8> Pat8;
        internal readonly IPattern<ISeq<T>, T9> Pat9;
        internal readonly IPattern<ISeq<T>, T10> Pat10;

        /// <summary>
        /// シーケンスに対するパターンを元にオブジェクトを構築します。
        /// </summary>
        /// <param name="pat1">1個目のパターン</param>
        /// <param name="pat2">2個目のパターン</param>
        /// <param name="pat3">3個目のパターン</param>
        /// <param name="pat4">4個目のパターン</param>
        /// <param name="pat5">5個目のパターン</param>
        /// <param name="pat6">6個目のパターン</param>
        /// <param name="pat7">7個目のパターン</param>
        /// <param name="pat8">8個目のパターン</param>
        /// <param name="pat9">9個目のパターン</param>
        /// <param name="pat10">10個目のパターン</param>
        public SeqPattern(IPattern<ISeq<T>, T1> pat1, IPattern<ISeq<T>, T2> pat2, IPattern<ISeq<T>, T3> pat3, IPattern<ISeq<T>, T4> pat4, IPattern<ISeq<T>, T5> pat5, IPattern<ISeq<T>, T6> pat6, IPattern<ISeq<T>, T7> pat7, IPattern<ISeq<T>, T8> pat8, IPattern<ISeq<T>, T9> pat9, IPattern<ISeq<T>, T10> pat10)
        {
            Pat1 = pat1;
            Pat2 = pat2;
            Pat3 = pat3;
            Pat4 = pat4;
            Pat5 = pat5;
            Pat6 = pat6;
            Pat7 = pat7;
            Pat8 = pat8;
            Pat9 = pat9;
            Pat10 = pat10;
        }

        /// <summary>
        /// パターンが一致した際の処理を登録します。
        /// </summary>
        /// <typeparam name="U">処理の結果の型</typeparam>
        /// <param name="f">パターンが一致した際の処理</param>
        /// <returns>処理の結果の型(パターンが一致しなかった場合はNone)</returns>
        public Func<ISeq<T>, Option<U>> Then<U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> f)
        {
            return xs =>
            {
                return
                    from _1 in Pat1.Match(xs)
                    from _2 in Pat2.Match(_1.Next)
                    from _3 in Pat3.Match(_2.Next)
                    from _4 in Pat4.Match(_3.Next)
                    from _5 in Pat5.Match(_4.Next)
                    from _6 in Pat6.Match(_5.Next)
                    from _7 in Pat7.Match(_6.Next)
                    from _8 in Pat8.Match(_7.Next)
                    from _9 in Pat9.Match(_8.Next)
                    from _10 in Pat10.Match(_9.Next)
                    select f(_1.Result, _2.Result, _3.Result, _4.Result, _5.Result, _6.Result, _7.Result, _8.Result, _9.Result, _10.Result);
            };
        }

        /// <summary>
        /// パターンが一致した際の処理を登録します。
        /// </summary>
        /// <typeparam name="U">処理の結果の型</typeparam>
        /// <param name="f">パターンが一致した際の処理</param>
        /// <param name="otherwise">パターンが一致しなかった際の処理</param>
        /// <returns>処理の結果の型</returns>
        public Func<ISeq<T>, U> Then<U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, U> f, Func<ISeq<T>, U> otherwise)
        {
            return xs => Then(f)(xs).Match(x => x, () => otherwise(xs));
        }
    }

    /// <summary>
    /// シーケンスに対するパターンと、パターンが一致した際の処理を関連付けるためのクラスです。
    /// </summary>
    /// <typeparam name="T">シーケンスの要素の型</typeparam>
    /// <typeparam name="T1">パターンが一致した際の処理が受け取る第1引数の型</typeparam>
    /// <typeparam name="T2">パターンが一致した際の処理が受け取る第2引数の型</typeparam>
    /// <typeparam name="T3">パターンが一致した際の処理が受け取る第3引数の型</typeparam>
    /// <typeparam name="T4">パターンが一致した際の処理が受け取る第4引数の型</typeparam>
    /// <typeparam name="T5">パターンが一致した際の処理が受け取る第5引数の型</typeparam>
    /// <typeparam name="T6">パターンが一致した際の処理が受け取る第6引数の型</typeparam>
    /// <typeparam name="T7">パターンが一致した際の処理が受け取る第7引数の型</typeparam>
    /// <typeparam name="T8">パターンが一致した際の処理が受け取る第8引数の型</typeparam>
    /// <typeparam name="T9">パターンが一致した際の処理が受け取る第9引数の型</typeparam>
    /// <typeparam name="T10">パターンが一致した際の処理が受け取る第10引数の型</typeparam>
    /// <typeparam name="T11">パターンが一致した際の処理が受け取る第11引数の型</typeparam>
    public class SeqPattern<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
    {
        internal readonly IPattern<ISeq<T>, T1> Pat1;
        internal readonly IPattern<ISeq<T>, T2> Pat2;
        internal readonly IPattern<ISeq<T>, T3> Pat3;
        internal readonly IPattern<ISeq<T>, T4> Pat4;
        internal readonly IPattern<ISeq<T>, T5> Pat5;
        internal readonly IPattern<ISeq<T>, T6> Pat6;
        internal readonly IPattern<ISeq<T>, T7> Pat7;
        internal readonly IPattern<ISeq<T>, T8> Pat8;
        internal readonly IPattern<ISeq<T>, T9> Pat9;
        internal readonly IPattern<ISeq<T>, T10> Pat10;
        internal readonly IPattern<ISeq<T>, T11> Pat11;

        /// <summary>
        /// シーケンスに対するパターンを元にオブジェクトを構築します。
        /// </summary>
        /// <param name="pat1">1個目のパターン</param>
        /// <param name="pat2">2個目のパターン</param>
        /// <param name="pat3">3個目のパターン</param>
        /// <param name="pat4">4個目のパターン</param>
        /// <param name="pat5">5個目のパターン</param>
        /// <param name="pat6">6個目のパターン</param>
        /// <param name="pat7">7個目のパターン</param>
        /// <param name="pat8">8個目のパターン</param>
        /// <param name="pat9">9個目のパターン</param>
        /// <param name="pat10">10個目のパターン</param>
        /// <param name="pat11">11個目のパターン</param>
        public SeqPattern(IPattern<ISeq<T>, T1> pat1, IPattern<ISeq<T>, T2> pat2, IPattern<ISeq<T>, T3> pat3, IPattern<ISeq<T>, T4> pat4, IPattern<ISeq<T>, T5> pat5, IPattern<ISeq<T>, T6> pat6, IPattern<ISeq<T>, T7> pat7, IPattern<ISeq<T>, T8> pat8, IPattern<ISeq<T>, T9> pat9, IPattern<ISeq<T>, T10> pat10, IPattern<ISeq<T>, T11> pat11)
        {
            Pat1 = pat1;
            Pat2 = pat2;
            Pat3 = pat3;
            Pat4 = pat4;
            Pat5 = pat5;
            Pat6 = pat6;
            Pat7 = pat7;
            Pat8 = pat8;
            Pat9 = pat9;
            Pat10 = pat10;
            Pat11 = pat11;
        }

        /// <summary>
        /// パターンが一致した際の処理を登録します。
        /// </summary>
        /// <typeparam name="U">処理の結果の型</typeparam>
        /// <param name="f">パターンが一致した際の処理</param>
        /// <returns>処理の結果の型(パターンが一致しなかった場合はNone)</returns>
        public Func<ISeq<T>, Option<U>> Then<U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> f)
        {
            return xs =>
            {
                return
                    from _1 in Pat1.Match(xs)
                    from _2 in Pat2.Match(_1.Next)
                    from _3 in Pat3.Match(_2.Next)
                    from _4 in Pat4.Match(_3.Next)
                    from _5 in Pat5.Match(_4.Next)
                    from _6 in Pat6.Match(_5.Next)
                    from _7 in Pat7.Match(_6.Next)
                    from _8 in Pat8.Match(_7.Next)
                    from _9 in Pat9.Match(_8.Next)
                    from _10 in Pat10.Match(_9.Next)
                    from _11 in Pat11.Match(_10.Next)
                    select f(_1.Result, _2.Result, _3.Result, _4.Result, _5.Result, _6.Result, _7.Result, _8.Result, _9.Result, _10.Result, _11.Result);
            };
        }

        /// <summary>
        /// パターンが一致した際の処理を登録します。
        /// </summary>
        /// <typeparam name="U">処理の結果の型</typeparam>
        /// <param name="f">パターンが一致した際の処理</param>
        /// <param name="otherwise">パターンが一致しなかった際の処理</param>
        /// <returns>処理の結果の型</returns>
        public Func<ISeq<T>, U> Then<U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, U> f, Func<ISeq<T>, U> otherwise)
        {
            return xs => Then(f)(xs).Match(x => x, () => otherwise(xs));
        }
    }

    /// <summary>
    /// シーケンスに対するパターンと、パターンが一致した際の処理を関連付けるためのクラスです。
    /// </summary>
    /// <typeparam name="T">シーケンスの要素の型</typeparam>
    /// <typeparam name="T1">パターンが一致した際の処理が受け取る第1引数の型</typeparam>
    /// <typeparam name="T2">パターンが一致した際の処理が受け取る第2引数の型</typeparam>
    /// <typeparam name="T3">パターンが一致した際の処理が受け取る第3引数の型</typeparam>
    /// <typeparam name="T4">パターンが一致した際の処理が受け取る第4引数の型</typeparam>
    /// <typeparam name="T5">パターンが一致した際の処理が受け取る第5引数の型</typeparam>
    /// <typeparam name="T6">パターンが一致した際の処理が受け取る第6引数の型</typeparam>
    /// <typeparam name="T7">パターンが一致した際の処理が受け取る第7引数の型</typeparam>
    /// <typeparam name="T8">パターンが一致した際の処理が受け取る第8引数の型</typeparam>
    /// <typeparam name="T9">パターンが一致した際の処理が受け取る第9引数の型</typeparam>
    /// <typeparam name="T10">パターンが一致した際の処理が受け取る第10引数の型</typeparam>
    /// <typeparam name="T11">パターンが一致した際の処理が受け取る第11引数の型</typeparam>
    /// <typeparam name="T12">パターンが一致した際の処理が受け取る第12引数の型</typeparam>
    public class SeqPattern<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
    {
        internal readonly IPattern<ISeq<T>, T1> Pat1;
        internal readonly IPattern<ISeq<T>, T2> Pat2;
        internal readonly IPattern<ISeq<T>, T3> Pat3;
        internal readonly IPattern<ISeq<T>, T4> Pat4;
        internal readonly IPattern<ISeq<T>, T5> Pat5;
        internal readonly IPattern<ISeq<T>, T6> Pat6;
        internal readonly IPattern<ISeq<T>, T7> Pat7;
        internal readonly IPattern<ISeq<T>, T8> Pat8;
        internal readonly IPattern<ISeq<T>, T9> Pat9;
        internal readonly IPattern<ISeq<T>, T10> Pat10;
        internal readonly IPattern<ISeq<T>, T11> Pat11;
        internal readonly IPattern<ISeq<T>, T12> Pat12;

        /// <summary>
        /// シーケンスに対するパターンを元にオブジェクトを構築します。
        /// </summary>
        /// <param name="pat1">1個目のパターン</param>
        /// <param name="pat2">2個目のパターン</param>
        /// <param name="pat3">3個目のパターン</param>
        /// <param name="pat4">4個目のパターン</param>
        /// <param name="pat5">5個目のパターン</param>
        /// <param name="pat6">6個目のパターン</param>
        /// <param name="pat7">7個目のパターン</param>
        /// <param name="pat8">8個目のパターン</param>
        /// <param name="pat9">9個目のパターン</param>
        /// <param name="pat10">10個目のパターン</param>
        /// <param name="pat11">11個目のパターン</param>
        /// <param name="pat12">12個目のパターン</param>
        public SeqPattern(IPattern<ISeq<T>, T1> pat1, IPattern<ISeq<T>, T2> pat2, IPattern<ISeq<T>, T3> pat3, IPattern<ISeq<T>, T4> pat4, IPattern<ISeq<T>, T5> pat5, IPattern<ISeq<T>, T6> pat6, IPattern<ISeq<T>, T7> pat7, IPattern<ISeq<T>, T8> pat8, IPattern<ISeq<T>, T9> pat9, IPattern<ISeq<T>, T10> pat10, IPattern<ISeq<T>, T11> pat11, IPattern<ISeq<T>, T12> pat12)
        {
            Pat1 = pat1;
            Pat2 = pat2;
            Pat3 = pat3;
            Pat4 = pat4;
            Pat5 = pat5;
            Pat6 = pat6;
            Pat7 = pat7;
            Pat8 = pat8;
            Pat9 = pat9;
            Pat10 = pat10;
            Pat11 = pat11;
            Pat12 = pat12;
        }

        /// <summary>
        /// パターンが一致した際の処理を登録します。
        /// </summary>
        /// <typeparam name="U">処理の結果の型</typeparam>
        /// <param name="f">パターンが一致した際の処理</param>
        /// <returns>処理の結果の型(パターンが一致しなかった場合はNone)</returns>
        public Func<ISeq<T>, Option<U>> Then<U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> f)
        {
            return xs =>
            {
                return
                    from _1 in Pat1.Match(xs)
                    from _2 in Pat2.Match(_1.Next)
                    from _3 in Pat3.Match(_2.Next)
                    from _4 in Pat4.Match(_3.Next)
                    from _5 in Pat5.Match(_4.Next)
                    from _6 in Pat6.Match(_5.Next)
                    from _7 in Pat7.Match(_6.Next)
                    from _8 in Pat8.Match(_7.Next)
                    from _9 in Pat9.Match(_8.Next)
                    from _10 in Pat10.Match(_9.Next)
                    from _11 in Pat11.Match(_10.Next)
                    from _12 in Pat12.Match(_11.Next)
                    select f(_1.Result, _2.Result, _3.Result, _4.Result, _5.Result, _6.Result, _7.Result, _8.Result, _9.Result, _10.Result, _11.Result, _12.Result);
            };
        }

        /// <summary>
        /// パターンが一致した際の処理を登録します。
        /// </summary>
        /// <typeparam name="U">処理の結果の型</typeparam>
        /// <param name="f">パターンが一致した際の処理</param>
        /// <param name="otherwise">パターンが一致しなかった際の処理</param>
        /// <returns>処理の結果の型</returns>
        public Func<ISeq<T>, U> Then<U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, U> f, Func<ISeq<T>, U> otherwise)
        {
            return xs => Then(f)(xs).Match(x => x, () => otherwise(xs));
        }
    }

    /// <summary>
    /// シーケンスに対するパターンと、パターンが一致した際の処理を関連付けるためのクラスです。
    /// </summary>
    /// <typeparam name="T">シーケンスの要素の型</typeparam>
    /// <typeparam name="T1">パターンが一致した際の処理が受け取る第1引数の型</typeparam>
    /// <typeparam name="T2">パターンが一致した際の処理が受け取る第2引数の型</typeparam>
    /// <typeparam name="T3">パターンが一致した際の処理が受け取る第3引数の型</typeparam>
    /// <typeparam name="T4">パターンが一致した際の処理が受け取る第4引数の型</typeparam>
    /// <typeparam name="T5">パターンが一致した際の処理が受け取る第5引数の型</typeparam>
    /// <typeparam name="T6">パターンが一致した際の処理が受け取る第6引数の型</typeparam>
    /// <typeparam name="T7">パターンが一致した際の処理が受け取る第7引数の型</typeparam>
    /// <typeparam name="T8">パターンが一致した際の処理が受け取る第8引数の型</typeparam>
    /// <typeparam name="T9">パターンが一致した際の処理が受け取る第9引数の型</typeparam>
    /// <typeparam name="T10">パターンが一致した際の処理が受け取る第10引数の型</typeparam>
    /// <typeparam name="T11">パターンが一致した際の処理が受け取る第11引数の型</typeparam>
    /// <typeparam name="T12">パターンが一致した際の処理が受け取る第12引数の型</typeparam>
    /// <typeparam name="T13">パターンが一致した際の処理が受け取る第13引数の型</typeparam>
    public class SeqPattern<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
    {
        internal readonly IPattern<ISeq<T>, T1> Pat1;
        internal readonly IPattern<ISeq<T>, T2> Pat2;
        internal readonly IPattern<ISeq<T>, T3> Pat3;
        internal readonly IPattern<ISeq<T>, T4> Pat4;
        internal readonly IPattern<ISeq<T>, T5> Pat5;
        internal readonly IPattern<ISeq<T>, T6> Pat6;
        internal readonly IPattern<ISeq<T>, T7> Pat7;
        internal readonly IPattern<ISeq<T>, T8> Pat8;
        internal readonly IPattern<ISeq<T>, T9> Pat9;
        internal readonly IPattern<ISeq<T>, T10> Pat10;
        internal readonly IPattern<ISeq<T>, T11> Pat11;
        internal readonly IPattern<ISeq<T>, T12> Pat12;
        internal readonly IPattern<ISeq<T>, T13> Pat13;

        /// <summary>
        /// シーケンスに対するパターンを元にオブジェクトを構築します。
        /// </summary>
        /// <param name="pat1">1個目のパターン</param>
        /// <param name="pat2">2個目のパターン</param>
        /// <param name="pat3">3個目のパターン</param>
        /// <param name="pat4">4個目のパターン</param>
        /// <param name="pat5">5個目のパターン</param>
        /// <param name="pat6">6個目のパターン</param>
        /// <param name="pat7">7個目のパターン</param>
        /// <param name="pat8">8個目のパターン</param>
        /// <param name="pat9">9個目のパターン</param>
        /// <param name="pat10">10個目のパターン</param>
        /// <param name="pat11">11個目のパターン</param>
        /// <param name="pat12">12個目のパターン</param>
        /// <param name="pat13">13個目のパターン</param>
        public SeqPattern(IPattern<ISeq<T>, T1> pat1, IPattern<ISeq<T>, T2> pat2, IPattern<ISeq<T>, T3> pat3, IPattern<ISeq<T>, T4> pat4, IPattern<ISeq<T>, T5> pat5, IPattern<ISeq<T>, T6> pat6, IPattern<ISeq<T>, T7> pat7, IPattern<ISeq<T>, T8> pat8, IPattern<ISeq<T>, T9> pat9, IPattern<ISeq<T>, T10> pat10, IPattern<ISeq<T>, T11> pat11, IPattern<ISeq<T>, T12> pat12, IPattern<ISeq<T>, T13> pat13)
        {
            Pat1 = pat1;
            Pat2 = pat2;
            Pat3 = pat3;
            Pat4 = pat4;
            Pat5 = pat5;
            Pat6 = pat6;
            Pat7 = pat7;
            Pat8 = pat8;
            Pat9 = pat9;
            Pat10 = pat10;
            Pat11 = pat11;
            Pat12 = pat12;
            Pat13 = pat13;
        }

        /// <summary>
        /// パターンが一致した際の処理を登録します。
        /// </summary>
        /// <typeparam name="U">処理の結果の型</typeparam>
        /// <param name="f">パターンが一致した際の処理</param>
        /// <returns>処理の結果の型(パターンが一致しなかった場合はNone)</returns>
        public Func<ISeq<T>, Option<U>> Then<U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> f)
        {
            return xs =>
            {
                return
                    from _1 in Pat1.Match(xs)
                    from _2 in Pat2.Match(_1.Next)
                    from _3 in Pat3.Match(_2.Next)
                    from _4 in Pat4.Match(_3.Next)
                    from _5 in Pat5.Match(_4.Next)
                    from _6 in Pat6.Match(_5.Next)
                    from _7 in Pat7.Match(_6.Next)
                    from _8 in Pat8.Match(_7.Next)
                    from _9 in Pat9.Match(_8.Next)
                    from _10 in Pat10.Match(_9.Next)
                    from _11 in Pat11.Match(_10.Next)
                    from _12 in Pat12.Match(_11.Next)
                    from _13 in Pat13.Match(_12.Next)
                    select f(_1.Result, _2.Result, _3.Result, _4.Result, _5.Result, _6.Result, _7.Result, _8.Result, _9.Result, _10.Result, _11.Result, _12.Result, _13.Result);
            };
        }

        /// <summary>
        /// パターンが一致した際の処理を登録します。
        /// </summary>
        /// <typeparam name="U">処理の結果の型</typeparam>
        /// <param name="f">パターンが一致した際の処理</param>
        /// <param name="otherwise">パターンが一致しなかった際の処理</param>
        /// <returns>処理の結果の型</returns>
        public Func<ISeq<T>, U> Then<U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, U> f, Func<ISeq<T>, U> otherwise)
        {
            return xs => Then(f)(xs).Match(x => x, () => otherwise(xs));
        }
    }

    /// <summary>
    /// シーケンスに対するパターンと、パターンが一致した際の処理を関連付けるためのクラスです。
    /// </summary>
    /// <typeparam name="T">シーケンスの要素の型</typeparam>
    /// <typeparam name="T1">パターンが一致した際の処理が受け取る第1引数の型</typeparam>
    /// <typeparam name="T2">パターンが一致した際の処理が受け取る第2引数の型</typeparam>
    /// <typeparam name="T3">パターンが一致した際の処理が受け取る第3引数の型</typeparam>
    /// <typeparam name="T4">パターンが一致した際の処理が受け取る第4引数の型</typeparam>
    /// <typeparam name="T5">パターンが一致した際の処理が受け取る第5引数の型</typeparam>
    /// <typeparam name="T6">パターンが一致した際の処理が受け取る第6引数の型</typeparam>
    /// <typeparam name="T7">パターンが一致した際の処理が受け取る第7引数の型</typeparam>
    /// <typeparam name="T8">パターンが一致した際の処理が受け取る第8引数の型</typeparam>
    /// <typeparam name="T9">パターンが一致した際の処理が受け取る第9引数の型</typeparam>
    /// <typeparam name="T10">パターンが一致した際の処理が受け取る第10引数の型</typeparam>
    /// <typeparam name="T11">パターンが一致した際の処理が受け取る第11引数の型</typeparam>
    /// <typeparam name="T12">パターンが一致した際の処理が受け取る第12引数の型</typeparam>
    /// <typeparam name="T13">パターンが一致した際の処理が受け取る第13引数の型</typeparam>
    /// <typeparam name="T14">パターンが一致した際の処理が受け取る第14引数の型</typeparam>
    public class SeqPattern<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
    {
        internal readonly IPattern<ISeq<T>, T1> Pat1;
        internal readonly IPattern<ISeq<T>, T2> Pat2;
        internal readonly IPattern<ISeq<T>, T3> Pat3;
        internal readonly IPattern<ISeq<T>, T4> Pat4;
        internal readonly IPattern<ISeq<T>, T5> Pat5;
        internal readonly IPattern<ISeq<T>, T6> Pat6;
        internal readonly IPattern<ISeq<T>, T7> Pat7;
        internal readonly IPattern<ISeq<T>, T8> Pat8;
        internal readonly IPattern<ISeq<T>, T9> Pat9;
        internal readonly IPattern<ISeq<T>, T10> Pat10;
        internal readonly IPattern<ISeq<T>, T11> Pat11;
        internal readonly IPattern<ISeq<T>, T12> Pat12;
        internal readonly IPattern<ISeq<T>, T13> Pat13;
        internal readonly IPattern<ISeq<T>, T14> Pat14;

        /// <summary>
        /// シーケンスに対するパターンを元にオブジェクトを構築します。
        /// </summary>
        /// <param name="pat1">1個目のパターン</param>
        /// <param name="pat2">2個目のパターン</param>
        /// <param name="pat3">3個目のパターン</param>
        /// <param name="pat4">4個目のパターン</param>
        /// <param name="pat5">5個目のパターン</param>
        /// <param name="pat6">6個目のパターン</param>
        /// <param name="pat7">7個目のパターン</param>
        /// <param name="pat8">8個目のパターン</param>
        /// <param name="pat9">9個目のパターン</param>
        /// <param name="pat10">10個目のパターン</param>
        /// <param name="pat11">11個目のパターン</param>
        /// <param name="pat12">12個目のパターン</param>
        /// <param name="pat13">13個目のパターン</param>
        /// <param name="pat14">14個目のパターン</param>
        public SeqPattern(IPattern<ISeq<T>, T1> pat1, IPattern<ISeq<T>, T2> pat2, IPattern<ISeq<T>, T3> pat3, IPattern<ISeq<T>, T4> pat4, IPattern<ISeq<T>, T5> pat5, IPattern<ISeq<T>, T6> pat6, IPattern<ISeq<T>, T7> pat7, IPattern<ISeq<T>, T8> pat8, IPattern<ISeq<T>, T9> pat9, IPattern<ISeq<T>, T10> pat10, IPattern<ISeq<T>, T11> pat11, IPattern<ISeq<T>, T12> pat12, IPattern<ISeq<T>, T13> pat13, IPattern<ISeq<T>, T14> pat14)
        {
            Pat1 = pat1;
            Pat2 = pat2;
            Pat3 = pat3;
            Pat4 = pat4;
            Pat5 = pat5;
            Pat6 = pat6;
            Pat7 = pat7;
            Pat8 = pat8;
            Pat9 = pat9;
            Pat10 = pat10;
            Pat11 = pat11;
            Pat12 = pat12;
            Pat13 = pat13;
            Pat14 = pat14;
        }

        /// <summary>
        /// パターンが一致した際の処理を登録します。
        /// </summary>
        /// <typeparam name="U">処理の結果の型</typeparam>
        /// <param name="f">パターンが一致した際の処理</param>
        /// <returns>処理の結果の型(パターンが一致しなかった場合はNone)</returns>
        public Func<ISeq<T>, Option<U>> Then<U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> f)
        {
            return xs =>
            {
                return
                    from _1 in Pat1.Match(xs)
                    from _2 in Pat2.Match(_1.Next)
                    from _3 in Pat3.Match(_2.Next)
                    from _4 in Pat4.Match(_3.Next)
                    from _5 in Pat5.Match(_4.Next)
                    from _6 in Pat6.Match(_5.Next)
                    from _7 in Pat7.Match(_6.Next)
                    from _8 in Pat8.Match(_7.Next)
                    from _9 in Pat9.Match(_8.Next)
                    from _10 in Pat10.Match(_9.Next)
                    from _11 in Pat11.Match(_10.Next)
                    from _12 in Pat12.Match(_11.Next)
                    from _13 in Pat13.Match(_12.Next)
                    from _14 in Pat14.Match(_13.Next)
                    select f(_1.Result, _2.Result, _3.Result, _4.Result, _5.Result, _6.Result, _7.Result, _8.Result, _9.Result, _10.Result, _11.Result, _12.Result, _13.Result, _14.Result);
            };
        }

        /// <summary>
        /// パターンが一致した際の処理を登録します。
        /// </summary>
        /// <typeparam name="U">処理の結果の型</typeparam>
        /// <param name="f">パターンが一致した際の処理</param>
        /// <param name="otherwise">パターンが一致しなかった際の処理</param>
        /// <returns>処理の結果の型</returns>
        public Func<ISeq<T>, U> Then<U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, U> f, Func<ISeq<T>, U> otherwise)
        {
            return xs => Then(f)(xs).Match(x => x, () => otherwise(xs));
        }
    }

    /// <summary>
    /// シーケンスに対するパターンと、パターンが一致した際の処理を関連付けるためのクラスです。
    /// </summary>
    /// <typeparam name="T">シーケンスの要素の型</typeparam>
    /// <typeparam name="T1">パターンが一致した際の処理が受け取る第1引数の型</typeparam>
    /// <typeparam name="T2">パターンが一致した際の処理が受け取る第2引数の型</typeparam>
    /// <typeparam name="T3">パターンが一致した際の処理が受け取る第3引数の型</typeparam>
    /// <typeparam name="T4">パターンが一致した際の処理が受け取る第4引数の型</typeparam>
    /// <typeparam name="T5">パターンが一致した際の処理が受け取る第5引数の型</typeparam>
    /// <typeparam name="T6">パターンが一致した際の処理が受け取る第6引数の型</typeparam>
    /// <typeparam name="T7">パターンが一致した際の処理が受け取る第7引数の型</typeparam>
    /// <typeparam name="T8">パターンが一致した際の処理が受け取る第8引数の型</typeparam>
    /// <typeparam name="T9">パターンが一致した際の処理が受け取る第9引数の型</typeparam>
    /// <typeparam name="T10">パターンが一致した際の処理が受け取る第10引数の型</typeparam>
    /// <typeparam name="T11">パターンが一致した際の処理が受け取る第11引数の型</typeparam>
    /// <typeparam name="T12">パターンが一致した際の処理が受け取る第12引数の型</typeparam>
    /// <typeparam name="T13">パターンが一致した際の処理が受け取る第13引数の型</typeparam>
    /// <typeparam name="T14">パターンが一致した際の処理が受け取る第14引数の型</typeparam>
    /// <typeparam name="T15">パターンが一致した際の処理が受け取る第15引数の型</typeparam>
    public class SeqPattern<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
    {
        internal readonly IPattern<ISeq<T>, T1> Pat1;
        internal readonly IPattern<ISeq<T>, T2> Pat2;
        internal readonly IPattern<ISeq<T>, T3> Pat3;
        internal readonly IPattern<ISeq<T>, T4> Pat4;
        internal readonly IPattern<ISeq<T>, T5> Pat5;
        internal readonly IPattern<ISeq<T>, T6> Pat6;
        internal readonly IPattern<ISeq<T>, T7> Pat7;
        internal readonly IPattern<ISeq<T>, T8> Pat8;
        internal readonly IPattern<ISeq<T>, T9> Pat9;
        internal readonly IPattern<ISeq<T>, T10> Pat10;
        internal readonly IPattern<ISeq<T>, T11> Pat11;
        internal readonly IPattern<ISeq<T>, T12> Pat12;
        internal readonly IPattern<ISeq<T>, T13> Pat13;
        internal readonly IPattern<ISeq<T>, T14> Pat14;
        internal readonly IPattern<ISeq<T>, T15> Pat15;

        /// <summary>
        /// シーケンスに対するパターンを元にオブジェクトを構築します。
        /// </summary>
        /// <param name="pat1">1個目のパターン</param>
        /// <param name="pat2">2個目のパターン</param>
        /// <param name="pat3">3個目のパターン</param>
        /// <param name="pat4">4個目のパターン</param>
        /// <param name="pat5">5個目のパターン</param>
        /// <param name="pat6">6個目のパターン</param>
        /// <param name="pat7">7個目のパターン</param>
        /// <param name="pat8">8個目のパターン</param>
        /// <param name="pat9">9個目のパターン</param>
        /// <param name="pat10">10個目のパターン</param>
        /// <param name="pat11">11個目のパターン</param>
        /// <param name="pat12">12個目のパターン</param>
        /// <param name="pat13">13個目のパターン</param>
        /// <param name="pat14">14個目のパターン</param>
        /// <param name="pat15">15個目のパターン</param>
        public SeqPattern(IPattern<ISeq<T>, T1> pat1, IPattern<ISeq<T>, T2> pat2, IPattern<ISeq<T>, T3> pat3, IPattern<ISeq<T>, T4> pat4, IPattern<ISeq<T>, T5> pat5, IPattern<ISeq<T>, T6> pat6, IPattern<ISeq<T>, T7> pat7, IPattern<ISeq<T>, T8> pat8, IPattern<ISeq<T>, T9> pat9, IPattern<ISeq<T>, T10> pat10, IPattern<ISeq<T>, T11> pat11, IPattern<ISeq<T>, T12> pat12, IPattern<ISeq<T>, T13> pat13, IPattern<ISeq<T>, T14> pat14, IPattern<ISeq<T>, T15> pat15)
        {
            Pat1 = pat1;
            Pat2 = pat2;
            Pat3 = pat3;
            Pat4 = pat4;
            Pat5 = pat5;
            Pat6 = pat6;
            Pat7 = pat7;
            Pat8 = pat8;
            Pat9 = pat9;
            Pat10 = pat10;
            Pat11 = pat11;
            Pat12 = pat12;
            Pat13 = pat13;
            Pat14 = pat14;
            Pat15 = pat15;
        }

        /// <summary>
        /// パターンが一致した際の処理を登録します。
        /// </summary>
        /// <typeparam name="U">処理の結果の型</typeparam>
        /// <param name="f">パターンが一致した際の処理</param>
        /// <returns>処理の結果の型(パターンが一致しなかった場合はNone)</returns>
        public Func<ISeq<T>, Option<U>> Then<U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> f)
        {
            return xs =>
            {
                return
                    from _1 in Pat1.Match(xs)
                    from _2 in Pat2.Match(_1.Next)
                    from _3 in Pat3.Match(_2.Next)
                    from _4 in Pat4.Match(_3.Next)
                    from _5 in Pat5.Match(_4.Next)
                    from _6 in Pat6.Match(_5.Next)
                    from _7 in Pat7.Match(_6.Next)
                    from _8 in Pat8.Match(_7.Next)
                    from _9 in Pat9.Match(_8.Next)
                    from _10 in Pat10.Match(_9.Next)
                    from _11 in Pat11.Match(_10.Next)
                    from _12 in Pat12.Match(_11.Next)
                    from _13 in Pat13.Match(_12.Next)
                    from _14 in Pat14.Match(_13.Next)
                    from _15 in Pat15.Match(_14.Next)
                    select f(_1.Result, _2.Result, _3.Result, _4.Result, _5.Result, _6.Result, _7.Result, _8.Result, _9.Result, _10.Result, _11.Result, _12.Result, _13.Result, _14.Result, _15.Result);
            };
        }

        /// <summary>
        /// パターンが一致した際の処理を登録します。
        /// </summary>
        /// <typeparam name="U">処理の結果の型</typeparam>
        /// <param name="f">パターンが一致した際の処理</param>
        /// <param name="otherwise">パターンが一致しなかった際の処理</param>
        /// <returns>処理の結果の型</returns>
        public Func<ISeq<T>, U> Then<U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, U> f, Func<ISeq<T>, U> otherwise)
        {
            return xs => Then(f)(xs).Match(x => x, () => otherwise(xs));
        }
    }

    /// <summary>
    /// シーケンスに対するパターンと、パターンが一致した際の処理を関連付けるためのクラスです。
    /// </summary>
    /// <typeparam name="T">シーケンスの要素の型</typeparam>
    /// <typeparam name="T1">パターンが一致した際の処理が受け取る第1引数の型</typeparam>
    /// <typeparam name="T2">パターンが一致した際の処理が受け取る第2引数の型</typeparam>
    /// <typeparam name="T3">パターンが一致した際の処理が受け取る第3引数の型</typeparam>
    /// <typeparam name="T4">パターンが一致した際の処理が受け取る第4引数の型</typeparam>
    /// <typeparam name="T5">パターンが一致した際の処理が受け取る第5引数の型</typeparam>
    /// <typeparam name="T6">パターンが一致した際の処理が受け取る第6引数の型</typeparam>
    /// <typeparam name="T7">パターンが一致した際の処理が受け取る第7引数の型</typeparam>
    /// <typeparam name="T8">パターンが一致した際の処理が受け取る第8引数の型</typeparam>
    /// <typeparam name="T9">パターンが一致した際の処理が受け取る第9引数の型</typeparam>
    /// <typeparam name="T10">パターンが一致した際の処理が受け取る第10引数の型</typeparam>
    /// <typeparam name="T11">パターンが一致した際の処理が受け取る第11引数の型</typeparam>
    /// <typeparam name="T12">パターンが一致した際の処理が受け取る第12引数の型</typeparam>
    /// <typeparam name="T13">パターンが一致した際の処理が受け取る第13引数の型</typeparam>
    /// <typeparam name="T14">パターンが一致した際の処理が受け取る第14引数の型</typeparam>
    /// <typeparam name="T15">パターンが一致した際の処理が受け取る第15引数の型</typeparam>
    /// <typeparam name="T16">パターンが一致した際の処理が受け取る第16引数の型</typeparam>
    public class SeqPattern<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
    {
        internal readonly IPattern<ISeq<T>, T1> Pat1;
        internal readonly IPattern<ISeq<T>, T2> Pat2;
        internal readonly IPattern<ISeq<T>, T3> Pat3;
        internal readonly IPattern<ISeq<T>, T4> Pat4;
        internal readonly IPattern<ISeq<T>, T5> Pat5;
        internal readonly IPattern<ISeq<T>, T6> Pat6;
        internal readonly IPattern<ISeq<T>, T7> Pat7;
        internal readonly IPattern<ISeq<T>, T8> Pat8;
        internal readonly IPattern<ISeq<T>, T9> Pat9;
        internal readonly IPattern<ISeq<T>, T10> Pat10;
        internal readonly IPattern<ISeq<T>, T11> Pat11;
        internal readonly IPattern<ISeq<T>, T12> Pat12;
        internal readonly IPattern<ISeq<T>, T13> Pat13;
        internal readonly IPattern<ISeq<T>, T14> Pat14;
        internal readonly IPattern<ISeq<T>, T15> Pat15;
        internal readonly IPattern<ISeq<T>, T16> Pat16;

        /// <summary>
        /// シーケンスに対するパターンを元にオブジェクトを構築します。
        /// </summary>
        /// <param name="pat1">1個目のパターン</param>
        /// <param name="pat2">2個目のパターン</param>
        /// <param name="pat3">3個目のパターン</param>
        /// <param name="pat4">4個目のパターン</param>
        /// <param name="pat5">5個目のパターン</param>
        /// <param name="pat6">6個目のパターン</param>
        /// <param name="pat7">7個目のパターン</param>
        /// <param name="pat8">8個目のパターン</param>
        /// <param name="pat9">9個目のパターン</param>
        /// <param name="pat10">10個目のパターン</param>
        /// <param name="pat11">11個目のパターン</param>
        /// <param name="pat12">12個目のパターン</param>
        /// <param name="pat13">13個目のパターン</param>
        /// <param name="pat14">14個目のパターン</param>
        /// <param name="pat15">15個目のパターン</param>
        /// <param name="pat16">16個目のパターン</param>
        public SeqPattern(IPattern<ISeq<T>, T1> pat1, IPattern<ISeq<T>, T2> pat2, IPattern<ISeq<T>, T3> pat3, IPattern<ISeq<T>, T4> pat4, IPattern<ISeq<T>, T5> pat5, IPattern<ISeq<T>, T6> pat6, IPattern<ISeq<T>, T7> pat7, IPattern<ISeq<T>, T8> pat8, IPattern<ISeq<T>, T9> pat9, IPattern<ISeq<T>, T10> pat10, IPattern<ISeq<T>, T11> pat11, IPattern<ISeq<T>, T12> pat12, IPattern<ISeq<T>, T13> pat13, IPattern<ISeq<T>, T14> pat14, IPattern<ISeq<T>, T15> pat15, IPattern<ISeq<T>, T16> pat16)
        {
            Pat1 = pat1;
            Pat2 = pat2;
            Pat3 = pat3;
            Pat4 = pat4;
            Pat5 = pat5;
            Pat6 = pat6;
            Pat7 = pat7;
            Pat8 = pat8;
            Pat9 = pat9;
            Pat10 = pat10;
            Pat11 = pat11;
            Pat12 = pat12;
            Pat13 = pat13;
            Pat14 = pat14;
            Pat15 = pat15;
            Pat16 = pat16;
        }

        /// <summary>
        /// パターンが一致した際の処理を登録します。
        /// </summary>
        /// <typeparam name="U">処理の結果の型</typeparam>
        /// <param name="f">パターンが一致した際の処理</param>
        /// <returns>処理の結果の型(パターンが一致しなかった場合はNone)</returns>
        public Func<ISeq<T>, Option<U>> Then<U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> f)
        {
            return xs =>
            {
                return
                    from _1 in Pat1.Match(xs)
                    from _2 in Pat2.Match(_1.Next)
                    from _3 in Pat3.Match(_2.Next)
                    from _4 in Pat4.Match(_3.Next)
                    from _5 in Pat5.Match(_4.Next)
                    from _6 in Pat6.Match(_5.Next)
                    from _7 in Pat7.Match(_6.Next)
                    from _8 in Pat8.Match(_7.Next)
                    from _9 in Pat9.Match(_8.Next)
                    from _10 in Pat10.Match(_9.Next)
                    from _11 in Pat11.Match(_10.Next)
                    from _12 in Pat12.Match(_11.Next)
                    from _13 in Pat13.Match(_12.Next)
                    from _14 in Pat14.Match(_13.Next)
                    from _15 in Pat15.Match(_14.Next)
                    from _16 in Pat16.Match(_15.Next)
                    select f(_1.Result, _2.Result, _3.Result, _4.Result, _5.Result, _6.Result, _7.Result, _8.Result, _9.Result, _10.Result, _11.Result, _12.Result, _13.Result, _14.Result, _15.Result, _16.Result);
            };
        }

        /// <summary>
        /// パターンが一致した際の処理を登録します。
        /// </summary>
        /// <typeparam name="U">処理の結果の型</typeparam>
        /// <param name="f">パターンが一致した際の処理</param>
        /// <param name="otherwise">パターンが一致しなかった際の処理</param>
        /// <returns>処理の結果の型</returns>
        public Func<ISeq<T>, U> Then<U>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, U> f, Func<ISeq<T>, U> otherwise)
        {
            return xs => Then(f)(xs).Match(x => x, () => otherwise(xs));
        }
    }

}