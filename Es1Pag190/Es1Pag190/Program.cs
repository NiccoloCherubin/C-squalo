using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es1Pag190
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, somma = 0;
            Console.WriteLine("Inserire un numero");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= num ; num--) 
            {
                somma = somma + num;                
            }
            Console.WriteLine("La somma è {0}",somma);
            Console.ReadLine();
        }
    }
}
