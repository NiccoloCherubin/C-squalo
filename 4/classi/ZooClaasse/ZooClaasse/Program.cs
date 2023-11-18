using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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
                        animali.Add(Inserimento());
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
        static AnimaleDomestico Inserimento()
        {
            AnimaleDomestico supp = new AnimaleDomestico();
            int supportoQuantita;
            Console.WriteLine("Inserire specie");
            supp.SetSpecie(Console.ReadLine());
            Console.WriteLine("Inserire razza");
            supp.SetRazza(Console.ReadLine());
            Console.WriteLine("Inserire cibo che mangia l'animale");
            supp.SetCibo(Console.ReadLine());
            Console.WriteLine("Inserire verso che fa l'animale");
            supp.SetVerso(Console.ReadLine());
            Console.WriteLine("Inserire quantità della tipologia di animale");
            while (!int.TryParse(Console.ReadLine(), out supportoQuantita) || supportoQuantita < 0)
            {
                Console.WriteLine("Inserire qualcosa di corretto");
            }
            supp.SetQuantita(supportoQuantita);
            supp.SetStatoNutrizione((Mangiato)Menu(Enum.GetNames(typeof(Mangiato)), "STATO NUTRIZIONE DELL'ANIMALE"));
            return supp;
        }
    }
}
