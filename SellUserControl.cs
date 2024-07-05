using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PharmacyManagementSystem
{
    public partial class SellUserControl : UserControl
    {
        private DataTable cartTable;
        public PharmacistsClass phc;

        public SellUserControl(PharmacistsClass phc)
        {
            this.phc = phc;
            InitializeComponent();
            LoadAllMedicineData();
            InitializeCartTable();
        }

        private void LoadAllMedicineData()
        {
            string sqlSelect = "SELECT * FROM Medicine";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sqlSelect, DBConnection.ConnectionString);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dGVViweMedicine.DataSource = dataTable;
            dGVViweMedicine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void searchbox()
        {
            try
            {
                string s = "";

                if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    s = $"SELECT * FROM Medicine WHERE Medicine_name LIKE '%{txtSearch.Text}%'";
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(s, DBConnection.ConnectionString);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dGVViweMedicine.DataSource = dataTable;
                dGVViweMedicine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading medicine data: " + ex.Message);
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchbox();
        }

        private void LoadMedicineData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DBConnection.ConnectionString))
                {
                    connection.Open();
                    string sqlSelect = "";

                    if (cmbCheck.SelectedItem.ToString() == "All Medicine")
                    {
                        sqlSelect = "SELECT * FROM Medicine";
                    }
                    else if (cmbCheck.SelectedItem.ToString() == "Expired Medicine")
                    {
                        sqlSelect = "SELECT * FROM Medicine WHERE Medicine_expirydate < NOW()";
                    }
                    else if (cmbCheck.SelectedItem.ToString() == "Valid Medicine")
                    {
                        sqlSelect = "SELECT * FROM Medicine WHERE Medicine_expirydate >= NOW()";
                    }
                    else
                    {
                        return;
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sqlSelect, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dGVViweMedicine.DataSource = dataTable;
                    dGVViweMedicine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading medicine data: " + ex.Message);
            }
        }

        private void RefreshMedicineData()
        {
            LoadMedicineData();
        }

        private void validComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshMedicineData();
        }

        private void InitializeCartTable()
        {
            cartTable = new DataTable();
            cartTable.Columns.Add("Medicine_ID", typeof(string));
            cartTable.Columns.Add("Medicine_name", typeof(string));
            cartTable.Columns.Add("Unit_price", typeof(double));
            cartTable.Columns.Add("Quantity", typeof(int));
            cartTable.Columns.Add("Total_price", typeof(double));
            cartDataGridView.DataSource = cartTable;
            cartDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {

        }

        private void addtocartButton_Click(object sender, EventArgs e)
        {
            if (dGVViweMedicine.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dGVViweMedicine.SelectedRows[0];
                string medicineID = selectedRow.Cells["Medicine_ID"].Value.ToString();
                string medicineName = selectedRow.Cells["Medicine_name"].Value.ToString();
                double unitPrice = Convert.ToDouble(selectedRow.Cells["Unit_price"].Value);
                int quantity = Convert.ToInt32(quantityNumericUpDown1.Value);

                if (int.TryParse(selectedRow.Cells["Quantity"].Value.ToString(), out int stockQuantity))
                {
                    if (quantity <= 0)
                    {
                        MessageBox.Show("Please select a quantity greater than zero.");
                        return;
                    }

                    if (stockQuantity < quantity)
                    {
                        MessageBox.Show("Not enough stock available.");
                        return;
                    }

                    int newStockQuantity = stockQuantity - quantity;
                    selectedRow.Cells["Quantity"].Value = newStockQuantity;

                    double totalPrice = unitPrice * quantity;

                    DataRow newRow = cartTable.NewRow();
                    newRow["Medicine_ID"] = medicineID;
                    newRow["Medicine_name"] = medicineName;
                    newRow["Unit_price"] = unitPrice;
                    newRow["Quantity"] = quantity;
                    newRow["Total_price"] = totalPrice;

                    cartTable.Rows.Add(newRow);

                    ReduceStockById(medicineID, quantity);

                    MessageBox.Show("Medicine added to cart successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please select a medicine before adding to cart.");
            }
        }

        private void quantityNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            string name = txtBoxFirstName.Text;
            string contact = txtBoxContact.Text;
            double sum = 0;

            foreach (DataRow row in cartTable.Rows)
            {
                if (row["Total_price"] != DBNull.Value)
                {
                    sum += Convert.ToDouble(row["Total_price"]);
                }
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(DBConnection.ConnectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO medicinesale (CustomerName, Phone, SaleDate, TotalPrice, Seller) VALUES (@CustomerName, @Phone, @SaleDate, @TotalPrice, @seller)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerName", name);
                        command.Parameters.AddWithValue("@Phone", contact);
                        command.Parameters.AddWithValue("@SaleDate", DateTime.Now);
                        command.Parameters.AddWithValue("@TotalPrice", sum);
                        command.Parameters.AddWithValue("@seller", phc.PhUsername);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Sale recorded successfully!\nTotal Amount: " + sum.ToString("C") + "\nCustomer Name: " + name + "\nContact: " + contact);
                cartTable.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error recording sale: " + ex.Message);
            }
        }
        private void ReduceStockById(string medicineID, int quantity)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DBConnection.ConnectionString))
                {
                    connection.Open();
                    string query = "UPDATE Medicine SET Quantity = Quantity - @Quantity WHERE Medicine_ID = @MedicineID";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Quantity", quantity);
                        command.Parameters.AddWithValue("@MedicineID", medicineID);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reducing stock: " + ex.Message);
            }
        }
    }
}
