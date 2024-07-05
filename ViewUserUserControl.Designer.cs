namespace PharmacyManagementSystem
{
    partial class ViewUserUserControl
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
            this.dGVViweUsers = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblViweUsers = new System.Windows.Forms.Label();
            this.bodyPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVViweUsers)).BeginInit();
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
            this.bodyPanel.Size = new System.Drawing.Size(986, 768);
            this.bodyPanel.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.dGVViweUsers);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Location = new System.Drawing.Point(0, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(986, 720);
            this.panel4.TabIndex = 4;
            // 
            // dGVViweUsers
            // 
            this.dGVViweUsers.AllowUserToAddRows = false;
            this.dGVViweUsers.AllowUserToDeleteRows = false;
            this.dGVViweUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVViweUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dGVViweUsers.Location = new System.Drawing.Point(0, 74);
            this.dGVViweUsers.Margin = new System.Windows.Forms.Padding(2);
            this.dGVViweUsers.Name = "dGVViweUsers";
            this.dGVViweUsers.ReadOnly = true;
            this.dGVViweUsers.RowHeadersWidth = 51;
            this.dGVViweUsers.RowTemplate.Height = 24;
            this.dGVViweUsers.Size = new System.Drawing.Size(986, 646);
            this.dGVViweUsers.TabIndex = 5;
            this.dGVViweUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVViweUsers_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(894, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 23);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(686, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(189, 20);
            this.txtSearch.TabIndex = 31;
            this.txtSearch.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblViweUsers);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(986, 48);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lblViweUsers
            // 
            this.lblViweUsers.AutoSize = true;
            this.lblViweUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViweUsers.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblViweUsers.Location = new System.Drawing.Point(429, 7);
            this.lblViweUsers.Name = "lblViweUsers";
            this.lblViweUsers.Size = new System.Drawing.Size(173, 33);
            this.lblViweUsers.TabIndex = 0;
            this.lblViweUsers.Text = "View Users";
            this.lblViweUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewUserUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bodyPanel);
            this.Name = "ViewUserUserControl";
            this.Size = new System.Drawing.Size(986, 768);
            this.bodyPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVViweUsers)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblViweUsers;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dGVViweUsers;
    }
}
