namespace FASILKOMPOINT.View.SKPI
{
    partial class ValidasiSKPIMahasiswa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValidasiSKPIMahasiswa));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.icons8_back_64;
            pictureBox1.Location = new Point(12, 10);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Candara", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(277, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(354, 33);
            label1.TabIndex = 4;
            label1.Text = "Validasi Data SKPI Mahasiswa";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 128);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(896, 387);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.Location = new Point(932, 178);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(88, 26);
            button2.TabIndex = 7;
            button2.Text = "Detail";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.ImeMode = ImeMode.NoControl;
            textBox1.Location = new Point(546, 97);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 23);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(820, 97);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(88, 26);
            button1.TabIndex = 10;
            button1.Text = "Cari";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ValidasiSKPIMahasiswa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FASILKOM_POINT__1_;
            ClientSize = new Size(921, 528);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "ValidasiSKPIMahasiswa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Validasi SKPI Mahasiswa";
            FormClosing += All_FormClosing;
            Load += ValidasiSKPIMahasiswa_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox textBox1;
        private Button button1;
    }
}