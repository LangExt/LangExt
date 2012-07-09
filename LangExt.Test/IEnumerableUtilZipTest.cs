using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LangExt.Test
{
    [TestFixture]
    class IEnumerableUtilZipTest
    {
        [Test]
        public void 二つのシーケンスをZipできる()
        {
            var a = new[] { 10, 20, 30 };
            var b = new[] { "a", "b", "c", "d" };

            Assert.That(a.Zip(b), Is.EqualTo(new[] { Tpl.Of(10, "a"), Tpl.Of(20, "b"), Tpl.Of(30, "c") }));
        }

        [Test]
        public void 二つのシーケンスの短い方のシーケンスに合わせられる()
        {
            var a = new[] { 10, 20, 30, 40 };
            var b = new[] { "a", "b", "c" };

            Assert.That(a.Zip(b), Is.EqualTo(new[] { Tpl.Of(10, "a"), Tpl.Of(20, "b"), Tpl.Of(30, "c") }));
            Assert.That(b.Zip(a), Is.EqualTo(new[] { Tpl.Of("a", 10), Tpl.Of("b", 20), Tpl.Of("c", 30) }));
        }

        [Test]
        public void 三つのシーケンスをZipできる()
        {
            var a = new[] { 10, 20, 30 };
            var b = new[] { "a", "b", "c" };
            var c = new object[] { null, null, null, null };

            Assert.That(a.Zip(b, c), Is.EqualTo(new[] {
                Tpl.Of(10, "a", default(object)),
                Tpl.Of(20, "b", default(object)),
                Tpl.Of(30, "c", default(object))
            }));
        }

        [Test]
        public void Zipしたシーケンスをもとの二つのシーケンスに戻せる()
        {
            var a = new[] { 10, 20, 30, 40 };
            var b = new[] { "a", "b", "c" };
            var zipped = a.Zip(b);

            var result = zipped.Unzip();
            Assert.That(result._1.ToArray(), Is.EqualTo(new[] { 10, 20, 30 })); // 長い方は戻せない
            Assert.That(result._2.ToArray(), Is.EqualTo(new[] { "a", "b", "c" }));
        }

        [Test]
        public void Zipしたシーケンスをもとの三つのシーケンスに戻せる()
        {
            var a = new[] { 10, 20, 30 };
            var b = new[] { "a", "b", "c", "d" };
            var c = new object[] { null, null, null };
            var zipped = a.Zip(b, c);

            var result = zipped.Unzip();
            Assert.That(result._1.ToArray(), Is.EqualTo(new[] { 10, 20, 30 }));
            Assert.That(result._2.ToArray(), Is.EqualTo(new[] { "a", "b", "c" })); // 長い方は戻せない
            Assert.That(result._3.ToArray(), Is.EqualTo(new object[] { null, null, null }));
        }

        [Test]
        public void 二つのシーケンスとタプルの生成メソッドをZipWithするとZipと同じ()
        {
            var a = new[] { 1, 2, 3 };
            var b = new[] { 4, 5, 6 };

            Assert.That(a.ZipWith(b, Tpl.Of), Is.EqualTo(a.Zip(b)));
        }

        [Test]
        public void 三つのシーケンスとタプルの生成メソッドをZipWithするとZipと同じ()
        {
            var a = new[] { 1, 2, 3 };
            var b = new[] { 1, 3, 5 };
            var c = new[] { "a", "b", "c" };

            Assert.That(a.ZipWith(b, c, Tpl.Of), Is.EqualTo(a.Zip(b, c)));
        }

        [Test]
        public void ZipWithIndexでインデックスとZipできる()
        {
            var a = new[] { "a", "b", "c" };

            Assert.That(a.ZipWithIndex(), Is.EqualTo(a.Zip(Enumerable.Range(0, int.MaxValue))));
        }

        [Test]
        public void ZipWithIndexでインデックスとほかのシーケンスをまとめてZipできる()
        {
            var a = new[] { "a", "b", "c" };
            var b = new[] { 10, 20, 30 };

            Assert.That(a.ZipWithIndex(b), Is.EqualTo(a.Zip(b, Enumerable.Range(0, int.MaxValue))));
        }
    }
}
