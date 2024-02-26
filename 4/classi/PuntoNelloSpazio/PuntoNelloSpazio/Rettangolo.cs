using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoNelloSpazio
{
    internal class Rettangolo
    {
        int _base;
        int altezza;                
        Punto punto;
        public Rettangolo(int _base, int altezza, Punto punto)
        {
            this._base = _base;
            this.altezza = altezza;
            this.punto = punto;
        }
        public int Area
        {
            get { return _base * altezza; }
        }
        public int Perimetro
        {
            get { return _base * 2 + altezza * 2; }
        }
        public override string ToString()
        {
            return String.Format($"punto alto a sinistra:{punto.ToString()} base: {_base}, altezza: {altezza} perimetro: {Perimetro} area: {Area}");
        }
    }
}
