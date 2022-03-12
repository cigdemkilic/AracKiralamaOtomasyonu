using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArackiralamaOtomasyonu
{
   public class Motorr:Arac
    {
        public static int tms;
      public Motorr()
        {
            tms++;
        }
        public override string vitesTipi(string tip)
        {
            return tip;
        }

        public override int fiyat(string a, string b, int c)
        {
            int d;
            if (a == "Yamaha YZF-R1")
            {
                if (b == "Günlük")
                    d = c * 150;
                else
                    d = c * 150 * 30;
            }

            else
            {
                if (b == "Günlük")
                    d = c * 200;
                else
                    d = c * 6000;
            }
            return d;
        }
    }
}
