﻿namespace Peminjaman_Playstation
{
    partial class Playstation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelIDPlaystation = new System.Windows.Forms.Label();
            this.textBoxIDPlaystation = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.labelJenisPlaystation = new System.Windows.Forms.Label();
            this.textBoxJenisPlaystation = new System.Windows.Forms.TextBox();
            this.labelHargaSewa = new System.Windows.Forms.Label();
            this.textBoxHargaSewa = new System.Windows.Forms.TextBox();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonUbah = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIDPlaystation
            // 
            this.labelIDPlaystation.AutoSize = true;
            this.labelIDPlaystation.Location = new System.Drawing.Point(12, 40);
            this.labelIDPlaystation.Name = "labelIDPlaystation";
            this.labelIDPlaystation.Size = new System.Drawing.Size(92, 16);
            this.labelIDPlaystation.TabIndex = 1;
            this.labelIDPlaystation.Text = "ID Playstation:";
            // 
            // textBoxIDPlaystation
            // 
            this.textBoxIDPlaystation.Location = new System.Drawing.Point(129, 37);
            this.textBoxIDPlaystation.Name = "textBoxIDPlaystation";
            this.textBoxIDPlaystation.Size = new System.Drawing.Size(150, 22);
            this.textBoxIDPlaystation.TabIndex = 2;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(299, 35);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 3;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            // 
            // labelJenisPlaystation
            // 
            this.labelJenisPlaystation.AutoSize = true;
            this.labelJenisPlaystation.Location = new System.Drawing.Point(12, 70);
            this.labelJenisPlaystation.Name = "labelJenisPlaystation";
            this.labelJenisPlaystation.Size = new System.Drawing.Size(111, 16);
            this.labelJenisPlaystation.TabIndex = 4;
            this.labelJenisPlaystation.Text = "Jenis Playstation:";
            // 
            // textBoxJenisPlaystation
            // 
            this.textBoxJenisPlaystation.Location = new System.Drawing.Point(129, 67);
            this.textBoxJenisPlaystation.Name = "textBoxJenisPlaystation";
            this.textBoxJenisPlaystation.Size = new System.Drawing.Size(245, 22);
            this.textBoxJenisPlaystation.TabIndex = 5;
            // 
            // labelHargaSewa
            // 
            this.labelHargaSewa.AutoSize = true;
            this.labelHargaSewa.Location = new System.Drawing.Point(12, 100);
            this.labelHargaSewa.Name = "labelHargaSewa";
            this.labelHargaSewa.Size = new System.Drawing.Size(114, 16);
            this.labelHargaSewa.TabIndex = 6;
            this.labelHargaSewa.Text = "Harga Sewa/Hari:";
            // 
            // textBoxHargaSewa
            // 
            this.textBoxHargaSewa.Location = new System.Drawing.Point(129, 97);
            this.textBoxHargaSewa.Name = "textBoxHargaSewa";
            this.textBoxHargaSewa.Size = new System.Drawing.Size(245, 22);
            this.textBoxHargaSewa.TabIndex = 7;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(15, 140);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(75, 23);
            this.buttonSimpan.TabIndex = 8;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            // 
            // buttonUbah
            // 
            this.buttonUbah.Location = new System.Drawing.Point(100, 140);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(75, 23);
            this.buttonUbah.TabIndex = 9;
            this.buttonUbah.Text = "Ubah";
            this.buttonUbah.UseVisualStyleBackColor = true;
            // 
            // buttonHapus
            // 
            this.buttonHapus.Location = new System.Drawing.Point(185, 140);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(75, 23);
            this.buttonHapus.TabIndex = 10;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(290, 140);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(15, 180);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(760, 200);
            this.dataGridView.TabIndex = 12;
            // 
            // Playstation
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonUbah);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.textBoxHargaSewa);
            this.Controls.Add(this.labelHargaSewa);
            this.Controls.Add(this.textBoxJenisPlaystation);
            this.Controls.Add(this.labelJenisPlaystation);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxIDPlaystation);
            this.Controls.Add(this.labelIDPlaystation);
            this.Name = "Playstation";
            this.Text = "Data Playstation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelIDPlaystation;
        private System.Windows.Forms.TextBox textBoxIDPlaystation;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label labelJenisPlaystation;
        private System.Windows.Forms.TextBox textBoxJenisPlaystation;
        private System.Windows.Forms.Label labelHargaSewa;
        private System.Windows.Forms.TextBox textBoxHargaSewa;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonUbah;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}
