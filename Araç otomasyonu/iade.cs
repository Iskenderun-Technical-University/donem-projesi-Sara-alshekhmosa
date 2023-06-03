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

      

        private void iade_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void dgv3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            araçplakası.Text = dgv3.SelectedRows[0].Cells[1].Value.ToString();
            txtAd3.Text= dgv3.SelectedRows[0].Cells[2].Value.ToString();
            iadetarihi.Text= dgv3.SelectedRows[0].Cells[4].Value.ToString();
            DateTime d1 = iadetarihi.Value.Date;
            DateTime d2 = DateTime.Now;
            TimeSpan t = d2 - d1;
            int NrOfDays = Convert.ToInt32(t.TotalDays);
            if(NrOfDays<=0)
            {
                gecikme.Text = "gecikme yok ";
                txtiyi.Text = "iyi değil";
            }
            else
            {

                gecikme.Text = "" + NrOfDays;
                txtiyi.Text = "" + (NrOfDays*250);




            }
        }

        private void btnİp3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnka2_Click(object sender, EventArgs e)
        {
           

        }
    }
}
