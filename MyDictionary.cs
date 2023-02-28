using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camp4_odev5
{
    class MyDictionary<Key,Value>
    {

        Key[] keys;
        Value[] values;
        public MyDictionary()
        {
            keys = new Key[0];
            values = new Value[0];
        }
        
        public void AddDictionary(Key key,Value value)
        {
            Key[] tempArrayKey = keys;
            keys = new Key[keys.Length + 1];
            for (int i = 0; i < tempArrayKey.Length; i++)
            {
                keys[0] = tempArrayKey[i];
            }
            keys[keys.Length - 1] = key;

            Value[] tempArrayValue = values;
            values = new Value[values.Length + 1];
            for (int x = 0; x < tempArrayValue.Length; x++)
            {
                values[0] = tempArrayValue[x];
            }
            values[values.Length - 1] = value;
            Console.WriteLine(keys[keys.Length - 1]+" " +values[values.Length-1]);
        }

    }
}
