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
            SqlConnection sqlConnection = new SqlConnection("Server=KERECI\\SQLEXPRESS; Initial Catalog=DbCustemer; Integrated Security=True;\r\n");   

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * from Tbl_Customer", sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;   
            sqlConnection.Close();
        }
    }
}
