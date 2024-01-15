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
        int codice = 0;
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
            get { return Posti; }
        }
        public string Targa
        {
            get { return targa; }
        }
        


    }
}
