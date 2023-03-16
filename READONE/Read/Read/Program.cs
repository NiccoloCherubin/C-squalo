using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tasto;
            string lettere = "", numeri = "";
            do
            {                
                tasto = Console.Read();
                if (tasto > 96 && tasto < 123)
                {
                    lettere = lettere + Convert.ToChar(tasto);
                }
                else if (tasto > 48 && tasto < 59)
                {
                    numeri = numeri + Convert.ToChar(tasto);
                }
            } while (tasto != 13);
            Console.WriteLine("Ecco i caratteri {0}", lettere);
            Console.WriteLine("Ecco i numeri {0}", numeri);
            Console.ReadLine(); // salta line feed
            Console.ReadLine(); // serve per bloccare programma
        }
    }
}
