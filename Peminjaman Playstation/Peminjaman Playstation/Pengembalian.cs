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
    public partial class Pengembalian : Form
    {
        private MySqlConnection connection;

        public Pengembalian()
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
                string query = "SELECT * FROM returns";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewPengembalian.DataSource = dataTable;
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
                    string query = "INSERT INTO returns (id_transaction, return_date, late_days, fine_per_day, total_fine, total_payment, amount_paid, change_amount) VALUES (@IDTransaction, @ReturnDate, @LateDays, @FinePerDay, @TotalFine, @TotalPayment, @AmountPaid, @ChangeAmount)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDTransaction", comboBoxNoTransaksi.SelectedValue);
                    command.Parameters.AddWithValue("@ReturnDate", dateTimePickerTglPengembalian.Value);
                    command.Parameters.AddWithValue("@LateDays", Convert.ToInt32(textBoxKeterlambatan.Text));
                    command.Parameters.AddWithValue("@FinePerDay", Convert.ToDecimal(textBoxDendaHari.Text));
                    command.Parameters.AddWithValue("@TotalFine", Convert.ToDecimal(textBoxTotalDenda.Text));
                    command.Parameters.AddWithValue("@TotalPayment", Convert.ToDecimal(textBoxTotalBayar.Text));
                    command.Parameters.AddWithValue("@AmountPaid", Convert.ToDecimal(textBoxBayar.Text));
                    command.Parameters.AddWithValue("@ChangeAmount", Convert.ToDecimal(textBoxKembalian.Text));
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "DELETE FROM returns WHERE id_return = @ID";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", comboBoxNoTransaksi.SelectedValue);
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
            comboBoxNoTransaksi.SelectedIndex = -1;
            dateTimePickerTglPengembalian.Value = DateTime.Now;
            textBoxKeterlambatan.Clear();
            textBoxDendaHari.Clear();
            textBoxTotalDenda.Clear();
            textBoxTotalBayar.Clear();
            textBoxBayar.Clear();
            textBoxKembalian.Clear();
        }

        private bool ValidateInput()
        {
            if (comboBoxNoTransaksi.SelectedIndex == -1)
            {
                MessageBox.Show("Transaction ID is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxKeterlambatan.Text) || !int.TryParse(textBoxKeterlambatan.Text, out int lateDays) || lateDays < 0)
            {
                MessageBox.Show("Valid late days are required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxDendaHari.Text) || !decimal.TryParse(textBoxDendaHari.Text, out decimal finePerDay) || finePerDay < 0)
            {
                MessageBox.Show("Valid fine per day is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxTotalDenda.Text) || !decimal.TryParse(textBoxTotalDenda.Text, out decimal totalFine) || totalFine < 0)
            {
                MessageBox.Show("Valid total fine is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxTotalBayar.Text) || !decimal.TryParse(textBoxTotalBayar.Text, out decimal totalPayment) || totalPayment < 0)
            {
                MessageBox.Show("Valid total payment is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxBayar.Text) || !decimal.TryParse(textBoxBayar.Text, out decimal amountPaid) || amountPaid < totalPayment)
            {
                MessageBox.Show("Amount paid must not be less than total payment.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxKembalian.Text) || !decimal.TryParse(textBoxKembalian.Text, out decimal changeAmount) || changeAmount < 0)
            {
                MessageBox.Show("Valid change amount is required.");
                return false;
            }
            return true;
        }

        private void buttonHitung_Click(object sender, EventArgs e)
        {
            CalculateFines();
        }

        private void CalculateFines()
        {
            if (int.TryParse(textBoxKeterlambatan.Text, out int lateDays) && decimal.TryParse(textBoxDendaHari.Text, out decimal finePerDay))
            {
                decimal totalFine = lateDays * finePerDay;
                textBoxTotalDenda.Text = totalFine.ToString("F2");

                if (decimal.TryParse(textBoxTotalHarga.Text, out decimal totalPrice))
                {
                    decimal totalPayment = totalPrice + totalFine;
                    textBoxTotalBayar.Text = totalPayment.ToString("F2");

                    if (decimal.TryParse(textBoxBayar.Text, out decimal amountPaid))
                    {
                        decimal changeAmount = amountPaid - totalPayment;
                        textBoxKembalian.Text = changeAmount.ToString("F2");
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid amount paid.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid total price.");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid late days and fine per day.");
            }
        }
    }
}
