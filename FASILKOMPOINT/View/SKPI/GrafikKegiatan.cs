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
using System.Windows.Forms.DataVisualization.Charting;

namespace FASILKOMPOINT.View.SKPI
{
    public partial class GrafikKegiatan : Form
    {
        public GrafikKegiatan()
        {
            InitializeComponent();
            DataTable result = GrafikContext.grafikKegiatan();

            Series seriesKegiatan = chart1.Series.Add("Kegiatan");

            chart1.DataSource = result;

            seriesKegiatan.XValueMember = "tahun";
            seriesKegiatan.YValueMembers = "jumlah_kegiatan";

            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = true;

            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            seriesKegiatan.ChartType = SeriesChartType.Column;
        }

        private void GrafikKegiatan_Load(object sender, EventArgs e)
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
        private void All_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
