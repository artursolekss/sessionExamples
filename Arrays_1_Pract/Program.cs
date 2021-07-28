using System;

namespace Arrays_1_Pract
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] myArr = { 5, 3, 7, 6, 2, 8 };
            // for (int i = 0; i < myArr.Length; i++)
            // {
            //     Console.Write(myArr[i] + " ");
            // }

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

            foreach (int element in myArray)
                Console.Write(element + " ");
            // int var = 0;
            // while (var < myArr.Length)
            // {
            //     Console.Write(myArr[var++] + " ");
            // }
        }
    }
}
