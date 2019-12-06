using System;
using System.Collections;
using System.Collections.Generic;

namespace Training.Task3.DynamicArray
{
    class CycledEnumerator<T> : IEnumerator<T>
    {
        private DynamicArray<T> _array;
        private int _index;

        public CycledEnumerator(DynamicArray<T> array)
        {
            _array = array;
            _index = _array.Length;
        }
        public T Current
        {

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
            }
            else
            {
                Reset();
            }
            return true;
        }
        public void Reset()
        {
            _index = 0;
        }
    }
}
