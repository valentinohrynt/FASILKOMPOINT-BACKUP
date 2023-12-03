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

namespace FASILKOMPOINT.View.SKPI
{
    public partial class ValidasiSKPIMahasiswa : Form
    {
        public string nim { get; set; }
        public ValidasiSKPIMahasiswa()
        {
            InitializeComponent();

            dataGridView1.DataSource = MahasiswaContext.showValidasiSKPI();

            DataGridViewButtonColumn detailButton = new DataGridViewButtonColumn();
            detailButton.HeaderText = "Detail";
            detailButton.Text = "Detail";
            detailButton.Name = "detailButton";
            detailButton.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert(4, detailButton);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BerandaSKPI berandaSKPI = new BerandaSKPI();
            berandaSKPI.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ValidasiSKPIMahasiswa_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ExecuteSearch();
                e.Handled = true;
            }
        }
        private void ExecuteSearch()
        {
            string searchquery = textBox1.Text;
            try
            {
                if (string.IsNullOrWhiteSpace(searchquery))
                {
                    ValidasiSKPIMahasiswa validasiSKPIMahasiswa = new ValidasiSKPIMahasiswa();
                    validasiSKPIMahasiswa.Show();
                    this.Hide();
                }
                else
                {
                    dataGridView1.DataSource = MahasiswaContext.showSearchValidasiSKPI(searchquery);

                    if (dataGridView1.Columns.Contains("detailButton"))
                    {
                        dataGridView1.Columns.Remove("detailButton");
                    }

                    DataGridViewButtonColumn detailButton = new DataGridViewButtonColumn();
                    detailButton.HeaderText = "Detail";
                    detailButton.Text = "Detail";
                    detailButton.Name = "detailButton";
                    detailButton.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(detailButton);

                    dataGridView1.Columns["nama_mahasiswa"].DisplayIndex = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchquery = textBox1.Text;
            if (string.IsNullOrWhiteSpace(searchquery))
            {
                ValidasiSKPIMahasiswa validasiSKPIMahasiswa = new ValidasiSKPIMahasiswa();
                validasiSKPIMahasiswa.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExecuteSearch();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["detailButton"].Index && e.RowIndex >= 0)
            {
                string nim = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["nim"].Value);
                this.nim = nim;

                DetailValidasiSKPIMahasiswa detailValidasiSKPIMahasiswa = new DetailValidasiSKPIMahasiswa(nim);
                detailValidasiSKPIMahasiswa.Show();
                this.Hide();
            }
        }
    }
}

