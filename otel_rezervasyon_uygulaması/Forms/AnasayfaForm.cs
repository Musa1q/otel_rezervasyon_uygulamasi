using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace otel_rezervasyon_uygulaması.Forms
{
    public partial class AnasayfaForm : Form
    {
       
        public string odaId { get; set; }
        public string pictureBox1Image;
        public string label4Text;

        public void icerik()
        {
            pictureBox1.Visible = true;
            label4.Visible = true;
            button1.Visible = true;

        }


        public AnasayfaForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AnasayfaForm_Load(object sender, EventArgs e)
        {
            button1.Hide();
            odaId = this.odaId;
            if(odaId != null)
            {
                VerileriGetir(odaId);
                icerik();
            }
           
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

            odaId = "1";
            icerik();
            VerileriGetir(odaId);

        }

        private void label2_Click(object sender, EventArgs e)
        {
            odaId = "2";
            icerik();
            VerileriGetir(odaId);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            odaId = "3";
            icerik();
            VerileriGetir(odaId);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 ye tıklandı");



        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2 e tıklandı");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("3 ye tıklandı");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            OdaSecimi odaSecimi = new OdaSecimi();
            odaSecimi.odaId = this.odaId;
            odaSecimi.Show();
        }
        public void VerileriGetir(string odaId)
        {
            if(odaId == "1")
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\YSARS\\source\\repos\\otel_rezervasyon_uygulaması\\otel_rezervasyon_uygulaması\\Resources\\1oda_sng.jpg");
                label4.Text = "Tek Yatak \nKüçük Oturma Alanı\nÜcretsiz Wi-Fi\n24 Saat Oda Servisi";
            }
            else if(odaId == "2")
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\YSARS\\source\\repos\\otel_rezervasyon_uygulaması\\otel_rezervasyon_uygulaması\\Resources\\çift.jpg");
                label4.Text = "Çift Kişilik Yatak \nAçık büfe \nOturma alanı\nÜcretsiz Wi-Fi\n24 Saat Oda Servisi";
            }
            else if (odaId == "3")
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\YSARS\\source\\repos\\otel_rezervasyon_uygulaması\\otel_rezervasyon_uygulaması\\Resources\\3-kisilik-oda.jpg");
                label4.Text = "Üç Kişilik Yatak Düzeni \nAçık büfe\nDaha Geniş Oturma Alanı\nÜcretsiz Wi-Fi\n24 Saat Oda Servisi";
            }
        }
    }
}
