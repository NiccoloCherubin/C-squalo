using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcessionariaVisuale
{
    internal class Moto : Veicolo
    {
        int numeroTempi;
        bool portaCasco;

        public Moto(string modello, double kmPercorsi, double costoKm,string marca, int numeroTempi, bool portaCasco) : base( modello, kmPercorsi, costoKm,marca)
        {
            this.numeroTempi = numeroTempi;
            this.portaCasco = portaCasco;
        }

        public int NumeroTempi { get => numeroTempi; }
        public bool PortaCasco { get => portaCasco; }

        public override string Stampa()
        {
            return string.Format($"modello: {Modello} - Km Percorsi: {KmPercorsi}  - costo al Km: {CostoKm}-marca{Marca} - numero tempi: {NumeroTempi} - porta casco:{PortaCasco}");
        }

        public static bool operator == ( Moto a, Moto b )
        {
            return a.Modello == b.Modello && a.Marca == b.Marca;
        }
        public static bool operator !=(Moto a, Moto b)
        {
            return !(a == b);
        }
    }
}
