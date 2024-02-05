using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KutuphaneYonetimSistemi
{
    public partial class FormKitaplar : Form
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=AYTEN\SQLEXPRESS;Initial Catalog=DbKutuphaneYS;Integrated Security=True");
        public FormKitaplar()
        {
            InitializeComponent();
        }
        //Kitap Ekleme...
        private void buttonKitapEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                SqlCommand sqlCommand = new SqlCommand("INSERT INTO TableBooks" +
                    "(KitapAdi,YazarAdi,YazarSoyadi,ISBN,Durum,KitapTurKodu) VALUES (@P1, @P2, @P3,@P4,@P5,@P6)", baglanti);
                sqlCommand.Parameters.AddWithValue("@P1", textBoxKitapAd.Text);
                sqlCommand.Parameters.AddWithValue("@P2", textBoxYazarAd.Text);
                sqlCommand.Parameters.AddWithValue("@P3", textBoxYSoyad.Text);
                sqlCommand.Parameters.AddWithValue("@P4", textBoxIsbn.Text);
                sqlCommand.Parameters.AddWithValue("@P5", "True");
                sqlCommand.Parameters.AddWithValue("@P6", textBoxTur.Text);

                sqlCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap eklenirken hata oluştu" + ex.Message);
            }
            finally { baglanti.Close(); }
            //Yeni eklenen kitabı görmek için... 
            verileriGoster();
        }
        public void verileriGoster()
        {
            //DataGripView içini veri tabanındaki bilgilerle doldurduk. 
            string query = "SELECT * FROM TableBooks";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, baglanti);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }
        private void FormKitaplar_Load(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Kitap bilgisi değiştirmek için değiştirlecek satırı seçtik.
            int secilenSatir = dataGridView1.SelectedCells[0].RowIndex;
            textBoxKitapAd.Text = dataGridView1.Rows[secilenSatir].Cells[1].Value.ToString();
            textBoxid.Text = dataGridView1.Rows[secilenSatir].Cells[0].Value.ToString();
            textBoxYazarAd.Text = dataGridView1.Rows[secilenSatir].Cells[2].Value.ToString();
            textBoxYSoyad.Text = dataGridView1.Rows[secilenSatir].Cells[3].Value.ToString();
            textBoxIsbn.Text = dataGridView1.Rows[secilenSatir].Cells[4].Value.ToString();
            textBoxTur.Text = dataGridView1.Rows[secilenSatir].Cells[8].Value.ToString();
            textBoxOdunc.Text = dataGridView1.Rows[secilenSatir].Cells[6].Value.ToString();
            //Tüm hücrelerdeki değerleri alıp stringe çevirdik ve date timeın değerini aldık.
            //Tarih NULL dönebilir o yüzden db value ile hata vermesini engelleyeceğiz.
            if (dataGridView1.Rows[secilenSatir].Cells[7].Value != DBNull.Value)
            { dateTime1.Value = (DateTime)dataGridView1.Rows[secilenSatir].Cells[7].Value; }
            //Farklı kitap seçildiğinde gecikme bedelini sıfırlamak için...
            labelGecikme.Text = "0";

        }
        // Kitap güncellemeleri...
        private void buttonBilgi_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE TableBooks SET KitapAdi = @P1, YazarAdi = @P2,YazarSoyadi = @P3 ,ISBN = @P4 ,KitapTurKodu = @P5 " +
                    "WHERE ID = @P6", baglanti);

                sqlCommand.Parameters.AddWithValue("@P1", textBoxKitapAd.Text);
                sqlCommand.Parameters.AddWithValue("@P2", textBoxYazarAd.Text);
                sqlCommand.Parameters.AddWithValue("@P3", textBoxYSoyad.Text);
                sqlCommand.Parameters.AddWithValue("@P4", textBoxIsbn.Text);
                sqlCommand.Parameters.AddWithValue("@P5", textBoxTur.Text);
                sqlCommand.Parameters.AddWithValue("@P6", textBoxid.Text);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap güncellenirken hata oluştu" + ex.Message);
            }
            finally { baglanti.Close(); }

            verileriGoster();

        }
        //Kitap ödünç verme ... 
        private void buttonOdunc_Click(object sender, EventArgs e)
        {
            if (textBoxKitapAd.Text.Length > 0)
            {
                try
                {
                    baglanti.Open();

                    SqlCommand sqlCommand = new("UPDATE TableBooks SET OduncAlan = @P1 , OduncAlmaTarihi = @P2, Durum =@P3 WHERE ID = @P4", baglanti);

                    sqlCommand.Parameters.AddWithValue("@P1", textBoxOdunc.Text);
                    sqlCommand.Parameters.Add("@P2", SqlDbType.Date).Value = dateTime1.Value.Date;
                    sqlCommand.Parameters.AddWithValue("P3", "False");
                    sqlCommand.Parameters.AddWithValue("@P4", textBoxid.Text);

                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap güncellenirken hata oluştu" + ex.Message);
                }
                finally { baglanti.Close(); }

                verileriGoster();

            }
            else
                MessageBox.Show("Devam etmek için lütfen bir kitap seçiniz.");
        }
        //10 günlük ödünç almsa süresinden sonra her gün 2 TL ceza yazack şekilde fonksiyonumuzu doldurduk.
        private void buttonHesapla_Click(object sender, EventArgs e)
        {
            if (textBoxKitapAd.Text.Length > 0)
            {
                DateTime bugunTarih = DateTime.Now;
                double gunSayısı = (bugunTarih - dateTime1.Value.Date).TotalDays;
                if (gunSayısı > 10)
                {
                    double gecikmeBedeli = (gunSayısı - 10) * 2;
                    labelGecikme.Text = gecikmeBedeli.ToString("F3");
                }
                else
                {
                    MessageBox.Show("Kitap 10 günden kısa sürede iade edilmistir. Gecikme ücreti bulunmamaktadır.");
                }


            }
            else
                MessageBox.Show("Lütfen ödünç alınmış kitabı seçin.");
        }

        private void buttonIade_Click(object sender, EventArgs e)
        {

            if (textBoxKitapAd.Text.Length > 0)
            {
                try
                {
                    baglanti.Open();

                    SqlCommand sqlCommand = new("UPDATE TableBooks SET OduncAlan = @P1 , OduncAlmaTarihi = @P2, Durum =@P3 WHERE ID = @P4", baglanti);

                    sqlCommand.Parameters.AddWithValue("@P1", "");
                    sqlCommand.Parameters.Add("@P2", SqlDbType.Date).Value = DateTime.Now;
                    sqlCommand.Parameters.AddWithValue("P3", "True");
                    sqlCommand.Parameters.AddWithValue("@P4", textBoxid.Text);
                    textBoxOdunc.Text = "";

                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap güncellenirken hata oluştu" + ex.Message);
                }
                finally { baglanti.Close(); }

                verileriGoster();
            }
            else
                MessageBox.Show("Lütfen iadesi yapılacak kitabı seçin");
        }
        //Hücreleri temizleyen fonksiyon
        public void herseyiTemizle()
        {
            textBoxid.Text = string.Empty;
            textBoxKitapAd.Text = string.Empty;
            textBoxYazarAd.Text = string.Empty;
            textBoxYSoyad.Text = string.Empty;
            textBoxIsbn.Text = string.Empty;
            textBoxTur.Text = string.Empty;
            textBoxOdunc.Text = string.Empty;
            labelGecikme.Text = string.Empty;
            dateTime1.Value = DateTime.Now;
        }
        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            herseyiTemizle();
        }

        private void buttonSorgu_Click(object sender, EventArgs e)
        {
            aramaSonucuGoster();
        }
        public void aramaSonucuGoster()
        {
            try
            {
                string query = "SELECT * FROM TableBooks WHERE KitapAdi LIKE '"
                    + textBoxKitapAd.Text + "%' AND YazarAdi LIKE'" + textBoxYazarAd.Text + "%' AND YazarSoyadi LIKE '"
                    + textBoxYSoyad.Text + "%' AND ISBN LIKE '" + textBoxIsbn.Text + "%' AND KitapTurKodu LIKE '"
                    + textBoxTur.Text + "%' AND OduncAlan LIKE '" + textBoxOdunc.Text + "%'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, baglanti);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex) { }
        }

        private void buttonTumu_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (textBoxid.Text.Length > 0)
            {

                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM TableBooks WHERE ID =@P1", baglanti);

                    sqlCommand.Parameters.AddWithValue("@P1", textBoxid.Text);

                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap silinirken hata oluştu" + ex.Message);
                }
                finally { baglanti.Close(); }

                verileriGoster();
                herseyiTemizle();

            }
        }

        private void FormKitaplar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
