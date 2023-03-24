using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paintsuvisualstudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            ConsoleKey tasto;
            int riga = 0, colonna = 0;
            int schWidht, schHeight;
            schWidht = Console.WindowWidth;
            schHeight = Console.WindowHeight;
            char matita = '.';
            bool fine = true;
            bool ins = false;
            bool canc = false;
            Console.SetCursorPosition(riga, colonna);
            Console.Write(matita);
            do
            {
                Console.SetCursorPosition(0, 28);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < Console.WindowWidth - 1; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("\rX: {0} Y: {1}", colonna, riga);

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(colonna, riga);
                if (!ins)
                {
                    Console.Write(matita);                    
                }
                if (canc)
                {
                    matita = ' ';
                }
                else
                {
                    matita = '.';
                }
                tasto = Console.ReadKey(true).Key;
                switch (tasto)
                {
                    case ConsoleKey.Escape:
                        fine = false;
                        break;
                    case ConsoleKey.RightArrow:
                        if (colonna < schWidht - 2)
                        {
                            colonna++;
                        }


                        break;
                    case ConsoleKey.LeftArrow:
                        if (colonna >= 1)
                        {
                            colonna--;
                        }

                        break;
                    case ConsoleKey.UpArrow:
                        if (riga >= 1)
                        {
                            riga--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (riga < schHeight - 1)
                        {
                            riga++;
                        }

                        break;
                    case ConsoleKey.Insert:
                        if (!ins)
                        {
                            ins = true;
                        }
                        else
                        {
                            ins = false;
                        }
                        break;
                    case ConsoleKey.Delete:
                        if (!canc)
                        {
                            canc = true;
                        }
                        else
                        {
                            canc = false;
                        }                        
                        break;
                }


            } while (fine);

            Console.ReadLine();


        }
    }
}