namespace Peminjaman_Playstation.view
{
    partial class Pengembalian
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelNamaAdmin = new System.Windows.Forms.Label();
            this.labelIDPelanggan = new System.Windows.Forms.Label();
            this.labelNamaPelanggan = new System.Windows.Forms.Label();
            this.labelNomorTelepon = new System.Windows.Forms.Label();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.labelNoTransaksi = new System.Windows.Forms.Label();
            this.labelTglPengembalian = new System.Windows.Forms.Label();
            this.labelIDPlaystation = new System.Windows.Forms.Label();
            this.labelPlaystation = new System.Windows.Forms.Label();
            this.labelTotalHarga = new System.Windows.Forms.Label();
            this.labelKeterlambatan = new System.Windows.Forms.Label();
            this.labelDendaHari = new System.Windows.Forms.Label();
            this.labelTotalDenda = new System.Windows.Forms.Label();
            this.labelTotalBayar = new System.Windows.Forms.Label();
            this.labelBayar = new System.Windows.Forms.Label();
            this.labelKembalian = new System.Windows.Forms.Label();
            this.textBoxNamaAdmin = new System.Windows.Forms.TextBox();
            this.textBoxNamaPelanggan = new System.Windows.Forms.TextBox();
            this.textBoxNomorTelepon = new System.Windows.Forms.TextBox();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.textBoxTotalHarga = new System.Windows.Forms.TextBox();
            this.textBoxKeterlambatan = new System.Windows.Forms.TextBox();
            this.textBoxDendaHari = new System.Windows.Forms.TextBox();
            this.textBoxTotalDenda = new System.Windows.Forms.TextBox();
            this.textBoxTotalBayar = new System.Windows.Forms.TextBox();
            this.textBoxBayar = new System.Windows.Forms.TextBox();
            this.textBoxKembalian = new System.Windows.Forms.TextBox();
            this.comboBoxIDPelanggan = new System.Windows.Forms.ComboBox();
            this.comboBoxNoTransaksi = new System.Windows.Forms.ComboBox();
            this.comboBoxIDPlaystation = new System.Windows.Forms.ComboBox();
            this.comboBoxPlaystation = new System.Windows.Forms.ComboBox();
            this.dateTimePickerTglPengembalian = new System.Windows.Forms.DateTimePicker();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonHitung = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewPengembalian = new System.Windows.Forms.DataGridView();
            this.buttonHitungDenda = new System.Windows.Forms.Button();
            this.btnPengembalian = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPengembalian)).BeginInit();
            this.SuspendLayout();
            this.buttonHitungDenda = new System.Windows.Forms.Button();
            // 
            // labelNamaAdmin
            // 
            this.labelNamaAdmin.Location = new System.Drawing.Point(20, 30);
            this.labelNamaAdmin.Name = "labelNamaAdmin";
            this.labelNamaAdmin.Size = new System.Drawing.Size(100, 20);
            this.labelNamaAdmin.TabIndex = 0;
            this.labelNamaAdmin.Text = "Nama Admin";
            // 
            // labelIDPelanggan
            // 
            this.labelIDPelanggan.Location = new System.Drawing.Point(20, 60);
            this.labelIDPelanggan.Name = "labelIDPelanggan";
            this.labelIDPelanggan.Size = new System.Drawing.Size(100, 20);
            this.labelIDPelanggan.TabIndex = 1;
            this.labelIDPelanggan.Text = "ID Pelanggan";
            // 
            // labelNamaPelanggan
            // 
            this.labelNamaPelanggan.Location = new System.Drawing.Point(20, 90);
            this.labelNamaPelanggan.Name = "labelNamaPelanggan";
            this.labelNamaPelanggan.Size = new System.Drawing.Size(100, 20);
            this.labelNamaPelanggan.TabIndex = 2;
            this.labelNamaPelanggan.Text = "Nama Pelanggan";
            // 
            // labelNomorTelepon
            // 
            this.labelNomorTelepon.Location = new System.Drawing.Point(20, 120);
            this.labelNomorTelepon.Name = "labelNomorTelepon";
            this.labelNomorTelepon.Size = new System.Drawing.Size(100, 20);
            this.labelNomorTelepon.TabIndex = 3;
            this.labelNomorTelepon.Text = "Nomor Telepon";
            // 
            // labelAlamat
            // 
            this.labelAlamat.Location = new System.Drawing.Point(20, 150);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(100, 20);
            this.labelAlamat.TabIndex = 4;
            this.labelAlamat.Text = "Alamat";
            // 
            // labelNoTransaksi
            // 
            this.labelNoTransaksi.Location = new System.Drawing.Point(346, 30);
            this.labelNoTransaksi.Name = "labelNoTransaksi";
            this.labelNoTransaksi.Size = new System.Drawing.Size(100, 20);
            this.labelNoTransaksi.TabIndex = 5;
            this.labelNoTransaksi.Text = "No. Transaksi";
            // 
            // labelTglPengembalian
            // 
            this.labelTglPengembalian.Location = new System.Drawing.Point(346, 60);
            this.labelTglPengembalian.Name = "labelTglPengembalian";
            this.labelTglPengembalian.Size = new System.Drawing.Size(130, 20);
            this.labelTglPengembalian.TabIndex = 6;
            this.labelTglPengembalian.Text = "Tgl. Pengembalian";
            // 
            // labelIDPlaystation
            // 
            this.labelIDPlaystation.Location = new System.Drawing.Point(346, 90);
            this.labelIDPlaystation.Name = "labelIDPlaystation";
            this.labelIDPlaystation.Size = new System.Drawing.Size(100, 20);
            this.labelIDPlaystation.TabIndex = 7;
            this.labelIDPlaystation.Text = "ID Playstation";
            // 
            // labelPlaystation
            // 
            this.labelPlaystation.Location = new System.Drawing.Point(346, 120);
            this.labelPlaystation.Name = "labelPlaystation";
            this.labelPlaystation.Size = new System.Drawing.Size(100, 20);
            this.labelPlaystation.TabIndex = 8;
            this.labelPlaystation.Text = "Playstation";
            // 
            // labelTotalHarga
            // 
            this.labelTotalHarga.Location = new System.Drawing.Point(346, 150);
            this.labelTotalHarga.Name = "labelTotalHarga";
            this.labelTotalHarga.Size = new System.Drawing.Size(100, 20);
            this.labelTotalHarga.TabIndex = 9;
            this.labelTotalHarga.Text = "Total Harga";
            // 
            // labelKeterlambatan
            // 
            this.labelKeterlambatan.Location = new System.Drawing.Point(346, 183);
            this.labelKeterlambatan.Name = "labelKeterlambatan";
            this.labelKeterlambatan.Size = new System.Drawing.Size(100, 20);
            this.labelKeterlambatan.TabIndex = 10;
            this.labelKeterlambatan.Text = "Keterlambatan";
            // 
            // labelDendaHari
            // 
            this.labelDendaHari.Location = new System.Drawing.Point(346, 213);
            this.labelDendaHari.Name = "labelDendaHari";
            this.labelDendaHari.Size = new System.Drawing.Size(100, 20);
            this.labelDendaHari.TabIndex = 11;
            this.labelDendaHari.Text = "Denda / Hari";
            // 
            // labelTotalDenda
            // 
            this.labelTotalDenda.Location = new System.Drawing.Point(346, 243);
            this.labelTotalDenda.Name = "labelTotalDenda";
            this.labelTotalDenda.Size = new System.Drawing.Size(100, 20);
            this.labelTotalDenda.TabIndex = 12;
            this.labelTotalDenda.Text = "Total Denda";
            // 
            // labelTotalBayar
            // 
            this.labelTotalBayar.Location = new System.Drawing.Point(346, 273);
            this.labelTotalBayar.Name = "labelTotalBayar";
            this.labelTotalBayar.Size = new System.Drawing.Size(100, 20);
            this.labelTotalBayar.TabIndex = 13;
            this.labelTotalBayar.Text = "Total Bayar";
            // 
            // labelBayar
            // 
            this.labelBayar.Location = new System.Drawing.Point(346, 303);
            this.labelBayar.Name = "labelBayar";
            this.labelBayar.Size = new System.Drawing.Size(100, 20);
            this.labelBayar.TabIndex = 14;
            this.labelBayar.Text = "Bayar";
            // 
            // labelKembalian
            // 
            this.labelKembalian.Location = new System.Drawing.Point(346, 333);
            this.labelKembalian.Name = "labelKembalian";
            this.labelKembalian.Size = new System.Drawing.Size(100, 20);
            this.labelKembalian.TabIndex = 15;
            this.labelKembalian.Text = "Kembalian";
            // 
            // textBoxNamaAdmin
            // 
            this.textBoxNamaAdmin.Location = new System.Drawing.Point(130, 30);
            this.textBoxNamaAdmin.Name = "textBoxNamaAdmin";
            this.textBoxNamaAdmin.Size = new System.Drawing.Size(200, 22);
            this.textBoxNamaAdmin.TabIndex = 16;
            // 
            // textBoxNamaPelanggan
            // 
            this.textBoxNamaPelanggan.Location = new System.Drawing.Point(130, 90);
            this.textBoxNamaPelanggan.Name = "textBoxNamaPelanggan";
            this.textBoxNamaPelanggan.Size = new System.Drawing.Size(200, 22);
            this.textBoxNamaPelanggan.TabIndex = 17;
            // 
            // textBoxNomorTelepon
            // 
            this.textBoxNomorTelepon.Location = new System.Drawing.Point(130, 120);
            this.textBoxNomorTelepon.Name = "textBoxNomorTelepon";
            this.textBoxNomorTelepon.Size = new System.Drawing.Size(200, 22);
            this.textBoxNomorTelepon.TabIndex = 18;
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Location = new System.Drawing.Point(130, 150);
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(200, 22);
            this.textBoxAlamat.TabIndex = 19;
            // 
            // textBoxTotalHarga
            // 
            this.textBoxTotalHarga.Location = new System.Drawing.Point(482, 150);
            this.textBoxTotalHarga.Name = "textBoxTotalHarga";
            this.textBoxTotalHarga.Size = new System.Drawing.Size(248, 22);
            this.textBoxTotalHarga.TabIndex = 20;
            // 
            // textBoxKeterlambatan
            // 
            this.textBoxKeterlambatan.Location = new System.Drawing.Point(482, 183);
            this.textBoxKeterlambatan.Name = "textBoxKeterlambatan";
            this.textBoxKeterlambatan.Size = new System.Drawing.Size(248, 22);
            this.textBoxKeterlambatan.TabIndex = 21;
            // 
            // textBoxDendaHari
            // 
            this.textBoxDendaHari.Location = new System.Drawing.Point(482, 213);
            this.textBoxDendaHari.Name = "textBoxDendaHari";
            this.textBoxDendaHari.Size = new System.Drawing.Size(248, 22);
            this.textBoxDendaHari.TabIndex = 22;
            // 
            // textBoxTotalDenda
            // 
            this.textBoxTotalDenda.Location = new System.Drawing.Point(482, 243);
            this.textBoxTotalDenda.Name = "textBoxTotalDenda";
            this.textBoxTotalDenda.Size = new System.Drawing.Size(248, 22);
            this.textBoxTotalDenda.TabIndex = 23;
            // 
            // textBoxTotalBayar
            // 
            this.textBoxTotalBayar.Location = new System.Drawing.Point(482, 273);
            this.textBoxTotalBayar.Name = "textBoxTotalBayar";
            this.textBoxTotalBayar.Size = new System.Drawing.Size(248, 22);
            this.textBoxTotalBayar.TabIndex = 24;
            // 
            // textBoxBayar
            // 
            this.textBoxBayar.Location = new System.Drawing.Point(482, 303);
            this.textBoxBayar.Name = "textBoxBayar";
            this.textBoxBayar.Size = new System.Drawing.Size(248, 22);
            this.textBoxBayar.TabIndex = 25;
            // 
            // textBoxKembalian
            // 
            this.textBoxKembalian.Location = new System.Drawing.Point(482, 333);
            this.textBoxKembalian.Name = "textBoxKembalian";
            this.textBoxKembalian.Size = new System.Drawing.Size(248, 22);
            this.textBoxKembalian.TabIndex = 26;
            // 
            // comboBoxIDPelanggan
            // 
            this.comboBoxIDPelanggan.Location = new System.Drawing.Point(130, 60);
            this.comboBoxIDPelanggan.Name = "comboBoxIDPelanggan";
            this.comboBoxIDPelanggan.Size = new System.Drawing.Size(200, 24);
            this.comboBoxIDPelanggan.TabIndex = 27;
            // 
            // comboBoxNoTransaksi
            // 
            this.comboBoxNoTransaksi.Location = new System.Drawing.Point(482, 30);
            this.comboBoxNoTransaksi.Name = "comboBoxNoTransaksi";
            this.comboBoxNoTransaksi.Size = new System.Drawing.Size(248, 24);
            this.comboBoxNoTransaksi.TabIndex = 28;
            this.comboBoxNoTransaksi.SelectedIndexChanged += new System.EventHandler(this.comboBoxNoTransaksi_SelectedIndexChanged);
            // 
            // comboBoxIDPlaystation
            // 
            this.comboBoxIDPlaystation.Location = new System.Drawing.Point(482, 90);
            this.comboBoxIDPlaystation.Name = "comboBoxIDPlaystation";
            this.comboBoxIDPlaystation.Size = new System.Drawing.Size(248, 24);
            this.comboBoxIDPlaystation.TabIndex = 29;
            // 
            // comboBoxPlaystation
            // 
            this.comboBoxPlaystation.Location = new System.Drawing.Point(482, 120);
            this.comboBoxPlaystation.Name = "comboBoxPlaystation";
            this.comboBoxPlaystation.Size = new System.Drawing.Size(248, 24);
            this.comboBoxPlaystation.TabIndex = 30;
            // 
            // dateTimePickerTglPengembalian
            // 
            this.dateTimePickerTglPengembalian.Location = new System.Drawing.Point(482, 60);
            this.dateTimePickerTglPengembalian.Name = "dateTimePickerTglPengembalian";
            this.dateTimePickerTglPengembalian.Size = new System.Drawing.Size(248, 22);
            this.dateTimePickerTglPengembalian.TabIndex = 31;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(19, 364);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(100, 30);
            this.buttonSimpan.TabIndex = 32;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonHitung
            // 
            this.buttonHitung.Location = new System.Drawing.Point(746, 303);
            this.buttonHitung.Name = "buttonHitung";
            this.buttonHitung.Size = new System.Drawing.Size(100, 30);
            this.buttonHitung.TabIndex = 33;
            this.buttonHitung.Text = "Hitung";
            this.buttonHitung.Click += new System.EventHandler(this.buttonHitung_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(231, 364);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 30);
            this.buttonClear.TabIndex = 34;
            this.buttonClear.Text = "Clear";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(125, 364);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 30);
            this.buttonDelete.TabIndex = 35;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridViewPengembalian
            // 
            this.dataGridViewPengembalian.ColumnHeadersHeight = 29;
            this.dataGridViewPengembalian.Location = new System.Drawing.Point(20, 400);
            this.dataGridViewPengembalian.Name = "dataGridViewPengembalian";
            this.dataGridViewPengembalian.RowHeadersWidth = 51;
            this.dataGridViewPengembalian.Size = new System.Drawing.Size(1280, 150);
            this.dataGridViewPengembalian.TabIndex = 36;
