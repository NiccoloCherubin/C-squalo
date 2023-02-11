using System;

namespace MaesraGita
{
    class Program
    {
        static void Main(string[] args)
        {
            int studenti;
            string alunno = "", nomePresente, cognomePresente;
            // inserimento dei bambini all'interno della classe
            do
            {
                Console.WriteLine("Quanti bambini ci sono in classe?");
                studenti = Convert.ToInt32(Console.ReadLine());
            } while (studenti <= 0);
            string[] nome = new string[studenti];
            string[] cognome = new string[studenti];
            // inserimento nome e cognome
            for (int i = 0; i < studenti; i++)
            {
                do
                {
                    Console.WriteLine("Inserire nome del bambino {0}", i + 1);
                    nome[i] = Console.ReadLine();
                } while (nome[i] == "");
                do
                {
                    Console.WriteLine("Inserire cognome del bambino {0}", i + 1);
                    cognome[i] = Console.ReadLine();
                } while (nome[i] == "");
            }
            // stampa degli alunni
            Console.WriteLine("Ecco gli alunni");
            for (int i = 0; i < studenti; i++)
            {
                alunno = i + 1 + " " + " " + nome[i] + " " + cognome[i];
                Console.WriteLine(alunno);
            }
            // conteggio di quelli saliti sul bus
            Console.WriteLine("Scrivere nomi dei bambini saliti sul bus");
            for (int i = 0; i < studenti; i++)
            {
                // inserimento nome ecognome per vedere se è presente
                do
                {
                    Console.WriteLine("Inserire nome del bambino");
                    nomePresente = Console.ReadLine();
                } while (nomePresente == "");

                do
                {
                    Console.WriteLine("Inserire cognome del bambino");
                    cognomePresente = Console.ReadLine();
                } while (cognomePresente == "");
                for (int k = 0; k < studenti; k++)
                {
                    if (nomePresente == nome[k])
                    {
                        if (cognomePresente == cognome[k])
                        {
                            Console.WriteLine("L'alunno {0} {1} è presente", nomePresente, cognomePresente);
                            if (i < studenti)
                            {
                                Console.WriteLine("mancano degli alunni");
                            }
                        }
                        else
                        {
                            Console.WriteLine("L'alunno inserito non è presente");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Il bambino è un imboscato");
                    }

                }
            }
            Console.ReadLine();
        }
    }
}
