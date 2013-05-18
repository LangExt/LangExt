using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LangExt
{
    sealed class CachedSeq<T> : ISeq<T>
    {
        IEnumerator<T> itor;
        readonly List<T> values = new List<T>();

        internal CachedSeq(IEnumerable<T> src)
        {
            this.itor = src.GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new CachedEnumerator<T>(this);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }

        public override string ToString()
        {
            if (itor == CachedEnumerator<T>.Dummy)
            {
                if (values.Any())
                    return "cached seq [" + string.Join(", ", values) + "]";
                return "cached seq []";
            }
            if (values.Any())
                return "cached seq [" + string.Join(", ", values) +", ...]";
            return "cached seq [...]";
        }

        class CachedEnumerator<U> : IEnumerator<U>
        {
            internal static readonly IEnumerator<U> Dummy = ((ICollection<U>)new U[0]).GetEnumerator();

            int index = -1;
            bool preMoveNext = false;
            readonly CachedSeq<U> src;
            internal CachedEnumerator(CachedSeq<U> src) { this.src = src; }

            public U Current { get { return src.values[index]; } }

            public bool MoveNext()
            {
                lock (src.itor)
                {
                    if (++index < src.values.Count)
                        return preMoveNext = true;
                    if (src.itor == Dummy)
                        return preMoveNext = false;
                    if (src.itor.MoveNext())
                    {
                        src.values.Add(src.itor.Current);
                        return preMoveNext = true;
                    }
                    return preMoveNext = false;
                }
            }

            public void Dispose()
            {
                lock (src.itor)
                {
                    if (preMoveNext == false && src.itor != Dummy)
                    {
                        src.itor.Dispose();
                        src.itor = Dummy;
                    }
                }
            }

            public void Reset() { index = -1; }

            object System.Collections.IEnumerator.Current { get { return ((IEnumerator<U>)this).Current; } }
        }
    }
}
