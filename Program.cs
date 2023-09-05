using System;
using System.Globalization;

namespace csharp101
{
    class Program
    {
        public static void Main(string[] args) {
            Calisan calisan1 = new Calisan
            {
                Ad = "Ayse",
                Soyad = "Demir",
                No = 1001,
                Departman = "İnsan Kaynakları",

            };
            calisan1.CalisanBilgileri();
            Calisan calisan2 = new Calisan("Ahmet", "Çelik", 1002, "Satın Alma");
            calisan2.CalisanBilgileri();
            
        }
      
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        public Calisan() {}
        public Calisan(string ad, string soyad, int no, string departman) { 
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        
        }
        public void CalisanBilgileri()
        {
            Console.WriteLine("Calisanin adi : {0}", Ad);
            Console.WriteLine("Calisanin soyadi : {0}", Soyad);
            Console.WriteLine("Calisanin numarasi : {0}", No);
            Console.WriteLine("Calisanin departmani : {0}", Departman);

        }
    }

}
