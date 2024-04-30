using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace otel_rezervasyon_uygulaması.Forms
{
    public partial class OdaSqlEkleme : Form
    {

        private readonly string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=OtelContext;Integrated Security=True";



        public OdaSqlEkleme()
        {
            InitializeComponent();
        }

        private void OdaSqlEkleme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string odaTipi = textBox1.Text;
            string durum = textBox2.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Bağlantıyı aç

                connection.Open();

                string query = "INSERT INTO Odalar (oda_tipi, durum) VALUES (@OdaTipi , @Durum)";

                SqlTransaction transaction = connection.BeginTransaction();


                try
                {
                    // İlk sorguyu çalıştır
                    using (SqlCommand command1 = new SqlCommand(query, connection, transaction))
                    {
                        // Parametreleri ekle
                        command1.Parameters.AddWithValue("@OdaTipi", odaTipi);
                        command1.Parameters.AddWithValue("@Durum", durum); 

                        // Komutu çalıştır
                        int rowsAffected1 = command1.ExecuteNonQuery();

                        // Ekleme işleminin sonucunu kontrol et
                        if (rowsAffected1 <= 0)
                        {
                            throw new Exception("Oda Eklenemedi.");
                        }
                    }


                    transaction.Commit();
                    MessageBox.Show("Oda Eklendi");
                    
                }
                catch (Exception ex)
                {
                    // Bir hata olursa, işlemi geri al
                    transaction.Rollback();
                    MessageBox.Show("Hata: " + ex.Message);
                }




                // Bağlantıyı kapat
                connection.Close();

            }
        }
    }
}
