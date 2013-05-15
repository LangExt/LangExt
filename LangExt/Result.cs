using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace LangExt
{
    partial class Create
    {
        /// <summary>
        /// valueがnullでない場合はResult.Success(value)と、
        /// valueがnullの場合はResult.Failure(Unit._)と同じオブジェクトを返します。
        /// </summary>
        /// <typeparam name="T">生成するResultのSuccess側の要素の型</typeparam>
        /// <param name="value">値</param>
        /// <returns>valueがnullの場合Failure、そうでない場合Success</returns>
        public static Result<T, Unit> Result<T>(T value) where T : class
        {
            return LangExt.Result.Create(value);
        }

        /// <summary>
        /// valueがnullでない場合はResult.Success(value.Value)と、
        /// valueがnullの場合はResult.Failure(Unit._)と同じオブジェクトを返します。
        /// </summary>
        /// <typeparam name="T">生成するResultのSuccess側の要素の型</typeparam>
        /// <param name="value">値</param>
        /// <returns>valueがnullの場合Failure、そうでない場合Success</returns>
        public static Result<T, Unit> Result<T>(T? value) where T : struct
        {
            return LangExt.Result.Create(value);
        }
    }

    /// <summary>
    /// Resultに対する関数を提供します。
    /// </summary>
    public static partial class Result
    {
        /// <summary>
        /// valueがnullでない場合はResult.Success(value)と、
        /// valueがnullの場合はResult.Failure(Unit._)と同じオブジェクトを返します。
        /// </summary>
        /// <typeparam name="T">生成するResultのSuccess側の要素の型</typeparam>
        /// <param name="value">値</param>
        /// <returns>valueがnullの場合Failure、そうでない場合Success</returns>
        public static Result<T, Unit> Create<T>(T value) where T : class
        {
            if (value == null)
                return Result.Failure(Unit._);
            return Result.Success(value);
        }

        /// <summary>
        /// valueがnullでない場合はResult.Success(value.Value)と、
        /// valueがnullの場合はResult.Failure(Unit._)と同じオブジェクトを返します。
        /// </summary>
        /// <typeparam name="T">生成するResultのSuccess側の要素の型</typeparam>
        /// <param name="value">値</param>
        /// <returns>valueがnullの場合Failure、そうでない場合Success</returns>
        public static Result<T, Unit> Create<T>(T? value) where T : struct
        {
            if (value == null)
                return Result.Failure(Unit._);
            return Result.Success(value.Value);
        }

        /// <summary>
        /// 成功した結果としてvalueを格納するResultを生成します。
        /// 通常は、NewSuccessではなく、Successを使用します。
        /// このメソッドは、失敗側の型も指定したい場合に使用します。
        /// </summary>
        /// <typeparam name="TSuccess">Resultに保持する成功の型</typeparam>
        /// <typeparam name="TFailure">Resultに保持する失敗の型</typeparam>
        /// <param name="value">Resultに保持する成功を表す値</param>
        /// <returns>Success(value)</returns>
        public static Result<TSuccess, TFailure> NewSuccess<TSuccess, TFailure>(TSuccess value)
        {
            return new Result<TSuccess, TFailure>(Option.Some(value), Option<TFailure>.None);
        }

        /// <summary>
        /// 成功した結果としてvalueを格納するResultを生成します。
        /// </summary>
        /// <typeparam name="TSuccess">Resultに保持する成功の型</typeparam>
        /// <param name="value">Resultに保持する成功を表す値</param>
        /// <returns>Success(value)</returns>
        public static Result<TSuccess, Placeholder> Success<TSuccess>(TSuccess value)
        {
            return new Result<TSuccess, Placeholder>(Option.Some(value), Option.None);
        }

        /// <summary>
        /// 失敗した結果としてvalueを格納するResultを生成します。
        /// 通常は、NewFailureではなく、Failureを使用します。
        /// このメソッドは、成功側の型も指定したい場合に使用します。
        /// </summary>
        /// <typeparam name="TSuccess">Resultに保持する成功の型</typeparam>
        /// <typeparam name="TFailure">Resultに保持する失敗の型</typeparam>
        /// <param name="value">Resultに保持する失敗を表す値</param>
        /// <returns>Failure(value)</returns>
        public static Result<TSuccess, TFailure> NewFailure<TSuccess, TFailure>(TFailure value)
        {
            return new Result<TSuccess, TFailure>(Option<TSuccess>.None, Option.Some(value));
        }

        /// <summary>
        /// 失敗した結果としてvalueを格納するResultを生成します。
        /// </summary>
        /// <typeparam name="TFailure">Resultに格納する失敗の型</typeparam>
        /// <param name="value">Resultに保持する失敗を表す値</param>
        /// <returns>Failure(value)</returns>
        public static Result<Placeholder, TFailure> Failure<TFailure>(TFailure value)
        {
            return new Result<Placeholder, TFailure>(Option.None, Option.Some(value));
        }

        /// <summary>
        /// 失敗しうる無引数関数からResultを生成します。
        /// この関数は、例外を使用するAPIとResultを使ったAPIの橋渡しをします。
        /// </summary>
        /// <typeparam name="TSuccess">関数が成功した場合の型(戻り値の型)</typeparam>
        /// <param name="f">実行する関数</param>
        /// <returns>関数が成功した場合、結果をSuccessで包んだ値。失敗した場合、例外をFailureで包んだ値。</returns>
        public static Result<TSuccess, Exception> FromFunc<TSuccess>(Func<TSuccess> f)
        {
            try { return Result.Success(f()); }
            catch (Exception e) { return Result.Failure(e); }
        }
        
        /// <summary>
        /// 保持している成功の値を強制的に取得します。
        /// このメソッドはFailureの場合に意味のない値(default(TFailure))を返すため、危険です。
        /// そのため、このメソッドは基本的には使用せず、MatchメソッドやGetOrメソッドを使用するようにしてください。
        /// </summary>
        /// <returns>内部で保持している成功の値</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static TSuccess GetSuccessValue<TSuccess, TFailure>(this Result<TSuccess, TFailure> self)
        {
            return self.SuccessValue;
        }

        /// <summary>
        /// 保持している失敗の値を強制的に取得します。
        /// このメソッドはSuccessの場合に意味のない値(default(TSuccess))を返すため、危険です。
        /// そのため、このメソッドは基本的には使用せず、MatchメソッドやGetFailureOrメソッドを使用するようにしてください。
        /// </summary>
        /// <returns>内部で保持している失敗の値</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static TFailure GetFailureValue<TSuccess, TFailure>(this Result<TSuccess, TFailure> self)
        {
            return self.FailureValue;
        }

        /// <summary>
        /// 成功かどうかを判断する関数が必要な時に使います。
        /// Result[TSuccess, TFailure]がプロパティとしてIsSuccessを持つため、拡張メソッドにはしていません。
        /// </summary>
        public static bool IsSuccess<TSuccess, TFailure>(Result<TSuccess, TFailure> r)
        {
            return r.IsSuccess;
        }

        /// <summary>
        /// 失敗かどうかを判断する関数が必要な時に使います。
        /// Result[TSuccess, TFailure]がプロパティとしてIsFailureを持つため、拡張メソッドにはしていません。
        /// </summary>
        public static bool IsFailure<TSuccess, TFailure>(Result<TSuccess, TFailure> r)
        {
            return r.IsFailure;
        }
    }

    /// <summary>
    /// Option[T]に加え、失敗時の原因も表すことのできるデータ型です。
    /// </summary>
    /// <remarks>
    /// この型は成功を表す「Success」と、失敗を表す「Failure」のどちらかとなります。
    /// </remarks>
    /// <typeparam name="TSuccess">成功したときの値の型</typeparam>
    /// <typeparam name="TFailure">失敗したときの値の型</typeparam>
    public sealed class Result<TSuccess, TFailure> : IEquatable<Result<TSuccess, TFailure>>
    {
        readonly Option<TSuccess> success;
        readonly Option<TFailure> failure;

        /// <summary>
        /// このオブジェクトが成功を表すかどうかを返します。
        /// 制御構文内でboolが必要な場所に対しては、IsSuccessやIsFailureではなく、Resultオブジェクトをそのまま使用することも可能です。
        /// </summary>
        public bool IsSuccess { get { return success.IsSome; } }

        /// <summary>
        /// このオブジェクトが失敗を表すかどうかを返します。
        /// 制御構文内でboolが必要な場所に対しては、IsSuccessやIsFailureではなく、Resultオブジェクトをそのまま使用することも可能です。
        /// </summary>
        public bool IsFailure { get { return failure.IsSome; } }

        internal Result(Option<TSuccess> s, Option<TFailure> f)
        {
            System.Diagnostics.Debug.Assert((s.IsSome && f.IsNone) || (s.IsNone && f.IsSome));
            this.success = s;
            this.failure = f;
        }

        internal TSuccess SuccessValue { get { return success.Value; } }
        internal TFailure FailureValue { get { return failure.Value; } }

        /// <summary>
        /// Successの場合、保持された値を取り出します。
        /// Failureの場合、引数に指定した値を返します。
        /// </summary>
        /// <param name="defaultValue">Failureの場合の戻り値</param>
        /// <returns>Successの場合保持している値。Failureの場合引数で指定した値</returns>
        public TSuccess GetOr(TSuccess defaultValue)
        {
            return this.IsSuccess ? this.SuccessValue : defaultValue;
        }

        /// <summary>
        /// Failureの場合、保持された値を取り出します。
        /// Successの場合、引数に指定した値を返します。
        /// </summary>
        /// <param name="defaultValue">Successの場合の戻り値</param>
        /// <returns>Failureの場合保持している値。Successの場合引数で指定した値</returns>
        public TFailure GetFailureOr(TFailure defaultValue)
        {
            return this.IsFailure ? this.FailureValue : defaultValue;
        }

        /// <summary>
        /// Successの場合、保持された値を取り出します。
        /// Failureの場合、引数に指定した関数の実行結果を返します。
        /// </summary>
        /// <param name="defaultF">Failureの場合の戻り値を返す関数</param>
        /// <returns>Successの場合保持している値。Failureの場合引数で指定した関数が返す値</returns>
        public TSuccess GetOrElse(Func<TSuccess> defaultF)
        {
            return this.IsSuccess ? this.SuccessValue : defaultF();
        }

        /// <summary>
        /// Failureの場合、保持された値を取り出します。
        /// Successの場合、引数に指定した関数の実行結果を返します。
        /// </summary>
        /// <param name="defaultF">Successの場合の戻り値を返す関数</param>
        /// <returns>Failureの場合保持している値。Successの場合引数で指定した関数が返す値</returns>
        public TFailure GetFailureOrElse(Func<TFailure> defaultF)
        {
            return this.IsFailure ? this.FailureValue : defaultF();
        }

        /// <summary>
        /// Result.Successで取得したオブジェクトを、任意のTFailureのSuccessに暗黙変換します。
        /// </summary>
        /// <param name="r">Result.Success</param>
        /// <returns>任意のTFailureのSuccess</returns>
        public static implicit operator Result<TSuccess, TFailure>(Result<TSuccess, Placeholder> r)
        {
            return new Result<TSuccess, TFailure>(r.success, Option.None);
        }

        /// <summary>
        /// Result[TSuccess, Unit]を、Result[TSuccess, TFailure]に暗黙変換します。
        /// </summary>
        public static implicit operator Result<TSuccess, TFailure>(Result<TSuccess, Unit> r)
        {
            return new Result<TSuccess, TFailure>(r.success, Option.None);
        }

        /// <summary>
        /// Result.Failureで取得したオブジェクトを、任意のTSuccessのFailureに暗黙変換します。
        /// </summary>
        /// <param name="r">Result.Failure</param>
        /// <returns>任意のTSuccessのFailure</returns>
        public static implicit operator Result<TSuccess, TFailure>(Result<Placeholder, TFailure> r)
        {
            return new Result<TSuccess, TFailure>(Option.None, r.failure);
        }

        /// <summary>
        /// Result[Unit, TFailure]を、Result[TSuccess, TFailure]に暗黙変換します。
        /// </summary>
        public static implicit operator Result<TSuccess, TFailure>(Result<Unit, TFailure> r)
        {
            return new Result<TSuccess, TFailure>(Option.None, r.failure);
        }

        /// <summary>
        /// Result[TSuccess, TFailure]型のFailureを、Result[TSuccess2, TFailure]に変換します。
        /// オブジェクトがSuccessの場合、InvalidOperationExceptionが投げられます。
        /// </summary>
        public Result<TSuccess2, TFailure> Cast<TSuccess2>()
        {
            return this.Match(
                s => { throw new InvalidOperationException(); },
                e => Result.Failure(e));
        }

        /// <summary>
        /// Result[TSuccess, TFailure]型を、Result[TSuccess2, TFailure]に変換します。
        /// オブジェクトがSuccessの場合、casterの結果が返ります。
        /// </summary>
        public Result<TSuccess2, TFailure> SafeCast<TSuccess2>(Func<TSuccess, TSuccess2> caster)
        {
            return this.Match(
                s => (Result<TSuccess2, TFailure>)Result.Success(caster(s)),
                e => Result.Failure(e));
        }

        /// <summary>
        /// Result[TSuccess, TFailure]型のFailureを、Result[TSuccess, TFailure2]に変換します。
        /// オブジェクトがFailureの場合、InvalidOperationExceptionが投げられます。
        /// </summary>
        public Result<TSuccess, TFailure2> CastFailure<TFailure2>()
        {
            return this.Match(
                s => Result.Success(s),
                e => { throw new InvalidOperationException(); });
        }

        /// <summary>
        /// Result[TSuccess, TFailure]型を、Result[TSuccess, TFailure2]に変換します。
        /// オブジェクトがFailureの場合、casterの結果が返ります。
        /// </summary>
        public Result<TSuccess, TFailure2> SafeCastFailure<TFailure2>(Func<TFailure, TFailure2> caster)
        {
            return this.Match(
                s => (Result<TSuccess, TFailure2>)Result.Success(s),
                e => Result.Failure(caster(e)));
        }

        /// <summary>
        /// 擬似的にパターンマッチを行います。
        /// 成功の場合と失敗の場合の両方で何らかの処理を行う必要がある際に使用します。
        /// </summary>
        /// <typeparam name="T">パターンマッチが返す処理の型</typeparam>
        /// <param name="Success">Successの場合の処理</param>
        /// <param name="Failure">Failureの場合の処理</param>
        /// <returns>処理が返した値</returns>
        public T Match<T>(Func<TSuccess, T> Success, Func<TFailure, T> Failure)
        {
            return this.IsSuccess ? Success(this.success.Value) : Failure(this.failure.Value);
        }

        /// <summary>
        /// 擬似的にパターンマッチを行います。
        /// 成功の場合と失敗の場合の両方で何らかの処理を行う必要がある際に使用します。
        /// </summary>
        /// <param name="Success">Successの場合の処理</param>
        /// <param name="Failure">Failureの場合の処理</param>
        public void Match(Action<TSuccess> Success, Action<TFailure> Failure)
        {
            if (this.IsSuccess)
                Success(this.success.Value);
            else
                Failure(this.failure.Value);
        }

        /// <summary>
        /// Option[TSuccess, TFailure]をOption[TSuccess2, TFailure]型に変換します。
        /// Successの場合のみに変換を適用します。
        /// 変換は、TSuccess型を受け取りResult[TSuccess2, TFailure]を返す関数として指定します。
        /// </summary>
        /// <typeparam name="TSuccess2">変換先の型</typeparam>
        /// <param name="f">変換に用いる関数</param>
        /// <returns>変換した値</returns>
        public Result<TSuccess2, TFailure> Bind<TSuccess2>(Func<TSuccess, Result<TSuccess2, TFailure>> f)
        {
            return Match<Result<TSuccess2, TFailure>>(success => f(success), failure => Result.Failure(failure));
        }

        /// <summary>
        /// Option[TSuccess, TFailure]をOption[TSuccess, TFailure2]型に変換します。
        /// Failureの場合のみに変換を適用します。
        /// 変換は、TFailure型を受け取りResult[TSuccess, TFailure2]を返す関数として指定します。
        /// </summary>
        /// <typeparam name="TFailure2">変換先の型</typeparam>
        /// <param name="f">変換に用いる関数</param>
        /// <returns>変換した値</returns>
        public Result<TSuccess, TFailure2> BindFailure<TFailure2>(Func<TFailure, Result<TSuccess, TFailure2>> f)
        {
            return Match<Result<TSuccess, TFailure2>>(success => Result.Success(success), failure => f(failure));
        }

        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較するOption</param>
        /// <returns>現在のオブジェクトがotherで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        public bool Equals(Result<TSuccess, TFailure> other)
        {
            if (this.IsSuccess && other.IsSuccess)
                return Equals(this.success, other.success);
            if (this.IsFailure && other.IsFailure)
                return Equals(this.failure, other.failure);
            return false;
        }

        /// <summary>
        /// 現在のオブジェクトが、別のオブジェクトと等しいかどうかを判定します。
        /// </summary>
        /// <param name="obj">このオブジェクトと比較するオブジェクト</param>
        /// <returns>現在のオブジェクトがobjで指定されたオブジェクトと等しい場合はtrue、それ以外の場合はfalse</returns>
        public override bool Equals(object obj)
        {
            if (obj.IsNull())
                return false;

            var type = obj.GetType();
            if (type.IsGenericType == false)
                return false;

            var genType = type.GetGenericTypeDefinition();
            if (genType != typeof(Result<,>))
                return false;

            if ((obj is Result<TSuccess, TFailure>) == false)
                return false;
            return Equals((Result<TSuccess, TFailure>)obj);
        }

        /// <summary>
        /// 2つのResultの比較を行います。 
        /// </summary>
        /// <param name="a">1つ目のResult</param>
        /// <param name="b">2つ目のResult</param>
        /// <returns>2つのResultが等しい場合はtrue、それ以外の場合はfalse</returns>
        public static bool operator ==(Result<TSuccess, TFailure> a, Result<TSuccess, TFailure> b)
        {
            return a.Equals(b);
        }

        /// <summary>
        /// 2つのResultの比較を行います。 
        /// </summary>
        /// <param name="a">1つ目のResult</param>
        /// <param name="b">2つ目のResult</param>
        /// <returns>2つのResultが等しい場合はfalse、それ以外の場合はtrue</returns>
        public static bool operator !=(Result<TSuccess, TFailure> a, Result<TSuccess, TFailure> b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Resultが成功かどうかを判定します。
        /// </summary>
        /// <param name="x">判定の対象</param>
        /// <returns>Successの場合はtrue、Failureの場合はfalse</returns>
        public static bool operator true(Result<TSuccess, TFailure> x)
        {
            return x.IsSuccess;
        }

        /// <summary>
        /// Resultが失敗かどうかを判定します。
        /// </summary>
        /// <param name="x">判定の対象</param>
        /// <returns>Successの場合はfalse、Failureの場合はtrue</returns>
        public static bool operator false(Result<TSuccess, TFailure> x)
        {
            return x.IsFailure;
        }

        /// <summary>
        /// <summary>
        /// 自身が値を持つ場合は自身を、そうでない場合はelsePartの結果を返します。
        /// Resultは短絡のor演算子を提供しているため、そちらを使用したほうが効率的です。
        /// </summary>
        /// <param name="elsePart">自身が値を持たなかった場合の値を返す関数</param>
        /// <returns>自身が値を持つ場合は自身、値を持たない場合はelsePartの結果</returns>
        public Result<TSuccess, TFailure> OrElse(Func<Result<TSuccess, TFailure>> elsePart)
        {
            return this.IsSuccess ? this : elsePart();
        }

        /// <summary>
        /// 自身とthenPartの結果の両方が値を持つ場合はthenPartの結果を、
        /// そうでない場合はFailure(自身がFailureの場合は自身、そうでない場合はthenPartの結果のFailure)を返します。
        /// Resultは短絡のand演算子を提供しているため、そちらを使用したほうが効率的です。
        /// </summary>
        /// <param name="thenPart">自身が値を持つ場合の値を返す関数</param>
        /// <returns>
        /// 自身とthenPartの結果の両方が値を持つ場合はthenPartの結果、
        /// どちらか一方でも値を持たなかった場合はFailure
        /// (自身がFailureの場合は自身、そうでない場合はthenPartの結果のFailure)
        /// </returns>
        public Result<U, TFailure> AndThen<U>(Func<Result<U, TFailure>> thenPart)
        {
            return this.IsFailure ? (Result<U, TFailure>)Result.Failure(this.FailureValue) : thenPart();
        }

        /// <summary>
        /// 左辺のResultがSuccessの場合は左辺を、そうでない場合は右辺を返します。
        /// 通常、直接使用せず、短絡演算子として使用します。
        /// </summary>
        /// <param name="a">1つ目のResult</param>
        /// <param name="b">2つ目のResult</param>
        /// <returns>左辺のResultがSuccessの場合は左辺、それ以外の場合は右辺</returns>
        public static Result<TSuccess, TFailure> operator |(Result<TSuccess, TFailure> a, Result<TSuccess, TFailure> b)
        {
            return a.IsSuccess ? a : b;
        }

        /// <summary>
        /// 両辺のResultがSuccessの場合右辺を、そうでない場合はFailure(左辺がFailureの場合は左辺、そうでない場合はthenPartの結果のFailure)を返します。
        /// 通常、直接使用せず、短絡演算子として使用します。
        /// </summary>
        /// <param name="a">1つ目のResult</param>
        /// <param name="b">2つ目のResult</param>
        /// <returns>
        /// 両辺のResultがSuccessの場合は右辺を、
        /// 一方でも値を持たない場合はFailure
        /// (左辺がFailureの場合は左辺、そうでない場合はthenPartの結果のFailure)
        /// </returns>
        public static Result<TSuccess, TFailure> operator &(Result<TSuccess, TFailure> a, Result<TSuccess, TFailure> b)
        {
            return a.IsFailure ? a : b;
        }

        /// <summary>
        /// オブジェクトのハッシュコードを取得します。
        /// </summary>
        /// <returns>ハッシュコード</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            var result = 31;
            result ^= success.GetHashCode();
            result ^= failure.GetHashCode();
            return result;
        }

        /// <summary>
        /// このオブジェクトを文字列表現に変換します。
        /// </summary>
        /// <returns>このオブジェクトの文字列表現</returns>
        public override string ToString()
        {
            return this.IsSuccess ? string.Format("Success({0})", this.success.Value) : string.Format("Failure({0})", this.failure.Value);
        }
    }
}
