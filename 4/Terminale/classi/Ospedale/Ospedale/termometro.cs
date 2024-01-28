using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ospedale
{
    internal class termometro
    {
        //deve dire di quanto varia rispetto a 36
        double temperatura;        
        public void SetTemperatura(double temperatura)
        {
            this.temperatura = temperatura;
        }
        public double GetTemperatura()
        {
            return temperatura;
        }
    }
}
