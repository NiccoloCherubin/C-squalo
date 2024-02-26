using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoNelloSpazio
{
    internal class Punto
    {
        public int x { get; set; }
        public int y { get; set; }
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        static public bool operator ==(Punto p1, Punto p2)
        {
            return (p1.x == p2.x && p1.y == p2.y);
        }
        static public bool operator !=(Punto p1, Punto p2)
        {
            return !(p1 == p2);
        }
        public override string ToString()
        {
            return String.Format($"({x},{y})");
        }

    }
}
