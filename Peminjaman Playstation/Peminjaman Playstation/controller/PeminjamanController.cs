using MySql.Data.MySqlClient;
using Peminjaman_Playstation.model;
using System.Collections.Generic;

namespace Peminjaman_Playstation.controller
{
    public class PeminjamanController
    {
        private koneksi db;

        public PeminjamanController()
        {
            db = new koneksi();
        }

        public List<M_Peminjaman> GetAllPeminjaman()
        {
            List<M_Peminjaman> listPeminjaman = new List<M_Peminjaman>();

            string query = "SELECT * FROM peminjaman";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

            db.OpenConnection();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                M_Peminjaman peminjaman = new M_Peminjaman
                {
                    No_Transaksi = reader.GetString("No_Transaksi"),
                    ID_Pelanggan = reader.GetString("ID_Pelanggan"),
                    ID_Playstation = reader.GetString("ID_Playstation"),
                    Tanggal_Peminjaman = reader.GetDateTime("Tanggal_Peminjaman"),
                    Tanggal_Pengembalian = reader.GetDateTime("Tanggal_Pengembalian"),
                    Lama_Sewa = reader.GetInt32("Lama_Sewa"),
                    Total_Harga = reader.GetDecimal("Total_Harga"),
                    Nama_Admin = reader.GetString("Nama_Admin")
                };
                listPeminjaman.Add(peminjaman);
            }

            reader.Close();
            db.CloseConnection();

            return listPeminjaman;
        }

        public M_Peminjaman GetPeminjamanByNoTransaksi(string noTransaksi)
        {
            M_Peminjaman peminjaman = null;

            string query = "SELECT * FROM peminjaman WHERE No_Transaksi = @No_Transaksi";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@No_Transaksi", noTransaksi);

            db.OpenConnection();
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                peminjaman = new M_Peminjaman
                {
                    No_Transaksi = reader.GetString("No_Transaksi"),
                    ID_Pelanggan = reader.GetString("ID_Pelanggan"),
                    ID_Playstation = reader.GetString("ID_Playstation"),
                    Tanggal_Peminjaman = reader.GetDateTime("Tanggal_Peminjaman"),
                    Tanggal_Pengembalian = reader.GetDateTime("Tanggal_Pengembalian"),
                    Lama_Sewa = reader.GetInt32("Lama_Sewa"),
                    Total_Harga = reader.GetDecimal("Total_Harga"),
                    Nama_Admin = reader.GetString("Nama_Admin")
                };
            }

            reader.Close();
            db.CloseConnection();

