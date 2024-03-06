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

namespace final_project.AllUserControl
{
    public partial class UC_Deleterecords : UserControl
    {
        public UC_Deleterecords()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string delete = txtDel.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\c#\final project\Mobile shop.mdf;Integrated Security=True;Connect Timeout=30");

            string del = "DELETE FROM newphone WHERE Model_Name='"+delete+"'";
            SqlCommand cmd = new SqlCommand(del, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Records Delete Successfully");
            }
            catch(SqlException se)
            {
                MessageBox.Show("ERROR" + se);
            }
        




        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\c#\final project\Mobile shop.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT * FROM newphone";

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(qry, constring);
                DataSet ds = new DataSet();
                da.Fill(ds, "newphone");
                DGV3.DataSource = ds.Tables["newphone"];
            }
            catch
            {
                MessageBox.Show("Error occrured");
            }
        }
    }
}
