using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araç_otomasyonu
{
    
     class Araç_Kiralama
    {

         static SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-QRQBUAH\SQLEXPRESS;Initial Catalog=Araç_Kiralama;Integrated Security=True");
         DataTable tablo;
        public static void ekle_sil_güncelle(SqlCommand komut,string sorgu)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }

}

