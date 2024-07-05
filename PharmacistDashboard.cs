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
    public partial class PharmacistDashboard : UserControl
    {
        public PharmacistsClass phc;
        public PharmacistDashboard(PharmacistsClass phc)
        {

            InitializeComponent();
            this.phc = phc;
            this.lblPhamacistsName.Text = this.phc.PhFirstName;
        }

        private void addMedicineButton_Click(object sender, EventArgs e)
        {
            AddMedicineUserControl addMed = new AddMedicineUserControl();
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(addMed);
        }

        private void viewMedicineButton_Click(object sender, EventArgs e)
        {
            ViewMedicineUserControl viewMed = new ViewMedicineUserControl();
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(viewMed);
        }

        private void updateMedicineButton_Click(object sender, EventArgs e)
        {
            UpdateMedicineUserControl updateMed= new UpdateMedicineUserControl(); 
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(updateMed);
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            this.Hide();
            loginForm.Show();
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            SellUserControl updateMed = new SellUserControl(this.phc);
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(updateMed);
        }

        private void sellreportButton_Click(object sender, EventArgs e)
        {
            SellReportUserControl updateMed = new SellReportUserControl();
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(updateMed);

        }
    }
}
