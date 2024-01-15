using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipassoItinere2
{
    internal class Program
    {
        static string path = Environment.CurrentDirectory + "\\" + "logBin" + "\\" + (DateTime.Now.ToShortDateString().Replace('/', '-')) + "logfile.txt";
        static void Main(string[] args)
        {
            string[] opzioni = {
                "aggiungi",
                "visualizza",
                "elimina",
                "visualliza con Targa",
                "visualliza con numero posti",
                "salva log",
                "visualizza log odierno",
                "tutti log",
                "esci"
            };
            int scelta;
            Flotta flotta = new Flotta();
            do
            {
                Console.Clear();
                scelta = Menu(opzioni, "FLOTTE DI AUTO");
                VerificaScelta(scelta, flotta);
            } while (scelta != opzioni.Length - 1);
        }
        static int Menu(string[] opzioni, string titolo)
        {
            int scelta;
            Console.WriteLine(titolo);
            for (int i = 0; i < opzioni.Length; i++)
            {
                Console.WriteLine($"[{i + 1}] {opzioni[i]}");
            }
            while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 1 || scelta > opzioni.Length)
            {
                Console.WriteLine("Inserisci qualcosa di corretto");
            }
            scelta--;
            return scelta;
        }
        static void VerificaScelta(int scelta, Flotta flotta)
        {
            int indice;
            switch (scelta)
            {

                case 0:
                    //aggiungi
                    flotta.Aggiungi(new Auto(InserimentoStringa("marca"), InserimentoStringa("modello"),
                        (NumeroPosti)Menu(Enum.GetNames(typeof(NumeroPosti)), "NUMERO POSTI")
                        ));
                    Console.WriteLine("Inserimento andato a buon fine");
                    break;
                case 1:
                    //visualizza
                    if (flotta.NElementi != 0) // verifico la lista sia vuota
                    {
                        flotta.CopiaLista().ForEach(x => Console.WriteLine(x.ToString()));
                    }
                    else
                    {
                        Console.WriteLine("lista vuota");
                    }
                    break;
                case 2:
                    //elimina
                    if (flotta.NElementi != 0) // verifico la lista sia vuota
                    {
                        Console.WriteLine("ELIMINAZIONE AUTO");
                        indice = Indice(flotta, InserimentoStringa("targa"));
                        if (indice != -1)
                        {
                            flotta.EliminaAuto(flotta.CopiaLista()[indice]);
                        }
                        else
                        {
                            Console.WriteLine("La macchina non esiste");
                        }
                    }
                    else
                    {
                        Console.WriteLine("lista vuota");
                    }
                    break;
                case 3:
                    //visualizza con ricerca targa
                    if (flotta.NElementi != 0) // verifico la lista sia vuota
                    {
                        Console.WriteLine("VISUALIZZA AUTO CON RICERCA");
                        indice = Indice(flotta, InserimentoStringa("targa"));
                        if (indice != -1)
                        {
                            Console.WriteLine(flotta.CopiaLista()[indice].ToString());
                        }
                        else
                        {
                            Console.WriteLine("La macchina non esiste");
                        }
                    }
                    break;
                case 4:
                    //visualizza tramite numero di posti
                    NumeroPosti choice;
                    if (flotta.NElementi != 0) // verifico la lista sia vuota
                    {
                        choice = (NumeroPosti)Menu(Enum.GetNames(typeof(NumeroPosti)), "NUMERO POSTI");
                        if (flotta.CopiaLista().Exists(x => x.numeroPosti == choice))
                        {
                            flotta.CopiaLista().FindAll(x => x.numeroPosti == choice).ForEach(x => Console.WriteLine(x.ToString()));
                        }
                        else
                        {
                            Console.WriteLine("Non esiste nessuna macchina con quel numero di posti");
                        }
                    }
                    else
                    {
                        Console.WriteLine("flotta vuota");
                    }
                    break;
                case 5:
                    // salva log
                    if (flotta.NElementi != 0) // verifico la lista sia vuota
                    {
                        int cont = 0;
                        foreach (Auto item in flotta.CopiaLista())
                        {
                            ScriviLog(path, flotta.CopiaLista()[cont].ToString());
                            cont++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("lista vuota");
                    }
                    break;
                case 6:
                    // visualizza log
                    LeggiLog(path);
                    break;
                case 7:
                    //tutti i log
                    string[] percorsi = Directory.GetFiles(Environment.CurrentDirectory + "\\" + "logBin", "*.txt"); // cerca solo i txt                        
                    string[] nomi = OttieniNomi(percorsi);
                    int log = Menu(nomi, "FILE DI LOG");
                    LeggiLog(percorsi[log]);
                    break;
            }
            Console.WriteLine("Premere invio per continuare");
            Console.ReadLine();
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
        static string InserimentoStringa(string campo)
        {
            Console.WriteLine($"Inserire {campo} dell'auto");
            string stringa;
            stringa = Console.ReadLine().Trim();
            while (String.IsNullOrEmpty(stringa))
            {
                Console.WriteLine("Reinserire");
                stringa = Console.ReadLine();
            }
            return stringa;
        }
        static int Indice(Flotta flotta, string targa)
        {
            if (flotta.CopiaLista().Exists(x => x.Targa == targa))
            {
                return flotta.CopiaLista().FindIndex(x => x.Targa == targa);
            }
            else
            {
                return -1; //la macchina non è presente nella lista
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
            StreamReader fileLog = new StreamReader(path);
            string linea;
            linea = fileLog.ReadLine();
            while (linea != null)
            {
                Console.WriteLine(linea);
                linea = fileLog.ReadLine();
            }
            fileLog.Close();
        }
    }
}
