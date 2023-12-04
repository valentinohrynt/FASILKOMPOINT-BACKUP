using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FASILKOMPOINT.View.TU
{
    partial class BerandaTU
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BerandaTU));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            btn_cari = new Button();
            logoutbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 128);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 5;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(896, 387);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Candara", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(351, 39);
            label1.Name = "label1";
            label1.Size = new Size(221, 33);
            label1.TabIndex = 6;
            label1.Text = "Daftar Mahasiswa";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(546, 97);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 23);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // btn_cari
            // 
            btn_cari.BackColor = Color.LightSkyBlue;
            btn_cari.Location = new Point(820, 97);
            btn_cari.Margin = new Padding(3, 2, 3, 2);
            btn_cari.Name = "btn_cari";
            btn_cari.Size = new Size(88, 26);
            btn_cari.TabIndex = 9;
            btn_cari.Text = "Cari";
            btn_cari.UseVisualStyleBackColor = false;
            btn_cari.Click += btn_cari_Click;
            // 
            // logoutbutton
            // 
            logoutbutton.BackColor = Color.OrangeRed;
            logoutbutton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            logoutbutton.ForeColor = Color.Transparent;
            logoutbutton.Location = new Point(809, 22);
            logoutbutton.Margin = new Padding(3, 2, 3, 2);
            logoutbutton.Name = "logoutbutton";
            logoutbutton.Size = new Size(82, 26);
            logoutbutton.TabIndex = 10;
            logoutbutton.Text = "Logout";
            logoutbutton.UseVisualStyleBackColor = false;
            logoutbutton.Click += logoutbutton_Click;
            // 
            // BerandaTU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(921, 528);
            Controls.Add(logoutbutton);
            Controls.Add(btn_cari);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "BerandaTU";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Beranda TU";
            FormClosing += All_FormClosing;
            Load += BerandaTU_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private Button btn_cari;
        private Button logoutbutton;
    }
}