using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using LangExt.Legacy;

namespace LangExt.Legacy.Tests
{
    [TestFixture]
    public class LegacyObjectTest
    {
        class FailureException : Exception { }

        public enum MatchResult
        {
            Success,
            Failure,
            Default
        }

        public class 型引数が1つのTypeMatch
        {
            [TestCase(42, MatchResult.Success)]
            [TestCase(true, MatchResult.Failure)]
            [TestCase((byte)42, MatchResult.Failure)]
            [TestCase('a', MatchResult.Failure)]
            [TestCase(42.0, MatchResult.Failure)]
            [TestCase("42", MatchResult.Failure)]
            public void objectがintにマッチした場合にintの処理が呼び出される(object target, MatchResult expected)
            {
                try
                {
                    target.TypeMatch(
                        (int _) => { if (expected == MatchResult.Success) return 0; else throw new FailureException(); });
                }
                catch (FailureException)
                {
                    if (expected != MatchResult.Failure)
                        Assert.Fail();
                }
                catch (MatchFailureException)
                {
                    if(expected != MatchResult.Failure)
                        Assert.Fail();
                }
            }

            [TestCase(42, MatchResult.Failure)]
            [TestCase(true, MatchResult.Failure)]
            [TestCase((byte)42, MatchResult.Failure)]
            [TestCase('a', MatchResult.Failure)]
            [TestCase(42.0, MatchResult.Failure)]
            [TestCase("42", MatchResult.Success)]
            public void objectがstringにマッチした場合にstringの処理が呼び出される(object target, MatchResult expected)
            {
                try
                {
                    target.TypeMatch(
                        (string _) => { if (expected == MatchResult.Success) return 0; else throw new FailureException(); });
                }
                catch (FailureException)
                {
                    if (expected != MatchResult.Failure)
                        Assert.Fail();
                }
                catch (MatchFailureException)
                {
                    if(expected != MatchResult.Failure)
                        Assert.Fail();
                }
            }

            [TestCase(42, MatchResult.Success)]
            [TestCase(true, MatchResult.Default)]
            [TestCase((byte)42, MatchResult.Default)]
            [TestCase('a', MatchResult.Default)]
            [TestCase(42.0, MatchResult.Default)]
            [TestCase("42", MatchResult.Default)]
            public void objectがintにマッチした場合にintの処理が呼び出され_マッチしなかった場合にデフォルトの処理が呼び出される(object target, MatchResult expected)
            {
                target.TypeMatch(
                    (int _) => { if (expected == MatchResult.Success) return 0; else throw new FailureException(); },
                    other => { if (expected == MatchResult.Default) return 0; else throw new FailureException(); });
            }

            [TestCase(42, MatchResult.Default)]
            [TestCase(true, MatchResult.Default)]
            [TestCase((byte)42, MatchResult.Default)]
            [TestCase('a', MatchResult.Default)]
            [TestCase(42.0, MatchResult.Default)]
            [TestCase("42", MatchResult.Success)]
            public void objectがstringにマッチした場合にstringの処理が呼び出され_マッチしなかった場合にデフォルトの処理が呼び出される(object target, MatchResult expected)
            {
                target.TypeMatch(
                    (string _) => { if (expected == MatchResult.Success) return 0; else throw new FailureException(); },
                    other => { if (expected == MatchResult.Default) return 0; else throw new FailureException(); });
            }
        }
    }
}
