
using System;
using LangExt;
using NUnit.Framework;

namespace LangExt.Tests
{
    [TestFixture]
    public class SeqDragonTest
    {
#region Count
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版Countが通常のCountと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1), Create.Tuple(2, 1), Create.Tuple(3, 3));;
            Assert.That(
                sut.Count((i1, i2) => i1 == i2).ToString(),
                Is.EqualTo(sut.Count(tpl => tpl._1() == tpl._2()).ToString()));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版Countが通常のCountと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1), Create.Tuple(2, 1, 2), Create.Tuple(3, 3, 3));;
            Assert.That(
                sut.Count((i1, i2, i3) => i1 == i2 && i1 == i3).ToString(),
                Is.EqualTo(sut.Count(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3()).ToString()));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版Countが通常のCountと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1), Create.Tuple(2, 1, 2, 2), Create.Tuple(3, 3, 3, 3));;
            Assert.That(
                sut.Count((i1, i2, i3, i4) => i1 == i2 && i1 == i3 && i1 == i4).ToString(),
                Is.EqualTo(sut.Count(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4()).ToString()));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版Countが通常のCountと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3));;
            Assert.That(
                sut.Count((i1, i2, i3, i4, i5) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5).ToString(),
                Is.EqualTo(sut.Count(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5()).ToString()));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版Countが通常のCountと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Count((i1, i2, i3, i4, i5, i6) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6).ToString(),
                Is.EqualTo(sut.Count(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6()).ToString()));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版Countが通常のCountと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Count((i1, i2, i3, i4, i5, i6, i7) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7).ToString(),
                Is.EqualTo(sut.Count(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7()).ToString()));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版Countが通常のCountと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Count((i1, i2, i3, i4, i5, i6, i7, i8) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8).ToString(),
                Is.EqualTo(sut.Count(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8()).ToString()));
        }
        [Test]
        public void _9要素タプルのドラゴンパターンマッチ版Countが通常のCountと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Count((i1, i2, i3, i4, i5, i6, i7, i8, i9) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9).ToString(),
                Is.EqualTo(sut.Count(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9()).ToString()));
        }
        [Test]
        public void _10要素タプルのドラゴンパターンマッチ版Countが通常のCountと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Count((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10).ToString(),
                Is.EqualTo(sut.Count(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10()).ToString()));
        }
        [Test]
        public void _11要素タプルのドラゴンパターンマッチ版Countが通常のCountと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Count((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11).ToString(),
                Is.EqualTo(sut.Count(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11()).ToString()));
        }
        [Test]
        public void _12要素タプルのドラゴンパターンマッチ版Countが通常のCountと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Count((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12).ToString(),
                Is.EqualTo(sut.Count(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12()).ToString()));
        }
        [Test]
        public void _13要素タプルのドラゴンパターンマッチ版Countが通常のCountと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Count((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13).ToString(),
                Is.EqualTo(sut.Count(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13()).ToString()));
        }
        [Test]
        public void _14要素タプルのドラゴンパターンマッチ版Countが通常のCountと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Count((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14).ToString(),
                Is.EqualTo(sut.Count(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14()).ToString()));
        }
        [Test]
        public void _15要素タプルのドラゴンパターンマッチ版Countが通常のCountと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Count((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15).ToString(),
                Is.EqualTo(sut.Count(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15()).ToString()));
        }
        [Test]
        public void _16要素タプルのドラゴンパターンマッチ版Countが通常のCountと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Count((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15 && i1 == i16).ToString(),
                Is.EqualTo(sut.Count(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15() && tpl._1() == tpl._16()).ToString()));
        }
#endregion
#region LongCount
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版LongCountが通常のLongCountと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1), Create.Tuple(2, 1), Create.Tuple(3, 3));;
            Assert.That(
                sut.LongCount((i1, i2) => i1 == i2).ToString(),
                Is.EqualTo(sut.LongCount(tpl => tpl._1() == tpl._2()).ToString()));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版LongCountが通常のLongCountと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1), Create.Tuple(2, 1, 2), Create.Tuple(3, 3, 3));;
            Assert.That(
                sut.LongCount((i1, i2, i3) => i1 == i2 && i1 == i3).ToString(),
                Is.EqualTo(sut.LongCount(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3()).ToString()));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版LongCountが通常のLongCountと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1), Create.Tuple(2, 1, 2, 2), Create.Tuple(3, 3, 3, 3));;
            Assert.That(
                sut.LongCount((i1, i2, i3, i4) => i1 == i2 && i1 == i3 && i1 == i4).ToString(),
                Is.EqualTo(sut.LongCount(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4()).ToString()));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版LongCountが通常のLongCountと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3));;
            Assert.That(
                sut.LongCount((i1, i2, i3, i4, i5) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5).ToString(),
                Is.EqualTo(sut.LongCount(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5()).ToString()));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版LongCountが通常のLongCountと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.LongCount((i1, i2, i3, i4, i5, i6) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6).ToString(),
                Is.EqualTo(sut.LongCount(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6()).ToString()));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版LongCountが通常のLongCountと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.LongCount((i1, i2, i3, i4, i5, i6, i7) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7).ToString(),
                Is.EqualTo(sut.LongCount(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7()).ToString()));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版LongCountが通常のLongCountと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.LongCount((i1, i2, i3, i4, i5, i6, i7, i8) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8).ToString(),
                Is.EqualTo(sut.LongCount(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8()).ToString()));
        }
        [Test]
        public void _9要素タプルのドラゴンパターンマッチ版LongCountが通常のLongCountと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.LongCount((i1, i2, i3, i4, i5, i6, i7, i8, i9) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9).ToString(),
                Is.EqualTo(sut.LongCount(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9()).ToString()));
        }
        [Test]
        public void _10要素タプルのドラゴンパターンマッチ版LongCountが通常のLongCountと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.LongCount((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10).ToString(),
                Is.EqualTo(sut.LongCount(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10()).ToString()));
        }
        [Test]
        public void _11要素タプルのドラゴンパターンマッチ版LongCountが通常のLongCountと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.LongCount((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11).ToString(),
                Is.EqualTo(sut.LongCount(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11()).ToString()));
        }
        [Test]
        public void _12要素タプルのドラゴンパターンマッチ版LongCountが通常のLongCountと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.LongCount((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12).ToString(),
                Is.EqualTo(sut.LongCount(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12()).ToString()));
        }
        [Test]
        public void _13要素タプルのドラゴンパターンマッチ版LongCountが通常のLongCountと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.LongCount((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13).ToString(),
                Is.EqualTo(sut.LongCount(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13()).ToString()));
        }
        [Test]
        public void _14要素タプルのドラゴンパターンマッチ版LongCountが通常のLongCountと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.LongCount((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14).ToString(),
                Is.EqualTo(sut.LongCount(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14()).ToString()));
        }
        [Test]
        public void _15要素タプルのドラゴンパターンマッチ版LongCountが通常のLongCountと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.LongCount((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15).ToString(),
                Is.EqualTo(sut.LongCount(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15()).ToString()));
        }
        [Test]
        public void _16要素タプルのドラゴンパターンマッチ版LongCountが通常のLongCountと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.LongCount((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15 && i1 == i16).ToString(),
                Is.EqualTo(sut.LongCount(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15() && tpl._1() == tpl._16()).ToString()));
        }
#endregion
#region TryFind
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版TryFindが通常のTryFindと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1), Create.Tuple(2, 1), Create.Tuple(3, 3));;
            Assert.That(
                sut.TryFind((i1, i2) => i1 == i2).ToString(),
                Is.EqualTo(sut.TryFind(tpl => tpl._1() == tpl._2()).ToString()));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版TryFindが通常のTryFindと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1), Create.Tuple(2, 1, 2), Create.Tuple(3, 3, 3));;
            Assert.That(
                sut.TryFind((i1, i2, i3) => i1 == i2 && i1 == i3).ToString(),
                Is.EqualTo(sut.TryFind(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3()).ToString()));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版TryFindが通常のTryFindと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1), Create.Tuple(2, 1, 2, 2), Create.Tuple(3, 3, 3, 3));;
            Assert.That(
                sut.TryFind((i1, i2, i3, i4) => i1 == i2 && i1 == i3 && i1 == i4).ToString(),
                Is.EqualTo(sut.TryFind(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4()).ToString()));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版TryFindが通常のTryFindと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryFind((i1, i2, i3, i4, i5) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5).ToString(),
                Is.EqualTo(sut.TryFind(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5()).ToString()));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版TryFindが通常のTryFindと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryFind((i1, i2, i3, i4, i5, i6) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6).ToString(),
                Is.EqualTo(sut.TryFind(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6()).ToString()));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版TryFindが通常のTryFindと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryFind((i1, i2, i3, i4, i5, i6, i7) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7).ToString(),
                Is.EqualTo(sut.TryFind(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7()).ToString()));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版TryFindが通常のTryFindと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryFind((i1, i2, i3, i4, i5, i6, i7, i8) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8).ToString(),
                Is.EqualTo(sut.TryFind(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8()).ToString()));
        }
        [Test]
        public void _9要素タプルのドラゴンパターンマッチ版TryFindが通常のTryFindと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryFind((i1, i2, i3, i4, i5, i6, i7, i8, i9) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9).ToString(),
                Is.EqualTo(sut.TryFind(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9()).ToString()));
        }
        [Test]
        public void _10要素タプルのドラゴンパターンマッチ版TryFindが通常のTryFindと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryFind((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10).ToString(),
                Is.EqualTo(sut.TryFind(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10()).ToString()));
        }
        [Test]
        public void _11要素タプルのドラゴンパターンマッチ版TryFindが通常のTryFindと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryFind((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11).ToString(),
                Is.EqualTo(sut.TryFind(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11()).ToString()));
        }
        [Test]
        public void _12要素タプルのドラゴンパターンマッチ版TryFindが通常のTryFindと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryFind((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12).ToString(),
                Is.EqualTo(sut.TryFind(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12()).ToString()));
        }
        [Test]
        public void _13要素タプルのドラゴンパターンマッチ版TryFindが通常のTryFindと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryFind((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13).ToString(),
                Is.EqualTo(sut.TryFind(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13()).ToString()));
        }
        [Test]
        public void _14要素タプルのドラゴンパターンマッチ版TryFindが通常のTryFindと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryFind((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14).ToString(),
                Is.EqualTo(sut.TryFind(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14()).ToString()));
        }
        [Test]
        public void _15要素タプルのドラゴンパターンマッチ版TryFindが通常のTryFindと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryFind((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15).ToString(),
                Is.EqualTo(sut.TryFind(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15()).ToString()));
        }
        [Test]
        public void _16要素タプルのドラゴンパターンマッチ版TryFindが通常のTryFindと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryFind((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15 && i1 == i16).ToString(),
                Is.EqualTo(sut.TryFind(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15() && tpl._1() == tpl._16()).ToString()));
        }
#endregion
#region Forall
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版Forallが通常のForallと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1), Create.Tuple(2, 1), Create.Tuple(3, 3));;
            Assert.That(
                sut.Forall((i1, i2) => i1 == i2).ToString(),
                Is.EqualTo(sut.Forall(tpl => tpl._1() == tpl._2()).ToString()));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版Forallが通常のForallと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1), Create.Tuple(2, 1, 2), Create.Tuple(3, 3, 3));;
            Assert.That(
                sut.Forall((i1, i2, i3) => i1 == i2 && i1 == i3).ToString(),
                Is.EqualTo(sut.Forall(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3()).ToString()));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版Forallが通常のForallと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1), Create.Tuple(2, 1, 2, 2), Create.Tuple(3, 3, 3, 3));;
            Assert.That(
                sut.Forall((i1, i2, i3, i4) => i1 == i2 && i1 == i3 && i1 == i4).ToString(),
                Is.EqualTo(sut.Forall(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4()).ToString()));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版Forallが通常のForallと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3));;
            Assert.That(
                sut.Forall((i1, i2, i3, i4, i5) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5).ToString(),
                Is.EqualTo(sut.Forall(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5()).ToString()));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版Forallが通常のForallと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Forall((i1, i2, i3, i4, i5, i6) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6).ToString(),
                Is.EqualTo(sut.Forall(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6()).ToString()));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版Forallが通常のForallと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Forall((i1, i2, i3, i4, i5, i6, i7) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7).ToString(),
                Is.EqualTo(sut.Forall(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7()).ToString()));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版Forallが通常のForallと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Forall((i1, i2, i3, i4, i5, i6, i7, i8) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8).ToString(),
                Is.EqualTo(sut.Forall(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8()).ToString()));
        }
        [Test]
        public void _9要素タプルのドラゴンパターンマッチ版Forallが通常のForallと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Forall((i1, i2, i3, i4, i5, i6, i7, i8, i9) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9).ToString(),
                Is.EqualTo(sut.Forall(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9()).ToString()));
        }
        [Test]
        public void _10要素タプルのドラゴンパターンマッチ版Forallが通常のForallと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Forall((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10).ToString(),
                Is.EqualTo(sut.Forall(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10()).ToString()));
        }
        [Test]
        public void _11要素タプルのドラゴンパターンマッチ版Forallが通常のForallと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Forall((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11).ToString(),
                Is.EqualTo(sut.Forall(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11()).ToString()));
        }
        [Test]
        public void _12要素タプルのドラゴンパターンマッチ版Forallが通常のForallと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Forall((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12).ToString(),
                Is.EqualTo(sut.Forall(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12()).ToString()));
        }
        [Test]
        public void _13要素タプルのドラゴンパターンマッチ版Forallが通常のForallと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Forall((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13).ToString(),
                Is.EqualTo(sut.Forall(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13()).ToString()));
        }
        [Test]
        public void _14要素タプルのドラゴンパターンマッチ版Forallが通常のForallと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Forall((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14).ToString(),
                Is.EqualTo(sut.Forall(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14()).ToString()));
        }
        [Test]
        public void _15要素タプルのドラゴンパターンマッチ版Forallが通常のForallと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Forall((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15).ToString(),
                Is.EqualTo(sut.Forall(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15()).ToString()));
        }
        [Test]
        public void _16要素タプルのドラゴンパターンマッチ版Forallが通常のForallと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Forall((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15 && i1 == i16).ToString(),
                Is.EqualTo(sut.Forall(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15() && tpl._1() == tpl._16()).ToString()));
        }
