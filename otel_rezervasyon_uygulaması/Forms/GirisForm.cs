using otel_rezervasyon_uygulaması.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace otel_rezervasyon_uygulaması
{
    public partial class GirisForm : Form
    {
        private int verificationCode { get; set; }
        private string aliciMail { get; set; }

        public GirisForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Mail ve şifreyi alıp veritabanında kontrol ettirip var ise iki aşamalı doğrulama sayfasına göndereceğim
            string userEmail = textBox1.Text;
            string userPassword = textBox2.Text;

            // Veritabanı bağlantısı

            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OtelContext;Integrated Security=True  
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=OtelContext;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Kullanicilar WHERE email = @Email AND sifre = @Password";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Email", userEmail);
                    cmd.Parameters.AddWithValue("@Password", userPassword);

                    int count = (int)cmd.ExecuteScalar();

                    if (count == 1)
                    {
                        // Başarılı giriş
                        MessageBox.Show("Giriş başarılı!");

                        Random random = new Random();
                        verificationCode = random.Next(100000, 999999);
                        aliciMail = userEmail;
                        DogrulamaMailGonder(aliciMail, verificationCode);
                        this.Hide();
                        CiftFaktorDogrulamaForm form = new CiftFaktorDogrulamaForm();
                        form.verificationCode = this.verificationCode;
                        form.aliciMail = this.aliciMail;
                        form.ShowDialog();



                    }
                    else
                    {
                        // Hatalı giriş
                        MessageBox.Show("E-posta veya şifre hatalı!");
                    }
                }
            }




        }
        public void DogrulamaMailGonder(string aliciMail, int verificationCode)
        {

            // HTML içeriğini oluştur
            string htmlContent = $@"
            <!DOCTYPE html>
            <html>
            <head>
                <title>Doğrulama Kodu</title>
            </head>
            <body>
                <p>Doğrulama kodunuz: <strong>{verificationCode}</strong></p>
                <p>Eğer bilginiz dışında bir giriş ise <a href=""mailto:hoteloctivia@yandex.com"">hoteloctivia@yandex.com</a> ile iletişime geçin.</p>
                <footer>
                    <p>Hotel Octovia</p>
                </footer>
            </body>
            </html>
        ";
            SmtpClient client = new SmtpClient
            {
                Port = 587,
                Host = "smtp.yandex.com.tr",
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("hoteloctivia@yandex.com", "dcilnbaluxzieaeg")
            };

            MailMessage mm = new MailMessage("hoteloctivia@yandex.com", aliciMail, "Giriş Doğrulama Kodu", htmlContent)
            {
                IsBodyHtml = true,
                BodyEncoding = Encoding.UTF8,
                DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
            };

            // E-posta gönder
            client.Send(mm);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AnasayfaForm anasayfaForm = new AnasayfaForm();
            anasayfaForm.ShowDialog();

        }
    }
}
