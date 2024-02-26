using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persone_Studenti
{
    internal class Studente : Persona
    {
        int matricola { get; }
        Random rand = new Random();
        public Studente(string nome, string cognome) : base(nome, cognome)
        {
            matricola = rand.Next(0,100000);
        }
        public override string ToString()
        {
            return String.Format($"Studente nome:{nome} cognome:{cognome} matricola: {matricola}");
        }
    }
}
