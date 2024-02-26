using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoNelloSpazio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rettangolo rettangolo = new Rettangolo(10,20, new Punto(2,4));
            Console.WriteLine(rettangolo.ToString());
            Console.ReadLine();
        }
    }
}
