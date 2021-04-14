using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Implementar la clase operaciones. Se deben cargar dos valores 
 * enteros en el constructor, calcular su suma, resta, multiplicación
 * y división, cada una en un método, imprimir dichos resultados. */

namespace Constructor2
{
    class Operaciones
    {
        private int num1, num2;

        public Operaciones() // Constructor
        {
            string linea;

            Console.Write("Ingrese el valor del primer numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("Ingrese el valor del segundo numero: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
        }

        public void Suma()
        {
            Console.Write("La suma de los numeros es: ");
            Console.WriteLine((num1 + num2));
        }

        public void Resta()
        {
            Console.Write("La resta de los numeros es: ");
            Console.WriteLine((num1 - num2));
        }

        public void Multiplicacion()
        {
            Console.Write("La multiplicacion de los numeros es: ");
            Console.WriteLine((num1 * num2));
        }

        public void Division()
        {
            Console.Write("La division de los numeros es: ");
            Console.WriteLine((num1 / num2));
        }

        static void Main(string[] args)
        {
            Operaciones operaciones1 = new Operaciones();

            operaciones1.Suma();
            operaciones1.Resta();
            operaciones1.Multiplicacion();
            operaciones1.Division();

            Console.ReadKey();
        }
    }
}
