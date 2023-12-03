using System.ComponentModel;

namespace FASILKOMPOINT.View.Mahasiswa
{
    partial class EntryDataSertifikasi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(EntryDataSertifikasi));
            dataGridView = new DataGridView();
            btn_prestasi = new Button();
            btn_kegiatan = new Button();
            btn_sertifikasi = new Button();
            btn_tambah = new Button();
            panel1 = new Panel();
            btn_kembali = new Button();
            label1 = new Label();
            ((ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(119, 83);
            dataGridView.Margin = new Padding(2);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 62;
            dataGridView.RowTemplate.Height = 33;
            dataGridView.Size = new Size(794, 434);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // btn_prestasi
            // 
            btn_prestasi.BackColor = Color.Transparent;
            btn_prestasi.Location = new Point(11, 43);
            btn_prestasi.Margin = new Padding(2);
            btn_prestasi.Name = "btn_prestasi";
            btn_prestasi.Size = new Size(86, 23);
            btn_prestasi.TabIndex = 1;
            btn_prestasi.Text = "Prestasi";
            btn_prestasi.UseVisualStyleBackColor = false;
            btn_prestasi.Click += btn_prestasi_Click;
            // 
            // btn_kegiatan
            // 
            btn_kegiatan.BackColor = Color.Transparent;
            btn_kegiatan.Location = new Point(11, 69);
            btn_kegiatan.Margin = new Padding(2);
            btn_kegiatan.Name = "btn_kegiatan";
            btn_kegiatan.Size = new Size(86, 23);
            btn_kegiatan.TabIndex = 2;
            btn_kegiatan.Text = "Kegiatan";
            btn_kegiatan.UseVisualStyleBackColor = false;
            btn_kegiatan.Click += btn_kegiatan_Click;
            // 
            // btn_sertifikasi
            // 
            btn_sertifikasi.BackColor = SystemColors.GradientActiveCaption;
            btn_sertifikasi.Location = new Point(11, 95);
            btn_sertifikasi.Margin = new Padding(2);
            btn_sertifikasi.Name = "btn_sertifikasi";
            btn_sertifikasi.Size = new Size(86, 23);
            btn_sertifikasi.TabIndex = 3;
            btn_sertifikasi.Text = "Sertifikasi";
            btn_sertifikasi.UseVisualStyleBackColor = false;
            btn_sertifikasi.Click += btn_sertifikasi_Click;
            // 
            // btn_tambah
            // 
            btn_tambah.BackColor = Color.Lime;
            btn_tambah.ForeColor = SystemColors.ActiveCaptionText;
            btn_tambah.Location = new Point(813, 56);
            btn_tambah.Margin = new Padding(2);
            btn_tambah.Name = "btn_tambah";
            btn_tambah.Size = new Size(86, 23);
            btn_tambah.TabIndex = 4;
            btn_tambah.Text = "Tambah";
            btn_tambah.UseVisualStyleBackColor = false;
            btn_tambah.Click += btn_tambah_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btn_kembali);
            panel1.Controls.Add(btn_prestasi);
            panel1.Controls.Add(btn_sertifikasi);
            panel1.Controls.Add(btn_kegiatan);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(111, 528);
            panel1.TabIndex = 5;
            // 
            // btn_kembali
            // 
            btn_kembali.Location = new Point(11, 483);
            btn_kembali.Margin = new Padding(3, 2, 3, 2);
            btn_kembali.Name = "btn_kembali";
            btn_kembali.Size = new Size(86, 22);
            btn_kembali.TabIndex = 4;
            btn_kembali.Text = "Kembali";
            btn_kembali.UseVisualStyleBackColor = true;
            btn_kembali.Click += btn_kembali_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Candara", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(398, 36);
            label1.Name = "label1";
            label1.Size = new Size(230, 29);
            label1.TabIndex = 6;
            label1.Text = "Entry Data Sertifikasi";
            // 
            // EntryDataSertifikasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(921, 528);
            Controls.Add(label1);
            Controls.Add(btn_tambah);
            Controls.Add(dataGridView);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "EntryDataSertifikasi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entry Data SKPI";
            Load += EntryDataSertifikasi_Load;
            ((ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Button btn_prestasi;
        private Button btn_kegiatan;
        private Button btn_sertifikasi;
        private Button btnTambah_Click;
        private Panel panel1;
        private Button button1;
        private Label label1;
        private Button btn_tambah;
        private Button btn_kembali;
    }
}