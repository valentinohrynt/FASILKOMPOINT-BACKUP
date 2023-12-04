namespace FASILKOMPOINT.View.Mahasiswa
{
    partial class FormUbahDataSertifikasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUbahDataSertifikasi));
            btn_kembali = new Button();
            btn_simpan = new Button();
            cbButirSertifikasi = new ComboBox();
            check_hari = new CheckBox();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txt_bukti = new TextBox();
            txt_tingkat = new TextBox();
            lbl_bukti = new Label();
            lbl_tingkat = new Label();
            txt_nama = new TextBox();
            lbl_ket = new Label();
            lbl_tgl = new Label();
            lbl_nama = new Label();
            lbl_judul = new Label();
            SuspendLayout();
            // 
            // btn_kembali
            // 
            btn_kembali.BackColor = Color.OrangeRed;
            btn_kembali.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_kembali.ForeColor = Color.Transparent;
            btn_kembali.Location = new Point(625, 448);
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
            btn_simpan.Location = new Point(718, 448);
            btn_simpan.Margin = new Padding(2);
            btn_simpan.Name = "btn_simpan";
            btn_simpan.Size = new Size(79, 24);
            btn_simpan.TabIndex = 96;
            btn_simpan.Text = "Simpan";
            btn_simpan.UseVisualStyleBackColor = false;
            btn_simpan.Click += btn_simpan_Click;
            // 
            // cbButirSertifikasi
            // 
            cbButirSertifikasi.FormattingEnabled = true;
            cbButirSertifikasi.Items.AddRange(new object[] { "Pilih Tingkat Penyeleggara", "Internasional", "Nasional" });
            cbButirSertifikasi.Location = new Point(308, 262);
            cbButirSertifikasi.Margin = new Padding(2);
            cbButirSertifikasi.Name = "cbButirSertifikasi";
            cbButirSertifikasi.Size = new Size(226, 23);
            cbButirSertifikasi.TabIndex = 95;
            cbButirSertifikasi.SelectedIndexChanged += cbButirSertifikasi_SelectedIndexChanged;
            // 
            // check_hari
            // 
            check_hari.AutoSize = true;
            check_hari.BackColor = Color.Transparent;
            check_hari.Location = new Point(308, 229);
            check_hari.Margin = new Padding(2);
            check_hari.Name = "check_hari";
            check_hari.Size = new Size(107, 19);
            check_hari.TabIndex = 94;
            check_hari.Text = "lebih dari 1 hari";
            check_hari.UseVisualStyleBackColor = false;
            check_hari.CheckedChanged += check_hari_CheckedChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Enabled = false;
            dateTimePicker2.Location = new Point(568, 199);
            dateTimePicker2.Margin = new Padding(2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(230, 23);
            dateTimePicker2.TabIndex = 93;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(538, 204);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 92;
            label1.Text = "s/d";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(308, 199);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(226, 23);
            dateTimePicker1.TabIndex = 91;
            // 
            // txt_bukti
            // 
            txt_bukti.Location = new Point(308, 357);
            txt_bukti.Margin = new Padding(2);
            txt_bukti.Name = "txt_bukti";
            txt_bukti.Size = new Size(306, 23);
            txt_bukti.TabIndex = 90;
            // 
            // txt_tingkat
            // 
            txt_tingkat.Location = new Point(308, 308);
            txt_tingkat.Margin = new Padding(2);
            txt_tingkat.Name = "txt_tingkat";
            txt_tingkat.Size = new Size(306, 23);
            txt_tingkat.TabIndex = 89;
            // 
            // lbl_bukti
            // 
            lbl_bukti.AutoSize = true;
            lbl_bukti.BackColor = Color.Transparent;
            lbl_bukti.Location = new Point(123, 363);
            lbl_bukti.Margin = new Padding(2, 0, 2, 0);
            lbl_bukti.Name = "lbl_bukti";
            lbl_bukti.Size = new Size(55, 15);
            lbl_bukti.TabIndex = 88;
            lbl_bukti.Text = "File Bukti";
            // 
            // lbl_tingkat
            // 
            lbl_tingkat.AutoSize = true;
            lbl_tingkat.BackColor = Color.Transparent;
            lbl_tingkat.Location = new Point(123, 308);
            lbl_tingkat.Margin = new Padding(2, 0, 2, 0);
            lbl_tingkat.Name = "lbl_tingkat";
            lbl_tingkat.Size = new Size(120, 15);
            lbl_tingkat.TabIndex = 87;
            lbl_tingkat.Text = "Nama Penyelenggara";
            // 
            // txt_nama
            // 
            txt_nama.Location = new Point(308, 148);
            txt_nama.Margin = new Padding(2);
            txt_nama.Name = "txt_nama";
            txt_nama.Size = new Size(489, 23);
            txt_nama.TabIndex = 86;
            // 
            // lbl_ket
            // 
            lbl_ket.AutoSize = true;
            lbl_ket.BackColor = Color.Transparent;
            lbl_ket.Location = new Point(123, 262);
            lbl_ket.Margin = new Padding(2, 0, 2, 0);
            lbl_ket.Name = "lbl_ket";
            lbl_ket.Size = new Size(127, 15);
            lbl_ket.TabIndex = 85;
            lbl_ket.Text = "Tingkat Penyelenggara";
            // 
            // lbl_tgl
            // 
            lbl_tgl.AutoSize = true;
            lbl_tgl.BackColor = Color.Transparent;
            lbl_tgl.Location = new Point(123, 200);
            lbl_tgl.Margin = new Padding(2, 0, 2, 0);
            lbl_tgl.Name = "lbl_tgl";
            lbl_tgl.Size = new Size(116, 15);
            lbl_tgl.TabIndex = 84;
            lbl_tgl.Text = "Tanggal Pelaksanaan";
            // 
            // lbl_nama
            // 
            lbl_nama.AutoSize = true;
            lbl_nama.BackColor = Color.Transparent;
            lbl_nama.Location = new Point(123, 152);
            lbl_nama.Margin = new Padding(2, 0, 2, 0);
            lbl_nama.Name = "lbl_nama";
            lbl_nama.Size = new Size(92, 15);
            lbl_nama.TabIndex = 83;
            lbl_nama.Text = "Nama Sertifikasi";
            // 
            // lbl_judul
            // 
            lbl_judul.AutoSize = true;
            lbl_judul.BackColor = Color.Transparent;
            lbl_judul.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_judul.Location = new Point(308, 56);
            lbl_judul.Margin = new Padding(2, 0, 2, 0);
            lbl_judul.Name = "lbl_judul";
            lbl_judul.Size = new Size(319, 32);
            lbl_judul.TabIndex = 82;
            lbl_judul.Text = "Form Ubah Data Sertifikasi";
            // 
            // FormUbahDataSertifikasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FASILKOM_POINT__1_;
            ClientSize = new Size(921, 528);
            Controls.Add(btn_kembali);
            Controls.Add(btn_simpan);
            Controls.Add(cbButirSertifikasi);
            Controls.Add(check_hari);
            Controls.Add(dateTimePicker2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(txt_bukti);
            Controls.Add(txt_tingkat);
            Controls.Add(lbl_bukti);
            Controls.Add(lbl_tingkat);
            Controls.Add(txt_nama);
            Controls.Add(lbl_ket);
            Controls.Add(lbl_tgl);
            Controls.Add(lbl_nama);
            Controls.Add(lbl_judul);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormUbahDataSertifikasi";
            Text = "Form Ubah Data Sertifikasi";
            FormClosing += All_FormClosing;
            Load += FormUbahDataSertifikasi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_kembali;
        private Button btn_simpan;
        private ComboBox cbButirSertifikasi;
        private CheckBox check_hari;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private TextBox txt_bukti;
        private TextBox txt_tingkat;
        private Label lbl_bukti;
        private Label lbl_tingkat;
        private TextBox txt_nama;
        private Label lbl_ket;
        private Label lbl_tgl;
        private Label lbl_nama;
        private Label lbl_judul;
    }
}