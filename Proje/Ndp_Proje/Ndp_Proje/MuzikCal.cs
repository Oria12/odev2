
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
using System.Media; //Müziği çaldırabilmek için Media kütüphanesini çağırıyoruz

namespace Ndp_Proje
{
    public class MuzikCal
    {

        public void Cal() //Cal adında bir method oluşturduk ve metodun içerisine işlemler atadık.
        {

            SoundPlayer ses = new SoundPlayer();  //System Media kütüphanesinden SoundPlayer classına tanımlama yapıyoruz
            string yol = Application.StartupPath + "//Ses/arkaplanMuzik.wav";  //Müziğin dizinde bulunduğu konumu yol değişkenine atadık
            ses.SoundLocation = yol;  //Konumun yol olduğunu gösterdik
            ses.Play(); //Müziği başlattık

        }


    }
}
