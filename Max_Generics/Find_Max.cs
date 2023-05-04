using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Generics
{
    internal class Find_Max<T> where T: IComparable
    {
        public T Max(params T[] a)
        {
            Array.Sort(a);
            return a[a.Length - 1];
        }
    }
}
