using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persone_Studenti
{
    internal class Studente : Persona
    {
        int matricola { get; }
        Random rand = new Random();
        public Studente(string nome, string cognome, Image immagine) : base(nome, cognome, immagine)
        {
            matricola = rand.Next(0,100000);
        }
        public override string ToString()
        {
            return String.Format($"Studente nome:{nome} cognome:{cognome} matricola: {matricola}");
        }
    }
}
