using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LangExt
{
    public static class Apply
    {
        public static class ApplicativeOption
        {
            internal static ApplicativeOption<TArg1> Create<TArg1>(Option<TArg1> m1)
            {
                return new ApplicativeOption<TArg1>(m1);
            }
        }

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

        public static ApplicativeOption<TArg1> To<TArg1>(Option<TArg1> m1)
        {
            return ApplicativeOption.Create(m1);
        }
    }
}
