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
using System.Data.SqlClient;
using System.Data.Common;
namespace Project1_AdonetCustomer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=KERECI\\SQLEXPRESS;Initial Catalog=DbCustermer;Integrated Security=True;");

        private void btnView_Click(object sender, EventArgs e)
        {
            
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * from Tbl_City", sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;   
            sqlConnection.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Insert into Tbl_City (CityName, CityCountry) values (@p1, @p2)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1", txtCityName.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtCountry.Text);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("City Added");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Delete from Tbl_City where CityId=@p1", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1", txtCityId.Text);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("City Deleted");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Update Tbl_City set CityName=@p1, CityCountry=@p2 where CityId=@p3", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1", txtCityName.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtCountry.Text);
            sqlCommand.Parameters.AddWithValue("@p3", txtCityId.Text);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("City Updated");

        }
    }
}
