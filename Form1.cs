using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class Form1 : Form
    {
        AdminDashboard admin;
        PharmacistDashboard pharmacist;
        public Form1(AdminDashboard admin)
        {
            this.admin = admin;
            InitializeComponent();
            this.bodyPanel.Controls.Clear();
            this.bodyPanel.Controls.Add(this.admin);
        }
        public Form1(PharmacistDashboard pharmacist)
        {
            this.pharmacist = pharmacist;
            InitializeComponent();
            this.bodyPanel.Controls.Clear();
            this.bodyPanel.Controls.Add(this.pharmacist);
        }


        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
