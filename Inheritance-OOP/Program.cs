namespace Inheritance_OOP
{
    class Program
    {
        public static void Main(string[] args) { 
        TohumluBitkiler th = new TohumluBitkiler();
            th.TohumluCogalma();
            th.Solunum();
            th.Beslenme();
            Console.WriteLine("***********************");

        Kuslar kuslar = new Kuslar();
            kuslar.Beslenme();
            kuslar.Ucma();
            kuslar.Solunum();   
            
        }
    }
}
