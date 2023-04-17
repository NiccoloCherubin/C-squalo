<<<<<<< HEAD:ITERAZIONI/LottoVenezia/Program.cs
﻿using System;

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
            int[] fortunelli = new int[5]; // numeri fortunati inseriti dall'utente
            int estratto;
            int puntata;
            bool esiste = false;
            int i = 0;
            const int max = (int)Ruote.Nazionale;
            int cont = 0; // conta numeri indovinati
            int scelta; // scelta della ruota
            bool valido;
            for (int k = 0; k <= max; k++)
            {
                Console.WriteLine("{0} {1}", k, (Ruote)k);
            }
            // scelta della ruota
            do
            {
                Console.WriteLine("che ruota scegli?");
                valido = Int32.TryParse(Console.ReadLine(), out scelta);
            }
            while (scelta < 0 || scelta > max);
            Console.Clear();
            // scelta numeri
            for (int k = 0; k < fortunelli.Length; k++)
            {
                do
                {
                    Console.WriteLine("Numero {0}", k + 1);
                    fortunelli[k] = Int32.Parse(Console.ReadLine());
                }
                while (fortunelli[k] < 0 || fortunelli[k] > 90);

            }
            // puntata
            do
            {
                Console.WriteLine("Inserisci puntata");
                puntata = Int32.Parse(Console.ReadLine());
            } while (puntata < 0);
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
            // controlla valori inseriti con quelli della ruota
            for (int k = 0; k < fortunelli.Length; k++)
            {
                for (int o = 0; o < fortunelli.Length; o++)
                    if (matrix[scelta, o] == fortunelli[k])
                    {
                        cont++;
                    }
            }
            switch (cont)
            {
                case 0:
                    puntata *= 0;
                    break;
                case 1:
                    puntata *= 11;
                    break;
                case 2:
                    puntata *= 250;
                    break;
                case 3:
                    puntata *= 4500;
                    break;
                case 4:
                    puntata *= 120000;
                    break;
                case 5:
                    puntata *= 6000000;
                    break;
            }
            Console.WriteLine("Hai vinto {0} euro", puntata);
            Console.ReadLine();
        }
    }
=======
﻿using System;

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
>>>>>>> e75f1797087f0a98317c658fbd0f083a71a4d68e:ITERAZIONI/Lotto/Program.cs
}