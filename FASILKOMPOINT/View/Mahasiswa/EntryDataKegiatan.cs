using FASILKOMPOINT.App.Context;
using FASILKOMPOINT.App.Core;
using FASILKOMPOINT.View.SKPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FASILKOMPOINT.View.Mahasiswa
{
    public partial class EntryDataKegiatan : Form
    {
        public string username { get; set; }
        public EntryDataKegiatan(string username)
        {
            InitializeComponent();
            Halaman halamanLogin = Application.OpenForms["Halaman"] as Halaman;
            this.username = username;
            dataGridView.DataSource = AktivitasKeikutsertaanContext.showKeikutsertaan(username, 601);
            dataGridView.Columns["Keterangan"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.HeaderText = "";
            editButton.Text = "Edit";
            editButton.Name = "editButton";
            editButton.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Insert(8, editButton);

            dataGridView.Columns["id_aktivitas"].Visible = false;
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

        private void EntryDataKegiatan_Load(object sender, EventArgs e)
        {

        }

        private void btn_prestasi_Click(object sender, EventArgs e)
        {
            EntryDataPrestasi entryDataPrestasi = new EntryDataPrestasi(username);
            entryDataPrestasi.Show();
            this.Hide();
        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            BerandaMahasiswa berandaMahasiswa = new BerandaMahasiswa(username);
            berandaMahasiswa.Show();
            this.Hide();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            FormEntryDataKegiatan formEntryDataKegiatan = new FormEntryDataKegiatan(username);
            formEntryDataKegiatan.Show();
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
            else if (e.ColumnIndex == dataGridView.Columns["editButton"].Index && e.RowIndex >= 0)
            {
                int id_aktivitas = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["id_aktivitas"].Value);

                using (FormUbahDataKegiatan formEditEntryKegiatan = new FormUbahDataKegiatan(id_aktivitas, username))
                {
                    FormUbahDataKegiatan halamaneditKegiatan = new FormUbahDataKegiatan(id_aktivitas, username);
                    halamaneditKegiatan.Show();
                    this.Hide();
                }
            }

        }
    }
}
