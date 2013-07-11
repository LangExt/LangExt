
using System;
using LangExt;
using NUnit.Framework;
using Microsoft.CSharp.RuntimeBinder;

namespace LangExt.Tests
{
    [TestFixture]
    public class TupleModuleTest
    {
#region Create.Tuple / TupleModule.Create / _1() ... _16()
        [Test]
        public void _16要素タプルの1番目の要素にアクセスできる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.That(tpl._1(), Is.EqualTo(1));
        }

        [Test]
        public void _16要素タプルの2番目の要素にアクセスできる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.That(tpl._2(), Is.EqualTo(2));
        }

        [Test]
        public void _16要素タプルの3番目の要素にアクセスできる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.That(tpl._3(), Is.EqualTo(3));
        }

        [Test]
        public void _16要素タプルの4番目の要素にアクセスできる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.That(tpl._4(), Is.EqualTo(4));
        }

        [Test]
        public void _16要素タプルの5番目の要素にアクセスできる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.That(tpl._5(), Is.EqualTo(5));
        }

        [Test]
        public void _16要素タプルの6番目の要素にアクセスできる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.That(tpl._6(), Is.EqualTo(6));
        }

        [Test]
        public void _16要素タプルの7番目の要素にアクセスできる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.That(tpl._7(), Is.EqualTo(7));
        }

        [Test]
        public void _16要素タプルの8番目の要素にアクセスできる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.That(tpl._8(), Is.EqualTo(8));
        }

        [Test]
        public void _16要素タプルの9番目の要素にアクセスできる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.That(tpl._9(), Is.EqualTo(9));
        }

        [Test]
        public void _16要素タプルの10番目の要素にアクセスできる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.That(tpl._10(), Is.EqualTo(10));
        }

        [Test]
        public void _16要素タプルの11番目の要素にアクセスできる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.That(tpl._11(), Is.EqualTo(11));
        }

        [Test]
        public void _16要素タプルの12番目の要素にアクセスできる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.That(tpl._12(), Is.EqualTo(12));
        }

        [Test]
        public void _16要素タプルの13番目の要素にアクセスできる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.That(tpl._13(), Is.EqualTo(13));
        }

        [Test]
        public void _16要素タプルの14番目の要素にアクセスできる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.That(tpl._14(), Is.EqualTo(14));
        }

        [Test]
        public void _16要素タプルの15番目の要素にアクセスできる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.That(tpl._15(), Is.EqualTo(15));
        }

        [Test]
        public void _16要素タプルの16番目の要素にアクセスできる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.That(tpl._16(), Is.EqualTo(16));
        }

#endregion

#region Add / RemoveLast
        [Test]
        public void _2要素タプルにはRemoveLastが存在しない()
        {
            dynamic pair = Create.Tuple(1, 2);
            try
            {
                var _ = pair.RemoveLast();
                Assert.Fail();
            }
            catch (RuntimeBinderException)
            {
                Assert.Pass();
            }
        }

        [Test]
        public void _16要素タプルにはAddが存在しない()
        {
            dynamic tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            try
            {
                var _ = tpl.Add("hoge");
                Assert.Fail();
            }
            catch (RuntimeBinderException)
            {
                Assert.Pass();
            }
        }
#endregion

#region AddFirst / RemoveFirst
        [Test]
        public void _2要素タプルにはRemoveFirstが存在しない()
        {
            dynamic pair = Create.Tuple(1, 2);
            try
            {
                var _ = pair.RemoveFirst();
                Assert.Fail();
            }
            catch (RuntimeBinderException)
            {
                Assert.Pass();
            }
        }

        [Test]
        public void _16要素タプルにはAddFirstが存在しない()
        {
            dynamic tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            try
            {
                var _ = tpl.AddFirst("hoge");
                Assert.Fail();
            }
            catch (RuntimeBinderException)
            {
                Assert.Pass();
            }
        }
#endregion

#region Match
        [Test]
        public void _16要素タプルをMatchさせると1番目の引数に1番目の要素が入ってくる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.That(
            tpl.Match((t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => t1),
            Is.EqualTo(1));
        }

        [Test]
        public void _16要素タプルをMatchさせると2番目の引数に2番目の要素が入ってくる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.That(
            tpl.Match((t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => t2),
            Is.EqualTo(2));
        }

        [Test]
        public void _16要素タプルをMatchさせると3番目の引数に3番目の要素が入ってくる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.That(
            tpl.Match((t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => t3),
            Is.EqualTo(3));
        }

        [Test]
        public void _16要素タプルをMatchさせると4番目の引数に4番目の要素が入ってくる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.That(
            tpl.Match((t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => t4),
            Is.EqualTo(4));
        }

        [Test]
        public void _16要素タプルをMatchさせると5番目の引数に5番目の要素が入ってくる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.That(
            tpl.Match((t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => t5),
            Is.EqualTo(5));
        }

        [Test]
        public void _16要素タプルをMatchさせると6番目の引数に6番目の要素が入ってくる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.That(
            tpl.Match((t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => t6),
            Is.EqualTo(6));
        }

        [Test]
        public void _16要素タプルをMatchさせると7番目の引数に7番目の要素が入ってくる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.That(
            tpl.Match((t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => t7),
            Is.EqualTo(7));
        }

        [Test]
        public void _16要素タプルをMatchさせると8番目の引数に8番目の要素が入ってくる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.That(
            tpl.Match((t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => t8),
            Is.EqualTo(8));
        }

        [Test]
        public void _16要素タプルをMatchさせると9番目の引数に9番目の要素が入ってくる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.That(
            tpl.Match((t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => t9),
            Is.EqualTo(9));
        }

        [Test]
        public void _16要素タプルをMatchさせると10番目の引数に10番目の要素が入ってくる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.That(
            tpl.Match((t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => t10),
            Is.EqualTo(10));
        }

        [Test]
        public void _16要素タプルをMatchさせると11番目の引数に11番目の要素が入ってくる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.That(
            tpl.Match((t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => t11),
            Is.EqualTo(11));
        }

        [Test]
        public void _16要素タプルをMatchさせると12番目の引数に12番目の要素が入ってくる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.That(
            tpl.Match((t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => t12),
            Is.EqualTo(12));
        }

        [Test]
        public void _16要素タプルをMatchさせると13番目の引数に13番目の要素が入ってくる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.That(
            tpl.Match((t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => t13),
            Is.EqualTo(13));
        }

        [Test]
        public void _16要素タプルをMatchさせると14番目の引数に14番目の要素が入ってくる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.That(
            tpl.Match((t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => t14),
            Is.EqualTo(14));
        }

        [Test]
        public void _16要素タプルをMatchさせると15番目の引数に15番目の要素が入ってくる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.That(
            tpl.Match((t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => t15),
            Is.EqualTo(15));
        }

        [Test]
        public void _16要素タプルをMatchさせると16番目の引数に16番目の要素が入ってくる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.That(
            tpl.Match((t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) => t16),
            Is.EqualTo(16));
        }

