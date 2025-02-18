using Peminjaman_Playstation.controller;
using Peminjaman_Playstation.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Peminjaman_Playstation.view
{
    public partial class Pengembalian : Form
    {
        private PengembalianController pengembalianController;
        private PeminjamanController peminjamanController;
        private PelangganController pelangganController;
        private PlaystationController playstationController;

        public Pengembalian()
        {
            InitializeComponent();
            pengembalianController = new PengembalianController();
            peminjamanController = new PeminjamanController();
            pelangganController = new PelangganController();
            playstationController = new PlaystationController();
            LoadData();
            LoadNoTransaksi();
            LoadPelanggan();
            LoadPlaystation();
        }

        private void LoadData()
        {
            List<M_Pengembalian> listPengembalian = pengembalianController.GetAllPengembalian();
            dataGridViewPengembalian.DataSource = listPengembalian;
        }

        private void LoadNoTransaksi()
        {
            List<M_Peminjaman> listPeminjaman = peminjamanController.GetAllPeminjaman();
            comboBoxNoTransaksi.DataSource = listPeminjaman;
            comboBoxNoTransaksi.DisplayMember = "No_Transaksi";
            comboBoxNoTransaksi.ValueMember = "No_Transaksi";
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

        private void comboBoxNoTransaksi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNoTransaksi.SelectedItem != null)
            {
                string selectedNoTransaksi = comboBoxNoTransaksi.SelectedValue.ToString();
                M_Peminjaman peminjaman = peminjamanController.GetPeminjamanByNoTransaksi(selectedNoTransaksi);

                if (peminjaman != null)
                {
                    comboBoxIDPelanggan.SelectedValue = peminjaman.ID_Pelanggan;
                    comboBoxIDPlaystation.SelectedValue = peminjaman.ID_Playstation;
                    dateTimePickerTglPengembalian.Value = peminjaman.Tanggal_Pengembalian;
                    textBoxTotalHarga.Text = peminjaman.Total_Harga.ToString("F2");
                    textBoxNamaAdmin.Text = peminjaman.Nama_Admin;

                    M_Pelanggan pelanggan = pelangganController.GetPelangganByID(peminjaman.ID_Pelanggan);
                    if (pelanggan != null)
                    {
                        textBoxNamaPelanggan.Text = pelanggan.Nama;
                        textBoxNomorTelepon.Text = pelanggan.NomorTelepon;
                        textBoxAlamat.Text = pelanggan.Alamat;
                    }

                    M_Playstation playstation = peminjamanController.GetPlaystationByID(peminjaman.ID_Playstation);
                    if (playstation != null)
                    {
                        comboBoxPlaystation.Text = playstation.Jenis_Playstation;
                    }
                }
            }
        }

        private void buttonHitung_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBoxTotalBayar.Text, out decimal totalBayar) &&
                decimal.TryParse(textBoxBayar.Text, out decimal bayar))
            {
                decimal kembalian = bayar - totalBayar;
                textBoxKembalian.Text = kembalian.ToString("F2");
            }
            else
            {
                MessageBox.Show("Pastikan total bayar dan bayar diisi dengan benar.");
            }
        }

        private void buttonHitungDenda_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxKeterlambatan.Text, out int keterlambatan) &&
                decimal.TryParse(textBoxDendaHari.Text, out decimal dendaPerHari) &&
                decimal.TryParse(textBoxTotalHarga.Text, out decimal totalHarga))
            {
                decimal totalDenda = keterlambatan * dendaPerHari;
                textBoxTotalDenda.Text = totalDenda.ToString("F2");

                decimal totalBayar = totalHarga + totalDenda;
                textBoxTotalBayar.Text = totalBayar.ToString("F2");
            }
            else
            {
                MessageBox.Show("Pastikan keterlambatan, denda per hari, dan total harga diisi dengan benar.");
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            M_Pengembalian pengembalian = new M_Pengembalian
            {
                No_Transaksi = comboBoxNoTransaksi.SelectedValue.ToString(),
                Tanggal_Pengembalian = dateTimePickerTglPengembalian.Value,
                Keterlambatan = int.Parse(textBoxKeterlambatan.Text),
                Denda_Per_Hari = decimal.Parse(textBoxDendaHari.Text),
                Total_Denda = decimal.Parse(textBoxTotalDenda.Text),
                Total_Bayar = decimal.Parse(textBoxTotalBayar.Text),
                Bayar = decimal.Parse(textBoxBayar.Text),
                Kembalian = decimal.Parse(textBoxKembalian.Text),
                Nama_Admin = textBoxNamaAdmin.Text
            };

            pengembalianController.InsertPengembalian(pengembalian);
            LoadData();
            MessageBox.Show("Data pengembalian berhasil disimpan.");
        }

        private void dataGridViewPengembalian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewPengembalian.Rows[e.RowIndex];
                comboBoxNoTransaksi.SelectedValue = row.Cells["No_Transaksi"].Value.ToString();
                // comboBoxIDPelanggan.SelectedValue = row.Cells["ID_Pelanggan"].Value.ToString();
                // comboBoxIDPlaystation.SelectedValue = row.Cells["ID_Playstation"].Value.ToString();
                dateTimePickerTglPengembalian.Value = Convert.ToDateTime(row.Cells["Tanggal_Pengembalian"].Value);
                // textBoxTotalHarga.Text = row.Cells["Total_Harga"].Value.ToString();
                textBoxNamaAdmin.Text = row.Cells["Nama_Admin"].Value.ToString();
                textBoxKeterlambatan.Text = row.Cells["Keterlambatan"].Value.ToString();
                textBoxDendaHari.Text = row.Cells["Denda_Per_Hari"].Value.ToString();
                textBoxTotalDenda.Text = row.Cells["Total_Denda"].Value.ToString();
                textBoxTotalBayar.Text = row.Cells["Total_Bayar"].Value.ToString();
                textBoxBayar.Text = row.Cells["Bayar"].Value.ToString();
                textBoxKembalian.Text = row.Cells["Kembalian"].Value.ToString();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewPengembalian.SelectedRows.Count > 0)
            {
                string noTransaksi = dataGridViewPengembalian.SelectedRows[0].Cells["No_Transaksi"].Value.ToString();
                pengembalianController.DeletePengembalian(noTransaksi);
                LoadData();
                MessageBox.Show("Data pengembalian berhasil dihapus.");
            }
            else
            {
                MessageBox.Show("Pilih data yang ingin dihapus terlebih dahulu.");
            }
        }


        private void btnPengembalian_Click(object sender, EventArgs e)
        {
            Excel excel = new Excel();
            excel.ExportToExcel(dataGridViewPengembalian, "Data Pengembalian");
        }

    }
}