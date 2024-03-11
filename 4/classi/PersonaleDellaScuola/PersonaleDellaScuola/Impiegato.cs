using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PersonaleDellaScuola
{
    internal class Impiegato : Dipendente
    {
        public string Ufficio { get; private set; }
        public Impiegato(string nominativo, string genere, string ufficio) : base(nominativo, genere)
        { 
            Ufficio = ufficio;
        }
        public override string ToString()
        {
            return String.Format($"nominativo: {nominativo} genere:{genere} ufficio: {Ufficio}");
        }
    }
}
