
using System;

namespace LangExt.Legacy.TypeMatches
{
    public static class LegacyObject
    {
        public static TResult TypeMatch<T1, TResult>(this object self, Func<T1, TResult> ifT1, Func<object, TResult> Otherwise)
        {
            if (self is T1) return ifT1((T1)self);
            return Otherwise(self);
        }

        public static TResult TypeMatch<T1, TResult>(this object self, Func<T1, TResult> ifT1)
        {
            return TypeMatch(self, ifT1, _ => { throw new Exception(); });
        }
        public static TResult TypeMatch<T1, T2, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<object, TResult> Otherwise)
        {
            if (self is T1) return ifT1((T1)self);
            if (self is T2) return ifT2((T2)self);
            return Otherwise(self);
        }

        public static TResult TypeMatch<T1, T2, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2)
        {
            return TypeMatch(self, ifT1, ifT2, _ => { throw new Exception(); });
        }
        public static TResult TypeMatch<T1, T2, T3, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<object, TResult> Otherwise)
        {
            if (self is T1) return ifT1((T1)self);
            if (self is T2) return ifT2((T2)self);
            if (self is T3) return ifT3((T3)self);
            return Otherwise(self);
        }

        public static TResult TypeMatch<T1, T2, T3, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3)
        {
            return TypeMatch(self, ifT1, ifT2, ifT3, _ => { throw new Exception(); });
        }
        public static TResult TypeMatch<T1, T2, T3, T4, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<object, TResult> Otherwise)
        {
            if (self is T1) return ifT1((T1)self);
            if (self is T2) return ifT2((T2)self);
            if (self is T3) return ifT3((T3)self);
            if (self is T4) return ifT4((T4)self);
            return Otherwise(self);
        }

        public static TResult TypeMatch<T1, T2, T3, T4, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4)
        {
            return TypeMatch(self, ifT1, ifT2, ifT3, ifT4, _ => { throw new Exception(); });
        }
        public static TResult TypeMatch<T1, T2, T3, T4, T5, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<object, TResult> Otherwise)
        {
            if (self is T1) return ifT1((T1)self);
            if (self is T2) return ifT2((T2)self);
            if (self is T3) return ifT3((T3)self);
            if (self is T4) return ifT4((T4)self);
            if (self is T5) return ifT5((T5)self);
            return Otherwise(self);
        }

        public static TResult TypeMatch<T1, T2, T3, T4, T5, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5)
        {
            return TypeMatch(self, ifT1, ifT2, ifT3, ifT4, ifT5, _ => { throw new Exception(); });
        }
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<object, TResult> Otherwise)
        {
            if (self is T1) return ifT1((T1)self);
            if (self is T2) return ifT2((T2)self);
            if (self is T3) return ifT3((T3)self);
            if (self is T4) return ifT4((T4)self);
            if (self is T5) return ifT5((T5)self);
            if (self is T6) return ifT6((T6)self);
            return Otherwise(self);
        }

        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6)
        {
            return TypeMatch(self, ifT1, ifT2, ifT3, ifT4, ifT5, ifT6, _ => { throw new Exception(); });
        }
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<object, TResult> Otherwise)
        {
            if (self is T1) return ifT1((T1)self);
            if (self is T2) return ifT2((T2)self);
            if (self is T3) return ifT3((T3)self);
            if (self is T4) return ifT4((T4)self);
            if (self is T5) return ifT5((T5)self);
            if (self is T6) return ifT6((T6)self);
            if (self is T7) return ifT7((T7)self);
            return Otherwise(self);
        }

        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7)
        {
            return TypeMatch(self, ifT1, ifT2, ifT3, ifT4, ifT5, ifT6, ifT7, _ => { throw new Exception(); });
        }
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<object, TResult> Otherwise)
        {
            if (self is T1) return ifT1((T1)self);
            if (self is T2) return ifT2((T2)self);
            if (self is T3) return ifT3((T3)self);
            if (self is T4) return ifT4((T4)self);
            if (self is T5) return ifT5((T5)self);
            if (self is T6) return ifT6((T6)self);
            if (self is T7) return ifT7((T7)self);
            if (self is T8) return ifT8((T8)self);
            return Otherwise(self);
        }

        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8)
        {
            return TypeMatch(self, ifT1, ifT2, ifT3, ifT4, ifT5, ifT6, ifT7, ifT8, _ => { throw new Exception(); });
        }
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<object, TResult> Otherwise)
        {
            if (self is T1) return ifT1((T1)self);
            if (self is T2) return ifT2((T2)self);
            if (self is T3) return ifT3((T3)self);
            if (self is T4) return ifT4((T4)self);
            if (self is T5) return ifT5((T5)self);
            if (self is T6) return ifT6((T6)self);
            if (self is T7) return ifT7((T7)self);
            if (self is T8) return ifT8((T8)self);
            if (self is T9) return ifT9((T9)self);
            return Otherwise(self);
        }

        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9)
        {
            return TypeMatch(self, ifT1, ifT2, ifT3, ifT4, ifT5, ifT6, ifT7, ifT8, ifT9, _ => { throw new Exception(); });
        }
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<object, TResult> Otherwise)
        {
            if (self is T1) return ifT1((T1)self);
            if (self is T2) return ifT2((T2)self);
            if (self is T3) return ifT3((T3)self);
            if (self is T4) return ifT4((T4)self);
            if (self is T5) return ifT5((T5)self);
            if (self is T6) return ifT6((T6)self);
            if (self is T7) return ifT7((T7)self);
            if (self is T8) return ifT8((T8)self);
            if (self is T9) return ifT9((T9)self);
            if (self is T10) return ifT10((T10)self);
            return Otherwise(self);
        }

        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10)
        {
            return TypeMatch(self, ifT1, ifT2, ifT3, ifT4, ifT5, ifT6, ifT7, ifT8, ifT9, ifT10, _ => { throw new Exception(); });
        }
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11, Func<object, TResult> Otherwise)
        {
            if (self is T1) return ifT1((T1)self);
            if (self is T2) return ifT2((T2)self);
            if (self is T3) return ifT3((T3)self);
            if (self is T4) return ifT4((T4)self);
            if (self is T5) return ifT5((T5)self);
            if (self is T6) return ifT6((T6)self);
            if (self is T7) return ifT7((T7)self);
            if (self is T8) return ifT8((T8)self);
            if (self is T9) return ifT9((T9)self);
            if (self is T10) return ifT10((T10)self);
            if (self is T11) return ifT11((T11)self);
            return Otherwise(self);
        }

        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11)
        {
            return TypeMatch(self, ifT1, ifT2, ifT3, ifT4, ifT5, ifT6, ifT7, ifT8, ifT9, ifT10, ifT11, _ => { throw new Exception(); });
        }
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11, Func<T12, TResult> ifT12, Func<object, TResult> Otherwise)
        {
            if (self is T1) return ifT1((T1)self);
            if (self is T2) return ifT2((T2)self);
            if (self is T3) return ifT3((T3)self);
            if (self is T4) return ifT4((T4)self);
            if (self is T5) return ifT5((T5)self);
            if (self is T6) return ifT6((T6)self);
            if (self is T7) return ifT7((T7)self);
            if (self is T8) return ifT8((T8)self);
            if (self is T9) return ifT9((T9)self);
            if (self is T10) return ifT10((T10)self);
            if (self is T11) return ifT11((T11)self);
            if (self is T12) return ifT12((T12)self);
            return Otherwise(self);
        }

        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11, Func<T12, TResult> ifT12)
        {
            return TypeMatch(self, ifT1, ifT2, ifT3, ifT4, ifT5, ifT6, ifT7, ifT8, ifT9, ifT10, ifT11, ifT12, _ => { throw new Exception(); });
        }
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11, Func<T12, TResult> ifT12, Func<T13, TResult> ifT13, Func<object, TResult> Otherwise)
        {
            if (self is T1) return ifT1((T1)self);
            if (self is T2) return ifT2((T2)self);
            if (self is T3) return ifT3((T3)self);
            if (self is T4) return ifT4((T4)self);
            if (self is T5) return ifT5((T5)self);
            if (self is T6) return ifT6((T6)self);
            if (self is T7) return ifT7((T7)self);
            if (self is T8) return ifT8((T8)self);
            if (self is T9) return ifT9((T9)self);
            if (self is T10) return ifT10((T10)self);
            if (self is T11) return ifT11((T11)self);
            if (self is T12) return ifT12((T12)self);
            if (self is T13) return ifT13((T13)self);
            return Otherwise(self);
        }

        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11, Func<T12, TResult> ifT12, Func<T13, TResult> ifT13)
        {
            return TypeMatch(self, ifT1, ifT2, ifT3, ifT4, ifT5, ifT6, ifT7, ifT8, ifT9, ifT10, ifT11, ifT12, ifT13, _ => { throw new Exception(); });
        }
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11, Func<T12, TResult> ifT12, Func<T13, TResult> ifT13, Func<T14, TResult> ifT14, Func<object, TResult> Otherwise)
        {
            if (self is T1) return ifT1((T1)self);
            if (self is T2) return ifT2((T2)self);
            if (self is T3) return ifT3((T3)self);
            if (self is T4) return ifT4((T4)self);
            if (self is T5) return ifT5((T5)self);
            if (self is T6) return ifT6((T6)self);
            if (self is T7) return ifT7((T7)self);
            if (self is T8) return ifT8((T8)self);
            if (self is T9) return ifT9((T9)self);
            if (self is T10) return ifT10((T10)self);
            if (self is T11) return ifT11((T11)self);
            if (self is T12) return ifT12((T12)self);
            if (self is T13) return ifT13((T13)self);
            if (self is T14) return ifT14((T14)self);
            return Otherwise(self);
        }

        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11, Func<T12, TResult> ifT12, Func<T13, TResult> ifT13, Func<T14, TResult> ifT14)
        {
            return TypeMatch(self, ifT1, ifT2, ifT3, ifT4, ifT5, ifT6, ifT7, ifT8, ifT9, ifT10, ifT11, ifT12, ifT13, ifT14, _ => { throw new Exception(); });
        }
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11, Func<T12, TResult> ifT12, Func<T13, TResult> ifT13, Func<T14, TResult> ifT14, Func<T15, TResult> ifT15, Func<object, TResult> Otherwise)
        {
            if (self is T1) return ifT1((T1)self);
            if (self is T2) return ifT2((T2)self);
            if (self is T3) return ifT3((T3)self);
            if (self is T4) return ifT4((T4)self);
            if (self is T5) return ifT5((T5)self);
            if (self is T6) return ifT6((T6)self);
            if (self is T7) return ifT7((T7)self);
            if (self is T8) return ifT8((T8)self);
            if (self is T9) return ifT9((T9)self);
            if (self is T10) return ifT10((T10)self);
            if (self is T11) return ifT11((T11)self);
            if (self is T12) return ifT12((T12)self);
            if (self is T13) return ifT13((T13)self);
            if (self is T14) return ifT14((T14)self);
            if (self is T15) return ifT15((T15)self);
            return Otherwise(self);
        }

        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11, Func<T12, TResult> ifT12, Func<T13, TResult> ifT13, Func<T14, TResult> ifT14, Func<T15, TResult> ifT15)
        {
            return TypeMatch(self, ifT1, ifT2, ifT3, ifT4, ifT5, ifT6, ifT7, ifT8, ifT9, ifT10, ifT11, ifT12, ifT13, ifT14, ifT15, _ => { throw new Exception(); });
        }
        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11, Func<T12, TResult> ifT12, Func<T13, TResult> ifT13, Func<T14, TResult> ifT14, Func<T15, TResult> ifT15, Func<T16, TResult> ifT16, Func<object, TResult> Otherwise)
        {
            if (self is T1) return ifT1((T1)self);
            if (self is T2) return ifT2((T2)self);
            if (self is T3) return ifT3((T3)self);
            if (self is T4) return ifT4((T4)self);
            if (self is T5) return ifT5((T5)self);
            if (self is T6) return ifT6((T6)self);
            if (self is T7) return ifT7((T7)self);
            if (self is T8) return ifT8((T8)self);
            if (self is T9) return ifT9((T9)self);
            if (self is T10) return ifT10((T10)self);
            if (self is T11) return ifT11((T11)self);
            if (self is T12) return ifT12((T12)self);
            if (self is T13) return ifT13((T13)self);
            if (self is T14) return ifT14((T14)self);
            if (self is T15) return ifT15((T15)self);
            if (self is T16) return ifT16((T16)self);
            return Otherwise(self);
        }

        public static TResult TypeMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11, Func<T12, TResult> ifT12, Func<T13, TResult> ifT13, Func<T14, TResult> ifT14, Func<T15, TResult> ifT15, Func<T16, TResult> ifT16)
        {
            return TypeMatch(self, ifT1, ifT2, ifT3, ifT4, ifT5, ifT6, ifT7, ifT8, ifT9, ifT10, ifT11, ifT12, ifT13, ifT14, ifT15, ifT16, _ => { throw new Exception(); });
        }
    }
}