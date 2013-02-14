using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LangExt2
{
    sealed class CachedEnumerable<T> : IEnumerable<T>
    {
        IEnumerator<T> itor;
        readonly List<T> values = new List<T>();

        internal CachedEnumerable(IEnumerable<T> src)
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

        class CachedEnumerator<U> : IEnumerator<U>
        {
            static readonly IEnumerator<U> dummy = ((ICollection<U>)new U[0]).GetEnumerator();

            int index = 0;
            readonly CachedEnumerable<U> src;
            internal CachedEnumerator(CachedEnumerable<U> src) { this.src = src; }

            public U Current { get { return src.values[index]; } }

            public bool MoveNext()
            {
                lock (src.itor)
                {
                    if (index < src.values.Count)
                    {
                        index++;
                        return true;
                    }
                    if (src.itor == dummy)
                        return false;
                    if (src.itor.MoveNext())
                    {
                        index++;
                        src.values.Add(src.itor.Current);
                        return true;
                    }
                    return false;
                }
            }

            public void Dispose()
            {
                lock (src.itor)
                {
                    if (src.itor != dummy)
                    {
                        src.itor.Dispose();
                        src.itor = dummy;
                    }
                }
            }

            public void Reset() { index = 0; }

            object System.Collections.IEnumerator.Current { get { return ((IEnumerator<U>)this).Current; } }
        }
    }
}
