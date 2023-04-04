using System;
using System.Collections.Generic;

namespace Grafos
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES
            int numVertices = 0;

            /*Console.WriteLine("Numero de vertices:");
            numVertices = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numVertices; i++)
            {

            }*/
            Vertice v7 = new Vertice(7);
            Vertice v8 = new Vertice(8);
            Vertice v4 = new Vertice(4);
            Vertice v6 = new Vertice(6);
            Vertice v5 = new Vertice(5);

            Console.WriteLine("***** VERTICE INICIAL 8 *****");
            v8.arista.Add(v5);
            v8.arista.Add(v6);
            v7.arista.Add(v8);
            v7.arista.Add(v6);
            v7.arista.Add(v4);
            v6.arista.Add(v5);
            v4.arista.Add(v6);
            v4.arista.Add(v5);
            Console.WriteLine("Vertice 8");
            camino(v8, " ");
            Console.WriteLine("Vertice 7");
            camino(v7, " ");
            Console.WriteLine("Vertice 6");
            camino(v6, " ");
            Console.WriteLine("Vertice 4");
            camino(v4, " ");

        }
        static void camino(Vertice v, string sp)
        {
            if (v.arista != null)
            {
                Console.WriteLine(sp + v.dato);
                foreach (var item in v.arista)
                {
                    camino(item, sp+"\t");
                }
            }
        }
    }
}
