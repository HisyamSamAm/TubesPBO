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
    public partial class Playstation : Form
    {
        private MySqlConnection connection;

        public Playstation()
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
                string query = "SELECT * FROM playstations";
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
            GeneratePlaystationID();
        }

        private void GeneratePlaystationID()
        {
            try
            {
                connection.Open();
                string query = "SELECT id_playstation FROM playstations ORDER BY id_playstation DESC LIMIT 1";
                MySqlCommand command = new MySqlCommand(query, connection);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    int lastID = Convert.ToInt32(result);
                    textBoxIDPlaystation.Text = "PS" + (lastID + 1).ToString("D4");
                }
                else
                {
                    textBoxIDPlaystation.Text = "PS0001";
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
                    string query = "INSERT INTO playstations (type, rental_price_per_day) VALUES (@Type, @RentalPricePerDay)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Type", textBoxJenisPlaystation.Text);
                    command.Parameters.AddWithValue("@RentalPricePerDay", Convert.ToDecimal(textBoxHargaSewa.Text));
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
                    string query = "UPDATE playstations SET type = @Type, rental_price_per_day = @RentalPricePerDay WHERE id_playstation = @ID";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", textBoxIDPlaystation.Text);
                    command.Parameters.AddWithValue("@Type", textBoxJenisPlaystation.Text);
                    command.Parameters.AddWithValue("@RentalPricePerDay", Convert.ToDecimal(textBoxHargaSewa.Text));
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
                string query = "DELETE FROM playstations WHERE id_playstation = @ID";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", textBoxIDPlaystation.Text);
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
            textBoxIDPlaystation.Clear();
            textBoxJenisPlaystation.Clear();
            textBoxHargaSewa.Clear();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxJenisPlaystation.Text))
            {
                MessageBox.Show("PlayStation type is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxHargaSewa.Text) || !decimal.TryParse(textBoxHargaSewa.Text, out decimal rentalPrice) || rentalPrice <= 0)
            {
                MessageBox.Show("Valid rental price is required.");
                return false;
            }
            return true;
        }
    }
}
