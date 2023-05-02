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

        List<Movie> movies = new List<Movie>();

        private int _CustomerID;
        public delegate void ConstructorFinishedEventHandler();
        public event ConstructorFinishedEventHandler ConstructorFinished;

        public MovieInventory(int customerId)
        {
            _CustomerID = customerId;
            ConstructorFinished?.Invoke();
        }

        public int CustomerID { get; set; }   
        public int rentalPlanID { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            getMovies();

        }

        private void getMovies()
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

            int movieId = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            var movieTitle = dataGridView1.Rows[e.RowIndex].Cells[1].Value;

            movies.Add(new Movie { movie_id = movieId, Title = movieTitle.ToString() });

            this.lstMovies.Items.Add("MovieID: " + movieId.ToString() + " Movie Title: " + movieTitle.ToString());
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            //CLose the form
            this.Close();
        }

        private void buttonSeeMovieListing_Click(object sender, EventArgs e)
        {
            //Create a connection string that points to the App settings where the DB connection is set.
            string conString = Properties.Settings.Default.MovieDbConnectionString;

            //Create the SQL Query
            string sqlQuery = "Select FirstName, LastName, m.movie_id, m.Title from customer c join customer_rental cr on c.CID = cr.CID join MOVIE m on m.movie_id = cr.movie_id" +
                "where cr.CID = @CustomerID";
            //string CustomerID = this.CustomerID;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                // Create a SqlCommand object
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {

                    command.Parameters.AddWithValue("@CustomerID", CustomerID);
                    // Open the connection to the database
                    connection.Open();

                    // Execute the SQL query
                    SqlDataReader reader = command.ExecuteReader();
                    //SqlDataReader reader = command.ExecuteReader();

                    // Read the data returned by the query
                    while (reader.Read())
                    {
                        // Access the data returned by the query
                        string firstName = (string)reader["FirstName"];
                        string lastName = (string)reader["LastName"];
                        int movie_id = (int)reader["movie_id"];
                        string Title = (string)reader["Title"];

                        // Do something with the data
                    }

                    // Close the reader and the connection
                    reader.Close();
                    connection.Close();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            int CustID = CustomerID;


            string conString = Properties.Settings.Default.MovieDbConnectionString;

            using(SqlConnection connection = new SqlConnection(conString))
            {

                connection.Open();
                try
                {


                    foreach (Movie movie in movies)
                    {
                        SqlCommand command = new SqlCommand("sp_insert_customer_rentals", connection);

                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter param1 = new SqlParameter("@movie_id", System.Data.SqlDbType.VarChar);
                        param1.Value = movie.movie_id;
                        command.Parameters.Add(param1);

                        SqlParameter param2 = new SqlParameter("@CID", System.Data.SqlDbType.VarChar);
                        param2.Value = CustID;
                        command.Parameters.Add(param2);

                        //SqlParameter param3 = new SqlParameter("@RID", System.Data.SqlDbType.VarChar);
                        //param3.Value = rentalPlanID;
                        //command.Parameters.Add(param3);

                        // command.Parameters.AddWithValue("@movie_id", movie.movie_id);
                        //command.Parameters.AddWithValue("@CID", CustID);
                        //command.Parameters.AddWithValue("@RID", rentalPlanID);

                        //connection.Open();


                        command.ExecuteNonQuery();
                        //connection.Close();

                    }
                    MessageBox.Show("Movie is added to your rental list!");
                }
                catch (SqlException ex)
                {

                   
                    MessageBox.Show("Movie is currently in use! Select another movie! or Maximum number of movies exceeded!");
                    
                }
                connection.Close();
            }
            lstMovies.Items.Clear();

        }


    }
    }
