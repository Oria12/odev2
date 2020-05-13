
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ndp_Proje
{
    public class Kazandi
    {

        public string mesaj;

        //KURUCU FONKSİYON
        public Kazandi(string msg)
        {
            this.mesaj = msg;           
        }


        //METOT
        public void kazandimetot()
        {

            //Oyun bittiğinde gelecek bir dialog oluşturuyorum. Dialogun cevabı evet ise oyunu tekrardan başlatıyorum hayır ise oyundan çıkartıyorum.
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Tebrikler " + mesaj, "Oyun Bitti", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                OyunEkrani oyun = new OyunEkrani();   //OyunEkrani ismindeki form sayfama oyun ismini veriyorum
                oyun.ShowDialog();   //oyun ismini verdiğim OyunEkrani form sayfamı açıyorum    
            }
            else
            {
                Application.Exit();
            }      


        }

    }
}
