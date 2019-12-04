using System;

namespace Training.Task3.DynamicArray
{
    class DynamicArray<T> : IEnumerable
    {
        private T[] array;
        public DynamicArray()
        {
            array = new T[8];
        }
        public DynamicArray(int capacity)
        {
            array = new T[capacity];
        }
        public DynamicArray(IEnumerable enumerable)
        {
            
        }
        public int Count => throw new NotImplementedException();
        public void Add(T item)
        {
            throw new NotImplementedException();
        }
        public void Clear()
        {
            throw new NotImplementedException();
        }
        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }
        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }
        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }
    }
}
