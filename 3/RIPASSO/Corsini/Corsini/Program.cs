using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corsini
{
    internal class Program
    {

        static void Main()
        {
            int cont = 0;
            string negro = "melone nero";
            do
            {
                negro = negro.Remove(0, negro.IndexOf('o') + 1);
                cont++;
            } while (negro.IndexOf('o') != -1);
            Console.WriteLine(cont);
            Console.ReadLine();
        }
    }
}

