using System;
using LangExt.RangeUnit;
using NUnit.Framework;

namespace LangExt.Tests
{
    [TestFixture]
    public class RangeTest
    {
        [Test]
        public void 長さ0のRangeを生成できる()
        {
            var range = Range.Create((0).ToLen());
            Assert.That(range.Begin, Is.EqualTo(0));
            Assert.That(range.End, Is.EqualTo(0));
            Assert.That(() => range.Last, Throws.Exception.TypeOf<InvalidOperationException>());
            Assert.That(range.Length, Is.EqualTo(0));
        }

        [Test]
        public void 長さが負のRangeは生成できない()
        {
            Assert.That(() => Range.Create((-1).ToLen()), Throws.Exception);
        }

        [Test]
        public void 長さを指定してRangeを生成できる()
        {
            var range = Range.Create((10).ToLen());
            Assert.That(range.Begin, Is.EqualTo(0));
            Assert.That(range.End, Is.EqualTo(10));
            Assert.That(range.Last, Is.EqualTo(9));
            Assert.That(range.Length, Is.EqualTo(10));
        }

        [Test]
        public void 始点と長さを指定してRangeを生成できる()
        {
            var range = Range.Create(3, (10).ToLen());
            Assert.That(range.Begin, Is.EqualTo(3));
            Assert.That(range.End, Is.EqualTo(13));
            Assert.That(range.Last, Is.EqualTo(12));
            Assert.That(range.Length, Is.EqualTo(10));
        }

        [Test]
        public void 終了位置を指定してRangeを生成できる()
        {
            var range = Range.Create((10).ToIdx());
            Assert.That(range.Begin, Is.EqualTo(0));
            Assert.That(range.End, Is.EqualTo(10));
            Assert.That(range.Last, Is.EqualTo(9));
            Assert.That(range.Length, Is.EqualTo(10));
        }

        [Test]
        public void 始点と終了位置を指定してRangeを生成できる()
        {
            var range = Range.Create(3, (10).ToIdx());
            Assert.That(range.Begin, Is.EqualTo(3));
            Assert.That(range.End, Is.EqualTo(10));
            Assert.That(range.Last, Is.EqualTo(9));
            Assert.That(range.Length, Is.EqualTo(7));
        }

        [Test]
        public void FromToでRangeが生成できる()
        {
            var range = Range.FromTo(0, 10);
            Assert.That(range, Is.EqualTo(Range.Create(0, (11).ToIdx())));
        }

        [Test]
        public void FromUntilでRangeが生成できる()
        {
            var range = Range.FromUntil(0, 10);
            Assert.That(range, Is.EqualTo(Range.Create(0, (10).ToIdx())));
        }

        [Test]
        public void FromToに同じ数値を渡すとそれのみを含むRangeが生成できる()
        {
            var range = Range.FromTo(10, 10);
            Assert.That(range.Begin, Is.EqualTo(10));
            Assert.That(range.End, Is.EqualTo(11));
            Assert.That(range.Last, Is.EqualTo(10));
            Assert.That(range.Length, Is.EqualTo(1));
        }

        [Test]
        public void FromUntilに同じ数値を渡すと空のRangeが生成できる()
        {
            var range = Range.FromUntil(0, 0);
            Assert.That(range.Begin, Is.EqualTo(0));
            Assert.That(range.End, Is.EqualTo(0));
            Assert.That(() => range.Last, Throws.Exception.TypeOf<InvalidOperationException>());
            Assert.That(range.Length, Is.EqualTo(0));
        }

        [Test]
        public void Fromより小さいToを渡しても適切なRangeが生成できる()
        {
            var range = Range.FromTo(10, 5);
            Assert.That(range.Begin, Is.EqualTo(10));
            Assert.That(range.End, Is.EqualTo(4));
            Assert.That(range.Last, Is.EqualTo(5));
            Assert.That(range.Length, Is.EqualTo(6));
        }

        [TestCase(0, 5, new[] { 0, 1, 2, 3, 4 })]
        [TestCase(1, 5, new[] { 1, 2, 3, 4 })]
        [TestCase(5, 0, new[] { 5, 4, 3, 2, 1 })]
        [TestCase(5, 5, new int[0])]
        [TestCase(0, 0, new int[0])]
        [TestCase(0, 1, new[] { 0 })]
        [TestCase(0, -1, new[] { 0 })]
        [TestCase(1, 0, new[] { 1 })]
        [TestCase(-1, 0, new[] { -1 })]
        public void RangeをSeqに変換できる(int begin, int end, int[] expected)
        {
            var range = Range.FromUntil(begin, end);
            Assert.That(range.ToSeq(), Is.EqualTo(Seq.Create(expected)));
        }

        [TestCase(0, 5, 1, new[] { 0, 1, 2, 3, 4 })]
        [TestCase(0, 5, 2, new[] { 0, 2, 4 })]
        [TestCase(0, 5, 3, new[] { 0, 3 })]
        [TestCase(0, 5, 0, null, ExpectedException=typeof(ArgumentOutOfRangeException))]
        [TestCase(0, 5, -1, null, ExpectedException=typeof(ArgumentException))]
        [TestCase(5, 0, 1, null, ExpectedException=typeof(ArgumentException))]
        public void Stepを指定してSeqに変換できる(int begin, int end, int step, int[] expected)
        {
            var range = Range.FromUntil(begin, end);
            Assert.That(range.ToSeq(step), Is.EqualTo(Seq.Create(expected)));
        }
    }
}
