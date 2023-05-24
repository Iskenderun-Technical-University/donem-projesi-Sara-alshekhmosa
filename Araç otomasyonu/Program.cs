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
        public static MüşteriListeme musterilisteleme;
        public static AraçKayıt arackayit;
        public static AraçListeleme araclisteleme;
        
        

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
            musterilisteleme = new MüşteriListeme();
            arackayit = new AraçKayıt();
            araclisteleme = new AraçListeleme();
            Application.Run(new AnaSyafa());
        }
    }
}
