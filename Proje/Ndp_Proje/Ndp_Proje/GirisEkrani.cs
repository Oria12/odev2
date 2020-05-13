
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
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }


        

       
        struct gelistirici //gelistirici adında bir struct oluşturuyorum 
        { 

            //Struct içerisine adsoyad, okulnumarasi, gelistirdigioyunsayisi şeklinde tanımlamalar yapıyorum
            public string adsoyad;
            public string okulnumarasi;
            public int gelistirdigioyunsayisi;

        }


        private void GirisEkrani_Load(object sender, EventArgs e)
        {
            lbladsoyad.Visible = false;
            lblnumara.Visible = false;
            lbloyun.Visible = false;
            btnOyna.Enabled = false;
            lblOyuncu1.Visible = false;
            lblOyuncu2.Visible = false;
            lblCevap.Visible = false;
            nasilOynanirPanel.Visible = false;
        }



        private void btnOyna_Click(object sender, EventArgs e)
        {
            GirisEkrani.ActiveForm.Hide();   //GirisEkrani formumu yani giriş sayfasını gizliyorum
            OyunEkrani oyunformu = new OyunEkrani();   //OyunEkrani ismindeki form sayfama oyunformu ismini veriyorum
            oyunformu.ShowDialog();   //oyunformu ismini verdiğim OyunEkrani form sayfamı açıyorum
        }

        private void btnNasilOynanir_Click(object sender, EventArgs e)
        {
            btnNasilOynanir.Visible = false;
            nasilOynanirPanel.Visible = true;
        }

        private void btnGelistirici_Click(object sender, EventArgs e)
        {
            
            //Geliştirici butonuna tıklandığında structtaki veri tiplerini çekmek istediğim için ekstra bir metot kullanmıyorum
            gelistirici o;  //Struct içerisindeki değişkenleri artık o parametresi ile çağırıyorum
            o.adsoyad = "Orçun Holta";
            o.okulnumarasi = "B191200300";
            o.gelistirdigioyunsayisi = 2;

            //Geliştiriciyi göstermek için yukarıda tanımlanan verileri labellara eşitliyorum
            lbladsoyad.Text = ("Adı Soyadı: " + o.adsoyad);
            lblnumara.Text = ("Okul Numarası: " + o.okulnumarasi);
            lbloyun.Text = ("Geliştirdiği Oyun Sayısı: " + o.gelistirdigioyunsayisi);


            //Geliştirici bilgileri gözüksün diye labelları görünür hale getiriyorum
            lbladsoyad.Visible = true;
            lblnumara.Visible = true;
            lbloyun.Visible = true;

        }




        private void btnKaydet_Click(object sender, EventArgs e)
        {

            KimOynuyor ko = new KimOynuyor();  //KimOynuyor classını çağırabilmek için ko isimli bir değişken tanımladım

            ko.oyuncu1 = oyuncu1Adi.Text;  //Textboxdaki veriyi oyuncu1 değişkenime gönderiyorum
            string oyuncu1 = ko.oyuncu1getir();  //Değişkendeki veriyi metotum ile geri döndürüyorum
            lblOyuncu1.Text = ko.oyuncu1getir();  //Metottaki geriye dönen veriyi labela atıyorum

            ko.oyuncu2getir = oyuncu2Adi.Text;
            string _oyuncu2 = ko.oyuncu2getir;
            lblOyuncu2.Text = ko.oyuncu2getir;




            //Doğru Cevap için if else ile birlikte try catch kullanıldı
            try
            {
                int cevap = Convert.ToInt32(btnCevap.Text);
                if (cevap == 8)
                {
                    lblCevap.Text = "Doğru cevap verdiniz, oyuna giriş yapabilirsiniz";
                    lblOyuncu1.Visible = true;
                    lblOyuncu2.Visible = true;
                    lblCevap.Visible = true;
                    btnOyna.Enabled = true;
                    lblCevap.Location = new Point(200, 210);
                }
                else 
                {
                    lblCevap.Visible = true;
                    lblCevap.Text = "Yanlış cevap verdiniz";
                    lblCevap.Location = new Point(322, 148);
                }
            }
          
            catch (FormatException) //Harf girmeye çalışılırsa
            {
                lblCevap.Visible = true;
                lblCevap.Text = "Lütfen sayısal bir değer giriniz";
                lblCevap.Location = new Point(305, 148);
            }
            catch (OverflowException) //Çok yüksek bir değer girmeye çalışılırsa
            {
                lblCevap.Visible = true;
                lblCevap.Text = "Çok yüksek yanlış bir değer girdiniz";
                lblCevap.Location = new Point(285, 148);
            }
                         
            catch (Exception) //Diğer tanımlamadığımız durumlarda
            {
                lblCevap.Visible = true;
                lblCevap.Text = "Yanlış değer girdiniz!";
                lblCevap.Location = new Point(318, 148);
            }


        }

        






    }
}
