using System;

public class BranchingSwitch
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Please, enter dice result:");
        int dice = Int32.Parse(Console.ReadLine());
        switch (dice)
        {
            case 1:
                Console.WriteLine("you earned 1 candy");
                break;
            case 2:
                Console.WriteLine("you earned 2 candies");
                break;
            case 3:
                Console.WriteLine("you earned 3 candies");
                break;
            case 4:
                Console.WriteLine("you earned 4 candies");
                break;
            case 5:
                Console.WriteLine("you earned 5 candies");
                break;
            case 6:
                Console.WriteLine("you earned 6 candies");
                break;
            default:
                Console.WriteLine("Error! This dice can only have 1 - 6 dots!");
                break;
        }

    }
}
