using System.Collections;

namespace Collections
{
    // Aggregate
    public class MijnCollectie<T> : IEnumerable<T>
    {
        private T?[] _collection = new T[100];

        public int Count
        {
            get 
            {
                return _collection.Length;
            }

        }
        public T? this[int idx]
        {
            get
            {
                if (idx < _collection.Length && idx >= 0)
                {
                    return _collection[idx];
                }
                return default;
            }
            set
            {
            if (idx < _collection.Length && idx >= 0)
                {
                    _collection[idx] = value;
                }
            }
        }
        public void Add(T item)
        {
            for(int i = 0; i < _collection.Length; i++)
            {
                if (_collection[i] == null)
                {
                    _collection[i] = item;
                    return;
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MijnIterator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _collection.GetEnumerator();
        }
    }
}