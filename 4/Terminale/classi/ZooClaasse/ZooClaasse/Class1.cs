using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooClaasse
{
    internal class AnimaleDomestico
    {
        public string specie, razza, cibo, verso;
        public int quantita;
        public Mangiato stato;
        public override string ToString()
        {
            return String.Format($"specie:{specie} razza:{razza} cibo:{cibo} verso:{verso} quantità:{quantita}");
        }
        public AnimaleDomestico()
        {

        }
        public AnimaleDomestico(int quantita, string specie, string razza, string cibo, string verso)
        {
            this.quantita = quantita;
            this.specie = specie;
            this.razza = razza;
            this.cibo = cibo;
            this.verso = verso;
        }
        public void SetQuantita(int quantita)
        {
            this.quantita = quantita;
        }
        public int GetQuantita()
        {
            return this.quantita;
        }
        public void SetSpecie(string specie)
        {
            this.specie = specie;
        }
        public string GetSpecie()
        {
            return this.specie;
        }
        public void SetRazza(string razza)
        {
            this.razza = razza;
        }
        public string GetRazza()
        {
            return this.razza;
        }
        public void SetCibo(string cibo)
        {
            this.cibo = cibo;
        }
        public string GetCibo()
        {
            return this.cibo;
        }
        public void SetVerso(string verso)
        {
            this.verso = verso;
        }
        public string GetVerso()
        {
            return this.verso;
        }
        public void SetStatoNutrizione(Mangiato stato)
        {
            this.stato = stato;
        }
    }
}
