using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipassoItinere2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] opzioni = {
                "aggiungi",
                "visualizza",
                "elimina",
                "visualliza con ricerca",
                "salva log",
                "visualizza log"
            };
            int scelta;
            Flotta flotta = new Flotta();
            do
            {
                Console.Clear();
                scelta = Menu(opzioni, "FLOTTE DI AUTO");
                VerificaScelta(scelta, flotta);
            } while (scelta != opzioni.Length - 1);
        }
        static int Menu(string[] opzioni, string titolo)
        {
            int scelta;
            Console.WriteLine(titolo);
            for (int i = 0; i < opzioni.Length; i++)
            {
                Console.WriteLine($"[{i + 1}] {opzioni[i]}");
            }
            while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 1 || scelta > opzioni.Length)
            {
                Console.WriteLine("Inserisci qualcosa di corretto");
            }
            scelta--;
            return scelta;
        }
        static void VerificaScelta(int scelta, Flotta flotta)
        {
            switch (scelta)
            {

                case 0:
                    //aggiungi
                    flotta.Aggiungi(new Auto(InserimentoStringa("marca"), InserimentoStringa("modello"), 
                        (NumeroPosti)Menu(Enum.GetNames(typeof(NumeroPosti)), "NUMERO POSTI")
                        ));
                    Console.WriteLine("Inserimento andato a buon fine");
                    break;
                case 1:
                    //visualizza
                    flotta.CopiaLista().ForEach(x => Console.WriteLine(x.StampaTutto()));
                    break;
                case 2:
                    //elimina
                    break;
                case 3:
                    //visualizza con ricerca
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }
            Console.WriteLine("Premere invio per continuare");
            Console.ReadLine();
        }
        static string InserimentoStringa(string campo)
        {
            Console.WriteLine($"Inserire {campo} dell'auto");
            string stringa;
            stringa = Console.ReadLine();
            while (String.IsNullOrEmpty(stringa.Trim()) || !StringaValida(stringa))
            {
                Console.WriteLine("Reinserire");
                stringa = Console.ReadLine();
            }
            return stringa;
        }
        static bool StringaValida(string stringa)
        {
            for (int i = 0; i < stringa.Length; i++)
            {
                if (char.IsDigit(stringa[i]))
                {
                    return false; // stringa non valida
                }
            }
            return true; // stringa valida
        }
    }
}
