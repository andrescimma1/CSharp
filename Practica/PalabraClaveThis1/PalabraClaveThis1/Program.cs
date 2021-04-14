using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Mediante la palabra clave this podemos acceder a 
    los atributos y métodos de la clase. Ejemplo:
 */

namespace PalabraClaveThis1
{
    class Persona
    {
        private string nombre;
        private int edad;

        public Persona(string nom, int ed)
        {
            this.nombre = nom;
            this.edad = ed;
            this.Imprimir();
        }

        public void Imprimir()
        {
            Console.WriteLine("Nombre:" + this.nombre);
            Console.WriteLine("Edad:" + this.edad);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Juan Carlos", 30);
        }
    }
}
