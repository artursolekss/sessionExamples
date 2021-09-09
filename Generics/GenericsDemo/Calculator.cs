using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class Calculator<T1,T2> where T1:IComparable where T2:IComparable
    {

      public bool checkGreater(T1 a, T1 b)
        {
            if (a.CompareTo(b) > 0)
                return true;
            else
                return false;
        }

        public bool checkLess(T2 a, T2 b)
        {
            if (a.CompareTo(b) < 0)
                return true;
            else
                return false;
        }

    }
}
