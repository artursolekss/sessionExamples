using System;

namespace Basics
{
    class StringExamples
    {
        static void Main(string[] args)
        {
            string testStrA = "Part";
            string testStrB = "Part1";
            string testAdd = "1";

            // testStrA = testStrA + testStrB;
            testStrA += "1";
            Console.WriteLine(testStrA.Equals(testStrB));


        }
    }
}