#endregion
#region Exists
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版Existsが通常のExistsと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1), Create.Tuple(2, 1), Create.Tuple(3, 3));;
            Assert.That(
                sut.Exists((i1, i2) => i1 == i2).ToString(),
                Is.EqualTo(sut.Exists(tpl => tpl._1() == tpl._2()).ToString()));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版Existsが通常のExistsと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1), Create.Tuple(2, 1, 2), Create.Tuple(3, 3, 3));;
            Assert.That(
                sut.Exists((i1, i2, i3) => i1 == i2 && i1 == i3).ToString(),
                Is.EqualTo(sut.Exists(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3()).ToString()));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版Existsが通常のExistsと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1), Create.Tuple(2, 1, 2, 2), Create.Tuple(3, 3, 3, 3));;
            Assert.That(
                sut.Exists((i1, i2, i3, i4) => i1 == i2 && i1 == i3 && i1 == i4).ToString(),
                Is.EqualTo(sut.Exists(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4()).ToString()));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版Existsが通常のExistsと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3));;
            Assert.That(
                sut.Exists((i1, i2, i3, i4, i5) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5).ToString(),
                Is.EqualTo(sut.Exists(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5()).ToString()));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版Existsが通常のExistsと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Exists((i1, i2, i3, i4, i5, i6) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6).ToString(),
                Is.EqualTo(sut.Exists(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6()).ToString()));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版Existsが通常のExistsと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Exists((i1, i2, i3, i4, i5, i6, i7) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7).ToString(),
                Is.EqualTo(sut.Exists(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7()).ToString()));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版Existsが通常のExistsと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Exists((i1, i2, i3, i4, i5, i6, i7, i8) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8).ToString(),
                Is.EqualTo(sut.Exists(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8()).ToString()));
        }
        [Test]
        public void _9要素タプルのドラゴンパターンマッチ版Existsが通常のExistsと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Exists((i1, i2, i3, i4, i5, i6, i7, i8, i9) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9).ToString(),
                Is.EqualTo(sut.Exists(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9()).ToString()));
        }
        [Test]
        public void _10要素タプルのドラゴンパターンマッチ版Existsが通常のExistsと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Exists((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10).ToString(),
                Is.EqualTo(sut.Exists(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10()).ToString()));
        }
        [Test]
        public void _11要素タプルのドラゴンパターンマッチ版Existsが通常のExistsと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Exists((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11).ToString(),
                Is.EqualTo(sut.Exists(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11()).ToString()));
        }
        [Test]
        public void _12要素タプルのドラゴンパターンマッチ版Existsが通常のExistsと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Exists((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12).ToString(),
                Is.EqualTo(sut.Exists(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12()).ToString()));
        }
        [Test]
        public void _13要素タプルのドラゴンパターンマッチ版Existsが通常のExistsと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Exists((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13).ToString(),
                Is.EqualTo(sut.Exists(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13()).ToString()));
        }
        [Test]
        public void _14要素タプルのドラゴンパターンマッチ版Existsが通常のExistsと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Exists((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14).ToString(),
                Is.EqualTo(sut.Exists(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14()).ToString()));
        }
        [Test]
        public void _15要素タプルのドラゴンパターンマッチ版Existsが通常のExistsと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Exists((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15).ToString(),
                Is.EqualTo(sut.Exists(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15()).ToString()));
        }
        [Test]
        public void _16要素タプルのドラゴンパターンマッチ版Existsが通常のExistsと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Exists((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15 && i1 == i16).ToString(),
                Is.EqualTo(sut.Exists(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15() && tpl._1() == tpl._16()).ToString()));
        }
#endregion
#region Filter
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版Filterが通常のFilterと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1), Create.Tuple(2, 1), Create.Tuple(3, 3));;
            Assert.That(
                sut.Filter((i1, i2) => i1 == i2).ToString(),
                Is.EqualTo(sut.Filter(tpl => tpl._1() == tpl._2()).ToString()));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版Filterが通常のFilterと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1), Create.Tuple(2, 1, 2), Create.Tuple(3, 3, 3));;
            Assert.That(
                sut.Filter((i1, i2, i3) => i1 == i2 && i1 == i3).ToString(),
                Is.EqualTo(sut.Filter(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3()).ToString()));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版Filterが通常のFilterと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1), Create.Tuple(2, 1, 2, 2), Create.Tuple(3, 3, 3, 3));;
            Assert.That(
                sut.Filter((i1, i2, i3, i4) => i1 == i2 && i1 == i3 && i1 == i4).ToString(),
                Is.EqualTo(sut.Filter(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4()).ToString()));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版Filterが通常のFilterと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3));;
            Assert.That(
                sut.Filter((i1, i2, i3, i4, i5) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5).ToString(),
                Is.EqualTo(sut.Filter(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5()).ToString()));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版Filterが通常のFilterと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Filter((i1, i2, i3, i4, i5, i6) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6).ToString(),
                Is.EqualTo(sut.Filter(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6()).ToString()));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版Filterが通常のFilterと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Filter((i1, i2, i3, i4, i5, i6, i7) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7).ToString(),
                Is.EqualTo(sut.Filter(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7()).ToString()));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版Filterが通常のFilterと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Filter((i1, i2, i3, i4, i5, i6, i7, i8) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8).ToString(),
                Is.EqualTo(sut.Filter(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8()).ToString()));
        }
        [Test]
        public void _9要素タプルのドラゴンパターンマッチ版Filterが通常のFilterと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Filter((i1, i2, i3, i4, i5, i6, i7, i8, i9) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9).ToString(),
                Is.EqualTo(sut.Filter(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9()).ToString()));
        }
        [Test]
        public void _10要素タプルのドラゴンパターンマッチ版Filterが通常のFilterと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Filter((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10).ToString(),
                Is.EqualTo(sut.Filter(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10()).ToString()));
        }
        [Test]
        public void _11要素タプルのドラゴンパターンマッチ版Filterが通常のFilterと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Filter((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11).ToString(),
                Is.EqualTo(sut.Filter(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11()).ToString()));
        }
        [Test]
        public void _12要素タプルのドラゴンパターンマッチ版Filterが通常のFilterと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Filter((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12).ToString(),
                Is.EqualTo(sut.Filter(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12()).ToString()));
        }
        [Test]
        public void _13要素タプルのドラゴンパターンマッチ版Filterが通常のFilterと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Filter((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13).ToString(),
                Is.EqualTo(sut.Filter(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13()).ToString()));
        }
        [Test]
        public void _14要素タプルのドラゴンパターンマッチ版Filterが通常のFilterと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Filter((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14).ToString(),
                Is.EqualTo(sut.Filter(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14()).ToString()));
        }
        [Test]
        public void _15要素タプルのドラゴンパターンマッチ版Filterが通常のFilterと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Filter((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15).ToString(),
                Is.EqualTo(sut.Filter(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15()).ToString()));
        }
        [Test]
        public void _16要素タプルのドラゴンパターンマッチ版Filterが通常のFilterと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Filter((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15 && i1 == i16).ToString(),
                Is.EqualTo(sut.Filter(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15() && tpl._1() == tpl._16()).ToString()));
        }
#endregion
#region SkipWhile
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版SkipWhileが通常のSkipWhileと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1), Create.Tuple(2, 1), Create.Tuple(3, 3));;
            Assert.That(
                sut.SkipWhile((i1, i2) => i1 == i2).ToString(),
                Is.EqualTo(sut.SkipWhile(tpl => tpl._1() == tpl._2()).ToString()));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版SkipWhileが通常のSkipWhileと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1), Create.Tuple(2, 1, 2), Create.Tuple(3, 3, 3));;
            Assert.That(
                sut.SkipWhile((i1, i2, i3) => i1 == i2 && i1 == i3).ToString(),
                Is.EqualTo(sut.SkipWhile(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3()).ToString()));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版SkipWhileが通常のSkipWhileと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1), Create.Tuple(2, 1, 2, 2), Create.Tuple(3, 3, 3, 3));;
            Assert.That(
                sut.SkipWhile((i1, i2, i3, i4) => i1 == i2 && i1 == i3 && i1 == i4).ToString(),
                Is.EqualTo(sut.SkipWhile(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4()).ToString()));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版SkipWhileが通常のSkipWhileと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3));;
            Assert.That(
                sut.SkipWhile((i1, i2, i3, i4, i5) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5).ToString(),
                Is.EqualTo(sut.SkipWhile(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5()).ToString()));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版SkipWhileが通常のSkipWhileと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.SkipWhile((i1, i2, i3, i4, i5, i6) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6).ToString(),
                Is.EqualTo(sut.SkipWhile(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6()).ToString()));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版SkipWhileが通常のSkipWhileと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.SkipWhile((i1, i2, i3, i4, i5, i6, i7) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7).ToString(),
                Is.EqualTo(sut.SkipWhile(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7()).ToString()));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版SkipWhileが通常のSkipWhileと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.SkipWhile((i1, i2, i3, i4, i5, i6, i7, i8) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8).ToString(),
                Is.EqualTo(sut.SkipWhile(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8()).ToString()));
        }
        [Test]
        public void _9要素タプルのドラゴンパターンマッチ版SkipWhileが通常のSkipWhileと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.SkipWhile((i1, i2, i3, i4, i5, i6, i7, i8, i9) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9).ToString(),
                Is.EqualTo(sut.SkipWhile(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9()).ToString()));
        }
        [Test]
        public void _10要素タプルのドラゴンパターンマッチ版SkipWhileが通常のSkipWhileと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.SkipWhile((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10).ToString(),
                Is.EqualTo(sut.SkipWhile(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10()).ToString()));
        }
        [Test]
        public void _11要素タプルのドラゴンパターンマッチ版SkipWhileが通常のSkipWhileと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.SkipWhile((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11).ToString(),
                Is.EqualTo(sut.SkipWhile(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11()).ToString()));
        }
        [Test]
        public void _12要素タプルのドラゴンパターンマッチ版SkipWhileが通常のSkipWhileと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.SkipWhile((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12).ToString(),
                Is.EqualTo(sut.SkipWhile(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12()).ToString()));
        }
        [Test]
        public void _13要素タプルのドラゴンパターンマッチ版SkipWhileが通常のSkipWhileと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.SkipWhile((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13).ToString(),
                Is.EqualTo(sut.SkipWhile(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13()).ToString()));
        }
        [Test]
        public void _14要素タプルのドラゴンパターンマッチ版SkipWhileが通常のSkipWhileと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.SkipWhile((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14).ToString(),
                Is.EqualTo(sut.SkipWhile(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14()).ToString()));
        }
        [Test]
        public void _15要素タプルのドラゴンパターンマッチ版SkipWhileが通常のSkipWhileと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.SkipWhile((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15).ToString(),
                Is.EqualTo(sut.SkipWhile(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15()).ToString()));
        }
        [Test]
        public void _16要素タプルのドラゴンパターンマッチ版SkipWhileが通常のSkipWhileと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.SkipWhile((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15 && i1 == i16).ToString(),
                Is.EqualTo(sut.SkipWhile(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15() && tpl._1() == tpl._16()).ToString()));
        }
#endregion
#region TakeWhile
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版TakeWhileが通常のTakeWhileと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1), Create.Tuple(2, 1), Create.Tuple(3, 3));;
            Assert.That(
                sut.TakeWhile((i1, i2) => i1 == i2).ToString(),
                Is.EqualTo(sut.TakeWhile(tpl => tpl._1() == tpl._2()).ToString()));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版TakeWhileが通常のTakeWhileと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1), Create.Tuple(2, 1, 2), Create.Tuple(3, 3, 3));;
            Assert.That(
                sut.TakeWhile((i1, i2, i3) => i1 == i2 && i1 == i3).ToString(),
                Is.EqualTo(sut.TakeWhile(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3()).ToString()));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版TakeWhileが通常のTakeWhileと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1), Create.Tuple(2, 1, 2, 2), Create.Tuple(3, 3, 3, 3));;
            Assert.That(
                sut.TakeWhile((i1, i2, i3, i4) => i1 == i2 && i1 == i3 && i1 == i4).ToString(),
                Is.EqualTo(sut.TakeWhile(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4()).ToString()));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版TakeWhileが通常のTakeWhileと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3));;
            Assert.That(
                sut.TakeWhile((i1, i2, i3, i4, i5) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5).ToString(),
                Is.EqualTo(sut.TakeWhile(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5()).ToString()));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版TakeWhileが通常のTakeWhileと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TakeWhile((i1, i2, i3, i4, i5, i6) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6).ToString(),
                Is.EqualTo(sut.TakeWhile(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6()).ToString()));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版TakeWhileが通常のTakeWhileと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TakeWhile((i1, i2, i3, i4, i5, i6, i7) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7).ToString(),
                Is.EqualTo(sut.TakeWhile(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7()).ToString()));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版TakeWhileが通常のTakeWhileと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TakeWhile((i1, i2, i3, i4, i5, i6, i7, i8) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8).ToString(),
                Is.EqualTo(sut.TakeWhile(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8()).ToString()));
        }
        [Test]
        public void _9要素タプルのドラゴンパターンマッチ版TakeWhileが通常のTakeWhileと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TakeWhile((i1, i2, i3, i4, i5, i6, i7, i8, i9) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9).ToString(),
                Is.EqualTo(sut.TakeWhile(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9()).ToString()));
        }
        [Test]
        public void _10要素タプルのドラゴンパターンマッチ版TakeWhileが通常のTakeWhileと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TakeWhile((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10).ToString(),
                Is.EqualTo(sut.TakeWhile(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10()).ToString()));
        }
        [Test]
        public void _11要素タプルのドラゴンパターンマッチ版TakeWhileが通常のTakeWhileと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TakeWhile((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11).ToString(),
                Is.EqualTo(sut.TakeWhile(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11()).ToString()));
        }
        [Test]
        public void _12要素タプルのドラゴンパターンマッチ版TakeWhileが通常のTakeWhileと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TakeWhile((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12).ToString(),
                Is.EqualTo(sut.TakeWhile(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12()).ToString()));
        }
        [Test]
        public void _13要素タプルのドラゴンパターンマッチ版TakeWhileが通常のTakeWhileと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TakeWhile((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13).ToString(),
                Is.EqualTo(sut.TakeWhile(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13()).ToString()));
        }
        [Test]
        public void _14要素タプルのドラゴンパターンマッチ版TakeWhileが通常のTakeWhileと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TakeWhile((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14).ToString(),
                Is.EqualTo(sut.TakeWhile(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14()).ToString()));
        }
        [Test]
        public void _15要素タプルのドラゴンパターンマッチ版TakeWhileが通常のTakeWhileと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TakeWhile((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15).ToString(),
                Is.EqualTo(sut.TakeWhile(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15()).ToString()));
        }
        [Test]
        public void _16要素タプルのドラゴンパターンマッチ版TakeWhileが通常のTakeWhileと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TakeWhile((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15 && i1 == i16).ToString(),
                Is.EqualTo(sut.TakeWhile(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15() && tpl._1() == tpl._16()).ToString()));
        }
