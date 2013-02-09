using System;
using LangExt2;
using NUnit.Framework;
using Microsoft.CSharp.RuntimeBinder;

namespace LangExt2.Tests
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

#region Map1 ... Map 16
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
    }
}