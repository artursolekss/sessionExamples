using System;

class Assgmnt2
{

    static void Main(string[] args)
    {
        int time;
        Console.WriteLine("Please, provide the time:");
        if (!Int32.TryParse(Console.ReadLine(), out time) || time < 0 || time > 24)
        {
            Console.WriteLine("Input is incorrect!");
            return;
        }

        if (time < 12)
            Console.WriteLine("Good Morning Sunshine!");
        else if (time >= 13 && time <= 19)
            Console.WriteLine("Good Afternoon. Work Hard!");
        else
            Console.WriteLine("Good Evening. Get some rest!");




    }

}