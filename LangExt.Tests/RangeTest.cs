using System;
using LangExt.RangeUnit;
using NUnit.Framework;

namespace LangExt.Tests
{
    [TestFixture]
    public class RangeTest
    {
        [Test]
        public void 長さを指定してRangeを生成できる()
        {
            var range = Range.Create((10).ToLen());
            Assert.That(range.From, Is.EqualTo(0));
            Assert.That(range.To, Is.EqualTo(9));
            Assert.That(range.Length, Is.EqualTo(10));
        }

        [Test]
        public void 始点と長さを指定してRangeを生成できる()
        {
            var range = Range.Create(3, (10).ToLen());
            Assert.That(range.From, Is.EqualTo(3));
            Assert.That(range.To, Is.EqualTo(12));
            Assert.That(range.Length, Is.EqualTo(10));
        }

        [Test]
        public void 終了位置を指定してRangeを生成できる()
        {
            var range = Range.Create((10).ToIdx());
            Assert.That(range.From, Is.EqualTo(0));
            Assert.That(range.To, Is.EqualTo(10));
            Assert.That(range.Length, Is.EqualTo(11));
        }

        [Test]
        public void 始点と終了位置を指定してRangeを生成できる()
        {
            var range = Range.Create(3, (10).ToIdx());
            Assert.That(range.From, Is.EqualTo(3));
            Assert.That(range.To, Is.EqualTo(10));
            Assert.That(range.Length, Is.EqualTo(8));
        }

        [Test]
        public void FromToでRangeが生成できる()
        {
            var range = Range.FromTo(0, 10);
            Assert.That(range, Is.EqualTo(Range.Create(0, (10).ToIdx())));
        }

        [Test]
        public void FromToに同じ数値を渡すとそれのみを含むRangeが生成できる()
        {
            var range = Range.FromTo(10, 10);
            Assert.That(range.From, Is.EqualTo(10));
            Assert.That(range.To, Is.EqualTo(10));
            Assert.That(range.Length, Is.EqualTo(1));
        }

        [Test]
        public void Fromより小さいToを渡しても適切なRangeが生成できる()
        {
            var range = Range.FromTo(10, 5);
            Assert.That(range.From, Is.EqualTo(10));
            Assert.That(range.To, Is.EqualTo(5));
            Assert.That(range.Length, Is.EqualTo(6));
        }

        [TestCase(0, 5, new[] { 0, 1, 2, 3, 4, 5 })]
        [TestCase(1, 5, new[] { 1, 2, 3, 4, 5 })]
        [TestCase(5, 0, new[] { 5, 4, 3, 2, 1, 0 })]
        [TestCase(5, 5, new[] { 5 })]
        // どうあがいても空のRangeは作れません
        [TestCase(0, 0, new[] { 0 })]
        [TestCase(0, 1, new[] { 0, 1 })]
        [TestCase(0, -1, new[] { 0, -1 })]
        [TestCase(1, 0, new[] { 1, 0 })]
        [TestCase(-1, 0, new[] { -1, 0 })]
        public void RangeをSeqに変換できる(int from, int to, int[] expected)
        {
            var range = Range.FromTo(from, to);
            Assert.That(range.ToSeq(), Is.EqualTo(Seq.Create(expected)));
        }
    }
}
