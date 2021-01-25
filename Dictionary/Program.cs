using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ogrenciler = new MyDictionary<int, string>();
            ogrenciler.Add(123, "Özge");
            
        }
    }
    
    class MyDictionary<TKey,TValue>
    {
        TKey[] _keys;
        TValue[] _values;
        TKey[] _tempkey;
        TValue[] _tempvalue;

        public MyDictionary()
        {
            _keys = new TKey[0];
            _values = new TValue[0];

        }

        public void Add(TKey key, TValue value)
        {
            _tempkey = _keys;
            _keys = new TKey[_keys.Length + 1];
            for(int i = 0; i < _tempkey.Length; i++)
            {
                _keys[i] = _tempkey[i];
            }
            _keys[_keys.Length - 1] = key;

            _tempvalue = _values;
            _values = new TValue[_values.Length + 1];
            for(int i=0; i < _tempvalue.Length; i++)
            {
                _values[i] = _tempvalue[i];
            }
            _values[_values.Length - 1] = value;
        }
    }
}
