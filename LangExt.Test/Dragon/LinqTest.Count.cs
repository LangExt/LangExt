using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using LangExt.Dragon;

namespace LangExt.Test.Dragon
{
    [TestFixture]
    class LinqTest_Count
    {
        [Test]
        public void 二要素のタプルのシーケンスから条件にあう要素数を取得できる()
        {
            var ts = new[] { 2, 4, 6, 8, 10 }.ZipWithIndex();

            Assert.That(ts.Count((i, j) => (i / 2) % 2 == 0 && j > 2), Is.EqualTo(1));
        }

        [Test]
        public void 二要素のタプルのシーケンスから条件にあう要素数をlongで取得できる()
        {
            var ts = new[] { 2, 4, 6, 8, 10 }.ZipWithIndex();

            var result = ts.LongCount((i, j) => (i / 2) % 2 == 0 && j > 2);
            Assert.That(result, Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<long>());
        }

        [Test]
        public void 三要素のタプルのシーケンスから条件にあう要素数を取得できる()
        {
            var ts = new[] { 2, 4, 6, 8, 10 }.ZipWithIndex(new[] { 10, 20, 30, 40, 50 });

            Assert.That(ts.Count((i, j, k) => (i / 2) % 2 == 0 && j > 2 && k == 3), Is.EqualTo(1));
        }

        [Test]
        public void 三要素のタプルのシーケンスから条件にあう要素数をlongで取得できる()
        {
            var ts = new[] { 2, 4, 6, 8, 10 }.ZipWithIndex(new[] { 10, 20, 30, 40, 50 });

            var result = ts.LongCount((i, j, k) => (i / 2) % 2 == 0 && j > 2 && k == 3);
            Assert.That(result, Is.EqualTo(1));
            Assert.That(result, Is.TypeOf<long>());
        }
    }
}