#endregion
#region Partition
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版Partitionが通常のPartitionと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1), Create.Tuple(2, 1), Create.Tuple(3, 3));;
            Assert.That(
                sut.Partition((i1, i2) => i1 == i2).ToString(),
                Is.EqualTo(sut.Partition(tpl => tpl._1() == tpl._2()).ToString()));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版Partitionが通常のPartitionと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1), Create.Tuple(2, 1, 2), Create.Tuple(3, 3, 3));;
            Assert.That(
                sut.Partition((i1, i2, i3) => i1 == i2 && i1 == i3).ToString(),
                Is.EqualTo(sut.Partition(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3()).ToString()));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版Partitionが通常のPartitionと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1), Create.Tuple(2, 1, 2, 2), Create.Tuple(3, 3, 3, 3));;
            Assert.That(
                sut.Partition((i1, i2, i3, i4) => i1 == i2 && i1 == i3 && i1 == i4).ToString(),
                Is.EqualTo(sut.Partition(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4()).ToString()));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版Partitionが通常のPartitionと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3));;
            Assert.That(
                sut.Partition((i1, i2, i3, i4, i5) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5).ToString(),
                Is.EqualTo(sut.Partition(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5()).ToString()));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版Partitionが通常のPartitionと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Partition((i1, i2, i3, i4, i5, i6) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6).ToString(),
                Is.EqualTo(sut.Partition(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6()).ToString()));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版Partitionが通常のPartitionと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Partition((i1, i2, i3, i4, i5, i6, i7) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7).ToString(),
                Is.EqualTo(sut.Partition(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7()).ToString()));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版Partitionが通常のPartitionと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Partition((i1, i2, i3, i4, i5, i6, i7, i8) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8).ToString(),
                Is.EqualTo(sut.Partition(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8()).ToString()));
        }
        [Test]
        public void _9要素タプルのドラゴンパターンマッチ版Partitionが通常のPartitionと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Partition((i1, i2, i3, i4, i5, i6, i7, i8, i9) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9).ToString(),
                Is.EqualTo(sut.Partition(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9()).ToString()));
        }
        [Test]
        public void _10要素タプルのドラゴンパターンマッチ版Partitionが通常のPartitionと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Partition((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10).ToString(),
                Is.EqualTo(sut.Partition(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10()).ToString()));
        }
        [Test]
        public void _11要素タプルのドラゴンパターンマッチ版Partitionが通常のPartitionと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Partition((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11).ToString(),
                Is.EqualTo(sut.Partition(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11()).ToString()));
        }
        [Test]
        public void _12要素タプルのドラゴンパターンマッチ版Partitionが通常のPartitionと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Partition((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12).ToString(),
                Is.EqualTo(sut.Partition(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12()).ToString()));
        }
        [Test]
        public void _13要素タプルのドラゴンパターンマッチ版Partitionが通常のPartitionと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Partition((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13).ToString(),
                Is.EqualTo(sut.Partition(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13()).ToString()));
        }
        [Test]
        public void _14要素タプルのドラゴンパターンマッチ版Partitionが通常のPartitionと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Partition((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14).ToString(),
                Is.EqualTo(sut.Partition(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14()).ToString()));
        }
        [Test]
        public void _15要素タプルのドラゴンパターンマッチ版Partitionが通常のPartitionと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Partition((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15).ToString(),
                Is.EqualTo(sut.Partition(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15()).ToString()));
        }
        [Test]
        public void _16要素タプルのドラゴンパターンマッチ版Partitionが通常のPartitionと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Partition((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15 && i1 == i16).ToString(),
                Is.EqualTo(sut.Partition(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15() && tpl._1() == tpl._16()).ToString()));
        }
#endregion
#region Span
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版Spanが通常のSpanと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1), Create.Tuple(2, 1), Create.Tuple(3, 3));;
            Assert.That(
                sut.Span((i1, i2) => i1 == i2).ToString(),
                Is.EqualTo(sut.Span(tpl => tpl._1() == tpl._2()).ToString()));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版Spanが通常のSpanと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1), Create.Tuple(2, 1, 2), Create.Tuple(3, 3, 3));;
            Assert.That(
                sut.Span((i1, i2, i3) => i1 == i2 && i1 == i3).ToString(),
                Is.EqualTo(sut.Span(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3()).ToString()));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版Spanが通常のSpanと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1), Create.Tuple(2, 1, 2, 2), Create.Tuple(3, 3, 3, 3));;
            Assert.That(
                sut.Span((i1, i2, i3, i4) => i1 == i2 && i1 == i3 && i1 == i4).ToString(),
                Is.EqualTo(sut.Span(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4()).ToString()));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版Spanが通常のSpanと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3));;
            Assert.That(
                sut.Span((i1, i2, i3, i4, i5) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5).ToString(),
                Is.EqualTo(sut.Span(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5()).ToString()));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版Spanが通常のSpanと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Span((i1, i2, i3, i4, i5, i6) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6).ToString(),
                Is.EqualTo(sut.Span(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6()).ToString()));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版Spanが通常のSpanと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Span((i1, i2, i3, i4, i5, i6, i7) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7).ToString(),
                Is.EqualTo(sut.Span(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7()).ToString()));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版Spanが通常のSpanと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Span((i1, i2, i3, i4, i5, i6, i7, i8) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8).ToString(),
                Is.EqualTo(sut.Span(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8()).ToString()));
        }
        [Test]
        public void _9要素タプルのドラゴンパターンマッチ版Spanが通常のSpanと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Span((i1, i2, i3, i4, i5, i6, i7, i8, i9) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9).ToString(),
                Is.EqualTo(sut.Span(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9()).ToString()));
        }
        [Test]
        public void _10要素タプルのドラゴンパターンマッチ版Spanが通常のSpanと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Span((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10).ToString(),
                Is.EqualTo(sut.Span(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10()).ToString()));
        }
        [Test]
        public void _11要素タプルのドラゴンパターンマッチ版Spanが通常のSpanと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Span((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11).ToString(),
                Is.EqualTo(sut.Span(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11()).ToString()));
        }
        [Test]
        public void _12要素タプルのドラゴンパターンマッチ版Spanが通常のSpanと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Span((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12).ToString(),
                Is.EqualTo(sut.Span(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12()).ToString()));
        }
        [Test]
        public void _13要素タプルのドラゴンパターンマッチ版Spanが通常のSpanと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Span((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13).ToString(),
                Is.EqualTo(sut.Span(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13()).ToString()));
        }
        [Test]
        public void _14要素タプルのドラゴンパターンマッチ版Spanが通常のSpanと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Span((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14).ToString(),
                Is.EqualTo(sut.Span(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14()).ToString()));
        }
        [Test]
        public void _15要素タプルのドラゴンパターンマッチ版Spanが通常のSpanと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Span((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15).ToString(),
                Is.EqualTo(sut.Span(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15()).ToString()));
        }
        [Test]
        public void _16要素タプルのドラゴンパターンマッチ版Spanが通常のSpanと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Span((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15 && i1 == i16).ToString(),
                Is.EqualTo(sut.Span(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15() && tpl._1() == tpl._16()).ToString()));
        }
#endregion
#region Break
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版Breakが通常のBreakと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1), Create.Tuple(2, 1), Create.Tuple(3, 3));;
            Assert.That(
                sut.Break((i1, i2) => i1 == i2).ToString(),
                Is.EqualTo(sut.Break(tpl => tpl._1() == tpl._2()).ToString()));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版Breakが通常のBreakと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1), Create.Tuple(2, 1, 2), Create.Tuple(3, 3, 3));;
            Assert.That(
                sut.Break((i1, i2, i3) => i1 == i2 && i1 == i3).ToString(),
                Is.EqualTo(sut.Break(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3()).ToString()));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版Breakが通常のBreakと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1), Create.Tuple(2, 1, 2, 2), Create.Tuple(3, 3, 3, 3));;
            Assert.That(
                sut.Break((i1, i2, i3, i4) => i1 == i2 && i1 == i3 && i1 == i4).ToString(),
                Is.EqualTo(sut.Break(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4()).ToString()));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版Breakが通常のBreakと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3));;
            Assert.That(
                sut.Break((i1, i2, i3, i4, i5) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5).ToString(),
                Is.EqualTo(sut.Break(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5()).ToString()));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版Breakが通常のBreakと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Break((i1, i2, i3, i4, i5, i6) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6).ToString(),
                Is.EqualTo(sut.Break(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6()).ToString()));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版Breakが通常のBreakと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Break((i1, i2, i3, i4, i5, i6, i7) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7).ToString(),
                Is.EqualTo(sut.Break(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7()).ToString()));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版Breakが通常のBreakと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Break((i1, i2, i3, i4, i5, i6, i7, i8) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8).ToString(),
                Is.EqualTo(sut.Break(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8()).ToString()));
        }
        [Test]
        public void _9要素タプルのドラゴンパターンマッチ版Breakが通常のBreakと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Break((i1, i2, i3, i4, i5, i6, i7, i8, i9) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9).ToString(),
                Is.EqualTo(sut.Break(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9()).ToString()));
        }
        [Test]
        public void _10要素タプルのドラゴンパターンマッチ版Breakが通常のBreakと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Break((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10).ToString(),
                Is.EqualTo(sut.Break(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10()).ToString()));
        }
        [Test]
        public void _11要素タプルのドラゴンパターンマッチ版Breakが通常のBreakと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Break((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11).ToString(),
                Is.EqualTo(sut.Break(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11()).ToString()));
        }
        [Test]
        public void _12要素タプルのドラゴンパターンマッチ版Breakが通常のBreakと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Break((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12).ToString(),
                Is.EqualTo(sut.Break(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12()).ToString()));
        }
        [Test]
        public void _13要素タプルのドラゴンパターンマッチ版Breakが通常のBreakと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Break((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13).ToString(),
                Is.EqualTo(sut.Break(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13()).ToString()));
        }
        [Test]
        public void _14要素タプルのドラゴンパターンマッチ版Breakが通常のBreakと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Break((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14).ToString(),
                Is.EqualTo(sut.Break(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14()).ToString()));
        }
        [Test]
        public void _15要素タプルのドラゴンパターンマッチ版Breakが通常のBreakと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Break((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15).ToString(),
                Is.EqualTo(sut.Break(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15()).ToString()));
        }
        [Test]
        public void _16要素タプルのドラゴンパターンマッチ版Breakが通常のBreakと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Break((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15 && i1 == i16).ToString(),
                Is.EqualTo(sut.Break(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15() && tpl._1() == tpl._16()).ToString()));
        }
#endregion
#region SumBy
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版SumByが通常のSumByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1), Create.Tuple(2, 1), Create.Tuple(3, 3));;
            Assert.That(
                sut.SumBy((i1, i2) => i1 + i2).ToString(),
                Is.EqualTo(sut.SumBy(tpl => tpl._1() + tpl._2()).ToString()));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版SumByが通常のSumByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1), Create.Tuple(2, 1, 2), Create.Tuple(3, 3, 3));;
            Assert.That(
                sut.SumBy((i1, i2, i3) => i1 + i2 + i3).ToString(),
                Is.EqualTo(sut.SumBy(tpl => tpl._1() + tpl._2() + tpl._3()).ToString()));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版SumByが通常のSumByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1), Create.Tuple(2, 1, 2, 2), Create.Tuple(3, 3, 3, 3));;
            Assert.That(
                sut.SumBy((i1, i2, i3, i4) => i1 + i2 + i3 + i4).ToString(),
                Is.EqualTo(sut.SumBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4()).ToString()));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版SumByが通常のSumByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3));;
            Assert.That(
                sut.SumBy((i1, i2, i3, i4, i5) => i1 + i2 + i3 + i4 + i5).ToString(),
                Is.EqualTo(sut.SumBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5()).ToString()));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版SumByが通常のSumByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.SumBy((i1, i2, i3, i4, i5, i6) => i1 + i2 + i3 + i4 + i5 + i6).ToString(),
                Is.EqualTo(sut.SumBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6()).ToString()));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版SumByが通常のSumByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.SumBy((i1, i2, i3, i4, i5, i6, i7) => i1 + i2 + i3 + i4 + i5 + i6 + i7).ToString(),
                Is.EqualTo(sut.SumBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7()).ToString()));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版SumByが通常のSumByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.SumBy((i1, i2, i3, i4, i5, i6, i7, i8) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8).ToString(),
                Is.EqualTo(sut.SumBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8()).ToString()));
        }
        [Test]
        public void _9要素タプルのドラゴンパターンマッチ版SumByが通常のSumByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.SumBy((i1, i2, i3, i4, i5, i6, i7, i8, i9) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9).ToString(),
                Is.EqualTo(sut.SumBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9()).ToString()));
        }
        [Test]
        public void _10要素タプルのドラゴンパターンマッチ版SumByが通常のSumByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.SumBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10).ToString(),
                Is.EqualTo(sut.SumBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10()).ToString()));
        }
        [Test]
        public void _11要素タプルのドラゴンパターンマッチ版SumByが通常のSumByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.SumBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11).ToString(),
                Is.EqualTo(sut.SumBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11()).ToString()));
        }
        [Test]
        public void _12要素タプルのドラゴンパターンマッチ版SumByが通常のSumByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.SumBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12).ToString(),
                Is.EqualTo(sut.SumBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12()).ToString()));
        }
        [Test]
        public void _13要素タプルのドラゴンパターンマッチ版SumByが通常のSumByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.SumBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13).ToString(),
                Is.EqualTo(sut.SumBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13()).ToString()));
        }
        [Test]
        public void _14要素タプルのドラゴンパターンマッチ版SumByが通常のSumByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.SumBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14).ToString(),
                Is.EqualTo(sut.SumBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13() + tpl._14()).ToString()));
        }
        [Test]
        public void _15要素タプルのドラゴンパターンマッチ版SumByが通常のSumByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.SumBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14 + i15).ToString(),
                Is.EqualTo(sut.SumBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13() + tpl._14() + tpl._15()).ToString()));
        }
        [Test]
        public void _16要素タプルのドラゴンパターンマッチ版SumByが通常のSumByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.SumBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14 + i15 + i16).ToString(),
                Is.EqualTo(sut.SumBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13() + tpl._14() + tpl._15() + tpl._16()).ToString()));
        }
