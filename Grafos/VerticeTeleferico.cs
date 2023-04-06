using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    class VerticeTeleferico
    {
        public Teleferico dato;
        public List<VerticeTeleferico> arista { get; set; }
        public VerticeTeleferico(Teleferico d)
        {
            this.dato = d;
            this.arista = new List<VerticeTeleferico>();
        }
    }
}
