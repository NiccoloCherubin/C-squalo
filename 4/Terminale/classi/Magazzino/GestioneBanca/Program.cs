using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GestioneBanca
{
    internal class Program
    {
        static void Main(string[] args) //Niccolo Cherubin Fila A
        {
            string[] opzioni = {
                "Aggiungi conto corrente",
                "Prelievo",
                "Versamento",
                "Visualizza tutti i correntisti",
                "Stampa saldo totale",
                "Esci"
            };
            Banca IntesaSanPaolo = new Banca("Intesa SanPaolo");
            int scelta;
            do
            {
                scelta = Menu(opzioni, "GESTIONE BANCA");
                VerifcaScelta(scelta, IntesaSanPaolo);
            } while (scelta != opzioni.Length - 1);
        }
        static int Menu(string[] opzioni, string titolo)
        {
            Console.Clear();
            int scelta;
            Console.WriteLine(titolo);
            for (int i = 0; i < opzioni.Length; i++)
            {
                Console.WriteLine($"[{i + 1}] {opzioni[i]}");
            }
            while (!int.TryParse(Console.ReadLine(), out scelta))
            {
                Console.WriteLine("Scelta non valida. Reinserire");
            }
            return scelta - 1;
        }
        static void VerifcaScelta(int scelta, Banca banca)
        {
            switch (scelta) // chiamo i metodi scelti dall'utente nel menu
            {
                case 0:
                    // inserimento
                    try
                    {
                        banca.Aggiungi(new ContoCorrente(                            
                            InserimentoDouble("saldo"),
                            InserimentoStringa("nome"),
                            InserimentoStringa("cognome"),
                            Banca.AssegnaNConto()));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case 1:
                    // prelievo
                    if (banca.Correntisti != 0)
                    {
                        try
                        {
                            //ricerco l'utente all'interno della lista e se lo trova effettuo il prelievo
                            banca.RicercaUtente(InserimentoIntero("Numero del conto corrente")).Prelievo(InserimentoDouble("Somma da prelevare desiderata"));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                    }
                    else
                    {
                        Console.WriteLine("Banca vuota");
                    }
                    break;
                case 2:
                    // versamento
                    if (banca.Correntisti != 0)
                    {
                        banca.RicercaUtente(InserimentoIntero("Numero del conto corrente")).Versamento(InserimentoDouble("Somma da versare desiderata"));
                    }
                    else
                    {
                        Console.WriteLine("Banca vuota");
                    }
                    break;
                case 3:
                    // stampa tutti i correntisti
                    if (banca.Correntisti != 0)
                    {
                        banca.GetCopiaLista().ForEach(x => Console.WriteLine(x.ToString()));
                    }
                    else
                    {
                        Console.WriteLine("Banca vuota");
                    }
                    break;
                case 4:
                    //visualizza saldo totale
                    Console.WriteLine($" saldo totale: {banca.SaldoTotale} €");
                    break;
            }
            Console.WriteLine("Premere invio per continuare");
            Console.ReadLine();
        }
        static string InserimentoStringa(string campo)
        {
            string valore;
            do
            {
                Console.WriteLine($"Inserire {campo} dell'utente");
                valore = Console.ReadLine();
            } while (String.IsNullOrEmpty(valore));
            return valore;
        }
        static double InserimentoDouble(string campo)
        {
            double valore;
            Console.WriteLine($"Inserire {campo} dell'utente");
            while (!Double.TryParse(Console.ReadLine(), out valore) || valore < 0)
            {
                Console.WriteLine("Reinserire");
            }
            return valore;
        }
        static int InserimentoIntero(string campo)
        {
            int valore;
            Console.WriteLine($"Inserire {campo} dell'utente");
            while (!int.TryParse(Console.ReadLine(), out valore))
            {
                Console.WriteLine("Reinserire");
            }
            return valore;
        }
        
    }
}
