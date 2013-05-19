using System;
using LangExt.Playground.PatternMatching;
using NUnit.Framework;

namespace LangExt.Tests.Playground.PatternMatching
{
    [TestFixture]
    public class Example
    {
        [Test]
        public void SimplePatternMatching()
        {
            var _ = new SeqPatternFactory<int>();
            /*
             * match [1..5] with
             * | x::xs ->
             *     Assert.That(x, Is.EqualTo(1))
             *     Assert.That(xs, Is.EqualTo([2..5]))
             * | otherwise -> failwith ""
             */
            Create.Seq(1, 2, 3, 4, 5).Match(
                _.Any.And(_.Rest).Then(
                    (x, xs) =>
                    {
                        Assert.That(x, Is.EqualTo(1));
                        Assert.That(xs, Is.EqualTo(Create.Seq(2, 3, 4, 5)));
                        return Unit._;
                    },
                    otherwise => { throw new Exception(); }));

            /*
             * match [1] with
             * | x::xs ->
             *     Assert.That(x, Is.EqualTo(1))
             *     Assert.That(xs, Is.Empty)
             * | otherwise -> failwith ""
             */
            Create.Seq(1).Match(
                _.Any.And(_.Rest).Then(
                    (x, xs) =>
                    {
                        Assert.That(x, Is.EqualTo(1));
                        Assert.That(xs, Is.Empty);
                        return Unit._;
                    },
                    otherwise => { throw new Exception(); }));

            /*
             * match [] with
             * | x::xs -> failwith ""
             * | otherwise -> Assert.That(otherwise, Is.Empty)
             */
            Seq.Empty<int>().Match(
                _.Any.And(_.Rest).Then(
                    (x, xs) => { throw new Exception(); },
                    otherwise =>
                    {
                        Assert.That(otherwise, Is.Empty);
                        return Unit._;
                    }));
        }

        [Test]
        public void ComplexPatternMatching()
        {
            var _ = new SeqPatternFactory<string>();
            /*
             * let simpl stack =
             *   match stack with
             *   | "0"::x::"+"::rest -> x::rest
             *   | x::"0"::"+"::rest -> x::rest
             *   | "1"::x::"*"::rest -> x::rest
             *   | x::"1"::"*"::rest -> x::rest
             *   | otherwise -> otherwie
             */
            Func<ISeq<string>, ISeq<string>> simpl = stack =>
                stack.Match(
                     _.Eq("0").And(_.Any).And(_.Eq("+")).And(_.Rest).Then(
                         (zero, x, plus, rest) => Seq.Singleton(x).Append(rest),
                     _.Any.And(_.Eq("0")).And(_.Eq("+")).And(_.Rest).Then(
                         (x, zero, plus, rest) => Seq.Singleton(x).Append(rest),
                     _.Eq("1").And(_.Any).And(_.Eq("*")).And(_.Rest).Then(
                         (one, x, aster, rest) => Seq.Singleton(x).Append(rest),
                     _.Any.And(_.Eq("1")).And(_.Eq("*")).And(_.Rest).Then(
                         (x, one, aster, rest) => Seq.Singleton(x).Append(rest),
                         otherwise => otherwise)))));

            Assert.That(simpl(Create.Seq("0", "42", "+", "1", "*")), Is.EqualTo(Create.Seq("42", "1", "*")));
            Assert.That(simpl(simpl(Create.Seq("0", "42", "+", "1", "*"))), Is.EqualTo(Create.Seq("42")));
            Assert.That(simpl(simpl(simpl(Create.Seq("0", "42", "+", "1", "*")))), Is.EqualTo(Create.Seq("42")));
        }
    }
}
