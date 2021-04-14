using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema propuesto:
        Imprimir los valores de 1 al 1000 utilizando un for
        y definiendo una variable implícita 
 */

namespace DatosImplicitos2
{
    class Program
    {
        public void Imprimir()
        {
            for(var x = 1; x <= 1000; x++)
            {
                Console.Write(x + "-");
            }
        }

        static void Main(string[] args)
        {
            Program obj = new Program();

            obj.Imprimir();

            Console.ReadKey();
        }
    }
}
