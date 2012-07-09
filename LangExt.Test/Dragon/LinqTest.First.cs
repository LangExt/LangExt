using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using LangExt.Dragon;

namespace LangExt.Test.Dragon
{
    [TestFixture]
    class LinqTest_First
    {
        [Test]
        public void 二要素のタプルをドラゴンパターンマッチした結果と自分でばらした結果が同じになる()
        {
            var ts = new[] { Tpl.Of(10, "aa"), Tpl.Of(20, "2"), Tpl.Of(30, "1"), Tpl.Of(25, "2") };
            
            Assert.That(ts.First((i, s) => i < 30 && s.Length == 1), Is.EqualTo(Tpl.Of(20, "2")));
            Assert.That(ts.FirstOrDefault((i, s) => i < 30 && s.Length == 1), Is.EqualTo(Tpl.Of(20, "2")));

            Assert.That(
                ts.First((i, s) => i < 30 && s.Length == 1),
                Is.EqualTo(Enumerable.First(ts, t => t._1 < 30 && t._2.Length == 1)));
            Assert.That(
                ts.FirstOrDefault((i, s) => i < 30 && s.Length == 1),
                Is.EqualTo(ts.FirstOrDefault(t => t._1 < 30 && t._2.Length == 1)));
        }

        [Test]
        public void 三要素のタプルをドラゴンパターンマッチした結果と自分でばらした結果が同じになる()
        {
            var ts = new[] { Tpl.Of(10, "aa", 1), Tpl.Of(20, "2", 1), Tpl.Of(30, "1", 1), Tpl.Of(25, "2", 1) };

            Assert.That(ts.First((i, s, j) => i < 30 && s.Length + j == 2), Is.EqualTo(Tpl.Of(20, "2", 1)));
            Assert.That(ts.FirstOrDefault((i, s, j) => i < 30 && s.Length + j == 2), Is.EqualTo(Tpl.Of(20, "2", 1)));

            Assert.That(
                ts.First((i, s, j) => i < 30 && s.Length + j == 2),
                Is.EqualTo(Enumerable.First(ts, t => t._1 < 30 && t._2.Length + t._3 == 2)));
            Assert.That(
                ts.FirstOrDefault((i, s, j) => i < 30 && s.Length + j == 2),
                Is.EqualTo(ts.FirstOrDefault(t => t._1 < 30 && t._2.Length + t._3 == 2)));
        }

        [Test]
        public void Firstを使って見つからなかった場合例外が送出される()
        {
            var ints = new[] { 10, 20, 30 };
            var strs = new[] { "aa", "2", "1" };
            var t2s = ints.Zip(strs);
            var t3s = ints.Zip(strs, Enumerable.Repeat(1, int.MaxValue));

            try
            {
                var _ = t2s.First((i, s) => i > 100);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                // OK
            }
            try
            {
                var _ = t3s.First((i, s, j) => i > 100);
                Assert.Fail();
            }
            catch (InvalidOperationException)
            {
                // OK
            }
        }

        [Test]
        public void FirstOrDefaultを使って見つからなかった場合デフォルト値が返される()
        {
            var ints = new[] { 10, 20, 30 };
            var strs = new[] { "aa", "2", "1" };
            var t2s = ints.Zip(strs);
            var t3s = ints.Zip(strs, Enumerable.Repeat(1, int.MaxValue));

            Assert.That(t2s.FirstOrDefault((i, s) => i > 100), Is.EqualTo(default(_<int, string>)));
            Assert.That(t3s.FirstOrDefault((i, s, j) => i > 100), Is.EqualTo(default(_<int, string, int>)));
        }
    }
}
