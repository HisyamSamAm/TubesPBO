using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Peminjaman_Playstation
{
    public partial class Pelanggan : Form
    {
        private MySqlConnection connection;

        public Pelanggan()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadData();
        }

        private void InitializeDatabaseConnection()
        {
            string connectionString = "server=localhost;database=rental_playstation;uid=root;pwd=;";
            connection = new MySqlConnection(connectionString);
        }

        private void LoadData()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM customers";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            GenerateCustomerID();
        }

        private void GenerateCustomerID()
        {
            try
            {
                connection.Open();
                string query = "SELECT id_customer FROM customers ORDER BY id_customer DESC LIMIT 1";
                MySqlCommand command = new MySqlCommand(query, connection);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    int lastID = Convert.ToInt32(result);
                    textBoxIDPelanggan.Text = "P" + (lastID + 1).ToString("D4");
                }
                else
                {
                    textBoxIDPelanggan.Text = "P0001";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO customers (NIK, name, phone_number, gender, address) VALUES (@NIK, @Name, @PhoneNumber, @Gender, @Address)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NIK", textBoxNIK.Text);
                    command.Parameters.AddWithValue("@Name", textBoxNama.Text);
                    command.Parameters.AddWithValue("@PhoneNumber", textBoxNomorTelepon.Text);
                    command.Parameters.AddWithValue("@Gender", radioButtonLakiLaki.Checked ? "Male" : "Female");
                    command.Parameters.AddWithValue("@Address", textBoxAlamat.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data saved successfully.");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE customers SET NIK = @NIK, name = @Name, phone_number = @PhoneNumber, gender = @Gender, address = @Address WHERE id_customer = @ID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", textBoxIDPelanggan.Text);
                    command.Parameters.AddWithValue("@NIK", textBoxNIK.Text);
                    command.Parameters.AddWithValue("@Name", textBoxNama.Text);
                    command.Parameters.AddWithValue("@PhoneNumber", textBoxNomorTelepon.Text);
                    command.Parameters.AddWithValue("@Gender", radioButtonLakiLaki.Checked ? "Male" : "Female");
                    command.Parameters.AddWithValue("@Address", textBoxAlamat.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data updated successfully.");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "DELETE FROM customers WHERE id_customer = @ID";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", textBoxIDPelanggan.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Data deleted successfully.");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void ClearInputFields()
        {
            textBoxIDPelanggan.Clear();
            textBoxNIK.Clear();
            textBoxNama.Clear();
            textBoxNomorTelepon.Clear();
            radioButtonLakiLaki.Checked = false;
            radioButtonPerempuan.Checked = false;
            textBoxAlamat.Clear();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxNIK.Text))
            {
                MessageBox.Show("NIK is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxNama.Text))
            {
                MessageBox.Show("Name is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxNomorTelepon.Text) || !textBoxNomorTelepon.Text.All(char.IsDigit))
            {
                MessageBox.Show("Valid phone number is required.");
                return false;
            }
            if (!radioButtonLakiLaki.Checked && !radioButtonPerempuan.Checked)
            {
                MessageBox.Show("Gender is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxAlamat.Text))
            {
                MessageBox.Show("Address is required.");
                return false;
            }
            return true;
        }
    }
}
