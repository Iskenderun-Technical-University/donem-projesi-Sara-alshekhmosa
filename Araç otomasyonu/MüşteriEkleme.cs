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
            string query = "Select *from müşterii";
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
                    string query = "insert into müşterii values ("+txtTc.Text+",'"+txtAd.Text+"','"+txtTe.Text+"','"+txtadres.Text+"','" +txtEm.Text+"')";
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtTc.Text == "")
            {
                MessageBox.Show("Eksik bilgi");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from müşterii where tc=" + txtTc.Text+ ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("müşteri silindi");
                    con.Close();
                    populate();

                }
                catch (Exception myex)
                {
                    MessageBox.Show(myex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtTe.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtadres.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtEm.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();


        }
    }

}

