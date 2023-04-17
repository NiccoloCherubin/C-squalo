using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TogliSpaziBianchi
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "la      mamma      va al mercato     a comprare    le    albicocche";
            string buffer;
            do
            {
                if (frase.IndexOf(' ') != 0)
                {
                    buffer = frase.Substring(0, frase.IndexOf(' '));
                    Console.Write($"{buffer} ");
                }
                frase = frase.Remove(0, frase.IndexOf(' ') + 1);
            } while (frase.IndexOf(' ') != -1);
            Console.WriteLine(frase);
            Console.ReadLine();
        }
    }
}