<<<<<<< HEAD
            this.dataGridViewPengembalian.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPengembalian_CellClick);
            // 
=======
            this.dataGridViewPengembalian.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPengembalian_CellClick);            // 
>>>>>>> cd6e5473f23f1e8968889d660bfa295ab911647f
            // buttonHitungDenda
            // 
            this.buttonHitungDenda.Location = new System.Drawing.Point(746, 243);
            this.buttonHitungDenda.Name = "buttonHitungDenda";
            this.buttonHitungDenda.Size = new System.Drawing.Size(119, 30);
            this.buttonHitungDenda.TabIndex = 37;
            this.buttonHitungDenda.Text = "Hitung Denda";
            this.buttonHitungDenda.UseVisualStyleBackColor = true;
            this.buttonHitungDenda.Click += new System.EventHandler(this.buttonHitungDenda_Click);
<<<<<<< HEAD
            // 
            // btnPengembalian
            // 
            this.btnPengembalian.BackColor = System.Drawing.Color.Red;
            this.btnPengembalian.ForeColor = System.Drawing.Color.Transparent;
            this.btnPengembalian.Location = new System.Drawing.Point(349, 364);
            this.btnPengembalian.Name = "btnPengembalian";
            this.btnPengembalian.Size = new System.Drawing.Size(106, 29);
            this.btnPengembalian.TabIndex = 38;
            this.btnPengembalian.Text = "Export to Excel";
            this.btnPengembalian.UseVisualStyleBackColor = false;
            this.btnPengembalian.Click += new System.EventHandler(this.btnPengembalian_Click);
