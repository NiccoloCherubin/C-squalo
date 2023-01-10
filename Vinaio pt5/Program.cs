using System;
using System.Collections.Generic;
using System.Linq;
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
            int bott;
            double litri, totale, sconto = 0;
            string endday, domicilio;
            const int scontoPer = 10, litriMin = 45 , pzL = 2, pzDom = 3;
            const double lBott = 1.5;
            // inizio ciclo di fine giornata
            do
            {
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
                    sconto = totale / scontoPer;
                    totale = totale - sconto;
                }
                else
                {
                    totale = litri * pzL;
                }

                // chiedo domicilio
                Console.WriteLine("Vuoi la consegna a domicilio (3 euro)");
                domicilio = Console.ReadLine();
                // verifico risposta e calcoli
                if (domicilio == "sì")
                {
                    totale = totale + pzDom;
                    if (sconto != 0)
                    {
                        //stampo scontrino sconto + domicilio
                        Console.WriteLine(" (========= Tana dei Goti ===========) ");
                        Console.WriteLine(" (Barbera n° bottiglioni {0} importo Totale {1}) ", bott, totale);
                        Console.WriteLine("(Sconto 10 % {0}", sconto);
                        Console.WriteLine(" (=======================================) ");
                        Console.WriteLine(" (Totale parziale $Euro) ");
                        Console.WriteLine(" (Spese di trasporto $Euro) ");
                        Console.WriteLine(" ( =======================================) ");
                        Console.WriteLine(" (Importo Totale $Euro) ");
                        Console.WriteLine(" (n° scontrino) ");
                        Console.WriteLine(" (========= Arrivederci =========) ");
                    }
                }
                else
                {
                                      
                }              
                
                // chiedo fine giornata
                Console.WriteLine("Siamo a fine giornata? ");
                endday = Console.ReadLine();
            }
            while (endday !="no");
        }
    }
}
