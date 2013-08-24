
using System;
using System.Collections.Generic;


namespace LangExt
{
    public static class Apply
    {
        #region for the Option
        public class ApplicativeOption<TArg1>
        {
			Option<TArg1> m1;

            internal ApplicativeOption(Option<TArg1> m1)
            {
				this.m1 = m1;
            }

            public Option<TResult> By<TResult>(Func<TArg1, TResult> f)
            {
                return 
					from arg1 in m1
                    select f(arg1);
            }
        }

        public static ApplicativeOption<TArg1> To<TArg1>(Option<TArg1> m1)
        {
            return new ApplicativeOption<TArg1>(m1);
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
                return 
					from arg1 in m1
					from arg2 in m2
                    select f(arg1, arg2);
            }
        }

        public static ApplicativeOption<TArg1, TArg2> To<TArg1, TArg2>(Option<TArg1> m1, Option<TArg2> m2)
        {
            return new ApplicativeOption<TArg1, TArg2>(m1, m2);
        }

        public class ApplicativeOption<TArg1, TArg2, TArg3>
        {
			Option<TArg1> m1;
			Option<TArg2> m2;
			Option<TArg3> m3;

            internal ApplicativeOption(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3)
            {
				this.m1 = m1;
				this.m2 = m2;
				this.m3 = m3;
            }

