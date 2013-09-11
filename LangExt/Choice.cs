
using System;
using System.ComponentModel;

namespace LangExt
{
    /// <summary>
    /// 複数の型のうち、どれか一つを保持する「多者択一」を表す型です。
    /// 成功と失敗を保持したい場合、この型ではなくResult[TSuccess, TFailure]型を使ってください。
    /// この型は、二つの型の違いにほとんど意味がない場合に使います。
    /// </summary>
    public sealed class Choice<T1, T2> : IEquatable<Choice<T1, T2>>
    {
        internal readonly Option<T1> Case1;
        internal readonly Option<T2> Case2;

        /// <summary>
        /// 何番目の型を保持しているかを取得します。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int TagIndex { get { return this.Match(_ => 1, _ => 2); } }

        /// <summary>
        /// T1を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T1 value) { Case1 = new Option<T1>(value); }

        /// <summary>
        /// T1型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2>(T1 value) { return new Choice<T1, T2>(value); }

        /// <summary>
        /// T2を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T2 value) { Case2 = new Option<T2>(value); }

        /// <summary>
        /// T2型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2>(T2 value) { return new Choice<T1, T2>(value); }

        /// <summary>
        /// 擬似的にパターンマッチを行います。
        /// </summary>
        public T Match<T>(Func<T1, T> Case1, Func<T2, T> Case2)
        {
            Func<T> thrower = () => { throw new InvalidOperationException(); };
            return this.Case1.Match<T>(Case1, () => this.Case2.Match<T>(Case2, thrower));
        }

        /// <summary>
        /// 擬似的にパターンマッチを行います。
        /// </summary>
        public void Match(Action<T1> Case1, Action<T2> Case2)
        {
            Action thrower = () => { throw new InvalidOperationException(); };
            this.Case1.Match(Case1, () => this.Case2.Match(Case2, thrower));
        }

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較するChoice</param>
        /// <returns>現在のオブジェクトがotherで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        public bool Equals(Choice<T1, T2> other)
        {
            return other.IsNotNull() && Case1 == other.Case1 && Case2 == other.Case2;
        }

        /// <summary>
        /// 2つのChoceの比較を行います。 
        /// </summary>
        /// <param name="a">1つ目のChoice</param>
        /// <param name="b">2つ目のChoice</param>
        /// <returns>2つのChoiceが等しい場合はtrue、それ以外の場合はfalse</returns>
        public static bool operator ==(Choice<T1, T2> a, Choice<T1, T2> b)
        {
            if (a.IsNull())
                return b.IsNull();
            return a.Equals(b);
        }

        /// <summary>
        /// 2つのChoceの比較を行います。 
        /// </summary>
        /// <param name="a">1つ目のChoice</param>
        /// <param name="b">2つ目のChoice</param>
        /// <returns>2つのChoiceが等しい場合はfalse、それ以外の場合はtrue</returns>
        public static bool operator !=(Choice<T1, T2> a, Choice<T1, T2> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト</param>
        /// <returns>現在のオブジェクトがobjで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            var other = obj as Choice<T1, T2>;
            if (other.IsNull())
                return false;
            return Equals(other);
        }

        /// <summary>
        /// オブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>ハッシュコード</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            var result = 31;
            result ^= Case1.GetHashCode();
            result ^= Case2.GetHashCode();
            return result;
        }

