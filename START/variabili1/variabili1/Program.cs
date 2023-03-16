using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variabili1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool angelo;
            int a, b, etaMasssima, risposta;
            a = 50;
            b = 80;
            etaMasssima = 55;
            Console.WriteLine(a + b);
            string temperatura, messaggio;
            temperatura = "stringa";
            messaggio = "Ponfo è !!bellissimo";
            Console.WriteLine(temperatura);
            Console.WriteLine("Immettere la tua età");
            int eta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La tua età è " + eta + " anni");
            if (eta == etaMasssima)
            {
                Console.WriteLine(messaggio);
            }
            else
            {
                Console.WriteLine("Ora entrarai nel ciclo while");
            }
            while (eta > etaMasssima)
            {
                Console.WriteLine("banana");
                eta = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Ora entrarai nel ciclo do while");
            do
            {
                eta++;
                Console.WriteLine("Ora la tua eta è "+eta);
            }
            while (eta < etaMasssima);
            Console.WriteLine("Finito cicli");
            do
            {
                do
                {
                    Console.WriteLine("True (1) o false (0)");
                    risposta = Convert.ToInt32(Console.ReadLine());

                }
                while (risposta != 1 && risposta != 0);
                if (risposta == 1)
                {
                    angelo = true;
                }
                else
                {
                    angelo = false;
                }
                if (angelo)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("False");
                }
                Console.WriteLine("Vuoi ripetere?");
                Console.Write(" Sì (1) No (0)");
            }

            while (risposta != 1 && risposta != 0);


            Console.ReadLine();
        } 
        
    }
}
