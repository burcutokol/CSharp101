namespace Practices
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine((int)Gunler.Pazar);
            int Sicaklik = 32;
            if(Sicaklik <= (int)HavaDurumu.Soguk) {
                Console.WriteLine("Dışarıya çıkmak için havanın ısınmasını bekle.");
            }
            else if(Sicaklik > (int)HavaDurumu.Sıcak)
            {
                Console.WriteLine("Hava cok sıcak.");
            }
            else if(Sicaklik < (int)HavaDurumu.CokSıcak && Sicaklik >= (int)HavaDurumu.Normal)
            {
                Console.WriteLine("Hadi dışarı çıkalım");
            }
        }

    }
    enum Gunler //ardışık devam eder
    {
        Pazartesi = 1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi, //24 olsaydı cuma 5, pazar 25 olacaktı.
        Pazar,
    }
    enum HavaDurumu
    {
        Soguk =5,
        Normal =20,
        Sıcak =25,
        CokSıcak=30,
    }
}