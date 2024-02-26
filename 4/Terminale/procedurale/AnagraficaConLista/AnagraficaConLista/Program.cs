using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagraficaStato
{
    internal class Program
    {
        static string path = Environment.CurrentDirectory + "\\" + "logBin" + "\\" + CostruisciData(DateTime.Now.ToShortDateString()) + "logfile.txt";

        enum Sesso
        {
            Maschio,
            Femmina
        }
        enum StatoCivile
        {
            Celibe,
            Nubile,
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
            public override string ToString()
            {
                return string.Format($"Nome:{nome,-5} Cognome:{cognome,4} Data Nascita: {dataNascita.ToShortDateString(),3} Stato Civile: {statoCivile,10} Sesso: {sesso,5} codice ficsale: {codiceFiscale,2}");
            }
            static void Main(string[] args)
            {
                int nElementi = -1;
                string[] opzioni = new string[] { "Inserimento", "Visualizza", "Cambia stato civile", "Calcolo età", "Rimozione", "Leggi log", "Cancella Log", "Tutti i log", "Exit" };
                List<Anagrafica> anagrafica = new List<Anagrafica>();
                int scelta;
                do
                {
                    scelta = Menu(opzioni, "COMUNE DI ROVIGO", 0, 0, ConsoleColor.DarkRed, ConsoleColor.Gray, ConsoleColor.Black);
                    Console.Clear();
                    VerificaScelta(scelta, anagrafica, ref nElementi);
                    Console.ReadLine();
                } while (scelta != opzioni.Length - 1);
            }
            static void VerificaScelta(int scelta, List<Anagrafica> anagrafica, ref int nElementi)
            {
                string risposta;
                int indice;
                switch (scelta)
                {
                    case 0:
                        Inserimento(anagrafica, nElementi);
                        nElementi++;
                        ScriviLog(path, anagrafica[nElementi].ToString()); // true = nuovo file, false = va in coda
                        break;
                    case 1:
                        if (anagrafica.Count != 0)
                        {
                            anagrafica.ForEach(x => Console.WriteLine(x.ToString()));
                            Console.WriteLine("Premere invio per continuare");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Lista vuota. Fare inserimento");
                        }
                        break;
                    case 2:
                        if (anagrafica.Count != 0)
                        {
                            int numero;
                            string cf;
                            Console.WriteLine("Inserire codice fiscale della persona di cui si vuole cambiare lo stato civile");
                            while (!ControlloStringhe(Console.ReadLine(), out cf))
                            {
                                Console.WriteLine("Inserito codice fiscale errato. Reinserire");
                            }
                            numero = anagrafica.FindLastIndex(x => x.codiceFiscale == cf);
                            CambioStatoCivile(anagrafica, numero);
                        }
                        else
                        {
                            Console.WriteLine("Array vuoto. Premere invio per continuare");
                            Console.ReadLine();
                        }

                        break;
                    case 3:
                        if (anagrafica.Count != 0)
                        {
                            Console.WriteLine("Inserire codice fiscale della persone della quale si vuole sapere l'età");
                            while (!ControlloStringhe(Console.ReadLine(), out risposta))
                            {
                                Console.WriteLine("Inserire stringa valida");
                            }
                            indice = anagrafica.FindLastIndex(x => x.codiceFiscale == risposta);
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
                        if (anagrafica.Count != 0)
                        {
                            Console.WriteLine("Inserire codice fiscale della persona da eliminare");
                            while (!ControlloStringhe(Console.ReadLine(), out risposta))
                            {
                                Console.WriteLine("Inserire stringa valida");
                            }
                            anagrafica.RemoveAt(anagrafica.FindLastIndex(x => x.codiceFiscale == risposta));
                            Console.WriteLine("Eliminazione completata. Premere invio per continuare");
                        }
                        else
                        {
                            Console.WriteLine("Anagrafica vuota. Fare inserimento");
                        }
                        break;
                    case 5:
                        if (File.Exists(path))
                        {
                            LeggiLog(path);
                        }
                        else
                        {
                            Console.WriteLine("File di log vuoto");
                            ScriviLog(path, "Provato a leggere log vuoto");
                        }
                        break;
                    case 6:
                        File.Delete(path);
                        Console.WriteLine("Eliminazione log avvenuta con successo");
                        break;
                    case 7:
                        string[] percorsi = Directory.GetFiles(Environment.CurrentDirectory + "\\" + "logBin", "*.txt"); // cerca solo i txt                        
                        string[] nomi = OttieniNomi(percorsi);
                        int log = Menu(nomi, "FILE DI LOG", 0, 0, ConsoleColor.Magenta, ConsoleColor.White, ConsoleColor.Black);
                        LeggiLog(percorsi[log]);
                        Console.WriteLine("Premere invio per continuare");
                        break;
                }
            }
            static int Menu(string[] opzioni, string titolo, int x, int y, ConsoleColor coloreTitolo, ConsoleColor coloreTesto, ConsoleColor coloreSfondo)
            {
                int temp = y;
                int scelta;
                y = temp;
                Console.Clear();
                Console.ForegroundColor = coloreTitolo;
                Console.BackgroundColor = coloreSfondo;
                Console.SetCursorPosition(x, y++);
                Console.WriteLine(titolo);
                Console.ForegroundColor = coloreTesto;
                for (int i = 0; i < opzioni.Length; i++)
                {
                    Console.SetCursorPosition(x, y++);
                    Console.WriteLine($"[{i + 1}] {opzioni[i]}");
                }
                Console.SetCursorPosition(x, y);
                Console.WriteLine("Inserire Opzione");
                while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 1 || scelta > opzioni.Length)
                {
                    Console.WriteLine("Inserisci qualcosa di corretto");
                }
                scelta--;
                return scelta;
            }
            static void Inserimento(List<Anagrafica> anagrafica, int nElementi)
            {
                string risposta;
                Anagrafica p1 = new Anagrafica();
                Console.WriteLine("Inserire nome");
                while (!ControlloStringhe(Console.ReadLine(), out p1.nome))
                {
                    Console.WriteLine("Inserire nome valido");
                }
                Console.WriteLine("Inserire cognome");
                while (!ControlloStringhe(Console.ReadLine(), out p1.cognome))
                {
                    Console.WriteLine("Inserire cognome valido");
                }
                p1.sesso = (Sesso)Menu(Enum.GetNames(typeof(Sesso)), "SESSO", 0, 0, ConsoleColor.Magenta, ConsoleColor.Gray, ConsoleColor.Black);
                p1.statoCivile = (StatoCivile)Menu(Enum.GetNames(typeof(StatoCivile)), "STATO CIVILE", 0, 0, ConsoleColor.Magenta, ConsoleColor.Gray, ConsoleColor.Black);
                Console.Clear();
                Console.WriteLine("inserire data di nascita");
                while (!DateTime.TryParse(Console.ReadLine(), out p1.dataNascita))
                {
                    Console.WriteLine("inserire data di nascita valida");
                }
                Console.WriteLine("Inserire codice fiscale");
                risposta = Console.ReadLine();
                while (anagrafica.Exists(x => x.codiceFiscale == risposta))
                {
                    Console.WriteLine("Codice fiscale già presente. Reinserire");
                    risposta = Console.ReadLine();
                }
                p1.codiceFiscale = risposta;
                anagrafica.Add(p1);
                Console.Clear();
                Console.WriteLine("Inserimento Completato. Premere invio per continuare");
            }
            static bool ControlloStringhe(string prova, out string stringa)
            {
                if (string.IsNullOrEmpty(prova))
                {
                    stringa = null;
                    return false;
                }
                else
                {
                    stringa = prova;
                    return true;
                }
            }
            static void CambioStatoCivile(List<Anagrafica> anagrafe, int posizione)
            {
                Anagrafica p1 = new Anagrafica();
                p1 = anagrafe[posizione];
                anagrafe.Remove(p1);
                p1.statoCivile = (StatoCivile)Menu(Enum.GetNames(typeof(StatoCivile)), "STATO CIVILE", 0, 0, ConsoleColor.Magenta, ConsoleColor.Gray, ConsoleColor.Black);
                anagrafe.Add(p1);
            }
            static int Eta(int indice, List<Anagrafica> anagrafe)
            {
                int eta = DateTime.Now.Year - anagrafe[indice].dataNascita.Year - 1; // calcolo età
                if (DateTime.Now.Month >= anagrafe[indice].dataNascita.Month && DateTime.Now.Day > anagrafe[indice].dataNascita.Day) // verifica del mese e del giorno
                {
                    eta++;
                }
                return eta;
            }
        }
        static void ScriviLog(string path, string stringa)
        {
            // ogni stringa accodata a quella prima
            StreamWriter fileLog;
            if (File.Exists(path))
            {
                fileLog = new StreamWriter(path, true); // ricostruisce da capo ogni volta il file di testo. Con true va in coda
            }
            else
            {
                fileLog = new StreamWriter(path); // ricostruisce da capo ogni volta il file di testo.
            }
            fileLog.WriteLine($"{DateTime.Now} {stringa}");
            // chiudere file            
            fileLog.Close();
        }
        static void LeggiLog(string path)
        {
            StreamReader fileLog = File.OpenText(path);
            string linea;
            linea = fileLog.ReadLine();
            while (linea != null)
            {
                Console.WriteLine(linea);
                linea = fileLog.ReadLine();
            }
            fileLog.Close();
        }
        static string CostruisciData(string dataConSlash)
        {
            return dataConSlash.Replace('/', '-');
        }
        static string[] OttieniNomi(string[] percorsi)
        {
            string[] nomi = new string[percorsi.Length];
            for (int i = 0; i < nomi.Length; i++)
            {
                nomi[i] = Path.GetFileName(percorsi[i]);
            }
            return nomi;
        }
    }
}