using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LangExt.Legacy
{
    public sealed class MatchFailureException : Exception
    {
        public MatchFailureException() { }
        public MatchFailureException(string msg) : base(msg) { }
        public MatchFailureException(string msg, Exception inner) : base(msg, inner) { }
    }
}
