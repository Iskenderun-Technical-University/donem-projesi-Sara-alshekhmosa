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
    public partial class Kiralama : Form
    {
        public Kiralama()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QRQBUAH\SQLEXPRESS;Initial Catalog=Araç_Kiralama;Integrated Security=True");
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
        private void fillcombo()
        {
            con.Open();
            string query = "select  plaka from araç where mevcut = '" + "Evet" +"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("plaka", typeof(string));
            dt.Load(rdr);
            ctxtAP.ValueMember = "plaka";
            ctxtAP.DataSource = dt;
            con.Close();
        }
        private void updateonRent()
        {
            con.Open();
            string query = "update araç set  mevcut ='" + "hayir" + "' where plaka = '" + ctxtAP.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
           // MessageBox.Show("araç güncellendi");
            con.Close();

        }
        private void updateonRentdelete()
        {
            con.Open();
            string query = "update araç set  mevcut ='" + "Evet" + "' where plaka ='" + ctxtAP.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            // MessageBox.Show("araç güncellendi");
            con.Close();

        }
        private void Kiralama_Load(object sender, EventArgs e)
        {
             fillcombo();
            fillcustomer();
            populate();
        }
        private void fillcustomer()
        {
            con.Open();
            string query = "select  tc from müşterii";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("tc", typeof(int));
            dt.Load(rdr);
            ctxtmusteri.ValueMember = "tc";
            ctxtmusteri.DataSource = dt;
            con.Close();
        }
        private void customerName()
        {
            con.Open();
            string query ="select * from müşterii where tc ="+ ctxtmusteri.SelectedValue.ToString()+ "";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtAd2.Text = dr["AdSoyad"].ToString();
            }
            con.Close();
        }

        private void ctxtAP_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void ctxtmusteri_SelectionChangeCommitted(object sender, EventArgs e)
        {
            customerName();

        }

        private void btnEk_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtAd2.Text == "" || txtuc.Text == "")
            {
                MessageBox.Show("Eksik bilgi");


            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into kira   values (" + txtId.Text + ",'" +  ctxtAP.SelectedValue.ToString() + "','" + txtAd2.Text + "','"  + gTime.Text + "','" + dgun.Text + "','" + txtuc.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("araç kiralandı");
                    con.Close();
                    updateonRent();
                    populate();
                }
                catch (Exception myex)
                {
                    MessageBox.Show(myex.Message);
                }
            }

        }

        private void btnİp_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaSyafa ana = new AnaSyafa();
            ana.Show();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Eksik bilgi");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from kira where id ='" + txtId.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("kiralama silindi");
                    con.Close();
                    populate();
                    updateonRentdelete();
                }
                catch (Exception myex)
                {
                    MessageBox.Show(myex.Message);
                }
            }
        }

        private void dgv3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgv3.SelectedRows[0].Cells[0].Value.ToString();
            ctxtAP.SelectedValue = dgv3.SelectedRows[0].Cells[1].Value.ToString();
           // txtAd2.Text = dgv3.SelectedRows[0].Cells[3].Value.ToString();
            txtuc.Text = dgv3.SelectedRows[0].Cells[5].Value.ToString();
           
        }
    }
}
