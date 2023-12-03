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
    public partial class DataSKPIMahasiswa : Form
    {
        public DataSKPIMahasiswa()
        {
            InitializeComponent();
            dataGridView1.DataSource = MahasiswaContext.showDataSKPIMahasiswa();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BerandaSKPI berandaSKPI = new BerandaSKPI();
            berandaSKPI.Show();
            this.Hide();
        }

        private void DataSKPIMahasiswa_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    dataGridView1.DataSource = MahasiswaContext.showDataSKPIMahasiswa();
                }
                else
                {
                    dataGridView1.DataSource = MahasiswaContext.showSearchDataMahasiswa(searchquery);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                dataGridView1.DataSource = MahasiswaContext.showDataSKPIMahasiswa();
            }
            ExecuteSearch();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExecuteSearch();
        }
    }
}
