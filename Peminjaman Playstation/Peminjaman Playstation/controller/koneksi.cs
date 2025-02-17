using System;
using MySql.Data.MySqlClient;

namespace Peminjaman_Playstation.controller
{
    internal class koneksi
    {
        private MySqlConnection connection;

        public koneksi()
        {
            Initialize();
        }

        private void Initialize()
        {
<<<<<<< HEAD
            string connectionString = "SERVER=localhost;DATABASE=peminjaman_playstation;UID=root;PASSWORD=;";

=======
            string connectionString = "SERVER=localhost;DATABASE=peminjaman_playstation;UID=root;PASSWORD=your_password;";
>>>>>>> cd6e5473f23f1e8968889d660bfa295ab911647f
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
