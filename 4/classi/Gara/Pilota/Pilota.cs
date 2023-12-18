using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace CorsaClandestina
{
    internal class Pilota
    {
        string nome, cognome;
        public Pilota() { }
        public Pilota(string nome, string cognome)
        {
            this.nome = nome;
            this.cognome = cognome;

        }
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
        public string Cognome
        {
            get { return this.cognome;}
            set { this.cognome = value; }
        }        
        public string StampaPilota()
        {
            return string.Format($"{this.cognome} {this.nome}");
        }
    }
}
