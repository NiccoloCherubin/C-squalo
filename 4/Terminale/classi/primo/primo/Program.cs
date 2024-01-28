using ClasseRettangolo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rettangolone oggetto = new Rettangolone();
            oggetto.SetBase(5);
            oggetto.SetAltezza(7);
            Console.WriteLine(oggetto.GetPerimetro());
            Console.WriteLine(oggetto.GetArea());
            Console.ReadKey();
            
        }
    }
}
