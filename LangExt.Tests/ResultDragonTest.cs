
using System;
using LangExt;
using NUnit.Framework;

namespace LangExt.Tests
{
    [TestFixture]
    public class ResultDragonTest
    {
#region Count
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版Countが通常のCountと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3));
            Assert.That(
                sut.Count((i1, i2) => i1 == i2).ToString(),
                Is.EqualTo(sut.Count(tpl => tpl._1() == tpl._2()).ToString()));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版Countが通常のCountと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3));
            Assert.That(
                sut.Count((i1, i2, i3) => i1 == i2 && i1 == i3).ToString(),
                Is.EqualTo(sut.Count(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3()).ToString()));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版Countが通常のCountと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3));
            Assert.That(
                sut.Count((i1, i2, i3, i4) => i1 == i2 && i1 == i3 && i1 == i4).ToString(),
                Is.EqualTo(sut.Count(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4()).ToString()));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版Countが通常のCountと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3));
            Assert.That(
                sut.Count((i1, i2, i3, i4, i5) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5).ToString(),
                Is.EqualTo(sut.Count(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5()).ToString()));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版Countが通常のCountと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3, 3));
            Assert.That(
                sut.Count((i1, i2, i3, i4, i5, i6) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6).ToString(),
                Is.EqualTo(sut.Count(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6()).ToString()));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版Countが通常のCountと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3, 3, 3));
            Assert.That(
                sut.Count((i1, i2, i3, i4, i5, i6, i7) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7).ToString(),
                Is.EqualTo(sut.Count(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7()).ToString()));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版Countが通常のCountと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3));
            Assert.That(
                sut.Count((i1, i2, i3, i4, i5, i6, i7, i8) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8).ToString(),
                Is.EqualTo(sut.Count(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8()).ToString()));
        }
        [Test]
        public void _9要素タプルのドラゴンパターンマッチ版Countが通常のCountと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3));
            Assert.That(
                sut.Count((i1, i2, i3, i4, i5, i6, i7, i8, i9) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9).ToString(),
                Is.EqualTo(sut.Count(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9()).ToString()));
        }
        [Test]
        public void _10要素タプルのドラゴンパターンマッチ版Countが通常のCountと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3));
            Assert.That(
                sut.Count((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10).ToString(),
                Is.EqualTo(sut.Count(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10()).ToString()));
        }
        [Test]
        public void _11要素タプルのドラゴンパターンマッチ版Countが通常のCountと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));
            Assert.That(
                sut.Count((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11).ToString(),
                Is.EqualTo(sut.Count(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11()).ToString()));
        }
        [Test]
        public void _12要素タプルのドラゴンパターンマッチ版Countが通常のCountと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));
            Assert.That(
                sut.Count((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12).ToString(),
                Is.EqualTo(sut.Count(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12()).ToString()));
        }
        [Test]
        public void _13要素タプルのドラゴンパターンマッチ版Countが通常のCountと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));
            Assert.That(
                sut.Count((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13).ToString(),
                Is.EqualTo(sut.Count(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13()).ToString()));
        }
        [Test]
        public void _14要素タプルのドラゴンパターンマッチ版Countが通常のCountと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));
            Assert.That(
                sut.Count((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14).ToString(),
                Is.EqualTo(sut.Count(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14()).ToString()));
        }
        [Test]
        public void _15要素タプルのドラゴンパターンマッチ版Countが通常のCountと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));
            Assert.That(
                sut.Count((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15).ToString(),
                Is.EqualTo(sut.Count(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15()).ToString()));
        }
        [Test]
        public void _16要素タプルのドラゴンパターンマッチ版Countが通常のCountと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));
            Assert.That(
                sut.Count((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15 && i1 == i16).ToString(),
                Is.EqualTo(sut.Count(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15() && tpl._1() == tpl._16()).ToString()));
        }
