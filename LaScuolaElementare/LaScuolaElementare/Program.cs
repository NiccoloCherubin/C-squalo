using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaScuolaElementare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] alunni = new string[3];
            for(int i = 0; i < alunni.Length; i++)
            {
                Console.WriteLine("Inserire nome alunno {0}", i + 1);
                alunni[i] = Console.ReadLine();
                Console.WriteLine("Mancano {0} nomi da inserire", alunni.Length- (i+1));
            }
            Console.WriteLine("La classe è piena");
            Console.ReadLine();
        }
    }
}
