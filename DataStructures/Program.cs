using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            int assigmntNo = 0;

            Console.WriteLine("Which assigment should be executed?");
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out assigmntNo))
                    break;
                else
                    Console.WriteLine("Please, repeat the input");
            }
            switch (assigmntNo)
            {
                case 1:
                    Assigment1.Start();
                    break;
                case 2:
                    Assigment4.Start();
                    break;
                default:
                    Console.WriteLine("Such assigment does exist");
                    break;
            }

        }
    }
}
