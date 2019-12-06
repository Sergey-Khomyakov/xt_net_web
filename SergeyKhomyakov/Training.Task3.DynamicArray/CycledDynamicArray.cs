using System;
using System.Collections;
using System.Collections.Generic;

namespace Training.Task3.DynamicArray
{
    class CycledDynamicArray<T> : DynamicArray<T>, IEnumerable<T>
    {
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
