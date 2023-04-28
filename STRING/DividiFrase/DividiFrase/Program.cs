using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividiFrase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase;
            const sbyte max = 80;
            Console.WriteLine("Inserire frase");
            frase = Console.ReadLine();
            while (string.IsNullOrEmpty(frase))
            {
                Console.WriteLine("Inserita una frase non valida\nReinserie");
                frase = Console.ReadLine();
            }
            if (frase.Length > max)
            {
                frase = frase.Substring(0, max);
            }
            frase = Taglio(frase);
            Console.WriteLine(frase);

            Console.ReadLine();

        }
        static string Taglio(string frase)
        {
            string buffer;
            int c = 0, x = 20;  // conta caratteri dopo lo spazio. 20 = lunghezza predefinita
            while (frase.Length > x)
            {
                if (frase[20] == ' ')
                {
                    buffer = frase.Substring(0, x);
                    Console.WriteLine(buffer);
                    frase = frase.Remove(0, x);
                }
                else
                {
                    while (frase[x] != ' ')
                    {
                        x--;
                        c++;
                    }
                    if (c >= x)
                    {
                        break;
                    }
                    else
                    {
                        buffer = frase.Substring(0, (x - c));
                        Console.WriteLine(buffer);
                        frase = frase.Remove(0, (x - c));
                    }
                }
                if (frase[0] == ' ')
                {
                    frase = frase.Remove(0, 1);
                }
                x = 20;
                c = 0;
            }
            return frase;

        }

    }
}