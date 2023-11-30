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

            string[] opzioni = { "inserimento", "visualizzazione di tutti i pazienti", "Exit" };
            int scelta = 0;
            // creazione dei reparti
            CreazioneReparti();
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
            int sceltaReparto;
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


                    paziente.SetTemperatura(InserimentoIntero("temperatura"));


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
                    //visualizza tutti i pazienti
                    for (int i = 0; i < reparti.Length; i++)
                    {
                        for (int j = 0; j < reparti[i].GetPazineti(); j++)
                        {
                            reparti[i].StampaPazienti();
                        }
                    }
                    break;
            }
            Console.WriteLine("Premere invio per continuare");
            Console.ReadLine();
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
        static int InserimentoIntero(string campo)
        {
            int supportoQuantita;
            Console.WriteLine($"Inserire {campo} del paziente");
            while (!int.TryParse(Console.ReadLine(), out supportoQuantita) || supportoQuantita < 0)
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
