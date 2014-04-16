using System;
using LangExt;

using NTest = global::NUnit.Framework.TestAttribute;
using NAssert = global::NUnit.Framework.Assert;

namespace LangExt.Assertions.NUnit.Tests
{
    [global::NUnit.Framework.TestFixture]
    public class AssertTest
    {
        void TestSuccess(Action assertion)
        {
            try
            {
                assertion();
            }
            catch (Exception e)
            {
                NAssert.Fail("成功すべきアサーションが失敗:\n" + e.Message + "\n" + e.StackTrace);
            }
        }

        void TestFailure(Action assertion)
        {
            try
            {
                assertion();
                NAssert.Fail("失敗すべきアサーションが成功");
            }
            catch (global::NUnit.Framework.AssertionException)
            {
                // 成功
            }
            catch (Exception e)
            {
                NAssert.Fail("アサーションの失敗以外の原因で失敗:\n" + e.Message + "\n" + e.StackTrace);
            }
        }

        [NTest]
        public void 型指定されたEqualToが使える()
        {
            TestSuccess(() => Assert.That(42, Is.EqualTo(42)));
            TestFailure(() => Assert.That(42, Is.EqualTo(0)));
        }

        [NTest]
        public void 型指定されたEqualToのNotが使える()
        {
            TestSuccess(() => Assert.That(42, Is.Not.EqualTo(0)));
            TestFailure(() => Assert.That(42, Is.Not.EqualTo(42)));
        }
    }
}
