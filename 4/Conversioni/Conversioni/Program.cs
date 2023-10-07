using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversioni
{
    internal class Program
    {
        struct Ip
        {
            public string ipDec;
            public string ipBin;
            public string ipHex;
        }
        static void Main(string[] args)
        {
            Ip ip = new Ip();
            ip.ipDec = "192.168.4.1";
            Console.WriteLine($" Indirizzo decimale: {ip.ipDec}");
            Console.Write("Indirizzo binario: ");
            Stampa(Convertitore(ip.ipDec, 2));
            Console.WriteLine("");
            Console.Write("Indirizzo esadecimale: ");
            Stampa(Convertitore(ip.ipDec, 16));


            Console.ReadLine();
        }
        static string[] Convertitore(string indirizzo, int baseConversione)
        {
            string[] numeri = Separatore(indirizzo);
            string[] convertiti = new string[numeri.Length];
            int numero;
            int resto;
            string convertito = "";
            for (int i = 0; i < numeri.Length; i++)
            {
                convertito = "";
                numero = Convert.ToInt32(numeri[i]);
                do
                {
                    resto = numero % baseConversione;
                    if (resto > 9)
                    {
                        char carattere = Convert.ToChar(resto + 'A' - 10);
                        convertito = carattere + convertito;
                    }
                    else
                    {
                        convertito = resto + convertito;
                    }
                    numero /= baseConversione;
                } while (numero != 0);
                convertiti[i] = convertito + '.';
            }
            return convertiti;
        }
        static string[] Separatore(string indirizzo)
        {
            return indirizzo.Split('.');
        }
        static void Stampa(string[] convertiti)
        {
            for (int i = 0; i < convertiti.Length; i++)
            {
                Console.Write(convertiti[i]);
            }
        }
    }
}
