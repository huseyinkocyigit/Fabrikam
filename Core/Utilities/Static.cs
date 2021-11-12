using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities
{
    public static class Static
    {
        public static List<int> TarihArasiSaatListele(DateTime basTrh,DateTime bitTrh)
        {
            List<int> sonuc = new List<int>();
            while(basTrh<bitTrh)
            {
                sonuc.Add(basTrh.Hour);
                basTrh=basTrh.AddHours(1);
            }
            return sonuc;
        }
    }
}