#endregion
#region LongSumBy
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版LongSumByが通常のLongSumByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1), Create.Tuple(2, 1), Create.Tuple(3, 3));;
            Assert.That(
                sut.LongSumBy((i1, i2) => i1 + i2).ToString(),
                Is.EqualTo(sut.LongSumBy(tpl => tpl._1() + tpl._2()).ToString()));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版LongSumByが通常のLongSumByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1), Create.Tuple(2, 1, 2), Create.Tuple(3, 3, 3));;
            Assert.That(
                sut.LongSumBy((i1, i2, i3) => i1 + i2 + i3).ToString(),
                Is.EqualTo(sut.LongSumBy(tpl => tpl._1() + tpl._2() + tpl._3()).ToString()));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版LongSumByが通常のLongSumByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1), Create.Tuple(2, 1, 2, 2), Create.Tuple(3, 3, 3, 3));;
            Assert.That(
                sut.LongSumBy((i1, i2, i3, i4) => i1 + i2 + i3 + i4).ToString(),
                Is.EqualTo(sut.LongSumBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4()).ToString()));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版LongSumByが通常のLongSumByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3));;
            Assert.That(
                sut.LongSumBy((i1, i2, i3, i4, i5) => i1 + i2 + i3 + i4 + i5).ToString(),
                Is.EqualTo(sut.LongSumBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5()).ToString()));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版LongSumByが通常のLongSumByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.LongSumBy((i1, i2, i3, i4, i5, i6) => i1 + i2 + i3 + i4 + i5 + i6).ToString(),
                Is.EqualTo(sut.LongSumBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6()).ToString()));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版LongSumByが通常のLongSumByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.LongSumBy((i1, i2, i3, i4, i5, i6, i7) => i1 + i2 + i3 + i4 + i5 + i6 + i7).ToString(),
                Is.EqualTo(sut.LongSumBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7()).ToString()));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版LongSumByが通常のLongSumByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.LongSumBy((i1, i2, i3, i4, i5, i6, i7, i8) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8).ToString(),
                Is.EqualTo(sut.LongSumBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8()).ToString()));
        }
        [Test]
        public void _9要素タプルのドラゴンパターンマッチ版LongSumByが通常のLongSumByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.LongSumBy((i1, i2, i3, i4, i5, i6, i7, i8, i9) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9).ToString(),
                Is.EqualTo(sut.LongSumBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9()).ToString()));
        }
        [Test]
        public void _10要素タプルのドラゴンパターンマッチ版LongSumByが通常のLongSumByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.LongSumBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10).ToString(),
                Is.EqualTo(sut.LongSumBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10()).ToString()));
        }
        [Test]
        public void _11要素タプルのドラゴンパターンマッチ版LongSumByが通常のLongSumByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.LongSumBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11).ToString(),
                Is.EqualTo(sut.LongSumBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11()).ToString()));
        }
        [Test]
        public void _12要素タプルのドラゴンパターンマッチ版LongSumByが通常のLongSumByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.LongSumBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12).ToString(),
                Is.EqualTo(sut.LongSumBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12()).ToString()));
        }
        [Test]
        public void _13要素タプルのドラゴンパターンマッチ版LongSumByが通常のLongSumByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.LongSumBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13).ToString(),
                Is.EqualTo(sut.LongSumBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13()).ToString()));
        }
        [Test]
        public void _14要素タプルのドラゴンパターンマッチ版LongSumByが通常のLongSumByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.LongSumBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14).ToString(),
                Is.EqualTo(sut.LongSumBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13() + tpl._14()).ToString()));
        }
        [Test]
        public void _15要素タプルのドラゴンパターンマッチ版LongSumByが通常のLongSumByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.LongSumBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14 + i15).ToString(),
                Is.EqualTo(sut.LongSumBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13() + tpl._14() + tpl._15()).ToString()));
        }
        [Test]
        public void _16要素タプルのドラゴンパターンマッチ版LongSumByが通常のLongSumByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.LongSumBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14 + i15 + i16).ToString(),
                Is.EqualTo(sut.LongSumBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13() + tpl._14() + tpl._15() + tpl._16()).ToString()));
        }
#endregion
#region TryMaxBy
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版TryMaxByが通常のTryMaxByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1), Create.Tuple(2, 1), Create.Tuple(3, 3));;
            Assert.That(
                sut.TryMaxBy((i1, i2) => i1 + i2).ToString(),
                Is.EqualTo(sut.TryMaxBy(tpl => tpl._1() + tpl._2()).ToString()));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版TryMaxByが通常のTryMaxByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1), Create.Tuple(2, 1, 2), Create.Tuple(3, 3, 3));;
            Assert.That(
                sut.TryMaxBy((i1, i2, i3) => i1 + i2 + i3).ToString(),
                Is.EqualTo(sut.TryMaxBy(tpl => tpl._1() + tpl._2() + tpl._3()).ToString()));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版TryMaxByが通常のTryMaxByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1), Create.Tuple(2, 1, 2, 2), Create.Tuple(3, 3, 3, 3));;
            Assert.That(
                sut.TryMaxBy((i1, i2, i3, i4) => i1 + i2 + i3 + i4).ToString(),
                Is.EqualTo(sut.TryMaxBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4()).ToString()));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版TryMaxByが通常のTryMaxByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryMaxBy((i1, i2, i3, i4, i5) => i1 + i2 + i3 + i4 + i5).ToString(),
                Is.EqualTo(sut.TryMaxBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5()).ToString()));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版TryMaxByが通常のTryMaxByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryMaxBy((i1, i2, i3, i4, i5, i6) => i1 + i2 + i3 + i4 + i5 + i6).ToString(),
                Is.EqualTo(sut.TryMaxBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6()).ToString()));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版TryMaxByが通常のTryMaxByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryMaxBy((i1, i2, i3, i4, i5, i6, i7) => i1 + i2 + i3 + i4 + i5 + i6 + i7).ToString(),
                Is.EqualTo(sut.TryMaxBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7()).ToString()));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版TryMaxByが通常のTryMaxByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryMaxBy((i1, i2, i3, i4, i5, i6, i7, i8) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8).ToString(),
                Is.EqualTo(sut.TryMaxBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8()).ToString()));
        }
        [Test]
        public void _9要素タプルのドラゴンパターンマッチ版TryMaxByが通常のTryMaxByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryMaxBy((i1, i2, i3, i4, i5, i6, i7, i8, i9) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9).ToString(),
                Is.EqualTo(sut.TryMaxBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9()).ToString()));
        }
        [Test]
        public void _10要素タプルのドラゴンパターンマッチ版TryMaxByが通常のTryMaxByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryMaxBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10).ToString(),
                Is.EqualTo(sut.TryMaxBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10()).ToString()));
        }
        [Test]
        public void _11要素タプルのドラゴンパターンマッチ版TryMaxByが通常のTryMaxByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryMaxBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11).ToString(),
                Is.EqualTo(sut.TryMaxBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11()).ToString()));
        }
        [Test]
        public void _12要素タプルのドラゴンパターンマッチ版TryMaxByが通常のTryMaxByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryMaxBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12).ToString(),
                Is.EqualTo(sut.TryMaxBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12()).ToString()));
        }
        [Test]
        public void _13要素タプルのドラゴンパターンマッチ版TryMaxByが通常のTryMaxByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryMaxBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13).ToString(),
                Is.EqualTo(sut.TryMaxBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13()).ToString()));
        }
        [Test]
        public void _14要素タプルのドラゴンパターンマッチ版TryMaxByが通常のTryMaxByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryMaxBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14).ToString(),
                Is.EqualTo(sut.TryMaxBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13() + tpl._14()).ToString()));
        }
        [Test]
        public void _15要素タプルのドラゴンパターンマッチ版TryMaxByが通常のTryMaxByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryMaxBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14 + i15).ToString(),
                Is.EqualTo(sut.TryMaxBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13() + tpl._14() + tpl._15()).ToString()));
        }
        [Test]
        public void _16要素タプルのドラゴンパターンマッチ版TryMaxByが通常のTryMaxByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryMaxBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14 + i15 + i16).ToString(),
                Is.EqualTo(sut.TryMaxBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13() + tpl._14() + tpl._15() + tpl._16()).ToString()));
        }
#endregion
#region TryMinBy
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版TryMinByが通常のTryMinByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1), Create.Tuple(2, 1), Create.Tuple(3, 3));;
            Assert.That(
                sut.TryMinBy((i1, i2) => i1 + i2).ToString(),
                Is.EqualTo(sut.TryMinBy(tpl => tpl._1() + tpl._2()).ToString()));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版TryMinByが通常のTryMinByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1), Create.Tuple(2, 1, 2), Create.Tuple(3, 3, 3));;
            Assert.That(
                sut.TryMinBy((i1, i2, i3) => i1 + i2 + i3).ToString(),
                Is.EqualTo(sut.TryMinBy(tpl => tpl._1() + tpl._2() + tpl._3()).ToString()));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版TryMinByが通常のTryMinByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1), Create.Tuple(2, 1, 2, 2), Create.Tuple(3, 3, 3, 3));;
            Assert.That(
                sut.TryMinBy((i1, i2, i3, i4) => i1 + i2 + i3 + i4).ToString(),
                Is.EqualTo(sut.TryMinBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4()).ToString()));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版TryMinByが通常のTryMinByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryMinBy((i1, i2, i3, i4, i5) => i1 + i2 + i3 + i4 + i5).ToString(),
                Is.EqualTo(sut.TryMinBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5()).ToString()));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版TryMinByが通常のTryMinByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryMinBy((i1, i2, i3, i4, i5, i6) => i1 + i2 + i3 + i4 + i5 + i6).ToString(),
                Is.EqualTo(sut.TryMinBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6()).ToString()));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版TryMinByが通常のTryMinByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryMinBy((i1, i2, i3, i4, i5, i6, i7) => i1 + i2 + i3 + i4 + i5 + i6 + i7).ToString(),
                Is.EqualTo(sut.TryMinBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7()).ToString()));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版TryMinByが通常のTryMinByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryMinBy((i1, i2, i3, i4, i5, i6, i7, i8) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8).ToString(),
                Is.EqualTo(sut.TryMinBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8()).ToString()));
        }
        [Test]
        public void _9要素タプルのドラゴンパターンマッチ版TryMinByが通常のTryMinByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryMinBy((i1, i2, i3, i4, i5, i6, i7, i8, i9) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9).ToString(),
                Is.EqualTo(sut.TryMinBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9()).ToString()));
        }
        [Test]
        public void _10要素タプルのドラゴンパターンマッチ版TryMinByが通常のTryMinByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryMinBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10).ToString(),
                Is.EqualTo(sut.TryMinBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10()).ToString()));
        }
        [Test]
        public void _11要素タプルのドラゴンパターンマッチ版TryMinByが通常のTryMinByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryMinBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11).ToString(),
                Is.EqualTo(sut.TryMinBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11()).ToString()));
        }
        [Test]
        public void _12要素タプルのドラゴンパターンマッチ版TryMinByが通常のTryMinByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryMinBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12).ToString(),
                Is.EqualTo(sut.TryMinBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12()).ToString()));
        }
        [Test]
        public void _13要素タプルのドラゴンパターンマッチ版TryMinByが通常のTryMinByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryMinBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13).ToString(),
                Is.EqualTo(sut.TryMinBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13()).ToString()));
        }
        [Test]
        public void _14要素タプルのドラゴンパターンマッチ版TryMinByが通常のTryMinByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryMinBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14).ToString(),
                Is.EqualTo(sut.TryMinBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13() + tpl._14()).ToString()));
        }
        [Test]
        public void _15要素タプルのドラゴンパターンマッチ版TryMinByが通常のTryMinByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryMinBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14 + i15).ToString(),
                Is.EqualTo(sut.TryMinBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13() + tpl._14() + tpl._15()).ToString()));
        }
        [Test]
        public void _16要素タプルのドラゴンパターンマッチ版TryMinByが通常のTryMinByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryMinBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14 + i15 + i16).ToString(),
                Is.EqualTo(sut.TryMinBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13() + tpl._14() + tpl._15() + tpl._16()).ToString()));
        }
#endregion
#region SortBy
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版SortByが通常のSortByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1), Create.Tuple(2, 1), Create.Tuple(3, 3));;
            Assert.That(
                sut.SortBy((i1, i2) => i1 + i2).ToString(),
                Is.EqualTo(sut.SortBy(tpl => tpl._1() + tpl._2()).ToString()));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版SortByが通常のSortByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1), Create.Tuple(2, 1, 2), Create.Tuple(3, 3, 3));;
            Assert.That(
                sut.SortBy((i1, i2, i3) => i1 + i2 + i3).ToString(),
                Is.EqualTo(sut.SortBy(tpl => tpl._1() + tpl._2() + tpl._3()).ToString()));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版SortByが通常のSortByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1), Create.Tuple(2, 1, 2, 2), Create.Tuple(3, 3, 3, 3));;
            Assert.That(
                sut.SortBy((i1, i2, i3, i4) => i1 + i2 + i3 + i4).ToString(),
                Is.EqualTo(sut.SortBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4()).ToString()));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版SortByが通常のSortByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3));;
            Assert.That(
                sut.SortBy((i1, i2, i3, i4, i5) => i1 + i2 + i3 + i4 + i5).ToString(),
                Is.EqualTo(sut.SortBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5()).ToString()));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版SortByが通常のSortByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.SortBy((i1, i2, i3, i4, i5, i6) => i1 + i2 + i3 + i4 + i5 + i6).ToString(),
                Is.EqualTo(sut.SortBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6()).ToString()));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版SortByが通常のSortByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.SortBy((i1, i2, i3, i4, i5, i6, i7) => i1 + i2 + i3 + i4 + i5 + i6 + i7).ToString(),
                Is.EqualTo(sut.SortBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7()).ToString()));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版SortByが通常のSortByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.SortBy((i1, i2, i3, i4, i5, i6, i7, i8) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8).ToString(),
                Is.EqualTo(sut.SortBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8()).ToString()));
        }
        [Test]
        public void _9要素タプルのドラゴンパターンマッチ版SortByが通常のSortByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.SortBy((i1, i2, i3, i4, i5, i6, i7, i8, i9) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9).ToString(),
                Is.EqualTo(sut.SortBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9()).ToString()));
        }
        [Test]
        public void _10要素タプルのドラゴンパターンマッチ版SortByが通常のSortByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.SortBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10).ToString(),
                Is.EqualTo(sut.SortBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10()).ToString()));
        }
        [Test]
        public void _11要素タプルのドラゴンパターンマッチ版SortByが通常のSortByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.SortBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11).ToString(),
                Is.EqualTo(sut.SortBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11()).ToString()));
        }
        [Test]
        public void _12要素タプルのドラゴンパターンマッチ版SortByが通常のSortByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.SortBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12).ToString(),
                Is.EqualTo(sut.SortBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12()).ToString()));
        }
        [Test]
        public void _13要素タプルのドラゴンパターンマッチ版SortByが通常のSortByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.SortBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13).ToString(),
                Is.EqualTo(sut.SortBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13()).ToString()));
        }
        [Test]
        public void _14要素タプルのドラゴンパターンマッチ版SortByが通常のSortByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.SortBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14).ToString(),
                Is.EqualTo(sut.SortBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13() + tpl._14()).ToString()));
        }
        [Test]
        public void _15要素タプルのドラゴンパターンマッチ版SortByが通常のSortByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.SortBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14 + i15).ToString(),
                Is.EqualTo(sut.SortBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13() + tpl._14() + tpl._15()).ToString()));
        }
        [Test]
        public void _16要素タプルのドラゴンパターンマッチ版SortByが通常のSortByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.SortBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14 + i15 + i16).ToString(),
                Is.EqualTo(sut.SortBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13() + tpl._14() + tpl._15() + tpl._16()).ToString()));
        }
