using System;
using LangExt;
using NUnit.Framework.Constraints;

using NAssert = NUnit.Framework.Assert;
using NIs = NUnit.Framework.Is;

namespace LangExt.Assertions.NUnit
{
    public static class Assert
    {
        public static void That<T>(T actual, IAssertionExpression<T> expression)
        {
            NAssert.That(actual, expression.ToNUnitConstraint());
        }
    }

    public interface IAssertionExpression<T>
    {
        IResolveConstraint ToNUnitConstraint();
    }

    internal sealed class AssertionExpression<T> : IAssertionExpression<T>
    {
        readonly IResolveConstraint constraint;

        public AssertionExpression(IResolveConstraint constraint)
        {
            this.constraint = constraint;
        }

        public IResolveConstraint ToNUnitConstraint()
        {
            return this.constraint;
        }
    }

    public static class Is
    {
        public static IAssertionExpression<T> EqualTo<T>(T expected)
        {
            return new AssertionExpression<T>(NIs.EqualTo(expected));
        }

        public static NotExpression Not
        {
            get { return NotExpression.Instance; }
        }
    }

    public sealed class NotExpression
    {
        internal static readonly NotExpression Instance = new NotExpression();

        public IAssertionExpression<T> EqualTo<T>(T expected)
        {
            return new AssertionExpression<T>(NIs.Not.EqualTo(expected));
        }
    }
}
