using System;
using System.Collections;
using System.Collections.Generic;

namespace Training.Task3.DynamicArray
{
    class Enumerator<T> : IEnumerator<T>
    {
        private DynamicArray<T> _array;
        private int _index;

        public Enumerator(DynamicArray<T> array) 
        {
            _array = array;
            _index = -1;
        }
        public T Current { 

            get 
            {
                if (_index == -1) 
                {
                    throw new InvalidOperationException();
                }
                return _array[_index];
            } 
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (_index < _array.Length - 1)
            {
                _index++;
                return true;
            }
            else 
            {
                return false;
            }           
        }
        public void Reset()
        {
            _index = -1;
        }
    }
}
