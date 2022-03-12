using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArackiralamaOtomasyonu
{
    public abstract class Arac
    {
        public abstract int fiyat(string a, string b, int c);
        public string marka { get; set; }
        public string uretimYeri { get; set; }
        public int kisi_ { get; set; }
        public abstract string vitesTipi(string tip);
        public virtual string beygir_gücü()
        {
            return "180 bg";
        }
    }
}
