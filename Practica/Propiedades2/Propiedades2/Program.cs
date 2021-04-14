using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Problema 1:
        Plantear una clase llamada Triangulo.
        Por defecto el valor de cada lado del 
        triángulo es 5. Calcular el perímetro.
 */

namespace Propiedades2
{
    class Triangulo
    {
        public int Lado1 { get; set; } = 5;
        public int Lado2 { get; set; } = 5;
        public int Lado3 { get; set; } = 5;

        public Triangulo(string titulo)
        {
            Console.WriteLine(titulo);
            Lado1 = 1;
            Lado2 = 1;
            Lado3 = 1;
        }

        public int RetornarPerimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo1 = new Triangulo("Perimetro triangulo 1") { Lado1 = 10, Lado2 = 20, Lado3 = 30 };
            Console.WriteLine(triangulo1.RetornarPerimetro());
            Triangulo triangulo2 = new Triangulo("Perimetro triangulo 2") { Lado3 = 30 };
            Console.WriteLine(triangulo2.RetornarPerimetro());
            Console.ReadKey();
        }
    }
}
