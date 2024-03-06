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
    public partial class UC_CostomerRecords : UserControl
    {
        public UC_CostomerRecords()
        {
            InitializeComponent();
        }

        private void DGV2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(x==false)
            {
                string user = txtSearch.Text;
                string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\c#\final project\Mobile shop.mdf;Integrated Security=True;Connect Timeout=30";
                string qry = "SELECT * FROM costomer WHERE name='" + user + "'";
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(qry, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "costomer");
                    DGV2.DataSource = ds.Tables["costomer"];
                }
                catch
                {
                    MessageBox.Show("Error occrured");
                }
            }
            else
            {
                string IMEI = txtSearch.Text;
                string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\c#\final project\Mobile shop.mdf;Integrated Security=True;Connect Timeout=30";
                string qry = "SELECT * FROM costomer WHERE IMEI='" + IMEI + "'";
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(qry, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "costomer");
                    DGV2.DataSource = ds.Tables["costomer"];
                }
                catch
                {
                    MessageBox.Show("Error occrured");
                }
            }
           


           
        }
        Boolean x;
        private void txtSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtSearchBy.SelectedIndex==0)
            {
                x = false;
                lableTOSET.Text = "Enter Costomer Name";
            }
            else
            {
                x = true;
                lableTOSET.Text = "Enter IMEI";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\c#\final project\Mobile shop.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT * FROM costomer";

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(qry, constring);
                DataSet ds = new DataSet();
                da.Fill(ds, "costomer");
                DGV2.DataSource = ds.Tables["costomer"];
            }
            catch
            {
                MessageBox.Show("Error occrured");
            }
        }
    }
}
