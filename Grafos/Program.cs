using System;
using System.Collections.Generic;

namespace Grafos
{
    class Program
    {
        static void Main(string[] args)
        {
            //AHORA TENEMOS OBJETOS TELEFERICO
            //PRIMERA CLASE GRAFOS

            /*Vertice v7 = new Vertice(7);
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
            */

            //PRACTICA GRAFO TELEFERICO
            Teleferico telAzul1 = new Teleferico("Azul", "Estacion Rio Seco");
            Teleferico telAzul2 = new Teleferico("Azul", "Estacion UPEA");
            Teleferico telAzul3 = new Teleferico("Azul", "Estacion Plaza La Paz");
            Teleferico telAzul4 = new Teleferico("Azul", "Estacion Plaza Libertad");
            Teleferico telAzul5 = new Teleferico("Azul", "Estacion 16 de Julio");

            Teleferico telRojo1 = new Teleferico("Rojo", "Estacion 16 de Julio");
            Teleferico telRojo2 = new Teleferico("Rojo", "Estacion Cementerio");
            Teleferico telRojo3 = new Teleferico("Rojo", "Estacion Central");

            Teleferico telNaranja1 = new Teleferico("Naranja", "Estacion Central");
            Teleferico telNaranja2 = new Teleferico("Naranja", "Estacion Armentia");
            Teleferico telNaranja3 = new Teleferico("Naranja", "Estacion Periferica");
            Teleferico telNaranja4 = new Teleferico("Naranja", "Estacion Plaza Villarroel");

            Teleferico telBlanca1 = new Teleferico("Blanco", "Estacion Plaza Villarroel");
            Teleferico telBlanca2 = new Teleferico("Blanco", "Estacion Monumento Busch");
            Teleferico telBlanca3 = new Teleferico("Blanco", "Estacion Plaza Triangular");
            Teleferico telBlanca4 = new Teleferico("Blanco", "Estacion Avenida Poeta");

            Teleferico telCafe1 = new Teleferico("Cafe", "Estacion Monumento Busch");
            Teleferico telCafe2 = new Teleferico("Cafe", "Estacion Villa Copacabana/San Antonio");

            Teleferico telCeleste1 = new Teleferico("Celeste", "Estacion Prado");
            Teleferico telCeleste3 = new Teleferico("Celeste", "Estacion Teatro al Aire Libre");
            Teleferico telCeleste2 = new Teleferico("Celeste", "Estacion Del Poeta");
            Teleferico telCeleste4 = new Teleferico("Celeste", "Estacion Libertador");

            Teleferico telVerde1 = new Teleferico("Verde", "Estacion Libertador");
            Teleferico telVerde2 = new Teleferico("Verde", "Estacion Alto Obrajes");
            Teleferico telVerde3 = new Teleferico("Verde", "Estacion Obrajes");
            Teleferico telVerde4 = new Teleferico("Verde", "Estacion Irpavi");

            Teleferico telAmarillo1 = new Teleferico("Amarillo", "Estacion Mirador");
            Teleferico telAmarillo2 = new Teleferico("Amarillo", "Estacion Buenos Aires");
            Teleferico telAmarillo3 = new Teleferico("Amarillo", "Estacion Sopocachi");
            Teleferico telAmarillo4 = new Teleferico("Amarillo", "Estacion Libertador");

            Teleferico telPlateado1 = new Teleferico("Plateado", "Estacion 16 de Julio");
            Teleferico telPlateado2 = new Teleferico("Plateado", "Estacion Faro Murillo");
            Teleferico telPlateado3 = new Teleferico("Plateado", "Estacion Mirador");

            Teleferico telMorado1 = new Teleferico("Morado", "Estacion 6 de Marzo");
            Teleferico telMorado2 = new Teleferico("Morado", "Estacion Faro Murillo");
            Teleferico telMorado3 = new Teleferico("Morado", "Estacion San Jose");

            //Vertices azules
            VerticeTeleferico vAzulEstacion1 = new VerticeTeleferico(telAzul1);
            VerticeTeleferico vAzulEstacion2 = new VerticeTeleferico(telAzul2);
            VerticeTeleferico vAzulEstacion3 = new VerticeTeleferico(telAzul3);
            VerticeTeleferico vAzulEstacion4 = new VerticeTeleferico(telAzul4);
            vAzulEstacion1.arista.Add(vAzulEstacion2);
            vAzulEstacion2.arista.Add(vAzulEstacion3);
            vAzulEstacion3.arista.Add(vAzulEstacion4);

            
            //Vertices Rojos
            VerticeTeleferico vRojoEstacion1 = new VerticeTeleferico(telRojo1);
            VerticeTeleferico vRojoEstacion2 = new VerticeTeleferico(telRojo2);
            VerticeTeleferico vRojoEstacion3 = new VerticeTeleferico(telRojo3);
            vAzulEstacion4.arista.Add(vRojoEstacion1);
            vRojoEstacion1.arista.Add(vRojoEstacion2);
            vRojoEstacion2.arista.Add(vRojoEstacion3);

            //Vertices Naranjas
            VerticeTeleferico vNaranjaEstacion1 = new VerticeTeleferico(telNaranja1);
            VerticeTeleferico vNaranjaEstacion2 = new VerticeTeleferico(telNaranja2);
            VerticeTeleferico vNaranjaEstacion3 = new VerticeTeleferico(telNaranja3);
            VerticeTeleferico vNaranjaEstacion4 = new VerticeTeleferico(telNaranja4);
            vRojoEstacion3.arista.Add(vNaranjaEstacion1);
            vNaranjaEstacion1.arista.Add(vNaranjaEstacion2);
            vNaranjaEstacion2.arista.Add(vNaranjaEstacion3);
            vNaranjaEstacion3.arista.Add(vNaranjaEstacion4);

            //Vertices Blancos
            VerticeTeleferico vBlancoEstacion1 = new VerticeTeleferico(telBlanca1);
            VerticeTeleferico vBlancoEstacion2 = new VerticeTeleferico(telBlanca2);
            VerticeTeleferico vBlancoEstacion3 = new VerticeTeleferico(telBlanca3);
            VerticeTeleferico vBlancoEstacion4 = new VerticeTeleferico(telBlanca4);
            vNaranjaEstacion4.arista.Add(vBlancoEstacion1);
            vBlancoEstacion1.arista.Add(vBlancoEstacion2);
            vBlancoEstacion2.arista.Add(vBlancoEstacion3);
            vBlancoEstacion3.arista.Add(vBlancoEstacion4);
            //Vertices Cafe
            VerticeTeleferico vCafeEstacion1 = new VerticeTeleferico(telCafe1);
            VerticeTeleferico vCafeEstacion2 = new VerticeTeleferico(telCafe2);
            vBlancoEstacion2.arista.Add(vCafeEstacion1);
            vCafeEstacion1.arista.Add(vCafeEstacion2);

            //Vertices Celestes
            VerticeTeleferico vCelesteEstacion1 = new VerticeTeleferico(telCeleste1);
            VerticeTeleferico vCelesteEstacion2 = new VerticeTeleferico(telCeleste2);
            VerticeTeleferico vCelesteEstacion3 = new VerticeTeleferico(telCeleste3);
            VerticeTeleferico vCelesteEstacion4 = new VerticeTeleferico(telCeleste4);
            vCelesteEstacion1.arista.Add(vCelesteEstacion2);
            vCelesteEstacion2.arista.Add(vCelesteEstacion3);
            vCelesteEstacion3.arista.Add(vCelesteEstacion4);
            vCelesteEstacion3.arista.Add(vBlancoEstacion4);
            vBlancoEstacion4.arista.Add(vCelesteEstacion3);

            //Vertices Verdes
            VerticeTeleferico vVerdeEstacion1 = new VerticeTeleferico(telVerde1);
            VerticeTeleferico vVerdeEstacion2 = new VerticeTeleferico(telVerde2);
            VerticeTeleferico vVerdeEstacion3 = new VerticeTeleferico(telVerde3);
            VerticeTeleferico vVerdeEstacion4 = new VerticeTeleferico(telVerde4);
            vVerdeEstacion1.arista.Add(vVerdeEstacion2);
            vVerdeEstacion2.arista.Add(vVerdeEstacion3);
            vVerdeEstacion3.arista.Add(vVerdeEstacion4);
            vVerdeEstacion1.arista.Add(vCelesteEstacion4);
            vCelesteEstacion4.arista.Add(vVerdeEstacion1);

            //Vertices Amarillos
            VerticeTeleferico vAmarilloEstacion1 = new VerticeTeleferico(telAmarillo1);
            VerticeTeleferico vAmarilloEstacion2 = new VerticeTeleferico(telAmarillo2);
            VerticeTeleferico vAmarilloEstacion3 = new VerticeTeleferico(telAmarillo3);
            VerticeTeleferico vAmarilloEstacion4 = new VerticeTeleferico(telAmarillo4);
            vAmarilloEstacion1.arista.Add(vAmarilloEstacion2);
            vAmarilloEstacion2.arista.Add(vAmarilloEstacion3);
            vAmarilloEstacion3.arista.Add(vAmarilloEstacion4);
            vAmarilloEstacion4.arista.Add(vVerdeEstacion1);
            vAmarilloEstacion4.arista.Add(vCelesteEstacion4);
            vCelesteEstacion4.arista.Add(vAmarilloEstacion4);

            //Vertices Plateados
            VerticeTeleferico vPlateadoEstacion1 = new VerticeTeleferico(telPlateado1);
            VerticeTeleferico vPlateadoEstacion2 = new VerticeTeleferico(telPlateado2);
            VerticeTeleferico vPlateadoEstacion3 = new VerticeTeleferico(telPlateado3);
            vPlateadoEstacion1.arista.Add(vPlateadoEstacion2);
            vPlateadoEstacion2.arista.Add(vPlateadoEstacion3);
            vPlateadoEstacion3.arista.Add(vAmarilloEstacion1);
            vPlateadoEstacion1.arista.Add(vRojoEstacion1);
            vPlateadoEstacion1.arista.Add(vAzulEstacion4);
            vAzulEstacion4.arista.Add(vPlateadoEstacion1);
            vRojoEstacion1.arista.Add(vPlateadoEstacion1);
            vRojoEstacion1.arista.Add(vAzulEstacion4);

            //Vertices Morados
            VerticeTeleferico vMoradoEstacion1 = new VerticeTeleferico(telMorado1);
            VerticeTeleferico vMoradoEstacion2 = new VerticeTeleferico(telMorado2);
            VerticeTeleferico vMoradoEstacion3 = new VerticeTeleferico(telMorado3);
            vMoradoEstacion1.arista.Add(vMoradoEstacion2);
            vMoradoEstacion2.arista.Add(vMoradoEstacion3);
            vMoradoEstacion2.arista.Add(vPlateadoEstacion2);
            vPlateadoEstacion2.arista.Add(vMoradoEstacion2);


            rutaTeleferico(vAzulEstacion1, " ");

            Console.WriteLine("Ruta Estacion Azul");
            rutaTeleferico(vAzulEstacion1, " ");
            rutaTeleferico(vAzulEstacion2, " ");
            rutaTeleferico(vAzulEstacion3, " ");
            rutaTeleferico(vAzulEstacion4, " ");

            Console.WriteLine("Ruta Estacion Rojo");
            rutaTeleferico(vRojoEstacion1, " ");
            rutaTeleferico(vRojoEstacion2, " ");
            rutaTeleferico(vRojoEstacion3, " ");

            Console.WriteLine("Ruta Estacion Naranja");
            rutaTeleferico(vNaranjaEstacion1, " ");
            rutaTeleferico(vNaranjaEstacion2, " ");
            rutaTeleferico(vNaranjaEstacion3, " ");
            rutaTeleferico(vNaranjaEstacion4, " ");

            Console.WriteLine("Ruta Estacion Blanco");
            rutaTeleferico(vBlancoEstacion1, " ");
            rutaTeleferico(vBlancoEstacion2, " ");
            rutaTeleferico(vBlancoEstacion3, " ");
            rutaTeleferico(vBlancoEstacion4, " ");

            Console.WriteLine("Ruta Estacion Cafe");
            rutaTeleferico(vCafeEstacion1, " ");
            rutaTeleferico(vCafeEstacion2, " ");

            Console.WriteLine("Ruta Estacion Celeste");
            rutaTeleferico(vCelesteEstacion1, " ");
            rutaTeleferico(vCelesteEstacion2, " ");
            rutaTeleferico(vCelesteEstacion3, " ");
            rutaTeleferico(vCelesteEstacion4, " ");

            Console.WriteLine("Ruta Estacion Verde");
            rutaTeleferico(vVerdeEstacion1, " ");
            rutaTeleferico(vVerdeEstacion2, " ");
            rutaTeleferico(vVerdeEstacion3, " ");
            rutaTeleferico(vVerdeEstacion4, " ");

            Console.WriteLine("Ruta Estacion Amarillo");
            rutaTeleferico(vAmarilloEstacion1, " ");
            rutaTeleferico(vAmarilloEstacion2, " ");
            rutaTeleferico(vAmarilloEstacion3, " ");
            rutaTeleferico(vAmarilloEstacion4, " ");

            Console.WriteLine("Ruta Estacion Plateado");
            rutaTeleferico(vPlateadoEstacion1, " ");
            rutaTeleferico(vPlateadoEstacion2, " ");
            rutaTeleferico(vPlateadoEstacion3, " ");

            Console.WriteLine("Ruta Estacion Morado");
            rutaTeleferico(vMoradoEstacion1, " ");
            rutaTeleferico(vMoradoEstacion2, " ");
            rutaTeleferico(vMoradoEstacion3, " ");



            //SEGUNDA CLASE DE GRAFOS
            /*Grafo fito = new Grafo(4);
            Grafo fito2 = new Grafo(3);
            Grafo fito3 = new Grafo(2);
            Grafo fito4 = new Grafo(1);

            fito.adiVertice(new Vertice2(1));
            fito.adiVertice(new Vertice2(2));
            fito.adiVertice(new Vertice2(3));
            fito.adiVertice(new Vertice2(4));

            fito.AdiArista(0, 1);
            fito.AdiArista(0, 2);

            fito.verMatAd();*/
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
                    rutaTeleferico(item, sp + "\t");
                }
            }
        }
    }
}
