using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema:
        Plantear una clase para administrar
        una lísta de datos utilizando genéricos.
        Implemente los métodos para insertar,
        extraer, cantidad e imprimir.

        Crear luego tres objetos de la clase 
        Lista uno con enteros, otros con string 
        y finalmente otro de tipo Persona 
        (declarar una clase Persona con 
        dos propiedades: Nombre y Edad)
 */

namespace Genericos3
{
    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public override string ToString()
        {
            return "(" + Nombre + "-" + Edad + ")";
        }
    }


    class ListaGenerica<T>
    {
        class Nodo
        {
            public T Info { get; set; }
            public Nodo Sig { get; set; }
        }

        private Nodo raiz;

        public ListaGenerica()
        {
            raiz = null;
        }

        public void Insertar(int pos, T x)
        {
            if (pos <= Cantidad() + 1)
            {
                Nodo nuevo = new Nodo();
                nuevo.Info = x;
                if (pos == 1)
                {
                    nuevo.Sig = raiz;
                    raiz = nuevo;
                }
                else
                    if (pos == Cantidad() + 1)
                {
                    Nodo reco = raiz;
                    while (reco.Sig != null)
                    {
                        reco = reco.Sig;
                    }
                    reco.Sig = nuevo;
                    nuevo.Sig = null;
                }
                else
                {
                    Nodo reco = raiz;
                    for (int f = 1; f <= pos - 2; f++)
                        reco = reco.Sig;
                    Nodo siguiente = reco.Sig;
                    reco.Sig = nuevo;
                    nuevo.Sig = siguiente;
                }
            }
        }

        public T Extraer(int pos)
        {
            T informacion;
            if (pos == 1)
            {
                informacion = raiz.Info;
                raiz = raiz.Sig;
            }
            else
            {
                Nodo reco;
                reco = raiz;
                for (int f = 1; f <= pos - 2; f++)
                    reco = reco.Sig;
                Nodo prox = reco.Sig;
                reco.Sig = prox.Sig;
                informacion = prox.Info;
            }
            return informacion;
        }

        public void Imprimir()
        {
            Nodo reco = raiz;
            while (reco != null)
            {
                Console.Write(reco.Info + "-");
                reco = reco.Sig;
            }
            Console.WriteLine();
        }

        public int Cantidad()
        {
            int cant = 0;
            Nodo reco = raiz;
            while (reco != null)
            {
                reco = reco.Sig;
                cant++;
            }
            return cant;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            ListaGenerica<int> lista1 = new ListaGenerica<int>();
            lista1.Insertar(1, 10);
            lista1.Insertar(2, 50);
            lista1.Insertar(3, 70);
            lista1.Imprimir();

            ListaGenerica<string> lista2 = new ListaGenerica<string>();
            lista2.Insertar(1, "uno");
            lista2.Insertar(2, "dos");
            lista2.Insertar(3, "tres");
            lista2.Imprimir();

            ListaGenerica<Persona> lista3 = new ListaGenerica<Persona>();
            lista3.Insertar(1, new Persona { Nombre = "juan", Edad = 20 });
            lista3.Insertar(2, new Persona { Nombre = "ana", Edad = 12 });
            lista3.Insertar(3, new Persona { Nombre = "luis", Edad = 40 });
            lista3.Imprimir();

            Console.ReadKey();
        }
    }
}
