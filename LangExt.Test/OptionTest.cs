using System.Linq;
using NUnit.Framework;

namespace LangExt.Test
{
    [TestFixture]
    class OptionTest
    {
        [Test]
        public void Someが生成できる()
        {
            Option<int> some = 42;
            Assert.That(some.GetType(), Is.EqualTo(typeof(Option<int>)));
        }

        [Test]
        public void Someが明示的に生成できる()
        {
            var some = new Option<int>(42);
            Assert.That(some.GetType(), Is.EqualTo(typeof(Option<int>)));
        }

        [Test]
        public void Noneが生成できる()
        {
            var none = default(Option<int>);
            Assert.That(none, Is.EqualTo(Option<int>.None));
        }

        [Test]
        public void Noneが明示的に生成できる()
        {
            var none = Option<int>.None;
            Assert.That(none.GetType(), Is.EqualTo(typeof(Option<int>)));
        }

        [Test]
        public void Optionを値型のdefaultで初期化してもNoneにならない()
        {
            Option<int> some = default(int); // 0
            Assert.That(some.Or(-1), Is.EqualTo(0));
        }

        [Test]
        public void Someに対応する関数が呼び出せる()
        {
            Option<int> opt = 21;
            var result = opt.Match(
                v => v * 2,
                _ => 0
            );
            Assert.That(result, Is.EqualTo(42));
        }

        [Test]
        public void Noneに対応する関数が呼び出せる()
        {
            Option<int> opt = default(Option<int>);
            var result = opt.Match(
                v => 42,
                _ => 0
            );
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Someの値が取り出せる()
        {
            Option<int> opt = 42;
            Assert.That(opt.Or(0), Is.EqualTo(42));
        }

        [Test]
        public void Noneが指定した値に変換される()
        {
            var opt = Option<int>.None;
            Assert.That(opt.Or(0), Is.EqualTo(0));
        }

        [TestCase(42, 42, true)]
        [TestCase(42, 10, false)]
        [TestCase(42, "", false)]
        public void 中の値によって等価性が判定される(object a, object b, bool expected)
        {
            Assert.That(new Option<object>(a).Equals(new Option<object>(b)), Is.EqualTo(expected));
        }

        [Test]
        public void NoneとSomeは等しくない()
        {
            Assert.That(new Option<int>(42), Is.Not.EqualTo(Option<int>.None));
        }

        [Test]
        public void 同じ型に対するNone同士は常に等しい()
        {
            var opt = Option<int>.None;
            Assert.That(opt, Is.EqualTo(Option<int>.None));
        }

        [Test]
        public void 違う型に対するNone同士は常に等しくない()
        {
            var opt = Option<int>.None;
            Assert.That(opt.Equals(Option<string>.None), Is.False);
        }

        [Test]
        public void NoneのBindが行える()
        {
            var opt = Option<int>.None;

            var opt2 = opt.Bind(v => new Option<int>(42));
            Assert.That(opt2.Equals(Option<int>.None), Is.True);
        }

        [Test]
        public void SomeのBindが行える()
        {
            var opt = new Option<int>(42);

            var opt2 = opt.Bind(v => new Option<int>(100));
            Assert.That(opt2.Equals(new Option<int>(100)), Is.True);
        }

        [Test]
        public void クエリ式でbindができる()
        {
            var opt1 = new Option<int>(42);
            var opt2 = new Option<int>(43);

            var result =
                    from v1 in opt1
                    from v2 in opt2
                    select v2;

            Assert.That(result.Equals(new Option<int>(43)), Is.True);
        }


        [Test]
        public void クエリ式でbindができる_途中失敗パターン()
        {
            var opt1 = new Option<int>(42);
            var opt2 = Option<int>.None;

            var result =
                    from v1 in opt1
                    from v2 in opt2
                    select v2;

            Assert.That(result.Equals(Option<int>.None), Is.True);
        }
    }
}
