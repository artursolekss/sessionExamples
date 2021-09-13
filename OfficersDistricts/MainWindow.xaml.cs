using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.Generic;
using MySqlConnector;
using System.Data.SqlClient;
using System.Data;

namespace OfficersDistricts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private LinkedList<Officer> officersList = new LinkedList<Officer>();
        private MySqlConnection connection = new MySqlConnection("Data Source=localhost;Database=officersindistrict;User ID=root;");
        public MainWindow()
        {
            InitializeComponent();
            this.connection.Open();
            this.setEntriesFromDB();
        }

        private void setEntriesFromDB()
        {
            string officersSelectQuery = "SELECT officers.id, officers.name, officers.surname,district.name," +
             "officers.crimes_solved FROM officers INNER JOIN district on district.external_id = officers.working_district";
            var command = new MySqlCommand(officersSelectQuery, this.connection);
            var officersReader = command.ExecuteReader();
            while (officersReader.Read())
            {
                Officer officer = new Officer();
                officer.setName(officersReader.GetString(1));
                officer.setSurname(officersReader.GetString(2));
                officer.WorkingDistrictName = officersReader.GetString(3);
                this.officersList.AddLast(officer);
                this.officers.Items.Add(officer);
            }
        }

        private void AddOfficer(object sender,RoutedEventArgs e)
        {
            officers.Items.Add(Name.Text + " " + Surname.Text);
        }
    }
}
