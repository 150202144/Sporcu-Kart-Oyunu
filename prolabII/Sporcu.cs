using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolabII
{
    public class Sporcu
    {
        private string _sporcuIsim;
        private string _sporcuTakim;



        public string sporcuIsim
        {
            get
            {
                return _sporcuIsim;
            }
            set
            {
                _sporcuIsim = value;
            }
        }

        public string sporcuTakim
        {
            get
            {
                return _sporcuTakim;
            }
            set
            {
                _sporcuTakim = value;
            }
        }



        public Sporcu()
        {

        }

        public Sporcu(string sporcuIsim, string sporcuTakim)
        {
            this.sporcuIsim = sporcuIsim;
            this.sporcuTakim = sporcuTakim;

        }


        public virtual void sporcuPuaniGoster()
        {
            Console.WriteLine("sporcuların kart puanı");

        }


    }
}









