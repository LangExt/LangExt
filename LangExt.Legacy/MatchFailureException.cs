using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LangExt.Legacy
{
    /// <summary>
    /// TypeMatch / CastMatchに失敗した場合に投げられる例外です。
    /// </summary>
    public sealed class MatchFailureException : Exception
    {
        /// <summary>
        /// 例外オブジェクトを構築します。
        /// </summary>
        public MatchFailureException() { }

        /// <summary>
        /// メッセージを指定して例外オブジェクトを構築します。
        /// </summary>
        /// <param name="msg">例外の原因などを含んだメッセージ</param>
        public MatchFailureException(string msg) : base(msg) { }

        /// <summary>
        /// メッセージと内部例外を指定して例外オブジェクトを構築します。
        /// </summary>
        /// <param name="msg">例外の原因などを含んだメッセージ</param>
        /// <param name="inner">内部例外</param>
        public MatchFailureException(string msg, Exception inner) : base(msg, inner) { }
    }
}
