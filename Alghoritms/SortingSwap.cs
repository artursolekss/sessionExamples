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

/// 3 54 -2 73 18 20 -8

///1.iteration - 3 -2 54 18 20 -8 73 (after the first iteration we always know the largest
                                      /// element will be positioned at he last position) 
///2.iteration - -2 3 18 20 -8 54 73 (after the second iteration we always know 2 largest
                                      /// elements will be positioned at the 2 last positions)   
///3.iteration - -2 3 18 -8 20 54 73 (after the third iteration we always know 3 largest
                                      /// elements will be positioned at the 3 last positions)
///4.iteration - -2 3 -8 18 20 54 73 (after the fourth iteration we always know 4 largest
                                      /// elements will be positioned at the 4 last positions) 
///5.iteration - -2 -8 3 18 20 54 73 (after the fifth iteration we always know 5 largest
                                      /// elements will be positioned at the 5 last positions)  
///6.iteration - -8 -2 3 18 20 54 73 (after the sixth iteration all the elements will be sorted)                                                                                      



        // int key = myArray[0];
        for (int i = 0; i < myArray.Length; i++)
        {
            for (int j = 0; j < myArray.Length - i - 1; j++)///myArray.Length - (myArray.Length - 1) - 1 = 0///the last iteration
                if (myArray[j] > myArray[j + 1])///change to myArray[j] < myArray[j + 1]) to sort in descending order
                {
                    //Swap
                    int key = myArray[j];
                    myArray[j] = myArray[j + 1];
                    myArray[j + 1] = key;
                }

        }

        foreach (int element in myArray)
            Console.Write(element + " ");


    }

}