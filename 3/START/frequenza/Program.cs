using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frequenza
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int conta0 = 0, conta1 = 0, conta2 = 0, conta3 = 0, conta4 = 0, conta5 = 0, conta6 = 0, conta7 = 0, conta8 = 0, conta9 = 0;
            int contaF0 = 0, contaF1 = 0, contaF2 = 0, contaF3 = 0, contaF4 = 0, contaF5 = 0, contaF6 = 0, contaF7 = 0, contaF8 = 0, contaF9 = 0;
            int resto, scomposto;
            const int fine = 0;
            // inizio
            Console.WriteLine("Inseriresci un numero ( 0 per uscire)");
            numero = Convert.ToInt32(Console.ReadLine());
            while (numero != fine)
            {
                scomposto = numero;
                // inizio scomposizione numero
                while (scomposto != 0)
                {

                    resto = Math.Abs(scomposto) % 10;
                    // conta cifre
                    switch (resto)
                    {
                        case (0):
                            conta0++;
                            contaF0++;
                            break;
                        case (1):
                            conta1++;
                            contaF1++;
                            break;
                        case (2):
                            conta2++;
                            contaF2++;
                            break;
                        case (3):
                            conta3++;
                            contaF3++;
                            break;
                        case (4):
                            conta4++;
                            contaF4++;
                            break;
                        case (5):
                            conta5++;
                            contaF5++;
                            break;
                        case (6):
                            conta6++;
                            contaF6++;
                            break;
                        case (7):
                            conta7++;
                            contaF7++;
                            break;
                        case (8):
                            conta8++;
                            contaF8++;
                            break;
                        case (9):
                            conta9++;
                            contaF9++;
                            break;
                    }
                    scomposto = scomposto / 10;

                }                
                // output cifre singolo numero
                if (conta0 != 0)
                {
                    Console.WriteLine("Nel tuo numero il numero 0 era presente {0}", conta0);
                }
                if (conta1 != 0)
                {
                    Console.WriteLine("Nel tuo numero il numero 1 era presente {0}", conta1);
                }
                if (conta2 != 0)
                {
                    Console.WriteLine("Nel tuo numero il numero 2 era presente {0}", conta2);
                }
                if (conta3 != 0)
                {
                    Console.WriteLine("Nel tuo numero il numero 3 era presente {0}", conta3);
                }
                if (conta4 != 0)
                {
                    Console.WriteLine("Nel tuo numero il numero 4 era presente {0}", conta4);
                }
                if (conta5 != 0)
                {
                    Console.WriteLine("Nel tuo numero il numero 5 era presente {0}", conta5);
                }
                if (conta6 != 0)
                {
                    Console.WriteLine("Nel tuo numero il numero 6 era presente {0}", conta6);
                }
                if (conta7 != 0)
                {
                    Console.WriteLine("Nel tuo numero il numero  7 era presente {0}", conta7);
                }
                if (conta8 != 0)
                {
                    Console.WriteLine("Nel tuo numero il numero 8 era presente {0}", conta8);
                }
                if (conta9 != 0)
                {
                    Console.WriteLine("Nel tuo numero il numero 9 era presente {0}", conta9);
                }

                // riinizializzo variabili
                conta0 = conta1 = conta2 = conta3 = conta4 = conta5 = conta6 = conta7 = conta8 = conta9 = 0;
                //richiedo numero
                Console.WriteLine("Inseriresci un numero ( 0 per uscire)");
                numero = Convert.ToInt32(Console.ReadLine());
                //fine while
            }
            //output finale 
            if (contaF0 != 0)
            {
                Console.WriteLine("Nella tua serie il numero 0 era presente {0}", contaF0);
            }
            if (contaF1 != 0)
            {
                Console.WriteLine("Nella tua serie il numero 1 era presente {0}", contaF1);
            }
            if (contaF2 != 0)
            {
                Console.WriteLine("Nella tua serie il numero 2 era presente {0}", contaF2);
            }
            if (contaF3 != 0)
            {
                Console.WriteLine("Nella tua serie il numero 3 era presente {0}", contaF3);
            }
            if (contaF4 != 0)
            {
                Console.WriteLine("Nella tua serie il numero 4 era presente {0}", contaF4);
            }
            if (contaF5 != 0)
            {
                Console.WriteLine("Nella tua serie il numero 5 era presente {0}", contaF5);
            }
            if (contaF6 != 0)
            {
                Console.WriteLine("Nella tua serie il numero 6 era presente {0}", contaF6);
            }
            if (contaF7 != 0)
            {
                Console.WriteLine("Nella tua serie il numero  7 era presente {0}", contaF7);
            }
            if (contaF8 != 0)
            {
                Console.WriteLine("Nella tua serie il numero 8 era presente {0}", contaF8);
            }
            if (contaF9 != 0)
            {
                Console.WriteLine("Nella tua serie il numero 9 era presente {0}", contaF9);
            }
            Console.ReadLine();

        }
    }
}
