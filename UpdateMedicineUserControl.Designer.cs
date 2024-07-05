namespace PharmacyManagementSystem
{
    partial class UpdateMedicineUserControl
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
            this.dGVUpdateMedicine = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtPricePerUnit = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblPricePerUnit = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblUpdateMedicine = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVUpdateMedicine)).BeginInit();
            this.panel1.SuspendLayout();
            this.bodyPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.dGVUpdateMedicine);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 56);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1315, 886);
            this.panel4.TabIndex = 4;
            // 
            // dGVUpdateMedicine
            // 
            this.dGVUpdateMedicine.AllowUserToAddRows = false;
            this.dGVUpdateMedicine.AllowUserToDeleteRows = false;
            this.dGVUpdateMedicine.ColumnHeadersHeight = 29;
            this.dGVUpdateMedicine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVUpdateMedicine.Location = new System.Drawing.Point(0, 0);
            this.dGVUpdateMedicine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVUpdateMedicine.Name = "dGVUpdateMedicine";
            this.dGVUpdateMedicine.ReadOnly = true;
            this.dGVUpdateMedicine.RowHeadersWidth = 51;
            this.dGVUpdateMedicine.Size = new System.Drawing.Size(1315, 732);
            this.dGVUpdateMedicine.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.txtPricePerUnit);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.lblPricePerUnit);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 732);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 154);
            this.panel1.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Green;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(1145, 25);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(137, 59);
            this.btnUpdate.TabIndex = 38;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.addButton_Click);
            // 
            // txtPricePerUnit
            // 
            this.txtPricePerUnit.Location = new System.Drawing.Point(756, 41);
            this.txtPricePerUnit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPricePerUnit.Name = "txtPricePerUnit";
            this.txtPricePerUnit.Size = new System.Drawing.Size(324, 22);
            this.txtPricePerUnit.TabIndex = 37;
            this.txtPricePerUnit.TextChanged += new System.EventHandler(this.txtPricePerUnit_TextChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(219, 41);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(163, 22);
            this.txtQuantity.TabIndex = 36;
            // 
            // lblPricePerUnit
            // 
            this.lblPricePerUnit.AutoSize = true;
            this.lblPricePerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPricePerUnit.ForeColor = System.Drawing.Color.Black;
            this.lblPricePerUnit.Location = new System.Drawing.Point(440, 25);
            this.lblPricePerUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPricePerUnit.Name = "lblPricePerUnit";
            this.lblPricePerUnit.Size = new System.Drawing.Size(231, 33);
            this.lblPricePerUnit.TabIndex = 35;
            this.lblPricePerUnit.Text = "Price(Per Unit):";
            this.lblPricePerUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.Black;
            this.lblQuantity.Location = new System.Drawing.Point(4, 25);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(141, 33);
            this.lblQuantity.TabIndex = 34;
            this.lblQuantity.Text = "Quantity:";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblUpdateMedicine);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1315, 58);
            this.panel3.TabIndex = 1;
            // 
            // lblUpdateMedicine
            // 
            this.lblUpdateMedicine.AutoSize = true;
            this.lblUpdateMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateMedicine.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblUpdateMedicine.Location = new System.Drawing.Point(519, 2);
            this.lblUpdateMedicine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateMedicine.Name = "lblUpdateMedicine";
            this.lblUpdateMedicine.Size = new System.Drawing.Size(248, 33);
            this.lblUpdateMedicine.TabIndex = 0;
            this.lblUpdateMedicine.Text = "Update Medicine";
            this.lblUpdateMedicine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateMedicineUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bodyPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UpdateMedicineUserControl";
            this.Size = new System.Drawing.Size(1315, 942);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVUpdateMedicine)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bodyPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblUpdateMedicine;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtPricePerUnit;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblPricePerUnit;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.DataGridView dGVUpdateMedicine;
    }
}
