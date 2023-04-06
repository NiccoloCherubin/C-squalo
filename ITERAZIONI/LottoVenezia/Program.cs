using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LottoVenezia
{
    class Program
    {
        enum Ruote
        {
            Venezia, Bari, Cagliari, Firenze, Genova, Milano, Napoli, Palermo, Roma, Torino, Nazionale
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numeri = new int[5];
            int estratto;
            bool esiste = false;
            int i = 0;
            const int max = (int)Ruote.Nazionale;
            for (int k = 0; k < max; k++)
            {
                Console.WriteLine("Ruota di {0}", (Ruote)k); // Scrivo il nome della ruota 
                do
                {
                    estratto = random.Next(0, 91);
                    for (int j = 0; j < i && !esiste; j++)
                    {
                        esiste = estratto == numeri[j]; // quando trova numero già presente nell'array esce dal ciclo
                    }
                    if (!esiste)
                    {
                        numeri[i] = estratto;
                        i++; // numeri presenti nell'array
                    }
                    else
                    {
                        esiste = false;
                    }
                    if( i == numeri.Length)
                    {
                        Array.Sort(numeri); // ordino l'array
                        // stampa array
                        foreach(int n in numeri)
                        {
                            Console.Write("{0} ",n);
                        }
                    }
                } while (i < 5);
                i = 0; // rinizializzazione della variabile
                Console.WriteLine("\n==========================="); // per saperare gli output
            }
            Console.ReadLine();
        }
    }
}
