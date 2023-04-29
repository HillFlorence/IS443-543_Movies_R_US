using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MovieRentalApp
{
    public partial class MovieInventory : Form
    {
        public MovieInventory()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movieDbDataSet.MOVIE' table. You can move, or remove it, as needed.
            this.mOVIETableAdapter.Fill(this.movieDbDataSet.MOVIE);
            DataSet ds = new DataSet();
            string @movieTitle = textBoxSearchTerm.Text;
            string conString = Properties.Settings.Default.MovieDbConnectionString;
            
            //cmd.Parameters.Add(movieid);
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string sqlQuery = "Select * from MOVIE";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connection);
                System.Data.DataSet dataSet = new System.Data.DataSet();
                dataAdapter.Fill(dataSet, "Movies");

                dataGridView1.DataSource = dataSet.Tables["Movies"];

                connection.Close();
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mOVIETableAdapter.FillBy(this.movieDbDataSet.MOVIE);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //Define needed variables
            DataSet ds = new DataSet(); 

            //Set a variable to the search term entered by user.
            string movieTitle = textBoxSearchTerm.Text;
            //here            //Set restriction if nothing is typed dont proceed


            //Create a connection string that points to the App settings where the DB connection is set.
            string conString = Properties.Settings.Default.MovieDbConnectionString;
            
            //Create the SQL Query
            string sqlQuery = " Select * from MOVIE Where title LIKE @movieTitle";

            //Create SQL connection using the connection string above
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

            //Create SQL Command to execute upon opening the connection.
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, connection);

            //add SQL query parameter to the command. This will prevent SQL Injection
            //Use % to work with LIKE keyword
            sqlCommand.Parameters.AddWithValue("@movieTitle", "%" + movieTitle + "%");

             //Create SQL data adapter to load the data into
             SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
             
             //Create a dataset that will store the data retrieved from SQL query
             System.Data.DataSet dataSet = new System.Data.DataSet();

             //Execute the fill command on data adapter to fill the dataset with a table named "Movies"
             dataAdapter.Fill(dataSet, "Movies");

                //Fill the UI DataGridView with the data in the table "Movie"
                dataGridView1.DataSource = dataSet.Tables["Movies"];

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            //CLose the form
            this.Close();
        }
    }
}
