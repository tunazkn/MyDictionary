using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> dictionary = new MyDictionary<string, int>();
            dictionary.Add("Kodlama", 8);
            dictionary.Add("Geliştirme", 2);
            dictionary.Add("Eğitim", 5);
            dictionary.Add("Yazılım", 10);
            dictionary.Add("Bİlgisayar", 1);
            dictionary.Add("C#", 9);
            dictionary.Add("Kelime", 12);

            foreach (var key in dictionary.Keys)
            {
                Console.WriteLine("Key: " + key);
            }

            foreach (var value in dictionary.Values)
            {
                Console.WriteLine("Value: " + value);
            }
        }
    }
}
