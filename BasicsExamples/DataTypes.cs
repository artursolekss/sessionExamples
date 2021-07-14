using System;

namespace Basics
{
    class DataTypes
    {
        static void Main(string[] args)
        {
            int variableName, test;
            string var1, var2;
            char male = 'M',female = 'F';
            int maleNum = 'M';
            int femaleNum = 'F';
            Console.WriteLine(maleNum);
            Console.WriteLine(femaleNum);
            char maleFromInt = (char)77;
            char femaleFromInt = (char)70;
            Console.WriteLine(maleFromInt);
            Console.WriteLine(femaleFromInt);

            var1 = "Part1";
            var2 = "Part2";
            variableName = 2;
            variableName += 3;
            test = 4;
            int result = variableName + test;
            Console.WriteLine(result);
            string resultString = var1 + var2;
            Console.WriteLine(resultString);
            int bothGenders = male + female;
            Console.WriteLine(bothGenders);

            bool testBool = true;
            Console.WriteLine(testBool == false);

            test = 5;
            bool compareResults = variableName == test;
            Console.WriteLine(compareResults);

            int mainInt = 23;
            double varDoublFromInt = mainInt;
            Console.WriteLine(varDoublFromInt);
            double varDoubl = 2.85;
            int varInt = (int)varDoubl;
            Console.WriteLine(varInt);

            string numberText = "23232";
            int simpleInteger = Int32.Parse(numberText);
            Console.WriteLine(simpleInteger);
        }
    }
}