using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRentalApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //logic to verify user identity/authenticate.

            // Login 
            Form frmLogin = new Login();
            Form fromMovieListing = new MovieListing();

            frmLogin.Close(); // OR this.Hide();
            fromMovieListing.Show();           
            
            //Show Message they cannot Login
            //*****************************

            
            string conString = Properties.Settings.Default.MovieDbConnectionString;
           
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            string sqlQuery = "SELECT COUNT(*) FROM CUSTOMER WHERE Username=@Username AND Password=@Password";

            using (SqlConnection connection = new SqlConnection(conString))
            
            {
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                if (count > 0) 
                {
                    MessageBox.Show("Login successful");
                    this.Hide();
                    Form frm = new MovieInventory();
                    frm.Show();

                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
        }

        private void buttonClose2_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }

        private void labelSlogan2_Click(object sender, EventArgs e)
        {

        }

        private void labelUserName_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            AddNewUser addNewUser = new AddNewUser();
            Login login = new Login();
            login.Close();
            addNewUser.Show();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
        }
    }
    
}
