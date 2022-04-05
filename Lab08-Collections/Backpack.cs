using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Collections
{
    public class Backpack<T> : IBag<T>
    {
        private List<T> _pack;

        public Backpack()
        {
            _pack = new List<T>();
        }

        public void Pack(T item)
        {
            if (item == null)
                return;

            _pack.Add(item);
        }

        public T Unpack(int index)
        {
            _pack.RemoveAt(index);
            return _pack[index];
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _pack.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
    }
}
