using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verifica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dizionario = new string[3];
            string frase;
            string buffer = ""; // per memorizzare parole
            int parole = 0; // conta parole
            bool trovato = false; // per vedere se parola nel dizionario
            do
            {
                Console.WriteLine("Inserisci una frase");
                frase = Console.ReadLine();
                frase += " "; // aggiungo uno spazio per contare anche l'ultima parola
            } while (frase == " "); // controllo che non prema invio per sbaglio
            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] != ' ')
                {
                    buffer += frase[i];
                }
                else
                {

                    // verifico se la parola è nel dizionario
                    for (int j = 0; j < dizionario.Length && !trovato; j++) // esco dal for appena trovo la parola
                    {
                        trovato = dizionario[j] == buffer;
                    }
                    if (trovato == false)
                    {
                        dizionario[parole] = buffer; // inserimetno parola nel dizionario
                    }
                    else
                    {
                        trovato = false; // rinizializzazione variabile
                    }
                }
            }
            // stampa dizionario            
            {
                for (int i = 0; i < parole; i++)
                {
                    Console.WriteLine("La parola numero {0}  del dizionario è {1}", i + 1, dizionario[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
