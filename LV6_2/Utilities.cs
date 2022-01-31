using System;
using System.Collections.Generic;
using System.Text;

namespace LV6_2
{
    class Utilities
    {
        public static List<int> Filter(IEnumerable<int> numbers, Func<int, bool> func)
        {
            List<int> lnumbers = new List<int>();
            foreach (var number in numbers)
            {
                if (func(number) == true) lnumbers.Add(number);
            }
            return lnumbers;
        }
    }

}
