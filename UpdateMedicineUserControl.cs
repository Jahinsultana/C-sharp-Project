using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PharmacyManagementSystem
{
    public partial class UpdateMedicineUserControl : UserControl
    {
        public UpdateMedicineUserControl()
        {
            InitializeComponent();
            LoadMedicineData();
        }

        private void LoadMedicineData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DBConnection.ConnectionString))
                {
                    connection.Open();
                    string sqlSelect = "SELECT * FROM Medicine";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sqlSelect, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dGVUpdateMedicine.DataSource = dataTable;
                    dGVUpdateMedicine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading medicine data: " + ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dGVUpdateMedicine.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dGVUpdateMedicine.SelectedRows[0];
                txtPricePerUnit.Text = selectedRow.Cells["Unit_price"].Value.ToString();
                txtQuantity.Text = selectedRow.Cells["Quantity"].Value.ToString();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dGVUpdateMedicine.SelectedRows.Count > 0)
                {
                    int selectedIndex = dGVUpdateMedicine.SelectedRows[0].Index;

                    if (ValidateInput())
                    {
                        double newPrice = double.Parse(txtPricePerUnit.Text);
                        int newQuantity = int.Parse(txtQuantity.Text);

                        dGVUpdateMedicine.Rows[selectedIndex].Cells["Unit_price"].Value = newPrice;
                        dGVUpdateMedicine.Rows[selectedIndex].Cells["Quantity"].Value = newQuantity;

                        string medicineID = dGVUpdateMedicine.Rows[selectedIndex].Cells["Medicine_ID"].Value.ToString();
                        DBConnection.UpdateRowInDatabase(medicineID, selectedIndex, newPrice, newQuantity);

                        dGVUpdateMedicine.ClearSelection();
                        txtPricePerUnit.Clear();
                        txtQuantity.Clear();

                        MessageBox.Show("Row updated successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row before updating.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating row: " + ex.Message);
            }
        }

        private bool ValidateInput()
        {
            if (!IsNumeric(txtQuantity.Text) || !IsNumeric(txtPricePerUnit.Text))
            {
                MessageBox.Show("Please enter valid numeric values for Quantity and Price Per Unit.");
                return false;
            }

            return true;
        }

        private bool IsNumeric(string value)
        {
            return double.TryParse(value, out _) && double.Parse(value) >= 0;
        }

        private void txtPricePerUnit_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
