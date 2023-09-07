using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_OOP
{
    public class Bitkiler : Canlılar
    {
        protected void Fotosentez()
        {
            Console.WriteLine("Bitkiler fotosentez yapar");
        }
    }
    public class TohumluBitkiler: Bitkiler
    {
        public TohumluBitkiler() { 
            base.Fotosentez();
            
        }
        public void TohumluCogalma()
        { Console.WriteLine("Tohumla çoğalırlar."); }
    }
    public class TohumsuzBitki : Bitkiler
    {
        public TohumsuzBitki()
        {
            base.Fotosentez();

        }
        public void Tohumsuz() { Console.WriteLine("Sporla cogalır."); }
    }
}
