using System;
using System.Globalization;

namespace csharp101
{
    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim { get { return isim; } set {  isim = value; } }  
        public string Soyisim { get { return soyisim; } set {  soyisim = value; } }
        public int OgrenciNo { get {  return ogrenciNo; } set {  ogrenciNo = value; } } 
        public int Sinif { get { return sinif; } 
         set {
                if (value < 1)
                {
                    Console.WriteLine("Sinif deðeri 1'den küçük olamaz.");
                    this.Sinif = 1;
                }
                else
                    sinif = value;
            }
        }

        public Ogrenci() { }
        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            this.isim = isim;
            this.soyisim = soyisim; 
            this.sinif = sinif;
            this.ogrenciNo = ogrenciNo;
        }
        public void OgrenciBilgileri()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("Ogrenci adi:     {0}",this.isim);
            Console.WriteLine("Ogrenci soyadi:     {0}", this.soyisim);
            Console.WriteLine("Ogrenci numarasý:     {0}", this.ogrenciNo);
            Console.WriteLine("Ogrenci sinifi:     {0}", this.sinif);
        }
        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1; 
        }
        public void SiniDusur()
        {   
            this.Sinif = this.Sinif - 1;
        }

    }
}