            public Option<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TResult> f)
            {
                return 
					from arg1 in m1
					from arg2 in m2
					from arg3 in m3
                    select f(arg1, arg2, arg3);
            }
        }

        public static ApplicativeOption<TArg1, TArg2, TArg3> To<TArg1, TArg2, TArg3>(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3)
        {
            return new ApplicativeOption<TArg1, TArg2, TArg3>(m1, m2, m3);
        }

        public class ApplicativeOption<TArg1, TArg2, TArg3, TArg4>
        {
			Option<TArg1> m1;
			Option<TArg2> m2;
			Option<TArg3> m3;
			Option<TArg4> m4;

            internal ApplicativeOption(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4)
            {
				this.m1 = m1;
				this.m2 = m2;
				this.m3 = m3;
				this.m4 = m4;
            }

            public Option<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TResult> f)
            {
                return 
					from arg1 in m1
					from arg2 in m2
					from arg3 in m3
					from arg4 in m4
                    select f(arg1, arg2, arg3, arg4);
            }
        }

        public static ApplicativeOption<TArg1, TArg2, TArg3, TArg4> To<TArg1, TArg2, TArg3, TArg4>(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4)
        {
            return new ApplicativeOption<TArg1, TArg2, TArg3, TArg4>(m1, m2, m3, m4);
        }

        public class ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5>
        {
			Option<TArg1> m1;
			Option<TArg2> m2;
			Option<TArg3> m3;
			Option<TArg4> m4;
			Option<TArg5> m5;

            internal ApplicativeOption(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5)
            {
				this.m1 = m1;
				this.m2 = m2;
				this.m3 = m3;
				this.m4 = m4;
				this.m5 = m5;
            }

            public Option<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> f)
            {
                return 
					from arg1 in m1
					from arg2 in m2
					from arg3 in m3
					from arg4 in m4
					from arg5 in m5
                    select f(arg1, arg2, arg3, arg4, arg5);
            }
        }

        public static ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5> To<TArg1, TArg2, TArg3, TArg4, TArg5>(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5)
        {
            return new ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5>(m1, m2, m3, m4, m5);
        }

        public class ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>
        {
			Option<TArg1> m1;
			Option<TArg2> m2;
			Option<TArg3> m3;
			Option<TArg4> m4;
			Option<TArg5> m5;
			Option<TArg6> m6;

            internal ApplicativeOption(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6)
            {
				this.m1 = m1;
				this.m2 = m2;
				this.m3 = m3;
				this.m4 = m4;
				this.m5 = m5;
				this.m6 = m6;
            }

            public Option<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> f)
            {
                return 
					from arg1 in m1
					from arg2 in m2
					from arg3 in m3
					from arg4 in m4
					from arg5 in m5
					from arg6 in m6
                    select f(arg1, arg2, arg3, arg4, arg5, arg6);
            }
        }

        public static ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6)
        {
            return new ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(m1, m2, m3, m4, m5, m6);
        }

        public class ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>
        {
			Option<TArg1> m1;
			Option<TArg2> m2;
			Option<TArg3> m3;
			Option<TArg4> m4;
			Option<TArg5> m5;
			Option<TArg6> m6;
			Option<TArg7> m7;

            internal ApplicativeOption(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7)
            {
				this.m1 = m1;
				this.m2 = m2;
				this.m3 = m3;
				this.m4 = m4;
				this.m5 = m5;
				this.m6 = m6;
				this.m7 = m7;
            }

            public Option<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> f)
            {
                return 
					from arg1 in m1
					from arg2 in m2
					from arg3 in m3
					from arg4 in m4
					from arg5 in m5
					from arg6 in m6
					from arg7 in m7
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            }
        }

        public static ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7)
        {
            return new ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(m1, m2, m3, m4, m5, m6, m7);
        }

        public class ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>
        {
			Option<TArg1> m1;
			Option<TArg2> m2;
			Option<TArg3> m3;
			Option<TArg4> m4;
			Option<TArg5> m5;
			Option<TArg6> m6;
			Option<TArg7> m7;
			Option<TArg8> m8;

            internal ApplicativeOption(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8)
            {
				this.m1 = m1;
				this.m2 = m2;
				this.m3 = m3;
				this.m4 = m4;
				this.m5 = m5;
				this.m6 = m6;
				this.m7 = m7;
				this.m8 = m8;
            }

            public Option<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> f)
            {
                return 
					from arg1 in m1
					from arg2 in m2
					from arg3 in m3
					from arg4 in m4
					from arg5 in m5
					from arg6 in m6
					from arg7 in m7
					from arg8 in m8
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
            }
        }

        public static ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8)
        {
            return new ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(m1, m2, m3, m4, m5, m6, m7, m8);
        }

        public class ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>
        {
			Option<TArg1> m1;
			Option<TArg2> m2;
			Option<TArg3> m3;
			Option<TArg4> m4;
			Option<TArg5> m5;
			Option<TArg6> m6;
			Option<TArg7> m7;
			Option<TArg8> m8;
			Option<TArg9> m9;

            internal ApplicativeOption(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8, Option<TArg9> m9)
            {
				this.m1 = m1;
				this.m2 = m2;
				this.m3 = m3;
				this.m4 = m4;
				this.m5 = m5;
				this.m6 = m6;
				this.m7 = m7;
				this.m8 = m8;
				this.m9 = m9;
            }

            public Option<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> f)
            {
                return 
					from arg1 in m1
					from arg2 in m2
					from arg3 in m3
					from arg4 in m4
					from arg5 in m5
					from arg6 in m6
					from arg7 in m7
					from arg8 in m8
					from arg9 in m9
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
            }
        }

        public static ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8, Option<TArg9> m9)
        {
            return new ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(m1, m2, m3, m4, m5, m6, m7, m8, m9);
        }

        public class ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>
        {
			Option<TArg1> m1;
			Option<TArg2> m2;
			Option<TArg3> m3;
			Option<TArg4> m4;
			Option<TArg5> m5;
			Option<TArg6> m6;
			Option<TArg7> m7;
			Option<TArg8> m8;
			Option<TArg9> m9;
			Option<TArg10> m10;

            internal ApplicativeOption(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8, Option<TArg9> m9, Option<TArg10> m10)
            {
				this.m1 = m1;
				this.m2 = m2;
				this.m3 = m3;
				this.m4 = m4;
				this.m5 = m5;
				this.m6 = m6;
				this.m7 = m7;
				this.m8 = m8;
				this.m9 = m9;
				this.m10 = m10;
            }

            public Option<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> f)
            {
                return 
					from arg1 in m1
					from arg2 in m2
					from arg3 in m3
					from arg4 in m4
					from arg5 in m5
					from arg6 in m6
					from arg7 in m7
					from arg8 in m8
					from arg9 in m9
					from arg10 in m10
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
            }
        }

        public static ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8, Option<TArg9> m9, Option<TArg10> m10)
        {
            return new ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10);
        }

        public class ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>
        {
			Option<TArg1> m1;
			Option<TArg2> m2;
			Option<TArg3> m3;
			Option<TArg4> m4;
			Option<TArg5> m5;
			Option<TArg6> m6;
			Option<TArg7> m7;
			Option<TArg8> m8;
			Option<TArg9> m9;
			Option<TArg10> m10;
			Option<TArg11> m11;

            internal ApplicativeOption(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8, Option<TArg9> m9, Option<TArg10> m10, Option<TArg11> m11)
            {
				this.m1 = m1;
				this.m2 = m2;
				this.m3 = m3;
				this.m4 = m4;
				this.m5 = m5;
				this.m6 = m6;
				this.m7 = m7;
				this.m8 = m8;
				this.m9 = m9;
				this.m10 = m10;
				this.m11 = m11;
            }

            public Option<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> f)
            {
                return 
					from arg1 in m1
					from arg2 in m2
					from arg3 in m3
					from arg4 in m4
					from arg5 in m5
					from arg6 in m6
					from arg7 in m7
					from arg8 in m8
					from arg9 in m9
					from arg10 in m10
					from arg11 in m11
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
            }
        }

        public static ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8, Option<TArg9> m9, Option<TArg10> m10, Option<TArg11> m11)
        {
            return new ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11);
        }

        public class ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>
        {
			Option<TArg1> m1;
			Option<TArg2> m2;
			Option<TArg3> m3;
			Option<TArg4> m4;
			Option<TArg5> m5;
			Option<TArg6> m6;
			Option<TArg7> m7;
			Option<TArg8> m8;
			Option<TArg9> m9;
			Option<TArg10> m10;
			Option<TArg11> m11;
			Option<TArg12> m12;

            internal ApplicativeOption(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8, Option<TArg9> m9, Option<TArg10> m10, Option<TArg11> m11, Option<TArg12> m12)
            {
				this.m1 = m1;
				this.m2 = m2;
				this.m3 = m3;
				this.m4 = m4;
				this.m5 = m5;
				this.m6 = m6;
				this.m7 = m7;
				this.m8 = m8;
				this.m9 = m9;
				this.m10 = m10;
				this.m11 = m11;
				this.m12 = m12;
            }

            public Option<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> f)
            {
                return 
					from arg1 in m1
					from arg2 in m2
					from arg3 in m3
					from arg4 in m4
					from arg5 in m5
					from arg6 in m6
					from arg7 in m7
					from arg8 in m8
					from arg9 in m9
					from arg10 in m10
					from arg11 in m11
					from arg12 in m12
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
            }
        }

        public static ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8, Option<TArg9> m9, Option<TArg10> m10, Option<TArg11> m11, Option<TArg12> m12)
        {
            return new ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12);
        }

        public class ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>
        {
			Option<TArg1> m1;
			Option<TArg2> m2;
			Option<TArg3> m3;
			Option<TArg4> m4;
			Option<TArg5> m5;
			Option<TArg6> m6;
			Option<TArg7> m7;
			Option<TArg8> m8;
			Option<TArg9> m9;
			Option<TArg10> m10;
			Option<TArg11> m11;
			Option<TArg12> m12;
			Option<TArg13> m13;

            internal ApplicativeOption(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8, Option<TArg9> m9, Option<TArg10> m10, Option<TArg11> m11, Option<TArg12> m12, Option<TArg13> m13)
            {
				this.m1 = m1;
				this.m2 = m2;
				this.m3 = m3;
				this.m4 = m4;
				this.m5 = m5;
				this.m6 = m6;
				this.m7 = m7;
				this.m8 = m8;
				this.m9 = m9;
				this.m10 = m10;
				this.m11 = m11;
				this.m12 = m12;
				this.m13 = m13;
            }

            public Option<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> f)
            {
                return 
					from arg1 in m1
					from arg2 in m2
					from arg3 in m3
					from arg4 in m4
					from arg5 in m5
					from arg6 in m6
					from arg7 in m7
					from arg8 in m8
					from arg9 in m9
					from arg10 in m10
					from arg11 in m11
					from arg12 in m12
					from arg13 in m13
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
            }
        }

        public static ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8, Option<TArg9> m9, Option<TArg10> m10, Option<TArg11> m11, Option<TArg12> m12, Option<TArg13> m13)
        {
            return new ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13);
        }

        public class ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>
        {
			Option<TArg1> m1;
			Option<TArg2> m2;
			Option<TArg3> m3;
			Option<TArg4> m4;
			Option<TArg5> m5;
			Option<TArg6> m6;
			Option<TArg7> m7;
			Option<TArg8> m8;
			Option<TArg9> m9;
			Option<TArg10> m10;
			Option<TArg11> m11;
			Option<TArg12> m12;
			Option<TArg13> m13;
			Option<TArg14> m14;

            internal ApplicativeOption(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8, Option<TArg9> m9, Option<TArg10> m10, Option<TArg11> m11, Option<TArg12> m12, Option<TArg13> m13, Option<TArg14> m14)
            {
				this.m1 = m1;
				this.m2 = m2;
				this.m3 = m3;
				this.m4 = m4;
				this.m5 = m5;
				this.m6 = m6;
				this.m7 = m7;
				this.m8 = m8;
				this.m9 = m9;
				this.m10 = m10;
				this.m11 = m11;
				this.m12 = m12;
				this.m13 = m13;
				this.m14 = m14;
            }

            public Option<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> f)
            {
                return 
					from arg1 in m1
					from arg2 in m2
					from arg3 in m3
					from arg4 in m4
					from arg5 in m5
					from arg6 in m6
					from arg7 in m7
					from arg8 in m8
					from arg9 in m9
					from arg10 in m10
					from arg11 in m11
					from arg12 in m12
					from arg13 in m13
					from arg14 in m14
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
            }
        }

        public static ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8, Option<TArg9> m9, Option<TArg10> m10, Option<TArg11> m11, Option<TArg12> m12, Option<TArg13> m13, Option<TArg14> m14)
        {
            return new ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14);
        }

        public class ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>
        {
			Option<TArg1> m1;
			Option<TArg2> m2;
			Option<TArg3> m3;
			Option<TArg4> m4;
			Option<TArg5> m5;
			Option<TArg6> m6;
			Option<TArg7> m7;
			Option<TArg8> m8;
			Option<TArg9> m9;
			Option<TArg10> m10;
			Option<TArg11> m11;
			Option<TArg12> m12;
			Option<TArg13> m13;
			Option<TArg14> m14;
			Option<TArg15> m15;

            internal ApplicativeOption(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8, Option<TArg9> m9, Option<TArg10> m10, Option<TArg11> m11, Option<TArg12> m12, Option<TArg13> m13, Option<TArg14> m14, Option<TArg15> m15)
            {
				this.m1 = m1;
				this.m2 = m2;
				this.m3 = m3;
				this.m4 = m4;
				this.m5 = m5;
				this.m6 = m6;
				this.m7 = m7;
				this.m8 = m8;
				this.m9 = m9;
				this.m10 = m10;
				this.m11 = m11;
				this.m12 = m12;
				this.m13 = m13;
				this.m14 = m14;
				this.m15 = m15;
            }

            public Option<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> f)
            {
                return 
					from arg1 in m1
					from arg2 in m2
					from arg3 in m3
					from arg4 in m4
					from arg5 in m5
					from arg6 in m6
					from arg7 in m7
					from arg8 in m8
					from arg9 in m9
					from arg10 in m10
					from arg11 in m11
					from arg12 in m12
					from arg13 in m13
					from arg14 in m14
					from arg15 in m15
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
            }
        }

        public static ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8, Option<TArg9> m9, Option<TArg10> m10, Option<TArg11> m11, Option<TArg12> m12, Option<TArg13> m13, Option<TArg14> m14, Option<TArg15> m15)
        {
            return new ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15);
        }

        public class ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>
        {
			Option<TArg1> m1;
			Option<TArg2> m2;
			Option<TArg3> m3;
			Option<TArg4> m4;
			Option<TArg5> m5;
			Option<TArg6> m6;
			Option<TArg7> m7;
			Option<TArg8> m8;
			Option<TArg9> m9;
			Option<TArg10> m10;
			Option<TArg11> m11;
			Option<TArg12> m12;
			Option<TArg13> m13;
			Option<TArg14> m14;
			Option<TArg15> m15;
			Option<TArg16> m16;

            internal ApplicativeOption(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8, Option<TArg9> m9, Option<TArg10> m10, Option<TArg11> m11, Option<TArg12> m12, Option<TArg13> m13, Option<TArg14> m14, Option<TArg15> m15, Option<TArg16> m16)
            {
				this.m1 = m1;
				this.m2 = m2;
				this.m3 = m3;
				this.m4 = m4;
				this.m5 = m5;
				this.m6 = m6;
				this.m7 = m7;
				this.m8 = m8;
				this.m9 = m9;
				this.m10 = m10;
				this.m11 = m11;
				this.m12 = m12;
				this.m13 = m13;
				this.m14 = m14;
				this.m15 = m15;
				this.m16 = m16;
            }

            public Option<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> f)
            {
                return 
					from arg1 in m1
					from arg2 in m2
					from arg3 in m3
					from arg4 in m4
					from arg5 in m5
					from arg6 in m6
					from arg7 in m7
					from arg8 in m8
					from arg9 in m9
					from arg10 in m10
					from arg11 in m11
					from arg12 in m12
					from arg13 in m13
					from arg14 in m14
					from arg15 in m15
					from arg16 in m16
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
            }
        }

        public static ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8, Option<TArg9> m9, Option<TArg10> m10, Option<TArg11> m11, Option<TArg12> m12, Option<TArg13> m13, Option<TArg14> m14, Option<TArg15> m15, Option<TArg16> m16)
        {
            return new ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15, m16);
        }

        #endregion

        #region for the ISeq
        public class ApplicativeISeq<TArg1>
        {
			ISeq<TArg1> m1;

            internal ApplicativeISeq(ISeq<TArg1> m1)
            {
				this.m1 = m1;
            }

            public ISeq<TResult> By<TResult>(Func<TArg1, TResult> f)
            {
                return 
					from arg1 in m1
                    select f(arg1);
            }
        }

        public static ApplicativeISeq<TArg1> To<TArg1>(ISeq<TArg1> m1)
        {
            return new ApplicativeISeq<TArg1>(m1);
        }

        public class ApplicativeISeq<TArg1, TArg2>
        {
			ISeq<TArg1> m1;
			ISeq<TArg2> m2;

            internal ApplicativeISeq(ISeq<TArg1> m1, ISeq<TArg2> m2)
            {
				this.m1 = m1;
				this.m2 = m2;
            }

            public ISeq<TResult> By<TResult>(Func<TArg1, TArg2, TResult> f)
            {
                return 
					from arg1 in m1
					from arg2 in m2
                    select f(arg1, arg2);
            }
        }

        public static ApplicativeISeq<TArg1, TArg2> To<TArg1, TArg2>(ISeq<TArg1> m1, ISeq<TArg2> m2)
        {
            return new ApplicativeISeq<TArg1, TArg2>(m1, m2);
        }

        public class ApplicativeISeq<TArg1, TArg2, TArg3>
        {
			ISeq<TArg1> m1;
			ISeq<TArg2> m2;
			ISeq<TArg3> m3;

            internal ApplicativeISeq(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3)
            {
				this.m1 = m1;
				this.m2 = m2;
				this.m3 = m3;
            }

            public ISeq<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TResult> f)
            {
                return 
					from arg1 in m1
					from arg2 in m2
					from arg3 in m3
                    select f(arg1, arg2, arg3);
            }
        }

        public static ApplicativeISeq<TArg1, TArg2, TArg3> To<TArg1, TArg2, TArg3>(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3)
        {
            return new ApplicativeISeq<TArg1, TArg2, TArg3>(m1, m2, m3);
        }

        public class ApplicativeISeq<TArg1, TArg2, TArg3, TArg4>
        {
			ISeq<TArg1> m1;
			ISeq<TArg2> m2;
			ISeq<TArg3> m3;
			ISeq<TArg4> m4;

            internal ApplicativeISeq(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4)
            {
				this.m1 = m1;
				this.m2 = m2;
				this.m3 = m3;
				this.m4 = m4;
            }

            public ISeq<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TResult> f)
            {
                return 
					from arg1 in m1
					from arg2 in m2
					from arg3 in m3
					from arg4 in m4
                    select f(arg1, arg2, arg3, arg4);
            }
        }

        public static ApplicativeISeq<TArg1, TArg2, TArg3, TArg4> To<TArg1, TArg2, TArg3, TArg4>(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4)
        {
            return new ApplicativeISeq<TArg1, TArg2, TArg3, TArg4>(m1, m2, m3, m4);
        }

        public class ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5>
        {
			ISeq<TArg1> m1;
			ISeq<TArg2> m2;
			ISeq<TArg3> m3;
			ISeq<TArg4> m4;
			ISeq<TArg5> m5;

            internal ApplicativeISeq(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5)
            {
				this.m1 = m1;
				this.m2 = m2;
				this.m3 = m3;
				this.m4 = m4;
				this.m5 = m5;
            }

            public ISeq<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> f)
            {
                return 
					from arg1 in m1
					from arg2 in m2
					from arg3 in m3
					from arg4 in m4
					from arg5 in m5
                    select f(arg1, arg2, arg3, arg4, arg5);
            }
        }

        public static ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5> To<TArg1, TArg2, TArg3, TArg4, TArg5>(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5)
        {
            return new ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5>(m1, m2, m3, m4, m5);
        }

        public class ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>
        {
			ISeq<TArg1> m1;
			ISeq<TArg2> m2;
			ISeq<TArg3> m3;
			ISeq<TArg4> m4;
			ISeq<TArg5> m5;
			ISeq<TArg6> m6;

            internal ApplicativeISeq(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6)
            {
				this.m1 = m1;
				this.m2 = m2;
				this.m3 = m3;
				this.m4 = m4;
				this.m5 = m5;
				this.m6 = m6;
            }

            public ISeq<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> f)
            {
                return 
					from arg1 in m1
					from arg2 in m2
					from arg3 in m3
					from arg4 in m4
					from arg5 in m5
					from arg6 in m6
                    select f(arg1, arg2, arg3, arg4, arg5, arg6);
            }
        }

        public static ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6)
        {
            return new ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(m1, m2, m3, m4, m5, m6);
        }

        public class ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>
        {
			ISeq<TArg1> m1;
			ISeq<TArg2> m2;
			ISeq<TArg3> m3;
			ISeq<TArg4> m4;
			ISeq<TArg5> m5;
			ISeq<TArg6> m6;
			ISeq<TArg7> m7;

            internal ApplicativeISeq(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7)
            {
				this.m1 = m1;
				this.m2 = m2;
				this.m3 = m3;
				this.m4 = m4;
				this.m5 = m5;
				this.m6 = m6;
				this.m7 = m7;
            }

            public ISeq<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> f)
            {
                return 
					from arg1 in m1
					from arg2 in m2
					from arg3 in m3
					from arg4 in m4
					from arg5 in m5
					from arg6 in m6
					from arg7 in m7
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            }
        }

        public static ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7)
        {
            return new ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(m1, m2, m3, m4, m5, m6, m7);
        }

        public class ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>
        {
			ISeq<TArg1> m1;
			ISeq<TArg2> m2;
			ISeq<TArg3> m3;
			ISeq<TArg4> m4;
			ISeq<TArg5> m5;
			ISeq<TArg6> m6;
			ISeq<TArg7> m7;
			ISeq<TArg8> m8;

            internal ApplicativeISeq(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8)
            {
				this.m1 = m1;
				this.m2 = m2;
				this.m3 = m3;
				this.m4 = m4;
				this.m5 = m5;
				this.m6 = m6;
				this.m7 = m7;
				this.m8 = m8;
            }

            public ISeq<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> f)
            {
                return 
					from arg1 in m1
					from arg2 in m2
					from arg3 in m3
					from arg4 in m4
					from arg5 in m5
					from arg6 in m6
					from arg7 in m7
					from arg8 in m8
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
            }
        }

        public static ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8)
        {
            return new ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(m1, m2, m3, m4, m5, m6, m7, m8);
        }

        public class ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>
        {
			ISeq<TArg1> m1;
			ISeq<TArg2> m2;
			ISeq<TArg3> m3;
			ISeq<TArg4> m4;
			ISeq<TArg5> m5;
			ISeq<TArg6> m6;
			ISeq<TArg7> m7;
			ISeq<TArg8> m8;
			ISeq<TArg9> m9;

            internal ApplicativeISeq(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8, ISeq<TArg9> m9)
            {
				this.m1 = m1;
				this.m2 = m2;
				this.m3 = m3;
				this.m4 = m4;
				this.m5 = m5;
				this.m6 = m6;
				this.m7 = m7;
				this.m8 = m8;
				this.m9 = m9;
            }

            public ISeq<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> f)
            {
                return 
					from arg1 in m1
					from arg2 in m2
					from arg3 in m3
					from arg4 in m4
					from arg5 in m5
					from arg6 in m6
					from arg7 in m7
					from arg8 in m8
					from arg9 in m9
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
            }
        }

        public static ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8, ISeq<TArg9> m9)
        {
            return new ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(m1, m2, m3, m4, m5, m6, m7, m8, m9);
        }

        public class ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>
        {
			ISeq<TArg1> m1;
			ISeq<TArg2> m2;
			ISeq<TArg3> m3;
			ISeq<TArg4> m4;
			ISeq<TArg5> m5;
			ISeq<TArg6> m6;
			ISeq<TArg7> m7;
			ISeq<TArg8> m8;
			ISeq<TArg9> m9;
			ISeq<TArg10> m10;

            internal ApplicativeISeq(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8, ISeq<TArg9> m9, ISeq<TArg10> m10)
            {
				this.m1 = m1;
				this.m2 = m2;
				this.m3 = m3;
				this.m4 = m4;
				this.m5 = m5;
				this.m6 = m6;
				this.m7 = m7;
				this.m8 = m8;
				this.m9 = m9;
				this.m10 = m10;
            }

            public ISeq<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> f)
            {
                return 
					from arg1 in m1
					from arg2 in m2
					from arg3 in m3
					from arg4 in m4
					from arg5 in m5
					from arg6 in m6
					from arg7 in m7
					from arg8 in m8
					from arg9 in m9
					from arg10 in m10
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
            }
        }

        public static ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8, ISeq<TArg9> m9, ISeq<TArg10> m10)
        {
            return new ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10);
        }

        public class ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>
        {
			ISeq<TArg1> m1;
			ISeq<TArg2> m2;
			ISeq<TArg3> m3;
			ISeq<TArg4> m4;
			ISeq<TArg5> m5;
			ISeq<TArg6> m6;
			ISeq<TArg7> m7;
			ISeq<TArg8> m8;
			ISeq<TArg9> m9;
			ISeq<TArg10> m10;
			ISeq<TArg11> m11;

            internal ApplicativeISeq(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8, ISeq<TArg9> m9, ISeq<TArg10> m10, ISeq<TArg11> m11)
            {
				this.m1 = m1;
				this.m2 = m2;
				this.m3 = m3;
				this.m4 = m4;
				this.m5 = m5;
				this.m6 = m6;
				this.m7 = m7;
				this.m8 = m8;
				this.m9 = m9;
				this.m10 = m10;
				this.m11 = m11;
            }

            public ISeq<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> f)
            {
                return 
					from arg1 in m1
					from arg2 in m2
					from arg3 in m3
					from arg4 in m4
					from arg5 in m5
					from arg6 in m6
					from arg7 in m7
					from arg8 in m8
					from arg9 in m9
					from arg10 in m10
					from arg11 in m11
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
            }
        }

        public static ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8, ISeq<TArg9> m9, ISeq<TArg10> m10, ISeq<TArg11> m11)
        {
            return new ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11);
        }

        public class ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>
        {
			ISeq<TArg1> m1;
			ISeq<TArg2> m2;
			ISeq<TArg3> m3;
			ISeq<TArg4> m4;
			ISeq<TArg5> m5;
			ISeq<TArg6> m6;
			ISeq<TArg7> m7;
			ISeq<TArg8> m8;
			ISeq<TArg9> m9;
			ISeq<TArg10> m10;
			ISeq<TArg11> m11;
			ISeq<TArg12> m12;

            internal ApplicativeISeq(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8, ISeq<TArg9> m9, ISeq<TArg10> m10, ISeq<TArg11> m11, ISeq<TArg12> m12)
            {
				this.m1 = m1;
				this.m2 = m2;
				this.m3 = m3;
				this.m4 = m4;
				this.m5 = m5;
				this.m6 = m6;
				this.m7 = m7;
				this.m8 = m8;
				this.m9 = m9;
				this.m10 = m10;
				this.m11 = m11;
				this.m12 = m12;
            }

            public ISeq<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> f)
            {
                return 
					from arg1 in m1
					from arg2 in m2
					from arg3 in m3
					from arg4 in m4
					from arg5 in m5
					from arg6 in m6
					from arg7 in m7
					from arg8 in m8
					from arg9 in m9
					from arg10 in m10
					from arg11 in m11
					from arg12 in m12
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
            }
        }

        public static ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8, ISeq<TArg9> m9, ISeq<TArg10> m10, ISeq<TArg11> m11, ISeq<TArg12> m12)
        {
            return new ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12);
        }

        public class ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>
        {
			ISeq<TArg1> m1;
			ISeq<TArg2> m2;
			ISeq<TArg3> m3;
			ISeq<TArg4> m4;
			ISeq<TArg5> m5;
			ISeq<TArg6> m6;
			ISeq<TArg7> m7;
			ISeq<TArg8> m8;
			ISeq<TArg9> m9;
			ISeq<TArg10> m10;
			ISeq<TArg11> m11;
			ISeq<TArg12> m12;
			ISeq<TArg13> m13;

            internal ApplicativeISeq(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8, ISeq<TArg9> m9, ISeq<TArg10> m10, ISeq<TArg11> m11, ISeq<TArg12> m12, ISeq<TArg13> m13)
            {
				this.m1 = m1;
				this.m2 = m2;
				this.m3 = m3;
				this.m4 = m4;
				this.m5 = m5;
				this.m6 = m6;
				this.m7 = m7;
				this.m8 = m8;
				this.m9 = m9;
				this.m10 = m10;
				this.m11 = m11;
				this.m12 = m12;
				this.m13 = m13;
            }

            public ISeq<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> f)
            {
                return 
					from arg1 in m1
					from arg2 in m2
					from arg3 in m3
					from arg4 in m4
					from arg5 in m5
					from arg6 in m6
					from arg7 in m7
					from arg8 in m8
					from arg9 in m9
					from arg10 in m10
					from arg11 in m11
					from arg12 in m12
					from arg13 in m13
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
            }
        }

        public static ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8, ISeq<TArg9> m9, ISeq<TArg10> m10, ISeq<TArg11> m11, ISeq<TArg12> m12, ISeq<TArg13> m13)
        {
            return new ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13);
        }

        public class ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>
        {
			ISeq<TArg1> m1;
			ISeq<TArg2> m2;
			ISeq<TArg3> m3;
			ISeq<TArg4> m4;
			ISeq<TArg5> m5;
			ISeq<TArg6> m6;
			ISeq<TArg7> m7;
			ISeq<TArg8> m8;
			ISeq<TArg9> m9;
			ISeq<TArg10> m10;
			ISeq<TArg11> m11;
			ISeq<TArg12> m12;
			ISeq<TArg13> m13;
			ISeq<TArg14> m14;

            internal ApplicativeISeq(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8, ISeq<TArg9> m9, ISeq<TArg10> m10, ISeq<TArg11> m11, ISeq<TArg12> m12, ISeq<TArg13> m13, ISeq<TArg14> m14)
            {
				this.m1 = m1;
				this.m2 = m2;
				this.m3 = m3;
				this.m4 = m4;
				this.m5 = m5;
				this.m6 = m6;
				this.m7 = m7;
				this.m8 = m8;
				this.m9 = m9;
				this.m10 = m10;
				this.m11 = m11;
				this.m12 = m12;
				this.m13 = m13;
				this.m14 = m14;
            }

            public ISeq<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> f)
            {
                return 
					from arg1 in m1
					from arg2 in m2
					from arg3 in m3
					from arg4 in m4
					from arg5 in m5
					from arg6 in m6
					from arg7 in m7
					from arg8 in m8
					from arg9 in m9
					from arg10 in m10
					from arg11 in m11
					from arg12 in m12
					from arg13 in m13
					from arg14 in m14
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
            }
        }

        public static ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8, ISeq<TArg9> m9, ISeq<TArg10> m10, ISeq<TArg11> m11, ISeq<TArg12> m12, ISeq<TArg13> m13, ISeq<TArg14> m14)
        {
            return new ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14);
        }

        public class ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>
        {
			ISeq<TArg1> m1;
			ISeq<TArg2> m2;
			ISeq<TArg3> m3;
			ISeq<TArg4> m4;
			ISeq<TArg5> m5;
			ISeq<TArg6> m6;
			ISeq<TArg7> m7;
			ISeq<TArg8> m8;
			ISeq<TArg9> m9;
			ISeq<TArg10> m10;
			ISeq<TArg11> m11;
			ISeq<TArg12> m12;
			ISeq<TArg13> m13;
			ISeq<TArg14> m14;
			ISeq<TArg15> m15;

            internal ApplicativeISeq(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8, ISeq<TArg9> m9, ISeq<TArg10> m10, ISeq<TArg11> m11, ISeq<TArg12> m12, ISeq<TArg13> m13, ISeq<TArg14> m14, ISeq<TArg15> m15)
            {
				this.m1 = m1;
				this.m2 = m2;
				this.m3 = m3;
				this.m4 = m4;
				this.m5 = m5;
				this.m6 = m6;
				this.m7 = m7;
				this.m8 = m8;
				this.m9 = m9;
				this.m10 = m10;
				this.m11 = m11;
				this.m12 = m12;
				this.m13 = m13;
				this.m14 = m14;
				this.m15 = m15;
            }

            public ISeq<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> f)
            {
                return 
					from arg1 in m1
					from arg2 in m2
					from arg3 in m3
					from arg4 in m4
					from arg5 in m5
					from arg6 in m6
					from arg7 in m7
					from arg8 in m8
					from arg9 in m9
					from arg10 in m10
					from arg11 in m11
					from arg12 in m12
					from arg13 in m13
					from arg14 in m14
					from arg15 in m15
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
            }
        }

        public static ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8, ISeq<TArg9> m9, ISeq<TArg10> m10, ISeq<TArg11> m11, ISeq<TArg12> m12, ISeq<TArg13> m13, ISeq<TArg14> m14, ISeq<TArg15> m15)
        {
            return new ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15);
        }

        public class ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>
        {
			ISeq<TArg1> m1;
			ISeq<TArg2> m2;
			ISeq<TArg3> m3;
			ISeq<TArg4> m4;
			ISeq<TArg5> m5;
			ISeq<TArg6> m6;
			ISeq<TArg7> m7;
			ISeq<TArg8> m8;
			ISeq<TArg9> m9;
			ISeq<TArg10> m10;
			ISeq<TArg11> m11;
			ISeq<TArg12> m12;
			ISeq<TArg13> m13;
			ISeq<TArg14> m14;
			ISeq<TArg15> m15;
			ISeq<TArg16> m16;

            internal ApplicativeISeq(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8, ISeq<TArg9> m9, ISeq<TArg10> m10, ISeq<TArg11> m11, ISeq<TArg12> m12, ISeq<TArg13> m13, ISeq<TArg14> m14, ISeq<TArg15> m15, ISeq<TArg16> m16)
            {
				this.m1 = m1;
				this.m2 = m2;
				this.m3 = m3;
				this.m4 = m4;
				this.m5 = m5;
				this.m6 = m6;
				this.m7 = m7;
				this.m8 = m8;
				this.m9 = m9;
				this.m10 = m10;
				this.m11 = m11;
				this.m12 = m12;
				this.m13 = m13;
				this.m14 = m14;
				this.m15 = m15;
				this.m16 = m16;
            }

            public ISeq<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> f)
            {
                return 
					from arg1 in m1
					from arg2 in m2
					from arg3 in m3
					from arg4 in m4
					from arg5 in m5
					from arg6 in m6
					from arg7 in m7
					from arg8 in m8
					from arg9 in m9
					from arg10 in m10
					from arg11 in m11
					from arg12 in m12
					from arg13 in m13
					from arg14 in m14
					from arg15 in m15
					from arg16 in m16
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
            }
        }

        public static ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8, ISeq<TArg9> m9, ISeq<TArg10> m10, ISeq<TArg11> m11, ISeq<TArg12> m12, ISeq<TArg13> m13, ISeq<TArg14> m14, ISeq<TArg15> m15, ISeq<TArg16> m16)
        {
            return new ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15, m16);
        }

        #endregion

    }
}