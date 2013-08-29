using System;
using NUnit.Framework;

namespace LangExt.Tests
{
    class Width : IUnit { }

    [TestFixture]
    public class IntWithUnitTest
    {
        [Test]
        public void デフォルトコンストラクタで値のないオブジェクトが生成できる()
        {
            var noValue = new IntWithUnit<Width>();
            Assert.That(noValue, Is.EqualTo(IntWithUnit<Width>.NoValue));
        }

        [Test]
        public void int値をIntWithUnitに変換できる()
        {
            var width = (IntWithUnit<Width>)42;
            Assert.That(width.HasValue, Is.True);
            Assert.That(width.Value, Is.EqualTo(42));
        }

        [TestCase(10, true)]
        [TestCase(null, false)]
        public void null許容int値をIntWithUnitに変換できる(int? value, bool expectedHasValue)
        {
            var width = (IntWithUnit<Width>)value;
            Assert.That(width.HasValue, Is.EqualTo(expectedHasValue));
        }

        [TestCase(10, 20, false)]
        [TestCase(10, 10, true)]
        [TestCase(20, 20, true)]
        [TestCase(null, 0, false)]
        [TestCase(0, null, false)]
        [TestCase(null, null, true)]
        public void 同値比較ができる(int? a, int? b, bool expectedEquals)
        {
            var width1 = a.WithUnit<Width>();
            var width2 = b.WithUnit<Width>();
            Assert.That(width1 == width2, Is.EqualTo(expectedEquals));
            Assert.That(width1 != width2, Is.Not.EqualTo(expectedEquals));
        }

        [TestCase(10, 20, false)]
        [TestCase(10, 10, true)]
        [TestCase(20, 20, true)]
        [TestCase(null, 0, false)]
        [TestCase(0, null, false)]
        [TestCase(null, null, true)]
        public void null許容int型との同値比較ができる(int? a, int? b, bool expectedEquals)
        {
            var width1 = a.WithUnit<Width>();
            int? width2 = b;
            Assert.That(width1 == width2, Is.EqualTo(expectedEquals));
            Assert.That(width1 != width2, Is.Not.EqualTo(expectedEquals));
            Assert.That(width2 == width1, Is.EqualTo(expectedEquals));
            Assert.That(width2 != width1, Is.Not.EqualTo(expectedEquals));
        }

        [TestCase(10, 20, false)]
        [TestCase(10, 10, true)]
        [TestCase(20, 20, true)]
        [TestCase(null, 0, false)]
        public void int型との同値比較ができる(int? a, int b, bool expectedEquals)
        {
            var width1 = a.WithUnit<Width>();
            int width2 = b;
            Assert.That(width1 == width2, Is.EqualTo(expectedEquals));
            Assert.That(width1 != width2, Is.Not.EqualTo(expectedEquals));
            Assert.That(width2 == width1, Is.EqualTo(expectedEquals));
            Assert.That(width2 != width1, Is.Not.EqualTo(expectedEquals));
        }

        [TestCase(-1, true)]
        [TestCase(0, true)]
        [TestCase(1, true)]
        [TestCase(null, false)]
        public void 条件式部分にIntWithUnitが使える(int? value, bool expectedRunTruePart)
        {
            var width = value.WithUnit<Width>();
            if (width)
            {
                if (expectedRunTruePart) Assert.Pass();
                else Assert.Fail();
            }
            else
            {
                if (expectedRunTruePart == false) Assert.Pass();
                else Assert.Fail();
            }
        }

        [TestCase(null, null, null)]
        [TestCase(null, 10, null)]
        [TestCase(10, null, null)]
        [TestCase(10, 20, 20)]
        [TestCase(20, 10, null)]
        [TestCase(10, 10, null)]
        public void 小なり演算子が使える(int? a, int? b, int? expected)
        {
            var width1 = a.WithUnit<Width>();
            var width2 = b.WithUnit<Width>();
            var expectedWidth = expected.WithUnit<Width>();

            Assert.That(width1 < width2, Is.EqualTo(expectedWidth));
        }

        [TestCase(null, null, null)]
        [TestCase(null, 10, null)]
        [TestCase(10, null, null)]
        [TestCase(10, 20, null)]
        [TestCase(20, 10, 10)]
        [TestCase(10, 10, null)]
        public void 大なり演算子が使える(int? a, int? b, int? expected)
        {
            var width1 = a.WithUnit<Width>();
            var width2 = b.WithUnit<Width>();
            var expectedWidth = expected.WithUnit<Width>();

            Assert.That(width1 > width2, Is.EqualTo(expectedWidth));
            Assert.That(width1 > b, Is.EqualTo(expectedWidth));
            Assert.That(a > width2, Is.EqualTo(expectedWidth));
        }

        [TestCase(null, null, null)]
        [TestCase(null, 10, null)]
        [TestCase(10, null, null)]
        [TestCase(10, 20, 20)]
        [TestCase(20, 10, null)]
        [TestCase(10, 10, 10)]
        public void 小なりイコール演算子が使える(int? a, int? b, int? expected)
        {
            var width1 = a.WithUnit<Width>();
            var width2 = b.WithUnit<Width>();
            var expectedWidth = expected.WithUnit<Width>();

            Assert.That(width1 <= width2, Is.EqualTo(expectedWidth));
        }

