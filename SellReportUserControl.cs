using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PharmacyManagementSystem
{
    public partial class SellReportUserControl : UserControl
    {
        public SellReportUserControl()
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
                    string sqlSelect = "SELECT * FROM MedicineSale";
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
                MessageBox.Show("Error loading Medicine data: " + ex.Message);
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
                    string sqlSelect = "SELECT * FROM MedicineSale";
                    if (!string.IsNullOrWhiteSpace(searchName))
                    {
                        sqlSelect += $" WHERE seller LIKE '%{searchName}%'";
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
                MessageBox.Show("Error loading Medicine data: " + ex.Message);
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

