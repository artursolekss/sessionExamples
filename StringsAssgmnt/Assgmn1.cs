using System;
using System.Text.RegularExpressions;

namespace StringsAssgmnt
{
    class Assgmn1
    {
       public static void Main()  
        {  
            string userInput;
    	    Console.Write("Input the string : ");
    	    userInput = Console.ReadLine();
   	        Console.Write("The string you entered is : {0}\n", userInput);
            int count = 0;
            foreach (char element in userInput)
            {
              if(Char.IsLetter(element))
            // if(Regex.IsMatch(userInput,"[a-zA-Z]"))
                count++;
            }   
            Console.WriteLine("The length of the string is " + count);

            for (int i = userInput.Length-1; i >= 0; i--){
                Console.Write(userInput[i]);
            }

            Console.Write("\n");
            string[] wordsInString = userInput.Split(" ");

            int countWords = wordsInString.Length;
            foreach(string word in wordsInString){
                if(Regex.IsMatch(word,"^[0-9]+$") ||//
                Regex.IsMatch(word,"[0-9]+\\.[0-9]+$"))
                  countWords--;
            }
            
            Console.WriteLine("There are " + countWords + " words in the string");
        }

    }

}