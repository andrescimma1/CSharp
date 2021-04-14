using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Problema 5:
    Otro problema típico que se presenta para analizar 
    la recursividad es el obtener el factorial de un número.
    Recordar que el factorial de un número es el resultado 
    que se obtiene de multiplicar dicho número por el anterior
    y así sucesivamente hasta llegar a uno.
    Ej. el factorial de 4 es 4 * 3 * 2 * 1 es decir 24.
 */

namespace Recursividad5
{
    public class Recursividad
    {
        int Factorial(int fact)
        {
            if (fact > 0)
            {
                int valor = fact * Factorial(fact - 1);
                return valor;
            }
            else
                return 1;
        }

        static void Main(string[] args)
        {
            Recursividad re = new Recursividad();
            int f = re.Factorial(4);
            Console.WriteLine("El factorial de 4 es " + f);
            Console.ReadKey();
        }
    }
}
