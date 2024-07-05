namespace PharmacyManagementSystem
{
    partial class AdminDashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAdminPortal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sellreportButton = new System.Windows.Forms.Button();
            this.btnViewMedicine = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnViewUser = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.bodyPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Controls.Add(this.bodyPanel);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 768);
            this.panel2.TabIndex = 2;
            // 
            // bodyPanel
            // 
            this.bodyPanel.Controls.Add(this.panel4);
            this.bodyPanel.Controls.Add(this.panel3);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bodyPanel.Location = new System.Drawing.Point(214, 0);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(986, 765);
            this.bodyPanel.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Honeydew;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 45);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 0, 22, 0);
            this.panel4.Size = new System.Drawing.Size(986, 720);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Salmon;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblAdminPortal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(986, 48);
            this.panel3.TabIndex = 4;
            // 
            // lblAdminPortal
            // 
            this.lblAdminPortal.AutoSize = true;
            this.lblAdminPortal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPortal.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblAdminPortal.Location = new System.Drawing.Point(352, 7);
            this.lblAdminPortal.Name = "lblAdminPortal";
            this.lblAdminPortal.Size = new System.Drawing.Size(194, 33);
            this.lblAdminPortal.TabIndex = 0;
            this.lblAdminPortal.Text = "Admin Portal";
            this.lblAdminPortal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(149)))));
            this.panel1.Controls.Add(this.sellreportButton);
            this.panel1.Controls.Add(this.btnViewMedicine);
            this.panel1.Controls.Add(this.btnEditUser);
            this.panel1.Controls.Add(this.btnViewUser);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 81);
            this.panel1.Size = new System.Drawing.Size(214, 768);
            this.panel1.TabIndex = 0;
            // 
            // sellreportButton
            // 
            this.sellreportButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.sellreportButton.Location = new System.Drawing.Point(0, 256);
            this.sellreportButton.Margin = new System.Windows.Forms.Padding(30);
            this.sellreportButton.Name = "sellreportButton";
            this.sellreportButton.Size = new System.Drawing.Size(214, 64);
            this.sellreportButton.TabIndex = 13;
            this.sellreportButton.Text = "Sales Report";
            this.sellreportButton.UseVisualStyleBackColor = true;
            this.sellreportButton.Click += new System.EventHandler(this.sellreportButton_Click);
            // 
            // btnViewMedicine
            // 
            this.btnViewMedicine.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewMedicine.Location = new System.Drawing.Point(0, 192);
            this.btnViewMedicine.Margin = new System.Windows.Forms.Padding(30);
            this.btnViewMedicine.Name = "btnViewMedicine";
            this.btnViewMedicine.Size = new System.Drawing.Size(214, 64);
            this.btnViewMedicine.TabIndex = 10;
            this.btnViewMedicine.Text = "View Inventory";
            this.btnViewMedicine.UseVisualStyleBackColor = true;
            this.btnViewMedicine.Click += new System.EventHandler(this.btnViewMedicine_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditUser.Location = new System.Drawing.Point(0, 128);
            this.btnEditUser.Margin = new System.Windows.Forms.Padding(30);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(214, 64);
            this.btnEditUser.TabIndex = 9;
            this.btnEditUser.Text = "Edit User";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.patientsButton_Click);
            // 
            // btnViewUser
            // 
            this.btnViewUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewUser.Location = new System.Drawing.Point(0, 64);
            this.btnViewUser.Margin = new System.Windows.Forms.Padding(30);
            this.btnViewUser.Name = "btnViewUser";
            this.btnViewUser.Size = new System.Drawing.Size(214, 64);
            this.btnViewUser.TabIndex = 8;
            this.btnViewUser.Text = "View User";
            this.btnViewUser.UseVisualStyleBackColor = true;
            this.btnViewUser.Click += new System.EventHandler(this.doctorsButton_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.Location = new System.Drawing.Point(0, 623);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(214, 64);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddUser.Location = new System.Drawing.Point(0, 0);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(30);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(214, 64);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.receptionistButton_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "AdminDashboard";
            this.Size = new System.Drawing.Size(1200, 768);
            this.panel2.ResumeLayout(false);
            this.bodyPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnViewUser;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblAdminPortal;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnViewMedicine;
        private System.Windows.Forms.Button sellreportButton;
    }
}
