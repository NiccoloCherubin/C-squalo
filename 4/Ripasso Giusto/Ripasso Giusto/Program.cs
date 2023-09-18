using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ripasso_Giusto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeriInteri;
            int dimensione = 10;
            CreaVettore(out numeriInteri, dimensione);
            Console.WriteLine(numeriInteri.Length);
            Visualizza(numeriInteri);
            Console.WriteLine();
            EstendiVettore(ref numeriInteri, 10);
            Console.WriteLine(numeriInteri.Length);
            Visualizza(numeriInteri);
            //Console.WriteLine("************");
            //Console.WriteLine(numeriInteri[0]);
            Console.ReadLine();
        }
        static void CreaVettore(out int[] numeriInteri, int dimensione)
        {            
            numeriInteri = new int[dimensione];
            RiempiVettore(numeriInteri);
        }
        static void Visualizza(int[] numeriInteri)
        {
            //numeriInteri[0] = 99;
            for (int i = 0; i < numeriInteri.Length; i++)
            {
                Console.Write(numeriInteri[i] + " ");
            }
        }
        static void EstendiVettore(ref int[] numeriInteri, int estensione)
        {
            int[] numeri = new int[numeriInteri.Length + estensione];
            Random casuale = new Random();
            for (int i = 0; i < numeriInteri.Length; i++)
            {
                numeri[i] = numeriInteri[i];
            }
            numeriInteri = numeri;
            RiempiVettore(numeriInteri);
        }
        static void RiempiVettore(int[] numeriInteri)
        {
            int estratto;
            bool esiste = false;
            int i = 0;
            Random random = new Random();
            do
            {
                estratto = random.Next(1, 50);
                for (int j = 0; j < i && !esiste; j++)
                {
                    esiste = estratto == numeriInteri[j]; // quando trova numero già presente nell'array esce dal ciclo
                }
                if (!esiste)
                {
                    numeriInteri[i] = estratto;
                    i++; // numeri presenti nell'array
                }
                else
                {
                    esiste = false;
                }
            } while (i < numeriInteri.Length);
        }
    }
}
