using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigliettoCilindrata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cilindrata;
            double biglietto;
            const int cc1 = 1000, cc2 = 2000, cc3 = 3000, auto1 = 20, auto2 = 30, camion1 = 40, camion2 = 50;
            const double auto3 = 0.1, camion3 = 2, costoBiglietto = 20;
            string scelta = "";
            do
            {
                Console.WriteLine("Costo biglietto:", costoBiglietto);
                Console.WriteLine("Inserire tipo di veicolo. \n -Autovettura; \n -Camion");
                scelta = Console.ReadLine();
            }
            while (scelta != "Camion" && scelta != "Autovettura" && scelta != "camion" && scelta != "autovettura");
            if (scelta == "camion")
            {
                Console.WriteLine("Inserire cilindrata del camion");
                cilindrata = Convert.ToInt32(Console.ReadLine());
                if (cilindrata < cc2)
                {
                    biglietto = camion1 + costoBiglietto;
                    Console.WriteLine("Il biglietto è di {0} ", biglietto);
                    Console.WriteLine("Aggiuntivo : {0}", camion1);
                }
                if (cilindrata < cc3)
                {
                    biglietto = camion2 + costoBiglietto;
                    Console.WriteLine("Il biglietto è di {0} ", biglietto);
                    Console.WriteLine("Aggiuntivo : {0}", camion2);
                }
                else
                {
                    biglietto = camion3 * costoBiglietto;
                    Console.WriteLine("Il biglietto è di {0} ", biglietto);
                    Console.WriteLine("Aggiuntivo: {0}", costoBiglietto);
                }

            }
            else
            {
                Console.WriteLine("Inserire cilindrata dell'autovettura");
                cilindrata = Convert.ToInt32(Console.ReadLine());
                if (cilindrata < cc1) 
                {
                    biglietto = costoBiglietto + auto1;
                    Console.WriteLine("Il biglietto è di {0} ", biglietto);
                    Console.WriteLine("Aggiuntivo : {0}", auto1);
                }
                if (cilindrata < cc2)
                {
                    biglietto = costoBiglietto + auto2;
                    Console.WriteLine("Il biglietto è di {0} ", biglietto);
                    Console.WriteLine("Aggiuntivo : {0}", auto2);
                }
                else
                {
                    biglietto = costoBiglietto * auto3 + costoBiglietto;
                    Console.WriteLine("Il biglietto è di {0} ", biglietto);
                    Console.WriteLine("Aggiuntivo : {0}", costoBiglietto * auto3);
                }
            }
            Console.ReadLine();                      
        }
    }
}
