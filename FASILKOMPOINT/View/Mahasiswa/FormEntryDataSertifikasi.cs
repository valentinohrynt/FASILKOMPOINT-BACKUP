using FASILKOMPOINT.App.Context;
using FASILKOMPOINT.App.Core;
using FASILKOMPOINT.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FASILKOMPOINT.View.Mahasiswa
{
    public partial class FormEntryDataSertifikasi : Form
    {
        public string username { get; set; }
        public FormEntryDataSertifikasi(string username)
        {
            InitializeComponent();
            this.username = username;
            dateTimePicker2.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";

            cbButirSertifikasi.DataSource = ButirContext.showTingkatSertifikasi();
            cbButirSertifikasi.DisplayMember = "nama_butir";
            cbButirSertifikasi.ValueMember = "nama_butir";
        }

        private void lbl_judul_Click(object sender, EventArgs e)
        {

        }

        private void FormEntryDataSertifikasi_Load(object sender, EventArgs e)
        {

        }

        private void check_hari_CheckedChanged(object sender, EventArgs e)
        {
            if (check_hari.Checked)
            {
                dateTimePicker2.Enabled = true;
            }
            else
            {
                dateTimePicker2.Enabled = false;
            }
        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            EntryDataSertifikasi entryDataSertifikasi = new EntryDataSertifikasi(username);
            entryDataSertifikasi.Show();
            this.Hide();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            var judul_sertifikasi = txt_nama.Text;
            var tanggal_dimulai = dateTimePicker1.Value;
            var tanggal_berakhir = dateTimePicker2.Value;
            var file_bukti = txt_bukti.Text;
            var tingkat_penyelenggara = Convert.ToString(cbButirSertifikasi.SelectedValue);
            var nama_penyelenggara = txt_tingkat.Text;


            M_Aktivitas_Sertifikasi aktivitasSertifikasiBaru = new M_Aktivitas_Sertifikasi
            {
                judul_sertifikasi = judul_sertifikasi,
                tanggal_dimulai = tanggal_dimulai,
                tanggal_berakhir = tanggal_berakhir,
                file_bukti = file_bukti,
                tingkat_penyelenggara = tingkat_penyelenggara,
                nama_penyelenggara = nama_penyelenggara,
                mahasiswa_username = username
            };
            AktivitasSertifikasiContext.AddSertifikasi(aktivitasSertifikasiBaru);

            DialogResult message = MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (message == DialogResult.OK)
            {
                this.Hide();
                EntryDataSertifikasi entryDataSertifikasi = new EntryDataSertifikasi(username);
                entryDataSertifikasi.Show();
            }
        }
    }
}
