using System;
using LangExt;
using LangExt.Unsafe;
using NUnit.Framework;

namespace LangExt.Tests
{
    using LinqIE = System.Linq.Enumerable;
    public class SeqTest
    {
        [Test(Description="Seq.Empty()は空のシーケンスを返す")]
        public void Empty()
        {
            Assert.That(Seq.Empty<int>().IsEmpty(), Is.True);
        }

        [TestCase(new int[0], "seq []")]
        [TestCase(new[] { 1 }, "seq [1]")]
        [TestCase(new[] { 1, 2 }, "seq [1, 2]")]
        [TestCase(new[] { 1, 2, 3 }, "seq [1, 2, 3]")]
        [TestCase(new[] { 1, 2, 3, 4 }, "seq [1, 2, 3, 4]")]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, "seq [1, 2, 3, 4, 5]")]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6 }, "seq [1, 2, 3, 4, 5, ...]")]
        public void ToString(int[] values, string expected)
        {
            var sut = Create.Seq(values);
            Assert.That(sut.ToString(), Is.EqualTo(expected));
        }

        [Test]
        public void ToString_EmptySeq()
        {
            Assert.That(Seq.Empty<int>().ToString(), Is.EqualTo("seq []"));
        }

        [TestCase(new int[0], "seq []")]
        [TestCase(new[] { 1 }, "seq [1]")]
        [TestCase(new[] { 1, 2 }, "seq [1, 2]")]
        [TestCase(new[] { 1, 2, 3 }, "seq [1, 2, 3]")]
        [TestCase(new[] { 1, 2, 3, 4 }, "seq [1, 2, 3, 4]")]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, "seq [1, 2, 3, 4, 5]")]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6 }, "seq [1, 2, 3, 4, 5, ...]")]
        public void ToString_OrderedSeq(int[] values, string expected)
        {
            var sut = Create.Seq(values).SortBy(i => i);
            Assert.That(sut.ToString(), Is.EqualTo(expected));
        }
    }
}
