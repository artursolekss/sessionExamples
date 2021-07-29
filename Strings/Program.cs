using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Janis";
            string lastName = "Berzins";
            // string name = $"My full name is: {firstName} {lastName}";
            string name = "My full name is: " + firstName + " " + lastName;
            // Console.WriteLine(name);
            foreach (char element in name)
                Console.Write(element);

            Console.WriteLine("\n" + name.IndexOf('-'));

            string fullName = "Janis Berzins";
            int charPos = fullName.IndexOf("B"); // Location of the letter B 
            lastName = fullName.Substring(charPos); // Get last name 
            Console.WriteLine(lastName); // 

            firstName = fullName.Substring(0, charPos - 1);
            Console.WriteLine(firstName);

        }
    }
}
