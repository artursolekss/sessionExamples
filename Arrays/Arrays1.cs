using System;

namespace Arrays
{
    class Arrays1
    {
        static void Main(string[] args)
        {
            // int[] arr = { 2, 54, 23, 91 };
            // Console.WriteLine(arr[2]);
            // Console.WriteLine(arr[1]);
            // Console.WriteLine(arr[0]);
            // Console.WriteLine(arr[3]);

            // string[] arr = new string[5];
            // int elemtnPosi = 0;
            // AddNewElement(elemtnPosi, ref arr);
            // AddNewElement(1, ref arr);
            // AddNewElement(2, ref arr);
            // AddNewElement(3, ref arr);
            // AddNewElement(4, ref arr);
            // AddNewElement(5, ref arr);CAN'T DO THIS, BECAUSE THERE ARE 5 CELLS ONLY!

            // Console.WriteLine(arr[0] + arr[1] + arr[2] + arr[3] + arr[4]);

            Console.WriteLine("How many elements of the array there are?");
            int numberOfElements;
            if (!Int32.TryParse(Console.ReadLine(), out numberOfElements))
            {
                Console.WriteLine("Wrong input!");
                return;
            }

            string[] arr = new string[numberOfElements];
            for (int i = 0; i < arr.Length; i++)//at this point arr.Length is the same as numberOfElements
                AddNewElement(i, ref arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.Write("\n");

            Console.WriteLine("The lenght of the array is " + arr.Length);

            //2-Dimensional arrays

            //   string[][] arr2Dim = new string[][];///this is not correct
            // string[][] arr2Dim = new string[3][];///this is correct

            // arr2Dim[0] = new string[3];
            // arr2Dim[1] = new string[2];
            // arr2Dim[2] = new string[4];

            // arr2Dim[0][2] = "Here is the element";
            // arr2Dim[2][3] = "Here is another element";

            // string[,] arr2Dim = new string[3, 3];///this is correct

            // arr2Dim[0, 2] = "Here is the element";
            // arr2Dim[2, 2] = "Here is another element";

        }

        public static void AddNewElement(int elementIndex, ref string[] arr)
        {
            Console.WriteLine("Provide the element number " + elementIndex);
            arr[elementIndex] = Console.ReadLine();
        }
    }
}
