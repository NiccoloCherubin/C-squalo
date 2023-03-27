using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SassoCartaForbici
{
    internal class Program
    {
        struct Info
        {
            public string mossa1;
            public string mossa2;
            public string vincitore;
        }
        static void Main(string[] args)
        {
            string scelta1, scelta2;
            int partite = 0;
            int vinte1 = 0, vinte2 = 0;
            const int maxPartite = 5;
            Info[] giocate = new Info[maxPartite];
            while (partite < maxPartite)
            {
                if (partite == maxPartite)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Partita numero {0}", partite + 1);
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.WriteLine("GIOCATORE 1 inserire scelta. A = Carta, S = sasso; D = forbici \n premere X per uscire");
                        Console.ForegroundColor = ConsoleColor.Black;
                        scelta1 = Console.ReadLine().ToUpper();
                    } while (scelta1 != "A" && scelta1 != "S" && scelta1 != "D" && scelta1 != "X");
                    if (scelta1 == "X")
                    {
                        break;
                    }
                    else
                    {
                        giocate[partite].mossa1 = scelta1;
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine("GIOCATORE 2 inserire scelta. J = Carta, K = sasso; L = forbici \n premere X per uscire");
                            Console.ForegroundColor = ConsoleColor.Black;
                            scelta2 = Console.ReadLine().ToUpper();
                        } while (scelta2 != "J" && scelta2 != "K" && scelta2 != "L" && scelta2 != "X");
                        if (scelta2 == "X")
                        {
                            break;
                        }
                        else
                        {
                            giocate[partite].mossa2 = scelta2;

                            Console.ForegroundColor = ConsoleColor.White;
                            if ((scelta1 == "A" && scelta2 == "J") || (scelta1 == "S" && scelta2 == "K") || (scelta1 == "D" && scelta2 == "L"))
                            {
                                Console.WriteLine("PAREGGIO");
                            }
                            else
                            {
                                if ((scelta1 == "A" && scelta2 == "K") || (scelta1 == "S" && scelta2 == "L") || (scelta1 == "D" && scelta2 == "J"))
                                {
                                    Console.WriteLine("Ha vinto il giocatore 1");
                                    vinte1++;
                                    giocate[partite].vincitore = "giocatore 1";
                                }
                                else
                                {
                                    Console.WriteLine("Ha vinto il giocatore 2");
                                    vinte2++;
                                    giocate[partite].vincitore = "giocatore 2";
                                }
                            }
                        }

                    }
                    Console.WriteLine("Premere invio per continuare");
                    Console.ReadLine();
                    partite++; // incremento numero di partite
                }

            }
            Console.ForegroundColor = ConsoleColor.White;
            if (vinte1 + vinte2 != 0)
            {
                Console.WriteLine("Sono state giocate {0} partite", partite);
                for (int i = 0; i < partite; i++)
                {
                    Console.WriteLine("Il giocaotre uno nella partita {0} ha giocato {1} ed il giocatore 2 ha giocato {2}. Ed ha vinto il giocatore {3}", i + 1, giocate[i].mossa1, giocate[i].mossa2, giocate[i].vincitore);
                }
                if (vinte1 > vinte2)
                {
                    Console.WriteLine("Ha vinto giocatore 1 con {0} vittorie", vinte1);

                }
                else
                {
                    Console.WriteLine("Ha vinto giocatore 2 con {0} vittorie", vinte2);
                }
            }
            else
            {
                Console.WriteLine("Non sono state vinte partite");
            }
            Console.ReadLine();
        }
    }
}
