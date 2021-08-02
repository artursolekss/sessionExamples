using System;
using System.Text.RegularExpressions;

namespace StringsAssgmnt
{
    class Assgmn4
    {

        static void Main(string[] args)
        {
            // if (Regex.IsMatch(args[0], "^[a-zA-Z]+$"))
            //     Console.WriteLine("Correct");
            // else
            // {
            //     Console.WriteLine("Not correct");
            // }


            // if (Regex.IsMatch(Console.ReadLine(), "^[a-zA-Z][0-9]{2}[a-zA-Z]+$"))
            //     Console.WriteLine("Correct");
            // else
            // {
            //     Console.WriteLine("Not correct");
            // }

            if (Regex.IsMatch(Console.ReadLine(), "^[0-9]{6}(\\s-\\s|-)[0-9]{5}$"))
                Console.WriteLine("Correct");
            else
            {
                Console.WriteLine("Not correct");
            }

        }

    }

}