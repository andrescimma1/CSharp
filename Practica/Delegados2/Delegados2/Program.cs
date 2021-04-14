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
        Un tercer método que reciba un delegado y 
        dos enteros.
 */

namespace Delegados2
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

        public void operacion(Operar d, int x, int y)
        {
            Console.WriteLine(d(10, 5));
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Suma y resta de 10 y 5.");
            p.operacion(p.Sumar, 10, 5);
            p.operacion(p.Restar, 10, 5);
            Console.ReadKey();
        }
    }
}
