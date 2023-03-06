using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizionario
{
    internal class BubbleSort
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 84, 5, 6, 8, 7, 9, 8, 11, 54, 32 };
            int scambio;
            string arrayS = "";
            // ordinamento array
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        scambio = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = scambio;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                arrayS = arrayS + " " + array[i];
            }
            Console.WriteLine("Eccco l'array  ordinato {0}", arrayS);
            Console.ReadLine();
        }
    }
}
