using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maggMin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, magg, min;
            Console.WriteLine("Inserire numero 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserire numero 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 < num2) {
                min = num1;
                magg = num2;
            }
            if (num1 > num2)
            {
                min = num2;
                magg = num1;
            }
            else
            {
                Console.WriteLine("{0} e {1} sono uguali", num1, num2);
            }
            Console.WriteLine($"Il maggiore è {magg}");
            Console.WriteLine($"Il minore è {min}");
            Console.ReadLine();
        }
    }
}
