using System;
using System.Collections.Generic;
using MySqlConnector;
using System.Data.SqlClient;
using System.Data;

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

            LinkedList<Disctrict> disctrictsEntered = new LinkedList<Disctrict>();
            if (answer == "Y")
                EnterDistricts(disctrictsEntered);//add one collection into another

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

            LinkedList<Officer> officersEntered = new LinkedList<Officer>();
            if (answer == "Y")
                EnterOfficers(officersEntered);

            SetEntriesToDatabase(officersEntered, disctrictsEntered);
        }

        static void SetEntriesToDatabase(LinkedList<Officer> officers, LinkedList<Disctrict> districts)
        {

            MySqlConnection connection = new MySqlConnection("Data Source=localhost;Database=officersindistrict;User ID=root;");
            connection.Open();

            // var transaction = connection.BeginTransaction();

            if (districts.Count > 0)
            {
                string insertDistrictsSQLQuery = "INSERT INTO district (name,external_id) VALUES (@name,@externalId)";

                MySqlParameter nameParam = new MySqlParameter("@name", SqlDbType.Text);
                MySqlParameter extIdParam = new MySqlParameter("@externalId", SqlDbType.Int);

                var command = new MySqlCommand(insertDistrictsSQLQuery, connection);
                command.Parameters.Add(extIdParam);
                command.Parameters.Add(nameParam);

                foreach (var district in districts)
                {
                    command.Parameters[0].Value = district.GetExternalId();
                    command.Parameters[1].Value = district.GetName();

                    command.Prepare();
                    command.ExecuteNonQuery();
                }
                // transaction.Commit();
            }

            if (officers.Count > 0)
            {
                string insertDistrictsSQLQuery = "INSERT INTO officers (name, surname, working_district, crimes_solved)"
                + "VALUES (@name,@surname,@working_district,@crimes_solved)";

                MySqlParameter nameParam = new MySqlParameter("@name", SqlDbType.Text);
                MySqlParameter surnameParam = new MySqlParameter("@surname", SqlDbType.Text);
                MySqlParameter working_districtParam = new MySqlParameter("@working_district", SqlDbType.Int);
                MySqlParameter crimesSolvedParam = new MySqlParameter("@crimes_solved", SqlDbType.Int);

                var command = new MySqlCommand(insertDistrictsSQLQuery, connection);
                command.Parameters.Add(nameParam);
                command.Parameters.Add(surnameParam);
                command.Parameters.Add(working_districtParam);
                command.Parameters.Add(crimesSolvedParam);

                foreach (var officer in officers)
                {
                    command.Parameters[0].Value = officer.getName();
                    command.Parameters[1].Value = officer.getSurname();
                    command.Parameters[2].Value = officer.WorkingDistrictExtId;
                    command.Parameters[3].Value = officer.getCrimesSolved();

                    command.Prepare();
                    command.ExecuteNonQuery();
                }
                // transaction.Commit();
            }

        }
        static void EnterDistricts(LinkedList<Disctrict> disctrictsEntered)
        {
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
        }

        static void EnterOfficers(LinkedList<Officer> officersEntered)
        {
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
        }
    }
}