        /// <summary>
        /// このオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>このオブジェクトの文字列表現</returns>
        public override string ToString()
        {
            return Match(
                t1 => string.Format("Choice({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Choice({0}:{1})", t2, typeof(T2).Name)
            );
        }
    }

    /// <summary>
    /// 複数の型のうち、どれか一つを保持する「多者択一」を表す型です。
    /// </summary>
    public sealed class Choice<T1, T2, T3> : IEquatable<Choice<T1, T2, T3>>
    {
        internal readonly Option<T1> Case1;
        internal readonly Option<T2> Case2;
        internal readonly Option<T3> Case3;

        /// <summary>
        /// 何番目の型を保持しているかを取得します。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int TagIndex { get { return this.Match(_ => 1, _ => 2, _ => 3); } }

        /// <summary>
        /// T1を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T1 value) { Case1 = new Option<T1>(value); }

        /// <summary>
        /// T1型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3>(T1 value) { return new Choice<T1, T2, T3>(value); }

        /// <summary>
        /// T2を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T2 value) { Case2 = new Option<T2>(value); }

        /// <summary>
        /// T2型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3>(T2 value) { return new Choice<T1, T2, T3>(value); }

        /// <summary>
        /// T3を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T3 value) { Case3 = new Option<T3>(value); }

        /// <summary>
        /// T3型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3>(T3 value) { return new Choice<T1, T2, T3>(value); }

        /// <summary>
        /// 擬似的にパターンマッチを行います。
        /// </summary>
        public T Match<T>(Func<T1, T> Case1, Func<T2, T> Case2, Func<T3, T> Case3)
        {
            Func<T> thrower = () => { throw new InvalidOperationException(); };
            return this.Case1.Match<T>(Case1, () => this.Case2.Match<T>(Case2, () => this.Case3.Match<T>(Case3, thrower)));
        }

        /// <summary>
        /// 擬似的にパターンマッチを行います。
        /// </summary>
        public void Match(Action<T1> Case1, Action<T2> Case2, Action<T3> Case3)
        {
            Action thrower = () => { throw new InvalidOperationException(); };
            this.Case1.Match(Case1, () => this.Case2.Match(Case2, () => this.Case3.Match(Case3, thrower)));
        }

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較するChoice</param>
        /// <returns>現在のオブジェクトがotherで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        public bool Equals(Choice<T1, T2, T3> other)
        {
            return other.IsNotNull() && Case1 == other.Case1 && Case2 == other.Case2 && Case3 == other.Case3;
        }

        /// <summary>
        /// 2つのChoceの比較を行います。 
        /// </summary>
        /// <param name="a">1つ目のChoice</param>
        /// <param name="b">2つ目のChoice</param>
        /// <returns>2つのChoiceが等しい場合はtrue、それ以外の場合はfalse</returns>
        public static bool operator ==(Choice<T1, T2, T3> a, Choice<T1, T2, T3> b)
        {
            if (a.IsNull())
                return b.IsNull();
            return a.Equals(b);
        }

        /// <summary>
        /// 2つのChoceの比較を行います。 
        /// </summary>
        /// <param name="a">1つ目のChoice</param>
        /// <param name="b">2つ目のChoice</param>
        /// <returns>2つのChoiceが等しい場合はfalse、それ以外の場合はtrue</returns>
        public static bool operator !=(Choice<T1, T2, T3> a, Choice<T1, T2, T3> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト</param>
        /// <returns>現在のオブジェクトがobjで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            var other = obj as Choice<T1, T2, T3>;
            if (other.IsNull())
                return false;
            return Equals(other);
        }

        /// <summary>
        /// オブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>ハッシュコード</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            var result = 31;
            result ^= Case1.GetHashCode();
            result ^= Case2.GetHashCode();
            result ^= Case3.GetHashCode();
            return result;
        }

        /// <summary>
        /// このオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>このオブジェクトの文字列表現</returns>
        public override string ToString()
        {
            return Match(
                t1 => string.Format("Choice({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Choice({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Choice({0}:{1})", t3, typeof(T3).Name)
            );
        }
    }

    /// <summary>
    /// 複数の型のうち、どれか一つを保持する「多者択一」を表す型です。
    /// </summary>
    public sealed class Choice<T1, T2, T3, T4> : IEquatable<Choice<T1, T2, T3, T4>>
    {
        internal readonly Option<T1> Case1;
        internal readonly Option<T2> Case2;
        internal readonly Option<T3> Case3;
        internal readonly Option<T4> Case4;

        /// <summary>
        /// 何番目の型を保持しているかを取得します。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int TagIndex { get { return this.Match(_ => 1, _ => 2, _ => 3, _ => 4); } }

        /// <summary>
        /// T1を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T1 value) { Case1 = new Option<T1>(value); }

        /// <summary>
        /// T1型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4>(T1 value) { return new Choice<T1, T2, T3, T4>(value); }

        /// <summary>
        /// T2を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T2 value) { Case2 = new Option<T2>(value); }

        /// <summary>
        /// T2型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4>(T2 value) { return new Choice<T1, T2, T3, T4>(value); }

        /// <summary>
        /// T3を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T3 value) { Case3 = new Option<T3>(value); }

        /// <summary>
        /// T3型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4>(T3 value) { return new Choice<T1, T2, T3, T4>(value); }

        /// <summary>
        /// T4を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T4 value) { Case4 = new Option<T4>(value); }

        /// <summary>
        /// T4型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4>(T4 value) { return new Choice<T1, T2, T3, T4>(value); }

        /// <summary>
        /// 擬似的にパターンマッチを行います。
        /// </summary>
        public T Match<T>(Func<T1, T> Case1, Func<T2, T> Case2, Func<T3, T> Case3, Func<T4, T> Case4)
        {
            Func<T> thrower = () => { throw new InvalidOperationException(); };
            return this.Case1.Match<T>(Case1, () => this.Case2.Match<T>(Case2, () => this.Case3.Match<T>(Case3, () => this.Case4.Match<T>(Case4, thrower))));
        }

        /// <summary>
        /// 擬似的にパターンマッチを行います。
        /// </summary>
        public void Match(Action<T1> Case1, Action<T2> Case2, Action<T3> Case3, Action<T4> Case4)
        {
            Action thrower = () => { throw new InvalidOperationException(); };
            this.Case1.Match(Case1, () => this.Case2.Match(Case2, () => this.Case3.Match(Case3, () => this.Case4.Match(Case4, thrower))));
        }

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較するChoice</param>
        /// <returns>現在のオブジェクトがotherで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        public bool Equals(Choice<T1, T2, T3, T4> other)
        {
            return other.IsNotNull() && Case1 == other.Case1 && Case2 == other.Case2 && Case3 == other.Case3 && Case4 == other.Case4;
        }

        /// <summary>
        /// 2つのChoceの比較を行います。 
        /// </summary>
        /// <param name="a">1つ目のChoice</param>
        /// <param name="b">2つ目のChoice</param>
        /// <returns>2つのChoiceが等しい場合はtrue、それ以外の場合はfalse</returns>
        public static bool operator ==(Choice<T1, T2, T3, T4> a, Choice<T1, T2, T3, T4> b)
        {
            if (a.IsNull())
                return b.IsNull();
            return a.Equals(b);
        }

        /// <summary>
        /// 2つのChoceの比較を行います。 
        /// </summary>
        /// <param name="a">1つ目のChoice</param>
        /// <param name="b">2つ目のChoice</param>
        /// <returns>2つのChoiceが等しい場合はfalse、それ以外の場合はtrue</returns>
        public static bool operator !=(Choice<T1, T2, T3, T4> a, Choice<T1, T2, T3, T4> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト</param>
        /// <returns>現在のオブジェクトがobjで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            var other = obj as Choice<T1, T2, T3, T4>;
            if (other.IsNull())
                return false;
            return Equals(other);
        }

        /// <summary>
        /// オブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>ハッシュコード</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            var result = 31;
            result ^= Case1.GetHashCode();
            result ^= Case2.GetHashCode();
            result ^= Case3.GetHashCode();
            result ^= Case4.GetHashCode();
            return result;
        }

        /// <summary>
        /// このオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>このオブジェクトの文字列表現</returns>
        public override string ToString()
        {
            return Match(
                t1 => string.Format("Choice({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Choice({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Choice({0}:{1})", t3, typeof(T3).Name),
                t4 => string.Format("Choice({0}:{1})", t4, typeof(T4).Name)
            );
        }
    }

    /// <summary>
    /// 複数の型のうち、どれか一つを保持する「多者択一」を表す型です。
    /// </summary>
    public sealed class Choice<T1, T2, T3, T4, T5> : IEquatable<Choice<T1, T2, T3, T4, T5>>
    {
        internal readonly Option<T1> Case1;
        internal readonly Option<T2> Case2;
        internal readonly Option<T3> Case3;
        internal readonly Option<T4> Case4;
        internal readonly Option<T5> Case5;

        /// <summary>
        /// 何番目の型を保持しているかを取得します。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int TagIndex { get { return this.Match(_ => 1, _ => 2, _ => 3, _ => 4, _ => 5); } }

        /// <summary>
        /// T1を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T1 value) { Case1 = new Option<T1>(value); }

        /// <summary>
        /// T1型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5>(T1 value) { return new Choice<T1, T2, T3, T4, T5>(value); }

        /// <summary>
        /// T2を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T2 value) { Case2 = new Option<T2>(value); }

        /// <summary>
        /// T2型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5>(T2 value) { return new Choice<T1, T2, T3, T4, T5>(value); }

        /// <summary>
        /// T3を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T3 value) { Case3 = new Option<T3>(value); }

        /// <summary>
        /// T3型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5>(T3 value) { return new Choice<T1, T2, T3, T4, T5>(value); }

        /// <summary>
        /// T4を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T4 value) { Case4 = new Option<T4>(value); }

        /// <summary>
        /// T4型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5>(T4 value) { return new Choice<T1, T2, T3, T4, T5>(value); }

        /// <summary>
        /// T5を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T5 value) { Case5 = new Option<T5>(value); }

        /// <summary>
        /// T5型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5>(T5 value) { return new Choice<T1, T2, T3, T4, T5>(value); }

        /// <summary>
        /// 擬似的にパターンマッチを行います。
        /// </summary>
        public T Match<T>(Func<T1, T> Case1, Func<T2, T> Case2, Func<T3, T> Case3, Func<T4, T> Case4, Func<T5, T> Case5)
        {
            Func<T> thrower = () => { throw new InvalidOperationException(); };
            return this.Case1.Match<T>(Case1, () => this.Case2.Match<T>(Case2, () => this.Case3.Match<T>(Case3, () => this.Case4.Match<T>(Case4, () => this.Case5.Match<T>(Case5, thrower)))));
        }

        /// <summary>
        /// 擬似的にパターンマッチを行います。
        /// </summary>
        public void Match(Action<T1> Case1, Action<T2> Case2, Action<T3> Case3, Action<T4> Case4, Action<T5> Case5)
        {
            Action thrower = () => { throw new InvalidOperationException(); };
            this.Case1.Match(Case1, () => this.Case2.Match(Case2, () => this.Case3.Match(Case3, () => this.Case4.Match(Case4, () => this.Case5.Match(Case5, thrower)))));
        }

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較するChoice</param>
        /// <returns>現在のオブジェクトがotherで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        public bool Equals(Choice<T1, T2, T3, T4, T5> other)
        {
            return other.IsNotNull() && Case1 == other.Case1 && Case2 == other.Case2 && Case3 == other.Case3 && Case4 == other.Case4 && Case5 == other.Case5;
        }

        /// <summary>
        /// 2つのChoceの比較を行います。 
        /// </summary>
        /// <param name="a">1つ目のChoice</param>
        /// <param name="b">2つ目のChoice</param>
        /// <returns>2つのChoiceが等しい場合はtrue、それ以外の場合はfalse</returns>
        public static bool operator ==(Choice<T1, T2, T3, T4, T5> a, Choice<T1, T2, T3, T4, T5> b)
        {
            if (a.IsNull())
                return b.IsNull();
            return a.Equals(b);
        }

        /// <summary>
        /// 2つのChoceの比較を行います。 
        /// </summary>
        /// <param name="a">1つ目のChoice</param>
        /// <param name="b">2つ目のChoice</param>
        /// <returns>2つのChoiceが等しい場合はfalse、それ以外の場合はtrue</returns>
        public static bool operator !=(Choice<T1, T2, T3, T4, T5> a, Choice<T1, T2, T3, T4, T5> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト</param>
        /// <returns>現在のオブジェクトがobjで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            var other = obj as Choice<T1, T2, T3, T4, T5>;
            if (other.IsNull())
                return false;
            return Equals(other);
        }

        /// <summary>
        /// オブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>ハッシュコード</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            var result = 31;
            result ^= Case1.GetHashCode();
            result ^= Case2.GetHashCode();
            result ^= Case3.GetHashCode();
            result ^= Case4.GetHashCode();
            result ^= Case5.GetHashCode();
            return result;
        }

        /// <summary>
        /// このオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>このオブジェクトの文字列表現</returns>
        public override string ToString()
        {
            return Match(
                t1 => string.Format("Choice({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Choice({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Choice({0}:{1})", t3, typeof(T3).Name),
                t4 => string.Format("Choice({0}:{1})", t4, typeof(T4).Name),
                t5 => string.Format("Choice({0}:{1})", t5, typeof(T5).Name)
            );
        }
    }

    /// <summary>
    /// 複数の型のうち、どれか一つを保持する「多者択一」を表す型です。
    /// </summary>
    public sealed class Choice<T1, T2, T3, T4, T5, T6> : IEquatable<Choice<T1, T2, T3, T4, T5, T6>>
    {
        internal readonly Option<T1> Case1;
        internal readonly Option<T2> Case2;
        internal readonly Option<T3> Case3;
        internal readonly Option<T4> Case4;
        internal readonly Option<T5> Case5;
        internal readonly Option<T6> Case6;

        /// <summary>
        /// 何番目の型を保持しているかを取得します。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int TagIndex { get { return this.Match(_ => 1, _ => 2, _ => 3, _ => 4, _ => 5, _ => 6); } }

        /// <summary>
        /// T1を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T1 value) { Case1 = new Option<T1>(value); }

        /// <summary>
        /// T1型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6>(T1 value) { return new Choice<T1, T2, T3, T4, T5, T6>(value); }

        /// <summary>
        /// T2を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T2 value) { Case2 = new Option<T2>(value); }

        /// <summary>
        /// T2型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6>(T2 value) { return new Choice<T1, T2, T3, T4, T5, T6>(value); }

        /// <summary>
        /// T3を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T3 value) { Case3 = new Option<T3>(value); }

        /// <summary>
        /// T3型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6>(T3 value) { return new Choice<T1, T2, T3, T4, T5, T6>(value); }

        /// <summary>
        /// T4を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T4 value) { Case4 = new Option<T4>(value); }

        /// <summary>
        /// T4型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6>(T4 value) { return new Choice<T1, T2, T3, T4, T5, T6>(value); }

        /// <summary>
        /// T5を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T5 value) { Case5 = new Option<T5>(value); }

        /// <summary>
        /// T5型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6>(T5 value) { return new Choice<T1, T2, T3, T4, T5, T6>(value); }

        /// <summary>
        /// T6を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T6 value) { Case6 = new Option<T6>(value); }

        /// <summary>
        /// T6型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6>(T6 value) { return new Choice<T1, T2, T3, T4, T5, T6>(value); }

        /// <summary>
        /// 擬似的にパターンマッチを行います。
        /// </summary>
        public T Match<T>(Func<T1, T> Case1, Func<T2, T> Case2, Func<T3, T> Case3, Func<T4, T> Case4, Func<T5, T> Case5, Func<T6, T> Case6)
        {
            Func<T> thrower = () => { throw new InvalidOperationException(); };
            return this.Case1.Match<T>(Case1, () => this.Case2.Match<T>(Case2, () => this.Case3.Match<T>(Case3, () => this.Case4.Match<T>(Case4, () => this.Case5.Match<T>(Case5, () => this.Case6.Match<T>(Case6, thrower))))));
        }

        /// <summary>
        /// 擬似的にパターンマッチを行います。
        /// </summary>
        public void Match(Action<T1> Case1, Action<T2> Case2, Action<T3> Case3, Action<T4> Case4, Action<T5> Case5, Action<T6> Case6)
        {
            Action thrower = () => { throw new InvalidOperationException(); };
            this.Case1.Match(Case1, () => this.Case2.Match(Case2, () => this.Case3.Match(Case3, () => this.Case4.Match(Case4, () => this.Case5.Match(Case5, () => this.Case6.Match(Case6, thrower))))));
        }

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較するChoice</param>
        /// <returns>現在のオブジェクトがotherで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        public bool Equals(Choice<T1, T2, T3, T4, T5, T6> other)
        {
            return other.IsNotNull() && Case1 == other.Case1 && Case2 == other.Case2 && Case3 == other.Case3 && Case4 == other.Case4 && Case5 == other.Case5 && Case6 == other.Case6;
        }

        /// <summary>
        /// 2つのChoceの比較を行います。 
        /// </summary>
        /// <param name="a">1つ目のChoice</param>
        /// <param name="b">2つ目のChoice</param>
        /// <returns>2つのChoiceが等しい場合はtrue、それ以外の場合はfalse</returns>
        public static bool operator ==(Choice<T1, T2, T3, T4, T5, T6> a, Choice<T1, T2, T3, T4, T5, T6> b)
        {
            if (a.IsNull())
                return b.IsNull();
            return a.Equals(b);
        }

        /// <summary>
        /// 2つのChoceの比較を行います。 
        /// </summary>
        /// <param name="a">1つ目のChoice</param>
        /// <param name="b">2つ目のChoice</param>
        /// <returns>2つのChoiceが等しい場合はfalse、それ以外の場合はtrue</returns>
        public static bool operator !=(Choice<T1, T2, T3, T4, T5, T6> a, Choice<T1, T2, T3, T4, T5, T6> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト</param>
        /// <returns>現在のオブジェクトがobjで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            var other = obj as Choice<T1, T2, T3, T4, T5, T6>;
            if (other.IsNull())
                return false;
            return Equals(other);
        }

        /// <summary>
        /// オブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>ハッシュコード</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            var result = 31;
            result ^= Case1.GetHashCode();
            result ^= Case2.GetHashCode();
            result ^= Case3.GetHashCode();
            result ^= Case4.GetHashCode();
            result ^= Case5.GetHashCode();
            result ^= Case6.GetHashCode();
            return result;
        }

        /// <summary>
        /// このオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>このオブジェクトの文字列表現</returns>
        public override string ToString()
        {
            return Match(
                t1 => string.Format("Choice({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Choice({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Choice({0}:{1})", t3, typeof(T3).Name),
                t4 => string.Format("Choice({0}:{1})", t4, typeof(T4).Name),
                t5 => string.Format("Choice({0}:{1})", t5, typeof(T5).Name),
                t6 => string.Format("Choice({0}:{1})", t6, typeof(T6).Name)
            );
        }
    }

    /// <summary>
    /// 複数の型のうち、どれか一つを保持する「多者択一」を表す型です。
    /// </summary>
    public sealed class Choice<T1, T2, T3, T4, T5, T6, T7> : IEquatable<Choice<T1, T2, T3, T4, T5, T6, T7>>
    {
        internal readonly Option<T1> Case1;
        internal readonly Option<T2> Case2;
        internal readonly Option<T3> Case3;
        internal readonly Option<T4> Case4;
        internal readonly Option<T5> Case5;
        internal readonly Option<T6> Case6;
        internal readonly Option<T7> Case7;

        /// <summary>
        /// 何番目の型を保持しているかを取得します。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int TagIndex { get { return this.Match(_ => 1, _ => 2, _ => 3, _ => 4, _ => 5, _ => 6, _ => 7); } }

        /// <summary>
        /// T1を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T1 value) { Case1 = new Option<T1>(value); }

        /// <summary>
        /// T1型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7>(T1 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7>(value); }

        /// <summary>
        /// T2を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T2 value) { Case2 = new Option<T2>(value); }

        /// <summary>
        /// T2型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7>(T2 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7>(value); }

        /// <summary>
        /// T3を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T3 value) { Case3 = new Option<T3>(value); }

        /// <summary>
        /// T3型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7>(T3 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7>(value); }

        /// <summary>
        /// T4を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T4 value) { Case4 = new Option<T4>(value); }

        /// <summary>
        /// T4型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7>(T4 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7>(value); }

        /// <summary>
        /// T5を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T5 value) { Case5 = new Option<T5>(value); }

        /// <summary>
        /// T5型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7>(T5 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7>(value); }

        /// <summary>
        /// T6を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T6 value) { Case6 = new Option<T6>(value); }

        /// <summary>
        /// T6型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7>(T6 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7>(value); }

        /// <summary>
        /// T7を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T7 value) { Case7 = new Option<T7>(value); }

        /// <summary>
        /// T7型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7>(T7 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7>(value); }

        /// <summary>
        /// 擬似的にパターンマッチを行います。
        /// </summary>
        public T Match<T>(Func<T1, T> Case1, Func<T2, T> Case2, Func<T3, T> Case3, Func<T4, T> Case4, Func<T5, T> Case5, Func<T6, T> Case6, Func<T7, T> Case7)
        {
            Func<T> thrower = () => { throw new InvalidOperationException(); };
            return this.Case1.Match<T>(Case1, () => this.Case2.Match<T>(Case2, () => this.Case3.Match<T>(Case3, () => this.Case4.Match<T>(Case4, () => this.Case5.Match<T>(Case5, () => this.Case6.Match<T>(Case6, () => this.Case7.Match<T>(Case7, thrower)))))));
        }

        /// <summary>
        /// 擬似的にパターンマッチを行います。
        /// </summary>
        public void Match(Action<T1> Case1, Action<T2> Case2, Action<T3> Case3, Action<T4> Case4, Action<T5> Case5, Action<T6> Case6, Action<T7> Case7)
        {
            Action thrower = () => { throw new InvalidOperationException(); };
            this.Case1.Match(Case1, () => this.Case2.Match(Case2, () => this.Case3.Match(Case3, () => this.Case4.Match(Case4, () => this.Case5.Match(Case5, () => this.Case6.Match(Case6, () => this.Case7.Match(Case7, thrower)))))));
        }

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較するChoice</param>
        /// <returns>現在のオブジェクトがotherで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        public bool Equals(Choice<T1, T2, T3, T4, T5, T6, T7> other)
        {
            return other.IsNotNull() && Case1 == other.Case1 && Case2 == other.Case2 && Case3 == other.Case3 && Case4 == other.Case4 && Case5 == other.Case5 && Case6 == other.Case6 && Case7 == other.Case7;
        }

        /// <summary>
        /// 2つのChoceの比較を行います。 
        /// </summary>
        /// <param name="a">1つ目のChoice</param>
        /// <param name="b">2つ目のChoice</param>
        /// <returns>2つのChoiceが等しい場合はtrue、それ以外の場合はfalse</returns>
        public static bool operator ==(Choice<T1, T2, T3, T4, T5, T6, T7> a, Choice<T1, T2, T3, T4, T5, T6, T7> b)
        {
            if (a.IsNull())
                return b.IsNull();
            return a.Equals(b);
        }

        /// <summary>
        /// 2つのChoceの比較を行います。 
        /// </summary>
        /// <param name="a">1つ目のChoice</param>
        /// <param name="b">2つ目のChoice</param>
        /// <returns>2つのChoiceが等しい場合はfalse、それ以外の場合はtrue</returns>
        public static bool operator !=(Choice<T1, T2, T3, T4, T5, T6, T7> a, Choice<T1, T2, T3, T4, T5, T6, T7> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト</param>
        /// <returns>現在のオブジェクトがobjで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            var other = obj as Choice<T1, T2, T3, T4, T5, T6, T7>;
            if (other.IsNull())
                return false;
            return Equals(other);
        }

        /// <summary>
        /// オブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>ハッシュコード</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            var result = 31;
            result ^= Case1.GetHashCode();
            result ^= Case2.GetHashCode();
            result ^= Case3.GetHashCode();
            result ^= Case4.GetHashCode();
            result ^= Case5.GetHashCode();
            result ^= Case6.GetHashCode();
            result ^= Case7.GetHashCode();
            return result;
        }

        /// <summary>
        /// このオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>このオブジェクトの文字列表現</returns>
        public override string ToString()
        {
            return Match(
                t1 => string.Format("Choice({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Choice({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Choice({0}:{1})", t3, typeof(T3).Name),
                t4 => string.Format("Choice({0}:{1})", t4, typeof(T4).Name),
                t5 => string.Format("Choice({0}:{1})", t5, typeof(T5).Name),
                t6 => string.Format("Choice({0}:{1})", t6, typeof(T6).Name),
                t7 => string.Format("Choice({0}:{1})", t7, typeof(T7).Name)
            );
        }
    }

    /// <summary>
    /// 複数の型のうち、どれか一つを保持する「多者択一」を表す型です。
    /// </summary>
    public sealed class Choice<T1, T2, T3, T4, T5, T6, T7, T8> : IEquatable<Choice<T1, T2, T3, T4, T5, T6, T7, T8>>
    {
        internal readonly Option<T1> Case1;
        internal readonly Option<T2> Case2;
        internal readonly Option<T3> Case3;
        internal readonly Option<T4> Case4;
        internal readonly Option<T5> Case5;
        internal readonly Option<T6> Case6;
        internal readonly Option<T7> Case7;
        internal readonly Option<T8> Case8;

        /// <summary>
        /// 何番目の型を保持しているかを取得します。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int TagIndex { get { return this.Match(_ => 1, _ => 2, _ => 3, _ => 4, _ => 5, _ => 6, _ => 7, _ => 8); } }

        /// <summary>
        /// T1を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T1 value) { Case1 = new Option<T1>(value); }

        /// <summary>
        /// T1型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8>(T1 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8>(value); }

        /// <summary>
        /// T2を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T2 value) { Case2 = new Option<T2>(value); }

        /// <summary>
        /// T2型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8>(T2 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8>(value); }

        /// <summary>
        /// T3を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T3 value) { Case3 = new Option<T3>(value); }

        /// <summary>
        /// T3型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8>(T3 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8>(value); }

        /// <summary>
        /// T4を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T4 value) { Case4 = new Option<T4>(value); }

        /// <summary>
        /// T4型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8>(T4 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8>(value); }

        /// <summary>
        /// T5を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T5 value) { Case5 = new Option<T5>(value); }

        /// <summary>
        /// T5型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8>(T5 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8>(value); }

        /// <summary>
        /// T6を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T6 value) { Case6 = new Option<T6>(value); }

        /// <summary>
        /// T6型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8>(T6 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8>(value); }

        /// <summary>
        /// T7を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T7 value) { Case7 = new Option<T7>(value); }

        /// <summary>
        /// T7型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8>(T7 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8>(value); }

        /// <summary>
        /// T8を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T8 value) { Case8 = new Option<T8>(value); }

        /// <summary>
        /// T8型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8>(T8 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8>(value); }

        /// <summary>
        /// 擬似的にパターンマッチを行います。
        /// </summary>
        public T Match<T>(Func<T1, T> Case1, Func<T2, T> Case2, Func<T3, T> Case3, Func<T4, T> Case4, Func<T5, T> Case5, Func<T6, T> Case6, Func<T7, T> Case7, Func<T8, T> Case8)
        {
            Func<T> thrower = () => { throw new InvalidOperationException(); };
            return this.Case1.Match<T>(Case1, () => this.Case2.Match<T>(Case2, () => this.Case3.Match<T>(Case3, () => this.Case4.Match<T>(Case4, () => this.Case5.Match<T>(Case5, () => this.Case6.Match<T>(Case6, () => this.Case7.Match<T>(Case7, () => this.Case8.Match<T>(Case8, thrower))))))));
        }

        /// <summary>
        /// 擬似的にパターンマッチを行います。
        /// </summary>
        public void Match(Action<T1> Case1, Action<T2> Case2, Action<T3> Case3, Action<T4> Case4, Action<T5> Case5, Action<T6> Case6, Action<T7> Case7, Action<T8> Case8)
        {
            Action thrower = () => { throw new InvalidOperationException(); };
            this.Case1.Match(Case1, () => this.Case2.Match(Case2, () => this.Case3.Match(Case3, () => this.Case4.Match(Case4, () => this.Case5.Match(Case5, () => this.Case6.Match(Case6, () => this.Case7.Match(Case7, () => this.Case8.Match(Case8, thrower))))))));
        }

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較するChoice</param>
        /// <returns>現在のオブジェクトがotherで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        public bool Equals(Choice<T1, T2, T3, T4, T5, T6, T7, T8> other)
        {
            return other.IsNotNull() && Case1 == other.Case1 && Case2 == other.Case2 && Case3 == other.Case3 && Case4 == other.Case4 && Case5 == other.Case5 && Case6 == other.Case6 && Case7 == other.Case7 && Case8 == other.Case8;
        }

        /// <summary>
        /// 2つのChoceの比較を行います。 
        /// </summary>
        /// <param name="a">1つ目のChoice</param>
        /// <param name="b">2つ目のChoice</param>
        /// <returns>2つのChoiceが等しい場合はtrue、それ以外の場合はfalse</returns>
        public static bool operator ==(Choice<T1, T2, T3, T4, T5, T6, T7, T8> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8> b)
        {
            if (a.IsNull())
                return b.IsNull();
            return a.Equals(b);
        }

        /// <summary>
        /// 2つのChoceの比較を行います。 
        /// </summary>
        /// <param name="a">1つ目のChoice</param>
        /// <param name="b">2つ目のChoice</param>
        /// <returns>2つのChoiceが等しい場合はfalse、それ以外の場合はtrue</returns>
        public static bool operator !=(Choice<T1, T2, T3, T4, T5, T6, T7, T8> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト</param>
        /// <returns>現在のオブジェクトがobjで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            var other = obj as Choice<T1, T2, T3, T4, T5, T6, T7, T8>;
            if (other.IsNull())
                return false;
            return Equals(other);
        }

        /// <summary>
        /// オブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>ハッシュコード</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            var result = 31;
            result ^= Case1.GetHashCode();
            result ^= Case2.GetHashCode();
            result ^= Case3.GetHashCode();
            result ^= Case4.GetHashCode();
            result ^= Case5.GetHashCode();
            result ^= Case6.GetHashCode();
            result ^= Case7.GetHashCode();
            result ^= Case8.GetHashCode();
            return result;
        }

        /// <summary>
        /// このオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>このオブジェクトの文字列表現</returns>
        public override string ToString()
        {
            return Match(
                t1 => string.Format("Choice({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Choice({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Choice({0}:{1})", t3, typeof(T3).Name),
                t4 => string.Format("Choice({0}:{1})", t4, typeof(T4).Name),
                t5 => string.Format("Choice({0}:{1})", t5, typeof(T5).Name),
                t6 => string.Format("Choice({0}:{1})", t6, typeof(T6).Name),
                t7 => string.Format("Choice({0}:{1})", t7, typeof(T7).Name),
                t8 => string.Format("Choice({0}:{1})", t8, typeof(T8).Name)
            );
        }
    }

    /// <summary>
    /// 複数の型のうち、どれか一つを保持する「多者択一」を表す型です。
    /// </summary>
    public sealed class Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9> : IEquatable<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>>
    {
        internal readonly Option<T1> Case1;
        internal readonly Option<T2> Case2;
        internal readonly Option<T3> Case3;
        internal readonly Option<T4> Case4;
        internal readonly Option<T5> Case5;
        internal readonly Option<T6> Case6;
        internal readonly Option<T7> Case7;
        internal readonly Option<T8> Case8;
        internal readonly Option<T9> Case9;

        /// <summary>
        /// 何番目の型を保持しているかを取得します。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int TagIndex { get { return this.Match(_ => 1, _ => 2, _ => 3, _ => 4, _ => 5, _ => 6, _ => 7, _ => 8, _ => 9); } }

        /// <summary>
        /// T1を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T1 value) { Case1 = new Option<T1>(value); }

        /// <summary>
        /// T1型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value); }

        /// <summary>
        /// T2を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T2 value) { Case2 = new Option<T2>(value); }

        /// <summary>
        /// T2型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T2 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value); }

        /// <summary>
        /// T3を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T3 value) { Case3 = new Option<T3>(value); }

        /// <summary>
        /// T3型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T3 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value); }

        /// <summary>
        /// T4を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T4 value) { Case4 = new Option<T4>(value); }

        /// <summary>
        /// T4型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T4 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value); }

        /// <summary>
        /// T5を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T5 value) { Case5 = new Option<T5>(value); }

        /// <summary>
        /// T5型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T5 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value); }

        /// <summary>
        /// T6を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T6 value) { Case6 = new Option<T6>(value); }

        /// <summary>
        /// T6型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T6 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value); }

        /// <summary>
        /// T7を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T7 value) { Case7 = new Option<T7>(value); }

        /// <summary>
        /// T7型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T7 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value); }

        /// <summary>
        /// T8を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T8 value) { Case8 = new Option<T8>(value); }

        /// <summary>
        /// T8型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T8 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value); }

        /// <summary>
        /// T9を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T9 value) { Case9 = new Option<T9>(value); }

        /// <summary>
        /// T9型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T9 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value); }

        /// <summary>
        /// 擬似的にパターンマッチを行います。
        /// </summary>
        public T Match<T>(Func<T1, T> Case1, Func<T2, T> Case2, Func<T3, T> Case3, Func<T4, T> Case4, Func<T5, T> Case5, Func<T6, T> Case6, Func<T7, T> Case7, Func<T8, T> Case8, Func<T9, T> Case9)
        {
            Func<T> thrower = () => { throw new InvalidOperationException(); };
            return this.Case1.Match<T>(Case1, () => this.Case2.Match<T>(Case2, () => this.Case3.Match<T>(Case3, () => this.Case4.Match<T>(Case4, () => this.Case5.Match<T>(Case5, () => this.Case6.Match<T>(Case6, () => this.Case7.Match<T>(Case7, () => this.Case8.Match<T>(Case8, () => this.Case9.Match<T>(Case9, thrower)))))))));
        }

        /// <summary>
        /// 擬似的にパターンマッチを行います。
        /// </summary>
        public void Match(Action<T1> Case1, Action<T2> Case2, Action<T3> Case3, Action<T4> Case4, Action<T5> Case5, Action<T6> Case6, Action<T7> Case7, Action<T8> Case8, Action<T9> Case9)
        {
            Action thrower = () => { throw new InvalidOperationException(); };
            this.Case1.Match(Case1, () => this.Case2.Match(Case2, () => this.Case3.Match(Case3, () => this.Case4.Match(Case4, () => this.Case5.Match(Case5, () => this.Case6.Match(Case6, () => this.Case7.Match(Case7, () => this.Case8.Match(Case8, () => this.Case9.Match(Case9, thrower)))))))));
        }

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較するChoice</param>
        /// <returns>現在のオブジェクトがotherで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        public bool Equals(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9> other)
        {
            return other.IsNotNull() && Case1 == other.Case1 && Case2 == other.Case2 && Case3 == other.Case3 && Case4 == other.Case4 && Case5 == other.Case5 && Case6 == other.Case6 && Case7 == other.Case7 && Case8 == other.Case8 && Case9 == other.Case9;
        }

        /// <summary>
        /// 2つのChoceの比較を行います。 
        /// </summary>
        /// <param name="a">1つ目のChoice</param>
        /// <param name="b">2つ目のChoice</param>
        /// <returns>2つのChoiceが等しい場合はtrue、それ以外の場合はfalse</returns>
        public static bool operator ==(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9> b)
        {
            if (a.IsNull())
                return b.IsNull();
            return a.Equals(b);
        }

        /// <summary>
        /// 2つのChoceの比較を行います。 
        /// </summary>
        /// <param name="a">1つ目のChoice</param>
        /// <param name="b">2つ目のChoice</param>
        /// <returns>2つのChoiceが等しい場合はfalse、それ以外の場合はtrue</returns>
        public static bool operator !=(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト</param>
        /// <returns>現在のオブジェクトがobjで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            var other = obj as Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9>;
            if (other.IsNull())
                return false;
            return Equals(other);
        }

        /// <summary>
        /// オブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>ハッシュコード</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            var result = 31;
            result ^= Case1.GetHashCode();
            result ^= Case2.GetHashCode();
            result ^= Case3.GetHashCode();
            result ^= Case4.GetHashCode();
            result ^= Case5.GetHashCode();
            result ^= Case6.GetHashCode();
            result ^= Case7.GetHashCode();
            result ^= Case8.GetHashCode();
            result ^= Case9.GetHashCode();
            return result;
        }

        /// <summary>
        /// このオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>このオブジェクトの文字列表現</returns>
        public override string ToString()
        {
            return Match(
                t1 => string.Format("Choice({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Choice({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Choice({0}:{1})", t3, typeof(T3).Name),
                t4 => string.Format("Choice({0}:{1})", t4, typeof(T4).Name),
                t5 => string.Format("Choice({0}:{1})", t5, typeof(T5).Name),
                t6 => string.Format("Choice({0}:{1})", t6, typeof(T6).Name),
                t7 => string.Format("Choice({0}:{1})", t7, typeof(T7).Name),
                t8 => string.Format("Choice({0}:{1})", t8, typeof(T8).Name),
                t9 => string.Format("Choice({0}:{1})", t9, typeof(T9).Name)
            );
        }
    }

    /// <summary>
    /// 複数の型のうち、どれか一つを保持する「多者択一」を表す型です。
    /// </summary>
    public sealed class Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : IEquatable<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>
    {
        internal readonly Option<T1> Case1;
        internal readonly Option<T2> Case2;
        internal readonly Option<T3> Case3;
        internal readonly Option<T4> Case4;
        internal readonly Option<T5> Case5;
        internal readonly Option<T6> Case6;
        internal readonly Option<T7> Case7;
        internal readonly Option<T8> Case8;
        internal readonly Option<T9> Case9;
        internal readonly Option<T10> Case10;

        /// <summary>
        /// 何番目の型を保持しているかを取得します。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int TagIndex { get { return this.Match(_ => 1, _ => 2, _ => 3, _ => 4, _ => 5, _ => 6, _ => 7, _ => 8, _ => 9, _ => 10); } }

        /// <summary>
        /// T1を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T1 value) { Case1 = new Option<T1>(value); }

        /// <summary>
        /// T1型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value); }

        /// <summary>
        /// T2を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T2 value) { Case2 = new Option<T2>(value); }

        /// <summary>
        /// T2型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T2 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value); }

        /// <summary>
        /// T3を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T3 value) { Case3 = new Option<T3>(value); }

        /// <summary>
        /// T3型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T3 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value); }

        /// <summary>
        /// T4を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T4 value) { Case4 = new Option<T4>(value); }

        /// <summary>
        /// T4型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T4 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value); }

        /// <summary>
        /// T5を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T5 value) { Case5 = new Option<T5>(value); }

        /// <summary>
        /// T5型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T5 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value); }

        /// <summary>
        /// T6を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T6 value) { Case6 = new Option<T6>(value); }

        /// <summary>
        /// T6型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T6 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value); }

        /// <summary>
        /// T7を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T7 value) { Case7 = new Option<T7>(value); }

        /// <summary>
        /// T7型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T7 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value); }

        /// <summary>
        /// T8を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T8 value) { Case8 = new Option<T8>(value); }

        /// <summary>
        /// T8型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T8 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value); }

        /// <summary>
        /// T9を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T9 value) { Case9 = new Option<T9>(value); }

        /// <summary>
        /// T9型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T9 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value); }

        /// <summary>
        /// T10を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T10 value) { Case10 = new Option<T10>(value); }

        /// <summary>
        /// T10型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T10 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value); }

        /// <summary>
        /// 擬似的にパターンマッチを行います。
        /// </summary>
        public T Match<T>(Func<T1, T> Case1, Func<T2, T> Case2, Func<T3, T> Case3, Func<T4, T> Case4, Func<T5, T> Case5, Func<T6, T> Case6, Func<T7, T> Case7, Func<T8, T> Case8, Func<T9, T> Case9, Func<T10, T> Case10)
        {
            Func<T> thrower = () => { throw new InvalidOperationException(); };
            return this.Case1.Match<T>(Case1, () => this.Case2.Match<T>(Case2, () => this.Case3.Match<T>(Case3, () => this.Case4.Match<T>(Case4, () => this.Case5.Match<T>(Case5, () => this.Case6.Match<T>(Case6, () => this.Case7.Match<T>(Case7, () => this.Case8.Match<T>(Case8, () => this.Case9.Match<T>(Case9, () => this.Case10.Match<T>(Case10, thrower))))))))));
        }

        /// <summary>
        /// 擬似的にパターンマッチを行います。
        /// </summary>
        public void Match(Action<T1> Case1, Action<T2> Case2, Action<T3> Case3, Action<T4> Case4, Action<T5> Case5, Action<T6> Case6, Action<T7> Case7, Action<T8> Case8, Action<T9> Case9, Action<T10> Case10)
        {
            Action thrower = () => { throw new InvalidOperationException(); };
            this.Case1.Match(Case1, () => this.Case2.Match(Case2, () => this.Case3.Match(Case3, () => this.Case4.Match(Case4, () => this.Case5.Match(Case5, () => this.Case6.Match(Case6, () => this.Case7.Match(Case7, () => this.Case8.Match(Case8, () => this.Case9.Match(Case9, () => this.Case10.Match(Case10, thrower))))))))));
        }

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較するChoice</param>
        /// <returns>現在のオブジェクトがotherで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        public bool Equals(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> other)
        {
            return other.IsNotNull() && Case1 == other.Case1 && Case2 == other.Case2 && Case3 == other.Case3 && Case4 == other.Case4 && Case5 == other.Case5 && Case6 == other.Case6 && Case7 == other.Case7 && Case8 == other.Case8 && Case9 == other.Case9 && Case10 == other.Case10;
        }

        /// <summary>
        /// 2つのChoceの比較を行います。 
        /// </summary>
        /// <param name="a">1つ目のChoice</param>
        /// <param name="b">2つ目のChoice</param>
        /// <returns>2つのChoiceが等しい場合はtrue、それ以外の場合はfalse</returns>
        public static bool operator ==(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> b)
        {
            if (a.IsNull())
                return b.IsNull();
            return a.Equals(b);
        }

        /// <summary>
        /// 2つのChoceの比較を行います。 
        /// </summary>
        /// <param name="a">1つ目のChoice</param>
        /// <param name="b">2つ目のChoice</param>
        /// <returns>2つのChoiceが等しい場合はfalse、それ以外の場合はtrue</returns>
        public static bool operator !=(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト</param>
        /// <returns>現在のオブジェクトがobjで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            var other = obj as Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>;
            if (other.IsNull())
                return false;
            return Equals(other);
        }

        /// <summary>
        /// オブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>ハッシュコード</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            var result = 31;
            result ^= Case1.GetHashCode();
            result ^= Case2.GetHashCode();
            result ^= Case3.GetHashCode();
            result ^= Case4.GetHashCode();
            result ^= Case5.GetHashCode();
            result ^= Case6.GetHashCode();
            result ^= Case7.GetHashCode();
            result ^= Case8.GetHashCode();
            result ^= Case9.GetHashCode();
            result ^= Case10.GetHashCode();
            return result;
        }

        /// <summary>
        /// このオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>このオブジェクトの文字列表現</returns>
        public override string ToString()
        {
            return Match(
                t1 => string.Format("Choice({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Choice({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Choice({0}:{1})", t3, typeof(T3).Name),
                t4 => string.Format("Choice({0}:{1})", t4, typeof(T4).Name),
                t5 => string.Format("Choice({0}:{1})", t5, typeof(T5).Name),
                t6 => string.Format("Choice({0}:{1})", t6, typeof(T6).Name),
                t7 => string.Format("Choice({0}:{1})", t7, typeof(T7).Name),
                t8 => string.Format("Choice({0}:{1})", t8, typeof(T8).Name),
                t9 => string.Format("Choice({0}:{1})", t9, typeof(T9).Name),
                t10 => string.Format("Choice({0}:{1})", t10, typeof(T10).Name)
            );
        }
    }

    /// <summary>
    /// 複数の型のうち、どれか一つを保持する「多者択一」を表す型です。
    /// </summary>
    public sealed class Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : IEquatable<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>
    {
        internal readonly Option<T1> Case1;
        internal readonly Option<T2> Case2;
        internal readonly Option<T3> Case3;
        internal readonly Option<T4> Case4;
        internal readonly Option<T5> Case5;
        internal readonly Option<T6> Case6;
        internal readonly Option<T7> Case7;
        internal readonly Option<T8> Case8;
        internal readonly Option<T9> Case9;
        internal readonly Option<T10> Case10;
        internal readonly Option<T11> Case11;

        /// <summary>
        /// 何番目の型を保持しているかを取得します。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int TagIndex { get { return this.Match(_ => 1, _ => 2, _ => 3, _ => 4, _ => 5, _ => 6, _ => 7, _ => 8, _ => 9, _ => 10, _ => 11); } }

        /// <summary>
        /// T1を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T1 value) { Case1 = new Option<T1>(value); }

        /// <summary>
        /// T1型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value); }

        /// <summary>
        /// T2を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T2 value) { Case2 = new Option<T2>(value); }

        /// <summary>
        /// T2型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T2 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value); }

        /// <summary>
        /// T3を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T3 value) { Case3 = new Option<T3>(value); }

        /// <summary>
        /// T3型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T3 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value); }

        /// <summary>
        /// T4を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T4 value) { Case4 = new Option<T4>(value); }

        /// <summary>
        /// T4型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T4 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value); }

        /// <summary>
        /// T5を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T5 value) { Case5 = new Option<T5>(value); }

        /// <summary>
        /// T5型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T5 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value); }

        /// <summary>
        /// T6を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T6 value) { Case6 = new Option<T6>(value); }

        /// <summary>
        /// T6型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T6 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value); }

        /// <summary>
        /// T7を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T7 value) { Case7 = new Option<T7>(value); }

        /// <summary>
        /// T7型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T7 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value); }

        /// <summary>
        /// T8を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T8 value) { Case8 = new Option<T8>(value); }

        /// <summary>
        /// T8型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T8 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value); }

        /// <summary>
        /// T9を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T9 value) { Case9 = new Option<T9>(value); }

        /// <summary>
        /// T9型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T9 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value); }

        /// <summary>
        /// T10を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T10 value) { Case10 = new Option<T10>(value); }

        /// <summary>
        /// T10型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T10 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value); }

        /// <summary>
        /// T11を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T11 value) { Case11 = new Option<T11>(value); }

        /// <summary>
        /// T11型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T11 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value); }

        /// <summary>
        /// 擬似的にパターンマッチを行います。
        /// </summary>
        public T Match<T>(Func<T1, T> Case1, Func<T2, T> Case2, Func<T3, T> Case3, Func<T4, T> Case4, Func<T5, T> Case5, Func<T6, T> Case6, Func<T7, T> Case7, Func<T8, T> Case8, Func<T9, T> Case9, Func<T10, T> Case10, Func<T11, T> Case11)
        {
            Func<T> thrower = () => { throw new InvalidOperationException(); };
            return this.Case1.Match<T>(Case1, () => this.Case2.Match<T>(Case2, () => this.Case3.Match<T>(Case3, () => this.Case4.Match<T>(Case4, () => this.Case5.Match<T>(Case5, () => this.Case6.Match<T>(Case6, () => this.Case7.Match<T>(Case7, () => this.Case8.Match<T>(Case8, () => this.Case9.Match<T>(Case9, () => this.Case10.Match<T>(Case10, () => this.Case11.Match<T>(Case11, thrower)))))))))));
        }

        /// <summary>
        /// 擬似的にパターンマッチを行います。
        /// </summary>
        public void Match(Action<T1> Case1, Action<T2> Case2, Action<T3> Case3, Action<T4> Case4, Action<T5> Case5, Action<T6> Case6, Action<T7> Case7, Action<T8> Case8, Action<T9> Case9, Action<T10> Case10, Action<T11> Case11)
        {
            Action thrower = () => { throw new InvalidOperationException(); };
            this.Case1.Match(Case1, () => this.Case2.Match(Case2, () => this.Case3.Match(Case3, () => this.Case4.Match(Case4, () => this.Case5.Match(Case5, () => this.Case6.Match(Case6, () => this.Case7.Match(Case7, () => this.Case8.Match(Case8, () => this.Case9.Match(Case9, () => this.Case10.Match(Case10, () => this.Case11.Match(Case11, thrower)))))))))));
        }

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較するChoice</param>
        /// <returns>現在のオブジェクトがotherで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        public bool Equals(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> other)
        {
            return other.IsNotNull() && Case1 == other.Case1 && Case2 == other.Case2 && Case3 == other.Case3 && Case4 == other.Case4 && Case5 == other.Case5 && Case6 == other.Case6 && Case7 == other.Case7 && Case8 == other.Case8 && Case9 == other.Case9 && Case10 == other.Case10 && Case11 == other.Case11;
        }

        /// <summary>
        /// 2つのChoceの比較を行います。 
        /// </summary>
        /// <param name="a">1つ目のChoice</param>
        /// <param name="b">2つ目のChoice</param>
        /// <returns>2つのChoiceが等しい場合はtrue、それ以外の場合はfalse</returns>
        public static bool operator ==(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> b)
        {
            if (a.IsNull())
                return b.IsNull();
            return a.Equals(b);
        }

        /// <summary>
        /// 2つのChoceの比較を行います。 
        /// </summary>
        /// <param name="a">1つ目のChoice</param>
        /// <param name="b">2つ目のChoice</param>
        /// <returns>2つのChoiceが等しい場合はfalse、それ以外の場合はtrue</returns>
        public static bool operator !=(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト</param>
        /// <returns>現在のオブジェクトがobjで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            var other = obj as Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>;
            if (other.IsNull())
                return false;
            return Equals(other);
        }

        /// <summary>
        /// オブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>ハッシュコード</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            var result = 31;
            result ^= Case1.GetHashCode();
            result ^= Case2.GetHashCode();
            result ^= Case3.GetHashCode();
            result ^= Case4.GetHashCode();
            result ^= Case5.GetHashCode();
            result ^= Case6.GetHashCode();
            result ^= Case7.GetHashCode();
            result ^= Case8.GetHashCode();
            result ^= Case9.GetHashCode();
            result ^= Case10.GetHashCode();
            result ^= Case11.GetHashCode();
            return result;
        }

        /// <summary>
        /// このオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>このオブジェクトの文字列表現</returns>
        public override string ToString()
        {
            return Match(
                t1 => string.Format("Choice({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Choice({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Choice({0}:{1})", t3, typeof(T3).Name),
                t4 => string.Format("Choice({0}:{1})", t4, typeof(T4).Name),
                t5 => string.Format("Choice({0}:{1})", t5, typeof(T5).Name),
                t6 => string.Format("Choice({0}:{1})", t6, typeof(T6).Name),
                t7 => string.Format("Choice({0}:{1})", t7, typeof(T7).Name),
                t8 => string.Format("Choice({0}:{1})", t8, typeof(T8).Name),
                t9 => string.Format("Choice({0}:{1})", t9, typeof(T9).Name),
                t10 => string.Format("Choice({0}:{1})", t10, typeof(T10).Name),
                t11 => string.Format("Choice({0}:{1})", t11, typeof(T11).Name)
            );
        }
    }

    /// <summary>
    /// 複数の型のうち、どれか一つを保持する「多者択一」を表す型です。
    /// </summary>
    public sealed class Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : IEquatable<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>
    {
        internal readonly Option<T1> Case1;
        internal readonly Option<T2> Case2;
        internal readonly Option<T3> Case3;
        internal readonly Option<T4> Case4;
        internal readonly Option<T5> Case5;
        internal readonly Option<T6> Case6;
        internal readonly Option<T7> Case7;
        internal readonly Option<T8> Case8;
        internal readonly Option<T9> Case9;
        internal readonly Option<T10> Case10;
        internal readonly Option<T11> Case11;
        internal readonly Option<T12> Case12;

        /// <summary>
        /// 何番目の型を保持しているかを取得します。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int TagIndex { get { return this.Match(_ => 1, _ => 2, _ => 3, _ => 4, _ => 5, _ => 6, _ => 7, _ => 8, _ => 9, _ => 10, _ => 11, _ => 12); } }

        /// <summary>
        /// T1を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T1 value) { Case1 = new Option<T1>(value); }

        /// <summary>
        /// T1型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value); }

        /// <summary>
        /// T2を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T2 value) { Case2 = new Option<T2>(value); }

        /// <summary>
        /// T2型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T2 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value); }

        /// <summary>
        /// T3を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T3 value) { Case3 = new Option<T3>(value); }

        /// <summary>
        /// T3型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T3 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value); }

        /// <summary>
        /// T4を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T4 value) { Case4 = new Option<T4>(value); }

        /// <summary>
        /// T4型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T4 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value); }

        /// <summary>
        /// T5を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T5 value) { Case5 = new Option<T5>(value); }

        /// <summary>
        /// T5型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T5 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value); }

        /// <summary>
        /// T6を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T6 value) { Case6 = new Option<T6>(value); }

        /// <summary>
        /// T6型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T6 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value); }

        /// <summary>
        /// T7を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T7 value) { Case7 = new Option<T7>(value); }

        /// <summary>
        /// T7型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T7 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value); }

        /// <summary>
        /// T8を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T8 value) { Case8 = new Option<T8>(value); }

        /// <summary>
        /// T8型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T8 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value); }

        /// <summary>
        /// T9を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T9 value) { Case9 = new Option<T9>(value); }

        /// <summary>
        /// T9型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T9 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value); }

        /// <summary>
        /// T10を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T10 value) { Case10 = new Option<T10>(value); }

        /// <summary>
        /// T10型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T10 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value); }

        /// <summary>
        /// T11を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T11 value) { Case11 = new Option<T11>(value); }

        /// <summary>
        /// T11型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T11 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value); }

        /// <summary>
        /// T12を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T12 value) { Case12 = new Option<T12>(value); }

        /// <summary>
        /// T12型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T12 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value); }

        /// <summary>
        /// 擬似的にパターンマッチを行います。
        /// </summary>
        public T Match<T>(Func<T1, T> Case1, Func<T2, T> Case2, Func<T3, T> Case3, Func<T4, T> Case4, Func<T5, T> Case5, Func<T6, T> Case6, Func<T7, T> Case7, Func<T8, T> Case8, Func<T9, T> Case9, Func<T10, T> Case10, Func<T11, T> Case11, Func<T12, T> Case12)
        {
            Func<T> thrower = () => { throw new InvalidOperationException(); };
            return this.Case1.Match<T>(Case1, () => this.Case2.Match<T>(Case2, () => this.Case3.Match<T>(Case3, () => this.Case4.Match<T>(Case4, () => this.Case5.Match<T>(Case5, () => this.Case6.Match<T>(Case6, () => this.Case7.Match<T>(Case7, () => this.Case8.Match<T>(Case8, () => this.Case9.Match<T>(Case9, () => this.Case10.Match<T>(Case10, () => this.Case11.Match<T>(Case11, () => this.Case12.Match<T>(Case12, thrower))))))))))));
        }

        /// <summary>
        /// 擬似的にパターンマッチを行います。
        /// </summary>
        public void Match(Action<T1> Case1, Action<T2> Case2, Action<T3> Case3, Action<T4> Case4, Action<T5> Case5, Action<T6> Case6, Action<T7> Case7, Action<T8> Case8, Action<T9> Case9, Action<T10> Case10, Action<T11> Case11, Action<T12> Case12)
        {
            Action thrower = () => { throw new InvalidOperationException(); };
            this.Case1.Match(Case1, () => this.Case2.Match(Case2, () => this.Case3.Match(Case3, () => this.Case4.Match(Case4, () => this.Case5.Match(Case5, () => this.Case6.Match(Case6, () => this.Case7.Match(Case7, () => this.Case8.Match(Case8, () => this.Case9.Match(Case9, () => this.Case10.Match(Case10, () => this.Case11.Match(Case11, () => this.Case12.Match(Case12, thrower))))))))))));
        }

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較するChoice</param>
        /// <returns>現在のオブジェクトがotherで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        public bool Equals(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> other)
        {
            return other.IsNotNull() && Case1 == other.Case1 && Case2 == other.Case2 && Case3 == other.Case3 && Case4 == other.Case4 && Case5 == other.Case5 && Case6 == other.Case6 && Case7 == other.Case7 && Case8 == other.Case8 && Case9 == other.Case9 && Case10 == other.Case10 && Case11 == other.Case11 && Case12 == other.Case12;
        }

        /// <summary>
        /// 2つのChoceの比較を行います。 
        /// </summary>
        /// <param name="a">1つ目のChoice</param>
        /// <param name="b">2つ目のChoice</param>
        /// <returns>2つのChoiceが等しい場合はtrue、それ以外の場合はfalse</returns>
        public static bool operator ==(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> b)
        {
            if (a.IsNull())
                return b.IsNull();
            return a.Equals(b);
        }

        /// <summary>
        /// 2つのChoceの比較を行います。 
        /// </summary>
        /// <param name="a">1つ目のChoice</param>
        /// <param name="b">2つ目のChoice</param>
        /// <returns>2つのChoiceが等しい場合はfalse、それ以外の場合はtrue</returns>
        public static bool operator !=(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト</param>
        /// <returns>現在のオブジェクトがobjで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            var other = obj as Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>;
            if (other.IsNull())
                return false;
            return Equals(other);
        }

        /// <summary>
        /// オブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>ハッシュコード</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            var result = 31;
            result ^= Case1.GetHashCode();
            result ^= Case2.GetHashCode();
            result ^= Case3.GetHashCode();
            result ^= Case4.GetHashCode();
            result ^= Case5.GetHashCode();
            result ^= Case6.GetHashCode();
            result ^= Case7.GetHashCode();
            result ^= Case8.GetHashCode();
            result ^= Case9.GetHashCode();
            result ^= Case10.GetHashCode();
            result ^= Case11.GetHashCode();
            result ^= Case12.GetHashCode();
            return result;
        }

        /// <summary>
        /// このオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>このオブジェクトの文字列表現</returns>
        public override string ToString()
        {
            return Match(
                t1 => string.Format("Choice({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Choice({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Choice({0}:{1})", t3, typeof(T3).Name),
                t4 => string.Format("Choice({0}:{1})", t4, typeof(T4).Name),
                t5 => string.Format("Choice({0}:{1})", t5, typeof(T5).Name),
                t6 => string.Format("Choice({0}:{1})", t6, typeof(T6).Name),
                t7 => string.Format("Choice({0}:{1})", t7, typeof(T7).Name),
                t8 => string.Format("Choice({0}:{1})", t8, typeof(T8).Name),
                t9 => string.Format("Choice({0}:{1})", t9, typeof(T9).Name),
                t10 => string.Format("Choice({0}:{1})", t10, typeof(T10).Name),
                t11 => string.Format("Choice({0}:{1})", t11, typeof(T11).Name),
                t12 => string.Format("Choice({0}:{1})", t12, typeof(T12).Name)
            );
        }
    }

    /// <summary>
    /// 複数の型のうち、どれか一つを保持する「多者択一」を表す型です。
    /// </summary>
    public sealed class Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : IEquatable<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>
    {
        internal readonly Option<T1> Case1;
        internal readonly Option<T2> Case2;
        internal readonly Option<T3> Case3;
        internal readonly Option<T4> Case4;
        internal readonly Option<T5> Case5;
        internal readonly Option<T6> Case6;
        internal readonly Option<T7> Case7;
        internal readonly Option<T8> Case8;
        internal readonly Option<T9> Case9;
        internal readonly Option<T10> Case10;
        internal readonly Option<T11> Case11;
        internal readonly Option<T12> Case12;
        internal readonly Option<T13> Case13;

        /// <summary>
        /// 何番目の型を保持しているかを取得します。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int TagIndex { get { return this.Match(_ => 1, _ => 2, _ => 3, _ => 4, _ => 5, _ => 6, _ => 7, _ => 8, _ => 9, _ => 10, _ => 11, _ => 12, _ => 13); } }

        /// <summary>
        /// T1を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T1 value) { Case1 = new Option<T1>(value); }

        /// <summary>
        /// T1型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value); }

        /// <summary>
        /// T2を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T2 value) { Case2 = new Option<T2>(value); }

        /// <summary>
        /// T2型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T2 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value); }

        /// <summary>
        /// T3を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T3 value) { Case3 = new Option<T3>(value); }

        /// <summary>
        /// T3型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T3 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value); }

        /// <summary>
        /// T4を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T4 value) { Case4 = new Option<T4>(value); }

        /// <summary>
        /// T4型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T4 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value); }

        /// <summary>
        /// T5を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T5 value) { Case5 = new Option<T5>(value); }

        /// <summary>
        /// T5型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T5 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value); }

        /// <summary>
        /// T6を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T6 value) { Case6 = new Option<T6>(value); }

        /// <summary>
        /// T6型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T6 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value); }

        /// <summary>
        /// T7を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T7 value) { Case7 = new Option<T7>(value); }

        /// <summary>
        /// T7型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T7 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value); }

        /// <summary>
        /// T8を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T8 value) { Case8 = new Option<T8>(value); }

        /// <summary>
        /// T8型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T8 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value); }

        /// <summary>
        /// T9を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T9 value) { Case9 = new Option<T9>(value); }

        /// <summary>
        /// T9型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T9 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value); }

        /// <summary>
        /// T10を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T10 value) { Case10 = new Option<T10>(value); }

        /// <summary>
        /// T10型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T10 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value); }

        /// <summary>
        /// T11を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T11 value) { Case11 = new Option<T11>(value); }

        /// <summary>
        /// T11型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T11 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value); }

        /// <summary>
        /// T12を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T12 value) { Case12 = new Option<T12>(value); }

        /// <summary>
        /// T12型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T12 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value); }

        /// <summary>
        /// T13を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T13 value) { Case13 = new Option<T13>(value); }

        /// <summary>
        /// T13型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T13 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value); }

        /// <summary>
        /// 擬似的にパターンマッチを行います。
        /// </summary>
        public T Match<T>(Func<T1, T> Case1, Func<T2, T> Case2, Func<T3, T> Case3, Func<T4, T> Case4, Func<T5, T> Case5, Func<T6, T> Case6, Func<T7, T> Case7, Func<T8, T> Case8, Func<T9, T> Case9, Func<T10, T> Case10, Func<T11, T> Case11, Func<T12, T> Case12, Func<T13, T> Case13)
        {
            Func<T> thrower = () => { throw new InvalidOperationException(); };
            return this.Case1.Match<T>(Case1, () => this.Case2.Match<T>(Case2, () => this.Case3.Match<T>(Case3, () => this.Case4.Match<T>(Case4, () => this.Case5.Match<T>(Case5, () => this.Case6.Match<T>(Case6, () => this.Case7.Match<T>(Case7, () => this.Case8.Match<T>(Case8, () => this.Case9.Match<T>(Case9, () => this.Case10.Match<T>(Case10, () => this.Case11.Match<T>(Case11, () => this.Case12.Match<T>(Case12, () => this.Case13.Match<T>(Case13, thrower)))))))))))));
        }

        /// <summary>
        /// 擬似的にパターンマッチを行います。
        /// </summary>
        public void Match(Action<T1> Case1, Action<T2> Case2, Action<T3> Case3, Action<T4> Case4, Action<T5> Case5, Action<T6> Case6, Action<T7> Case7, Action<T8> Case8, Action<T9> Case9, Action<T10> Case10, Action<T11> Case11, Action<T12> Case12, Action<T13> Case13)
        {
            Action thrower = () => { throw new InvalidOperationException(); };
            this.Case1.Match(Case1, () => this.Case2.Match(Case2, () => this.Case3.Match(Case3, () => this.Case4.Match(Case4, () => this.Case5.Match(Case5, () => this.Case6.Match(Case6, () => this.Case7.Match(Case7, () => this.Case8.Match(Case8, () => this.Case9.Match(Case9, () => this.Case10.Match(Case10, () => this.Case11.Match(Case11, () => this.Case12.Match(Case12, () => this.Case13.Match(Case13, thrower)))))))))))));
        }

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較するChoice</param>
        /// <returns>現在のオブジェクトがotherで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        public bool Equals(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> other)
        {
            return other.IsNotNull() && Case1 == other.Case1 && Case2 == other.Case2 && Case3 == other.Case3 && Case4 == other.Case4 && Case5 == other.Case5 && Case6 == other.Case6 && Case7 == other.Case7 && Case8 == other.Case8 && Case9 == other.Case9 && Case10 == other.Case10 && Case11 == other.Case11 && Case12 == other.Case12 && Case13 == other.Case13;
        }

        /// <summary>
        /// 2つのChoceの比較を行います。 
        /// </summary>
        /// <param name="a">1つ目のChoice</param>
        /// <param name="b">2つ目のChoice</param>
        /// <returns>2つのChoiceが等しい場合はtrue、それ以外の場合はfalse</returns>
        public static bool operator ==(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> b)
        {
            if (a.IsNull())
                return b.IsNull();
            return a.Equals(b);
        }

        /// <summary>
        /// 2つのChoceの比較を行います。 
        /// </summary>
        /// <param name="a">1つ目のChoice</param>
        /// <param name="b">2つ目のChoice</param>
        /// <returns>2つのChoiceが等しい場合はfalse、それ以外の場合はtrue</returns>
        public static bool operator !=(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト</param>
        /// <returns>現在のオブジェクトがobjで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            var other = obj as Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>;
            if (other.IsNull())
                return false;
            return Equals(other);
        }

        /// <summary>
        /// オブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>ハッシュコード</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            var result = 31;
            result ^= Case1.GetHashCode();
            result ^= Case2.GetHashCode();
            result ^= Case3.GetHashCode();
            result ^= Case4.GetHashCode();
            result ^= Case5.GetHashCode();
            result ^= Case6.GetHashCode();
            result ^= Case7.GetHashCode();
            result ^= Case8.GetHashCode();
            result ^= Case9.GetHashCode();
            result ^= Case10.GetHashCode();
            result ^= Case11.GetHashCode();
            result ^= Case12.GetHashCode();
            result ^= Case13.GetHashCode();
            return result;
        }

        /// <summary>
        /// このオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>このオブジェクトの文字列表現</returns>
        public override string ToString()
        {
            return Match(
                t1 => string.Format("Choice({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Choice({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Choice({0}:{1})", t3, typeof(T3).Name),
                t4 => string.Format("Choice({0}:{1})", t4, typeof(T4).Name),
                t5 => string.Format("Choice({0}:{1})", t5, typeof(T5).Name),
                t6 => string.Format("Choice({0}:{1})", t6, typeof(T6).Name),
                t7 => string.Format("Choice({0}:{1})", t7, typeof(T7).Name),
                t8 => string.Format("Choice({0}:{1})", t8, typeof(T8).Name),
                t9 => string.Format("Choice({0}:{1})", t9, typeof(T9).Name),
                t10 => string.Format("Choice({0}:{1})", t10, typeof(T10).Name),
                t11 => string.Format("Choice({0}:{1})", t11, typeof(T11).Name),
                t12 => string.Format("Choice({0}:{1})", t12, typeof(T12).Name),
                t13 => string.Format("Choice({0}:{1})", t13, typeof(T13).Name)
            );
        }
    }

    /// <summary>
    /// 複数の型のうち、どれか一つを保持する「多者択一」を表す型です。
    /// </summary>
    public sealed class Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : IEquatable<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>
    {
        internal readonly Option<T1> Case1;
        internal readonly Option<T2> Case2;
        internal readonly Option<T3> Case3;
        internal readonly Option<T4> Case4;
        internal readonly Option<T5> Case5;
        internal readonly Option<T6> Case6;
        internal readonly Option<T7> Case7;
        internal readonly Option<T8> Case8;
        internal readonly Option<T9> Case9;
        internal readonly Option<T10> Case10;
        internal readonly Option<T11> Case11;
        internal readonly Option<T12> Case12;
        internal readonly Option<T13> Case13;
        internal readonly Option<T14> Case14;

        /// <summary>
        /// 何番目の型を保持しているかを取得します。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int TagIndex { get { return this.Match(_ => 1, _ => 2, _ => 3, _ => 4, _ => 5, _ => 6, _ => 7, _ => 8, _ => 9, _ => 10, _ => 11, _ => 12, _ => 13, _ => 14); } }

        /// <summary>
        /// T1を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T1 value) { Case1 = new Option<T1>(value); }

        /// <summary>
        /// T1型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value); }

        /// <summary>
        /// T2を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T2 value) { Case2 = new Option<T2>(value); }

        /// <summary>
        /// T2型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T2 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value); }

        /// <summary>
        /// T3を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T3 value) { Case3 = new Option<T3>(value); }

        /// <summary>
        /// T3型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T3 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value); }

        /// <summary>
        /// T4を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T4 value) { Case4 = new Option<T4>(value); }

        /// <summary>
        /// T4型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T4 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value); }

        /// <summary>
        /// T5を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T5 value) { Case5 = new Option<T5>(value); }

        /// <summary>
        /// T5型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T5 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value); }

        /// <summary>
        /// T6を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T6 value) { Case6 = new Option<T6>(value); }

        /// <summary>
        /// T6型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T6 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value); }

        /// <summary>
        /// T7を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T7 value) { Case7 = new Option<T7>(value); }

        /// <summary>
        /// T7型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T7 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value); }

        /// <summary>
        /// T8を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T8 value) { Case8 = new Option<T8>(value); }

        /// <summary>
        /// T8型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T8 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value); }

        /// <summary>
        /// T9を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T9 value) { Case9 = new Option<T9>(value); }

        /// <summary>
        /// T9型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T9 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value); }

        /// <summary>
        /// T10を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T10 value) { Case10 = new Option<T10>(value); }

        /// <summary>
        /// T10型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T10 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value); }

        /// <summary>
        /// T11を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T11 value) { Case11 = new Option<T11>(value); }

        /// <summary>
        /// T11型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T11 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value); }

        /// <summary>
        /// T12を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T12 value) { Case12 = new Option<T12>(value); }

        /// <summary>
        /// T12型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T12 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value); }

        /// <summary>
        /// T13を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T13 value) { Case13 = new Option<T13>(value); }

        /// <summary>
        /// T13型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T13 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value); }

        /// <summary>
        /// T14を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T14 value) { Case14 = new Option<T14>(value); }

        /// <summary>
        /// T14型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T14 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value); }

        /// <summary>
        /// 擬似的にパターンマッチを行います。
        /// </summary>
        public T Match<T>(Func<T1, T> Case1, Func<T2, T> Case2, Func<T3, T> Case3, Func<T4, T> Case4, Func<T5, T> Case5, Func<T6, T> Case6, Func<T7, T> Case7, Func<T8, T> Case8, Func<T9, T> Case9, Func<T10, T> Case10, Func<T11, T> Case11, Func<T12, T> Case12, Func<T13, T> Case13, Func<T14, T> Case14)
        {
            Func<T> thrower = () => { throw new InvalidOperationException(); };
            return this.Case1.Match<T>(Case1, () => this.Case2.Match<T>(Case2, () => this.Case3.Match<T>(Case3, () => this.Case4.Match<T>(Case4, () => this.Case5.Match<T>(Case5, () => this.Case6.Match<T>(Case6, () => this.Case7.Match<T>(Case7, () => this.Case8.Match<T>(Case8, () => this.Case9.Match<T>(Case9, () => this.Case10.Match<T>(Case10, () => this.Case11.Match<T>(Case11, () => this.Case12.Match<T>(Case12, () => this.Case13.Match<T>(Case13, () => this.Case14.Match<T>(Case14, thrower))))))))))))));
        }

        /// <summary>
        /// 擬似的にパターンマッチを行います。
        /// </summary>
        public void Match(Action<T1> Case1, Action<T2> Case2, Action<T3> Case3, Action<T4> Case4, Action<T5> Case5, Action<T6> Case6, Action<T7> Case7, Action<T8> Case8, Action<T9> Case9, Action<T10> Case10, Action<T11> Case11, Action<T12> Case12, Action<T13> Case13, Action<T14> Case14)
        {
            Action thrower = () => { throw new InvalidOperationException(); };
            this.Case1.Match(Case1, () => this.Case2.Match(Case2, () => this.Case3.Match(Case3, () => this.Case4.Match(Case4, () => this.Case5.Match(Case5, () => this.Case6.Match(Case6, () => this.Case7.Match(Case7, () => this.Case8.Match(Case8, () => this.Case9.Match(Case9, () => this.Case10.Match(Case10, () => this.Case11.Match(Case11, () => this.Case12.Match(Case12, () => this.Case13.Match(Case13, () => this.Case14.Match(Case14, thrower))))))))))))));
        }

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較するChoice</param>
        /// <returns>現在のオブジェクトがotherで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        public bool Equals(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> other)
        {
            return other.IsNotNull() && Case1 == other.Case1 && Case2 == other.Case2 && Case3 == other.Case3 && Case4 == other.Case4 && Case5 == other.Case5 && Case6 == other.Case6 && Case7 == other.Case7 && Case8 == other.Case8 && Case9 == other.Case9 && Case10 == other.Case10 && Case11 == other.Case11 && Case12 == other.Case12 && Case13 == other.Case13 && Case14 == other.Case14;
        }

        /// <summary>
        /// 2つのChoceの比較を行います。 
        /// </summary>
        /// <param name="a">1つ目のChoice</param>
        /// <param name="b">2つ目のChoice</param>
        /// <returns>2つのChoiceが等しい場合はtrue、それ以外の場合はfalse</returns>
        public static bool operator ==(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> b)
        {
            if (a.IsNull())
                return b.IsNull();
            return a.Equals(b);
        }

        /// <summary>
        /// 2つのChoceの比較を行います。 
        /// </summary>
        /// <param name="a">1つ目のChoice</param>
        /// <param name="b">2つ目のChoice</param>
        /// <returns>2つのChoiceが等しい場合はfalse、それ以外の場合はtrue</returns>
        public static bool operator !=(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト</param>
        /// <returns>現在のオブジェクトがobjで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            var other = obj as Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>;
            if (other.IsNull())
                return false;
            return Equals(other);
        }

        /// <summary>
        /// オブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>ハッシュコード</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            var result = 31;
            result ^= Case1.GetHashCode();
            result ^= Case2.GetHashCode();
            result ^= Case3.GetHashCode();
            result ^= Case4.GetHashCode();
            result ^= Case5.GetHashCode();
            result ^= Case6.GetHashCode();
            result ^= Case7.GetHashCode();
            result ^= Case8.GetHashCode();
            result ^= Case9.GetHashCode();
            result ^= Case10.GetHashCode();
            result ^= Case11.GetHashCode();
            result ^= Case12.GetHashCode();
            result ^= Case13.GetHashCode();
            result ^= Case14.GetHashCode();
            return result;
        }

        /// <summary>
        /// このオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>このオブジェクトの文字列表現</returns>
        public override string ToString()
        {
            return Match(
                t1 => string.Format("Choice({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Choice({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Choice({0}:{1})", t3, typeof(T3).Name),
                t4 => string.Format("Choice({0}:{1})", t4, typeof(T4).Name),
                t5 => string.Format("Choice({0}:{1})", t5, typeof(T5).Name),
                t6 => string.Format("Choice({0}:{1})", t6, typeof(T6).Name),
                t7 => string.Format("Choice({0}:{1})", t7, typeof(T7).Name),
                t8 => string.Format("Choice({0}:{1})", t8, typeof(T8).Name),
                t9 => string.Format("Choice({0}:{1})", t9, typeof(T9).Name),
                t10 => string.Format("Choice({0}:{1})", t10, typeof(T10).Name),
                t11 => string.Format("Choice({0}:{1})", t11, typeof(T11).Name),
                t12 => string.Format("Choice({0}:{1})", t12, typeof(T12).Name),
                t13 => string.Format("Choice({0}:{1})", t13, typeof(T13).Name),
                t14 => string.Format("Choice({0}:{1})", t14, typeof(T14).Name)
            );
        }
    }

    /// <summary>
    /// 複数の型のうち、どれか一つを保持する「多者択一」を表す型です。
    /// </summary>
    public sealed class Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : IEquatable<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>
    {
        internal readonly Option<T1> Case1;
        internal readonly Option<T2> Case2;
        internal readonly Option<T3> Case3;
        internal readonly Option<T4> Case4;
        internal readonly Option<T5> Case5;
        internal readonly Option<T6> Case6;
        internal readonly Option<T7> Case7;
        internal readonly Option<T8> Case8;
        internal readonly Option<T9> Case9;
        internal readonly Option<T10> Case10;
        internal readonly Option<T11> Case11;
        internal readonly Option<T12> Case12;
        internal readonly Option<T13> Case13;
        internal readonly Option<T14> Case14;
        internal readonly Option<T15> Case15;

        /// <summary>
        /// 何番目の型を保持しているかを取得します。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int TagIndex { get { return this.Match(_ => 1, _ => 2, _ => 3, _ => 4, _ => 5, _ => 6, _ => 7, _ => 8, _ => 9, _ => 10, _ => 11, _ => 12, _ => 13, _ => 14, _ => 15); } }

        /// <summary>
        /// T1を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T1 value) { Case1 = new Option<T1>(value); }

        /// <summary>
        /// T1型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value); }

        /// <summary>
        /// T2を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T2 value) { Case2 = new Option<T2>(value); }

        /// <summary>
        /// T2型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T2 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value); }

        /// <summary>
        /// T3を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T3 value) { Case3 = new Option<T3>(value); }

        /// <summary>
        /// T3型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T3 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value); }

        /// <summary>
        /// T4を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T4 value) { Case4 = new Option<T4>(value); }

        /// <summary>
        /// T4型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T4 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value); }

        /// <summary>
        /// T5を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T5 value) { Case5 = new Option<T5>(value); }

        /// <summary>
        /// T5型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T5 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value); }

        /// <summary>
        /// T6を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T6 value) { Case6 = new Option<T6>(value); }

        /// <summary>
        /// T6型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T6 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value); }

        /// <summary>
        /// T7を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T7 value) { Case7 = new Option<T7>(value); }

        /// <summary>
        /// T7型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T7 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value); }

        /// <summary>
        /// T8を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T8 value) { Case8 = new Option<T8>(value); }

        /// <summary>
        /// T8型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T8 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value); }

        /// <summary>
        /// T9を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T9 value) { Case9 = new Option<T9>(value); }

        /// <summary>
        /// T9型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T9 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value); }

        /// <summary>
        /// T10を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T10 value) { Case10 = new Option<T10>(value); }

        /// <summary>
        /// T10型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T10 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value); }

        /// <summary>
        /// T11を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T11 value) { Case11 = new Option<T11>(value); }

        /// <summary>
        /// T11型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T11 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value); }

        /// <summary>
        /// T12を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T12 value) { Case12 = new Option<T12>(value); }

        /// <summary>
        /// T12型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T12 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value); }

        /// <summary>
        /// T13を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T13 value) { Case13 = new Option<T13>(value); }

        /// <summary>
        /// T13型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T13 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value); }

        /// <summary>
        /// T14を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T14 value) { Case14 = new Option<T14>(value); }

        /// <summary>
        /// T14型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T14 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value); }

        /// <summary>
        /// T15を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T15 value) { Case15 = new Option<T15>(value); }

        /// <summary>
        /// T15型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T15 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value); }

        /// <summary>
        /// 擬似的にパターンマッチを行います。
        /// </summary>
        public T Match<T>(Func<T1, T> Case1, Func<T2, T> Case2, Func<T3, T> Case3, Func<T4, T> Case4, Func<T5, T> Case5, Func<T6, T> Case6, Func<T7, T> Case7, Func<T8, T> Case8, Func<T9, T> Case9, Func<T10, T> Case10, Func<T11, T> Case11, Func<T12, T> Case12, Func<T13, T> Case13, Func<T14, T> Case14, Func<T15, T> Case15)
        {
            Func<T> thrower = () => { throw new InvalidOperationException(); };
            return this.Case1.Match<T>(Case1, () => this.Case2.Match<T>(Case2, () => this.Case3.Match<T>(Case3, () => this.Case4.Match<T>(Case4, () => this.Case5.Match<T>(Case5, () => this.Case6.Match<T>(Case6, () => this.Case7.Match<T>(Case7, () => this.Case8.Match<T>(Case8, () => this.Case9.Match<T>(Case9, () => this.Case10.Match<T>(Case10, () => this.Case11.Match<T>(Case11, () => this.Case12.Match<T>(Case12, () => this.Case13.Match<T>(Case13, () => this.Case14.Match<T>(Case14, () => this.Case15.Match<T>(Case15, thrower)))))))))))))));
        }

        /// <summary>
        /// 擬似的にパターンマッチを行います。
        /// </summary>
        public void Match(Action<T1> Case1, Action<T2> Case2, Action<T3> Case3, Action<T4> Case4, Action<T5> Case5, Action<T6> Case6, Action<T7> Case7, Action<T8> Case8, Action<T9> Case9, Action<T10> Case10, Action<T11> Case11, Action<T12> Case12, Action<T13> Case13, Action<T14> Case14, Action<T15> Case15)
        {
            Action thrower = () => { throw new InvalidOperationException(); };
            this.Case1.Match(Case1, () => this.Case2.Match(Case2, () => this.Case3.Match(Case3, () => this.Case4.Match(Case4, () => this.Case5.Match(Case5, () => this.Case6.Match(Case6, () => this.Case7.Match(Case7, () => this.Case8.Match(Case8, () => this.Case9.Match(Case9, () => this.Case10.Match(Case10, () => this.Case11.Match(Case11, () => this.Case12.Match(Case12, () => this.Case13.Match(Case13, () => this.Case14.Match(Case14, () => this.Case15.Match(Case15, thrower)))))))))))))));
        }

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較するChoice</param>
        /// <returns>現在のオブジェクトがotherで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        public bool Equals(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> other)
        {
            return other.IsNotNull() && Case1 == other.Case1 && Case2 == other.Case2 && Case3 == other.Case3 && Case4 == other.Case4 && Case5 == other.Case5 && Case6 == other.Case6 && Case7 == other.Case7 && Case8 == other.Case8 && Case9 == other.Case9 && Case10 == other.Case10 && Case11 == other.Case11 && Case12 == other.Case12 && Case13 == other.Case13 && Case14 == other.Case14 && Case15 == other.Case15;
        }

        /// <summary>
        /// 2つのChoceの比較を行います。 
        /// </summary>
        /// <param name="a">1つ目のChoice</param>
        /// <param name="b">2つ目のChoice</param>
        /// <returns>2つのChoiceが等しい場合はtrue、それ以外の場合はfalse</returns>
        public static bool operator ==(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> b)
        {
            if (a.IsNull())
                return b.IsNull();
            return a.Equals(b);
        }

        /// <summary>
        /// 2つのChoceの比較を行います。 
        /// </summary>
        /// <param name="a">1つ目のChoice</param>
        /// <param name="b">2つ目のChoice</param>
        /// <returns>2つのChoiceが等しい場合はfalse、それ以外の場合はtrue</returns>
        public static bool operator !=(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト</param>
        /// <returns>現在のオブジェクトがobjで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            var other = obj as Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>;
            if (other.IsNull())
                return false;
            return Equals(other);
        }

        /// <summary>
        /// オブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>ハッシュコード</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            var result = 31;
            result ^= Case1.GetHashCode();
            result ^= Case2.GetHashCode();
            result ^= Case3.GetHashCode();
            result ^= Case4.GetHashCode();
            result ^= Case5.GetHashCode();
            result ^= Case6.GetHashCode();
            result ^= Case7.GetHashCode();
            result ^= Case8.GetHashCode();
            result ^= Case9.GetHashCode();
            result ^= Case10.GetHashCode();
            result ^= Case11.GetHashCode();
            result ^= Case12.GetHashCode();
            result ^= Case13.GetHashCode();
            result ^= Case14.GetHashCode();
            result ^= Case15.GetHashCode();
            return result;
        }

        /// <summary>
        /// このオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>このオブジェクトの文字列表現</returns>
        public override string ToString()
        {
            return Match(
                t1 => string.Format("Choice({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Choice({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Choice({0}:{1})", t3, typeof(T3).Name),
                t4 => string.Format("Choice({0}:{1})", t4, typeof(T4).Name),
                t5 => string.Format("Choice({0}:{1})", t5, typeof(T5).Name),
                t6 => string.Format("Choice({0}:{1})", t6, typeof(T6).Name),
                t7 => string.Format("Choice({0}:{1})", t7, typeof(T7).Name),
                t8 => string.Format("Choice({0}:{1})", t8, typeof(T8).Name),
                t9 => string.Format("Choice({0}:{1})", t9, typeof(T9).Name),
                t10 => string.Format("Choice({0}:{1})", t10, typeof(T10).Name),
                t11 => string.Format("Choice({0}:{1})", t11, typeof(T11).Name),
                t12 => string.Format("Choice({0}:{1})", t12, typeof(T12).Name),
                t13 => string.Format("Choice({0}:{1})", t13, typeof(T13).Name),
                t14 => string.Format("Choice({0}:{1})", t14, typeof(T14).Name),
                t15 => string.Format("Choice({0}:{1})", t15, typeof(T15).Name)
            );
        }
    }

    /// <summary>
    /// 複数の型のうち、どれか一つを保持する「多者択一」を表す型です。
    /// </summary>
    public sealed class Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : IEquatable<Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>
    {
        internal readonly Option<T1> Case1;
        internal readonly Option<T2> Case2;
        internal readonly Option<T3> Case3;
        internal readonly Option<T4> Case4;
        internal readonly Option<T5> Case5;
        internal readonly Option<T6> Case6;
        internal readonly Option<T7> Case7;
        internal readonly Option<T8> Case8;
        internal readonly Option<T9> Case9;
        internal readonly Option<T10> Case10;
        internal readonly Option<T11> Case11;
        internal readonly Option<T12> Case12;
        internal readonly Option<T13> Case13;
        internal readonly Option<T14> Case14;
        internal readonly Option<T15> Case15;
        internal readonly Option<T16> Case16;

        /// <summary>
        /// 何番目の型を保持しているかを取得します。
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public int TagIndex { get { return this.Match(_ => 1, _ => 2, _ => 3, _ => 4, _ => 5, _ => 6, _ => 7, _ => 8, _ => 9, _ => 10, _ => 11, _ => 12, _ => 13, _ => 14, _ => 15, _ => 16); } }

        /// <summary>
        /// T1を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T1 value) { Case1 = new Option<T1>(value); }

        /// <summary>
        /// T1型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T1 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value); }

        /// <summary>
        /// T2を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T2 value) { Case2 = new Option<T2>(value); }

        /// <summary>
        /// T2型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T2 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value); }

        /// <summary>
        /// T3を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T3 value) { Case3 = new Option<T3>(value); }

        /// <summary>
        /// T3型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T3 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value); }

        /// <summary>
        /// T4を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T4 value) { Case4 = new Option<T4>(value); }

        /// <summary>
        /// T4型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T4 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value); }

        /// <summary>
        /// T5を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T5 value) { Case5 = new Option<T5>(value); }

        /// <summary>
        /// T5型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T5 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value); }

        /// <summary>
        /// T6を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T6 value) { Case6 = new Option<T6>(value); }

        /// <summary>
        /// T6型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T6 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value); }

        /// <summary>
        /// T7を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T7 value) { Case7 = new Option<T7>(value); }

        /// <summary>
        /// T7型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T7 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value); }

        /// <summary>
        /// T8を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T8 value) { Case8 = new Option<T8>(value); }

        /// <summary>
        /// T8型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T8 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value); }

        /// <summary>
        /// T9を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T9 value) { Case9 = new Option<T9>(value); }

        /// <summary>
        /// T9型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T9 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value); }

        /// <summary>
        /// T10を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T10 value) { Case10 = new Option<T10>(value); }

        /// <summary>
        /// T10型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T10 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value); }

        /// <summary>
        /// T11を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T11 value) { Case11 = new Option<T11>(value); }

        /// <summary>
        /// T11型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T11 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value); }

        /// <summary>
        /// T12を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T12 value) { Case12 = new Option<T12>(value); }

        /// <summary>
        /// T12型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T12 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value); }

        /// <summary>
        /// T13を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T13 value) { Case13 = new Option<T13>(value); }

        /// <summary>
        /// T13型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T13 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value); }

        /// <summary>
        /// T14を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T14 value) { Case14 = new Option<T14>(value); }

        /// <summary>
        /// T14型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T14 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value); }

        /// <summary>
        /// T15を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T15 value) { Case15 = new Option<T15>(value); }

        /// <summary>
        /// T15型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T15 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value); }

        /// <summary>
        /// T16を保持するChoice[...]オブジェクトを生成します。
        /// </summary>
        public Choice(T16 value) { Case16 = new Option<T16>(value); }

        /// <summary>
        /// T16型のオブジェクトをChoice[...]に変換します。
        /// </summary>
        public static implicit operator Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T16 value) { return new Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value); }

        /// <summary>
        /// 擬似的にパターンマッチを行います。
        /// </summary>
        public T Match<T>(Func<T1, T> Case1, Func<T2, T> Case2, Func<T3, T> Case3, Func<T4, T> Case4, Func<T5, T> Case5, Func<T6, T> Case6, Func<T7, T> Case7, Func<T8, T> Case8, Func<T9, T> Case9, Func<T10, T> Case10, Func<T11, T> Case11, Func<T12, T> Case12, Func<T13, T> Case13, Func<T14, T> Case14, Func<T15, T> Case15, Func<T16, T> Case16)
        {
            Func<T> thrower = () => { throw new InvalidOperationException(); };
            return this.Case1.Match<T>(Case1, () => this.Case2.Match<T>(Case2, () => this.Case3.Match<T>(Case3, () => this.Case4.Match<T>(Case4, () => this.Case5.Match<T>(Case5, () => this.Case6.Match<T>(Case6, () => this.Case7.Match<T>(Case7, () => this.Case8.Match<T>(Case8, () => this.Case9.Match<T>(Case9, () => this.Case10.Match<T>(Case10, () => this.Case11.Match<T>(Case11, () => this.Case12.Match<T>(Case12, () => this.Case13.Match<T>(Case13, () => this.Case14.Match<T>(Case14, () => this.Case15.Match<T>(Case15, () => this.Case16.Match<T>(Case16, thrower))))))))))))))));
        }

        /// <summary>
        /// 擬似的にパターンマッチを行います。
        /// </summary>
        public void Match(Action<T1> Case1, Action<T2> Case2, Action<T3> Case3, Action<T4> Case4, Action<T5> Case5, Action<T6> Case6, Action<T7> Case7, Action<T8> Case8, Action<T9> Case9, Action<T10> Case10, Action<T11> Case11, Action<T12> Case12, Action<T13> Case13, Action<T14> Case14, Action<T15> Case15, Action<T16> Case16)
        {
            Action thrower = () => { throw new InvalidOperationException(); };
            this.Case1.Match(Case1, () => this.Case2.Match(Case2, () => this.Case3.Match(Case3, () => this.Case4.Match(Case4, () => this.Case5.Match(Case5, () => this.Case6.Match(Case6, () => this.Case7.Match(Case7, () => this.Case8.Match(Case8, () => this.Case9.Match(Case9, () => this.Case10.Match(Case10, () => this.Case11.Match(Case11, () => this.Case12.Match(Case12, () => this.Case13.Match(Case13, () => this.Case14.Match(Case14, () => this.Case15.Match(Case15, () => this.Case16.Match(Case16, thrower))))))))))))))));
        }

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較するChoice</param>
        /// <returns>現在のオブジェクトがotherで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        public bool Equals(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> other)
        {
            return other.IsNotNull() && Case1 == other.Case1 && Case2 == other.Case2 && Case3 == other.Case3 && Case4 == other.Case4 && Case5 == other.Case5 && Case6 == other.Case6 && Case7 == other.Case7 && Case8 == other.Case8 && Case9 == other.Case9 && Case10 == other.Case10 && Case11 == other.Case11 && Case12 == other.Case12 && Case13 == other.Case13 && Case14 == other.Case14 && Case15 == other.Case15 && Case16 == other.Case16;
        }

        /// <summary>
        /// 2つのChoceの比較を行います。 
        /// </summary>
        /// <param name="a">1つ目のChoice</param>
        /// <param name="b">2つ目のChoice</param>
        /// <returns>2つのChoiceが等しい場合はtrue、それ以外の場合はfalse</returns>
        public static bool operator ==(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> b)
        {
            if (a.IsNull())
                return b.IsNull();
            return a.Equals(b);
        }

        /// <summary>
        /// 2つのChoceの比較を行います。 
        /// </summary>
        /// <param name="a">1つ目のChoice</param>
        /// <param name="b">2つ目のChoice</param>
        /// <returns>2つのChoiceが等しい場合はfalse、それ以外の場合はtrue</returns>
        public static bool operator !=(Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> a, Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト</param>
        /// <returns>現在のオブジェクトがobjで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            var other = obj as Choice<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>;
            if (other.IsNull())
                return false;
            return Equals(other);
        }

        /// <summary>
        /// オブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>ハッシュコード</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            var result = 31;
            result ^= Case1.GetHashCode();
            result ^= Case2.GetHashCode();
            result ^= Case3.GetHashCode();
            result ^= Case4.GetHashCode();
            result ^= Case5.GetHashCode();
            result ^= Case6.GetHashCode();
            result ^= Case7.GetHashCode();
            result ^= Case8.GetHashCode();
            result ^= Case9.GetHashCode();
            result ^= Case10.GetHashCode();
            result ^= Case11.GetHashCode();
            result ^= Case12.GetHashCode();
            result ^= Case13.GetHashCode();
            result ^= Case14.GetHashCode();
            result ^= Case15.GetHashCode();
            result ^= Case16.GetHashCode();
            return result;
        }

        /// <summary>
        /// このオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>このオブジェクトの文字列表現</returns>
        public override string ToString()
        {
            return Match(
                t1 => string.Format("Choice({0}:{1})", t1, typeof(T1).Name),
                t2 => string.Format("Choice({0}:{1})", t2, typeof(T2).Name),
                t3 => string.Format("Choice({0}:{1})", t3, typeof(T3).Name),
                t4 => string.Format("Choice({0}:{1})", t4, typeof(T4).Name),
                t5 => string.Format("Choice({0}:{1})", t5, typeof(T5).Name),
                t6 => string.Format("Choice({0}:{1})", t6, typeof(T6).Name),
                t7 => string.Format("Choice({0}:{1})", t7, typeof(T7).Name),
                t8 => string.Format("Choice({0}:{1})", t8, typeof(T8).Name),
                t9 => string.Format("Choice({0}:{1})", t9, typeof(T9).Name),
                t10 => string.Format("Choice({0}:{1})", t10, typeof(T10).Name),
                t11 => string.Format("Choice({0}:{1})", t11, typeof(T11).Name),
                t12 => string.Format("Choice({0}:{1})", t12, typeof(T12).Name),
                t13 => string.Format("Choice({0}:{1})", t13, typeof(T13).Name),
                t14 => string.Format("Choice({0}:{1})", t14, typeof(T14).Name),
                t15 => string.Format("Choice({0}:{1})", t15, typeof(T15).Name),
                t16 => string.Format("Choice({0}:{1})", t16, typeof(T16).Name)
            );
        }
    }

}