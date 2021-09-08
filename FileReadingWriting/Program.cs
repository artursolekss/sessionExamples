using System;

namespace FileReadingWriting
{
    class Program
    {
        static void Main(string[] args)
        {
            // string text = System.IO.File.ReadAllText(@"C:\Users\Arturs Olekss\Documents\NET_lessons\File1.txt");
            // Console.WriteLine(text);
            System.Text.StringBuilder text = new System.Text.StringBuilder();
            while (true)
            {
                Console.WriteLine("Do you want to add the line? (Y/N)");
                string answer = Console.ReadLine();
                if (answer == "Y")
                {
                    string line = Console.ReadLine();
                    text.AppendLine(line);
                }
                else if (answer == "N")
                    break;
                else
                {
                    Console.WriteLine("Input is incorrect, please, repeat");
                    continue;
                }
            }
            Console.WriteLine("Provide the file path");
            string path = Console.ReadLine();
            System.IO.File.WriteAllText(path, text.ToString());
        }
    }
}
