using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    class Vertice
    {
        public int dato;
        public List<Vertice> arista { get; set; }
        public Vertice (int d)
        {
            this.dato = d;
            this.arista = new List<Vertice>();
        }
    }
    class Vertice2
    {
        public int dato;
        public Vertice2(int d)
        {
            this.dato = d;
        }
    }
}
