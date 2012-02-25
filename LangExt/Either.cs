using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LangExt
{
    /// <summary>
    /// Eitherを取得します。
    /// </summary>
    public static class Either
    {
        /// <summary>
        /// 定義されていない型を示します。
        /// </summary>
        public class Undefined { }

        internal interface IEitherRight<T>
        {
            Option<T> GetRight();
        }


        internal interface IEitherLeft<T>
        {
            Option<T> GetLeft();
        }

        /// <summary>
        /// Left値を取得します。
        /// </summary>
        /// <typeparam name="TLeft"></typeparam>
        /// <param name="left"></param>
        /// <returns></returns>
        public static Either<TLeft, Undefined> Left<TLeft>(TLeft left)
        {
            if (left == null) throw new ArgumentNullException("left");

            return new Either<TLeft, Undefined>(left);
        }

        /// <summary>
        /// Right値を取得します。
        /// </summary>
        /// <typeparam name="TRight"></typeparam>
        /// <param name="right"></param>
        /// <returns></returns>
        public static Either<Undefined, TRight> Right<TRight>(TRight right)
        {
            if (right == null) throw new ArgumentNullException("right");

            return new Either<Undefined, TRight>(right);
        }
    }


    /// <summary>
    /// LeftかRightかどちらかの値を示します。
    /// </summary>
    /// <typeparam name="TLeft"></typeparam>
    /// <typeparam name="TRight"></typeparam>
    public class Either<TLeft, TRight> : IEquatable<Either<TLeft, TRight>>, Either.IEitherLeft<TLeft>, Either.IEitherRight<TRight>
    {
        Option<TLeft> left;
        Option<TRight> right;

        public Either<TLeft, TRight2> Bind<TRight2>(Func<TRight, Either<TLeft, TRight2>> f)
        {
            return Match<Either<TLeft, TRight2>>(left => Either.Left(left), right => f(right));
        }

        /// <summary>
        /// 型がTであるかを示す値を返します。
        /// </summary>
        /// <typeparam name="T">型引数T</typeparam>
        /// <returns>結果の値</returns>
        public bool Is<T>()
        {
            return (typeof(T) == typeof(TLeft) && left != Option<TLeft>.None)
                || ( typeof(T) == typeof(TRight) && right != Option<TRight>.None);
        }

        /// <summary>
        /// Leftの値を取得します。
        /// </summary>
        [Obsolete("このプロパティは使わないでください。代わりにパターンマッチを使います")]
        public TLeft Left
        {
            get { return (TLeft)left; }
        }

        /// <summary>
        /// Rightの値を取得します。
        /// </summary>
        [Obsolete("このプロパティは使わないでください。代わりにパターンマッチを使います")]
        public TRight Right
        {
            get { return (TRight)right; }
        }

        Option<TLeft> Either.IEitherLeft<TLeft>.GetLeft()
        {
            return left;
        }

        Option<TRight> Either.IEitherRight<TRight>.GetRight()
        {
            return right;
        }
 
        private Either() { }
        internal Either(TLeft left)
        {
            this.left = left;
        }

        internal Either(TRight right)
        {
            this.right = right;
        }

        /// <summary>
        /// パターンマッチを行います
        /// </summary>
        /// <typeparam name="S">マッチした関数の結果</typeparam>
        /// <param name="ifLeft">Leftにマッチしたときの関数</param>
        /// <param name="ifRight">Rightにマッチしたときの関数</param>
        /// <returns></returns>
        public S Match<S>(
            Func<TLeft, S> ifLeft,
            Func<TRight, S> ifRight)
        {
            if (left != Option<TLeft>.None)
            {
                return ifLeft(Left);
            }
            else
            {
                return ifRight(Right);
            }
        }

        public static implicit operator Either<TLeft, TRight>(Either<TLeft, Either.Undefined> other)
        {
            return new Either<TLeft, TRight>(other.Left);
        }

        public static implicit operator Either<TLeft, TRight>(Either<Either.Undefined, TRight> other)
        {
            return new Either<TLeft, TRight>(other.Right);
        }    
        
        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較する Either。</param>
        /// <returns>現在のオブジェクトが other パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public bool Equals(Either<TLeft,TRight> other)
        {
            return (other.left == left) && (other.right == right);
        }

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較する Either。</param>
        /// <returns>現在のオブジェクトが other パラメータと等しい場合は true。それ以外の場合は false。</returns>
        private bool EqualsRight(Either.IEitherRight<TRight> other)
        {
            return (other.GetRight() == right);
        }

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較する Either。</param>
        /// <returns>現在のオブジェクトが other パラメータと等しい場合は true。それ以外の場合は false。</returns>
        private bool EqualsLeft(Either.IEitherLeft<TLeft> other)
        {
            return (other.GetLeft() == left);
        }

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト。</param>
        /// <returns>現在のオブジェクトが obj パラメータと等しい場合は true。それ以外の場合は false。</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Either<TLeft, TRight>))
            {
                if (this is Either<Either.Undefined, TRight> || obj is Either<Either.Undefined, TRight>)
                {
                    return EqualsRight((Either.IEitherRight<TRight>)obj);
                }
                else if (this is Either<TLeft, Either.Undefined> || obj is Either<TLeft, Either.Undefined>)
                {
                    return EqualsLeft((Either.IEitherLeft<TLeft>)obj);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return Equals((Either<TLeft, TRight>)obj);
            }
        }

        /// <summary>
        /// 2 つの Either の比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Either。</param>
        /// <param name="b">2 つ目の Either。</param>
        /// <returns>2 つの Either が等しい場合は true、それ以外の場合は false。</returns>
        public static bool operator ==(Either<TLeft, TRight> a, Either<TLeft, TRight> b)
        {
            return a.Equals(b);
        }

        /// <summary>
        /// 2 つの Either の比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Either。</param>
        /// <param name="b">2 つ目の Either。</param>
        /// <returns>2 つの Either が等しい場合は false、それ以外の場合は true。</returns>
        public static bool operator !=(Either<TLeft, TRight> a, Either<TLeft, TRight> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 2 つの Either の比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Either。</param>
        /// <param name="b">2 つ目の Either。</param>
        /// <returns>2 つの Either が等しい場合は true、それ以外の場合は false。</returns>
        public static bool operator ==(Either<Either.Undefined, TRight> a, Either<TLeft, TRight> b)
        {
            return a.Equals(b);
        }

        /// <summary>
        /// 2 つの Either の比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Either。</param>
        /// <param name="b">2 つ目の Either。</param>
        /// <returns>2 つの Option が等しい場合は false、それ以外の場合は true。</returns>
        public static bool operator !=(Either<Either.Undefined, TRight> a, Either<TLeft, TRight> b)
        {
            return !(a == b);
        }

        /// 2 つの Option の比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Either。</param>
        /// <param name="b">2 つ目の Either。</param>
        /// <returns>2 つの Either が等しい場合は true、それ以外の場合は false。</returns>
        public static bool operator ==(Either<TLeft, Either.Undefined> a, Either<TLeft, TRight> b)
        {
            return a.Equals(b);
        }

        /// <summary>
        /// 2 つの Either の比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Either。</param>
        /// <param name="b">2 つ目の Either。</param>
        /// <returns>2 つの Either が等しい場合は false、それ以外の場合は true。</returns>
        public static bool operator !=(Either<TLeft, Either.Undefined> a, Either<TLeft, TRight> b)
        {
            return !(a == b);
        }


        /// <summary>
        /// 2 つの Either の比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Either。</param>
        /// <param name="b">2 つ目の Either。</param>
        /// <returns>2 つの Either が等しい場合は true、それ以外の場合は false。</returns>
        public static bool operator ==(Either<TLeft, TRight> a, Either<Either.Undefined, TRight> b)
        {
            return a.Equals(b);
        }

        /// <summary>
        /// 2 つの Either の比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Either。</param>
        /// <param name="b">2 つ目の Either。</param>
        /// <returns>2 つの Either が等しい場合は false、それ以外の場合は true。</returns>
        public static bool operator !=(Either<TLeft, TRight> a, Either<Either.Undefined, TRight> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 2 つの Either の比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Either。</param>
        /// <param name="b">2 つ目の Either。</param>
        /// <returns>2 つの Either が等しい場合は true、それ以外の場合は false。</returns>
        public static bool operator ==(Either<TLeft, TRight> a, Either<TLeft, Either.Undefined> b)
        {
            return a.Equals(b);
        }

        /// <summary>
        /// 2 つの Either の比較を行います。
        /// </summary>
        /// <param name="a">1 つ目の Either。</param>
        /// <param name="b">2 つ目の Either。</param>
        /// <returns>2 つの Either が等しい場合は false、それ以外の場合は true。</returns>
        public static bool operator !=(Either<TLeft, TRight> a, Either<TLeft, Either.Undefined> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 現在のオブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>現在のオブジェクトのハッシュコード。</returns>
        public override int GetHashCode()
        {
            var result = 31;
            result ^= left.GetHashCode();
            result ^= right.GetHashCode();
            return result;
        }

        /// <summary>
        /// 現在のオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>現在のオブジェクトの文字列表現。</returns>
        public override string ToString()
        {
            if (right != Option<TRight>.None)
                return string.Format("Right({0})", right.Match(some => some, _ => { throw new InvalidCastException(); }));
            else
                return string.Format("Left({0})", left.Match(some => some, _ => { throw new InvalidCastException(); }));
        }


    }
}
