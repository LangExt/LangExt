
using System;
using LangExt;
using NUnit.Framework;

namespace LangExt.Tests
{
    [TestFixture]
    public class FuncCurryTest
    {
        [Test]
        public void TestCurried()
        {
            var f2 = new Func<int, int, int>((i1, i2) => i1 + i2);
            Assert.That(f2.Curried().Uncurried()(1, 1), Is.EqualTo(2));
            Assert.That(Func.Uncurry(Func.Curry(f2))(1, 1), Is.EqualTo(2));
            var f3 = new Func<int, int, int, int>((i1, i2, i3) => i1 + i2 + i3);
            Assert.That(f3.Curried().Uncurried()(1, 1, 1), Is.EqualTo(3));
            Assert.That(Func.Uncurry(Func.Curry(f3))(1, 1, 1), Is.EqualTo(3));
            var f4 = new Func<int, int, int, int, int>((i1, i2, i3, i4) => i1 + i2 + i3 + i4);
            Assert.That(f4.Curried().Uncurried()(1, 1, 1, 1), Is.EqualTo(4));
            Assert.That(Func.Uncurry(Func.Curry(f4))(1, 1, 1, 1), Is.EqualTo(4));
            var f5 = new Func<int, int, int, int, int, int>((i1, i2, i3, i4, i5) => i1 + i2 + i3 + i4 + i5);
            Assert.That(f5.Curried().Uncurried()(1, 1, 1, 1, 1), Is.EqualTo(5));
            Assert.That(Func.Uncurry(Func.Curry(f5))(1, 1, 1, 1, 1), Is.EqualTo(5));
            var f6 = new Func<int, int, int, int, int, int, int>((i1, i2, i3, i4, i5, i6) => i1 + i2 + i3 + i4 + i5 + i6);
            Assert.That(f6.Curried().Uncurried()(1, 1, 1, 1, 1, 1), Is.EqualTo(6));
            Assert.That(Func.Uncurry(Func.Curry(f6))(1, 1, 1, 1, 1, 1), Is.EqualTo(6));
            var f7 = new Func<int, int, int, int, int, int, int, int>((i1, i2, i3, i4, i5, i6, i7) => i1 + i2 + i3 + i4 + i5 + i6 + i7);
            Assert.That(f7.Curried().Uncurried()(1, 1, 1, 1, 1, 1, 1), Is.EqualTo(7));
            Assert.That(Func.Uncurry(Func.Curry(f7))(1, 1, 1, 1, 1, 1, 1), Is.EqualTo(7));
            var f8 = new Func<int, int, int, int, int, int, int, int, int>((i1, i2, i3, i4, i5, i6, i7, i8) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8);
            Assert.That(f8.Curried().Uncurried()(1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(8));
            Assert.That(Func.Uncurry(Func.Curry(f8))(1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(8));
            var f9 = new Func<int, int, int, int, int, int, int, int, int, int>((i1, i2, i3, i4, i5, i6, i7, i8, i9) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9);
            Assert.That(f9.Curried().Uncurried()(1, 1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(9));
            Assert.That(Func.Uncurry(Func.Curry(f9))(1, 1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(9));
            var f10 = new Func<int, int, int, int, int, int, int, int, int, int, int>((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10);
            Assert.That(f10.Curried().Uncurried()(1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(10));
            Assert.That(Func.Uncurry(Func.Curry(f10))(1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(10));
            var f11 = new Func<int, int, int, int, int, int, int, int, int, int, int, int>((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11);
            Assert.That(f11.Curried().Uncurried()(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(11));
            Assert.That(Func.Uncurry(Func.Curry(f11))(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(11));
            var f12 = new Func<int, int, int, int, int, int, int, int, int, int, int, int, int>((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12);
            Assert.That(f12.Curried().Uncurried()(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(12));
            Assert.That(Func.Uncurry(Func.Curry(f12))(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(12));
            var f13 = new Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int>((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13);
            Assert.That(f13.Curried().Uncurried()(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(13));
            Assert.That(Func.Uncurry(Func.Curry(f13))(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(13));
            var f14 = new Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14);
            Assert.That(f14.Curried().Uncurried()(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(14));
            Assert.That(Func.Uncurry(Func.Curry(f14))(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(14));
            var f15 = new Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14 + i15);
            Assert.That(f15.Curried().Uncurried()(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(15));
            Assert.That(Func.Uncurry(Func.Curry(f15))(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(15));
            var f16 = new Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14 + i15 + i16);
            Assert.That(f16.Curried().Uncurried()(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(16));
            Assert.That(Func.Uncurry(Func.Curry(f16))(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(16));
        }

        [Test]
        public void TestCurriedX()
        {
            var f2 = new Func<Tuple<int, int>, int>(tpl => tpl.Match((i1, i2) => i1 + i2));
            Assert.That(f2.CurriedX().UncurriedX()(Create.Tuple(1, 1)), Is.EqualTo(2));
            Assert.That(Func.UncurryX(Func.CurryX(f2))(Create.Tuple(1, 1)), Is.EqualTo(2));
            var f3 = new Func<Tuple<int, int, int>, int>(tpl => tpl.Match((i1, i2, i3) => i1 + i2 + i3));
            Assert.That(f3.CurriedX().UncurriedX()(Create.Tuple(1, 1, 1)), Is.EqualTo(3));
            Assert.That(Func.UncurryX(Func.CurryX(f3))(Create.Tuple(1, 1, 1)), Is.EqualTo(3));
            var f4 = new Func<Tuple<int, int, int, int>, int>(tpl => tpl.Match((i1, i2, i3, i4) => i1 + i2 + i3 + i4));
            Assert.That(f4.CurriedX().UncurriedX()(Create.Tuple(1, 1, 1, 1)), Is.EqualTo(4));
            Assert.That(Func.UncurryX(Func.CurryX(f4))(Create.Tuple(1, 1, 1, 1)), Is.EqualTo(4));
            var f5 = new Func<Tuple<int, int, int, int, int>, int>(tpl => tpl.Match((i1, i2, i3, i4, i5) => i1 + i2 + i3 + i4 + i5));
            Assert.That(f5.CurriedX().UncurriedX()(Create.Tuple(1, 1, 1, 1, 1)), Is.EqualTo(5));
            Assert.That(Func.UncurryX(Func.CurryX(f5))(Create.Tuple(1, 1, 1, 1, 1)), Is.EqualTo(5));
            var f6 = new Func<Tuple<int, int, int, int, int, int>, int>(tpl => tpl.Match((i1, i2, i3, i4, i5, i6) => i1 + i2 + i3 + i4 + i5 + i6));
            Assert.That(f6.CurriedX().UncurriedX()(Create.Tuple(1, 1, 1, 1, 1, 1)), Is.EqualTo(6));
            Assert.That(Func.UncurryX(Func.CurryX(f6))(Create.Tuple(1, 1, 1, 1, 1, 1)), Is.EqualTo(6));
            var f7 = new Func<Tuple<int, int, int, int, int, int, int>, int>(tpl => tpl.Match((i1, i2, i3, i4, i5, i6, i7) => i1 + i2 + i3 + i4 + i5 + i6 + i7));
            Assert.That(f7.CurriedX().UncurriedX()(Create.Tuple(1, 1, 1, 1, 1, 1, 1)), Is.EqualTo(7));
            Assert.That(Func.UncurryX(Func.CurryX(f7))(Create.Tuple(1, 1, 1, 1, 1, 1, 1)), Is.EqualTo(7));
            var f8 = new Func<Tuple<int, int, int, int, int, int, int, Tuple<int>>, int>(tpl => tpl.Match((i1, i2, i3, i4, i5, i6, i7, i8) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8));
            Assert.That(f8.CurriedX().UncurriedX()(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1)), Is.EqualTo(8));
            Assert.That(Func.UncurryX(Func.CurryX(f8))(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1)), Is.EqualTo(8));
            var f9 = new Func<Tuple<int, int, int, int, int, int, int, Tuple<int, int>>, int>(tpl => tpl.Match((i1, i2, i3, i4, i5, i6, i7, i8, i9) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9));
            Assert.That(f9.CurriedX().UncurriedX()(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1)), Is.EqualTo(9));
            Assert.That(Func.UncurryX(Func.CurryX(f9))(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1)), Is.EqualTo(9));
            var f10 = new Func<Tuple<int, int, int, int, int, int, int, Tuple<int, int, int>>, int>(tpl => tpl.Match((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10));
            Assert.That(f10.CurriedX().UncurriedX()(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1)), Is.EqualTo(10));
            Assert.That(Func.UncurryX(Func.CurryX(f10))(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1)), Is.EqualTo(10));
            var f11 = new Func<Tuple<int, int, int, int, int, int, int, Tuple<int, int, int, int>>, int>(tpl => tpl.Match((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11));
            Assert.That(f11.CurriedX().UncurriedX()(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)), Is.EqualTo(11));
            Assert.That(Func.UncurryX(Func.CurryX(f11))(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)), Is.EqualTo(11));
            var f12 = new Func<Tuple<int, int, int, int, int, int, int, Tuple<int, int, int, int, int>>, int>(tpl => tpl.Match((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12));
            Assert.That(f12.CurriedX().UncurriedX()(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)), Is.EqualTo(12));
            Assert.That(Func.UncurryX(Func.CurryX(f12))(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)), Is.EqualTo(12));
            var f13 = new Func<Tuple<int, int, int, int, int, int, int, Tuple<int, int, int, int, int, int>>, int>(tpl => tpl.Match((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13));
            Assert.That(f13.CurriedX().UncurriedX()(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)), Is.EqualTo(13));
            Assert.That(Func.UncurryX(Func.CurryX(f13))(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)), Is.EqualTo(13));
            var f14 = new Func<Tuple<int, int, int, int, int, int, int, Tuple<int, int, int, int, int, int, int>>, int>(tpl => tpl.Match((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14));
            Assert.That(f14.CurriedX().UncurriedX()(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)), Is.EqualTo(14));
            Assert.That(Func.UncurryX(Func.CurryX(f14))(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)), Is.EqualTo(14));
            var f15 = new Func<Tuple<int, int, int, int, int, int, int, Tuple<int, int, int, int, int, int, int, Tuple<int>>>, int>(tpl => tpl.Match((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14 + i15));
            Assert.That(f15.CurriedX().UncurriedX()(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)), Is.EqualTo(15));
            Assert.That(Func.UncurryX(Func.CurryX(f15))(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)), Is.EqualTo(15));
            var f16 = new Func<Tuple<int, int, int, int, int, int, int, Tuple<int, int, int, int, int, int, int, Tuple<int, int>>>, int>(tpl => tpl.Match((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14 + i15 + i16));
            Assert.That(f16.CurriedX().UncurriedX()(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)), Is.EqualTo(16));
            Assert.That(Func.UncurryX(Func.CurryX(f16))(Create.Tuple(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)), Is.EqualTo(16));
        }

        [Test]
        public void TestTupled()
        {
            var f2 = new Func<int, int, int>((i1, i2) => i1 + i2);
            Assert.That(f2.Tupled().Untupled()(1, 1), Is.EqualTo(2));
            Assert.That(Func.Untuple(Func.Tuple(f2))(1, 1), Is.EqualTo(2));
            var f3 = new Func<int, int, int, int>((i1, i2, i3) => i1 + i2 + i3);
            Assert.That(f3.Tupled().Untupled()(1, 1, 1), Is.EqualTo(3));
            Assert.That(Func.Untuple(Func.Tuple(f3))(1, 1, 1), Is.EqualTo(3));
            var f4 = new Func<int, int, int, int, int>((i1, i2, i3, i4) => i1 + i2 + i3 + i4);
            Assert.That(f4.Tupled().Untupled()(1, 1, 1, 1), Is.EqualTo(4));
            Assert.That(Func.Untuple(Func.Tuple(f4))(1, 1, 1, 1), Is.EqualTo(4));
            var f5 = new Func<int, int, int, int, int, int>((i1, i2, i3, i4, i5) => i1 + i2 + i3 + i4 + i5);
            Assert.That(f5.Tupled().Untupled()(1, 1, 1, 1, 1), Is.EqualTo(5));
            Assert.That(Func.Untuple(Func.Tuple(f5))(1, 1, 1, 1, 1), Is.EqualTo(5));
            var f6 = new Func<int, int, int, int, int, int, int>((i1, i2, i3, i4, i5, i6) => i1 + i2 + i3 + i4 + i5 + i6);
            Assert.That(f6.Tupled().Untupled()(1, 1, 1, 1, 1, 1), Is.EqualTo(6));
            Assert.That(Func.Untuple(Func.Tuple(f6))(1, 1, 1, 1, 1, 1), Is.EqualTo(6));
            var f7 = new Func<int, int, int, int, int, int, int, int>((i1, i2, i3, i4, i5, i6, i7) => i1 + i2 + i3 + i4 + i5 + i6 + i7);
            Assert.That(f7.Tupled().Untupled()(1, 1, 1, 1, 1, 1, 1), Is.EqualTo(7));
            Assert.That(Func.Untuple(Func.Tuple(f7))(1, 1, 1, 1, 1, 1, 1), Is.EqualTo(7));
            var f8 = new Func<int, int, int, int, int, int, int, int, int>((i1, i2, i3, i4, i5, i6, i7, i8) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8);
            Assert.That(f8.Tupled().Untupled()(1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(8));
            Assert.That(Func.Untuple(Func.Tuple(f8))(1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(8));
            var f9 = new Func<int, int, int, int, int, int, int, int, int, int>((i1, i2, i3, i4, i5, i6, i7, i8, i9) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9);
            Assert.That(f9.Tupled().Untupled()(1, 1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(9));
            Assert.That(Func.Untuple(Func.Tuple(f9))(1, 1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(9));
            var f10 = new Func<int, int, int, int, int, int, int, int, int, int, int>((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10);
            Assert.That(f10.Tupled().Untupled()(1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(10));
            Assert.That(Func.Untuple(Func.Tuple(f10))(1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(10));
            var f11 = new Func<int, int, int, int, int, int, int, int, int, int, int, int>((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11);
            Assert.That(f11.Tupled().Untupled()(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(11));
            Assert.That(Func.Untuple(Func.Tuple(f11))(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(11));
            var f12 = new Func<int, int, int, int, int, int, int, int, int, int, int, int, int>((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12);
            Assert.That(f12.Tupled().Untupled()(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(12));
            Assert.That(Func.Untuple(Func.Tuple(f12))(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(12));
            var f13 = new Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int>((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13);
            Assert.That(f13.Tupled().Untupled()(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(13));
            Assert.That(Func.Untuple(Func.Tuple(f13))(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(13));
            var f14 = new Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14);
            Assert.That(f14.Tupled().Untupled()(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(14));
            Assert.That(Func.Untuple(Func.Tuple(f14))(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(14));
            var f15 = new Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14 + i15);
            Assert.That(f15.Tupled().Untupled()(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(15));
            Assert.That(Func.Untuple(Func.Tuple(f15))(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(15));
            var f16 = new Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14 + i15 + i16);
            Assert.That(f16.Tupled().Untupled()(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(16));
            Assert.That(Func.Untuple(Func.Tuple(f16))(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1), Is.EqualTo(16));
        }
    }
}