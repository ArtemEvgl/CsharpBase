using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14._3
{
    class MyDictionary<TKey, TValue> : IEnumerable<object>, IEnumerator<object>
    {
        TKey[] keys;
        TValue[] values;
        int position = -1;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public TValue this[TKey key]
        {
            get
            {
                if(keys.Contains(key))
                {
                    int index = Array.FindIndex(keys, (i) => i.Equals(key));
                    return values[index];
                } else
                {
                    throw new Exception("Ключ не найден");
                }
            }
        }

        

        public void Add(TValue value, TKey key)
        {
            TValue[] tempV = new TValue[values.Length + 1];
            TKey[] tempK = new TKey[keys.Length + 1];
            values.CopyTo(tempV, 0);
            keys.CopyTo(tempK, 0);
            tempV[values.Length] = value;
            tempK[keys.Length] = key;
            values = tempV;
            keys = tempK;

        }

        public object Current => $"key:{keys[position]}---value:{values[position]}";
        public void Dispose()
        {
            Reset();
        }

        public IEnumerator<object> GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            while (true)
            {
                if(position < keys.Length - 1)
                {
                    position++;
                    return true;
                } else
                {
                    return false;
                }
            }
        }

        public void Reset()
        {
            position = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
}
