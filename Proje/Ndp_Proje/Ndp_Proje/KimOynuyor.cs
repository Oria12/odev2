
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
    class KimOynuyor
    {

        //2 şekilde get set uygulandı
        public string oyuncu1 { get; set; } 
        private string _oyuncu2;


        public string oyuncu1getir()
        {
            return oyuncu1;
        }


        public string oyuncu2getir
        {
            get { return _oyuncu2; }

            set { _oyuncu2 = value; }
        }


    }
}




 