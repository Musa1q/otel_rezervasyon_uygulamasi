using otel_rezervasyon_uygulaması.Forms;
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




            Random random = new Random();
            verificationCode = random.Next(100000, 999999);
            aliciMail = "hoteloctivia@yandex.com";
            DogrulamaMailGonder(aliciMail, verificationCode);
            this.Hide();
            CiftFaktorDogrulamaForm form = new CiftFaktorDogrulamaForm();
            form.verificationCode = this.verificationCode;
            form.aliciMail = this.aliciMail;
            form.ShowDialog();
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
    }
}
