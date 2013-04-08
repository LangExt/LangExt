using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LangExt2.Tests
{
    [TestFixture]
    public class ObjectModuleTest
    {
        public class ObjectIsNull
        {
            readonly object sut = null;

            [Test]
            public void IsNull_True()
            {
                Assert.That(sut.IsNull(), Is.True);
            }

            [Test]
            public void IsNotNull_False()
            {
                Assert.That(sut.IsNotNull(), Is.False);
            }

            [TestCase(null, true)]
            [TestCase("not null", false)]
            public void IsEqualTo(object other, bool expected)
            {
                Assert.That(sut.IsEqualTo(other), Is.EqualTo(expected));
            }

            [TestCase(null, false)]
            [TestCase("not null", true)]
            public void IsNotEqualTo(object other, bool expected)
            {
                Assert.That(sut.IsNotEqualTo(other), Is.EqualTo(expected));
            }

            [TestCase(null, true)]
            [TestCase("not null", false)]
            public void Eq(object other, bool expected)
            {
                Assert.That(ObjectModule.Eq(sut, other), Is.EqualTo(expected));
            }

            [TestCase(null, false)]
            [TestCase("not null", true)]
            public void NotEq(object other, bool expected)
            {
                Assert.That(ObjectModule.NotEq(sut, other), Is.EqualTo(expected));
            }

            [Test]
            public void ToStr_EmptyStr()
            {
                Assert.That(sut.ToStr(), Is.EqualTo(""));
            }
        }

        public class ObjectIsNotNull
        {
            readonly object sut = "not null";

            [Test]
            public void IsNull_False()
            {
                Assert.That(sut.IsNull(), Is.False);
            }

            [Test]
            public void IsNotNull_True()
            {
                Assert.That(sut.IsNotNull(), Is.True);
            }

            [TestCase(null, false)]
            [TestCase("not null", true)]
            [TestCase("not same", false)]
            public void IsEqualTo(object other, bool expected)
            {
                Assert.That(sut.IsEqualTo(other), Is.EqualTo(expected));
            }

            [TestCase(null, true)]
            [TestCase("not null", false)]
            [TestCase("not same", true)]
            public void IsNotEqualTo(object other, bool expected)
            {
                Assert.That(sut.IsNotEqualTo(other), Is.EqualTo(expected));
            }

            [TestCase(null, false)]
            [TestCase("not null", true)]
            [TestCase("not same", false)]
            public void Eq(object other, bool expected)
            {
                Assert.That(ObjectModule.Eq(sut, other), Is.EqualTo(expected));
            }

            [TestCase(null, true)]
            [TestCase("not null", false)]
            [TestCase("not same", true)]
            public void NotEq(object other, bool expected)
            {
                Assert.That(ObjectModule.NotEq(sut, other), Is.EqualTo(expected));
            }

            [Test]
            public void ToStr_NotNullStr()
            {
                Assert.That(sut.ToStr(), Is.EqualTo("not null"));
            }
        }

        public class StringIsNull
        {
            readonly string sut = null;

            [Test]
            public void IsNull_True()
            {
                Assert.That(sut.IsNull(), Is.True);
            }

            [Test]
            public void IsNotNull_False()
            {
                Assert.That(sut.IsNotNull(), Is.False);
            }

            [TestCase(null, true)]
            [TestCase("not null", false)]
            public void IsEqualTo(object other, bool expected)
            {
                Assert.That(sut.IsEqualTo(other), Is.EqualTo(expected));
            }

            [TestCase(null, false)]
            [TestCase("not null", true)]
            public void IsNotEqualTo(object other, bool expected)
            {
                Assert.That(sut.IsNotEqualTo(other), Is.EqualTo(expected));
            }

            [TestCase(null, true)]
            [TestCase("not null", false)]
            public void Eq(object other, bool expected)
            {
                Assert.That(ObjectModule.Eq(sut, other), Is.EqualTo(expected));
            }

            [TestCase(null, false)]
            [TestCase("not null", true)]
            public void NotEq(object other, bool expected)
            {
                Assert.That(ObjectModule.NotEq(sut, other), Is.EqualTo(expected));
            }

            [Test]
            public void ToStr_EmptyStr()
            {
                Assert.That(sut.ToStr(), Is.EqualTo(""));
            }
        }

        public class StringIsNotNull
        {
            readonly string sut = "not null";

            [Test]
            public void IsNull_False()
            {
                Assert.That(sut.IsNull(), Is.False);
            }

            [Test]
            public void IsNotNull_True()
            {
                Assert.That(sut.IsNotNull(), Is.True);
            }

            [TestCase(null, false)]
            [TestCase("not null", true)]
            [TestCase("not same", false)]
            public void IsEqualTo(object other, bool expected)
            {
                Assert.That(sut.IsEqualTo(other), Is.EqualTo(expected));
            }

            [TestCase(null, true)]
            [TestCase("not null", false)]
            [TestCase("not same", true)]
            public void IsNotEqualTo(object other, bool expected)
            {
                Assert.That(sut.IsNotEqualTo(other), Is.EqualTo(expected));
            }

            [TestCase(null, false)]
            [TestCase("not null", true)]
            [TestCase("not same", false)]
            public void Eq(object other, bool expected)
            {
                Assert.That(ObjectModule.Eq(sut, other), Is.EqualTo(expected));
            }

            [TestCase(null, true)]
            [TestCase("not null", false)]
            [TestCase("not same", true)]
            public void NotEq(object other, bool expected)
            {
                Assert.That(ObjectModule.NotEq(sut, other), Is.EqualTo(expected));
            }

            [Test]
            public void ToStr_NotNullStr()
            {
                Assert.That(sut.ToStr(), Is.EqualTo("not null"));
            }
        }
    }
}
