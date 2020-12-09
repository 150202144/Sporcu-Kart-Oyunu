using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolabII
{
    public class Bilgisayar : Oyuncu
    {
        public Bilgisayar()
        {

        }

        public Bilgisayar(int oyuncuID, string oyuncuAdi, int skor)
        {
            base.oyuncuID = oyuncuID;
            base.oyuncuAdi = oyuncuAdi;
            base.skor = skor;
        }

        public override T kartSec<T>(List<T> kartListe)
        {
            Random rnd = new Random();

            int random = rnd.Next(0, kartListe.Count);
            return kartListe[random];


        }



    }
}









