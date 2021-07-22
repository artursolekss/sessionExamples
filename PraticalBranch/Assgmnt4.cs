using System;

class Assgmnt2
{

    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the year");

        int year, yearDays;
        if (!Int32.TryParse(Console.ReadLine(), out year) || year < 0)
        {
            Console.WriteLine("Input is incorrect");
            return;
        }

        //    The rule is that if the year is divisible by 100 and not divisible by 400, leap year is skipped.
        //     The year 2000 was a leap year, for example, but the years 1700, 1800, and 1900 were not.
        //     The next time a leap year will be skipped is the year 2100.

        if (((year % 100) == 0) && ((year % 400) != 0))
            yearDays = 365;
        else if ((year % 4) == 0)///year division by 4 gives 0 as the remaining part
            yearDays = 366;
        else
            yearDays = 365;

        Console.WriteLine("Please insert the day of the year");

        int days;
        if (!Int32.TryParse(Console.ReadLine(), out days) || days < 1 || days > yearDays)
        {
            Console.WriteLine("Input is incorrect");
            return;
        }

        if (yearDays == 366 && days > (31 + 28))///if this is long year and the day provided is after 28th of February
            days--;///days = days - 1;  in this case the program will consider 29th of Feabruary as 28th of February

        if (days >= 1 && days <= 31)
        {
            // Console.WriteLine($"The day number is: { days }");
            Console.WriteLine("It is January");
        }
        else if (days >= 32 && days <= 59)
        {
            // Console.WriteLine($"The day number is: { days }");
            Console.WriteLine("It is February");
        }
        else if (days >= 60 && days <= 90)
        {
            // Console.WriteLine($"The day number is: { days }");
            Console.WriteLine("It is March");
        }
        else if (days >= 91 && days <= 120)
        {
            // Console.WriteLine($"The day number is: { days }");
            Console.WriteLine("It is April");
        }
        else if (days >= 121 && days <= 151)
        {
            // Console.WriteLine($"The day number is: { days }");
            Console.WriteLine("It is May");
        }
        else if (days >= 152 && days <= 181)
        {
            // Console.WriteLine($"The day number is: { days }");
            Console.WriteLine("It is June");
        }
        else if (days >= 182 && days <= 212)
        {
            // Console.WriteLine($"The day number is: { days }");
            Console.WriteLine("It is July");
        }
        else if (days >= 213 && days <= 243)
        {
            // Console.WriteLine($"The day number is: { days }");
            Console.WriteLine("It is August");
        }
        else if (days >= 244 && days <= 273)
        {
            // Console.WriteLine($"The day number is: { days }");
            Console.WriteLine("It is September");
        }
        else if (days >= 274 && days <= 304)
        {
            // Console.WriteLine($"The day number is: { days }");
            Console.WriteLine("It is October");
        }
        else if (days >= 305 && days <= 334)
        {
            // Console.WriteLine($"The day number is: { days }");
            Console.WriteLine("It is November");
        }
        else if (days >= 335 && days <= 365)
        {
            // Console.WriteLine($"The day number is: { days }");
            Console.WriteLine("It is December");
        }
    }

}