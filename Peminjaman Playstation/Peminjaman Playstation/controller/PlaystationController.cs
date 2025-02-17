using MySql.Data.MySqlClient;
using Peminjaman_Playstation.model;
using System.Collections.Generic;

namespace Peminjaman_Playstation.controller
{
    public class PlaystationController
    {
        private koneksi db;

        public PlaystationController()
        {
            db = new koneksi();
        }

        public List<M_Playstation> GetAllPlaystation()
        {
            List<M_Playstation> listPlaystation = new List<M_Playstation>();

            string query = "SELECT * FROM playstation";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

            db.OpenConnection();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                M_Playstation playstation = new M_Playstation
                {
                    ID_Playstation = reader.GetString("ID_Playstation"),
                    Jenis_Playstation = reader.GetString("Jenis_Playstation"),
                    Harga_Sewa_Per_Hari = reader.GetDecimal("Harga_Sewa_Per_Hari")
                };
                listPlaystation.Add(playstation);
            }

            reader.Close();
            db.CloseConnection();

            return listPlaystation;
        }

        public void InsertPlaystation(M_Playstation playstation)
        {
            string query = "INSERT INTO playstation (ID_Playstation, Jenis_Playstation, Harga_Sewa_Per_Hari) VALUES (@ID_Playstation, @Jenis_Playstation, @Harga_Sewa_Per_Hari)";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

            cmd.Parameters.AddWithValue("@ID_Playstation", playstation.ID_Playstation);
            cmd.Parameters.AddWithValue("@Jenis_Playstation", playstation.Jenis_Playstation);
            cmd.Parameters.AddWithValue("@Harga_Sewa_Per_Hari", playstation.Harga_Sewa_Per_Hari);

            db.OpenConnection();
            cmd.ExecuteNonQuery();
            db.CloseConnection();
        }

        public void UpdatePlaystation(M_Playstation playstation)
        {
            string query = "UPDATE playstation SET Jenis_Playstation = @Jenis_Playstation, Harga_Sewa_Per_Hari = @Harga_Sewa_Per_Hari WHERE ID_Playstation = @ID_Playstation";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

            cmd.Parameters.AddWithValue("@ID_Playstation", playstation.ID_Playstation);
            cmd.Parameters.AddWithValue("@Jenis_Playstation", playstation.Jenis_Playstation);
            cmd.Parameters.AddWithValue("@Harga_Sewa_Per_Hari", playstation.Harga_Sewa_Per_Hari);

            db.OpenConnection();
            cmd.ExecuteNonQuery();
            db.CloseConnection();
        }

        public void DeletePlaystation(string idPlaystation)
        {
            string query = "DELETE FROM playstation WHERE ID_Playstation = @ID_Playstation";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

            cmd.Parameters.AddWithValue("@ID_Playstation", idPlaystation);

            db.OpenConnection();
            cmd.ExecuteNonQuery();
            db.CloseConnection();
        }

        public string GetLastIDPlaystation()
        {
            string lastID = null;
            string query = "SELECT ID_Playstation FROM playstation ORDER BY ID_Playstation DESC LIMIT 1";
            MySqlCommand cmd = new MySqlCommand(query, db.GetConnection());

            db.OpenConnection();
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lastID = reader.GetString("ID_Playstation");
            }

            reader.Close();
            db.CloseConnection();

            return lastID;
        }
    }
}