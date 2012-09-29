using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LangExt.Test
{
    [TestFixture]
    class VariantTest
    {
        static R Fail<A, R>(A _) { throw new Exception(); }

        static T Id<T>(T t) { return t; }

        [Test]
        public void intとstringからなるVariantに数値を入れると数値が取り出せる()
        {
            Variant<int, string> v = 12;
            Assert.That(v.Match(Id, Fail<string, int>), Is.EqualTo(12));
        }

        [Test]
        public void stringとintからなるVariantに数値を入れると数値が取り出せる()
        {
            Variant<string, int> v = 12;
            Assert.That(v.Match(Fail<string, int>, Id), Is.EqualTo(12));
        }

        [Test]
        public void intとstringからなるVariantに文字列を入れると文字列が取り出せる()
        {
            Variant<int, string> v = "hoge";
            Assert.That(v.Match(Fail<int, string>, Id), Is.EqualTo("hoge"));
        }

        [Test]
        public void stringとintからなるVariantに文字列を入れると文字列が取り出せる()
        {
            Variant<string, int> v = "hoge";
            Assert.That(v.Match(Id, Fail<int, string>), Is.EqualTo("hoge"));
        }

        [Test]
        public void intとstringとobjectからなるVariantに数値を入れると数値が取り出せる()
        {
            Variant<int, string, object> v = 12;
            Assert.That(v.Match(Id, Fail<string, int>, Fail<object, int>), Is.EqualTo(12));
        }

        [Test]
        public void intとstringとobjectからなるVariantに文字列を入れると文字列が取り出せる()
        {
            Variant<int, string, object> v = "hoge";
            Assert.That(v.Match(Fail<int, string>, Id, Fail<object, string>), Is.EqualTo("hoge"));
        }

        [Test]
        public void intとstringとobjectからなるVariantにオブジェクトを入れるとオブジェクトが取り出せる()
        {
            var obj = new object();
            Variant<int, string, object> v = obj;
            Assert.That(v.Match(Fail<int, object>, Fail<string, object>, Id), Is.EqualTo(obj));
        }

        [Test]
        public void intとobjectとstringからなるVariantに文字列を入れると文字列が取り出せる()
        {
            Variant<int, object, string> v = "hoge";
            Assert.That(v.Match(Fail<int, string>, Fail<object, string>, s => s), Is.EqualTo("hoge"));
        }

        [Test]
        public void intとobjectとstringからなるVariantにオブジェクトを入れるとオブジェクトが取り出せる()
        {
            var obj = new object();
            Variant<int, object, string> v = obj;
            Assert.That(v.Match(Fail<int, object>, o => o, Fail<string, object>), Is.EqualTo(obj));
        }
    }
}