#endregion

#region Map1 ... Map16
        [Test]
        public void _16要素タプルの1番目の要素に対してMapできる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            var mapped = tpl.Map1(x => x * 2);
        
            Assert.That(mapped._1(), Is.EqualTo(1 * 2));
            Assert.That(mapped._2(), Is.EqualTo(2));
            Assert.That(mapped._3(), Is.EqualTo(3));
            Assert.That(mapped._4(), Is.EqualTo(4));
            Assert.That(mapped._5(), Is.EqualTo(5));
            Assert.That(mapped._6(), Is.EqualTo(6));
            Assert.That(mapped._7(), Is.EqualTo(7));
            Assert.That(mapped._8(), Is.EqualTo(8));
            Assert.That(mapped._9(), Is.EqualTo(9));
            Assert.That(mapped._10(), Is.EqualTo(10));
            Assert.That(mapped._11(), Is.EqualTo(11));
            Assert.That(mapped._12(), Is.EqualTo(12));
            Assert.That(mapped._13(), Is.EqualTo(13));
            Assert.That(mapped._14(), Is.EqualTo(14));
            Assert.That(mapped._15(), Is.EqualTo(15));
            Assert.That(mapped._16(), Is.EqualTo(16));
        }

        [Test]
        public void _16要素タプルの2番目の要素に対してMapできる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            var mapped = tpl.Map2(x => x * 2);
        
            Assert.That(mapped._2(), Is.EqualTo(2 * 2));
            Assert.That(mapped._1(), Is.EqualTo(1));
            Assert.That(mapped._3(), Is.EqualTo(3));
            Assert.That(mapped._4(), Is.EqualTo(4));
            Assert.That(mapped._5(), Is.EqualTo(5));
            Assert.That(mapped._6(), Is.EqualTo(6));
            Assert.That(mapped._7(), Is.EqualTo(7));
            Assert.That(mapped._8(), Is.EqualTo(8));
            Assert.That(mapped._9(), Is.EqualTo(9));
            Assert.That(mapped._10(), Is.EqualTo(10));
            Assert.That(mapped._11(), Is.EqualTo(11));
            Assert.That(mapped._12(), Is.EqualTo(12));
            Assert.That(mapped._13(), Is.EqualTo(13));
            Assert.That(mapped._14(), Is.EqualTo(14));
            Assert.That(mapped._15(), Is.EqualTo(15));
            Assert.That(mapped._16(), Is.EqualTo(16));
        }

        [Test]
        public void _16要素タプルの3番目の要素に対してMapできる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            var mapped = tpl.Map3(x => x * 2);
        
            Assert.That(mapped._3(), Is.EqualTo(3 * 2));
            Assert.That(mapped._1(), Is.EqualTo(1));
            Assert.That(mapped._2(), Is.EqualTo(2));
            Assert.That(mapped._4(), Is.EqualTo(4));
            Assert.That(mapped._5(), Is.EqualTo(5));
            Assert.That(mapped._6(), Is.EqualTo(6));
            Assert.That(mapped._7(), Is.EqualTo(7));
            Assert.That(mapped._8(), Is.EqualTo(8));
            Assert.That(mapped._9(), Is.EqualTo(9));
            Assert.That(mapped._10(), Is.EqualTo(10));
            Assert.That(mapped._11(), Is.EqualTo(11));
            Assert.That(mapped._12(), Is.EqualTo(12));
            Assert.That(mapped._13(), Is.EqualTo(13));
            Assert.That(mapped._14(), Is.EqualTo(14));
            Assert.That(mapped._15(), Is.EqualTo(15));
            Assert.That(mapped._16(), Is.EqualTo(16));
        }

        [Test]
        public void _16要素タプルの4番目の要素に対してMapできる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            var mapped = tpl.Map4(x => x * 2);
        
            Assert.That(mapped._4(), Is.EqualTo(4 * 2));
            Assert.That(mapped._1(), Is.EqualTo(1));
            Assert.That(mapped._2(), Is.EqualTo(2));
            Assert.That(mapped._3(), Is.EqualTo(3));
            Assert.That(mapped._5(), Is.EqualTo(5));
            Assert.That(mapped._6(), Is.EqualTo(6));
            Assert.That(mapped._7(), Is.EqualTo(7));
            Assert.That(mapped._8(), Is.EqualTo(8));
            Assert.That(mapped._9(), Is.EqualTo(9));
            Assert.That(mapped._10(), Is.EqualTo(10));
            Assert.That(mapped._11(), Is.EqualTo(11));
            Assert.That(mapped._12(), Is.EqualTo(12));
            Assert.That(mapped._13(), Is.EqualTo(13));
            Assert.That(mapped._14(), Is.EqualTo(14));
            Assert.That(mapped._15(), Is.EqualTo(15));
            Assert.That(mapped._16(), Is.EqualTo(16));
        }

        [Test]
        public void _16要素タプルの5番目の要素に対してMapできる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            var mapped = tpl.Map5(x => x * 2);
        
            Assert.That(mapped._5(), Is.EqualTo(5 * 2));
            Assert.That(mapped._1(), Is.EqualTo(1));
            Assert.That(mapped._2(), Is.EqualTo(2));
            Assert.That(mapped._3(), Is.EqualTo(3));
            Assert.That(mapped._4(), Is.EqualTo(4));
            Assert.That(mapped._6(), Is.EqualTo(6));
            Assert.That(mapped._7(), Is.EqualTo(7));
            Assert.That(mapped._8(), Is.EqualTo(8));
            Assert.That(mapped._9(), Is.EqualTo(9));
            Assert.That(mapped._10(), Is.EqualTo(10));
            Assert.That(mapped._11(), Is.EqualTo(11));
            Assert.That(mapped._12(), Is.EqualTo(12));
            Assert.That(mapped._13(), Is.EqualTo(13));
            Assert.That(mapped._14(), Is.EqualTo(14));
            Assert.That(mapped._15(), Is.EqualTo(15));
            Assert.That(mapped._16(), Is.EqualTo(16));
        }

        [Test]
        public void _16要素タプルの6番目の要素に対してMapできる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            var mapped = tpl.Map6(x => x * 2);
        
            Assert.That(mapped._6(), Is.EqualTo(6 * 2));
            Assert.That(mapped._1(), Is.EqualTo(1));
            Assert.That(mapped._2(), Is.EqualTo(2));
            Assert.That(mapped._3(), Is.EqualTo(3));
            Assert.That(mapped._4(), Is.EqualTo(4));
            Assert.That(mapped._5(), Is.EqualTo(5));
            Assert.That(mapped._7(), Is.EqualTo(7));
            Assert.That(mapped._8(), Is.EqualTo(8));
            Assert.That(mapped._9(), Is.EqualTo(9));
            Assert.That(mapped._10(), Is.EqualTo(10));
            Assert.That(mapped._11(), Is.EqualTo(11));
            Assert.That(mapped._12(), Is.EqualTo(12));
            Assert.That(mapped._13(), Is.EqualTo(13));
            Assert.That(mapped._14(), Is.EqualTo(14));
            Assert.That(mapped._15(), Is.EqualTo(15));
            Assert.That(mapped._16(), Is.EqualTo(16));
        }

        [Test]
        public void _16要素タプルの7番目の要素に対してMapできる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            var mapped = tpl.Map7(x => x * 2);
        
            Assert.That(mapped._7(), Is.EqualTo(7 * 2));
            Assert.That(mapped._1(), Is.EqualTo(1));
            Assert.That(mapped._2(), Is.EqualTo(2));
            Assert.That(mapped._3(), Is.EqualTo(3));
            Assert.That(mapped._4(), Is.EqualTo(4));
            Assert.That(mapped._5(), Is.EqualTo(5));
            Assert.That(mapped._6(), Is.EqualTo(6));
            Assert.That(mapped._8(), Is.EqualTo(8));
            Assert.That(mapped._9(), Is.EqualTo(9));
            Assert.That(mapped._10(), Is.EqualTo(10));
            Assert.That(mapped._11(), Is.EqualTo(11));
            Assert.That(mapped._12(), Is.EqualTo(12));
            Assert.That(mapped._13(), Is.EqualTo(13));
            Assert.That(mapped._14(), Is.EqualTo(14));
            Assert.That(mapped._15(), Is.EqualTo(15));
            Assert.That(mapped._16(), Is.EqualTo(16));
        }

        [Test]
        public void _16要素タプルの8番目の要素に対してMapできる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            var mapped = tpl.Map8(x => x * 2);
        
            Assert.That(mapped._8(), Is.EqualTo(8 * 2));
            Assert.That(mapped._1(), Is.EqualTo(1));
            Assert.That(mapped._2(), Is.EqualTo(2));
            Assert.That(mapped._3(), Is.EqualTo(3));
            Assert.That(mapped._4(), Is.EqualTo(4));
            Assert.That(mapped._5(), Is.EqualTo(5));
            Assert.That(mapped._6(), Is.EqualTo(6));
            Assert.That(mapped._7(), Is.EqualTo(7));
            Assert.That(mapped._9(), Is.EqualTo(9));
            Assert.That(mapped._10(), Is.EqualTo(10));
            Assert.That(mapped._11(), Is.EqualTo(11));
            Assert.That(mapped._12(), Is.EqualTo(12));
            Assert.That(mapped._13(), Is.EqualTo(13));
            Assert.That(mapped._14(), Is.EqualTo(14));
            Assert.That(mapped._15(), Is.EqualTo(15));
            Assert.That(mapped._16(), Is.EqualTo(16));
        }

        [Test]
        public void _16要素タプルの9番目の要素に対してMapできる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            var mapped = tpl.Map9(x => x * 2);
        
            Assert.That(mapped._9(), Is.EqualTo(9 * 2));
            Assert.That(mapped._1(), Is.EqualTo(1));
            Assert.That(mapped._2(), Is.EqualTo(2));
            Assert.That(mapped._3(), Is.EqualTo(3));
            Assert.That(mapped._4(), Is.EqualTo(4));
            Assert.That(mapped._5(), Is.EqualTo(5));
            Assert.That(mapped._6(), Is.EqualTo(6));
            Assert.That(mapped._7(), Is.EqualTo(7));
            Assert.That(mapped._8(), Is.EqualTo(8));
            Assert.That(mapped._10(), Is.EqualTo(10));
            Assert.That(mapped._11(), Is.EqualTo(11));
            Assert.That(mapped._12(), Is.EqualTo(12));
            Assert.That(mapped._13(), Is.EqualTo(13));
            Assert.That(mapped._14(), Is.EqualTo(14));
            Assert.That(mapped._15(), Is.EqualTo(15));
            Assert.That(mapped._16(), Is.EqualTo(16));
        }

        [Test]
        public void _16要素タプルの10番目の要素に対してMapできる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            var mapped = tpl.Map10(x => x * 2);
        
            Assert.That(mapped._10(), Is.EqualTo(10 * 2));
            Assert.That(mapped._1(), Is.EqualTo(1));
            Assert.That(mapped._2(), Is.EqualTo(2));
            Assert.That(mapped._3(), Is.EqualTo(3));
            Assert.That(mapped._4(), Is.EqualTo(4));
            Assert.That(mapped._5(), Is.EqualTo(5));
            Assert.That(mapped._6(), Is.EqualTo(6));
            Assert.That(mapped._7(), Is.EqualTo(7));
            Assert.That(mapped._8(), Is.EqualTo(8));
            Assert.That(mapped._9(), Is.EqualTo(9));
            Assert.That(mapped._11(), Is.EqualTo(11));
            Assert.That(mapped._12(), Is.EqualTo(12));
            Assert.That(mapped._13(), Is.EqualTo(13));
            Assert.That(mapped._14(), Is.EqualTo(14));
            Assert.That(mapped._15(), Is.EqualTo(15));
            Assert.That(mapped._16(), Is.EqualTo(16));
        }

        [Test]
        public void _16要素タプルの11番目の要素に対してMapできる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            var mapped = tpl.Map11(x => x * 2);
        
            Assert.That(mapped._11(), Is.EqualTo(11 * 2));
            Assert.That(mapped._1(), Is.EqualTo(1));
            Assert.That(mapped._2(), Is.EqualTo(2));
            Assert.That(mapped._3(), Is.EqualTo(3));
            Assert.That(mapped._4(), Is.EqualTo(4));
            Assert.That(mapped._5(), Is.EqualTo(5));
            Assert.That(mapped._6(), Is.EqualTo(6));
            Assert.That(mapped._7(), Is.EqualTo(7));
            Assert.That(mapped._8(), Is.EqualTo(8));
            Assert.That(mapped._9(), Is.EqualTo(9));
            Assert.That(mapped._10(), Is.EqualTo(10));
            Assert.That(mapped._12(), Is.EqualTo(12));
            Assert.That(mapped._13(), Is.EqualTo(13));
            Assert.That(mapped._14(), Is.EqualTo(14));
            Assert.That(mapped._15(), Is.EqualTo(15));
            Assert.That(mapped._16(), Is.EqualTo(16));
        }

        [Test]
        public void _16要素タプルの12番目の要素に対してMapできる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            var mapped = tpl.Map12(x => x * 2);
        
            Assert.That(mapped._12(), Is.EqualTo(12 * 2));
            Assert.That(mapped._1(), Is.EqualTo(1));
            Assert.That(mapped._2(), Is.EqualTo(2));
            Assert.That(mapped._3(), Is.EqualTo(3));
            Assert.That(mapped._4(), Is.EqualTo(4));
            Assert.That(mapped._5(), Is.EqualTo(5));
            Assert.That(mapped._6(), Is.EqualTo(6));
            Assert.That(mapped._7(), Is.EqualTo(7));
            Assert.That(mapped._8(), Is.EqualTo(8));
            Assert.That(mapped._9(), Is.EqualTo(9));
            Assert.That(mapped._10(), Is.EqualTo(10));
            Assert.That(mapped._11(), Is.EqualTo(11));
            Assert.That(mapped._13(), Is.EqualTo(13));
            Assert.That(mapped._14(), Is.EqualTo(14));
            Assert.That(mapped._15(), Is.EqualTo(15));
            Assert.That(mapped._16(), Is.EqualTo(16));
        }

        [Test]
        public void _16要素タプルの13番目の要素に対してMapできる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            var mapped = tpl.Map13(x => x * 2);
        
            Assert.That(mapped._13(), Is.EqualTo(13 * 2));
            Assert.That(mapped._1(), Is.EqualTo(1));
            Assert.That(mapped._2(), Is.EqualTo(2));
            Assert.That(mapped._3(), Is.EqualTo(3));
            Assert.That(mapped._4(), Is.EqualTo(4));
            Assert.That(mapped._5(), Is.EqualTo(5));
            Assert.That(mapped._6(), Is.EqualTo(6));
            Assert.That(mapped._7(), Is.EqualTo(7));
            Assert.That(mapped._8(), Is.EqualTo(8));
            Assert.That(mapped._9(), Is.EqualTo(9));
            Assert.That(mapped._10(), Is.EqualTo(10));
            Assert.That(mapped._11(), Is.EqualTo(11));
            Assert.That(mapped._12(), Is.EqualTo(12));
            Assert.That(mapped._14(), Is.EqualTo(14));
            Assert.That(mapped._15(), Is.EqualTo(15));
            Assert.That(mapped._16(), Is.EqualTo(16));
        }

        [Test]
        public void _16要素タプルの14番目の要素に対してMapできる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            var mapped = tpl.Map14(x => x * 2);
        
            Assert.That(mapped._14(), Is.EqualTo(14 * 2));
            Assert.That(mapped._1(), Is.EqualTo(1));
            Assert.That(mapped._2(), Is.EqualTo(2));
            Assert.That(mapped._3(), Is.EqualTo(3));
            Assert.That(mapped._4(), Is.EqualTo(4));
            Assert.That(mapped._5(), Is.EqualTo(5));
            Assert.That(mapped._6(), Is.EqualTo(6));
            Assert.That(mapped._7(), Is.EqualTo(7));
            Assert.That(mapped._8(), Is.EqualTo(8));
            Assert.That(mapped._9(), Is.EqualTo(9));
            Assert.That(mapped._10(), Is.EqualTo(10));
            Assert.That(mapped._11(), Is.EqualTo(11));
            Assert.That(mapped._12(), Is.EqualTo(12));
            Assert.That(mapped._13(), Is.EqualTo(13));
            Assert.That(mapped._15(), Is.EqualTo(15));
            Assert.That(mapped._16(), Is.EqualTo(16));
        }

        [Test]
        public void _16要素タプルの15番目の要素に対してMapできる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            var mapped = tpl.Map15(x => x * 2);
        
            Assert.That(mapped._15(), Is.EqualTo(15 * 2));
            Assert.That(mapped._1(), Is.EqualTo(1));
            Assert.That(mapped._2(), Is.EqualTo(2));
            Assert.That(mapped._3(), Is.EqualTo(3));
            Assert.That(mapped._4(), Is.EqualTo(4));
            Assert.That(mapped._5(), Is.EqualTo(5));
            Assert.That(mapped._6(), Is.EqualTo(6));
            Assert.That(mapped._7(), Is.EqualTo(7));
            Assert.That(mapped._8(), Is.EqualTo(8));
            Assert.That(mapped._9(), Is.EqualTo(9));
            Assert.That(mapped._10(), Is.EqualTo(10));
            Assert.That(mapped._11(), Is.EqualTo(11));
            Assert.That(mapped._12(), Is.EqualTo(12));
            Assert.That(mapped._13(), Is.EqualTo(13));
            Assert.That(mapped._14(), Is.EqualTo(14));
            Assert.That(mapped._16(), Is.EqualTo(16));
        }

        [Test]
        public void _16要素タプルの16番目の要素に対してMapできる()
        {
            var tpl = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            var mapped = tpl.Map16(x => x * 2);
        
            Assert.That(mapped._16(), Is.EqualTo(16 * 2));
            Assert.That(mapped._1(), Is.EqualTo(1));
            Assert.That(mapped._2(), Is.EqualTo(2));
            Assert.That(mapped._3(), Is.EqualTo(3));
            Assert.That(mapped._4(), Is.EqualTo(4));
            Assert.That(mapped._5(), Is.EqualTo(5));
            Assert.That(mapped._6(), Is.EqualTo(6));
            Assert.That(mapped._7(), Is.EqualTo(7));
            Assert.That(mapped._8(), Is.EqualTo(8));
            Assert.That(mapped._9(), Is.EqualTo(9));
            Assert.That(mapped._10(), Is.EqualTo(10));
            Assert.That(mapped._11(), Is.EqualTo(11));
            Assert.That(mapped._12(), Is.EqualTo(12));
            Assert.That(mapped._13(), Is.EqualTo(13));
            Assert.That(mapped._14(), Is.EqualTo(14));
            Assert.That(mapped._15(), Is.EqualTo(15));
        }

