using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantTrackerWinForm
{
    public partial class Form1 : Form
    {
        List<Restaurant> restaurants = new List<Restaurant>();
        private string connectionString;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["RestaurantDBConnectionString"].ConnectionString;
            LoadData();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Restaurant newRestaurant = new Restaurant();
            newRestaurant.Name = nameTextBox.Text;
            newRestaurant.Cuisine = cuisineComboBox.Text;
            newRestaurant.City = cityTextBox.Text;
            newRestaurant.State = stateComboBox.Text;
            newRestaurant.BeenThere = beenThereCheckBox.Checked;
            newRestaurant.Rating = (int)ratingNumericUpDown.Value;
            restaurants.Add(newRestaurant);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Restaurants (Name, CuisineType, City, State, Visited, Rating) VALUES (@Name, @CuisineType, @City, @State, @Visited, @Rating)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Name", newRestaurant.Name);
                command.Parameters.AddWithValue("@CuisineType", newRestaurant.Cuisine);
                command.Parameters.AddWithValue("@City", newRestaurant.City);
                command.Parameters.AddWithValue("@State", newRestaurant.State);
                command.Parameters.AddWithValue("@Visited", newRestaurant.BeenThere);
                command.Parameters.AddWithValue("@Rating", newRestaurant.Rating);

                connection.Open();
                command.ExecuteNonQuery();
            }
            LoadData();
        }
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Restaurants";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }
    }
}
