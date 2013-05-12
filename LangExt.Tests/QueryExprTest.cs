using System;
using NUnit.Framework;
// Sytem.Linq等をusingしないこと

namespace LangExt.Tests
{
    [TestFixture]
    public class QueryExprTest
    {
        public class EnumerableTest
        {
            [Test]
            public void Select()
            {
                var xs = new[] { 1, 2, 3 };
                var ys =
                    from x in xs
                    select x * 2;
                Assert.That(ys, Is.EqualTo(xs.Select(x => x * 2)));
            }

            [Test]
            public void Where()
            {
                var xs = new[] { 1, 2, 3 };
                var ys =
                    from x in xs
                    where x % 2 == 0
                    select x;
                Assert.That(ys, Is.EqualTo(xs.Where(x => x % 2 == 0)));
            }

            [Test]
            public void NestedFrom()
            {
                var xs = new[] { 1, 2, 3 };
                var ys = new[] { 10, 15, 20 };
                var zs = new[] { 0, 1, 0, 1 };
                var res =
                    from x in xs
                    from y in ys
                    from z in zs
                    select Create.Tuple(x, y, z);
                Assert.That(res, Is.EqualTo(xs.Bind(x => ys.Bind(y => zs.Bind(z => new[] { Create.Tuple(x, y, z) })))));
            }
        }

        public class SeqTest
        {
            [Test]
            public void Select()
            {
                var xs = Create.Seq(1, 2, 3);
                var ys =
                    from x in xs
                    select x * 2;
                Assert.That(ys, Is.EqualTo(xs.Map(x => x * 2)));
            }

            [Test]
            public void Where()
            {
                var xs = Create.Seq(1, 2, 3);
                var ys =
                    from x in xs
                    where x % 2 == 0
                    select x;
                Assert.That(ys, Is.EqualTo(xs.Filter(x => x % 2 == 0)));
            }

            [Test]
            public void NestedFrom()
            {
                var xs = Create.Seq(1, 2, 3);
                var ys = Create.Seq(10, 15, 20);
                var zs = Create.Seq(0, 1, 0, 1);
                var res =
                    from x in xs
                    from y in ys
                    from z in zs
                    select Create.Tuple(x, y, z);
                Assert.That(res, Is.EqualTo(xs.Bind(x => ys.Bind(y => zs.Bind(z => new[] { Create.Tuple(x, y, z) })))));
            }
        }

        public class OptionTest
        {
            [Test]
            public void Select_Some()
            {
                var res =
                    from x in Option.Some(42)
                    select x * 2;
                Assert.That(res, Is.EqualTo(Option.Some(84)));
            }

            [Test]
            public void Select_None()
            {
                var res =
                    from int x in Option.None
                    select x * 2;
                Assert.That(res, Is.EqualTo(Option<int>.None));
            }

            [TestCase(42, true)]
            [TestCase(41, false)]
            public void Where_Some(int n, bool isSome)
            {
                var res =
                    from x in Option.Some(n)
                    where x % 2 == 0
                    select x;
                Assert.That(res, Is.EqualTo(isSome ? Option.Some(n) : Option.None));
            }

            [Test]
            public void Where_None()
            {
                var res =
                    from int x in Option.None
                    where x % 2 == 0
                    select x;
                Assert.That(res, Is.EqualTo(Option<int>.None));
            }

            [Test]
            public void NestedFrom_Some()
            {
                var res =
                    from x in Option.Some(10)
                    from y in Option.Some(20)
                    from z in Option.Some(30)
                    select Create.Tuple(x, y, z);
                Assert.That(res, Is.EqualTo(Option.Some(Create.Tuple(10, 20, 30))));
            }

            [Test]
            public void NestedFrom_None()
            {
                var res =
                    from x in Option.Some(10)
                    from y in Option.Some(20)
                    from z in Option.None
                    select Create.Tuple(x, y, z);
                Assert.That(res, Is.EqualTo(Option<Tuple<int, int, Placeholder>>.None));
            }
        }

        public class ResultTest
        {
            [Test]
            public void Select_Success()
            {
                var res =
                    from x in Result.Success(42)
                    select x * 2;
                Assert.That(res, Is.EqualTo(Result.Success(84)));
            }

            [Test]
            public void Select_Failure()
            {
                var res =
                    from int x in Result.Failure(42)
                    select x * 2;
                Assert.That(res, Is.EqualTo(Result.Failure(42).Cast<int>()));
            }

            [Test]
            public void NestedFrom_Success()
            {
                var res =
                    from x in Result.Success(10)
                    from y in Result.Success(20)
                    from z in Result.Success(30)
                    select Create.Tuple(x, y, z);
                Assert.That(res, Is.EqualTo(Result.Success(Create.Tuple(10, 20, 30))));
            }

            [Test]
            public void NestedFrom_Failure()
            {
                var res =
                    from x in Result.Success(10).CastFailure<int>()
                    from y in Result.Success(20).CastFailure<int>()
                    from int z in Result.Failure(30)
                    select Create.Tuple(x, y, z);
                Assert.That(res, Is.EqualTo(Result.Failure(30).Cast<Tuple<int, int, int>>()));
            }
        }
    }
}
