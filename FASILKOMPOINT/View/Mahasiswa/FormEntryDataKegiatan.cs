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
    public partial class FormEntryDataKegiatan : Form
    {
        public string username { get; set; }
        public FormEntryDataKegiatan(string username)
        {
            InitializeComponent();
            this.username = username;

            dateTimePicker2.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";

            cbSubKategoriKegiatan.DataSource = subKategoriContext.showSubKategoriKegiatan();
            cbSubKategoriKegiatan.DisplayMember = "nama_subkategori";
            cbSubKategoriKegiatan.ValueMember = "id_subkategori";

            cbButirSerta.Enabled = false;
            cbSubButirSerta.Enabled = false;
        }

        private void lbl_judul_Click(object sender, EventArgs e)
        {

        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            EntryDataKegiatan entryDataKegiatan = new EntryDataKegiatan(username);
            entryDataKegiatan.Show();
            this.Hide();
        }

        private void FormEntryDataKegiatan_Load(object sender, EventArgs e)
        {

        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            var nama_kegiatan = txt_nama.Text;
            var tanggal_dimulai = dateTimePicker1.Value;
            var tanggal_berakhir = dateTimePicker2.Value;
            var jenis_kepesertaan = cbSubButirSerta.SelectedValue;
            var strJenisKepesertaan = jenis_kepesertaan != null ? jenis_kepesertaan.ToString() : null;
            var level_tingkat = Convert.ToString(cbButirSerta.SelectedValue);
            var sub_kategori_id_subkategori = Convert.ToInt32(cbSubKategoriKegiatan.SelectedValue);
            var file_bukti = txt_bukti.Text;

            M_Aktivitas_Keikutsertaan aktivitasKeikutsertaanBaru = new M_Aktivitas_Keikutsertaan
            {
                nama_kegiatan = nama_kegiatan,
                tanggal_dimulai = tanggal_dimulai,
                tanggal_berakhir = tanggal_berakhir,
                file_bukti = file_bukti,
                jenis_kepesertaan = strJenisKepesertaan,
                level_tingkat = level_tingkat,
                mahasiswa_username = username,
                sub_kategori_id_subkategori = sub_kategori_id_subkategori,
                is_acc = "menunggu"
            };
            AktivitasKeikutsertaanContext.AddKeikutsertaan(aktivitasKeikutsertaanBaru);

            DialogResult message = MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (message == DialogResult.OK)
            {
                this.Hide();
                EntryDataKegiatan entryDataKegiatan = new EntryDataKegiatan(username);
                entryDataKegiatan.Show();
            }
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

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbSubKategoriKegiatan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIdx1 = cbSubKategoriKegiatan.SelectedIndex;

            if (selectedIdx1 == 0)
            {
                cbButirSerta.DataSource = ButirContext.showTingkatKegiatanMenduduki();
            }
            else if (selectedIdx1 == 1)
            {
                cbButirSerta.DataSource = ButirContext.showTingkatKegiatanJabatan();
            }
            else if (selectedIdx1 == 2)
            {
                cbButirSerta.DataSource = ButirContext.showTingkatKegiatanKepanitiaan();
            }
            else if (selectedIdx1 == 3)
            {
                cbButirSerta.DataSource = ButirContext.showTingkatKegiatanPK2MABA();
            }
            else if (selectedIdx1 == 4)
            {
                cbButirSerta.DataSource = ButirContext.showTingkatKegiatanKepesertaan();
            }
            else if (selectedIdx1 == 5)
            {
                cbButirSerta.DataSource = ButirContext.showTingkatKegiatanPenelitian();
            }
            else if (selectedIdx1 == 6)
            {
                cbButirSerta.DataSource = ButirContext.showTingkatKegiatanPenugasan();
            }

            cbButirSerta.DisplayMember = "nama_butir";
            cbButirSerta.ValueMember = "nama_butir";
            cbButirSerta.Enabled = true;
        }

        private void cbButirSerta_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIdx2 = cbButirSerta.SelectedIndex;
            int selectedIdx1 = cbSubKategoriKegiatan.SelectedIndex;

            if (selectedIdx1 == 0)
            {
                if (selectedIdx2 == 0)
                {
                    cbSubButirSerta.DataSource = SubbutirContext.showKegiatanJabatanUniv();
                }
                else if (selectedIdx2 == 1)
                {
                    cbSubButirSerta.DataSource = SubbutirContext.showKegiatanJabatanFakultas();
                }
                else if (selectedIdx2 == 2)
                {
                    cbSubButirSerta.DataSource = SubbutirContext.showKegiatanJabatanFakultas();
                }
                else if (selectedIdx2 <= 3)
                {
                    cbSubButirSerta.DataSource = null;
                }
            }

            else if (selectedIdx1 == 1)
            {
                if (selectedIdx2 <= 0)
                {
                    cbSubButirSerta.DataSource = SubbutirContext.showKegiatanJabatanLuarKampus();
                }
            }

            else if (selectedIdx1 == 2)
            {
                if (selectedIdx2 <= 0)
                {
                    cbSubButirSerta.DataSource = SubbutirContext.showKegiatanKarya();
                }
            }

            else if (selectedIdx1 == 3)
            {
                if (selectedIdx2 <= 0)
                {
                    cbSubButirSerta.DataSource = SubbutirContext.showKegiatanJabatanFakultas();
                }
            }

            else if (selectedIdx1 == 4)
            {
                if (selectedIdx2 == 0)
                {
                    cbSubButirSerta.DataSource = SubbutirContext.showKegiatanKepesertaanWorkshop();
                }

                else if (selectedIdx2 <= 1)
                {
                    cbSubButirSerta.DataSource = SubbutirContext.showKegiatanKepesertaan();
                }
            }

            else if (selectedIdx1 <= 5)
            {
                cbSubButirSerta.DataSource = null;
            }

            else if (selectedIdx1 <= 6)
            {
                cbSubButirSerta.DataSource = null;
            }
            cbSubButirSerta.DisplayMember = "nama_butir";
            cbSubButirSerta.ValueMember = "nama_butir";
            cbSubButirSerta.Enabled = true;
        }
    }
}
