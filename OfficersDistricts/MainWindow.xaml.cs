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
        private LinkedList<District> districtList = new LinkedList<District>();
        private MySqlConnection connection = new MySqlConnection("Data Source=localhost;Database=officersindistrict;User ID=root;");
        public MainWindow()
        {
            InitializeComponent();
            this.connection.Open();
            this.setEntriesFromDB();
            this.connection.Close();
            this.connection.Open();
            this.setPossibleDistricts();
            this.connection.Close();
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

        private void setPossibleDistricts()
        {
            string districtsSelect = "SELECT name,external_id FROM district";
            var command = new MySqlCommand(districtsSelect, this.connection);
            var districtsReader = command.ExecuteReader();
            while (districtsReader.Read())
            {
                District district = new District(districtsReader.GetString(0), districtsReader.GetInt32(1));
                this.districtList.AddLast(district);
                this.WorkingDistrict.Items.Add(district);
            }
        }

        private void AddOfficer(object sender,RoutedEventArgs e)
        {
            this.AddOfficersToDatabase();
            this.officers.Items.Clear();
            this.connection.Open();
            this.setEntriesFromDB();
        }

        private void AddOfficersToDatabase()
        {
            this.connection.Open();
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

            command.Parameters[0].Value = this.Name.Text;
            command.Parameters[1].Value = this.Surname.Text;
            District district = (District) this.WorkingDistrict.SelectedItem;
            command.Parameters[2].Value = district.WorkingDistrictExtId;
            command.Parameters[3].Value = Int32.Parse(this.CrimesSolved.Text);
            command.Prepare();
            command.ExecuteNonQuery();
            this.connection.Close();
        }
    }
}

class District
{
    private string name;
    private int extId;

    public int WorkingDistrictExtId
    {
        get { return this.extId; }
        set { this.extId = value; }
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public District(string name,int id)
    {
        this.name = name;
        this.extId = id;
    }

    public override string ToString()
    {
        return this.Name;
    }

}
