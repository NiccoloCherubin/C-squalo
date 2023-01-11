using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Vinaio_pt5
{
    class Program
    {
        static void Main(string[] args)
        {
            // barbera in bottoglioni (1.5L). Sconti  10 %acquisti superiori 45L. L = 2. Domicilio = 3
            /*
             (=======   Tana dei goti   ======)
             (Barbera n° bottiglioni (n° litri) importo totale)
             (Sconto 10%                                Sconto)
             (================================================)
             (Totale parziale                          $Sconto)
             (Spese trasporto                            $Euro)
             (================================================)
             (Importo Totale                             $Euro)
             (                                    n° scontrino)
            */
            int bott, botTot = 0, scontrini = 0, domicilioTot = 0;
            double litri, litriTot = 0, parziale, totale, sconto = 0, scontoTot = 0, totL, incasso = 0;
            string endday, domicilio;
            const int scontoPer = 10, litriMin = 45, pzL = 2, pzDom = 3;
            const double lBott = 1.5;
            // inizio ciclo di fine giornata
            do
            {
                // calcolo numero scontrini
                scontrini++;
                // inserimento bottiglioni
                do
                {
                    Console.WriteLine("Benvenuto alla tana dei goti quanti bottiglioni (1.5L) di barbera vuole ordinare? ");
                    bott = Convert.ToInt32(Console.ReadLine());
                }
                while (bott <= 0);

                // calcolo litri
                litri = lBott * bott;

                // verifico litri per sconto
                if (litri > litriMin)
                {
                    totale = litri * pzL;
                    totL = totale;
                    sconto = totale / scontoPer;
                    totale = totale - sconto;
                }
                else
                {
                    totale = litri * pzL;
                    totL = totale;
                }

                // chiedo domicilio
                do
                {
                    Console.WriteLine("Vuoi la consegna a domicilio (3 euro)");
                    domicilio = Console.ReadLine();
                } while (domicilio != "sì" && domicilio != "no");
                parziale = totale;
                // verifico risposta e calcoli
                if (domicilio == "sì")
                {
                    totale = totale + pzDom;
                    if (sconto != 0)
                    {
                        //stampo scontrino sconto + domicilio
                        Console.WriteLine(" (========= Tana dei Goti ===========) ");
                        Console.WriteLine(" (Barbera n° bottiglioni {0} litri Totali {1}) ", bott, litri);
                        Console.WriteLine(" (Sconto 10 % {0})", sconto);
                        Console.WriteLine(" (=======================================) ");
                        Console.WriteLine(" (Totale parziale {0}) ", parziale);
                        Console.WriteLine(" (Spese di trasporto {0}) ", domicilio);
                        Console.WriteLine(" ( =======================================) ");
                        Console.WriteLine(" (Importo Totale {0}) ", totale);
                        Console.WriteLine(" (n° scontrino) {0}", scontrini);
                        Console.WriteLine(" (========= Arrivederci =========) ");
                    }
                    else
                    {
                        // scontrino solo con domicilio
                        Console.WriteLine(" (========= Tana dei Goti ===========) ");
                        Console.WriteLine(" (Barbera n° bottiglioni {0} litri totali {1}) ", bott, totL);
                        Console.WriteLine(" (=======================================) ");
                        Console.WriteLine(" (Totale parziale {0}) ", parziale);
                        Console.WriteLine(" (Spese di trasporto {0}) ", domicilio);
                        Console.WriteLine(" ( =======================================) ");
                        Console.WriteLine(" (Importo Totale {0}) ", totale);
                        Console.WriteLine(" (n° scontrino) {0}", scontrini);
                        Console.WriteLine(" (========= Arrivederci =========) ");
                    }
                    // calcolo domicilio tot solo quando c'è domicilio
                    domicilioTot = domicilioTot + pzDom;
                }
                else
                {
                    // scontrino solo con sconto
                    Console.WriteLine(" (========= Tana dei Goti ===========) ");
                    Console.WriteLine(" (Barbera n° bottiglioni {0} litri totali {1}) ", bott, totL);
                    Console.WriteLine(" (Sconto 10 % {0})", sconto);
                    Console.WriteLine(" (=======================================) ");
                    Console.WriteLine(" (Totale parziale {0}) ", parziale);
                    Console.WriteLine(" ( =======================================) ");
                    Console.WriteLine(" (Importo Totale {0}) ", totale);
                    Console.WriteLine(" (n° scontrino) {0}", scontrini);
                    Console.WriteLine(" (========= Arrivederci =========) ");
                }
                // chiedo se fine giornata
                Console.WriteLine("Siamo a fine giornata? ");
                endday = Console.ReadLine();
                // calcolo tot per fare recap
                botTot = botTot + bott;
                litriTot = litriTot + litri ;
                scontoTot = scontoTot + sconto;
                incasso = incasso + totale;
            }
            while (endday == "no");
            // scontrino per il titolare
            Console.WriteLine("(========= Tana dei Goti =========== )");
            Console.WriteLine("(========= Chiusura Cassa =========== )");
            Console.WriteLine("(Barbera Totale: n° bottiglioni   {0}, n° litri     {1})" , botTot, litriTot);
            Console.WriteLine("(=======================================)");
            Console.WriteLine("(Totale Sconto  {0})", scontoTot);
            Console.WriteLine("(Totale Incasso {0}", incasso);
            Console.WriteLine("(Totale Spese di trasporto {0})" , domicilioTot);
            Console.WriteLine("(n° scontrini emessi     {0})" , scontrini);
            Console.WriteLine("(========= Arrivederci =========)");
            Console.ReadLine();
        }
    }
}