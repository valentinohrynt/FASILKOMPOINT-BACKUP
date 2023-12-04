using FASILKOMPOINT.App.Context;
using FASILKOMPOINT.App.Core;
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
    public partial class RekapDataSKPI : Form
    {
        public string username { get; set; }
        public RekapDataSKPI(string username)
        {
            InitializeComponent();
            this.username = username;
            DataTable rekapData = AktivitasPrestasiContext.showRekapPrestasi(username, 602);
            dataGridView1.DataSource = rekapData;
            dataGridView1.Columns["Keterangan"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            defaultpoin.Text = Convert.ToString(AktivitasKeikutsertaanContext.AkumulasiPoin(username));
        }


        private void RekapDataSKPI_Load(object sender, EventArgs e)
        {

        }

        private void btn_prestasi_Click(object sender, EventArgs e)
        {
            DataTable rekapData = AktivitasPrestasiContext.showRekapPrestasi(username, 602);
            dataGridView1.DataSource = rekapData;
            dataGridView1.Columns["Keterangan"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            BerandaMahasiswa berandaMahasiswa = new BerandaMahasiswa(username);
            berandaMahasiswa.Show();
        }

        private void btn_kegiatan_Click(object sender, EventArgs e)
        {
            DataTable rekapData = AktivitasKeikutsertaanContext.showRekapKeikutsertaan(username, 601);
            dataGridView1.DataSource = rekapData;
            dataGridView1.Columns["Keterangan"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void btn_sertifikasi_Click(object sender, EventArgs e)
        {
            DataTable rekapData = AktivitasSertifikasiContext.showRekapSertifikasi(username, 603);
            dataGridView1.DataSource = rekapData;
            dataGridView1.Columns["Keterangan"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void defaultpoin_Click(object sender, EventArgs e)
        {

        }
        private void All_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
