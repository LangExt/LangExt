using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LangExt
{
    public static class Apply
    {
        public class ApplicativeOption<TArg1>
        {
            Option<TArg1> m1;

            internal ApplicativeOption(Option<TArg1> m1) 
            {
                this.m1 = m1;
            }

            public Option<TResult> By<TResult>(Func<TArg1, TResult> f)
            {
                return from arg1 in m1
                       select f(arg1);
            }
        }

        public class ApplicativeOption<TArg1, TArg2>
        {
            Option<TArg1> m1;
            Option<TArg2> m2;

            internal ApplicativeOption(Option<TArg1> m1, Option<TArg2> m2)
            {
                this.m1 = m1;
                this.m2 = m2;
            }

            public Option<TResult> By<TResult>(Func<TArg1, TArg2, TResult> f)
            {
                return from arg1 in m1
                       from arg2 in m2
                       select f(arg1, arg2);
            }
        }

        public static ApplicativeOption<TArg1> To<TArg1>(Option<TArg1> m1)
        {
            return new ApplicativeOption<TArg1>(m1);
        }

        public static ApplicativeOption<TArg1, TArg2> To<TArg1, TArg2>(Option<TArg1> m1, Option<TArg2> m2)
        {
            return new ApplicativeOption<TArg1, TArg2>(m1, m2);
        }
    }
}
