using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagraficaStato
{
    internal class Program
    {
        public enum Stato
        {
            libero,
            occupato,
            cancellato
        }
        public enum Sesso
        {
            Maschio,
            Femmina
        }
        public enum StatoCivile
        {
            Celibe, // no moglie
            Nubile, // no marito
            Coniugato,
            Divorziato,
            Separato
        }
        struct Anagrafica
        {
            public string codiceFiscale;
            public string nome;
            public string cognome;
            public DateTime dataNascita;
            public StatoCivile statoCivile;
            public Sesso sesso;
            public Stato stato;
            public override string ToString() // ridifinito metodo toString, perché comune a tutti
            {
                return string.Format($"Nome:{nome,-5} Cognome:{cognome,4} Data Nascita: {dataNascita.ToShortDateString(),3} Stato Civile: {statoCivile,10} Sesso: {sesso,5}");
            }
            static void Main(string[] args)
            {
                int ultimo = -1;
                string[] opzioni = new string[] { "Inserimento", "Visualizza", "Cambia stato civile", "Calcolo età", "Rimozione", "Exit" };
                Anagrafica[] anagrafica = new Anagrafica[3];
                int scelta;
                do
                {
                    scelta = Menu(opzioni, "COMUNE DI ROVIGO", 0, 0, ConsoleColor.DarkRed, ConsoleColor.Gray, ConsoleColor.Black);
                    Console.Clear();
                    VerifcaScelta(scelta, anagrafica, ref ultimo);
                    Console.ReadLine();
                } while (scelta != opzioni.Length - 1);
            }
            static void VerifcaScelta(int scelta, Anagrafica[] anagrafica, ref int ultimo)
            {
                string risposta;
                int indice;
                switch (scelta)
                {
                    case 0:
                        Inserimento(anagrafica, ref ultimo);
                        break;
                    case 1:
                        if (ultimo != -1)
                        {
                            Visualizza(ultimo, anagrafica);
                            Console.WriteLine("Premere invio per continuare");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Array vuoto. Fare inserimento");
                        }
                        break;
                    case 2:
                        if (ultimo != -1)
                        {
                            Console.WriteLine($"Di chi vuoi cambiare lo stato civile? (inserisci il numero maggiore di zero e minore uguale di {ultimo})");
                            byte numero;

                            while (!Byte.TryParse(Console.ReadLine(), out numero) || numero > anagrafica.Length || numero < 0)
                            {
                                Console.WriteLine("Inserisci qualcosa di corretto");
                            }
                            CambioStatoCivile(anagrafica, numero);
                        }
                        else
                        {
                            Console.WriteLine("Array vuoto. Premere invio per continuare");
                            Console.ReadLine();
                        }

                        break;
                    case 3:
                        if (ultimo != -1)
                        {
                            Console.WriteLine("Inserire codice fiscale della persone della quale si vuole sapere l'età");
                            while (!ControlloStringhe(Console.ReadLine(), out risposta))
                            {
                                Console.WriteLine("Inserire stringa valida");
                            }
                            indice = Ricerca(anagrafica, risposta);
                            if (indice != -1)
                            {
                                Console.Write($"Età di {anagrafica[indice].nome} {anagrafica[indice].cognome}: ");
                                Console.WriteLine(Eta(indice, anagrafica));
                            }
                            else
                            {
                                Console.WriteLine("Persona non presente nell'archivio");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Array vuoto. Premere invio per continuare");

                        }
                        break;
                    case 4:
                        if (ultimo != -1)
                        {
                            Console.WriteLine("Inserire codice fiscale della persona da eliminare");
                            while (!ControlloStringhe(Console.ReadLine(), out risposta))
                            {
                                Console.WriteLine("Inserire stringa valida");
                            }
                            indice = Ricerca(anagrafica, risposta);
                            Elimina(anagrafica, indice, ref ultimo);
                            Console.WriteLine("Eliminazione completata. Premere invio per continuare");
                        }
                        else
                        {
                            Console.WriteLine("Anagrafica vuota. Fare inserimento");
                        }
                        break;

                }
            }
            static int Menu(string[] opzioni, string titolo, int x, int y, ConsoleColor coloreTitolo, ConsoleColor coloreTesto, ConsoleColor coloreSfondo)
            {
                int temp = y; // per salvare valore (mandatory)
                int scelta;
                y = temp;
                Console.Clear();
                Console.ForegroundColor = coloreTitolo;
                Console.BackgroundColor = coloreSfondo;
                Console.SetCursorPosition(x, y++); // cambio posizione al titolo
                Console.WriteLine(titolo);
                Console.ForegroundColor = coloreTesto;
                for (int i = 0; i < opzioni.Length; i++)
                {
                    Console.SetCursorPosition(x, y++);
                    Console.WriteLine($"[{i + 1}] {opzioni[i]}");
                }
                Console.SetCursorPosition(x, y);
                Console.WriteLine("Inserire Opzione");
                while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 1 || scelta > opzioni.Length) // per non fare crushare programma
                {
                    Console.WriteLine("Inserisci qualcosa di corretto");
                }


                scelta--; // perché l'utente vede le opzioni aumentate di uno
                return scelta;
            }
            static void Visualizza(int ultimo, Anagrafica[] anagrafica)
            {
                for (int n = 0; n <= ultimo; n++)
                {
                    if (anagrafica[n].stato == Stato.occupato)
                    {
                        Console.WriteLine(anagrafica[n].ToString());
                    }
                }
            }
            static void Inserimento(Anagrafica[] anagrafica, ref int ultimo)
            {
                string risposta;
                do
                {
                    ultimo++;
                    Console.WriteLine("Inserire nome");
                    while (!ControlloStringhe(Console.ReadLine(), out anagrafica[ultimo].nome))
                    {
                        Console.WriteLine("Inserire nome valido");
                    }
                    Console.WriteLine("Inserire cognome");
                    while (!ControlloStringhe(Console.ReadLine(), out anagrafica[ultimo].cognome))
                    {
                        Console.WriteLine("Inserire cognome valido");
                    }
                    //stato civile
                    anagrafica[ultimo].sesso = (Sesso)Menu(Enum.GetNames(typeof(Sesso)), "SESSO", 0, 0, ConsoleColor.Magenta, ConsoleColor.Gray, ConsoleColor.Black);
                    anagrafica[ultimo].statoCivile = (StatoCivile)Menu(Enum.GetNames(typeof(StatoCivile)), "STATO CIVILE", 0, 0, ConsoleColor.Magenta, ConsoleColor.Gray, ConsoleColor.Black);
                    Console.Clear();
                    Console.WriteLine("inserire data di nascita");
                    while (!DateTime.TryParse(Console.ReadLine(), out anagrafica[ultimo].dataNascita))
                    {
                        Console.WriteLine("inserire data di nascita valida");
                    }
                    Console.WriteLine("Inserire codice fiscale");
                    risposta = Console.ReadLine();
                    while (!ControlloInserimento(risposta, anagrafica, ultimo))
                    {
                        Console.WriteLine("Codice fiscale già presente. Reinserire");
                        risposta = Console.ReadLine();
                    }
                    anagrafica[ultimo].codiceFiscale = risposta;
                    anagrafica[ultimo].stato = Stato.occupato; // cambio stato
                    Console.WriteLine("Continuare (s/n)?");
                    risposta = Console.ReadLine();
                    Console.Clear();
                } while (risposta != "n" && ultimo != anagrafica.Length - 1);
                anagrafica[ultimo].stato = Stato.occupato;
                Console.WriteLine("Inserimento Completato. Premere invio per continuare");
            }
            static bool ControlloStringhe(string prova, out string stringa)
            {
                if (string.IsNullOrEmpty(prova))
                {
                    stringa = "";
                    return false;
                }
                else
                {
                    stringa = prova;
                    return true;
                }
            }
            static bool ControlloInserimento(string codice, Anagrafica[] codiciFiscali, int ultimo)
            {
                for (int i = 0; i < ultimo; i++)
                {
                    //controllo se nell'array è presente un doppione
                    if (codice == codiciFiscali[i].codiceFiscale)
                    {
                        return false;
                    }
                }
                return true;
            }
            static void CambioStatoCivile(Anagrafica[] anagrafe, int posizione)
            {
                Console.WriteLine($"Vecchio stato civile : {anagrafe[posizione].statoCivile}");
                anagrafe[posizione].statoCivile = (StatoCivile)Menu(Enum.GetNames(typeof(StatoCivile)), "STATO CIVILE", 0, 0, ConsoleColor.Magenta, ConsoleColor.Gray, ConsoleColor.Black);
            }
            static int Ricerca(Anagrafica[] anagrafe, string codice)
            {
                for (int i = 0; i < anagrafe.Length; i++)
                {
                    if (anagrafe[i].codiceFiscale == codice)
                    {
                        return i;
                    }
                }
                return -1; // codice fiscale non trovato
            }
            static int Eta(int indice, Anagrafica[] anagrafe)
            {
                int eta = DateTime.Now.Year - anagrafe[indice].dataNascita.Year - 1; // calcolo età
                if (DateTime.Now.Month >= anagrafe[indice].dataNascita.Month && DateTime.Now.Day > anagrafe[indice].dataNascita.Day) // verifica del mese e del giorno
                {
                    eta++;
                }
                return eta;
            }
            static void Elimina(Anagrafica[] anagrafe, int indice, ref int ultimo)
            {
                anagrafe[indice].stato = Stato.cancellato; // cambio stato
                //for (int i = indice; i < anagrafe.Length - 1; i++)
                //{
                //    anagrafe[i] = anagrafe[i + 1];
                //}
                //ultimo--;
            }
        }
    }
}
