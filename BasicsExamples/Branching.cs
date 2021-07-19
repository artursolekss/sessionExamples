using System;

public class Branching
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("What's your age?");

        // int age;
        // try
        // {
        //     age = Int32.Parse(Console.ReadLine());
        // }
        // catch (FormatException e)
        // {
        //     Console.WriteLine("Only integer number can be entered");
        //     return;
        // }

        // string textAge = Console.ReadLine();///value from the console is read as the text

        int age;
        if (!Int32.TryParse(Console.ReadLine(), out age))
        {
            Console.WriteLine("Only integer number can be entered");
            return;///break the program
        }

        // if (age < 18)
        // {
        //     Console.WriteLine("You can't buy this glass of beer");
        // }
        // else
        // {
        //     Console.WriteLine("What beer you prefer?");
        // }

        Console.WriteLine("What is the drink you prefer?");
        string drinkName = Console.ReadLine();


        if (drinkName.Equals("Whiskey"))
            if (age < 21)
                Console.WriteLine("Sorry, you are too young to buy the Whiskey");
            else
                Console.WriteLine("Please, take your drink");
        else
            Console.WriteLine("Please, take your drink");

        // if (drinkName.Equals("Whiskey") && age < 21)
        // {
        //     Console.WriteLine("You can't buy Whiskey");
        // }
        // else if (drinkName.Equals("Whiskey") && age >= 21)
        // {
        //     Console.WriteLine("Please, take your drink");
        // }
        // else
        // {
        //     Console.WriteLine("We don't have such drink");
        // }

        ///If we have only one action to be executed under if or else statements, than we can skip using the curly brackets
        // if (age < 18)
        //     Console.WriteLine("You can't buy this glass of beer");
        // else
        //     Console.WriteLine("What beer you prefer?");

    }

}
