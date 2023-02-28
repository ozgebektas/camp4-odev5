using System;

namespace Camp4_odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> vocabulary = new MyDictionary<int ,string>();
            vocabulary.AddDictionary(1,"özge");
            vocabulary.AddDictionary(2,"ezgi");
            vocabulary.AddDictionary(3,"berkay");
        }
    }
}
