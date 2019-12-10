using System;
using System.Collections;
using System.Collections.Generic;

namespace Training.Task3.DynamicArray
{
    class CycledDynamicArray<T> : DynamicArray<T>, IEnumerable<T>
    {
        public CycledDynamicArray() : base() { }

        public CycledDynamicArray(int capacity) : base(capacity) { }

        public CycledDynamicArray(IEnumerable<T> collection) : base(collection) { }
        public override IEnumerator<T> GetEnumerator()
        {
            return new CycledEnumerator<T>(this);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new CycledEnumerator<T>(this);
        }
    }
}
