using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos2
{
    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }

    class Pila<T>
    {
        private T[] vec = new T[5];
        private int tope = 0;

        public void Insertar(T x)
        {
            vec[tope] = x;
            tope++;
        }

        public T Extraer()
        {
            tope--;
            return vec[tope];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pila<Persona> pila1 = new Pila<Persona>();
            Persona persona1 = new Persona { Nombre = "Juan", Edad = 22 };
            Persona persona2 = new Persona { Nombre = "Ana", Edad = 34 };
            Persona persona3 = new Persona { Nombre = "Carlos", Edad = 47 };
            pila1.Insertar(persona1);
            pila1.Insertar(persona2);
            pila1.Insertar(persona3);
            Persona p = pila1.Extraer();
            Console.WriteLine(p.Nombre + " " + p.Edad);
            Console.ReadKey();
        }
    }
}
