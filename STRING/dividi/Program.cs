using System;

namespace BreakFrase
{
    class Program
    {
        static void Main(string[] args)
        {
            short parole = 0;
            const sbyte maxParole = sbyte.MaxValue; // dubito possa metterne di più con 80 caratteri massimo 
            string[] pp = new string[maxParole]; // contiene tutte parole
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
            WriteWrap(frase, line, ref parole, pp);
            string[] frasi = FrasiMaker(pp, frase, line);
            Giustifica80(frasi);
            Console.ReadLine();
        }
        // Definizione: stampa la frase e la divide in righe di massimo max parole
        // Parametri:
        // Input: stringa contenente la frase, lunghezza massima delle right
        // Output: array di stringhe con tutte le parole
        static private string[] WriteWrap(string frase, int max, ref short parole, string[] pp)
        {
            int l = 0;
            foreach (string parola in RemoveSpace(frase).Split(' '))
            {
                l += parola.Length; // l = lunghezza
                if (l > max)
                {
                    l = parola.Length;
                    Console.WriteLine();
                }
                l++;
                Console.Write("{0} ", parola);
                pp[parole] = parola; // salvataggio parole
                parole++; // numero parole

            }
            Console.WriteLine();
            return pp;

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
        static private string[] FrasiMaker(string[] pp, string frase, int line)
        {
            string[] frasi = new string[pp.Length];
            int cont = 0;
            //frasi[cont] = Convert.ToString(frase[0]);
            for (int i = 0; i < frasi.Length; i++)
            {
                frasi[cont] = frasi[cont] + pp[i] + " ";
                if (pp[i] == null)
                {
                    break;
                }
                else if(frasi[cont].Length + pp[i].Length > line)
                {
                    cont++;
                    i++;
                }


            }
            return frasi;
        }

        static private string[] Giustifica80(string[] pp)
        {

            return pp;
        }
    }
}