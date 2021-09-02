using System;
using System.Collections.Generic;

namespace OfficersDistrictDB
{
    class Program
    {
        static void Main(string[] args)
        {

            string answer = "";
            while (true)
            {
                Console.WriteLine("Do you want to enter the disctricts? (Y/N)");
                answer = Console.ReadLine();
                if (answer != "Y" && answer != "N")
                {
                    Console.WriteLine("Incorrect input");
                    continue;
                }
                else
                    break;
            }

            LinkedList<Disctrict> disctrictsEntered;
            if (answer == "Y")
                disctrictsEntered = EnterDistricts();

            answer = "";
            while (true)
            {
                Console.WriteLine("Do you want to enter the officers? (Y/N)");
                answer = Console.ReadLine();
                if (answer != "Y" && answer != "N")
                {
                    Console.WriteLine("Incorrect input");
                    continue;
                }
                else
                    break;
            }

            LinkedList<Officer> officersEntered;
            if (answer == "Y")
                officersEntered = EnterOfficers();
        }

        static LinkedList<Disctrict> EnterDistricts()
        {

            LinkedList<Disctrict> disctrictsEntered = new LinkedList<Disctrict>();
            while (true)//In this loop we fill in all the district from console
            {
                Console.WriteLine("Provide the name of the district:");
                string name = Console.ReadLine();

                int extId = -1;

                while (true)
                {
                    Console.WriteLine("Provide the (external) id of the destrict:");
                    if (!Int32.TryParse(Console.ReadLine(), out extId))
                        Console.WriteLine("Incorrect input");
                    else
                        break;
                }

                Disctrict disctrict = new Disctrict();
                disctrict.SetName(name);
                disctrict.SetExternalId(extId);
                disctrictsEntered.AddLast(disctrict);

                string answer = "";
                while (true)
                {
                    Console.WriteLine("The district is registered. Do you want to continue entering the district? (Y/N)");
                    answer = Console.ReadLine();
                    if (answer != "Y" && answer != "N")
                    {
                        Console.WriteLine("Incorrect input");
                        continue;
                    }
                    else
                        break;
                }

                if (answer.Equals("N"))
                    break;
            }
            return disctrictsEntered;
        }

        static LinkedList<Officer> EnterOfficers()
        {

            LinkedList<Officer> officersEntered = new LinkedList<Officer>();
            while (true)
            {
                Console.WriteLine("Provide the name of the officer:");
                string name = Console.ReadLine();

                Console.WriteLine("Provide the last name of the officer:");
                string lastName = Console.ReadLine();
                int extId = -1;

                while (true)
                {
                    Console.WriteLine("Provide the (external) id of the destrict, where the officer works:");
                    if (!Int32.TryParse(Console.ReadLine(), out extId))
                        Console.WriteLine("Incorrect input");
                    else
                        break;
                }

                int crimesSolvedNumber = -1;
                while (true)
                {
                    Console.WriteLine("Provide the number of crimes solved:");
                    if (!Int32.TryParse(Console.ReadLine(), out crimesSolvedNumber))
                        Console.WriteLine("Incorrect input");
                    else
                        break;
                }
                Officer officer = new Officer();
                officer.setName(name);
                officer.setSurname(lastName);
                officer.setWorkingDistrict(extId);
                officer.setCrimesSolved(crimesSolvedNumber);
                officersEntered.AddLast(officer);

                string answer = "";
                while (true)
                {
                    Console.WriteLine("The officer is registered. Do you want to continue entering the officers? (Y/N)");
                    answer = Console.ReadLine();
                    if (answer != "Y" && answer != "N")
                    {
                        Console.WriteLine("Incorrect input");
                        continue;
                    }
                    else
                        break;
                }

                if (answer.Equals("N"))
                    break;
            }
            return officersEntered;
        }
    }
}
