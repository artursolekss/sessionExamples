using System;
using System.Text.RegularExpressions;

public class Assgmn5
{
    public static void Main()
    {
        Console.WriteLine("Please, enter the word to check");
        string text = Console.ReadLine().ToUpper();
        text = Regex.Replace(text, "[^A-Z0-9]", "");
        Console.WriteLine("The text to check:" + text);
        bool palindrome = true;
        for (int i = 0; i < text.Length / 2; i++)         ///MOMTMOM --> length / 2 = 3; middle character can be skipped, since we don't compare it
        {
            if (text[i] != text[text.Length - 1 - i])
            {
                palindrome = false;
                break;//since we do know that it is not th palindrome, we can skip checking further
            }
        }
        Console.WriteLine(palindrome ? "This is palindrome" : "This is not the palindrom");

    }

}