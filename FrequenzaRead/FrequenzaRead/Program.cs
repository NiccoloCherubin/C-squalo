using System;
using System.Runtime.CompilerServices;

namespace trovaParola
{
    class Program
    {
        static void Main(string[] args)
        {
            int tasto;
            int indice;
            char carattere;
            int[] contatore = new int[28]; // 26 lettere, 1 numeri, 1 altri caratteri
            Console.WriteLine("Inserisci una frase");
            do
            {
                tasto = Console.Read();
                if (Char.IsLetter(Convert.ToChar(tasto)))
                {
                    indice = tasto - 65;
                    contatore[indice]++;
                }
                else if (Char.IsDigit(Convert.ToChar(tasto)))
                {
                    contatore[26]++; // per numeri
                }
                else if (tasto != 32)
                {
                    contatore[27]++; // per caratteri speciali
                }
            } while (tasto != 13);
            for (int i = 0; i < contatore.Length ; i++) // -1 perché sennò mi scriveva la /
            {
                if (contatore[i] != 0)
                {
                    if (i < 26)
                    {
                        carattere = Convert.ToChar(i + 65);
                        Console.WriteLine("Hai scritto {0} volte la lettera {1}", contatore[i], carattere);
                    }
                    else if (i == 26)
                    {
                        Console.WriteLine("Hai scritto {0} volte dei numeri", contatore[i]);
                    }
                    else
                    {
                        Console.WriteLine("Hai scritto {0} volte caratteri speciali", contatore[i]);
                    }
                }
            }
            Console.ReadLine(); // ripiristana LF
            Console.ReadLine(); // ferma programma
        }
    }
}