#endregion
#region RevSortBy
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版RevSortByが通常のRevSortByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1), Create.Tuple(2, 1), Create.Tuple(3, 3));;
            Assert.That(
                sut.RevSortBy((i1, i2) => i1 + i2).ToString(),
                Is.EqualTo(sut.RevSortBy(tpl => tpl._1() + tpl._2()).ToString()));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版RevSortByが通常のRevSortByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1), Create.Tuple(2, 1, 2), Create.Tuple(3, 3, 3));;
            Assert.That(
                sut.RevSortBy((i1, i2, i3) => i1 + i2 + i3).ToString(),
                Is.EqualTo(sut.RevSortBy(tpl => tpl._1() + tpl._2() + tpl._3()).ToString()));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版RevSortByが通常のRevSortByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1), Create.Tuple(2, 1, 2, 2), Create.Tuple(3, 3, 3, 3));;
            Assert.That(
                sut.RevSortBy((i1, i2, i3, i4) => i1 + i2 + i3 + i4).ToString(),
                Is.EqualTo(sut.RevSortBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4()).ToString()));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版RevSortByが通常のRevSortByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3));;
            Assert.That(
                sut.RevSortBy((i1, i2, i3, i4, i5) => i1 + i2 + i3 + i4 + i5).ToString(),
                Is.EqualTo(sut.RevSortBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5()).ToString()));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版RevSortByが通常のRevSortByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.RevSortBy((i1, i2, i3, i4, i5, i6) => i1 + i2 + i3 + i4 + i5 + i6).ToString(),
                Is.EqualTo(sut.RevSortBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6()).ToString()));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版RevSortByが通常のRevSortByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.RevSortBy((i1, i2, i3, i4, i5, i6, i7) => i1 + i2 + i3 + i4 + i5 + i6 + i7).ToString(),
                Is.EqualTo(sut.RevSortBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7()).ToString()));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版RevSortByが通常のRevSortByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.RevSortBy((i1, i2, i3, i4, i5, i6, i7, i8) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8).ToString(),
                Is.EqualTo(sut.RevSortBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8()).ToString()));
        }
        [Test]
        public void _9要素タプルのドラゴンパターンマッチ版RevSortByが通常のRevSortByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.RevSortBy((i1, i2, i3, i4, i5, i6, i7, i8, i9) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9).ToString(),
                Is.EqualTo(sut.RevSortBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9()).ToString()));
        }
        [Test]
        public void _10要素タプルのドラゴンパターンマッチ版RevSortByが通常のRevSortByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.RevSortBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10).ToString(),
                Is.EqualTo(sut.RevSortBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10()).ToString()));
        }
        [Test]
        public void _11要素タプルのドラゴンパターンマッチ版RevSortByが通常のRevSortByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.RevSortBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11).ToString(),
                Is.EqualTo(sut.RevSortBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11()).ToString()));
        }
        [Test]
        public void _12要素タプルのドラゴンパターンマッチ版RevSortByが通常のRevSortByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.RevSortBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12).ToString(),
                Is.EqualTo(sut.RevSortBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12()).ToString()));
        }
        [Test]
        public void _13要素タプルのドラゴンパターンマッチ版RevSortByが通常のRevSortByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.RevSortBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13).ToString(),
                Is.EqualTo(sut.RevSortBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13()).ToString()));
        }
        [Test]
        public void _14要素タプルのドラゴンパターンマッチ版RevSortByが通常のRevSortByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.RevSortBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14).ToString(),
                Is.EqualTo(sut.RevSortBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13() + tpl._14()).ToString()));
        }
        [Test]
        public void _15要素タプルのドラゴンパターンマッチ版RevSortByが通常のRevSortByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.RevSortBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14 + i15).ToString(),
                Is.EqualTo(sut.RevSortBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13() + tpl._14() + tpl._15()).ToString()));
        }
        [Test]
        public void _16要素タプルのドラゴンパターンマッチ版RevSortByが通常のRevSortByと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.RevSortBy((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14 + i15 + i16).ToString(),
                Is.EqualTo(sut.RevSortBy(tpl => tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13() + tpl._14() + tpl._15() + tpl._16()).ToString()));
        }
#endregion
#region Fold
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版Foldが通常のFoldと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1), Create.Tuple(2, 1), Create.Tuple(3, 3));;
            Assert.That(
                sut.Fold(0, (acc, i1, i2) => acc + i1 + i2),
                Is.EqualTo(sut.Fold(0, (acc, tpl) => acc + tpl._1() + tpl._2())));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版Foldが通常のFoldと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1), Create.Tuple(2, 1, 2), Create.Tuple(3, 3, 3));;
            Assert.That(
                sut.Fold(0, (acc, i1, i2, i3) => acc + i1 + i2 + i3),
                Is.EqualTo(sut.Fold(0, (acc, tpl) => acc + tpl._1() + tpl._2() + tpl._3())));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版Foldが通常のFoldと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1), Create.Tuple(2, 1, 2, 2), Create.Tuple(3, 3, 3, 3));;
            Assert.That(
                sut.Fold(0, (acc, i1, i2, i3, i4) => acc + i1 + i2 + i3 + i4),
                Is.EqualTo(sut.Fold(0, (acc, tpl) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4())));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版Foldが通常のFoldと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3));;
            Assert.That(
                sut.Fold(0, (acc, i1, i2, i3, i4, i5) => acc + i1 + i2 + i3 + i4 + i5),
                Is.EqualTo(sut.Fold(0, (acc, tpl) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5())));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版Foldが通常のFoldと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Fold(0, (acc, i1, i2, i3, i4, i5, i6) => acc + i1 + i2 + i3 + i4 + i5 + i6),
                Is.EqualTo(sut.Fold(0, (acc, tpl) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6())));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版Foldが通常のFoldと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Fold(0, (acc, i1, i2, i3, i4, i5, i6, i7) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7),
                Is.EqualTo(sut.Fold(0, (acc, tpl) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7())));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版Foldが通常のFoldと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Fold(0, (acc, i1, i2, i3, i4, i5, i6, i7, i8) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8),
                Is.EqualTo(sut.Fold(0, (acc, tpl) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8())));
        }
        [Test]
        public void _9要素タプルのドラゴンパターンマッチ版Foldが通常のFoldと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Fold(0, (acc, i1, i2, i3, i4, i5, i6, i7, i8, i9) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9),
                Is.EqualTo(sut.Fold(0, (acc, tpl) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9())));
        }
        [Test]
        public void _10要素タプルのドラゴンパターンマッチ版Foldが通常のFoldと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Fold(0, (acc, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10),
                Is.EqualTo(sut.Fold(0, (acc, tpl) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10())));
        }
        [Test]
        public void _11要素タプルのドラゴンパターンマッチ版Foldが通常のFoldと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Fold(0, (acc, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11),
                Is.EqualTo(sut.Fold(0, (acc, tpl) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11())));
        }
        [Test]
        public void _12要素タプルのドラゴンパターンマッチ版Foldが通常のFoldと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Fold(0, (acc, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12),
                Is.EqualTo(sut.Fold(0, (acc, tpl) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12())));
        }
        [Test]
        public void _13要素タプルのドラゴンパターンマッチ版Foldが通常のFoldと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Fold(0, (acc, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13),
                Is.EqualTo(sut.Fold(0, (acc, tpl) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13())));
        }
        [Test]
        public void _14要素タプルのドラゴンパターンマッチ版Foldが通常のFoldと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Fold(0, (acc, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14),
                Is.EqualTo(sut.Fold(0, (acc, tpl) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13() + tpl._14())));
        }
        [Test]
        public void _15要素タプルのドラゴンパターンマッチ版Foldが通常のFoldと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Fold(0, (acc, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14 + i15),
                Is.EqualTo(sut.Fold(0, (acc, tpl) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13() + tpl._14() + tpl._15())));
        }
#endregion
#region FoldBack
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版FoldBackが通常のFoldBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1), Create.Tuple(2, 1), Create.Tuple(3, 3));;
            Assert.That(
                sut.FoldBack(0, (i1, i2, acc) => acc + i1 + i2),
                Is.EqualTo(sut.FoldBack(0, (tpl, acc) => acc + tpl._1() + tpl._2())));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版FoldBackが通常のFoldBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1), Create.Tuple(2, 1, 2), Create.Tuple(3, 3, 3));;
            Assert.That(
                sut.FoldBack(0, (i1, i2, i3, acc) => acc + i1 + i2 + i3),
                Is.EqualTo(sut.FoldBack(0, (tpl, acc) => acc + tpl._1() + tpl._2() + tpl._3())));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版FoldBackが通常のFoldBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1), Create.Tuple(2, 1, 2, 2), Create.Tuple(3, 3, 3, 3));;
            Assert.That(
                sut.FoldBack(0, (i1, i2, i3, i4, acc) => acc + i1 + i2 + i3 + i4),
                Is.EqualTo(sut.FoldBack(0, (tpl, acc) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4())));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版FoldBackが通常のFoldBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3));;
            Assert.That(
                sut.FoldBack(0, (i1, i2, i3, i4, i5, acc) => acc + i1 + i2 + i3 + i4 + i5),
                Is.EqualTo(sut.FoldBack(0, (tpl, acc) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5())));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版FoldBackが通常のFoldBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.FoldBack(0, (i1, i2, i3, i4, i5, i6, acc) => acc + i1 + i2 + i3 + i4 + i5 + i6),
                Is.EqualTo(sut.FoldBack(0, (tpl, acc) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6())));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版FoldBackが通常のFoldBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.FoldBack(0, (i1, i2, i3, i4, i5, i6, i7, acc) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7),
                Is.EqualTo(sut.FoldBack(0, (tpl, acc) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7())));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版FoldBackが通常のFoldBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.FoldBack(0, (i1, i2, i3, i4, i5, i6, i7, i8, acc) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8),
                Is.EqualTo(sut.FoldBack(0, (tpl, acc) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8())));
        }
        [Test]
        public void _9要素タプルのドラゴンパターンマッチ版FoldBackが通常のFoldBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.FoldBack(0, (i1, i2, i3, i4, i5, i6, i7, i8, i9, acc) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9),
                Is.EqualTo(sut.FoldBack(0, (tpl, acc) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9())));
        }
        [Test]
        public void _10要素タプルのドラゴンパターンマッチ版FoldBackが通常のFoldBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.FoldBack(0, (i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, acc) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10),
                Is.EqualTo(sut.FoldBack(0, (tpl, acc) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10())));
        }
        [Test]
        public void _11要素タプルのドラゴンパターンマッチ版FoldBackが通常のFoldBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.FoldBack(0, (i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, acc) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11),
                Is.EqualTo(sut.FoldBack(0, (tpl, acc) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11())));
        }
        [Test]
        public void _12要素タプルのドラゴンパターンマッチ版FoldBackが通常のFoldBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.FoldBack(0, (i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, acc) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12),
                Is.EqualTo(sut.FoldBack(0, (tpl, acc) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12())));
        }
        [Test]
        public void _13要素タプルのドラゴンパターンマッチ版FoldBackが通常のFoldBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.FoldBack(0, (i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, acc) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13),
                Is.EqualTo(sut.FoldBack(0, (tpl, acc) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13())));
        }
        [Test]
        public void _14要素タプルのドラゴンパターンマッチ版FoldBackが通常のFoldBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.FoldBack(0, (i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, acc) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14),
                Is.EqualTo(sut.FoldBack(0, (tpl, acc) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13() + tpl._14())));
        }
        [Test]
        public void _15要素タプルのドラゴンパターンマッチ版FoldBackが通常のFoldBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.FoldBack(0, (i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, acc) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14 + i15),
                Is.EqualTo(sut.FoldBack(0, (tpl, acc) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13() + tpl._14() + tpl._15())));
        }
#endregion
#region Scan
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版Scanが通常のScanと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1), Create.Tuple(2, 1), Create.Tuple(3, 3));;
            Assert.That(
                sut.Scan(0, (acc, i1, i2) => acc + i1 + i2),
                Is.EqualTo(sut.Scan(0, (acc, tpl) => acc + tpl._1() + tpl._2())));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版Scanが通常のScanと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1), Create.Tuple(2, 1, 2), Create.Tuple(3, 3, 3));;
            Assert.That(
                sut.Scan(0, (acc, i1, i2, i3) => acc + i1 + i2 + i3),
                Is.EqualTo(sut.Scan(0, (acc, tpl) => acc + tpl._1() + tpl._2() + tpl._3())));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版Scanが通常のScanと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1), Create.Tuple(2, 1, 2, 2), Create.Tuple(3, 3, 3, 3));;
            Assert.That(
                sut.Scan(0, (acc, i1, i2, i3, i4) => acc + i1 + i2 + i3 + i4),
                Is.EqualTo(sut.Scan(0, (acc, tpl) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4())));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版Scanが通常のScanと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3));;
            Assert.That(
                sut.Scan(0, (acc, i1, i2, i3, i4, i5) => acc + i1 + i2 + i3 + i4 + i5),
                Is.EqualTo(sut.Scan(0, (acc, tpl) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5())));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版Scanが通常のScanと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Scan(0, (acc, i1, i2, i3, i4, i5, i6) => acc + i1 + i2 + i3 + i4 + i5 + i6),
                Is.EqualTo(sut.Scan(0, (acc, tpl) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6())));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版Scanが通常のScanと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Scan(0, (acc, i1, i2, i3, i4, i5, i6, i7) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7),
                Is.EqualTo(sut.Scan(0, (acc, tpl) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7())));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版Scanが通常のScanと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Scan(0, (acc, i1, i2, i3, i4, i5, i6, i7, i8) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8),
                Is.EqualTo(sut.Scan(0, (acc, tpl) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8())));
        }
        [Test]
        public void _9要素タプルのドラゴンパターンマッチ版Scanが通常のScanと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Scan(0, (acc, i1, i2, i3, i4, i5, i6, i7, i8, i9) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9),
                Is.EqualTo(sut.Scan(0, (acc, tpl) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9())));
        }
        [Test]
        public void _10要素タプルのドラゴンパターンマッチ版Scanが通常のScanと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Scan(0, (acc, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10),
                Is.EqualTo(sut.Scan(0, (acc, tpl) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10())));
        }
        [Test]
        public void _11要素タプルのドラゴンパターンマッチ版Scanが通常のScanと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Scan(0, (acc, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11),
                Is.EqualTo(sut.Scan(0, (acc, tpl) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11())));
        }
        [Test]
        public void _12要素タプルのドラゴンパターンマッチ版Scanが通常のScanと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Scan(0, (acc, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12),
                Is.EqualTo(sut.Scan(0, (acc, tpl) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12())));
        }
        [Test]
        public void _13要素タプルのドラゴンパターンマッチ版Scanが通常のScanと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Scan(0, (acc, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13),
                Is.EqualTo(sut.Scan(0, (acc, tpl) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13())));
        }
        [Test]
        public void _14要素タプルのドラゴンパターンマッチ版Scanが通常のScanと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Scan(0, (acc, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14),
                Is.EqualTo(sut.Scan(0, (acc, tpl) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13() + tpl._14())));
        }
        [Test]
        public void _15要素タプルのドラゴンパターンマッチ版Scanが通常のScanと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Scan(0, (acc, i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14 + i15),
                Is.EqualTo(sut.Scan(0, (acc, tpl) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13() + tpl._14() + tpl._15())));
        }
