using FASILKOMPOINT.App.Context;
using FASILKOMPOINT.App.Core;
using FASILKOMPOINT.View.Mahasiswa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FASILKOMPOINT.View.SKPI
{
    public partial class Grafik : Form
    {
        public Grafik()
        {
            InitializeComponent();
            DataTable result = GrafikContext.grafikPrestasi();

            Series seriesPrestasi = chart1.Series.Add("Prestasi");

            chart1.DataSource = result;

            seriesPrestasi.XValueMember = "tahun";
            seriesPrestasi.YValueMembers = "jumlah_prestasi";

            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = true;

            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            seriesPrestasi.ChartType = SeriesChartType.Column;
        }

        private void Grafik_Load(object sender, EventArgs e)
        {

        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            BerandaSKPI berandaSKPI = new BerandaSKPI();
            berandaSKPI.Show();
            this.Hide();
        }

        private void btn_sertifikasi_Click(object sender, EventArgs e)
        {
            this.Hide();
            GrafikSertifikasi grafikSertifikasi = new GrafikSertifikasi();
            grafikSertifikasi.Show();
        }

        private void btn_kegiatan_Click(object sender, EventArgs e)
        {
            this.Hide();
            GrafikKegiatan grafikKegiatan = new GrafikKegiatan();
            grafikKegiatan.Show();
        }

        private void btn_prestasi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Grafik grafik = new Grafik();
            grafik.Show();
        }
    }
}
