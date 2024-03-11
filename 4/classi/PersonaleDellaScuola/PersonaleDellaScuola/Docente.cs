using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaleDellaScuola
{
    public enum Ruolo
    {
        supplente,
        insegnante,
        diplomato,
        insegnato_Laureato
    }
    internal class Docente : Dipendente
    {
        public string Disciplina { get; private set; }
        public Ruolo ruolo { get; private set; }

        public Docente(string nominativo, string genere, string disciplina, Ruolo ruolo) : base(nominativo, genere)
        {
            Disciplina = disciplina;
            this.ruolo = ruolo;
        }
        public override string ToString()
        {
            return String.Format($"nominativo: {nominativo} genere:{genere} disciplina: {Disciplina} ruolo:{ruolo}");
        }
    }
}
