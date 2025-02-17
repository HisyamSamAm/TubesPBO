using System;

namespace Peminjaman_Playstation.model
{
    public class M_Peminjaman
    {
        public string No_Transaksi { get; set; }
        public string ID_Pelanggan { get; set; }
        public string ID_Playstation { get; set; }
        public DateTime Tanggal_Peminjaman { get; set; }
        public DateTime Tanggal_Pengembalian { get; set; }
        public int Lama_Sewa { get; set; }
        public decimal Total_Harga { get; set; }
        public string Nama_Admin { get; set; }
    }
}