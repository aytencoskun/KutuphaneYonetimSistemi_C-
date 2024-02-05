using System.Data.SqlClient;
using System.Runtime.ConstrainedExecution;

namespace KutuphaneYonetimSistemi
{
    public partial class FormGiris : Form
    {
        //Formlar i�in nesne tan�mlad�k. 
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
                //Sifre ve kullan�c� ad�n� veri taban�ndan �ekmek i�in...
                SqlCommand cmd = new SqlCommand("SELECT Sifre FROM TableKHaneAdminleri WHERE KullaniciAdi=@p1", baglanti);
                cmd.Parameters.AddWithValue("@p1", textBoxKullanici.Text);

                //Verileri okutmak i�in...
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    sifre = reader[0].ToString();
                }

                //�ifrenin veri ile uyumunu kontrol edelim.
                if (sifre == textBoxSifre.Text)
                {
                    label2.Text = "�ifrenizi do�ru girdiniz.";
                    //Ana forma ge�i� yap. 
                    formKitaplar = new FormKitaplar();
                    this.Hide();
                    formKitaplar.Show();

                }
                else
                {
                    MessageBox.Show("Kullan�c� ad� ya da �ifreniz hatal�. L�tfen yeniden deneyiniz.");
                    textBoxKullanici.Text = " ";
                    textBoxSifre.Text = " ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ba�lant� hatas�!!!" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}