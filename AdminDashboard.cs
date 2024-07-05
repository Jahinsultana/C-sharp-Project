using PharmacyManagementSystem.Resources;
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
    public partial class AdminDashboard : UserControl
    {
        public AdminDashboard()
        {
            InitializeComponent();         
        }

        private void doctorsButton_Click(object sender, EventArgs e)
        {
            ViewUserUserControl viewUserUserControl = new ViewUserUserControl();
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(viewUserUserControl);
        }

        private void patientsButton_Click(object sender, EventArgs e)
        {
            EditUserUserControl patientsListUC = new EditUserUserControl();
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(patientsListUC);
        }


        private void logOutButton_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            this.Hide();
            loginForm.Show();
        }

        private void receptionistButton_Click(object sender, EventArgs e)
        {
            AddUser adduser=new AddUser();
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(adduser);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnViewMedicine_Click(object sender, EventArgs e)
        {
            ViewMedicineUserControl viewMed = new ViewMedicineUserControl();
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(viewMed);
        }

        private void sellreportButton_Click(object sender, EventArgs e)
        {
            SellReportUserControl updateMed = new SellReportUserControl();
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(updateMed);
        }
    }
    
}
