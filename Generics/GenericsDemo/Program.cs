using System;
using System.Collections.Generic;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator<int,string> cal = new Calculator<int,string>();
            Console.WriteLine(cal.checkGreater(10, 4));
            Console.WriteLine(cal.checkLess("AA", "BB"));

            Calculator<string,int> calStr = new Calculator<string,int>();
            Console.WriteLine(calStr.checkGreater("AAA", "BBB"));
            Console.WriteLine(calStr.checkLess(10, 4));

            LinkedList<string> myStrList = new LinkedList<string>();

               myStrList.AddLast("Str1");
            myStrList.AddLast("Str2");

            //myStrList.AddLast(423432);

        }
    }
}
