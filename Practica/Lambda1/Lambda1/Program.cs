using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema
        Definir un método estático llamado Operar.
        Llegan como parámetro dos enteros y la 
        referencia a una expresión lambda (lo debe
        recibir un delegado). En el bloque del método
        llamar a la función que llega como parámetro
        y enviar los dos primeros parámetros.

        Desde la función Main llamar a Operar y enviar
        distintas expresiones lambdas que permitan 
        sumar, restar y elevar el primer valor al segundo.
 */

namespace Lambda1
{
    delegate int Operacion(int x1, int x2);

    class Program
    {

        public static int Operar(int x1, int x2, Operacion delegado)
        {
            return delegado(x1, x2);
        }

        static void Main(string[] args)
        {
            var suma = Program.Operar(10, 3, (x, y) => { return x + y; });
            Console.WriteLine("La suma de 10 y 3 es {0}", suma);
            var resta = Program.Operar(10, 3, (x, y) => { return x - y; });
            Console.WriteLine("La resta de 10 y 3 es {0}", resta);
            var elevadoOctava = Program.Operar(2, 8, (x, y) => {
                var valor = x;
                for (int f = 1; f < y; f++)
                    valor = valor * x;
                return valor;
            });
            Console.WriteLine("2 elevado a la 8 es {0}", elevadoOctava);
            Console.ReadKey();
        }
    }
}
