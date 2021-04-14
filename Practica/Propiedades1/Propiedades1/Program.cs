using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema 1:
        Plantear una clase llamada Cuadrado definir
        una propiedad llamada Lado. Calcular la superficie.
 */

namespace Propiedades1
{
    class Cuadrado
    {
        public int Lado { get; set; }

        public int RetornarSuperficie()
        {
            return Lado * Lado;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cuadrado cuadrado1 = new Cuadrado();
            cuadrado1.Lado = 30;
            Console.WriteLine("Su superficie es:" + cuadrado1.RetornarSuperficie());
            Console.ReadKey();
        }
    }
}
