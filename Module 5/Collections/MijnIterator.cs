using System.Collections;

namespace Collections
{
    public class MijnIterator<T> : IEnumerator<T>
    {
        private MijnCollectie<T> _theCollection;
        private int _index = -1;
        public MijnIterator(MijnCollectie<T> col)
        {
            _theCollection = col;
        }

        public T Current 
        {
            get
            {
                return _theCollection[_index]!;
            }
        }

        object IEnumerator.Current => Current!;

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
           if (_index < _theCollection.Count)
           {
               _index++;
               return true;
           }
           return false;
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}