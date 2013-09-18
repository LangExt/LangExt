
using System;
using LangExt;
using NUnit.Framework;

namespace LangExt.Tests
{
    [TestFixture]
    public class FuncCreateTest
    {
        [Test]
        public void TestFuncCreate()
        {
            var f1 = Func.Create((int i1) => i1);
            Assert.That(f1(1), Is.EqualTo(1));
            var f2 = Func.Create((int i1, int i2) => i1 + i2);
            Assert.That(f2(1, 2), Is.EqualTo(3));
            var f3 = Func.Create((int i1, int i2, int i3) => i1 + i2 + i3);
            Assert.That(f3(1, 2, 3), Is.EqualTo(6));
            var f4 = Func.Create((int i1, int i2, int i3, int i4) => i1 + i2 + i3 + i4);
            Assert.That(f4(1, 2, 3, 4), Is.EqualTo(10));
            var f5 = Func.Create((int i1, int i2, int i3, int i4, int i5) => i1 + i2 + i3 + i4 + i5);
            Assert.That(f5(1, 2, 3, 4, 5), Is.EqualTo(15));
            var f6 = Func.Create((int i1, int i2, int i3, int i4, int i5, int i6) => i1 + i2 + i3 + i4 + i5 + i6);
            Assert.That(f6(1, 2, 3, 4, 5, 6), Is.EqualTo(21));
            var f7 = Func.Create((int i1, int i2, int i3, int i4, int i5, int i6, int i7) => i1 + i2 + i3 + i4 + i5 + i6 + i7);
            Assert.That(f7(1, 2, 3, 4, 5, 6, 7), Is.EqualTo(28));
            var f8 = Func.Create((int i1, int i2, int i3, int i4, int i5, int i6, int i7, int i8) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8);
            Assert.That(f8(1, 2, 3, 4, 5, 6, 7, 8), Is.EqualTo(36));
            var f9 = Func.Create((int i1, int i2, int i3, int i4, int i5, int i6, int i7, int i8, int i9) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9);
            Assert.That(f9(1, 2, 3, 4, 5, 6, 7, 8, 9), Is.EqualTo(45));
            var f10 = Func.Create((int i1, int i2, int i3, int i4, int i5, int i6, int i7, int i8, int i9, int i10) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10);
            Assert.That(f10(1, 2, 3, 4, 5, 6, 7, 8, 9, 10), Is.EqualTo(55));
            var f11 = Func.Create((int i1, int i2, int i3, int i4, int i5, int i6, int i7, int i8, int i9, int i10, int i11) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11);
            Assert.That(f11(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11), Is.EqualTo(66));
            var f12 = Func.Create((int i1, int i2, int i3, int i4, int i5, int i6, int i7, int i8, int i9, int i10, int i11, int i12) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12);
            Assert.That(f12(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12), Is.EqualTo(78));
            var f13 = Func.Create((int i1, int i2, int i3, int i4, int i5, int i6, int i7, int i8, int i9, int i10, int i11, int i12, int i13) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13);
            Assert.That(f13(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13), Is.EqualTo(91));
            var f14 = Func.Create((int i1, int i2, int i3, int i4, int i5, int i6, int i7, int i8, int i9, int i10, int i11, int i12, int i13, int i14) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14);
            Assert.That(f14(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14), Is.EqualTo(105));
            var f15 = Func.Create((int i1, int i2, int i3, int i4, int i5, int i6, int i7, int i8, int i9, int i10, int i11, int i12, int i13, int i14, int i15) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14 + i15);
            Assert.That(f15(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15), Is.EqualTo(120));
            var f16 = Func.Create((int i1, int i2, int i3, int i4, int i5, int i6, int i7, int i8, int i9, int i10, int i11, int i12, int i13, int i14, int i15, int i16) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14 + i15 + i16);
            Assert.That(f16(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16), Is.EqualTo(136));
        }

        [Test]
        public void TestCreateFunc()
        {
            var f1 = Create.Func((int i1) => i1);
            Assert.That(f1(1), Is.EqualTo(1));
            var f2 = Create.Func((int i1, int i2) => i1 + i2);
            Assert.That(f2(1, 2), Is.EqualTo(3));
            var f3 = Create.Func((int i1, int i2, int i3) => i1 + i2 + i3);
            Assert.That(f3(1, 2, 3), Is.EqualTo(6));
            var f4 = Create.Func((int i1, int i2, int i3, int i4) => i1 + i2 + i3 + i4);
            Assert.That(f4(1, 2, 3, 4), Is.EqualTo(10));
            var f5 = Create.Func((int i1, int i2, int i3, int i4, int i5) => i1 + i2 + i3 + i4 + i5);
            Assert.That(f5(1, 2, 3, 4, 5), Is.EqualTo(15));
            var f6 = Create.Func((int i1, int i2, int i3, int i4, int i5, int i6) => i1 + i2 + i3 + i4 + i5 + i6);
            Assert.That(f6(1, 2, 3, 4, 5, 6), Is.EqualTo(21));
            var f7 = Create.Func((int i1, int i2, int i3, int i4, int i5, int i6, int i7) => i1 + i2 + i3 + i4 + i5 + i6 + i7);
            Assert.That(f7(1, 2, 3, 4, 5, 6, 7), Is.EqualTo(28));
            var f8 = Create.Func((int i1, int i2, int i3, int i4, int i5, int i6, int i7, int i8) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8);
            Assert.That(f8(1, 2, 3, 4, 5, 6, 7, 8), Is.EqualTo(36));
            var f9 = Create.Func((int i1, int i2, int i3, int i4, int i5, int i6, int i7, int i8, int i9) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9);
            Assert.That(f9(1, 2, 3, 4, 5, 6, 7, 8, 9), Is.EqualTo(45));
            var f10 = Create.Func((int i1, int i2, int i3, int i4, int i5, int i6, int i7, int i8, int i9, int i10) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10);
            Assert.That(f10(1, 2, 3, 4, 5, 6, 7, 8, 9, 10), Is.EqualTo(55));
            var f11 = Create.Func((int i1, int i2, int i3, int i4, int i5, int i6, int i7, int i8, int i9, int i10, int i11) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11);
            Assert.That(f11(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11), Is.EqualTo(66));
            var f12 = Create.Func((int i1, int i2, int i3, int i4, int i5, int i6, int i7, int i8, int i9, int i10, int i11, int i12) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12);
            Assert.That(f12(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12), Is.EqualTo(78));
            var f13 = Create.Func((int i1, int i2, int i3, int i4, int i5, int i6, int i7, int i8, int i9, int i10, int i11, int i12, int i13) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13);
            Assert.That(f13(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13), Is.EqualTo(91));
            var f14 = Create.Func((int i1, int i2, int i3, int i4, int i5, int i6, int i7, int i8, int i9, int i10, int i11, int i12, int i13, int i14) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14);
            Assert.That(f14(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14), Is.EqualTo(105));
            var f15 = Create.Func((int i1, int i2, int i3, int i4, int i5, int i6, int i7, int i8, int i9, int i10, int i11, int i12, int i13, int i14, int i15) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14 + i15);
            Assert.That(f15(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15), Is.EqualTo(120));
            var f16 = Create.Func((int i1, int i2, int i3, int i4, int i5, int i6, int i7, int i8, int i9, int i10, int i11, int i12, int i13, int i14, int i15, int i16) => i1 + i2 + i3 + i4 + i5 + i6 + i7 + i8 + i9 + i10 + i11 + i12 + i13 + i14 + i15 + i16);
            Assert.That(f16(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16), Is.EqualTo(136));
        }
    }
}