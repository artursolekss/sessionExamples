using System;
using System.Text.RegularExpressions;

namespace StringsAssgmnt
{
    class Assgmn3
    {

        static void Main(string[] args)
        {
            string text = "Climb mountains not so the world can see you, but so you can see the world";
            string[] words = text.Split(" ");
            string[] alphaNumericalWords = new string[words.Length];
            Console.WriteLine("There are " + words.Length + " words in the sentence");
            int countThe = 0, countS = 0, iter = 0;
            foreach (var word in words)// no difference in this case if we use var or string as the type
            {
                string wordAdjusted = Regex.Replace(word, "[^a-zA-Z0-9]", "").ToLower();
                alphaNumericalWords[iter++] = wordAdjusted;
                if (wordAdjusted.Equals("the"))///the same as word == "the"
                    countThe++;
                if (wordAdjusted.Contains("s"))
                    countS++;
            }

            Console.WriteLine("There are " + countThe + " the in the sentence");
            Console.WriteLine("There are " + countS + " s words in the sentence");

            for (int i = 0; i < alphaNumericalWords.Length - 1; i++)
            {
                for (int j = i + 1; j < alphaNumericalWords.Length; j++)
                {
                    if (alphaNumericalWords[i] == alphaNumericalWords[j])
                    {
                        Console.WriteLine("Word " + alphaNumericalWords[i] + " is repeated");
                        break;
                    }
                }
            }

            Console.WriteLine(text.Replace("you", "You"));
        }

    }

}