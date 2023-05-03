using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Generics
{
    internal class Find_Max<T> where T: IComparable
    {
        public void FindMaxValue(T first, T second, T third)
        {
            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
            {
                Console.WriteLine("{0} is greater number out of {1} {2} {3}", first, first, second, third);
            }
            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
            {
                Console.WriteLine("{0} is greater number out of {1} {2} {3}", second, first, second, third);
            }
            else
            {
                Console.WriteLine("{0} is greater number out of {1} {2} {3}", third, first, second, third);
            }
        }
    }
}
