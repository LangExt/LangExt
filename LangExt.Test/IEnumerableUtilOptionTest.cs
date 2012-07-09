using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LangExt.Test
{
    [TestFixture]
    class IEnumerableUtilOptionTest
    {
        [TestCase(0, 10)]
        [TestCase(1, 20)]
        [TestCase(2, 30)]
        public void 配列の要素が安全に取り出せる(int index, int expected)
        {
            Assert.That(new[] { 10, 20, 30 }.ElementAt(index), Is.EqualTo(Option.Some(expected)));
        }

        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        public void 配列の要素を安全に取り出せる_存在しない場合はNone(int index)
        {
            Assert.That(new[] { 10, 20, 30 }.ElementAt(index), Is.EqualTo(Option<int>.None));
        }

        [Test]
        public void 配列の最初の要素が安全に取り出せる()
        {
            Assert.That(new[] { 10, 20, 30 }.First(), Is.EqualTo(Option.Some(10)));
        }

        [Test]
        public void 配列の最初の要素が安全に取り出せる_存在しない場合はNone()
        {
            Assert.That(new int[] { }.First(), Is.EqualTo(Option<int>.None));
        }

        [Test]
        public void 配列の一つだけの要素が安全に取り出せる()
        {
            Assert.That(new[] { 10 }.Single(), Is.EqualTo(Option.Some(10)));
        }

        [Test]
        public void 配列の一つだけの要素が安全に取り出せる_存在しない場合はNone()
        {
            Assert.That(new int[] { }.Single(), Is.EqualTo(Option<int>.None));
        }

        [Test]
        public void 配列の一つだけの要素が安全に取り出せる_二つ以上存在する場合はNone()
        {
            Assert.That(new int[] {　10, 20, 30 }.Single(), Is.EqualTo(Option<int>.None));
        }
    }
}
