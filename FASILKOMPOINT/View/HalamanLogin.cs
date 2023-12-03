using FASILKOMPOINT.App.Context;
using FASILKOMPOINT.App.Core;
using FASILKOMPOINT.View.Mahasiswa;
using FASILKOMPOINT.View.SKPI;
using FASILKOMPOINT.View.TU;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FASILKOMPOINT.View
{
    public partial class Halaman : Form
    {
        public Halaman instance;
        public TextBox tb1;
        private TextBox tb2;
        private bool isButton1Hovered = false;
        public string username { get; private set; }

        public Halaman()
        {
            InitializeComponent();
            instance = this;

            passwordtb.PasswordChar = '*';
            loginbutton.MouseEnter += button1_MouseEnter;
            loginbutton.MouseLeave += button1_MouseLeave;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void FasilkomPOint_Click(object sender, EventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string username = usernametb.Text;
            string password = passwordtb.Text;
            int id_role = UserContext.CekLogin(username, password);
            this.username = username;
            if (id_role == 1)
            {
                BerandaSKPI berandaSKPI = new BerandaSKPI();
                berandaSKPI.Show();
                this.Hide();
            }
            else if (id_role == 2)
            {
                BerandaTU berandaTU = new BerandaTU();
                berandaTU.Show();
                this.Hide();
            }
            else if (id_role == 3)
            {
                BerandaMahasiswa berandaMahasiswa = new BerandaMahasiswa(username);
                berandaMahasiswa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Maaf username atau password yang Anda inputkan salah, silahkan ulangi kembali.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            // Mengubah warna tombol button1 saat cursor mendekatinya
            isButton1Hovered = true;
            loginbutton.ForeColor = Color.DarkBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            // Mengembalikan warna tombol button1 saat cursor menjauh
            isButton1Hovered = false;
            loginbutton.ForeColor = Color.Black;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
