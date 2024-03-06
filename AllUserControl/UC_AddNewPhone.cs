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
    public partial class UC_AddNewPhone : UserControl
    {
        public UC_AddNewPhone()
        {
            InitializeComponent();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCompany.Text != "" && txtModelName.Text != "" && txtRam.Text != "" && txtInternal.Text != "" && txtInternal.Text != "" && txtExpandable.Text != "" && txtDisplay.Text != "" && txtRear.Text != "" && txtFront.Text != "" && txtFingerprint.Text != "" && txtSim.Text != "" && txtNetwork.Text != "" && txtPrice.Text != "")
            {
                string company = txtCompany.Text;
                string model = txtModelName.Text;
                string ram = txtRam.Text;
                string intel = txtInternal.Text;
                string expandable = txtExpandable.Text;
                string display = txtDisplay.Text;
                string rear = txtRear.Text;
                string front = txtFront.Text;
                string fringerprint = txtFingerprint.Text;
                string sim = txtSim.Text;
                string network = txtNetwork.Text;
                int price = int.Parse(txtPrice.Text);

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\c#\final project\Mobile shop.mdf;Integrated Security=True;Connect Timeout=30");
                string qry = "INSERT INTO newphone VALUES('" + company + "','" + model + "','" + ram + "','" + intel + "','" + expandable + "','" + display + "','" + rear + "','" + front + "','" + fringerprint + "','" + sim + "','" + network + "'," + price + ")";
                SqlCommand cmd = new SqlCommand(qry, con);


                try
                {

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted Successfully");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error Occured" + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Fill all the Fields");
            }
            















        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCompany.Text = "";
            txtModelName.Text = "";
            txtRam.Text = "";
            txtInternal.Text = "";
            txtExpandable.Text = "";
            txtFront.Text = "";
            txtRear.Text = "";
            txtSim.Text = "";
            txtNetwork.Text = "";
            txtPrice.Text = "";
            txtFingerprint.Text = "";
            txtDisplay.Text= "";

        }
    }
}
