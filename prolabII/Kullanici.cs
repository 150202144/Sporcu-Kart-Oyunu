using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolabII
{
    public class Kullanici : Oyuncu
    {
        public Kullanici()
        {

        }

        public Kullanici(int oyuncuID, string oyuncuAdi, int skor)
        {
            base.oyuncuID = oyuncuID;
            base.oyuncuAdi = oyuncuAdi;
            base.skor = skor;
        }

        public override T  kartSec<T>(List<T> kartListe)
        {
            return default(T);
        }
    }
}
