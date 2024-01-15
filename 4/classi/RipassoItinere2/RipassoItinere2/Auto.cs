using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipassoItinere2
{
    internal class Auto
    {
        string marca, modello, targa;
        int codice = -1;
        NumeroPosti Posti;
        public Auto()
        {
            codice++;
            targa = Ministero.Targa();
        }
        public Auto(string marca, string modello, NumeroPosti numeroPosti)
        {
            this.marca = marca;
            this.modello = modello;
            targa = Ministero.Targa();
            codice++;
            this.Posti = numeroPosti;
        }
        public string Marca
        {
            set { marca = value; }
            get { return marca; }
        }
        public string Modello
        {
            set { modello = value; }
            get { return modello; }
        }
        public int Codice
        {
            private set { codice = value; } // l'utente non può modificarlo
            get { return codice; }
        }
        public NumeroPosti numeroPosti
        {
            set { numeroPosti = (NumeroPosti)value; }
            get { return numeroPosti; }
        }
        public string StampaTutto()
        {
            return String.Format($"marca: {marca} modello: {modello} posti: {Posti} codice: {codice}");
        }


    }
}
