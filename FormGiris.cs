using System.Data.SqlClient;
using System.Runtime.ConstrainedExecution;

namespace KutuphaneYonetimSistemi
{
    public partial class FormGiris : Form
    {
        //Formlar için nesne tanýmladýk. 
        FormKitaplar formKitaplar;


        public FormGiris()
        {
            InitializeComponent();

        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=AYTEN\SQLEXPRESS;Initial Catalog=DbKutuphaneYS;Integrated Security=True");
        private void textBoxKullanici_Click(object sender, EventArgs e)
        {
            textBoxKullanici.Text = string.Empty;
        }
        private void textBoxSifre_Click(object sender, EventArgs e)
        {
            textBoxSifre.Text = string.Empty;
            textBoxSifre.PasswordChar = '*';

        }


        string sifre = " ";
        private void buttonGiris_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                //Sifre ve kullanýcý adýný veri tabanýndan çekmek için...
                SqlCommand cmd = new SqlCommand("SELECT Sifre FROM TableKHaneAdminleri WHERE KullaniciAdi=@p1", baglanti);
                cmd.Parameters.AddWithValue("@p1", textBoxKullanici.Text);

                //Verileri okutmak için...
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    sifre = reader[0].ToString();
                }

                //Þifrenin veri ile uyumunu kontrol edelim.
                if (sifre == textBoxSifre.Text)
                {
                    label2.Text = "Þifrenizi doðru girdiniz.";
                    //Ana forma geçiþ yap. 
                    formKitaplar = new FormKitaplar();
                    this.Hide();
                    formKitaplar.Show();

                }
                else
                {
                    MessageBox.Show("Kullanýcý adý ya da þifreniz hatalý. Lütfen yeniden deneyiniz.");
                    textBoxKullanici.Text = " ";
                    textBoxSifre.Text = " ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Baðlantý hatasý!!!" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}