using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    internal class DBConnection
    {
        public static string ConnectionString = "Server=127.0.0.1;Database=hms;Uid=root;Pwd=;";
        public static PharmacistsClass pharmacist=null;

        public static bool InsertDataIntoMedicineTable(string medicineName, DateTime expiryDate, DateTime manufDate, int quantity, double unitPrice)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    string sqlGetMaxID = "SELECT IFNULL(MAX(Medicine_ID), 0) FROM Medicine";
                    using (MySqlCommand cmdGetMaxID = new MySqlCommand(sqlGetMaxID, connection))
                    {
                        int highestMedicineID = int.Parse(cmdGetMaxID.ExecuteScalar().ToString());
                        int newMedicineID = highestMedicineID + 1;

                        string sqlInsert = @"INSERT INTO Medicine
                             (Medicine_ID, Medicine_name, Medicine_expirydate, Medicince_manufdate, Quantity, Unit_price)
                             VALUES
                             (@MedicineID, @MedicineName, @ExpiryDate, @ManufDate, @Quantity, @UnitPrice)";

                        using (MySqlCommand cmd = new MySqlCommand(sqlInsert, connection))
                        {
                            cmd.Parameters.AddWithValue("@MedicineID", newMedicineID);
                            cmd.Parameters.AddWithValue("@MedicineName", medicineName);
                            cmd.Parameters.AddWithValue("@ExpiryDate", expiryDate.ToString("yyyy-MM-dd HH:mm:ss"));
                            cmd.Parameters.AddWithValue("@ManufDate", manufDate.ToString("yyyy-MM-dd HH:mm:ss"));
                            cmd.Parameters.AddWithValue("@Quantity", quantity);
                            cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void UpdateRowInDatabase(string medicineID, int rowIndex, double newPrice, int newQuantity)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(DBConnection.ConnectionString))
                {
                    connection.Open();
                    string sqlUpdate = @"UPDATE Medicine
                                 SET Unit_price = @NewPrice,
                                     Quantity = @NewQuantity
                                 WHERE Medicine_ID = @MedicineID";

                    using (MySqlCommand cmd = new MySqlCommand(sqlUpdate, connection))
                    {
                        cmd.Parameters.AddWithValue("@NewPrice", newPrice);
                        cmd.Parameters.AddWithValue("@NewQuantity", newQuantity);
                        cmd.Parameters.AddWithValue("@MedicineID", medicineID);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating row in the database: " + ex.Message);
            }
        }

        public static bool VerifyPharmacistCredentials(string username, string password)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    string sqlVerify = "SELECT COUNT(*) FROM Pharmacist WHERE ph_username = @Username AND ph_password = @Password";
                    using (MySqlCommand cmdVerify = new MySqlCommand(sqlVerify, connection))
                    {
                        cmdVerify.Parameters.AddWithValue("@Username", username);
                        cmdVerify.Parameters.AddWithValue("@Password", password);

                        int count = Convert.ToInt32(cmdVerify.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error verifying pharmacist credentials: " + ex.Message);
                return false;
            }
        }

        public static bool InsertDataIntoPharmacistTable
            (string firstName, string lastName,
            string gender,
            string contact, double salary,
            string username, string password)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    string sqlGetMaxID = "SELECT IFNULL(MAX(Ph_id), 0) FROM Pharmacist";
                    using (MySqlCommand cmdGetMaxID = new MySqlCommand(sqlGetMaxID, connection))
                    {
                        int highestPharmacistID = int.Parse(cmdGetMaxID.ExecuteScalar().ToString());
                        int newPharmacistID = highestPharmacistID + 1;

                        string sqlInsert = @"INSERT INTO Pharmacist
                                            (Ph_id, ph_firstname, ph_lastname, ph_gender, ph_contact, ph_salary, ph_username, ph_password)
                                            VALUES
                                            (@PhID, @FirstName, @LastName, @Gender, @Contact, @Salary, @Username, @Password)";

                        using (MySqlCommand cmdInsert = new MySqlCommand(sqlInsert, connection))
                        {
                            cmdInsert.Parameters.AddWithValue("@PhID", newPharmacistID.ToString());
                            cmdInsert.Parameters.AddWithValue("@FirstName", firstName);
                            cmdInsert.Parameters.AddWithValue("@LastName", lastName);
                            cmdInsert.Parameters.AddWithValue("@Gender", gender);
                            cmdInsert.Parameters.AddWithValue("@Contact", contact);
                            cmdInsert.Parameters.AddWithValue("@Salary", salary);
                            cmdInsert.Parameters.AddWithValue("@Username", username);
                            cmdInsert.Parameters.AddWithValue("@Password", password);

                            cmdInsert.ExecuteNonQuery();
                        }

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data into Pharmacist table: " + ex.Message);
                return false;
            }
        }

        public static void DeleteRowFromPharmacistTable(string pharmacistId)
        {
            using (MySqlConnection connection = new MySqlConnection(DBConnection.ConnectionString))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM Pharmacist WHERE Ph_Id = @Ph_Id";
                using (MySqlCommand cmd = new MySqlCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Ph_Id", pharmacistId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static PharmacistsClass GetPharmacistByUsername(string username)
        {
            using (MySqlConnection connection = new MySqlConnection(DBConnection.ConnectionString))
            {
                connection.Open();
                string selectQuery = "SELECT Ph_id, ph_firstname, ph_lastname,  ph_gender, ph_contact, ph_salary, ph_username, ph_password " +
                    "FROM Pharmacist WHERE ph_username = @Username";

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", username);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            pharmacist = new PharmacistsClass
                            (
                                reader["Ph_id"].ToString(),
                                reader["ph_firstname"].ToString(),
                                reader["ph_lastname"].ToString(),
                                reader["ph_gender"].ToString(),
                                reader["ph_contact"].ToString(),
                                Convert.ToDouble(reader["ph_salary"]),
                                reader["ph_username"].ToString(),
                                reader["ph_password"].ToString()
                            );
                        }
                    }
                }
            }
            return pharmacist;
        }

    }
}
