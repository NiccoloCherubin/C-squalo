using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace lancioDado
{
    class dado
    {
        static void Main(string[] args)
        {
            // dichiarazione variabili
            string giocatore1, giocatore2;
            int centerx, centery, punteggio1, punteggio2, faccia = 0, facciaVis;

            // creo il random che deciderà che faccia del dado visualizzare
            Random dado = new Random();
            centery = Console.WindowHeight / 2;
            centerx = Console.WindowWidth / 2;

            // faccio inserire i nomi ai giocatori
            Console.WriteLine("Inserire nome giocatore 1");
            giocatore1 = Console.ReadLine();
            Console.WriteLine("Inserire nome giocatore 2");
            giocatore2 = Console.ReadLine();

            // metto le istruzioni fuori dal ciclo perché sennò farei riscrivere le stesse cose nello stesso punto ogni ripetizione del ciclo
            Console.SetCursorPosition(centerx - 7, centery);
            Console.WriteLine("=======");
            Console.SetCursorPosition(centerx - 7, centery + 4);
            Console.WriteLine("=======");

            // uso il for perché so che devo ripetere le stesse istruzioni due volte
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine($"{giocatore1} prema un tasto per tirare il dado");
                Console.ReadKey(); // per far tirare il dado quando si preme un tasto
                faccia = 0; // metto faccia = 0 per non fare un ciclo infinto
                facciaVis = dado.Next(1, 7); // metto 7 perché l'estremo maggiore è escluso
                Console.WriteLine("La faccia che visualizzerai sarà quella con il numero {0}", facciaVis - 1); // scrivo all'utente la faccia che visualizzerà
                for (int j = 1; j <= 7; j++) // uso j per il for precedente
                {
                    faccia++;
                    if (faccia == 1)
                    {
                        Console.SetCursorPosition(centerx - 7, centery + 1);
                        Console.WriteLine("=     =");
                        Console.SetCursorPosition(centerx - 7, centery + 2);
                        Console.WriteLine("=  0  =");
                        Console.SetCursorPosition(centerx - 7, centery + 3);
                        Console.WriteLine("=     =");
                        Console.SetCursorPosition(centerx - 7, centery + 4);
                    }
                    else if (faccia == 2)
                    {
                        Console.SetCursorPosition(centerx - 7, centery + 1);
                        Console.WriteLine("=0    =");
                        Console.SetCursorPosition(centerx - 7, centery + 2);
                        Console.WriteLine("=     =");
                        Console.SetCursorPosition(centerx - 7, centery + 3);
                        Console.WriteLine("=    0=");
                    }
                    else if (faccia == 3)
                    {
                        Console.SetCursorPosition(centerx - 7, centery + 1);
                        Console.WriteLine("=0    =");
                        Console.SetCursorPosition(centerx - 7, centery + 2);
                        Console.WriteLine("=  0  =");
                        Console.SetCursorPosition(centerx - 7, centery + 3);
                        Console.WriteLine("=    0=");
                    }
                    else if (faccia == 4)
                    {
                        Console.SetCursorPosition(centerx - 7, centery + 1);
                        Console.WriteLine("=0   0=");
                        Console.SetCursorPosition(centerx - 7, centery + 2);
                        Console.WriteLine("=     =");
                        Console.SetCursorPosition(centerx - 7, centery + 3);
                        Console.WriteLine("=0   0=");
                    }
                    else if (faccia == 5)
                    {
                        Console.SetCursorPosition(centerx - 7, centery + 1);
                        Console.WriteLine("=0   0=");
                        Console.SetCursorPosition(centerx - 7, centery + 2);
                        Console.WriteLine("=  0  =");
                        Console.SetCursorPosition(centerx - 7, centery + 3);
                        Console.WriteLine("=0   0=");
                    }
                    else if (faccia == 6)
                    {
                        Console.SetCursorPosition(centerx - 7, centery + 1);
                        Console.WriteLine("=0   0=");
                        Console.SetCursorPosition(centerx - 7, centery + 2);
                        Console.WriteLine("=0   0=");
                        Console.SetCursorPosition(centerx - 7, centery + 3);
                        Console.WriteLine("=0   0=");
                        faccia = facciaVis;
                    }
                    Thread.Sleep(1000); // per far vedere le facce che cambiano all'utente
                }
            }
            Console.ReadLine();
        }
    }
}