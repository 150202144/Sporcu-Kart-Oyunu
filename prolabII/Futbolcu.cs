using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolabII
{
    public class Futbolcu:Sporcu
    {
        public bool kartKullanildiMi=false;

        private int _penalti;
        private int _serbestatis;
        private int _kaleciKarsiKarsiya;

        public int penalti
        {
            get 
            { 
             return _penalti;
            }
            set
            {
             _penalti = value;
            }
        }
        public int serbestAtis
        {
            get
            {
                return _serbestatis;
            }
            set
            {
                _serbestatis = value;
            }
        }

        public int kaleciKarsiKarsiya
        {
            get
            {
                return _kaleciKarsiKarsiya;
            }
            set
            {
                _kaleciKarsiKarsiya = value;
            }
        }

        public Futbolcu()
        {

        }

        public Futbolcu(string futbolcuAdi, string  futbolcuTakim)
        {
            base.sporcuIsim = futbolcuAdi;
            base.sporcuTakim = futbolcuTakim;
            
        }

        public override void sporcuPuaniGoster()
        {
            Console.WriteLine($"Penaltı: {0} - Serbest Atış: {1} - Kaleciyle Karşı Karşıya: {2}",penalti,serbestAtis,kaleciKarsiKarsiya);

        }


    }
}
