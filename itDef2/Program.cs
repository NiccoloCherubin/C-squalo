using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itDef2
{
    class Program
    {
        static void Main(string[] args)
        {
            //iterazione indefinata
            const int numMist = 20;
            int numIns, tentativi = 1;
            Console.WriteLine("Inserire numero");
            numIns = Convert.ToInt32(Console.ReadLine());
            while(numIns != numMist)
            {
                tentativi++;
                Console.WriteLine("Hai sbagliato. Riprova");
                numIns = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Compimenti! Hai indovinato con {tentativi} tentativi");
            Console.ReadLine();
        }
    }
}
