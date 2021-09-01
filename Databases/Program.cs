using System;
using MySqlConnector;

namespace Databases
{
    class Program
    {
        static void Main(string[] args)
        {
            // MySqlConnection connection = new MySqlConnection("Data Source=localhost;Database=demodotnet;User ID=root;");
            MySqlConnection connection = new MySqlConnection("Data Source=localhost;User ID=root;");
            connection.Open();

            Console.WriteLine("Coonection with the server is established");
            // var command = new MySqlCommand("SELECT * FROM CUSTOMER", connection); ----if the database is provided in the connection
            var command = new MySqlCommand("SELECT * FROM demodotnet.CUSTOMER", connection); //if the database is not provided in the connection
            var myReader = command.ExecuteReader();
            while (myReader.Read())///if it retur false, than it means that the next entry does not exist
            {///the next entry is read
                Console.WriteLine(myReader.GetInt32(0) + " " + myReader.GetString(1) + " " + myReader.GetString(2) + " " + myReader.GetString(3) + " "
                + myReader.GetString(4));
            }
        }
    }
}
