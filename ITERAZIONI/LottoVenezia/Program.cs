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
            int[] fortunelli = new int[5]; // numeri giocati            
            byte scelta; // scelta della ruota
            byte contatore = 0; // conta numeri indovinati
            ulong puntata;
            bool valido;

            for (int k = 0; k < (int)Ruote.Nazionale; k++)
            {
                Console.WriteLine($"{k} {(Ruote)k}");
            }
                do
                {
                Console.WriteLine("Scegli una ruota");
                scelta = Byte.Parse(Console.ReadLine());
            }
            while (scelta < 0 || scelta > (int)Ruote.Nazionale);
            Console.Clear();
            do
            {
                Console.WriteLine("Numero {0}", i + 1);
                fortunelli[i] = Int32.Parse(Console.ReadLine());
                if (fortunelli[i] > 0 && fortunelli[i] < 90)
                {
                    ++i;
                }
            } while (i != 5);
            i = 0;
            // inserimento puntata
            Console.WriteLine("Mettere puntata");
            valido = ulong.TryParse(Console.ReadLine(), out puntata);

            for (int k = 0; k <= max; k++)
            {
                Console.Write(" {0,-10}: ", (Ruote)k); // Scrivo il nome della ruota 
                do
                {
                    estratto = random.Next(1, 91);
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
