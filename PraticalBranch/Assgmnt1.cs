using System;

class Assgmnt1
{
    static void Main(string[] args)
    {
        int variable1 = 4, variable2 = 3;
        // variable1 > variable2 ? variable1 : variable2; --- this return the value
        // int maxVal = variable1 > variable2 ? variable1 : variable2;
        Console.WriteLine("Largest variable is " + (variable1 > variable2 ? variable1 : variable2));
        ///The same as 
        // if (variable1 > variable2)
        //     Console.WriteLine("Largest variable is " + variable1);
        // else
        //     Console.WriteLine("Largest variable is " + variable2);

        Console.WriteLine("Smallest variable is " + (variable1 < variable2 ? variable1 : variable2));
        Console.WriteLine(variable1 == variable2 ? "The variables are equal" : "The variables are not equal");

        Console.WriteLine(variable1 % 2 == 1 ? ("Value " + variable1 + " is odd") : ("Value " + variable1 + "is even"));
        Console.WriteLine(variable2 % 2 == 1 ? ("Value " + variable2 + " is odd") : ("Value " + variable2 + "is even"));

        if (variable1 < 0)
            Console.WriteLine("Value " + variable1 + " is negative");

        if (variable2 < 0)
            Console.WriteLine("Value " + variable2 + " is negative");

        if (variable1 < 100)
            Console.WriteLine("Value " + variable1 + " is less than 100");

        if (variable2 < 100)
            Console.WriteLine("Value " + variable2 + " is less than 100");

    }

}