#endregion
#region ScanBack
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版ScanBackが通常のScanBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1), Create.Tuple(2, 1), Create.Tuple(3, 3));;
            Assert.That(
                sut.ScanBack(0, (i1, i2, acc) => acc + i1 + i2),
                Is.EqualTo(sut.ScanBack(0, (tpl, acc) => acc + tpl._1() + tpl._2())));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版ScanBackが通常のScanBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1), Create.Tuple(2, 1, 2), Create.Tuple(3, 3, 3));;
            Assert.That(
                sut.ScanBack(0, (i1, i2, i3, acc) => acc + i1 + i2 + i3),
                Is.EqualTo(sut.ScanBack(0, (tpl, acc) => acc + tpl._1() + tpl._2() + tpl._3())));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版ScanBackが通常のScanBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1), Create.Tuple(2, 1, 2, 2), Create.Tuple(3, 3, 3, 3));;
            Assert.That(
                sut.ScanBack(0, (i1, i2, i3, i4, acc) => acc + i1 + i2 + i3 + i4),
                Is.EqualTo(sut.ScanBack(0, (tpl, acc) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4())));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版ScanBackが通常のScanBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3));;
            Assert.That(
                sut.ScanBack(0, (i1, i2, i3, i4, i5, acc) => acc + i1 + i2 + i3 + i4 + i5),
                Is.EqualTo(sut.ScanBack(0, (tpl, acc) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5())));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版ScanBackが通常のScanBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.ScanBack(0, (i1, i2, i3, i4, i5, i6, acc) => acc + i1 + i2 + i3 + i4 + i5 + i6),
                Is.EqualTo(sut.ScanBack(0, (tpl, acc) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6())));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版ScanBackが通常のScanBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.ScanBack(0, (i1, i2, i3, i4, i5, i6, i7, acc) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7),
                Is.EqualTo(sut.ScanBack(0, (tpl, acc) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7())));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版ScanBackが通常のScanBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.ScanBack(0, (i1, i2, i3, i4, i5, i6, i7, i8, acc) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8),
                Is.EqualTo(sut.ScanBack(0, (tpl, acc) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8())));
        }
        [Test]
        public void _9要素タプルのドラゴンパターンマッチ版ScanBackが通常のScanBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.ScanBack(0, (i1, i2, i3, i4, i5, i6, i7, i8, i9, acc) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9),
                Is.EqualTo(sut.ScanBack(0, (tpl, acc) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9())));
        }
        [Test]
        public void _10要素タプルのドラゴンパターンマッチ版ScanBackが通常のScanBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.ScanBack(0, (i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, acc) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10),
                Is.EqualTo(sut.ScanBack(0, (tpl, acc) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10())));
        }
        [Test]
        public void _11要素タプルのドラゴンパターンマッチ版ScanBackが通常のScanBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.ScanBack(0, (i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, acc) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11),
                Is.EqualTo(sut.ScanBack(0, (tpl, acc) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11())));
        }
        [Test]
        public void _12要素タプルのドラゴンパターンマッチ版ScanBackが通常のScanBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.ScanBack(0, (i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, acc) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12),
                Is.EqualTo(sut.ScanBack(0, (tpl, acc) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12())));
        }
        [Test]
        public void _13要素タプルのドラゴンパターンマッチ版ScanBackが通常のScanBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.ScanBack(0, (i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, acc) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13),
                Is.EqualTo(sut.ScanBack(0, (tpl, acc) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13())));
        }
        [Test]
        public void _14要素タプルのドラゴンパターンマッチ版ScanBackが通常のScanBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.ScanBack(0, (i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, acc) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14),
                Is.EqualTo(sut.ScanBack(0, (tpl, acc) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13() + tpl._14())));
        }
        [Test]
        public void _15要素タプルのドラゴンパターンマッチ版ScanBackが通常のScanBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.ScanBack(0, (i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, acc) => acc + i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14 + i15),
                Is.EqualTo(sut.ScanBack(0, (tpl, acc) => acc + tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13() + tpl._14() + tpl._15())));
        }
#endregion
#region TryReduce
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版TryReduceが通常のTryReduceと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1), Create.Tuple(2, 1), Create.Tuple(3, 3));;
            Assert.That(
                sut.TryReduce((i1, i2, j1, j2) => Create.Tuple(i1 + j1, i2 + j2)),
                Is.EqualTo(sut.TryReduce((tpl, tpl2) => Create.Tuple(tpl._1() + tpl2._1(), tpl._2() + tpl2._2()))));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版TryReduceが通常のTryReduceと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1), Create.Tuple(2, 1, 2), Create.Tuple(3, 3, 3));;
            Assert.That(
                sut.TryReduce((i1, i2, i3, j1, j2, j3) => Create.Tuple(i1 + j1, i2 + j2, i3 + j3)),
                Is.EqualTo(sut.TryReduce((tpl, tpl2) => Create.Tuple(tpl._1() + tpl2._1(), tpl._2() + tpl2._2(), tpl._3() + tpl2._3()))));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版TryReduceが通常のTryReduceと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1), Create.Tuple(2, 1, 2, 2), Create.Tuple(3, 3, 3, 3));;
            Assert.That(
                sut.TryReduce((i1, i2, i3, i4, j1, j2, j3, j4) => Create.Tuple(i1 + j1, i2 + j2, i3 + j3, i4 + j4)),
                Is.EqualTo(sut.TryReduce((tpl, tpl2) => Create.Tuple(tpl._1() + tpl2._1(), tpl._2() + tpl2._2(), tpl._3() + tpl2._3(), tpl._4() + tpl2._4()))));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版TryReduceが通常のTryReduceと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryReduce((i1, i2, i3, i4, i5, j1, j2, j3, j4, j5) => Create.Tuple(i1 + j1, i2 + j2, i3 + j3, i4 + j4, i5 + j5)),
                Is.EqualTo(sut.TryReduce((tpl, tpl2) => Create.Tuple(tpl._1() + tpl2._1(), tpl._2() + tpl2._2(), tpl._3() + tpl2._3(), tpl._4() + tpl2._4(), tpl._5() + tpl2._5()))));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版TryReduceが通常のTryReduceと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryReduce((i1, i2, i3, i4, i5, i6, j1, j2, j3, j4, j5, j6) => Create.Tuple(i1 + j1, i2 + j2, i3 + j3, i4 + j4, i5 + j5, i6 + j6)),
                Is.EqualTo(sut.TryReduce((tpl, tpl2) => Create.Tuple(tpl._1() + tpl2._1(), tpl._2() + tpl2._2(), tpl._3() + tpl2._3(), tpl._4() + tpl2._4(), tpl._5() + tpl2._5(), tpl._6() + tpl2._6()))));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版TryReduceが通常のTryReduceと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryReduce((i1, i2, i3, i4, i5, i6, i7, j1, j2, j3, j4, j5, j6, j7) => Create.Tuple(i1 + j1, i2 + j2, i3 + j3, i4 + j4, i5 + j5, i6 + j6, i7 + j7)),
                Is.EqualTo(sut.TryReduce((tpl, tpl2) => Create.Tuple(tpl._1() + tpl2._1(), tpl._2() + tpl2._2(), tpl._3() + tpl2._3(), tpl._4() + tpl2._4(), tpl._5() + tpl2._5(), tpl._6() + tpl2._6(), tpl._7() + tpl2._7()))));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版TryReduceが通常のTryReduceと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryReduce((i1, i2, i3, i4, i5, i6, i7, i8, j1, j2, j3, j4, j5, j6, j7, j8) => Create.Tuple(i1 + j1, i2 + j2, i3 + j3, i4 + j4, i5 + j5, i6 + j6, i7 + j7, i8 + j8)),
                Is.EqualTo(sut.TryReduce((tpl, tpl2) => Create.Tuple(tpl._1() + tpl2._1(), tpl._2() + tpl2._2(), tpl._3() + tpl2._3(), tpl._4() + tpl2._4(), tpl._5() + tpl2._5(), tpl._6() + tpl2._6(), tpl._7() + tpl2._7(), tpl._8() + tpl2._8()))));
        }
#endregion
#region TryReduceBack
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版TryReduceBackが通常のTryReduceBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1), Create.Tuple(2, 1), Create.Tuple(3, 3));;
            Assert.That(
                sut.TryReduceBack((i1, i2, j1, j2) => Create.Tuple(i1 + j1, i2 + j2)),
                Is.EqualTo(sut.TryReduceBack((tpl, tpl2) => Create.Tuple(tpl._1() + tpl2._1(), tpl._2() + tpl2._2()))));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版TryReduceBackが通常のTryReduceBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1), Create.Tuple(2, 1, 2), Create.Tuple(3, 3, 3));;
            Assert.That(
                sut.TryReduceBack((i1, i2, i3, j1, j2, j3) => Create.Tuple(i1 + j1, i2 + j2, i3 + j3)),
                Is.EqualTo(sut.TryReduceBack((tpl, tpl2) => Create.Tuple(tpl._1() + tpl2._1(), tpl._2() + tpl2._2(), tpl._3() + tpl2._3()))));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版TryReduceBackが通常のTryReduceBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1), Create.Tuple(2, 1, 2, 2), Create.Tuple(3, 3, 3, 3));;
            Assert.That(
                sut.TryReduceBack((i1, i2, i3, i4, j1, j2, j3, j4) => Create.Tuple(i1 + j1, i2 + j2, i3 + j3, i4 + j4)),
                Is.EqualTo(sut.TryReduceBack((tpl, tpl2) => Create.Tuple(tpl._1() + tpl2._1(), tpl._2() + tpl2._2(), tpl._3() + tpl2._3(), tpl._4() + tpl2._4()))));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版TryReduceBackが通常のTryReduceBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryReduceBack((i1, i2, i3, i4, i5, j1, j2, j3, j4, j5) => Create.Tuple(i1 + j1, i2 + j2, i3 + j3, i4 + j4, i5 + j5)),
                Is.EqualTo(sut.TryReduceBack((tpl, tpl2) => Create.Tuple(tpl._1() + tpl2._1(), tpl._2() + tpl2._2(), tpl._3() + tpl2._3(), tpl._4() + tpl2._4(), tpl._5() + tpl2._5()))));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版TryReduceBackが通常のTryReduceBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryReduceBack((i1, i2, i3, i4, i5, i6, j1, j2, j3, j4, j5, j6) => Create.Tuple(i1 + j1, i2 + j2, i3 + j3, i4 + j4, i5 + j5, i6 + j6)),
                Is.EqualTo(sut.TryReduceBack((tpl, tpl2) => Create.Tuple(tpl._1() + tpl2._1(), tpl._2() + tpl2._2(), tpl._3() + tpl2._3(), tpl._4() + tpl2._4(), tpl._5() + tpl2._5(), tpl._6() + tpl2._6()))));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版TryReduceBackが通常のTryReduceBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryReduceBack((i1, i2, i3, i4, i5, i6, i7, j1, j2, j3, j4, j5, j6, j7) => Create.Tuple(i1 + j1, i2 + j2, i3 + j3, i4 + j4, i5 + j5, i6 + j6, i7 + j7)),
                Is.EqualTo(sut.TryReduceBack((tpl, tpl2) => Create.Tuple(tpl._1() + tpl2._1(), tpl._2() + tpl2._2(), tpl._3() + tpl2._3(), tpl._4() + tpl2._4(), tpl._5() + tpl2._5(), tpl._6() + tpl2._6(), tpl._7() + tpl2._7()))));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版TryReduceBackが通常のTryReduceBackと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryReduceBack((i1, i2, i3, i4, i5, i6, i7, i8, j1, j2, j3, j4, j5, j6, j7, j8) => Create.Tuple(i1 + j1, i2 + j2, i3 + j3, i4 + j4, i5 + j5, i6 + j6, i7 + j7, i8 + j8)),
                Is.EqualTo(sut.TryReduceBack((tpl, tpl2) => Create.Tuple(tpl._1() + tpl2._1(), tpl._2() + tpl2._2(), tpl._3() + tpl2._3(), tpl._4() + tpl2._4(), tpl._5() + tpl2._5(), tpl._6() + tpl2._6(), tpl._7() + tpl2._7(), tpl._8() + tpl2._8()))));
        }
#endregion
#region Scan1
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版Scan1が通常のScan1と同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1), Create.Tuple(2, 1), Create.Tuple(3, 3));;
            Assert.That(
                sut.Scan1((i1, i2, j1, j2) => Create.Tuple(i1 + j1, i2 + j2)),
                Is.EqualTo(sut.Scan1((tpl, tpl2) => Create.Tuple(tpl._1() + tpl2._1(), tpl._2() + tpl2._2()))));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版Scan1が通常のScan1と同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1), Create.Tuple(2, 1, 2), Create.Tuple(3, 3, 3));;
            Assert.That(
                sut.Scan1((i1, i2, i3, j1, j2, j3) => Create.Tuple(i1 + j1, i2 + j2, i3 + j3)),
                Is.EqualTo(sut.Scan1((tpl, tpl2) => Create.Tuple(tpl._1() + tpl2._1(), tpl._2() + tpl2._2(), tpl._3() + tpl2._3()))));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版Scan1が通常のScan1と同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1), Create.Tuple(2, 1, 2, 2), Create.Tuple(3, 3, 3, 3));;
            Assert.That(
                sut.Scan1((i1, i2, i3, i4, j1, j2, j3, j4) => Create.Tuple(i1 + j1, i2 + j2, i3 + j3, i4 + j4)),
                Is.EqualTo(sut.Scan1((tpl, tpl2) => Create.Tuple(tpl._1() + tpl2._1(), tpl._2() + tpl2._2(), tpl._3() + tpl2._3(), tpl._4() + tpl2._4()))));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版Scan1が通常のScan1と同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3));;
            Assert.That(
                sut.Scan1((i1, i2, i3, i4, i5, j1, j2, j3, j4, j5) => Create.Tuple(i1 + j1, i2 + j2, i3 + j3, i4 + j4, i5 + j5)),
                Is.EqualTo(sut.Scan1((tpl, tpl2) => Create.Tuple(tpl._1() + tpl2._1(), tpl._2() + tpl2._2(), tpl._3() + tpl2._3(), tpl._4() + tpl2._4(), tpl._5() + tpl2._5()))));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版Scan1が通常のScan1と同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Scan1((i1, i2, i3, i4, i5, i6, j1, j2, j3, j4, j5, j6) => Create.Tuple(i1 + j1, i2 + j2, i3 + j3, i4 + j4, i5 + j5, i6 + j6)),
                Is.EqualTo(sut.Scan1((tpl, tpl2) => Create.Tuple(tpl._1() + tpl2._1(), tpl._2() + tpl2._2(), tpl._3() + tpl2._3(), tpl._4() + tpl2._4(), tpl._5() + tpl2._5(), tpl._6() + tpl2._6()))));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版Scan1が通常のScan1と同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Scan1((i1, i2, i3, i4, i5, i6, i7, j1, j2, j3, j4, j5, j6, j7) => Create.Tuple(i1 + j1, i2 + j2, i3 + j3, i4 + j4, i5 + j5, i6 + j6, i7 + j7)),
                Is.EqualTo(sut.Scan1((tpl, tpl2) => Create.Tuple(tpl._1() + tpl2._1(), tpl._2() + tpl2._2(), tpl._3() + tpl2._3(), tpl._4() + tpl2._4(), tpl._5() + tpl2._5(), tpl._6() + tpl2._6(), tpl._7() + tpl2._7()))));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版Scan1が通常のScan1と同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Scan1((i1, i2, i3, i4, i5, i6, i7, i8, j1, j2, j3, j4, j5, j6, j7, j8) => Create.Tuple(i1 + j1, i2 + j2, i3 + j3, i4 + j4, i5 + j5, i6 + j6, i7 + j7, i8 + j8)),
                Is.EqualTo(sut.Scan1((tpl, tpl2) => Create.Tuple(tpl._1() + tpl2._1(), tpl._2() + tpl2._2(), tpl._3() + tpl2._3(), tpl._4() + tpl2._4(), tpl._5() + tpl2._5(), tpl._6() + tpl2._6(), tpl._7() + tpl2._7(), tpl._8() + tpl2._8()))));
        }
