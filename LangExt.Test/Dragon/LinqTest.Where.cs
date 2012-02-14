using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using LangExt.Dragon;

namespace LangExt.Test.Dragon
{
    [TestFixture]
    class LinqTest_Where
    {
        [Test]
        public void 二要素のタプルをドラゴンパターンマッチした結果と自分でばらした結果が同じになる()
        {
            var ts = new[] { Tpl.Of(10, "aa"), Tpl.Of(20, "2"), Tpl.Of(30, "1") };

            Assert.That(
                ts.Where((i, s) => i < 30 && s.Length == 1).ToArray(),
                Is.EqualTo(ts.Where(t => t._1 < 30 && t._2.Length == 1).ToArray()));
        }

        [Test]
        public void 二要素のタプルのドラゴンパターンマッチにインデックスを付けることができる()
        {
            var ts = new[] { Tpl.Of(10, "aa"), Tpl.Of(20, "2"), Tpl.Of(30, "1") };

            Assert.That(
                ts.Where((i, s, j) => i < 30 && s.Length + j == 1).ToArray(),
                Is.EqualTo(ts.Where((t, i) => t._1 < 30 && t._2.Length + i == 1).ToArray()));
        }

        [Test]
        public void 三要素のタプルをドラゴンパターンマッチした結果と自分でばらした結果が同じになる()
        {
            var ts = new[] { Tpl.Of(10, "aa", 1), Tpl.Of(20, "2", 1), Tpl.Of(30, "1", 1) };

            Assert.That(
                ts.Where((i, s, j) => i < 30 && s.Length + j == 2).ToArray(),
                Is.EqualTo(ts.Where(t => t._1 < 30 && t._2.Length + t._3 == 2).ToArray()));
        }

        [Test]
        public void 三要素のタプルのドラゴンパターンマッチにインデックスを付けることができる()
        {
            var ts = new[] { Tpl.Of(10, "aa", 1), Tpl.Of(20, "2", 1), Tpl.Of(30, "1", 1) };

            Assert.That(
                ts.Where((i, s, j, k) => i < 30 && s.Length + j + k == 2).ToArray(),
                Is.EqualTo(ts.Where((t, i) => t._1 < 30 && t._2.Length + t._3 + i == 2).ToArray()));
        }
    }
}
