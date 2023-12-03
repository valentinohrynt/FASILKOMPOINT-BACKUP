using FASILKOMPOINT.App.Context;
using FASILKOMPOINT.App.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FASILKOMPOINT.View.Mahasiswa
{
    public partial class EntryDataPrestasi : Form
    {
        public string username { get; set; }

        public EntryDataPrestasi(string username)
        {
            InitializeComponent();
            this.username = username;
            dataGridView.DataSource = AktivitasPrestasiContext.showPrestasi(username, 602);
            dataGridView.Columns["Keterangan"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.HeaderText = "";
            editButton.Text = "Edit";
            editButton.Name = "editButton";
            editButton.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Insert(9, editButton);

            dataGridView.Columns["id_aktivitas"].Visible = false;
        }

        private void btn_prestasi_Click(object sender, EventArgs e)
        {
            EntryDataPrestasi entryDataPrestasi = new EntryDataPrestasi(username);
            entryDataPrestasi.Show();
            this.Hide();
        }

        private void btn_kegiatan_Click(object sender, EventArgs e)
        {
            EntryDataKegiatan entryDataKegiatan = new EntryDataKegiatan(username);
            entryDataKegiatan.Show();
            this.Hide();
        }

        private void btn_sertifikasi_Click(object sender, EventArgs e)
        {
            EntryDataSertifikasi entryDataSertifikasi = new EntryDataSertifikasi(username);
            entryDataSertifikasi.Show();
            this.Hide();
        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            BerandaMahasiswa berandaMahasiswa = new BerandaMahasiswa(username);
            berandaMahasiswa.Show();
            this.Hide();
        }

        private void EntryDataPrestasi_Load(object sender, EventArgs e)
        {

        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            FormEntryDataPrestasi formEntryDataPrestasi = new FormEntryDataPrestasi(username);
            formEntryDataPrestasi.Show();
            this.Hide();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView.Columns["Bukti"].Index && e.RowIndex >= 0)
            {
                string link = dataGridView.Rows[e.RowIndex].Cells["Bukti"].Value?.ToString();

                if (!string.IsNullOrEmpty(link))
                {
                    ShellExecutor.OpenFileUsingDefaultProgram(link);
                }
            }
            else if (e.ColumnIndex == dataGridView.Columns["Penyelenggara"].Index && e.RowIndex >= 0)
            {
                string link = dataGridView.Rows[e.RowIndex].Cells["Penyelenggara"].Value?.ToString();

                if (!string.IsNullOrEmpty(link))
                {
                    ShellExecutor.OpenFileUsingDefaultProgram(link);
                }
            }

            else if (e.ColumnIndex == dataGridView.Columns["editButton"].Index && e.RowIndex >= 0)
            {
                int id_aktivitas = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["id_aktivitas"].Value);

                using (FormUbahDataPrestasi formEditEntryPrestasi = new FormUbahDataPrestasi(username, id_aktivitas))
                {
                    FormUbahDataPrestasi halamaneditPrestasi = new FormUbahDataPrestasi(username, id_aktivitas);
                    halamaneditPrestasi.Show();
                    this.Hide();
                }
            }
        }
    }
}