#endregion
#region ScanBack1
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版ScanBack1が通常のScanBack1と同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1), Create.Tuple(2, 1), Create.Tuple(3, 3));;
            Assert.That(
                sut.ScanBack1((i1, i2, j1, j2) => Create.Tuple(i1 + j1, i2 + j2)),
                Is.EqualTo(sut.ScanBack1((tpl, tpl2) => Create.Tuple(tpl._1() + tpl2._1(), tpl._2() + tpl2._2()))));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版ScanBack1が通常のScanBack1と同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1), Create.Tuple(2, 1, 2), Create.Tuple(3, 3, 3));;
            Assert.That(
                sut.ScanBack1((i1, i2, i3, j1, j2, j3) => Create.Tuple(i1 + j1, i2 + j2, i3 + j3)),
                Is.EqualTo(sut.ScanBack1((tpl, tpl2) => Create.Tuple(tpl._1() + tpl2._1(), tpl._2() + tpl2._2(), tpl._3() + tpl2._3()))));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版ScanBack1が通常のScanBack1と同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1), Create.Tuple(2, 1, 2, 2), Create.Tuple(3, 3, 3, 3));;
            Assert.That(
                sut.ScanBack1((i1, i2, i3, i4, j1, j2, j3, j4) => Create.Tuple(i1 + j1, i2 + j2, i3 + j3, i4 + j4)),
                Is.EqualTo(sut.ScanBack1((tpl, tpl2) => Create.Tuple(tpl._1() + tpl2._1(), tpl._2() + tpl2._2(), tpl._3() + tpl2._3(), tpl._4() + tpl2._4()))));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版ScanBack1が通常のScanBack1と同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3));;
            Assert.That(
                sut.ScanBack1((i1, i2, i3, i4, i5, j1, j2, j3, j4, j5) => Create.Tuple(i1 + j1, i2 + j2, i3 + j3, i4 + j4, i5 + j5)),
                Is.EqualTo(sut.ScanBack1((tpl, tpl2) => Create.Tuple(tpl._1() + tpl2._1(), tpl._2() + tpl2._2(), tpl._3() + tpl2._3(), tpl._4() + tpl2._4(), tpl._5() + tpl2._5()))));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版ScanBack1が通常のScanBack1と同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.ScanBack1((i1, i2, i3, i4, i5, i6, j1, j2, j3, j4, j5, j6) => Create.Tuple(i1 + j1, i2 + j2, i3 + j3, i4 + j4, i5 + j5, i6 + j6)),
                Is.EqualTo(sut.ScanBack1((tpl, tpl2) => Create.Tuple(tpl._1() + tpl2._1(), tpl._2() + tpl2._2(), tpl._3() + tpl2._3(), tpl._4() + tpl2._4(), tpl._5() + tpl2._5(), tpl._6() + tpl2._6()))));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版ScanBack1が通常のScanBack1と同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.ScanBack1((i1, i2, i3, i4, i5, i6, i7, j1, j2, j3, j4, j5, j6, j7) => Create.Tuple(i1 + j1, i2 + j2, i3 + j3, i4 + j4, i5 + j5, i6 + j6, i7 + j7)),
                Is.EqualTo(sut.ScanBack1((tpl, tpl2) => Create.Tuple(tpl._1() + tpl2._1(), tpl._2() + tpl2._2(), tpl._3() + tpl2._3(), tpl._4() + tpl2._4(), tpl._5() + tpl2._5(), tpl._6() + tpl2._6(), tpl._7() + tpl2._7()))));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版ScanBack1が通常のScanBack1と同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.ScanBack1((i1, i2, i3, i4, i5, i6, i7, i8, j1, j2, j3, j4, j5, j6, j7, j8) => Create.Tuple(i1 + j1, i2 + j2, i3 + j3, i4 + j4, i5 + j5, i6 + j6, i7 + j7, i8 + j8)),
                Is.EqualTo(sut.ScanBack1((tpl, tpl2) => Create.Tuple(tpl._1() + tpl2._1(), tpl._2() + tpl2._2(), tpl._3() + tpl2._3(), tpl._4() + tpl2._4(), tpl._5() + tpl2._5(), tpl._6() + tpl2._6(), tpl._7() + tpl2._7(), tpl._8() + tpl2._8()))));
        }
#endregion
#region TryPick
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版TryPickが通常のTryPickと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1), Create.Tuple(2, 1), Create.Tuple(3, 3));;
            Assert.That(
                sut.TryPick((i1, i2) => i1 == i2 ? Option.Some(i2) : Option.None).ToString(),
                Is.EqualTo(sut.TryPick(tpl => tpl._1() == tpl._2() ? Option.Some(tpl._2()) : Option.None).ToString()));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版TryPickが通常のTryPickと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1), Create.Tuple(2, 1, 2), Create.Tuple(3, 3, 3));;
            Assert.That(
                sut.TryPick((i1, i2, i3) => i1 == i2 && i1 == i3 ? Option.Some(i3) : Option.None).ToString(),
                Is.EqualTo(sut.TryPick(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() ? Option.Some(tpl._3()) : Option.None).ToString()));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版TryPickが通常のTryPickと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1), Create.Tuple(2, 1, 2, 2), Create.Tuple(3, 3, 3, 3));;
            Assert.That(
                sut.TryPick((i1, i2, i3, i4) => i1 == i2 && i1 == i3 && i1 == i4 ? Option.Some(i4) : Option.None).ToString(),
                Is.EqualTo(sut.TryPick(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() ? Option.Some(tpl._4()) : Option.None).ToString()));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版TryPickが通常のTryPickと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryPick((i1, i2, i3, i4, i5) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 ? Option.Some(i5) : Option.None).ToString(),
                Is.EqualTo(sut.TryPick(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() ? Option.Some(tpl._5()) : Option.None).ToString()));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版TryPickが通常のTryPickと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryPick((i1, i2, i3, i4, i5, i6) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 ? Option.Some(i6) : Option.None).ToString(),
                Is.EqualTo(sut.TryPick(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() ? Option.Some(tpl._6()) : Option.None).ToString()));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版TryPickが通常のTryPickと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryPick((i1, i2, i3, i4, i5, i6, i7) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 ? Option.Some(i7) : Option.None).ToString(),
                Is.EqualTo(sut.TryPick(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() ? Option.Some(tpl._7()) : Option.None).ToString()));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版TryPickが通常のTryPickと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryPick((i1, i2, i3, i4, i5, i6, i7, i8) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 ? Option.Some(i8) : Option.None).ToString(),
                Is.EqualTo(sut.TryPick(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() ? Option.Some(tpl._8()) : Option.None).ToString()));
        }
        [Test]
        public void _9要素タプルのドラゴンパターンマッチ版TryPickが通常のTryPickと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryPick((i1, i2, i3, i4, i5, i6, i7, i8, i9) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 ? Option.Some(i9) : Option.None).ToString(),
                Is.EqualTo(sut.TryPick(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() ? Option.Some(tpl._9()) : Option.None).ToString()));
        }
        [Test]
        public void _10要素タプルのドラゴンパターンマッチ版TryPickが通常のTryPickと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryPick((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 ? Option.Some(i10) : Option.None).ToString(),
                Is.EqualTo(sut.TryPick(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() ? Option.Some(tpl._10()) : Option.None).ToString()));
        }
        [Test]
        public void _11要素タプルのドラゴンパターンマッチ版TryPickが通常のTryPickと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryPick((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 ? Option.Some(i11) : Option.None).ToString(),
                Is.EqualTo(sut.TryPick(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() ? Option.Some(tpl._11()) : Option.None).ToString()));
        }
        [Test]
        public void _12要素タプルのドラゴンパターンマッチ版TryPickが通常のTryPickと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryPick((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 ? Option.Some(i12) : Option.None).ToString(),
                Is.EqualTo(sut.TryPick(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() ? Option.Some(tpl._12()) : Option.None).ToString()));
        }
        [Test]
        public void _13要素タプルのドラゴンパターンマッチ版TryPickが通常のTryPickと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryPick((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 ? Option.Some(i13) : Option.None).ToString(),
                Is.EqualTo(sut.TryPick(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() ? Option.Some(tpl._13()) : Option.None).ToString()));
        }
        [Test]
        public void _14要素タプルのドラゴンパターンマッチ版TryPickが通常のTryPickと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryPick((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 ? Option.Some(i14) : Option.None).ToString(),
                Is.EqualTo(sut.TryPick(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() ? Option.Some(tpl._14()) : Option.None).ToString()));
        }
        [Test]
        public void _15要素タプルのドラゴンパターンマッチ版TryPickが通常のTryPickと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryPick((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15 ? Option.Some(i15) : Option.None).ToString(),
                Is.EqualTo(sut.TryPick(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15() ? Option.Some(tpl._15()) : Option.None).ToString()));
        }
        [Test]
        public void _16要素タプルのドラゴンパターンマッチ版TryPickが通常のTryPickと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.TryPick((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15 && i1 == i16 ? Option.Some(i16) : Option.None).ToString(),
                Is.EqualTo(sut.TryPick(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15() && tpl._1() == tpl._16() ? Option.Some(tpl._16()) : Option.None).ToString()));
        }
#endregion
#region Map
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版Mapが通常のMapと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1), Create.Tuple(2, 1), Create.Tuple(3, 3));;
            Assert.That(
                sut.Map((i1, i2) => i1 == i2 ? Option.Some(i2) : Option.None).ToString(),
                Is.EqualTo(sut.Map(tpl => tpl._1() == tpl._2() ? Option.Some(tpl._2()) : Option.None).ToString()));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版Mapが通常のMapと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1), Create.Tuple(2, 1, 2), Create.Tuple(3, 3, 3));;
            Assert.That(
                sut.Map((i1, i2, i3) => i1 == i2 && i1 == i3 ? Option.Some(i3) : Option.None).ToString(),
                Is.EqualTo(sut.Map(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() ? Option.Some(tpl._3()) : Option.None).ToString()));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版Mapが通常のMapと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1), Create.Tuple(2, 1, 2, 2), Create.Tuple(3, 3, 3, 3));;
            Assert.That(
                sut.Map((i1, i2, i3, i4) => i1 == i2 && i1 == i3 && i1 == i4 ? Option.Some(i4) : Option.None).ToString(),
                Is.EqualTo(sut.Map(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() ? Option.Some(tpl._4()) : Option.None).ToString()));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版Mapが通常のMapと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3));;
            Assert.That(
                sut.Map((i1, i2, i3, i4, i5) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 ? Option.Some(i5) : Option.None).ToString(),
                Is.EqualTo(sut.Map(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() ? Option.Some(tpl._5()) : Option.None).ToString()));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版Mapが通常のMapと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Map((i1, i2, i3, i4, i5, i6) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 ? Option.Some(i6) : Option.None).ToString(),
                Is.EqualTo(sut.Map(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() ? Option.Some(tpl._6()) : Option.None).ToString()));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版Mapが通常のMapと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Map((i1, i2, i3, i4, i5, i6, i7) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 ? Option.Some(i7) : Option.None).ToString(),
                Is.EqualTo(sut.Map(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() ? Option.Some(tpl._7()) : Option.None).ToString()));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版Mapが通常のMapと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Map((i1, i2, i3, i4, i5, i6, i7, i8) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 ? Option.Some(i8) : Option.None).ToString(),
                Is.EqualTo(sut.Map(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() ? Option.Some(tpl._8()) : Option.None).ToString()));
        }
        [Test]
        public void _9要素タプルのドラゴンパターンマッチ版Mapが通常のMapと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Map((i1, i2, i3, i4, i5, i6, i7, i8, i9) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 ? Option.Some(i9) : Option.None).ToString(),
                Is.EqualTo(sut.Map(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() ? Option.Some(tpl._9()) : Option.None).ToString()));
        }
        [Test]
        public void _10要素タプルのドラゴンパターンマッチ版Mapが通常のMapと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Map((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 ? Option.Some(i10) : Option.None).ToString(),
                Is.EqualTo(sut.Map(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() ? Option.Some(tpl._10()) : Option.None).ToString()));
        }
        [Test]
        public void _11要素タプルのドラゴンパターンマッチ版Mapが通常のMapと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Map((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 ? Option.Some(i11) : Option.None).ToString(),
                Is.EqualTo(sut.Map(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() ? Option.Some(tpl._11()) : Option.None).ToString()));
        }
        [Test]
        public void _12要素タプルのドラゴンパターンマッチ版Mapが通常のMapと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Map((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 ? Option.Some(i12) : Option.None).ToString(),
                Is.EqualTo(sut.Map(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() ? Option.Some(tpl._12()) : Option.None).ToString()));
        }
        [Test]
        public void _13要素タプルのドラゴンパターンマッチ版Mapが通常のMapと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Map((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 ? Option.Some(i13) : Option.None).ToString(),
                Is.EqualTo(sut.Map(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() ? Option.Some(tpl._13()) : Option.None).ToString()));
        }
        [Test]
        public void _14要素タプルのドラゴンパターンマッチ版Mapが通常のMapと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Map((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 ? Option.Some(i14) : Option.None).ToString(),
                Is.EqualTo(sut.Map(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() ? Option.Some(tpl._14()) : Option.None).ToString()));
        }
        [Test]
        public void _15要素タプルのドラゴンパターンマッチ版Mapが通常のMapと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Map((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15 ? Option.Some(i15) : Option.None).ToString(),
                Is.EqualTo(sut.Map(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15() ? Option.Some(tpl._15()) : Option.None).ToString()));
        }
        [Test]
        public void _16要素タプルのドラゴンパターンマッチ版Mapが通常のMapと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Map((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15 && i1 == i16 ? Option.Some(i16) : Option.None).ToString(),
                Is.EqualTo(sut.Map(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15() && tpl._1() == tpl._16() ? Option.Some(tpl._16()) : Option.None).ToString()));
        }
