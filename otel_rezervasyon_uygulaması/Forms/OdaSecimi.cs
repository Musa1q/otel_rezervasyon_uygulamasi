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
            if (odaId == "1")
            {
                numericUpDown1.Value = 1;
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;

            }
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
    }
}
