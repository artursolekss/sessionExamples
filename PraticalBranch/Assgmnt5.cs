using System;

class Assgmnt5
{
    static void Main(string[] args)
    {
        double workingHoursInDay, ratePerDay;
        Console.WriteLine("Enter the working hours per day");
        if (!Double.TryParse(Console.ReadLine(), out workingHoursInDay))
        {
            Console.WriteLine("Input is incorrect");
            return;
        }

        if (workingHoursInDay < 0 || workingHoursInDay > 24)
        {
            Console.WriteLine("Working hours value is incorrect");
            return;
        }

        if (workingHoursInDay <= 8)
            ratePerDay = workingHoursInDay * 10;
        else
            ratePerDay = 80 + ((workingHoursInDay - 8) * 15);

        Console.WriteLine("Rate per day = " + ratePerDay + " euros");
    }

}