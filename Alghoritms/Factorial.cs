using System;

class Factorial
{
    static void Main(string[] args)
    {
        int n;
        if (!Int32.TryParse(args[0], out n))
        {
            Console.WriteLine("Input is incorrect");
            return;
        }
        Console.WriteLine(GetFactorial(n));

    }
    public static int GetFactorial(int n)
    {
        if (n == 1)
            return 1;
        else
            return (n * GetFactorial(n - 1));
    }

}