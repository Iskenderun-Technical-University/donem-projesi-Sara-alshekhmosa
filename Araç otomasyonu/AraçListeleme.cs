using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Araç_otomasyonu
{
    public partial class AraçListeleme : Form
    {
        public AraçListeleme()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QRQBUAH\SQLEXPRESS;Initial Catalog=Araç_Kiralama;Integrated Security=True");
        public void populate()
        {
            con.Open();
            string query = "Select *from araçlar";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgv2.DataSource = ds.Tables[0];
            con.Close();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtPl.Text == "" || txtMa.Text == "" || txtMo.Text == "" || txtKi.Text == "")
            {
                MessageBox.Show("Eksik bilgi");


            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into araçlar values (" + txtPl.Text + ",'" + txtMa.Text + "','" + txtMo.Text + "','" + txtKi.Text + "','" + ctxtMe.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("araç eklendi");
                    con.Close();

                   populate();
                }
                catch (Exception myex)
                {
                    MessageBox.Show(myex.Message);
                }
            }
        }

        private void AraçListeleme_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnİp4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil2_Click(object sender, EventArgs e)
        {
            if (txtPA.Text == "")
            {
                MessageBox.Show("Eksik bilgi");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from araçlar where plaka ='" + txtPA.Text + "';";
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
    }
}
