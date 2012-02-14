using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LangExt.Test
{
    [TestFixture]
    class ObjectUtilTest
    {
        [Test]
        public void 適切な型に変換できる()
        {
            object obj = "hoge";
            var result = obj.TypeMatch(
                (string s) => s
            );
            Assert.That(result, Is.EqualTo("hoge"));
        }

        [Test]
        public void 不適切な型は無視される()
        {
            object obj = "hoge";
            var result = obj.TypeMatch(
                (int _) => { throw new Exception(); },
                (string s) => s
            );
            Assert.That(result, Is.EqualTo("hoge"));
        }

        [Test, ExpectedException(typeof(Exception))]
        public void 適切な型がない場合otherwiseをとらないTypeMatchでは例外が投げられる()
        {
            object obj = "hoge";
            var __ = obj.TypeMatch(
                (int _) => ""
            );
            Assert.Fail();
        }

        [Test]
        public void 適切な型がない場合otherwiseをとるTypeMatchではotherwiseが実行される()
        {
            object obj = "hoge";
            var result = obj.TypeMatch(
                (int _) => "",
                () => "otherwise"
            );
            Assert.That(result, Is.EqualTo("otherwise"));
        }
    }
}
