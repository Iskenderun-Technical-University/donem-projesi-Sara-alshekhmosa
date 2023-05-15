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

namespace Araç_otomasyonu
{
    public partial class MüşteriEkleme : Form



 
    {
        public MüşteriEkleme()
    {
        InitializeComponent();
    }
        private void btnİp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void btnEk_Click(object sender, EventArgs e)
        {
            string cümle = "insert into müşteri(tc,adsoyad,telefon,adres,email) values(@tc,@adsoyad,@telefon,@adres,@email)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", txtTc.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAd.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTe.Text);
            komut2.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut2.Parameters.AddWithValue("@email", txtEm.Text);
            arackiralama.ekle_sil_güncelle(komut2,cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
        }


    }

}

