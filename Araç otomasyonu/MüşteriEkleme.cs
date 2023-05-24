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

    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QRQBUAH\SQLEXPRESS;Initial Catalog=Araç_Kiralama;Integrated Security=True");
      
    private void btnİp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void btnEk_Click(object sender, EventArgs e)
        {
           if (txtTc.Text== "" || txtAd.Text== "" || txtTe.Text== "" || txtadres.Text== ""|| txtEm.Text=="")
            {
                MessageBox.Show("Eksik bilgi");


            }
           else
            {
                try {
                    con.Open();
                    string query = "insert into müşteri values ("+txtTc.Text+",'"+txtAd.Text+"','"+txtTe.Text+"','"+txtadres.Text+"','" +txtEm.Text+"')";
                    SqlCommand cmd = new SqlCommand(query,con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("müşteri eklendi");
                    con.Close();

                }
                catch(Exception myex)
                {
                    MessageBox.Show(myex.Message);
                }
            }
        }

    }

}

