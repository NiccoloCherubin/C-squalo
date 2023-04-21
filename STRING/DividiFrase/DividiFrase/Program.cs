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
        static public void Separa(string frase, short caratteri)
        {
            string buffer = "";
            for (int i = 0; i < frase.Length; i++)
            {
                if (buffer.Length == caratteri)
                {
                    Console.WriteLine(buffer);
                    buffer = "";
                }
                else
                {
                    buffer += frase[i];
                }
            }
            Console.WriteLine(buffer); // scrivo il rimanente
        }
    }
}
