using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compra
{
    class Program
    {
        static void Main(string[] args)
        {
            int precio, cantidad, resultado;
            string linea;

            Console.Write("Ingrese el precio del producto: ");
            linea = Console.ReadLine();
            precio = int.Parse(linea);

            Console.Write("Ingrese la cantidad: ");
            linea = Console.ReadLine();
            cantidad = int.Parse(linea);

            resultado = precio * cantidad;

            Console.Write("El precio a abonar es de: ");
            Console.WriteLine(resultado);

            Console.ReadKey();
        }
    }
}