=======
>>>>>>> cd6e5473f23f1e8968889d660bfa295ab911647f
            // 
            // Pengembalian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 600);
<<<<<<< HEAD
            this.Controls.Add(this.btnPengembalian);
=======
>>>>>>> cd6e5473f23f1e8968889d660bfa295ab911647f
            this.Controls.Add(this.buttonHitungDenda);
            this.Controls.Add(this.labelNamaAdmin);
            this.Controls.Add(this.labelIDPelanggan);
            this.Controls.Add(this.labelNamaPelanggan);
            this.Controls.Add(this.labelNomorTelepon);
            this.Controls.Add(this.labelAlamat);
            this.Controls.Add(this.labelNoTransaksi);
            this.Controls.Add(this.labelTglPengembalian);
            this.Controls.Add(this.labelIDPlaystation);
            this.Controls.Add(this.labelPlaystation);
            this.Controls.Add(this.labelTotalHarga);
            this.Controls.Add(this.labelKeterlambatan);
            this.Controls.Add(this.labelDendaHari);
            this.Controls.Add(this.labelTotalDenda);
            this.Controls.Add(this.labelTotalBayar);
            this.Controls.Add(this.labelBayar);
            this.Controls.Add(this.labelKembalian);
            this.Controls.Add(this.textBoxNamaAdmin);
            this.Controls.Add(this.textBoxNamaPelanggan);
            this.Controls.Add(this.textBoxNomorTelepon);
            this.Controls.Add(this.textBoxAlamat);
            this.Controls.Add(this.textBoxTotalHarga);
            this.Controls.Add(this.textBoxKeterlambatan);
            this.Controls.Add(this.textBoxDendaHari);
            this.Controls.Add(this.textBoxTotalDenda);
            this.Controls.Add(this.textBoxTotalBayar);
            this.Controls.Add(this.textBoxBayar);
            this.Controls.Add(this.textBoxKembalian);
            this.Controls.Add(this.comboBoxIDPelanggan);
            this.Controls.Add(this.comboBoxNoTransaksi);
            this.Controls.Add(this.comboBoxIDPlaystation);
            this.Controls.Add(this.comboBoxPlaystation);
            this.Controls.Add(this.dateTimePickerTglPengembalian);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.buttonHitung);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridViewPengembalian);
            this.Name = "Pengembalian";
            this.Text = "Pengembalian";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPengembalian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Define components here
        private System.Windows.Forms.Label labelNamaAdmin;
        private System.Windows.Forms.Label labelIDPelanggan;
        private System.Windows.Forms.Label labelNamaPelanggan;
        private System.Windows.Forms.Label labelNomorTelepon;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Label labelNoTransaksi;
        private System.Windows.Forms.Label labelTglPengembalian;
        private System.Windows.Forms.Label labelIDPlaystation;
        private System.Windows.Forms.Label labelPlaystation;
        private System.Windows.Forms.Label labelTotalHarga;
        private System.Windows.Forms.Label labelKeterlambatan;
        private System.Windows.Forms.Label labelDendaHari;
        private System.Windows.Forms.Label labelTotalDenda;
        private System.Windows.Forms.Label labelTotalBayar;
        private System.Windows.Forms.Label labelBayar;
        private System.Windows.Forms.Label labelKembalian;

        private System.Windows.Forms.TextBox textBoxNamaAdmin;
        private System.Windows.Forms.TextBox textBoxNamaPelanggan;
        private System.Windows.Forms.TextBox textBoxNomorTelepon;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.TextBox textBoxTotalHarga;
        private System.Windows.Forms.TextBox textBoxKeterlambatan;
        private System.Windows.Forms.TextBox textBoxDendaHari;
        private System.Windows.Forms.TextBox textBoxTotalDenda;
        private System.Windows.Forms.TextBox textBoxTotalBayar;
        private System.Windows.Forms.TextBox textBoxBayar;
        private System.Windows.Forms.TextBox textBoxKembalian;

        private System.Windows.Forms.ComboBox comboBoxIDPelanggan;
        private System.Windows.Forms.ComboBox comboBoxNoTransaksi;
        private System.Windows.Forms.ComboBox comboBoxIDPlaystation;
        private System.Windows.Forms.ComboBox comboBoxPlaystation;

        private System.Windows.Forms.DateTimePicker dateTimePickerTglPengembalian;

        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonHitung;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDelete;

        private System.Windows.Forms.DataGridView dataGridViewPengembalian;
        private System.Windows.Forms.Button buttonHitungDenda;
<<<<<<< HEAD
        private System.Windows.Forms.Button btnPengembalian;
=======
>>>>>>> cd6e5473f23f1e8968889d660bfa295ab911647f
    }
}
