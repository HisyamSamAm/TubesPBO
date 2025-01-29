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
    public partial class Peminjaman : Form
    {
        private MySqlConnection connection;

        public Peminjaman()
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
                string query = "SELECT * FROM loans";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewTransactions.DataSource = dataTable;
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
            GenerateTransactionID();
        }

        private void GenerateTransactionID()
        {
            try
            {
                connection.Open();
                string query = "SELECT id_transaction FROM loans ORDER BY id_transaction DESC LIMIT 1";
                MySqlCommand command = new MySqlCommand(query, connection);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    int lastID = Convert.ToInt32(result);
                    textBox1.Text = "T" + (lastID + 1).ToString("D4");
                }
                else
                {
                    textBox1.Text = "T0001";
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
                    string query = "INSERT INTO loans (id_customer, id_playstation, loan_date, rental_duration, total_price) VALUES (@IDCustomer, @IDPlaystation, @LoanDate, @RentalDuration, @TotalPrice)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDCustomer", comboBoxIDPelanggan.SelectedValue);
                    command.Parameters.AddWithValue("@IDPlaystation", comboBoxIDPlaystation.SelectedValue);
                    command.Parameters.AddWithValue("@LoanDate", dateTimePickerTglPeminjaman.Value);
                    command.Parameters.AddWithValue("@RentalDuration", Convert.ToInt32(textBoxLamaSewa.Text));
                    command.Parameters.AddWithValue("@TotalPrice", Convert.ToDecimal(textBoxTotalHarga.Text));
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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE loans SET id_customer = @IDCustomer, id_playstation = @IDPlaystation, loan_date = @LoanDate, rental_duration = @RentalDuration, total_price = @TotalPrice WHERE id_transaction = @ID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", textBox1.Text);
                    command.Parameters.AddWithValue("@IDCustomer", comboBoxIDPelanggan.SelectedValue);
                    command.Parameters.AddWithValue("@IDPlaystation", comboBoxIDPlaystation.SelectedValue);
                    command.Parameters.AddWithValue("@LoanDate", dateTimePickerTglPeminjaman.Value);
                    command.Parameters.AddWithValue("@RentalDuration", Convert.ToInt32(textBoxLamaSewa.Text));
                    command.Parameters.AddWithValue("@TotalPrice", Convert.ToDecimal(textBoxTotalHarga.Text));
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
                string query = "DELETE FROM loans WHERE id_transaction = @ID";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", textBox1.Text);
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
            textBox1.Clear();
            comboBoxIDPelanggan.SelectedIndex = -1;
            comboBoxIDPlaystation.SelectedIndex = -1;
            dateTimePickerTglPeminjaman.Value = DateTime.Now;
            textBoxLamaSewa.Clear();
            textBoxTotalHarga.Clear();
        }

        private bool ValidateInput()
        {
            if (comboBoxIDPelanggan.SelectedIndex == -1)
            {
                MessageBox.Show("Customer ID is required.");
                return false;
            }
            if (comboBoxIDPlaystation.SelectedIndex == -1)
            {
                MessageBox.Show("PlayStation ID is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxLamaSewa.Text) || !int.TryParse(textBoxLamaSewa.Text, out int rentalDuration) || rentalDuration <= 0)
            {
                MessageBox.Show("Valid rental duration is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxTotalHarga.Text) || !decimal.TryParse(textBoxTotalHarga.Text, out decimal totalPrice) || totalPrice <= 0)
            {
                MessageBox.Show("Valid total price is required.");
                return false;
            }
            return true;
        }

        private void buttonHitungOtomatis_Click(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void CalculateTotalPrice()
        {
            if (int.TryParse(textBoxLamaSewa.Text, out int rentalDuration) && decimal.TryParse(textBoxHarga.Text, out decimal rentalPricePerDay))
            {
                decimal totalPrice = rentalDuration * rentalPricePerDay;
                textBoxTotalHarga.Text = totalPrice.ToString("F2");
            }
            else
            {
                MessageBox.Show("Please enter valid rental duration and price.");
            }
        }
    }
}
