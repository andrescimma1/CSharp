using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema:
        Realizar la carga de 2 enteros por teclado,
        mostrar el resultado de dividir el primero 
        por el segundo. 
 */

namespace PruebaExcepcion2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingrese primer valor:");
                var num1 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese segundo valor:");
                var num2 = int.Parse(Console.ReadLine());
                var resu = num1 / num2;
                Console.WriteLine($"La división de {num1} respecto a {num2} es {resu}");
            }
            catch (FormatException e)
            {
                Console.Write("Debe ingresar obligatoriamente números enteros.");
            }
            catch (DivideByZeroException e)
            {
                Console.Write("No se puede dividir por cero");
            }
            Console.ReadKey();
        }
    }
}
