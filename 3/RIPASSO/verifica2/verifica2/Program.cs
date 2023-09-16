using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verifica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero; // contiene numero random
            int[] frequenza = new int[10]; // per frequenza numeri
            int resto; // per vedere cifra
            int volte;
            const int min = 1, max = 101;
            Random random = new Random();
            volte = random.Next(min, max);
            for (int i = 0; i < volte; i++)
            {
                numero = random.Next(min, max);
                Console.WriteLine(numero);
                while (numero != 0)
                {
                    resto = numero % 10;
                    frequenza[resto]++;
                    numero = numero /10;
                }
            }
            // stampa frequenza
            for(int i = 0; i <  frequenza.Length; i++)
            {
                if (frequenza[i] != 0)
                {
                    Console.WriteLine("La frequenza del numero {0} è di {1}", i, frequenza[i]);
                }
            }
            Console.ReadLine();

        }
    }
}
