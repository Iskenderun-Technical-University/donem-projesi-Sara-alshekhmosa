﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araç_otomasyonu
{
    public partial class AnaSyafa : Form
    {
        public AnaSyafa()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnME_Click(object sender, EventArgs e)
        {
            this.Hide();
            MüşteriEkleme müşteriEkleme = new MüşteriEkleme(); 
            müşteriEkleme.Show();
        }

        private void btnCi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void btnAk_Click(object sender, EventArgs e)
        {
            this.Hide();
            iade iade = new iade();
                 
            iade.Show();
        }

        private void btnAl_Click(object sender, EventArgs e)
        {
            this.Hide();
            AraçListeleme araçListeleme = new AraçListeleme();
            araçListeleme.Show();

        }

        private void btnSo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kiralama kiralama = new Kiralama();

            kiralama.Show();
        }

       
    }
}
