using System;
using System.Collections.Generic;
using System.Text;

namespace myDictionary
{
    class MyDictionary<TKey, TValue>
    {
        List<TKey> _keys;
        List<TValue> _values;

        public MyDictionary()
        {
           _keys = new List<TKey>();
           _values = new List<TValue>();
        }

        public void Add(TKey key, TValue value)
        {
            if (_keys.Contains(key))
            {
                throw new ArgumentException();
            }
            _keys.Add(key);
            _values.Add(value);
        }

        public TValue GetValue(TKey key)
        {
            int index = _keys.IndexOf(key);
            return _values[index];
        }

        public TKey GetKey(TValue val)
        {
            int index = _values.IndexOf(val);
            return _keys[index];
        }

        public bool ContainsKey(TKey key)
        {
            return _keys.Contains(key);
        }

        public bool ContainsValue(TValue value)
        {
            return _values.Contains(value);
        }

        public void List()
        {
            Console.WriteLine("==== Here is the list: ====");
            for(var i=0; i<_keys.Count; i++)
            {
                Console.WriteLine( _keys[i]+ ":"+ _values[i]);
            }
        }

    }
}
