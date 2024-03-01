using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persone_Studenti
{
    internal class Persona
    {
        public string nome { get; private set; }
        public string cognome { get; private set; }
        public Image immagine { get; private set; }
        public Persona(string nome, string cognome, Image immagine)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.immagine = immagine;
        }
        static public bool operator ==(Persona a, Persona b)
        {
            return a.nome == b.nome && a.cognome == b.cognome;
        }
        static public bool operator !=(Persona a, Persona b)
        {
            return !(a == b);
        }
        public override string ToString()
        {
            return String.Format($"PERSONA nome:{nome} cognome:{cognome}");
        }
    }
}
