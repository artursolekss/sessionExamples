using System;

namespace Basics
{
    class SubArray
    {

        static void Main()
        {
            int[] mainArray = { 21, 32, 32, 32, 9123, 17, 18, 14, 237, 18 };
            int countEven = 0;
            foreach (int element in mainArray)
            {
                if (element % 2 == 0)
                    countEven++;
            }

            if (countEven == 0)
                return;///if there no elements for the new array, program to be finished

            int[] evenArray = new int[countEven];
            int index = 0;
            foreach (int element in mainArray)
            {
                if (element % 2 == 0)
                    evenArray[index++] = element;
            }


            int[] subArray = new int[mainArray.Length / 2];
            Array.Copy(mainArray, 0, subArray, 0, mainArray.Length / 2);//the first half of the array

            int[] subArray2 = new int[mainArray.Length / 2];
            int middleIndex = (int)(Math.Ceiling((decimal)mainArray.Length / 2));
            Array.Copy(mainArray, middleIndex, subArray2, 0, mainArray.Length / 2);//the first half of the array

            foreach (int element in evenArray)
                Console.Write(element + " ");

            Console.Write("\n");
            foreach (int element in subArray)
                Console.Write(element + " ");

            Console.Write("\n");
            foreach (int element in subArray2)
                Console.Write(element + " ");

        }

    }

}