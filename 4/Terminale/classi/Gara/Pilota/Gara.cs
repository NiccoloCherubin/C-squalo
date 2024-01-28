using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CorsaClandestina
{
    internal class Gara
    {
        //        GARA
        //        nome
        //risultato
        //griglia partenza = lista auto
        //metodo CorriGara farà vincere randomicamente una macchina

        List<Auto> grigliaPartenza;
        int risultato;
        string nome;
        int posti = 5;
        Cronometro cronometro;
        public Gara()
        {
            grigliaPartenza = new List<Auto>();
            this.risultato = 0;
            this.nome = null;
            this.posti = 5;
            this.cronometro = new Cronometro();
        }
        public Gara(string nome, List<Auto> grigliaPartenza, int posti)
        {
            this.nome = nome;
            this.grigliaPartenza = grigliaPartenza;
            this.posti = posti;
            this.cronometro = new Cronometro();
        }
        public void SetGrigliaPartenza(List<Auto> grigliaPartenza)
        {
            this.grigliaPartenza = grigliaPartenza;
        }
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
        //torna chi è arrivato primo
        //ritorna un intero che corrisponde al vincitore della gara
        public int SetRisultato()
        {
            cronometro.Start();
            if (grigliaPartenza.Count > 1)
            {
                Random random = new Random();
                cronometro.Stop();
                return this.risultato = random.Next(0, grigliaPartenza.Count);
            }
            throw new Exception("macchine insufficienti per effettuare una corsa");
        }
        public Cronometro Cronometro { get { return cronometro; } }
        public void AggiungiAuto(Auto auto)
        {
            if (grigliaPartenza.Count == posti)
            {
                throw new Exception("Griglia piena");
            }
            grigliaPartenza.Add(auto);
        }
        //torna copia della lista delle auto
        public List<Auto> GetLista()
        {
            return grigliaPartenza.ToList();
        }
    }
}
