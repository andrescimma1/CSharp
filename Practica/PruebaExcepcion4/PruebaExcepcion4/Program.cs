using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema:
        Declarar un vector de 10 elementos enteros.
        Permitir que el usuario ingrese un subíndice
        del vector y nos muestre el contenido de dicha
        componente. Atrapar las excepciones de fuera 
        de rango del vector y si ingresa un valor no 
        entero. 
 */

namespace PruebaExcepcion4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vec = { 20, 45, 76, 81, 34, 567, 423, 6, 3, 5 };
            try
            {
                Console.Write("Ingrese un valor entre 0 y 9:");
                var indice = int.Parse(Console.ReadLine());
                Console.WriteLine($"En el vector se almacena en la posición {indice} el valor {vec[indice]}");
            }
            catch (FormatException e)
            {
                Console.Write("Debe ingresar obligatoriamente números enteros.");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.Write("El valor debe estar entre 0 y 9");
            }
            Console.ReadKey();
        }
    }
}
