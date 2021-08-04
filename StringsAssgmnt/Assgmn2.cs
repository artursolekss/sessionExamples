using System;
using System.Text.RegularExpressions;

namespace StringsAssgmnt
{
    class Assgmn2
    {

        static void Main()
        {
            string[] arr = { "Computer", "Plate", "Chair", "Girl", "Boy", "Cat", "Dog", "Shirt", "Determination" };
            int countC = 0, countE = 0, count5 = 0, countEexist = 0, countTe = 0;
            int maxLen = 0;
            foreach (string element in arr)
            {
                if (element[0] == 'C')
                    countC++;
                if (element[element.Length - 1] == 'e')
                    countE++;
                if (element.Length == 5)
                    count5++;
                if (element.Contains("e"))
                    countEexist++;
                if (element.Contains("te"))
                    countTe++;

                if (element.Length > maxLen)
                    maxLen = element.Length;

            }
            int[] histogram = new int[maxLen + 1];///+1 is herer, because the arrays start at 0
            foreach (var element in arr)
            {
                int prevValue = histogram[element.Length];
                histogram[element.Length] = ++prevValue;
            }

            Console.WriteLine("There are " + countC + " starting with C");
            Console.WriteLine("There are " + countE + " ending with E");
            Console.WriteLine("There are " + count5 + " with the lenght 5");
            Console.WriteLine("There are " + countEexist + " consist of the character e");
            Console.WriteLine("There are " + countTe + " consist of the substring te");

            for (int i = 0; i < histogram.Length; i++)
            {
                Console.WriteLine("There are " + histogram[i] + " words with the length " + i);
            }

        }

    }

}