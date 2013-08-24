using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LangExt.Tests
{
    [TestFixture]
    public class ApplicativeTest
    {
        [TestCase()]
        public void ApplyToTheOption()
        {
            var applied = Apply.To(Option.Some(23))
                .By(i => i.ToString());
            Assert.That(applied, Is.EqualTo(Option.Some("23")));
        }

        [TestCase()]
        public void ApplyToTwoOption()
        {
            var applied = Apply.To(Option.Some(23), Option.Some("Something"))
                .By((i, str) => i.ToString() + str);
            Assert.That(applied, Is.EqualTo(Option.Some("23Something")));
        }

        [TestCase()]
        public void ApplyToTheSeq()
        {
            var applied = Apply.To(Seq.Init(3, Func.Id))
                .By(i => i.ToString());
            Assert.That(applied, Is.EqualTo(new []{ "0", "1", "2" }.ToSeq()));
        }

        [TestCase()]
        public void ApplyToTwoSeq()
        {
            var applied = Apply.To(Seq.Init(2, Func.Id), Seq.Init(2, Func.Id))
                .By((x1, x2) => x1 + x2); // [0 + 0; 0 + 1; 1 + 0; 1 + 1]
            Assert.That(applied, Is.EqualTo(new[] { 0, 1, 1, 2 }.ToSeq()));
        }
    }
}
