using System;
using LangExt;
using NUnit.Framework;

namespace LangExt.Tests
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
