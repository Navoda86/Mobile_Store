using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            uC_AddNewPhone1.Visible = false;
            uC_Costomer1.Visible = false;
            uC_Stock1.Visible = false;
            uC_CostomerRecords1.Visible = false;
            uC_Deleterecords1.Visible = false;
        }

        private void btnAddnewPhone_Click(object sender, EventArgs e)
        {
            uC_AddNewPhone1.Visible = true;
            uC_AddNewPhone1.BringToFront();
        }

        private void uC_AddNewPhone1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCostomer_Click(object sender, EventArgs e)
        {
            uC_Costomer1.Visible = true;
            uC_Costomer1.BringToFront();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            uC_Stock1.Visible = true;
            uC_Stock1.BringToFront();
        }

        private void btnCostomerRecords_Click(object sender, EventArgs e)
        {
            uC_CostomerRecords1.Visible = true;
            uC_CostomerRecords1.BringToFront();
        }

        private void uC_CostomerRecords1_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            uC_Deleterecords1.Visible = true;
            uC_Deleterecords1.BringToFront();
        }

        private void uC_Login1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
