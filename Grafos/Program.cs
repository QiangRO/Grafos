using System;
using System.Collections.Generic;

namespace Grafos
{
    class Program
    {
        static void Main(string[] args)
        {
            //PRIMERA CLASE GRAFOS
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

            //PRACTICA GRAFO TELEFERICO
            Teleferico telAzul1 = new Teleferico("Azul", "Rio Seco");
            Teleferico telAzul2 = new Teleferico("Azul", "UPEA");
            Teleferico telAzul3 = new Teleferico("Azul", "Plaza La Paz");
            Teleferico telAzul4 = new Teleferico("Azul", "16 de Julio");

            Teleferico telRojo1 = new Teleferico("Rojo", "16 de Julio");
            Teleferico telRojo2 = new Teleferico("Rojo","Cementerio");
            Teleferico telRojo3 = new Teleferico("Rojo","Estacion Central");

            Teleferico telNaranja1 = new Teleferico("Naranja", "Estacion Central");
            Teleferico telNaranja2 = new Teleferico("Naranja", "Armentia");
            Teleferico telNaranja3 = new Teleferico("Naranja", "Periferica");
            Teleferico telNaranja4 = new Teleferico("Naranja", "Plaza Villarroel");

            Teleferico telBlanca1 = new Teleferico("Blanco", "Plaza Villarroel");
            Teleferico telBlanca2 = new Teleferico("Blanco", "Avenida Busch");
            Teleferico telBlanca3 = new Teleferico("Blanco", "Plaza Triangular");
            Teleferico telBlanca4 = new Teleferico("Blanco", "Del Poeta");
            Teleferico telBlanca5 = new Teleferico("Blanco", "Libertador");

            Teleferico telCeleste1 = new Teleferico("Celeste", "Prado");
            Teleferico telCeleste3 = new Teleferico("Celeste", "Teatro al Aire Libre");
            Teleferico telCeleste2 = new Teleferico("Celeste", "Del Poeta");

            Teleferico telCeleste4 = new Teleferico("Celeste", "Libertador");

            Teleferico telVerde1 = new Teleferico("Verde", "Libertador");
            Teleferico telVerde2 = new Teleferico("Verde", "Alto Obrajes");
            Teleferico telVerde3 = new Teleferico("Verde", "Obrajes");
            Teleferico telVerde4 = new Teleferico("Verde", "Irpavi");

            Teleferico telAmarillo1 = new Teleferico("Amarillo", "Libertador");
            Teleferico telAmarillo2 = new Teleferico("Amarillo", "Sopocachi");
            Teleferico telAmarillo3 = new Teleferico("Amarillo", "Buenos Aires");
            Teleferico telAmarillo4 = new Teleferico("Amarillo", "Mirador");

            Teleferico telPlateado1 = new Teleferico("Plateado", "Mirador");
            Teleferico telPlateado2 = new Teleferico("Plateado", "Faro Murillo");
            Teleferico telPlateado3 = new Teleferico("Plateado", "16 de Julo");

            Teleferico telMorado1 = new Teleferico("Morado", "6 de Marzo");
            Teleferico telMorado2 = new Teleferico("Morado", "Faro Murillo");
            Teleferico telMorado3 = new Teleferico("Morado", "Obelisco");

            //Vertices azules
            VerticeTeleferico vAzulParada1 = new VerticeTeleferico(telAzul1);
            VerticeTeleferico vAzulParada2 = new VerticeTeleferico(telAzul2);
            VerticeTeleferico vAzulParada3 = new VerticeTeleferico(telAzul3);
            VerticeTeleferico vAzulParada4 = new VerticeTeleferico(telAzul4);
            //Vertices Rojos
            VerticeTeleferico vRojoParada1 = new VerticeTeleferico(telRojo1);
            VerticeTeleferico vRojoParada2 = new VerticeTeleferico(telRojo2);
            VerticeTeleferico vRojoParada3 = new VerticeTeleferico(telRojo3);
            //Vertices Naranjas
            VerticeTeleferico vNaranjaParada1 = new VerticeTeleferico(telNaranja1);
            VerticeTeleferico vNaranjaParada2 = new VerticeTeleferico(telNaranja2);
            VerticeTeleferico vNaranjaParada3 = new VerticeTeleferico(telNaranja3);
            VerticeTeleferico vNaranjaParada4 = new VerticeTeleferico(telNaranja4);
            //Vertices Blancos
            VerticeTeleferico vBlancoParada1 = new VerticeTeleferico(telBlanca1);
            VerticeTeleferico vBlancoParada2 = new VerticeTeleferico(telBlanca2);
            VerticeTeleferico vBlancoParada3 = new VerticeTeleferico(telBlanca3);
            VerticeTeleferico vBlancoParada4 = new VerticeTeleferico(telBlanca4);
            VerticeTeleferico vBlancoParada5 = new VerticeTeleferico(telBlanca5);
            //Vertices Celestes
            VerticeTeleferico vCelesteParada1 = new VerticeTeleferico(telCeleste1);
            VerticeTeleferico vCelesteParada2 = new VerticeTeleferico(telCeleste2);
            VerticeTeleferico vCelesteParada3 = new VerticeTeleferico(telCeleste3);
            VerticeTeleferico vCelesteParada4 = new VerticeTeleferico(telCeleste4);
            //Vertices Verdes
            VerticeTeleferico vVerdeParada1 = new VerticeTeleferico(telVerde1);
            VerticeTeleferico vVerdeParada2 = new VerticeTeleferico(telVerde2);
            VerticeTeleferico vVerdeParada3 = new VerticeTeleferico(telVerde3);
            VerticeTeleferico vVerdeParada4 = new VerticeTeleferico(telVerde4);
            //Vertices Amarillos
            VerticeTeleferico vAmarilloParada1 = new VerticeTeleferico(telAmarillo1);
            VerticeTeleferico vAmarilloParada2 = new VerticeTeleferico(telAmarillo2);
            VerticeTeleferico vAmarilloParada3 = new VerticeTeleferico(telAmarillo3);
            VerticeTeleferico vAmarilloParada4 = new VerticeTeleferico(telAmarillo4);
            //Vertices Plateados
            VerticeTeleferico vPlateadoParada1 = new VerticeTeleferico(telPlateado1);
            VerticeTeleferico vPlateadoParada2 = new VerticeTeleferico(telPlateado2);
            VerticeTeleferico vPlateadoParada3 = new VerticeTeleferico(telPlateado3);
            //Vertices Morados
            VerticeTeleferico vMoradoParada1 = new VerticeTeleferico(telMorado1);
            VerticeTeleferico vMoradoParada2 = new VerticeTeleferico(telMorado2);
            VerticeTeleferico vMoradoParada3 = new VerticeTeleferico(telMorado3);

            vAzulParada1.arista.Add(vAzulParada2);
            vAzulParada2.arista.Add(vAzulParada3);
            vAzulParada3.arista.Add(vAzulParada4);
            vAzulParada4.arista.Add(vRojoParada1);
            vRojoParada1.arista.Add(vRojoParada2);
            vRojoParada2.arista.Add(vRojoParada3);
            vRojoParada3.arista.Add(vNaranjaParada1);
            vNaranjaParada1.arista.Add(vNaranjaParada2);
            vNaranjaParada2.arista.Add(vNaranjaParada3);
            vNaranjaParada3.arista.Add(vNaranjaParada4);
            vNaranjaParada4.arista.Add(vBlancoParada1);
            vBlancoParada1.arista.Add(vBlancoParada2);
            vBlancoParada2.arista.Add(vBlancoParada3);
            vBlancoParada3.arista.Add(vBlancoParada4);
            Console.WriteLine("*************AZUL");
            rutaTeleferico(vAzulParada1, "  ");


            vAzulParada1.dato.verDatos();
            //SEGUNDA CLASE DE GRAFOS
            Grafo fito = new Grafo(4);
            Grafo fito2 = new Grafo(3);
            Grafo fito3 = new Grafo(2);
            Grafo fito4 = new Grafo(1);

            fito.adiVertice(new Vertice2(1));
            fito.adiVertice(new Vertice2(2));
            fito.adiVertice(new Vertice2(3));
            fito.adiVertice(new Vertice2(4));

            fito.AdiArista(0, 1);
            fito.AdiArista(0, 2);

            fito.verMatAd();
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
        static void rutaTeleferico(VerticeTeleferico v, string sp)
        {
            if (v.arista != null)
            {
                Console.WriteLine(sp + v.dato);
                foreach (var item in v.arista)
                {
                    camino((Vertice)item, sp + "\t");
                }
            }
        }
    }
}
