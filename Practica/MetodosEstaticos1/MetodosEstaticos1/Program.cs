using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema 1:
        Implementar una clase llamada Operacion.
        Definir dos métodos estáticos que permitan
        sumar y restar dos valores enteros. 
 */

namespace MetodosEstaticos1
{
    class Operacion
    {
        public static int Sumar(int x1, int x2)
        {
            int r = x1 + x2;

            return r;
        }

        public static int Restar(int x1, int x2)
        {
            int r = x1 - x2;

            return r;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("La suma de 2 + 4 es: ");
            Console.WriteLine(Operacion.Sumar(2, 4));

            Console.Write("La resta de 9 - 1 es: ");
            Console.WriteLine(Operacion.Restar(9, 1));

            Console.ReadKey();
        }
    }
}
