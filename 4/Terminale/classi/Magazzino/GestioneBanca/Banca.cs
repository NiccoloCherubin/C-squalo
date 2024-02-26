using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneBanca
{
    internal class Banca
    {
        List<ContoCorrente> bancaList;
        string nome { get; set; }
        static int Nconto;
        int correntisti;
        double saldoTotale;
        public Banca(string nome)
        {
            this.nome = nome;
            bancaList = new List<ContoCorrente>();
        }
        public int Correntisti
        {
            get { return bancaList.Count; }
        }
        public double SaldoTotale
        {
            get { return CalcolaSaldoTotale(); }
        }
        public void Aggiungi(ContoCorrente contoCorrente)
        {
            if (bancaList.Exists(x => x.nome == contoCorrente.nome && x.cognome == contoCorrente.cognome)) // verifico che non ci siano doppioni all'interno della lista
            {
                throw new Exception("Conto corrente già presente all'interno della banca");
            }
            bancaList.Add(contoCorrente);
        }
        public ContoCorrente RicercaUtente(int Nconto)
        {
            if (bancaList.Exists(x => x.nConto == Nconto))
            {
                return bancaList.FindLast(x => x.nConto == Nconto);
            }
            throw new Exception("Non esiste l'utente ricercato");
        }
        public List<ContoCorrente> GetCopiaLista()
        {
            return bancaList.ToList();
        }
        public static int AssegnaNConto()
        {
            Nconto++;
            return Nconto;
        }
        private double CalcolaSaldoTotale()
        {
            double sum = 0;
            bancaList.ForEach(x => { sum += x.Saldo; });
            return sum;

        }

    }
}
