using System.Configuration;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Data.Sqlite;

namespace WPF_SQLITE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SqliteConnection conn;
        public MainWindow()
        {
            InitializeComponent();

            conn = new SqliteConnection("Data Source=users.db");
            conn.Open();

            loadData();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            var Imie = ImieTextBox.Text;
            var Nazwisko = NazwiskoTextBox.Text;
            var Pesel = PeselTextBox.Text;


            var query = "INSERT INTO users (Imie, Nazwisko, Pesel) VALUES (@Imie, @Nazwisko, @Pesel)";
            var cmd = new SqliteCommand(query, conn);
            cmd.Parameters.AddWithValue("@Imie", Imie);
            cmd.Parameters.AddWithValue("@Nazwisko", Nazwisko);
            cmd.Parameters.AddWithValue("@Pesel", Pesel);
            cmd.ExecuteNonQuery();

            loadData();
        }
        private void loadData()
        {
            var query = "SELECT * FROM users";
            var cmd = new SqliteCommand(query, conn);
            var reader = cmd.ExecuteReader();
            var users = new List<Person>();

            while (reader.Read())
            {
                var person = new Person
                {
                    Id = reader.GetInt32(0),
                    Imie = reader.GetString(1),
                    Nazwisko = reader.GetString(2),
                    Pesel = reader.GetString(3)
                };  
                users.Add(person);
            }
            
            OsobyDataGrid.ItemsSource = users;
        }
        private class Person
        {
            public int Id { get; set; } = 0;
            public string Imie { get; set; } = string.Empty;
            public string Nazwisko { get; set; } = string.Empty;
            public string Pesel { get; set; } = string.Empty;
        }


    }

}