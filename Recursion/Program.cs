using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = null;
            int numberElements = 0;
            EnterArrayValue(ref myArray, ref numberElements);
            PrintArray(myArray);

        }

        public static void EnterArrayValue(ref int[] myArray, ref int numberElements)
        {
            Console.WriteLine("Enter the element of the array");
            int elementInput;
            // Int32.Parse()/ --does not check if the parsing is sucessfull or not
            if (!Int32.TryParse(Console.ReadLine(), out elementInput))
                return;
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
            EnterArrayValue(ref myArray, ref numberElements);
        }

        public static void PrintArray(int[] arr)
        {
            Console.Write("\n");
            foreach (int element in arr)
                Console.Write(element + " ");
        }
    }
}
