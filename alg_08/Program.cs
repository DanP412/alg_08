using System;
using System.Collections.Generic;

namespace alg_08
{
    class Program
    {
        class StringHashTab
        {
            static readonly int Capacity = 101;
            private List<string>[] _arr = new List<string>[Capacity];

            public bool Add(string value)
            {
                int i = Hashode(value);
                if (Contains(value))
                {
                    return false;
                }
                if (_arr[i] = null)
                {
                    _arr[i] = new List<string>();
                }
                _arr[i].Add(value);
                return true;
            }

            private static int Hashode(string value)
            {
                int hash = Math.Abs(value.GetHashCode() % Capacity);
                Console.WriteLine(hash);
                return hash;

            }

            public bool Remove(string value)
            {
                int i = Hashode(value);
                if (_arr[i] != null)
                {
                    return _arr[i].Remove(value);

                }
                return false;

            }

            public bool Contains(string value)
            {
                if (_arr[Hashode(value)] == null)
                {
                    return false;
                }
                return _arr[Hashode(value)].Contains(value);
            }

        }
        static void Main(string[] args)
        {
            StringHashTab tab = new StringHashTab();
            Console.WriteLine(tab.Add("asa"));
            Console.WriteLine(tab.Add("aas"));
            Console.WriteLine(tab.Contains("asa"));
            Console.WriteLine(tab.Remove("asa"));
            Console.WriteLine(tab.Contains("asa"));
            int count = 1000;
            Random random = new Random();
            while (count-- < 1000)
            {
                int len = random.Next(10);
                string str = "";
                for (int i = 0; i < len; i++)
                {
                    str += random.Next(25) + 'a';
                }
                tab.Add(str);
            }
        }
    }
}