using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorsaClandestina
{
    internal class Auto
    {
        string scuderia;
        Pilota pilota;
        public Auto() { }
        public Auto(string scuderia, Pilota pilota)
        {
            this.scuderia = scuderia;
            this.pilota = pilota;
        }
        public void SetScuderia(string scuderia)
        {
            this.scuderia = scuderia;
        }
        public string GetScuderia()
        {
            return this.scuderia;
        }        
        public string GetAuto()
        {
            return string.Format($"scuderia: {this.scuderia} pilota: {this.pilota.StampaPilota()}");
        }
    }
}
