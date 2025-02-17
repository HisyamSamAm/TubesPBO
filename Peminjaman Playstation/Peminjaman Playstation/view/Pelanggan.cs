using Peminjaman_Playstation.controller;
using Peminjaman_Playstation.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Peminjaman_Playstation.view
{
    public partial class Pelanggan : Form
    {
        private PelangganController pelangganController;

        public Pelanggan()
        {
            InitializeComponent();
            pelangganController = new PelangganController();
            LoadData();
        }

        private void LoadData()
        {
            List<M_Pelanggan> listPelanggan = pelangganController.GetAllPelanggan();
            dataGridView.DataSource = listPelanggan;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            M_Pelanggan pelanggan = new M_Pelanggan
            {
                ID_Pelanggan = textBoxIDPelanggan.Text,
                NIK = textBoxNIK.Text,
                Nama = textBoxNama.Text,
                NomorTelepon = textBoxNomorTelepon.Text,
                JenisKelamin = radioButtonLakiLaki.Checked ? "Laki-laki" : "Perempuan",
                Alamat = textBoxAlamat.Text
            };

            pelangganController.InsertPelanggan(pelanggan);
            LoadData();
            ClearForm();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            string lastID = pelangganController.GetLastIDPelanggan();
            string newID = GenerateNewID(lastID);
            textBoxIDPelanggan.Text = newID;
        }

        private string GenerateNewID(string lastID)
        {
            if (string.IsNullOrEmpty(lastID))
            {
                return "CUST001";
            }

            int number = int.Parse(lastID.Substring(4)) + 1;
            return "CUST" + number.ToString("D3");
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                string idPelanggan = dataGridView.SelectedRows[0].Cells["ID_Pelanggan"].Value.ToString();
                pelangganController.DeletePelanggan(idPelanggan);
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
                M_Pelanggan pelanggan = new M_Pelanggan
                {
                    ID_Pelanggan = textBoxIDPelanggan.Text,
                    NIK = textBoxNIK.Text,
                    Nama = textBoxNama.Text,
                    NomorTelepon = textBoxNomorTelepon.Text,
                    JenisKelamin = radioButtonLakiLaki.Checked ? "Laki-laki" : "Perempuan",
                    Alamat = textBoxAlamat.Text
                };

                pelangganController.UpdatePelanggan(pelanggan);
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
                textBoxIDPelanggan.Text = row.Cells["ID_Pelanggan"].Value.ToString();
                textBoxNIK.Text = row.Cells["NIK"].Value.ToString();
                textBoxNama.Text = row.Cells["Nama"].Value.ToString();
                textBoxNomorTelepon.Text = row.Cells["NomorTelepon"].Value.ToString();
                if (row.Cells["JenisKelamin"].Value.ToString() == "Laki-laki")
                {
                    radioButtonLakiLaki.Checked = true;
                }
                else
                {
                    radioButtonPerempuan.Checked = true;
                }
                textBoxAlamat.Text = row.Cells["Alamat"].Value.ToString();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            textBoxIDPelanggan.Clear();
            textBoxNIK.Clear();
            textBoxNama.Clear();
            textBoxNomorTelepon.Clear();
            radioButtonLakiLaki.Checked = false;
            radioButtonPerempuan.Checked = false;
            textBoxAlamat.Clear();
        }
    }
}