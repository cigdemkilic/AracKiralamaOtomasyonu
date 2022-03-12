using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArackiralamaOtomasyonu
{
    public class Bisiklett: Arac
    {
            public string tur;
            public string malzeme;
            public double agirlik;

        public static int tbs;
        public Bisiklett()
        {
            tbs++;
        }

        public override string vitesTipi(string tip)
            {
                return tip;
            }
            public override int fiyat(string a, string b, int c)
            {
                if (a == "Çocuk")
                {
                    if (b == "Saatlik")
                    {
                        return 12 * c;
                    }
                    else
                    {
                        return 30 * c;
                    }
                }
                else if (a == "Dağ")
                {
                    if (b == "Saatlik")
                    {
                        return 20 * c;
                    }
                    else
                    {
                        return 65 * c;
                    }
                }
                else
                {
                    if (b == "Saatlik")
                    {
                        return 18 * c;
                    }
                    else
                    {
                        return 50 * c;
                    }
                }
            }
        }
    }