#endregion
#region Forall
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版Forallが通常のForallと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3));
            Assert.That(
                sut.Forall((i1, i2) => i1 == i2).ToString(),
                Is.EqualTo(sut.Forall(tpl => tpl._1() == tpl._2()).ToString()));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版Forallが通常のForallと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3));
            Assert.That(
                sut.Forall((i1, i2, i3) => i1 == i2 && i1 == i3).ToString(),
                Is.EqualTo(sut.Forall(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3()).ToString()));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版Forallが通常のForallと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3));
            Assert.That(
                sut.Forall((i1, i2, i3, i4) => i1 == i2 && i1 == i3 && i1 == i4).ToString(),
                Is.EqualTo(sut.Forall(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4()).ToString()));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版Forallが通常のForallと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3));
            Assert.That(
                sut.Forall((i1, i2, i3, i4, i5) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5).ToString(),
                Is.EqualTo(sut.Forall(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5()).ToString()));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版Forallが通常のForallと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3, 3));
            Assert.That(
                sut.Forall((i1, i2, i3, i4, i5, i6) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6).ToString(),
                Is.EqualTo(sut.Forall(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6()).ToString()));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版Forallが通常のForallと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3, 3, 3));
            Assert.That(
                sut.Forall((i1, i2, i3, i4, i5, i6, i7) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7).ToString(),
                Is.EqualTo(sut.Forall(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7()).ToString()));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版Forallが通常のForallと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3));
            Assert.That(
                sut.Forall((i1, i2, i3, i4, i5, i6, i7, i8) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8).ToString(),
                Is.EqualTo(sut.Forall(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8()).ToString()));
        }
        [Test]
        public void _9要素タプルのドラゴンパターンマッチ版Forallが通常のForallと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3));
            Assert.That(
                sut.Forall((i1, i2, i3, i4, i5, i6, i7, i8, i9) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9).ToString(),
                Is.EqualTo(sut.Forall(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9()).ToString()));
        }
        [Test]
        public void _10要素タプルのドラゴンパターンマッチ版Forallが通常のForallと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3));
            Assert.That(
                sut.Forall((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10).ToString(),
                Is.EqualTo(sut.Forall(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10()).ToString()));
        }
        [Test]
        public void _11要素タプルのドラゴンパターンマッチ版Forallが通常のForallと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));
            Assert.That(
                sut.Forall((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11).ToString(),
                Is.EqualTo(sut.Forall(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11()).ToString()));
        }
        [Test]
        public void _12要素タプルのドラゴンパターンマッチ版Forallが通常のForallと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));
            Assert.That(
                sut.Forall((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12).ToString(),
                Is.EqualTo(sut.Forall(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12()).ToString()));
        }
        [Test]
        public void _13要素タプルのドラゴンパターンマッチ版Forallが通常のForallと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));
            Assert.That(
                sut.Forall((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13).ToString(),
                Is.EqualTo(sut.Forall(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13()).ToString()));
        }
        [Test]
        public void _14要素タプルのドラゴンパターンマッチ版Forallが通常のForallと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));
            Assert.That(
                sut.Forall((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14).ToString(),
                Is.EqualTo(sut.Forall(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14()).ToString()));
        }
        [Test]
        public void _15要素タプルのドラゴンパターンマッチ版Forallが通常のForallと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));
            Assert.That(
                sut.Forall((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15).ToString(),
                Is.EqualTo(sut.Forall(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15()).ToString()));
        }
        [Test]
        public void _16要素タプルのドラゴンパターンマッチ版Forallが通常のForallと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));
            Assert.That(
                sut.Forall((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15 && i1 == i16).ToString(),
                Is.EqualTo(sut.Forall(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15() && tpl._1() == tpl._16()).ToString()));
        }
