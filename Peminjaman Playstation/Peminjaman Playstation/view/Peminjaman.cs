using Peminjaman_Playstation.controller;
using Peminjaman_Playstation.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Peminjaman_Playstation.view
{
    public partial class Peminjaman : Form
    {
        private PeminjamanController peminjamanController;
        private PelangganController pelangganController;
        private PlaystationController playstationController;

        public Peminjaman()
        {
            InitializeComponent();
            peminjamanController = new PeminjamanController();
            pelangganController = new PelangganController();
            playstationController = new PlaystationController();
            LoadData();
            LoadPelanggan();
            LoadPlaystation();
        }

        private void LoadData()
        {
            List<M_Peminjaman> listPeminjaman = peminjamanController.GetAllPeminjaman();
            dataGridViewTransactions.DataSource = listPeminjaman;
        }

        private void LoadPelanggan()
        {
            List<M_Pelanggan> listPelanggan = pelangganController.GetAllPelanggan();
            comboBoxIDPelanggan.DataSource = listPelanggan;
            comboBoxIDPelanggan.DisplayMember = "ID_Pelanggan";
            comboBoxIDPelanggan.ValueMember = "ID_Pelanggan";
        }

        private void LoadPlaystation()
        {
            List<M_Playstation> listPlaystation = playstationController.GetAllPlaystation();
            comboBoxIDPlaystation.DataSource = listPlaystation;
            comboBoxIDPlaystation.DisplayMember = "ID_Playstation";
            comboBoxIDPlaystation.ValueMember = "ID_Playstation";
        }

        private void comboBoxIDPelanggan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxIDPelanggan.SelectedItem != null)
            {
                string selectedID = comboBoxIDPelanggan.SelectedValue.ToString();
                M_Pelanggan pelanggan = peminjamanController.GetPelangganByID(selectedID);

                if (pelanggan != null)
                {
                    textBoxNIK.Text = pelanggan.NIK;
                    textBoxNamaPelanggan.Text = pelanggan.Nama;
                    textBoxNomorTelepon.Text = pelanggan.NomorTelepon;
                    textBoxAlamat.Text = pelanggan.Alamat;
                }
            }
        }

        private void comboBoxIDPlaystation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxIDPlaystation.SelectedItem != null)
            {
                string selectedID = comboBoxIDPlaystation.SelectedValue.ToString();
                M_Playstation playstation = peminjamanController.GetPlaystationByID(selectedID);

                if (playstation != null)
                {
                    comboBoxPlaystation.Text = playstation.Jenis_Playstation;
                    textBoxHarga.Text = playstation.Harga_Sewa_Per_Hari.ToString();
                }
            }
        }

        private string GenerateNewNoTransaksi(string lastNoTransaksi)
        {
            if (string.IsNullOrEmpty(lastNoTransaksi))
            {
                return "TRX001";
            }

            int number = int.Parse(lastNoTransaksi.Substring(3)) + 1;
            return "TRX" + number.ToString("D3");
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            string lastNoTransaksi = peminjamanController.GetLastNoTransaksi();
            string newNoTransaksi = GenerateNewNoTransaksi(lastNoTransaksi);
            textBoxNoTransaksi.Text = newNoTransaksi;
        }

        private void buttonHitungOtomatis_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBoxHarga.Text, out decimal harga) && int.TryParse(textBoxLamaSewa.Text, out int lamaSewa))
            {
                decimal totalHarga = harga * lamaSewa;
                textBoxTotalHarga.Text = totalHarga.ToString("F2");
            }
            else
            {
                MessageBox.Show("Pastikan harga dan lama sewa diisi dengan benar.");
            }
        }

        private void textBoxLamaSewa_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxLamaSewa.Text, out int lamaSewa))
            {
                DateTime tglPeminjaman = dateTimePickerTglPeminjaman.Value;
                DateTime tglPengembalian = tglPeminjaman.AddDays(lamaSewa);
                dateTimePickerTglPengembalian.Value = tglPengembalian;
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            M_Peminjaman peminjaman = new M_Peminjaman
            {
                No_Transaksi = textBoxNoTransaksi.Text,
                ID_Pelanggan = comboBoxIDPelanggan.SelectedValue.ToString(),
                ID_Playstation = comboBoxIDPlaystation.SelectedValue.ToString(),
                Tanggal_Peminjaman = dateTimePickerTglPeminjaman.Value,
                Tanggal_Pengembalian = dateTimePickerTglPengembalian.Value,
                Lama_Sewa = int.Parse(textBoxLamaSewa.Text),
                Total_Harga = decimal.Parse(textBoxTotalHarga.Text),
                Nama_Admin = textBoxNamaAdmin.Text
            };

            peminjamanController.InsertPeminjaman(peminjaman);
            LoadData();
            MessageBox.Show("Data peminjaman berhasil disimpan.");
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewTransactions.SelectedRows.Count > 0)
            {
                M_Peminjaman peminjaman = new M_Peminjaman
                {
                    No_Transaksi = textBoxNoTransaksi.Text,
                    ID_Pelanggan = comboBoxIDPelanggan.SelectedValue.ToString(),
                    ID_Playstation = comboBoxIDPlaystation.SelectedValue.ToString(),
                    Tanggal_Peminjaman = dateTimePickerTglPeminjaman.Value,
                    Tanggal_Pengembalian = dateTimePickerTglPengembalian.Value,
                    Lama_Sewa = int.Parse(textBoxLamaSewa.Text),
                    Total_Harga = decimal.Parse(textBoxTotalHarga.Text),
                    Nama_Admin = textBoxNamaAdmin.Text
                };

                peminjamanController.UpdatePeminjaman(peminjaman);
                LoadData();
                MessageBox.Show("Data peminjaman berhasil diubah.");
            }
            else
            {
                MessageBox.Show("Pilih data yang ingin diubah terlebih dahulu.");
            }
        }

        private void dataGridViewTransactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewTransactions.Rows[e.RowIndex];
                textBoxNoTransaksi.Text = row.Cells["No_Transaksi"].Value.ToString();
                comboBoxIDPelanggan.SelectedValue = row.Cells["ID_Pelanggan"].Value.ToString();
                comboBoxIDPlaystation.SelectedValue = row.Cells["ID_Playstation"].Value.ToString();
                dateTimePickerTglPeminjaman.Value = Convert.ToDateTime(row.Cells["Tanggal_Peminjaman"].Value);
                dateTimePickerTglPengembalian.Value = Convert.ToDateTime(row.Cells["Tanggal_Pengembalian"].Value);
                textBoxLamaSewa.Text = row.Cells["Lama_Sewa"].Value.ToString();
                textBoxTotalHarga.Text = row.Cells["Total_Harga"].Value.ToString();
                textBoxNamaAdmin.Text = row.Cells["Nama_Admin"].Value.ToString();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            textBoxNoTransaksi.Clear();
            comboBoxIDPelanggan.SelectedIndex = -1;
            comboBoxIDPlaystation.SelectedIndex = -1;
            comboBoxPlaystation.SelectedIndex = -1;
            dateTimePickerTglPeminjaman.Value = DateTime.Now;
            dateTimePickerTglPengembalian.Value = DateTime.Now;
            textBoxLamaSewa.Clear();
            textBoxTotalHarga.Clear();
            textBoxNamaAdmin.Clear();
            textBoxNIK.Clear();
            textBoxNamaPelanggan.Clear();
            textBoxNomorTelepon.Clear();
            textBoxAlamat.Clear();
            textBoxHarga.Clear();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (dataGridViewTransactions.SelectedRows.Count > 0)
            {
                string noTransaksi = dataGridViewTransactions.SelectedRows[0].Cells["No_Transaksi"].Value.ToString();
                peminjamanController.DeletePeminjaman(noTransaksi);
                LoadData();
                ClearForm();
                MessageBox.Show("Data peminjaman berhasil dihapus.");
            }
            else
            {
                MessageBox.Show("Pilih data yang ingin dihapus terlebih dahulu.");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Excel excel = new Excel();
            excel.ExportToExcel(dataGridViewTransactions, "Data Peminjaman");

        }

    }
}