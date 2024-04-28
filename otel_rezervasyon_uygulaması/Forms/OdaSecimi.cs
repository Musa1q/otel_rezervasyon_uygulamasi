using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otel_rezervasyon_uygulaması.Forms
{
    public partial class OdaSecimi : Form
    {
        public string odaId { get; set; }

        public OdaSecimi()
        {
            InitializeComponent();
        }

        private void OdaSecimi_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker2.MinDate = DateTime.Today;

            if (odaId == "1")
            {
                numericUpDown1.Value = 1;
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;

            }
            else if (odaId == "2")
            {
                numericUpDown1.Minimum = 1;
                numericUpDown1.Maximum = 2;
                numericUpDown2.Maximum = 1;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Hide();
            AnasayfaForm anasayfaForm = new AnasayfaForm();
            anasayfaForm.odaId = this.odaId;
            anasayfaForm.ShowDialog();


        }

        public void tekOdaUcretHesapla(int days)
        {
            int hesapla = 890 * days;
            label10.Text = hesapla.ToString();
        }

        public void ciftOdaUcretHesapla(int days , int yetiskin)
        {
            int ucret = yetiskin * 890;
            int hesapla = ucret * days;
            label10.Text = hesapla.ToString();
        }

        public void ciftOdaUcretHesapla2(int days, int yetiskin, int cocuk)
        {
            int ucret = (yetiskin * 890) + (cocuk * 445);
            int hesapla = ucret * days;
            label10.Text = hesapla.ToString();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;


            // İki tarih arasındaki farkı hesaplama
            TimeSpan difference = endDate - startDate;


            // İki tarih arasındaki gün sayısını hesaplama
            int daysDifference = difference.Days;

            if (odaId == "1")
            {
                tekOdaUcretHesapla(daysDifference);
            }
            else if (odaId == "2") {
                if (numericUpDown1.Value == 2) {
                    ciftOdaUcretHesapla(daysDifference, (int)numericUpDown1.Value);
                }else if(numericUpDown1.Value == 1) { 
                    if(numericUpDown2.Value == 1) {
                        ciftOdaUcretHesapla2(daysDifference, (int)numericUpDown1.Value, (int)numericUpDown2.Value);
                    }
                }
            }
            else if (odaId == "3")
            {
                //burada kaldın
                //Veritabanına kaydet rezervasyonları kullanıcın adını ve oda numarasını hangi tarih aralarında kalacaklarını
                //
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnasayfaForm anasayfaForm = new AnasayfaForm();
            anasayfaForm.odaId = this.odaId;
            anasayfaForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 1)
            {
                if (numericUpDown2.Value == 1)
                {
                    MessageBox.Show("İki kişilik oda 3 kişi kalamazsınız!");
                }
            }else if (numericUpDown1.Value == 1)
            {
                if (numericUpDown2.Value == 0)
                {
                    MessageBox.Show("İki kişilik odada tek kişilik kalamazsınız!");
                }
            }



        }
    }
}
