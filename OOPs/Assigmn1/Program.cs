using System;

namespace Assigmn1
{
    class Program
    {
        static void Main(string[] args)
        {
            Officer officer1 = new Officer();
            officer1.setCrimesSolved(10);
            officer1.setName("Jack");
            officer1.setSurname("Tall");
            officer1.setOfficerId(833232);
            officer1.setWorkingDistrict("District 1");
            Console.WriteLine(officer1 + "\n");// the method ToString will be called

            Officer officer2 = new Officer();
            officer2.setCrimesSolved(60);
            officer2.setName("Thom");
            officer2.setSurname("Ricchy");
            officer2.setOfficerId(9374232);
            officer2.setWorkingDistrict("District 2");
            Console.WriteLine(officer2 + "\n");

            Officer officer3 = new Officer("John", "Oliverio", "Disctrict 1", 8723232, 38);
            Console.WriteLine(officer3);

            Officer[] District99 = new Officer[4];
            District99[0] = officer1;
            District99[1] = officer2;
            District99[2] = officer3;

            Console.WriteLine("There are " + Officer.getCountByLevel(1, District99) +
            " officers with level 1 in District99");

            Console.WriteLine("There are " + Officer.getCountByLevelMore(1, District99) +
            " officers with level greater than 1 in District99");

            Console.WriteLine(Officer.checkNameExist("John", District99) ? "There is the officer John in Disctrict"
             : "There is no John in district");


            Console.WriteLine("Creating a new officer...");
            Officer myNewOfficer = new Officer();

            Console.WriteLine("Enter the Name");
            myNewOfficer.setName(Console.ReadLine());

            Console.WriteLine("Enter the Surname");
            myNewOfficer.setSurname(Console.ReadLine());

            Console.WriteLine("Enter Working District");
            myNewOfficer.setWorkingDistrict(Console.ReadLine());

            Console.WriteLine("Enter Officer Id");
            while (true)
            {

                int officerId = -1;//-1 can be used as NOT FOUND
                if (Int32.TryParse(Console.ReadLine(), out officerId))
                {
                    myNewOfficer.setOfficerId(officerId);
                    break;
                }
                else
                    Console.WriteLine("Value entered is not correct, please, try again");
            }

            Console.WriteLine("Enter Crimes Solved number");
            while (true)
            {

                int crimesSolved = -1;//-1 can be used as NOT FOUND
                if (Int32.TryParse(Console.ReadLine(), out crimesSolved))
                {
                    myNewOfficer.setCrimesSolved(crimesSolved);
                    break;
                }
                else
                    Console.WriteLine("Value entered is not correct, please, try again");
            }

            District99[3] = myNewOfficer;
            Console.WriteLine(myNewOfficer);

            myNewOfficer.WorkingDistrict = "Test district";
            Console.WriteLine("Working district repeat " + myNewOfficer.WorkingDistrict);

            Disctrict disctrict = new Disctrict(3);
            disctrict.addOfficerToDistrict(myNewOfficer);
            disctrict.addOfficerToDistrict(officer2);
            disctrict.addOfficerToDistrict(officer1);
            disctrict.removeOfficerFromDistrict(officer2);
            Console.WriteLine(disctrict.getNumberOfOfficerInDistrict());

        }

    }
}
