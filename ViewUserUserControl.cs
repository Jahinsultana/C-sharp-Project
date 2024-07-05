using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PharmacyManagementSystem
{
    public partial class ViewUserUserControl : UserControl
    {
        public ViewUserUserControl()
        {
            InitializeComponent();
            LoadPharmacistData();
        }

        private void LoadPharmacistData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DBConnection.ConnectionString))
                {
                    connection.Open();
                    string sqlSelect = "SELECT * FROM Pharmacist";
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlSelect, connection))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dGVViweUsers.DataSource = dataTable;
                        dGVViweUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Pharmacist data: " + ex.Message);
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchPharmacist(txtSearch.Text);
        }

        private void SearchPharmacist(string searchName = "")
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DBConnection.ConnectionString))
                {
                    connection.Open();
                    string sqlSelect = "SELECT * FROM Pharmacist";
                    if (!string.IsNullOrWhiteSpace(searchName))
                    {
                        sqlSelect += $" WHERE ph_firstname LIKE '%{searchName}%'";
                    }
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlSelect, connection))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dGVViweUsers.DataSource = dataTable;
                        dGVViweUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Pharmacist data: " + ex.Message);
            }
        }

        private void dGVViweUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Your event handling code here
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
