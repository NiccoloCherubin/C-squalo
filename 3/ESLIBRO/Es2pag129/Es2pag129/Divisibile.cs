using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es2pag129
{
    internal class Divisibile
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Inserire un numero per scoprire se è divisibile per cinque");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero % 5 == 0){
                Console.WriteLine("{0} è divisibile per 5", numero);
            }
            else
            {
                Console.WriteLine("{0} non è divisibile per 5", numero);
            }
            Console.WriteLine("Premere un tasto per continuare");
            Console.ReadLine();
        }
    }
}
