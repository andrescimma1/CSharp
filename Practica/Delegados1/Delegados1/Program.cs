using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema:
        Declarar un delegado que reciba dos enteros
        y retorne un entero.
        Plantear una clase Operacion y los métodos 
        que permitan sumar y restar dos enteros.
        Llamar a los métodos mediante la definición
        de un delegado. 
 */

namespace Delegados1
{
    delegate int Operar(int x1, int x2);

    class Program
    {
        public int Sumar(int x, int y)
        {
            return x + y;
        }

        public int Restar(int x, int y)
        {
            return x - y;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Suma y resta de dos valores llamando directamente a los métodos.");
            Console.WriteLine(p.Sumar(10, 5));
            Console.WriteLine(p.Restar(10, 5));
            Operar delegado = p.Sumar;
            Console.WriteLine("Suma y resta de dos valores llamando a los métodos a través de delegados");
            Console.WriteLine(delegado(10, 5));
            delegado = p.Restar;
            Console.WriteLine(delegado(10, 5));
            Console.ReadKey();
        }
    }
}