        [TestCase(null, null, null)]
        [TestCase(null, 10, null)]
        [TestCase(10, null, null)]
        [TestCase(10, 20, null)]
        [TestCase(20, 10, 10)]
        [TestCase(10, 10, 10)]
        public void 大なりイコール演算子が使える(int? a, int? b, int? expected)
        {
            var width1 = a.WithUnit<Width>();
            var width2 = b.WithUnit<Width>();
            var expectedWidth = expected.WithUnit<Width>();

            Assert.That(width1 >= width2, Is.EqualTo(expectedWidth));
        }

        [TestCase(null, null, null, false)]
        [TestCase(null, 20, 30, false)]
        [TestCase(10, null, 30, false)]
        [TestCase(10, 20, null, false)]
        [TestCase(10, 20, 30, true)]
        [TestCase(10, 10, 30, true)]
        [TestCase(10, 20, 20, false)]
        [TestCase(30, 20, 20, false)]
        [TestCase(30, 20, 50, false)]
        public void 比較演算子の連結が出来る(int? a, int? b, int? c, bool expected)
        {
            var width1 = a.WithUnit<Width>();
            var width2 = b.WithUnit<Width>();
            var width3 = c.WithUnit<Width>();
            if (width1 <= width2 < width3)
            {
                if (expected) Assert.Pass();
                else Assert.Fail();
            }
            else
            {
                if (expected == false) Assert.Pass();
                else Assert.Fail();
            }
        }

        [TestCase(10, null, 30, false)]
        [TestCase(10, 20, 30, true)]
        [TestCase(10, 10, 30, true)]
        [TestCase(10, 20, 20, false)]
        [TestCase(30, 20, 20, false)]
        [TestCase(30, 20, 50, false)]
        public void 比較演算子の連結が出来る(int a, int? b, int c, bool expected)
        {
            int width1 = a;
            var width2 = b.WithUnit<Width>();
            int width3 = c;
            if (width1 <= width2 < width3)
            {
                if (expected) Assert.Pass();
                else Assert.Fail();
            }
            else
            {
                if (expected == false) Assert.Pass();
                else Assert.Fail();
            }
        }

        [TestCase(null, null, null)]
        [TestCase(10, null, null)]
        [TestCase(null, 20, null)]
        [TestCase(10, 20, 30)]
        public void 加算が出来る(int? a, int? b, int? expected)
        {
            var width1 = a.WithUnit<Width>();
            var width2 = b.WithUnit<Width>();
            var expectedWidth = expected.WithUnit<Width>();
            Assert.That(width1 + width2, Is.EqualTo(expectedWidth));
        }

        [TestCase(null, null, null)]
        [TestCase(10, null, null)]
        [TestCase(null, 20, null)]
        [TestCase(10, 20, -10)]
        public void 減算が出来る(int? a, int? b, int? expected)
        {
            var width1 = a.WithUnit<Width>();
            var width2 = b.WithUnit<Width>();
            var expectedWidth = expected.WithUnit<Width>();
            Assert.That(width1 - width2, Is.EqualTo(expectedWidth));
        }

        [TestCase(null, null, null)]
        [TestCase(10, null, null)]
        [TestCase(null, 20, null)]
        [TestCase(10, 20, 200)]
        public void 乗算が出来る(int? a, int? b, int? expected)
        {
            var width1 = a.WithUnit<Width>();
            var expectedWidth = expected.WithUnit<Width>();
            Assert.That(width1 * b, Is.EqualTo(expectedWidth));
            Assert.That(b * width1, Is.EqualTo(expectedWidth));
        }

        [TestCase(null, null, null)]
        [TestCase(10, null, null)]
        [TestCase(null, 20, null)]
        [TestCase(20, 10, 2)]
        public void 除算が出来る(int? a, int? b, int? expected)
        {
            var width1 = a.WithUnit<Width>();
            var expectedWidth = expected.WithUnit<Width>();
            Assert.That(width1 / b, Is.EqualTo(expectedWidth));
        }

        [TestCase(null, null, null)]
        [TestCase(10, null, null)]
        [TestCase(null, 20, null)]
        [TestCase(20, 9, 2)]
        public void 余りを計算できる(int? a, int? b, int? expected)
        {
            var width1 = a.WithUnit<Width>();
            var expectedWidth = expected.WithUnit<Width>();
            Assert.That(width1 % b, Is.EqualTo(expectedWidth));
        }

        [TestCase(null, null)]
        [TestCase(10, -10)]
        [TestCase(-20, 20)]
        public void 符号が反転できる(int? value, int? expected)
        {
            var width = value.WithUnit<Width>();
            var expectedWidth = expected.WithUnit<Width>();
            Assert.That(-width, Is.EqualTo(expectedWidth));
        }
    }
}
