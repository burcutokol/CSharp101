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
            calisanSayisi = 0; //calisan s�n�f�ndan ilk nesne olu�turuldu�u zaman 1 kere �al���r.

        }
        public Calisan()
        { }
        public Calisan(string isim, string soyisim, string departman)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.departman = departman;
            calisanSayisi++; //her �al��an nesnesi olu�unca �al��an say�s� artar. bu �ekilde direkt olarak calisanSayisi artacakt�r ve eri�ildi�inde g�ncel de�er gelecektir.

        }

        public void CalisanBilgileri()
        {
            Console.WriteLine("Calisanin adi : {0}", Isim);
            Console.WriteLine("Calisanin soyadi : {0}", Soyisim);
            Console.WriteLine("Calisanin departmani : {0}", Departman);

        }


    }
}
