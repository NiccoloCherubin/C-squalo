using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ospedale
{
    internal class paziente
    {
        string nome;
        string cognome;
        string reparto;
        double temperatura;
        public paziente(string nome, string cognome, string reparto) // costruttore
        {
            this.nome = nome;
            this.cognome = cognome;
            this.reparto = reparto;
            this.temperatura = 36;
        }
        public string GetNome()
        {
            return nome;
        }
        public string GetCognome()
        {
            return cognome;
        }
        public string GetReparto()
        {
            return reparto;
        }
        public double GetTemperatura()
        {
            return temperatura;
        }
        public void SetTemperatura(double temperatura)
        {
            this.temperatura= temperatura;
        }
        public void SetReparto(string reparto)
        {
            this.reparto = reparto;
        }
        public string Anagrafica(paziente paziente)
        {
            return string.Format($"nome: {paziente.nome} cognome: {paziente.cognome} reparto: {paziente.reparto} temperatura: {paziente.temperatura}°C");
        }
    }
}
