using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema:
        Realizar la carga de un número entero 
        por teclado e imprimir su cuadrado. 
 */

namespace PruebaExcepcion5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingrese un valor:");
                string linea = Console.ReadLine();
                var num = int.Parse(linea);
                var cuadrado = num * num;
                Console.WriteLine($"El cuadrado de {num} es {cuadrado}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Propiedad Message: {e.Message}\n");
                Console.WriteLine($"Propiedad StackTrade: {e.StackTrace}\n");
                Console.WriteLine($"Propiedad Source: {e.Source}\n");
                Console.WriteLine($"Propiedad TargetSize: {e.TargetSite}");
            }
            Console.ReadKey();
        }
    }
}
