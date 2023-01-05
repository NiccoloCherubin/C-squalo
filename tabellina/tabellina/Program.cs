using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabellina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, prodotto;
            Console.WriteLine("Inserire numero di cui si vuole vedere la tabellina pitagorica");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i<= 10; i++)
            {
                prodotto = num * i;
                Console.WriteLine($"{num} * {i} = {prodotto}");
            }
            Console.ReadLine();
        }
    }
}
