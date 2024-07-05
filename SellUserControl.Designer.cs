namespace PharmacyManagementSystem
{
    partial class SellUserControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.addtocartButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cartDataGridView = new System.Windows.Forms.DataGridView();
            this.btnSell = new System.Windows.Forms.Button();
            this.quantityNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.txtBoxContact = new System.Windows.Forms.TextBox();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.dGVViweMedicine = new System.Windows.Forms.DataGridView();
            this.txtCheck = new System.Windows.Forms.TextBox();
            this.cmbCheck = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblViweMedicine = new System.Windows.Forms.Label();
            this.bodyPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown1)).BeginInit();
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
            this.panel4.Controls.Add(this.panel1);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.addtocartButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cartDataGridView);
            this.panel1.Controls.Add(this.btnSell);
            this.panel1.Controls.Add(this.quantityNumericUpDown1);
            this.panel1.Controls.Add(this.quantityLabel);
            this.panel1.Controls.Add(this.txtBoxContact);
            this.panel1.Controls.Add(this.txtBoxFirstName);
            this.panel1.Controls.Add(this.lblContact);
            this.panel1.Controls.Add(this.customerNameLabel);
            this.panel1.Controls.Add(this.dGVViweMedicine);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 100, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 665);
            this.panel1.TabIndex = 34;
            // 
            // addtocartButton
            // 
            this.addtocartButton.BackColor = System.Drawing.Color.Green;
            this.addtocartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtocartButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addtocartButton.Location = new System.Drawing.Point(904, 288);
            this.addtocartButton.Name = "addtocartButton";
            this.addtocartButton.Size = new System.Drawing.Size(65, 46);
            this.addtocartButton.TabIndex = 44;
            this.addtocartButton.Text = "Add to Cart";
            this.addtocartButton.UseVisualStyleBackColor = false;
            this.addtocartButton.Click += new System.EventHandler(this.addtocartButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Cart";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "Select From here";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cartDataGridView
            // 
            this.cartDataGridView.AllowUserToAddRows = false;
            this.cartDataGridView.AllowUserToDeleteRows = false;
            this.cartDataGridView.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.cartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cartDataGridView.Location = new System.Drawing.Point(2, 430);
            this.cartDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.cartDataGridView.Name = "cartDataGridView";
            this.cartDataGridView.ReadOnly = true;
            this.cartDataGridView.RowHeadersWidth = 51;
            this.cartDataGridView.RowTemplate.Height = 24;
            this.cartDataGridView.Size = new System.Drawing.Size(798, 231);
            this.cartDataGridView.TabIndex = 41;
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.Green;
            this.btnSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSell.Location = new System.Drawing.Point(800, 603);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(183, 59);
            this.btnSell.TabIndex = 40;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // quantityNumericUpDown1
            // 
            this.quantityNumericUpDown1.Location = new System.Drawing.Point(811, 262);
            this.quantityNumericUpDown1.Name = "quantityNumericUpDown1";
            this.quantityNumericUpDown1.Size = new System.Drawing.Size(158, 20);
            this.quantityNumericUpDown1.TabIndex = 39;
            this.quantityNumericUpDown1.ValueChanged += new System.EventHandler(this.quantityNumericUpDown1_ValueChanged);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.ForeColor = System.Drawing.Color.Black;
            this.quantityLabel.Location = new System.Drawing.Point(817, 243);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(63, 16);
            this.quantityLabel.TabIndex = 38;
            this.quantityLabel.Text = "Quantity";
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxContact
            // 
            this.txtBoxContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxContact.Location = new System.Drawing.Point(811, 166);
            this.txtBoxContact.Name = "txtBoxContact";
            this.txtBoxContact.Size = new System.Drawing.Size(158, 22);
            this.txtBoxContact.TabIndex = 37;
            this.txtBoxContact.TextChanged += new System.EventHandler(this.txtBoxContact_TextChanged);
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFirstName.Location = new System.Drawing.Point(811, 75);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(158, 22);
            this.txtBoxFirstName.TabIndex = 36;
            this.txtBoxFirstName.TextChanged += new System.EventHandler(this.txtBoxFirstName_TextChanged);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.Color.Black;
            this.lblContact.Location = new System.Drawing.Point(817, 135);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(63, 16);
            this.lblContact.TabIndex = 35;
            this.lblContact.Text = "Contact:";
            this.lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.ForeColor = System.Drawing.Color.Black;
            this.customerNameLabel.Location = new System.Drawing.Point(817, 46);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(52, 16);
            this.customerNameLabel.TabIndex = 34;
            this.customerNameLabel.Text = "Name:";
            this.customerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dGVViweMedicine
            // 
            this.dGVViweMedicine.AllowUserToAddRows = false;
            this.dGVViweMedicine.AllowUserToDeleteRows = false;
            this.dGVViweMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVViweMedicine.Location = new System.Drawing.Point(0, 29);
            this.dGVViweMedicine.Margin = new System.Windows.Forms.Padding(2);
            this.dGVViweMedicine.Name = "dGVViweMedicine";
            this.dGVViweMedicine.ReadOnly = true;
            this.dGVViweMedicine.RowHeadersWidth = 51;
            this.dGVViweMedicine.RowTemplate.Height = 24;
            this.dGVViweMedicine.Size = new System.Drawing.Size(798, 354);
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
            this.lblViweMedicine.Size = new System.Drawing.Size(202, 33);
            this.lblViweMedicine.TabIndex = 0;
            this.lblViweMedicine.Text = "Sell Medicine";
            this.lblViweMedicine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SellUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bodyPanel);
            this.Name = "SellUserControl";
            this.Size = new System.Drawing.Size(986, 765);
            this.bodyPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown1)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBoxContact;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown1;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.DataGridView cartDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addtocartButton;
    }
}
