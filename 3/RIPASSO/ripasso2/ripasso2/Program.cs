using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ripasso2
{
    class Program
    {
        static void Main(string[] args)
        {
            int basel, altezza;
            // chiedo base rettangolo
            do
            {
                Console.WriteLine("Inserire base");
                basel = Convert.ToInt32(Console.ReadLine());
            } while (basel < 3 || basel > 30);
            // chiedo altezza rettangolo
            do
            {
                Console.WriteLine("Inserire altezza");
                altezza = Convert.ToInt32(Console.ReadLine());
            } while (altezza < 3 || altezza > 30);
            // costruisco lati rettangolo
            // altezze
            for (int i = 0; i < altezza; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + (altezza - i));
                Console.WriteLine('*');
            }
            for (int i = 0; i < altezza; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 + basel, Console.WindowHeight / 2 + (altezza - i));
                Console.WriteLine('*');
            }
            //basi
            for (int i = 0; i < basel; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 + (basel - i), Console.WindowHeight / 2);
                Console.WriteLine('*');
            }
            for (int i = 0; i < basel; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 + (basel - i), Console.WindowHeight / 2 + altezza);
                Console.WriteLine('*');
            }
            // fine rettangolo
            Console.ReadLine();
        }
    }
}
