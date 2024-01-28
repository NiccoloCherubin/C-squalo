using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CorsaClandestina
{
    internal class Cronometro
    {
        // start e stop
        // metodo genera tempo. Ogni auto ha un tempo
        // proprietà che torna un tempo
        private DateTime startTime;
        private DateTime stopTime;
        public Cronometro() { }
        public void Start()
        {
            startTime = DateTime.Now;
        }
        public void Stop()
        {
            Thread.Sleep(100);
            stopTime = DateTime.Now;
        }
        public TimeSpan GeneraTempo()
        {            
            return stopTime - startTime;
        }


    }
}
