using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Ospedale
{
    internal class Reparti
    {
        termometro termometro;
        List<paziente> pazientiList;
        string reparto;
        int nPazineti;
        public Reparti(string reparto) //costruttore
        {
            this.reparto = reparto;
            termometro = new termometro();
            this.nPazineti = 5;
            pazientiList = new List<paziente>(nPazineti);
        }
        public Reparti(int letti, string reparto) // costruttore
        {
            this.reparto = reparto;
            termometro = new termometro();
            pazientiList = new List<paziente>(letti);
        }
        public void Aggiungi(paziente paziente)
        {
            if (pazientiList.Count > nPazineti)
            {
                throw new Exception("Reparto pieno");
            }
            else
            {
                pazientiList.Add(paziente);
            }
        }
        public int GetPazineti()
        {
            return pazientiList.Count;
        }
        public void StampaPazienti()
        {
            foreach(paziente paziente in pazientiList)
            {
                Console.WriteLine($"nome: {paziente.GetNome()} cognome: {paziente.GetCognome()} temperatura: {paziente.GetTemperatura()} reparto:{reparto}");                
            }
        }
    }
}
