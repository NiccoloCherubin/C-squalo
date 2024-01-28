using System;
using System.Threading;

class Program
{
    static void Main()
    {        
        Console.WriteLine("Benvenuto alle Slot Machines!");

        while (true)
        {
            Console.WriteLine("\nPremi Enter per giocare o 'q' per uscire.");
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
            {
                Console.WriteLine("Grazie per aver giocato. Arrivederci!");
                break;
            }

            GiocaSlotMachine();
        }
    }

    static void GiocaSlotMachine()
    {
        Console.WriteLine("\nGirando i rulli...");

        Random random = new Random();

        // Simula l'effetto di rotazione dei rulli
        int[] risultatiRulli = new int[3];
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                risultatiRulli[j] = random.Next(1, 4);
            }

            MostraRulliInMovimento(risultatiRulli);
            Thread.Sleep(100); // Aggiunge un piccolo ritardo tra le rotazioni dei rulli
        }

        // Simula l'arresto dei rulli
        Console.Clear();
        MostraRulliFermi(risultatiRulli);

        // Mostra i risultati finali
        Console.WriteLine($"\nRisultati: {risultatiRulli[0]} {risultatiRulli[1]} {risultatiRulli[2]}");

        // Verifica se l'utente ha vinto
        if (risultatiRulli[0] == risultatiRulli[1] && risultatiRulli[1] == risultatiRulli[2])
        {
            Console.WriteLine("Hai vinto! 🎉");
        }
        else
        {
            Console.WriteLine("Spiacente, non hai vinto. 😞");
        }
    }

    static void MostraRulliInMovimento(int[] valori)
    {
        Console.Clear();
        Console.WriteLine("Girando i rulli...");
        Console.WriteLine($"\n   {valori[0]}   ");
        Console.WriteLine($"\n   {valori[1]}   ");
        Console.WriteLine($"\n   {valori[2]}   ");
    }

    static void MostraRulliFermi(int[] valori)
    {
        Console.Clear();
        Console.WriteLine("Risultati:");
        Console.WriteLine($"\n   {valori[0]}   ");
        Console.WriteLine($"\n   {valori[1]}   ");
        Console.WriteLine($"\n   {valori[2]}   ");
    }
}
