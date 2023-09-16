using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ripasso1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, resto;
            string risposta;
            const int divisibile = 5, min = 5, max = 200;

            // inizio ciclo da ripetere in base alla risposta
            do
            {
                // inizio ciclo inserimento numero
                do
                {
                    Console.WriteLine("Inserire numero");
                    numero = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                } while (numero < min || numero > max);
                Console.WriteLine("I numeri divsisibili per {0} in ordine decrescente da {1} sono", divisibile, numero);
                //inizio calcoli
                while (numero != 0)
                {
                    resto = numero % divisibile;
                    switch (resto)
                    {
                        case (0):                            
                            numero -= 5;
                            break;
                        case (1):
                            numero -= 1;
                            break;
                        case (2):
                            numero -= 2;
                            break;
                        case (3):
                            numero -= 3;
                            break;
                        case (4):
                            numero -= 4;
                            break;
                    }
                    Console.WriteLine(numero);
                }
                // chiedo e verifico risposta per ripetere ciclo
                Console.WriteLine("Vuoi ripetere il ciclo?");
                risposta = Console.ReadLine();
            } while (risposta != "no");

        }
    }
}
