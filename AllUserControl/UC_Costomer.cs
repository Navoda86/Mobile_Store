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
    public partial class UC_Costomer : UserControl
    {
        public UC_Costomer()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtGender.Text != "" && txtContact.Text != "" && txtEmail.Text != "" && txtAddress.Text != "" && txtCompany.Text != "" && txtmodel.Text != "" && txtprice.Text != "" && txtImei.Text != "")
            {
                string name = txtName.Text;
                string gender = txtGender.Text;
                int contact =int.Parse(txtContact.Text);
                string email = txtEmail.Text;
                string address = txtAddress.Text;
                string company = txtCompany.Text;
                string model=txtmodel.Text;
                int price = int.Parse(txtprice.Text);
                string IMEI = txtImei.Text;


                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\c#\final project\Mobile shop.mdf;Integrated Security=True;Connect Timeout=30");
                string qry = "INSERT INTO costomer VALUES('" + name + "','" + gender + "'," + contact + ",'" + email + "','" + address + "','" + company + "','" + model + "'," + price + ",'" + IMEI + "')";
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
            { MessageBox.Show("Fill all the Fields"); }
        }

    }
}
