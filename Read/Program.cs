using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] parole = new string[50];
            string[] numeriP = new string[50];
            int contaParole = 0,  contaNumeri = 0;
            string frase;
            // leggere da tastiera e distinguere numeri da caratteri
            char tasto;
            string numeri = "", lettere = "";
            Console.WriteLine("inserire frase");
            frase = Console.ReadLine();
            do
            {
                tasto = Convert.ToChar(frase);
                for (int i = 0; i < frase.Length; i++)
                {
                    if (Char.IsLetter(tasto))
                    {
                        if (frase[i] == ' ')
                        {
                            parole[contaParole] = lettere;
                            lettere = "";
                            contaParole++;
                        }
                        else
                        {
                            lettere = lettere + Convert.ToChar(tasto);
                        }
                    }
                    else if (Char.IsDigit(tasto))
                    {
                        if (frase[i] == ' ')
                        {
                            parole[contaNumeri] = numeri;
                            numeri = "";
                            contaNumeri++;
                        }
                        else
                        {
                            numeri = numeri + Convert.ToChar(tasto);
                        }
                    }
                    Char.IsLetterOrDigit(tasto);
                }
            } while (tasto != 13);
            Console.WriteLine("Ecco i caratteri {0}", lettere);
            Console.WriteLine("Ecco i numeri {0}", numeri);
            Console.ReadLine(); // salta line feed
            Console.ReadLine(); // serve per bloccare programma
        }
    }
}