
namespace final_project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCostomer = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnCostomerRecords = new System.Windows.Forms.Button();
            this.btnAddnewPhone = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse7 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse8 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_First1 = new final_project.AllUserControl.UC_First();
            this.uC_Stock1 = new final_project.AllUserControl.UC_Stock();
            this.uC_Deleterecords1 = new final_project.AllUserControl.UC_Deleterecords();
            this.uC_CostomerRecords1 = new final_project.AllUserControl.UC_CostomerRecords();
            this.uC_Costomer1 = new final_project.AllUserControl.UC_Costomer();
            this.uC_AddNewPhone1 = new final_project.AllUserControl.UC_AddNewPhone();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnCostomer);
            this.panel1.Controls.Add(this.btnStock);
            this.panel1.Controls.Add(this.btnCostomerRecords);
            this.panel1.Controls.Add(this.btnAddnewPhone);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 530);
            this.panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(3, 423);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(197, 49);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "    Delete phone Record";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCostomer
            // 
            this.btnCostomer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCostomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCostomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCostomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCostomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCostomer.Image")));
            this.btnCostomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCostomer.Location = new System.Drawing.Point(3, 119);
            this.btnCostomer.Name = "btnCostomer";
            this.btnCostomer.Size = new System.Drawing.Size(197, 49);
            this.btnCostomer.TabIndex = 4;
            this.btnCostomer.Text = "Customers";
            this.btnCostomer.UseVisualStyleBackColor = false;
            this.btnCostomer.Click += new System.EventHandler(this.btnCostomer_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStock.Image = ((System.Drawing.Image)(resources.GetObject("btnStock.Image")));
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Location = new System.Drawing.Point(3, 229);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(197, 49);
            this.btnStock.TabIndex = 3;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnCostomerRecords
            // 
            this.btnCostomerRecords.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCostomerRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCostomerRecords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCostomerRecords.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCostomerRecords.Image = ((System.Drawing.Image)(resources.GetObject("btnCostomerRecords.Image")));
            this.btnCostomerRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCostomerRecords.Location = new System.Drawing.Point(3, 323);
            this.btnCostomerRecords.Name = "btnCostomerRecords";
            this.btnCostomerRecords.Size = new System.Drawing.Size(197, 49);
            this.btnCostomerRecords.TabIndex = 2;
            this.btnCostomerRecords.Text = "     Customer Records";
            this.btnCostomerRecords.UseVisualStyleBackColor = false;
            this.btnCostomerRecords.Click += new System.EventHandler(this.btnCostomerRecords_Click);
            // 
            // btnAddnewPhone
            // 
            this.btnAddnewPhone.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddnewPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddnewPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddnewPhone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddnewPhone.Image = ((System.Drawing.Image)(resources.GetObject("btnAddnewPhone.Image")));
            this.btnAddnewPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddnewPhone.Location = new System.Drawing.Point(3, 18);
            this.btnAddnewPhone.Name = "btnAddnewPhone";
            this.btnAddnewPhone.Size = new System.Drawing.Size(197, 49);
            this.btnAddnewPhone.TabIndex = 1;
            this.btnAddnewPhone.Text = "   Add New Phone";
            this.btnAddnewPhone.UseVisualStyleBackColor = false;
            this.btnAddnewPhone.Click += new System.EventHandler(this.btnAddnewPhone_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(49, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 32);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 32);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 0;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.uC_First1);
            this.panel2.Controls.Add(this.uC_Stock1);
            this.panel2.Controls.Add(this.uC_Deleterecords1);
            this.panel2.Controls.Add(this.uC_CostomerRecords1);
            this.panel2.Controls.Add(this.uC_Costomer1);
            this.panel2.Controls.Add(this.uC_AddNewPhone1);
            this.panel2.Location = new System.Drawing.Point(218, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(989, 624);
            this.panel2.TabIndex = 1;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 0;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 0;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.BorderRadius = 0;
            // 
            // guna2Elipse7
            // 
            this.guna2Elipse7.BorderRadius = 0;
            // 
            // guna2Elipse8
            // 
            this.guna2Elipse8.BorderRadius = 0;
            // 
            // uC_First1
            // 
            this.uC_First1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.uC_First1.Location = new System.Drawing.Point(0, -2);
            this.uC_First1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uC_First1.Name = "uC_First1";
            this.uC_First1.Size = new System.Drawing.Size(989, 626);
            this.uC_First1.TabIndex = 5;
            // 
            // uC_Stock1
            // 
            this.uC_Stock1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uC_Stock1.Location = new System.Drawing.Point(1, 0);
            this.uC_Stock1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uC_Stock1.Name = "uC_Stock1";
            this.uC_Stock1.Size = new System.Drawing.Size(988, 624);
            this.uC_Stock1.TabIndex = 4;
            // 
            // uC_Deleterecords1
            // 
            this.uC_Deleterecords1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uC_Deleterecords1.Location = new System.Drawing.Point(1, 0);
            this.uC_Deleterecords1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uC_Deleterecords1.Name = "uC_Deleterecords1";
            this.uC_Deleterecords1.Size = new System.Drawing.Size(988, 624);
            this.uC_Deleterecords1.TabIndex = 3;
            // 
            // uC_CostomerRecords1
            // 
            this.uC_CostomerRecords1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.uC_CostomerRecords1.Location = new System.Drawing.Point(1, 0);
            this.uC_CostomerRecords1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uC_CostomerRecords1.Name = "uC_CostomerRecords1";
            this.uC_CostomerRecords1.Size = new System.Drawing.Size(988, 624);
            this.uC_CostomerRecords1.TabIndex = 2;
            // 
            // uC_Costomer1
            // 
            this.uC_Costomer1.BackColor = System.Drawing.Color.White;
            this.uC_Costomer1.Location = new System.Drawing.Point(1, 0);
            this.uC_Costomer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uC_Costomer1.Name = "uC_Costomer1";
            this.uC_Costomer1.Size = new System.Drawing.Size(988, 624);
            this.uC_Costomer1.TabIndex = 1;
            // 
            // uC_AddNewPhone1
            // 
            this.uC_AddNewPhone1.BackColor = System.Drawing.Color.White;
            this.uC_AddNewPhone1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uC_AddNewPhone1.Location = new System.Drawing.Point(1, 0);
            this.uC_AddNewPhone1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uC_AddNewPhone1.Name = "uC_AddNewPhone1";
            this.uC_AddNewPhone1.Size = new System.Drawing.Size(988, 624);
            this.uC_AddNewPhone1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1211, 636);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCostomer;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnCostomerRecords;
        private System.Windows.Forms.Button btnAddnewPhone;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse7;
        public System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse8;
        private AllUserControl.UC_AddNewPhone uC_AddNewPhone1;
        private AllUserControl.UC_First uC_First1;
        private AllUserControl.UC_Stock uC_Stock1;
        private AllUserControl.UC_Deleterecords uC_Deleterecords1;
        private AllUserControl.UC_CostomerRecords uC_CostomerRecords1;
        private AllUserControl.UC_Costomer uC_Costomer1;
    }
}

