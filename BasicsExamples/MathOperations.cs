using System;

namespace Operations
{
    class MathOperations
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Please enter the first value:");
            int value1 = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Please enter the second value:");
            int value2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("The value " + Math.Max(value1, value2) +
            " is the maximal value and the value " + Math.Min(value1, value2) + " is the minimal");
            // Console.WriteLine("Max of 9 and (Min of 15,8) is " + Math.Max(9, Math.Min(15, 8)));
            Console.WriteLine("value1 ^ value2 = " + Math.Pow(value1, value2));


            Console.WriteLine("Please enter the decimal value:");
            double valueDec = Double.Parse(Console.ReadLine().Replace('.', ','));

            Console.WriteLine("The rounded value is " + Math.Round(valueDec));


        }
    }
}