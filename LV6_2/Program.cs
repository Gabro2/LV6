using System;
using System.Collections.Generic;

namespace LV6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
        }
        public static void Test()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();

            Random generator = new Random();
            for (int i = 0; i < n; i++)
            {
                list.Add(generator.Next(-10, 10));
            }
            Console.WriteLine(string.Join(",", list));
            Console.WriteLine(string.Join(",", Utilities.Filter(list, (int x) => x % 3 == 0 && x != 0)));
            Console.WriteLine(string.Join(",", Utilities.Filter(list, (int x) => x >= -5 && x <= 5)));
        }
    }
}
