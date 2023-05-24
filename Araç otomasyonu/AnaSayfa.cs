using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araç_otomasyonu
{
    public partial class AnaSyafa : Form
    {
        public AnaSyafa()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnME_Click(object sender, EventArgs e)
        {
            Program.musteriekleme.Show();
        }

        private void btnCi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void btnAk_Click(object sender, EventArgs e)
        {
            Program.arackayit.Show();
        }

        private void btnAl_Click(object sender, EventArgs e)
        {
            Program.araclisteleme.Show();

        }
    }
}
