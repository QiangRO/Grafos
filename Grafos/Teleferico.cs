using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    class Teleferico
    {
        public string color = " ";
        public string parada = " ";
        public Teleferico()
        {
            this.color = "sin color";
            this.parada = "sin datos";
        }
        public Teleferico(string color, string parada)
        {
            this.color = color;
            this.parada = parada;
        }
        public void leerDatos()
        {
            Console.WriteLine("color: ");
            color = Console.ReadLine();
            Console.WriteLine("parada: ");
            parada = Console.ReadLine();
        }
        public void verDatos()
        {
            Console.WriteLine($"\nColor: {this.color}" +
                $"Parada: {this.parada}\n");
        }
    }
}
