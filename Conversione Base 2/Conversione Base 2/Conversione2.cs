using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversione_Base_2
{
    internal class Conversione2
    {
        static void Main(string[] args)
        {
            string risultato = "";
            int numeroCalc; // variabile per calcoli
            int numeroVisua; // numero da visualizzare
            int basel, resto;
            char[] convertitore = new char[16] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            // inserimento numero di massimo un byte
            do
            {
                Console.WriteLine("Inserire numero da coverire, di massimo un byte (0-225)");
                numeroCalc = Convert.ToInt32(Console.ReadLine());
            } while (numeroCalc < 0 || numeroCalc > 225);
            numeroVisua = numeroCalc;
            // inserimento base compresa tra 2 e 16
            do
            {
                Console.WriteLine("Inserire base in cui convertire {0} (2-16)", numeroVisua);
                basel = Convert.ToInt32(Console.ReadLine());
            } while (basel < 2 || basel > 16);
            while (numeroCalc != 0)
            {
                resto = numeroCalc % basel;
                risultato = convertitore[resto] + risultato;
                numeroCalc = numeroCalc / basel;
            }
            Console.WriteLine("il numero {0} convertito in base {1} equivale a {2}", numeroVisua, basel, risultato);
            Console.ReadLine();
        }
    }
}
