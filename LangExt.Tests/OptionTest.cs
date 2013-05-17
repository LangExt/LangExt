using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace LangExt.Tests
{
    [TestFixture]
    public class OptionTest
    {
        static Option<T> SomeIf<T>(bool isSome, T someValue) { return isSome ? Option.Some(someValue) : Option.None; }

        public class Instantiation
        {
            void TestOptionIsSome<T>(Func<Option<T>> testTarget, bool expectedIsSome, Func<T> expectedSomeValue)
            {
                var opt = testTarget();
                Assert.That(opt.IsSome, Is.EqualTo(expectedIsSome));
                if (expectedIsSome)
                    Assert.That(opt.GetValue(), Is.EqualTo(expectedSomeValue()));
            }

            void TestSome<T>(Func<Option<T>> testTarget, T expectedSomeValue)
            {
                TestOptionIsSome(testTarget, true, () => expectedSomeValue);
            }

            void TestExn<T>(Func<Option<T>> testTarget, IResolveConstraint expr) { Assert.That(() => testTarget(), expr); }
            
            [TestCase("", true)]
            [TestCase("not empty", true)]
            [TestCase(null, false)]
            public void CreateStringOpt(string value, bool expectedIsSome)
            {
                TestOptionIsSome(() => Create.Option(value), expectedIsSome, () => value);
            }

            [TestCase("", true)]
            [TestCase("not empty", true)]
            [TestCase(null, false)]
            public void OptionCreateStr(string value, bool expectedIsSome)
            {
                TestOptionIsSome(() => Option.Create(value), expectedIsSome, () => value);
            }

            [TestCase(-1, true)]
            [TestCase(0, true)]
            [TestCase(1, true)]
            [TestCase(null, false)]
            public void CreateIntOpt(int? value, bool expectedIsSome)
            {
                TestOptionIsSome(() => Create.Option(value), expectedIsSome, () => value.Value);
            }

            [TestCase(-1, true)]
            [TestCase(0, true)]
            [TestCase(1, true)]
            [TestCase(null, false)]
            public void OptionCreateInt(int? value, bool expectedIsSome)
            {
                TestOptionIsSome(() => Option.Create(value), expectedIsSome, () => value.Value);
            }

            [TestCase(null)]
            [TestCase("")]
            [TestCase("not null")]
            public void Some(string value)
            {
                if (value != null)
                    TestOptionIsSome(() => Option.Some(value), true, () => value);
                else
                    TestExn(() => Option.Some(value), Throws.Exception.TypeOf<ArgumentNullException>().And.Message.Contains("value"));
            }

            [Test]
            public void None()
            {
                var opt = Option.None;
                Assert.That(opt.IsSome, Is.False);
                Assert.That(opt.IsNone, Is.True);
            }

            [Test]
            public void Empty()
            {
                var opt = Option.Empty<string>();
                Assert.That(opt.IsSome, Is.False);
                Assert.That(opt.IsNone, Is.True);
            }

            [TestCase("", null, true)]
            [TestCase("", "", false)]
            [TestCase("", "not empty", true)]
            [TestCase(null, null, false)]
            [TestCase(null, "", false, ExpectedException=typeof(ArgumentNullException))]
            [TestCase(null, "not empty", false, ExpectedException=typeof(ArgumentNullException))]
            public void NoneIf_T(string str, string x, bool expectedIsSome)
            {
                TestOptionIsSome(() => str.NoneIf(x), expectedIsSome, () => str);
            }

            public enum FuncResult { True, False, Exception }
            static Func<bool> FuncResultToFunc(FuncResult fr)
            {
                if (fr == FuncResult.Exception)
                    return () => { throw new Exception(); };
                return () => fr == FuncResult.True;
            }

            [TestCase("", FuncResult.True, false)]
            [TestCase("", FuncResult.False, true)]
            [TestCase("", FuncResult.Exception, null)]
            [TestCase(null, FuncResult.True, false)]
            [TestCase(null, FuncResult.False, true, ExpectedException=typeof(ArgumentNullException))]
            [TestCase(null, FuncResult.Exception, null)]
            public void NoneIf_Func(string str, FuncResult res, bool? expectedIsSome)
            {
                var predF = FuncResultToFunc(res);
                if (res != FuncResult.Exception)
                    TestOptionIsSome(() => str.NoneIf(predF), expectedIsSome.Value, () => str);
                else
                    TestExn(() => str.NoneIf(predF), Throws.Exception);
            }

            [TestCase(42, true, false)]
            [TestCase(0, true, false)]
            [TestCase(42, false, true)]
            [TestCase(0, false, true)]
            public void FromFunc(int value, bool thrownExn, bool expectedIsSome)
            {
                var f = new Func<int, string>(i => { if (thrownExn) throw new Exception(); else return i.ToString(); });
                Assert.That(Option.FromFunc(() => f(value)).IsSome, Is.EqualTo(expectedIsSome));
            }

            #region use static methods instead of these constructors.
            [Test]
            public void DefaultConstructor()
            {
                var opt = new Option<int>();
                Assert.That(opt, Is.EqualTo(Option<int>.None));
            }

            [TestCase(null)]
            [TestCase("")]
            [TestCase("not null")]
            public void Constructor(string value)
            {
                if (value != null)
                    TestSome(() => new Option<string>(value), value);
                else
                    TestExn(() => new Option<string>(value), Throws.Exception.TypeOf<ArgumentNullException>());
            }
            #endregion
        }

        public class Some
        {
            [TestCase("")]
            [TestCase("hoge")]
            public void IsSomeMethod_eq_IsSomeProperty(string value)
            {
                var sut = Option.Some(value);
                Assert.That(Option.IsSome(sut), Is.EqualTo(sut.IsSome));
            }

            [TestCase("")]
            [TestCase("hoge")]
            public void IsNoneMethod_eq_IsNoneProperty(string value)
            {
                var sut = Option.Some(value);
                Assert.That(Option.IsNone(sut), Is.EqualTo(sut.IsNone));
            }

            [TestCase("", null)]
            [TestCase("", "")]
            [TestCase("", "hoge")]
            [TestCase("hoge", null)]
            [TestCase("hoge", "")]
            [TestCase("hoge", "hoge")]
            [TestCase("piyo", "hoge")]
            public void GetOr(string value, string defaultValue)
            {
                Assert.That(Option.Some(value).GetOr(defaultValue), Is.EqualTo(value));
            }

            T ThrowIf<T>(bool exn, T value) { return value; }

            [TestCase("", null, true)]
            [TestCase("", null, false)]
            [TestCase("", "", false)]
            [TestCase("", "hoge", false)]
            [TestCase("hoge", null, false)]
            [TestCase("hoge", "", false)]
            [TestCase("hoge", "hoge", false)]
            [TestCase("piyo", "hoge", false)]
            public void GetOrElse(string value, string defaultValue, bool thrownExn)
            {
                Assert.That(Option.Some(value).GetOrElse(() => ThrowIf(thrownExn, defaultValue)), Is.EqualTo(value));
            }

            [TestCase(10, "hoge")]
            [TestCase(10, 20)]
            [TestCase("piyo", "hoge")]
            [TestCase("piyo", 20)]
            public void MatchFunc<T, U>(T value, U expected)
            {
                Assert.That(Option.Some(value).Match(
                    Some: v => {
                        Assert.That(v, Is.EqualTo(value)); // valueがvとして渡されてくる
                        return expected;
                    },
                    None: () => {
                        throw new Exception("oops!");
                    }), Is.EqualTo(expected)); // Matchの中で返した値が全体の戻り値になる
            }

            [TestCase(10)]
            [TestCase(20)]
            [TestCase("hoge")]
            public void MatchAction<T>(T value)
            {
                Option.Some(value).Match(
                    Some: v => { Assert.That(v, Is.EqualTo(value)); }, // valueがvとして渡されてくる
                    None: () => { throw new Exception("oops!"); });
            }

            [TestCase(10, true, "hoge")]
            [TestCase(10, true, 20)]
            [TestCase("piyo", true, "hoge")]
            [TestCase("piyo", true, 20)]
            [TestCase(10, false, "")]
            [TestCase("piyo", false, "")]
            public void Bind<T, U>(T value, bool expectedIsSome, U expected)
            {
                Assert.That(Option.Some(value).Bind(v =>
                {
                    Assert.That(v, Is.EqualTo(value)); // valueがvとして渡されてくる
                    return SomeIf(expectedIsSome, expected);
                }), Is.EqualTo(SomeIf(expectedIsSome, expected))); // Bindの中で返したものがそのまま返される
            }

            [Test]
            public void OperatorTrueFalse()
            {
                // 短絡演算子を提供するために、一応できるようにしているが、明示的にIsSome/IsNoneプロパティを使うべき
                if (Option.Some(42)) Assert.Pass();
                else Assert.Fail();
            }

            [TestCase("hoge")]
            [TestCase(10)]
            public void OrElse<T>(T value)
            {
                var sut = Option.Some(value);
                Assert.That(sut.OrElse(() => { throw new Exception(); }), Is.EqualTo(Option.Some(value)));
            }

            [TestCase("hoge", "piyo")]
            [TestCase("hoge", 10)]
            [TestCase(10, 20)]
            [TestCase(10, "hoge")]
            public void AndThen<T, U>(T value, U otherValue)
            {
                var sut = Option.Some(value);
                var some = Option.Some(otherValue);
                var none = Option.None;
                Assert.That(sut.AndThen(() => some), Is.EqualTo(some));
                Assert.That(sut.AndThen(() => none), Is.EqualTo(Option.None));
            }

            [TestCase("hoge")]
            [TestCase(10)]
            public void OperatorOrOr<T>(T value)
            {
                var sut = Option.Some(value);
                Assert.That(sut || new Func<Option<T>>(() => { throw new Exception(); })(), Is.EqualTo(Option.Some(value)));
            }

            [TestCase("hoge", true, "piyo")]
            [TestCase(10, true, 20)]
            [TestCase("hoge", false, "piyo")]
            [TestCase(10, false, 20)]
            public void OperatorAndAnd<T>(T value, bool otherIsSome, T otherValue)
            {
                var sut = Option.Some(value);
                var other = SomeIf(otherIsSome, otherValue);
                Assert.That(sut && SomeIf(otherIsSome, otherValue), Is.EqualTo(other));
            }

            [TestCase("hoge", "Some(hoge)")]
            [TestCase(42, "Some(42)")]
            public void ToString<T>(T value, string expected)
            {
                Assert.That(Option.Some(value).ToString(), Is.EqualTo(expected));
            }

            [TestCase("", 0, 42)]
            [TestCase("hoge", 0, 42)]
            [TestCase(0, "", "hoge")]
            public void Maybe<T, U>(T value, U defaultValue, U expected)
            {
                var sut = Option.Some(value);
                Assert.That(sut.Maybe(defaultValue, v =>
                {
                    Assert.That(v, Is.EqualTo(value));
                    return expected;
                }), Is.EqualTo(expected));
            }

            [TestCase("hoge", 0, 42)]
            [TestCase(42, "", "hoge")]
            public void Fold<T, U>(T value, U init, U expected)
            {
                var sut = Option.Some(value);
                Assert.That(sut.Fold(init, (acc, v) =>
                {
                    Assert.That(acc, Is.EqualTo(init));
                    Assert.That(v, Is.EqualTo(value));
                    return expected;
                }), Is.EqualTo(expected));
            }

            [TestCase("hoge", "piyo")]
            [TestCase("hoge", "hoge")]
            [TestCase(42, 10)]
            [TestCase(42, 42)]
            public void Filter<T>(T value, T filter)
            {
                var sut = Option.Some(value);
                Assert.That(sut.Filter(v =>
                {
                    Assert.That(v, Is.EqualTo(value));
                    return v.Equals(filter);
                }), Is.EqualTo(value.Equals(filter) ? Option.Some(value) : Option.None));
            }

            [TestCase("hoge", "piyo")]
            [TestCase("hoge", 42)]
            [TestCase(42, "hoge")]
            [TestCase(42, 10)]
            public void Map<T, U>(T value, U map)
            {
                var sut = Option.Some(value);
                Assert.That(sut.Map(v =>
                {
                    Assert.That(v, Is.EqualTo(value));
                    return map;
                }), Is.EqualTo(Option.Some(map)));
            }

            [TestCase(10)]
            [TestCase("hoge")]
            public void Iter<T>(T value)
            {
                var sut = Option.Some(value);
                sut.Iter(v => { Assert.That(v, Is.EqualTo(value)); });
            }

            [Test]
            public void IsEmpty()
            {
                Assert.That(Option.Some(42).IsEmpty(), Is.False);
            }

            [Test]
            public void IsNotEmpty()
            {
                Assert.That(Option.Some(42).IsNotEmpty(), Is.True);
            }

            [TestCase(10)]
            [TestCase(11)]
            [TestCase(42)]
            [TestCase(43)]
            public void Exists(int value)
            {
                var sut = Option.Some(value);
                Assert.That(sut.Exists(v =>
                {
                    Assert.That(v, Is.EqualTo(value));
                    return value % 2 == 0;
                }), Is.EqualTo(value % 2 == 0));
            }

            [TestCase(10)]
            [TestCase(11)]
            [TestCase(42)]
            [TestCase(43)]
            public void Forall(int value)
            {
                var sut = Option.Some(value);
                Assert.That(sut.Forall(v =>
                {
                    Assert.That(v, Is.EqualTo(value));
                    return value % 2 == 0;
                }), Is.EqualTo(value % 2 == 0));
            }

            [Test]
            public void Len()
            {
                Assert.That(Option.Some(10).Len(), Is.EqualTo(1));
            }

            [TestCase(true, 1)]
            [TestCase(false, 0)]
            public void Count(bool b, int expected)
            {
                Assert.That(Option.Some(10).Count(_ => b), Is.EqualTo(expected));
            }

            [Test]
            public void ToArray()
            {
                Assert.That(Option.Some(10).ToArray(), Is.EqualTo(new[] { 10 }));
            }

            [Test]
            public void ToSeq()
            {
                Assert.That(Option.Some(10).ToSeq(), Is.EqualTo(new[] { 10 }));
            }

            [Test]
            public void ToResult()
            {
                Assert.That(Option.Some(10).ToResult(), Is.EqualTo(Result.Success(10).CastFailure<Unit>()));
            }
        }

        public class None
        {
            [Test]
            public void IsSomeMethod_eq_IsSomeProperty()
            {
                var sut = Option.None;
                Assert.That(Option.IsSome(sut), Is.EqualTo(sut.IsSome));
            }

            [Test]
            public void IsNoneMethod_eq_IsNoneProperty()
            {
                var sut = Option.None;
                Assert.That(Option.IsNone(sut), Is.EqualTo(sut.IsNone));
            }

            [TestCase(null)]
            [TestCase("")]
            [TestCase("hoge")]
            public void GetOr(string defaultValue)
            {
                Assert.That(Option<string>.None.GetOr(defaultValue), Is.EqualTo(defaultValue));
            }

            T ThrowIf<T>(bool exn, T value) { if (exn) throw new Exception(); return value; }

            [TestCase("", null, true, ExpectedException=typeof(Exception))]
            [TestCase("", null, false)]
            [TestCase("", "", false)]
            [TestCase("", "piyo", false)]
            [TestCase("hoge", null, true, ExpectedException=typeof(Exception))]
            [TestCase("hoge", null, false)]
            [TestCase("hoge", "", false)]
            [TestCase("hoge", "piyo", false)]
            public void GetOrElse(string value, string defaultValue, bool thrownExn)
            {
                Assert.That(Option<string>.None.GetOrElse(() => ThrowIf(thrownExn, defaultValue)), Is.EqualTo(defaultValue));
            }

            [TestCase(10)]
            [TestCase("piyo")]
            public void MatchFunc<T>(T value)
            {
                Assert.That(Option.None.Match(
                    Some: v => {
                        throw new Exception("oops!");
                    },
                    None: () => value), Is.EqualTo(value)); // Matchの中で返した値が全体の戻り値になる
            }

            [Test]
            public void MatchAction()
            {
                Option.None.Match(
                    Some: v => { throw new Exception("oops!"); },
                    None: () => { Assert.Pass(); });
            }

            [Test]
            public void Bind()
            {
                Option.None.Bind<int>(v => { throw new Exception("oops!"); });
                Assert.Pass();
            }

            [Test]
            public void OperatorTrueFalse()
            {
                // 短絡演算子を提供するために、一応できるようにしているが、明示的にIsSome/IsNoneプロパティを使うべき
                if (Option.None) Assert.Fail();
                else Assert.Pass();
            }

            [TestCase("hoge")]
            [TestCase(10)]
            public void OrElse<T>(T value)
            {
                var sut = Option<T>.None;
                Assert.That(sut.OrElse(() => Option.Some(value)), Is.EqualTo(Option.Some(value)));
                Assert.That(sut.OrElse(() => Option<T>.None), Is.EqualTo(Option<T>.None));
            }

            [Test]
            public void AndThen()
            {
                var sut = Option<int>.None;
                Assert.That(sut.AndThen<int>(() => { throw new Exception("oops!"); }), Is.EqualTo(sut));
            }

            [TestCase("hoge")]
            [TestCase(10)]
            public void OperatorOrOr<T>(T value)
            {
                var sut = Option<T>.None;
                Assert.That(sut || new Func<Option<T>>(() => Option.Some(value))(), Is.EqualTo(Option.Some(value)));
            }

            [Test]
            public void OperatorAndAnd()
            {
                var sut = Option<int>.None;
                Assert.That(sut && new Func<Option<int>>(() => { throw new Exception(); })(), Is.EqualTo(sut));
            }

            [Test]
            public new void ToString()
            {
                Assert.That(Option<int>.None.ToString(), Is.EqualTo("None"));
            }

            [Test]
            public void Maybe()
            {
                Assert.That(Option.None.Maybe(42, v => { throw new Exception("oops!"); }), Is.EqualTo(42));
            }

            [Test]
            public void Fold()
            {
                Assert.That(Option.None.Fold(42, (v, _) => { throw new Exception("oops!"); }), Is.EqualTo(42));
            }

            [Test]
            public void Filter()
            {
                Assert.That(Option.None.Filter(_ => { throw new Exception("oops!"); }), Is.EqualTo(Option.None));
            }

            [Test]
            public void Map()
            {
                Assert.That(Option<int>.None.Map<int, int>(_ => { throw new Exception("oops!"); }), Is.EqualTo(Option<int>.None));
            }

            [Test]
            public void Iter()
            {
                Option.None.Iter(_ => { throw new Exception("oops!"); });
            }

            [Test]
            public void IsEmpty()
            {
                Assert.That(Option.None.IsEmpty(), Is.True);
            }

            [Test]
            public void IsNotEmpty()
            {
                Assert.That(Option.None.IsNotEmpty(), Is.False);
            }

            [TestCase(true)]
            [TestCase(false)]
            public void Exists(bool b)
            {
                Assert.That(Option.None.Exists(_ => b), Is.False);
            }

            [TestCase(true)]
            [TestCase(false)]
            public void Forall(bool b)
            {
                Assert.That(Option.None.Forall(_ => b), Is.True);
            }

            [Test]
            public void Len()
            {
                Assert.That(Option.None.Len(), Is.EqualTo(0));
            }

            [TestCase(true)]
            [TestCase(false)]
            public void Count(bool b)
            {
                Assert.That(Option.None.Count(_ => b), Is.EqualTo(0));
            }

            [Test]
            public void ToArray()
            {
                Assert.That(Option.None.ToArray(), Is.EqualTo(new Placeholder[0]));
            }

            [Test]
            public void ToSeq()
            {
                Assert.That(Option.None.ToSeq(), Is.EqualTo(new Placeholder[0]));
            }

            [Test]
            public void ToResult()
            {
                Assert.That(Option.None.ToResult(), Is.EqualTo(Result.Failure(Unit._)));
            }
        }

        // ==/!=のテストはF#側に定義
        public class Equality
        {
            [TestCase("hoge", true, "", false)]
            [TestCase("hoge", true, "hoge", true)]
            [TestCase("hoge", true, "piyo", false)]
            [TestCase("hoge", false, "piyo", false)]
            [TestCase(42, true, 0, false)]
            [TestCase(42, true, 42, true)]
            [TestCase(42, false, 42, false)]
            public void Equals_Some<T>(T value, bool otherIsSome, T other, bool expected)
            {
                Assert.That(Option.Some(value).Equals(SomeIf(otherIsSome, other)), Is.EqualTo(expected));
                Assert.That(Option.Some(value).Equals(value), Is.False);
            }

            [TestCase(true, "hoge", true)]
            [TestCase(false, "hoge", false)]
            [TestCase(true, 42, true)]
            [TestCase(false, 42, false)]
            public void Equals_None<T>(bool isNone, T other, bool expected)
            {
                Assert.That(Option.None.Equals(SomeIf(!isNone, other)), Is.False);
                Assert.That(Option<T>.None.Equals(SomeIf(!isNone, other)), Is.EqualTo(expected));
            }

            [Test]
            public void EqualsObj_Null()
            {
                object some = Option.Some("hoge");
                Assert.That(some.Equals(null), Is.False);

                object none = Option.None;
                Assert.That(none.Equals(null), Is.False);

                object typedNone = Option<string>.None;
                Assert.That(typedNone.Equals(null), Is.False);
            }

            [Test]
            public void EqualsObj_DifferentSome()
            {
                object someStr = Option.Some("hoge");
                object someInt = Option.Some(42);
                Assert.That(someStr.Equals(someInt), Is.False);
                Assert.That(someInt.Equals(someStr), Is.False);
            }

            [Test]
            public void EqualsObj_DifferentNone()
            {
                object obj = Option<int>.None;
                Assert.That(obj.Equals(Option<string>.None), Is.False);
            }

            [Test]
            public void EqualsObj_DifferentTypedNone()
            {
                // 異なる型のNoneは基本的には比較するとfalse
                Assert.That(Option<int>.None.Equals(Option<string>.None), Is.False);
                Assert.That(Option<string>.None.Equals(Option<int>.None), Is.False);

                // Option.NoneではOption<Placeholder>型のNoneが返るので、falseになる
                Assert.That(Option.None.Equals(Option<int>.None), Is.False);
                // 反射率を満たしてないように見えるけど、Option<T>のEqualsが呼び出されているだけ
                // そして、Option<Placeholder>はOption<T>に暗黙の型変換されるので、trueになる
                Assert.That(Option<int>.None.Equals(Option.None), Is.True);
                Assert.That(Option<int>.None.Equals((object)Option<Placeholder>.None), Is.False); // 明示的にobjectの方を呼び出してあげるとfalseになる
            }

            [Test]
            public void EqualsObj_List()
            {
                object obj = Option.Some("hoge");
                Assert.That(obj.Equals(new List<string> { "hoge" }), Is.False);
            }

            [Test]
            public void EqualsObj_Placeholder()
            {
                object noneInt = Option<int>.None;
                object nonePlaceholder = Option<Placeholder>.None;
                Assert.That(noneInt.Equals(nonePlaceholder), Is.False);
                Assert.That(nonePlaceholder.Equals(noneInt), Is.False);
            }
        }
    }
}
