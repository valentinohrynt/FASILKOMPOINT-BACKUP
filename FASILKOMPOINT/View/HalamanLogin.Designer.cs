using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FASILKOMPOINT.View
{
    partial class Halaman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Halaman));
            usernametb = new TextBox();
            passwordtb = new TextBox();
            Username = new Label();
            Password = new Label();
            loginbutton = new Button();
            SuspendLayout();
            // 
            // usernametb
            // 
            usernametb.Location = new Point(591, 260);
            usernametb.Name = "usernametb";
            usernametb.Size = new Size(255, 23);
            usernametb.TabIndex = 0;
            usernametb.TextChanged += textBox1_TextChanged;
            // 
            // passwordtb
            // 
            passwordtb.Location = new Point(591, 327);
            passwordtb.Name = "passwordtb";
            passwordtb.Size = new Size(255, 23);
            passwordtb.TabIndex = 1;
            passwordtb.TextChanged += textBox2_TextChanged;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.BackColor = Color.Transparent;
            Username.FlatStyle = FlatStyle.Popup;
            Username.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Username.ForeColor = Color.White;
            Username.Location = new Point(587, 238);
            Username.Name = "Username";
            Username.Size = new Size(83, 20);
            Username.TabIndex = 2;
            Username.Text = "Username";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.BackColor = Color.Transparent;
            Password.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Password.ForeColor = Color.White;
            Password.Location = new Point(591, 306);
            Password.Name = "Password";
            Password.Size = new Size(78, 20);
            Password.TabIndex = 3;
            Password.Text = "Password";
            Password.Click += Password_Click;
            // 
            // loginbutton
            // 
            loginbutton.BackColor = SystemColors.Highlight;
            loginbutton.FlatAppearance.BorderSize = 0;
            loginbutton.FlatStyle = FlatStyle.Flat;
            loginbutton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginbutton.ForeColor = SystemColors.ControlLightLight;
            loginbutton.Location = new Point(591, 380);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(255, 29);
            loginbutton.TabIndex = 4;
            loginbutton.Text = "Log In";
            loginbutton.UseVisualStyleBackColor = false;
            loginbutton.Click += loginbutton_Click;
            // 
            // Halaman
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(921, 528);
            Controls.Add(loginbutton);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(passwordtb);
            Controls.Add(usernametb);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Halaman";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += All_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernametb;
        private TextBox passwordtb;
        private Label Username;
        private Label Password;
        private Button loginbutton;
    }
}