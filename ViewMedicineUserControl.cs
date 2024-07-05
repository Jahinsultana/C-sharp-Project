using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PharmacyManagementSystem
{
    public partial class ViewMedicineUserControl : UserControl
    {
        public ViewMedicineUserControl()
        {
            InitializeComponent();
            LoadAllMedicineData();
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
    }
}
