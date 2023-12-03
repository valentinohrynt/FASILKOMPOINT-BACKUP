namespace FASILKOMPOINT.View.Mahasiswa
{
    partial class FormUbahDataPrestasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUbahDataPrestasi));
            cbSubKategoriPrestasi = new ComboBox();
            label3 = new Label();
            btn_kembali = new Button();
            btn_simpan = new Button();
            cbSubButirPrestasi = new ComboBox();
            cbButirPrestasi = new ComboBox();
            txt_nampem = new TextBox();
            txt_notugas = new TextBox();
            lbl_pembimbing = new Label();
            lbl_nosurat = new Label();
            check_hari = new CheckBox();
            dateTimePicker2 = new DateTimePicker();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txt_bukti = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            txt_url = new TextBox();
            txt_nama = new TextBox();
            lbl_ket = new Label();
            lbl_tgl = new Label();
            lbl_nama = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // cbSubKategoriPrestasi
            // 
            cbSubKategoriPrestasi.FormattingEnabled = true;
            cbSubKategoriPrestasi.Location = new Point(310, 258);
            cbSubKategoriPrestasi.Name = "cbSubKategoriPrestasi";
            cbSubKategoriPrestasi.Size = new Size(226, 23);
            cbSubKategoriPrestasi.TabIndex = 110;
            cbSubKategoriPrestasi.SelectedIndexChanged += cbSubKategoriPrestasi_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(124, 264);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 109;
            label3.Text = "Kategori Prestasi";
            // 
            // btn_kembali
            // 
            btn_kembali.BackColor = Color.OrangeRed;
            btn_kembali.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_kembali.ForeColor = Color.Transparent;
            btn_kembali.Location = new Point(627, 512);
            btn_kembali.Margin = new Padding(2);
            btn_kembali.Name = "btn_kembali";
            btn_kembali.Size = new Size(79, 24);
            btn_kembali.TabIndex = 108;
            btn_kembali.Text = "Kembali";
            btn_kembali.UseVisualStyleBackColor = false;
            btn_kembali.Click += btn_kembali_Click;
            // 
            // btn_simpan
            // 
            btn_simpan.BackColor = Color.LimeGreen;
            btn_simpan.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_simpan.ForeColor = Color.Transparent;
            btn_simpan.Location = new Point(720, 512);
            btn_simpan.Margin = new Padding(2);
            btn_simpan.Name = "btn_simpan";
            btn_simpan.Size = new Size(79, 24);
            btn_simpan.TabIndex = 107;
            btn_simpan.Text = "Simpan";
            btn_simpan.UseVisualStyleBackColor = false;
            btn_simpan.Click += btn_simpan_Click;
            // 
            // cbSubButirPrestasi
            // 
            cbSubButirPrestasi.Enabled = false;
            cbSubButirPrestasi.FormattingEnabled = true;
            cbSubButirPrestasi.Items.AddRange(new object[] { "Pilih Juara", "Juara Lain", "Juara I", "Juara II", "Juara III" });
            cbSubButirPrestasi.Location = new Point(310, 330);
            cbSubButirPrestasi.Margin = new Padding(2);
            cbSubButirPrestasi.Name = "cbSubButirPrestasi";
            cbSubButirPrestasi.Size = new Size(226, 23);
            cbSubButirPrestasi.TabIndex = 106;
            cbSubButirPrestasi.SelectedIndexChanged += cbSubButirPrestasi_SelectedIndexChanged;
            // 
            // cbButirPrestasi
            // 
            cbButirPrestasi.Enabled = false;
            cbButirPrestasi.FormattingEnabled = true;
            cbButirPrestasi.Items.AddRange(new object[] { "Pilih Level", "Fakultas", "Universitas", "Jurusan", "Nasional", "Internasional", "Propinsi", "Kab/Kota", "Wilayah/Regional" });
            cbButirPrestasi.Location = new Point(310, 294);
            cbButirPrestasi.Margin = new Padding(2);
            cbButirPrestasi.Name = "cbButirPrestasi";
            cbButirPrestasi.Size = new Size(226, 23);
            cbButirPrestasi.TabIndex = 105;
            cbButirPrestasi.SelectedIndexChanged += cbButirPrestasi_SelectedIndexChanged;
            // 
            // txt_nampem
            // 
            txt_nampem.Location = new Point(310, 443);
            txt_nampem.Margin = new Padding(2);
            txt_nampem.Name = "txt_nampem";
            txt_nampem.Size = new Size(489, 23);
            txt_nampem.TabIndex = 104;
            // 
            // txt_notugas
            // 
            txt_notugas.Location = new Point(310, 403);
            txt_notugas.Margin = new Padding(2);
            txt_notugas.Name = "txt_notugas";
            txt_notugas.Size = new Size(489, 23);
            txt_notugas.TabIndex = 103;
            // 
            // lbl_pembimbing
            // 
            lbl_pembimbing.AutoSize = true;
            lbl_pembimbing.BackColor = Color.Transparent;
            lbl_pembimbing.Location = new Point(124, 446);
            lbl_pembimbing.Margin = new Padding(2, 0, 2, 0);
            lbl_pembimbing.Name = "lbl_pembimbing";
            lbl_pembimbing.Size = new Size(111, 15);
            lbl_pembimbing.TabIndex = 102;
            lbl_pembimbing.Text = "Nama Pembimbing";
            // 
            // lbl_nosurat
            // 
            lbl_nosurat.AutoSize = true;
            lbl_nosurat.BackColor = Color.Transparent;
            lbl_nosurat.Location = new Point(124, 409);
            lbl_nosurat.Margin = new Padding(2, 0, 2, 0);
            lbl_nosurat.Name = "lbl_nosurat";
            lbl_nosurat.Size = new Size(162, 15);
            lbl_nosurat.TabIndex = 101;
            lbl_nosurat.Text = "No. Surat Tugas Pembimbing";
            // 
            // check_hari
            // 
            check_hari.AutoSize = true;
            check_hari.BackColor = Color.Transparent;
            check_hari.Location = new Point(310, 199);
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
            dateTimePicker2.Location = new Point(573, 167);
            dateTimePicker2.Margin = new Padding(2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(226, 23);
            dateTimePicker2.TabIndex = 99;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(545, 173);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(24, 15);
            label9.TabIndex = 98;
            label9.Text = "s/d";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(310, 167);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(226, 23);
            dateTimePicker1.TabIndex = 97;
            // 
            // txt_bukti
            // 
            txt_bukti.Location = new Point(310, 366);
            txt_bukti.Margin = new Padding(2);
            txt_bukti.Name = "txt_bukti";
            txt_bukti.Size = new Size(489, 23);
            txt_bukti.TabIndex = 96;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(124, 372);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 95;
            label6.Text = "File Bukti";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(124, 298);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 94;
            label5.Text = "Level/Tingkat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 267);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 93;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(124, 333);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 92;
            label2.Text = "Juara";
            // 
            // txt_url
            // 
            txt_url.Location = new Point(310, 225);
            txt_url.Margin = new Padding(2);
            txt_url.Name = "txt_url";
            txt_url.Size = new Size(489, 23);
            txt_url.TabIndex = 91;
            // 
            // txt_nama
            // 
            txt_nama.Location = new Point(310, 123);
            txt_nama.Margin = new Padding(2);
            txt_nama.Name = "txt_nama";
            txt_nama.Size = new Size(489, 23);
            txt_nama.TabIndex = 90;
            // 
            // lbl_ket
            // 
            lbl_ket.AutoSize = true;
            lbl_ket.BackColor = Color.Transparent;
            lbl_ket.Location = new Point(124, 228);
            lbl_ket.Margin = new Padding(2, 0, 2, 0);
            lbl_ket.Name = "lbl_ket";
            lbl_ket.Size = new Size(103, 15);
            lbl_ket.TabIndex = 89;
            lbl_ket.Text = "Url Penyelenggara";
            // 
            // lbl_tgl
            // 
            lbl_tgl.AutoSize = true;
            lbl_tgl.BackColor = Color.Transparent;
            lbl_tgl.Location = new Point(124, 167);
            lbl_tgl.Margin = new Padding(2, 0, 2, 0);
            lbl_tgl.Name = "lbl_tgl";
            lbl_tgl.Size = new Size(116, 15);
            lbl_tgl.TabIndex = 88;
            lbl_tgl.Text = "Tanggal Pelaksanaan";
            // 
            // lbl_nama
            // 
            lbl_nama.AutoSize = true;
            lbl_nama.BackColor = Color.Transparent;
            lbl_nama.Location = new Point(124, 131);
            lbl_nama.Margin = new Padding(2, 0, 2, 0);
            lbl_nama.Name = "lbl_nama";
            lbl_nama.Size = new Size(82, 15);
            lbl_nama.TabIndex = 87;
            lbl_nama.Text = "Nama Prestasi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(310, 58);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(295, 32);
            label1.TabIndex = 86;
            label1.Text = "Form Ubah Data Prestasi";
            // 
            // FormUbahDataPrestasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FASILKOM_POINT__1_;
            ClientSize = new Size(921, 618);
            Controls.Add(cbSubKategoriPrestasi);
            Controls.Add(label3);
            Controls.Add(btn_kembali);
            Controls.Add(btn_simpan);
            Controls.Add(cbSubButirPrestasi);
            Controls.Add(cbButirPrestasi);
            Controls.Add(txt_nampem);
            Controls.Add(txt_notugas);
            Controls.Add(lbl_pembimbing);
            Controls.Add(lbl_nosurat);
            Controls.Add(check_hari);
            Controls.Add(dateTimePicker2);
            Controls.Add(label9);
            Controls.Add(dateTimePicker1);
            Controls.Add(txt_bukti);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txt_url);
            Controls.Add(txt_nama);
            Controls.Add(lbl_ket);
            Controls.Add(lbl_tgl);
            Controls.Add(lbl_nama);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormUbahDataPrestasi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Ubah Data Prestasi";
            Load += FormUbahDataPrestasi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbSubKategoriPrestasi;
        private Label label3;
        private Button btn_kembali;
        private Button btn_simpan;
        private ComboBox cbSubButirPrestasi;
        private ComboBox cbButirPrestasi;
        private TextBox txt_nampem;
        private TextBox txt_notugas;
        private Label lbl_pembimbing;
        private Label lbl_nosurat;
        private CheckBox check_hari;
        private DateTimePicker dateTimePicker2;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private TextBox txt_bukti;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private TextBox txt_url;
        private TextBox txt_nama;
        private Label lbl_ket;
        private Label lbl_tgl;
        private Label lbl_nama;
        private Label label1;
    }
}