#endregion

#region その他のテスト
        [Test]
        public void その他のメソッドが呼び出せるかどうか()
        {
            // TODO : 位置によって型を変えたテストにする 

            var tpl2 = Create.Tuple(1, 2);
            Assert.That(tpl2.Fst(), Is.EqualTo(1));
            Assert.That(tpl2.Snd(), Is.EqualTo(2));
            Assert.That(tpl2.Map1(i => i + 1), Is.EqualTo(Create.Tuple(2, 2)));
            Assert.That(tpl2.Map2(i => i + 1), Is.EqualTo(Create.Tuple(1, 3)));
            Assert.That(tpl2._1(), Is.EqualTo(1));
            Assert.That(tpl2._2(), Is.EqualTo(2));
            Assert.That(tpl2.Match((i1, i2) => i1 + i2), Is.EqualTo(2 * (2 + 1) / 2));
            Assert.That(tpl2.Add(3), Is.EqualTo(Create.Tuple(1, 2, 3)));

            var tpl3 = Create.Tuple(1, 2, 3);
            Assert.That(tpl3.Fst(), Is.EqualTo(1));
            Assert.That(tpl3.Snd(), Is.EqualTo(2));
            Assert.That(tpl3.Map1(i => i + 1), Is.EqualTo(Create.Tuple(2, 2, 3)));
            Assert.That(tpl3.Map2(i => i + 1), Is.EqualTo(Create.Tuple(1, 3, 3)));
            Assert.That(tpl3.Map3(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 4)));
            Assert.That(tpl3._1(), Is.EqualTo(1));
            Assert.That(tpl3._2(), Is.EqualTo(2));
            Assert.That(tpl3._3(), Is.EqualTo(3));
            Assert.That(tpl3.Match((i1, i2, i3) => i1 + i2 + i3), Is.EqualTo(3 * (3 + 1) / 2));
            Assert.That(tpl3.Add(4), Is.EqualTo(Create.Tuple(1, 2, 3, 4)));
            Assert.That(tpl3.RemoveLast(), Is.EqualTo(Create.Tuple(1, 2)));

            var tpl4 = Create.Tuple(1, 2, 3, 4);
            Assert.That(tpl4.Fst(), Is.EqualTo(1));
            Assert.That(tpl4.Snd(), Is.EqualTo(2));
            Assert.That(tpl4.Map1(i => i + 1), Is.EqualTo(Create.Tuple(2, 2, 3, 4)));
            Assert.That(tpl4.Map2(i => i + 1), Is.EqualTo(Create.Tuple(1, 3, 3, 4)));
            Assert.That(tpl4.Map3(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 4, 4)));
            Assert.That(tpl4.Map4(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 5)));
            Assert.That(tpl4._1(), Is.EqualTo(1));
            Assert.That(tpl4._2(), Is.EqualTo(2));
            Assert.That(tpl4._3(), Is.EqualTo(3));
            Assert.That(tpl4._4(), Is.EqualTo(4));
            Assert.That(tpl4.Match((i1, i2, i3, i4) => i1 + i2 + i3 + i4), Is.EqualTo(4 * (4 + 1) / 2));
            Assert.That(tpl4.Add(5), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5)));
            Assert.That(tpl4.RemoveLast(), Is.EqualTo(Create.Tuple(1, 2, 3)));

            var tpl5 = Create.Tuple(1, 2, 3, 4, 5);
            Assert.That(tpl5.Fst(), Is.EqualTo(1));
            Assert.That(tpl5.Snd(), Is.EqualTo(2));
            Assert.That(tpl5.Map1(i => i + 1), Is.EqualTo(Create.Tuple(2, 2, 3, 4, 5)));
            Assert.That(tpl5.Map2(i => i + 1), Is.EqualTo(Create.Tuple(1, 3, 3, 4, 5)));
            Assert.That(tpl5.Map3(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 4, 4, 5)));
            Assert.That(tpl5.Map4(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 5, 5)));
            Assert.That(tpl5.Map5(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 6)));
            Assert.That(tpl5._1(), Is.EqualTo(1));
            Assert.That(tpl5._2(), Is.EqualTo(2));
            Assert.That(tpl5._3(), Is.EqualTo(3));
            Assert.That(tpl5._4(), Is.EqualTo(4));
            Assert.That(tpl5._5(), Is.EqualTo(5));
            Assert.That(tpl5.Match((i1, i2, i3, i4, i5) => i1 + i2 + i3 + i4 + i5), Is.EqualTo(5 * (5 + 1) / 2));
            Assert.That(tpl5.Add(6), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6)));
            Assert.That(tpl5.RemoveLast(), Is.EqualTo(Create.Tuple(1, 2, 3, 4)));

            var tpl6 = Create.Tuple(1, 2, 3, 4, 5, 6);
            Assert.That(tpl6.Fst(), Is.EqualTo(1));
            Assert.That(tpl6.Snd(), Is.EqualTo(2));
            Assert.That(tpl6.Map1(i => i + 1), Is.EqualTo(Create.Tuple(2, 2, 3, 4, 5, 6)));
            Assert.That(tpl6.Map2(i => i + 1), Is.EqualTo(Create.Tuple(1, 3, 3, 4, 5, 6)));
            Assert.That(tpl6.Map3(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 4, 4, 5, 6)));
            Assert.That(tpl6.Map4(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 5, 5, 6)));
            Assert.That(tpl6.Map5(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 6, 6)));
            Assert.That(tpl6.Map6(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 7)));
            Assert.That(tpl6._1(), Is.EqualTo(1));
            Assert.That(tpl6._2(), Is.EqualTo(2));
            Assert.That(tpl6._3(), Is.EqualTo(3));
            Assert.That(tpl6._4(), Is.EqualTo(4));
            Assert.That(tpl6._5(), Is.EqualTo(5));
            Assert.That(tpl6._6(), Is.EqualTo(6));
            Assert.That(tpl6.Match((i1, i2, i3, i4, i5, i6) => i1 + i2 + i3 + i4 + i5 + i6), Is.EqualTo(6 * (6 + 1) / 2));
            Assert.That(tpl6.Add(7), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7)));
            Assert.That(tpl6.RemoveLast(), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5)));

            var tpl7 = Create.Tuple(1, 2, 3, 4, 5, 6, 7);
            Assert.That(tpl7.Fst(), Is.EqualTo(1));
            Assert.That(tpl7.Snd(), Is.EqualTo(2));
            Assert.That(tpl7.Map1(i => i + 1), Is.EqualTo(Create.Tuple(2, 2, 3, 4, 5, 6, 7)));
            Assert.That(tpl7.Map2(i => i + 1), Is.EqualTo(Create.Tuple(1, 3, 3, 4, 5, 6, 7)));
            Assert.That(tpl7.Map3(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 4, 4, 5, 6, 7)));
            Assert.That(tpl7.Map4(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 5, 5, 6, 7)));
            Assert.That(tpl7.Map5(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 6, 6, 7)));
            Assert.That(tpl7.Map6(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 7, 7)));
            Assert.That(tpl7.Map7(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 8)));
            Assert.That(tpl7._1(), Is.EqualTo(1));
            Assert.That(tpl7._2(), Is.EqualTo(2));
            Assert.That(tpl7._3(), Is.EqualTo(3));
            Assert.That(tpl7._4(), Is.EqualTo(4));
            Assert.That(tpl7._5(), Is.EqualTo(5));
            Assert.That(tpl7._6(), Is.EqualTo(6));
            Assert.That(tpl7._7(), Is.EqualTo(7));
            Assert.That(tpl7.Match((i1, i2, i3, i4, i5, i6, i7) => i1 + i2 + i3 + i4 + i5 + i6 + i7), Is.EqualTo(7 * (7 + 1) / 2));
            Assert.That(tpl7.Add(8), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8)));
            Assert.That(tpl7.RemoveLast(), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6)));

            var tpl8 = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8);
            Assert.That(tpl8.Fst(), Is.EqualTo(1));
            Assert.That(tpl8.Snd(), Is.EqualTo(2));
            Assert.That(tpl8.Map1(i => i + 1), Is.EqualTo(Create.Tuple(2, 2, 3, 4, 5, 6, 7, 8)));
            Assert.That(tpl8.Map2(i => i + 1), Is.EqualTo(Create.Tuple(1, 3, 3, 4, 5, 6, 7, 8)));
            Assert.That(tpl8.Map3(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 4, 4, 5, 6, 7, 8)));
            Assert.That(tpl8.Map4(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 5, 5, 6, 7, 8)));
            Assert.That(tpl8.Map5(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 6, 6, 7, 8)));
            Assert.That(tpl8.Map6(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 7, 7, 8)));
            Assert.That(tpl8.Map7(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 8, 8)));
            Assert.That(tpl8.Map8(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 9)));
            Assert.That(tpl8._1(), Is.EqualTo(1));
            Assert.That(tpl8._2(), Is.EqualTo(2));
            Assert.That(tpl8._3(), Is.EqualTo(3));
            Assert.That(tpl8._4(), Is.EqualTo(4));
            Assert.That(tpl8._5(), Is.EqualTo(5));
            Assert.That(tpl8._6(), Is.EqualTo(6));
            Assert.That(tpl8._7(), Is.EqualTo(7));
            Assert.That(tpl8._8(), Is.EqualTo(8));
            Assert.That(tpl8.Match((i1, i2, i3, i4, i5, i6, i7, i8) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8), Is.EqualTo(8 * (8 + 1) / 2));
            Assert.That(tpl8.Add(9), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9)));
            Assert.That(tpl8.RemoveLast(), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7)));

            var tpl9 = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9);
            Assert.That(tpl9.Fst(), Is.EqualTo(1));
            Assert.That(tpl9.Snd(), Is.EqualTo(2));
            Assert.That(tpl9.Map1(i => i + 1), Is.EqualTo(Create.Tuple(2, 2, 3, 4, 5, 6, 7, 8, 9)));
            Assert.That(tpl9.Map2(i => i + 1), Is.EqualTo(Create.Tuple(1, 3, 3, 4, 5, 6, 7, 8, 9)));
            Assert.That(tpl9.Map3(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 4, 4, 5, 6, 7, 8, 9)));
            Assert.That(tpl9.Map4(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 5, 5, 6, 7, 8, 9)));
            Assert.That(tpl9.Map5(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 6, 6, 7, 8, 9)));
            Assert.That(tpl9.Map6(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 7, 7, 8, 9)));
            Assert.That(tpl9.Map7(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 8, 8, 9)));
            Assert.That(tpl9.Map8(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 9, 9)));
            Assert.That(tpl9.Map9(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 10)));
            Assert.That(tpl9._1(), Is.EqualTo(1));
            Assert.That(tpl9._2(), Is.EqualTo(2));
            Assert.That(tpl9._3(), Is.EqualTo(3));
            Assert.That(tpl9._4(), Is.EqualTo(4));
            Assert.That(tpl9._5(), Is.EqualTo(5));
            Assert.That(tpl9._6(), Is.EqualTo(6));
            Assert.That(tpl9._7(), Is.EqualTo(7));
            Assert.That(tpl9._8(), Is.EqualTo(8));
            Assert.That(tpl9._9(), Is.EqualTo(9));
            Assert.That(tpl9.Match((i1, i2, i3, i4, i5, i6, i7, i8, i9) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9), Is.EqualTo(9 * (9 + 1) / 2));
            Assert.That(tpl9.Add(10), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10)));
            Assert.That(tpl9.RemoveLast(), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8)));

            var tpl10 = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Assert.That(tpl10.Fst(), Is.EqualTo(1));
            Assert.That(tpl10.Snd(), Is.EqualTo(2));
            Assert.That(tpl10.Map1(i => i + 1), Is.EqualTo(Create.Tuple(2, 2, 3, 4, 5, 6, 7, 8, 9, 10)));
            Assert.That(tpl10.Map2(i => i + 1), Is.EqualTo(Create.Tuple(1, 3, 3, 4, 5, 6, 7, 8, 9, 10)));
            Assert.That(tpl10.Map3(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 4, 4, 5, 6, 7, 8, 9, 10)));
            Assert.That(tpl10.Map4(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 5, 5, 6, 7, 8, 9, 10)));
            Assert.That(tpl10.Map5(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 6, 6, 7, 8, 9, 10)));
            Assert.That(tpl10.Map6(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 7, 7, 8, 9, 10)));
            Assert.That(tpl10.Map7(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 8, 8, 9, 10)));
            Assert.That(tpl10.Map8(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 9, 9, 10)));
            Assert.That(tpl10.Map9(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 10, 10)));
            Assert.That(tpl10.Map10(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 11)));
            Assert.That(tpl10._1(), Is.EqualTo(1));
            Assert.That(tpl10._2(), Is.EqualTo(2));
            Assert.That(tpl10._3(), Is.EqualTo(3));
            Assert.That(tpl10._4(), Is.EqualTo(4));
            Assert.That(tpl10._5(), Is.EqualTo(5));
            Assert.That(tpl10._6(), Is.EqualTo(6));
            Assert.That(tpl10._7(), Is.EqualTo(7));
            Assert.That(tpl10._8(), Is.EqualTo(8));
            Assert.That(tpl10._9(), Is.EqualTo(9));
            Assert.That(tpl10._10(), Is.EqualTo(10));
            Assert.That(tpl10.Match((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10), Is.EqualTo(10 * (10 + 1) / 2));
            Assert.That(tpl10.Add(11), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11)));
            Assert.That(tpl10.RemoveLast(), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9)));

            var tpl11 = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);
            Assert.That(tpl11.Fst(), Is.EqualTo(1));
            Assert.That(tpl11.Snd(), Is.EqualTo(2));
            Assert.That(tpl11.Map1(i => i + 1), Is.EqualTo(Create.Tuple(2, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11)));
            Assert.That(tpl11.Map2(i => i + 1), Is.EqualTo(Create.Tuple(1, 3, 3, 4, 5, 6, 7, 8, 9, 10, 11)));
            Assert.That(tpl11.Map3(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 4, 4, 5, 6, 7, 8, 9, 10, 11)));
            Assert.That(tpl11.Map4(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 5, 5, 6, 7, 8, 9, 10, 11)));
            Assert.That(tpl11.Map5(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 6, 6, 7, 8, 9, 10, 11)));
            Assert.That(tpl11.Map6(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 7, 7, 8, 9, 10, 11)));
            Assert.That(tpl11.Map7(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 8, 8, 9, 10, 11)));
            Assert.That(tpl11.Map8(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 9, 9, 10, 11)));
            Assert.That(tpl11.Map9(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 10, 10, 11)));
            Assert.That(tpl11.Map10(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 11)));
            Assert.That(tpl11.Map11(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12)));
            Assert.That(tpl11._1(), Is.EqualTo(1));
            Assert.That(tpl11._2(), Is.EqualTo(2));
            Assert.That(tpl11._3(), Is.EqualTo(3));
            Assert.That(tpl11._4(), Is.EqualTo(4));
            Assert.That(tpl11._5(), Is.EqualTo(5));
            Assert.That(tpl11._6(), Is.EqualTo(6));
            Assert.That(tpl11._7(), Is.EqualTo(7));
            Assert.That(tpl11._8(), Is.EqualTo(8));
            Assert.That(tpl11._9(), Is.EqualTo(9));
            Assert.That(tpl11._10(), Is.EqualTo(10));
            Assert.That(tpl11._11(), Is.EqualTo(11));
            Assert.That(tpl11.Match((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11), Is.EqualTo(11 * (11 + 1) / 2));
            Assert.That(tpl11.Add(12), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12)));
            Assert.That(tpl11.RemoveLast(), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10)));

            var tpl12 = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);
            Assert.That(tpl12.Fst(), Is.EqualTo(1));
            Assert.That(tpl12.Snd(), Is.EqualTo(2));
            Assert.That(tpl12.Map1(i => i + 1), Is.EqualTo(Create.Tuple(2, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12)));
            Assert.That(tpl12.Map2(i => i + 1), Is.EqualTo(Create.Tuple(1, 3, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12)));
            Assert.That(tpl12.Map3(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 4, 4, 5, 6, 7, 8, 9, 10, 11, 12)));
            Assert.That(tpl12.Map4(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 5, 5, 6, 7, 8, 9, 10, 11, 12)));
            Assert.That(tpl12.Map5(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 6, 6, 7, 8, 9, 10, 11, 12)));
            Assert.That(tpl12.Map6(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 7, 7, 8, 9, 10, 11, 12)));
            Assert.That(tpl12.Map7(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 8, 8, 9, 10, 11, 12)));
            Assert.That(tpl12.Map8(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 9, 9, 10, 11, 12)));
            Assert.That(tpl12.Map9(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 10, 10, 11, 12)));
            Assert.That(tpl12.Map10(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 11, 12)));
            Assert.That(tpl12.Map11(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 12)));
            Assert.That(tpl12.Map12(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 13)));
            Assert.That(tpl12._1(), Is.EqualTo(1));
            Assert.That(tpl12._2(), Is.EqualTo(2));
            Assert.That(tpl12._3(), Is.EqualTo(3));
            Assert.That(tpl12._4(), Is.EqualTo(4));
            Assert.That(tpl12._5(), Is.EqualTo(5));
            Assert.That(tpl12._6(), Is.EqualTo(6));
            Assert.That(tpl12._7(), Is.EqualTo(7));
            Assert.That(tpl12._8(), Is.EqualTo(8));
            Assert.That(tpl12._9(), Is.EqualTo(9));
            Assert.That(tpl12._10(), Is.EqualTo(10));
            Assert.That(tpl12._11(), Is.EqualTo(11));
            Assert.That(tpl12._12(), Is.EqualTo(12));
            Assert.That(tpl12.Match((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12), Is.EqualTo(12 * (12 + 1) / 2));
            Assert.That(tpl12.Add(13), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13)));
            Assert.That(tpl12.RemoveLast(), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11)));

            var tpl13 = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13);
            Assert.That(tpl13.Fst(), Is.EqualTo(1));
            Assert.That(tpl13.Snd(), Is.EqualTo(2));
            Assert.That(tpl13.Map1(i => i + 1), Is.EqualTo(Create.Tuple(2, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13)));
            Assert.That(tpl13.Map2(i => i + 1), Is.EqualTo(Create.Tuple(1, 3, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13)));
            Assert.That(tpl13.Map3(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 4, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13)));
            Assert.That(tpl13.Map4(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 5, 5, 6, 7, 8, 9, 10, 11, 12, 13)));
            Assert.That(tpl13.Map5(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 6, 6, 7, 8, 9, 10, 11, 12, 13)));
            Assert.That(tpl13.Map6(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 7, 7, 8, 9, 10, 11, 12, 13)));
            Assert.That(tpl13.Map7(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 8, 8, 9, 10, 11, 12, 13)));
            Assert.That(tpl13.Map8(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 9, 9, 10, 11, 12, 13)));
            Assert.That(tpl13.Map9(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 10, 10, 11, 12, 13)));
            Assert.That(tpl13.Map10(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 11, 12, 13)));
            Assert.That(tpl13.Map11(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 12, 13)));
            Assert.That(tpl13.Map12(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 13, 13)));
            Assert.That(tpl13.Map13(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 14)));
            Assert.That(tpl13._1(), Is.EqualTo(1));
            Assert.That(tpl13._2(), Is.EqualTo(2));
            Assert.That(tpl13._3(), Is.EqualTo(3));
            Assert.That(tpl13._4(), Is.EqualTo(4));
            Assert.That(tpl13._5(), Is.EqualTo(5));
            Assert.That(tpl13._6(), Is.EqualTo(6));
            Assert.That(tpl13._7(), Is.EqualTo(7));
            Assert.That(tpl13._8(), Is.EqualTo(8));
            Assert.That(tpl13._9(), Is.EqualTo(9));
            Assert.That(tpl13._10(), Is.EqualTo(10));
            Assert.That(tpl13._11(), Is.EqualTo(11));
            Assert.That(tpl13._12(), Is.EqualTo(12));
            Assert.That(tpl13._13(), Is.EqualTo(13));
            Assert.That(tpl13.Match((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13), Is.EqualTo(13 * (13 + 1) / 2));
            Assert.That(tpl13.Add(14), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14)));
            Assert.That(tpl13.RemoveLast(), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12)));

            var tpl14 = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);
            Assert.That(tpl14.Fst(), Is.EqualTo(1));
            Assert.That(tpl14.Snd(), Is.EqualTo(2));
            Assert.That(tpl14.Map1(i => i + 1), Is.EqualTo(Create.Tuple(2, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14)));
            Assert.That(tpl14.Map2(i => i + 1), Is.EqualTo(Create.Tuple(1, 3, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14)));
            Assert.That(tpl14.Map3(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 4, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14)));
            Assert.That(tpl14.Map4(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 5, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14)));
            Assert.That(tpl14.Map5(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 6, 6, 7, 8, 9, 10, 11, 12, 13, 14)));
            Assert.That(tpl14.Map6(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 7, 7, 8, 9, 10, 11, 12, 13, 14)));
            Assert.That(tpl14.Map7(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 8, 8, 9, 10, 11, 12, 13, 14)));
            Assert.That(tpl14.Map8(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 9, 9, 10, 11, 12, 13, 14)));
            Assert.That(tpl14.Map9(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 10, 10, 11, 12, 13, 14)));
            Assert.That(tpl14.Map10(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 11, 12, 13, 14)));
            Assert.That(tpl14.Map11(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 12, 13, 14)));
            Assert.That(tpl14.Map12(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 13, 13, 14)));
            Assert.That(tpl14.Map13(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 14, 14)));
            Assert.That(tpl14.Map14(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 15)));
            Assert.That(tpl14._1(), Is.EqualTo(1));
            Assert.That(tpl14._2(), Is.EqualTo(2));
            Assert.That(tpl14._3(), Is.EqualTo(3));
            Assert.That(tpl14._4(), Is.EqualTo(4));
            Assert.That(tpl14._5(), Is.EqualTo(5));
            Assert.That(tpl14._6(), Is.EqualTo(6));
            Assert.That(tpl14._7(), Is.EqualTo(7));
            Assert.That(tpl14._8(), Is.EqualTo(8));
            Assert.That(tpl14._9(), Is.EqualTo(9));
            Assert.That(tpl14._10(), Is.EqualTo(10));
            Assert.That(tpl14._11(), Is.EqualTo(11));
            Assert.That(tpl14._12(), Is.EqualTo(12));
            Assert.That(tpl14._13(), Is.EqualTo(13));
            Assert.That(tpl14._14(), Is.EqualTo(14));
            Assert.That(tpl14.Match((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14), Is.EqualTo(14 * (14 + 1) / 2));
            Assert.That(tpl14.Add(15), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15)));
            Assert.That(tpl14.RemoveLast(), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13)));

            var tpl15 = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
            Assert.That(tpl15.Fst(), Is.EqualTo(1));
            Assert.That(tpl15.Snd(), Is.EqualTo(2));
            Assert.That(tpl15.Map1(i => i + 1), Is.EqualTo(Create.Tuple(2, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15)));
            Assert.That(tpl15.Map2(i => i + 1), Is.EqualTo(Create.Tuple(1, 3, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15)));
            Assert.That(tpl15.Map3(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 4, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15)));
            Assert.That(tpl15.Map4(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 5, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15)));
            Assert.That(tpl15.Map5(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 6, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15)));
            Assert.That(tpl15.Map6(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 7, 7, 8, 9, 10, 11, 12, 13, 14, 15)));
            Assert.That(tpl15.Map7(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 8, 8, 9, 10, 11, 12, 13, 14, 15)));
            Assert.That(tpl15.Map8(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 9, 9, 10, 11, 12, 13, 14, 15)));
            Assert.That(tpl15.Map9(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 10, 10, 11, 12, 13, 14, 15)));
            Assert.That(tpl15.Map10(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 11, 12, 13, 14, 15)));
            Assert.That(tpl15.Map11(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 12, 13, 14, 15)));
            Assert.That(tpl15.Map12(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 13, 13, 14, 15)));
            Assert.That(tpl15.Map13(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 14, 14, 15)));
            Assert.That(tpl15.Map14(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 15, 15)));
            Assert.That(tpl15.Map15(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 16)));
            Assert.That(tpl15._1(), Is.EqualTo(1));
            Assert.That(tpl15._2(), Is.EqualTo(2));
            Assert.That(tpl15._3(), Is.EqualTo(3));
            Assert.That(tpl15._4(), Is.EqualTo(4));
            Assert.That(tpl15._5(), Is.EqualTo(5));
            Assert.That(tpl15._6(), Is.EqualTo(6));
            Assert.That(tpl15._7(), Is.EqualTo(7));
            Assert.That(tpl15._8(), Is.EqualTo(8));
            Assert.That(tpl15._9(), Is.EqualTo(9));
            Assert.That(tpl15._10(), Is.EqualTo(10));
            Assert.That(tpl15._11(), Is.EqualTo(11));
            Assert.That(tpl15._12(), Is.EqualTo(12));
            Assert.That(tpl15._13(), Is.EqualTo(13));
            Assert.That(tpl15._14(), Is.EqualTo(14));
            Assert.That(tpl15._15(), Is.EqualTo(15));
            Assert.That(tpl15.Match((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14 + i15), Is.EqualTo(15 * (15 + 1) / 2));
            Assert.That(tpl15.Add(16), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16)));
            Assert.That(tpl15.RemoveLast(), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14)));

            var tpl16 = Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.That(tpl16.Fst(), Is.EqualTo(1));
            Assert.That(tpl16.Snd(), Is.EqualTo(2));
            Assert.That(tpl16.Map1(i => i + 1), Is.EqualTo(Create.Tuple(2, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16)));
            Assert.That(tpl16.Map2(i => i + 1), Is.EqualTo(Create.Tuple(1, 3, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16)));
            Assert.That(tpl16.Map3(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 4, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16)));
            Assert.That(tpl16.Map4(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 5, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16)));
            Assert.That(tpl16.Map5(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 6, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16)));
            Assert.That(tpl16.Map6(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 7, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16)));
            Assert.That(tpl16.Map7(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 8, 8, 9, 10, 11, 12, 13, 14, 15, 16)));
            Assert.That(tpl16.Map8(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 9, 9, 10, 11, 12, 13, 14, 15, 16)));
            Assert.That(tpl16.Map9(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 10, 10, 11, 12, 13, 14, 15, 16)));
            Assert.That(tpl16.Map10(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 11, 12, 13, 14, 15, 16)));
            Assert.That(tpl16.Map11(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 12, 13, 14, 15, 16)));
            Assert.That(tpl16.Map12(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 13, 13, 14, 15, 16)));
            Assert.That(tpl16.Map13(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 14, 14, 15, 16)));
            Assert.That(tpl16.Map14(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 15, 15, 16)));
            Assert.That(tpl16.Map15(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 16, 16)));
            Assert.That(tpl16.Map16(i => i + 1), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 17)));
            Assert.That(tpl16._1(), Is.EqualTo(1));
            Assert.That(tpl16._2(), Is.EqualTo(2));
            Assert.That(tpl16._3(), Is.EqualTo(3));
            Assert.That(tpl16._4(), Is.EqualTo(4));
            Assert.That(tpl16._5(), Is.EqualTo(5));
            Assert.That(tpl16._6(), Is.EqualTo(6));
            Assert.That(tpl16._7(), Is.EqualTo(7));
            Assert.That(tpl16._8(), Is.EqualTo(8));
            Assert.That(tpl16._9(), Is.EqualTo(9));
            Assert.That(tpl16._10(), Is.EqualTo(10));
            Assert.That(tpl16._11(), Is.EqualTo(11));
            Assert.That(tpl16._12(), Is.EqualTo(12));
            Assert.That(tpl16._13(), Is.EqualTo(13));
            Assert.That(tpl16._14(), Is.EqualTo(14));
            Assert.That(tpl16._15(), Is.EqualTo(15));
            Assert.That(tpl16._16(), Is.EqualTo(16));
            Assert.That(tpl16.Match((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14 + i15 + i16), Is.EqualTo(16 * (16 + 1) / 2));
            Assert.That(tpl16.RemoveLast(), Is.EqualTo(Create.Tuple(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15)));
        }
#endregion
    }
}