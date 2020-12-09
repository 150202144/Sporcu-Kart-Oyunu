using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolabII
{
    public class Test
    {

        Random rnd = new Random();
        
        public List<Futbolcu> futbolculiste;
        public List<Basketbolcu> basketbolculiste;
        public string futbolSecilenPozisyon;
        public string basketbolSecilenPozisyon;





        public void oyuncuTuret()
        {
            #region Futbolcu Türetme


            Futbolcu f1 = new Futbolcu("Erling Haland","Dortmund")
            {
                penalti = 85,
                serbestAtis = 70,
                kaleciKarsiKarsiya = 88
                
            };
            Futbolcu f2 = new Futbolcu("Leon Goretzka","Bayern")
            {
                penalti = 85,
                serbestAtis = 75,
                kaleciKarsiKarsiya = 80
            };
            Futbolcu f3 = new Futbolcu("Kylian Mbappe","PSG")
            {               
                penalti = 90,
                serbestAtis = 85,
                kaleciKarsiKarsiya = 90
            };
            Futbolcu f4 = new Futbolcu("Zlatan Ibrahimoviç","Milan")
            {
                penalti = 90,
                serbestAtis = 90,
                kaleciKarsiKarsiya = 95
            };
            Futbolcu f5 = new Futbolcu("Lautaro Martinez","Inter")
            {
                penalti = 85,
                serbestAtis = 81,
                kaleciKarsiKarsiya = 88
            };
            Futbolcu f6 = new Futbolcu("Joao Felix","Atletico")
            {
                penalti = 80,
                serbestAtis = 75,
                kaleciKarsiKarsiya = 80
            };
            Futbolcu f7 = new Futbolcu("Roberto Firmino","Liverpool")
            {
                penalti = 80,
                serbestAtis = 85,
                kaleciKarsiKarsiya = 84
            };
            Futbolcu f8 = new Futbolcu("Eden Hazard","Real Madrid")
            {
                penalti = 85,
                serbestAtis = 75,
                kaleciKarsiKarsiya = 88
            };

            Futbolcu f9 = new Futbolcu("Lionel Messi","Barcelona")
            {
                penalti = 95,
                serbestAtis = 93,
                kaleciKarsiKarsiya = 95
            };

            Futbolcu f10 = new Futbolcu("Pierre Aubameyang","Arsenal")
            {
                penalti = 92,
                serbestAtis = 85,
                kaleciKarsiKarsiya = 94
            };

            Futbolcu f11 = new Futbolcu("Dreis Mertens","Napoli")
            {
                penalti = 89,
                serbestAtis = 83,
                kaleciKarsiKarsiya = 90
            };

            Futbolcu f12 = new Futbolcu("Kevin De Bruyne","M.City")
            {
                penalti = 90,
                serbestAtis = 91,
                kaleciKarsiKarsiya = 87
            };

            Futbolcu f13 = new Futbolcu("Bruno Fernandes","M.United")
            {
                penalti = 98,
                serbestAtis = 90,
                kaleciKarsiKarsiya = 85
            };

            Futbolcu f14 = new Futbolcu("Timo Werner","Chelsea")
            {
                penalti = 87,
                serbestAtis = 70,
                kaleciKarsiKarsiya = 92
            };

            //Futbolcu f15 = new Futbolcu()
            //{
            //    sporcuIsim = "Eden Hazard",
            //    sporcuTakim =
            //    penalti = 87,
            //    serbestAtis = 70,
            //    kaleciKarsiKarsiya = 92
            //};

            #endregion

            #region Basketbolcu Türetme

            Basketbolcu b1 = new Basketbolcu("Kobe Bryant","Lakers")
            {
                ikilik = 80,
                ucluk = 85,
                serbestAtis = 80 
            };
            Basketbolcu b2 = new Basketbolcu("Michael Jordan","Bulls")
            {
                ikilik = 80,
                ucluk = 85,
                serbestAtis = 80
            };
            Basketbolcu b3 = new Basketbolcu("Kevin Garnett","Wolves")
            {
                ikilik = 80,
                ucluk = 45,
                serbestAtis = 80
            };
            Basketbolcu b4 = new Basketbolcu("Shaquille O'Neal","Lakers")
            {
                ikilik = 80,
                ucluk = 20,
                serbestAtis = 80
            };
            Basketbolcu b5 = new Basketbolcu("Tracy McGrady","Rockets")
            {
                ikilik = 80,
                ucluk = 85,
                serbestAtis = 80
            };
            Basketbolcu b6 = new Basketbolcu("Kareem Abdul-Jabbar","Lakers")
            {
                ikilik = 80,
                ucluk = 60,
                serbestAtis = 80
            };
            Basketbolcu b7 = new Basketbolcu("Lebron James","Lakers")
            {
                ikilik = 80,
                ucluk = 85,
                serbestAtis = 80
            };
            Basketbolcu b8 = new Basketbolcu("Kevin Durant","Nets")
            {
                ikilik = 80,
                ucluk = 88,
                serbestAtis = 80
            };
            Basketbolcu b9 = new Basketbolcu("Stephen Curry","Warriors")
            {
                ikilik = 80,
                ucluk = 98,
                serbestAtis = 80
            };
            Basketbolcu b10 = new Basketbolcu("Steve Nash","Suns")
            {
                ikilik = 80,
                ucluk = 92,
                serbestAtis = 80
            };
            Basketbolcu b11 = new Basketbolcu("Manu Ginobili","Spurs")
            {
                ikilik = 80,
                ucluk = 92,
                serbestAtis = 80
            };
            Basketbolcu b12 = new Basketbolcu("Tim Duncan", "Spurs")
            {
                ikilik = 80,
                ucluk = 70,
                serbestAtis = 80
            };
            Basketbolcu b13 = new Basketbolcu("Dirk Nowitski", "Mavericks")
            {
                ikilik = 80,
                ucluk = 88,
                serbestAtis = 80
            };
            Basketbolcu b14 = new Basketbolcu("Allen Iverson","76ers")
            {
                ikilik = 80,
                ucluk = 95,
                serbestAtis = 80
            };

            #endregion

            futbolculiste= new List<Futbolcu>();
            futbolculiste.AddRange(new List<Futbolcu>
            {
                f1,f2,f3,f4,f5,f6,f7,f8,f9,f10,f11,f12,f13,f14
            });

            futbolculiste = futbolculiste.OrderBy(x => Guid.NewGuid()).Take(8).ToList();

            basketbolculiste = new List<Basketbolcu>();
            basketbolculiste.AddRange(new List<Basketbolcu>
            {
                b1,b2,b3,b4,b5,b6,b7,b8,b9,b10,b11,b12,b13,b14
            });

            basketbolculiste = basketbolculiste.OrderBy(x => Guid.NewGuid()).Take(8).ToList();

            
            
        }









        public void pozisyonBilgisi()
        {
            List<string > futbolPozisyonListe = new List<string>();
            futbolPozisyonListe.Add("penalti");
            futbolPozisyonListe.Add("serbestAtis");
            futbolPozisyonListe.Add("kaleciKarsiKarsiya");

            int randomsayi = rnd.Next(futbolPozisyonListe.Count);
            futbolSecilenPozisyon = futbolPozisyonListe[randomsayi];


            List<string>  basketbolPozisyonListe = new List<string>();
            basketbolPozisyonListe.Add("ikilik");
            basketbolPozisyonListe.Add("ucluk");
            basketbolPozisyonListe.Add("serbestAtis");

            int randomsayi2 = rnd.Next(basketbolPozisyonListe.Count);
            basketbolSecilenPozisyon = basketbolPozisyonListe[randomsayi2];

        }
    }
}
