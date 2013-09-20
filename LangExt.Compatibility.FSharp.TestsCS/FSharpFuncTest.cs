using System;
using LangExt;
using LangExt.Compatibility.FSharp;
using NUnit.Framework;

namespace LangExt.Compatibility.FSharp.TestsCS
{
    [TestFixture]
    public class FSharpFuncTest
    {
        [Test]
        public void FuncをFSharpFuncに変換できる()
        {
            var f0 = Create.Func(() => 42);
            var g0 = f0.ToFSharpFunc();
            Assert.That(g0.Invoke(null), Is.EqualTo(42));

            var f1 = Create.Func((int i) => i);
            var g1 = f1.ToFSharpFunc();
            Assert.That(g1.Invoke(42), Is.EqualTo(42));

            var f2 = Create.Func((int i1, int i2) => i1 + i2);
            var g2 = f2.ToFSharpFunc();
            Assert.That(g2.Invoke(10).Invoke(20), Is.EqualTo(30));
        }

        [Test]
        public void FSharpFuncをFuncに変換できる()
        {
            var f0 = Microsoft.FSharp.Core.FSharpFunc<Microsoft.FSharp.Core.Unit, int>.FromConverter(_ => 42);
            var g0 = f0.ToFunc();
            Assert.That(g0(), Is.EqualTo(42));

            var f1 = Microsoft.FSharp.Core.FSharpFunc<int, int>.FromConverter(i => i);
            var g1 = f1.ToFunc();
            Assert.That(g1(42), Is.EqualTo(42));

            var f2 = Microsoft.FSharp.Core.FSharpFunc<int, Microsoft.FSharp.Core.FSharpFunc<int, int>>.FromConverter(i1 =>
                Microsoft.FSharp.Core.FSharpFunc<int, int>.FromConverter(i2 => i1 + i2));
            var g2 = f2.ToFunc();
            Assert.That(g2(10, 20), Is.EqualTo(30));
        }
    }
}
