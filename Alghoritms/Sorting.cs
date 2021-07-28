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


    }

    public int[] Sorting(int[] L)
    {

        int[] L1 = new int[L.Length];


    }

    public void addElement(int element, ref int[] L1)
    {
        for (int i = 0; i < L1.Length; i++)
        {
            if (element < L1[i])
            {
                L1[i] = element;
            }
        }
    }

    public void shiftToRight(int startPos, ref int[] L1)
    {
        /// 3 4 5 6 7
 
        for (int i = L1.Length; i > startPos; i--)
            L1[i] = L1[i - 1];

    }



}