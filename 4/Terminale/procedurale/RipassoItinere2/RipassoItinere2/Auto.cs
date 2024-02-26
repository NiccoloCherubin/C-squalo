using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipassoItinere2
{

    internal class Auto
    {
        public override string ToString()
        {
            return String.Format($"marca: {marca} modello: {modello} posti: {Posti} targa: {targa} codice: {codice}");
        }
        string marca, modello, targa;
        int codice;
        NumeroPosti Posti;
        public Auto(string marca, string modello, NumeroPosti numeroPosti)
        {
            this.marca = marca;
            this.modello = modello;
            targa = Ministero.Targa();
            this.Posti = numeroPosti;
            codice = Flotta.SetCodiceAuto();
        }
        public NumeroPosti numeroPosti
        {
            set { numeroPosti = (NumeroPosti)value; }
            get { return Posti; }
        }
        public string Targa
        {
            get { return targa; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Modello
        {
            get { return modello; }
            set { modello = value; }
        }
        public int Codice
        {
            get { return codice; }
        }

    }
}
