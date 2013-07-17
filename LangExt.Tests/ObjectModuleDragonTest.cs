
using System;
using LangExt;
using NUnit.Framework;

namespace LangExt.Tests
{
    [TestFixture]
    public class ObjectModuleDragonTest
    {
#region NoneIf
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版NoneIfが通常のNoneIfと同じ動作をする()
        {
            var sut = Create.Tuple(3, 3);
            Assert.That(
                sut.NoneIf((i1, i2) => i1 == i2).ToString(),
                Is.EqualTo(sut.NoneIf(tpl => tpl._1() == tpl._2()).ToString()));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版NoneIfが通常のNoneIfと同じ動作をする()
        {
            var sut = Create.Tuple(3, 3, 3);
            Assert.That(
                sut.NoneIf((i1, i2, i3) => i1 == i2 && i1 == i3).ToString(),
                Is.EqualTo(sut.NoneIf(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3()).ToString()));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版NoneIfが通常のNoneIfと同じ動作をする()
        {
            var sut = Create.Tuple(3, 3, 3, 3);
            Assert.That(
                sut.NoneIf((i1, i2, i3, i4) => i1 == i2 && i1 == i3 && i1 == i4).ToString(),
                Is.EqualTo(sut.NoneIf(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4()).ToString()));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版NoneIfが通常のNoneIfと同じ動作をする()
        {
            var sut = Create.Tuple(3, 3, 3, 3, 3);
            Assert.That(
                sut.NoneIf((i1, i2, i3, i4, i5) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5).ToString(),
                Is.EqualTo(sut.NoneIf(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5()).ToString()));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版NoneIfが通常のNoneIfと同じ動作をする()
        {
            var sut = Create.Tuple(3, 3, 3, 3, 3, 3);
            Assert.That(
                sut.NoneIf((i1, i2, i3, i4, i5, i6) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6).ToString(),
                Is.EqualTo(sut.NoneIf(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6()).ToString()));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版NoneIfが通常のNoneIfと同じ動作をする()
        {
            var sut = Create.Tuple(3, 3, 3, 3, 3, 3, 3);
            Assert.That(
                sut.NoneIf((i1, i2, i3, i4, i5, i6, i7) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7).ToString(),
                Is.EqualTo(sut.NoneIf(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7()).ToString()));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版NoneIfが通常のNoneIfと同じ動作をする()
        {
            var sut = Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3);
            Assert.That(
                sut.NoneIf((i1, i2, i3, i4, i5, i6, i7, i8) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8).ToString(),
                Is.EqualTo(sut.NoneIf(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8()).ToString()));
        }
        [Test]
        public void _9要素タプルのドラゴンパターンマッチ版NoneIfが通常のNoneIfと同じ動作をする()
        {
            var sut = Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3);
            Assert.That(
                sut.NoneIf((i1, i2, i3, i4, i5, i6, i7, i8, i9) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9).ToString(),
                Is.EqualTo(sut.NoneIf(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9()).ToString()));
        }
        [Test]
        public void _10要素タプルのドラゴンパターンマッチ版NoneIfが通常のNoneIfと同じ動作をする()
        {
            var sut = Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3);
            Assert.That(
                sut.NoneIf((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10).ToString(),
                Is.EqualTo(sut.NoneIf(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10()).ToString()));
        }
        [Test]
        public void _11要素タプルのドラゴンパターンマッチ版NoneIfが通常のNoneIfと同じ動作をする()
        {
            var sut = Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3);
            Assert.That(
                sut.NoneIf((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11).ToString(),
                Is.EqualTo(sut.NoneIf(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11()).ToString()));
        }
        [Test]
        public void _12要素タプルのドラゴンパターンマッチ版NoneIfが通常のNoneIfと同じ動作をする()
        {
            var sut = Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3);
            Assert.That(
                sut.NoneIf((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12).ToString(),
                Is.EqualTo(sut.NoneIf(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12()).ToString()));
        }
        [Test]
        public void _13要素タプルのドラゴンパターンマッチ版NoneIfが通常のNoneIfと同じ動作をする()
        {
            var sut = Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3);
            Assert.That(
                sut.NoneIf((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13).ToString(),
                Is.EqualTo(sut.NoneIf(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13()).ToString()));
        }
        [Test]
        public void _14要素タプルのドラゴンパターンマッチ版NoneIfが通常のNoneIfと同じ動作をする()
        {
            var sut = Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3);
            Assert.That(
                sut.NoneIf((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14).ToString(),
                Is.EqualTo(sut.NoneIf(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14()).ToString()));
        }
        [Test]
        public void _15要素タプルのドラゴンパターンマッチ版NoneIfが通常のNoneIfと同じ動作をする()
        {
            var sut = Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3);
            Assert.That(
                sut.NoneIf((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15).ToString(),
                Is.EqualTo(sut.NoneIf(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15()).ToString()));
        }
        [Test]
        public void _16要素タプルのドラゴンパターンマッチ版NoneIfが通常のNoneIfと同じ動作をする()
        {
            var sut = Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3);
            Assert.That(
                sut.NoneIf((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15 && i1 == i16).ToString(),
                Is.EqualTo(sut.NoneIf(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15() && tpl._1() == tpl._16()).ToString()));
        }
#endregion
#region FailureIf
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版FailureIfが通常のFailureIfと同じ動作をする()
        {
            var sut = Create.Tuple(3, 3);
            Assert.That(
                sut.FailureIf((i1, i2) => i1 == i2).ToString(),
                Is.EqualTo(sut.FailureIf(tpl => tpl._1() == tpl._2()).ToString()));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版FailureIfが通常のFailureIfと同じ動作をする()
        {
            var sut = Create.Tuple(3, 3, 3);
            Assert.That(
                sut.FailureIf((i1, i2, i3) => i1 == i2 && i1 == i3).ToString(),
                Is.EqualTo(sut.FailureIf(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3()).ToString()));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版FailureIfが通常のFailureIfと同じ動作をする()
        {
            var sut = Create.Tuple(3, 3, 3, 3);
            Assert.That(
                sut.FailureIf((i1, i2, i3, i4) => i1 == i2 && i1 == i3 && i1 == i4).ToString(),
                Is.EqualTo(sut.FailureIf(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4()).ToString()));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版FailureIfが通常のFailureIfと同じ動作をする()
        {
            var sut = Create.Tuple(3, 3, 3, 3, 3);
            Assert.That(
                sut.FailureIf((i1, i2, i3, i4, i5) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5).ToString(),
                Is.EqualTo(sut.FailureIf(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5()).ToString()));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版FailureIfが通常のFailureIfと同じ動作をする()
        {
            var sut = Create.Tuple(3, 3, 3, 3, 3, 3);
            Assert.That(
                sut.FailureIf((i1, i2, i3, i4, i5, i6) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6).ToString(),
                Is.EqualTo(sut.FailureIf(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6()).ToString()));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版FailureIfが通常のFailureIfと同じ動作をする()
        {
            var sut = Create.Tuple(3, 3, 3, 3, 3, 3, 3);
            Assert.That(
                sut.FailureIf((i1, i2, i3, i4, i5, i6, i7) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7).ToString(),
                Is.EqualTo(sut.FailureIf(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7()).ToString()));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版FailureIfが通常のFailureIfと同じ動作をする()
        {
            var sut = Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3);
            Assert.That(
                sut.FailureIf((i1, i2, i3, i4, i5, i6, i7, i8) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8).ToString(),
                Is.EqualTo(sut.FailureIf(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8()).ToString()));
        }
        [Test]
        public void _9要素タプルのドラゴンパターンマッチ版FailureIfが通常のFailureIfと同じ動作をする()
        {
            var sut = Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3);
            Assert.That(
                sut.FailureIf((i1, i2, i3, i4, i5, i6, i7, i8, i9) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9).ToString(),
                Is.EqualTo(sut.FailureIf(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9()).ToString()));
        }
        [Test]
        public void _10要素タプルのドラゴンパターンマッチ版FailureIfが通常のFailureIfと同じ動作をする()
        {
            var sut = Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3);
            Assert.That(
                sut.FailureIf((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10).ToString(),
                Is.EqualTo(sut.FailureIf(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10()).ToString()));
        }
        [Test]
        public void _11要素タプルのドラゴンパターンマッチ版FailureIfが通常のFailureIfと同じ動作をする()
        {
            var sut = Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3);
            Assert.That(
                sut.FailureIf((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11).ToString(),
                Is.EqualTo(sut.FailureIf(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11()).ToString()));
        }
        [Test]
        public void _12要素タプルのドラゴンパターンマッチ版FailureIfが通常のFailureIfと同じ動作をする()
        {
            var sut = Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3);
            Assert.That(
                sut.FailureIf((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12).ToString(),
                Is.EqualTo(sut.FailureIf(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12()).ToString()));
        }
        [Test]
        public void _13要素タプルのドラゴンパターンマッチ版FailureIfが通常のFailureIfと同じ動作をする()
        {
            var sut = Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3);
            Assert.That(
                sut.FailureIf((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13).ToString(),
                Is.EqualTo(sut.FailureIf(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13()).ToString()));
        }
        [Test]
        public void _14要素タプルのドラゴンパターンマッチ版FailureIfが通常のFailureIfと同じ動作をする()
        {
            var sut = Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3);
            Assert.That(
                sut.FailureIf((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14).ToString(),
                Is.EqualTo(sut.FailureIf(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14()).ToString()));
        }
        [Test]
        public void _15要素タプルのドラゴンパターンマッチ版FailureIfが通常のFailureIfと同じ動作をする()
        {
            var sut = Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3);
            Assert.That(
                sut.FailureIf((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15).ToString(),
                Is.EqualTo(sut.FailureIf(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15()).ToString()));
        }
        [Test]
        public void _16要素タプルのドラゴンパターンマッチ版FailureIfが通常のFailureIfと同じ動作をする()
        {
            var sut = Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3);
            Assert.That(
                sut.FailureIf((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15 && i1 == i16).ToString(),
                Is.EqualTo(sut.FailureIf(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15() && tpl._1() == tpl._16()).ToString()));
        }
#endregion
    }
}
