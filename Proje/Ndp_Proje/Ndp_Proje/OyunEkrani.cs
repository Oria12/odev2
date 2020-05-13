
/********************************************************    
**              SAKARYA ÜNİVERSİTESİ
**     BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**       BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**          NESNEYE DAYALI PROGRAMLAMA DERSİ 
**               2019-2020 BAHAR DÖNEMİ 
**
**                  ÖDEV NUMARASI: 2 
**             ÖĞRENCİ ADI: ORÇUN HOLTA
**            ÖĞRENCİ NUMARASI: B191200300
**               DERSİN ALINDIĞI GRUP: 
*********************************************************/





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ndp_Proje
{
    public partial class OyunEkrani : Form  //Bu temel olarak kalıtıma bir örnektir
    {
        public OyunEkrani()
        {
            InitializeComponent();

            //Arkaplanı transparan yapmak için gerekli kod
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
        }



        //ates etkinliklerim için işime yarayacak değişkenler
        public int obirx;
        public int obiry;
        public int oikix;
        public int oikiy;

        Random rnd = new Random();    //Random değer oluşturmak için tanımladığım rnd isimli değişkenim


        //Düşmanların standart hız değerleri
        int dusmanHiziUst = 5;
        int dusmanHiziUst2 = 4;
        int dusmanHiziUst3 = 3;
        int dusmanHiziUst4 = 2;

        int genelsayac;    //Oyunun hızını kontrol etmek için gerekli olan sayaç



      
        private void OyunEkrani_Load(object sender, EventArgs e)
        {


            MuzikCal m = new MuzikCal(); //MuzikCal classını çağırabilmek için m isimli bir değişken tanımladım
            m.Cal(); //Class içerisindeki Cal isimli metodumuzu çağırdık bu şekilde formumuz yüklendiği anda yani oyun başladığı anda müzik başladı.


       
            atesTimer.Interval = 50;
            ates2Timer.Interval = 50;
            ates.Visible = false;
            ates2.Visible = false;
            atesTimer.Stop();
            ates2Timer.Stop();
            can1.Value = 100;
            can2.Value = 100;
            

            zaman.Enabled = true;

            oyuncu1.Location = new Point(165, 403);
            oyuncu2.Location = new Point(639, 403);
            
        }

       


        private void zaman_Tick(object sender, EventArgs e)
        {

            //Aşağıda tanımlarda karışmasın diye en üstte tüm düşmanlarımın x ve y koordinatlarına kısa değişken tanımlamaları yapıyorum.  
            int d1x = dusman1.Location.X;
            int d1y = dusman1.Location.Y;

            int d2x = dusman2.Location.X;
            int d2y = dusman2.Location.Y;

            int d3x = dusman3.Location.X;
            int d3y = dusman3.Location.Y;

            int d4x = dusman4.Location.X;
            int d4y = dusman4.Location.Y;

            int d5x = dusman5.Location.X;
            int d5y = dusman5.Location.Y;

            int d6x = dusman6.Location.X;
            int d6y = dusman6.Location.Y;

            int d7x = dusman7.Location.X;
            int d7y = dusman7.Location.Y;

            int d8x = dusman8.Location.X;
            int d8y = dusman8.Location.Y;




            /*Burada bir x düşüncesi oluşturuyorum ve diyorum ki eğer x(herhangi bir nesne) picturebox ise ve Tag'i dusmanUst ise 
            onun her saniye üstünde kalan boşluk dusmanHiziUst değeri kadar olsun. Bu işlemleri zaman timerı içinde yaptığım için
            her saniye pictureboxlarım hareket ediyor. Aynı işlemleri diğer düşmanlar için de uyguluyorum bu şekilde farklı hızlarda gidiyorlar. 
             */
                           
           foreach (Control x in this.Controls)
           {
               if (x is PictureBox && x.Tag=="dusmanUst")
               {
                   x.Top += dusmanHiziUst;                  
               }
           }

          
           foreach (Control x in this.Controls)
           {

               if (x is PictureBox && x.Tag == "dusmanUst2")
               {
                   x.Top += dusmanHiziUst2;                 
               }
           }
         

           foreach (Control x in this.Controls)
           {
               if (x is PictureBox && x.Tag == "dusmanUst3")
               {
                   x.Top += dusmanHiziUst3;                 
               }
           }


           foreach (Control x in this.Controls)
           {
               if (x is PictureBox && x.Tag == "dusmanUst4")
               {
                   x.Top += dusmanHiziUst4;                 
               }
           }



           //DÜŞMANLAR CAN BARLARINA DEĞERSE
            
           if (dusman1.Bounds.IntersectsWith(can1.Bounds))
           {
               dusman1.Top += dusmanHiziUst;
               can1.Value -= 10;
               dusman1.Top = -110; //bu kod bakıldığında bir işe yaramasa da her el rastgele yerden gelmesini sağlıyor
               d1x = rnd.Next(0, 350);
               d1y = -110;            
               dusman1.Location = new Point(d1x, d1y);

           }

           if (dusman2.Bounds.IntersectsWith(can2.Bounds))
           {
               dusman2.Top += dusmanHiziUst;
               can2.Value -= 10;
               dusman2.Top = -110;
               d2x = rnd.Next(450, 800);
               d2y = -110;            
               dusman2.Location = new Point(d2x, d2y);
           }

           if (dusman3.Bounds.IntersectsWith(can1.Bounds))
           {
               dusman3.Top += dusmanHiziUst2;
               can1.Value -= 10;
               dusman3.Top = -110;
               d3x = rnd.Next(0, 350);
               d3y = -110;       
               dusman3.Location = new Point(d3x, d3y);

           }

           if (dusman4.Bounds.IntersectsWith(can2.Bounds))
           {
               dusman4.Top += dusmanHiziUst2;
               can2.Value -= 10;
               dusman4.Top = -110;
               d4x = rnd.Next(450, 800);
               d4y = -110;              
               dusman4.Location = new Point(d4x, d4y);
           }

           if (dusman5.Bounds.IntersectsWith(can1.Bounds))
           {
               dusman5.Top += dusmanHiziUst3;
               can1.Value -= 10;
               dusman5.Top = -110;
               d5x = rnd.Next(0, 350);
               d5y = -110;
               dusman5.Location = new Point(d5x, d5y);

           }

           if (dusman6.Bounds.IntersectsWith(can2.Bounds))
           {
               dusman6.Top += dusmanHiziUst3;
               can2.Value -= 10;
               dusman6.Top = -110;
               d6x = rnd.Next(450, 800);
               d6y = -110;
               dusman6.Location = new Point(d6x, d6y);
           }

           if (dusman7.Bounds.IntersectsWith(can1.Bounds))
           {
               dusman7.Top += dusmanHiziUst4;
               can1.Value -= 10;
               dusman7.Top = -110;
               d7x = rnd.Next(0, 350);
               d7y = -110;
               dusman7.Location = new Point(d7x, d7y);

           }

           if (dusman8.Bounds.IntersectsWith(can2.Bounds))
           {
               dusman8.Top += dusmanHiziUst4;
               can2.Value -= 10;
               dusman8.Top = -110;
               d8x = rnd.Next(450, 800);
               d8y = -110;
               dusman8.Location = new Point(d8x, d8y);
           }







           //ATEŞ 1 DÜŞMANLARA DEĞERSE

           else if (ates.Bounds.IntersectsWith(dusman1.Bounds))
           {
               dusman1.Location = new Point(337, -110);
               ates.Location = new Point(obirx, obiry);              
               ates.Visible = false;
               atesTimer.Stop();
                
           }
           
           else if (ates.Bounds.IntersectsWith(dusman3.Bounds))
           {
               dusman3.Location = new Point(117, -110);
               ates.Location = new Point(obirx, obiry);             
               ates.Visible = false;
               atesTimer.Stop();
           }
           
           else if (ates.Bounds.IntersectsWith(dusman5.Bounds))
           {
               dusman5.Location = new Point(227, -110);
               ates.Location = new Point(obirx, obiry);              
               ates.Visible = false;
               atesTimer.Stop();
           }
           
           else if (ates.Bounds.IntersectsWith(dusman7.Bounds))
           {
               dusman7.Location = new Point(7, -110);
               ates.Location = new Point(obirx, obiry);              
               ates.Visible = false;
               atesTimer.Stop();
           }
           




           //ATEŞ 2 DÜŞMANLARA DEĞERSE

           else if (ates2.Bounds.IntersectsWith(dusman2.Bounds))
           {
               dusman2.Location = new Point(447, -110);
               ates2.Location = new Point(oikix, oikiy);               
               ates2.Visible = false;
               ates2Timer.Stop();
           }
           
           else if (ates2.Bounds.IntersectsWith(dusman4.Bounds))
           {
               dusman4.Location = new Point(667, -110);
               ates2.Location = new Point(oikix, oikiy);
               ates2.Visible = false;
               ates2Timer.Stop();
           }
           
           else if (ates2.Bounds.IntersectsWith(dusman6.Bounds))
           {
               dusman6.Location = new Point(557, -110);
              ates2.Location = new Point(oikix, oikiy);               
               ates2.Visible = false;
               ates2Timer.Stop();
           }
          
           else if (ates2.Bounds.IntersectsWith(dusman8.Bounds))
           {
               dusman8.Location = new Point(777, -110);
               ates2.Location = new Point(oikix, oikiy);             
               ates2.Visible = false;
               ates2Timer.Stop();
           }
           





          //CAN 1 veya CAN 2 BELİRLİ SEVİYENİN ALTINA DÜŞERSE YANİ HERHANGİ BİRİ KAYBEDERSE
           if (can1.Value==0)
           {
               zaman.Stop();
               Kazandi o2 = new Kazandi("Oyuncu 2 \n\nTekrar Oynamak İster misiniz?"); //Classın Kurucusuna "Oyuncu2"yi gönderdik
               o2.kazandimetot(); //Class içerisindeki metotu çağırdık
           }
             if (can2.Value==0)
           {
               zaman.Stop();
               Kazandi o1 = new Kazandi("Oyuncu 1 \n\nTekrar Oynamak İster misiniz?");
               o1.kazandimetot();
           }






            //ZAMAN KISMI

             genelsayac++; //genelsayac değişkenimi zaman timerım her değiştiğinde 1 arttırıyorum bu şekilde saniyeye oranlamış oluyorum

             /*genelsayac değişkenim 0 dan sonsuza kadar artıyor onun belirli zamanlarında oyunun hızının bulunduğu timer olan
              zaman timer'ının intervalini değiştiriyorum ki düşmanlar daha hızlı şekilde gelsinler.
              Yani aslında düşmanlar hızlanmıyor oyun hızlanıyor */
             switch (genelsayac)
             {
                 case 5:
                     zaman.Interval = 85;
                     break;
                 case 10:
                     zaman.Interval = 82;
                     break;
                 case 15:
                     zaman.Interval = 79;
                     break;
                 case 20:
                     zaman.Interval = 76;
                     break;
                 case 25:
                     zaman.Interval = 73;
                     break;
                 case 30:
                     zaman.Interval = 70;
                     break;
                 case 35:
                     zaman.Interval = 67;
                     break;
                 case 40:
                     zaman.Interval = 64;
                     break;
                 case 45:
                     zaman.Interval = 61;
                     break;
                 case 50:
                     zaman.Interval = 58;
                     break;
                 case 55:
                     zaman.Interval = 55;
                     break;
                 case 60:
                     zaman.Interval = 52;
                     break;
                 case 65:
                     zaman.Interval = 49;
                     break;
                 case 70:
                     zaman.Interval = 46;
                     break;
                 case 75:
                     zaman.Interval = 43;
                     break;
                 case 80:
                     zaman.Interval = 40;
                     break;
                 case 85:
                     zaman.Interval = 36;
                     break;
                 case 90:
                     zaman.Interval = 33;
                     break;
                 case 95:
                     zaman.Interval = 30;
                     break;
                 case 100:
                     zaman.Interval = 27;
                     break;
                 case 105:
                     zaman.Interval = 24;
                     break;
                 case 110:
                     zaman.Interval = 21;
                     break;
                 case 115:
                     zaman.Interval = 18;
                     break;
                 case 120:
                     zaman.Interval = 15;
                     break;
                 case 125:
                     zaman.Interval = 12;
                     break;

             }


            //Darphanelerin can değerlerini yüzde şeklinde yazdırıyorum
             can1Yuzde.Text = can1.Value.ToString() + "%"; 
             can2Yuzde.Text = can2.Value.ToString() + "%";


          
       }


   


       private void Hareket(object sender, KeyEventArgs e)
       {


           /*oyuncu1 i hareket ettirmek için x ve y değerlerine karakterin x ve y değerlerini atıyorum sonra 
           klavyeden basılan tuşa ve konumun haritanın diğer tarafında ve dışında olmamasına dikkat ederek karakteri hareket ettiriyorum  */
            int o1x = oyuncu1.Location.X;
            int o1y = oyuncu1.Location.Y;
          
            if (e.KeyCode == Keys.A && o1x > 20)
            {
                o1x = o1x - 45;
            }

            if (e.KeyCode == Keys.D && o1x < 340)
            {
                o1x = o1x + 45;
            }

            oyuncu1.Location = new Point(o1x, o1y);



            /*oyuncu2 yi hareket ettirmek için x ve y değerlerine karakterin x ve y değerlerini atıyorum sonra 
            klavyeden basılan tuşa ve konumun haritanın diğer tarafında ve dışında olmamasına dikkat ederek karakteri hareket ettiriyorum  */
            int o2x = oyuncu2.Location.X;
            int o2y = oyuncu2.Location.Y;
       
            if (e.KeyCode == Keys.Left && o2x > 480)
            {
                o2x = o2x - 45;
            }

            if (e.KeyCode == Keys.Right && o2x < 800)
            {
                o2x = o2x + 45;
            }

            oyuncu2.Location = new Point(o2x, o2y);




            //F ve L aynı işlemleri yapıyor o yüzden sadece buna açıklamaları yazıyorum
            if (e.KeyCode == Keys.F) //F tuşuna basıldığında 
            {                
                ates.Visible = true; //ates pictureboxımı görünür yapıyorum
                atesTimer.Start();  //atestimerımı çalıştırıyorum ki yukarı doğru ilerlesin
            }
            if (e.KeyCode == Keys.L)
            {                
                ates2.Visible = true;
                ates2Timer.Start();
            }


     
        }





        private void atesTimer_Tick(object sender, EventArgs e)
        {
            //ateş 1 ve iki aynı işlemleri yapıyor o yüzden sadece buna açıklamaları yazıyorum
            ates.Top -= 25; //ateş 1 yani soldaki ateşin hareket hızı
            obirx = (oyuncu1.Location.X) + 12;  //obirx değişkenimi oyuncu 1 pictureboxımın hafif sağına yani aslında ortasına konumlandırıyorum
            //Çünkü:visual studio X i dediğinizde pictureboxın solundan Y si dediğinizde üstünden 0 noktalarını alıyor
            obiry = (oyuncu1.Location.Y) - 7; ////obirx değişkenimi oyuncu 1 pictureboxımın hafif altına yani aslında ortasına konumlandırıyorum
            if (ates.Top < -20) //eğer ates1 haritanın üstünden çıkarsa 
            {
                ates.Location = new Point(obirx, obiry); //atesi tekrardan oyuncu1 in ortasına konumlandırıyorum               
                ates.Visible = false; //Ates pictureboxımı görünmez yapıyorum
                atesTimer.Stop(); //atestimerımı durduruyorum
            }
        }


        private void ates2Timer_Tick(object sender, EventArgs e)
        {
            ates2.Top -= 25;
            oikix = (oyuncu2.Location.X) + 12;
            oikiy = (oyuncu2.Location.Y) - 7;
            if (ates2.Top < -20)
            {
                ates2.Location = new Point(oikix, oikiy);               
                ates2.Visible = false;
                ates2Timer.Stop();
            }
        }





      
    }
}
