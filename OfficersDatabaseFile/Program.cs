using System;
using System.Collections.Generic;
using MySqlConnector;
using System.Data.SqlClient;
using System.Data;


namespace OfficersDatabaseFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the list separator defined?");
            string separator = Console.ReadLine();

            Console.WriteLine("Do you want to export (E) or import (I) the Officers?");
            string answer = Console.ReadLine();

            MySqlConnection connection = new MySqlConnection("Data Source=localhost;Database=officersindistrict;User ID=root;");
            connection.Open();

            if (answer == "E")
            {
                // string query = "SELECT * FROM officers";
                string query = "SELECT officers.id, officers.name, officers.surname,district.name," +
             "officers.crimes_solved FROM officers INNER JOIN district on district.external_id = officers.working_district";
                var command = new MySqlCommand(query, connection);
                var reader = command.ExecuteReader();
                // Console.Write("ID NAME SURNAME WORKING_DISTRICT CRIMES_SOLVED\n");
                System.Text.StringBuilder fileContent = new System.Text.StringBuilder();
                fileContent.AppendLine("ID" + separator + "NAME" + separator +
                "SURNAME" + separator + "WORKING_DISTRICT" + separator + "CRIMES_SOLVED");
                while (reader.Read())
                {
                    fileContent.Append(reader.GetInt32(0) + separator);
                    fileContent.Append(reader.GetString(1) + separator);
                    fileContent.Append(reader.GetString(2) + separator);
                    fileContent.Append(reader.GetString(3) + separator);
                    fileContent.Append(reader.GetInt32(4) + "\n");
                }
                Console.WriteLine("Provide the file path");
                string path = Console.ReadLine();

                System.IO.File.WriteAllText(path, fileContent.ToString());
            }
            else if (answer == "I")
            {
                LinkedList<Officer> officers = new LinkedList<Officer>();
                Console.WriteLine("Enter the file path");
                string path = Console.ReadLine();
                string fileContect = System.IO.File.ReadAllText(path);

                //At this point let's assume that we know what is the sequnce of the fields in CSV fields.
                string[] officersLines = fileContect.Split("\n");
                foreach (var line in officersLines)
                {
                    Officer officer = new Officer();
                    string[] fields = line.Split(separator);
                    officer.setName(fields[0]);//first element in the CSV file is the name
                    officer.setSurname(fields[1]);
                    officer.setWorkingDistrict(Int32.Parse(fields[2]));
                    officer.setCrimesSolved(Int32.Parse(fields[3]));
                    officers.AddLast(officer);

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
                }

            }
        }
    }
}
