using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArackiralamaOtomasyonu
{
    public class Arabaa : Arac, elektrikli_
    {
        public int model;
        public string renk;

        public static int tas;
        public Arabaa()
        {
            tas++;
        }

        public override string vitesTipi(string tip)
        {
            return tip;
        }

        public string özellik(string tip2)
        {
            if (tip2 == "Elektrik")
                return "Elektrik ile çalışıyor. ";

            else
            {
                return "Benzin ile çalışıyor.";
            }
        }



        public override int fiyat(string a, string b, int c)
        {
            int d;
            if (a == "TOGG")
            {
                if (b == "Günlük")
                    d = c * 200;
                else
                    d = c * 300 * 30;
            }
            else
            {
                if (b == "Günlük")
                    d = c * 250;
                else
                    d = c * 500;
            }

            return d;
        }
    }
}

