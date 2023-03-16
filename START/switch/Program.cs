using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string dies;
            Console.WriteLine("Inserire giorno settimana");
            dies = Console.ReadLine();
            //if (dies == "luendì")
            //{
            //    Console.WriteLine("è il primo dies della week");
            //}
            //else
            //{
            //    if (dies == "martedì")
            //    {
            //        Console.WriteLine("è il second dies della week");
            //    }

            //    else
            //    {
            //        if (dies == "mercoledì")
            //        {
            //            Console.WriteLine("è il third dies della week");
            //        }

            //        else
            //        {
            //            if (dies == "giovedì")
            //            {
            //                Console.WriteLine("è il cuarto dies della week");
            //            }
            //            else
            //            {
            //                if (dies == "venerdì")
            //                {
            //                    Console.WriteLine("è il V dies della week");
            //                }
            //                else
            //                {
            //                    if (dies == "sabato")
            //                    {
            //                        Console.WriteLine("è il sesto dies della week");
            //                    }
            //                    else
            //                    {
            //                        if (dies == "domenica")
            //                        {
            //                            Console.WriteLine("è il septimo dies della week");
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            switch(dies)
            {
                case ("lunedì"):
                    Console.WriteLine("Primo dies");
                    break;
                case ("martedì"):
                    Console.WriteLine("secondo dies");
                    break;
                case ("mercoledì"):
                    Console.WriteLine("terzo dies");
                    break;
                case ("giovedì"):
                    Console.WriteLine("quarto dies");
                    break;
                case ("venerdì"):
                    Console.WriteLine("quinto dies");
                    break;
                case ("sabato"):
                    Console.WriteLine("sesto dies");
                    break;
                case ("domenica"):
                    Console.WriteLine("settimo dies");
                    break;
                default:
                    Console.WriteLine("Te sì marso");
                    break;
            }
            Console.ReadLine();                            
        }

    }
}
