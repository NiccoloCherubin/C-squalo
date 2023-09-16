using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LaScuolaElementare
{
    class Program
    {
        static void Main(string[] args)
        {
            int opzione, nAlunno = 0, posizione = 0;
            int presentiGita = 0; // per contare quanti vengono in gita
            string ricerca;
            const int maxOpzione = 7, nAlunni = 3;
            string[] nomeAlunni = new string[nAlunni]; // elenco nomi dei bambini
            string[] gita = new string[nAlunni]; // per fare elenco di chi va in gita
            string rispostaGita; // risposta se viene in gita o no
            bool fattoGita = false; // per vedere se ha fatto elenco
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
                    Console.WriteLine("[5] Fai elenco di chi va in gita");
                    Console.WriteLine("[6] Visualizza elenco di chi va in gita");
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
                        // ripristino colori base console
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                        break;
                    case 5:
                        // verifico se sono presenti degli alunni
                        if (nAlunno != 0)
                        {
                            // chiedo chi va in gita
                            for (int i = 0; i < nAlunno; i++)
                            {
                                Console.WriteLine("{0} viene in gita?", nomeAlunni[i]);
                                rispostaGita = Console.ReadLine().ToLower(); // rendo la risposta minuscola per non verificare ogni possibilità
                                // verifico risposta per dare messaggio d'errore
                                while (rispostaGita != "sì" && rispostaGita != "no")
                                {
                                    Console.WriteLine("Inserire risposta valida (Sì o No)");
                                    rispostaGita = Console.ReadLine().ToLower();
                                }
                                if (rispostaGita == "sì")
                                {
                                    gita[i] = nomeAlunni[i]; // inserisco il nome dell'alunno nell'elenco della gita
                                    presentiGita++;
                                }
                            }
                            fattoGita = true;
                        }
                        // messagio di errore nel caso di mancato inserimento
                        else
                        {
                            Console.WriteLine("Non hai inserito nome degli alunni. Premere invio per continuare");
                            Console.ReadLine();
                        }
                        break;
                    case 6:
                        // verifico se ha fatto l'elenco della gita
                        if (fattoGita)
                        {
                            // stampo elenco di chi viene in gita
                            for (int i = 0; i < presentiGita; i++)
                            {
                                Console.WriteLine("L'alunno {0} viene in gita", gita[i]);
                            }
                            Console.WriteLine("premere invio per continuare");
                            Console.ReadLine();
                        }
                        // stampo messaggio di errore
                        else
                        {
                            Console.WriteLine("Non hai fatto l'elenco di chi viene in gita");
                            Console.WriteLine("premere invio per continuare");
                            Console.ReadLine();
                        }
                        break;
                }

            } while (opzione != maxOpzione);     // ripete ciclo finché non esce            
        }
    }
}