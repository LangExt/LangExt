using System;
using LangExt;
using NUnit.Framework;

namespace LangExt.Tests
{
    [TestFixture]
    public class ChoiceTest
    {
        static U Fail<T, U>(T _) { throw new Exception(); }

        [Test]
        public void intとstringからなるChoiceに数値を入れると数値が取り出せる()
        {
            Choice<int, string> x = Choice.CreateCase1Of2(42);
            Assert.That(x.Match<int>(Func.Id, Fail<string, int>), Is.EqualTo(42));
        }

        [Test]
        public void intとstringからなるChoiceに文字列を入れると文字列が取り出せる()
        {
            Choice<int, string> x = Choice.CreateCase2Of2("hoge");
            Assert.That(x.Match<string>(Fail<int, string>, Func.Id), Is.EqualTo("hoge"));
        }

        [TestCase(1, 1, true)]
        [TestCase(1, 2, false)]
        [TestCase("hoge", "hoge", true)]
        [TestCase("hoge", "piyo", false)]
        [TestCase(1, "hoge", false)]
        public void Equalsで比較ができる(object a, object b, bool expected)
        {
            var x = a.GetType() == typeof(int) ? new Choice<int, string>((int)a) : new Choice<int, string>((string)a);
            var y = b.GetType() == typeof(int) ? new Choice<int, string>((int)b) : new Choice<int, string>((string)b);
            Assert.That(x.Equals(y), Is.EqualTo(expected));
            Assert.That(x == y, Is.EqualTo(expected));
            Assert.That(x != y, Is.EqualTo(!expected));
        }

        [TestCase(42, "Choice(42:Int32)")]
        [TestCase("hoge", "Choice(hoge:String)")]
        public void ToStringで文字列化できる(object a, string expected)
        {
            var x = a.GetType() == typeof(int) ? new Choice<int, string>((int)a) : new Choice<int, string>((string)a);
            Assert.That(x.ToString(), Is.EqualTo(expected));
        }

        [TestCase("hoge", "piyo", "hogepiyo")]
        [TestCase(40, 2, "42")]
        [TestCase("hoge", 2, null)]
        [TestCase(40, "piyo", null)]
        public void 二項演算できる(object a, object b, string expected)
        {
            var x = a.GetType() == typeof(int) ? new Choice<int, string>((int)a) : new Choice<int, string>((string)a);
            var y = b.GetType() == typeof(int) ? new Choice<int, string>((int)b) : new Choice<int, string>((string)b);
            var expectedOpt = Option.Create(expected);
            Assert.That(Create.Tuple(x, y).TryBinOp((i, j) => (i + j).ToString(), (s1, s2) => s1 + s2), Is.EqualTo(expectedOpt));
        }

        [TestCase(1, 2, -1)]
        [TestCase(1, 1, 0)]
        [TestCase(2, 1, 1)]
        [TestCase("hoge", "piyo", -1)]
        [TestCase("hoge", "hoge", 0)]
        [TestCase("piyo", "hoge", 1)]
        [TestCase(1, "hoge", -1)]
        [TestCase("hoge", 2, 1)]
        public void 大小比較できる(object a, object b, int expected)
        {
            var x = a.GetType() == typeof(int) ? new Choice<int, string>((int)a) : new Choice<int, string>((string)a);
            var y = b.GetType() == typeof(int) ? new Choice<int, string>((int)b) : new Choice<int, string>((string)b);
            Assert.That(x.CompareTo(y).Match(() => -1, () => 0, () => 1), Is.EqualTo(expected));
            var cmp = Choice.Comparer<int, string>();
            Assert.That(cmp.Compare(x, y), Is.EqualTo(expected));
        }
    }
}
