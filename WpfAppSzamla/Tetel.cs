using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppSzamla
{
    public class Tetel
    {
        String termekNev;
        int egysegAr;
        String egyseg;
        double mennyiseg;

        public Tetel(string termekNev, int egysegAr, string egyseg, double mennyiseg)
        {
            this.termekNev = termekNev;
            this.egysegAr = egysegAr;
            this.egyseg = egyseg;
            this.mennyiseg = mennyiseg;
        }

        public string TermekNev { get; set;  }
        public int EgysegAr { get; set; }
        public string Egyseg { get; set; }
        public double Mennyiseg { get; set; }
    }
}
