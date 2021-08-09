using System;

public class CountSumArray
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 83, 19, 52, 19, 21 };
        Console.WriteLine(sumElements(arr, arr.Length - 1));
    }

    static int sumElements(int[] arr, int currentPosition)
    {
        if (-1 == currentPosition)///since we need to count the first element (index 0), we will stop when the counter is -1
            return 0;
        else
        {
            int sum = sumElements(arr, --currentPosition);
            Console.WriteLine(sum);
            return arr[currentPosition + 1] + sum;
        }
    }

}