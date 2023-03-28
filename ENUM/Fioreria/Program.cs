using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fioreria
{
    class Program
    {
        enum Fiori // possono essere convertiti direttamente in intero. Tipi cardinali
        {
            Rose,
            Margherite,
            Ciclamini,
            Gerbere
        }
        struct FioreriaRossi
        {
            public double prezzo;
            public Fiori tipo;
        }
        static void Main(string[] args)
        {
            // non sbagliare a scrivere nomi --> creo tipo fiori che contiene solo Rose,Gerani, Crisantemi
            // struct (Fioreria Rossi) col prezzo di ogni tipo di fiori (double) 
            int scelta;
            int quantiFiori;
            int cont = 0;
            do
            {
                Console.WriteLine("Quanti fiori ci sono oggi in magazzino?");
                quantiFiori = Convert.ToInt32(Console.ReadLine());
            } while (quantiFiori <= 0);
            FioreriaRossi[] fiori = new FioreriaRossi[quantiFiori];
            while (cont < fiori.Length)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("===========Fioreria Rossi=========");
                    Console.WriteLine($"[{(int)Fiori.Rose + 1}] {Fiori.Rose}");
                    Console.WriteLine($"[{(int)Fiori.Margherite + 1}] {Fiori.Margherite}");
                    Console.WriteLine($"[{(int)Fiori.Ciclamini + 1}] {Fiori.Ciclamini}");
                    Console.WriteLine($"[{(int)Fiori.Gerbere + 1}] {Fiori.Gerbere}");
                    Console.WriteLine("===========Fioreria Rossi=========");
                    scelta = Convert.ToInt32(Console.ReadLine());
                } while (scelta < (int)Fiori.Rose + 1 || scelta > (int)Fiori.Gerbere + 1);

                fiori[cont].tipo = (Fiori)scelta - 1; // cast di scelta per leggere direttamente un intero
                do
                {
                    Console.WriteLine($"Quanto costa una {fiori[cont].tipo}");
                    fiori[cont].prezzo = Convert.ToDouble(Console.ReadLine());

                } while (fiori[cont].prezzo <= 0);
                cont++; // incremento numero di fiori inseriti
                Console.WriteLine("Premere invio per continuare");
                Console.ReadLine();
            }
            // stampa array
            foreach(FioreriaRossi n in fiori)
            {
                Console.WriteLine($"{n.tipo} costa {n.prezzo}");
            }
            Console.ReadLine();
        }
    }
}
