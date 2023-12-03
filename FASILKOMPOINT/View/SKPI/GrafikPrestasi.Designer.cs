namespace FASILKOMPOINT.View.SKPI
{
    partial class Grafik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grafik));
            btn_kegiatan = new Button();
            btn_sertifikasi = new Button();
            btn_prestasi = new Button();
            btn_kembali = new Button();
            panel1 = new Panel();
            label1 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
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
            btn_sertifikasi.BackColor = Color.Transparent;
            btn_sertifikasi.Location = new Point(11, 95);
            btn_sertifikasi.Margin = new Padding(2);
            btn_sertifikasi.Name = "btn_sertifikasi";
            btn_sertifikasi.Size = new Size(86, 23);
            btn_sertifikasi.TabIndex = 3;
            btn_sertifikasi.Text = "Sertifikasi";
            btn_sertifikasi.UseVisualStyleBackColor = false;
            btn_sertifikasi.Click += btn_sertifikasi_Click;
            // 
            // btn_prestasi
            // 
            btn_prestasi.BackColor = SystemColors.GradientActiveCaption;
            btn_prestasi.Location = new Point(11, 43);
            btn_prestasi.Margin = new Padding(2);
            btn_prestasi.Name = "btn_prestasi";
            btn_prestasi.Size = new Size(86, 23);
            btn_prestasi.TabIndex = 1;
            btn_prestasi.Text = "Prestasi";
            btn_prestasi.UseVisualStyleBackColor = false;
            btn_prestasi.Click += btn_prestasi_Click;
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
            panel1.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Candara", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(409, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(182, 33);
            label1.TabIndex = 30;
            label1.Text = "Grafik Prestasi";
            // 
            // chart1
            // 
            chart1.BackColor = Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.Enabled = false;
            chart1.Location = new Point(178, 95);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(678, 396);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // Grafik
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackgroundImage = Properties.Resources.FASILKOM_POINT__2_;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(921, 528);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(chart1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Grafik";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grafik Prestasi";
            Load += Grafik_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_kegiatan;
        private Button btn_sertifikasi;
        private Button btn_prestasi;
        private Button btn_kembali;
        private Panel panel1;
        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}