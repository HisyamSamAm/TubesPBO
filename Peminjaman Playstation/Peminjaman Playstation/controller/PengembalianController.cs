using MySql.Data.MySqlClient;
using Peminjaman_Playstation.model;
using System.Collections.Generic;

namespace Peminjaman_Playstation.controller
{
    public class PengembalianController
    {
        private koneksi db;

        public PengembalianController()
        {
            db = new koneksi();
        }

        public List<M_Pengembalian> GetAllPengembalian()
        {
            List<M_Pengembalian> listPengembalian = new List<M_Pengembalian>();

            string query = "SELECT * FROM pengembalian";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

            db.OpenConnection();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                M_Pengembalian pengembalian = new M_Pengembalian
                {
                    No_Transaksi = reader.GetString("No_Transaksi"),
                    Tanggal_Pengembalian = reader.GetDateTime("Tanggal_Pengembalian"),
                    Keterlambatan = reader.GetInt32("Keterlambatan"),
                    Denda_Per_Hari = reader.GetDecimal("Denda_Per_Hari"),
                    Total_Denda = reader.GetDecimal("Total_Denda"),
                    Total_Bayar = reader.GetDecimal("Total_Bayar"),
                    Bayar = reader.GetDecimal("Bayar"),
                    Kembalian = reader.GetDecimal("Kembalian"),
                    Nama_Admin = reader.GetString("Nama_Admin")
                };
                listPengembalian.Add(pengembalian);
            }

            reader.Close();
            db.CloseConnection();

            return listPengembalian;
        }

        // public M_Peminjaman GetPeminjamanByNoTransaksi(string noTransaksi)
        // {
        //     M_Peminjaman peminjaman = null;

        //     string query = "SELECT * FROM peminjaman WHERE No_Transaksi = @No_Transaksi";
        //     MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
        //     cmd.Parameters.AddWithValue("@No_Transaksi", noTransaksi);

        //     db.OpenConnection();
        //     MySqlDataReader reader = cmd.ExecuteReader();

        //     if (reader.Read())
        //     {
        //         peminjaman = new M_Peminjaman
        //         {
        //             No_Transaksi = reader.GetString("No_Transaksi"),
        //             ID_Pelanggan = reader.GetString("ID_Pelanggan"),
        //             ID_Playstation = reader.GetString("ID_Playstation"),
        //             Tanggal_Peminjaman = reader.GetDateTime("Tanggal_Peminjaman"),
        //             Tanggal_Pengembalian = reader.GetDateTime("Tanggal_Pengembalian"),
        //             Lama_Sewa = reader.GetInt32("Lama_Sewa"),
        //             Total_Harga = reader.GetDecimal("Total_Harga"),
        //             Nama_Admin = reader.GetString("Nama_Admin")
        //         };
        //     }

        //     reader.Close();
        //     db.CloseConnection();

        //     return peminjaman;
        // }

        public void InsertPengembalian(M_Pengembalian pengembalian)
        {
            string query = "INSERT INTO pengembalian (No_Transaksi, Tanggal_Pengembalian, Keterlambatan, Denda_Per_Hari, Total_Denda, Total_Bayar, Bayar, Kembalian, Nama_Admin) VALUES (@No_Transaksi, @Tanggal_Pengembalian, @Keterlambatan, @Denda_Per_Hari, @Total_Denda, @Total_Bayar, @Bayar, @Kembalian, @Nama_Admin)";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

            cmd.Parameters.AddWithValue("@No_Transaksi", pengembalian.No_Transaksi);
            cmd.Parameters.AddWithValue("@Tanggal_Pengembalian", pengembalian.Tanggal_Pengembalian);
            cmd.Parameters.AddWithValue("@Keterlambatan", pengembalian.Keterlambatan);
            cmd.Parameters.AddWithValue("@Denda_Per_Hari", pengembalian.Denda_Per_Hari);
            cmd.Parameters.AddWithValue("@Total_Denda", pengembalian.Total_Denda);
            cmd.Parameters.AddWithValue("@Total_Bayar", pengembalian.Total_Bayar);
            cmd.Parameters.AddWithValue("@Bayar", pengembalian.Bayar);
            cmd.Parameters.AddWithValue("@Kembalian", pengembalian.Kembalian);
            cmd.Parameters.AddWithValue("@Nama_Admin", pengembalian.Nama_Admin);

            db.OpenConnection();
            cmd.ExecuteNonQuery();
            db.CloseConnection();
        }

        public void DeletePengembalian(string noTransaksi)
        {
            string query = "DELETE FROM pengembalian WHERE No_Transaksi = @No_Transaksi";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

            cmd.Parameters.AddWithValue("@No_Transaksi", noTransaksi);

            db.OpenConnection();
            cmd.ExecuteNonQuery();
            db.CloseConnection();
        }
    }
}