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

            Console.WriteLine(a <= b); /// the same as !(a > b)
            Console.WriteLine("Text1" != "Text");
            Console.WriteLine((a == b) || (a > b));///the same as a >= b
            // Console.WriteLine(4 || 6);///not correct, only boolean values can be used

            Console.WriteLine("\n\n\n");
            int x = 15, y = 10;
            bool a1 = true, result;
            // AND operator
            result = (x <= y) && (x > 10);
            Console.WriteLine("AND Operator: " + result);
            // OR operator
            result = (x >= y) || (x < 5);
            Console.WriteLine("OR Operator: " + result);
            //NOT operator
            result = !a1;
            Console.WriteLine("NOT Operator: " + result);
            // Console.WriteLine("Press Enter Key to Exit..");
            // Console.ReadLine();


            Console.WriteLine("\n\n\n" + x++);
            Console.WriteLine(x);

            Console.WriteLine("\n\n\n" + ++x);
            Console.WriteLine(x);

            // int resultInt = y * ++x;
            // Console.WriteLine(resultInt);  <---- result is 180
            /// the same as
            // x++;
            // int resultInt = y * x;


            int resultInt = y * x++;
            Console.WriteLine(resultInt);
            /// the same as
            // int resultInt = y * x;
            // x++;

            resultInt += x;//resultInt = resultInt + x;
            Console.WriteLine(resultInt);

            resultInt %= x;//resultInt = resultInt % x;
            Console.WriteLine(resultInt);

            ///For strings
            string firstString = "AAB", secondString = "AAA";
            Console.WriteLine(firstString.Equals(secondString));
            Console.WriteLine(firstString.CompareTo(secondString));


        }
    }

}