using System;

namespace BreakFrase
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxFrase = 80, maxRiga = 20;
            int line;
            string frase;
            do
            {
                Console.WriteLine("Inserisci la frase: ");
                frase = Console.ReadLine();
            } while (frase == "");
            if (frase.Length > maxFrase)
            {
                frase = frase.Remove(maxFrase);
            }
            Console.WriteLine(frase);
            Console.WriteLine("Inserisci il numero massimo di caratteri per riga: ");
            while (!int.TryParse(Console.ReadLine(), out line) || line < 1 || line > maxRiga)
            {
                Console.WriteLine("Inserisci un valore corretto: ");
            }
            Console.WriteLine();
            WriteWrap(frase, line);
            Console.ReadLine();
        }
        // Definizione: stampa la frase e la divide in righe di massimo max parole
        // Parametri:
        // Input: stringa contenente la frase, lunghezza massima delle right
        // Output: void
        static private void WriteWrap(string frase, int max)
        {
            int l = 0;
            foreach (string parola in RemoveSpace(frase).Split(' '))
            {
                l += parola.Length;
                if (l > max)
                {
                    l = parola.Length;
                    Console.WriteLine();
                }
                l++;
                Console.Write("{0} ", parola);
            }
            Console.WriteLine();
        }
        // Definizione: rimuove gli spazi superflui
        // Parametri:
        // Input: stringa contenente la frase
        // Output: stringa contenente la frase senza spazi
        static private string RemoveSpace(string frase)
        {
            frase = frase.Trim();
            int i = frase.IndexOf("  ");
            while (i != -1)
            {
                frase = frase.Remove(i, 1);
                i = frase.IndexOf("  ");
            }
            return frase;
        }
    }
}