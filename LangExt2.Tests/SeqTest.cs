using System;
using LangExt2;
using NUnit.Framework;

namespace LangExt2.Tests
{
    using LinqIE = System.Linq.Enumerable;
    public class SeqTest
    {
        [Test(Description="Seq.Empty()は空のシーケンスを返す")]
        public void Empty()
        {
            Assert.That(Seq.Empty<int>().IsEmpty(), Is.True);
        }
    }
}
