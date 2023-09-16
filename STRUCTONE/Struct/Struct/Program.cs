using System;
using System.Dynamic;
using System.Web;
using System.IO;
using System.Threading.Tasks;

namespace Struct
{
    internal class Program
    {
        struct Biblioteca
        {
            public string titolo;
            public string autore;
            public int prezzo;
        }
        // buttini
        static void Main(string[] args)
        {
            Console.WriteLine("prova");
            Biblioteca[] libri = new Biblioteca[5];
            for(int i = 0; i < libri.Length; i++)
            {
                libri[i].titolo = Console.ReadLine();
            }
        }
    }
}
