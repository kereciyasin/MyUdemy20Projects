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

namespace Project1_AdonetCustomer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void btnView_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Server=KERECI\\SQLEXPRESS; initial catalog=DbCustomer; integrated security=true");   

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * from TblCustomer", sqlConnection);
            sqlConnection.Close();
        }
    }
}
