using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema 1:
        Implementar un método que se le envíen dos 
        variables y nos devuelvan sus contenidos intercambiados. 
 */

namespace ParametrosReferencia1
{
    class Program
    {
        public void Intercambiar(ref int valor1, ref int valor2)
        {
            int aux = valor1;
            valor1 = valor2;
            valor2 = aux;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            int x1 = 10;
            int x2 = 20;
            Console.WriteLine("Los valores antes de intercambiar son " + x1 + " " + x2);
            p.Intercambiar(ref x1, ref x2);
            Console.WriteLine("Los valores después de intercambiar son " + x1 + " " + x2);
            Console.ReadKey();
        }
    }
}
