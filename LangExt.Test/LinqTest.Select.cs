using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using LangExt.Dragon;

namespace LangExt.Test.Dragon
{
    [TestFixture]
    class LinqTest
    {
        [Test]
        public void ドラゴンパターンマッチした結果と自分でばらした結果が同じになる()
        {
            var ts = new[] { Tpl.Of(10, "3"), Tpl.Of(20, "2"), Tpl.Of(30, "1") };

            Assert.That(
                ts.Select((i, s) => i + int.Parse(s)).ToArray(),
                Is.EqualTo(ts.Select(t => t._1 + int.Parse(t._2)).ToArray()));
        }

        [Test]
        public void ドラゴンパターンマッチにインデックスを付けることができる()
        {
            var ts = new[] { Tpl.Of(10, "3"), Tpl.Of(20, "2"), Tpl.Of(30, "1") };

            Assert.That(
                ts.Select((i, s, j) => i + int.Parse(s) + j).ToArray(),
                Is.EqualTo(ts.Select((t, i) => t._1 + int.Parse(t._2) + i).ToArray()));
        }
    }
}
