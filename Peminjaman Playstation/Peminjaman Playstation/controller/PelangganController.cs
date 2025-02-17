using MySql.Data.MySqlClient;
using Peminjaman_Playstation.model;
using System.Collections.Generic;

namespace Peminjaman_Playstation.controller
{
    public class PelangganController
    {
        private koneksi db;

        public PelangganController()
        {
            db = new koneksi();
        }

        public List<M_Pelanggan> GetAllPelanggan()
        {
            List<M_Pelanggan> listPelanggan = new List<M_Pelanggan>();

            string query = "SELECT * FROM pelanggan";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

            db.OpenConnection();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                M_Pelanggan pelanggan = new M_Pelanggan
                {
                    ID_Pelanggan = reader.GetString("ID_Pelanggan"),
                    NIK = reader.GetString("NIK"),
                    Nama = reader.GetString("Nama"),
                    NomorTelepon = reader.GetString("Nomor_Telepon"),
                    JenisKelamin = reader.GetString("Jenis_Kelamin"),
                    Alamat = reader.GetString("Alamat")
                };
                listPelanggan.Add(pelanggan);
            }

            reader.Close();
            db.CloseConnection();

            return listPelanggan;
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

        public void InsertPelanggan(M_Pelanggan pelanggan)
        {
            string query = "INSERT INTO pelanggan (ID_Pelanggan, NIK, Nama, Nomor_Telepon, Jenis_Kelamin, Alamat) VALUES (@ID_Pelanggan, @NIK, @Nama, @Nomor_Telepon, @Jenis_Kelamin, @Alamat)";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

            cmd.Parameters.AddWithValue("@ID_Pelanggan", pelanggan.ID_Pelanggan);
            cmd.Parameters.AddWithValue("@NIK", pelanggan.NIK);
            cmd.Parameters.AddWithValue("@Nama", pelanggan.Nama);
            cmd.Parameters.AddWithValue("@Nomor_Telepon", pelanggan.NomorTelepon);
            cmd.Parameters.AddWithValue("@Jenis_Kelamin", pelanggan.JenisKelamin);
            cmd.Parameters.AddWithValue("@Alamat", pelanggan.Alamat);

            db.OpenConnection();
            cmd.ExecuteNonQuery();
            db.CloseConnection();
        }

        public void DeletePelanggan(string idPelanggan)
        {
            string query = "DELETE FROM pelanggan WHERE ID_Pelanggan = @ID_Pelanggan";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

            cmd.Parameters.AddWithValue("@ID_Pelanggan", idPelanggan);

            db.OpenConnection();
            cmd.ExecuteNonQuery();
            db.CloseConnection();
        }

        public void UpdatePelanggan(M_Pelanggan pelanggan)
        {
            string query = "UPDATE pelanggan SET NIK = @NIK, Nama = @Nama, Nomor_Telepon = @Nomor_Telepon, Jenis_Kelamin = @Jenis_Kelamin, Alamat = @Alamat WHERE ID_Pelanggan = @ID_Pelanggan";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

            cmd.Parameters.AddWithValue("@ID_Pelanggan", pelanggan.ID_Pelanggan);
            cmd.Parameters.AddWithValue("@NIK", pelanggan.NIK);
            cmd.Parameters.AddWithValue("@Nama", pelanggan.Nama);
            cmd.Parameters.AddWithValue("@Nomor_Telepon", pelanggan.NomorTelepon);
            cmd.Parameters.AddWithValue("@Jenis_Kelamin", pelanggan.JenisKelamin);
            cmd.Parameters.AddWithValue("@Alamat", pelanggan.Alamat);

            db.OpenConnection();
            cmd.ExecuteNonQuery();
            db.CloseConnection();
        }

        public string GetLastIDPelanggan()
        {
            string lastID = null;
            string query = "SELECT ID_Pelanggan FROM pelanggan ORDER BY ID_Pelanggan DESC LIMIT 1";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

            db.OpenConnection();
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lastID = reader.GetString("ID_Pelanggan");
            }

            reader.Close();
            db.CloseConnection();

            return lastID;
        }
    }
}
