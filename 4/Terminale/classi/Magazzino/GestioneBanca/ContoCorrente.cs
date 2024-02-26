using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneBanca
{
    internal class ContoCorrente
    {
        double saldo;
        public int nConto { get;}
        public string nome { get;}
        public string cognome { get; }
        public ContoCorrente(double saldo, string nome, string cognome, int numero) // costruttore master
        {
            this.nConto = numero;
            this.saldo = saldo;
            this.nome = nome;
            this.cognome = cognome;
        }
        public double Saldo { get { return saldo; } private set { saldo = 10; } }
        public void Prelievo(double somma)
        {
            if (somma > saldo) // verifico che il saldo sia sufficiente per il prelievo
            {
                throw new Exception("saldo insufficiente");
            }
            saldo -= somma;
        }
        public void Versamento(double somma)
        {
            saldo += somma;
        }
        public override string ToString()
        {
            return String.Format($"nome {nome}, cognome {cognome}, saldo {saldo}, numero conto {nConto}");
        }
    }
}
