using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LangExt.Tests
{
    [TestFixture]
    public class FuncTest
    {
        [TestCase(42)]
        [TestCase("hoge")]
        public void Id<T>(T x)
        {
            Assert.That(Func.Id(x), Is.EqualTo(x));
        }

        static readonly Func<int, int, int> Sub = (a, b) => a - b;
        static readonly Func<int, Func<int, int>> SubC = a => b => a - b;
        static readonly Func<Tuple<int, int>, int> SubT = tpl => tpl.Match((a, b) => a - b);

        static readonly Func<int, int, int, int> Sub3 = (a, b, c) => a - b - c;
        static readonly Func<int, Func<int, Func<int, int>>> Sub3C = a => b => c => a - b - c;
        static readonly Func<Tuple<int, int, int>, int> Sub3T = tpl => tpl.Match((a, b, c) => a - b - c);

        [Test]
        public void Flip()
        {
            Assert.That(Func.Flip(Sub)(1, 20), Is.EqualTo(19));
        }

        [Test]
        public void Flip2()
        {
            Assert.That(Func.Flip(SubC)(1)(20), Is.EqualTo(19));
        }

        #region Curry/Uncurry/Curried/Uncurried
        [Test]
        public void Curry2()
        {
            var curried = Func.Curry(Sub);
            Assert.That(curried(20)(1), Is.EqualTo(19));
        }

        [Test]
        public void Curry3()
        {
            var curried = Func.Curry(Sub3);
            Assert.That(curried(20)(1)(2), Is.EqualTo(17));
        }

        [Test]
        public void Uncurry2()
        {
            var curried = Func.Curry(Sub);
            var uncurried = Func.Uncurried(curried);
            Assert.That(uncurried(20, 1), Is.EqualTo(19));
        }

        [Test]
        public void Uncurry3()
        {
            var curried = Func.Curry(Sub3);
            var uncurried = Func.Uncurried(curried);
            Assert.That(uncurried(20, 1, 2), Is.EqualTo(17));
        }

        [Test]
        public void Curried2()
        {
            var curried = Sub.Curried();
            Assert.That(curried(20)(1), Is.EqualTo(19));
        }

        [Test]
        public void Curried3()
        {
            var curried = Sub3.Curried();
            Assert.That(curried(20)(1)(2), Is.EqualTo(17));
        }

        [Test]
        public void Uncurried2()
        {
            var curried = Sub.Curried();
            var uncurried = curried.Uncurried();
            Assert.That(uncurried(20, 1), Is.EqualTo(19));
        }

        [Test]
        public void Uncurried3()
        {
            var curried = Sub3.Curried();
            var uncurried = curried.Uncurried();
            Assert.That(uncurried(20, 1, 2), Is.EqualTo(17));
        }
        #endregion

        #region Tuple/Untuple/Tupled/Untupled
        [Test]
        public void Tuple2()
        {
            var tupled = Func.Tuple(Sub);
            Assert.That(tupled(Create.Tuple(20, 1)), Is.EqualTo(19));
        }

        [Test]
        public void Tuple3()
        {
            var tupled = Func.Tuple(Sub3);
            Assert.That(tupled(Create.Tuple(20, 1, 2)), Is.EqualTo(17));
        }

        [Test]
        public void Untuple2()
        {
            var tupled = Func.Tuple(Sub);
            var untupled = Func.Untuple(tupled);
            Assert.That(untupled(20, 1), Is.EqualTo(19));
        }

        [Test]
        public void Untuple3()
        {
            var tupled = Func.Tuple(Sub3);
            var untupled = Func.Untuple(tupled);
            Assert.That(untupled(20, 1,2), Is.EqualTo(17));
        }

        [Test]
        public void Tupled2()
        {
            var tupled = Sub.Tupled();
            Assert.That(tupled(Create.Tuple(20, 1)), Is.EqualTo(19));
        }

        [Test]
        public void Tupled3()
        {
            var tupled = Sub3.Tupled();
            Assert.That(tupled(Create.Tuple(20, 1, 2)), Is.EqualTo(17));
        }

        [Test]
        public void Untupled2()
        {
            var tupled = Sub.Tupled();
            var untupled = tupled.Untupled();
            Assert.That(untupled(20, 1), Is.EqualTo(19));
        }

        [Test]
        public void Untupled3()
        {
            var tupled = Sub3.Tupled();
            var untupled = tupled.Untupled();
            Assert.That(untupled(20, 1, 2), Is.EqualTo(17));
        }
        #endregion

        #region CurryX/UncurryX/UncurriedX/UncurryX
        [Test]
        public void CurryX2()
        {
            var curried = Func.CurryX(SubT);
            Assert.That(curried(20)(1), Is.EqualTo(19));
        }

        [Test]
        public void CurryX3()
        {
            var curried = Func.CurryX(Sub3T);
            Assert.That(curried(20)(1)(2), Is.EqualTo(17));
        }

        [Test]
        public void UncurryX2()
        {
            var curried = Func.CurryX(SubT);
            var uncurried = Func.UncurryX(curried);
            Assert.That(uncurried(Create.Tuple(20, 1)), Is.EqualTo(19));
        }

        [Test]
        public void UncurryX3()
        {
            var curried = Func.CurryX(Sub3T);
            var uncurried = Func.UncurryX(curried);
            Assert.That(uncurried(Create.Tuple(20, 1, 2)), Is.EqualTo(17));
        }

        [Test]
        public void CurriedX2()
        {
            var curried = SubT.CurriedX();
            Assert.That(curried(20)(1), Is.EqualTo(19));
        }

        [Test]
        public void CurriedX3()
        {
            var curried = Sub3T.CurriedX();
            Assert.That(curried(20)(1)(2), Is.EqualTo(17));
        }

        [Test]
        public void UncurriedX2()
        {
            var curried = SubT.CurriedX();
            var uncurried = curried.UncurriedX();
            Assert.That(uncurried(Create.Tuple(20, 1)), Is.EqualTo(19));
        }

        [Test]
        public void UncurriedX3()
        {
            var curried = Sub3T.CurriedX();
            var uncurried = curried.UncurriedX();
            Assert.That(uncurried(Create.Tuple(20, 1, 2)), Is.EqualTo(17));
        }
        #endregion
    }
}
