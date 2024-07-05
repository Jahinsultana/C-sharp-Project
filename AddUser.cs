using System;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace PharmacyManagementSystem
{
    public partial class AddUser : UserControl
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void sumitButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    string firstName = txtBoxFirstName.Text;
                    string lastName = txtBoxLastName.Text;
                    string gender = comboBoxGender.SelectedItem.ToString();
                    string contact = txtBoxContact.Text;
                    double salary = double.Parse(txtBoxSalary.Text);
                    string username = txtBoxUseName.Text;
                    string password = txtBoxPassword.Text;

                    bool success = DBConnection.InsertDataIntoPharmacistTable(firstName, lastName, gender, contact, salary, username, password);

                    if (success)
                    {
                        MessageBox.Show("Pharmacist added successfully!");
                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Error adding new Pharmacist!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtBoxFirstName.Text))
            {
                MessageBox.Show("Please enter a value for First Name.");
                return false;
            }
            if (txtBoxFirstName.Text.Any(char.IsDigit) || txtBoxFirstName.Text.Any(char.IsSymbol))
            {
                MessageBox.Show("First Name should not contain any numerical values or symbols.");
                return false;
            }

            if (string.IsNullOrEmpty(txtBoxLastName.Text))
            {
                MessageBox.Show("Please enter a value for Last Name.");
                return false;
            }
            if (txtBoxLastName.Text.Any(char.IsDigit) || txtBoxLastName.Text.Any(char.IsSymbol))
            {
                MessageBox.Show("Last Name should not contain any numerical values or symbols.");
                return false;
            }

            if (comboBoxGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a gender.");
                return false;
            }

            if (string.IsNullOrEmpty(txtBoxContact.Text) || !txtBoxContact.Text.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid numerical value for Contact.");
                return false;
            }

            if (!decimal.TryParse(txtBoxSalary.Text, out decimal salary) || salary < 0)
            {
                MessageBox.Show("Please enter a valid non-negative numeric value for Salary.");
                return false;
            }

            if (string.IsNullOrEmpty(txtBoxUseName.Text))
            {
                MessageBox.Show("Please enter a value for Username.");
                return false;
            }

            if (string.IsNullOrEmpty(txtBoxPassword.Text) || txtBoxPassword.Text.Length < 6)
            {
                MessageBox.Show("Password should not be less than 6 characters.");
                return false;
            }

            return true; 
        }

        private void ClearInputFields()
        {
            txtBoxFirstName.Clear();
            txtBoxLastName.Clear();
            dtpDateOfBirth.Value = DateTime.Now;
            comboBoxGender.SelectedIndex = -1;
            txtBoxContact.Clear();
            txtBoxSalary.Clear();
            txtBoxUseName.Clear();
            txtBoxPassword.Clear();
        }
    }
}
