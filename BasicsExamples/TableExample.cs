using System;

namespace Basics
{
    class TableExample
    {
        static void Main()
        {
            string[,] table = new string[3, 4];
            ///Header row
            table[0, 0] = "Name";
            table[0, 1] = "Surname";
            table[0, 2] = "Date of Birth";
            table[0, 3] = "Eye color";
            ///row 1
            table[1, 0] = "Janis";
            table[1, 1] = "Kalnis";
            table[1, 2] = "19.04.1990";
            table[1, 3] = "Green";
            // row 2
            table[2, 0] = "Uldis";
            table[2, 1] = "Liepins";
            table[2, 2] = "16.03.1995";
            table[2, 3] = "Blue";
            print2DArray(table);
        }

        static void print2DArray(string[,] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.GetLength(i); j++)
                {
                    Console.Write(arr.GetValue(i, j) + " ");
                }
                Console.Write("\n");
            }
        }
    }

}