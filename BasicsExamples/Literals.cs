using System;

namespace Variables
{
    class Literals
    { //our main class

        // Main method
        public static void Main(String[] args)
        {

            // decimal-form literal
            int a = 123;

            // octal-form literal
            int b = 0123;

            // Hexa-decimal form literal
            int c = 0xFace;

            // // binary-form literal
            // int x = 0b123;

            Console.WriteLine(a); //to avoid writing System. – add using System; above all
            Console.WriteLine(b);
            Console.WriteLine(c);
            // System.Console.WriteLine(x);

            char specialSymbol = '\u00C6';
            Console.WriteLine(specialSymbol);

            string escapeChar = "\"\\nText";
            Console.WriteLine(escapeChar);

            // character literal within single quote
            char ch = 'a';

            // Unicode representation
            char cc = '\u0061';

            Console.WriteLine(ch);
            Console.WriteLine(cc);

            // Escape character literal
            Console.WriteLine("Hello\n\nWorld\t!");

            String s = "Hello World!";
            String s2 = @"Hello World!";

            // If we assign without "" then it
            // treats as a variable
            // and causes compiler error
            // String s1 = Hello;

            Console.WriteLine(s);
            Console.WriteLine(s2);

        }
    }
}