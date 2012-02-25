using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LangExt.Test
{
    [TestFixture]
    public class MonadTest
    {
        [Test]
        public void Optionを剥がしてまた被せる()
        {
            var m = new Option<string>("hoge");
            var result = from result1 in m
                         select result1;

            Assert.That(result, Is.EqualTo(m));
        }

        [Test]
        public void Optionにidを適用()
        {
            var m = new Option<string>("hoge");
            var result = from result1 in m
                         let result2 = FuncUtil.Id(result1)
                         select result2;

            Assert.That(result, Is.EqualTo(m));
        }

        [Test]
        public void Optionに関数を適用()
        {
            var safeParse = FuncUtil.Maybe<string, int>(int.Parse);
            var m = new Option<string>("12345");
            var result = from result1 in m
                         from result2 in safeParse(result1)
                         select result2;

            Assert.That(result, Is.EqualTo(new Option<int>(12345)));
        }

        [Test]
        public void Optionに関数を適用_途中で失敗する関数()
        {
            var safeParse = FuncUtil.Maybe<string, int>(int.Parse);
            var m = new Option<string>("hoge");
            var result = from result1 in m
                         from result2 in safeParse(result1)
                         select result2;

            Assert.That(result, Is.EqualTo(Option<int>.None));
        }

        [Test]
        public void Eitherを剥がしてまた被せる()
        {
            var m = new Either<int, string>("success");
            var result = from result1 in m
                         select result1;

            Assert.That(result, Is.EqualTo(m));
        }

        [Test]
        public void Eitherにidを適用()
        {
            var m = new Either<int, string>("success");
            var result = from result1 in m
                         let result2 = FuncUtil.Id(result1)
                         select result2;

            Assert.That(result, Is.EqualTo(m));
        }

        [Test]
        public void Eitherに関数を適用()
        {
            var safeParse = FuncUtil.Maybe<string, int>(int.Parse);
            var m = new Option<string>("12345");
            var result = from result1 in m
                         from result2 in safeParse(result1)
                         select result2;

            Assert.That(result, Is.EqualTo(new Option<int>(12345)));
        }

        [Test]
        public void Eitherに関数を適用_途中で失敗する関数()
        {
            var safeParse = FuncUtil.Either<string, int>(int.Parse);
            var m = (Either<Exception, string>)Either.Right("hoge");
            var result = from result1 in m
                         from result2 in safeParse(result1)
                         select result2;

            Assert.That(result.Match(l => true, r => false), Is.True);
        }
    }
}
