using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_OOP
{
    public class Hayvanlar : Canlılar
    {
        public void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon yapar.");
        }
    }
    public class Surungen : Hayvanlar
    {
        public void Surunme()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket ederler.");    
        }
    }
    public class Kuslar : Hayvanlar 
    {
        public void Ucma() {
            Console.WriteLine("Kuslar ucar.");
        }
    }
}
