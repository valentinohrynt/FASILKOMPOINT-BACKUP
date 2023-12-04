namespace FASILKOMPOINT.View.Mahasiswa
{
    partial class FormUbahDataKegiatan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUbahDataKegiatan));
            cbSubKategoriKegiatan = new ComboBox();
            label3 = new Label();
            cbButirSerta = new ComboBox();
            label2 = new Label();
            cbSubButirSerta = new ComboBox();
            check_hari = new CheckBox();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            btn_kembali = new Button();
            btn_simpan = new Button();
            txt_bukti = new TextBox();
            lbl_bukti = new Label();
            lbl_tingkat = new Label();
            dateTimePicker1 = new DateTimePicker();
            txt_nama = new TextBox();
            lbl_tgl = new Label();
            lbl_nama = new Label();
            lbl_judul = new Label();
            SuspendLayout();
            // 
            // cbSubKategoriKegiatan
            // 
            cbSubKategoriKegiatan.FormattingEnabled = true;
            cbSubKategoriKegiatan.Location = new Point(291, 250);
            cbSubKategoriKegiatan.Name = "cbSubKategoriKegiatan";
            cbSubKategoriKegiatan.Size = new Size(434, 23);
            cbSubKategoriKegiatan.TabIndex = 105;
            cbSubKategoriKegiatan.SelectedIndexChanged += cbSubKategoriKegiatan_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(105, 256);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 104;
            label3.Text = "Kategori Kegiatan";
            // 
            // cbButirSerta
            // 
            cbButirSerta.Enabled = false;
            cbButirSerta.FormattingEnabled = true;
            cbButirSerta.Location = new Point(290, 289);
            cbButirSerta.Name = "cbButirSerta";
            cbButirSerta.Size = new Size(226, 23);
            cbButirSerta.TabIndex = 103;
            cbButirSerta.SelectedIndexChanged += cbButirSerta_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(105, 332);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 102;
            label2.Text = "Jenis Kepesertaan";
            // 
            // cbSubButirSerta
            // 
            cbSubButirSerta.Enabled = false;
            cbSubButirSerta.FormattingEnabled = true;
            cbSubButirSerta.Location = new Point(290, 329);
            cbSubButirSerta.Margin = new Padding(2);
            cbSubButirSerta.Name = "cbSubButirSerta";
            cbSubButirSerta.Size = new Size(226, 23);
            cbSubButirSerta.TabIndex = 101;
            // 
            // check_hari
            // 
            check_hari.AutoSize = true;
            check_hari.BackColor = Color.Transparent;
            check_hari.Location = new Point(290, 219);
            check_hari.Margin = new Padding(2);
            check_hari.Name = "check_hari";
            check_hari.Size = new Size(107, 19);
            check_hari.TabIndex = 100;
            check_hari.Text = "lebih dari 1 hari";
            check_hari.UseVisualStyleBackColor = false;
            check_hari.CheckedChanged += check_hari_CheckedChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Enabled = false;
            dateTimePicker2.Location = new Point(549, 186);
            dateTimePicker2.Margin = new Padding(2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(225, 23);
            dateTimePicker2.TabIndex = 99;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(520, 189);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 98;
            label1.Text = "s/d";
            // 
            // btn_kembali
            // 
            btn_kembali.BackColor = Color.OrangeRed;
            btn_kembali.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_kembali.ForeColor = Color.Transparent;
            btn_kembali.Location = new Point(634, 456);
            btn_kembali.Margin = new Padding(2);
            btn_kembali.Name = "btn_kembali";
            btn_kembali.Size = new Size(79, 24);
            btn_kembali.TabIndex = 97;
            btn_kembali.Text = "Kembali";
            btn_kembali.UseVisualStyleBackColor = false;
            btn_kembali.Click += btn_kembali_Click;
            // 
            // btn_simpan
            // 
            btn_simpan.BackColor = Color.LimeGreen;
            btn_simpan.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_simpan.ForeColor = Color.Transparent;
            btn_simpan.Location = new Point(717, 456);
            btn_simpan.Margin = new Padding(2);
            btn_simpan.Name = "btn_simpan";
            btn_simpan.Size = new Size(79, 24);
            btn_simpan.TabIndex = 96;
            btn_simpan.Text = "Simpan";
            btn_simpan.UseVisualStyleBackColor = false;
            btn_simpan.Click += btn_simpan_Click;
            // 
            // txt_bukti
            // 
            txt_bukti.Location = new Point(290, 378);
            txt_bukti.Margin = new Padding(2);
            txt_bukti.Name = "txt_bukti";
            txt_bukti.Size = new Size(490, 23);
            txt_bukti.TabIndex = 95;
            // 
            // lbl_bukti
            // 
            lbl_bukti.AutoSize = true;
            lbl_bukti.BackColor = Color.Transparent;
            lbl_bukti.Location = new Point(105, 381);
            lbl_bukti.Margin = new Padding(2, 0, 2, 0);
            lbl_bukti.Name = "lbl_bukti";
            lbl_bukti.Size = new Size(55, 15);
            lbl_bukti.TabIndex = 94;
            lbl_bukti.Text = "File Bukti";
            // 
            // lbl_tingkat
            // 
            lbl_tingkat.AutoSize = true;
            lbl_tingkat.BackColor = Color.Transparent;
            lbl_tingkat.Location = new Point(105, 292);
            lbl_tingkat.Margin = new Padding(2, 0, 2, 0);
            lbl_tingkat.Name = "lbl_tingkat";
            lbl_tingkat.Size = new Size(78, 15);
            lbl_tingkat.TabIndex = 93;
            lbl_tingkat.Text = "Level/Tingkat";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(290, 185);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(226, 23);
            dateTimePicker1.TabIndex = 92;
            // 
            // txt_nama
            // 
            txt_nama.Location = new Point(290, 136);
            txt_nama.Margin = new Padding(2);
            txt_nama.Name = "txt_nama";
            txt_nama.Size = new Size(489, 23);
            txt_nama.TabIndex = 91;
            // 
            // lbl_tgl
            // 
            lbl_tgl.AutoSize = true;
            lbl_tgl.BackColor = Color.Transparent;
            lbl_tgl.Location = new Point(105, 188);
            lbl_tgl.Margin = new Padding(2, 0, 2, 0);
            lbl_tgl.Name = "lbl_tgl";
            lbl_tgl.Size = new Size(116, 15);
            lbl_tgl.TabIndex = 90;
            lbl_tgl.Text = "Tanggal Pelaksanaan";
            lbl_tgl.Click += lbl_tgl_Click;
            // 
            // lbl_nama
            // 
            lbl_nama.AutoSize = true;
            lbl_nama.BackColor = Color.Transparent;
            lbl_nama.Location = new Point(105, 141);
            lbl_nama.Margin = new Padding(2, 0, 2, 0);
            lbl_nama.Name = "lbl_nama";
            lbl_nama.Size = new Size(88, 15);
            lbl_nama.TabIndex = 89;
            lbl_nama.Text = "Nama Kegiatan";
            lbl_nama.Click += lbl_nama_Click;
            // 
            // lbl_judul
            // 
            lbl_judul.AutoSize = true;
            lbl_judul.BackColor = Color.Transparent;
            lbl_judul.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_judul.Location = new Point(308, 49);
            lbl_judul.Margin = new Padding(2, 0, 2, 0);
            lbl_judul.Name = "lbl_judul";
            lbl_judul.Size = new Size(307, 32);
            lbl_judul.TabIndex = 88;
            lbl_judul.Text = "Form Ubah Data Kegiatan";
            // 
            // FormUbahDataKegiatan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FASILKOM_POINT__1_;
            ClientSize = new Size(921, 528);
            Controls.Add(cbSubKategoriKegiatan);
            Controls.Add(label3);
            Controls.Add(cbButirSerta);
            Controls.Add(label2);
            Controls.Add(cbSubButirSerta);
            Controls.Add(check_hari);
            Controls.Add(dateTimePicker2);
            Controls.Add(label1);
            Controls.Add(btn_kembali);
            Controls.Add(btn_simpan);
            Controls.Add(txt_bukti);
            Controls.Add(lbl_bukti);
            Controls.Add(lbl_tingkat);
            Controls.Add(dateTimePicker1);
            Controls.Add(txt_nama);
            Controls.Add(lbl_tgl);
            Controls.Add(lbl_nama);
            Controls.Add(lbl_judul);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormUbahDataKegiatan";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Ubah Data Kegiatan";
            FormClosing += All_FormClosing;
            Load += FormUbahDataKegiatan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbSubKategoriKegiatan;
        private Label label3;
        private ComboBox cbButirSerta;
        private Label label2;
        private ComboBox cbSubButirSerta;
        private CheckBox check_hari;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Button btn_kembali;
        private Button btn_simpan;
        private TextBox txt_bukti;
        private Label lbl_bukti;
        private Label lbl_tingkat;
        private DateTimePicker dateTimePicker1;
        private TextBox txt_nama;
        private Label lbl_tgl;
        private Label lbl_nama;
        private Label lbl_judul;
    }
}