namespace KutuphaneYonetimSistemi
{
    partial class FormKitaplar
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
            groupBoxEkle = new GroupBox();
            buttonSil = new Button();
            buttonTumu = new Button();
            buttonSorgu = new Button();
            buttonTemizle = new Button();
            textBoxTur = new TextBox();
            buttonKitapEkle = new Button();
            buttonBilgi = new Button();
            textBoxIsbn = new TextBox();
            textBoxYSoyad = new TextBox();
            textBoxYazarAd = new TextBox();
            textBoxid = new TextBox();
            textBoxKitapAd = new TextBox();
            label9 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            groupBoxOdunc = new GroupBox();
            buttonOdunc = new Button();
            dateTime1 = new DateTimePicker();
            textBoxOdunc = new TextBox();
            groupBoxIade = new GroupBox();
            panel1 = new Panel();
            label11 = new Label();
            labelGecikme = new Label();
            buttonIade = new Button();
            buttonHesapla = new Button();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBoxEkle.SuspendLayout();
            groupBoxOdunc.SuspendLayout();
            groupBoxIade.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxEkle
            // 
            groupBoxEkle.Controls.Add(buttonSil);
            groupBoxEkle.Controls.Add(buttonTumu);
            groupBoxEkle.Controls.Add(buttonSorgu);
            groupBoxEkle.Controls.Add(buttonTemizle);
            groupBoxEkle.Controls.Add(textBoxTur);
            groupBoxEkle.Controls.Add(buttonKitapEkle);
            groupBoxEkle.Controls.Add(buttonBilgi);
            groupBoxEkle.Controls.Add(textBoxIsbn);
            groupBoxEkle.Controls.Add(textBoxYSoyad);
            groupBoxEkle.Controls.Add(textBoxYazarAd);
            groupBoxEkle.Controls.Add(textBoxid);
            groupBoxEkle.Controls.Add(textBoxKitapAd);
            groupBoxEkle.Controls.Add(label9);
            groupBoxEkle.Controls.Add(label5);
            groupBoxEkle.Controls.Add(label4);
            groupBoxEkle.Controls.Add(label3);
            groupBoxEkle.Controls.Add(label2);
            groupBoxEkle.Controls.Add(label1);
            groupBoxEkle.Location = new Point(15, 6);
            groupBoxEkle.Name = "groupBoxEkle";
            groupBoxEkle.Size = new Size(427, 345);
            groupBoxEkle.TabIndex = 0;
            groupBoxEkle.TabStop = false;
            groupBoxEkle.Text = "Kitap Ekle";
            // 
            // buttonSil
            // 
            buttonSil.BackColor = Color.SteelBlue;
            buttonSil.BackgroundImageLayout = ImageLayout.None;
            buttonSil.FlatStyle = FlatStyle.Popup;
            buttonSil.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonSil.ForeColor = Color.AliceBlue;
            buttonSil.Location = new Point(288, 215);
            buttonSil.Name = "buttonSil";
            buttonSil.Size = new Size(107, 51);
            buttonSil.TabIndex = 23;
            buttonSil.Text = "Seçili Kitabı Sil";
            buttonSil.UseVisualStyleBackColor = false;
            buttonSil.Click += buttonSil_Click;
            // 
            // buttonTumu
            // 
            buttonTumu.BackColor = Color.SteelBlue;
            buttonTumu.BackgroundImageLayout = ImageLayout.None;
            buttonTumu.FlatStyle = FlatStyle.Popup;
            buttonTumu.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonTumu.ForeColor = Color.AliceBlue;
            buttonTumu.Location = new Point(288, 280);
            buttonTumu.Name = "buttonTumu";
            buttonTumu.Size = new Size(107, 51);
            buttonTumu.TabIndex = 22;
            buttonTumu.Text = "Tüm Kitapları Göster";
            buttonTumu.UseVisualStyleBackColor = false;
            buttonTumu.Click += buttonTumu_Click;
            // 
            // buttonSorgu
            // 
            buttonSorgu.BackColor = Color.SteelBlue;
            buttonSorgu.BackgroundImageLayout = ImageLayout.None;
            buttonSorgu.FlatStyle = FlatStyle.Popup;
            buttonSorgu.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonSorgu.ForeColor = Color.AliceBlue;
            buttonSorgu.Location = new Point(156, 280);
            buttonSorgu.Name = "buttonSorgu";
            buttonSorgu.Size = new Size(107, 51);
            buttonSorgu.TabIndex = 21;
            buttonSorgu.Text = "Sorgula";
            buttonSorgu.UseVisualStyleBackColor = false;
            buttonSorgu.Click += buttonSorgu_Click;
            // 
            // buttonTemizle
            // 
            buttonTemizle.BackColor = Color.SteelBlue;
            buttonTemizle.BackgroundImageLayout = ImageLayout.None;
            buttonTemizle.FlatStyle = FlatStyle.Popup;
            buttonTemizle.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonTemizle.ForeColor = Color.AliceBlue;
            buttonTemizle.Location = new Point(23, 280);
            buttonTemizle.Name = "buttonTemizle";
            buttonTemizle.Size = new Size(107, 51);
            buttonTemizle.TabIndex = 20;
            buttonTemizle.Text = "Alanları Temizle";
            buttonTemizle.UseVisualStyleBackColor = false;
            buttonTemizle.Click += buttonTemizle_Click;
            // 
            // textBoxTur
            // 
            textBoxTur.BackColor = Color.MintCream;
            textBoxTur.BorderStyle = BorderStyle.None;
            textBoxTur.Location = new Point(156, 171);
            textBoxTur.Multiline = true;
            textBoxTur.Name = "textBoxTur";
            textBoxTur.Size = new Size(204, 20);
            textBoxTur.TabIndex = 14;
            // 
            // buttonKitapEkle
            // 
            buttonKitapEkle.BackColor = Color.SteelBlue;
            buttonKitapEkle.BackgroundImageLayout = ImageLayout.None;
            buttonKitapEkle.FlatStyle = FlatStyle.Popup;
            buttonKitapEkle.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonKitapEkle.ForeColor = Color.AliceBlue;
            buttonKitapEkle.Location = new Point(156, 215);
            buttonKitapEkle.Name = "buttonKitapEkle";
            buttonKitapEkle.Size = new Size(107, 51);
            buttonKitapEkle.TabIndex = 19;
            buttonKitapEkle.Text = "   Yeni Kitap     Ekle";
            buttonKitapEkle.UseVisualStyleBackColor = false;
            buttonKitapEkle.Click += buttonKitapEkle_Click;
            // 
            // buttonBilgi
            // 
            buttonBilgi.BackColor = Color.SteelBlue;
            buttonBilgi.BackgroundImageLayout = ImageLayout.None;
            buttonBilgi.FlatStyle = FlatStyle.Popup;
            buttonBilgi.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonBilgi.ForeColor = Color.AliceBlue;
            buttonBilgi.Location = new Point(23, 215);
            buttonBilgi.Name = "buttonBilgi";
            buttonBilgi.Size = new Size(107, 51);
            buttonBilgi.TabIndex = 18;
            buttonBilgi.Text = "Kitap Bilgisi Güncelle";
            buttonBilgi.UseVisualStyleBackColor = false;
            buttonBilgi.Click += buttonBilgi_Click;
            // 
            // textBoxIsbn
            // 
            textBoxIsbn.BackColor = Color.MintCream;
            textBoxIsbn.BorderStyle = BorderStyle.None;
            textBoxIsbn.Location = new Point(156, 145);
            textBoxIsbn.Multiline = true;
            textBoxIsbn.Name = "textBoxIsbn";
            textBoxIsbn.Size = new Size(204, 20);
            textBoxIsbn.TabIndex = 13;
            // 
            // textBoxYSoyad
            // 
            textBoxYSoyad.BackColor = Color.MintCream;
            textBoxYSoyad.BorderStyle = BorderStyle.None;
            textBoxYSoyad.Location = new Point(156, 119);
            textBoxYSoyad.Multiline = true;
            textBoxYSoyad.Name = "textBoxYSoyad";
            textBoxYSoyad.Size = new Size(204, 20);
            textBoxYSoyad.TabIndex = 12;
            // 
            // textBoxYazarAd
            // 
            textBoxYazarAd.BackColor = Color.MintCream;
            textBoxYazarAd.BorderStyle = BorderStyle.None;
            textBoxYazarAd.Location = new Point(156, 93);
            textBoxYazarAd.Multiline = true;
            textBoxYazarAd.Name = "textBoxYazarAd";
            textBoxYazarAd.Size = new Size(204, 20);
            textBoxYazarAd.TabIndex = 11;
            // 
            // textBoxid
            // 
            textBoxid.BackColor = Color.MintCream;
            textBoxid.BorderStyle = BorderStyle.None;
            textBoxid.Enabled = false;
            textBoxid.Location = new Point(156, 41);
            textBoxid.Multiline = true;
            textBoxid.Name = "textBoxid";
            textBoxid.Size = new Size(204, 20);
            textBoxid.TabIndex = 10;
            // 
            // textBoxKitapAd
            // 
            textBoxKitapAd.BackColor = Color.MintCream;
            textBoxKitapAd.BorderStyle = BorderStyle.None;
            textBoxKitapAd.Location = new Point(156, 67);
            textBoxKitapAd.Multiline = true;
            textBoxKitapAd.Name = "textBoxKitapAd";
            textBoxKitapAd.Size = new Size(204, 20);
            textBoxKitapAd.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(61, 171);
            label9.Name = "label9";
            label9.Size = new Size(78, 20);
            label9.TabIndex = 8;
            label9.Text = "Tür Kodu : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(88, 145);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 4;
            label5.Text = "ISBN : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(41, 119);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 3;
            label4.Text = "Yazar Soyad : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(60, 93);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 2;
            label3.Text = "Yazar Adı : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(60, 65);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Kitap Adı : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(104, 41);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "ID : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(46, 79);
            label8.Name = "label8";
            label8.Size = new Size(95, 20);
            label8.TabIndex = 7;
            label8.Text = "Alma Tarihi : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(46, 48);
            label7.Name = "label7";
            label7.Size = new Size(95, 20);
            label7.TabIndex = 6;
            label7.Text = "Ödünç Alan : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(14, 9);
            label6.Name = "label6";
            label6.Size = new Size(117, 20);
            label6.TabIndex = 5;
            label6.Text = "Gecikme Ücreti : ";
            // 
            // groupBoxOdunc
            // 
            groupBoxOdunc.Controls.Add(buttonOdunc);
            groupBoxOdunc.Controls.Add(dateTime1);
            groupBoxOdunc.Controls.Add(label7);
            groupBoxOdunc.Controls.Add(textBoxOdunc);
            groupBoxOdunc.Controls.Add(label8);
            groupBoxOdunc.Location = new Point(474, 12);
            groupBoxOdunc.Name = "groupBoxOdunc";
            groupBoxOdunc.Size = new Size(396, 165);
            groupBoxOdunc.TabIndex = 1;
            groupBoxOdunc.TabStop = false;
            groupBoxOdunc.Text = "Kitap Ödünç Alma";
            // 
            // buttonOdunc
            // 
            buttonOdunc.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonOdunc.BackColor = Color.SteelBlue;
            buttonOdunc.BackgroundImageLayout = ImageLayout.None;
            buttonOdunc.FlatStyle = FlatStyle.Popup;
            buttonOdunc.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonOdunc.ForeColor = Color.AliceBlue;
            buttonOdunc.Location = new Point(128, 119);
            buttonOdunc.Name = "buttonOdunc";
            buttonOdunc.Size = new Size(185, 36);
            buttonOdunc.TabIndex = 20;
            buttonOdunc.Text = "Kitabı Ödünç Ver";
            buttonOdunc.UseVisualStyleBackColor = false;
            buttonOdunc.Click += buttonOdunc_Click;
            // 
            // dateTime1
            // 
            dateTime1.Location = new Point(147, 79);
            dateTime1.Name = "dateTime1";
            dateTime1.Size = new Size(144, 27);
            dateTime1.TabIndex = 16;
            // 
            // textBoxOdunc
            // 
            textBoxOdunc.BackColor = Color.MintCream;
            textBoxOdunc.BorderStyle = BorderStyle.None;
            textBoxOdunc.Location = new Point(147, 45);
            textBoxOdunc.Multiline = true;
            textBoxOdunc.Name = "textBoxOdunc";
            textBoxOdunc.Size = new Size(144, 23);
            textBoxOdunc.TabIndex = 15;
            // 
            // groupBoxIade
            // 
            groupBoxIade.Controls.Add(panel1);
            groupBoxIade.Controls.Add(buttonIade);
            groupBoxIade.Controls.Add(buttonHesapla);
            groupBoxIade.Location = new Point(474, 186);
            groupBoxIade.Name = "groupBoxIade";
            groupBoxIade.Size = new Size(396, 165);
            groupBoxIade.TabIndex = 2;
            groupBoxIade.TabStop = false;
            groupBoxIade.Text = "Kitap İadesi";
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(labelGecikme);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(97, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 36);
            panel1.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(219, 9);
            label11.Name = "label11";
            label11.Size = new Size(28, 20);
            label11.TabIndex = 21;
            label11.Text = "TL ";
            // 
            // labelGecikme
            // 
            labelGecikme.AutoSize = true;
            labelGecikme.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            labelGecikme.Location = new Point(137, 9);
            labelGecikme.Name = "labelGecikme";
            labelGecikme.Size = new Size(21, 20);
            labelGecikme.TabIndex = 20;
            labelGecikme.Text = "0 ";
            // 
            // buttonIade
            // 
            buttonIade.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonIade.BackColor = Color.SteelBlue;
            buttonIade.BackgroundImageLayout = ImageLayout.None;
            buttonIade.FlatStyle = FlatStyle.Popup;
            buttonIade.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonIade.ForeColor = Color.AliceBlue;
            buttonIade.Location = new Point(133, 124);
            buttonIade.Name = "buttonIade";
            buttonIade.Size = new Size(185, 36);
            buttonIade.TabIndex = 22;
            buttonIade.Text = "Kitabı İade Et";
            buttonIade.UseVisualStyleBackColor = false;
            buttonIade.Click += buttonIade_Click;
            // 
            // buttonHesapla
            // 
            buttonHesapla.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonHesapla.BackColor = Color.SteelBlue;
            buttonHesapla.BackgroundImageLayout = ImageLayout.None;
            buttonHesapla.FlatStyle = FlatStyle.Popup;
            buttonHesapla.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            buttonHesapla.ForeColor = Color.AliceBlue;
            buttonHesapla.Location = new Point(133, 26);
            buttonHesapla.Name = "buttonHesapla";
            buttonHesapla.Size = new Size(185, 36);
            buttonHesapla.TabIndex = 19;
            buttonHesapla.Text = "Gecikme Bedeli Hesapla";
            buttonHesapla.UseVisualStyleBackColor = false;
            buttonHesapla.Click += buttonHesapla_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 357);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(861, 233);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kitap Listesi";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.SlateGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(855, 207);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // FormKitaplar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(885, 602);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxIade);
            Controls.Add(groupBoxOdunc);
            Controls.Add(groupBoxEkle);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FormKitaplar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Yönetim Sistemi";
            FormClosed += FormKitaplar_FormClosed;
            Load += FormKitaplar_Load;
            groupBoxEkle.ResumeLayout(false);
            groupBoxEkle.PerformLayout();
            groupBoxOdunc.ResumeLayout(false);
            groupBoxOdunc.PerformLayout();
            groupBoxIade.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxEkle;
        private GroupBox groupBoxOdunc;
        private GroupBox groupBoxIade;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label9;
        private TextBox textBoxid;
        private TextBox textBoxKitapAd;
        private TextBox textBoxOdunc;
        private TextBox textBoxTur;
        private TextBox textBoxIsbn;
        private TextBox textBoxYSoyad;
        private TextBox textBoxYazarAd;
        private Button buttonBilgi;
        private Button buttonKitapEkle;
        private DateTimePicker dateTime1;
        private Button buttonHesapla;
        private Button buttonOdunc;
        private Button buttonIade;
        private Label label11;
        private Label labelGecikme;
        private GroupBox groupBox1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Button buttonSorgu;
        private Button buttonTemizle;
        private Button buttonTumu;
        private Button buttonSil;
    }
}