            return peminjaman;
        }

        public M_Pelanggan GetPelangganByID(string idPelanggan)
        {
            M_Pelanggan pelanggan = null;

            string query = "SELECT * FROM pelanggan WHERE ID_Pelanggan = @ID_Pelanggan";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@ID_Pelanggan", idPelanggan);

            db.OpenConnection();
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                pelanggan = new M_Pelanggan
                {
                    ID_Pelanggan = reader.GetString("ID_Pelanggan"),
                    NIK = reader.GetString("NIK"),
                    Nama = reader.GetString("Nama"),
                    NomorTelepon = reader.GetString("Nomor_Telepon"),
                    JenisKelamin = reader.GetString("Jenis_Kelamin"),
                    Alamat = reader.GetString("Alamat")
                };
            }

            reader.Close();
            db.CloseConnection();

            return pelanggan;
        }

        public M_Playstation GetPlaystationByID(string idPlaystation)
        {
            M_Playstation playstation = null;

            string query = "SELECT * FROM playstation WHERE ID_Playstation = @ID_Playstation";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());
            cmd.Parameters.AddWithValue("@ID_Playstation", idPlaystation);

            db.OpenConnection();
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                playstation = new M_Playstation
                {
                    ID_Playstation = reader.GetString("ID_Playstation"),
                    Jenis_Playstation = reader.GetString("Jenis_Playstation"),
                    Harga_Sewa_Per_Hari = reader.GetDecimal("Harga_Sewa_Per_Hari")
                };
            }

            reader.Close();
            db.CloseConnection();

            return playstation;
        }

        public string GetLastNoTransaksi()
        {
            string lastNoTransaksi = null;

            string query = "SELECT No_Transaksi FROM peminjaman ORDER BY No_Transaksi DESC LIMIT 1";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

            db.OpenConnection();
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lastNoTransaksi = reader.GetString("No_Transaksi");
            }

            reader.Close();
            db.CloseConnection();

            return lastNoTransaksi;
        }

        public void InsertPeminjaman(M_Peminjaman peminjaman)
        {
            string query = "INSERT INTO peminjaman (No_Transaksi, ID_Pelanggan, ID_Playstation, Tanggal_Peminjaman, Tanggal_Pengembalian, Lama_Sewa, Total_Harga, Nama_Admin) VALUES (@No_Transaksi, @ID_Pelanggan, @ID_Playstation, @Tanggal_Peminjaman, @Tanggal_Pengembalian, @Lama_Sewa, @Total_Harga, @Nama_Admin)";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

            cmd.Parameters.AddWithValue("@No_Transaksi", peminjaman.No_Transaksi);
            cmd.Parameters.AddWithValue("@ID_Pelanggan", peminjaman.ID_Pelanggan);
            cmd.Parameters.AddWithValue("@ID_Playstation", peminjaman.ID_Playstation);
            cmd.Parameters.AddWithValue("@Tanggal_Peminjaman", peminjaman.Tanggal_Peminjaman);
            cmd.Parameters.AddWithValue("@Tanggal_Pengembalian", peminjaman.Tanggal_Pengembalian);
            cmd.Parameters.AddWithValue("@Lama_Sewa", peminjaman.Lama_Sewa);
            cmd.Parameters.AddWithValue("@Total_Harga", peminjaman.Total_Harga);
            cmd.Parameters.AddWithValue("@Nama_Admin", peminjaman.Nama_Admin);

            db.OpenConnection();
            cmd.ExecuteNonQuery();
            db.CloseConnection();
        }

        public void UpdatePeminjaman(M_Peminjaman peminjaman)
        {
            string query = "UPDATE peminjaman SET ID_Pelanggan = @ID_Pelanggan, ID_Playstation = @ID_Playstation, Tanggal_Peminjaman = @Tanggal_Peminjaman, Tanggal_Pengembalian = @Tanggal_Pengembalian, Lama_Sewa = @Lama_Sewa, Total_Harga = @Total_Harga, Nama_Admin = @Nama_Admin WHERE No_Transaksi = @No_Transaksi";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

            cmd.Parameters.AddWithValue("@No_Transaksi", peminjaman.No_Transaksi);
            cmd.Parameters.AddWithValue("@ID_Pelanggan", peminjaman.ID_Pelanggan);
            cmd.Parameters.AddWithValue("@ID_Playstation", peminjaman.ID_Playstation);
            cmd.Parameters.AddWithValue("@Tanggal_Peminjaman", peminjaman.Tanggal_Peminjaman);
            cmd.Parameters.AddWithValue("@Tanggal_Pengembalian", peminjaman.Tanggal_Pengembalian);
            cmd.Parameters.AddWithValue("@Lama_Sewa", peminjaman.Lama_Sewa);
            cmd.Parameters.AddWithValue("@Total_Harga", peminjaman.Total_Harga);
            cmd.Parameters.AddWithValue("@Nama_Admin", peminjaman.Nama_Admin);

            db.OpenConnection();
            cmd.ExecuteNonQuery();
            db.CloseConnection();
        }

        public void DeletePeminjaman(string noTransaksi)
        {
            string query = "DELETE FROM peminjaman WHERE No_Transaksi = @No_Transaksi";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

            cmd.Parameters.AddWithValue("@No_Transaksi", noTransaksi);

            db.OpenConnection();
            cmd.ExecuteNonQuery();
            db.CloseConnection();
        }
    }
}