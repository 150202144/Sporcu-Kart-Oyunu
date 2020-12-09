using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prolabII
{
    public partial class OyunForm : Form
    {

        public string futbolSecilenPozisyon;
        public string basketbolSecilenPozisyon;

        Test test;
        Bilgisayar bilgisayarOyuncu;
        Kullanici kullaniciOyuncu;



        List<Futbolcu> oyuncuFutbolcuListe;
        List<Futbolcu> bilgisayarFutbolcuListe;
        List<Basketbolcu> oyuncuBasketbolcuListe;
        List<Basketbolcu> bilgisayarBasketbolcuListe;







        public OyunForm()
        {
            InitializeComponent();
        }

        private void btn_Kartlari_Dagit_Click(object sender, EventArgs e)
        {
            btn_Kartlari_Dagit.Visible = false;

            panel_Oyuncu_Futbolcular.Enabled = true;
            panel_Oyuncu_Basketbolcular.Enabled = true;
            panel_Bilgisayar_Futbolcular.Enabled = true;
            panel_Bilgisayar_Basketbolcular.Enabled = true;


            kullaniciOyuncu = new Kullanici(1, "mert", 0);
            bilgisayarOyuncu = new Bilgisayar(2, "pc", 0);
            lbl_oyuncuAd.Text = kullaniciOyuncu.oyuncuAdi;
            lbl_bilgisayarAd.Text = bilgisayarOyuncu.oyuncuAdi;

            test = new Test();
            test.oyuncuTuret();
            kullaniciOyuncu.futbolcuKartListe = test.futbolculiste;
            kullaniciOyuncu.basketbolcuKartListe = test.basketbolculiste;




            oyuncuFutbolcuListe = kullaniciOyuncu.futbolcuKartListe.Take(4).ToList();
            kullaniciOyuncu.futbolcuKartListe.RemoveRange(0, 4);
            bilgisayarFutbolcuListe = kullaniciOyuncu.futbolcuKartListe.Take(4).ToList();

            oyuncuBasketbolcuListe = kullaniciOyuncu.basketbolcuKartListe.Take(4).ToList();
            kullaniciOyuncu.basketbolcuKartListe.RemoveRange(0, 4);
            bilgisayarBasketbolcuListe = kullaniciOyuncu.basketbolcuKartListe.Take(4).ToList();

            for (int i = 1; i <= 4; i++)
            {
                // oyuncu isimlerinin eklenmesi
                var oyuncu_futbolcu_ad = panel_Oyuncu_Futbolcular.Controls.Find("lbl_oyuncu_futbol_" + i, true).FirstOrDefault();
                oyuncu_futbolcu_ad.Text = oyuncuFutbolcuListe[i - 1].sporcuIsim + " - " + oyuncuFutbolcuListe[i - 1].sporcuTakim;
                var bilgisayar_futbolcu_ad = panel_Bilgisayar_Futbolcular.Controls.Find("lbl_bilgisayar_futbol_" + i, true).FirstOrDefault();
                bilgisayar_futbolcu_ad.Text = bilgisayarFutbolcuListe[i - 1].sporcuIsim + " - " + bilgisayarFutbolcuListe[i - 1].sporcuTakim;
                var oyuncu_basketbolcu_ad = panel_Oyuncu_Basketbolcular.Controls.Find("lbl_oyuncu_basketbol_" + i, true).FirstOrDefault();
                oyuncu_basketbolcu_ad.Text = oyuncuBasketbolcuListe[i - 1].sporcuIsim + " - " + oyuncuBasketbolcuListe[i - 1].sporcuTakim;
                var bilgisayar_basketbolcu_ad = panel_Bilgisayar_Basketbolcular.Controls.Find("lbl_bilgisayar_basketbol_" + i, true).FirstOrDefault();
                bilgisayar_basketbolcu_ad.Text = bilgisayarBasketbolcuListe[i - 1].sporcuIsim + " - " + bilgisayarBasketbolcuListe[i - 1].sporcuTakim;

                // oyuncunun futbolcularının özelliklerine labellara atama
                var oyuncu_futbol_penalti = panel_Oyuncu_Futbolcular.Controls.Find("lbl_o_p_" + i, true).FirstOrDefault();
                oyuncu_futbol_penalti.Text = oyuncuFutbolcuListe[i - 1].penalti.ToString();
                var oyuncu_futbol_serbestvurus = panel_Oyuncu_Futbolcular.Controls.Find("lbl_o_sv_" + i, true).FirstOrDefault();
                oyuncu_futbol_serbestvurus.Text = oyuncuFutbolcuListe[i - 1].serbestAtis.ToString();
                var oyuncu_futbol_karsikarsiya = panel_Oyuncu_Futbolcular.Controls.Find("lbl_o_kk_" + i, true).FirstOrDefault();
                oyuncu_futbol_karsikarsiya.Text = oyuncuFutbolcuListe[i - 1].kaleciKarsiKarsiya.ToString();

                // bilgisayarın futbolcularının özelliklerine labellara atama
                var bilgisayar_futbol_penalti = panel_Bilgisayar_Futbolcular.Controls.Find("lbl_b_p_" + i, true).FirstOrDefault();
                bilgisayar_futbol_penalti.Text = bilgisayarFutbolcuListe[i - 1].penalti.ToString();
                var bilgisayar_futbol_serbestvurus = panel_Bilgisayar_Futbolcular.Controls.Find("lbl_b_sv_" + i, true).FirstOrDefault();
                bilgisayar_futbol_serbestvurus.Text = bilgisayarFutbolcuListe[i - 1].serbestAtis.ToString();
                var bilgisayar_futbol_karsikarsiya = panel_Bilgisayar_Futbolcular.Controls.Find("lbl_b_kk_" + i, true).FirstOrDefault();
                bilgisayar_futbol_karsikarsiya.Text = bilgisayarFutbolcuListe[i - 1].kaleciKarsiKarsiya.ToString();

                // oyuncunun basketbolcularının özelliklerinin labellera atama
                var oyuncu_basketbol_ikilik = panel_Oyuncu_Basketbolcular.Controls.Find("lbl_o_b_iki_" + i, true).FirstOrDefault();
                oyuncu_basketbol_ikilik.Text = oyuncuBasketbolcuListe[i - 1].ikilik.ToString();
                var oyuncu_basketbol_ucluk = panel_Oyuncu_Basketbolcular.Controls.Find("lbl_o_b_uc_" + i, true).FirstOrDefault();
                oyuncu_basketbol_ucluk.Text = oyuncuBasketbolcuListe[i - 1].ucluk.ToString();
                var oyuncu_basketbol_serbestatis = panel_Oyuncu_Basketbolcular.Controls.Find("lbl_o_b_sa_" + i, true).FirstOrDefault();
                oyuncu_basketbol_serbestatis.Text = oyuncuBasketbolcuListe[i - 1].serbestAtis.ToString();

                // bilgisayarın basketbolcularının özelliklerinin labellera atama
                var bilgisayar_basketbol_ikilik = panel_Bilgisayar_Basketbolcular.Controls.Find("lbl_b_b_iki_" + i, true).FirstOrDefault();
                bilgisayar_basketbol_ikilik.Text = bilgisayarBasketbolcuListe[i - 1].ikilik.ToString();
                var bilgisayar_basketbol_ucluk = panel_Bilgisayar_Basketbolcular.Controls.Find("lbl_b_b_uc_" + i, true).FirstOrDefault();
                bilgisayar_basketbol_ucluk.Text = bilgisayarBasketbolcuListe[i - 1].ucluk.ToString();
                var bilgisayar_basketbol_serbestatis = panel_Bilgisayar_Basketbolcular.Controls.Find("lbl_b_b_sa_" + i, true).FirstOrDefault();
                bilgisayar_basketbol_serbestatis.Text = bilgisayarBasketbolcuListe[i - 1].serbestAtis.ToString();


            }



        }

        private void OyunForm_Load(object sender, EventArgs e)
        {
            panel_Oyuncu_Futbolcular.Enabled = false;
            panel_Oyuncu_Basketbolcular.Enabled = false;
            panel_Bilgisayar_Futbolcular.Enabled = false;
            panel_Bilgisayar_Basketbolcular.Enabled = false;
        }



        private void pb_o_f_1_Click(object sender, EventArgs e)
        {
            Futbolcu secilenFutbolcu = oyuncuFutbolcuListe[0];
            Futbolcu randomFutbolcu = bilgisayarOyuncu.kartSec<Futbolcu>(bilgisayarFutbolcuListe);
            FutbolcuPozisyonKarsilastirma(secilenFutbolcu, randomFutbolcu, pnl_o_f_1);




        }

        private void pb_o_f_2_Click(object sender, EventArgs e)
        {
            Futbolcu secilenFutbolcu = oyuncuFutbolcuListe[1];
            Futbolcu randomFutbolcu = bilgisayarOyuncu.kartSec<Futbolcu>(bilgisayarFutbolcuListe);
            FutbolcuPozisyonKarsilastirma(secilenFutbolcu, randomFutbolcu, pnl_o_f_2);





        }

        private void pb_o_f_3_Click(object sender, EventArgs e)
        {
            Futbolcu secilenFutbolcu = oyuncuFutbolcuListe[2];
            Futbolcu randomFutbolcu = bilgisayarOyuncu.kartSec<Futbolcu>(bilgisayarFutbolcuListe);
            FutbolcuPozisyonKarsilastirma(secilenFutbolcu, randomFutbolcu, pnl_o_f_3);



        }

        private void pb_o_f_4_Click(object sender, EventArgs e)
        {
            Futbolcu secilenFutbolcu = oyuncuFutbolcuListe[3];
            Futbolcu randomFutbolcu = bilgisayarOyuncu.kartSec<Futbolcu>(bilgisayarFutbolcuListe);
            FutbolcuPozisyonKarsilastirma(secilenFutbolcu, randomFutbolcu, pnl_o_f_4);



        }

        private void pb_o_b_1_Click(object sender, EventArgs e)
        {
            Basketbolcu secilenBasketbolcu = oyuncuBasketbolcuListe[0];
            Basketbolcu randomBasketbolcu = bilgisayarOyuncu.kartSec<Basketbolcu>(bilgisayarBasketbolcuListe);
            BasketbolcuPozisyonKarsilastirma(secilenBasketbolcu, randomBasketbolcu, pnl_o_b_1);




        }

        private void pb_o_b_2_Click(object sender, EventArgs e)
        {
            Basketbolcu secilenBasketbolcu = oyuncuBasketbolcuListe[1];
            Basketbolcu randomBasketbolcu = bilgisayarOyuncu.kartSec<Basketbolcu>(bilgisayarBasketbolcuListe);
            BasketbolcuPozisyonKarsilastirma(secilenBasketbolcu, randomBasketbolcu, pnl_o_b_2);




        }

        private void pb_o_b_3_Click(object sender, EventArgs e)
        {
            Basketbolcu secilenBasketbolcu = oyuncuBasketbolcuListe[2];
            Basketbolcu randomBasketbolcu = bilgisayarOyuncu.kartSec<Basketbolcu>(bilgisayarBasketbolcuListe);
            BasketbolcuPozisyonKarsilastirma(secilenBasketbolcu, randomBasketbolcu, pnl_o_b_3);



        }

        private void pb_o_b_4_Click(object sender, EventArgs e)
        {
            Basketbolcu secilenBasketbolcu = oyuncuBasketbolcuListe[3];
            Basketbolcu randomBasketbolcu = bilgisayarOyuncu.kartSec<Basketbolcu>(bilgisayarBasketbolcuListe);
            BasketbolcuPozisyonKarsilastirma(secilenBasketbolcu, randomBasketbolcu, pnl_o_b_4);




        }


        public void FutbolcuPozisyonKarsilastirma(Futbolcu secilenFutbolcu, Futbolcu randomFutbolcu, Panel futbolcuPanel)
        {
            test.pozisyonBilgisi();
            futbolSecilenPozisyon = test.futbolSecilenPozisyon;

            switch (futbolSecilenPozisyon)
            {
                case "penalti":
                    {
                        txt_Pozisyon.Text = "PENALTI";
                        if (secilenFutbolcu.penalti > randomFutbolcu.penalti)
                        {
                            kullaniciOyuncu.skor += 10;
                            bilgisayarFutbolcuListe.Remove(randomFutbolcu);
                            secilenFutbolcu.kartKullanildiMi = true;
                            randomFutbolcu.kartKullanildiMi = true;
                            futbolcuPanel.Enabled = false;

                        }
                        else if (secilenFutbolcu.penalti < randomFutbolcu.penalti)
                        {
                            bilgisayarOyuncu.skor += 10;
                            bilgisayarFutbolcuListe.Remove(randomFutbolcu);
                            secilenFutbolcu.kartKullanildiMi = true;
                            randomFutbolcu.kartKullanildiMi = true;
                            futbolcuPanel.Enabled = false;


                        }
                        else
                        {
                            MessageBox.Show("Eşitlik");

                        }
                        break;
                    }


                case "serbestAtis":
                    {
                        txt_Pozisyon.Text = "SERBEST VURUŞ";
                        if (secilenFutbolcu.serbestAtis > randomFutbolcu.serbestAtis)
                        {
                            kullaniciOyuncu.skor += 10;
                            bilgisayarFutbolcuListe.Remove(randomFutbolcu);
                            secilenFutbolcu.kartKullanildiMi = true;
                            randomFutbolcu.kartKullanildiMi = true;
                            futbolcuPanel.Enabled = false;


                        }
                        else if (secilenFutbolcu.serbestAtis < randomFutbolcu.serbestAtis)
                        {
                            bilgisayarOyuncu.skor += 10;
                            bilgisayarFutbolcuListe.Remove(randomFutbolcu);
                            secilenFutbolcu.kartKullanildiMi = true;
                            randomFutbolcu.kartKullanildiMi = true;
                            futbolcuPanel.Enabled = false;


                        }
                        else
                        {
                            MessageBox.Show("Eşitlik");


                        }
                        break;
                    }


                case "kaleciKarsiKarsiya":
                    {
                        txt_Pozisyon.Text = "KARŞI KARŞIYA";
                        if (secilenFutbolcu.kaleciKarsiKarsiya > randomFutbolcu.kaleciKarsiKarsiya)
                        {
                            kullaniciOyuncu.skor += 10;
                            bilgisayarFutbolcuListe.Remove(randomFutbolcu);
                            secilenFutbolcu.kartKullanildiMi = true;
                            randomFutbolcu.kartKullanildiMi = true;
                            futbolcuPanel.Enabled = false;


                        }
                        else if (secilenFutbolcu.kaleciKarsiKarsiya < randomFutbolcu.kaleciKarsiKarsiya)
                        {
                            bilgisayarOyuncu.skor += 10;
                            bilgisayarFutbolcuListe.Remove(randomFutbolcu);
                            secilenFutbolcu.kartKullanildiMi = true;
                            randomFutbolcu.kartKullanildiMi = true;
                            futbolcuPanel.Enabled = false;


                        }
                        else
                        {
                            MessageBox.Show("Eşitlik");

                        }
                        break;
                    }

                default:
                    MessageBox.Show("Yanlış pozisyon");
                    break;
            }


            label4.Text = randomFutbolcu.sporcuIsim;

            txt_oyuncu_skor.Text = kullaniciOyuncu.skorGoster();
            txt_bilgisayar_skor.Text = bilgisayarOyuncu.skorGoster();


            if (oyuncuBasketbolcuListe.TrueForAll(x => x.kartKullanildiMi == true))
            {
                panel_Oyuncu_Futbolcular.Enabled = true;
                panel_Oyuncu_Basketbolcular.Enabled = false;
            }
            else
            {
                panel_Oyuncu_Futbolcular.Enabled = false;
                panel_Oyuncu_Basketbolcular.Enabled = true;
            }

            if (oyuncuBasketbolcuListe.TrueForAll(x => x.kartKullanildiMi == true) && oyuncuFutbolcuListe.TrueForAll(x => x.kartKullanildiMi == true))
            {
                if (kullaniciOyuncu.skor > bilgisayarOyuncu.skor)
                    MessageBox.Show("Oyun bitti. Kazanan:  " + kullaniciOyuncu.oyuncuAdi);
                else if (kullaniciOyuncu.skor < bilgisayarOyuncu.skor)
                    MessageBox.Show("Oyun bitti. Kazanan: " + bilgisayarOyuncu.oyuncuAdi);
                else
                    MessageBox.Show("Oyun bitti. Kazanan yok.");

            }






        }


        public void BasketbolcuPozisyonKarsilastirma(Basketbolcu secilenBasketbolcu, Basketbolcu randomBasketbolcu, Panel basketbolcuPanel)
        {
            test.pozisyonBilgisi();
            basketbolSecilenPozisyon = test.basketbolSecilenPozisyon;

            switch (basketbolSecilenPozisyon)
            {
                case "ikilik":
                    {
                        txt_Pozisyon.Text = "İKİLİK";
                        if (secilenBasketbolcu.ikilik > randomBasketbolcu.ikilik)
                        {
                            kullaniciOyuncu.skor += 10;
                            bilgisayarBasketbolcuListe.Remove(randomBasketbolcu);
                            secilenBasketbolcu.kartKullanildiMi = true;
                            randomBasketbolcu.kartKullanildiMi = true;
                            basketbolcuPanel.Enabled = false;


                        }
                        else if (secilenBasketbolcu.ikilik < randomBasketbolcu.ikilik)
                        {
                            bilgisayarOyuncu.skor += 10;
                            bilgisayarBasketbolcuListe.Remove(randomBasketbolcu);
                            secilenBasketbolcu.kartKullanildiMi = true;
                            randomBasketbolcu.kartKullanildiMi = true;
                            basketbolcuPanel.Enabled = false;


                        }
                        else
                        {
                            MessageBox.Show("Eşitlik");



                        }
                        break;
                    }


                case "ucluk":
                    {
                        txt_Pozisyon.Text = "ÜÇLÜK";
                        if (secilenBasketbolcu.ucluk > randomBasketbolcu.ucluk)
                        {
                            kullaniciOyuncu.skor += 10;
                            bilgisayarBasketbolcuListe.Remove(randomBasketbolcu);
                            secilenBasketbolcu.kartKullanildiMi = true;
                            randomBasketbolcu.kartKullanildiMi = true;
                            basketbolcuPanel.Enabled = false;



                        }
                        else if (secilenBasketbolcu.ucluk < randomBasketbolcu.ucluk)
                        {
                            bilgisayarOyuncu.skor += 10;
                            bilgisayarBasketbolcuListe.Remove(randomBasketbolcu);
                            secilenBasketbolcu.kartKullanildiMi = true;
                            randomBasketbolcu.kartKullanildiMi = true;
                            basketbolcuPanel.Enabled = false;


                        }
                        else
                        {
                            MessageBox.Show("Eşitlik");





                        }
                        break;
                    }


                case "serbestAtis":
                    {
                        txt_Pozisyon.Text = "SERBEST ATIŞ";
                        if (secilenBasketbolcu.serbestAtis > randomBasketbolcu.serbestAtis)
                        {
                            kullaniciOyuncu.skor += 10;
                            bilgisayarBasketbolcuListe.Remove(randomBasketbolcu);
                            secilenBasketbolcu.kartKullanildiMi = true;
                            randomBasketbolcu.kartKullanildiMi = true;
                            basketbolcuPanel.Enabled = false;



                        }
                        else if (secilenBasketbolcu.serbestAtis < randomBasketbolcu.serbestAtis)
                        {
                            bilgisayarOyuncu.skor += 10;
                            bilgisayarBasketbolcuListe.Remove(randomBasketbolcu);
                            secilenBasketbolcu.kartKullanildiMi = true;
                            randomBasketbolcu.kartKullanildiMi = true;
                            basketbolcuPanel.Enabled = false;


                        }
                        else
                        {
                            MessageBox.Show("Eşitlik");





                        }
                        break;
                    }

                default:
                    MessageBox.Show("Yanlış pozisyon");
                    break;
            }
            label4.Text = randomBasketbolcu.sporcuIsim;

            txt_oyuncu_skor.Text = kullaniciOyuncu.skorGoster();
            txt_bilgisayar_skor.Text = bilgisayarOyuncu.skorGoster();

            if (oyuncuFutbolcuListe.TrueForAll(x => x.kartKullanildiMi == true))
            {
                panel_Oyuncu_Futbolcular.Enabled = false;
                panel_Oyuncu_Basketbolcular.Enabled = true;
            }
            else
            {
                panel_Oyuncu_Futbolcular.Enabled = true;
                panel_Oyuncu_Basketbolcular.Enabled = false;
            }

            if (oyuncuBasketbolcuListe.TrueForAll(x => x.kartKullanildiMi == true) && oyuncuFutbolcuListe.TrueForAll(x => x.kartKullanildiMi == true))
            {
                if (kullaniciOyuncu.skor > bilgisayarOyuncu.skor)
                    MessageBox.Show("Oyun bitti. Kazanan:  " + kullaniciOyuncu.oyuncuAdi);
                else if (kullaniciOyuncu.skor < bilgisayarOyuncu.skor)
                    MessageBox.Show("Oyun bitti. Kazanan: " + bilgisayarOyuncu.oyuncuAdi);
                else
                    MessageBox.Show("Oyun bitti. Kazanan yok.");
            }

        }
    }
}









