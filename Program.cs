using System;
using System.Globalization;

namespace csharp101
{
    class Program
    {
        public static void Main(string[] args) {
            Console.WriteLine("Calisan sayisi : {0}", Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Ayse", "Demir", "İnsan Kaynakları");

           
            
            Calisan calisan2 = new Calisan("Ahmet", "Çelik", "Satın Alma");
            Console.WriteLine("Calisan sayisi : {0}", Calisan.CalisanSayisi);

            Calisan calisan3 = new Calisan("Burcu", "Yılmaz", "İnsan Kaynakları");
            Console.WriteLine("Calisan sayisi : {0}", Calisan.CalisanSayisi);


            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Lale";
            ogrenci.Soyisim = "Kara";
            ogrenci.Sinif = 4;
            ogrenci.OgrenciNo = 153;

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileri();

            Ogrenci ogrenci1 = new Ogrenci("Deniz", "Demir", 45, 1);
            ogrenci1.OgrenciBilgileri();
            ogrenci1.SiniDusur();

        }
      
    }
    //class Calisan
    //{
    //    public string Ad;
    //    public string Soyad;
    //    public int No;
    //    public string Departman;
    //    public Calisan() {}
    //    public Calisan(string ad, string soyad, int no, string departman) { 
    //        this.Ad = ad;
    //        this.Soyad = soyad;
    //        this.No = no;
    //        this.Departman = departman;
        
    //    }
    //    public void CalisanBilgileri()
    //    {
    //        Console.WriteLine("Calisanin adi : {0}", Ad);
    //        Console.WriteLine("Calisanin soyadi : {0}", Soyad);
    //        Console.WriteLine("Calisanin numarasi : {0}", No);
    //        Console.WriteLine("Calisanin departmani : {0}", Departman);

    //    }
    //}

}
