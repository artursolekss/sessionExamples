using System;

public class ExceptionsExample
{
    public static void Main(string[] args)
    {

        int[] arr = new int[5];

        // arr[6] = 8;  //this will crash
        try
        {
            testCrash(arr);
            // arr[6] = 8;  //the program flow will come from here
        }
        catch (Exception)
        {
            //the program flow will come here
            Console.WriteLine("Something went wrong");
        }
        Console.WriteLine("Here is the finish");
    }

    static void testCrash(int[] arr)
    {
        try
        {
            anotherFunction(arr);
        }
        catch (Exception)///Exception catches all the possible exceptions
        {
            //the program flow will come here
            Console.WriteLine("Something went wrong inside the function testCrash");
        }

    }

    static void anotherFunction(int[] arr)
    {
        try
        {
            int zero = 0;
            int result = 4 / zero;
            arr[6] = 8;///this line will NOT BE TRIGERRED!
        }
        catch (IndexOutOfRangeException)//this catch will ONLY CATCH IndexOutOfRangeException
        {
            //the program flow will come here
            Console.WriteLine("Something went wrong inside the function anotherFunction");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("There was the division by zero");
        }

    }
}