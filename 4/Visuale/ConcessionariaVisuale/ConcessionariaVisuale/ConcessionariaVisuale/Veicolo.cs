using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConcessionariaVisuale
{
    abstract internal class Veicolo
    {
        string modello;
        double kmPercorsi;
        double costoKm;
        string marca;
        const int costoNoleggio = 25;

        protected string Modello { get => modello; set => modello = value; }
        protected double KmPercorsi { get => kmPercorsi; set => kmPercorsi = value; }
        protected double CostoKm { get => costoKm; set => costoKm = value; }
        protected string Marca { get => marca; set => marca = value; }

        protected Veicolo(string modello, double kmPercorsi, double costoKm, string marca)
        {
            Modello = modello;
            KmPercorsi = kmPercorsi;
            CostoKm = costoKm;
            Marca = marca;
        }

        abstract public string Stampa();
    }
}
