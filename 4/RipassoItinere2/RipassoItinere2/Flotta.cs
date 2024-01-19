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
        static int codiceAuto;
        public Flotta()
        {
            autorizzazione = Ministero.Autorizzazione(); // ministero genera autorizzazione in automatico
            parcoMacchine = new List<Auto>();
        }
        public string Autorizzazione
        {
            get { return autorizzazione; }
        }
        public string Nome
        {
            set { autorizzazione = value; }
            get { return nome; }
        }
        public int NElementi
        {
            get { return parcoMacchine.Count; }
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
        public Auto TrovaDaTarga(string targa)
        {
            if (!parcoMacchine.Exists(x => x.Targa == targa))
            {
                throw new Exception("L'auto non esiste");
            }
            return parcoMacchine.Find(x => x.Targa == targa);            
        }        
        public List<Auto> MacchineConNumeroPosti(NumeroPosti posti)
        {
            if (!parcoMacchine.Exists(x => x.numeroPosti == posti))
            {
                throw new Exception("Non esiste nessuna macchina con quel numero di posti");
            }
            return parcoMacchine.FindAll(x=> x.numeroPosti == posti);
        }
        public static int SetCodiceAuto()
        {
            codiceAuto++;
            return codiceAuto;
        }
    }
}
