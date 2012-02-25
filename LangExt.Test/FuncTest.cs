using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LangExt.Test
{
    [TestFixture]
    public class FuncTest
    {
        [Test]
        public void Id関数()
        {
            Assert.That(FuncUtil.Id(123), Is.EqualTo(123));
            Assert.That(FuncUtil.Id("foo"), Is.EqualTo("foo"));
        }

        [Test]
        public void Maybe関数()
        {
            var safeParse = FuncUtil.Maybe<string, int>(int.Parse);
            Assert.That(safeParse("123"), Is.EqualTo(new Option<int>(123)));
            Assert.That(safeParse("ababa"), Is.EqualTo(Option<int>.None));
        }

        [Test]
        public void Either関数()
        {
            var safeParse = FuncUtil.Either<string, int>(int.Parse);
            Assert.That(safeParse("123"), Is.EqualTo(Either.Right(123)));
            Assert.That(safeParse("ababa").Match(l => true, r => false), Is.True);
        }
    }
}
