using System;
using System.Threading;

namespace AgendaTelefonica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool trovato = false ; // per la ricerca nell'array del nome
            const int maxOpzione = 4;
            const int nomiMax = 5;
            int posizione = 0; // posto nell'array di dov'è l'utente di cui si vuole cambiare numero di telefono
            string risposta; // nome dell'utente a cui cambiare il numero di telefono
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
                    Console.WriteLine("[3] Cambio numero di telefoni");
                    Console.WriteLine("[{0}] Fine", maxOpzione);
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
                            while (telefono[telefoni].Length != 10)
                            {
                                Console.WriteLine("Un numero di telefono deve avere 10 cifre");
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
                        break;
                    case 3:
                        // verifico che abbia inserito almeno un numero di telefono
                        if(telefoni != 0)
                        {
                            Console.WriteLine("Inserisci nome del contatto di cui vuoi cambiare il numero telefono");
                            risposta = Console.ReadLine();
                            for(int i = 0; i < telefoni && !trovato; i++)
                            {
                                if (risposta == telefono[i])
                                {
                                    trovato = true;
                                    posizione = i;
                                }
                                    
                            }
                            if (!trovato)
                            {
                                Console.WriteLine("Inserire il numero di telefono con cui si vuole sostituire quello precedente");
                                telefono[posizione] = Console.ReadLine();                                
                                while (telefono[posizione].Length != 10) // controllo se la lunghezza del numero di telefono sia corretta
                                {
                                    // stampo messaggio d'errore
                                    Console.WriteLine("Un numero di telefono deve avere 10 cifre");
                                    // reinsirimento del numero
                                    telefono[posizione] = Console.ReadLine();
                                }
                            }
                            else
                            {
                                // messaggio di errore
                                Console.WriteLine("L'utente {0} non è presente nell'elenco", risposta);
                            }
                        }
                        else
                        {
                            // messaggio d'errore
                            Console.WriteLine("Non hai inserito nessuno numero di telefono");
                        }                        
                        break;
                }
                Console.WriteLine("Premere invio per continuare");
                Console.ReadLine();
            }
            while (scelta != maxOpzione); // ripete ciclo finché non preme tasto per uscire
            Console.WriteLine("Buona Gioranata :)"); // stampo messaggio d'addio
            Thread.Sleep(500); // per far leggere il messaggio d'addio all'utente
        }
    }
}
