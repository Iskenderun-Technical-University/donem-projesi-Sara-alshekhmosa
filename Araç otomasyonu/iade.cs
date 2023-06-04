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
    public partial class iade : Form
    {
        public iade()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QRQBUAH\SQLEXPRESS;Initial Catalog=Araç_Kiralama;Integrated Security=True");

        public int ConvertToInt32 { get; private set; }

        public void populate()
        {
            con.Open();
            string query = "Select *from kira";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgv3.DataSource = ds.Tables[0];
            con.Close();

        }
        public void populateRet()
        {
            con.Open();
            string query = "Select *from iade";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgv4.DataSource = ds.Tables[0];
            con.Close();

        }
        private void deleteOnReturn()
        {
            int rentid;
            rentid = Convert.ToInt32(dgv3.SelectedRows[0].Cells[0].Value.ToString());
            con.Open();
            string query = "delete from kira where id ='" + rentid + "';";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
           // MessageBox.Show("kiralama silindi");
            con.Close();
            populate();
            
        }


        private void iade_Load(object sender, EventArgs e)
        {
            populate();
            populateRet();
        }

        private void dgv3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            araçplakası.Text = dgv3.SelectedRows[0].Cells[1].Value.ToString();
            txtAd2.Text= dgv3.SelectedRows[0].Cells[2].Value.ToString();
            gTime.Text= dgv3.SelectedRows[0].Cells[4].Value.ToString();
            DateTime d1 = gTime.Value.Date;
            DateTime d2 = DateTime.Now;
            TimeSpan t = d2 - d1;
            int NrOfDays = Convert.ToInt32(t.TotalDays);
            if(NrOfDays<=0)
            {
                gecikme.Text = "gecikme yok ";
                txtiyi.Text = "0";
            }
            else
            {

                gecikme.Text = "" + NrOfDays;
                txtiyi.Text = "" + (NrOfDays*250);




            }
        }

        private void btnİp3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaSyafa ana = new AnaSyafa();
            ana.Show();
        }

        private void btnka2_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtAd2.Text == "" || gecikme.Text == ""|| txtiyi.Text=="")
            {
                MessageBox.Show("Eksik bilgi");


            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into iade  values (" + txtId.Text + ",'" + araçplakası.Text + "','" + txtAd2.Text + "','" + gTime.Text + "','" + gecikme.Text + "','" + txtiyi.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("araç iade edildi");
                    con.Close();
                   // updateonRent();
                    populateRet();
                    deleteOnReturn();
                }
                catch (Exception myex)
                {
                    MessageBox.Show(myex.Message);
                }
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
