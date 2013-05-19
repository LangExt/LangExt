using System;
using LangExt.Playground.OperatorChain;
using NUnit.Framework;

namespace LangExt.Tests.Playground.OperatorChain
{
    [TestFixture]
    public class Example
    {
        [Test]
        public void CompileTest()
        {
            Cmp<int> x = 10;
            Cmp<int> y = 20;
            Cmp<int> z = 30;
            if (0 < x < y < z < 100)
            { /* do-nothing */ }
            else
                Assert.Fail();

            if (0 < x < z < y < 100)
                Assert.Fail();
            else
            { /* do-nothing */ }

            if (0 < x < z > y < 100)
            { /* do-nothing */ }
            else
                Assert.Fail();

            if (0 < x < z > y > 10)
            { /* do-nothing */ }
            else
                Assert.Fail();
        }

        [TestCase(0, false)]
        [TestCase(10, false)]
        [TestCase(11, true)]
        [TestCase(99, true)]
        [TestCase(100, false)]
        [TestCase(1000, false)]
        public void Between10And100_GtGt(int i, bool expected)
        {
            Cmp<int> x = i;
            if (10 < x < 100)
                Assert.That(expected, Is.True);
            else
                Assert.That(expected, Is.False);
        }

        [TestCase(0, false)]
        [TestCase(10, true)]
        [TestCase(11, true)]
        [TestCase(99, true)]
        [TestCase(100, false)]
        [TestCase(1000, false)]
        public void Between10And100_GteGt(int i, bool expected)
        {
            Cmp<int> x = i;
            if (10 <= x < 100)
                Assert.That(expected, Is.True);
            else
                Assert.That(expected, Is.False);
        }

        [TestCase(0, false)]
        [TestCase(10, false)]
        [TestCase(11, true)]
        [TestCase(99, true)]
        [TestCase(100, true)]
        [TestCase(1000, false)]
        public void Between10And100_GtGte(int i, bool expected)
        {
            Cmp<int> x = i;
            if (10 < x <= 100)
                Assert.That(expected, Is.True);
            else
                Assert.That(expected, Is.False);
        }

        [TestCase(0, false)]
        [TestCase(10, true)]
        [TestCase(11, true)]
        [TestCase(99, true)]
        [TestCase(100, true)]
        [TestCase(1000, false)]
        public void Between10And100_GteGte(int i, bool expected)
        {
            Cmp<int> x = i;
            if (10 <= x <= 100)
                Assert.That(expected, Is.True);
            else
                Assert.That(expected, Is.False);
        }

        [TestCase(0, false)]
        [TestCase(10, false)]
        [TestCase(11, true)]
        [TestCase(99, true)]
        [TestCase(100, false)]
        [TestCase(1000, false)]
        public void Between100And10_LtLt(int i, bool expected)
        {
            Cmp<int> x = i;
            if (100 > x > 10)
                Assert.That(expected, Is.True);
            else
                Assert.That(expected, Is.False);
        }

        [TestCase(0, false)]
        [TestCase(10, false)]
        [TestCase(11, true)]
        [TestCase(99, true)]
        [TestCase(100, true)]
        [TestCase(1000, false)]
        public void Between100And10_LteLt(int i, bool expected)
        {
            Cmp<int> x = i;
            if (100 >= x > 10)
                Assert.That(expected, Is.True);
            else
                Assert.That(expected, Is.False);
        }

        [TestCase(0, false)]
        [TestCase(10, true)]
        [TestCase(11, true)]
        [TestCase(99, true)]
        [TestCase(100, false)]
        [TestCase(1000, false)]
        public void Between100And10_LtLte(int i, bool expected)
        {
            Cmp<int> x = i;
            if (100 > x >= 10)
                Assert.That(expected, Is.True);
            else
                Assert.That(expected, Is.False);
        }

        [TestCase(0, false)]
        [TestCase(10, true)]
        [TestCase(11, true)]
        [TestCase(99, true)]
        [TestCase(100, true)]
        [TestCase(1000, false)]
        public void Between100And10_LteLte(int i, bool expected)
        {
            Cmp<int> x = i;
            if (100 >= x >= 10)
                Assert.That(expected, Is.True);
            else
                Assert.That(expected, Is.False);
        }

        [Test]
        public void Lazy()
        {
            Cmp<int> x = 10;
            var i = 0;
            LazyVal<int> y = new Func<int>(() => i++);
            if (100 < x > y) { /* do-nothing */ }
            Assert.That(i, Is.EqualTo(0));

            if (0 < x > y) { /* do-nothing */ }
            Assert.That(i, Is.EqualTo(1));

            if (0 < y) { /* do-nothing */ }
            Assert.That(i, Is.EqualTo(1));
        }
    }
}
