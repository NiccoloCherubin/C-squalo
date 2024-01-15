using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RipassoItinere2
{
    internal class Flotta
    {        
        List<Auto> parcoMacchine;
        string nome, autorizzazione;
        int nElementi;
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
        public void EliminaAuto(Auto auto)
        {
            parcoMacchine.Remove(auto);
        }
        public string StampaAuto(Auto auto)
        {
            return auto.ToString();
        }
        public int NElementi
        {
            get { return nElementi; }
        }
    }
}