#endregion
#region Exists
        [Test]
        public void _2要素タプルのドラゴンパターンマッチ版Existsが通常のExistsと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3));
            Assert.That(
                sut.Exists((i1, i2) => i1 == i2).ToString(),
                Is.EqualTo(sut.Exists(tpl => tpl._1() == tpl._2()).ToString()));
        }
        [Test]
        public void _3要素タプルのドラゴンパターンマッチ版Existsが通常のExistsと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3));
            Assert.That(
                sut.Exists((i1, i2, i3) => i1 == i2 && i1 == i3).ToString(),
                Is.EqualTo(sut.Exists(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3()).ToString()));
        }
        [Test]
        public void _4要素タプルのドラゴンパターンマッチ版Existsが通常のExistsと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3));
            Assert.That(
                sut.Exists((i1, i2, i3, i4) => i1 == i2 && i1 == i3 && i1 == i4).ToString(),
                Is.EqualTo(sut.Exists(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4()).ToString()));
        }
        [Test]
        public void _5要素タプルのドラゴンパターンマッチ版Existsが通常のExistsと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3));
            Assert.That(
                sut.Exists((i1, i2, i3, i4, i5) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5).ToString(),
                Is.EqualTo(sut.Exists(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5()).ToString()));
        }
        [Test]
        public void _6要素タプルのドラゴンパターンマッチ版Existsが通常のExistsと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3, 3));
            Assert.That(
                sut.Exists((i1, i2, i3, i4, i5, i6) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6).ToString(),
                Is.EqualTo(sut.Exists(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6()).ToString()));
        }
        [Test]
        public void _7要素タプルのドラゴンパターンマッチ版Existsが通常のExistsと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3, 3, 3));
            Assert.That(
                sut.Exists((i1, i2, i3, i4, i5, i6, i7) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7).ToString(),
                Is.EqualTo(sut.Exists(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7()).ToString()));
        }
        [Test]
        public void _8要素タプルのドラゴンパターンマッチ版Existsが通常のExistsと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3));
            Assert.That(
                sut.Exists((i1, i2, i3, i4, i5, i6, i7, i8) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8).ToString(),
                Is.EqualTo(sut.Exists(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8()).ToString()));
        }
        [Test]
        public void _9要素タプルのドラゴンパターンマッチ版Existsが通常のExistsと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3));
            Assert.That(
                sut.Exists((i1, i2, i3, i4, i5, i6, i7, i8, i9) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9).ToString(),
                Is.EqualTo(sut.Exists(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9()).ToString()));
        }
        [Test]
        public void _10要素タプルのドラゴンパターンマッチ版Existsが通常のExistsと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3));
            Assert.That(
                sut.Exists((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10).ToString(),
                Is.EqualTo(sut.Exists(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10()).ToString()));
        }
        [Test]
        public void _11要素タプルのドラゴンパターンマッチ版Existsが通常のExistsと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));
            Assert.That(
                sut.Exists((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11).ToString(),
                Is.EqualTo(sut.Exists(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11()).ToString()));
        }
        [Test]
        public void _12要素タプルのドラゴンパターンマッチ版Existsが通常のExistsと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));
            Assert.That(
                sut.Exists((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12).ToString(),
                Is.EqualTo(sut.Exists(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12()).ToString()));
        }
        [Test]
        public void _13要素タプルのドラゴンパターンマッチ版Existsが通常のExistsと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));
            Assert.That(
                sut.Exists((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13).ToString(),
                Is.EqualTo(sut.Exists(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13()).ToString()));
        }
        [Test]
        public void _14要素タプルのドラゴンパターンマッチ版Existsが通常のExistsと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));
            Assert.That(
                sut.Exists((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14).ToString(),
                Is.EqualTo(sut.Exists(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14()).ToString()));
        }
        [Test]
        public void _15要素タプルのドラゴンパターンマッチ版Existsが通常のExistsと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));
            Assert.That(
                sut.Exists((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15).ToString(),
                Is.EqualTo(sut.Exists(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15()).ToString()));
        }
        [Test]
        public void _16要素タプルのドラゴンパターンマッチ版Existsが通常のExistsと同じ動作をする()
        {
            var sut = Result.Success(Create.Tuple(3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3));
            Assert.That(
                sut.Exists((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16) => i1 == i2 && i1 == i3 && i1 == i4 && i1 == i5 && i1 == i6 && i1 == i7 && i1 == i8 && i1 == i9 && i1 == i10 && i1 == i11 && i1 == i12 && i1 == i13 && i1 == i14 && i1 == i15 && i1 == i16).ToString(),
                Is.EqualTo(sut.Exists(tpl => tpl._1() == tpl._2() && tpl._1() == tpl._3() && tpl._1() == tpl._4() && tpl._1() == tpl._5() && tpl._1() == tpl._6() && tpl._1() == tpl._7() && tpl._1() == tpl._8() && tpl._1() == tpl._9() && tpl._1() == tpl._10() && tpl._1() == tpl._11() && tpl._1() == tpl._12() && tpl._1() == tpl._13() && tpl._1() == tpl._14() && tpl._1() == tpl._15() && tpl._1() == tpl._16()).ToString()));
        }
#endregion
    }
}
