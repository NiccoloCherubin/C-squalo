using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaleDellaScuola
{
    internal class Dipendente
    {
        protected string nominativo;
        protected string genere;

        public Dipendente(string nominativo, string genere)
        {
            this.nominativo = nominativo;
            this.genere = genere;
        }
        public override string ToString()
        {
            return String.Format($"nominativo: {nominativo} genere:{genere}");
        }
    }
}
