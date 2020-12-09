using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolabII
{
    public class Basketbolcu : Sporcu
    {
        public bool kartKullanildiMi = false;

        private int _ikilik;
        private int _ucluk;
        private int _serbestAtis;



        public int ikilik
        {
            get
            {
                return _ikilik;
            }
            set
            {
                _ikilik = value;
            }
        }
        public int ucluk
        {
            get
            {
                return _ucluk;
            }
            set
            {
                _ucluk = value;
            }
        }

        public int serbestAtis
        {
            get
            {
                return _serbestAtis;
            }
            set
            {
                _serbestAtis = value;
            }
        }

        public Basketbolcu()
        {

        }

        public Basketbolcu(string basketbolcuAdi, string basketbolcuTakim)
        {
            base.sporcuIsim = basketbolcuAdi;
            base.sporcuTakim = basketbolcuTakim;

        }

        public override void sporcuPuaniGoster()
        {
            Console.WriteLine($"İkilik: {0} - Üçlük: {1} - Serbest Atış: {2}", ikilik, ucluk, serbestAtis);
        }


    }
}








