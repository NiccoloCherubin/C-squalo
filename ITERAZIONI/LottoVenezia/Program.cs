using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LottoVenezia
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numeri = new int[5];
            int[] scelte = new int[5];
            int estratto;
            int cont = 0;
            bool esiste = false, trovato = false;
            int i = 0, j = -1;
            int puntata;
            do
            {
                Console.Clear();
                Console.WriteLine("Scegli numeri da 1 a 90");
                j++;
                scelte[j] = Convert.ToInt32(Console.ReadLine());
            } while (scelte[j] < 1 || scelte[j] > 90 || j != 4);
            do
            {
                Console.WriteLine("Metti una puntata");
                puntata = Convert.ToInt32(Console.ReadLine());
            } while (puntata <= 0);
            do
            {
                estratto = random.Next(1, 91);
                for (j = 0; j < i && !esiste; j++)
                {
                    esiste = estratto == numeri[j];
                    trovato = scelte[cont] == numeri[j];
                }
                if (!esiste)
                {
                    numeri[i] = estratto;
                    Console.WriteLine(numeri[i]);
                    i++;
                }
                else
                {
                    esiste = false;
                }
                if (trovato)
                {
                    cont++;
                }
                else
                {
                    trovato = false;
                }
            } while (i < 5);
            switch (cont)
            {
                case 0:
                    Console.WriteLine("Non hai indovinato nessun numero");
                    puntata *= 0;
                    break;
                case 1:
                    Console.WriteLine("Hai indovinato un numero");
                    puntata *= 11;
                    break;
                case 2:
                    Console.WriteLine("Hai indovinato due numeri");
                    puntata *= 250;
                    break;
                case 3:
                    Console.WriteLine("Hai indovinato tre numeri");
                    puntata *= 4500;
                    break;
                case 4:
                    Console.WriteLine("Hai indovinato quattro numeri");
                    puntata *= 120000;
                    break;
                case 5:
                    Console.WriteLine("Hai indovinato tutti i numeri");
                    puntata *= 6000000;
                    break;
            }
            Console.WriteLine("Hai vinto {0}", puntata);
            Console.ReadLine();
        }
    }
}
