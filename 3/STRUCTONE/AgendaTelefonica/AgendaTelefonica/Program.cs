using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefonica
{
    internal class Program
    {
        struct Agenda
        {
            public string nome;
            public string cognome;
            public string numero;
        }
        static void Main(string[] args)
        {
            int posizione;
            int scelta = 0;
            sbyte cont = 0; // contatore di contatti
            const short max = 100;
            Agenda[] agenda = new Agenda[max];
            const int opMax = 7;
            string ricercato;
            Riempi(agenda, ref cont);
            do
            {
                Menu(out scelta, opMax);
                if (scelta == opMax)
                {
                    break;
                }
                else
                {
                    switch (scelta)
                    {
                        case 1:
                            Riempi(agenda, ref cont);
                            break;
                        case 2:
                            PrintArr(agenda, cont);
                            break;
                        case 3:
                            Console.WriteLine("Inserire numero del contatto di qui si vuole modificare le generalità");
                            ricercato = Console.ReadLine();
                            posizione = Ricerca(agenda, cont, ricercato);
                            if (posizione != -1)
                            {
                                ModificaContatto(agenda, posizione);
                            }
                            else
                            {
                                Console.WriteLine($"Il numero {ricercato} non risulta presente nella rubrica");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Inserire numero del contatto di qui si vuole modificare le generalità");
                            ricercato = Console.ReadLine();
                            posizione = Ricerca(agenda, cont, ricercato);
                            if (posizione != -1)
                            {
                                Elimination(agenda, cont, posizione);

                            }
                            else
                            {
                                Console.WriteLine($"Il numero {ricercato} non risulta presente nella rubrica");
                            }
                            break;
                        case 5:
                            Console.WriteLine("Scrivere numero del contatto da cercare nella rubrica");
                            ricercato = Console.ReadLine();
                            Console.WriteLine("Il contatto da lei cercato è alla posizione {0} della sua rubrica", Ricerca(agenda, cont, ricercato) + 1);
                            break;
                        case 6:
                            Console.WriteLine("Allargamento avvenuto con successo");
                            break;
                    }
                    Console.WriteLine("Premere invio per continuare");
                    Console.ReadLine();
                }
            } while (true);
        }
        // torna struct piena
        static void Riempi(Agenda[] agenda, ref sbyte cont)
        {
            string risposta;
            if (cont < agenda.Length)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine($"Inserire nome del contannto numero {cont + 1}");
                    agenda[cont].nome = Console.ReadLine();
                    Console.WriteLine($"Inserire cognome del contannto numero {cont + 1}");
                    agenda[cont].cognome = Console.ReadLine();
                    Console.WriteLine($"Inserire numero del contannto numero {cont + 1}");
                    agenda[cont].numero = Console.ReadLine();
                    cont++;
                    Console.WriteLine("Scrivere '-1' per uscire");
                    risposta = Console.ReadLine();
                    if (risposta == "-1")
                    {
                        break;
                    }
                } while (cont < agenda.Length);
            }
            else
            {
                Console.WriteLine("Agenda piena");
            }
        }
        // stmapa menù
        static void Menu(out int scelta, int opMax)
        {
            bool valido;
            Console.Clear();
            Console.WriteLine("Premere [1] per aggiungere contatti");
            Console.WriteLine("Premere [2] per stampare agenda");
            Console.WriteLine("Premere [3] per modificare un contatto");
            Console.WriteLine("Premere [4] per eliminare un contatto");
            Console.WriteLine("Premere [5] per cercare un contatto");
            Console.WriteLine("Premere [6] per espandere rubrica");
            Console.WriteLine($"Premere [{opMax}] per uscire");

            do
            {
                Console.WriteLine("Inserire un opzione");
                valido = !int.TryParse(Console.ReadLine(), out scelta);
            } while (valido || scelta > opMax);
        }
        static void PrintArr(Agenda[] agenda, int cont)
        {
            for (int i = 0; i < cont; i++)
            {
                Console.WriteLine($"Nome del contatto {i + 1} : {agenda[i].nome}");
                Console.WriteLine($"Cognome del contatto {i + 1} : {agenda[i].cognome}");
                Console.WriteLine($"Numero del contatto {i + 1} : {agenda[i].numero}");
            }
        }
        static int Ricerca(Agenda[] agenda, sbyte cont, string ricercato)
        {
            for (int i = 0; i < cont; i++)
            {
                if (agenda[i].numero == ricercato)
                {
                    return i;
                }
            }
            return -1;
        }
        static void ModificaContatto(Agenda[] agenda, int posizione)
        {
            string risposta;
            do
            {
                Console.WriteLine("Cosa vuoi modifcare del contatto?");
                Console.WriteLine("[1] nome");
                Console.WriteLine("[2] cognome");
                Console.WriteLine("[3] numero");
                Console.WriteLine(" Digitare '-1' per uscire");
                risposta = Console.ReadLine();
                switch (risposta)
                {
                    case "1":
                        Console.WriteLine("Inserire nuovo nome");
                        agenda[posizione].nome = Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Inserire nuovo cognome");
                        agenda[posizione].cognome = Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Inserire nuovo numero");
                        agenda[posizione].numero = Console.ReadLine();
                        break;
                }
            } while (risposta != "-1");
        }
        static void Elimination(Agenda[] agenda, sbyte cont, int posizone)
        {
            for (int i = posizone; i < cont - 1; i++)
            {
                agenda[i].numero = agenda[i + 1].numero;
            }
        }
        static void SgrandaVettore(ref Agenda[] agenda)
        {
            // se devo inserire passo per valore
            // se voglio creare si usa per out
            // se voglio cambiare dimensioner per ref
            Agenda[] c2 = new Agenda[agenda.Length + 1];
            for (int i = 0; i < agenda.Length; i++)
            {
                c2[i] = agenda[i];
            }
            agenda = c2;

        }
    }
}
