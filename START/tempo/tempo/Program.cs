using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tempo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, tempo;
            Console.WriteLine("Inserire il numero 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserire il numero 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 < num2) 
            {
                tempo = num1;
                num1 = num2;
                num2 = tempo;
            }
            Console.WriteLine("Il maggiore è {0}", num1);
            Console.WriteLine("Il minore è {0}", num2);
            Console.ReadLine();
        }
    }
}
