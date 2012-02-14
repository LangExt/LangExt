using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using LangExt.Dragon;

namespace LangExt.Test.Dragon
{
    [TestFixture]
    class LinqTest_Average
    {
        [Test]
        public void decimalをdecimalとして平均を計算できる()
        {
            var ts = new[] { 1.0m, 2.0m, 3.0m, 4.0m }.ZipWithIndex();

            Assert.That(ts.Average((d, i) => d + i), Is.EqualTo(ts.Average(t => t._1 + t._2)));
            Assert.That(ts.Average((d, i) => d + i), Is.EqualTo(4.0m).Within(0.001m));
        }

        [Test]
        public void intをdoubleとして平均を計算できる()
        {
            var ts = new[] { 1, 2, 3, 4 }.ZipWithIndex();

            Assert.That(ts.Average((i, j) => i + j), Is.EqualTo(ts.Average(t => t._1 + t._2)));
            Assert.That(ts.Average((i, j) => i + j), Is.EqualTo(4.0).Within(0.001));
        }

        [Test]
        public void NullableなdecimalをNullableなdecimalとして平均を計算できる()
        {
            var ts = new decimal?[] { 1.0m, 2.0m, null, 3.0m, null, 4.0m }.ZipWithIndex();

            Assert.That(ts.Average((d, i) => d.HasValue ? d.Value + i : i), Is.EqualTo(ts.Average(t => t._1.HasValue ? t._1.Value + t._2 : t._2)));
            Assert.That(ts.Average((d, i) => d.HasValue ? d.Value + i : i), Is.EqualTo(4.166m).Within(0.001m));
        }

        [Test]
        public void NullableなintをNullableなdoubleとして平均を計算できる()
        {
            var ts = new int?[] { 1, 2, null, 3, null, 4 }.ZipWithIndex();

            Assert.That(ts.Average((i, j) => i.HasValue ? i.Value + j : j), Is.EqualTo(ts.Average(t => t._1.HasValue ? t._1.Value + t._2 : t._2)));
            Assert.That(ts.Average((i, j) => i.HasValue ? i.Value + j : j), Is.EqualTo(4.166).Within(0.001));
        }
    }
}
