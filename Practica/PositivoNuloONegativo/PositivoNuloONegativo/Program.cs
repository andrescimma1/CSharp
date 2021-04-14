using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositivoNuloONegativo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string linea;

            Console.Write("Ingrese un numero: ");
            linea = Console.ReadLine();
            numero = int.Parse(linea);

            if(numero < 0)
            {
                Console.Write("El numero es negativo");
            }
            else if(numero == 0)
            {
                Console.Write("El numero es nulo (0)");
            }
            else
            {
                Console.Write("El numero es positivo");
            }

            Console.ReadKey();
        }
    }
}
