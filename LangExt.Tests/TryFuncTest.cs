using System;
using NUnit.Framework;

namespace LangExt.Tests
{
    [TestFixture]
    public class TryFuncTest
    {
        public enum FuncResult
        {
            False,
            Exception,
            Null,
            True
        }

        static readonly TryFunc<FuncResult, int> F = (FuncResult fr, out int res) =>
        {
            switch (fr)
            {
                case FuncResult.False:
                    res = 0;
                    return false;
                case FuncResult.Exception:
                    res = 0;
                    throw new Exception();
                case FuncResult.Null:
                    throw new ArgumentException();
                case FuncResult.True:
                    res = 42;
                    return true;
            }
            throw new InvalidProgramException();
        };

        static readonly TryFunc<FuncResult, int?> G = (FuncResult fr, out int? res) =>
        {
            switch (fr)
            {
                case FuncResult.False:
                    res = null;
                    return false;
                case FuncResult.Exception:
                    res = null;
                    throw new Exception();
                case FuncResult.Null:
                    res = null;
                    return true;
                case FuncResult.True:
                    res = 42;
                    return true;
            }
            throw new InvalidProgramException();
        };

        static readonly TryFunc<FuncResult, string> H = (FuncResult fr, out string res) =>
        {
            switch (fr)
            {
                case FuncResult.False:
                    res = null;
                    return false;
                case FuncResult.Exception:
                    res = null;
                    throw new Exception();
                case FuncResult.Null:
                    res = null;
                    return true;
                case FuncResult.True:
                    res = "hoge";
                    return true;
            }
            throw new InvalidProgramException();
        };

        [TestCase(FuncResult.False, null)] 
        [TestCase(FuncResult.Exception, null, ExpectedException=typeof(Exception))]
        [TestCase(FuncResult.Null, null, ExpectedException=typeof(ArgumentException))]
        [TestCase(FuncResult.True, 42)]
        public void 値型の出力引数を伴う関数をOptionを返す関数に変換できる(FuncResult fr, object expected)
        {
            var f = F.ToOptFunc();
            Assert.That(f(fr), Is.EqualTo(expected == null ? Option<int>.None : Option.Some((int)expected)));
        }

        [TestCase(FuncResult.False, null, typeof(NullResultException))] 
        [TestCase(FuncResult.Exception, null, typeof(Exception))]
        [TestCase(FuncResult.Null, null, typeof(ArgumentException))]
        [TestCase(FuncResult.True, 42, null)]
        public void 値型の出力引数を伴う関数をResultを返す関数に変換できる(FuncResult fr, object expectedSuccess, Type expectedFailure)
        {
            var f = F.ToResultFunc();
            if (expectedFailure != null)
            {
                Assert.That(f(fr).GetFailureOr(null), Is.TypeOf(expectedFailure));
            }
            else
            {
                Assert.That(f(fr), Is.EqualTo(Result.NewSuccess<int, Exception>((int)expectedSuccess)));
            }
        }

        [TestCase(FuncResult.False, null)] 
        [TestCase(FuncResult.Exception, null, ExpectedException=typeof(Exception))]
        [TestCase(FuncResult.Null, null)]
        [TestCase(FuncResult.True, 42)]
        public void null許容型の出力引数を伴う関数をOptionを返す関数に変換できる(FuncResult fr, object expected)
        {
            var f = G.ToOptFunc();
            Assert.That(f(fr), Is.EqualTo(expected == null ? Option<int?>.None : Option.Some((int?)expected)));
        }

        [TestCase(FuncResult.False, null, typeof(NullResultException))] 
        [TestCase(FuncResult.Exception, null, typeof(Exception))]
        [TestCase(FuncResult.Null, null, typeof(NullResultException))]
        [TestCase(FuncResult.True, 42, null)]
        public void null許容型の出力引数を伴う関数をResultを返す関数に変換できる(FuncResult fr, object expectedSuccess, Type expectedFailure)
        {
            var f = G.ToResultFunc();
            if (expectedFailure != null)
            {
                Assert.That(f(fr).GetFailureOr(null), Is.TypeOf(expectedFailure));
            }
            else
            {
                Assert.That(f(fr), Is.EqualTo(Result.NewSuccess<int?, Exception>((int?)expectedSuccess)));
            }
        }

        [TestCase(FuncResult.False, null)] 
        [TestCase(FuncResult.Exception, null, ExpectedException=typeof(Exception))]
        [TestCase(FuncResult.Null, null)]
        [TestCase(FuncResult.True, "hoge")]
        public void 参照型の出力引数を伴う関数をOptionを返す関数に変換できる(FuncResult fr, object expected)
        {
            var f = H.ToOptFunc();
            Assert.That(f(fr), Is.EqualTo(expected == null ? Option<string>.None : Option.Some((string)expected)));
        }

        [TestCase(FuncResult.False, null, typeof(NullResultException))] 
        [TestCase(FuncResult.Exception, null, typeof(Exception))]
        [TestCase(FuncResult.Null, null, typeof(NullResultException))]
        [TestCase(FuncResult.True, "hoge", null)]
        public void 参照型の出力引数を伴う関数をResultを返す関数に変換できる(FuncResult fr, object expectedSuccess, Type expectedFailure)
        {
            var f = H.ToResultFunc();
            if (expectedFailure != null)
            {
                Assert.That(f(fr).GetFailureOr(null), Is.TypeOf(expectedFailure));
            }
            else
            {
                Assert.That(f(fr), Is.EqualTo(Result.NewSuccess<string, Exception>((string)expectedSuccess)));
            }
        }
    }
}
