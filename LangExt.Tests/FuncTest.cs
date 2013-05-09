using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LangExt.Tests
{
    public static class ExnExt
    {
        public static Exception AsExn<T>(this T self) where T : Exception { return self; }
    }

    [TestFixture]
    public class FuncTest
    {
        [TestCase(42)]
        [TestCase("hoge")]
        public void Id<T>(T x)
        {
            Assert.That(Func.Id(x), Is.EqualTo(x));
        }

        static readonly Func<int, int, int> Sub = (a, b) => a - b;
        static readonly Func<int, Func<int, int>> SubC = a => b => a - b;
        static readonly Func<Tuple<int, int>, int> SubT = tpl => tpl.Match((a, b) => a - b);

        static readonly Func<int, int, int, int> Sub3 = (a, b, c) => a - b - c;
        static readonly Func<int, Func<int, Func<int, int>>> Sub3C = a => b => c => a - b - c;
        static readonly Func<Tuple<int, int, int>, int> Sub3T = tpl => tpl.Match((a, b, c) => a - b - c);

        [Test]
        public void Flip()
        {
            Assert.That(Func.Flip(Sub)(1, 20), Is.EqualTo(19));
        }

        [Test]
        public void Flip2()
        {
            Assert.That(Func.Flip(SubC)(1)(20), Is.EqualTo(19));
        }

        public class FuncCurry
        {
            void TestCurry2(Func<Func<int, Func<int, int>>> testTarget)
            {
                var curried = testTarget();
                Assert.That(curried(20)(1), Is.EqualTo(19));
            }

            void TestCurry3(Func<Func<int, Func<int, Func<int, int>>>> testTarget)
            {
                var curried = testTarget();
                Assert.That(curried(20)(1)(2), Is.EqualTo(17));
            }

            void TestMultiargs2(Func<Func<int, int, int>> testTaregt)
            {
                var multiargs = testTaregt();
                Assert.That(multiargs(20, 1), Is.EqualTo(19));
            }

            void TestMultiargs3(Func<Func<int, int, int, int>> testTarget)
            {
                var multiargs = testTarget();
                Assert.That(multiargs(20, 1, 2), Is.EqualTo(17));
            }

            void TestTupled2(Func<Func<Tuple<int, int>, int>> testTarget)
            {
                var tupled = testTarget();
                Assert.That(tupled(Tuple.Create(20, 1)), Is.EqualTo(19));
            }

            void TestTupled3(Func<Func<Tuple<int, int, int>, int>> testTarget)
            {
                var tupled = testTarget();
                Assert.That(tupled(Tuple.Create(20, 1, 2)), Is.EqualTo(17));
            }

            #region Curry/Uncurry/Curried/Uncurried

            [Test]
            public void Curry2() { TestCurry2(() => Func.Curry(Sub)); }

            [Test]
            public void Curried2() { TestCurry2(() => Sub.Curried()); }

            [Test]
            public void Curry3() { TestCurry3(() => Func.Curry(Sub3)); }

            [Test]
            public void Curried3() { TestCurry3(() => Sub3.Curried()); }

            [Test]
            public void Uncurry2() { TestMultiargs2(() => Func.Uncurry(Sub.Curried())); }

            [Test]
            public void Uncurried2() { TestMultiargs2(() => Sub.Curried().Uncurried()); }

            [Test]
            public void Uncurry3() { TestMultiargs3(() => Func.Uncurry(Sub3.Curried())); }

            [Test]
            public void Uncurried3() { TestMultiargs3(() => Sub3.Curried().Uncurried()); }
            #endregion

            #region Tuple/Untuple/Tupled/Untupled
            [Test]
            public void Tuple2() { TestTupled2(() => Func.Tuple(Sub)); }

            [Test]
            public void Tupled2() { TestTupled2(() => Sub.Tupled()); }

            [Test]
            public void Tuple3() { TestTupled3(() => Func.Tuple(Sub3)); }

            [Test]
            public void Tupled3() { TestTupled3(() => Sub3.Tupled()); }

            [Test]
            public void Untuple2() { TestMultiargs2(() => Func.Untuple(Sub.Tupled())); }

            [Test]
            public void Untupled2() { TestMultiargs2(() => Sub.Tupled().Untupled()); }

            [Test]
            public void Untuple3() { TestMultiargs3(() => Func.Untuple(Sub3.Tupled())); }

            [Test]
            public void Untupled3() { TestMultiargs3(() => Sub3.Tupled().Untupled()); }
            #endregion

            #region CurryX/UncurryX/UncurriedX/UncurryX
            [Test]
            public void CurryX2() { TestCurry2(() => Func.CurryX(SubT)); }

            [Test]
            public void CurriedX2() { TestCurry2(() => SubT.CurriedX()); }

            [Test]
            public void CurryX3() { TestCurry3(() => Func.CurryX(Sub3T)); }

            [Test]
            public void CurriedX3() { TestCurry3(() => Sub3T.CurriedX()); } 

            [Test]
            public void UncurryX2() { TestTupled2(() => Func.UncurryX(SubT.CurriedX())); }

            [Test]
            public void UncurriedX2() { TestTupled2(() => SubT.CurriedX().UncurriedX()); }

            [Test]
            public void UncurryX3() { TestTupled3(() => Func.UncurryX(Sub3T.CurriedX())); }

            [Test]
            public void UncurriedX3() { TestTupled3(() => Sub3T.CurriedX().UncurriedX()); }
            #endregion
        }

        public class MyException : Exception
        {
            public override bool Equals(object obj) { return obj is MyException; }
        }

        public static readonly Func<int?> ErrorInt0 = () => { throw new MyException(); };
        public static readonly Func<int?> NotErrorInt0 = () => 42;
        public static readonly Func<int, int?> ErrorInt1 = x => ErrorInt0();
        public static readonly Func<int, int?> NotErrorInt1 = x => NotErrorInt0();
        public static readonly Func<int, int, int?> ErrorInt2 = (x, y) => ErrorInt0();
        public static readonly Func<int, int, int?> NotErrorInt2 = (x, y) => NotErrorInt0();

        public static readonly Func<string> ErrorStr0 = () => { throw new MyException(); };
        public static readonly Func<string> NotErrorStr0 = () => "hoge";
        public static readonly Func<int, string> ErrorStr1 = x => ErrorStr0();
        public static readonly Func<int, string> NotErrorStr1 = x => NotErrorStr0();
        public static readonly Func<int, int, string> ErrorStr2 = (x, y) => ErrorStr0();
        public static readonly Func<int, int, string> NotErrorStr2 = (x, y) => NotErrorStr0();

        public static readonly Func<int?> NullInt0 = () => null;
        public static readonly Func<int?> NotNullInt0 = () => 42;
        public static readonly Func<int, int?> NullInt1 = x => NullInt0();
        public static readonly Func<int, int?> NotNullInt1 = x => NotNullInt0();
        public static readonly Func<int, int, int?> NullInt2 = (x, y) => NullInt0();
        public static readonly Func<int, int, int?> NotNullInt2 = (x, y) => NotNullInt0();

        public static readonly Func<string> NullStr0 = () => null;
        public static readonly Func<string> NotNullStr0 = () => "hoge";
        public static readonly Func<int, string> NullStr1 = x => NullStr0();
        public static readonly Func<int, string> NotNullStr1 = x => NotNullStr0();
        public static readonly Func<int, int, string> NullStr2 = (x, y) => NullStr0();
        public static readonly Func<int, int, string> NotNullStr2 = (x, y) => NotNullStr0();

        public class FuncOption
        {
            void Test0<T>(Func<Func<Option<T>>> testTarget, Option<T> expected)
            {
                var f = testTarget();
                Assert.That(f(), Is.EqualTo(expected));
            }

            void Test1<T>(Func<Func<int, Option<T>>> testTarget, Option<T> expected)
            {
                var f = testTarget();
                Assert.That(f(0), Is.EqualTo(expected));
            }

            void Test2<T>(Func<Func<int, int, Option<T>>> testTarget, Option<T> expected)
            {
                var f = testTarget();
                Assert.That(f(0, 1), Is.EqualTo(expected));
            }

            #region ExnToOption
            [Test]
            public void ExnToOption0_Error() { Test0<int?>(ErrorInt0.ExnToOption, Option.None); }

            [Test]
            public void ExnToOption0_NotError() { Test0(NotErrorInt0.ExnToOption, Option.Some<int?>(42)); }

            [Test]
            public void ExnToOption1_Error() { Test1<int?>(ErrorInt1.ExnToOption, Option.None); }

            [Test]
            public void ExnToOption1_NotError() { Test1(NotErrorInt1.ExnToOption, Option.Some<int?>(42)); }

            [Test]
            public void ExnToOption2_Error() { Test2<int?>(ErrorInt2.ExnToOption, Option.None); }

            [Test]
            public void ExnToOption2_NotError() { Test2(NotErrorInt2.ExnToOption, Option.Some<int?>(42)); }
            #endregion

            #region NullToOption
            [Test]
            public void NullToOption0_NullInt() { Test0<int>(NullInt0.NullToOption, Option.None); }

            [Test]
            public void NullToOption0_NotNullInt() { Test0(NotNullInt0.NullToOption, Option.Some(42)); }

            [Test]
            public void NullToOption0_NullStr() { Test0<string>(NullStr0.NullToOption, Option.None); }

            [Test]
            public void NullToOption0_NotNullStr() { Test0(NotNullStr0.NullToOption, Option.Some("hoge")); }

            [Test]
            public void NullToOption1_NullInt() { Test1<int>(NullInt1.NullToOption, Option.None); } 

            [Test]
            public void NullToOption1_NotNullInt() { Test1(NotNullInt1.NullToOption, Option.Some(42)); }

            [Test]
            public void NullToOption1_NullStr() { Test1<string>(NullStr1.NullToOption, Option.None); }

            [Test]
            public void NullToOption1_NotNullStr() { Test1(NotNullStr1.NullToOption, Option.Some("hoge")); }

            [Test]
            public void NullToOption2_NullInt() { Test2<int>(NullInt2.NullToOption, Option.None); }

            [Test]
            public void NullToOption2_NotNullInt() { Test2(NotNullInt2.NullToOption, Option.Some(42)); }

            [Test]
            public void NullToOption2_NullStr() { Test2<string>(NullStr2.NullToOption, Option.None); }

            [Test]
            public void NullToOption2_NotNullStr() { Test2(NotNullStr2.NullToOption, Option.Some("hoge")); }
            #endregion

            #region ToOption
            [Test]
            public void ToOption0_ErrorInt() { Test0<int>(ErrorInt0.ToOption, Option.None); }

            [Test]
            public void ToOption0_NullInt() { Test0<int>(NullInt0.ToOption, Option.None); }

            [Test]
            public void ToOption0_Int() { Test0(NotNullInt0.ToOption, Option.Some(42)); }

            [Test]
            public void ToOption0_ErrorStr() { Test0<string>(ErrorStr0.ToOption, Option.None); }

            [Test]
            public void ToOption0_NullStr() { Test0<string>(NullStr0.ToOption, Option.None); }

            [Test]
            public void ToOption0_Str() { Test0(NotNullStr0.ToOption, Option.Some("hoge")); }

            [Test]
            public void ToOption1_ErrorInt() { Test1<int>(ErrorInt1.ToOption, Option.None); }

            [Test]
            public void ToOption1_NullInt() { Test1<int>(NullInt1.ToOption, Option.None); }

            [Test]
            public void ToOption1_Int() { Test1(NotNullInt1.ToOption, Option.Some(42)); }

            [Test]
            public void ToOption1_ErrorStr() { Test1<string>(ErrorStr1.ToOption, Option.None); }

            [Test]
            public void ToOption1_NullStr() { Test1<string>(NullStr1.ToOption, Option.None); }

            [Test]
            public void ToOption1_Str() { Test1(NotNullStr1.ToOption, Option.Some("hoge")); }

            [Test]
            public void ToOption2_ErrorInt() { Test2<int>(ErrorInt2.ToOption, Option.None); }

            [Test]
            public void ToOption2_NullInt() { Test2<int>(NullInt2.ToOption, Option.None); }

            [Test]
            public void ToOption2_Int() { Test2(NotNullInt2.ToOption, Option.Some(42)); }

            [Test]
            public void ToOption2_ErrorStr() { Test2<string>(ErrorStr2.ToOption, Option.None); }

            [Test]
            public void ToOption2_NullStr() { Test2<string>(NullStr2.ToOption, Option.None); }

            [Test]
            public void ToOption2_Str() { Test2(NotNullStr2.ToOption, Option.Some("hoge")); }
            #endregion
        }

        public class FuncResult
        {
            void Test0<T, U>(Func<Func<Result<T, U>>> testTarget, Result<T, U> expected)
            {
                var f = testTarget();
                Assert.That(f(), Is.EqualTo(expected));
            }

            void Test0<T>(Func<Func<Result<T, Exception>>> testTarget, Result<T, Exception> expected)
            {
                var res = testTarget()();
                if (expected.IsFailure && expected.GetFailureValue().GetType() == typeof(NullResultException))
                    Assert.That(res.GetFailureValue(), Is.TypeOf<NullResultException>());
                else
                    Assert.That(res, Is.EqualTo(expected));
            }

            void Test1<T, U>(Func<Func<int, Result<T, U>>> testTarget, Result<T, U> expected)
            {
                var f = testTarget();
                Assert.That(f(0), Is.EqualTo(expected));
            }

            void Test1<T>(Func<Func<int, Result<T, Exception>>> testTarget, Result<T, Exception> expected)
            {
                var res = testTarget()(0);
                if (expected.IsFailure && expected.GetFailureValue().GetType() == typeof(NullResultException))
                    Assert.That(res.GetFailureValue(), Is.TypeOf<NullResultException>());
                else
                    Assert.That(res, Is.EqualTo(expected));
            }

            void Test2<T, U>(Func<Func<int, int, Result<T, U>>> testTarget, Result<T, U> expected)
            {
                var f = testTarget();
                Assert.That(f(0, 1), Is.EqualTo(expected));
            }

            void Test2<T>(Func<Func<int, int, Result<T, Exception>>> testTarget, Result<T, Exception> expected)
            {
                var res = testTarget()(0, 1);
                if (expected.IsFailure && expected.GetFailureValue().GetType() == typeof(NullResultException))
                    Assert.That(res.GetFailureValue(), Is.TypeOf<NullResultException>());
                else
                    Assert.That(res, Is.EqualTo(expected));
            }

            #region ExnToResult
            [Test]
            public void ExnToResult0_Error() { Test0<int?, Exception>(ErrorInt0.ExnToResult, Result.Failure(new MyException().AsExn())); }

            [Test]
            public void ExnToResult0_NotError() { Test0(NotErrorInt0.ExnToResult, Result.Success<int?>(42).CastFailure<Exception>()); }

            [Test]
            public void ExnToResult1_Error() { Test1<int?, Exception>(ErrorInt1.ExnToResult, Result.Failure(new MyException().AsExn())); }

            [Test]
            public void ExnToResult1_NotError() { Test1(NotErrorInt1.ExnToResult, Result.Success<int?>(42).CastFailure<Exception>()); }

            [Test]
            public void ExnToResult2_Error() { Test2<int?, Exception>(ErrorInt2.ExnToResult, Result.Failure(new MyException().AsExn())); }

            [Test]
            public void ExnToResult2_NotError() { Test2(NotErrorInt2.ExnToResult, Result.Success<int?>(42).CastFailure<Exception>()); }
            #endregion

            #region NullToResult
            [Test]
            public void NullToResult0_NullInt() { Test0<int, Unit>(NullInt0.NullToResult, Result.Failure(Unit._)); }

            [Test]
            public void NullToResult0_NotNullInt() { Test0(NotNullInt0.NullToResult, Result.Success(42).CastFailure<Unit>()); }

            [Test]
            public void NullToResult0_NullStr() { Test0<string, Unit>(NullStr0.NullToResult, Result.Failure(Unit._)); }

            [Test]
            public void NullToResult0_NotNullStr() { Test0(NotNullStr0.NullToResult, Result.Success("hoge").CastFailure<Unit>()); }

            [Test]
            public void NullToResult1_NullInt() { Test1<int, Unit>(NullInt1.NullToResult, Result.Failure(Unit._)); } 

            [Test]
            public void NullToResult1_NotNullInt() { Test1(NotNullInt1.NullToResult, Result.Success(42).CastFailure<Unit>()); }

            [Test]
            public void NullToResult1_NullStr() { Test1<string, Unit>(NullStr1.NullToResult, Result.Failure(Unit._)); }

            [Test]
            public void NullToResult1_NotNullStr() { Test1(NotNullStr1.NullToResult, Result.Success("hoge").CastFailure<Unit>()); }

            [Test]
            public void NullToResult2_NullInt() { Test2<int, Unit>(NullInt2.NullToResult, Result.Failure(Unit._)); }

            [Test]
            public void NullToResult2_NotNullInt() { Test2(NotNullInt2.NullToResult, Result.Success(42).CastFailure<Unit>()); }

            [Test]
            public void NullToResult2_NullStr() { Test2<string, Unit>(NullStr2.NullToResult, Result.Failure(Unit._)); }

            [Test]
            public void NullToResult2_NotNullStr() { Test2(NotNullStr2.NullToResult, Result.Success("hoge").CastFailure<Unit>()); }
            #endregion

            #region ToResult
            [Test]
            public void ToResult0_ErrorInt() { Test0<int>(ErrorInt0.ToResult, Result.Failure(new MyException().AsExn())); }

            [Test]
            public void ToResult0_NullInt() { Test0<int>(NullInt0.ToResult, Result.Failure(new NullResultException().AsExn())); }

            [Test]
            public void ToResult0_Int() { Test0(NotNullInt0.ToResult, Result.Success(42).CastFailure<Exception>()); }

            [Test]
            public void ToResult0_ErrorStr() { Test0<string>(ErrorStr0.ToResult, Result.Failure(new MyException().AsExn())); }

            [Test]
            public void ToResult0_NullStr() { Test0<string>(NullStr0.ToResult, Result.Failure(new NullResultException().AsExn())); }

            [Test]
            public void ToResult0_Str() { Test0(NotNullStr0.ToResult, Result.Success("hoge").CastFailure<Exception>()); }

            [Test]
            public void ToResult1_ErrorInt() { Test1<int>(ErrorInt1.ToResult, Result.Failure(new MyException().AsExn())); }

            [Test]
            public void ToResult1_NullInt() { Test1<int>(NullInt1.ToResult, Result.Failure(new NullResultException().AsExn())); }

            [Test]
            public void ToResult1_Int() { Test1(NotNullInt1.ToResult, Result.Success(42).CastFailure<Exception>()); }

            [Test]
            public void ToResult1_ErrorStr() { Test1<string>(ErrorStr1.ToResult, Result.Failure(new MyException().AsExn())); }

            [Test]
            public void ToResult1_NullStr() { Test1<string>(NullStr1.ToResult, Result.Failure(new NullResultException().AsExn())); }

            [Test]
            public void ToResult1_Str() { Test1(NotNullStr1.ToResult, Result.Success("hoge").CastFailure<Exception>()); }

            [Test]
            public void ToResult2_ErrorInt() { Test2<int>(ErrorInt2.ToResult, Result.Failure(new MyException().AsExn())); }

            [Test]
            public void ToResult2_NullInt() { Test2<int>(NullInt2.ToResult, Result.Failure(new NullResultException().AsExn())); }

            [Test]
            public void ToResult2_Int() { Test2(NotNullInt2.ToResult, Result.Success(42).CastFailure<Exception>()); }

            [Test]
            public void ToResult2_ErrorStr() { Test2<string>(ErrorStr2.ToResult, Result.Failure(new MyException().AsExn())); }

            [Test]
            public void ToResult2_NullStr() { Test2<string>(NullStr2.ToResult, Result.Failure(new NullResultException().AsExn())); }

            [Test]
            public void ToResult2_Str() { Test2(NotNullStr2.ToResult, Result.Success("hoge").CastFailure<Exception>()); }
            #endregion
        }
    }
}
