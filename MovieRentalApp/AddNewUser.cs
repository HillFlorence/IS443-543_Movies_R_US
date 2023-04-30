using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRentalApp
{
    public partial class AddNewUser : Form
    {
        public AddNewUser()
        {
            InitializeComponent();
        }

        private void buttonClose3_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }

        private void buttonCreateMyAccount_Click(object sender, EventArgs e)
        {
            string conString = Properties.Settings.Default.MovieDbConnectionString;
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            string insertQuery = "INSERT INTO customer(username, password, email, phone_number, street_address, city, state, FirstName, LastName) VALUES (@username, @password, @email, @phone_number, @street_address, @city, @state, @FirstName, @LastName)";
            SqlCommand command = new SqlCommand(insertQuery, connection);
            command.Parameters.AddWithValue("@username", textboxUsername.Text);
            command.Parameters.AddWithValue("@password", textboxPassword.Text);
            command.Parameters.AddWithValue("@email", textboxEmail.Text);
            command.Parameters.AddWithValue("@phone_number", textboxPhoneNumber.Text);
            command.Parameters.AddWithValue("@street_address", textboxStreetAddress.Text);
            command.Parameters.AddWithValue("@city", textboxCity.Text);
            command.Parameters.AddWithValue("@state", textboxState.Text);
            command.Parameters.AddWithValue("@FirstName", textboxFirstName.Text);
            command.Parameters.AddWithValue("@LastName", textboxLastName.Text);
            command.ExecuteNonQuery();
            connection.Close();
            textboxUsername.Clear();
            textboxPassword.Clear();
            textboxEmail.Clear();
            textboxPhoneNumber.Clear();
            textboxStreetAddress.Clear();
            textboxCity.Clear();
            textboxState.Clear();
            textboxFirstName.Clear();
            textboxLastName.Clear();


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            AddNewUser addNewUser = new AddNewUser();
            addNewUser.Close();
            login.Show();
        }
    }
}
