using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusioneNucleare
{
    internal class Program
    {
        static int inseriti = -1;
        const int max = 2;

        struct Studente
        {
            public string nome;
            public string cognome;
            public double voto; // per voti mezzi
            public override string ToString()
            {
                return string.Format($"{nome,-15} {cognome,-5} {voto,10}");
            }
        }
        static void Main(string[] args)
        {
            //Struct
            // array struct
            //metodo inserimento con controllo max
            //metodo visualizza
            //controllo dati validi
            //controllo doppioni
            Studente[] classe = new Studente[max];
            int scelta;
            string[] opzioni = { "Inserisci", "Visualizza", "Esci" };
            do
            {
                scelta = Menu(opzioni);
                VerificaScelta(scelta, classe);
            } while (scelta != opzioni.Length - 1);
        }
        static int Menu(string[] opzioni)
        {
            Console.Clear();
            int scelta;
            for (int i = 0; i < opzioni.Length; i++)
            {
                Console.WriteLine($" [{i + 1}] {opzioni[i]}");
            }
            while (ControlloScelta(out scelta, opzioni.Length))
            {
                Console.WriteLine("Inserisci un valore corretto");
            }
            scelta--;
            return scelta; //l'utente vede le opzioni maggiorate di uno
        }
        static void VerificaScelta(int scelta, Studente[] studenti)
        {
            switch (scelta)
            {
                case 0:
                    //inserimento
                    if (inseriti <= max)
                    {
                        Inserimento(studenti);
                    }
                    else
                    {
                        Console.WriteLine("Classe piena");
                    }
                    Console.WriteLine("Inserimento completato. Premere invio per continuare");
                    break;
                case 1:
                    //visualizza
                    if (inseriti != -1)
                    {
                        Visualizza(studenti);
                    }
                    else
                    {
                        Console.WriteLine("Classe vuota. Fare inserimento");
                    }
                    Console.WriteLine("Premere invio per continuare");
                    break;
            }
            Console.ReadLine();
        }
        static void Inserimento(Studente[] studenti)
        {
            Studente studente = new Studente(); // per non sporcare l'array
            bool doppio;
            inseriti++;
            do
            {

                string prova;
                //inserimento nome
                Console.WriteLine($"Inserire nome dello studente {inseriti + 1}");
                while (!ControlloStringhe(Console.ReadLine(), out prova))
                {
                    Console.WriteLine("Inserire un nome corretto");
                }
                studente.nome = prova; // assegnazione nome
                Console.WriteLine($"Inserire cognome dello studente {inseriti + 1}");
                //inserimento cognome
                while (!ControlloStringhe(Console.ReadLine(), out prova))
                {

                    Console.WriteLine("Inserire un cognome corretto");
                }
                studente.cognome = prova; // assegnazione cognome
                do
                {
                    Console.WriteLine($"Inserire voto dello studente {inseriti + 1} (0-10)");
                } while (!double.TryParse(Console.ReadLine(), out studente.voto) || !ControlloVoto(studenti[inseriti].voto));

                doppio = ControlloDoppioni(studenti, studente); // controllo doppioni

                if (doppio)
                {
                    Console.WriteLine("Studente già inserito. Reinserire");
                }
            } while (doppio);

            studenti[inseriti] = studente; //inserimento studente nella classe

        }
        static bool ControlloDoppioni(Studente[] studenti, Studente studente)
        {
            for (int i = 0; i < inseriti; i++)
            {
                if (studente.nome.ToLower() == studenti[i].nome.ToLower() && studente.cognome.ToLower() == studenti[i].cognome.ToLower())
                {
                    return true; // doppione trovato
                }
            }
            return false; // doppione non trovato
        }
        static bool ControlloVoto(double voto)
        {
            if (voto < 0 || voto > 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static bool ControlloScelta(out int scelta, int lunghezza)
        {
            return !int.TryParse(Console.ReadLine(), out scelta) || scelta < 1 || scelta > lunghezza;
        }
        static bool ControlloStringhe(string prova, out string stringa)
        {
            prova = prova.Trim();
            if (String.IsNullOrEmpty(prova))
            {
                stringa = null;
                return false;
            }
            else
            {
                stringa = prova;
                return true;
            }

        }
        static void Visualizza(Studente[] classe)
        {
            for (int i = 0; i <= inseriti; i++)
            {
                Console.WriteLine($"STUDENTE {i + 1}");
                Console.WriteLine(classe[i].ToString());
                Console.WriteLine($"===================");
            }
        }       
    }
}
