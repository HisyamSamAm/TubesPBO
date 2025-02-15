namespace Peminjaman_Playstation.view
{
    partial class Peminjaman
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
            this.labelNIK = new System.Windows.Forms.Label();
            this.labelNamaPelanggan = new System.Windows.Forms.Label();
            this.labelNomorTelepon = new System.Windows.Forms.Label();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.labelNoTransaksi = new System.Windows.Forms.Label();
            this.labelTglPeminjaman = new System.Windows.Forms.Label();
            this.labelIDPlaystation = new System.Windows.Forms.Label();
            this.labelPlaystation = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.labelLamaSewa = new System.Windows.Forms.Label();
            this.labelTotalHarga = new System.Windows.Forms.Label();
            this.labelTglPengembalian = new System.Windows.Forms.Label();
            this.textBoxNamaAdmin = new System.Windows.Forms.TextBox();
            this.textBoxNIK = new System.Windows.Forms.TextBox();
            this.textBoxNamaPelanggan = new System.Windows.Forms.TextBox();
            this.textBoxNomorTelepon = new System.Windows.Forms.TextBox();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.textBoxLamaSewa = new System.Windows.Forms.TextBox();
            this.textBoxTotalHarga = new System.Windows.Forms.TextBox();
            this.comboBoxIDPelanggan = new System.Windows.Forms.ComboBox();
            this.comboBoxIDPlaystation = new System.Windows.Forms.ComboBox();
            this.comboBoxPlaystation = new System.Windows.Forms.ComboBox();
            this.dateTimePickerTglPeminjaman = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTglPengembalian = new System.Windows.Forms.DateTimePicker();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonHitungOtomatis = new System.Windows.Forms.Button();
            this.dataGridViewTransactions = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).BeginInit();
            this.SuspendLayout();
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
            // labelNIK
            // 
            this.labelNIK.Location = new System.Drawing.Point(20, 90);
            this.labelNIK.Name = "labelNIK";
            this.labelNIK.Size = new System.Drawing.Size(100, 20);
            this.labelNIK.TabIndex = 2;
            this.labelNIK.Text = "NIK";
            // 
            // labelNamaPelanggan
            // 
            this.labelNamaPelanggan.Location = new System.Drawing.Point(20, 120);
            this.labelNamaPelanggan.Name = "labelNamaPelanggan";
            this.labelNamaPelanggan.Size = new System.Drawing.Size(100, 20);
            this.labelNamaPelanggan.TabIndex = 3;
            this.labelNamaPelanggan.Text = "Nama Pelanggan";
            // 
            // labelNomorTelepon
            // 
            this.labelNomorTelepon.Location = new System.Drawing.Point(20, 150);
            this.labelNomorTelepon.Name = "labelNomorTelepon";
            this.labelNomorTelepon.Size = new System.Drawing.Size(100, 20);
            this.labelNomorTelepon.TabIndex = 4;
            this.labelNomorTelepon.Text = "Nomor Telepon";
            // 
            // labelAlamat
            // 
            this.labelAlamat.Location = new System.Drawing.Point(20, 180);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(100, 20);
            this.labelAlamat.TabIndex = 5;
            this.labelAlamat.Text = "Alamat";
            // 
            // labelNoTransaksi
            // 
            this.labelNoTransaksi.Location = new System.Drawing.Point(362, 27);
            this.labelNoTransaksi.Name = "labelNoTransaksi";
            this.labelNoTransaksi.Size = new System.Drawing.Size(100, 20);
            this.labelNoTransaksi.TabIndex = 6;
            this.labelNoTransaksi.Text = "No. Transaksi";
            // 
            // labelTglPeminjaman
            // 
            this.labelTglPeminjaman.Location = new System.Drawing.Point(362, 60);
            this.labelTglPeminjaman.Name = "labelTglPeminjaman";
            this.labelTglPeminjaman.Size = new System.Drawing.Size(100, 20);
            this.labelTglPeminjaman.TabIndex = 7;
            this.labelTglPeminjaman.Text = "Tgl. Peminjaman";
            // 
            // labelIDPlaystation
            // 
            this.labelIDPlaystation.Location = new System.Drawing.Point(362, 90);
            this.labelIDPlaystation.Name = "labelIDPlaystation";
            this.labelIDPlaystation.Size = new System.Drawing.Size(100, 20);
            this.labelIDPlaystation.TabIndex = 8;
            this.labelIDPlaystation.Text = "ID Playstation";
            // 
            // labelPlaystation
            // 
            this.labelPlaystation.Location = new System.Drawing.Point(362, 120);
            this.labelPlaystation.Name = "labelPlaystation";
            this.labelPlaystation.Size = new System.Drawing.Size(100, 20);
            this.labelPlaystation.TabIndex = 9;
            this.labelPlaystation.Text = "Playstation";
            // 
            // labelHarga
            // 
            this.labelHarga.Location = new System.Drawing.Point(362, 150);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(100, 20);
            this.labelHarga.TabIndex = 10;
            this.labelHarga.Text = "Harga";
            // 
            // labelLamaSewa
            // 
            this.labelLamaSewa.Location = new System.Drawing.Point(362, 180);
            this.labelLamaSewa.Name = "labelLamaSewa";
            this.labelLamaSewa.Size = new System.Drawing.Size(100, 20);
            this.labelLamaSewa.TabIndex = 11;
            this.labelLamaSewa.Text = "Lama Sewa";
            // 
            // labelTotalHarga
            // 
            this.labelTotalHarga.Location = new System.Drawing.Point(362, 210);
            this.labelTotalHarga.Name = "labelTotalHarga";
            this.labelTotalHarga.Size = new System.Drawing.Size(100, 20);
            this.labelTotalHarga.TabIndex = 12;
            this.labelTotalHarga.Text = "Total Harga";
            // 
            // labelTglPengembalian
            // 
            this.labelTglPengembalian.Location = new System.Drawing.Point(362, 240);
            this.labelTglPengembalian.Name = "labelTglPengembalian";
            this.labelTglPengembalian.Size = new System.Drawing.Size(100, 20);
            this.labelTglPengembalian.TabIndex = 13;
            this.labelTglPengembalian.Text = "Tgl. Pengembalian";
            // 
            // textBoxNamaAdmin
            // 
            this.textBoxNamaAdmin.Location = new System.Drawing.Point(130, 30);
            this.textBoxNamaAdmin.Name = "textBoxNamaAdmin";
            this.textBoxNamaAdmin.Size = new System.Drawing.Size(200, 22);
            this.textBoxNamaAdmin.TabIndex = 14;
            // 
            // textBoxNIK
            // 
            this.textBoxNIK.Location = new System.Drawing.Point(130, 90);
            this.textBoxNIK.Name = "textBoxNIK";
            this.textBoxNIK.Size = new System.Drawing.Size(200, 22);
            this.textBoxNIK.TabIndex = 15;
            // 
            // textBoxNamaPelanggan
            // 
            this.textBoxNamaPelanggan.Location = new System.Drawing.Point(130, 120);
            this.textBoxNamaPelanggan.Name = "textBoxNamaPelanggan";
            this.textBoxNamaPelanggan.Size = new System.Drawing.Size(200, 22);
            this.textBoxNamaPelanggan.TabIndex = 16;
            // 
            // textBoxNomorTelepon
            // 
            this.textBoxNomorTelepon.Location = new System.Drawing.Point(130, 150);
            this.textBoxNomorTelepon.Name = "textBoxNomorTelepon";
            this.textBoxNomorTelepon.Size = new System.Drawing.Size(200, 22);
            this.textBoxNomorTelepon.TabIndex = 17;
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Location = new System.Drawing.Point(130, 180);
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(200, 22);
            this.textBoxAlamat.TabIndex = 18;
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.Location = new System.Drawing.Point(472, 150);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(226, 22);
            this.textBoxHarga.TabIndex = 19;
            // 
            // textBoxLamaSewa
            // 
            this.textBoxLamaSewa.Location = new System.Drawing.Point(472, 180);
            this.textBoxLamaSewa.Name = "textBoxLamaSewa";
            this.textBoxLamaSewa.Size = new System.Drawing.Size(226, 22);
            this.textBoxLamaSewa.TabIndex = 20;
            // 
            // textBoxTotalHarga
            // 
            this.textBoxTotalHarga.Location = new System.Drawing.Point(472, 210);
            this.textBoxTotalHarga.Name = "textBoxTotalHarga";
            this.textBoxTotalHarga.Size = new System.Drawing.Size(226, 22);
            this.textBoxTotalHarga.TabIndex = 21;
            // 
            // comboBoxIDPelanggan
            // 
            this.comboBoxIDPelanggan.Location = new System.Drawing.Point(130, 60);
            this.comboBoxIDPelanggan.Name = "comboBoxIDPelanggan";
            this.comboBoxIDPelanggan.Size = new System.Drawing.Size(200, 24);
            this.comboBoxIDPelanggan.TabIndex = 22;
            // 
            // comboBoxIDPlaystation
            // 
            this.comboBoxIDPlaystation.Location = new System.Drawing.Point(472, 90);
            this.comboBoxIDPlaystation.Name = "comboBoxIDPlaystation";
            this.comboBoxIDPlaystation.Size = new System.Drawing.Size(226, 24);
            this.comboBoxIDPlaystation.TabIndex = 23;
            // 
            // comboBoxPlaystation
            // 
            this.comboBoxPlaystation.Location = new System.Drawing.Point(472, 120);
            this.comboBoxPlaystation.Name = "comboBoxPlaystation";
            this.comboBoxPlaystation.Size = new System.Drawing.Size(226, 24);
            this.comboBoxPlaystation.TabIndex = 24;
            // 
            // dateTimePickerTglPeminjaman
            // 
            this.dateTimePickerTglPeminjaman.Location = new System.Drawing.Point(472, 60);
            this.dateTimePickerTglPeminjaman.Name = "dateTimePickerTglPeminjaman";
            this.dateTimePickerTglPeminjaman.Size = new System.Drawing.Size(226, 22);
            this.dateTimePickerTglPeminjaman.TabIndex = 25;
            // 
            // dateTimePickerTglPengembalian
            // 
            this.dateTimePickerTglPengembalian.Location = new System.Drawing.Point(472, 240);
            this.dateTimePickerTglPengembalian.Name = "dateTimePickerTglPengembalian";
            this.dateTimePickerTglPengembalian.Size = new System.Drawing.Size(226, 22);
            this.dateTimePickerTglPengembalian.TabIndex = 26;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(22, 293);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(100, 30);
            this.buttonSimpan.TabIndex = 27;
            this.buttonSimpan.Text = "Simpan";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(132, 293);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 30);
            this.buttonEdit.TabIndex = 28;
            this.buttonEdit.Text = "Edit";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(242, 293);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 30);
            this.buttonClear.TabIndex = 29;
            this.buttonClear.Text = "Clear";
            // 
            // buttonHapus
            // 
            this.buttonHapus.Location = new System.Drawing.Point(352, 293);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(100, 30);
            this.buttonHapus.TabIndex = 30;
            this.buttonHapus.Text = "Hapus";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(713, 19);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(100, 30);
            this.buttonGenerate.TabIndex = 31;
            this.buttonGenerate.Text = "Generate";
            // 
            // buttonHitungOtomatis
            // 
            this.buttonHitungOtomatis.Location = new System.Drawing.Point(713, 203);
            this.buttonHitungOtomatis.Name = "buttonHitungOtomatis";
            this.buttonHitungOtomatis.Size = new System.Drawing.Size(150, 30);
            this.buttonHitungOtomatis.TabIndex = 32;
            this.buttonHitungOtomatis.Text = "Hitung Otomatis";
            // 
            // dataGridViewTransactions
            // 
            this.dataGridViewTransactions.ColumnHeadersHeight = 29;
            this.dataGridViewTransactions.Location = new System.Drawing.Point(23, 329);
            this.dataGridViewTransactions.Name = "dataGridViewTransactions";
            this.dataGridViewTransactions.RowHeadersWidth = 51;
            this.dataGridViewTransactions.Size = new System.Drawing.Size(950, 200);
            this.dataGridViewTransactions.TabIndex = 33;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(472, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 22);
            this.textBox1.TabIndex = 34;
            // 
            // Peminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelNamaAdmin);
            this.Controls.Add(this.labelIDPelanggan);
            this.Controls.Add(this.labelNIK);
            this.Controls.Add(this.labelNamaPelanggan);
            this.Controls.Add(this.labelNomorTelepon);
            this.Controls.Add(this.labelAlamat);
            this.Controls.Add(this.labelNoTransaksi);
            this.Controls.Add(this.labelTglPeminjaman);
            this.Controls.Add(this.labelIDPlaystation);
            this.Controls.Add(this.labelPlaystation);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.labelLamaSewa);
            this.Controls.Add(this.labelTotalHarga);
            this.Controls.Add(this.labelTglPengembalian);
            this.Controls.Add(this.textBoxNamaAdmin);
            this.Controls.Add(this.textBoxNIK);
            this.Controls.Add(this.textBoxNamaPelanggan);
            this.Controls.Add(this.textBoxNomorTelepon);
            this.Controls.Add(this.textBoxAlamat);
            this.Controls.Add(this.textBoxHarga);
            this.Controls.Add(this.textBoxLamaSewa);
            this.Controls.Add(this.textBoxTotalHarga);
            this.Controls.Add(this.comboBoxIDPelanggan);
            this.Controls.Add(this.comboBoxIDPlaystation);
            this.Controls.Add(this.comboBoxPlaystation);
            this.Controls.Add(this.dateTimePickerTglPeminjaman);
            this.Controls.Add(this.dateTimePickerTglPengembalian);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.buttonHitungOtomatis);
            this.Controls.Add(this.dataGridViewTransactions);
            this.Name = "Peminjaman";
            this.Text = "Aplikasi Peminjaman Rental Playstation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Define components here
        private System.Windows.Forms.Label labelNamaAdmin;
        private System.Windows.Forms.Label labelIDPelanggan;
        private System.Windows.Forms.Label labelNIK;
        private System.Windows.Forms.Label labelNamaPelanggan;
        private System.Windows.Forms.Label labelNomorTelepon;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Label labelNoTransaksi;
        private System.Windows.Forms.Label labelTglPeminjaman;
        private System.Windows.Forms.Label labelIDPlaystation;
        private System.Windows.Forms.Label labelPlaystation;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Label labelLamaSewa;
        private System.Windows.Forms.Label labelTotalHarga;
        private System.Windows.Forms.Label labelTglPengembalian;

        private System.Windows.Forms.TextBox textBoxNamaAdmin;
        private System.Windows.Forms.TextBox textBoxNIK;
        private System.Windows.Forms.TextBox textBoxNamaPelanggan;
        private System.Windows.Forms.TextBox textBoxNomorTelepon;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.TextBox textBoxLamaSewa;
        private System.Windows.Forms.TextBox textBoxTotalHarga;

        private System.Windows.Forms.ComboBox comboBoxIDPelanggan;
        private System.Windows.Forms.ComboBox comboBoxIDPlaystation;
        private System.Windows.Forms.ComboBox comboBoxPlaystation;

        private System.Windows.Forms.DateTimePicker dateTimePickerTglPeminjaman;
        private System.Windows.Forms.DateTimePicker dateTimePickerTglPengembalian;

        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonHitungOtomatis;

        private System.Windows.Forms.DataGridView dataGridViewTransactions;
        private System.Windows.Forms.TextBox textBox1;
    }
}
