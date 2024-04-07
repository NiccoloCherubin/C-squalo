using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcessionariaVisuale
{
    internal class Auto : Veicolo
    {
        int cilindrata;
        int numeroVolumi;

        public Auto(string modello, double kmPercorsi, double costoKm,string marca ,int cilindrata, int numeroVolumi) : base(modello, kmPercorsi, costoKm,marca)
        {
            this.cilindrata = cilindrata;
            this.numeroVolumi = numeroVolumi;
        }

        public int Cilindrata { get => cilindrata;}
        public int NumeroVolumi { get => numeroVolumi;}

        public override string Stampa()
        {
            return string.Format($"modello: {Modello} - Km Percorsi: {KmPercorsi}  - costo al Km: {CostoKm}  marca {Marca}- cilindrata: {Cilindrata} - numero volumi:{NumeroVolumi}");
        }

        public static bool operator ==(Auto a, Auto b)
        {
            return a.Modello == b.Modello && a.Marca == b.Marca;
        }
        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }
    }
}
