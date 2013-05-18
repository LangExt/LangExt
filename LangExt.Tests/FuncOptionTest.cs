
using System;
using LangExt;
using NUnit.Framework;

namespace LangExt.Tests
{
    [TestFixture]
    public class FuncOptionTest
    {
        [Test]
        public void ExnToOptionFunc()
        {
            var f0 = new Func<int>(() =>  + 0);
            var g0 = f0.ExnToOptionFunc();
            Assert.That(g0(), Is.EqualTo(Option.Some( + 0)));
            f0 = new Func<int>(() => { throw new Exception("oops!"); });
            g0 = f0.ExnToOptionFunc();
            Assert.That(g0(), Is.EqualTo(Option<int>.None));

            var f1 = new Func<int, int>((a1) => a1 + 0);
            var g1 = f1.ExnToOptionFunc();
            Assert.That(g1(1), Is.EqualTo(Option.Some(1 + 0)));
            f1 = new Func<int, int>((a1) => { throw new Exception("oops!"); });
            g1 = f1.ExnToOptionFunc();
            Assert.That(g1(1), Is.EqualTo(Option<int>.None));

            var f2 = new Func<int, int, int>((a1, a2) => a1 + a2 + 0);
            var g2 = f2.ExnToOptionFunc();
            Assert.That(g2(1, 2), Is.EqualTo(Option.Some(1 + 2 + 0)));
            f2 = new Func<int, int, int>((a1, a2) => { throw new Exception("oops!"); });
            g2 = f2.ExnToOptionFunc();
            Assert.That(g2(1, 2), Is.EqualTo(Option<int>.None));

            var f3 = new Func<int, int, int, int>((a1, a2, a3) => a1 + a2 + a3 + 0);
            var g3 = f3.ExnToOptionFunc();
            Assert.That(g3(1, 2, 3), Is.EqualTo(Option.Some(1 + 2 + 3 + 0)));
            f3 = new Func<int, int, int, int>((a1, a2, a3) => { throw new Exception("oops!"); });
            g3 = f3.ExnToOptionFunc();
            Assert.That(g3(1, 2, 3), Is.EqualTo(Option<int>.None));

            var f4 = new Func<int, int, int, int, int>((a1, a2, a3, a4) => a1 + a2 + a3 + a4 + 0);
            var g4 = f4.ExnToOptionFunc();
            Assert.That(g4(1, 2, 3, 4), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 0)));
            f4 = new Func<int, int, int, int, int>((a1, a2, a3, a4) => { throw new Exception("oops!"); });
            g4 = f4.ExnToOptionFunc();
            Assert.That(g4(1, 2, 3, 4), Is.EqualTo(Option<int>.None));

