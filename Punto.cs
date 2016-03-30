using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Punto
    {
        private int x;
        private int y;

        public Punto(int Punto1, int Punto2)
        {
            this.x = Punto1;
            this.y = Punto2;
        }

        public int DevolverX()
        {
            return this.x;
        }

        public int DevolverY()
        {
            return this.y;
        }
    }
}
