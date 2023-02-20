using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaScuolaElementare
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Visita di'istruzione to do
             * Capire chi viene in gita e chiede a tutti chi va.
             * Se sì va, sennò no
             * stampare elenco di chi viene in gita.
             * La maestra ha la necessità che l'elenco dei bambini che vanno in gita vada mantenuto fino alla prossima visita d'struzione
             */
            int opzione, nAlunno = 0, posizione = 0;
            string ricerca;
            const int maxOpzione = 5, nAlunni = 3;
            string[] nomeAlunni = new string[nAlunni];
            //visualizzazione menù
            do
            {
                // scelta dell'opzione
                do
                {
                    Console.Clear();
                    Console.WriteLine("===Registro di classe===");
                    Console.WriteLine("[1] inserimento");
                    Console.WriteLine("[2] presenti");
                    Console.WriteLine("[3] ricerca");
                    Console.WriteLine("[4] visualizza alunno");
                    Console.WriteLine("[{0}] esci", maxOpzione);
                    opzione = Convert.ToInt32(Console.ReadLine());
                } while (opzione < 1 || opzione > maxOpzione);
                // verifica dell'opzione ed esecuzione
                switch (opzione)
                {
                    // inserimento nome alunni
                    case 1:
                        // verifico se classe al completo
                        if (nAlunni != nAlunno)
                        {
                            Console.WriteLine("inserire nome alunno");
                            nomeAlunni[nAlunno] = Console.ReadLine(); // inserimento nome
                            nAlunno++;
                        }
                        // se la classe è al completo
                        else
                        {
                            Console.WriteLine("La classe è al completo. Premere invio per continuare");
                            Console.ReadLine();
                        }

                        break;
                    // visualizzazione alunno
                    case 2:
                        // verifico se sono presente degli alunni
                        if (nAlunno != 0)
                        {
                            // stampa dei presenti
                            for (int i = 0; i < nAlunno; i++)
                            {
                                Console.WriteLine("{0} {1}", i + 1, nomeAlunni[i]);
                            }
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Non hai inserito nome degli alunni. Premere invio per continuare");
                            Console.ReadLine();
                        }
                        break;
                    // ricerca
                    case 3:
                        if (nAlunno != 0)
                        {
                            Console.WriteLine("Inserire nome dell'alunno da cercare");
                            ricerca = Console.ReadLine();
                            // ricerca del nome nell'array
                            bool trovato = false;
                            for (int i = 0; i < nAlunno && !trovato; i++)
                            {
                                if (ricerca == nomeAlunni[i])
                                {
                                    trovato = true;
                                    posizione = i + 1;
                                }

                            }
                            // verifico se c'è il nome in elenco
                            if (trovato)
                            {
                                Console.WriteLine("L'alunno {0} è presente", ricerca);
                            }
                            else
                            {
                                Console.WriteLine("L'alunno {0} è assente", ricerca);
                            }
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Non hai inserito nome degli alunni. Premere invio per continuare");
                            Console.ReadLine();
                        }
                        // per vedere se ha usato ricerca                        
                        break;
                    case 4:
                        if (posizione != 0)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.WriteLine($"{posizione} {nomeAlunni[posizione - 1]}");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Non hai effettuato ricerca");
                        }
                        Console.ReadLine();
                        break;
                }
            } while (opzione != maxOpzione);     // ripete ciclo finché non esce            
        }
    }
}