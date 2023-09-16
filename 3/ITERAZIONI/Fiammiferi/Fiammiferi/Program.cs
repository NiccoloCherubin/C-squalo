using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiammiferi
{
    class Program
    {
        static void Main(string[] args)
        {
            const byte fiammiferiMax = 21;
            byte contFiammiferi = fiammiferiMax;
            string vincitore;
            string g1 = string.Empty, g2 = string.Empty;
            if (SceltaAvversario())
            {
                // gioca con altra persona
                InserimentoNomi(ref g1, ref g2);
                vincitore = Party(contFiammiferi, g1, g2);
            }
            else
            {
                Console.WriteLine("Inserire nome giocaotre ");
                ControlloString(ref g1);
                vincitore = Computer(contFiammiferi, g1);
            }
            Console.WriteLine($"Ha vinto {vincitore}");
            Console.ReadLine();
        }
        static void InserimentoNomi(ref string g1, ref string g2)
        {
            Console.WriteLine("Giocatore 1 inserire nome da visualizzare a video");
            ControlloString(ref g1);
            Console.WriteLine("Giocatore 2 inserire nome da visualizzare a video");
            ControlloString(ref g2);
        }
        static void ControlloString(ref string stringa)
        {
            while (String.IsNullOrEmpty(stringa))
            {
                Console.WriteLine("Inserire nome");
                stringa = Console.ReadLine();
            }

        }
        // per giocare contro un altra persona
        static string Party(byte cont, string g1, string g2)
        {
            bool cambio = false;
            byte scelta;
            string vincitore;
            do
            {
                if (cambio)
                {
                    Console.WriteLine($"turno di {g2}");
                }
                else
                {
                    Console.WriteLine($"turno di {g1}");
                }
                Console.WriteLine("Scegli quanti fiammiferi togliere (min 1 max 3)");
                while (!byte.TryParse(Console.ReadLine(), out scelta) || scelta < 1 || scelta > 3)
                {
                    Console.WriteLine("Fai una scelta valida");
                }
                cambio = !cambio; // per cambiare turno
                cont -= scelta;
                Console.WriteLine($"Rimangono : {cont} fiammiferi");
            } while (cont > 1);
            if (cambio)
            {
                vincitore = g2;
            }
            else
            {
                vincitore = g1;
            }
            return vincitore;
        }
        // quando gioca contro il computer                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      
        static string Computer(byte cont, string g1)
        {
            string vincitore;
            byte scelta;
            Random random = new Random(); // far scegliere il pc
            bool cambio = false;
            do
            {
                if (cambio)
                {
                    Console.WriteLine($"turno del pc");
                    scelta = (byte)random.Next(1, 4); // estremo massimo escluso
                    Console.WriteLine($"Il pc ha tolto {scelta} fiammiferi");
                }
                else
                {
                    Console.WriteLine($"turno di {g1}");
                    Console.WriteLine("Scegli quanti fiammiferi togliere (min 1 max 3)");
                    while (!Byte.TryParse(Console.ReadLine(), out scelta) || scelta < 1 || scelta > 3)
                    {
                        Console.WriteLine("inserire valore valido");

                    }
                }
                cambio = !cambio; // per cambiare turno
                cont -= scelta;
                Console.WriteLine($"Rimangono : {cont} fiammiferi");

            } while (cont > 1);
            if (cambio)
            {
                vincitore = "computer";
            }
            else
            {
                vincitore = g1;
            }
            return vincitore;
        }
        static bool SceltaAvversario()
        {
            string risposta;
            Console.WriteLine("Vuoi giocare col pc (sì/no)");
            risposta = Console.ReadLine().ToLower();
            if (risposta != "no")
            {
                return false;
            }
            else
            {
                return true;

            }
        }
    }
}