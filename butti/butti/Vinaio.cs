using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace butti
{
    internal class Vinaio
    {
        static void Main(string[] args)
        {
            long scelta, risposta, consegna, litri;
            double prezzoSoave, prezzoMerlot, prezzoProsecco, iva, prezzo, sconto ;
            string descrizioneVino , msg1 , msg2;
            msg1 = "Quanti litri di ";
            msg2 = " vuole prendere? (Solo numeri tondi)";
            prezzoSoave = 1; 
            prezzoMerlot = 1.50;
            prezzoProsecco = 3;
            iva = 0.22;
            sconto = 0.10;
            consegna = 5;
            do {
                Console.WriteLine("Che vino vuole prendere?" + "\n 1 Soave " + "\n 2 Merlot " + "\n 3 Prosecco ");
                scelta = Convert.ToInt32(Console.ReadLine());
            }
            while (scelta < 1 || scelta > 3);
            if (scelta == 1)
            {
                descrizioneVino = "soave";
                Console.WriteLine(msg1 + descrizioneVino +msg2);
                do
                {
                    litri = Convert.ToInt32(Console.ReadLine());
                }
                while (litri <= 0);
                iva = litri * iva;
                prezzo = prezzoSoave * litri + iva;
            }
            if (scelta == 2)
            {
                descrizioneVino = "merlot";
                Console.WriteLine(msg1 + descrizioneVino + msg2);
                do
                {
                    litri = Convert.ToInt32(Console.ReadLine());
                }
                while (litri <= 0);
                iva = litri * iva;
                prezzo = prezzoMerlot * litri + iva;
            }
            else
            {
                descrizioneVino = "prosecco";
                Console.WriteLine(msg1 + descrizioneVino + msg2);
                do
                {
                    litri = Convert.ToInt32(Console.ReadLine());
                }
                while (litri <= 0);
                iva = litri * iva;
                prezzo = prezzoProsecco * litri + iva;
            }
            Console.WriteLine("Desidera la consegna a domicilio?" + "\n Sì (1) No (0)");
            risposta = Convert.ToInt32(Console.ReadLine());
            if (risposta == 1)
            {
                prezzo = prezzo + consegna;                
            }
            if (litri >= 10)
            {
                sconto = prezzo * sconto;
                prezzo = prezzo - sconto;
            }

            Console.WriteLine( "SCONTRINO" + "\n Sconto = " + sconto + '€' + "\n Costo Totale = " + prezzo + '€' + "\n Iva = " + iva + '€' + "\n Litri presi =" + litri + " l" + "\n Vino preso = " +descrizioneVino);
            Console.ReadLine();
        }
    }
}
