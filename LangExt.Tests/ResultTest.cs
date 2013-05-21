using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LangExt;
using LangExt.Unsafe;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace LangExt.Tests
{
    [TestFixture]
    public class ResultTest
    {
        static Result<T, Unit> SuccessIf<T>(bool isSuccess, T successValue)
        {
            return isSuccess ? Result.NewSuccess<T, Unit>(successValue) : Result.NewFailure<T, Unit>(Unit._);
        }

        static Result<Unit, T> FailureIf<T>(bool isFailure, T failureValue)
        {
            return isFailure ? Result.NewFailure<Unit, T>(failureValue) : Result.NewSuccess<Unit, T>(Unit._);
        }

        public class Instantiation
        {
            void TestResultIsSuccess<T, _>(Func<Result<T, _>> testTarget, bool expectedIsSuccess, Func<T> expectedSuccessValue)
            {
                var res = testTarget();
                Assert.That(res.IsSuccess, Is.EqualTo(expectedIsSuccess));
                if (expectedIsSuccess)
                    Assert.That(res.GetSuccessValue(), Is.EqualTo(expectedSuccessValue()));
            }

            void TestResultIsFailure<_, T>(Func<Result<_, T>> testTarget, bool expectedIsFailure, Func<T> expectedFailureValue)
            {
                var res = testTarget();
                Assert.That(res.IsFailure, Is.EqualTo(expectedIsFailure));
                if (expectedIsFailure)
                    Assert.That(res.GetFailureValue(), Is.EqualTo(expectedFailureValue()));
            }

            void TestSuccess<T, _>(Func<Result<T, _>> testTarget, T expectedSuccessValue)
            {
                TestResultIsSuccess(testTarget, true, () => expectedSuccessValue);
            }
            
            void TestExn<T, _>(Func<Result<T, _>> testTarget, IResolveConstraint expr) { Assert.That(() => testTarget(), expr); }

            [TestCase("", true)]
            [TestCase("not empty", true)]
            [TestCase(null, false)]
            public void CreateStringRes(string value, bool expectedIsSuccess)
            {
                TestResultIsSuccess(() => Create.Result(value), expectedIsSuccess, () => value);
            }

            [TestCase("", true)]
            [TestCase("not empty", true)]
            [TestCase(null, false)]
            public void ResultCreateStr(string value, bool expectedIsSuccess)
            {
                TestResultIsSuccess(() => Result.Create(value), expectedIsSuccess, () => value);
            }

            [TestCase(-1, true)]
            [TestCase(0, true)]
            [TestCase(1, true)]
            [TestCase(null, false)]
            public void CreateIntRes(int? value, bool expectedIsSuccess)
            {
                TestResultIsSuccess(() => Create.Result(value), expectedIsSuccess, () => value.Value);
            }

            [TestCase(-1, true)]
            [TestCase(0, true)]
            [TestCase(1, true)]
            [TestCase(null, false)]
            public void ResultCreateInt(int? value, bool expectedIsSuccess)
            {
                TestResultIsSuccess(() => Result.Create(value), expectedIsSuccess, () => value.Value);
            }

            [TestCase(null)]
            [TestCase("")]
            [TestCase("not null")]
            public void Success(string value)
            {
                if (value != null)
                    TestResultIsSuccess(() => Result.Success(value), true, () => value);
                else
                    TestExn(() => Result.Success(value), Throws.Exception.TypeOf<ArgumentNullException>().And.Message.Contains("value"));
            }

            [TestCase(null)]
            [TestCase("")]
            [TestCase("not null")]
            public void Failure(string value)
            {
                if (value != null)
                    TestResultIsFailure(() => Result.Failure(value), true, () => value);
                else
                    TestExn(() => Result.Failure(value), Throws.Exception.TypeOf<ArgumentNullException>().And.Message.Contains("value"));
            }

            [TestCase("", null, true)]
            [TestCase("", "", false)]
            [TestCase("", "not empty", true)]
            [TestCase(null, null, false)]
            [TestCase(null, "", false, ExpectedException=typeof(ArgumentNullException))]
            [TestCase(null, "not empty", false, ExpectedException=typeof(ArgumentNullException))]
            public void FailureIf_T(string str, string x, bool expectedIsSuccess)
            {
                TestResultIsSuccess(() => str.FailureIf(x), expectedIsSuccess, () => str);
            }

            public enum FuncResult { True, False, Exception }
            static Func<bool> FuncResultToFunc(FuncResult fr)
            {
                if (fr == FuncResult.Exception)
                    return () => { throw new Exception(); };
                return () => fr == FuncResult.True;
            }

            [TestCase("", FuncResult.True, false)]
            [TestCase("", FuncResult.False, true)]
            [TestCase("", FuncResult.Exception, null)]
            [TestCase(null, FuncResult.True, false)]
            [TestCase(null, FuncResult.False, true, ExpectedException=typeof(ArgumentNullException))]
            [TestCase(null, FuncResult.Exception, null)]
            public void FailureIf_Func(string str, FuncResult res, bool? expectedIsSuccess)
            {
                var predF = FuncResultToFunc(res);
                if (res != FuncResult.Exception)
                {
                    TestResultIsSuccess(() => str.FailureIf(predF), expectedIsSuccess.Value, () => str);
                    TestResultIsSuccess(
                        () => str.FailureIf(s => { Assert.That(s, Is.EqualTo(str)); return predF(); }),
                        expectedIsSuccess.Value,
                        () => str);
                }
                else
                {
                    TestExn(() => str.FailureIf(predF), Throws.Exception);
                }
            }

            [TestCase("", true)]
            [TestCase(default(string), false)]
            public void FailureIfNullStr(string value, bool expectedIsSuccess)
            {
                TestResultIsSuccess(() => value.FailureIfNull(), expectedIsSuccess, () => value);
            }

            // 値型なので常にSuccessを返す
            [TestCase(42, true)]
            [TestCase(default(int), true)]
            public void FailureIfNullInt(int value, bool expectedIsSuccess)
            {
                TestResultIsSuccess(() => value.FailureIfNull(), expectedIsSuccess, () => value);
            }

            [TestCase("hoge", true, false)]
            [TestCase(null, true, false)]
            [TestCase("hoge", false, true)]
            [TestCase(null, false, false)]
            public void FromFunc(string value, bool thrownExn, bool expectedIsSuccess)
            {
                var f = new Func<string>(() => { if (thrownExn) throw new Exception(); else return value; });
                if (expectedIsSuccess)
                    Assert.That(Result.FromFunc(f), Is.EqualTo(Result.NewSuccess<string, Exception>(value)));
                else if (!thrownExn && value.IsNull())
                    Assert.That(Result.FromFunc(f).GetFailureValue(), Is.TypeOf<NullResultException>());
                else
                    Assert.That(Result.FromFunc(f).GetFailureValue(), Is.TypeOf<Exception>());
            }
        }

        public class Success
        {
            [TestCase("")]
            [TestCase("hoge")]
            public void IsSuccessMethod_eq_IsSuccessProperty(string value)
            {
                var sut = Result.Success(value);
                Assert.That(Result.IsSuccess(sut), Is.EqualTo(sut.IsSuccess));
            }

            [TestCase("")]
            [TestCase("hoge")]
            public void IsFailureMethod_eq_IsFailureProperty(string value)
            {
                var sut = Result.Success(value);
                Assert.That(Result.IsFailure(sut), Is.EqualTo(sut.IsFailure));
            }

            [TestCase("", null)]
            [TestCase("", "")]
            [TestCase("", "hoge")]
            [TestCase("hoge", null)]
            [TestCase("hoge", "")]
            [TestCase("hoge", "hoge")]
            [TestCase("piyo", "hoge")]
            public void GetOr(string value, string defaultValue)
            {
                Assert.That(Result.Success(value).GetOr(defaultValue), Is.EqualTo(value));
            }

            [TestCase("", null)]
            [TestCase("", "")]
            [TestCase("", "hoge")]
            [TestCase("hoge", null)]
            [TestCase("hoge", "")]
            [TestCase("hoge", "hoge")]
            [TestCase("piyo", "hoge")]
            public void GetFailureOr(string value, string defaultValue)
            {
                Assert.That(Result.NewSuccess<string, string>(value).GetFailureOr(defaultValue), Is.EqualTo(defaultValue));
            }

            T ThrowIf<T>(bool exn, T value)
            {
                if (exn)
                    throw new Exception("oops!");
                return value;
            }

            [TestCase("", null, true)]
            [TestCase("", null, false)]
            [TestCase("", "", false)]
            [TestCase("", "hoge", false)]
            [TestCase("hoge", null, false)]
            [TestCase("hoge", "", false)]
            [TestCase("hoge", "hoge", false)]
            [TestCase("piyo", "hoge", false)]
            public void GetOrElse(string value, string defaultValue, bool thrownExn)
            {
                Assert.That(Result.Success(value).GetOrElse(() => ThrowIf(thrownExn, defaultValue)), Is.EqualTo(value));
            }

            [TestCase("", null, true)]
            [TestCase("", null, false)]
            [TestCase("", "", false)]
            [TestCase("", "hoge", false)]
            [TestCase("hoge", null, false)]
            [TestCase("hoge", "", false)]
            [TestCase("hoge", "hoge", false)]
            [TestCase("piyo", "hoge", false)]
            public void GetFailureOrElse(string value, string defaultValue, bool thrownExn)
            {
                Assert.That(() =>
                    Result.NewSuccess<string, string>(value).GetFailureOrElse(() => ThrowIf(thrownExn, defaultValue)),
                    thrownExn ? Throws.Exception as IResolveConstraint : Is.EqualTo(defaultValue));
            }

            [TestCase(10, "hoge")]
            [TestCase(10, 20)]
            [TestCase("piyo", "hoge")]
            [TestCase("piyo", 20)]
            public void MatchFunc<T, U>(T value, U expected)
            {
                Assert.That(Result.Success(value).Match(
                    Success: v => {
                        Assert.That(v, Is.EqualTo(value)); // valueがvとして渡されてくる
                        return expected;
                    },
                    Failure: v => {
                        throw new Exception("oops!");
                    }), Is.EqualTo(expected)); // Matchの中で返した値が全体の戻り値になる
            }

            [TestCase(10)]
            [TestCase(20)]
            [TestCase("hoge")]
            public void MatchAction<T>(T value)
            {
                Result.Success(value).Match(
                    Success: v => { Assert.That(v, Is.EqualTo(value)); }, // valueがvとして渡されてくる
                    Failure: v => { throw new Exception("oops!"); });
            }

            [TestCase(10)]
            [TestCase(20)]
            [TestCase("hoge")]
            public void MatchFuncUnit<T>(T value)
            {
                Result.Success(value).Match(
                    Success: v => { Assert.That(v, Is.EqualTo(value)); return Unit._; }, // valueがvとして渡されてくる
                    Failure: v => { throw new Exception("oops!"); });
            }

            [TestCase(10, true, "hoge")]
            [TestCase(10, true, 20)]
            [TestCase("piyo", true, "hoge")]
            [TestCase("piyo", true, 20)]
            [TestCase(10, false, "")]
            [TestCase("piyo", false, "")]
            public void Bind<T, U>(T value, bool expectedIsSuccess, U expected)
            {
                Assert.That(Result.NewSuccess<T, Unit>(value).Bind(v =>
                {
                    Assert.That(v, Is.EqualTo(value)); // valueがvとして渡されてくる
                    return SuccessIf(expectedIsSuccess, expected);
                }), Is.EqualTo(SuccessIf(expectedIsSuccess, expected))); // Bindの中で返したものがそのまま返される
            }

            [TestCase(10)]
            [TestCase("piyo")]
            public void BindFailure<T>(T value)
            {
                Assert.That(
                    Result.Success(value).BindFailure<int>(v => { throw new Exception("oops!"); }),
                    Is.EqualTo(Result.NewSuccess<T, int>(value)));
            }

            [Test]
            public void OperatorTrueFalse()
            {
                // 短絡演算子を提供するために、一応できるようにしているが、明示的にIsSuccess/IsFailureプロパティを使うべき
                if (Result.Success(42)) Assert.Pass();
                else Assert.Fail();
            }

            [TestCase("hoge")]
            [TestCase(10)]
            public void OrElse<T>(T value)
            {
                var sut = Result.Success(value);
                Assert.That(sut.OrElse(() => { throw new Exception(); }), Is.EqualTo(Result.Success(value)));
            }

            [TestCase("hoge", "piyo")]
            [TestCase("hoge", 10)]
            [TestCase(10, 20)]
            [TestCase(10, "hoge")]
            public void AndThen<T, U>(T value, U otherValue)
            {
                var sut = Result.NewSuccess<T, Unit>(value);
                var success = Result.NewSuccess<U, Unit>(otherValue);
                var failure = Result.NewFailure<U, Unit>(Unit._);
                Assert.That(sut.AndThen(() => success), Is.EqualTo(success));
                Assert.That(sut.AndThen(() => failure), Is.EqualTo(failure));
            }

            [TestCase("hoge")]
            [TestCase(10)]
            public void OperatorOrOr<T>(T value)
            {
                var sut = Result.NewSuccess<T, Unit>(value);
                Assert.That(sut || new Func<Result<T, Unit>>(() => { throw new Exception(); })(), Is.EqualTo(Result.NewSuccess<T, Unit>(value)));
            }

            [TestCase("hoge", true, "piyo")]
            [TestCase(10, true, 20)]
            [TestCase("hoge", false, "piyo")]
            [TestCase(10, false, 20)]
            public void OperatorAndAnd<T>(T value, bool otherIsSuccess, T otherValue)
            {
                var sut = Result.NewSuccess<T, Unit>(value);
                var other = SuccessIf(otherIsSuccess, otherValue);
                Assert.That(sut && SuccessIf(otherIsSuccess, otherValue), Is.EqualTo(other));
            }

            [TestCase("hoge", "Success(hoge)")]
            [TestCase(42, "Success(42)")]
            public void ToString<T>(T value, string expected)
            {
                Assert.That(Result.Success(value).ToString(), Is.EqualTo(expected));
            }

            [TestCase("hoge", 0, 42)]
            [TestCase(42, "", "hoge")]
            public void Fold<T, U>(T value, U init, U expected)
            {
                var sut = Result.Success(value);
                Assert.That(sut.Fold(init, (acc, v) =>
                {
                    Assert.That(acc, Is.EqualTo(init));
                    Assert.That(v, Is.EqualTo(value));
                    return expected;
                }), Is.EqualTo(expected));
            }

            [TestCase("hoge", 0)]
            [TestCase(42, "")]
            public void FoldFailure<T, U>(T value, U init)
            {
                var sut = Result.Success(value);
                Assert.That(sut.FoldFailure(init, (acc, v) =>
                {
                    throw new Exception("oops!");
                }), Is.EqualTo(init));
            }

            [TestCase("hoge", "piyo")]
            [TestCase("hoge", 42)]
            [TestCase(42, "hoge")]
            [TestCase(42, 10)]
            public void Map<T, U>(T value, U map)
            {
                var sut = Result.Success(value);
                Assert.That(sut.Map(v =>
                {
                    Assert.That(v, Is.EqualTo(value));
                    return map;
                }), Is.EqualTo(Result.Success(map)));
            }

            [TestCase("hoge")]
            [TestCase(42)]
            public void MapFailure<T>(T value)
            {
                var sut = Result.NewSuccess<T, Unit>(value);
                Assert.That(sut.MapFailure<T, Unit, Unit>(v =>
                {
                    throw new Exception("oops!");
                }), Is.EqualTo(sut));
            }

            [TestCase(10)]
            [TestCase("hoge")]
            public void Iter<T>(T value)
            {
                var sut = Result.Success(value);
                sut.Iter(v => { Assert.That(v, Is.EqualTo(value)); });
            }

            [TestCase(10)]
            [TestCase("hoge")]
            public void Iter2<T>(T value)
            {
                var sut = Result.Success(value);
                Assert.That(sut.Iter(v => { Assert.That(v, Is.EqualTo(value)); return Unit._; }), Is.EqualTo(Unit._));
            }

            [TestCase(10)]
            [TestCase("hoge")]
            public void IterFailure<T>(T value)
            {
                var sut = Result.Success(value);
                sut.IterFailure(v => { throw new Exception("oops!"); });
            }

            [TestCase(10)]
            [TestCase("hoge")]
            public void IterFailure2<T>(T value)
            {
                var sut = Result.Success(value);
                Assert.That(sut.IterFailure(v => { throw new Exception("oops!"); }), Is.EqualTo(Unit._));
            }

            // ResultにIsEmpty/IsNotEmptyを用意するとなると、
            // Result<T, Unit>に対して？
            // とりあえず、必要性はあまり感じないので提供しない。

            [TestCase(10)]
            [TestCase(11)]
            [TestCase(42)]
            [TestCase(43)]
            public void Exists(int value)
            {
                var sut = Result.Success(value);
                Assert.That(sut.Exists(v =>
                {
                    Assert.That(v, Is.EqualTo(value));
                    return value % 2 == 0;
                }), Is.EqualTo(value % 2 == 0));
            }

            [TestCase(10)]
            [TestCase(11)]
            [TestCase(42)]
            [TestCase(43)]
            public void ExistsFailure(int value)
            {
                var sut = Result.Success(value);
                Assert.That(sut.ExistsFailure(v =>
                {
                    Assert.That(v, Is.EqualTo(value));
                    return value % 2 == 0;
                }), Is.False);
            }

            [TestCase(10)]
            [TestCase(11)]
            [TestCase(42)]
            [TestCase(43)]
            public void Forall(int value)
            {
                var sut = Result.Success(value);
                Assert.That(sut.Forall(v =>
                {
                    Assert.That(v, Is.EqualTo(value));
                    return value % 2 == 0;
                }), Is.EqualTo(value % 2 == 0));
            }

            [TestCase(10)]
            [TestCase(11)]
            [TestCase(42)]
            [TestCase(43)]
            public void ForallFailure(int value)
            {
                var sut = Result.Success(value);
                Assert.That(sut.ForallFailure(v =>
                {
                    Assert.That(v, Is.EqualTo(value));
                    return value % 2 == 0;
                }), Is.True);
            }

            [Test]
            public void Len()
            {
                Assert.That(Result.Success(10).Len(), Is.EqualTo(1));
            }

            [Test]
            public void LenFailure()
            {
                Assert.That(Result.Success(10).LenFailure(), Is.EqualTo(0));
            }

            [TestCase(true, 1)]
            [TestCase(false, 0)]
            public void Count(bool b, int expected)
            {
                Assert.That(Result.Success(10).Count(_ => b), Is.EqualTo(expected));
            }

            [TestCase(true)]
            [TestCase(false)]
            public void CountFailure(bool b)
            {
                Assert.That(Result.Success(10).CountFailure(_ => b), Is.EqualTo(0));
            }

            [Test]
            public void ToArray()
            {
                Assert.That(Result.Success(10).ToArray(), Is.EqualTo(new[] { 10 }));
            }

            [Test]
            public void ToArrayFailure()
            {
                Assert.That(Result.NewSuccess<int, Unit>(10).ToArrayFailure(), Is.EqualTo(new Unit[0]));
            }

            [Test]
            public void ToSeq()
            {
                Assert.That(Result.Success(10).ToSeq(), Is.EqualTo(new[] { 10 }));
            }

            [Test]
            public void ToSeqFailure()
            {
                Assert.That(Result.NewSuccess<int, Unit>(10).ToSeqFailure(), Is.EqualTo(new Unit[0]));
            }

            [Test]
            public void ToOption()
            {
                Assert.That(Result.Success(10).ToOption(), Is.EqualTo(Option.Some(10)));
            }

            [Test]
            public void ToOptionFailure()
            {
                Assert.That(Result.Success(10).ToOptionFailure(), Is.EqualTo(Option.None));
            }

            [Test]
            public void SwapResult()
            {
                var sut = Result.NewSuccess<int, string>(42);
                Assert.That(sut.SwapResult(), Is.EqualTo(Result.NewFailure<string, int>(42)));
            }

            [Test]
            public void Cast()
            {
                var sut = Result.Success(42);
                Assert.That(() => sut.Cast<string>(), Throws.Exception);
            }

            [Test]
            public void SafeCast()
            {
                var sut = Result.Success(42);
                Assert.That(sut.SafeCast<string>(i => i.ToString()), Is.EqualTo(Result.Success("42")));
            }

            [Test]
            public void CastFailure()
            {
                var sut = Result.Success(42);
                Assert.That(sut.CastFailure<string>(), Is.EqualTo(Result.NewSuccess<int, string>(42)));
            }

            [Test]
            public void SafeCastFailure()
            {
                var sut = Result.Success(42);
                Assert.That(sut.SafeCastFailure<string>(_ => ""), Is.EqualTo(Result.NewSuccess<int, string>(42)));
            }
        }

        public class Failure
        {
            [TestCase("")]
            [TestCase("hoge")]
            public void IsSuccessMethod_eq_IsSuccessProperty(string value)
            {
                var sut = Result.Failure(value);
                Assert.That(Result.IsSuccess(sut), Is.EqualTo(sut.IsSuccess));
            }

            [TestCase("")]
            [TestCase("hoge")]
            public void IsFailureMethod_eq_IsFailureProperty(string value)
            {
                var sut = Result.Failure(value);
                Assert.That(Result.IsFailure(sut), Is.EqualTo(sut.IsFailure));
            }

            [TestCase("", null)]
            [TestCase("", "")]
            [TestCase("", "hoge")]
            [TestCase("hoge", null)]
            [TestCase("hoge", "")]
            [TestCase("hoge", "hoge")]
            [TestCase("piyo", "hoge")]
            public void GetOr(string value, string defaultValue)
            {
                Assert.That(Result.NewFailure<string, string>(value).GetOr(defaultValue), Is.EqualTo(defaultValue));
            }

            [TestCase("", null)]
            [TestCase("", "")]
            [TestCase("", "hoge")]
            [TestCase("hoge", null)]
            [TestCase("hoge", "")]
            [TestCase("hoge", "hoge")]
            [TestCase("piyo", "hoge")]
            public void GetFailureOr(string value, string defaultValue)
            {
                Assert.That(Result.Failure(value).GetFailureOr(defaultValue), Is.EqualTo(value));
            }

            T ThrowIf<T>(bool exn, T value)
            {
                if (exn)
                    throw new Exception("oops!");
                return value;
            }

            [TestCase("", null, true)]
            [TestCase("", null, false)]
            [TestCase("", "", false)]
            [TestCase("", "hoge", false)]
            [TestCase("hoge", null, false)]
            [TestCase("hoge", "", false)]
            [TestCase("hoge", "hoge", false)]
            [TestCase("piyo", "hoge", false)]
            public void GetOrElse(string value, string defaultValue, bool thrownExn)
            {
                Assert.That(() =>
                    Result.NewFailure<string, string>(value).GetOrElse(() => ThrowIf(thrownExn, defaultValue)),
                    thrownExn ? Throws.Exception as IResolveConstraint : Is.EqualTo(defaultValue));
            }

            [TestCase("", null, true)]
            [TestCase("", null, false)]
            [TestCase("", "", false)]
            [TestCase("", "hoge", false)]
            [TestCase("hoge", null, false)]
            [TestCase("hoge", "", false)]
            [TestCase("hoge", "hoge", false)]
            [TestCase("piyo", "hoge", false)]
            public void GetFailureOrElse(string value, string defaultValue, bool thrownExn)
            {
                Assert.That(Result.Failure(value).GetFailureOrElse(() => ThrowIf(thrownExn, defaultValue)), Is.EqualTo(value));
            }

            [TestCase(10, "hoge")]
            [TestCase(10, 20)]
            [TestCase("piyo", "hoge")]
            [TestCase("piyo", 20)]
            public void MatchFunc<T, U>(T value, U expected)
            {
                Assert.That(Result.Failure(value).Match(
                    Success: v => {
                        throw new Exception("oops!");
                    },
                    Failure: v => {
                        Assert.That(v, Is.EqualTo(value)); // valueがvとして渡されてくる
                        return expected;
                    }), Is.EqualTo(expected)); // Matchの中で返した値が全体の戻り値になる
            }

            [TestCase(10)]
            [TestCase(20)]
            [TestCase("hoge")]
            public void MatchAction<T>(T value)
            {
                Result.Failure(value).Match(
                    Failure: v => { Assert.That(v, Is.EqualTo(value)); }, // valueがvとして渡されてくる
                    Success: v => { throw new Exception("oops!"); });
            }

            [TestCase(10)]
            [TestCase(20)]
            [TestCase("hoge")]
            public void MatchFuncUnit<T>(T value)
            {
                Result.Failure(value).Match(
                    Failure: v => { Assert.That(v, Is.EqualTo(value)); return Unit._; }, // valueがvとして渡されてくる
                    Success: v => { throw new Exception("oops!"); });
            }

            [TestCase(10)]
            [TestCase(10)]
            [TestCase("piyo")]
            [TestCase("piyo")]
            [TestCase(10)]
            [TestCase("piyo")]
            public void Bind<T>(T value)
            {
                Assert.That(
                    Result.Failure(value).Bind<int>(v => { throw new Exception("oops!"); }),
                    Is.EqualTo(Result.NewFailure<int, T>(value)));
            }

            [TestCase(10, true, "hoge")]
            [TestCase(10, true, 20)]
            [TestCase("piyo", true, "hoge")]
            [TestCase("piyo", true, 20)]
            [TestCase(10, false, "")]
            [TestCase("piyo", false, "")]
            public void BindFailure<T, U>(T value, bool expectedIsFailure, U expected)
            {
                Assert.That(Result.NewFailure<Unit, T>(value).BindFailure(v =>
                {
                    Assert.That(v, Is.EqualTo(value)); // valueがvとして渡されてくる
                    return FailureIf(expectedIsFailure, expected);
                }), Is.EqualTo(FailureIf(expectedIsFailure, expected))); // BindFailureの中で返したものがそのまま返される
            }

            [Test]
            public void OperatorTrueFalse()
            {
                // 短絡演算子を提供するために、一応できるようにしているが、明示的にIsSuccess/IsFailureプロパティを使うべき
                if (Result.Failure(42)) Assert.Fail();
                else Assert.Pass();
            }

            [TestCase("hoge")]
            [TestCase(10)]
            public void OrElse<T>(T value)
            {
                var sut = Result.NewFailure<T, T>(value);
                Assert.That(sut.OrElse(() => Result.NewSuccess<T, T>(value)), Is.EqualTo(Result.NewSuccess<T, T>(value)));
                Assert.That(sut.OrElse(() => Result.NewFailure<T, T>(value)), Is.EqualTo(Result.NewFailure<T, T>(value)));
            }

            [TestCase("hoge")]
            [TestCase(10)]
            public void AndThen<T>(T value)
            {
                var sut = Result.NewFailure<int, T>(value);
                Assert.That(sut.AndThen<int>(() => { throw new Exception("oops!"); }), Is.EqualTo(sut));
            }

            [TestCase("hoge")]
            [TestCase(10)]
            public void OperatorOrOr<T>(T value)
            {
                var sut = Result.Failure(Unit._);
                Assert.That(sut || new Func<Result<T, Unit>>(() => Result.Success(value))(), Is.EqualTo(Result.NewSuccess<T, Unit>(value)));
            }

            [TestCase("hoge", true, "piyo")]
            [TestCase(10, true, 20)]
            [TestCase("hoge", false, "piyo")]
            [TestCase(10, false, 20)]
            public void OperatorAndAnd<T>(T value, bool otherIsSuccess, T otherValue)
            {
                var sut = Result.NewFailure<T, Unit>(Unit._);
                var other = SuccessIf(otherIsSuccess, otherValue);
                Assert.That(sut && SuccessIf(otherIsSuccess, otherValue), Is.EqualTo(sut));
            }

            [TestCase("hoge", "Failure(hoge)")]
            [TestCase(42, "Failure(42)")]
            public void ToString<T>(T value, string expected)
            {
                Assert.That(Result.Failure(value).ToString(), Is.EqualTo(expected));
            }

            [TestCase("hoge", 0)]
            [TestCase(42, "")]
            public void Fold<T, U>(T value, U init)
            {
                var sut = Result.Failure(value);
                Assert.That(sut.Fold(init, (acc, v) =>
                {
                    throw new Exception("oops!");
                }), Is.EqualTo(init));
            }

            [TestCase("hoge", 0, 42)]
            [TestCase(42, "", "hoge")]
            public void FoldFailure<T, U>(T value, U init, U expected)
            {
                var sut = Result.Failure(value);
                Assert.That(sut.FoldFailure(init, (acc, v) =>
                {
                    Assert.That(acc, Is.EqualTo(init));
                    Assert.That(v, Is.EqualTo(value));
                    return expected;
                }), Is.EqualTo(expected));
            }

            [TestCase("hoge")]
            [TestCase(42)]
            public void Map<T>(T value)
            {
                var sut = Result.NewFailure<Unit, T>(value);
                Assert.That(sut.Map<Unit, T, Unit>(v =>
                {
                    throw new Exception("oops!");
                }), Is.EqualTo(sut));
            }

            [TestCase("hoge", "piyo")]
            [TestCase("hoge", 42)]
            [TestCase(42, "hoge")]
            [TestCase(42, 10)]
            public void MapFailure<T, U>(T value, U map)
            {
                var sut = Result.Failure(value);
                Assert.That(sut.MapFailure(v =>
                {
                    Assert.That(v, Is.EqualTo(value));
                    return map;
                }), Is.EqualTo(Result.Failure(map)));
            }

            [TestCase(10)]
            [TestCase("hoge")]
            public void Iter<T>(T value)
            {
                var sut = Result.Failure(value);
                sut.Iter(v => { throw new Exception("oops!"); });
            }

            [TestCase(10)]
            [TestCase("hoge")]
            public void Iter2<T>(T value)
            {
                var sut = Result.Failure(value);
                Assert.That(sut.Iter(v => { throw new Exception("oops!"); }), Is.EqualTo(Unit._));
            }

            [TestCase(10)]
            [TestCase("hoge")]
            public void IterFailure<T>(T value)
            {
                var sut = Result.Failure(value);
                sut.IterFailure(v => { Assert.That(v, Is.EqualTo(value)); });
            }

            [TestCase(10)]
            [TestCase("hoge")]
            public void IterFailure2<T>(T value)
            {
                var sut = Result.Failure(value);
                Assert.That(sut.IterFailure(v => { Assert.That(v, Is.EqualTo(value)); return Unit._; }), Is.EqualTo(Unit._));
            }

            // ResultにIsEmpty/IsNotEmptyを用意するとなると、
            // Result<T, Unit>に対して？
            // とりあえず、必要性はあまり感じないので提供しない。

            [TestCase(10)]
            [TestCase(11)]
            [TestCase(42)]
            [TestCase(43)]
            public void Exists(int value)
            {
                var sut = Result.Failure(value);
                Assert.That(sut.Exists(v =>
                {
                    Assert.That(v, Is.EqualTo(value));
                    return value % 2 == 0;
                }), Is.False);
            }

            [TestCase(10)]
            [TestCase(11)]
            [TestCase(42)]
            [TestCase(43)]
            public void ExistsFailure(int value)
            {
                var sut = Result.Failure(value);
                Assert.That(sut.ExistsFailure(v =>
                {
                    Assert.That(v, Is.EqualTo(value));
                    return value % 2 == 0;
                }), Is.EqualTo(value % 2 == 0));
            }

            [TestCase(10)]
            [TestCase(11)]
            [TestCase(42)]
            [TestCase(43)]
            public void Forall(int value)
            {
                var sut = Result.Failure(value);
                Assert.That(sut.Forall(v =>
                {
                    Assert.That(v, Is.EqualTo(value));
                    return value % 2 == 0;
                }), Is.True);
            }

            [TestCase(10)]
            [TestCase(11)]
            [TestCase(42)]
            [TestCase(43)]
            public void ForallFailure(int value)
            {
                var sut = Result.Failure(value);
                Assert.That(sut.ForallFailure(v =>
                {
                    Assert.That(v, Is.EqualTo(value));
                    return value % 2 == 0;
                }), Is.EqualTo(value % 2 == 0));
            }

            [Test]
            public void Len()
            {
                Assert.That(Result.Failure(10).Len(), Is.EqualTo(0));
            }

            [Test]
            public void LenFailure()
            {
                Assert.That(Result.Failure(10).LenFailure(), Is.EqualTo(1));
            }

            [TestCase(true)]
            [TestCase(false)]
            public void Count(bool b)
            {
                Assert.That(Result.Failure(10).Count(_ => b), Is.EqualTo(0));
            }

            [TestCase(true, 1)]
            [TestCase(false, 0)]
            public void CountFailure(bool b, int expected)
            {
                Assert.That(Result.Failure(10).CountFailure(_ => b), Is.EqualTo(expected));
            }

            [Test]
            public void ToArray()
            {
                Assert.That(Result.NewFailure<Unit, int>(10).ToArray(), Is.EqualTo(new Unit[0]));
            }

            [Test]
            public void ToArrayFailure()
            {
                Assert.That(Result.Failure(10).ToArrayFailure(), Is.EqualTo(new[] { 10 }));
            }

            [Test]
            public void ToSeq()
            {
                Assert.That(Result.NewFailure<Unit, int>(10).ToSeq(), Is.EqualTo(new Unit[0]));
            }

            [Test]
            public void ToSeqFailure()
            {
                Assert.That(Result.Failure(10).ToSeqFailure(), Is.EqualTo(new[] { 10 }));
            }

            [Test]
            public void ToOption()
            {
                Assert.That(Result.Failure(10).ToOption(), Is.EqualTo(Option.None));
            }

            [Test]
            public void ToOptionFailure()
            {
                Assert.That(Result.Failure(10).ToOptionFailure(), Is.EqualTo(Option.Some(10)));
            }

            [Test]
            public void SwapResult()
            {
                var sut = Result.NewFailure<int, string>("hoge");
                Assert.That(sut.SwapResult(), Is.EqualTo(Result.NewSuccess<string, int>("hoge")));
            }

            [Test]
            public void Cast()
            {
                var sut = Result.Failure(42);
                Assert.That(sut.Cast<string>(), Is.EqualTo(Result.NewFailure<string, int>(42)));
            }

            [Test]
            public void SafeCast()
            {
                var sut = Result.Failure(42);
                Assert.That(sut.SafeCast<string>(_ => "hoge"), Is.EqualTo(Result.NewFailure<string, int>(42)));
            }

            [Test]
            public void CastFailure()
            {
                var sut = Result.Failure(42);
                Assert.That(() => sut.CastFailure<string>(), Throws.Exception);
            }

            [Test]
            public void SafeCastFailure()
            {
                var sut = Result.Failure(42);
                Assert.That(sut.SafeCastFailure<string>(i => i.ToString()), Is.EqualTo(Result.Failure("42")));
            }
        }

        // ==/!=のテストはF#側に定義
        public class Equality
        {
            [TestCase("hoge", true, "", false)]
            [TestCase("hoge", true, "hoge", true)]
            [TestCase("hoge", true, "piyo", false)]
            [TestCase("hoge", false, "piyo", false)]
            [TestCase(42, true, 0, false)]
            [TestCase(42, true, 42, true)]
            [TestCase(42, false, 42, false)]
            public void Equals_Success<T>(T value, bool otherIsSuccess, T other, bool expected)
            {
                Assert.That(Result.NewSuccess<T, Unit>(value).Equals(SuccessIf(otherIsSuccess, other)), Is.EqualTo(expected));
                Assert.That(Result.Success(value).Equals(value), Is.False);
            }

            [TestCase(true, "hoge", true)]
            [TestCase(false, "hoge", false)]
            [TestCase(true, 42, true)]
            [TestCase(false, 42, false)]
            public void Equals_Failure<T>(bool isFailure, T other, bool expected)
            {
                Assert.That(Result.Failure(Unit._).Equals(SuccessIf(!isFailure, other)), Is.False);
            }

            [Test]
            public void EqualsObj_Null()
            {
                object success = Result.Success("hoge");
                Assert.That(success.Equals(null), Is.False);

                object failure = Result.Failure("piyo");
                Assert.That(failure.Equals(null), Is.False);

                object typedSuccess = Result.NewSuccess<string, int>("hoge");
                Assert.That(typedSuccess.Equals(null), Is.False);

                object typedFailure = Result.NewFailure<string, int>(42);
                Assert.That(typedFailure.Equals(null), Is.False);
            }

            [Test]
            public void EqualsObj_DifferentSuccess()
            {
                object successStr = Result.Success("hoge");
                object successInt = Result.Success(42);
                Assert.That(successStr.Equals(successInt), Is.False);
                Assert.That(successInt.Equals(successStr), Is.False);
            }

            [Test]
            public void EqualsObj_DifferentFailure()
            {
                object failureStr = Result.Failure("hoge");
                object failureInt = Result.Failure(42);
                Assert.That(failureStr.Equals(failureInt), Is.False);
                Assert.That(failureInt.Equals(failureStr), Is.False);
            }

            [Test]
            public void EqualsObj_DifferentType()
            {
                // Success側の値が同じでも、Failure側の型が異なれば等しくない
                Assert.That(Result.NewSuccess<int, string>(42).Equals(Result.NewSuccess<int, int>(42)), Is.False);
                // 逆も同じ
                Assert.That(Result.NewFailure<int, string>("hoge").Equals(Result.NewSuccess<string, string>("hoge")), Is.False);
            }
        }
    }
}
