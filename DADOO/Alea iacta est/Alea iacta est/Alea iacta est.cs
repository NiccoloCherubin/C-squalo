using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Alea_iacta_est
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int centerx, centery, faccia, punteggio1 = 0, punteggio2 = 0, facciaVis, j = 0;
            string giocatore1, giocatore2;
            bool fine = false, cambio = false; // per far finire il ciclo una volta che il giocatore 2 ha visto il suo risultato
            centery = Console.WindowHeight / 2;
            centerx = Console.WindowWidth / 2;
            Random dado = new Random();
            Console.WriteLine("Inserire nome giocatore 1");
            giocatore1 = Console.ReadLine();
            Console.WriteLine("Inserire nome giocatore 2");
            giocatore2 = Console.ReadLine();
            do
            {
                // per far pulizia dello schermo
                Console.Clear();
                // per far girare il dado dall'inizio
                faccia = 0;
                // per variare il messaggio in base al turno
                if(cambio == false)
                {
                    facciaVis = dado.Next(1, 6);
                    Console.WriteLine($" \n {giocatore1} prema un tasto per tirare il dado");
                    // per fare in modo che il programma aspetti l'input dell'utente per partire
                    Console.ReadKey();
                    Console.WriteLine($" \n Il valore che è uscito a {giocatore1} è {facciaVis + 1}");
                }
                else
                {                    
                    facciaVis = dado.Next(1, 6);
                    Console.WriteLine($" \n {giocatore2} prema un tasto per tirare il dado");
                    // per fare in modo che il programma aspetti l'input dell'utente per partire
                    Console.ReadKey();
                    Console.WriteLine($"\n Il valore che è uscito a {giocatore2} è {facciaVis + 1}");                    
                }
                // istruzioni fuori dal ciclo for perché sarebbero rindondanti altrimenti
                Console.SetCursorPosition(centerx - 7, centery);
                Console.WriteLine("=======");
                Console.SetCursorPosition(centerx - 7, centery + 4);
                Console.WriteLine("=======");
                for (int i = 1; i <= 7; i++)
                {
                    j++;
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
                    
                    Thread.Sleep(1000);
                }
                // fuori dal for, quindi usiamo la j invece della i
                if (j == 7 && fine == false)
                {
                    punteggio1 = facciaVis + 1;
                    fine = true;
                    faccia = 0;
                    cambio = true;
                }
                else
                {
                    punteggio2 = facciaVis + 1;
                    fine = false;
                }
            }
            while (fine == true);
            Console.Clear();
            Console.WriteLine("\n Il punteggio di {0} = {1}",giocatore1,punteggio1);
            Console.WriteLine("\n Il punteggio di {0} = {1}", giocatore2, punteggio2);
            //confronto i punteggi per vedere chi ha vinto
            if(punteggio1 == punteggio2)
            {
                Console.WriteLine("\n Avete pareggiato");
            }
            else if (punteggio1 > punteggio2)
            {
                Console.WriteLine("\n Ha vinto {0}", giocatore1);
            }
            else
            {
                Console.WriteLine("\n Ha vinto {0}", giocatore2);
            }
            Console.ReadLine();
        }
    }
}
