using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
        public List<paziente> GetLista()
        {
            return pazientiList.ToList();
        }

        public paziente GetPaziente(int indice)
        {
            return pazientiList[indice];
        }
        public bool Vuoto()
        {
            if (pazientiList.Count > 0)
            {
                return false; // non vuoto

            }
            else
            {
                return true; // vuoto
            }
        }
    }
}
