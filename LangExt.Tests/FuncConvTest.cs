
using System;
using LangExt;
using NUnit.Framework;

namespace LangExt.Tests
{
    [TestFixture]
    public class FuncConvTest
    {
        [Test]
        public void TestToFunctional()
        {
            var f1 = Create.Func((string prefix, int x1, int x2) => prefix + (x1 + x2));
            var g1 = f1.ToFunctional();
            Assert.That(g1(1)(2)("hoge"), Is.EqualTo(f1("hoge", 1, 2)));
            var f2 = Create.Func((string prefix, int x1, int x2, int x3) => prefix + (x1 + x2 + x3));
            var g2 = f2.ToFunctional();
            Assert.That(g2(1)(2)(3)("hoge"), Is.EqualTo(f2("hoge", 1, 2, 3)));
            var f3 = Create.Func((string prefix, int x1, int x2, int x3, int x4) => prefix + (x1 + x2 + x3 + x4));
            var g3 = f3.ToFunctional();
            Assert.That(g3(1)(2)(3)(4)("hoge"), Is.EqualTo(f3("hoge", 1, 2, 3, 4)));
            var f4 = Create.Func((string prefix, int x1, int x2, int x3, int x4, int x5) => prefix + (x1 + x2 + x3 + x4 + x5));
            var g4 = f4.ToFunctional();
            Assert.That(g4(1)(2)(3)(4)(5)("hoge"), Is.EqualTo(f4("hoge", 1, 2, 3, 4, 5)));
            var f5 = Create.Func((string prefix, int x1, int x2, int x3, int x4, int x5, int x6) => prefix + (x1 + x2 + x3 + x4 + x5 + x6));
            var g5 = f5.ToFunctional();
            Assert.That(g5(1)(2)(3)(4)(5)(6)("hoge"), Is.EqualTo(f5("hoge", 1, 2, 3, 4, 5, 6)));
            var f6 = Create.Func((string prefix, int x1, int x2, int x3, int x4, int x5, int x6, int x7) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7));
            var g6 = f6.ToFunctional();
            Assert.That(g6(1)(2)(3)(4)(5)(6)(7)("hoge"), Is.EqualTo(f6("hoge", 1, 2, 3, 4, 5, 6, 7)));
            var f7 = Create.Func((string prefix, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8));
            var g7 = f7.ToFunctional();
            Assert.That(g7(1)(2)(3)(4)(5)(6)(7)(8)("hoge"), Is.EqualTo(f7("hoge", 1, 2, 3, 4, 5, 6, 7, 8)));
            var f8 = Create.Func((string prefix, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9));
            var g8 = f8.ToFunctional();
            Assert.That(g8(1)(2)(3)(4)(5)(6)(7)(8)(9)("hoge"), Is.EqualTo(f8("hoge", 1, 2, 3, 4, 5, 6, 7, 8, 9)));
            var f9 = Create.Func((string prefix, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10));
            var g9 = f9.ToFunctional();
            Assert.That(g9(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)("hoge"), Is.EqualTo(f9("hoge", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10)));
            var f10 = Create.Func((string prefix, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, int x11) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10 + x11));
            var g10 = f10.ToFunctional();
            Assert.That(g10(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)("hoge"), Is.EqualTo(f10("hoge", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11)));
            var f11 = Create.Func((string prefix, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, int x11, int x12) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10 + x11 + x12));
            var g11 = f11.ToFunctional();
            Assert.That(g11(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)("hoge"), Is.EqualTo(f11("hoge", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12)));
            var f12 = Create.Func((string prefix, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, int x11, int x12, int x13) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10 + x11 + x12 + x13));
            var g12 = f12.ToFunctional();
            Assert.That(g12(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13)("hoge"), Is.EqualTo(f12("hoge", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13)));
            var f13 = Create.Func((string prefix, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, int x11, int x12, int x13, int x14) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10 + x11 + x12 + x13 + x14));
            var g13 = f13.ToFunctional();
            Assert.That(g13(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13)(14)("hoge"), Is.EqualTo(f13("hoge", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14)));
            var f14 = Create.Func((string prefix, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, int x11, int x12, int x13, int x14, int x15) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10 + x11 + x12 + x13 + x14 + x15));
            var g14 = f14.ToFunctional();
            Assert.That(g14(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13)(14)(15)("hoge"), Is.EqualTo(f14("hoge", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15)));
        }

        [Test]
        public void TestToObjective()
        {
            var f1 = Create.Func((int x1, int x2, string prefix) => prefix + (x1 + x2)).Curried();
            var g1 = f1.ToObjective();
            Assert.That(g1("hoge", 1, 2), Is.EqualTo(f1(1)(2)("hoge")));
            var f2 = Create.Func((int x1, int x2, int x3, string prefix) => prefix + (x1 + x2 + x3)).Curried();
            var g2 = f2.ToObjective();
            Assert.That(g2("hoge", 1, 2, 3), Is.EqualTo(f2(1)(2)(3)("hoge")));
            var f3 = Create.Func((int x1, int x2, int x3, int x4, string prefix) => prefix + (x1 + x2 + x3 + x4)).Curried();
            var g3 = f3.ToObjective();
            Assert.That(g3("hoge", 1, 2, 3, 4), Is.EqualTo(f3(1)(2)(3)(4)("hoge")));
            var f4 = Create.Func((int x1, int x2, int x3, int x4, int x5, string prefix) => prefix + (x1 + x2 + x3 + x4 + x5)).Curried();
            var g4 = f4.ToObjective();
            Assert.That(g4("hoge", 1, 2, 3, 4, 5), Is.EqualTo(f4(1)(2)(3)(4)(5)("hoge")));
            var f5 = Create.Func((int x1, int x2, int x3, int x4, int x5, int x6, string prefix) => prefix + (x1 + x2 + x3 + x4 + x5 + x6)).Curried();
            var g5 = f5.ToObjective();
            Assert.That(g5("hoge", 1, 2, 3, 4, 5, 6), Is.EqualTo(f5(1)(2)(3)(4)(5)(6)("hoge")));
            var f6 = Create.Func((int x1, int x2, int x3, int x4, int x5, int x6, int x7, string prefix) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7)).Curried();
            var g6 = f6.ToObjective();
            Assert.That(g6("hoge", 1, 2, 3, 4, 5, 6, 7), Is.EqualTo(f6(1)(2)(3)(4)(5)(6)(7)("hoge")));
            var f7 = Create.Func((int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, string prefix) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8)).Curried();
            var g7 = f7.ToObjective();
            Assert.That(g7("hoge", 1, 2, 3, 4, 5, 6, 7, 8), Is.EqualTo(f7(1)(2)(3)(4)(5)(6)(7)(8)("hoge")));
            var f8 = Create.Func((int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, string prefix) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9)).Curried();
            var g8 = f8.ToObjective();
            Assert.That(g8("hoge", 1, 2, 3, 4, 5, 6, 7, 8, 9), Is.EqualTo(f8(1)(2)(3)(4)(5)(6)(7)(8)(9)("hoge")));
            var f9 = Create.Func((int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, string prefix) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10)).Curried();
            var g9 = f9.ToObjective();
            Assert.That(g9("hoge", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10), Is.EqualTo(f9(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)("hoge")));
            var f10 = Create.Func((int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, int x11, string prefix) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10 + x11)).Curried();
            var g10 = f10.ToObjective();
            Assert.That(g10("hoge", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11), Is.EqualTo(f10(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)("hoge")));
            var f11 = Create.Func((int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, int x11, int x12, string prefix) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10 + x11 + x12)).Curried();
            var g11 = f11.ToObjective();
            Assert.That(g11("hoge", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12), Is.EqualTo(f11(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)("hoge")));
            var f12 = Create.Func((int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, int x11, int x12, int x13, string prefix) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10 + x11 + x12 + x13)).Curried();
            var g12 = f12.ToObjective();
            Assert.That(g12("hoge", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13), Is.EqualTo(f12(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13)("hoge")));
            var f13 = Create.Func((int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, int x11, int x12, int x13, int x14, string prefix) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10 + x11 + x12 + x13 + x14)).Curried();
            var g13 = f13.ToObjective();
            Assert.That(g13("hoge", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14), Is.EqualTo(f13(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13)(14)("hoge")));
            var f14 = Create.Func((int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, int x11, int x12, int x13, int x14, int x15, string prefix) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10 + x11 + x12 + x13 + x14 + x15)).Curried();
            var g14 = f14.ToObjective();
            Assert.That(g14("hoge", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15), Is.EqualTo(f14(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13)(14)(15)("hoge")));
        }

        [Test]
        public void ToFunctionalしてToObjectiveすると元に戻る()
        {
            var f1 = Create.Func((string prefix, int x1, int x2) => prefix + (x1 + x2));
            var g1 = f1.ToFunctional().ToObjective();
            Assert.That(g1("hoge", 1, 2), Is.EqualTo(f1("hoge", 1, 2)));
            var f2 = Create.Func((string prefix, int x1, int x2, int x3) => prefix + (x1 + x2 + x3));
            var g2 = f2.ToFunctional().ToObjective();
            Assert.That(g2("hoge", 1, 2, 3), Is.EqualTo(f2("hoge", 1, 2, 3)));
            var f3 = Create.Func((string prefix, int x1, int x2, int x3, int x4) => prefix + (x1 + x2 + x3 + x4));
            var g3 = f3.ToFunctional().ToObjective();
            Assert.That(g3("hoge", 1, 2, 3, 4), Is.EqualTo(f3("hoge", 1, 2, 3, 4)));
            var f4 = Create.Func((string prefix, int x1, int x2, int x3, int x4, int x5) => prefix + (x1 + x2 + x3 + x4 + x5));
            var g4 = f4.ToFunctional().ToObjective();
            Assert.That(g4("hoge", 1, 2, 3, 4, 5), Is.EqualTo(f4("hoge", 1, 2, 3, 4, 5)));
            var f5 = Create.Func((string prefix, int x1, int x2, int x3, int x4, int x5, int x6) => prefix + (x1 + x2 + x3 + x4 + x5 + x6));
            var g5 = f5.ToFunctional().ToObjective();
            Assert.That(g5("hoge", 1, 2, 3, 4, 5, 6), Is.EqualTo(f5("hoge", 1, 2, 3, 4, 5, 6)));
            var f6 = Create.Func((string prefix, int x1, int x2, int x3, int x4, int x5, int x6, int x7) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7));
            var g6 = f6.ToFunctional().ToObjective();
            Assert.That(g6("hoge", 1, 2, 3, 4, 5, 6, 7), Is.EqualTo(f6("hoge", 1, 2, 3, 4, 5, 6, 7)));
            var f7 = Create.Func((string prefix, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8));
            var g7 = f7.ToFunctional().ToObjective();
            Assert.That(g7("hoge", 1, 2, 3, 4, 5, 6, 7, 8), Is.EqualTo(f7("hoge", 1, 2, 3, 4, 5, 6, 7, 8)));
            var f8 = Create.Func((string prefix, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9));
            var g8 = f8.ToFunctional().ToObjective();
            Assert.That(g8("hoge", 1, 2, 3, 4, 5, 6, 7, 8, 9), Is.EqualTo(f8("hoge", 1, 2, 3, 4, 5, 6, 7, 8, 9)));
            var f9 = Create.Func((string prefix, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10));
            var g9 = f9.ToFunctional().ToObjective();
            Assert.That(g9("hoge", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10), Is.EqualTo(f9("hoge", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10)));
            var f10 = Create.Func((string prefix, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, int x11) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10 + x11));
            var g10 = f10.ToFunctional().ToObjective();
            Assert.That(g10("hoge", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11), Is.EqualTo(f10("hoge", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11)));
            var f11 = Create.Func((string prefix, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, int x11, int x12) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10 + x11 + x12));
            var g11 = f11.ToFunctional().ToObjective();
            Assert.That(g11("hoge", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12), Is.EqualTo(f11("hoge", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12)));
            var f12 = Create.Func((string prefix, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, int x11, int x12, int x13) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10 + x11 + x12 + x13));
            var g12 = f12.ToFunctional().ToObjective();
            Assert.That(g12("hoge", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13), Is.EqualTo(f12("hoge", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13)));
            var f13 = Create.Func((string prefix, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, int x11, int x12, int x13, int x14) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10 + x11 + x12 + x13 + x14));
            var g13 = f13.ToFunctional().ToObjective();
            Assert.That(g13("hoge", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14), Is.EqualTo(f13("hoge", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14)));
            var f14 = Create.Func((string prefix, int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, int x11, int x12, int x13, int x14, int x15) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10 + x11 + x12 + x13 + x14 + x15));
            var g14 = f14.ToFunctional().ToObjective();
            Assert.That(g14("hoge", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15), Is.EqualTo(f14("hoge", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15)));
        }

        [Test]
        public void ToObjectiveしてToFunctionalすると元に戻る()
        {
            var f1 = Create.Func((int x1, int x2, string prefix) => prefix + (x1 + x2)).Curried();
            var g1 = f1.ToObjective().ToFunctional();
            Assert.That(g1(1)(2)("hoge"), Is.EqualTo(f1(1)(2)("hoge")));
            var f2 = Create.Func((int x1, int x2, int x3, string prefix) => prefix + (x1 + x2 + x3)).Curried();
            var g2 = f2.ToObjective().ToFunctional();
            Assert.That(g2(1)(2)(3)("hoge"), Is.EqualTo(f2(1)(2)(3)("hoge")));
            var f3 = Create.Func((int x1, int x2, int x3, int x4, string prefix) => prefix + (x1 + x2 + x3 + x4)).Curried();
            var g3 = f3.ToObjective().ToFunctional();
            Assert.That(g3(1)(2)(3)(4)("hoge"), Is.EqualTo(f3(1)(2)(3)(4)("hoge")));
            var f4 = Create.Func((int x1, int x2, int x3, int x4, int x5, string prefix) => prefix + (x1 + x2 + x3 + x4 + x5)).Curried();
            var g4 = f4.ToObjective().ToFunctional();
            Assert.That(g4(1)(2)(3)(4)(5)("hoge"), Is.EqualTo(f4(1)(2)(3)(4)(5)("hoge")));
            var f5 = Create.Func((int x1, int x2, int x3, int x4, int x5, int x6, string prefix) => prefix + (x1 + x2 + x3 + x4 + x5 + x6)).Curried();
            var g5 = f5.ToObjective().ToFunctional();
            Assert.That(g5(1)(2)(3)(4)(5)(6)("hoge"), Is.EqualTo(f5(1)(2)(3)(4)(5)(6)("hoge")));
            var f6 = Create.Func((int x1, int x2, int x3, int x4, int x5, int x6, int x7, string prefix) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7)).Curried();
            var g6 = f6.ToObjective().ToFunctional();
            Assert.That(g6(1)(2)(3)(4)(5)(6)(7)("hoge"), Is.EqualTo(f6(1)(2)(3)(4)(5)(6)(7)("hoge")));
            var f7 = Create.Func((int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, string prefix) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8)).Curried();
            var g7 = f7.ToObjective().ToFunctional();
            Assert.That(g7(1)(2)(3)(4)(5)(6)(7)(8)("hoge"), Is.EqualTo(f7(1)(2)(3)(4)(5)(6)(7)(8)("hoge")));
            var f8 = Create.Func((int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, string prefix) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9)).Curried();
            var g8 = f8.ToObjective().ToFunctional();
            Assert.That(g8(1)(2)(3)(4)(5)(6)(7)(8)(9)("hoge"), Is.EqualTo(f8(1)(2)(3)(4)(5)(6)(7)(8)(9)("hoge")));
            var f9 = Create.Func((int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, string prefix) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10)).Curried();
            var g9 = f9.ToObjective().ToFunctional();
            Assert.That(g9(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)("hoge"), Is.EqualTo(f9(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)("hoge")));
            var f10 = Create.Func((int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, int x11, string prefix) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10 + x11)).Curried();
            var g10 = f10.ToObjective().ToFunctional();
            Assert.That(g10(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)("hoge"), Is.EqualTo(f10(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)("hoge")));
            var f11 = Create.Func((int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, int x11, int x12, string prefix) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10 + x11 + x12)).Curried();
            var g11 = f11.ToObjective().ToFunctional();
            Assert.That(g11(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)("hoge"), Is.EqualTo(f11(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)("hoge")));
            var f12 = Create.Func((int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, int x11, int x12, int x13, string prefix) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10 + x11 + x12 + x13)).Curried();
            var g12 = f12.ToObjective().ToFunctional();
            Assert.That(g12(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13)("hoge"), Is.EqualTo(f12(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13)("hoge")));
            var f13 = Create.Func((int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, int x11, int x12, int x13, int x14, string prefix) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10 + x11 + x12 + x13 + x14)).Curried();
            var g13 = f13.ToObjective().ToFunctional();
            Assert.That(g13(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13)(14)("hoge"), Is.EqualTo(f13(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13)(14)("hoge")));
            var f14 = Create.Func((int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10, int x11, int x12, int x13, int x14, int x15, string prefix) => prefix + (x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10 + x11 + x12 + x13 + x14 + x15)).Curried();
            var g14 = f14.ToObjective().ToFunctional();
            Assert.That(g14(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13)(14)(15)("hoge"), Is.EqualTo(f14(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13)(14)(15)("hoge")));
        }
    }
}