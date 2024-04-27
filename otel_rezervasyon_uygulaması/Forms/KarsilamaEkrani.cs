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
    public partial class KarsilamaEkrani : Form
    {
        public KarsilamaEkrani()
        {
            InitializeComponent();
        }

        private void girisButton_Click(object sender, EventArgs e)
        {
            GirisForm girisForm = new GirisForm();
            girisForm.ShowDialog();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            KayitOl kayitOl = new KayitOl();
            kayitOl.Show();
            this.Hide();
        }
    }
}
