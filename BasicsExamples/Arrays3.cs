using System;

public class Arrays3
{
    public static void Main(string[] args)
    {

        ///point 1
        byte[] arr = new byte[10];
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter the element " + i);
            while (true)
                if (Byte.TryParse(Console.ReadLine(), out arr[i]) && arr[i] >= 0 && arr[i] <= 10)
                    break;
                else
                    Console.WriteLine("Incorrect! Repeat the input");
        }

        /// point 2
        int failedCount = 0;
        foreach (byte grade in arr)
            if (grade < 4)
                failedCount++;

        Console.WriteLine("There are " + failedCount + " failed students");

        /// point 3
        int countA = 0;
        foreach (byte grade in arr)
            if (grade == 10)
                countA++;

        Console.WriteLine("There are " + countA + " students who got 10");


        ///point 4
        int[] histogram = new int[10];//we have only 10 possible grades
        foreach (byte grade in arr)
            histogram[grade - 1]++;

        for (int i = 0; i < histogram.Length; i++)
            Console.WriteLine(histogram[i] + " students have the grade " + (i + 1));
    }

}