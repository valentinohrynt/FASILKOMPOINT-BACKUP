namespace FASILKOMPOINT.View.Mahasiswa
{
    partial class FormEntryDataPrestasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntryDataPrestasi));
            label1 = new Label();
            lbl_nama = new Label();
            lbl_tgl = new Label();
            lbl_ket = new Label();
            txt_nama = new TextBox();
            txt_url = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_bukti = new TextBox();
            check_hari = new CheckBox();
            dateTimePicker2 = new DateTimePicker();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txt_nampem = new TextBox();
            txt_notugas = new TextBox();
            lbl_pembimbing = new Label();
            lbl_nosurat = new Label();
            cbButirPrestasi = new ComboBox();
            cbSubButirPrestasi = new ComboBox();
            btn_kembali = new Button();
            btn_simpan = new Button();
            label3 = new Label();
            cbSubKategoriPrestasi = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(303, 36);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(297, 32);
            label1.TabIndex = 0;
            label1.Text = "Form Entry Data Prestasi";
            label1.Click += label1_Click;
            // 
            // lbl_nama
            // 
            lbl_nama.AutoSize = true;
            lbl_nama.BackColor = Color.Transparent;
            lbl_nama.Location = new Point(117, 109);
            lbl_nama.Margin = new Padding(2, 0, 2, 0);
            lbl_nama.Name = "lbl_nama";
            lbl_nama.Size = new Size(82, 15);
            lbl_nama.TabIndex = 1;
            lbl_nama.Text = "Nama Prestasi";
            lbl_nama.Click += lbl_nama_Click;
            // 
            // lbl_tgl
            // 
            lbl_tgl.AutoSize = true;
            lbl_tgl.BackColor = Color.Transparent;
            lbl_tgl.Location = new Point(117, 145);
            lbl_tgl.Margin = new Padding(2, 0, 2, 0);
            lbl_tgl.Name = "lbl_tgl";
            lbl_tgl.Size = new Size(116, 15);
            lbl_tgl.TabIndex = 4;
            lbl_tgl.Text = "Tanggal Pelaksanaan";
            lbl_tgl.Click += label5_Click;
            // 
            // lbl_ket
            // 
            lbl_ket.AutoSize = true;
            lbl_ket.BackColor = Color.Transparent;
            lbl_ket.Location = new Point(117, 206);
            lbl_ket.Margin = new Padding(2, 0, 2, 0);
            lbl_ket.Name = "lbl_ket";
            lbl_ket.Size = new Size(103, 15);
            lbl_ket.TabIndex = 5;
            lbl_ket.Text = "Url Penyelenggara";
            lbl_ket.Click += label6_Click;
            // 
            // txt_nama
            // 
            txt_nama.Location = new Point(303, 101);
            txt_nama.Margin = new Padding(2);
            txt_nama.Name = "txt_nama";
            txt_nama.Size = new Size(489, 23);
            txt_nama.TabIndex = 7;
            // 
            // txt_url
            // 
            txt_url.Location = new Point(303, 203);
            txt_url.Margin = new Padding(2);
            txt_url.Name = "txt_url";
            txt_url.Size = new Size(489, 23);
            txt_url.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(117, 315);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 19;
            label2.Text = "Juara";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(114, 245);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(117, 276);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 22;
            label5.Text = "Level/Tingkat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(117, 350);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 23;
            label6.Text = "File Bukti";
            // 
            // txt_bukti
            // 
            txt_bukti.Location = new Point(303, 344);
            txt_bukti.Margin = new Padding(2);
            txt_bukti.Name = "txt_bukti";
            txt_bukti.Size = new Size(489, 23);
            txt_bukti.TabIndex = 27;
            // 
            // check_hari
            // 
            check_hari.AutoSize = true;
            check_hari.BackColor = Color.Transparent;
            check_hari.Location = new Point(303, 177);
            check_hari.Margin = new Padding(2);
            check_hari.Name = "check_hari";
            check_hari.Size = new Size(107, 19);
            check_hari.TabIndex = 66;
            check_hari.Text = "lebih dari 1 hari";
            check_hari.UseVisualStyleBackColor = false;
            check_hari.CheckedChanged += check_hari_CheckedChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Enabled = false;
            dateTimePicker2.Location = new Point(566, 145);
            dateTimePicker2.Margin = new Padding(2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(226, 23);
            dateTimePicker2.TabIndex = 65;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(538, 151);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(24, 15);
            label9.TabIndex = 64;
            label9.Text = "s/d";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(303, 145);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(226, 23);
            dateTimePicker1.TabIndex = 61;
            // 
            // txt_nampem
            // 
            txt_nampem.Location = new Point(303, 421);
            txt_nampem.Margin = new Padding(2);
            txt_nampem.Name = "txt_nampem";
            txt_nampem.Size = new Size(489, 23);
            txt_nampem.TabIndex = 73;
            // 
            // txt_notugas
            // 
            txt_notugas.Location = new Point(303, 381);
            txt_notugas.Margin = new Padding(2);
            txt_notugas.Name = "txt_notugas";
            txt_notugas.Size = new Size(489, 23);
            txt_notugas.TabIndex = 72;
            // 
            // lbl_pembimbing
            // 
            lbl_pembimbing.AutoSize = true;
            lbl_pembimbing.BackColor = Color.Transparent;
            lbl_pembimbing.Location = new Point(117, 424);
            lbl_pembimbing.Margin = new Padding(2, 0, 2, 0);
            lbl_pembimbing.Name = "lbl_pembimbing";
            lbl_pembimbing.Size = new Size(111, 15);
            lbl_pembimbing.TabIndex = 71;
            lbl_pembimbing.Text = "Nama Pembimbing";
            // 
            // lbl_nosurat
            // 
            lbl_nosurat.AutoSize = true;
            lbl_nosurat.BackColor = Color.Transparent;
            lbl_nosurat.Location = new Point(117, 387);
            lbl_nosurat.Margin = new Padding(2, 0, 2, 0);
            lbl_nosurat.Name = "lbl_nosurat";
            lbl_nosurat.Size = new Size(162, 15);
            lbl_nosurat.TabIndex = 70;
            lbl_nosurat.Text = "No. Surat Tugas Pembimbing";
            lbl_nosurat.Click += label11_Click;
            // 
            // cbButirPrestasi
            // 
            cbButirPrestasi.Enabled = false;
            cbButirPrestasi.FormattingEnabled = true;
            cbButirPrestasi.Items.AddRange(new object[] { "Pilih Level", "Fakultas", "Universitas", "Jurusan", "Nasional", "Internasional", "Propinsi", "Kab/Kota", "Wilayah/Regional" });
            cbButirPrestasi.Location = new Point(303, 272);
            cbButirPrestasi.Margin = new Padding(2);
            cbButirPrestasi.Name = "cbButirPrestasi";
            cbButirPrestasi.Size = new Size(226, 23);
            cbButirPrestasi.TabIndex = 75;
            cbButirPrestasi.SelectedIndexChanged += cbButirPrestasi_SelectedIndexChanged;
            // 
            // cbSubButirPrestasi
            // 
            cbSubButirPrestasi.Enabled = false;
            cbSubButirPrestasi.FormattingEnabled = true;
            cbSubButirPrestasi.Items.AddRange(new object[] { "Pilih Juara", "Juara Lain", "Juara I", "Juara II", "Juara III" });
            cbSubButirPrestasi.Location = new Point(303, 308);
            cbSubButirPrestasi.Margin = new Padding(2);
            cbSubButirPrestasi.Name = "cbSubButirPrestasi";
            cbSubButirPrestasi.Size = new Size(226, 23);
            cbSubButirPrestasi.TabIndex = 76;
            // 
            // btn_kembali
            // 
            btn_kembali.BackColor = Color.OrangeRed;
            btn_kembali.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_kembali.ForeColor = Color.Transparent;
            btn_kembali.Location = new Point(620, 465);
            btn_kembali.Margin = new Padding(2);
            btn_kembali.Name = "btn_kembali";
            btn_kembali.Size = new Size(79, 24);
            btn_kembali.TabIndex = 83;
            btn_kembali.Text = "Kembali";
            btn_kembali.UseVisualStyleBackColor = false;
            btn_kembali.Click += btn_kembali_Click;
            // 
            // btn_simpan
            // 
            btn_simpan.BackColor = Color.LimeGreen;
            btn_simpan.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_simpan.ForeColor = Color.Transparent;
            btn_simpan.Location = new Point(713, 465);
            btn_simpan.Margin = new Padding(2);
            btn_simpan.Name = "btn_simpan";
            btn_simpan.Size = new Size(79, 24);
            btn_simpan.TabIndex = 82;
            btn_simpan.Text = "Simpan";
            btn_simpan.UseVisualStyleBackColor = false;
            btn_simpan.Click += btn_simpan_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(117, 242);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 84;
            label3.Text = "Kategori Prestasi";
            // 
            // cbSubKategoriPrestasi
            // 
            cbSubKategoriPrestasi.FormattingEnabled = true;
            cbSubKategoriPrestasi.Location = new Point(303, 236);
            cbSubKategoriPrestasi.Name = "cbSubKategoriPrestasi";
            cbSubKategoriPrestasi.Size = new Size(226, 23);
            cbSubKategoriPrestasi.TabIndex = 85;
            cbSubKategoriPrestasi.SelectedIndexChanged += cbSubKategoriPrestasi_SelectedIndexChanged;
            // 
            // FormEntryDataPrestasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(921, 528);
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
            Margin = new Padding(2);
            Name = "FormEntryDataPrestasi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Entry Data Prestasi";
            FormClosing += All_FormClosing;
            Load += EntryDataPrestasi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_nama;
        private Label lbl_tgl;
        private Label lbl_ket;
        private TextBox txt_nama;
        private TextBox txt_url;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_bukti;
        private CheckBox check_hari;
        private DateTimePicker dateTimePicker2;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private TextBox txt_nampem;
        private TextBox txt_notugas;
        private Label lbl_pembimbing;
        private Label lbl_nosurat;
        private ComboBox cbButirPrestasi;
        private ComboBox cbSubButirPrestasi;
        private Button btn_kembali;
        private Button btn_simpan;
        private Label label3;
        private ComboBox cbSubKategoriPrestasi;
    }
}