            var f5 = new Func<int, int, int, int, int, int>((a1, a2, a3, a4, a5) => a1 + a2 + a3 + a4 + a5 + 0);
            var g5 = f5.ExnToOptionFunc();
            Assert.That(g5(1, 2, 3, 4, 5), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 0)));
            f5 = new Func<int, int, int, int, int, int>((a1, a2, a3, a4, a5) => { throw new Exception("oops!"); });
            g5 = f5.ExnToOptionFunc();
            Assert.That(g5(1, 2, 3, 4, 5), Is.EqualTo(Option<int>.None));

            var f6 = new Func<int, int, int, int, int, int, int>((a1, a2, a3, a4, a5, a6) => a1 + a2 + a3 + a4 + a5 + a6 + 0);
            var g6 = f6.ExnToOptionFunc();
            Assert.That(g6(1, 2, 3, 4, 5, 6), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 6 + 0)));
            f6 = new Func<int, int, int, int, int, int, int>((a1, a2, a3, a4, a5, a6) => { throw new Exception("oops!"); });
            g6 = f6.ExnToOptionFunc();
            Assert.That(g6(1, 2, 3, 4, 5, 6), Is.EqualTo(Option<int>.None));

            var f7 = new Func<int, int, int, int, int, int, int, int>((a1, a2, a3, a4, a5, a6, a7) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + 0);
            var g7 = f7.ExnToOptionFunc();
            Assert.That(g7(1, 2, 3, 4, 5, 6, 7), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 6 + 7 + 0)));
            f7 = new Func<int, int, int, int, int, int, int, int>((a1, a2, a3, a4, a5, a6, a7) => { throw new Exception("oops!"); });
            g7 = f7.ExnToOptionFunc();
            Assert.That(g7(1, 2, 3, 4, 5, 6, 7), Is.EqualTo(Option<int>.None));

            var f8 = new Func<int, int, int, int, int, int, int, int, int>((a1, a2, a3, a4, a5, a6, a7, a8) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + 0);
            var g8 = f8.ExnToOptionFunc();
            Assert.That(g8(1, 2, 3, 4, 5, 6, 7, 8), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 0)));
            f8 = new Func<int, int, int, int, int, int, int, int, int>((a1, a2, a3, a4, a5, a6, a7, a8) => { throw new Exception("oops!"); });
            g8 = f8.ExnToOptionFunc();
            Assert.That(g8(1, 2, 3, 4, 5, 6, 7, 8), Is.EqualTo(Option<int>.None));

            var f9 = new Func<int, int, int, int, int, int, int, int, int, int>((a1, a2, a3, a4, a5, a6, a7, a8, a9) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + 0);
            var g9 = f9.ExnToOptionFunc();
            Assert.That(g9(1, 2, 3, 4, 5, 6, 7, 8, 9), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 0)));
            f9 = new Func<int, int, int, int, int, int, int, int, int, int>((a1, a2, a3, a4, a5, a6, a7, a8, a9) => { throw new Exception("oops!"); });
            g9 = f9.ExnToOptionFunc();
            Assert.That(g9(1, 2, 3, 4, 5, 6, 7, 8, 9), Is.EqualTo(Option<int>.None));

            var f10 = new Func<int, int, int, int, int, int, int, int, int, int, int>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + 0);
            var g10 = f10.ExnToOptionFunc();
            Assert.That(g10(1, 2, 3, 4, 5, 6, 7, 8, 9, 10), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 + 0)));
            f10 = new Func<int, int, int, int, int, int, int, int, int, int, int>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10) => { throw new Exception("oops!"); });
            g10 = f10.ExnToOptionFunc();
            Assert.That(g10(1, 2, 3, 4, 5, 6, 7, 8, 9, 10), Is.EqualTo(Option<int>.None));

            var f11 = new Func<int, int, int, int, int, int, int, int, int, int, int, int>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11 + 0);
            var g11 = f11.ExnToOptionFunc();
            Assert.That(g11(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 + 11 + 0)));
            f11 = new Func<int, int, int, int, int, int, int, int, int, int, int, int>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11) => { throw new Exception("oops!"); });
            g11 = f11.ExnToOptionFunc();
            Assert.That(g11(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11), Is.EqualTo(Option<int>.None));

            var f12 = new Func<int, int, int, int, int, int, int, int, int, int, int, int, int>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11 + a12 + 0);
            var g12 = f12.ExnToOptionFunc();
            Assert.That(g12(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 + 11 + 12 + 0)));
            f12 = new Func<int, int, int, int, int, int, int, int, int, int, int, int, int>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12) => { throw new Exception("oops!"); });
            g12 = f12.ExnToOptionFunc();
            Assert.That(g12(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12), Is.EqualTo(Option<int>.None));

            var f13 = new Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11 + a12 + a13 + 0);
            var g13 = f13.ExnToOptionFunc();
            Assert.That(g13(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 + 11 + 12 + 13 + 0)));
            f13 = new Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13) => { throw new Exception("oops!"); });
            g13 = f13.ExnToOptionFunc();
            Assert.That(g13(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13), Is.EqualTo(Option<int>.None));

            var f14 = new Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11 + a12 + a13 + a14 + 0);
            var g14 = f14.ExnToOptionFunc();
            Assert.That(g14(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 + 11 + 12 + 13 + 14 + 0)));
            f14 = new Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14) => { throw new Exception("oops!"); });
            g14 = f14.ExnToOptionFunc();
            Assert.That(g14(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14), Is.EqualTo(Option<int>.None));

            var f15 = new Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11 + a12 + a13 + a14 + a15 + 0);
            var g15 = f15.ExnToOptionFunc();
            Assert.That(g15(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 + 11 + 12 + 13 + 14 + 15 + 0)));
            f15 = new Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15) => { throw new Exception("oops!"); });
            g15 = f15.ExnToOptionFunc();
            Assert.That(g15(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15), Is.EqualTo(Option<int>.None));

            var f16 = new Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11 + a12 + a13 + a14 + a15 + a16 + 0);
            var g16 = f16.ExnToOptionFunc();
            Assert.That(g16(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 + 11 + 12 + 13 + 14 + 15 + 16 + 0)));
            f16 = new Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16) => { throw new Exception("oops!"); });
            g16 = f16.ExnToOptionFunc();
            Assert.That(g16(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16), Is.EqualTo(Option<int>.None));

        }

        [Test]
        public void NullToOptionFunc()
        {
            var f1_0 = new Func<string>(() => "");
            var g1_0 = f1_0.NullToOptionFunc();
            Assert.That(g1_0(), Is.EqualTo(Option.Some("")));
            f1_0 = new Func<string>(() => null);
            g1_0 = f1_0.NullToOptionFunc();
            Assert.That(g1_0(), Is.EqualTo(Option<string>.None));

            var f2_0 = new Func<int?>(() =>  + 0);
            var g2_0 = f2_0.NullToOptionFunc();
            Assert.That(g2_0(), Is.EqualTo(Option.Some( + 0)));
            f2_0 = new Func<int?>(() => null);
            g2_0 = f2_0.NullToOptionFunc();
            Assert.That(g2_0(), Is.EqualTo(Option<int>.None));

            var f1_1 = new Func<string, string>((a1) => a1);
            var g1_1 = f1_1.NullToOptionFunc();
            Assert.That(g1_1("1"), Is.EqualTo(Option.Some("1")));
            f1_1 = new Func<string, string>((a1) => null);
            g1_1 = f1_1.NullToOptionFunc();
            Assert.That(g1_1("1"), Is.EqualTo(Option<string>.None));

            var f2_1 = new Func<int?, int?>((a1) => a1 + 0);
            var g2_1 = f2_1.NullToOptionFunc();
            Assert.That(g2_1(1), Is.EqualTo(Option.Some(1 + 0)));
            f2_1 = new Func<int?, int?>((a1) => null);
            g2_1 = f2_1.NullToOptionFunc();
            Assert.That(g2_1(1), Is.EqualTo(Option<int>.None));

            var f1_2 = new Func<string, string, string>((a1, a2) => a1 + a2);
            var g1_2 = f1_2.NullToOptionFunc();
            Assert.That(g1_2("1", "2"), Is.EqualTo(Option.Some("12")));
            f1_2 = new Func<string, string, string>((a1, a2) => null);
            g1_2 = f1_2.NullToOptionFunc();
            Assert.That(g1_2("1", "2"), Is.EqualTo(Option<string>.None));

            var f2_2 = new Func<int?, int?, int?>((a1, a2) => a1 + a2 + 0);
            var g2_2 = f2_2.NullToOptionFunc();
            Assert.That(g2_2(1, 2), Is.EqualTo(Option.Some(1 + 2 + 0)));
            f2_2 = new Func<int?, int?, int?>((a1, a2) => null);
            g2_2 = f2_2.NullToOptionFunc();
            Assert.That(g2_2(1, 2), Is.EqualTo(Option<int>.None));

            var f1_3 = new Func<string, string, string, string>((a1, a2, a3) => a1 + a2 + a3);
            var g1_3 = f1_3.NullToOptionFunc();
            Assert.That(g1_3("1", "2", "3"), Is.EqualTo(Option.Some("123")));
            f1_3 = new Func<string, string, string, string>((a1, a2, a3) => null);
            g1_3 = f1_3.NullToOptionFunc();
            Assert.That(g1_3("1", "2", "3"), Is.EqualTo(Option<string>.None));

            var f2_3 = new Func<int?, int?, int?, int?>((a1, a2, a3) => a1 + a2 + a3 + 0);
            var g2_3 = f2_3.NullToOptionFunc();
            Assert.That(g2_3(1, 2, 3), Is.EqualTo(Option.Some(1 + 2 + 3 + 0)));
            f2_3 = new Func<int?, int?, int?, int?>((a1, a2, a3) => null);
            g2_3 = f2_3.NullToOptionFunc();
            Assert.That(g2_3(1, 2, 3), Is.EqualTo(Option<int>.None));

            var f1_4 = new Func<string, string, string, string, string>((a1, a2, a3, a4) => a1 + a2 + a3 + a4);
            var g1_4 = f1_4.NullToOptionFunc();
            Assert.That(g1_4("1", "2", "3", "4"), Is.EqualTo(Option.Some("1234")));
            f1_4 = new Func<string, string, string, string, string>((a1, a2, a3, a4) => null);
            g1_4 = f1_4.NullToOptionFunc();
            Assert.That(g1_4("1", "2", "3", "4"), Is.EqualTo(Option<string>.None));

            var f2_4 = new Func<int?, int?, int?, int?, int?>((a1, a2, a3, a4) => a1 + a2 + a3 + a4 + 0);
            var g2_4 = f2_4.NullToOptionFunc();
            Assert.That(g2_4(1, 2, 3, 4), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 0)));
            f2_4 = new Func<int?, int?, int?, int?, int?>((a1, a2, a3, a4) => null);
            g2_4 = f2_4.NullToOptionFunc();
            Assert.That(g2_4(1, 2, 3, 4), Is.EqualTo(Option<int>.None));

            var f1_5 = new Func<string, string, string, string, string, string>((a1, a2, a3, a4, a5) => a1 + a2 + a3 + a4 + a5);
            var g1_5 = f1_5.NullToOptionFunc();
            Assert.That(g1_5("1", "2", "3", "4", "5"), Is.EqualTo(Option.Some("12345")));
            f1_5 = new Func<string, string, string, string, string, string>((a1, a2, a3, a4, a5) => null);
            g1_5 = f1_5.NullToOptionFunc();
            Assert.That(g1_5("1", "2", "3", "4", "5"), Is.EqualTo(Option<string>.None));

            var f2_5 = new Func<int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5) => a1 + a2 + a3 + a4 + a5 + 0);
            var g2_5 = f2_5.NullToOptionFunc();
            Assert.That(g2_5(1, 2, 3, 4, 5), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 0)));
            f2_5 = new Func<int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5) => null);
            g2_5 = f2_5.NullToOptionFunc();
            Assert.That(g2_5(1, 2, 3, 4, 5), Is.EqualTo(Option<int>.None));

            var f1_6 = new Func<string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6) => a1 + a2 + a3 + a4 + a5 + a6);
            var g1_6 = f1_6.NullToOptionFunc();
            Assert.That(g1_6("1", "2", "3", "4", "5", "6"), Is.EqualTo(Option.Some("123456")));
            f1_6 = new Func<string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6) => null);
            g1_6 = f1_6.NullToOptionFunc();
            Assert.That(g1_6("1", "2", "3", "4", "5", "6"), Is.EqualTo(Option<string>.None));

            var f2_6 = new Func<int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6) => a1 + a2 + a3 + a4 + a5 + a6 + 0);
            var g2_6 = f2_6.NullToOptionFunc();
            Assert.That(g2_6(1, 2, 3, 4, 5, 6), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 6 + 0)));
            f2_6 = new Func<int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6) => null);
            g2_6 = f2_6.NullToOptionFunc();
            Assert.That(g2_6(1, 2, 3, 4, 5, 6), Is.EqualTo(Option<int>.None));

            var f1_7 = new Func<string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7) => a1 + a2 + a3 + a4 + a5 + a6 + a7);
            var g1_7 = f1_7.NullToOptionFunc();
            Assert.That(g1_7("1", "2", "3", "4", "5", "6", "7"), Is.EqualTo(Option.Some("1234567")));
            f1_7 = new Func<string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7) => null);
            g1_7 = f1_7.NullToOptionFunc();
            Assert.That(g1_7("1", "2", "3", "4", "5", "6", "7"), Is.EqualTo(Option<string>.None));

            var f2_7 = new Func<int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + 0);
            var g2_7 = f2_7.NullToOptionFunc();
            Assert.That(g2_7(1, 2, 3, 4, 5, 6, 7), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 6 + 7 + 0)));
            f2_7 = new Func<int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7) => null);
            g2_7 = f2_7.NullToOptionFunc();
            Assert.That(g2_7(1, 2, 3, 4, 5, 6, 7), Is.EqualTo(Option<int>.None));

            var f1_8 = new Func<string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8);
            var g1_8 = f1_8.NullToOptionFunc();
            Assert.That(g1_8("1", "2", "3", "4", "5", "6", "7", "8"), Is.EqualTo(Option.Some("12345678")));
            f1_8 = new Func<string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8) => null);
            g1_8 = f1_8.NullToOptionFunc();
            Assert.That(g1_8("1", "2", "3", "4", "5", "6", "7", "8"), Is.EqualTo(Option<string>.None));

            var f2_8 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + 0);
            var g2_8 = f2_8.NullToOptionFunc();
            Assert.That(g2_8(1, 2, 3, 4, 5, 6, 7, 8), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 0)));
            f2_8 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8) => null);
            g2_8 = f2_8.NullToOptionFunc();
            Assert.That(g2_8(1, 2, 3, 4, 5, 6, 7, 8), Is.EqualTo(Option<int>.None));

            var f1_9 = new Func<string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9);
            var g1_9 = f1_9.NullToOptionFunc();
            Assert.That(g1_9("1", "2", "3", "4", "5", "6", "7", "8", "9"), Is.EqualTo(Option.Some("123456789")));
            f1_9 = new Func<string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9) => null);
            g1_9 = f1_9.NullToOptionFunc();
            Assert.That(g1_9("1", "2", "3", "4", "5", "6", "7", "8", "9"), Is.EqualTo(Option<string>.None));

            var f2_9 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + 0);
            var g2_9 = f2_9.NullToOptionFunc();
            Assert.That(g2_9(1, 2, 3, 4, 5, 6, 7, 8, 9), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 0)));
            f2_9 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9) => null);
            g2_9 = f2_9.NullToOptionFunc();
            Assert.That(g2_9(1, 2, 3, 4, 5, 6, 7, 8, 9), Is.EqualTo(Option<int>.None));

            var f1_10 = new Func<string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10);
            var g1_10 = f1_10.NullToOptionFunc();
            Assert.That(g1_10("1", "2", "3", "4", "5", "6", "7", "8", "9", "10"), Is.EqualTo(Option.Some("12345678910")));
            f1_10 = new Func<string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10) => null);
            g1_10 = f1_10.NullToOptionFunc();
            Assert.That(g1_10("1", "2", "3", "4", "5", "6", "7", "8", "9", "10"), Is.EqualTo(Option<string>.None));

            var f2_10 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + 0);
            var g2_10 = f2_10.NullToOptionFunc();
            Assert.That(g2_10(1, 2, 3, 4, 5, 6, 7, 8, 9, 10), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 + 0)));
            f2_10 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10) => null);
            g2_10 = f2_10.NullToOptionFunc();
            Assert.That(g2_10(1, 2, 3, 4, 5, 6, 7, 8, 9, 10), Is.EqualTo(Option<int>.None));

            var f1_11 = new Func<string, string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11);
            var g1_11 = f1_11.NullToOptionFunc();
            Assert.That(g1_11("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11"), Is.EqualTo(Option.Some("1234567891011")));
            f1_11 = new Func<string, string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11) => null);
            g1_11 = f1_11.NullToOptionFunc();
            Assert.That(g1_11("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11"), Is.EqualTo(Option<string>.None));

            var f2_11 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11 + 0);
            var g2_11 = f2_11.NullToOptionFunc();
            Assert.That(g2_11(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 + 11 + 0)));
            f2_11 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11) => null);
            g2_11 = f2_11.NullToOptionFunc();
            Assert.That(g2_11(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11), Is.EqualTo(Option<int>.None));

            var f1_12 = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11 + a12);
            var g1_12 = f1_12.NullToOptionFunc();
            Assert.That(g1_12("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"), Is.EqualTo(Option.Some("123456789101112")));
            f1_12 = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12) => null);
            g1_12 = f1_12.NullToOptionFunc();
            Assert.That(g1_12("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"), Is.EqualTo(Option<string>.None));

            var f2_12 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11 + a12 + 0);
            var g2_12 = f2_12.NullToOptionFunc();
            Assert.That(g2_12(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 + 11 + 12 + 0)));
            f2_12 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12) => null);
            g2_12 = f2_12.NullToOptionFunc();
            Assert.That(g2_12(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12), Is.EqualTo(Option<int>.None));

            var f1_13 = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11 + a12 + a13);
            var g1_13 = f1_13.NullToOptionFunc();
            Assert.That(g1_13("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13"), Is.EqualTo(Option.Some("12345678910111213")));
            f1_13 = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13) => null);
            g1_13 = f1_13.NullToOptionFunc();
            Assert.That(g1_13("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13"), Is.EqualTo(Option<string>.None));

            var f2_13 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11 + a12 + a13 + 0);
            var g2_13 = f2_13.NullToOptionFunc();
            Assert.That(g2_13(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 + 11 + 12 + 13 + 0)));
            f2_13 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13) => null);
            g2_13 = f2_13.NullToOptionFunc();
            Assert.That(g2_13(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13), Is.EqualTo(Option<int>.None));

            var f1_14 = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11 + a12 + a13 + a14);
            var g1_14 = f1_14.NullToOptionFunc();
            Assert.That(g1_14("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14"), Is.EqualTo(Option.Some("1234567891011121314")));
            f1_14 = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14) => null);
            g1_14 = f1_14.NullToOptionFunc();
            Assert.That(g1_14("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14"), Is.EqualTo(Option<string>.None));

            var f2_14 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11 + a12 + a13 + a14 + 0);
            var g2_14 = f2_14.NullToOptionFunc();
            Assert.That(g2_14(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 + 11 + 12 + 13 + 14 + 0)));
            f2_14 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14) => null);
            g2_14 = f2_14.NullToOptionFunc();
            Assert.That(g2_14(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14), Is.EqualTo(Option<int>.None));

            var f1_15 = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11 + a12 + a13 + a14 + a15);
            var g1_15 = f1_15.NullToOptionFunc();
            Assert.That(g1_15("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"), Is.EqualTo(Option.Some("123456789101112131415")));
            f1_15 = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15) => null);
            g1_15 = f1_15.NullToOptionFunc();
            Assert.That(g1_15("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"), Is.EqualTo(Option<string>.None));

            var f2_15 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11 + a12 + a13 + a14 + a15 + 0);
            var g2_15 = f2_15.NullToOptionFunc();
            Assert.That(g2_15(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 + 11 + 12 + 13 + 14 + 15 + 0)));
            f2_15 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15) => null);
            g2_15 = f2_15.NullToOptionFunc();
            Assert.That(g2_15(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15), Is.EqualTo(Option<int>.None));

            var f1_16 = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11 + a12 + a13 + a14 + a15 + a16);
            var g1_16 = f1_16.NullToOptionFunc();
            Assert.That(g1_16("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16"), Is.EqualTo(Option.Some("12345678910111213141516")));
            f1_16 = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16) => null);
            g1_16 = f1_16.NullToOptionFunc();
            Assert.That(g1_16("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16"), Is.EqualTo(Option<string>.None));

            var f2_16 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11 + a12 + a13 + a14 + a15 + a16 + 0);
            var g2_16 = f2_16.NullToOptionFunc();
            Assert.That(g2_16(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 + 11 + 12 + 13 + 14 + 15 + 16 + 0)));
            f2_16 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16) => null);
            g2_16 = f2_16.NullToOptionFunc();
            Assert.That(g2_16(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16), Is.EqualTo(Option<int>.None));

        }

        [Test]
        public void ToOptionFunc()
        {
            var f1_0 = new Func<string>(() => "");
            var g1_0 = f1_0.ToOptionFunc();
            Assert.That(g1_0(), Is.EqualTo(Option.Some("")));
            f1_0 = new Func<string>(() => { throw new Exception("oops!"); });
            g1_0 = f1_0.ToOptionFunc();
            Assert.That(g1_0(), Is.EqualTo(Option<string>.None));
            f1_0 = new Func<string>(() => null);
            g1_0 = f1_0.ToOptionFunc();
            Assert.That(g1_0(), Is.EqualTo(Option<string>.None));

            var f2_0 = new Func<int?>(() =>  + 0);
            var g2_0 = f2_0.ToOptionFunc();
            Assert.That(g2_0(), Is.EqualTo(Option.Some( + 0)));
            f2_0 = new Func<int?>(() => { throw new Exception("oops!"); });
            g2_0 = f2_0.ToOptionFunc();
            Assert.That(g2_0(), Is.EqualTo(Option<int>.None));
            f2_0 = new Func<int?>(() => null);
            g2_0 = f2_0.ToOptionFunc();
            Assert.That(g2_0(), Is.EqualTo(Option<int>.None));

            var f1_1 = new Func<string, string>((a1) => a1);
            var g1_1 = f1_1.ToOptionFunc();
            Assert.That(g1_1("1"), Is.EqualTo(Option.Some("1")));
            f1_1 = new Func<string, string>((a1) => { throw new Exception("oops!"); });
            g1_1 = f1_1.ToOptionFunc();
            Assert.That(g1_1("1"), Is.EqualTo(Option<string>.None));
            f1_1 = new Func<string, string>((a1) => null);
            g1_1 = f1_1.ToOptionFunc();
            Assert.That(g1_1("1"), Is.EqualTo(Option<string>.None));

            var f2_1 = new Func<int?, int?>((a1) => a1 + 0);
            var g2_1 = f2_1.ToOptionFunc();
            Assert.That(g2_1(1), Is.EqualTo(Option.Some(1 + 0)));
            f2_1 = new Func<int?, int?>((a1) => { throw new Exception("oops!"); });
            g2_1 = f2_1.ToOptionFunc();
            Assert.That(g2_1(1), Is.EqualTo(Option<int>.None));
            f2_1 = new Func<int?, int?>((a1) => null);
            g2_1 = f2_1.ToOptionFunc();
            Assert.That(g2_1(1), Is.EqualTo(Option<int>.None));

            var f1_2 = new Func<string, string, string>((a1, a2) => a1 + a2);
            var g1_2 = f1_2.ToOptionFunc();
            Assert.That(g1_2("1", "2"), Is.EqualTo(Option.Some("12")));
            f1_2 = new Func<string, string, string>((a1, a2) => { throw new Exception("oops!"); });
            g1_2 = f1_2.ToOptionFunc();
            Assert.That(g1_2("1", "2"), Is.EqualTo(Option<string>.None));
            f1_2 = new Func<string, string, string>((a1, a2) => null);
            g1_2 = f1_2.ToOptionFunc();
            Assert.That(g1_2("1", "2"), Is.EqualTo(Option<string>.None));

            var f2_2 = new Func<int?, int?, int?>((a1, a2) => a1 + a2 + 0);
            var g2_2 = f2_2.ToOptionFunc();
            Assert.That(g2_2(1, 2), Is.EqualTo(Option.Some(1 + 2 + 0)));
            f2_2 = new Func<int?, int?, int?>((a1, a2) => { throw new Exception("oops!"); });
            g2_2 = f2_2.ToOptionFunc();
            Assert.That(g2_2(1, 2), Is.EqualTo(Option<int>.None));
            f2_2 = new Func<int?, int?, int?>((a1, a2) => null);
            g2_2 = f2_2.ToOptionFunc();
            Assert.That(g2_2(1, 2), Is.EqualTo(Option<int>.None));

            var f1_3 = new Func<string, string, string, string>((a1, a2, a3) => a1 + a2 + a3);
            var g1_3 = f1_3.ToOptionFunc();
            Assert.That(g1_3("1", "2", "3"), Is.EqualTo(Option.Some("123")));
            f1_3 = new Func<string, string, string, string>((a1, a2, a3) => { throw new Exception("oops!"); });
            g1_3 = f1_3.ToOptionFunc();
            Assert.That(g1_3("1", "2", "3"), Is.EqualTo(Option<string>.None));
            f1_3 = new Func<string, string, string, string>((a1, a2, a3) => null);
            g1_3 = f1_3.ToOptionFunc();
            Assert.That(g1_3("1", "2", "3"), Is.EqualTo(Option<string>.None));

            var f2_3 = new Func<int?, int?, int?, int?>((a1, a2, a3) => a1 + a2 + a3 + 0);
            var g2_3 = f2_3.ToOptionFunc();
            Assert.That(g2_3(1, 2, 3), Is.EqualTo(Option.Some(1 + 2 + 3 + 0)));
            f2_3 = new Func<int?, int?, int?, int?>((a1, a2, a3) => { throw new Exception("oops!"); });
            g2_3 = f2_3.ToOptionFunc();
            Assert.That(g2_3(1, 2, 3), Is.EqualTo(Option<int>.None));
            f2_3 = new Func<int?, int?, int?, int?>((a1, a2, a3) => null);
            g2_3 = f2_3.ToOptionFunc();
            Assert.That(g2_3(1, 2, 3), Is.EqualTo(Option<int>.None));

            var f1_4 = new Func<string, string, string, string, string>((a1, a2, a3, a4) => a1 + a2 + a3 + a4);
            var g1_4 = f1_4.ToOptionFunc();
            Assert.That(g1_4("1", "2", "3", "4"), Is.EqualTo(Option.Some("1234")));
            f1_4 = new Func<string, string, string, string, string>((a1, a2, a3, a4) => { throw new Exception("oops!"); });
            g1_4 = f1_4.ToOptionFunc();
            Assert.That(g1_4("1", "2", "3", "4"), Is.EqualTo(Option<string>.None));
            f1_4 = new Func<string, string, string, string, string>((a1, a2, a3, a4) => null);
            g1_4 = f1_4.ToOptionFunc();
            Assert.That(g1_4("1", "2", "3", "4"), Is.EqualTo(Option<string>.None));

            var f2_4 = new Func<int?, int?, int?, int?, int?>((a1, a2, a3, a4) => a1 + a2 + a3 + a4 + 0);
            var g2_4 = f2_4.ToOptionFunc();
            Assert.That(g2_4(1, 2, 3, 4), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 0)));
            f2_4 = new Func<int?, int?, int?, int?, int?>((a1, a2, a3, a4) => { throw new Exception("oops!"); });
            g2_4 = f2_4.ToOptionFunc();
            Assert.That(g2_4(1, 2, 3, 4), Is.EqualTo(Option<int>.None));
            f2_4 = new Func<int?, int?, int?, int?, int?>((a1, a2, a3, a4) => null);
            g2_4 = f2_4.ToOptionFunc();
            Assert.That(g2_4(1, 2, 3, 4), Is.EqualTo(Option<int>.None));

            var f1_5 = new Func<string, string, string, string, string, string>((a1, a2, a3, a4, a5) => a1 + a2 + a3 + a4 + a5);
            var g1_5 = f1_5.ToOptionFunc();
            Assert.That(g1_5("1", "2", "3", "4", "5"), Is.EqualTo(Option.Some("12345")));
            f1_5 = new Func<string, string, string, string, string, string>((a1, a2, a3, a4, a5) => { throw new Exception("oops!"); });
            g1_5 = f1_5.ToOptionFunc();
            Assert.That(g1_5("1", "2", "3", "4", "5"), Is.EqualTo(Option<string>.None));
            f1_5 = new Func<string, string, string, string, string, string>((a1, a2, a3, a4, a5) => null);
            g1_5 = f1_5.ToOptionFunc();
            Assert.That(g1_5("1", "2", "3", "4", "5"), Is.EqualTo(Option<string>.None));

            var f2_5 = new Func<int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5) => a1 + a2 + a3 + a4 + a5 + 0);
            var g2_5 = f2_5.ToOptionFunc();
            Assert.That(g2_5(1, 2, 3, 4, 5), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 0)));
            f2_5 = new Func<int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5) => { throw new Exception("oops!"); });
            g2_5 = f2_5.ToOptionFunc();
            Assert.That(g2_5(1, 2, 3, 4, 5), Is.EqualTo(Option<int>.None));
            f2_5 = new Func<int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5) => null);
            g2_5 = f2_5.ToOptionFunc();
            Assert.That(g2_5(1, 2, 3, 4, 5), Is.EqualTo(Option<int>.None));

            var f1_6 = new Func<string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6) => a1 + a2 + a3 + a4 + a5 + a6);
            var g1_6 = f1_6.ToOptionFunc();
            Assert.That(g1_6("1", "2", "3", "4", "5", "6"), Is.EqualTo(Option.Some("123456")));
            f1_6 = new Func<string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6) => { throw new Exception("oops!"); });
            g1_6 = f1_6.ToOptionFunc();
            Assert.That(g1_6("1", "2", "3", "4", "5", "6"), Is.EqualTo(Option<string>.None));
            f1_6 = new Func<string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6) => null);
            g1_6 = f1_6.ToOptionFunc();
            Assert.That(g1_6("1", "2", "3", "4", "5", "6"), Is.EqualTo(Option<string>.None));

            var f2_6 = new Func<int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6) => a1 + a2 + a3 + a4 + a5 + a6 + 0);
            var g2_6 = f2_6.ToOptionFunc();
            Assert.That(g2_6(1, 2, 3, 4, 5, 6), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 6 + 0)));
            f2_6 = new Func<int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6) => { throw new Exception("oops!"); });
            g2_6 = f2_6.ToOptionFunc();
            Assert.That(g2_6(1, 2, 3, 4, 5, 6), Is.EqualTo(Option<int>.None));
            f2_6 = new Func<int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6) => null);
            g2_6 = f2_6.ToOptionFunc();
            Assert.That(g2_6(1, 2, 3, 4, 5, 6), Is.EqualTo(Option<int>.None));

            var f1_7 = new Func<string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7) => a1 + a2 + a3 + a4 + a5 + a6 + a7);
            var g1_7 = f1_7.ToOptionFunc();
            Assert.That(g1_7("1", "2", "3", "4", "5", "6", "7"), Is.EqualTo(Option.Some("1234567")));
            f1_7 = new Func<string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7) => { throw new Exception("oops!"); });
            g1_7 = f1_7.ToOptionFunc();
            Assert.That(g1_7("1", "2", "3", "4", "5", "6", "7"), Is.EqualTo(Option<string>.None));
            f1_7 = new Func<string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7) => null);
            g1_7 = f1_7.ToOptionFunc();
            Assert.That(g1_7("1", "2", "3", "4", "5", "6", "7"), Is.EqualTo(Option<string>.None));

            var f2_7 = new Func<int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + 0);
            var g2_7 = f2_7.ToOptionFunc();
            Assert.That(g2_7(1, 2, 3, 4, 5, 6, 7), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 6 + 7 + 0)));
            f2_7 = new Func<int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7) => { throw new Exception("oops!"); });
            g2_7 = f2_7.ToOptionFunc();
            Assert.That(g2_7(1, 2, 3, 4, 5, 6, 7), Is.EqualTo(Option<int>.None));
            f2_7 = new Func<int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7) => null);
            g2_7 = f2_7.ToOptionFunc();
            Assert.That(g2_7(1, 2, 3, 4, 5, 6, 7), Is.EqualTo(Option<int>.None));

            var f1_8 = new Func<string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8);
            var g1_8 = f1_8.ToOptionFunc();
            Assert.That(g1_8("1", "2", "3", "4", "5", "6", "7", "8"), Is.EqualTo(Option.Some("12345678")));
            f1_8 = new Func<string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8) => { throw new Exception("oops!"); });
            g1_8 = f1_8.ToOptionFunc();
            Assert.That(g1_8("1", "2", "3", "4", "5", "6", "7", "8"), Is.EqualTo(Option<string>.None));
            f1_8 = new Func<string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8) => null);
            g1_8 = f1_8.ToOptionFunc();
            Assert.That(g1_8("1", "2", "3", "4", "5", "6", "7", "8"), Is.EqualTo(Option<string>.None));

            var f2_8 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + 0);
            var g2_8 = f2_8.ToOptionFunc();
            Assert.That(g2_8(1, 2, 3, 4, 5, 6, 7, 8), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 0)));
            f2_8 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8) => { throw new Exception("oops!"); });
            g2_8 = f2_8.ToOptionFunc();
            Assert.That(g2_8(1, 2, 3, 4, 5, 6, 7, 8), Is.EqualTo(Option<int>.None));
            f2_8 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8) => null);
            g2_8 = f2_8.ToOptionFunc();
            Assert.That(g2_8(1, 2, 3, 4, 5, 6, 7, 8), Is.EqualTo(Option<int>.None));

            var f1_9 = new Func<string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9);
            var g1_9 = f1_9.ToOptionFunc();
            Assert.That(g1_9("1", "2", "3", "4", "5", "6", "7", "8", "9"), Is.EqualTo(Option.Some("123456789")));
            f1_9 = new Func<string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9) => { throw new Exception("oops!"); });
            g1_9 = f1_9.ToOptionFunc();
            Assert.That(g1_9("1", "2", "3", "4", "5", "6", "7", "8", "9"), Is.EqualTo(Option<string>.None));
            f1_9 = new Func<string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9) => null);
            g1_9 = f1_9.ToOptionFunc();
            Assert.That(g1_9("1", "2", "3", "4", "5", "6", "7", "8", "9"), Is.EqualTo(Option<string>.None));

            var f2_9 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + 0);
            var g2_9 = f2_9.ToOptionFunc();
            Assert.That(g2_9(1, 2, 3, 4, 5, 6, 7, 8, 9), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 0)));
            f2_9 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9) => { throw new Exception("oops!"); });
            g2_9 = f2_9.ToOptionFunc();
            Assert.That(g2_9(1, 2, 3, 4, 5, 6, 7, 8, 9), Is.EqualTo(Option<int>.None));
            f2_9 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9) => null);
            g2_9 = f2_9.ToOptionFunc();
            Assert.That(g2_9(1, 2, 3, 4, 5, 6, 7, 8, 9), Is.EqualTo(Option<int>.None));

            var f1_10 = new Func<string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10);
            var g1_10 = f1_10.ToOptionFunc();
            Assert.That(g1_10("1", "2", "3", "4", "5", "6", "7", "8", "9", "10"), Is.EqualTo(Option.Some("12345678910")));
            f1_10 = new Func<string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10) => { throw new Exception("oops!"); });
            g1_10 = f1_10.ToOptionFunc();
            Assert.That(g1_10("1", "2", "3", "4", "5", "6", "7", "8", "9", "10"), Is.EqualTo(Option<string>.None));
            f1_10 = new Func<string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10) => null);
            g1_10 = f1_10.ToOptionFunc();
            Assert.That(g1_10("1", "2", "3", "4", "5", "6", "7", "8", "9", "10"), Is.EqualTo(Option<string>.None));

            var f2_10 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + 0);
            var g2_10 = f2_10.ToOptionFunc();
            Assert.That(g2_10(1, 2, 3, 4, 5, 6, 7, 8, 9, 10), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 + 0)));
            f2_10 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10) => { throw new Exception("oops!"); });
            g2_10 = f2_10.ToOptionFunc();
            Assert.That(g2_10(1, 2, 3, 4, 5, 6, 7, 8, 9, 10), Is.EqualTo(Option<int>.None));
            f2_10 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10) => null);
            g2_10 = f2_10.ToOptionFunc();
            Assert.That(g2_10(1, 2, 3, 4, 5, 6, 7, 8, 9, 10), Is.EqualTo(Option<int>.None));

            var f1_11 = new Func<string, string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11);
            var g1_11 = f1_11.ToOptionFunc();
            Assert.That(g1_11("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11"), Is.EqualTo(Option.Some("1234567891011")));
            f1_11 = new Func<string, string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11) => { throw new Exception("oops!"); });
            g1_11 = f1_11.ToOptionFunc();
            Assert.That(g1_11("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11"), Is.EqualTo(Option<string>.None));
            f1_11 = new Func<string, string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11) => null);
            g1_11 = f1_11.ToOptionFunc();
            Assert.That(g1_11("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11"), Is.EqualTo(Option<string>.None));

            var f2_11 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11 + 0);
            var g2_11 = f2_11.ToOptionFunc();
            Assert.That(g2_11(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 + 11 + 0)));
            f2_11 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11) => { throw new Exception("oops!"); });
            g2_11 = f2_11.ToOptionFunc();
            Assert.That(g2_11(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11), Is.EqualTo(Option<int>.None));
            f2_11 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11) => null);
            g2_11 = f2_11.ToOptionFunc();
            Assert.That(g2_11(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11), Is.EqualTo(Option<int>.None));

            var f1_12 = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11 + a12);
            var g1_12 = f1_12.ToOptionFunc();
            Assert.That(g1_12("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"), Is.EqualTo(Option.Some("123456789101112")));
            f1_12 = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12) => { throw new Exception("oops!"); });
            g1_12 = f1_12.ToOptionFunc();
            Assert.That(g1_12("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"), Is.EqualTo(Option<string>.None));
            f1_12 = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12) => null);
            g1_12 = f1_12.ToOptionFunc();
            Assert.That(g1_12("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"), Is.EqualTo(Option<string>.None));

            var f2_12 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11 + a12 + 0);
            var g2_12 = f2_12.ToOptionFunc();
            Assert.That(g2_12(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 + 11 + 12 + 0)));
            f2_12 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12) => { throw new Exception("oops!"); });
            g2_12 = f2_12.ToOptionFunc();
            Assert.That(g2_12(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12), Is.EqualTo(Option<int>.None));
            f2_12 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12) => null);
            g2_12 = f2_12.ToOptionFunc();
            Assert.That(g2_12(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12), Is.EqualTo(Option<int>.None));

            var f1_13 = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11 + a12 + a13);
            var g1_13 = f1_13.ToOptionFunc();
            Assert.That(g1_13("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13"), Is.EqualTo(Option.Some("12345678910111213")));
            f1_13 = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13) => { throw new Exception("oops!"); });
            g1_13 = f1_13.ToOptionFunc();
            Assert.That(g1_13("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13"), Is.EqualTo(Option<string>.None));
            f1_13 = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13) => null);
            g1_13 = f1_13.ToOptionFunc();
            Assert.That(g1_13("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13"), Is.EqualTo(Option<string>.None));

            var f2_13 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11 + a12 + a13 + 0);
            var g2_13 = f2_13.ToOptionFunc();
            Assert.That(g2_13(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 + 11 + 12 + 13 + 0)));
            f2_13 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13) => { throw new Exception("oops!"); });
            g2_13 = f2_13.ToOptionFunc();
            Assert.That(g2_13(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13), Is.EqualTo(Option<int>.None));
            f2_13 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13) => null);
            g2_13 = f2_13.ToOptionFunc();
            Assert.That(g2_13(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13), Is.EqualTo(Option<int>.None));

            var f1_14 = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11 + a12 + a13 + a14);
            var g1_14 = f1_14.ToOptionFunc();
            Assert.That(g1_14("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14"), Is.EqualTo(Option.Some("1234567891011121314")));
            f1_14 = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14) => { throw new Exception("oops!"); });
            g1_14 = f1_14.ToOptionFunc();
            Assert.That(g1_14("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14"), Is.EqualTo(Option<string>.None));
            f1_14 = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14) => null);
            g1_14 = f1_14.ToOptionFunc();
            Assert.That(g1_14("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14"), Is.EqualTo(Option<string>.None));

            var f2_14 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11 + a12 + a13 + a14 + 0);
            var g2_14 = f2_14.ToOptionFunc();
            Assert.That(g2_14(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 + 11 + 12 + 13 + 14 + 0)));
            f2_14 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14) => { throw new Exception("oops!"); });
            g2_14 = f2_14.ToOptionFunc();
            Assert.That(g2_14(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14), Is.EqualTo(Option<int>.None));
            f2_14 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14) => null);
            g2_14 = f2_14.ToOptionFunc();
            Assert.That(g2_14(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14), Is.EqualTo(Option<int>.None));

            var f1_15 = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11 + a12 + a13 + a14 + a15);
            var g1_15 = f1_15.ToOptionFunc();
            Assert.That(g1_15("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"), Is.EqualTo(Option.Some("123456789101112131415")));
            f1_15 = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15) => { throw new Exception("oops!"); });
            g1_15 = f1_15.ToOptionFunc();
            Assert.That(g1_15("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"), Is.EqualTo(Option<string>.None));
            f1_15 = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15) => null);
            g1_15 = f1_15.ToOptionFunc();
            Assert.That(g1_15("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"), Is.EqualTo(Option<string>.None));

            var f2_15 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11 + a12 + a13 + a14 + a15 + 0);
            var g2_15 = f2_15.ToOptionFunc();
            Assert.That(g2_15(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 + 11 + 12 + 13 + 14 + 15 + 0)));
            f2_15 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15) => { throw new Exception("oops!"); });
            g2_15 = f2_15.ToOptionFunc();
            Assert.That(g2_15(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15), Is.EqualTo(Option<int>.None));
            f2_15 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15) => null);
            g2_15 = f2_15.ToOptionFunc();
            Assert.That(g2_15(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15), Is.EqualTo(Option<int>.None));

            var f1_16 = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11 + a12 + a13 + a14 + a15 + a16);
            var g1_16 = f1_16.ToOptionFunc();
            Assert.That(g1_16("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16"), Is.EqualTo(Option.Some("12345678910111213141516")));
            f1_16 = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16) => { throw new Exception("oops!"); });
            g1_16 = f1_16.ToOptionFunc();
            Assert.That(g1_16("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16"), Is.EqualTo(Option<string>.None));
            f1_16 = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16) => null);
            g1_16 = f1_16.ToOptionFunc();
            Assert.That(g1_16("1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16"), Is.EqualTo(Option<string>.None));

            var f2_16 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16) => a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a11 + a12 + a13 + a14 + a15 + a16 + 0);
            var g2_16 = f2_16.ToOptionFunc();
            Assert.That(g2_16(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16), Is.EqualTo(Option.Some(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 + 11 + 12 + 13 + 14 + 15 + 16 + 0)));
            f2_16 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16) => { throw new Exception("oops!"); });
            g2_16 = f2_16.ToOptionFunc();
            Assert.That(g2_16(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16), Is.EqualTo(Option<int>.None));
            f2_16 = new Func<int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?, int?>((a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16) => null);
            g2_16 = f2_16.ToOptionFunc();
            Assert.That(g2_16(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16), Is.EqualTo(Option<int>.None));

        }
    }
}