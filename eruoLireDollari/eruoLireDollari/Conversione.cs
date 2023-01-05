using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eruoLireDollari
{
    internal class Conversione
    {
        static void Main(string[] args)
        {
            double euro, lire, dollari;
            const double euroLire = 1936.27, euroDollari = 1.03;
            Console.WriteLine("Immettere saldo del conto corrente in euro.");
            euro = Convert.ToDouble(Console.ReadLine()); //convert to double per avere cifre dopo la virgola
            lire = euro * euroLire;
            Console.WriteLine("saldo in lire = " + lire);
            dollari = euroDollari * euro;
            Console.WriteLine("Saldo in dollari = " + dollari);
            Console.WriteLine("Premere invio per continuare");
            Console.ReadLine();
        }
    }
}
