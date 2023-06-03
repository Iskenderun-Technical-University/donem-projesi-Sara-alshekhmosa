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
            string query = "Select *from araç";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgv2.DataSource = ds.Tables[0];
            con.Close();

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
                    string query = "insert into araç values (" + txtPl.Text + ",'" + txtMa.Text + "','" + txtMo.Text + "','" + txtKi.Text + "','" + ctxtMe.SelectedItem.ToString() + "')";
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
        private void fillAvailable()
        {
            con.Open();
            string query = "select mevcut from araç";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("mevcut", typeof(string));
            dt.Load(rdr);
            güncell.ValueMember = "mevcut";
            güncell.DataSource = dt;
            con.Close();
        }

        private void AraçListeleme_Load(object sender, EventArgs e)
        {
            populate();
            fillAvailable();
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
                    string query = "delete from araç where plaka ='" + txtPA.Text + "';";
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

        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPl.Text = dgv2.SelectedRows[0].Cells[0].Value.ToString();
            txtMa.Text = dgv2.SelectedRows[0].Cells[1].Value.ToString();
            txtMo.Text = dgv2.SelectedRows[0].Cells[2].Value.ToString();
            txtKi.Text = dgv2.SelectedRows[0].Cells[3].Value.ToString();
            ctxtMe.SelectedItem = dgv2.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnGu2_Click(object sender, EventArgs e)
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
                    string query = "update araç set marka ='" + txtMa.Text + "',model ='" + txtMo.Text + "',kiraÜcreti ='" + txtKi.Text + "',mevcut ='" + ctxtMe.SelectedItem.ToString() + "' where plaka = " + txtPl.Text + " ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("araç güncellendi");
                    con.Close();

                    populate();
                }
                catch (Exception myex)
                {
                    MessageBox.Show(myex.Message);
                }
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            populate();
        }
    }
    }

