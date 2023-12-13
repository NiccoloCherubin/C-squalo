using System;
using System.Collections.Generic;
using System.Linq;
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
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public string GetNome()
        {
            return this.nome;
        }
        public void SetCognome(string cognome)
        {
            this.cognome = cognome;
        }
        public string GetCognome()
        {
            return this.cognome;
        }        
        public string StampaPilota()
        {
            return string.Format($"{this.cognome} {this.nome}");
        }
    }
}
