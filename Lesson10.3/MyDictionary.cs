using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10._3
{
    class MyDictionary<TKey,TValue>
    {
        private TKey[] keys;
        private TValue[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TValue value, TKey key)
        {
            if(keys.Contains(key))
            {
                for (int i = 0; i < keys.Length; i++)
                {
                    if(keys[i].Equals(key))
                    {
                        values[i] = value;
                        Console.WriteLine("Данный ключ существует. Значение было обновлено.");
                    }
                }
            } else
            {
                AddItem<TValue>(ref values, value);
                AddItem<TKey>(ref keys, key);
            }
                
        }

        private void AddItem<T>(ref T[] array, T value)
        {
            T[] tempArray = new T[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }
            tempArray[array.Length] = value;
            array = tempArray;
        }

        public string this[int index]
        {
            get
            {
                if(index >= 0 && index < keys.Length)
                {
                    return string.Format($"key: {keys[index]} value: {values[index]}");
                } else
                {
                    return "Индекс указывает за границы массива";
                }
            }
        }


        public int Lenght => keys.Length;

        public TValue this[TKey key]
        {
            get
            {                
                for (int i = 0; i < keys.Length; i++)
                {
                    if(keys[i].Equals(key))
                    {
                        return values[i];
                    }
                }
                Console.WriteLine("Заданный ключ не найден");
                return default(TValue);
            }
        }

        public void Clear()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
    }
}
