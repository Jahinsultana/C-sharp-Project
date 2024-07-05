using System;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username.Equals("admin") && password.Equals("admin"))
            {
                AdminDashboard admin = new AdminDashboard();
                Form1 form = new Form1(admin);
                
                this.Hide();
                form.Show();

            }
            else
            {
                bool isValidPharmacist = DBConnection.VerifyPharmacistCredentials(username, password);

                if (isValidPharmacist)
                {
                    PharmacistsClass phc = DBConnection.GetPharmacistByUsername(username);
                    PharmacistDashboard ph = new PharmacistDashboard(phc);
                    Form1 form = new Form1(ph);

                    this.Hide();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
        }

        private void iklShowHidePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (iklShowHidePassword.Text == "Show")
            {
                iklShowHidePassword.Text = "Hide";
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                iklShowHidePassword.Text = "Show";
                txtPassword.PasswordChar = '*';
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
