namespace KutuphaneYonetimSistemi
{
    partial class FormGiris
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
            panel1 = new Panel();
            textBoxSifre = new TextBox();
            textBoxKullanici = new TextBox();
            buttonGiris = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Snow;
            panel1.Controls.Add(textBoxSifre);
            panel1.Controls.Add(textBoxKullanici);
            panel1.Controls.Add(buttonGiris);
            panel1.Location = new Point(173, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(356, 200);
            panel1.TabIndex = 0;
            // 
            // textBoxSifre
            // 
            textBoxSifre.ForeColor = SystemColors.ActiveBorder;
            textBoxSifre.Location = new Point(77, 85);
            textBoxSifre.Multiline = true;
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(198, 32);
            textBoxSifre.TabIndex = 2;
            textBoxSifre.Text = "Şifre";
            textBoxSifre.TextAlign = HorizontalAlignment.Center;
            textBoxSifre.Click += textBoxSifre_Click;
            // 
            // textBoxKullanici
            // 
            textBoxKullanici.Cursor = Cursors.IBeam;
            textBoxKullanici.ForeColor = SystemColors.ActiveBorder;
            textBoxKullanici.Location = new Point(77, 37);
            textBoxKullanici.Multiline = true;
            textBoxKullanici.Name = "textBoxKullanici";
            textBoxKullanici.Size = new Size(198, 32);
            textBoxKullanici.TabIndex = 1;
            textBoxKullanici.Text = "Kullanıcı Adı";
            textBoxKullanici.TextAlign = HorizontalAlignment.Center;
            textBoxKullanici.Click += textBoxKullanici_Click;
            // 
            // buttonGiris
            // 
            buttonGiris.BackColor = Color.SteelBlue;
            buttonGiris.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGiris.ForeColor = SystemColors.ControlLight;
            buttonGiris.Location = new Point(96, 136);
            buttonGiris.Name = "buttonGiris";
            buttonGiris.Size = new Size(153, 31);
            buttonGiris.TabIndex = 0;
            buttonGiris.Text = "Giriş Yap";
            buttonGiris.UseVisualStyleBackColor = false;
            buttonGiris.Click += buttonGiris_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(183, 78);
            label1.Name = "label1";
            label1.Size = new Size(346, 31);
            label1.TabIndex = 1;
            label1.Text = "Kütüphane Yönetim Sistemi Giriş";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.png_transparent_book_computer_icons_book_angle_furniture_rectangle_thumbnail1;
            pictureBox1.Location = new Point(641, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(173, 371);
            label2.Name = "label2";
            label2.Size = new Size(0, 23);
            label2.TabIndex = 3;
            // 
            // FormGiris
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(730, 443);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FormGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Yönetim Sistemi";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button buttonGiris;
        private TextBox textBoxKullanici;
        private TextBox textBoxSifre;
        private PictureBox pictureBox1;
        private Label label2;
    }
}