using System;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] _keys;
        TValue[] _values;
        public MyDictionary()
        {
            _keys = new TKey[0];
            _values = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            TKey[] keys = _keys;
            TValue[] values = _values;

            _keys = new TKey[_keys.Length + 1];
            _values = new TValue[_values.Length + 1];

            for (int i = 0; i < keys.Length; i++)
            {
                _keys[i] = keys[i];
                _values[i] = values[i];
            }

            _keys[_keys.Length - 1] = key;
            _values[_values.Length - 1] = value;
        }
        public TKey[] Keys
        {
            get { return _keys; }
        }

        public TValue[] Values
        {
            get { return _values; }
        }
    }
}
