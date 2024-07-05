using System;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class AddMedicineUserControl : UserControl
    {
        public AddMedicineUserControl()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string errorMessage = ValidateInput();

            if (string.IsNullOrEmpty(errorMessage))
            {
                bool a = DBConnection.InsertDataIntoMedicineTable(
                    txtMedicineName.Text,
                    cmbExpireDate.Value,
                    cmbManufactureDate.Value,
                    int.Parse(txtQuantity.Text),
                    double.Parse(txtPricePerUnit.Text)
                );

                if (a)
                {
                    MessageBox.Show("Medicine Added Successfully!");
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Error Adding new Medicine!");
                }
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }

        private string ValidateInput()
        {
            if (string.IsNullOrEmpty(txtMedicineName.Text))
            {
                return "Please enter a value for Medicine Name.";
            }

            if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                return "Please enter a value for Quantity.";
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity < 0)
            {
                return "Please enter a valid value for Quantity.";
            }

            if (string.IsNullOrEmpty(txtPricePerUnit.Text))
            {
                return "Please enter a value for Price Per Unit.";
            }

            if (!double.TryParse(txtPricePerUnit.Text, out double price) || price < 0)
            {
                return "Please enter a valid non-negative numeric value for Price Per Unit.";
            }

            return string.Empty;
        }

        private void ClearForm()
        {
            txtMedicineName.Text = string.Empty;
            cmbExpireDate.Value = DateTime.Now;
            cmbManufactureDate.Value = DateTime.Now;
            txtQuantity.Text = string.Empty;
            txtPricePerUnit.Text = string.Empty;
        }
    }
}
