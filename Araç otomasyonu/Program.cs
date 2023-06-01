using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araç_otomasyonu
{
    static class Program
    {
        public static AnaSyafa anasayfa;
        public static MüşteriEkleme musteriekleme;
      
        public static iade iadee;
        public static AraçListeleme araclisteleme;
        public static Kiralama kiralama;

        
        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            anasayfa = new AnaSyafa();
            musteriekleme = new MüşteriEkleme();
        
            iadee = new iade();
            araclisteleme = new AraçListeleme();
            kiralama = new Kiralama();
            Application.Run(new AnaSyafa());
        }
    }
}
