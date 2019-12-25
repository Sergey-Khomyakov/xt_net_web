using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Training.Task3.DynamicArray
{
    class DynamicArray<T>: IEnumerable<T>, IEnumerable, ICloneable
    {
        private T[] _array;
        private int _size;
        public DynamicArray()
        {
            _array = new T[8];
            _size = 0;
        }
        public DynamicArray(int capacity)
        {
            if (capacity < 0)
                throw new ArgumentException("Negative number");
            _array = new T[capacity];
            _size = 0;
        }
        public DynamicArray(IEnumerable<T> collection)
        {
            if (collection == null)
                throw new ArgumentException("Collection is empty or null");
            _array = new T[collection.Count()];
            _size = collection.Count();
            int i = 0;
            foreach (var item in collection) 
            {
                _array[i++] = item;
            }
        }  
        public void Add(T item)
        {
            if (_size == _array.Length) 
            {
                _array = ToArray(_array.Length * 2);
            }
            _array[_size++] = item;
        }
        public void AddRange(IEnumerable<T> collection)
        {
            if (collection == null)
                throw new ArgumentException("Collection is empty or null");

            if (collection.Count() + _array.Length > _size) 
            {
                _array = ToArray(_array.Length + collection.Count());
            }

            foreach (var item in collection) 
            {
                _array[_size++] = item;
            }
        }
        public bool Remove(T item)
        {
            bool isFlagIndex = false;
            int index = 0;
            for (int i = 0; i < _size; i++) 
            {
                if (_array[i].Equals(item))
                {
                    isFlagIndex = true;
                    index = i;
                    break;
                }
            }
            if (isFlagIndex) 
            {
                for (int i = index; i < _size - 1; i++) 
                {
                    _array[i] = _array[i + 1];
                }
                _size--;
                return true;
            }
            return false;
        }      
        public bool Insert(T item, int index)
        {
            ChekIndex(index, this);

            if (_size == _array.Length)
            {
                ToArray(_array.Length * 2);
            }

            Array.Copy(_array, index, _array, index + 1, _size - index);
            _array[index] = item;
            _size++;
            return true;
        }
        public int Length { get { return _size; } }
        public int Capacity
        { 
            get
            { 
                return _array.Length;
            }
            set 
            {
                if (value <= 0) 
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (_size > value) 
                {
                    _size = value;
                }
                _array = ToArray(value);
            }
        }
        public virtual IEnumerator<T> GetEnumerator()
        {
            return new Enumerator<T>(this);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator<T>(this);
        }

        // index = -1 last item, index = -2 penultimate item
        public T this[int index]
        {
            get
            {
                if (index == -1)
                {
                    return _array[_array.Length];
                }
                else if (index == -2)
                {
                    return _array[_array.Length - 1];
                }
                else 
                {
                    return _array[index];
                }              
            } 
            set 
            {
                if (index == -1)
                {
                    _array[_array.Length] = value;
                }
                else if (index == -2)
                {
                    _array[_array.Length - 1] = value;
                }
                else 
                {
                    _array[index] = value;
                }                
            }
        }
        public object Clone()
        {
            return new DynamicArray<T>();
        }

        private void ChekIndex(int index, DynamicArray<T> array) 
        {
            if (index < 0 || index > _array.Length)
            {
                throw new IndexOutOfRangeException();
            }
        }

        private T[] ToArray(int size) 
        {
            T[] array = new T[size];
            _array.CopyTo(array, 0);
            return array;
        } 
    }
}
