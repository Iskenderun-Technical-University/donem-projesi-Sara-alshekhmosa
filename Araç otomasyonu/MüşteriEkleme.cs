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
        public void populate()
        {
            con.Open();
            string query = "Select *from müşteri";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }

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
                    populate();
                }
                catch(Exception myex)
                {
                    MessageBox.Show(myex.Message);
                }
            }
        }

        private void MüşteriEkleme_Load(object sender, EventArgs e)
        {
            populate();
        }
    }

}

