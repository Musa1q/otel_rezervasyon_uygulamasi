using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otel_rezervasyon_uygulaması.Forms
{

    public partial class CiftFaktorDogrulamaForm : Form
    {
        private int countdownValue = 60;
        public int verificationCode { get; set; }
        public string aliciMail { get; set; }

        public CiftFaktorDogrulamaForm()
        {
            InitializeComponent();

        }

        private void CiftFaktorDogrulamaForm_Load(object sender, EventArgs e)
        {

            timerCountdown.Interval = 1000;
            timerCountdown.Tick += timerCountdown_Tick_1;

            labelCountdown.Text = countdownValue.ToString();
            StartCountdown();

        }
        private void StartCountdown()
        {

            timerCountdown.Start();
        }

        private void timerCountdown_Tick_1(object sender, EventArgs e)
        {
            countdownValue--;
            labelCountdown.Text = countdownValue.ToString();
            if (countdownValue == 0)
            {
                timerCountdown.Stop();
                button1.Enabled = false;
                sureDolduLabel.Visible = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            verificationCode = random.Next(100000, 999999);
            DogrulamaMailGonder(aliciMail, verificationCode);
            button1.Enabled = true;
            label4.Visible = false;
            sureDolduLabel.Visible = false;
            countdownValue = countdownValue + 90;
            StartCountdown();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (verificationCode.ToString() == textBox2.Text)
            {
                this.Hide();
                AnasayfaForm form = new AnasayfaForm();
                form.ShowDialog();
            }
            else
            {
                label4.Visible = true;

                await Task.Run(async () =>
                {
                    await Task.Delay(4000);
                    label4.Invoke((Action)(() =>
                    {
                        label4.Visible = false;
                    }));
                });

            }
            label4.Visible = false;
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
