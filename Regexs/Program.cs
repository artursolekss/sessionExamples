using System;
using System.Text.RegularExpressions;

namespace Regexs
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter the phone number");
           string phoneNumber = Console.ReadLine(); 
        //    if(Regex.IsMatch(phoneNumber, "*\\+3712\\d{7}*")){
            //   Console.WriteLine("The phone number is correct");
            //   else
            //  Console.WriteLine("Phone number is not corect");
           if(Regex.IsMatch(phoneNumber, "*name*")){
             Console.WriteLine("This string contains the word name");
           }
           else
             Console.WriteLine("This string does not contain the word name");


        }
    }
}
