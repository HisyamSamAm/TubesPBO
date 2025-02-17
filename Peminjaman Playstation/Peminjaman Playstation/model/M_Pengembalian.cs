using System;

namespace Peminjaman_Playstation.model
{
    public class M_Pengembalian
    {
        public string No_Transaksi { get; set; }
        public DateTime Tanggal_Pengembalian { get; set; }
        public int Keterlambatan { get; set; }
        public decimal Denda_Per_Hari { get; set; }
        public decimal Total_Denda { get; set; }
        public decimal Total_Bayar { get; set; }
        public decimal Bayar { get; set; }
        public decimal Kembalian { get; set; }
        public string Nama_Admin { get; set; }
    }
}