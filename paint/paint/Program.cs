using System;

internal class Program
{
    struct Studente
    {
        public string nome;
        public string cognome;
        public int matricola;
        public char letteraPreferita;
    }
    static void Main(string[] args)
    {
        Studente[] classe3F = new Studente[23];
        Studente st1 = new Studente();
        st1.nome = "Luca";
        st1.cognome = "Rossi";
        st1.matricola = 37;
        st1.letteraPreferita = 'z';
        Console.WriteLine(st1.nome);
        Console.WriteLine(st1.cognome);
        Console.WriteLine(st1.matricola);
        Console.WriteLine(st1.letteraPreferita);
        Console.WriteLine("*****************************");
        Studente st2 = new Studente();
        st2.nome = "Edoardo";
        st2.cognome = "Verdi";
        Console.WriteLine(st2.nome);
        Console.WriteLine(st2.cognome);
        Console.WriteLine(st2.matricola);
        Console.WriteLine(st2.letteraPreferita);
        classe3F[0] = st1;
        classe3F[1] = st2;
        Console.WriteLine("*********************");
        Console.WriteLine(classe3F[0].matricola);



        Console.ReadLine();
    }
}
