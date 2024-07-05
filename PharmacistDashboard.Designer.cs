namespace PharmacyManagementSystem
{
    partial class PharmacistDashboard
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPhamacistsPortal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sellreportButton = new System.Windows.Forms.Button();
            this.SellButton = new System.Windows.Forms.Button();
            this.pB2PhamacistsPortal = new System.Windows.Forms.PictureBox();
            this.lblPhamacistsName = new System.Windows.Forms.Label();
            this.btnUpdateMedicine = new System.Windows.Forms.Button();
            this.btnViewMedicine = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.bodyPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB2PhamacistsPortal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Honeydew;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(986, 720);
            this.panel4.TabIndex = 3;
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddMedicine.Location = new System.Drawing.Point(0, 0);
            this.btnAddMedicine.Margin = new System.Windows.Forms.Padding(30);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(214, 64);
            this.btnAddMedicine.TabIndex = 2;
            this.btnAddMedicine.Text = "Add Medicine";
            this.btnAddMedicine.UseVisualStyleBackColor = true;
            this.btnAddMedicine.Click += new System.EventHandler(this.addMedicineButton_Click);
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
            this.panel2.TabIndex = 4;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Salmon;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblPhamacistsPortal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(986, 48);
            this.panel3.TabIndex = 4;
            // 
            // lblPhamacistsPortal
            // 
            this.lblPhamacistsPortal.AutoSize = true;
            this.lblPhamacistsPortal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhamacistsPortal.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblPhamacistsPortal.Location = new System.Drawing.Point(352, 7);
            this.lblPhamacistsPortal.Name = "lblPhamacistsPortal";
            this.lblPhamacistsPortal.Size = new System.Drawing.Size(268, 33);
            this.lblPhamacistsPortal.TabIndex = 0;
            this.lblPhamacistsPortal.Text = "Phamacists Portal";
            this.lblPhamacistsPortal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(149)))));
            this.panel1.Controls.Add(this.sellreportButton);
            this.panel1.Controls.Add(this.SellButton);
            this.panel1.Controls.Add(this.pB2PhamacistsPortal);
            this.panel1.Controls.Add(this.lblPhamacistsName);
            this.panel1.Controls.Add(this.btnUpdateMedicine);
            this.panel1.Controls.Add(this.btnViewMedicine);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnAddMedicine);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
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
            this.sellreportButton.TabIndex = 12;
            this.sellreportButton.Text = "Report";
            this.sellreportButton.UseVisualStyleBackColor = true;
            this.sellreportButton.Click += new System.EventHandler(this.sellreportButton_Click);
            // 
            // SellButton
            // 
            this.SellButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SellButton.Location = new System.Drawing.Point(0, 192);
            this.SellButton.Margin = new System.Windows.Forms.Padding(30);
            this.SellButton.Name = "SellButton";
            this.SellButton.Size = new System.Drawing.Size(214, 64);
            this.SellButton.TabIndex = 11;
            this.SellButton.Text = "Sell";
            this.SellButton.UseVisualStyleBackColor = true;
            this.SellButton.Click += new System.EventHandler(this.SellButton_Click);
            // 
            // pB2PhamacistsPortal
            // 
            this.pB2PhamacistsPortal.Image = global::PharmacyManagementSystem.Properties.Resources.new_user;
            this.pB2PhamacistsPortal.Location = new System.Drawing.Point(29, 672);
            this.pB2PhamacistsPortal.Margin = new System.Windows.Forms.Padding(2);
            this.pB2PhamacistsPortal.Name = "pB2PhamacistsPortal";
            this.pB2PhamacistsPortal.Size = new System.Drawing.Size(21, 21);
            this.pB2PhamacistsPortal.TabIndex = 0;
            this.pB2PhamacistsPortal.TabStop = false;
            // 
            // lblPhamacistsName
            // 
            this.lblPhamacistsName.AutoSize = true;
            this.lblPhamacistsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhamacistsName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPhamacistsName.Location = new System.Drawing.Point(54, 673);
            this.lblPhamacistsName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhamacistsName.Name = "lblPhamacistsName";
            this.lblPhamacistsName.Size = new System.Drawing.Size(147, 20);
            this.lblPhamacistsName.TabIndex = 10;
            this.lblPhamacistsName.Text = "PhamacistsName";
            // 
            // btnUpdateMedicine
            // 
            this.btnUpdateMedicine.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateMedicine.Location = new System.Drawing.Point(0, 128);
            this.btnUpdateMedicine.Margin = new System.Windows.Forms.Padding(30);
            this.btnUpdateMedicine.Name = "btnUpdateMedicine";
            this.btnUpdateMedicine.Size = new System.Drawing.Size(214, 64);
            this.btnUpdateMedicine.TabIndex = 9;
            this.btnUpdateMedicine.Text = "Update Medicine";
            this.btnUpdateMedicine.UseVisualStyleBackColor = true;
            this.btnUpdateMedicine.Click += new System.EventHandler(this.updateMedicineButton_Click);
            // 
            // btnViewMedicine
            // 
            this.btnViewMedicine.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewMedicine.Location = new System.Drawing.Point(0, 64);
            this.btnViewMedicine.Margin = new System.Windows.Forms.Padding(30);
            this.btnViewMedicine.Name = "btnViewMedicine";
            this.btnViewMedicine.Size = new System.Drawing.Size(214, 64);
            this.btnViewMedicine.TabIndex = 8;
            this.btnViewMedicine.Text = "View Medicine";
            this.btnViewMedicine.UseVisualStyleBackColor = true;
            this.btnViewMedicine.Click += new System.EventHandler(this.viewMedicineButton_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.Location = new System.Drawing.Point(0, 701);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(214, 59);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // PharmacistDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "PharmacistDashboard";
            this.Size = new System.Drawing.Size(1200, 768);
            this.panel2.ResumeLayout(false);
            this.bodyPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB2PhamacistsPortal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPhamacistsPortal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdateMedicine;
        private System.Windows.Forms.Button btnViewMedicine;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblPhamacistsName;
        private System.Windows.Forms.PictureBox pB2PhamacistsPortal;
        private System.Windows.Forms.Button sellreportButton;
        private System.Windows.Forms.Button SellButton;
    }
}
