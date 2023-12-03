using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FASILKOMPOINT.View.Mahasiswa
{
    partial class RekapDataSKPI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RekapDataSKPI));
            panel1 = new Panel();
            btn_kembali = new Button();
            btn_sertifikasi = new Button();
            btn_kegiatan = new Button();
            btn_prestasi = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            defaultpoin = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btn_kembali);
            panel1.Controls.Add(btn_sertifikasi);
            panel1.Controls.Add(btn_kegiatan);
            panel1.Controls.Add(btn_prestasi);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(111, 528);
            panel1.TabIndex = 0;
            // 
            // btn_kembali
            // 
            btn_kembali.Location = new Point(11, 483);
            btn_kembali.Margin = new Padding(2);
            btn_kembali.Name = "btn_kembali";
            btn_kembali.Size = new Size(86, 23);
            btn_kembali.TabIndex = 17;
            btn_kembali.Text = "Kembali";
            btn_kembali.UseVisualStyleBackColor = true;
            btn_kembali.Click += btn_kembali_Click;
            // 
            // btn_sertifikasi
            // 
            btn_sertifikasi.Location = new Point(11, 95);
            btn_sertifikasi.Margin = new Padding(3, 2, 3, 2);
            btn_sertifikasi.Name = "btn_sertifikasi";
            btn_sertifikasi.Size = new Size(86, 23);
            btn_sertifikasi.TabIndex = 2;
            btn_sertifikasi.Text = "Sertifikasi";
            btn_sertifikasi.UseVisualStyleBackColor = true;
            btn_sertifikasi.Click += btn_sertifikasi_Click;
            // 
            // btn_kegiatan
            // 
            btn_kegiatan.Location = new Point(11, 69);
            btn_kegiatan.Margin = new Padding(3, 2, 3, 2);
            btn_kegiatan.Name = "btn_kegiatan";
            btn_kegiatan.Size = new Size(86, 23);
            btn_kegiatan.TabIndex = 1;
            btn_kegiatan.Text = "Kegiatan";
            btn_kegiatan.UseVisualStyleBackColor = true;
            btn_kegiatan.Click += btn_kegiatan_Click;
            // 
            // btn_prestasi
            // 
            btn_prestasi.Location = new Point(11, 43);
            btn_prestasi.Margin = new Padding(3, 2, 3, 2);
            btn_prestasi.Name = "btn_prestasi";
            btn_prestasi.Size = new Size(86, 23);
            btn_prestasi.TabIndex = 0;
            btn_prestasi.Text = "Prestasi";
            btn_prestasi.UseVisualStyleBackColor = true;
            btn_prestasi.Click += btn_prestasi_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(124, 84);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(787, 435);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Candara", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(423, 25);
            label1.Name = "label1";
            label1.Size = new Size(181, 29);
            label1.TabIndex = 7;
            label1.Text = "Rekap Data SKPI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(124, 62);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 8;
            label2.Text = "Total Poin Keseluruhan :";
            // 
            // defaultpoin
            // 
            defaultpoin.AutoSize = true;
            defaultpoin.BackColor = Color.Transparent;
            defaultpoin.Location = new Point(257, 62);
            defaultpoin.Name = "defaultpoin";
            defaultpoin.Size = new Size(32, 15);
            defaultpoin.TabIndex = 9;
            defaultpoin.Text = "label";
            defaultpoin.Click += defaultpoin_Click;
            // 
            // RekapDataSKPI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FASILKOM_POINT__2_;
            ClientSize = new Size(921, 528);
            Controls.Add(defaultpoin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "RekapDataSKPI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rekap Data SKPI";
            Load += RekapDataSKPI_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btn_sertifikasi;
        private Button btn_kegiatan;
        private Button btn_prestasi;
        private DataGridView dataGridView1;
        private Button btn_kembali;
        private Label label1;
        private Label label2;
        private Label defaultpoin;
    }
}