#endregion
#region Choose
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版Chooseが通常のChooseと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1), Create.Tuple(2, 1), Create.Tuple(3, 3));;
            Assert.That(
                sut.Choose((i1, i2) => i1 == i2 ? Option.Some(i2) : Option.None).ToString(),
                Is.EqualTo(sut.Choose(tpl => tpl._1() == tpl._2() ? Option.Some(tpl._2()) : Option.None).ToString()));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版Chooseが通常のChooseと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1), Create.Tuple(2, 1, 2), Create.Tuple(3, 3, 3));;
            Assert.That(
                sut.Choose((i1, i2, i3) => i1 == i2 && i1 == i3 ? Option.Some(i3) : Option.None).ToString(),
                Is.EqualTo(sut.Choose(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() ? Option.Some(tpl._3()) : Option.None).ToString()));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版Chooseが通常のChooseと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1), Create.Tuple(2, 1, 2, 2), Create.Tuple(3, 3, 3, 3));;
            Assert.That(
                sut.Choose((i1, i2, i3, i4) => i1 == i2 && i1 == i3 && i1 == i4 ? Option.Some(i4) : Option.None).ToString(),
                Is.EqualTo(sut.Choose(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() ? Option.Some(tpl._4()) : Option.None).ToString()));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版Chooseが通常のChooseと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3));;
            Assert.That(
                sut.Choose((i1, i2, i3, i4, i5) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 ? Option.Some(i5) : Option.None).ToString(),
                Is.EqualTo(sut.Choose(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() ? Option.Some(tpl._5()) : Option.None).ToString()));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版Chooseが通常のChooseと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Choose((i1, i2, i3, i4, i5, i6) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 ? Option.Some(i6) : Option.None).ToString(),
                Is.EqualTo(sut.Choose(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() ? Option.Some(tpl._6()) : Option.None).ToString()));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版Chooseが通常のChooseと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Choose((i1, i2, i3, i4, i5, i6, i7) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 ? Option.Some(i7) : Option.None).ToString(),
                Is.EqualTo(sut.Choose(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() ? Option.Some(tpl._7()) : Option.None).ToString()));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版Chooseが通常のChooseと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Choose((i1, i2, i3, i4, i5, i6, i7, i8) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 ? Option.Some(i8) : Option.None).ToString(),
                Is.EqualTo(sut.Choose(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() ? Option.Some(tpl._8()) : Option.None).ToString()));
        }
        [Test]
        public void _9要素タプルのドラゴンパターンマッチ版Chooseが通常のChooseと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Choose((i1, i2, i3, i4, i5, i6, i7, i8, i9) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 ? Option.Some(i9) : Option.None).ToString(),
                Is.EqualTo(sut.Choose(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() ? Option.Some(tpl._9()) : Option.None).ToString()));
        }
        [Test]
        public void _10要素タプルのドラゴンパターンマッチ版Chooseが通常のChooseと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Choose((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 ? Option.Some(i10) : Option.None).ToString(),
                Is.EqualTo(sut.Choose(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() ? Option.Some(tpl._10()) : Option.None).ToString()));
        }
        [Test]
        public void _11要素タプルのドラゴンパターンマッチ版Chooseが通常のChooseと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Choose((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 ? Option.Some(i11) : Option.None).ToString(),
                Is.EqualTo(sut.Choose(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() ? Option.Some(tpl._11()) : Option.None).ToString()));
        }
        [Test]
        public void _12要素タプルのドラゴンパターンマッチ版Chooseが通常のChooseと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Choose((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 ? Option.Some(i12) : Option.None).ToString(),
                Is.EqualTo(sut.Choose(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() ? Option.Some(tpl._12()) : Option.None).ToString()));
        }
        [Test]
        public void _13要素タプルのドラゴンパターンマッチ版Chooseが通常のChooseと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Choose((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 ? Option.Some(i13) : Option.None).ToString(),
                Is.EqualTo(sut.Choose(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() ? Option.Some(tpl._13()) : Option.None).ToString()));
        }
        [Test]
        public void _14要素タプルのドラゴンパターンマッチ版Chooseが通常のChooseと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Choose((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 ? Option.Some(i14) : Option.None).ToString(),
                Is.EqualTo(sut.Choose(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() ? Option.Some(tpl._14()) : Option.None).ToString()));
        }
        [Test]
        public void _15要素タプルのドラゴンパターンマッチ版Chooseが通常のChooseと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Choose((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15 ? Option.Some(i15) : Option.None).ToString(),
                Is.EqualTo(sut.Choose(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15() ? Option.Some(tpl._15()) : Option.None).ToString()));
        }
        [Test]
        public void _16要素タプルのドラゴンパターンマッチ版Chooseが通常のChooseと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Choose((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15 && i1 == i16 ? Option.Some(i16) : Option.None).ToString(),
                Is.EqualTo(sut.Choose(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15() && tpl._1() == tpl._16() ? Option.Some(tpl._16()) : Option.None).ToString()));
        }
#endregion
#region Iter
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版Iterが通常のIterと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1), Create.Tuple(2, 1), Create.Tuple(3, 3));;
            var res1 = 0;
            var res2 = 10;
            sut.Iter((i1, i2) => { res1 = i1 + i2; });
            sut.Iter(tpl => { res2 = tpl._1() + tpl._2(); });
            Assert.That(res1, Is.EqualTo(res2));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版Iterが通常のIterと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1), Create.Tuple(2, 1, 2), Create.Tuple(3, 3, 3));;
            var res1 = 0;
            var res2 = 10;
            sut.Iter((i1, i2, i3) => { res1 = i1 + i2 + i3; });
            sut.Iter(tpl => { res2 = tpl._1() + tpl._2() + tpl._3(); });
            Assert.That(res1, Is.EqualTo(res2));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版Iterが通常のIterと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1), Create.Tuple(2, 1, 2, 2), Create.Tuple(3, 3, 3, 3));;
            var res1 = 0;
            var res2 = 10;
            sut.Iter((i1, i2, i3, i4) => { res1 = i1 + i2 + i3 + i4; });
            sut.Iter(tpl => { res2 = tpl._1() + tpl._2() + tpl._3() + tpl._4(); });
            Assert.That(res1, Is.EqualTo(res2));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版Iterが通常のIterと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3));;
            var res1 = 0;
            var res2 = 10;
            sut.Iter((i1, i2, i3, i4, i5) => { res1 = i1 + i2 + i3 + i4 + i5; });
            sut.Iter(tpl => { res2 = tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5(); });
            Assert.That(res1, Is.EqualTo(res2));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版Iterが通常のIterと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3));;
            var res1 = 0;
            var res2 = 10;
            sut.Iter((i1, i2, i3, i4, i5, i6) => { res1 = i1 + i2 + i3 + i4 + i5 + i6; });
            sut.Iter(tpl => { res2 = tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6(); });
            Assert.That(res1, Is.EqualTo(res2));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版Iterが通常のIterと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3));;
            var res1 = 0;
            var res2 = 10;
            sut.Iter((i1, i2, i3, i4, i5, i6, i7) => { res1 = i1 + i2 + i3 + i4 + i5 + i6 + i7; });
            sut.Iter(tpl => { res2 = tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7(); });
            Assert.That(res1, Is.EqualTo(res2));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版Iterが通常のIterと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3));;
            var res1 = 0;
            var res2 = 10;
            sut.Iter((i1, i2, i3, i4, i5, i6, i7, i8) => { res1 = i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8; });
            sut.Iter(tpl => { res2 = tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8(); });
            Assert.That(res1, Is.EqualTo(res2));
        }
        [Test]
        public void _9要素タプルのドラゴンパターンマッチ版Iterが通常のIterと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3));;
            var res1 = 0;
            var res2 = 10;
            sut.Iter((i1, i2, i3, i4, i5, i6, i7, i8, i9) => { res1 = i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9; });
            sut.Iter(tpl => { res2 = tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9(); });
            Assert.That(res1, Is.EqualTo(res2));
        }
        [Test]
        public void _10要素タプルのドラゴンパターンマッチ版Iterが通常のIterと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            var res1 = 0;
            var res2 = 10;
            sut.Iter((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) => { res1 = i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10; });
            sut.Iter(tpl => { res2 = tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10(); });
            Assert.That(res1, Is.EqualTo(res2));
        }
        [Test]
        public void _11要素タプルのドラゴンパターンマッチ版Iterが通常のIterと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            var res1 = 0;
            var res2 = 10;
            sut.Iter((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) => { res1 = i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11; });
            sut.Iter(tpl => { res2 = tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11(); });
            Assert.That(res1, Is.EqualTo(res2));
        }
        [Test]
        public void _12要素タプルのドラゴンパターンマッチ版Iterが通常のIterと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            var res1 = 0;
            var res2 = 10;
            sut.Iter((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) => { res1 = i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12; });
            sut.Iter(tpl => { res2 = tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12(); });
            Assert.That(res1, Is.EqualTo(res2));
        }
        [Test]
        public void _13要素タプルのドラゴンパターンマッチ版Iterが通常のIterと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            var res1 = 0;
            var res2 = 10;
            sut.Iter((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) => { res1 = i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13; });
            sut.Iter(tpl => { res2 = tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13(); });
            Assert.That(res1, Is.EqualTo(res2));
        }
        [Test]
        public void _14要素タプルのドラゴンパターンマッチ版Iterが通常のIterと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            var res1 = 0;
            var res2 = 10;
            sut.Iter((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) => { res1 = i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14; });
            sut.Iter(tpl => { res2 = tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13() + tpl._14(); });
            Assert.That(res1, Is.EqualTo(res2));
        }
        [Test]
        public void _15要素タプルのドラゴンパターンマッチ版Iterが通常のIterと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            var res1 = 0;
            var res2 = 10;
            sut.Iter((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) => { res1 = i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14 + i15; });
            sut.Iter(tpl => { res2 = tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13() + tpl._14() + tpl._15(); });
            Assert.That(res1, Is.EqualTo(res2));
        }
        [Test]
        public void _16要素タプルのドラゴンパターンマッチ版Iterが通常のIterと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            var res1 = 0;
            var res2 = 10;
            sut.Iter((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16) => { res1 = i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14 + i15 + i16; });
            sut.Iter(tpl => { res2 = tpl._1() + tpl._2() + tpl._3() + tpl._4() + tpl._5() + tpl._6() + tpl._7() + tpl._8() + tpl._9() + tpl._10() + tpl._11() + tpl._12() + tpl._13() + tpl._14() + tpl._15() + tpl._16(); });
            Assert.That(res1, Is.EqualTo(res2));
        }
#endregion
#region Bind
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版Bindが通常のBindと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1), Create.Tuple(2, 1), Create.Tuple(3, 3));;
            Assert.That(
                sut.Bind((i1, i2) => Seq.Repeat(i2, i2)).ToString(),
                Is.EqualTo(sut.Bind(tpl => Seq.Repeat(tpl._2(), tpl._2())).ToString()));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版Bindが通常のBindと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1), Create.Tuple(2, 1, 2), Create.Tuple(3, 3, 3));;
            Assert.That(
                sut.Bind((i1, i2, i3) => Seq.Repeat(i2, i3)).ToString(),
                Is.EqualTo(sut.Bind(tpl => Seq.Repeat(tpl._2(), tpl._3())).ToString()));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版Bindが通常のBindと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1), Create.Tuple(2, 1, 2, 2), Create.Tuple(3, 3, 3, 3));;
            Assert.That(
                sut.Bind((i1, i2, i3, i4) => Seq.Repeat(i2, i4)).ToString(),
                Is.EqualTo(sut.Bind(tpl => Seq.Repeat(tpl._2(), tpl._4())).ToString()));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版Bindが通常のBindと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3));;
            Assert.That(
                sut.Bind((i1, i2, i3, i4, i5) => Seq.Repeat(i2, i5)).ToString(),
                Is.EqualTo(sut.Bind(tpl => Seq.Repeat(tpl._2(), tpl._5())).ToString()));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版Bindが通常のBindと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Bind((i1, i2, i3, i4, i5, i6) => Seq.Repeat(i2, i6)).ToString(),
                Is.EqualTo(sut.Bind(tpl => Seq.Repeat(tpl._2(), tpl._6())).ToString()));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版Bindが通常のBindと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Bind((i1, i2, i3, i4, i5, i6, i7) => Seq.Repeat(i2, i7)).ToString(),
                Is.EqualTo(sut.Bind(tpl => Seq.Repeat(tpl._2(), tpl._7())).ToString()));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版Bindが通常のBindと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Bind((i1, i2, i3, i4, i5, i6, i7, i8) => Seq.Repeat(i2, i8)).ToString(),
                Is.EqualTo(sut.Bind(tpl => Seq.Repeat(tpl._2(), tpl._8())).ToString()));
        }
        [Test]
        public void _9要素タプルのドラゴンパターンマッチ版Bindが通常のBindと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Bind((i1, i2, i3, i4, i5, i6, i7, i8, i9) => Seq.Repeat(i2, i9)).ToString(),
                Is.EqualTo(sut.Bind(tpl => Seq.Repeat(tpl._2(), tpl._9())).ToString()));
        }
        [Test]
        public void _10要素タプルのドラゴンパターンマッチ版Bindが通常のBindと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Bind((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) => Seq.Repeat(i2, i10)).ToString(),
                Is.EqualTo(sut.Bind(tpl => Seq.Repeat(tpl._2(), tpl._10())).ToString()));
        }
        [Test]
        public void _11要素タプルのドラゴンパターンマッチ版Bindが通常のBindと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Bind((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) => Seq.Repeat(i2, i11)).ToString(),
                Is.EqualTo(sut.Bind(tpl => Seq.Repeat(tpl._2(), tpl._11())).ToString()));
        }
        [Test]
        public void _12要素タプルのドラゴンパターンマッチ版Bindが通常のBindと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Bind((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) => Seq.Repeat(i2, i12)).ToString(),
                Is.EqualTo(sut.Bind(tpl => Seq.Repeat(tpl._2(), tpl._12())).ToString()));
        }
        [Test]
        public void _13要素タプルのドラゴンパターンマッチ版Bindが通常のBindと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Bind((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) => Seq.Repeat(i2, i13)).ToString(),
                Is.EqualTo(sut.Bind(tpl => Seq.Repeat(tpl._2(), tpl._13())).ToString()));
        }
        [Test]
        public void _14要素タプルのドラゴンパターンマッチ版Bindが通常のBindと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Bind((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) => Seq.Repeat(i2, i14)).ToString(),
                Is.EqualTo(sut.Bind(tpl => Seq.Repeat(tpl._2(), tpl._14())).ToString()));
        }
        [Test]
        public void _15要素タプルのドラゴンパターンマッチ版Bindが通常のBindと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Bind((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) => Seq.Repeat(i2, i15)).ToString(),
                Is.EqualTo(sut.Bind(tpl => Seq.Repeat(tpl._2(), tpl._15())).ToString()));
        }
        [Test]
        public void _16要素タプルのドラゴンパターンマッチ版Bindが通常のBindと同じ動作をする()
        {
            var sut = Create.Seq(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Create.Tuple(2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2), Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));;
            Assert.That(
                sut.Bind((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16) => Seq.Repeat(i2, i16)).ToString(),
                Is.EqualTo(sut.Bind(tpl => Seq.Repeat(tpl._2(), tpl._16())).ToString()));
        }
#endregion
    }
}
