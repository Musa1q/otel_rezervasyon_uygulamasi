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
    public partial class OdaSecimi : Form
    {
        public string odaId { get; set; }

        public OdaSecimi()
        {
            InitializeComponent();
        }

        private void OdaSecimi_Load(object sender, EventArgs e)
        {
             
            label7.Text = BosOdaSayisiniGetir().ToString();
        }

        

        public int BosOdaSayisiniGetir()
        {

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=OtelContext;Integrated Security=True";
            int oda_tipi = Convert.ToInt32(odaId);
            int bosOdaSayisi = 0; // Başlangıçta boş oda sayısını sıfıra eşitle

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT oda_tipi, durum FROM Odalar WHERE oda_tipi = @oda_tipi AND durum = 0";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@oda_tipi", oda_tipi);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            bosOdaSayisi++;
                        }
                    }
                }
            }

            return bosOdaSayisi; // Boş oda sayısını geri döndür
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Hide();
            AnasayfaForm anasayfaForm = new AnasayfaForm();
            anasayfaForm.odaId = this.odaId;
            anasayfaForm.ShowDialog();


        }
 

            private void button1_Click(object sender, EventArgs e)
        { 

 

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

            if (BosOdaSayisiniGetir() < 1)
            {
                MessageBox.Show("Rezervasyon Alınamaz.\nOdalar Dolu : " + BosOdaSayisiniGetir());
            }
            else
            {
                RezervasyonForm rezervasyonForm = new RezervasyonForm();
                rezervasyonForm.odaId = this.odaId;
                rezervasyonForm.ShowDialog();

            }

            

        }
    }
}
