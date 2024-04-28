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

namespace otel_rezervasyon_uygulaması.Forms
{
    public partial class KayitOl : Form
    {
        private readonly string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=OtelContext;Integrated Security=True";

        public KayitOl()
        {
            InitializeComponent();
        }

        private void KayitOl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            string cinsiyet = comboBox1.Text;
            string email = textBox4.Text;
            string telefon = textBox5.Text;
            string sifre = textBox7.Text;
            string sifreTekrar = textBox8.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Bağlantıyı aç

                connection.Open();

                // Giriş doğrulaması
                if (string.IsNullOrWhiteSpace(ad) ||
                    string.IsNullOrWhiteSpace(soyad) ||
                    string.IsNullOrWhiteSpace(cinsiyet) ||
                    string.IsNullOrWhiteSpace(email) ||
                    string.IsNullOrWhiteSpace(telefon) ||
                    string.IsNullOrWhiteSpace(sifre) ||
                    string.IsNullOrWhiteSpace(sifreTekrar))
                {
                    MessageBox.Show("Tüm alanların doldurulması gerekmektedir.");
                    return;  // İşlemi durdurun
                }

                // E-posta formatını kontrol edin
                try
                {
                    var emailAddr = new System.Net.Mail.MailAddress(email);
                    if (emailAddr.Address != email)
                    {
                        MessageBox.Show("Geçersiz e-posta formatı.");
                        return;  // İşlemi durdurun
                    }
                }
                catch
                {
                    MessageBox.Show("Geçersiz e-posta formatı.");
                    return;  // İşlemi durdurun
                }

                // Telefon numarasının geçerliliğini kontrol edin
                if (!IsPhoneNumberValid(telefon))
                {
                    MessageBox.Show("Geçersiz telefon numarası.");
                    return;  // İşlemi durdurun
                }
                if(sifre != sifreTekrar)
                {
                    MessageBox.Show("Şifreler uyuşmuyor lüfen alanları kontrol ediniz.");
                    return;
                }
                // Fonksiyon: Telefon numarasını doğrulamak için
                bool IsPhoneNumberValid(string phone)
                {
                    // Telefon numarasının geçerliliğini kontrol etmek için düzenli ifade (regex) kullanabilirsiniz
                    // Örnek bir basit regex ifadesi:
                    return System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d{10}$");
                }


                string checkQuery = "SELECT COUNT(*) FROM Kullanicilar WHERE email = @Email OR telefon = @Telefon";

                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@Email", email);
                    checkCommand.Parameters.AddWithValue("@Telefon", telefon);

                    // Mevcut kullanıcı sayısını alın
                    int existingUserCount = (int)checkCommand.ExecuteScalar();

                    if (existingUserCount > 0)
                    {
                        // Kullanıcı zaten mevcut
                        MessageBox.Show("Bu e-posta veya kullanıcı adı zaten kayıtlı. Lütfen başka bir e-posta veya kullanıcı adı girin.");
                        return;  // İşlemi durdurun, kullanıcı zaten mevcut
                    }
                }


                // INSERT INTO sorgusunu hazırla
                string query = "INSERT INTO Kullanicilar (ad, soyad, cinsiyet, email, telefon,sifre) " +
                               "VALUES (@Ad, @Soyad, @Cinsiyet, @Email, @Telefon, @Sifre)";

                // Komutu oluştur ve parametreleri ekle
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@Ad", ad);
                    command.Parameters.AddWithValue("@Soyad", soyad);
                    command.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Telefon", telefon);
                    command.Parameters.AddWithValue("@Sifre", sifre);
                    // Komutu çalıştır

                    int rowsAffected = command.ExecuteNonQuery();

                    // Ekleme işleminin sonucunu kontrol et
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Kullanıcı başarıyla eklendi!");
                        this.Hide();
                        KarsilamaEkrani karsilamaEkrani = new KarsilamaEkrani();
                        karsilamaEkrani.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı eklenirken bir hata meydana geldi.");
                    }

                }

                // Bağlantıyı kapat
                connection.Close();

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            /*
            KarsilamaEkrani karsilamaEkrani = new KarsilamaEkrani();
            karsilamaEkrani.ShowDialog();
            this.Hide();
            */

        }

        private void button3_Click(object sender, EventArgs e)
        {   
            this.Hide();
            KarsilamaEkrani karsilamaEkrani = new KarsilamaEkrani();
            karsilamaEkrani.ShowDialog();
            
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}