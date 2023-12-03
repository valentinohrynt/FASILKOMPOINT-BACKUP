using FASILKOMPOINT.App.Context;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FASILKOMPOINT.View.Mahasiswa
{
    public partial class FormUbahDataPrestasi : Form
    {
        public string username { get; set; }
        public int id_aktivitas { get; set; }

        public FormUbahDataPrestasi(string username, int id_aktivitas)
        {
            InitializeComponent();
            this.username = username;
            this.id_aktivitas = id_aktivitas;

            dateTimePicker2.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";

            cbSubKategoriPrestasi.DataSource = subKategoriContext.showSubKategoriPrestasi();
            cbSubKategoriPrestasi.DisplayMember = "nama_subkategori";
            cbSubKategoriPrestasi.ValueMember = "id_subkategori";

            cbButirPrestasi.Enabled = false;
            cbSubButirPrestasi.Enabled = false;
        }

        private void FormUbahDataPrestasi_Load(object sender, EventArgs e)
        {

        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            EntryDataPrestasi entryDataPrestasi = new EntryDataPrestasi(username);
            entryDataPrestasi.Show();
            this.Hide();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            var nama_prestasi = txt_nama.Text;
            var tanggal_dimulai = dateTimePicker1.Value;
            var tanggal_berakhir = dateTimePicker2.Value;
            var url_penyelenggara = txt_url.Text;
            var level_tingkat = Convert.ToString(cbButirPrestasi.SelectedValue);
            var juara = cbSubButirPrestasi.SelectedValue;
            var strjuara = juara != null ? juara.ToString() : null;
            var sub_kategori_id_subkategori = Convert.ToInt32(cbSubKategoriPrestasi.SelectedValue);
            var no_surat = txt_notugas.Text;
            var nama_dosbing = txt_nampem.Text;
            var file_bukti = txt_bukti.Text;

            M_Aktivitas_Prestasi aktivitasPrestasiBaru = new M_Aktivitas_Prestasi
            {
                nama_prestasi = nama_prestasi,
                tanggal_dimulai = tanggal_dimulai,
                tanggal_berakhir = tanggal_berakhir,
                url_penyelenggara = url_penyelenggara,
                level_tingkat = level_tingkat,
                juara = strjuara,
                sub_kategori_id_subkategori = sub_kategori_id_subkategori,
                no_surat = no_surat,
                nama_dosbing = nama_dosbing,
                file_bukti = file_bukti,
                mahasiswa_username = username,
                is_acc = "menunggu",
                id_aktivitas = id_aktivitas
            };
            AktivitasPrestasiContext.UpdatePrestasi(aktivitasPrestasiBaru);

            DialogResult message = MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (message == DialogResult.OK)
            {
                this.Hide();
                EntryDataPrestasi entryDataPrestasi = new EntryDataPrestasi(username);
                entryDataPrestasi.Show();
            }
        }

        private void cbSubKategoriPrestasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIdx1 = cbSubKategoriPrestasi.SelectedIndex;

            if (selectedIdx1 == 0)
            {
                cbButirPrestasi.DataSource = ButirContext.showTingkatPrestasiKejuaraan();
            }
            else if (selectedIdx1 == 1)
            {
                cbButirPrestasi.DataSource = ButirContext.showTingkatPrestasiDuta();
            }
            else if (selectedIdx1 == 2)
            {
                cbButirPrestasi.DataSource = ButirContext.showTIngkatPrestasiRekognisi();
            }

            cbButirPrestasi.DisplayMember = "nama_butir";
            cbButirPrestasi.ValueMember = "nama_butir";

            cbButirPrestasi.Enabled = true;
        }

        private void cbButirPrestasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIdx2 = cbButirPrestasi.SelectedIndex;
            int selectedIdx1 = cbSubKategoriPrestasi.SelectedIndex;

            if (selectedIdx1 == 0)
            {
                if (selectedIdx2 == 0)
                {
                    cbSubButirPrestasi.DataSource = SubbutirContext.showPrestasi3Subbutir();
                }
                else if (selectedIdx2 == 1)
                {
                    cbSubButirPrestasi.DataSource = SubbutirContext.showPrestasi4Subbutir();
                }
                else if (selectedIdx2 >= 2 && selectedIdx2 <= 4)
                {
                    cbSubButirPrestasi.DataSource = SubbutirContext.showPrestasi3Subbutir();
                }
                cbSubButirPrestasi.DisplayMember = "nama_butir";
                cbSubButirPrestasi.ValueMember = "nama_butir";
            }

            else if (selectedIdx1 == 1)
            {
                cbSubButirPrestasi.DataSource = null;
                cbSubButirPrestasi.DisplayMember = null;
                cbSubButirPrestasi.ValueMember = null;
            }

            else if (selectedIdx1 == 2)
            {
                cbSubButirPrestasi.DataSource = null;
                cbSubButirPrestasi.DisplayMember = null;
                cbSubButirPrestasi.ValueMember = null;
            }
            cbSubButirPrestasi.Enabled = true;
        }

        private void cbSubButirPrestasi_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
