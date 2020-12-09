using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolabII
{
    public class Oyuncu
    {
        public List<Futbolcu> futbolcuKartListe;
        public List<Basketbolcu> basketbolcuKartListe;



        public int _oyuncuID { get; set; }
        public string _oyuncuAdi { get; set; }
        public int _skor { get; set; }

        public int oyuncuID
        {
            get
            {
                return _oyuncuID;
            }
            set
            {
                _oyuncuID = value;
            }
        }

        public string oyuncuAdi
        {
            get
            {
                return _oyuncuAdi;
            }
            set
            {
                _oyuncuAdi = value;
            }
        }

        public int skor
        {
            get
            {
                return _skor;
            }
            set
            {
                _skor = value;
            }
        }



        public Oyuncu()
        {

        }

        public Oyuncu(int oyuncuID, string oyuncuAdi, int skor)
        {
            this.oyuncuID = oyuncuID;
            this.oyuncuAdi = oyuncuAdi;
            this.skor = skor;
        }


        public string skorGoster()
        {
            return skor.ToString();
        }

        public virtual T kartSec<T>(List<T> kartListe)
        {

            return default(T);


        }
    }
}

