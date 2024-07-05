namespace PharmacyManagementSystem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.minButton = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.minButton);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1600, 39);
            this.panel1.TabIndex = 0;
            // 
            // minButton
            // 
            this.minButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.minButton.Image = global::PharmacyManagementSystem.Properties.Resources.minimize;
            this.minButton.Location = new System.Drawing.Point(1520, 0);
            this.minButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(40, 39);
            this.minButton.TabIndex = 1;
            this.minButton.UseVisualStyleBackColor = true;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.Image = global::PharmacyManagementSystem.Properties.Resources.close;
            this.closeBtn.Location = new System.Drawing.Point(1560, 0);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(40, 39);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // bodyPanel
            // 
            this.bodyPanel.BackColor = System.Drawing.Color.MediumAquamarine;
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(0, 39);
            this.bodyPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(1600, 946);
            this.bodyPanel.TabIndex = 1;
            this.bodyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 985);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button minButton;
        public System.Windows.Forms.Panel bodyPanel;
    }
}

