using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generatore_numeri
{
    class Program
    {
        static void Main(string[] args)
        {
            //generare 10 numeri casuali da 0 a 9 e stampare numeri mai usciti
            int[] valori = new int[10];
            int j = 0;
            Random random = new Random();
            for (int i = 0; i < valori.Length; i++)
            {
                j = random.Next(0, 10);
                Console.WriteLine(j);
                valori[j] = 1; // per mettere "true e false" nellla cella corrispondente al numero
            }
            for (int i = 0; i < valori.Length; i++)
            {
                if (valori[i] == 0) // verifico se true o false
                {
                    Console.WriteLine("Non è uscito il numero {0}", i); // se false stampo questo
                }
            }
            Console.ReadLine();
        }
    }
}
