using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipassoItinere2
{
    internal class Flotta
    {
        List<Auto> parcoMacchine;
        string nome, autorizzazione;        
        public Flotta()
        {
            autorizzazione = Ministero.Autorizzazione(); // ministero genera autorizzazione in automatico
            parcoMacchine = new List<Auto>();
        }
        public string Nome
        {
            set { autorizzazione = value; }
            get { return nome; }
        }
        public void Aggiungi(Auto auto)
        {
            parcoMacchine.Add(auto);
        }
        public List<Auto> CopiaLista()
        {
            return parcoMacchine.ToList();
        }
        
    }
}
