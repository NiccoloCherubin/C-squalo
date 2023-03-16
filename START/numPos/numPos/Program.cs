using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numPos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Inserire numero");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > 0) {
                Console.WriteLine("Il numero è positivo");
            }
            if (num < 0)
            {
                Console.WriteLine("Il numero è negativo");
            }
            else
            {
                Console.WriteLine("0 non è nè positivo nè negativo");
            }
        }
    }
}
