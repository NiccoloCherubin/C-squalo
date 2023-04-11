using System;

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
            int[,] matrix = new int[(int)Ruote.Nazionale + 1, 5];            
            int estratto;
            bool esiste = false;
            int i = 0;
            const int max = (int)Ruote.Nazionale;
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
                    if (i == numeri.Length)
                    {
                        Array.Sort(numeri); // ordino l'array                        
                        // riempimento matrice
                        for (int o = 0; o < matrix.GetLength(1); o++)
                        {
                            matrix[k, o] = numeri[o];
                        }
                    }
                } while (i < 5);
                i = 0; // rinizializzazione della variabile

                // stampa matrice                
                for (int p = 0; p < matrix.GetLength(1); p++)
                {
                    Console.Write("{0,2} ", matrix[k, p]);
                }
                Console.Write("||");
                Console.WriteLine("\n=========================== //"); // per separare gli output
                
            }
            Console.ReadLine();
        }
    }
}