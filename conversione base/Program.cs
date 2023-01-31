using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace conversione_base
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input; // valore inserito dall'utente
            int resto; // resto della divisione per la base
            const int basel = 16; // base di conversione
            string convertito = ""; // numero convertito
            string restoStr = ""; // per convertire convertito in stringa
            string[] lettere = new string[6];
            // lettere per la conversione
            lettere[0] = "A";
            lettere[1] = "B";
            lettere[2] = "C";
            lettere[3] = "D";
            lettere[4] = "E";
            lettere[5] = "F";
            do
            {
                Console.WriteLine("Inserire valore di massimo un byte (255)");
                input = Convert.ToInt32(Console.ReadLine());
            }
            while (input < 0 || input > 255);
            while (input != 0)
            {
                resto = input % basel;
                input = input / basel; // scompongo il numero
                //converto resto in stringa
                // verifico resto per assegnarli una lettera
                restoStr = Convert.ToString(resto);
                switch (resto)
                {
                    case 10:
                        restoStr = lettere[0];
                        break;
                    case 11:
                        restoStr = lettere[1];
                        break;
                    case 12:
                        restoStr = lettere[2];
                        break;
                    case 13:
                        restoStr = lettere[3];
                        break;
                    case 14:
                        restoStr = lettere[4];
                        break;
                    case 15:
                        restoStr = lettere[5];
                        break;
                }
                convertito = restoStr + convertito;  // scrivo il numero convertito
            }
            Console.WriteLine("Il numero converito in base {0} è {1:0000000}", basel, convertito);
            Console.ReadLine();
        }
    }
}
