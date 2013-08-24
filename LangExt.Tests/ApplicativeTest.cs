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
                .By((i) => i.ToString());
            Assert.That(applied, Is.EqualTo(Option.Some("23")));
        }

        [TestCase()]
        public void ApplyToTwoOption()
        {
            var applied = Apply.To(Option.Some(23), Option.Some("Something"))
                .By((i, str) => i.ToString() + str);
            Assert.That(applied, Is.EqualTo(Option.Some("23Something")));
        }
    }
}
