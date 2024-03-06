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
    public partial class UC_Stock : UserControl
    {
        public UC_Stock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\c#\final project\Mobile shop.mdf;Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT * FROM newphone";

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(qry, constring);
                DataSet ds = new DataSet();
                da.Fill(ds, "newphone");
                DGV1.DataSource = ds.Tables["newphone"];
            }
            catch
            {
                MessageBox.Show("Error occrured");
            }
        }
    }
}
