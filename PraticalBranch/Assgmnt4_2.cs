using System;

class Assignment4
{
    public static void Main(string[] args)

    {
        int dayNumber;
        Console.WriteLine("Please write the number of the day");
        if (!Int32.TryParse(Console.ReadLine(), out dayNumber) || dayNumber < 0 || dayNumber > 365)

        {
            Console.WriteLine("Input is incorrect");
            return;
        }

        if (dayNumber >= 1 && dayNumber <= 31)
            Console.WriteLine("It's January");
        else if (dayNumber >= 32 && dayNumber <= 59)
            Console.WriteLine("It's Febuary");
        else if (dayNumber >= 60 && dayNumber <= 90)
            Console.WriteLine("It's March");
        else if (dayNumber >= 91 && dayNumber <= 120)
            Console.WriteLine("It's April");
        else if (dayNumber >= 121 && dayNumber <= 151)
            Console.WriteLine("It's May");
        else if (dayNumber >= 152 && dayNumber <= 181)
            Console.WriteLine("It's June");
        else if (dayNumber >= 182 && dayNumber <= 212)
            Console.WriteLine("It's July");
        else if (dayNumber >= 213 && dayNumber <= 243)
            Console.WriteLine("It's August");
        else if (dayNumber >= 244 && dayNumber <= 273)
            Console.WriteLine("It's September");
        else if (dayNumber >= 274 && dayNumber <= 304)
            Console.WriteLine("It's October");
        else if (dayNumber >= 305 && dayNumber <= 334)
            Console.WriteLine("It's November");
        else if (dayNumber >= 335 && dayNumber <= 365)
            Console.WriteLine("It's December");
    }
}