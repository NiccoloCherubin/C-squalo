using System;

namespace trovaParola
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dizionario = new string[3];
            string buffer = "";
            int tasto, paroleTrovate = 0;
            bool trovato;
            Console.Write("Inserisci una frase: ");
            do
            {
                // Leggo un carattere dal buffer dello stream di input
                tasto = Console.Read();
                // Controllo se è uno spazio o un carriedge return. Controllo poi se il buffer è vuoto
                if ((tasto == 32 || tasto == 13) && buffer != "")
                {
                    // Trasformo la parola in minuscono e poi controllo se è già presente nel dizionario
                    buffer = buffer.ToLower();
                    trovato = false;
                    for (int i = 0; i < paroleTrovate && !trovato; i++)
                    {
                        trovato = dizionario[i] == buffer;
                    }
                    // Controllo se la parola non è già presente
                    if (!trovato)
                    {
                        // Controllo se il dizionario è pieno
                        if (paroleTrovate < dizionario.Length)
                        {
                            dizionario[paroleTrovate] = buffer;
                            // Stampo la parola
                            Console.WriteLine("Hai inserito la parola {0}", dizionario[paroleTrovate]);
                            // Aggiungo uno alla lunghezza del dizionario
                            paroleTrovate++;
                        }
                        else
                        {
                            Console.WriteLine("Il dizionario è pieno.");
                            break;
                        }
                    }
                    // Cancello il buffer
                    buffer = "";

                }
                // Controllo se è una lettera o un numero
                else if (Char.IsLetterOrDigit(Convert.ToChar(tasto)))
                {
                    // Aggiungo il carattere al buffer
                    buffer += Convert.ToChar(tasto);
                }
                // Interrompo il ciclo quando arrivo al carriedge return
            } while (tasto != 13);
            // Controllo se non è stata trovata almeno una parola
            if (paroleTrovate == 0)
            {
                Console.WriteLine("Non hai inserito aluna parola.");
            }
            Console.ReadLine(); // Mi prendo il CR
            Console.ReadLine(); // Mi prendo il LF e aspetto l'invio per la chiusura del programma
        }
    }
}