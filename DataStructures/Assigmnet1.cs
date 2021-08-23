using System;
using System.Collections;

namespace DataStructures
{
    class Assigment1
    {

        private static void SortArrList(ArrayList list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    ///swap
                    ///string has CompareTo method, where we can pass anothet string to compare
                    ///if the string passed is smaller, then the value 1 is returned from the method
                    ///if the string passed is greater, then the value -1 is returned
                    ///if the string passed has the same value, then 0 is returned
                    if (((string)list[j]).CompareTo((string)list[j + 1]) > 0)
                    {
                        string current = (string)list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = current;
                    }

                }

            }

        }

        public static void PrintArrayList(ArrayList arrayList)
        {
            foreach (string item in arrayList)
            {
                Console.WriteLine(item + " ");
            }
        }

        public static void Start()
        {
            ///For the array lists objects we do not define the type, so we can put any object/value inside
            ArrayList arrList = new ArrayList();//in other words, we can simply say, that the type "Object" is allowed for the array list elements
            arrList.Add("Computer");
            arrList.Add("Plate");
            arrList.Add("Chair");
            arrList.Add("Girl");
            arrList.Add("Boy");
            arrList.Add("Cat");
            arrList.Add("Dog");
            arrList.Add("Shirt");
            arrList.Add("Determination");

            int countC = 0, countE = 0, count5 = 0, countEexist = 0, countTe = 0;
            int maxLen = 0;
            foreach (string element in arrList)
            {
                if (element[0] == 'C')
                    countC++;
                if (element[element.Length - 1] == 'e')
                    countE++;
                if (element.Length == 5)
                    count5++;
                if (element.Contains("e"))
                    countEexist++;
                if (element.Contains("te"))
                    countTe++;

                if (element.Length > maxLen)
                    maxLen = element.Length;

            }
            int[] histogram = new int[maxLen + 1];///+1 is herer, because the arrays start at 0
            foreach (string element in arrList)
            {
                int prevValue = histogram[element.Length];
                histogram[element.Length] = ++prevValue;
            }

            Console.WriteLine("There are " + countC + " starting with C");
            Console.WriteLine("There are " + countE + " ending with E");
            Console.WriteLine("There are " + count5 + " with the lenght 5");
            Console.WriteLine("There are " + countEexist + " consist of the character e");
            Console.WriteLine("There are " + countTe + " consist of the substring te");

            for (int i = 0; i < histogram.Length; i++)
            {
                Console.WriteLine("There are " + histogram[i] + " words with the length " + i);
            }

            Assigment1.SortArrList(arrList);
            Assigment1.PrintArrayList(arrList);
        }
    }
}
