using System;
using System.Text.RegularExpressions;

namespace StringsAssgmnt
{
    class Assgmn1
    {
        public static void Main(string[] args)
        {
            string name = "Jo hn ";
            name = name.Replace(" ", "");///replace the spaces
            Console.WriteLine(name);
            if (Regex.IsMatch(name, "^[a-zA-Z]+$"))
                Console.WriteLine("The name is correct");
        }
    }
}