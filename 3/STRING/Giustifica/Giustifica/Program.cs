using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giustifica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = "La mamma va a fare la spesa";
            Giustifica80(frase.Split(' '));
            Console.ReadLine();
        }
        static void Giustifica80(string[] frase)
        {
            int spazi = (frase.Length + 1) / (frase.Length - 1);
            int volte = (frase.Length + 1) % (frase.Length - 1);
            Console.ReadLine();

        }
    }
}
