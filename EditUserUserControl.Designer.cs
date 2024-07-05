namespace PharmacyManagementSystem.Resources
{
    partial class EditUserUserControl
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.dGVEditUser = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblEditUser = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEditUser)).BeginInit();
            this.bodyPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.dGVEditUser);
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(986, 720);
            this.panel4.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(502, 564);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(236, 54);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // dGVEditUser
            // 
            this.dGVEditUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVEditUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.dGVEditUser.Location = new System.Drawing.Point(0, 0);
            this.dGVEditUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dGVEditUser.Name = "dGVEditUser";
            this.dGVEditUser.RowHeadersWidth = 51;
            this.dGVEditUser.RowTemplate.Height = 24;
            this.dGVEditUser.Size = new System.Drawing.Size(986, 539);
            this.dGVEditUser.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.ForestGreen;
            this.btnUpdate.Location = new System.Drawing.Point(237, 564);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(217, 54);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // bodyPanel
            // 
            this.bodyPanel.Controls.Add(this.panel4);
            this.bodyPanel.Controls.Add(this.panel3);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(0, 0);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(986, 768);
            this.bodyPanel.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblEditUser);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(986, 48);
            this.panel3.TabIndex = 1;
            // 
            // lblEditUser
            // 
            this.lblEditUser.AutoSize = true;
            this.lblEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditUser.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblEditUser.Location = new System.Drawing.Point(429, 7);
            this.lblEditUser.Name = "lblEditUser";
            this.lblEditUser.Size = new System.Drawing.Size(144, 33);
            this.lblEditUser.TabIndex = 0;
            this.lblEditUser.Text = "Edit User";
            this.lblEditUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditUserUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bodyPanel);
            this.Name = "EditUserUserControl";
            this.Size = new System.Drawing.Size(986, 768);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVEditUser)).EndInit();
            this.bodyPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblEditUser;
        private System.Windows.Forms.DataGridView dGVEditUser;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}
