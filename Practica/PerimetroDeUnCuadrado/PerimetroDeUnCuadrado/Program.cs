using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimetroDeUnCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado, perimetro;
            string linea;

            Console.Write("Ingrese el valor del lado del cuadrado: ");
            linea = Console.ReadLine();
            lado = int.Parse(linea);

            perimetro = lado * 4;

            Console.Write("El perimetro del cuadrado es: ");
            Console.WriteLine(perimetro);
            Console.ReadKey();

        }
    }
}
