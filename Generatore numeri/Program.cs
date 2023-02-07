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
            int conter = 0;
            Random random = new Random();
            for (int i = 0; i < valori.Length; i++)
            {
                conter = valori[i] = random.Next(0, 10);
                Console.WriteLine(valori[i]);
            }

            Console.ReadLine();
        }
    }
}
