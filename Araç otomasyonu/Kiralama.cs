﻿using System;
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
        private void fillcombo()
        {
            con.Open();
            string query = "select  plaka from araç";
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
        private void Kiralama_Load(object sender, EventArgs e)
        {
            fillcombo();
            fillcustomer();
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
    }
}
