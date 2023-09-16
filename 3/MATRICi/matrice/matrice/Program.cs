using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrice = new int[5, 4]; // righe, colonne
            matrice[4, 2] = 5;
            Console.WriteLine(matrice.Length);
        }
    }
}
