
using System;

namespace LangExt.Legacy.CastMatches
{
    public static class LegacyObject
    {
        public static TResult CastMatch<T1, TResult>(this object self, Func<T1, TResult> ifT1, Func<object, TResult> Otherwise)
        {
            try { return ifT1((T1)self); } catch { /* do nothing */ }
            return Otherwise(self);
        }

        public static TResult CastMatch<T1, TResult>(this object self, Func<T1, TResult> ifT1)
        {
            return CastMatch(
                self,
                ifT1,
                _ => { throw new MatchFailureException(string.Format("Doesn't match any of [{1}].", typeof(T1).Name)); });
        }
        public static TResult CastMatch<T1, T2, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<object, TResult> Otherwise)
        {
            try { return ifT1((T1)self); } catch { /* do nothing */ }
            try { return ifT2((T2)self); } catch { /* do nothing */ }
            return Otherwise(self);
        }

        public static TResult CastMatch<T1, T2, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2)
        {
            return CastMatch(
                self,
                ifT1, ifT2,
                _ => { throw new MatchFailureException(string.Format("Doesn't match any of [{1}, {2}].", typeof(T1).Name, typeof(T2).Name)); });
        }
        public static TResult CastMatch<T1, T2, T3, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<object, TResult> Otherwise)
        {
            try { return ifT1((T1)self); } catch { /* do nothing */ }
            try { return ifT2((T2)self); } catch { /* do nothing */ }
            try { return ifT3((T3)self); } catch { /* do nothing */ }
            return Otherwise(self);
        }

        public static TResult CastMatch<T1, T2, T3, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3)
        {
            return CastMatch(
                self,
                ifT1, ifT2, ifT3,
                _ => { throw new MatchFailureException(string.Format("Doesn't match any of [{1}, {2}, {3}].", typeof(T1).Name, typeof(T2).Name, typeof(T3).Name)); });
        }
        public static TResult CastMatch<T1, T2, T3, T4, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<object, TResult> Otherwise)
        {
            try { return ifT1((T1)self); } catch { /* do nothing */ }
            try { return ifT2((T2)self); } catch { /* do nothing */ }
            try { return ifT3((T3)self); } catch { /* do nothing */ }
            try { return ifT4((T4)self); } catch { /* do nothing */ }
            return Otherwise(self);
        }

        public static TResult CastMatch<T1, T2, T3, T4, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4)
        {
            return CastMatch(
                self,
                ifT1, ifT2, ifT3, ifT4,
                _ => { throw new MatchFailureException(string.Format("Doesn't match any of [{1}, {2}, {3}, {4}].", typeof(T1).Name, typeof(T2).Name, typeof(T3).Name, typeof(T4).Name)); });
        }
        public static TResult CastMatch<T1, T2, T3, T4, T5, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<object, TResult> Otherwise)
        {
            try { return ifT1((T1)self); } catch { /* do nothing */ }
            try { return ifT2((T2)self); } catch { /* do nothing */ }
            try { return ifT3((T3)self); } catch { /* do nothing */ }
            try { return ifT4((T4)self); } catch { /* do nothing */ }
            try { return ifT5((T5)self); } catch { /* do nothing */ }
            return Otherwise(self);
        }

        public static TResult CastMatch<T1, T2, T3, T4, T5, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5)
        {
            return CastMatch(
                self,
                ifT1, ifT2, ifT3, ifT4, ifT5,
                _ => { throw new MatchFailureException(string.Format("Doesn't match any of [{1}, {2}, {3}, {4}, {5}].", typeof(T1).Name, typeof(T2).Name, typeof(T3).Name, typeof(T4).Name, typeof(T5).Name)); });
        }
        public static TResult CastMatch<T1, T2, T3, T4, T5, T6, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<object, TResult> Otherwise)
        {
            try { return ifT1((T1)self); } catch { /* do nothing */ }
            try { return ifT2((T2)self); } catch { /* do nothing */ }
            try { return ifT3((T3)self); } catch { /* do nothing */ }
            try { return ifT4((T4)self); } catch { /* do nothing */ }
            try { return ifT5((T5)self); } catch { /* do nothing */ }
            try { return ifT6((T6)self); } catch { /* do nothing */ }
            return Otherwise(self);
        }

        public static TResult CastMatch<T1, T2, T3, T4, T5, T6, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6)
        {
            return CastMatch(
                self,
                ifT1, ifT2, ifT3, ifT4, ifT5, ifT6,
                _ => { throw new MatchFailureException(string.Format("Doesn't match any of [{1}, {2}, {3}, {4}, {5}, {6}].", typeof(T1).Name, typeof(T2).Name, typeof(T3).Name, typeof(T4).Name, typeof(T5).Name, typeof(T6).Name)); });
        }
        public static TResult CastMatch<T1, T2, T3, T4, T5, T6, T7, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<object, TResult> Otherwise)
        {
            try { return ifT1((T1)self); } catch { /* do nothing */ }
            try { return ifT2((T2)self); } catch { /* do nothing */ }
            try { return ifT3((T3)self); } catch { /* do nothing */ }
            try { return ifT4((T4)self); } catch { /* do nothing */ }
            try { return ifT5((T5)self); } catch { /* do nothing */ }
            try { return ifT6((T6)self); } catch { /* do nothing */ }
            try { return ifT7((T7)self); } catch { /* do nothing */ }
            return Otherwise(self);
        }

        public static TResult CastMatch<T1, T2, T3, T4, T5, T6, T7, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7)
        {
            return CastMatch(
                self,
                ifT1, ifT2, ifT3, ifT4, ifT5, ifT6, ifT7,
                _ => { throw new MatchFailureException(string.Format("Doesn't match any of [{1}, {2}, {3}, {4}, {5}, {6}, {7}].", typeof(T1).Name, typeof(T2).Name, typeof(T3).Name, typeof(T4).Name, typeof(T5).Name, typeof(T6).Name, typeof(T7).Name)); });
        }
        public static TResult CastMatch<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<object, TResult> Otherwise)
        {
            try { return ifT1((T1)self); } catch { /* do nothing */ }
            try { return ifT2((T2)self); } catch { /* do nothing */ }
            try { return ifT3((T3)self); } catch { /* do nothing */ }
            try { return ifT4((T4)self); } catch { /* do nothing */ }
            try { return ifT5((T5)self); } catch { /* do nothing */ }
            try { return ifT6((T6)self); } catch { /* do nothing */ }
            try { return ifT7((T7)self); } catch { /* do nothing */ }
            try { return ifT8((T8)self); } catch { /* do nothing */ }
            return Otherwise(self);
        }

        public static TResult CastMatch<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8)
        {
            return CastMatch(
                self,
                ifT1, ifT2, ifT3, ifT4, ifT5, ifT6, ifT7, ifT8,
                _ => { throw new MatchFailureException(string.Format("Doesn't match any of [{1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}].", typeof(T1).Name, typeof(T2).Name, typeof(T3).Name, typeof(T4).Name, typeof(T5).Name, typeof(T6).Name, typeof(T7).Name, typeof(T8).Name)); });
        }
        public static TResult CastMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<object, TResult> Otherwise)
        {
            try { return ifT1((T1)self); } catch { /* do nothing */ }
            try { return ifT2((T2)self); } catch { /* do nothing */ }
            try { return ifT3((T3)self); } catch { /* do nothing */ }
            try { return ifT4((T4)self); } catch { /* do nothing */ }
            try { return ifT5((T5)self); } catch { /* do nothing */ }
            try { return ifT6((T6)self); } catch { /* do nothing */ }
            try { return ifT7((T7)self); } catch { /* do nothing */ }
            try { return ifT8((T8)self); } catch { /* do nothing */ }
            try { return ifT9((T9)self); } catch { /* do nothing */ }
            return Otherwise(self);
        }

        public static TResult CastMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9)
        {
            return CastMatch(
                self,
                ifT1, ifT2, ifT3, ifT4, ifT5, ifT6, ifT7, ifT8, ifT9,
                _ => { throw new MatchFailureException(string.Format("Doesn't match any of [{1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}].", typeof(T1).Name, typeof(T2).Name, typeof(T3).Name, typeof(T4).Name, typeof(T5).Name, typeof(T6).Name, typeof(T7).Name, typeof(T8).Name, typeof(T9).Name)); });
        }
        public static TResult CastMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<object, TResult> Otherwise)
        {
            try { return ifT1((T1)self); } catch { /* do nothing */ }
            try { return ifT2((T2)self); } catch { /* do nothing */ }
            try { return ifT3((T3)self); } catch { /* do nothing */ }
            try { return ifT4((T4)self); } catch { /* do nothing */ }
            try { return ifT5((T5)self); } catch { /* do nothing */ }
            try { return ifT6((T6)self); } catch { /* do nothing */ }
            try { return ifT7((T7)self); } catch { /* do nothing */ }
            try { return ifT8((T8)self); } catch { /* do nothing */ }
            try { return ifT9((T9)self); } catch { /* do nothing */ }
            try { return ifT10((T10)self); } catch { /* do nothing */ }
            return Otherwise(self);
        }

        public static TResult CastMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10)
        {
            return CastMatch(
                self,
                ifT1, ifT2, ifT3, ifT4, ifT5, ifT6, ifT7, ifT8, ifT9, ifT10,
                _ => { throw new MatchFailureException(string.Format("Doesn't match any of [{1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}].", typeof(T1).Name, typeof(T2).Name, typeof(T3).Name, typeof(T4).Name, typeof(T5).Name, typeof(T6).Name, typeof(T7).Name, typeof(T8).Name, typeof(T9).Name, typeof(T10).Name)); });
        }
        public static TResult CastMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11, Func<object, TResult> Otherwise)
        {
            try { return ifT1((T1)self); } catch { /* do nothing */ }
            try { return ifT2((T2)self); } catch { /* do nothing */ }
            try { return ifT3((T3)self); } catch { /* do nothing */ }
            try { return ifT4((T4)self); } catch { /* do nothing */ }
            try { return ifT5((T5)self); } catch { /* do nothing */ }
            try { return ifT6((T6)self); } catch { /* do nothing */ }
            try { return ifT7((T7)self); } catch { /* do nothing */ }
            try { return ifT8((T8)self); } catch { /* do nothing */ }
            try { return ifT9((T9)self); } catch { /* do nothing */ }
            try { return ifT10((T10)self); } catch { /* do nothing */ }
            try { return ifT11((T11)self); } catch { /* do nothing */ }
            return Otherwise(self);
        }

        public static TResult CastMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11)
        {
            return CastMatch(
                self,
                ifT1, ifT2, ifT3, ifT4, ifT5, ifT6, ifT7, ifT8, ifT9, ifT10, ifT11,
                _ => { throw new MatchFailureException(string.Format("Doesn't match any of [{1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}].", typeof(T1).Name, typeof(T2).Name, typeof(T3).Name, typeof(T4).Name, typeof(T5).Name, typeof(T6).Name, typeof(T7).Name, typeof(T8).Name, typeof(T9).Name, typeof(T10).Name, typeof(T11).Name)); });
        }
        public static TResult CastMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11, Func<T12, TResult> ifT12, Func<object, TResult> Otherwise)
        {
            try { return ifT1((T1)self); } catch { /* do nothing */ }
            try { return ifT2((T2)self); } catch { /* do nothing */ }
            try { return ifT3((T3)self); } catch { /* do nothing */ }
            try { return ifT4((T4)self); } catch { /* do nothing */ }
            try { return ifT5((T5)self); } catch { /* do nothing */ }
            try { return ifT6((T6)self); } catch { /* do nothing */ }
            try { return ifT7((T7)self); } catch { /* do nothing */ }
            try { return ifT8((T8)self); } catch { /* do nothing */ }
            try { return ifT9((T9)self); } catch { /* do nothing */ }
            try { return ifT10((T10)self); } catch { /* do nothing */ }
            try { return ifT11((T11)self); } catch { /* do nothing */ }
            try { return ifT12((T12)self); } catch { /* do nothing */ }
            return Otherwise(self);
        }

        public static TResult CastMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11, Func<T12, TResult> ifT12)
        {
            return CastMatch(
                self,
                ifT1, ifT2, ifT3, ifT4, ifT5, ifT6, ifT7, ifT8, ifT9, ifT10, ifT11, ifT12,
                _ => { throw new MatchFailureException(string.Format("Doesn't match any of [{1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}].", typeof(T1).Name, typeof(T2).Name, typeof(T3).Name, typeof(T4).Name, typeof(T5).Name, typeof(T6).Name, typeof(T7).Name, typeof(T8).Name, typeof(T9).Name, typeof(T10).Name, typeof(T11).Name, typeof(T12).Name)); });
        }
        public static TResult CastMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11, Func<T12, TResult> ifT12, Func<T13, TResult> ifT13, Func<object, TResult> Otherwise)
        {
            try { return ifT1((T1)self); } catch { /* do nothing */ }
            try { return ifT2((T2)self); } catch { /* do nothing */ }
            try { return ifT3((T3)self); } catch { /* do nothing */ }
            try { return ifT4((T4)self); } catch { /* do nothing */ }
            try { return ifT5((T5)self); } catch { /* do nothing */ }
            try { return ifT6((T6)self); } catch { /* do nothing */ }
            try { return ifT7((T7)self); } catch { /* do nothing */ }
            try { return ifT8((T8)self); } catch { /* do nothing */ }
            try { return ifT9((T9)self); } catch { /* do nothing */ }
            try { return ifT10((T10)self); } catch { /* do nothing */ }
            try { return ifT11((T11)self); } catch { /* do nothing */ }
            try { return ifT12((T12)self); } catch { /* do nothing */ }
            try { return ifT13((T13)self); } catch { /* do nothing */ }
            return Otherwise(self);
        }

        public static TResult CastMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11, Func<T12, TResult> ifT12, Func<T13, TResult> ifT13)
        {
            return CastMatch(
                self,
                ifT1, ifT2, ifT3, ifT4, ifT5, ifT6, ifT7, ifT8, ifT9, ifT10, ifT11, ifT12, ifT13,
                _ => { throw new MatchFailureException(string.Format("Doesn't match any of [{1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}].", typeof(T1).Name, typeof(T2).Name, typeof(T3).Name, typeof(T4).Name, typeof(T5).Name, typeof(T6).Name, typeof(T7).Name, typeof(T8).Name, typeof(T9).Name, typeof(T10).Name, typeof(T11).Name, typeof(T12).Name, typeof(T13).Name)); });
        }
        public static TResult CastMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11, Func<T12, TResult> ifT12, Func<T13, TResult> ifT13, Func<T14, TResult> ifT14, Func<object, TResult> Otherwise)
        {
            try { return ifT1((T1)self); } catch { /* do nothing */ }
            try { return ifT2((T2)self); } catch { /* do nothing */ }
            try { return ifT3((T3)self); } catch { /* do nothing */ }
            try { return ifT4((T4)self); } catch { /* do nothing */ }
            try { return ifT5((T5)self); } catch { /* do nothing */ }
            try { return ifT6((T6)self); } catch { /* do nothing */ }
            try { return ifT7((T7)self); } catch { /* do nothing */ }
            try { return ifT8((T8)self); } catch { /* do nothing */ }
            try { return ifT9((T9)self); } catch { /* do nothing */ }
            try { return ifT10((T10)self); } catch { /* do nothing */ }
            try { return ifT11((T11)self); } catch { /* do nothing */ }
            try { return ifT12((T12)self); } catch { /* do nothing */ }
            try { return ifT13((T13)self); } catch { /* do nothing */ }
            try { return ifT14((T14)self); } catch { /* do nothing */ }
            return Otherwise(self);
        }

        public static TResult CastMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11, Func<T12, TResult> ifT12, Func<T13, TResult> ifT13, Func<T14, TResult> ifT14)
        {
            return CastMatch(
                self,
                ifT1, ifT2, ifT3, ifT4, ifT5, ifT6, ifT7, ifT8, ifT9, ifT10, ifT11, ifT12, ifT13, ifT14,
                _ => { throw new MatchFailureException(string.Format("Doesn't match any of [{1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}].", typeof(T1).Name, typeof(T2).Name, typeof(T3).Name, typeof(T4).Name, typeof(T5).Name, typeof(T6).Name, typeof(T7).Name, typeof(T8).Name, typeof(T9).Name, typeof(T10).Name, typeof(T11).Name, typeof(T12).Name, typeof(T13).Name, typeof(T14).Name)); });
        }
        public static TResult CastMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11, Func<T12, TResult> ifT12, Func<T13, TResult> ifT13, Func<T14, TResult> ifT14, Func<T15, TResult> ifT15, Func<object, TResult> Otherwise)
        {
            try { return ifT1((T1)self); } catch { /* do nothing */ }
            try { return ifT2((T2)self); } catch { /* do nothing */ }
            try { return ifT3((T3)self); } catch { /* do nothing */ }
            try { return ifT4((T4)self); } catch { /* do nothing */ }
            try { return ifT5((T5)self); } catch { /* do nothing */ }
            try { return ifT6((T6)self); } catch { /* do nothing */ }
            try { return ifT7((T7)self); } catch { /* do nothing */ }
            try { return ifT8((T8)self); } catch { /* do nothing */ }
            try { return ifT9((T9)self); } catch { /* do nothing */ }
            try { return ifT10((T10)self); } catch { /* do nothing */ }
            try { return ifT11((T11)self); } catch { /* do nothing */ }
            try { return ifT12((T12)self); } catch { /* do nothing */ }
            try { return ifT13((T13)self); } catch { /* do nothing */ }
            try { return ifT14((T14)self); } catch { /* do nothing */ }
            try { return ifT15((T15)self); } catch { /* do nothing */ }
            return Otherwise(self);
        }

        public static TResult CastMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11, Func<T12, TResult> ifT12, Func<T13, TResult> ifT13, Func<T14, TResult> ifT14, Func<T15, TResult> ifT15)
        {
            return CastMatch(
                self,
                ifT1, ifT2, ifT3, ifT4, ifT5, ifT6, ifT7, ifT8, ifT9, ifT10, ifT11, ifT12, ifT13, ifT14, ifT15,
                _ => { throw new MatchFailureException(string.Format("Doesn't match any of [{1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}].", typeof(T1).Name, typeof(T2).Name, typeof(T3).Name, typeof(T4).Name, typeof(T5).Name, typeof(T6).Name, typeof(T7).Name, typeof(T8).Name, typeof(T9).Name, typeof(T10).Name, typeof(T11).Name, typeof(T12).Name, typeof(T13).Name, typeof(T14).Name, typeof(T15).Name)); });
        }
        public static TResult CastMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11, Func<T12, TResult> ifT12, Func<T13, TResult> ifT13, Func<T14, TResult> ifT14, Func<T15, TResult> ifT15, Func<T16, TResult> ifT16, Func<object, TResult> Otherwise)
        {
            try { return ifT1((T1)self); } catch { /* do nothing */ }
            try { return ifT2((T2)self); } catch { /* do nothing */ }
            try { return ifT3((T3)self); } catch { /* do nothing */ }
            try { return ifT4((T4)self); } catch { /* do nothing */ }
            try { return ifT5((T5)self); } catch { /* do nothing */ }
            try { return ifT6((T6)self); } catch { /* do nothing */ }
            try { return ifT7((T7)self); } catch { /* do nothing */ }
            try { return ifT8((T8)self); } catch { /* do nothing */ }
            try { return ifT9((T9)self); } catch { /* do nothing */ }
            try { return ifT10((T10)self); } catch { /* do nothing */ }
            try { return ifT11((T11)self); } catch { /* do nothing */ }
            try { return ifT12((T12)self); } catch { /* do nothing */ }
            try { return ifT13((T13)self); } catch { /* do nothing */ }
            try { return ifT14((T14)self); } catch { /* do nothing */ }
            try { return ifT15((T15)self); } catch { /* do nothing */ }
            try { return ifT16((T16)self); } catch { /* do nothing */ }
            return Otherwise(self);
        }

        public static TResult CastMatch<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this object self, Func<T1, TResult> ifT1, Func<T2, TResult> ifT2, Func<T3, TResult> ifT3, Func<T4, TResult> ifT4, Func<T5, TResult> ifT5, Func<T6, TResult> ifT6, Func<T7, TResult> ifT7, Func<T8, TResult> ifT8, Func<T9, TResult> ifT9, Func<T10, TResult> ifT10, Func<T11, TResult> ifT11, Func<T12, TResult> ifT12, Func<T13, TResult> ifT13, Func<T14, TResult> ifT14, Func<T15, TResult> ifT15, Func<T16, TResult> ifT16)
        {
            return CastMatch(
                self,
                ifT1, ifT2, ifT3, ifT4, ifT5, ifT6, ifT7, ifT8, ifT9, ifT10, ifT11, ifT12, ifT13, ifT14, ifT15, ifT16,
                _ => { throw new MatchFailureException(string.Format("Doesn't match any of [{1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}].", typeof(T1).Name, typeof(T2).Name, typeof(T3).Name, typeof(T4).Name, typeof(T5).Name, typeof(T6).Name, typeof(T7).Name, typeof(T8).Name, typeof(T9).Name, typeof(T10).Name, typeof(T11).Name, typeof(T12).Name, typeof(T13).Name, typeof(T14).Name, typeof(T15).Name, typeof(T16).Name)); });
        }
    }
}