using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Confeccionar una clase que represente un empleado. Definir como 
 * atributos su nombre y su sueldo. En el constructor cargar los atributos
 * y luego en otro método imprimir sus datos y por último uno que imprima un 
 * mensaje si debe pagar impuestos (si el sueldo supera a 3000) */

namespace Constructor1
{
    class Empleado
    {
        private string nombre;
        private float sueldo;
        public Empleado()  // Constructor
        {
            string linea;

            Console.Write("Ingrese el nombre del empleado: ");
            linea = Console.ReadLine();
            nombre = linea;

            Console.Write("Ingrese el sueldo: ");
            linea = Console.ReadLine();
            sueldo = float.Parse(linea);
        }

        public void Imprimir()
        {
            Console.Write("El nombre del empleado es: " + nombre);
            Console.Write(" y su sueldo es: " + sueldo);
        }

        public void Impuestos()
        {
            Console.WriteLine();

            if(sueldo > 3000)
            {
                Console.Write("Debe pagar impuestos.");
            }
            else
            {
                Console.Write("No debe pagar impuestos.");
            }
        }

        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado();

            empleado1.Imprimir();
            empleado1.Impuestos();

            Console.ReadKey();
        }
    }
}
