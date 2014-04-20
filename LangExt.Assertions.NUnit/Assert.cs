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

        public static void That<T>(Option<T> actual, OptionExpression<T> expression)
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

    public class OptionExpression<T>
    {
        readonly IResolveConstraint constraint;

        public OptionExpression(IResolveConstraint constraint)
        {
            this.constraint = constraint;
        }

        public virtual IResolveConstraint ToNUnitConstraint()
        {
            return this.constraint;
        }

        public static implicit operator OptionExpression<T>(OptionIsNoneExpression expr)
        {
            return new OptionExpression<T>(NIs.EqualTo(Option<T>.None));
        }
    }

    public class OptionIsNoneExpression
    {
        public static readonly OptionIsNoneExpression Instance = new OptionIsNoneExpression();
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

        public static OptionIsNoneExpression None
        {
            get { return OptionIsNoneExpression.Instance; }
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
