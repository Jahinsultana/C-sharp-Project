namespace PharmacyManagementSystem
{
    partial class ViewMedicineUserControl
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
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dGVViweMedicine = new System.Windows.Forms.DataGridView();
            this.txtCheck = new System.Windows.Forms.TextBox();
            this.cmbCheck = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblViweMedicine = new System.Windows.Forms.Label();
            this.bodyPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVViweMedicine)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bodyPanel
            // 
            this.bodyPanel.Controls.Add(this.panel4);
            this.bodyPanel.Controls.Add(this.panel3);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(0, 0);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(986, 765);
            this.bodyPanel.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.dGVViweMedicine);
            this.panel4.Controls.Add(this.txtCheck);
            this.panel4.Controls.Add(this.cmbCheck);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(986, 720);
            this.panel4.TabIndex = 4;
            // 
            // dGVViweMedicine
            // 
            this.dGVViweMedicine.AllowUserToAddRows = false;
            this.dGVViweMedicine.AllowUserToDeleteRows = false;
            this.dGVViweMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVViweMedicine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dGVViweMedicine.Location = new System.Drawing.Point(0, 80);
            this.dGVViweMedicine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dGVViweMedicine.Name = "dGVViweMedicine";
            this.dGVViweMedicine.ReadOnly = true;
            this.dGVViweMedicine.RowHeadersWidth = 51;
            this.dGVViweMedicine.RowTemplate.Height = 24;
            this.dGVViweMedicine.Size = new System.Drawing.Size(986, 640);
            this.dGVViweMedicine.TabIndex = 33;
            // 
            // txtCheck
            // 
            this.txtCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheck.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCheck.Location = new System.Drawing.Point(32, 19);
            this.txtCheck.Name = "txtCheck";
            this.txtCheck.Size = new System.Drawing.Size(56, 22);
            this.txtCheck.TabIndex = 32;
            this.txtCheck.Text = "Check";
            // 
            // cmbCheck
            // 
            this.cmbCheck.FormattingEnabled = true;
            this.cmbCheck.Items.AddRange(new object[] {
            "All Medicine",
            "Expired Medicine",
            "Valid Medicine "});
            this.cmbCheck.Location = new System.Drawing.Point(94, 20);
            this.cmbCheck.Name = "cmbCheck";
            this.cmbCheck.Size = new System.Drawing.Size(242, 21);
            this.cmbCheck.TabIndex = 31;
            this.cmbCheck.SelectedIndexChanged += new System.EventHandler(this.validComboBox_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(880, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(62, 23);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(672, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(202, 20);
            this.txtSearch.TabIndex = 29;
            this.txtSearch.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGreen;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblViweMedicine);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(986, 48);
            this.panel3.TabIndex = 1;
            // 
            // lblViweMedicine
            // 
            this.lblViweMedicine.AutoSize = true;
            this.lblViweMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViweMedicine.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblViweMedicine.Location = new System.Drawing.Point(429, 7);
            this.lblViweMedicine.Name = "lblViweMedicine";
            this.lblViweMedicine.Size = new System.Drawing.Size(216, 33);
            this.lblViweMedicine.TabIndex = 0;
            this.lblViweMedicine.Text = "View Medicine";
            this.lblViweMedicine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewMedicineUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bodyPanel);
            this.Name = "ViewMedicineUserControl";
            this.Size = new System.Drawing.Size(986, 765);
            this.bodyPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVViweMedicine)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblViweMedicine;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbCheck;
        private System.Windows.Forms.TextBox txtCheck;
        private System.Windows.Forms.DataGridView dGVViweMedicine;
    }
}
