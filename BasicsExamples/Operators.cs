using System;

namespace Basics
{
    class Operators
    {

        static void Main(string[] args)
        {
            int a = 102, b = 5;
            int c = a / b;
            int moduloPart = a - ((a / b) * b);/// the same as a % b --> 102 - (20 * 5) = 2
            Console.WriteLine(c);
            Console.WriteLine(moduloPart);
        }
    }

}