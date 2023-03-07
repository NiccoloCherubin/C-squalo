using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadKey
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo tasto;
            char matita = '.';
            do
            {
                // se metto true memorizza ma non fa vedere i tasti che premi
                // ritorna valore ConsoleKeyInfo
                // può essere usato in due modi


                tasto = Console.ReadKey(true);


                switch (tasto.Key)
                {
                    case (ConsoleKey.LeftArrow):
                        Console.CursorLeft--;
                        break;
                    case (ConsoleKey.RightArrow):
                        if (Console.WindowWidth < Console.CursorLeft)
                        {
                            Console.CursorLeft++;
                        }
                        break;
                    case (ConsoleKey.UpArrow):
                        Console.CursorTop--;
                        Console.CursorLeft++;
                        break;
                    case (ConsoleKey.DownArrow):
                        Console.CursorTop++;
                        Console.CursorLeft--;
                        break;
                }
                Console.Write(matita);
            } while (tasto.Key != ConsoleKey.Enter); // diverso da invio


        }
    }
}
