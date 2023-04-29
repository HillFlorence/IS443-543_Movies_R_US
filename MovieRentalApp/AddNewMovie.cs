using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRentalApp
{
    public partial class AddNewMovie : Form
    {
        public AddNewMovie()
        {
            InitializeComponent();
        }

        private void AddNewMovie_Load(object sender, EventArgs e)
        {

        }

        private void buttonCloseAddNewMovie_Click(object sender, EventArgs e)
        {
            //Close the Form
            this.Close();
        }
    }
}
