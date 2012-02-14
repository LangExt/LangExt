using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using LangExt.Dragon;

namespace LangExt.Test.Dragon
{
    [TestFixture]
    class LinqTest_Aggregate
    {
        static bool IsInt(string str)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(str, @"\d+");
        }

        [Test]
        public void 二要素のタプルをドラゴンパターンマッチした結果と自分でばらした結果が同じになる()
        {
            var ts = new[] { Tpl.Of(10, "aa"), Tpl.Of(20, "2"), Tpl.Of(30, "1") };

            Assert.That(
                ts.Aggregate(0, (a, i, s) => a + (IsInt(s) ? i + int.Parse(s) : 0)),
                Is.EqualTo(ts.Aggregate(0, (a, t) => a + (IsInt(t._2) ? t._1 + int.Parse(t._2) : 0))));
        }

        [Test]
        public void 二要素のタプルをドラゴンパターンマッチして変換した結果と自分でばらして変換した結果が同じになる()
        {
            var ts = new[] { Tpl.Of(10, "aa"), Tpl.Of(20, "2"), Tpl.Of(30, "1") };

            Assert.That(
                ts.Aggregate(new StringBuilder(), (a, i, s) => IsInt(s) ? a.Append(s) : a.Append(i), a => int.Parse(a.ToString())),
                Is.EqualTo(ts.Aggregate(new StringBuilder(), (a, t) => IsInt(t._2) ? a.Append(t._2) : a.Append(t._1), a => int.Parse(a.ToString()))));
        }

        [Test]
        public void 三要素のタプルをドラゴンパターンマッチした結果と自分でばらした結果が同じになる()
        {
            var ts = new[] { Tpl.Of(10, "aa", 1), Tpl.Of(20, "2", 0), Tpl.Of(30, "1", 1) };

            Assert.That(
                ts.Aggregate(0, (a, i, s, j) => a + (IsInt(s) ? i + int.Parse(s) : 0) * j),
                Is.EqualTo(ts.Aggregate(0, (a, t) => a + (IsInt(t._2) ? t._1 + int.Parse(t._2) : 0) * t._3)));
        }

        [Test]
        public void 三要素のタプルをドラゴンパターンマッチして変換した結果と自分でばらして変換した結果が同じになる()
        {
            var ts = new[] { Tpl.Of(10, "aa", 1), Tpl.Of(20, "2", 0), Tpl.Of(30, "1", 1) };

            Assert.That(
                ts.Aggregate(new StringBuilder(), (a, i, s, j) => IsInt(s) ? a.Append(s) : a.Append(i + j), a => int.Parse(a.ToString())),
                Is.EqualTo(ts.Aggregate(new StringBuilder(), (a, t) => IsInt(t._2) ? a.Append(t._2) : a.Append(t._1 + t._3), a => int.Parse(a.ToString()))));
        }
    }
}
