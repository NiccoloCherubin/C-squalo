using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6p142
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double spesa, sconto = 0;
            const double sconto1 = 0.05, sconto2 = 0.06, sconto3 = 0.07, sconto4 = 0.1;
            const int tar1 = 50, tar2 = 65, tar3 = 80;
            do
            {
                Console.WriteLine("Inserire totale spesa");
                spesa = Convert.ToInt32(Console.ReadLine());
            }
            while (spesa <= 0);
            if (spesa <tar1)
            {
                sconto = spesa * sconto1;
                spesa = spesa - sconto;
                if (spesa < tar2)
                {
                    sconto = spesa * sconto2;
                    spesa = spesa - sconto;
                    if (spesa < tar3)
                    {
                        sconto = spesa * sconto3;
                        spesa = spesa - sconto;
                    }
                }
            }
            else
            {
                sconto = spesa * sconto4;
                spesa = spesa - sconto;
            }
            Console.WriteLine("Lo sconto è di {0}", sconto);
            Console.WriteLine("Quindi l'importo da pagare è di {0}", spesa);
            Console.ReadLine();
        }
    }
}
