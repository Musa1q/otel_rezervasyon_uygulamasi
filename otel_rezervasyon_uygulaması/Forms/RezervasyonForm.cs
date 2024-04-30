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
    public partial class RezervasyonForm : Form
    {
        public string odaId { get; set; }
        public RezervasyonForm()
        {
            InitializeComponent();
        }

        private void RezervasyonForm_Load(object sender, EventArgs e)
        {

            

        }


        public void tekOdaUcretHesapla(int days, int yetiskin)
        {
            int ucret = yetiskin * 890;
            int hesapla = ucret * days;
            label10.Text = hesapla.ToString();
        }

        public void ciftOdaUcretHesapla(int days, int yetiskin)
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

            //DateTime startDate = dateTimePicker1.Value;
            //DateTime endDate = dateTimePicker2.Value;

            //// İki tarih arasındaki farkı hesaplama
            //TimeSpan difference = endDate - startDate;



        }




    }
}
