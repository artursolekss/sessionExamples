using System;

class Sorting
{


    static void Main(string[] args)
    {

        int[] myArray = null;
        int numberElements = 0;
        while (true)
        {
            Console.WriteLine("Enter the element of the array");
            int elementInput;
            // Int32.Parse()/ --does not check if the parsing is sucessfull or not
            if (!Int32.TryParse(Console.ReadLine(), out elementInput))
                break;
            else
            {
                if (myArray != null)///it means that it is not the first element we add
                {
                    int[] copyArray = myArray;
                    myArray = new int[++numberElements];///create a new array with the incremented number of the elements
                    copyArray.CopyTo(myArray, 0);
                }
                else
                    myArray = new int[++numberElements];///we are here first time, no array to copy, initialize the array with ONE element

                myArray[(numberElements - 1)] = elementInput;///add the last element
            }
        }
        PrintArray(Sort(myArray));


    }

    public static void PrintArray(int[] arr)
    {
        Console.Write("\n");
        foreach (int element in arr)
            Console.Write(element + " ");
    }

    public static int[] Sort(int[] L)
    {

        int[] L1 = (int[])L.Clone();

        for (int i = 0; i < L1.Length; i++)
        {
            int x = L1[i];
            int j = i;
            while (j > 0 && L1[j - 1] > x)
            {
                L1[j] = L1[j - 1];
                j = j - 1;
            }
            L1[j] = x;
        }

        return L1;

    }

}