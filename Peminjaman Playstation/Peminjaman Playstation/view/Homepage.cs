using Peminjaman_Playstation.model;
using Peminjaman_Playstation.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Peminjaman_Playstation
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void pelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pelanggan pelangganForm = new Pelanggan();
            pelangganForm.MdiParent = this; // Set the MDI parent to Homepage
            pelangganForm.Show(); // Show the Pelanggan form within the Homepage
        }

        private void playstationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Playstation playstationForm = new Playstation();
            playstationForm.MdiParent = this;
            playstationForm.Show();
        }

        private void peminjamanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Peminjaman peminjamanForm = new Peminjaman();
            peminjamanForm.MdiParent = this;
            peminjamanForm.Show();
        }

        private void pengembalianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pengembalian pengembalianForm = new Pengembalian();
            pengembalianForm.MdiParent = this;
            pengembalianForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
