﻿using System;
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
            this.Hide();
            GirisForm girisForm = new GirisForm();
            girisForm.ShowDialog();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            KayitOl kayitOl = new KayitOl();
            kayitOl.Show();
            
        }
    }
}
