using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LangExt.Test
{
    [TestFixture]
    class EitherTest
    {
        [Test]
        public void Leftを取得()
        {
            Either<string, int> left = Either.Left("Leftです");
            Assert.That(left.Left, Is.EqualTo("Leftです") );
        }

        [Test, ExpectedException(typeof(InvalidCastException))]
        public void LeftのRightを取得しようとすると失敗する()
        {
            Either<string, int> left = Either.Left("Leftです");
            var right = left.Right;
        }

        [Test]
        public void Rightを取得()
        {
            Either<string, int> right = Either.Right(10);
            Assert.That(right.Right, Is.EqualTo(10));
        }

        [Test, ExpectedException(typeof(InvalidCastException))]
        public void RightのLeftを取得しようとすると失敗する()
        {
            Either<string, int> right = Either.Right(10);
            var left = right.Left;
        }

        [Test]
        public void Leftのパターンマッチを行う()
        {
            Either<string, int> leftEither = Either.Left("Leftです");

            var result = leftEither.Match(
                                left => "Left",
                                right => "Right");

            Assert.That(result, Is.EqualTo("Left"));
        }

        [Test]
        public void Rightのパターンマッチを行う()
        {
            Either<string, int> rightEither = Either.Right(10);

            var result = rightEither.Match(
                                left => "Left",
                                right => "Right");

            Assert.That(result, Is.EqualTo("Right"));
        }

        [Test]
        public void 型を判別する_Right()
        {
            Either<string, int> rightEither = Either.Right(10);

            Assert.IsTrue(rightEither.Is<int>());
        }

        [Test]
        public void 型を判別する_Leftで右にIs()
        {
            Either<string, int> leftEither = Either.Left("Leftです");

            Assert.IsFalse(leftEither.Is<int>());
        }

        [Test]
        public void 型を判別する_Left()
        {
            Either<string, int> leftEither = Either.Left("Leftです");

            Assert.IsTrue(leftEither.Is<String>());
        }
        [Test]
        public void SomeのBindが行える()
        {
            Either<int, string> rightEither1 = Either.Right("Rightです");

            var result = rightEither1.Bind(v => Either.Right("Right2です"));
            Assert.That(result.Equals(Either.Right("Right2です")), Is.True);
        }

        [Test]
        public void クエリ式でbindができる()
        {
            Either<int, string> rightEither1 = Either.Right("Right1です");
            Either<int, string> rightEither2 = Either.Right("Right2です");

            var result =
                    from v1 in rightEither1
                    from v2 in rightEither2
                    select v2;

            Assert.That(result.Equals(Either.Right("Right2です")), Is.True);
        }


        [Test]
        public void クエリ式でbindができる_途中失敗パターン()
        {
            Either<int, string> rightEither1 = Either.Right("Right1です");
            Either<int, string> leftEither2 = Either.Left(100);

            var result =
                    from v1 in rightEither1
                    from v2 in leftEither2
                    select v2;

            Assert.That(result.Equals(Either.Left(100)), Is.True);
        }

        [Test]
        public void 等値演算子が定義されている()
        {
            Either<Exception, string> rightEither1 = Either.Right("Right1");
            var rightEither2 = Either.Right("Right1");

            Assert.That(rightEither1, Is.EqualTo(rightEither2));
            Assert.That(rightEither2, Is.EqualTo(rightEither1));
        }

        [Test]
        public void 引数なしのRightでUnit値を生成できる()
        {
            Either<Either.Undefined, Unit> either = Either.Right();

            Assert.That(either, Is.EqualTo(Either.Right(Unit._)));
        }
    }
}
