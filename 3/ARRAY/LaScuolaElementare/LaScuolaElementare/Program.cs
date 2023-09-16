using System;

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
            while (!false)
            {
                Console.ReadLine();
            }
        }
    }
}
