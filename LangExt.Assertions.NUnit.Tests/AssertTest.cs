using System;
using LangExt;

using NTest = global::NUnit.Framework.TestAttribute;
using NAssert = global::NUnit.Framework.Assert;
using NIs = global::NUnit.Framework.Is;

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

        void TestFailure(Action assertion, string message = null)
        {
            try
            {
                assertion();
                NAssert.Fail("失敗すべきアサーションが成功");
            }
            catch (global::NUnit.Framework.AssertionException e)
            {
                if (message != null)
                {
                    NAssert.That(e.Message, NIs.EqualTo(message));
                }
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

        [NTest]
        public void Noneの比較ができる()
        {
            TestSuccess(() => Assert.That(Option<int>.None, Is.None));
            TestFailure(() => Assert.That(Option.Some(42), Is.None), "  Expected: None\r\n  But was:  Some(42)\r\n");
        }

        [NTest]
        public void Someの比較ができる()
        {
            TestSuccess(() => Assert.That(Option.Some("hoge"), Is.EqualTo(Option.Some("hoge"))));
            TestFailure(() => Assert.That(Option<string>.None, Is.EqualTo(Option.Some("hoge"))), "  Expected: Some(hoge)\r\n  But was:  None\r\n");

            TestSuccess(() => Assert.That(Option.Some("hoge"), Is.Some("hoge")));
            TestFailure(() => Assert.That(Option<string>.None, Is.Some("hoge")), "  Expected: Some(hoge)\r\n  But was:  None\r\n");
        }

        [NTest]
        public void タプルの比較ができる()
        {
            TestSuccess(() => Assert.That(Tuple.Create(42, "aaa"), Is.EqualTo(42, "aaa")));
            TestFailure(() => Assert.That(Tuple.Create(42, "aaa"), Is.EqualTo(0, "aaa")));
        }
    }
}
