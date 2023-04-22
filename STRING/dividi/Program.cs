using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividiFrase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase;


            const short caratteri = 34;
            do
            {
                Console.WriteLine("Inserisci una frase");
                frase = Console.ReadLine();
            } while (string.IsNullOrEmpty(frase)); // guardo se dentro frase c'è qualcosa
            // separazione frase
            Separa(frase, caratteri);
            Console.ReadLine();
        }

        // separa stringa
        // input: stringa e costante
        // output: niente
        static public void Separa(string frase, short caratteri)
        {
            string buffer;
            // divisione frase
            do
            {
                buffer = frase.Substring(0, caratteri);
                Console.WriteLine(buffer);
                frase = frase.Remove(0, caratteri);
            } while (frase.Length > caratteri);
            buffer = frase.Substring(0, frase.Length);
            buffer = buffer.Trim(); // togliere spazi in eccesso
            Console.WriteLine(buffer); // stampa stringa rimanente
        }
    }
}