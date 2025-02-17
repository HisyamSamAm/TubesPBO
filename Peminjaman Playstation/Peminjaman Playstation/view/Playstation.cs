using Peminjaman_Playstation.controller;
using Peminjaman_Playstation.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Peminjaman_Playstation.view
{
    public partial class Playstation : Form
    {
        private PlaystationController playstationController;

        public Playstation()
        {
            InitializeComponent();
            playstationController = new PlaystationController();
            LoadData();
        }

        private void LoadData()
        {
            List<M_Playstation> listPlaystation = playstationController.GetAllPlaystation();
            dataGridView.DataSource = listPlaystation;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            M_Playstation playstation = new M_Playstation
            {
                ID_Playstation = textBoxIDPlaystation.Text,
                Jenis_Playstation = textBoxJenisPlaystation.Text,
                Harga_Sewa_Per_Hari = decimal.Parse(textBoxHargaSewa.Text)
            };

            playstationController.InsertPlaystation(playstation);
            LoadData();
            ClearForm();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            string lastID = playstationController.GetLastIDPlaystation();
            string newID = GenerateNewID(lastID);
            textBoxIDPlaystation.Text = newID;
        }

        private string GenerateNewID(string lastID)
        {
            if (string.IsNullOrEmpty(lastID))
            {
                return "PS001";
            }

            int number = int.Parse(lastID.Substring(2)) + 1;
            return "PS" + number.ToString("D3");
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                string idPlaystation = dataGridView.SelectedRows[0].Cells["ID_Playstation"].Value.ToString();
                playstationController.DeletePlaystation(idPlaystation);
                LoadData();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Pilih data yang ingin dihapus terlebih dahulu.");
            }
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                M_Playstation playstation = new M_Playstation
                {
                    ID_Playstation = textBoxIDPlaystation.Text,
                    Jenis_Playstation = textBoxJenisPlaystation.Text,
                    Harga_Sewa_Per_Hari = decimal.Parse(textBoxHargaSewa.Text)
                };

                playstationController.UpdatePlaystation(playstation);
                LoadData();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Pilih data yang ingin diubah terlebih dahulu.");
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                textBoxIDPlaystation.Text = row.Cells["ID_Playstation"].Value.ToString();
                textBoxJenisPlaystation.Text = row.Cells["Jenis_Playstation"].Value.ToString();
                textBoxHargaSewa.Text = Convert.ToDecimal(row.Cells["Harga_Sewa_Per_Hari"].Value).ToString("F2");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            textBoxIDPlaystation.Clear();
            textBoxJenisPlaystation.Clear();
            textBoxHargaSewa.Clear();
        }
    }
}