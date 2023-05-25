using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form
{
    internal class Program
    {
        static int dimensione;
        static void Main(string[] args)
        {
            // far inserire le cose all'utente
            string stringa;
            InserimentoParamentri(out int x, out int y, out dimensione, out int coloreSfondo, out int coloreTesto);
            Console.Clear(); // pulisco le schermo per dare spazio
            Pannello(0, 1, (ConsoleColor)coloreSfondo, (ConsoleColor)coloreTesto);
            stringa = Lettura(0, 1, (ConsoleColor)coloreSfondo, (ConsoleColor)coloreTesto);
            Scrittura(stringa, x, y, (ConsoleColor)coloreSfondo, (ConsoleColor)coloreTesto);

            Console.ReadLine();
        }
        // verifica se un parametro inserito dall'utente d
        static void MaggioreZero(ref int parametro)
        {
            while (parametro <= 0)
            {
                Console.WriteLine("parametro inserito non valido. Reinserire un numero maggiore di 0");
                parametro = Convert.ToInt32(Console.ReadLine());
            }
        }
        //controllo dei parametri colore inseriti dall'utente
        static void ControlloColore(ref int colore)
        {
            while (colore < 0 || colore > 16)
            {
                Console.WriteLine("parametro inserito non valido. Reinserire un numero maggiore di 0 e minore di 16");
                colore = Convert.ToInt32(Console.ReadLine());
            }
        }
        // inserimetno + controlli(metodi) dei parametri che inserirà l'utente
        static void InserimentoParamentri(out int x, out int y, out int dimensione, out int coloreSfondo, out int coloreTesto)
        {
            Console.WriteLine("Inserire x dove stampare la scritta");
            x = Convert.ToInt32(Console.ReadLine());
            MaggioreZero(ref x);
            Console.WriteLine("Inserire y dove stampare la scritta");
            y = Convert.ToInt32(Console.ReadLine());
            MaggioreZero(ref y);
            Console.WriteLine("Inserire lunghezza di quanto si vuole scrivere");
            dimensione = Convert.ToInt32(Console.ReadLine());
            MaggioreZero(ref dimensione);
            for (int i = 0; i <= (int)ConsoleColor.White; i++)
            {
                Console.WriteLine($"{i + 1} - {(ConsoleColor)i}");
            }            
            Console.WriteLine("Scegli un numero per il colore dello sfondo");
            coloreSfondo = Convert.ToInt32(Console.ReadLine());
            --coloreSfondo;
            ControlloColore(ref coloreSfondo);
            Console.WriteLine("Scegli un numero per il colore del testo");
            coloreTesto = Convert.ToInt32(Console.ReadLine());
            --coloreTesto;
            ControlloColore(ref coloreTesto);

        }
        // stampa quello che ha inserito l'utente nella posizione scelta da esso e con i colori scelti da lui
        static void Scrittura(string stringa, int x, int y, ConsoleColor coloreSfondo, ConsoleColor coloreTesto)
        {
            Console.SetCursorPosition(x, y);
            Console.BackgroundColor = coloreSfondo;
            Console.ForegroundColor = coloreTesto;
            Console.WriteLine(stringa);
        }
        // legge la stringa che inserirà l'utente
        static string Lettura(int x, int y, ConsoleColor coloresFondo, ConsoleColor coloreTesto)
        {
            ConsoleKeyInfo tasto;
            Console.BackgroundColor = ConsoleColor.Black; // per far capire all'utente che diminuisce lo spazio
            string stringa = "";
            Console.SetCursorPosition(x, y - 1);
            Console.WriteLine("Inserire stringa non superiore a dimensione");
            do
            {
                tasto = Console.ReadKey();
                stringa += tasto.KeyChar; // per salvare carattere premuto
                x++;
            } while (x < dimensione);


            return stringa;
        }
        // stampa rettangolo dove scriverà l'utente
        static void Pannello(int x, int y, ConsoleColor coloreSfondo, ConsoleColor coloreTesto)
        {
            // rettangolo
            Console.BackgroundColor = coloreSfondo;
            for (int i = 0; i < dimensione; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(" ");
                x++;
            }

        }
    }
}
