namespace csharp101
{
    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }
        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string Departman { get => departman; set => departman = value; }

        private string isim;
        private string soyisim;
        private string departman;

        static Calisan()
        {
            calisanSayisi = 0; //calisan sýnýfýndan ilk nesne oluþturulduðu zaman 1 kere çalýþýr.

        }
        public Calisan()
        { }
        public Calisan(string isim, string soyisim, string departman)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.departman = departman;
            calisanSayisi++; //her çalýþan nesnesi oluþunca çalýþan sayýsý artar. bu þekilde direkt olarak calisanSayisi artacaktýr ve eriþildiðinde güncel deðer gelecektir.

        }

        public void CalisanBilgileri()
        {
            Console.WriteLine("Calisanin adi : {0}", Isim);
            Console.WriteLine("Calisanin soyadi : {0}", Soyisim);
            Console.WriteLine("Calisanin departmani : {0}", Departman);

        }


    }
}
