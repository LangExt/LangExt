using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LangExt.Test
{
    [TestFixture]
    class TplTest
    {
        [Test]
        public void 二要素のタプルが生成できる()
        {
            var t = Tpl.Of("hoge", 42);
            Assert.That(t.GetType(), Is.EqualTo(typeof(_<string, int>)));
        }

        [Test]
        public void 三要素のタプルが生成できる()
        {
            var t = Tpl.Of(0, 1, default(object));
            Assert.That(t.GetType(), Is.EqualTo(typeof(_<int, int, object>)));
        }

        [Test]
        public void 二要素のタプルから先頭要素を取り出せる()
        {
            var t = Tpl.Of(10, "aaa");
            Assert.That(t._1, Is.EqualTo(10));
        }

        [Test]
        public void 二要素のタプルから末尾要素を取り出せる()
        {
            var t = Tpl.Of(10, "aaa");
            Assert.That(t._2, Is.EqualTo("aaa"));
        }

        [Test]
        public void 二要素のタプルから3つ目の要素は取り出せない()
        {
            var t = Tpl.Of(10, "aaa");
            var type = typeof(_<int, string>);
            Assert.That(
                type.GetField("_2"), Is.Not.Null);
            Assert.That(
                type.GetField("_3"), Is.Null);
        }

        [Test]
        public void 三要素のタプルから先頭要素を取り出せる()
        {
            var t = Tpl.Of("aaa", 1, new DateTime(2010, 12, 23));
            Assert.That(t._1, Is.EqualTo("aaa"));
        }

        [Test]
        public void 三要素のタプルから中央要素を取り出せる()
        {
            var t = Tpl.Of("aaa", 1, new DateTime(2010, 12, 23));
            Assert.That(t._2, Is.EqualTo(1));
        }

        [Test]
        public void 三要素のタプルから末尾要素を取り出せる()
        {
            var t = Tpl.Of("aaa", 1, new DateTime(2010, 12, 23));
            Assert.That(t._3, Is.EqualTo(new DateTime(2010, 12, 23)));
        }

        [Test]
        public void 三要素のタプルから4つ目の要素は取り出せない()
        {
            var t = Tpl.Of("aaa", 1, new DateTime(2010, 12, 23));
            var type = typeof(_<int, string, DateTime>);
            Assert.That(
                type.GetField("_2"), Is.Not.Null);
            Assert.That(
                type.GetField("_3"), Is.Not.Null);
            Assert.That(
                type.GetField("_4"), Is.Null);
        }

        [TestCase(10, 20, 10, 20, true)]
        [TestCase(10, 20, 20, 10, false)]
        [TestCase(10, 20, 10, 30, false)]
        [TestCase(10, 20, 30, 20, false)]
        public void 二要素のタプルの等値性をEqualsメソッドで判別できる(int a1, int a2, int b1, int b2, bool expected)
        {
            var a = Tpl.Of(a1, a2);
            var b = Tpl.Of(b1, b2);

            Assert.That(a.Equals(b), Is.EqualTo(expected));
        }

        [TestCase(10, 20, 10, 20, true)]
        [TestCase(10, 20, 20, 10, false)]
        [TestCase(10, 20, 10, 30, false)]
        [TestCase(10, 20, 30, 20, false)]
        public void 二要素のタプルの等値性を演算子で判別できる(int a1, int a2, int b1, int b2, bool expected)
        {
            var a = Tpl.Of(a1, a2);
            var b = Tpl.Of(b1, b2);

            Assert.That(a == b, Is.EqualTo(expected));
            Assert.That(a != b, Is.Not.EqualTo(expected));
        }

        [TestCase(10, 20, 30, 10, 20, 30, true)]
        [TestCase(10, 20, 30, 1, 2, 3, false)]
        [TestCase(10, 20, 30, 20, 10, 30, false)]
        [TestCase(10, 20, 30, 10, 30, 20, false)]
        [TestCase(10, 20, 30, 30, 20, 10, false)]
        public void 三要素のタプルの等値性をEqualsメソッドで判別できる(int a1, int a2, int a3, int b1, int b2, int b3, bool expected)
        {
            var a = Tpl.Of(a1, a2, a3);
            var b = Tpl.Of(b1, b2, b3);

            Assert.That(a.Equals(b), Is.EqualTo(expected));
        }

        [TestCase(10, 20, 30, 10, 20, 30, true)]
        [TestCase(10, 20, 30, 1, 2, 3, false)]
        [TestCase(10, 20, 30, 20, 10, 30, false)]
        [TestCase(10, 20, 30, 10, 30, 20, false)]
        [TestCase(10, 20, 30, 30, 20, 10, false)]
        public void 三要素のタプルの等値性を演算子で判別できる(int a1, int a2, int a3, int b1, int b2, int b3, bool expected)
        {
            var a = Tpl.Of(a1, a2, a3);
            var b = Tpl.Of(b1, b2, b3);

            Assert.That(a == b, Is.EqualTo(expected));
            Assert.That(a != b, Is.Not.EqualTo(expected));
        }

        [TestCase(null, null)]
        [TestCase(10, 20)]
        [TestCase(null, 20)]
        [TestCase(0, 0)]
        [TestCase(10, null)]
        [TestCase(0, 10)]
        public void 二要素タプルのハッシュ値が計算できる(object a, object b)
        {
            var t = Tpl.Of(a, b);
            var expected = 31 ^ (a == null ? 0 : a.GetHashCode()) ^ (b == null ? 0 : b.GetHashCode());
            Assert.That(t.GetHashCode(), Is.EqualTo(expected));
        }

        [TestCase(null, null, null)]
        [TestCase(10, 20, 30)]
        [TestCase(null, 20, 30)]
        [TestCase(0, 0, 0)]
        [TestCase(10, null, null)]
        [TestCase(0, 10, 0)]
        public void 三要素タプルのハッシュ値が計算できる(object a, object b, object c)
        {
            var t = Tpl.Of(a, b, c);
            var expected = 31 ^ (a == null ? 0 : a.GetHashCode()) ^ (b == null ? 0 : b.GetHashCode()) ^ (c == null ? 0 : c.GetHashCode());
            Assert.That(t.GetHashCode(), Is.EqualTo(expected));
        }

        [Test]
        public void 二要素タプルを文字列表現に変換できる()
        {
            var t = Tpl.Of(10, "hoge");
            Assert.That(t.ToString(), Is.EqualTo("(10, hoge)"));
        }

        [Test]
        public void 三要素タプルを文字列表現に変換できる()
        {
            var t = Tpl.Of("aaa", "bbb", "ccc");
            Assert.That(t.ToString(), Is.EqualTo("(aaa, bbb, ccc)"));
        }
    }
}
