namespace PharmacyManagementSystem
{
    partial class AddMedicineUserControl
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
            this.lblAddMedicine = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbExpireDate = new System.Windows.Forms.DateTimePicker();
            this.lblExpireDate = new System.Windows.Forms.Label();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.cmbManufactureDate = new System.Windows.Forms.DateTimePicker();
            this.txtPricePerUnit = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            this.lblPricePerUnit = new System.Windows.Forms.Label();
            this.lblManufactureDate = new System.Windows.Forms.Label();
            this.lblquantity = new System.Windows.Forms.Label();
            this.lblMedicineName = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.bodyPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddMedicine
            // 
            this.lblAddMedicine.AutoSize = true;
            this.lblAddMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMedicine.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblAddMedicine.Location = new System.Drawing.Point(568, 9);
            this.lblAddMedicine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddMedicine.Name = "lblAddMedicine";
            this.lblAddMedicine.Size = new System.Drawing.Size(203, 33);
            this.lblAddMedicine.TabIndex = 0;
            this.lblAddMedicine.Text = "Add Medicine";
            this.lblAddMedicine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.ForestGreen;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblAddMedicine);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1315, 58);
            this.panel3.TabIndex = 1;
            // 
            // bodyPanel
            // 
            this.bodyPanel.Controls.Add(this.panel4);
            this.bodyPanel.Controls.Add(this.panel3);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(0, 0);
            this.bodyPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(1315, 942);
            this.bodyPanel.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.cmbExpireDate);
            this.panel4.Controls.Add(this.lblExpireDate);
            this.panel4.Controls.Add(this.btnAddMedicine);
            this.panel4.Controls.Add(this.cmbManufactureDate);
            this.panel4.Controls.Add(this.txtPricePerUnit);
            this.panel4.Controls.Add(this.txtQuantity);
            this.panel4.Controls.Add(this.txtMedicineName);
            this.panel4.Controls.Add(this.lblPricePerUnit);
            this.panel4.Controls.Add(this.lblManufactureDate);
            this.panel4.Controls.Add(this.lblquantity);
            this.panel4.Controls.Add(this.lblMedicineName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 56);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1315, 886);
            this.panel4.TabIndex = 4;
            // 
            // cmbExpireDate
            // 
            this.cmbExpireDate.Location = new System.Drawing.Point(488, 346);
            this.cmbExpireDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbExpireDate.Name = "cmbExpireDate";
            this.cmbExpireDate.Size = new System.Drawing.Size(735, 22);
            this.cmbExpireDate.TabIndex = 45;
            // 
            // lblExpireDate
            // 
            this.lblExpireDate.AutoSize = true;
            this.lblExpireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpireDate.ForeColor = System.Drawing.Color.Black;
            this.lblExpireDate.Location = new System.Drawing.Point(103, 334);
            this.lblExpireDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpireDate.Name = "lblExpireDate";
            this.lblExpireDate.Size = new System.Drawing.Size(187, 33);
            this.lblExpireDate.TabIndex = 44;
            this.lblExpireDate.Text = "Expire Date:";
            this.lblExpireDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.BackColor = System.Drawing.Color.Green;
            this.btnAddMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedicine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddMedicine.Location = new System.Drawing.Point(423, 665);
            this.btnAddMedicine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(500, 63);
            this.btnAddMedicine.TabIndex = 33;
            this.btnAddMedicine.Text = "ADD";
            this.btnAddMedicine.UseVisualStyleBackColor = false;
            this.btnAddMedicine.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cmbManufactureDate
            // 
            this.cmbManufactureDate.Location = new System.Drawing.Point(488, 286);
            this.cmbManufactureDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbManufactureDate.Name = "cmbManufactureDate";
            this.cmbManufactureDate.Size = new System.Drawing.Size(735, 22);
            this.cmbManufactureDate.TabIndex = 32;
            // 
            // txtPricePerUnit
            // 
            this.txtPricePerUnit.Location = new System.Drawing.Point(488, 422);
            this.txtPricePerUnit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPricePerUnit.Name = "txtPricePerUnit";
            this.txtPricePerUnit.Size = new System.Drawing.Size(735, 22);
            this.txtPricePerUnit.TabIndex = 31;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(488, 229);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(735, 22);
            this.txtQuantity.TabIndex = 29;
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Location = new System.Drawing.Point(488, 175);
            this.txtMedicineName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(735, 22);
            this.txtMedicineName.TabIndex = 28;
            // 
            // lblPricePerUnit
            // 
            this.lblPricePerUnit.AutoSize = true;
            this.lblPricePerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricePerUnit.ForeColor = System.Drawing.Color.Black;
            this.lblPricePerUnit.Location = new System.Drawing.Point(103, 406);
            this.lblPricePerUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPricePerUnit.Name = "lblPricePerUnit";
            this.lblPricePerUnit.Size = new System.Drawing.Size(231, 33);
            this.lblPricePerUnit.TabIndex = 25;
            this.lblPricePerUnit.Text = "Price(Per Unit):";
            this.lblPricePerUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblManufactureDate
            // 
            this.lblManufactureDate.AutoSize = true;
            this.lblManufactureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManufactureDate.ForeColor = System.Drawing.Color.Black;
            this.lblManufactureDate.Location = new System.Drawing.Point(103, 273);
            this.lblManufactureDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManufactureDate.Name = "lblManufactureDate";
            this.lblManufactureDate.Size = new System.Drawing.Size(270, 33);
            this.lblManufactureDate.TabIndex = 23;
            this.lblManufactureDate.Text = "Manufacture Date:";
            this.lblManufactureDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquantity.ForeColor = System.Drawing.Color.Black;
            this.lblquantity.Location = new System.Drawing.Point(97, 213);
            this.lblquantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(141, 33);
            this.lblquantity.TabIndex = 22;
            this.lblquantity.Text = "Quantity:";
            this.lblquantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMedicineName
            // 
            this.lblMedicineName.AutoSize = true;
            this.lblMedicineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicineName.ForeColor = System.Drawing.Color.Black;
            this.lblMedicineName.Location = new System.Drawing.Point(97, 159);
            this.lblMedicineName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedicineName.Name = "lblMedicineName";
            this.lblMedicineName.Size = new System.Drawing.Size(240, 33);
            this.lblMedicineName.TabIndex = 21;
            this.lblMedicineName.Text = "Medicine Name:";
            this.lblMedicineName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddMedicineUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bodyPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddMedicineUserControl";
            this.Size = new System.Drawing.Size(1315, 942);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.bodyPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAddMedicine;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.DateTimePicker cmbManufactureDate;
        private System.Windows.Forms.TextBox txtPricePerUnit;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.Label lblPricePerUnit;
        private System.Windows.Forms.Label lblManufactureDate;
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.Label lblMedicineName;
        private System.Windows.Forms.DateTimePicker cmbExpireDate;
        private System.Windows.Forms.Label lblExpireDate;
    }
}
