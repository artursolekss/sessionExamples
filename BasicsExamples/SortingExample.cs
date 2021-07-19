using System;
using System.Collections.Generic;

class SortingExample
{
    static void Main(string[] args)
    {
        double value1, value2, value3;

        Console.WriteLine("Enter value 1:");
        if (!Double.TryParse(Console.ReadLine().Replace(".", ","), out value1))
        {
            Console.WriteLine("Input is incorrect!");
            return;
        }

        Console.WriteLine("Enter value 2:");
        if (!Double.TryParse(Console.ReadLine().Replace(".", ","), out value2))
        {
            Console.WriteLine("Input is incorrect!");
            return;
        }

        Console.WriteLine("Enter value 3:");
        if (!Double.TryParse(Console.ReadLine().Replace(".", ","), out value3))
        {
            Console.WriteLine("Input is incorrect!");
            return;
        }

        // List<double> doubleCol = new List<double>();
        // doubleCol.Add(value1);
        // doubleCol.Add(value2);
        // doubleCol.Add(value3);
        // doubleCol.Sort();

        // doubleCol.Reverse();
        // Console.WriteLine(doubleCol[0] + " " + doubleCol[1] + " " + doubleCol[2]);


        // if (value1 >= value2 && value2 >= value3)
        // {
        //     Console.WriteLine(value1 + " " + value2 + " " + value3);
        // }
        // else if (value2 >= value1 &&  value1 >= value3)
        // {
        //





        if (value1 > value2)
        {
            if (value1 > value3)
            {
                if (value1 > value2)
                    if (value2 > value3)
                        Console.WriteLine(value1 + " " + value2 + " " + value3);
                    else
                        Console.WriteLine(value1 + " " + value3 + " " + value2);
                else
                    Console.WriteLine(value2 + " " + value1 + " " + value3);
            }
            else
                Console.WriteLine(value3 + " " + value1 + " " + value2);
        }
        else//value2 > value1
        {
            if (value3 > value2)
                Console.WriteLine(value3 + " " + value2 + " " + value1);
            else
            {
                if (value3 > value1)
                    Console.WriteLine(value2 + " " + value3 + " " + value1);
                else
                    Console.WriteLine(value2 + " " + value1 + " " + value3);
            }
        }

    }

}