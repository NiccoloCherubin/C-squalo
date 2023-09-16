using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScattiTelefonici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int scatti, scattiPr;
            double costoScattiPr, costoCostoScattiTr, differenza;
            const double canone = 20;
            const double costoScatti = 0.10;
            do
            {
                Console.WriteLine("Inserire scatti bolletta precedente");
                scattiPr = Convert.ToInt32(Console.ReadLine());
            }
            while (scattiPr < 0);
            do
            {
                Console.WriteLine("Inserire scatti telefonici letti il primo giorno del primo mese del trimestre");
                scatti = Convert.ToInt32(Console.ReadLine());
            }
            while (scatti < 0);
            
            do
            {
                Console.WriteLine("Inserire scatti telefonici dell'ultimo giorno del trimestre");
                scatti = Convert.ToInt32(Console.ReadLine()) - scatti;
            }
            while (scatti < 0);
            costoScattiPr = scattiPr * costoScatti + canone;
            costoCostoScattiTr = scatti * costoScatti + canone;
            Console.WriteLine("Costo singolo scatto {0}", costoScatti);
            Console.WriteLine("Canone fisso {0}", canone);
            Console.WriteLine("Il trimestre scorso ha speso {0}", costoScattiPr);
            Console.WriteLine("Scatti di questo trimestre : {0}", scatti);
            Console.WriteLine("Questo trimestre ha speso : {0}", costoScattiPr);
            differenza = costoScattiPr - costoCostoScattiTr;
            if (differenza < 0){
                differenza = differenza * -1;
                Console.WriteLine("Questo trimestre ha speso {0} euro in meno rispetto al mese scorso",differenza);
            }
            else
            {
                Console.WriteLine("Questo trimestre ha speso {0} euro in più rispetto al mese scorso",differenza);
            }
            Console.ReadLine();
        }
    }
}
