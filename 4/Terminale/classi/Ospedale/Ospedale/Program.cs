using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ospedale
{
    internal class Program
    {
        static string[] repartiDisponibili = { "radio terapia", "cardiologia", "anestesia" };// lista reparti
        static Reparti[] reparti = new Reparti[repartiDisponibili.Length];

        static void Main(string[] args)
        {

            string[] opzioni = { "inserimento", "visualizzazione di tutti i pazienti", "cambio temperatura", "visualizza singolo paziente", "Exit" };
            int scelta;
            // creazione dei reparti
            CreazioneReparti();
            // pazienti di deafault
            reparti[0].Aggiungi(new paziente("mario", "rossi", repartiDisponibili[0]));
            reparti[0].Aggiungi(new paziente("mario", "verdi", repartiDisponibili[0]));
            reparti[0].Aggiungi(new paziente("mario", "bianchi", repartiDisponibili[0]));
            reparti[1].Aggiungi(new paziente("Luca", "bianchi", repartiDisponibili[1]));
            reparti[1].Aggiungi(new paziente("Luca", "rossi", repartiDisponibili[1]));
            reparti[1].Aggiungi(new paziente("Luca", "verdi", repartiDisponibili[1]));
            reparti[1].Aggiungi(new paziente("Luca", "verdi", repartiDisponibili[1]));
            reparti[2].Aggiungi(new paziente("Matteo", "verdi", repartiDisponibili[2]));
            reparti[2].Aggiungi(new paziente("Matteo", "rossi", repartiDisponibili[2]));
            reparti[2].Aggiungi(new paziente("Matteo", "bianchi", repartiDisponibili[2]));

            do
            {
                Console.Clear();
                scelta = Menu(opzioni, "OSPEDALE");
                VerificaScelta(scelta);
            } while (scelta != opzioni.Length - 1);
        }
        static void CreazioneReparti()
        {
            for (int i = 0; i < repartiDisponibili.Length; i++)
            {
                reparti[i] = new Reparti(repartiDisponibili[i]);
            }
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
        static void VerificaScelta(int scelta)
        {
            int sceltaReparto = 0;
            int sceltaPaziente;
            switch (scelta)
            {
                case 0:
                    //inserimento
                    sceltaReparto = Menu(repartiDisponibili, "Reparti Disponibili");
                    paziente paziente =
                        new paziente(
                        InserimentoStringa("nome"), // nome del paziente
                        InserimentoStringa("cognome"), // cognome del paziente
                        repartiDisponibili[sceltaReparto]); // reparto dove inserirlo è già stato scelta dall'utente
                    try
                    {
                        reparti[sceltaReparto].Aggiungi(paziente);
                        Console.WriteLine("Inserimento avvenuto con successo");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 1:
                    if (RepartiVuoti(reparti))
                    {
                        Console.WriteLine("Tutti reparti vuoti");
                        break;
                    }
                    //visualizza tutti i pazienti
                    for (int i = 0; i < reparti.Length; i++)
                    {
                        reparti[i].GetLista().ForEach(x => Console.WriteLine(
                            $"nome: {x.GetNome()}, " +
                            $"cognome: {x.GetCognome()}," +
                            $" reparto: {x.GetReparto()}," +
                            $" temperatura {x.GetTemperatura()}"
                            )
                        );
                    }
                    break;
                case 2:
                    //cambio temperatura
                    if (RepartiVuoti(reparti))
                    {
                        Console.WriteLine("Tutti reparti sono vuoti");
                        break;
                    }

                    sceltaPaziente = SceltaPaziente(ref sceltaReparto);

                    try
                    {
                        reparti[sceltaReparto].GetPaziente(sceltaPaziente).SetTemperatura(InserimentoDouble("temperatura"));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 3:
                    if (RepartiVuoti(reparti))
                    {
                        Console.WriteLine("Tutti reparti sono vuoti");
                        break;
                    }
                    ConsoleKeyInfo tasto;
                    sceltaPaziente = SceltaPaziente(ref sceltaReparto);
                    //errore
                    if (sceltaPaziente == -1)
                    {
                        Console.WriteLine("scelta non valida");
                        break;
                    }
                    paziente supporto = reparti[sceltaReparto].GetPaziente(sceltaPaziente);
                    int originale = sceltaPaziente;
                    do
                    {
                        Console.WriteLine("esc = exit, [->] = successivo [<-] = precedente, [r] reset");
                        Console.WriteLine(supporto.Anagrafica(supporto));
                        tasto = Console.ReadKey();
                        if (tasto.Key == ConsoleKey.RightArrow)
                        {
                            try
                            {
                                supporto = reparti[sceltaReparto].Next(sceltaPaziente);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            sceltaPaziente++;
                        }
                        else if (tasto.Key == ConsoleKey.LeftArrow)
                        {
                            try
                            {
                                supporto = reparti[sceltaReparto].Prec(sceltaPaziente);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            sceltaPaziente--;
                        }
                        else if(tasto.Key == ConsoleKey.R)
                        {
                            sceltaPaziente = originale;
                        }
                    } while (tasto.Key != ConsoleKey.Escape);
                    Console.WriteLine("ffine. Premere invio per continuare");
                    Console.ReadLine();
                    break;
            }

            Console.WriteLine("Premere invio per continuare");
            Console.ReadLine();
        }
        static int SceltaPaziente(ref int sceltaReparto)
        {
            sceltaReparto = Menu(repartiDisponibili, "Reparti Disponibili");
            if (reparti[sceltaReparto].Vuoto())
            {
                Console.WriteLine("Il reparto scelto è vuoto");
                return -1;
            }
            int sceltaPaziente;
            return sceltaPaziente = Menu(arrayStringheDiPazienti(reparti[sceltaReparto].GetLista()), "SCELTA PAZIENTE");
        }
        static bool RepartiVuoti(Reparti[] reparti)
        {
            bool vuoti = false; //nessun vuoti
            for (int i = 0; i < reparti.Length; i++)
            {
                if (reparti[i].Vuoto())
                {
                    vuoti = true; //tutti vuoto
                }
                else
                {
                    return false;
                }
            }
            return vuoti;
        }
        static string[] arrayStringheDiPazienti(List<paziente> pazienti)
        {
            string[] array = new string[pazienti.Count];
            for (int i = 0; i < pazienti.Count; i++)
            {
                //array[i] = pazienti[i].ToString();
                array[i] = $"nome: {pazienti[i].GetNome()} " +
                    $"cognome: {pazienti[i].GetCognome()}" +
                    $"temperatura: {pazienti[i].GetTemperatura()} °C"
                    ;
            }
            return array;
        }
        static string InserimentoStringa(string campo)
        {
            Console.WriteLine($"Inserire {campo} del paziente");
            string stringa;
            stringa = Console.ReadLine();
            while (String.IsNullOrEmpty(stringa.Trim()) || !StringaValida(stringa))
            {
                Console.WriteLine("Reinserire");
                stringa = Console.ReadLine();
            }
            return stringa;
        }
        static double InserimentoDouble(string campo)
        {
            double supportoQuantita;
            Console.WriteLine($"Inserire {campo} del paziente");
            while (!Double.TryParse(Console.ReadLine(), out supportoQuantita) || supportoQuantita < 0)
            {
                Console.WriteLine("Inserire qualcosa di corretto");
            }
            return supportoQuantita;
        }
        static bool StringaValida(string stringa)
        {
            for (int i = 0; i < stringa.Length; i++)
            {
                if (char.IsDigit(stringa[i]))
                {
                    return false; // stringa non valida
                }
            }
            return true; // stringa valida
        }

    }
}
