using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    class Grafo
    {
        public int[,] matAd;
        List<Vertice2> Arista;
        public Grafo(int nVert)
        {
            matAd = new int[nVert, nVert];
            Arista = new List<Vertice2>();
        }
        public void adiVertice(Vertice2 v)
        {
            this.Arista.Add(v);
        }
        public void AdiArista(int fila, int col)
        {
            this.matAd[fila, col] = 1;
        }
        public void verMatAd()
        {
            for (int i = 0; i < matAd.GetLength(0); i++)
            {
                for (int j = 0; j < matAd.GetLength(1); j++)
                {
                    Console.WriteLine(matAd[i, j]);
                }
            }
        }
    }
}
