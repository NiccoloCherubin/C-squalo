using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AgendaTelefonica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int maxOpzione = 3;
            const int nomiMax = 5;
            int telefoni = 0; // conta numeri di telefono inseriti
            string[] nomeCognome = new string[nomiMax]; // per inserire nomi e cognomi
            string[] telefono = new string[nomiMax]; // per inserire numeri telefono
            int scelta; // scelta dell'opzione
            do
            {

                do
                {
                    Console.Clear();
                    Console.WriteLine("=== Agenda Telefonica ===");
                    Console.WriteLine("[1] Inserimento nome, cogome e numero telefono");
                    Console.WriteLine("[2] Visualizzazione numeri di telefono");
                    Console.WriteLine("[3] Fine");
                    scelta = Convert.ToInt32(Console.ReadLine());

                } while (scelta < 1 || scelta > maxOpzione);
                switch (scelta)
                {
                    case 1:                       
                            // inserimento nome e cognome
                            Console.WriteLine("Inserire nome e cognome");
                            nomeCognome[telefoni] = Console.ReadLine();
                            // controllo se sbaglia a scrivere
                            while (nomeCognome[telefoni] == "")
                            {
                                // stampo messaggio d'errore
                                Console.WriteLine("Hai premuto invio per sbaglio");
                                nomeCognome[telefoni] = Console.ReadLine();
                            }
                            // inserimento numero di telefono
                            Console.WriteLine("Inserisci numero di telefono di {0}. Il prefisso è +39", nomeCognome[telefoni]);
                            telefono[telefoni] = Console.ReadLine();
                            // verifico se ha messo un numero di telefono valido
                            while (telefono[telefoni].Length != 9)
                            {
                                Console.WriteLine("Un numero di telefono deve avere 9 cifre");
                                telefono[telefoni] = Console.ReadLine();
                            }
                            telefoni++;                        
                        break;
                    case 2:
                        // verifico che abbia inserito almeno un numero di telefono
                        if (telefoni != 0)
                        {
                            for (int i = 0; i < telefoni; i++)
                            {
                                Console.WriteLine("Il numero di telefono di {0} è {1}", nomeCognome[i], telefono[i]);
                            }
                        }
                        // stampa messsaggio d'errore
                        else
                        {
                            Console.WriteLine("Non hai inserito nessun numero di telefono");
                        }
                        Console.WriteLine("Premere invio per continuare");
                        Console.ReadLine();
                        break;
                }
            }
            while (scelta != maxOpzione); // ripete ciclo finché non preme tasto per uscire
            Console.WriteLine("Buona Gioranata :)"); // stampo messaggio d'addio
            Thread.Sleep(500); // per far leggere il messaggio d'addio all'utente
        }
    }
}
