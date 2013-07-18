using System;
using LangExt;
using NUnit.Framework;

namespace LangExt.Tests
{
    [TestFixture]
    public class CachedSeqTest
    {
        public class EmptyCachedSeq
        {
            [Test]
            public void Test()
            {
                // キャッシュしたシーケンスをそのまま使うパターン
                Assert.That(Seq.Empty<int>().Cache().Len(), Is.EqualTo(0));
                Assert.That(Seq.Empty<int>().Cache().Map<int, int>(_ => { throw new Exception("oops!"); }), Is.EqualTo(Seq.Empty<int>()));
                Assert.That(Seq.Empty<int>().Cache().IterF(_ => { throw new Exception("oops!"); }), Is.EqualTo(Unit._));
                // ToStringは走査しないので、空かどうかは回してみるまではわからない。
                // Seq.Emptyで得られる型を特別扱いという手もあるけど、統一性がなくなるのでしない。
                Assert.That(Seq.Empty<int>().Cache().ToString(), Is.EqualTo("cached seq [...]"));

                // キャッシュしたシーケンスを使い回すパターン
                var cached = Seq.Empty<int>().Cache();
                Assert.That(cached.Len(), Is.EqualTo(0));
                Assert.That(cached.Map<int, int>(_ => { throw new Exception("oops!"); }), Is.EqualTo(Seq.Empty<int>()));
                Assert.That(cached.IterF(_ => { throw new Exception("oops!"); }), Is.EqualTo(Unit._));
                // 最初のLenで、空であることが確定したシーケンスなので、「...」が消えている。
                Assert.That(cached.ToString(), Is.EqualTo("cached seq []"));
            }
        }

        public class Holder
        {
            public System.Collections.Generic.List<int> History { get; private set; }
            public ISeq<int> Body { get; private set; }

            public Holder(params int[] values)
            {
                History = new System.Collections.Generic.List<int>();
                Body = Seq.Init(values.Length, i => { History.Add(values[i]); return values[i]; }).Cache();
            }

            public static Holder Create(params int[] values) { return new Holder(values); }
        }

        public class InitialState
        {
            static Holder CreateSut()
            {
                var res = Holder.Create(1, 2, 3, 4, 5);
                Assert.That(res.History, Is.Empty);
                return res;
            }

            [Test]
            public void Len()
            {
                var sut = CreateSut();
                Assert.That(sut.Body.Len(), Is.EqualTo(5));
                Assert.That(sut.History.Count, Is.EqualTo(5));
            }

            [Test]
            public void Map()
            {
                var sut = CreateSut();
                Assert.That(sut.Body.Map(_ => _ + 1), Is.EqualTo(Create.Seq(2, 3, 4, 5, 6)));
                Assert.That(sut.History.Count, Is.EqualTo(5));
            }

            [Test]
            public new void ToString()
            {
                var sut = CreateSut();
                Assert.That(sut.Body.ToString(), Is.EqualTo("cached seq [...]"));
                // ToStringではイテレータを走査しない。
                Assert.That(sut.History, Is.Empty);
            }

            [Test]
            public void Append()
            {
                var sut = CreateSut();
                var _ = sut.Body.Append(Create.Seq(0));
                _.Take(2).Iter(__ => { });
                Assert.That(sut.History.Count, Is.EqualTo(2));
                _.Iter(__ => { });
                Assert.That(sut.History.Count, Is.EqualTo(5));
            }
        }

        public class IteratedSeq
        {
            static Holder CreateSut(params int[] values)
            {
                var res = Holder.Create(values);
                res.Body.Iter(_ => { });
                Assert.That(res.History.Count, Is.EqualTo(values.Length));
                return res;
            }

            [Test]
            public void Len()
            {
                var sut = CreateSut(1, 2, 3, 4, 5);
                Assert.That(sut.Body.Len(), Is.EqualTo(5));
                Assert.That(sut.History.Count, Is.EqualTo(5));
            }

            [Test]
            public void Map()
            {
                var sut = CreateSut(1, 2, 3, 4, 5);
                Assert.That(sut.Body.Map(_ => _ + 1), Is.EqualTo(Create.Seq(2, 3, 4, 5, 6)));
                Assert.That(sut.History.Count, Is.EqualTo(5));
            }

            [TestCase(new int[0], "cached seq []")]
            [TestCase(new[] { 1 }, "cached seq [1]")]
            [TestCase(new[] { 1, 2 }, "cached seq [1, 2]")]
            // Seqと異なり、すべての要素を保持しているため、いったん走査したら全部表示できる。
            [TestCase(new[] { 1, 2, 3, 4, 5, 6 }, "cached seq [1, 2, 3, 4, 5, 6]")]
            public void ToString(int[] values, string expected)
            {
                var sut = CreateSut(values);
                // 走査済みのイテレータが指していた値はキャッシュされているため、ToStringで表示できる。
                Assert.That(sut.Body.ToString(), Is.EqualTo(expected));
                Assert.That(sut.History.Count, Is.EqualTo(values.Length));
            }

            [Test]
            public void Append()
            {
                var sut = CreateSut(1, 2, 3, 4, 5);
                var _ = sut.Body.Append(Create.Seq(0));
                _.Take(2).Iter(__ => { });
                Assert.That(sut.History.Count, Is.EqualTo(5));
                _.Iter(__ => { });
                Assert.That(sut.History.Count, Is.EqualTo(5));
            }
        }

        public class HalfwayIteratedSeq
        {
            static Holder CreateSut()
            {
                var res = Holder.Create(1, 2, 3, 4, 5);
                res.Body.Take(2).Iter(_ => { });
                Assert.That(res.History.Count, Is.EqualTo(2));
                return res;
            }

            [Test]
            public void Len()
            {
                var sut = CreateSut();
                Assert.That(sut.Body.Len(), Is.EqualTo(5));
                Assert.That(sut.History.Count, Is.EqualTo(5));
            }

            [Test]
            public void Map()
            {
                var sut = CreateSut();
                Assert.That(sut.Body.Map(_ => _ + 1), Is.EqualTo(Create.Seq(2, 3, 4, 5, 6)));
                Assert.That(sut.History.Count, Is.EqualTo(5));
            }

            [Test]
            public new void ToString()
            {
                var sut = CreateSut();
                // 走査済みのイテレータが指していた値はキャッシュされているため、ToStringで表示できる。
                Assert.That(sut.Body.ToString(), Is.EqualTo("cached seq [1, 2, ...]"));
                // だけど、走査されてない部分はそのまま。
                Assert.That(sut.History.Count, Is.EqualTo(2));
            }

            [Test]
            public void Append()
            {
                var sut = CreateSut();
                var _ = sut.Body.Append(Create.Seq(0));
                _.Take(3).Iter(__ => { });
                Assert.That(sut.History.Count, Is.EqualTo(3));
                _.Iter(__ => { });
                Assert.That(sut.History.Count, Is.EqualTo(5));
            }
        }
    }
}
