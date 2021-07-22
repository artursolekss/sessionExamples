using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // //Print the numbers from 1 to 10
            // for (int i = -10; i < 0; i--)
            // {
            //     // for (;true; )
            //     // {
            //     //     Console.WriteLine("Loop");
            //     Console.WriteLine(i);
            //     if (i == -20)
            //         break;//staement can be used to break execution the loop
            // }

            // for (int i = 1; i < 20; i *= 2)
            // {
            //     Console.WriteLine("The current iteraton is : " + i);
            // }
            // for (int i = 0; i < 10; i++)
            // {
            //     for (int j = 0; j < 10 - i; j++)
            //     {
            //         Console.Write("*");
            //     }
            //     Console.Write("\n");
            // }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (j > 8 - i && j < 11 + i)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
        }
    }
}
