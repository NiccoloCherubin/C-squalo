using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ZooClaasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<AnimaleDomestico> animali = new List<AnimaleDomestico>();
            string[] opzioni = { "inserimento", "visualizzazione", "Exit" };
            int scelta = 0;

            do
            {
                Console.Clear();
                scelta = Menu(opzioni, "ANIMALI");
                VerificaScelta(scelta, animali);
                Console.ReadLine();
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
        static void VerificaScelta(int scelta, List<AnimaleDomestico> animali)
        {
            const int max = 3;
            switch (scelta)
            {
                case 0:
                    if (animali.Count <= max)
                    {
                        //inserimento
                        AnimaleDomestico animale = new AnimaleDomestico();
                        //animali.Add(Inserimento());
                        
                        animale.SetSpecie(InserimentoStringa("specie"));
                        animale.SetRazza(InserimentoStringa("razza"));
                        animale.SetRazza(InserimentoStringa("verso"));
                        animale.SetQuantita(InserimentoIntero("quantità"));
                        animale.SetStatoNutrizione(InserimentoStato());

                        animali.Add(animale);
                    }
                    break;
                case 1:
                    if (animali.Count > 0)
                    {
                        //stampa a video gli animali
                        animali.ForEach(x => Console.WriteLine(x.ToString()));
                    }
                    else
                    {
                        Console.WriteLine("Lista vuota. Fare inserimento");
                    }
                    break;
            }
        }
        static int InserimentoIntero(string campo)
        {
            int supportoQuantita;
            Console.WriteLine($"Inserire {campo} dell'animale");
            while (!int.TryParse(Console.ReadLine(), out supportoQuantita) || supportoQuantita < 0)
            {
                Console.WriteLine("Inserire qualcosa di corretto");
            }
            return supportoQuantita;
        }
        static Mangiato InserimentoStato()
        {
            Mangiato mangiato = new Mangiato();
            bool valido = false;            
            do
            {
                try
                {
                    Console.WriteLine("Stato nutrizione animale");
                    Console.WriteLine("mangiato");
                    Console.WriteLine("non_può_mangiare");
                    Console.WriteLine("deve_mangiare");
                    if (!Enum.TryParse(Console.ReadLine(), out mangiato))
                    {
                        valido = false;
                        throw new Exception("Valore Inserito non valido");
                    }
                    else
                    {
                        valido = true;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Premere invio per continuare");
                }

            } while (!valido);
            return mangiato;

        }
        static string InserimentoStringa(string campo)
        {
            Console.WriteLine($"Inserire {campo} dell'animale");
            string stringa;
            stringa = Console.ReadLine();
            while (String.IsNullOrEmpty(stringa.Trim()) ||!StringaValida(stringa))
            {
                Console.WriteLine("Reinserire");
                stringa = Console.ReadLine();
            }
            return stringa;
        }
        static bool StringaValida(string stringa)
        {
            for(int i = 0; i < stringa.Length; i++)
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
