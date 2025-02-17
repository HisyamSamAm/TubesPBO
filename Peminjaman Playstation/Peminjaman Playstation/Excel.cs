using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace Peminjaman_Playstation
{
    internal class Excel
    {
        public void ExportToExcel(DataGridView dataGridView, string namaFile = "DataPeminjaman")
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Excel Files|*.xlsx";
                    sfd.FileName = $"{namaFile}.xlsx";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                        using (ExcelPackage package = new ExcelPackage())
                        {
                            var worksheet = package.Workbook.Worksheets.Add(namaFile);

                            // Header
                            for (int i = 0; i < dataGridView.Columns.Count; i++)
                            {
                                worksheet.Cells[1, i + 1].Value = dataGridView.Columns[i].HeaderText;
                            }

                            // Isi Data
                            for (int i = 0; i < dataGridView.Rows.Count; i++)
                            {
                                for (int j = 0; j < dataGridView.Columns.Count; j++)
                                {
                                    worksheet.Cells[i + 2, j + 1].Value = dataGridView.Rows[i].Cells[j].Value?.ToString() ?? "";
                                }
                            }

                            var file = new FileInfo(sfd.FileName);
                            package.SaveAs(file);
                        }

                        MessageBox.Show($"Data {namaFile} berhasil diexport ke Excel!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
